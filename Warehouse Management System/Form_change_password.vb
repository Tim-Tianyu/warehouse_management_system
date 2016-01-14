Public Class Form_change_password
    Private Sub BT_cofrim_Click(sender As Object, e As EventArgs) Handles BT_cofrim.Click
        If TB_old_pass.Text = Form_log_in.password_get() Then
            If check() Then
                Form_log_in.password_change(TB_new_pass.Text)
                MsgBox("success")
                Me.Close()
            End If
        Else
            LB_hint_old.Text = "wrong old password"
            TB_old_pass.Clear()
            TB_old_pass.Focus()
        End If
    End Sub

    Private Function check() As Boolean
        Dim oldpass As String = TB_new_pass.Text
        Dim state As Boolean = True
        If oldpass.Length < 4 Then
            LB_hint_new.Text = "length can not smaller than 4"
            state = False
        Else
            Dim i As Integer
            For i = 0 To oldpass.Length - 1
                If Not (IsNumeric(oldpass(i)) Or isalpha(oldpass(i))) Then
                    state = False
                End If
            Next i
            If Not state Then
                LB_hint_new.Text = "数字 或 字母"
            Else
                LB_hint_new.Text = ""
            End If
        End If
        If TB_again.Text <> TB_new_pass.Text Then
            state = False
            LB_hint_again.Text = "not same as new password"
        Else
            LB_hint_again.Text = ""
        End If
        Return state
    End Function

    Private Function isalpha(cha As Char) As Boolean
        Return ((Asc(cha) >= 65) And (Asc(cha) <= 90))
    End Function

    Private Sub Form_change_password_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main_Form.Enabled = True
    End Sub
End Class