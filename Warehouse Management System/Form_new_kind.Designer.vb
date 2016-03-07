<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_new_kind
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
        Me.TB_type = New System.Windows.Forms.TextBox()
        Me.TB_amount = New System.Windows.Forms.TextBox()
        Me.TB_dangerline = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BT_confirm = New System.Windows.Forms.Button()
        Me.LB_hint_name = New System.Windows.Forms.Label()
        Me.LB_hint_type = New System.Windows.Forms.Label()
        Me.LB_hint_amount = New System.Windows.Forms.Label()
        Me.LB_hint_dangerline = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TB_name
        '
        Me.TB_name.Location = New System.Drawing.Point(122, 56)
        Me.TB_name.Name = "TB_name"
        Me.TB_name.Size = New System.Drawing.Size(100, 21)
        Me.TB_name.TabIndex = 1
        '
        'TB_type
        '
        Me.TB_type.Location = New System.Drawing.Point(122, 106)
        Me.TB_type.Name = "TB_type"
        Me.TB_type.Size = New System.Drawing.Size(100, 21)
        Me.TB_type.TabIndex = 2
        '
        'TB_amount
        '
        Me.TB_amount.Location = New System.Drawing.Point(122, 156)
        Me.TB_amount.Name = "TB_amount"
        Me.TB_amount.Size = New System.Drawing.Size(100, 21)
        Me.TB_amount.TabIndex = 3
        '
        'TB_dangerline
        '
        Me.TB_dangerline.Location = New System.Drawing.Point(122, 206)
        Me.TB_dangerline.Name = "TB_dangerline"
        Me.TB_dangerline.Size = New System.Drawing.Size(100, 21)
        Me.TB_dangerline.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "名字"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "类型"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "数量"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "危险线"
        '
        'BT_confirm
        '
        Me.BT_confirm.Location = New System.Drawing.Point(122, 252)
        Me.BT_confirm.Name = "BT_confirm"
        Me.BT_confirm.Size = New System.Drawing.Size(75, 23)
        Me.BT_confirm.TabIndex = 9
        Me.BT_confirm.Text = "确认"
        Me.BT_confirm.UseVisualStyleBackColor = True
        '
        'LB_hint_name
        '
        Me.LB_hint_name.AutoSize = True
        Me.LB_hint_name.Location = New System.Drawing.Point(120, 80)
        Me.LB_hint_name.Name = "LB_hint_name"
        Me.LB_hint_name.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_name.TabIndex = 10
        '
        'LB_hint_type
        '
        Me.LB_hint_type.AutoSize = True
        Me.LB_hint_type.Location = New System.Drawing.Point(120, 130)
        Me.LB_hint_type.Name = "LB_hint_type"
        Me.LB_hint_type.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_type.TabIndex = 11
        '
        'LB_hint_amount
        '
        Me.LB_hint_amount.AutoSize = True
        Me.LB_hint_amount.Location = New System.Drawing.Point(120, 180)
        Me.LB_hint_amount.Name = "LB_hint_amount"
        Me.LB_hint_amount.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_amount.TabIndex = 12
        '
        'LB_hint_dangerline
        '
        Me.LB_hint_dangerline.AutoSize = True
        Me.LB_hint_dangerline.Location = New System.Drawing.Point(120, 230)
        Me.LB_hint_dangerline.Name = "LB_hint_dangerline"
        Me.LB_hint_dangerline.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_dangerline.TabIndex = 13
        '
        'Form_new_kind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 321)
        Me.Controls.Add(Me.LB_hint_dangerline)
        Me.Controls.Add(Me.LB_hint_amount)
        Me.Controls.Add(Me.LB_hint_type)
        Me.Controls.Add(Me.LB_hint_name)
        Me.Controls.Add(Me.BT_confirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_dangerline)
        Me.Controls.Add(Me.TB_amount)
        Me.Controls.Add(Me.TB_type)
        Me.Controls.Add(Me.TB_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_new_kind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "新材料"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_name As System.Windows.Forms.TextBox
    Friend WithEvents TB_type As System.Windows.Forms.TextBox
    Friend WithEvents TB_amount As System.Windows.Forms.TextBox
    Friend WithEvents TB_dangerline As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BT_confirm As System.Windows.Forms.Button
    Friend WithEvents LB_hint_name As System.Windows.Forms.Label
    Friend WithEvents LB_hint_type As System.Windows.Forms.Label
    Friend WithEvents LB_hint_amount As System.Windows.Forms.Label
    Friend WithEvents LB_hint_dangerline As System.Windows.Forms.Label
End Class
