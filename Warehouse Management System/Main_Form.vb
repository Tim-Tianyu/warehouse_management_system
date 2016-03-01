
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO
Imports Microsoft.Office.Interop

'****************************************************************************************************
'this form is the "main form",also user can see the record table in the grid and convert the table into excel file
'****************************************************************************************************
Public Class Main_Form
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString 'get the connection string
    Dim cs As New SqlConnection(sqlcs) 'connection to the database
    Dim table As New DataTable
    Dim oExcel As New Excel.Application 'excel application
    Dim oBook As Excel.Workbook 'excel workbook
    Dim oSheet As Excel.Worksheet 'excel worksheet

    '****************************************************************************************************
    'this subroutine will load the warehouse_record table into the DGV_record_table grid, user can give different condition(time, name of the worker/material), and only the record accord with the condition given will be load
    '****************************************************************************************************
    Private Sub load_table()
        Dim sqlcomd As New SqlCommand("select Mname as 材料名,Mtype as 类型,Material_ID as 材料ID,Wname as 工人名,Wstate as 状态,Worker_ID as 工人ID,Onum_take as 取货量,Onum_left as 余货量,Odatetime as 时间 from warehouse_out_record, warehouse_worker, warehouse_material where (Material_ID_FK=Material_ID and Worker_ID_FK=Worker_ID) " + sqlstring(), cs) 'command to select the take out record and sqlstring is the condition
        Dim sqladp As New SqlDataAdapter(sqlcomd) 'dataadapter
        sqladp.Fill(table) 'fill the data to the table
        DGV_record_table.DataSource = table
    End Sub

    '****************************************************************************************************
    'when the form is enable again(after using other form) the data grid will be refreash
    '****************************************************************************************************
    Private Sub Main_Form_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged 'after the enbale state changed
        If Me.Enabled = True Then
            table.Clear() 'clear the table
            load_table() 'load datagrid again
        End If
    End Sub

    '****************************************************************************************************
    'when user close this form, user actually want to close the program, so we need to close form_log_in which is now invisible, then the whole program will be close
    '****************************************************************************************************
    Private Sub Main_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed 'after tis form be close
        Form_log_in.Close() 'form_log_in is actually the main from, close it to close the program
    End Sub

    '****************************************************************************************************
    'when this form load, all the record will be load because no condition have given, and some porperty of the table will be rewrite
    '****************************************************************************************************
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'when this form be loaded
        load_table() 'load datagrid view
        With DGV_record_table 'rewrite some poperty for datagridview
            .Columns("工人ID").Visible = False
            .Columns("材料ID").Visible = False
            .Columns("状态").Visible = False 'invisible initially
            .Columns("工人名").Width = 70
            .Columns("工人ID").Width = 50
            .Columns("状态").Width = 40
            .Columns("取货量").Width = 50
            .Columns("余货量").Width = 50
            .Columns("类型").Width = 50
            .Columns("材料ID").Width = 50
            .Columns("时间").Width = 120 'change the width to make it easier to see
        End With
    End Sub

    '****************************************************************************************************
    'user can choose to show or hide worker_id, material_id, state of worker by tick or untick the checkbox correspond, so when the checkstate of checkbox change, visible porperty will be change
    '****************************************************************************************************
    Private Sub CB_worker_id_CheckedChanged(sender As Object, e As EventArgs) Handles CB_worker_id.CheckedChanged 'when the user tick or untick the checkbox
        DGV_record_table.Columns("工人ID").Visible = CB_worker_id.CheckState 'make it visible or invisible depend on the state of check box
    End Sub

    Private Sub CB_material_id_CheckedChanged(sender As Object, e As EventArgs) Handles CB_material_id.CheckedChanged 'same as 42 to 44
        DGV_record_table.Columns("材料ID").Visible = CB_material_id.CheckState
    End Sub

    Private Sub CB_worker_state_CheckedChanged(sender As Object, e As EventArgs) Handles CB_worker_state.CheckedChanged 'same as 42 to 44
        DGV_record_table.Columns("状态").Visible = CB_worker_state.CheckState
    End Sub

    '****************************************************************************************************
    'when user click the BT_search button, reload the table  use load_table()
    '****************************************************************************************************
    Private Sub BT_search_Click(sender As Object, e As EventArgs) Handles BT_search.Click 'when the user click the search button
        table.Clear() 'clear the table
        load_table() 'reload the table
    End Sub

    '****************************************************************************************************
    'this function will return string of the condition given by the user, the string will be putted in sqlcommand in load_table()
    '****************************************************************************************************
    Private Function sqlstring() As String 'will return condition
        Dim STR As String = ""
        If TB_material_name.Text.Length <> 0 Then 'when there is any character
            STR = STR + " and Mname = '" + TB_material_name.Text + "'" 'material name condition add
        End If
        If TB_worker_name.Text.Length <> 0 Then
            STR = STR + " and Wname = '" + TB_worker_name.Text + "'" 'worker name
        End If 'user may enter some sqlcommad in material_name or worker_name, then the table get will be very messy, but that is what the user want get if they really enter those thing, so just let it go
        If CB_year.Text.Length = 4 And IsNumeric(CB_year.Text) Then 'when the length is excatly 4 number yyyy
            STR = STR + " and year(Odatetime) ='" + CB_year.Text + "'" 'year
        ElseIf CB_year.Text.Length <> 0 Then 'or when it is null
            LB_hint_search.Text = "year in 4 numbers" 'give user a hint
        End If
        If CB_month.Text.Length <= 2 And IsNumeric(CB_month.Text) Then 'mm
            STR = STR + " and month(Odatetime) ='" + CB_month.Text + "'" 'month
        ElseIf CB_month.Text.Length <> 0 Then
            LB_hint_search.Text = LB_hint_search.Text + " month in 2 numbers"
        End If
        If CB_day.Text.Length <= 2 And IsNumeric(CB_day.Text) Then 'dd
            STR = STR + " and day(Odatetime) ='" + CB_day.Text + "'" 'day
        ElseIf CB_day.Text.Length <> 0 Then
            LB_hint_search.Text = LB_hint_search.Text + " day in 2 numbers"
        End If
        Return STR 'return the condition
    End Function

    '****************************************************************************************************
    'this subroutine will load the form_new_material used to add material
    '****************************************************************************************************
    Private Sub BT_new_material_Click(sender As Object, e As EventArgs) Handles BT_new_material.Click 'when the user click new material button
        Form_new_material.Show() 'show the form
        Me.Enabled = False 'unable this form
    End Sub

    '****************************************************************************************************
    'this subroutine will load the form_search and tell form_search to search worker and put search result in which textbox
    '****************************************************************************************************
    Private Sub BT_search_worker_Click(sender As Object, e As EventArgs) Handles BT_search_worker.Click 'search the worker name
        Form_search.LB_state.Text = "worker" 'tell form_search we need to search worker table
        Form_search.Find_TB("MF worker") 'tell form_search this button and this form activate it
        Form_search.TB_search.Text = TB_worker_name.Text 'put the input from user into form_search
        Form_search.Show()
        Me.Enabled = False 'unable this form(I don't want to say this every time)
    End Sub

    '****************************************************************************************************
    'this subroutine will load the form_search and tell form_search to search material and put search result in which text box
    '****************************************************************************************************
    Private Sub BT_search_material_Click(sender As Object, e As EventArgs) Handles BT_search_material.Click 'search the material name
        Form_search.LB_state.Text = "material" '
        Form_search.Find_TB("MF material")
        Form_search.TB_search.Text = TB_material_name.Text
        Form_search.Show()
        Me.Enabled = False
    End Sub


    '****************************************************************************************************
    'this subroutine will load form_change_password used to change the password of user
    '****************************************************************************************************
    Private Sub BT_password_Click(sender As Object, e As EventArgs) Handles BT_password.Click 'user want to change passwrd
        Form_change_password.Show()
        Me.Enabled = False
    End Sub


    '****************************************************************************************************
    'this subroutine will load form_take_out used to take record of take out material
    '****************************************************************************************************
    Private Sub BT_out_material_Click(sender As Object, e As EventArgs) Handles BT_out_material.Click 'user want to take out material
        Form_take_out.Show()
        Me.Enabled = False
    End Sub

    '****************************************************************************************************
    'this subroutine will load form_worker used to manage worker, but only boss can use this part
    '****************************************************************************************************
    Private Sub BT_edit_worker_Click(sender As Object, e As EventArgs) Handles BT_edit_worker.Click 'user want to edit worker
        If Form_log_in.level_get() Then 'from form_log_in we get the level of user
            Form_worker.Show()
            Me.Enabled = False
        Else
            MsgBox("only boss can manage worker") 'oh no I'm not boss
        End If
    End Sub

    '****************************************************************************************************
    'this subroutine will load form_log_in, and make this form invisible, used to change user(boss/manager)
    '****************************************************************************************************
    Private Sub BT_log_out_Click(sender As Object, e As EventArgs) Handles BT_log_out.Click 'user want to log off
        Me.Hide() 'hide this form
        Form_log_in.Enabled = True 'enable form_log_in
        Form_log_in.Show()
    End Sub

    '****************************************************************************************************
    'this subroutine will save the data in table as excel file(.xlsx), it will load SFD_save(savefiledialog) for user to choose the address and enter file name, then it will put all the column name and all the items in table into excel worksheet using loop and at last save the file as given name in give address
    '****************************************************************************************************
    Private Sub BT_save_as_Click(sender As Object, e As EventArgs) Handles BT_save_as.Click 'user want to save the out record table
        oBook = oExcel.Workbooks().Add 'add workbook to application
        oSheet = oBook.Worksheets(1) 'add worksheet to workbook
        oSheet.Name = "test" 'rename
        With SFD_save 'some poperty need to be changed
            .DefaultExt = "xlsx"
            .Filter = "Excel file (*.xlsx)|*.xlsx" 'only this kind of file
            .FilterIndex = 0
            .OverwritePrompt = True 'can over write same name file
            .Title = "保存" 'chinese tile: save
        End With
        If SFD_save.ShowDialog = Windows.Forms.DialogResult.OK Then 'save file dialog
            Dim r As Integer, c As Integer, rCount As Integer, cCount As Integer 'r=row c=colum
            rCount = table.Rows.Count 'number of rows get
            cCount = table.Columns.Count 'number of colums get
            For c = 1 To cCount
                oSheet.Cells(1, c) = table.Columns(c - 1).ColumnName 'put the tital in
            Next
            For r = 1 To rCount
                For c = 1 To cCount
                    oSheet.Cells(r + 1, c) = table.Rows(r - 1).Item(c - 1).ToString 'put every cell in
                Next
            Next
            Try
                oBook.SaveAs(SFD_save.FileName) 'save the file
                oBook.Close()
                MsgBox("success")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

End Class
