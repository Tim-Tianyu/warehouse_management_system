Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form_new_worker
    Dim check_name As Boolean = False
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Private Sub Form_new_worker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_worker.Enabled = True
    End Sub

    Private Sub TB_name_TextChanged(sender As Object, e As EventArgs) Handles TB_name.TextChanged
        Dim flag As Boolean
        Try
            Dim a As String = TB_name.Text
            LB_hint_name.Text = ""
            flag = True
            If a.Length > 4 Then
                LB_hint_name.Text = "too long, should be 4 or less"
                flag = False
            End If
        Catch ex As Exception
            LB_hint_name.Text = "please enter proper name"
            flag = False
        End Try
        check_name = flag
    End Sub

    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        Me.Enabled = False
        If check_name Then
            If write() Then
                MsgBox("success")
                Me.Close()
            Else
                MsgBox("fail")
            End If
        Else
            LB_hint_name.Text = "please enter the name"
        End If
        Me.Enabled = True
    End Sub

    Private Function write() As Boolean

        Dim asnr(20) As Byte
        Dim aBuffer(256) As Byte
        Dim a(20) As Byte
        Dim b(256) As Byte

        Dim ret As Integer
        ret = MF_Getsnr(0, 0, a(0), b(0))
        If ret = 0 Then
            Randomize()
            Dim C0 As Byte = Int(Rnd() * 255)
            Dim C1 As Byte = Int(Rnd() * 255)
            Dim C2 As Byte = Int(Rnd() * 255)
            Dim C3 As Byte = Int(Rnd() * 255)
            Dim Cver As Byte = Int(Rnd() * 255)
            Dim sqlcmd As New SqlCommand("INSERT INTO warehouse_worker (Wname,Wstate,Wcard_0,Wcard_1,Wcard_2,Wcard_3,Wcard_ver) VALUES (@name,@state,@c0,@c1,@c2,@c3,@cver)", cs)
            With sqlcmd.Parameters
                .Add("name", SqlDbType.NChar).Value = TB_name.Text
                .Add("state", SqlDbType.Bit).Value = True
                .Add("c0", SqlDbType.TinyInt).Value = C0
                .Add("c1", SqlDbType.TinyInt).Value = C1
                .Add("c2", SqlDbType.TinyInt).Value = C2
                .Add("c3", SqlDbType.TinyInt).Value = C3
                .Add("cver", SqlDbType.TinyInt).Value = Cver
            End With
            ret = ControlBuzzer(4, 1, aBuffer(0))   'T5577 Unprotected
            asnr(0) = 0
            asnr(1) = Cver
            asnr(2) = C0
            asnr(3) = C1
            asnr(4) = C2
            asnr(5) = C3

            ret = MF_Write(0, 1, 1, asnr(0), aBuffer(0))
            'ret = ControlBuzzer(1, 1, aBuffer(0))
            cs.Open()
            sqlcmd.ExecuteNonQuery()
            cs.Close()
            Return True
        Else
            Return False
        End If
    End Function
End Class