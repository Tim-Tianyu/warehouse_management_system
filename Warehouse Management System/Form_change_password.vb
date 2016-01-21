'****************************************************************************************************
'this form will help user change password
'****************************************************************************************************
Public Class Form_change_password

    '****************************************************************************************************
    'this subroutine will first check the old password entered by the user is right or not use password_get() in form_log_in, if not it will tell user password is wrong, if right it will validate the new password enter use check() if valid, it will change the password use password_change() in form_log_in 
    '****************************************************************************************************
    Private Sub BT_cofrim_Click(sender As Object, e As EventArgs) Handles BT_cofrim.Click 'as bottum click
        If TB_old_pass.Text = Form_log_in.password_get() Then 'check the old password enter is write
            If check() Then 'check new password
                Form_log_in.password_change(TB_new_pass.Text) 'change the password
                MsgBox("success")
                Me.Close()
            End If
        Else
            LB_hint_old.Text = "wrong old password"
            TB_old_pass.Clear()
            TB_old_pass.Focus()
        End If
    End Sub

    '****************************************************************************************************
    'this function will check the new password enter is valid or not, password can not smaller than 4 char, can not longer than 50 char, can only contain numeric char or alphabetical char(it will check every one character in the string), and the password entered again must be same as the new password, 
    '****************************************************************************************************
    Private Function check() As Boolean 'validation check
        Dim pass As String = TB_new_pass.Text
        Dim state As Boolean = True 'if nothing goes wrong it will keep true
        LB_hint_again.Text = ""
        LB_hint_new.Text = ""
        If pass.Length < 4 Then 'check new pass
            LB_hint_new.Text = "length can not smaller than 4"
            state = False
        ElseIf pass.Length > 50 Then
            LB_hint_new.Text = "length can not be more than 50"
            state = False
        Else
            Dim i As Integer
            For i = 0 To pass.Length - 1
                If Not (IsNumeric(pass(i)) Or isalpha(pass(i))) Then 'check every character, only number and alphabeticl character can be enter
                    state = False
                End If
            Next i
            If Not state Then 'becasue this part in else, so if state is false here, it can only because the character is not nmber of alpha
                LB_hint_new.Text = "数字 和 字母"
            End If
        End If
        If TB_again.Text <> TB_new_pass.Text Then 'check renter pass
            state = False
            LB_hint_again.Text = "not same as new password"
        End If
        Return state
    End Function

    '****************************************************************************************************
    'this function will return true if the character is alphabetical value
    '****************************************************************************************************
    Private Function isalpha(cha As Char) As Boolean 'check if cha is an alphabetical character
        Return ((Asc(cha) >= 65) And (Asc(cha) <= 90))
    End Function

    '****************************************************************************************************
    'when this form closed, enable Main_form
    '****************************************************************************************************
    Private Sub Form_change_password_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main_Form.Enabled = True
    End Sub
End Class