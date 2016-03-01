<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Me.DGV_record_table = New System.Windows.Forms.DataGridView()
        Me.BT_save_as = New System.Windows.Forms.Button()
        Me.BT_search = New System.Windows.Forms.Button()
        Me.TB_worker_name = New System.Windows.Forms.TextBox()
        Me.TB_material_name = New System.Windows.Forms.TextBox()
        Me.CB_worker_id = New System.Windows.Forms.CheckBox()
        Me.CB_material_id = New System.Windows.Forms.CheckBox()
        Me.CB_worker_state = New System.Windows.Forms.CheckBox()
        Me.BT_new_material = New System.Windows.Forms.Button()
        Me.BT_out_material = New System.Windows.Forms.Button()
        Me.BT_edit_worker = New System.Windows.Forms.Button()
        Me.BT_search_worker = New System.Windows.Forms.Button()
        Me.BT_search_material = New System.Windows.Forms.Button()
        Me.CB_year = New System.Windows.Forms.ComboBox()
        Me.CB_month = New System.Windows.Forms.ComboBox()
        Me.CB_day = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BT_password = New System.Windows.Forms.Button()
        Me.BT_log_out = New System.Windows.Forms.Button()
        Me.SFD_save = New System.Windows.Forms.SaveFileDialog()
        Me.LB_hint_search = New System.Windows.Forms.Label()
        CType(Me.DGV_record_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_record_table
        '
        Me.DGV_record_table.AllowUserToAddRows = False
        Me.DGV_record_table.AllowUserToDeleteRows = False
        Me.DGV_record_table.AllowUserToResizeColumns = False
        Me.DGV_record_table.AllowUserToResizeRows = False
        Me.DGV_record_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_record_table.Location = New System.Drawing.Point(282, 122)
        Me.DGV_record_table.Name = "DGV_record_table"
        Me.DGV_record_table.ReadOnly = True
        Me.DGV_record_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_record_table.RowTemplate.Height = 23
        Me.DGV_record_table.Size = New System.Drawing.Size(668, 376)
        Me.DGV_record_table.TabIndex = 0
        '
        'BT_save_as
        '
        Me.BT_save_as.Location = New System.Drawing.Point(818, 528)
        Me.BT_save_as.Name = "BT_save_as"
        Me.BT_save_as.Size = New System.Drawing.Size(75, 23)
        Me.BT_save_as.TabIndex = 4
        Me.BT_save_as.Text = "Save as"
        Me.BT_save_as.UseVisualStyleBackColor = True
        '
        'BT_search
        '
        Me.BT_search.Location = New System.Drawing.Point(282, 86)
        Me.BT_search.Name = "BT_search"
        Me.BT_search.Size = New System.Drawing.Size(75, 24)
        Me.BT_search.TabIndex = 5
        Me.BT_search.Text = "search"
        Me.BT_search.UseVisualStyleBackColor = True
        '
        'TB_worker_name
        '
        Me.TB_worker_name.Location = New System.Drawing.Point(450, 89)
        Me.TB_worker_name.Name = "TB_worker_name"
        Me.TB_worker_name.Size = New System.Drawing.Size(100, 21)
        Me.TB_worker_name.TabIndex = 6
        '
        'TB_material_name
        '
        Me.TB_material_name.Location = New System.Drawing.Point(630, 89)
        Me.TB_material_name.Name = "TB_material_name"
        Me.TB_material_name.Size = New System.Drawing.Size(100, 21)
        Me.TB_material_name.TabIndex = 7
        '
        'CB_worker_id
        '
        Me.CB_worker_id.AutoSize = True
        Me.CB_worker_id.Location = New System.Drawing.Point(450, 528)
        Me.CB_worker_id.Name = "CB_worker_id"
        Me.CB_worker_id.Size = New System.Drawing.Size(60, 16)
        Me.CB_worker_id.TabIndex = 9
        Me.CB_worker_id.Text = "工人ID"
        Me.CB_worker_id.UseVisualStyleBackColor = True
        '
        'CB_material_id
        '
        Me.CB_material_id.AutoSize = True
        Me.CB_material_id.Location = New System.Drawing.Point(562, 528)
        Me.CB_material_id.Name = "CB_material_id"
        Me.CB_material_id.Size = New System.Drawing.Size(60, 16)
        Me.CB_material_id.TabIndex = 10
        Me.CB_material_id.Text = "材料ID"
        Me.CB_material_id.UseVisualStyleBackColor = True
        '
        'CB_worker_state
        '
        Me.CB_worker_state.AutoSize = True
        Me.CB_worker_state.Location = New System.Drawing.Point(681, 528)
        Me.CB_worker_state.Name = "CB_worker_state"
        Me.CB_worker_state.Size = New System.Drawing.Size(72, 16)
        Me.CB_worker_state.TabIndex = 11
        Me.CB_worker_state.Text = "工人状态"
        Me.CB_worker_state.UseVisualStyleBackColor = True
        '
        'BT_new_material
        '
        Me.BT_new_material.Location = New System.Drawing.Point(50, 50)
        Me.BT_new_material.Name = "BT_new_material"
        Me.BT_new_material.Size = New System.Drawing.Size(186, 97)
        Me.BT_new_material.TabIndex = 14
        Me.BT_new_material.Text = "new material come"
        Me.BT_new_material.UseVisualStyleBackColor = True
        '
        'BT_out_material
        '
        Me.BT_out_material.Location = New System.Drawing.Point(50, 180)
        Me.BT_out_material.Name = "BT_out_material"
        Me.BT_out_material.Size = New System.Drawing.Size(186, 97)
        Me.BT_out_material.TabIndex = 17
        Me.BT_out_material.Text = "take out material"
        Me.BT_out_material.UseVisualStyleBackColor = True
        '
        'BT_edit_worker
        '
        Me.BT_edit_worker.Location = New System.Drawing.Point(50, 310)
        Me.BT_edit_worker.Name = "BT_edit_worker"
        Me.BT_edit_worker.Size = New System.Drawing.Size(186, 97)
        Me.BT_edit_worker.TabIndex = 18
        Me.BT_edit_worker.Text = "management worker"
        Me.BT_edit_worker.UseVisualStyleBackColor = True
        '
        'BT_search_worker
        '
        Me.BT_search_worker.Image = Global.Warehouse_Management_System.My.Resources.Resources.放大镜_小
        Me.BT_search_worker.Location = New System.Drawing.Point(556, 81)
        Me.BT_search_worker.Name = "BT_search_worker"
        Me.BT_search_worker.Size = New System.Drawing.Size(36, 35)
        Me.BT_search_worker.TabIndex = 19
        Me.BT_search_worker.UseVisualStyleBackColor = True
        '
        'BT_search_material
        '
        Me.BT_search_material.Image = Global.Warehouse_Management_System.My.Resources.Resources.放大镜_小
        Me.BT_search_material.Location = New System.Drawing.Point(736, 81)
        Me.BT_search_material.Name = "BT_search_material"
        Me.BT_search_material.Size = New System.Drawing.Size(36, 35)
        Me.BT_search_material.TabIndex = 20
        Me.BT_search_material.UseVisualStyleBackColor = True
        '
        'CB_year
        '
        Me.CB_year.FormattingEnabled = True
        Me.CB_year.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.CB_year.Location = New System.Drawing.Point(818, 89)
        Me.CB_year.Name = "CB_year"
        Me.CB_year.Size = New System.Drawing.Size(50, 20)
        Me.CB_year.TabIndex = 21
        '
        'CB_month
        '
        Me.CB_month.FormattingEnabled = True
        Me.CB_month.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CB_month.Location = New System.Drawing.Point(868, 89)
        Me.CB_month.Name = "CB_month"
        Me.CB_month.Size = New System.Drawing.Size(35, 20)
        Me.CB_month.TabIndex = 22
        '
        'CB_day
        '
        Me.CB_day.FormattingEnabled = True
        Me.CB_day.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CB_day.Location = New System.Drawing.Point(903, 89)
        Me.CB_day.Name = "CB_day"
        Me.CB_day.Size = New System.Drawing.Size(35, 20)
        Me.CB_day.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(448, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "worker name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(629, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "material name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(816, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(866, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "month"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(901, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 12)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "day"
        '
        'BT_password
        '
        Me.BT_password.Location = New System.Drawing.Point(50, 440)
        Me.BT_password.Name = "BT_password"
        Me.BT_password.Size = New System.Drawing.Size(186, 97)
        Me.BT_password.TabIndex = 29
        Me.BT_password.Text = "change passward"
        Me.BT_password.UseVisualStyleBackColor = True
        '
        'BT_log_out
        '
        Me.BT_log_out.Location = New System.Drawing.Point(899, 12)
        Me.BT_log_out.Name = "BT_log_out"
        Me.BT_log_out.Size = New System.Drawing.Size(75, 23)
        Me.BT_log_out.TabIndex = 30
        Me.BT_log_out.Text = "log out"
        Me.BT_log_out.UseVisualStyleBackColor = True
        '
        'LB_hint_search
        '
        Me.LB_hint_search.AutoSize = True
        Me.LB_hint_search.Location = New System.Drawing.Point(450, 48)
        Me.LB_hint_search.Name = "LB_hint_search"
        Me.LB_hint_search.Size = New System.Drawing.Size(0, 12)
        Me.LB_hint_search.TabIndex = 32
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(984, 579)
        Me.Controls.Add(Me.LB_hint_search)
        Me.Controls.Add(Me.BT_log_out)
        Me.Controls.Add(Me.BT_password)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_day)
        Me.Controls.Add(Me.CB_month)
        Me.Controls.Add(Me.CB_year)
        Me.Controls.Add(Me.BT_search_material)
        Me.Controls.Add(Me.BT_search_worker)
        Me.Controls.Add(Me.BT_edit_worker)
        Me.Controls.Add(Me.BT_out_material)
        Me.Controls.Add(Me.BT_new_material)
        Me.Controls.Add(Me.CB_worker_state)
        Me.Controls.Add(Me.CB_material_id)
        Me.Controls.Add(Me.CB_worker_id)
        Me.Controls.Add(Me.TB_material_name)
        Me.Controls.Add(Me.TB_worker_name)
        Me.Controls.Add(Me.BT_search)
        Me.Controls.Add(Me.BT_save_as)
        Me.Controls.Add(Me.DGV_record_table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(1000, 618)
        Me.MinimumSize = New System.Drawing.Size(1000, 618)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse Management System"
        CType(Me.DGV_record_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_record_table As System.Windows.Forms.DataGridView
    Friend WithEvents BT_save_as As System.Windows.Forms.Button
    Friend WithEvents BT_search As System.Windows.Forms.Button
    Friend WithEvents TB_worker_name As System.Windows.Forms.TextBox
    Friend WithEvents TB_material_name As System.Windows.Forms.TextBox
    Friend WithEvents CB_worker_id As System.Windows.Forms.CheckBox
    Friend WithEvents CB_material_id As System.Windows.Forms.CheckBox
    Friend WithEvents CB_worker_state As System.Windows.Forms.CheckBox
    Friend WithEvents BT_new_material As System.Windows.Forms.Button
    Friend WithEvents BT_out_material As System.Windows.Forms.Button
    Friend WithEvents BT_edit_worker As System.Windows.Forms.Button
    Friend WithEvents BT_search_worker As System.Windows.Forms.Button
    Friend WithEvents BT_search_material As System.Windows.Forms.Button
    Friend WithEvents CB_year As System.Windows.Forms.ComboBox
    Friend WithEvents CB_month As System.Windows.Forms.ComboBox
    Friend WithEvents CB_day As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BT_password As System.Windows.Forms.Button
    Friend WithEvents BT_log_out As System.Windows.Forms.Button
    Friend WithEvents SFD_save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LB_hint_search As System.Windows.Forms.Label

End Class
