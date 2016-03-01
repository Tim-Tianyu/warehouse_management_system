<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_change_password
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
        Me.TB_old_pass = New System.Windows.Forms.TextBox()
        Me.TB_new_pass = New System.Windows.Forms.TextBox()
        Me.TB_again = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_cofrim = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LB_hint_old = New System.Windows.Forms.Label()
        Me.LB_hint_new = New System.Windows.Forms.Label()
        Me.LB_hint_again = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TB_old_pass
        '
        Me.TB_old_pass.Location = New System.Drawing.Point(135, 66)
        Me.TB_old_pass.Name = "TB_old_pass"
        Me.TB_old_pass.Size = New System.Drawing.Size(100, 21)
        Me.TB_old_pass.TabIndex = 0
        '
        'TB_new_pass
        '
        Me.TB_new_pass.Location = New System.Drawing.Point(135, 126)
        Me.TB_new_pass.Name = "TB_new_pass"
        Me.TB_new_pass.Size = New System.Drawing.Size(100, 21)
        Me.TB_new_pass.TabIndex = 1
        '
        'TB_again
        '
        Me.TB_again.Location = New System.Drawing.Point(135, 184)
        Me.TB_again.Name = "TB_again"
        Me.TB_again.Size = New System.Drawing.Size(100, 21)
        Me.TB_again.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "old password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "new password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "enter again"
        '
        'BT_cofrim
        '
        Me.BT_cofrim.Location = New System.Drawing.Point(95, 226)
        Me.BT_cofrim.Name = "BT_cofrim"
        Me.BT_cofrim.Size = New System.Drawing.Size(75, 23)
        Me.BT_cofrim.TabIndex = 6
        Me.BT_cofrim.Text = "confirm"
        Me.BT_cofrim.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Change Password"
        '
        'LB_hint_old
        '
        Me.LB_hint_old.AutoSize = True
        Me.LB_hint_old.Location = New System.Drawing.Point(133, 90)
        Me.LB_hint_old.Name = "LB_hint_old"
        Me.LB_hint_old.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_old.TabIndex = 8
        '
        'LB_hint_new
        '
        Me.LB_hint_new.AutoSize = True
        Me.LB_hint_new.Location = New System.Drawing.Point(133, 150)
        Me.LB_hint_new.Name = "LB_hint_new"
        Me.LB_hint_new.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_new.TabIndex = 9
        '
        'LB_hint_again
        '
        Me.LB_hint_again.AutoSize = True
        Me.LB_hint_again.Location = New System.Drawing.Point(133, 208)
        Me.LB_hint_again.Name = "LB_hint_again"
        Me.LB_hint_again.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_again.TabIndex = 10
        '
        'Form_change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LB_hint_again)
        Me.Controls.Add(Me.LB_hint_new)
        Me.Controls.Add(Me.LB_hint_old)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BT_cofrim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_again)
        Me.Controls.Add(Me.TB_new_pass)
        Me.Controls.Add(Me.TB_old_pass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_change_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_change_password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_old_pass As System.Windows.Forms.TextBox
    Friend WithEvents TB_new_pass As System.Windows.Forms.TextBox
    Friend WithEvents TB_again As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BT_cofrim As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LB_hint_old As System.Windows.Forms.Label
    Friend WithEvents LB_hint_new As System.Windows.Forms.Label
    Friend WithEvents LB_hint_again As System.Windows.Forms.Label
End Class
