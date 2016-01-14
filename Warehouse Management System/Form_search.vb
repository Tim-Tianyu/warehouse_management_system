Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form_search
    Dim TB_name As String = ""
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim sqlcmd As New SqlCommand("", cs)
    Dim tbl As New DataTable
    Public Sub Find_TB(name As String)
        TB_name = name
    End Sub
    Private Sub BT_search_Click(sender As Object, e As EventArgs) Handles BT_search.Click
        tbl.Clear()
        If LB_state.Text = "worker" Then
            sqlcmd.CommandText = "SELECT * FROM warehouse_worker WHERE Wname LIKE @name"
        Else
            sqlcmd.CommandText = "SELECT Worker_ID, Wname, Wstate FROM warehouse_material WHERE Mname LIKE @name"
        End If
        sqlcmd.Parameters.Item("name").Value = "%" + TB_search.Text + "%"
        Dim sqladp As New SqlDataAdapter(sqlcmd)
        sqladp.Fill(tbl)
        DGV_result.DataSource = tbl
    End Sub

    Private Sub DGV_result_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_result.CellClick
        'TB_search.Text = RTrim(tbl.Rows(DGV_result.CurrentRow.Index).Item(1))
        TB_search.Text = RTrim(DGV_result.CurrentRow.Cells(1).Value.ToString())
    End Sub

    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        Select Case TB_name
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

    Private Sub Form_search_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Select Case TB_name
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

    Private Sub Form_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LB_state.Text = "worker" Then
            sqlcmd.CommandText = "SELECT * FROM warehouse_worker WHERE Wname LIKE @name"
        Else
            sqlcmd.CommandText = "SELECT * FROM warehouse_material WHERE Mname LIKE @name"
        End If
        sqlcmd.Parameters.Add("name", SqlDbType.NChar).Value = "%" + TB_search.Text + "%"
        Dim sqladp As New SqlDataAdapter(sqlcmd)
        sqladp.Fill(tbl)
        DGV_result.DataSource = tbl
    End Sub
End Class