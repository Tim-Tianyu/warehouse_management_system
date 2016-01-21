Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form_search
    Dim TB_name As String = ""
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim sqlcmd As New SqlCommand("", cs)
    Dim tbl As New DataTable

    '****************************************************************************************************
    'this subroutine will receive the signal from other form to identify which bottun opened this form
    '****************************************************************************************************
    Public Sub Find_TB(name As String)
        TB_name = name 'get signal form other forms
    End Sub

    '****************************************************************************************************
    'this subroutine will load the search result into DGV_result grid using, using select...like...
    '****************************************************************************************************
    Private Sub BT_search_Click(sender As Object, e As EventArgs) Handles BT_search.Click 'this is not a very strong search function
        tbl.Clear() 'clear tbl
        If LB_state.Text = "worker" Then 'the text can only be worker or material
            sqlcmd.CommandText = "SELECT Worker_ID, Wname, Wstate FROM warehouse_worker WHERE Wname LIKE @name"
        Else
            sqlcmd.CommandText = "SELECT * FROM warehouse_material WHERE Mname LIKE @name" 'like, you know?
        End If
        sqlcmd.Parameters.Item("name").Value = "%" + TB_search.Text + "%" 'search any record that worker/material name contain the string entered by user
        Dim sqladp As New SqlDataAdapter(sqlcmd)
        sqladp.Fill(tbl) 'fill tbl
        DGV_result.DataSource = tbl 'put datasource in grid
    End Sub

    '****************************************************************************************************
    'this subroutine will put the search result click by the user into the textbox TB_search for user to confirm
    '****************************************************************************************************
    Private Sub DGV_result_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_result.CellClick
        TB_search.Text = RTrim(DGV_result.CurrentRow.Cells(1).Value.ToString()) 'only the worker/material name of the current row, Rtrim() remove the space"
    End Sub

    '****************************************************************************************************
    'this subroutinet will put the search result confirm by the user back to the right textbox depend on the signal it get from other form
    '****************************************************************************************************
    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click 'put the text be searched back to the form that opened the form_search
        Select Case TB_name 'the signal from other form
            Case Is = "MF worker"
                Main_Form.TB_worker_name.Text = TB_search.Text
            Case Is = "MF material"
                Main_Form.TB_material_name.Text = TB_search.Text
            Case Is = "New material"
                Form_new_material.TB_name.Text = TB_search.Text
            Case Is = "TO material"
                Form_take_out.TB_material.Text = TB_search.Text
            Case Is = "TO worker"
                Form_take_out.TB_worker.Text = TB_search.Text
            Case Is = "FW worker"
                Form_worker.TB_worker.Text = TB_search.Text
        End Select
        Me.Close()
    End Sub

    '****************************************************************************************************
    'using the signal get from other form to enable the right form when this form closed
    '****************************************************************************************************
    Private Sub Form_search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed 'enable the form that open the form_search
        Select Case TB_name 'signal from other form
            Case Is = "MF worker"
                Main_Form.Enabled = True
            Case Is = "MF material"
                Main_Form.Enabled = True
            Case Is = "New material"
                Form_new_material.Enabled = True
            Case Is = "TO material"
                Form_take_out.Enabled = True
            Case Is = "TO worker"
                Form_take_out.Enabled = True
            Case Is = "FW worker"
                Form_worker.Enabled = True
        End Select
    End Sub

    '****************************************************************************************************
    'when this from load, load the table(same as BT_search_click)
    '****************************************************************************************************
    Private Sub Form_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'same as event when search button click, but this happened when the form loaded
        If LB_state.Text = "worker" Then
            sqlcmd.CommandText = "SELECT Worker_ID, Wname, Wstate FROM warehouse_worker WHERE Wname LIKE @name"
        Else
            sqlcmd.CommandText = "SELECT * FROM warehouse_material WHERE Mname LIKE @name"
        End If
        sqlcmd.Parameters.Add("name", SqlDbType.NChar).Value = "%" + TB_search.Text + "%"
        Dim sqladp As New SqlDataAdapter(sqlcmd)
        sqladp.Fill(tbl)
        DGV_result.DataSource = tbl
    End Sub
End Class