<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_search
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
        Me.LB_state = New System.Windows.Forms.Label()
        Me.TB_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_result = New System.Windows.Forms.DataGridView()
        Me.BT_search = New System.Windows.Forms.Button()
        Me.BT_confirm = New System.Windows.Forms.Button()
        CType(Me.DGV_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_state
        '
        Me.LB_state.AutoSize = True
        Me.LB_state.Location = New System.Drawing.Point(111, 65)
        Me.LB_state.Name = "LB_state"
        Me.LB_state.Size = New System.Drawing.Size(53, 12)
        Me.LB_state.TabIndex = 0
        Me.LB_state.Text = "LB_state"
        '
        'TB_search
        '
        Me.TB_search.Location = New System.Drawing.Point(93, 80)
        Me.TB_search.Name = "TB_search"
        Me.TB_search.Size = New System.Drawing.Size(100, 21)
        Me.TB_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "输入名字的一部分进行搜索"
        '
        'DGV_result
        '
        Me.DGV_result.AllowUserToAddRows = False
        Me.DGV_result.AllowUserToDeleteRows = False
        Me.DGV_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_result.Location = New System.Drawing.Point(12, 107)
        Me.DGV_result.Name = "DGV_result"
        Me.DGV_result.ReadOnly = True
        Me.DGV_result.RowTemplate.Height = 23
        Me.DGV_result.Size = New System.Drawing.Size(261, 208)
        Me.DGV_result.TabIndex = 3
        '
        'BT_search
        '
        Me.BT_search.Location = New System.Drawing.Point(12, 78)
        Me.BT_search.Name = "BT_search"
        Me.BT_search.Size = New System.Drawing.Size(75, 23)
        Me.BT_search.TabIndex = 4
        Me.BT_search.Text = "搜索"
        Me.BT_search.UseVisualStyleBackColor = True
        '
        'BT_confirm
        '
        Me.BT_confirm.Location = New System.Drawing.Point(199, 78)
        Me.BT_confirm.Name = "BT_confirm"
        Me.BT_confirm.Size = New System.Drawing.Size(75, 23)
        Me.BT_confirm.TabIndex = 5
        Me.BT_confirm.Text = "确认"
        Me.BT_confirm.UseVisualStyleBackColor = True
        '
        'Form_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 327)
        Me.Controls.Add(Me.BT_confirm)
        Me.Controls.Add(Me.BT_search)
        Me.Controls.Add(Me.DGV_result)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_search)
        Me.Controls.Add(Me.LB_state)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "搜索"
        CType(Me.DGV_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_state As System.Windows.Forms.Label
    Friend WithEvents TB_search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_result As System.Windows.Forms.DataGridView
    Friend WithEvents BT_search As System.Windows.Forms.Button
    Friend WithEvents BT_confirm As System.Windows.Forms.Button
End Class
