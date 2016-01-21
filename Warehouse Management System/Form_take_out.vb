Imports System.Configuration
Imports System.Data.SqlClient
'****************************************************************************************************
'this from will take record when worker want to take out material
'****************************************************************************************************
Public Class Form_take_out
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim check_state_amount As Boolean = False
    Dim ID As Integer

    '****************************************************************************************************
    'when user click BT_search_worker button, means they want to find a worker
    'this subroutine will open form_search and send information to form_search and tell form_search it need to search worker or material and tell it the resualt show return to which textbox on which form
    '****************************************************************************************************
    Private Sub BT_search_worker_Click(sender As Object, e As EventArgs) Handles BT_search_worker.Click
        Form_search.LB_state.Text = "worker" 'tell form_search we need to search worker
        Form_search.Find_TB("TO worker") 'tell form_search that this bottum use it
        Form_search.TB_search.Text = TB_worker.Text 'put the text in the text box into form_search
        Form_search.Show()
        Me.Enabled = False
    End Sub

    '****************************************************************************************************
    'when user click BT_search_material button, means they want to find a material
    'this subroutine will open form_search and send information to form_search and tell form_search it need to search worker or material and tell it the resualt show return to which textbox on which form
    '****************************************************************************************************
    Private Sub BT_search_material_Click(sender As Object, e As EventArgs) Handles BT_search_material.Click
        Form_search.LB_state.Text = "material" 'tell form_search we need to search material
        Form_search.Find_TB("TO material") 'tell form_search that this bottum use it
        Form_search.TB_search.Text = TB_material.Text 'put the text in the text box into form_search
        Form_search.Show()
        Me.Enabled = False
    End Sub

    '****************************************************************************************************
    'when user click BT_confirm
    'this subroutine will check the worker id/name and material id/name use Check_material() and Check_worker(), if can not find id/name in the table, it will give user hint from the return value of Check_worker and Check_material, if the name/id is valid than it will check the state of worker and the current stock of the material, if the state is false or the number take out is bigger than stock, it will tell user, at last if all the information entered is valid, it will read the card of worker using scan() and if scan() return true(card is valid) it will insert a new record to warehouse_out_record and update the stock of that material in warehouse_material
    '****************************************************************************************************
    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        Dim material_id As Integer = Check_material(TB_material.Text) 'check material name/id return id
        Dim worker_id As Integer = Check_worker(TB_worker.Text) 'check worker name/id return id
        ID = worker_id '77777 means no such id(if enter numbers), 88888 means no such name(if entered any non-numerical char), 99999 means user must enter id
        Select Case material_id 'give user hint from the return value
            Case Is = 77777
                LB_hint_material.Text = "no such ID"
                material_id = 0
            Case Is = 88888
                LB_hint_material.Text = "no such name"
                material_id = 0
            Case Is = 99999
                LB_hint_material.Text = "two or more have this name, must enter ID"
                material_id = 0 'change id to zero, means fasle
        End Select
        Select Case worker_id 'same as upwards
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
        If check_state_amount And worker_id <> 0 And material_id <> 0 Then 'only if primary check of amount, worker/material name/id is vaild
            Dim amount As Integer = Int(TB_amount.Text) 'this line will not goes wrong because primary check have passed
            Dim sql_stock As New SqlCommand("SELECT Mstock FROM warehouse_material WHERE Material_ID = @ID", cs) 'get the current stock
            sql_stock.Parameters.Add("@ID", SqlDbType.SmallInt).Value = material_id 'add parameter id
            Dim sqladp_stock As New SqlDataAdapter(sql_stock) 'put command into adptor
            Dim tbl As New DataTable 'table
            sqladp_stock.Fill(tbl) 'fill table
            Dim stock As Integer = tbl.Rows(0).Item(0) 'get the stock
            tbl.Clear() 'clear a table
            Dim sql_state As New SqlCommand("SELECT Wstate FROM warehouse_worker WHERE Worker_ID = @ID", cs) 'get the state of worker
            sql_state.Parameters.Add("@ID", SqlDbType.TinyInt).Value = worker_id'add parameters
            Dim sqladp_state As New SqlDataAdapter(sql_state)
            sqladp_state.Fill(tbl)
            Dim state As Boolean = tbl.Rows(0).Item(1) 'actually I used Rows(0).Item(0) at first, but the value is null, I don't know why, maybe dim a new table is saver
            If Not state Then 'at first i put this part in else in the if sentence below, but i found if stock<amount, user won't konw if the worker state is true or not at the first time, both the check of state and the check of amount need to be run at the first time
                LB_hint_worker.Text = "this worker can not take out material"
                TB_worker.Focus()
            End If
            If stock < amount Then 'easy to understand
                LB_hint_amount.Text = "still bigger than stock"
                TB_amount.Focus()
            ElseIf state Then 'this part will run only if state is true and stock>amount
                If scan() Then 'will return true if card number is same as it in database
                    Dim sql_update As New SqlCommand("UPDATE warehouse_material SET Mstock = MStock-@num WHERE Material_ID = @ID", cs) 'update the stock in material table
                    sql_update.Parameters.Add("@num", SqlDbType.SmallInt).Value = amount
                    sql_update.Parameters.Add("@ID", SqlDbType.SmallInt).Value = material_id 'add parameters
                    Dim sql_insert As New SqlCommand("INSERT INTO warehouse_out_record (Material_ID_FK,Worker_ID_FK,Onum_take,Onum_left,Odatetime) VALUES (@Mid,@Wid,@numt,@numl,@datetime)", cs) 'insert a new record in out record table
                    sql_insert.Parameters.Add("@Mid", SqlDbType.SmallInt).Value = material_id
                    sql_insert.Parameters.Add("@Wid", SqlDbType.TinyInt).Value = worker_id
                    sql_insert.Parameters.Add("@numt", SqlDbType.SmallInt).Value = amount 'numtake
                    sql_insert.Parameters.Add("@numl", SqlDbType.SmallInt).Value = stock - amount 'numleft
                    sql_insert.Parameters.Add("@datetime", SqlDbType.DateTime).Value = System.DateTime.Now
                    cs.Open() 'execute the commands
                    sql_insert.ExecuteNonQuery()
                    sql_update.ExecuteNonQuery()
                    cs.Close()
                    MsgBox("success")
                    Me.Close()
                End If
            End If
        End If
    End Sub

    '****************************************************************************************************
    'when user change the text in TB_amount
    'this subroutine will check if the the text enter is number, and positve, and not too big, if yes check_state_amount will become true, else check_state_amount will become false and it will give user hint  on the text entered
    '****************************************************************************************************
    Private Sub TB_amount_TextChanged(sender As Object, e As EventArgs) Handles TB_amount.TextChanged 'primary check
        Try
            Dim a As Integer = Int(TB_amount.Text)
            LB_hint_amount.Text = ""
            check_state_amount = True
            If a > 32767 Then 'the stock can not be bigger than 32767, i can not select stock here because user may not enter the id/name at this stage, but give a primary check still save a lot of time
                LB_hint_amount.Text = "too big, must below stock"
                check_state_amount = False
            ElseIf a < 0 Then
                LB_hint_amount.Text = "only positive value"
                check_state_amount = False
            End If
        Catch ex As Exception 'this exception should not be triggered any time
            MsgBox(ex.ToString)
            LB_hint_amount.Text = "you should enter proper number"
            check_state_amount = False
        End Try
    End Sub

    '****************************************************************************************************
    'this function will read the card using MF_Getsnr() which is the function in the MF1.dll it will return 0 if it read the card and it will put the number get into aBuffer and asnr than compare the number in the card and the number in worker table if they are same that means the card used is right card and this function will return true, else if the numbers are not same or if it didn't read a card it will return false
    '****************************************************************************************************
    Private Function scan() As Boolean 'read the card and compare to numbers in the database 
        Dim sqlcmd As New SqlCommand("SELECT Wcard_0, Wcard_1, Wcard_2, Wcard_3, Wcard_ver FROM warehouse_worker WHERE Worker_ID=@ID", cs) 'select the numbers from database
        sqlcmd.Parameters.Add("ID", SqlDbType.TinyInt).Value = ID 'add parameter
        Dim sqladp As New SqlDataAdapter(sqlcmd)
        Dim table As New DataTable
        sqladp.Fill(table) 'fill the table then get numbers
        Dim C0 As Byte = table.Rows(0).Item(0)
        Dim C1 As Byte = table.Rows(0).Item(1)
        Dim C2 As Byte = table.Rows(0).Item(2)
        Dim C3 As Byte = table.Rows(0).Item(3)
        Dim Cver As Byte = table.Rows(0).Item(4) '/get numbers

        Dim ret As Integer

        Dim asnr(20) As Byte
        Dim aBuffer(256) As Byte

        ret = MF_Getsnr(0, 0, asnr(0), aBuffer(0)) 'function in MF1.dll used to read card, will return 0 if read successly

        If ret = 0 Then
            If C0 = aBuffer(0) And C1 = aBuffer(1) And C2 = aBuffer(2) And C3 = aBuffer(3) And Cver = asnr(0) Then 'the numbers are same means the card use is correct
                'ret = ControlBuzzer(1, 1, aBuffer(0))
                Return True
            Else
                MsgBox("wrong card")
                Return False
            End If
        Else 'ret <> 0 means fail to scan
            MsgBox("fail to scan")
            Return False
        End If
    End Function

    '****************************************************************************************************
    'this subroutine will enable the main_from after user close this form
    '****************************************************************************************************
    Private Sub Form_take_out_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main_Form.Enabled = True
    End Sub
End Class