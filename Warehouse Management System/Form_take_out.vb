Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form_take_out
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim check_state_amount As Boolean = False
    Dim ID As Integer
    Private Sub BT_search_worker_Click(sender As Object, e As EventArgs) Handles BT_search_worker.Click
        Form_search.LB_state.Text = "worker"
        Form_search.Find_TB("TO worker")
        Form_search.TB_search.Text = TB_worker.Text
        Form_search.Show()
        Me.Enabled = False
    End Sub

    Private Sub BT_search_material_Click(sender As Object, e As EventArgs) Handles BT_search_material.Click
        Form_search.LB_state.Text = "material"
        Form_search.Find_TB("TO material")
        Form_search.TB_search.Text = TB_material.Text
        Form_search.Show()
        Me.Enabled = False
    End Sub

    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        Dim material_id As Integer = Check_material(TB_material.Text)
        Dim worker_id As Integer = Check_worker(TB_worker.Text)
        ID = worker_id
        Select Case material_id
            Case Is = 77777
                LB_hint_material.Text = "no such ID"
                material_id = 0
            Case Is = 88888
                LB_hint_material.Text = "no such name"
                material_id = 0
            Case Is = 99999
                LB_hint_material.Text = "two or more have this name, must enter ID"
                material_id = 0
        End Select
        Select Case worker_id
            Case Is = 77777
                LB_hint_worker.Text = "no such ID"
                worker_id = 0
            Case Is = 88888
                LB_hint_worker.Text = "no such name"
                worker_id = 0
            Case Is = 99999
                LB_hint_worker.Text = "two or more have this name, must enter ID"
                worker_id = 0
        End Select
        If check_state_amount And worker_id <> 0 And material_id <> 0 Then
            Dim amount As Integer = Int(TB_amount.Text)
            Dim sql_stock As New SqlCommand("SELECT Mstock FROM warehouse_material WHERE Material_ID = @ID", cs)
            sql_stock.Parameters.Add("@ID", SqlDbType.SmallInt).Value = material_id
            Dim sqladp_stock As New SqlDataAdapter(sql_stock)
            Dim tbl As New DataTable
            sqladp_stock.Fill(tbl)
            Dim stock As Integer = tbl.Rows(0).Item(0)
            tbl.Clear()
            Dim sql_state As New SqlCommand("SELECT Wstate FROM warehouse_worker WHERE Worker_ID = @ID", cs)
            sql_state.Parameters.Add("@ID", SqlDbType.TinyInt).Value = worker_id
            Dim sqladp_state As New SqlDataAdapter(sql_state)
            sqladp_state.Fill(tbl)
            Dim state As Boolean = tbl.Rows(0).Item(1)
            If Not state Then
                LB_hint_worker.Text = "this worker can not take out material"
                TB_worker.Focus()
            End If
            If stock < amount Then
                LB_hint_amount.Text = "bigger than stock"
                TB_amount.Focus()
            ElseIf state Then
                If scan() Then
                    Dim sql_update As New SqlCommand("UPDATE warehouse_material SET Mstock = MStock-@num WHERE Material_ID = @ID", cs)
                    sql_update.Parameters.Add("@num", SqlDbType.SmallInt).Value = amount
                    sql_update.Parameters.Add("@ID", SqlDbType.SmallInt).Value = material_id
                    Dim sql_insert As New SqlCommand("INSERT INTO warehouse_out_record (Material_ID_FK,Worker_ID_FK,Onum_take,Onum_left,Odatetime) VALUES (@Mid,@Wid,@numt,@numl,@datetime)", cs)
                    sql_insert.Parameters.Add("@Mid", SqlDbType.SmallInt).Value = material_id
                    sql_insert.Parameters.Add("@Wid", SqlDbType.TinyInt).Value = worker_id
                    sql_insert.Parameters.Add("@numt", SqlDbType.SmallInt).Value = amount
                    sql_insert.Parameters.Add("@numl", SqlDbType.SmallInt).Value = stock - amount
                    sql_insert.Parameters.Add("@datetime", SqlDbType.DateTime).Value = System.DateTime.Now
                    cs.Open()
                    sql_insert.ExecuteNonQuery()
                    sql_update.ExecuteNonQuery()
                    cs.Close()
                    MsgBox("success")
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub TB_amount_TextChanged(sender As Object, e As EventArgs) Handles TB_amount.TextChanged
        Try
            Dim a As Integer = Int(TB_amount.Text)
            LB_hint_amount.Text = ""
            check_state_amount = True
            If a > 32767 Then
                LB_hint_amount.Text = "bigger than stock"
                check_state_amount = False
            ElseIf a < 0 Then
                LB_hint_amount.Text = "only positive value"
                check_state_amount = False
            End If
        Catch ex As Exception
            LB_hint_amount.Text = "you should enter proper number"
            check_state_amount = False
        End Try
    End Sub

    Private Function scan() As Boolean
        Dim sqlcmd As New SqlCommand("SELECT Wcard_0, Wcard_1, Wcard_2, Wcard_3, Wcard_ver FROM warehouse_worker WHERE Worker_ID=@ID", cs)
        sqlcmd.Parameters.Add("ID", SqlDbType.TinyInt).Value = ID
        Dim sqladp As New SqlDataAdapter(sqlcmd)
        Dim table As New DataTable
        sqladp.Fill(table)
        Dim C0 As Byte = table.Rows(0).Item(0)
        Dim C1 As Byte = table.Rows(0).Item(1)
        Dim C2 As Byte = table.Rows(0).Item(2)
        Dim C3 As Byte = table.Rows(0).Item(3)
        Dim Cver As Byte = table.Rows(0).Item(4)

        Dim ret As Integer

        Dim asnr(20) As Byte
        Dim aBuffer(256) As Byte

        ret = MF_Getsnr(0, 0, asnr(0), aBuffer(0))

        If ret = 0 Then
            If C0 = aBuffer(0) And C1 = aBuffer(1) And C2 = aBuffer(2) And C3 = aBuffer(3) And Cver = asnr(0) Then
                'ret = ControlBuzzer(1, 1, aBuffer(0))
                Return True
            Else
                MsgBox("wrong card")
                Return False
            End If
        Else
            MsgBox("fail to scan")
            Return False
        End If
    End Function

    Private Sub Form_take_out_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main_Form.Enabled = True
    End Sub
End Class