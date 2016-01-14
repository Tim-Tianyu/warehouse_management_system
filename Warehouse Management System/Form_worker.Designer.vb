<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_worker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TB_worker = New System.Windows.Forms.TextBox()
        Me.BT_search_worker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_add_new = New System.Windows.Forms.Button()
        Me.BT_confirm = New System.Windows.Forms.Button()
        Me.LB_hint_worker = New System.Windows.Forms.Label()
        Me.CB_state = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TB_worker
        '
        Me.TB_worker.Location = New System.Drawing.Point(97, 102)
        Me.TB_worker.Name = "TB_worker"
        Me.TB_worker.Size = New System.Drawing.Size(100, 21)
        Me.TB_worker.TabIndex = 0
        '
        'BT_search_worker
        '
        Me.BT_search_worker.Image = Global.Warehouse_Management_System.My.Resources.Resources.放大镜_小
        Me.BT_search_worker.Location = New System.Drawing.Point(212, 94)
        Me.BT_search_worker.Name = "BT_search_worker"
        Me.BT_search_worker.Size = New System.Drawing.Size(36, 35)
        Me.BT_search_worker.TabIndex = 20
        Me.BT_search_worker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "name/id"
        '
        'BT_add_new
        '
        Me.BT_add_new.Location = New System.Drawing.Point(197, 12)
        Me.BT_add_new.Name = "BT_add_new"
        Me.BT_add_new.Size = New System.Drawing.Size(75, 45)
        Me.BT_add_new.TabIndex = 23
        Me.BT_add_new.Text = "Add new worker"
        Me.BT_add_new.UseVisualStyleBackColor = True
        '
        'BT_confirm
        '
        Me.BT_confirm.Location = New System.Drawing.Point(97, 202)
        Me.BT_confirm.Name = "BT_confirm"
        Me.BT_confirm.Size = New System.Drawing.Size(75, 23)
        Me.BT_confirm.TabIndex = 24
        Me.BT_confirm.Text = "confirm"
        Me.BT_confirm.UseVisualStyleBackColor = True
        '
        'LB_hint_worker
        '
        Me.LB_hint_worker.AutoSize = True
        Me.LB_hint_worker.Location = New System.Drawing.Point(95, 126)
        Me.LB_hint_worker.Name = "LB_hint_worker"
        Me.LB_hint_worker.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_worker.TabIndex = 25
        '
        'CB_state
        '
        Me.CB_state.AutoSize = True
        Me.CB_state.Location = New System.Drawing.Point(97, 152)
        Me.CB_state.Name = "CB_state"
        Me.CB_state.Size = New System.Drawing.Size(54, 16)
        Me.CB_state.TabIndex = 26
        Me.CB_state.Text = "state"
        Me.CB_state.UseVisualStyleBackColor = True
        '
        'Form_worker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CB_state)
        Me.Controls.Add(Me.LB_hint_worker)
        Me.Controls.Add(Me.BT_confirm)
        Me.Controls.Add(Me.BT_add_new)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_search_worker)
        Me.Controls.Add(Me.TB_worker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_worker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "工人管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_worker As System.Windows.Forms.TextBox
    Friend WithEvents BT_search_worker As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_add_new As System.Windows.Forms.Button
    Friend WithEvents BT_confirm As System.Windows.Forms.Button
    Friend WithEvents LB_hint_worker As System.Windows.Forms.Label
    Friend WithEvents CB_state As System.Windows.Forms.CheckBox
End Class
