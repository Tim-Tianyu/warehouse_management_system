﻿
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO
'Imports Warehouse_Management_System.warehouse_module(useless)
Public Class Form_new_material
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim check_state_amount As Boolean = False 'status of priamry validation check of amount
    Private Sub Form_new_material_FormClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        Main_Form.Enabled = True
    End Sub

    Private Sub TB_amount_TextChanged(sender As Object, e As EventArgs) Handles TB_amount.TextChanged 'primary check
        Try
            Dim a As Integer = Int(TB_amount.Text) 'if text is not numbers or is null this will cause an exception
            LB_hint_num.Text = ""
            check_state_amount = True
            If a > 32767 Then 'can not be too big
                LB_hint_num.Text = "Too big"
                check_state_amount = False
            ElseIf a < 1 Then 'or negetive or zero
                LB_hint_num.Text = "only positive value"
                check_state_amount = False
            End If
        Catch ex As Exception 'not numbers
            LB_hint_num.Text = "you should enter number"
            check_state_amount = False
        End Try
    End Sub


    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click 'when user click confirm
        Dim sqlinsert_Record As New SqlCommand("INSERT INTO warehouse_in_record (Material_ID,Idatetime,Iamount) VALUES (@Material_ID,@Idatetime,@Iamount)", cs)
        Dim sqlupdate_Material As New SqlCommand("UPDATE warehouse_material SET Mstock = Mstock + @num WHERE Material_ID = @ID", cs)
        Dim sqlselect_Material As New SqlCommand("SELECT Mstock FROM warehouse_material WHERE Material_ID=@ID", cs)
        Dim ID As Integer = Check_material(TB_name.Text) 'in warehouse_module
        Select Case ID 'use case because it is easier to read than if, but not faster :-)
            Case Is = 77777 'get the signal from Check_material function
                LB_hint_ID.Text = "no such ID"
                ID = 0 'id can not be eqaul to zero, use this to show no id be founded
            Case Is = 88888
                LB_hint_ID.Text = "no such name"
                ID = 0
            Case Is = 99999
                LB_hint_ID.Text = "two or more have this name, must enter ID"
                ID = 0
        End Select
        If check_state_amount And ID Then 'if amount primariy check is true and ID is not 0
            Dim amount As Integer = Int(TB_amount.Text)
            sqlselect_Material.Parameters.Add("@ID", SqlDbType.SmallInt).Value = ID
            Dim sqladp As New SqlDataAdapter(sqlselect_Material) 'get the amount is material table
            Dim tbl As New DataTable
            sqladp.Fill(tbl)
            If tbl.Rows(0).Item(0) + amount < 32767 Then 'the total number must not be overflow, notice: I didn't put this in primary check(when text change) is because we do not know the id at that time
                sqlinsert_Record.Parameters.Add("@Material_ID", SqlDbType.SmallInt).Value = ID
                sqlinsert_Record.Parameters.Add("@Idatetime", SqlDbType.DateTime).Value = System.DateTime.Now 'system datetime
                sqlinsert_Record.Parameters.Add("@Iamount", SqlDbType.SmallInt).Value = amount
                sqlupdate_Material.Parameters.Add("@num", SqlDbType.SmallInt).Value = amount
                sqlupdate_Material.Parameters.Add("@ID", SqlDbType.SmallInt).Value = ID 'add parameters
                cs.Open()
                sqlinsert_Record.ExecuteNonQuery() 'in record table be inserted a new record
                sqlupdate_Material.ExecuteNonQuery() 'update the amount in material table
                cs.Close()
                MsgBox("success")
                Me.Close()
            Else
                LB_hint_num.Text = "too big"
                TB_amount.Focus()
            End If
        End If
    End Sub

    Private Sub BT_search_Click(sender As Object, e As EventArgs) Handles BT_search.Click
        Form_search.LB_state.Text = "material" 'tell form_search we need to search material
        Form_search.Find_TB("New material") 'tell the form_search the form call it
        Form_search.TB_search.Text = TB_name.Text
        Form_search.Show()
        Me.Enabled = False
    End Sub

    Private Sub BT_new_kind_Click(sender As Object, e As EventArgs) Handles BT_new_kind.Click 'if user want to add a new kind of material
        Form_new_kind.Show()
        Me.Enabled = False
    End Sub
End Class