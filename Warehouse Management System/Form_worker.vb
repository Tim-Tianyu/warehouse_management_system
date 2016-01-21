Imports System.Configuration
Imports System.Data.SqlClient

'****************************************************************************************************
'this form is used for change the state of the worker, if state is false the worker can not take out matreial
'****************************************************************************************************
Public Class Form_worker
    Dim sqlcs As String = ConfigurationManager.ConnectionStrings("connect").ConnectionString
    Dim cs As New SqlConnection(sqlcs)

    '****************************************************************************************************
    'when user click BT_search_worker button, means they want to find a worker
    'this subroutine will open form_search and send information to form_search and tell form_search it need to search worker or material and tell it the resualt show return to which textbox on which form
    '****************************************************************************************************
    Private Sub BT_search_worker_Click(sender As Object, e As EventArgs) Handles BT_search_worker.Click
        Form_search.LB_state.Text = "worker" 'tell form_search we need to search worker
        Form_search.Find_TB("FW worker") 'tell form_search this button open it
        Form_search.TB_search.Text = TB_worker.Text 'put the word into the form_search
        Form_search.Show()
        Me.Enabled = False
    End Sub

    '****************************************************************************************************
    'when user click BT_confirm button
    'this subroutine will check the name of the user entered use Check_worker function, if the name is valid it will update the worker information of that worker in warehouse_worker table using sqlcommand
    '****************************************************************************************************
    Private Sub BT_confirm_Click(sender As Object, e As EventArgs) Handles BT_confirm.Click
        Dim worker_id As Integer = Check_worker(TB_worker.Text) 'check the worker name return id
        Select Case worker_id 'give hint from the return result
            Case Is = 77777
                LB_hint_worker.Text = "no such ID"
                worker_id = 0 'means it is wrong
            Case Is = 88888
                LB_hint_worker.Text = "no such name"
                worker_id = 0
            Case Is = 99999
                LB_hint_worker.Text = "two or more have this name, must enter ID"
                worker_id = 0
        End Select
        If worker_id <> 0 Then
            Dim sql_update As New SqlCommand("UPDATE warehouse_worker SET Wstate = @state WHERE Worker_ID = @ID", cs) 'update the worker state
            sql_update.Parameters.Add("@state", SqlDbType.Bit).Value = CB_state.CheckState 'the checkstate of checkbox
            sql_update.Parameters.Add("@ID", SqlDbType.TinyInt).Value = worker_id 'add parameters
            cs.Open()
            sql_update.ExecuteNonQuery() 'execute the command
            cs.Close()
            MsgBox("success")
            Me.Close()
        End If
    End Sub

    'when user close this form, enable the main_form
    Private Sub Form_worker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main_Form.Enabled = True
    End Sub

    'when user click BT_add_new, means they want to a new worker, disable this form
    Private Sub BT_add_new_Click(sender As Object, e As EventArgs) Handles BT_add_new.Click 'if user want add a new worker
        Form_new_worker.Show()
        Me.Enabled = False
    End Sub
End Class