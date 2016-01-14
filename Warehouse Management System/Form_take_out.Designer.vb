<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_take_out
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_worker = New System.Windows.Forms.TextBox()
        Me.TB_material = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_amount = New System.Windows.Forms.TextBox()
        Me.BT_confirm = New System.Windows.Forms.Button()
        Me.BT_search_worker = New System.Windows.Forms.Button()
        Me.BT_search_material = New System.Windows.Forms.Button()
        Me.LB_hint_worker = New System.Windows.Forms.Label()
        Me.LB_hint_material = New System.Windows.Forms.Label()
        Me.LB_hint_amount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "take out material"
        '
        'TB_worker
        '
        Me.TB_worker.Location = New System.Drawing.Point(106, 79)
        Me.TB_worker.Name = "TB_worker"
        Me.TB_worker.Size = New System.Drawing.Size(100, 21)
        Me.TB_worker.TabIndex = 1
        '
        'TB_material
        '
        Me.TB_material.Location = New System.Drawing.Point(106, 129)
        Me.TB_material.Name = "TB_material"
        Me.TB_material.Size = New System.Drawing.Size(100, 21)
        Me.TB_material.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "worker name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "material name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "amount take"
        '
        'TB_amount
        '
        Me.TB_amount.Location = New System.Drawing.Point(106, 179)
        Me.TB_amount.Name = "TB_amount"
        Me.TB_amount.Size = New System.Drawing.Size(100, 21)
        Me.TB_amount.TabIndex = 6
        '
        'BT_confirm
        '
        Me.BT_confirm.Location = New System.Drawing.Point(106, 226)
        Me.BT_confirm.Name = "BT_confirm"
        Me.BT_confirm.Size = New System.Drawing.Size(75, 23)
        Me.BT_confirm.TabIndex = 7
        Me.BT_confirm.Text = "confirm"
        Me.BT_confirm.UseVisualStyleBackColor = True
        '
        'BT_search_worker
        '
        Me.BT_search_worker.Image = Global.Warehouse_Management_System.My.Resources.Resources.放大镜_小
        Me.BT_search_worker.Location = New System.Drawing.Point(222, 71)
        Me.BT_search_worker.Name = "BT_search_worker"
        Me.BT_search_worker.Size = New System.Drawing.Size(36, 35)
        Me.BT_search_worker.TabIndex = 20
        Me.BT_search_worker.UseVisualStyleBackColor = True
        '
        'BT_search_material
        '
        Me.BT_search_material.Image = Global.Warehouse_Management_System.My.Resources.Resources.放大镜_小
        Me.BT_search_material.Location = New System.Drawing.Point(222, 121)
        Me.BT_search_material.Name = "BT_search_material"
        Me.BT_search_material.Size = New System.Drawing.Size(36, 35)
        Me.BT_search_material.TabIndex = 21
        Me.BT_search_material.UseVisualStyleBackColor = True
        '
        'LB_hint_worker
        '
        Me.LB_hint_worker.AutoSize = True
        Me.LB_hint_worker.Location = New System.Drawing.Point(104, 103)
        Me.LB_hint_worker.Name = "LB_hint_worker"
        Me.LB_hint_worker.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_worker.TabIndex = 22
        '
        'LB_hint_material
        '
        Me.LB_hint_material.AutoSize = True
        Me.LB_hint_material.Location = New System.Drawing.Point(104, 153)
        Me.LB_hint_material.Name = "LB_hint_material"
        Me.LB_hint_material.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_material.TabIndex = 23
        '
        'LB_hint_amount
        '
        Me.LB_hint_amount.AutoSize = True
        Me.LB_hint_amount.Location = New System.Drawing.Point(104, 203)
        Me.LB_hint_amount.Name = "LB_hint_amount"
        Me.LB_hint_amount.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_amount.TabIndex = 24
        '
        'Form_take_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LB_hint_amount)
        Me.Controls.Add(Me.LB_hint_material)
        Me.Controls.Add(Me.LB_hint_worker)
        Me.Controls.Add(Me.BT_search_material)
        Me.Controls.Add(Me.BT_search_worker)
        Me.Controls.Add(Me.BT_confirm)
        Me.Controls.Add(Me.TB_amount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_material)
        Me.Controls.Add(Me.TB_worker)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_take_out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_take_out"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_worker As System.Windows.Forms.TextBox
    Friend WithEvents TB_material As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_amount As System.Windows.Forms.TextBox
    Friend WithEvents BT_confirm As System.Windows.Forms.Button
    Friend WithEvents BT_search_worker As System.Windows.Forms.Button
    Friend WithEvents BT_search_material As System.Windows.Forms.Button
    Friend WithEvents LB_hint_worker As System.Windows.Forms.Label
    Friend WithEvents LB_hint_material As System.Windows.Forms.Label
    Friend WithEvents LB_hint_amount As System.Windows.Forms.Label
End Class
