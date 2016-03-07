<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_new_material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_new_material))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_name = New System.Windows.Forms.TextBox()
        Me.TB_amount = New System.Windows.Forms.TextBox()
        Me.BT_new_kind = New System.Windows.Forms.Button()
        Me.BT_confirm = New System.Windows.Forms.Button()
        Me.BT_search = New System.Windows.Forms.Button()
        Me.LB_hint_num = New System.Windows.Forms.Label()
        Me.LB_hint_ID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名字/ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "数量"
        '
        'TB_name
        '
        Me.TB_name.Location = New System.Drawing.Point(114, 100)
        Me.TB_name.Name = "TB_name"
        Me.TB_name.Size = New System.Drawing.Size(100, 21)
        Me.TB_name.TabIndex = 2
        '
        'TB_amount
        '
        Me.TB_amount.Location = New System.Drawing.Point(114, 231)
        Me.TB_amount.Name = "TB_amount"
        Me.TB_amount.Size = New System.Drawing.Size(100, 21)
        Me.TB_amount.TabIndex = 3
        '
        'BT_new_kind
        '
        Me.BT_new_kind.Location = New System.Drawing.Point(39, 134)
        Me.BT_new_kind.Name = "BT_new_kind"
        Me.BT_new_kind.Size = New System.Drawing.Size(75, 45)
        Me.BT_new_kind.TabIndex = 4
        Me.BT_new_kind.Text = "新材料"
        Me.BT_new_kind.UseVisualStyleBackColor = True
        '
        'BT_confirm
        '
        Me.BT_confirm.Location = New System.Drawing.Point(114, 296)
        Me.BT_confirm.Name = "BT_confirm"
        Me.BT_confirm.Size = New System.Drawing.Size(75, 23)
        Me.BT_confirm.TabIndex = 5
        Me.BT_confirm.Text = "确认"
        Me.BT_confirm.UseVisualStyleBackColor = True
        '
        'BT_search
        '
        Me.BT_search.Image = CType(resources.GetObject("BT_search.Image"), System.Drawing.Image)
        Me.BT_search.Location = New System.Drawing.Point(220, 92)
        Me.BT_search.Name = "BT_search"
        Me.BT_search.Size = New System.Drawing.Size(36, 35)
        Me.BT_search.TabIndex = 7
        Me.BT_search.UseVisualStyleBackColor = True
        '
        'LB_hint_num
        '
        Me.LB_hint_num.AutoSize = True
        Me.LB_hint_num.Location = New System.Drawing.Point(112, 255)
        Me.LB_hint_num.Name = "LB_hint_num"
        Me.LB_hint_num.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_num.TabIndex = 8
        '
        'LB_hint_ID
        '
        Me.LB_hint_ID.AutoSize = True
        Me.LB_hint_ID.Location = New System.Drawing.Point(112, 124)
        Me.LB_hint_ID.Name = "LB_hint_ID"
        Me.LB_hint_ID.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_ID.TabIndex = 9
        '
        'Form_new_material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.LB_hint_ID)
        Me.Controls.Add(Me.LB_hint_num)
        Me.Controls.Add(Me.BT_search)
        Me.Controls.Add(Me.BT_confirm)
        Me.Controls.Add(Me.BT_new_kind)
        Me.Controls.Add(Me.TB_amount)
        Me.Controls.Add(Me.TB_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_new_material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "材料入仓"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_name As System.Windows.Forms.TextBox
    Friend WithEvents TB_amount As System.Windows.Forms.TextBox
    Friend WithEvents BT_new_kind As System.Windows.Forms.Button
    Friend WithEvents BT_confirm As System.Windows.Forms.Button
    Friend WithEvents BT_search As System.Windows.Forms.Button
    Friend WithEvents LB_hint_num As System.Windows.Forms.Label
    Friend WithEvents LB_hint_ID As System.Windows.Forms.Label
End Class
