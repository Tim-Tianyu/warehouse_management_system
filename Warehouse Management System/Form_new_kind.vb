﻿Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form_new_kind
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim check_name As Boolean = False
    Dim check_type As Boolean = True 'can be null
    Dim check_amount As Boolean = False
    Dim check_dangerline As Boolean = True 'can be null

    'notice: these 4 events blow all happened when textchange
    Private Sub TB_amount_TextChanged(sender As Object, e As EventArgs) Handles TB_amount.TextChanged 'check amount
        Dim flag As Boolean = True 'if nothing goes wrong this will remain true
        Try
            Dim a As Integer = Int(TB_amount.Text) 'this line will cause a exception, if it is not number
            LB_hint_amount.Text = ""
            If a > 32767 Then 'can not be too big
                LB_hint_amount.Text = "too big, should be less than 32767"
                flag = False
            ElseIf a < 1 Then 'can not be negetive
                LB_hint_amount.Text = "only positive value"
                flag = False
            End If
        Catch ex As Exception 'if it is not number
            LB_hint_amount.Text = "you should only enter number"
            flag = False
        End Try
        check_amount = flag
    End Sub

    Private Sub TB_dangerline_TextChanged(sender As Object, e As EventArgs) Handles TB_dangerline.TextChanged 'check dangerline
        Dim flag As Boolean = True
        Try
            Dim a As Integer = Int(TB_dangerline.Text) 'cause an exception if it is not a number
            LB_hint_dangerline.Text = ""
            If a > 32767 Then
                LB_hint_dangerline.Text = "too big, should be less than 32767"
                flag = False
            ElseIf a < 1 Then
                LB_hint_dangerline.Text = "only positive value"
                flag = False
            End If
        Catch ex As Exception 'can only be number
            If TB_dangerline.Text <> "" Then 'can be null
                LB_hint_dangerline.Text = "you should only enter number"
                flag = False
            End If
        End Try
        check_dangerline = flag
    End Sub

    Private Sub TB_name_TextChanged(sender As Object, e As EventArgs) Handles TB_name.TextChanged 'check name
        Dim flag As Boolean = True
        Try
            Dim a As String = TB_name.Text
            LB_hint_name.Text = ""
            If a.Length > 15 Then 'length can not be longer than 15
                LB_hint_name.Text = "too long, should be 15 or less"
                flag = False
            End If
        Catch ex As Exception 'this exception may not be triggered any way
            LB_hint_name.Text = "please enter proper name"
            flag = False
        End Try
        check_name = flag
    End Sub

    Private Sub TB_type_TextChanged(sender As Object, e As EventArgs) Handles TB_type.TextChanged 'similar to check dangerline
        Dim flag As Boolean = True
        Try
            Dim a As Integer = Int(TB_type.Text)
            LB_hint_type.Text = ""
            If a > 32767 Then
                LB_hint_type.Text = "too big, should be less than 32767"
                flag = False
            End If
        Catch ex As Exception
            If TB_type.Text <> "" Then
                LB_hint_type.Text = "you should only enter number"
                flag = False
            End If
        End Try
        check_type = flag
    End Sub

    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click 'when user click confirm
        If check_name And check_type And check_dangerline And check_amount Then 'only if all four is true
            Dim sqlcmd As New SqlCommand("INSERT INTO warehouse_material (Mname, Mtype, Mstock, Mdanger_line) VALUES (@name,@type,@amount,@dangerline)", cs) 'insert command
            sqlcmd.Parameters.Add("@name", SqlDbType.NChar).Value = TB_name.Text
            sqlcmd.Parameters.Add("@type", SqlDbType.SmallInt).Value = Int(TB_type.Text)
            sqlcmd.Parameters.Add("@amount", SqlDbType.SmallInt).Value = Int(TB_amount.Text)
            sqlcmd.Parameters.Add("@dangerline", SqlDbType.SmallInt).Value = Int(TB_dangerline.Text) 'add parameters
            cs.Open()
            sqlcmd.ExecuteNonQuery() 'execute command
            cs.Close()
            MsgBox("success") 'tell user this is success
            Me.Close()
            'Else
            '    MsgBox(check_name.ToString)
            '    MsgBox(check_type.ToString)
            '    MsgBox(check_amount.ToString)
            '    MsgBox(check_dangerline.ToString)
        End If
    End Sub

    Private Sub Form_new_kind_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_new_material.Enabled = True
    End Sub
End Class