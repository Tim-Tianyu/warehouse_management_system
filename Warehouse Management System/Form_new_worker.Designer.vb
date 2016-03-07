<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_new_worker
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
        Me.TB_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_confirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_hint = New System.Windows.Forms.Label()
        Me.LB_hint_name = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TB_name
        '
        Me.TB_name.Location = New System.Drawing.Point(104, 88)
        Me.TB_name.Name = "TB_name"
        Me.TB_name.Size = New System.Drawing.Size(100, 21)
        Me.TB_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "姓名"
        '
        'BT_confirm
        '
        Me.BT_confirm.Location = New System.Drawing.Point(87, 151)
        Me.BT_confirm.Name = "BT_confirm"
        Me.BT_confirm.Size = New System.Drawing.Size(117, 53)
        Me.BT_confirm.TabIndex = 2
        Me.BT_confirm.Text = "确认并写入ID卡"
        Me.BT_confirm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "请将ID卡放置在读卡器上"
        '
        'LB_hint
        '
        Me.LB_hint.AutoSize = True
        Me.LB_hint.Location = New System.Drawing.Point(102, 112)
        Me.LB_hint.Name = "LB_hint"
        Me.LB_hint.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint.TabIndex = 4
        '
        'LB_hint_name
        '
        Me.LB_hint_name.AutoSize = True
        Me.LB_hint_name.Location = New System.Drawing.Point(102, 112)
        Me.LB_hint_name.Name = "LB_hint_name"
        Me.LB_hint_name.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_name.TabIndex = 5
        '
        'Form_new_worker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LB_hint_name)
        Me.Controls.Add(Me.LB_hint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BT_confirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_new_worker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "添加新工人"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_confirm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LB_hint As System.Windows.Forms.Label
    Friend WithEvents LB_hint_name As System.Windows.Forms.Label
End Class
