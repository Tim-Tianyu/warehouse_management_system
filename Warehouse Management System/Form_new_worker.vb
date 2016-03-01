Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form_new_worker
    Dim check_name As Boolean = False
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)

    'enable form_worker when this form closed
    Private Sub Form_new_worker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_worker.Enabled = True
    End Sub

    '****************************************************************************************************
    'this subroutine will check the name entered by user when text in TB_name changed, it will check the length of string is below 4 or not, if yes it will check evert character in the the string is numeric or not, there should be no numeric character in the string
    '****************************************************************************************************
    Private Sub TB_name_TextChanged(sender As Object, e As EventArgs) Handles TB_name.TextChanged 'check name
        Dim flag As Boolean
        Try
            Dim a As String = TB_name.Text
            LB_hint_name.Text = ""
            flag = True
            If a.Length > 4 Then 'longest normal chinese name i know is only 4 characters
                LB_hint_name.Text = "too long, should be 4 or less"
                flag = False
            ElseIf a.Length < 2 Then
                LB_hint_name.Text = "too short, 2 or more"
                flag = False
            Else
                Dim i As Integer
                For i = 0 To TB_name.Text.Length - 1
                    If IsNumeric(TB_name.Text(i)) Then
                        flag = False
                    End If
                Next
                If Not flag Then
                    LB_hint_name.Text = "can not contain numerical value"
                End If
            End If
        Catch ex As Exception 'this exception may not be triggered any way
            LB_hint_name.Text = "please enter proper name"
            flag = False
        End Try
        check_name = flag
    End Sub

    '****************************************************************************************************
    'this subroutine will write card for the new worker using write()
    '****************************************************************************************************
    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        Me.Enabled = False
        If check_name Then
            If write() Then
                MsgBox("success")
                Me.Close()
            Else
                MsgBox("fail")
            End If
        End If
        Me.Enabled = True
    End Sub

    '****************************************************************************************************
    'this function will write card for the new worker at first it will read the card, if the card can be read, the card number will be generate by rnd() random number, than it will write the number into the card using MF_write(), than it will try to insert a new worker into warehouse_worker, because the worker_id is tiny int so it may catch an exception because of that
    '****************************************************************************************************
    Private Function write() As Boolean

        Dim asnr(20) As Byte
        Dim aBuffer(256) As Byte 'i do not know if 256 is really needed
        Dim a(20) As Byte
        Dim b(256) As Byte

        Dim ret As Integer
        ret = MF_Getsnr(0, 0, a(0), b(0)) 'the function in .dll used to read card
        If ret = 0 Then 'if a card be readed
            Randomize() 'initialize rnd()
            Dim C0 As Byte = Int(Rnd() * 255) 'random number between 0 and 255
            Dim C1 As Byte = Int(Rnd() * 255)
            Dim C2 As Byte = Int(Rnd() * 255)
            Dim C3 As Byte = Int(Rnd() * 255)
            Dim Cver As Byte = Int(Rnd() * 255) 'actually there is a risk of 2 or more workers have same card number because i use random number, but the chance is too small as the worker number can not be more than 256
            Dim sqlcmd As New SqlCommand("INSERT INTO warehouse_worker (Wname,Wstate,Wcard_0,Wcard_1,Wcard_2,Wcard_3,Wcard_ver) VALUES (@name,@state,@c0,@c1,@c2,@c3,@cver)", cs)
            With sqlcmd.Parameters
                .Add("name", SqlDbType.NChar).Value = TB_name.Text
                .Add("state", SqlDbType.Bit).Value = True
                .Add("c0", SqlDbType.TinyInt).Value = C0
                .Add("c1", SqlDbType.TinyInt).Value = C1
                .Add("c2", SqlDbType.TinyInt).Value = C2
                .Add("c3", SqlDbType.TinyInt).Value = C3
                .Add("cver", SqlDbType.TinyInt).Value = Cver 'add random number into the database
            End With
            ret = ControlBuzzer(4, 1, aBuffer(0))   'T5577 Unprotected (this is a signal send to the card reader
            asnr(0) = 0
            asnr(1) = Cver
            asnr(2) = C0
            asnr(3) = C1
            asnr(4) = C2
            asnr(5) = C3 'put the random number in correct order

            ret = MF_Write(0, 1, 1, asnr(0), aBuffer(0)) 'write the number in
            'ret = ControlBuzzer(1, 1, aBuffer(0)) 'to make sound
            Try
                cs.Open()
                sqlcmd.ExecuteNonQuery()
                cs.Close()
                Return True
            Catch ex As Exception 'the worker number may become higher than 256 because the current number is around 100
                MsgBox("no more worker can be added")
                MsgBox(ex.ToString) 'make sure there is no other causes of exception
                Return False
            End Try
        Else
            Return False 'if no card be readed
        End If
    End Function
End Class