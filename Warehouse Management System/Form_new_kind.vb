﻿Imports System.Configuration
Imports System.Data.SqlClient

'****************************************************************************************************
'this form is used to add new kind of material
'****************************************************************************************************
Public Class Form_new_kind
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim check_name As Boolean = False
    Dim check_type As Boolean = True 'can be null
    Dim check_amount As Boolean = False
    Dim check_dangerline As Boolean = True 'can be null

    'notice: these 4 events blow all happened when textchange

    '****************************************************************************************************
    'this subroutine will check the amount entered by the user when the text change in TB_amount, if will use try catch to find the text enter is number or not, then it will check the number is positive and below 23767
    '****************************************************************************************************
    Private Sub TB_amount_TextChanged(sender As Object, e As EventArgs) Handles TB_amount.TextChanged 'check amount
        Dim flag As Boolean = True 'if nothing goes wrong this will remain true
        LB_hint_amount.Text = ""
        Try
            Dim a As Integer = Int(TB_amount.Text) 'this line will cause a exception, if it is not number
            If a > 32767 Then 'can not be too big
                LB_hint_amount.Text = "不能高于32767"
                flag = False
            ElseIf a < 1 Then 'can not be negetive
                LB_hint_amount.Text = "不能低于一"
                flag = False
            End If
        Catch ex As Exception 'if it is not number
            If ex.GetType.ToString = "System.OverflowException" Then
                LB_hint_amount.Text = "溢出"
            Else
                LB_hint_amount.Text = "应输入数字"
                flag = False
            End If
        End Try
        check_amount = flag
    End Sub

    '****************************************************************************************************
    'this subroutine will check the amount entered by the user when the text change in TB_amount, it will use try catch to find the text enter is number or not, then it will check if the number is positive and below 32767（it can be null)
    '****************************************************************************************************
    Private Sub TB_dangerline_TextChanged(sender As Object, e As EventArgs) Handles TB_dangerline.TextChanged 'check dangerline
        Dim flag As Boolean = True
        LB_hint_dangerline.Text = ""
        Try
            Dim a As Integer = Int(TB_dangerline.Text) 'cause an exception if it is not a number
            If a > 32767 Then
                LB_hint_dangerline.Text = "不能高于32767"
                flag = False
            ElseIf a < 1 Then
                LB_hint_dangerline.Text = "不能低于一"
                flag = False
            End If
        Catch ex As Exception 'can only be number
            If TB_dangerline.Text <> "" Then 'can be null
                If ex.GetType.ToString = "System.OverflowException" Then
                    LB_hint_dangerline.Text = "溢出"
                Else
                    LB_hint_dangerline.Text = "应输入数字"
                    flag = False
                End If
            End If
        End Try
        check_dangerline = flag
    End Sub

    '****************************************************************************************************
    'this subroutine will check the name entered by the user when the text change in TB_name, it will use try catch to find the text enter is string(useless), then it will check if the length of string is below 15，and check if all of the character is none-numerical charc
    '****************************************************************************************************
    Private Sub TB_name_TextChanged(sender As Object, e As EventArgs) Handles TB_name.TextChanged 'check name
        Dim flag As Boolean = True
        LB_hint_name.Text = ""
        Try
            Dim a As String = TB_name.Text
            If a.Length > 15 Then 'length can not be longer than 15
                LB_hint_name.Text = "不能超过15个字符"
                flag = False
            Else
                Dim i As Integer
                For i = 0 To TB_name.Text.Length - 1
                    If IsNumeric(TB_name.Text(i)) Then
                        flag = False
                    End If
                Next
                If Not flag Then
                    LB_hint_name.Text = "不得包含数字"
                End If
            End If
        Catch ex As Exception 'this exception may not be triggered any way
            LB_hint_name.Text = "请输入合法字符"
            flag = False
        End Try
        check_name = flag
    End Sub

    '****************************************************************************************************
    'this subroutine will check the type entered by the user when the text change in TB_amount, it will use try catch to find the text enter is number or not, then it will check if the number is bigger than -32768 and below 32767（it can be null）
    '****************************************************************************************************
    Private Sub TB_type_TextChanged(sender As Object, e As EventArgs) Handles TB_type.TextChanged 'similar to check dangerline
        Dim flag As Boolean = True
        LB_hint_type.Text = ""
        Try
            Dim a As Integer = Int(TB_type.Text)
            If a > 32767 Then
                LB_hint_type.Text = "不能高于32767"
                flag = False
            ElseIf a < -32768 Then
                LB_hint_type.Text = "不能低于-32768"
                flag = False
            End If
        Catch ex As Exception
            If TB_type.Text <> "" Then
                If ex.GetType.ToString = "System.OverflowException" Then
                    LB_hint_type.Text = "溢出"
                Else
                    LB_hint_type.Text = "应输入数字"
                    flag = False
                End If
            End If
        End Try
        check_type = flag
    End Sub

    '****************************************************************************************************
    'this subroutine will insert the values into warehouse_material if the value entered is all valid
    '****************************************************************************************************
    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click 'when user click confirm
        If check_name And check_type And check_dangerline And check_amount Then 'only if all four is true
            Dim sqlcmd As New SqlCommand("INSERT INTO warehouse_material (Mname, Mtype, Mstock, Mdanger_line) VALUES (@name,@type,@amount,@dangerline)", cs) 'insert command
            sqlcmd.Parameters.Add("@name", SqlDbType.NChar).Value = TB_name.Text
            Try
                Int(TB_type.Text)
                sqlcmd.Parameters.Add("@type", SqlDbType.SmallInt).Value = Int(TB_type.Text)
            Catch
                Dim a As Integer
                sqlcmd.Parameters.Add("@type", SqlDbType.SmallInt).Value = a
            End Try
            Try
                Int(TB_dangerline.Text)
                sqlcmd.Parameters.Add("@dangerline", SqlDbType.SmallInt).Value = Int(TB_dangerline.Text)
            Catch
                Dim b As Integer
                sqlcmd.Parameters.Add("@dangerline", SqlDbType.SmallInt).Value = b
            End Try
            sqlcmd.Parameters.Add("@amount", SqlDbType.SmallInt).Value = Int(TB_amount.Text)
            cs.Open()
            sqlcmd.ExecuteNonQuery() 'execute command
            cs.Close()
            MsgBox("成功") 'tell user this is success
            Me.Close()
            'Else
            '    MsgBox(check_name.ToString)
            '    MsgBox(check_type.ToString)
            '    MsgBox(check_amount.ToString)
            '    MsgBox(check_dangerline.ToString)
        End If
    End Sub

    'enable form_new_material
    Private Sub Form_new_kind_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_new_material.Enabled = True
    End Sub
End Class