<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.ColA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColB = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColD = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BTN_Fill = New System.Windows.Forms.Button()
        Me.btn_Simple_Clear = New System.Windows.Forms.Button()
        Me.BTN_Custom_Clear = New System.Windows.Forms.Button()
        Me.RB_MainThread = New System.Windows.Forms.RadioButton()
        Me.RB_ThreadPool = New System.Windows.Forms.RadioButton()
        Me.NUD_Threads = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Rows = New System.Windows.Forms.NumericUpDown()
        Me.BTN_GC = New System.Windows.Forms.Button()
        Me.BTN_Report = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Console = New System.Windows.Forms.TextBox()
        Me.BTN_KWClear = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Threads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColA, Me.ColB, Me.ColC, Me.ColD})
        Me.DGV1.Location = New System.Drawing.Point(0, 0)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(439, 353)
        Me.DGV1.TabIndex = 0
        '
        'ColA
        '
        Me.ColA.HeaderText = "ColA"
        Me.ColA.Name = "ColA"
        '
        'ColB
        '
        Me.ColB.HeaderText = "ColB"
        Me.ColB.Name = "ColB"
        '
        'ColC
        '
        Me.ColC.HeaderText = "ColC"
        Me.ColC.Name = "ColC"
        '
        'ColD
        '
        Me.ColD.HeaderText = "ColD"
        Me.ColD.Name = "ColD"
        '
        'BTN_Fill
        '
        Me.BTN_Fill.Location = New System.Drawing.Point(0, 359)
        Me.BTN_Fill.Name = "BTN_Fill"
        Me.BTN_Fill.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Fill.TabIndex = 1
        Me.BTN_Fill.Text = "Fill"
        Me.BTN_Fill.UseVisualStyleBackColor = True
        '
        'btn_Simple_Clear
        '
        Me.btn_Simple_Clear.Location = New System.Drawing.Point(0, 388)
        Me.btn_Simple_Clear.Name = "btn_Simple_Clear"
        Me.btn_Simple_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Simple_Clear.TabIndex = 2
        Me.btn_Simple_Clear.Text = "Simple Clear"
        Me.btn_Simple_Clear.UseVisualStyleBackColor = True
        '
        'BTN_Custom_Clear
        '
        Me.BTN_Custom_Clear.Location = New System.Drawing.Point(0, 417)
        Me.BTN_Custom_Clear.Name = "BTN_Custom_Clear"
        Me.BTN_Custom_Clear.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Custom_Clear.TabIndex = 3
        Me.BTN_Custom_Clear.Text = "Custom Clear"
        Me.BTN_Custom_Clear.UseVisualStyleBackColor = True
        '
        'RB_MainThread
        '
        Me.RB_MainThread.AutoSize = True
        Me.RB_MainThread.Checked = True
        Me.RB_MainThread.Location = New System.Drawing.Point(82, 422)
        Me.RB_MainThread.Name = "RB_MainThread"
        Me.RB_MainThread.Size = New System.Drawing.Size(85, 17)
        Me.RB_MainThread.TabIndex = 4
        Me.RB_MainThread.TabStop = True
        Me.RB_MainThread.Text = "Main Thread"
        Me.RB_MainThread.UseVisualStyleBackColor = True
        '
        'RB_ThreadPool
        '
        Me.RB_ThreadPool.AutoSize = True
        Me.RB_ThreadPool.Location = New System.Drawing.Point(183, 422)
        Me.RB_ThreadPool.Name = "RB_ThreadPool"
        Me.RB_ThreadPool.Size = New System.Drawing.Size(80, 17)
        Me.RB_ThreadPool.TabIndex = 5
        Me.RB_ThreadPool.TabStop = True
        Me.RB_ThreadPool.Text = "ThreadPool"
        Me.RB_ThreadPool.UseVisualStyleBackColor = True
        '
        'NUD_Threads
        '
        Me.NUD_Threads.Location = New System.Drawing.Point(332, 422)
        Me.NUD_Threads.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Threads.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Threads.Name = "NUD_Threads"
        Me.NUD_Threads.Size = New System.Drawing.Size(120, 20)
        Me.NUD_Threads.TabIndex = 6
        Me.NUD_Threads.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NUD_Rows
        '
        Me.NUD_Rows.Location = New System.Drawing.Point(163, 362)
        Me.NUD_Rows.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Rows.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUD_Rows.Name = "NUD_Rows"
        Me.NUD_Rows.Size = New System.Drawing.Size(120, 20)
        Me.NUD_Rows.TabIndex = 7
        Me.NUD_Rows.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'BTN_GC
        '
        Me.BTN_GC.Location = New System.Drawing.Point(377, 364)
        Me.BTN_GC.Name = "BTN_GC"
        Me.BTN_GC.Size = New System.Drawing.Size(75, 23)
        Me.BTN_GC.TabIndex = 8
        Me.BTN_GC.Text = "GC"
        Me.BTN_GC.UseVisualStyleBackColor = True
        '
        'BTN_Report
        '
        Me.BTN_Report.Location = New System.Drawing.Point(377, 393)
        Me.BTN_Report.Name = "BTN_Report"
        Me.BTN_Report.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Report.TabIndex = 9
        Me.BTN_Report.Text = "report"
        Me.BTN_Report.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Rows"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Chunks"
        '
        'TB_Console
        '
        Me.TB_Console.BackColor = System.Drawing.Color.Black
        Me.TB_Console.Dock = System.Windows.Forms.DockStyle.Right
        Me.TB_Console.ForeColor = System.Drawing.Color.Lime
        Me.TB_Console.Location = New System.Drawing.Point(458, 0)
        Me.TB_Console.Multiline = True
        Me.TB_Console.Name = "TB_Console"
        Me.TB_Console.Size = New System.Drawing.Size(342, 450)
        Me.TB_Console.TabIndex = 12
        '
        'BTN_KWClear
        '
        Me.BTN_KWClear.Location = New System.Drawing.Point(81, 388)
        Me.BTN_KWClear.Name = "BTN_KWClear"
        Me.BTN_KWClear.Size = New System.Drawing.Size(75, 23)
        Me.BTN_KWClear.TabIndex = 13
        Me.BTN_KWClear.Text = "Kyle Clear"
        Me.BTN_KWClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_KWClear)
        Me.Controls.Add(Me.TB_Console)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Report)
        Me.Controls.Add(Me.BTN_GC)
        Me.Controls.Add(Me.NUD_Rows)
        Me.Controls.Add(Me.NUD_Threads)
        Me.Controls.Add(Me.RB_ThreadPool)
        Me.Controls.Add(Me.RB_MainThread)
        Me.Controls.Add(Me.BTN_Custom_Clear)
        Me.Controls.Add(Me.btn_Simple_Clear)
        Me.Controls.Add(Me.BTN_Fill)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Threads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents ColA As DataGridViewTextBoxColumn
    Friend WithEvents ColB As DataGridViewComboBoxColumn
    Friend WithEvents ColC As DataGridViewComboBoxColumn
    Friend WithEvents ColD As DataGridViewComboBoxColumn
    Friend WithEvents BTN_Fill As Button
    Friend WithEvents btn_Simple_Clear As Button
    Friend WithEvents BTN_Custom_Clear As Button
    Friend WithEvents RB_MainThread As RadioButton
    Friend WithEvents RB_ThreadPool As RadioButton
    Friend WithEvents NUD_Threads As NumericUpDown
    Friend WithEvents NUD_Rows As NumericUpDown
    Friend WithEvents BTN_GC As Button
    Friend WithEvents BTN_Report As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Console As TextBox
    Friend WithEvents BTN_KWClear As Button
End Class
