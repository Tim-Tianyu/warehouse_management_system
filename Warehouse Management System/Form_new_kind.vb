Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form_new_kind
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)
    Dim check_name As Boolean = False
    Dim check_type As Boolean = True
    Dim check_amount As Boolean = False
    Dim check_dangerline As Boolean = True
    Private Sub TB_amount_TextChanged(sender As Object, e As EventArgs) Handles TB_amount.TextChanged
        Dim flag As Boolean
        Try
            Dim a As Integer = Int(TB_amount.Text)
            LB_hint_amount.Text = ""
            flag = True
            If a > 32767 Then
                LB_hint_amount.Text = "too big, should be less than 32767"
                flag = False
            ElseIf a < 0 Then
                LB_hint_amount.Text = "only positive value"
                flag = False
            End If
        Catch ex As Exception
            LB_hint_amount.Text = "you should only enter number"
            flag = False
        End Try
        check_amount = flag
    End Sub

    Private Sub TB_dangerline_TextChanged(sender As Object, e As EventArgs) Handles TB_dangerline.TextChanged
        Dim flag As Boolean
        Try
            Dim a As Integer = Int(TB_dangerline.Text)
            LB_hint_dangerline.Text = ""
            flag = True
            If a > 32767 Then
                LB_hint_dangerline.Text = "too big, should be less than 32767"
                flag = False
            ElseIf a < 0 Then
                LB_hint_dangerline.Text = "only positive value"
                flag = False
            End If
        Catch ex As Exception
            If TB_dangerline.Text <> "" Then
                LB_hint_dangerline.Text = "you should only enter number"
                flag = False
            End If
        End Try
        check_dangerline = flag
    End Sub

    Private Sub TB_name_TextChanged(sender As Object, e As EventArgs) Handles TB_name.TextChanged
        Dim flag As Boolean
        Try
            Dim a As String = TB_name.Text
            LB_hint_name.Text = ""
            flag = True
            If a.Length > 15 Then
                LB_hint_name.Text = "too long, should be 15 or less"
                flag = False
            End If
        Catch ex As Exception
            LB_hint_name.Text = "please enter proper name"
            flag = False
        End Try
        check_name = flag
    End Sub

    Private Sub TB_type_TextChanged(sender As Object, e As EventArgs) Handles TB_type.TextChanged
        Dim flag As Boolean
        Try
            Dim a As Integer = Int(TB_type.Text)
            LB_hint_type.Text = ""
            flag = True
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

    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        If check_name And check_type And check_dangerline And check_amount Then
            Dim sqlcmd As New SqlCommand("INSERT INTO warehouse_material (Mname, Mtype, Mstock, Mdanger_line) VALUES (@name,@type,@amount,@dangerline)", cs)
            sqlcmd.Parameters.Add("@name", SqlDbType.NChar).Value = TB_name.Text
            sqlcmd.Parameters.Add("@type", SqlDbType.SmallInt).Value = Int(TB_type.Text)
            sqlcmd.Parameters.Add("@amount", SqlDbType.SmallInt).Value = Int(TB_amount.Text)
            sqlcmd.Parameters.Add("@dangerline", SqlDbType.SmallInt).Value = Int(TB_dangerline.Text)
            cs.Open()
            sqlcmd.ExecuteNonQuery()
            cs.Close()
            MsgBox("success")
            Me.Close()
        Else
            MsgBox(check_name.ToString)
            MsgBox(check_type.ToString)
            MsgBox(check_amount.ToString)
            MsgBox(check_dangerline.ToString)
        End If
    End Sub

    Private Sub Form_new_kind_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_new_material.Enabled = True
    End Sub
End Class

