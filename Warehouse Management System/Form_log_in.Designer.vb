<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_log_in
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.BT_log_in = New System.Windows.Forms.Button()
        Me.LB_hint = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RB_boss = New System.Windows.Forms.RadioButton()
        Me.RB_manager = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "warehouse management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "password"
        '
        'TB_password
        '
        Me.TB_password.Location = New System.Drawing.Point(122, 138)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(34532)
        Me.TB_password.Size = New System.Drawing.Size(100, 21)
        Me.TB_password.TabIndex = 2
        '
        'BT_log_in
        '
        Me.BT_log_in.Location = New System.Drawing.Point(100, 196)
        Me.BT_log_in.Name = "BT_log_in"
        Me.BT_log_in.Size = New System.Drawing.Size(75, 23)
        Me.BT_log_in.TabIndex = 3
        Me.BT_log_in.Text = "log in"
        Me.BT_log_in.UseVisualStyleBackColor = True
        '
        'LB_hint
        '
        Me.LB_hint.AutoSize = True
        Me.LB_hint.Location = New System.Drawing.Point(120, 162)
        Me.LB_hint.Name = "LB_hint"
        Me.LB_hint.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint.TabIndex = 4
        '
        'RB_boss
        '
        Me.RB_boss.AutoSize = True
        Me.RB_boss.Location = New System.Drawing.Point(65, 91)
        Me.RB_boss.Name = "RB_boss"
        Me.RB_boss.Size = New System.Drawing.Size(47, 16)
        Me.RB_boss.TabIndex = 5
        Me.RB_boss.Text = "boss"
        Me.RB_boss.UseVisualStyleBackColor = True
        '
        'RB_manager
        '
        Me.RB_manager.AutoSize = True
        Me.RB_manager.Checked = True
        Me.RB_manager.Location = New System.Drawing.Point(140, 91)
        Me.RB_manager.Name = "RB_manager"
        Me.RB_manager.Size = New System.Drawing.Size(65, 16)
        Me.RB_manager.TabIndex = 6
        Me.RB_manager.TabStop = True
        Me.RB_manager.Text = "manager"
        Me.RB_manager.UseVisualStyleBackColor = True
        '
        'Form_log_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RB_manager)
        Me.Controls.Add(Me.RB_boss)
        Me.Controls.Add(Me.LB_hint)
        Me.Controls.Add(Me.BT_log_in)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_log_in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_log_in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_password As System.Windows.Forms.TextBox
    Friend WithEvents BT_log_in As System.Windows.Forms.Button
    Friend WithEvents LB_hint As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RB_boss As System.Windows.Forms.RadioButton
    Friend WithEvents RB_manager As System.Windows.Forms.RadioButton
End Class
