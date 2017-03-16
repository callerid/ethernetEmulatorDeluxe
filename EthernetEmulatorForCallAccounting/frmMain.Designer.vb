<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbProgress = New System.Windows.Forms.GroupBox()
        Me.btnRawData = New System.Windows.Forms.Button()
        Me.dgvL4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvL3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvL2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvL1 = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbL4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pbLine1 = New System.Windows.Forms.ProgressBar()
        Me.gbFormat = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnFormatEdit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbETSIFormat = New System.Windows.Forms.RadioButton()
        Me.rbUSAFormat = New System.Windows.Forms.RadioButton()
        Me.btnFormatContinue = New System.Windows.Forms.Button()
        Me.gbCallSetup = New System.Windows.Forms.GroupBox()
        Me.ndLine4Int = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbLine4 = New System.Windows.Forms.ProgressBar()
        Me.pbLine3 = New System.Windows.Forms.ProgressBar()
        Me.pbLine2 = New System.Windows.Forms.ProgressBar()
        Me.cbL4Name = New System.Windows.Forms.ComboBox()
        Me.cbL3Name = New System.Windows.Forms.ComboBox()
        Me.cbL2Name = New System.Windows.Forms.ComboBox()
        Me.cbL4Num = New System.Windows.Forms.ComboBox()
        Me.cbL3Num = New System.Windows.Forms.ComboBox()
        Me.cbL2Num = New System.Windows.Forms.ComboBox()
        Me.cbL4AU = New System.Windows.Forms.ComboBox()
        Me.cbL3AU = New System.Windows.Forms.ComboBox()
        Me.cbL2AU = New System.Windows.Forms.ComboBox()
        Me.cbL4IO = New System.Windows.Forms.ComboBox()
        Me.cbL3IO = New System.Windows.Forms.ComboBox()
        Me.cbL2IO = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbL1Name = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbL1Num = New System.Windows.Forms.ComboBox()
        Me.btnL4Send = New System.Windows.Forms.Button()
        Me.btnL3Send = New System.Windows.Forms.Button()
        Me.btnL2Send = New System.Windows.Forms.Button()
        Me.btnL1Send = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbL1AU = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbL1IO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDetailed = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSEB = New System.Windows.Forms.ComboBox()
        Me.gbTiming = New System.Windows.Forms.GroupBox()
        Me.btnTimingEdit = New System.Windows.Forms.Button()
        Me.btnTimingContinue = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ndOutboundStartOff = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ndInboundOffOn = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ndInboundStartOff = New System.Windows.Forms.NumericUpDown()
        Me.gbParameters = New System.Windows.Forms.GroupBox()
        Me.lbSEB = New System.Windows.Forms.Label()
        Me.lbDetailed = New System.Windows.Forms.Label()
        Me.btnParametersEdit = New System.Windows.Forms.Button()
        Me.btnParameterContinue = New System.Windows.Forms.Button()
        Me.ckbCallAccounting = New System.Windows.Forms.CheckBox()
        Me.ckbOutboundOn = New System.Windows.Forms.CheckBox()
        Me.cbUnit = New System.Windows.Forms.ComboBox()
        Me.gbUnit = New System.Windows.Forms.GroupBox()
        Me.btnChangeUnit = New System.Windows.Forms.Button()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.gbCallAccounting = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ndL4TBA = New System.Windows.Forms.NumericUpDown()
        Me.ndL3TBA = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ndL4TimeOnHold = New System.Windows.Forms.NumericUpDown()
        Me.ndL3TimeOnHold = New System.Windows.Forms.NumericUpDown()
        Me.cbL4SIPCode = New System.Windows.Forms.ComboBox()
        Me.cbL3SIPCode = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.LbCAL4 = New System.Windows.Forms.Label()
        Me.btnCallAccountingEdit = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnCallAccountingContinue = New System.Windows.Forms.Button()
        Me.ipSend = New IPControlsClass.IPInput()
        Me.lbIPAddress = New System.Windows.Forms.Label()
        Me.lbHelp = New System.Windows.Forms.Label()
        Me.gbProgress.SuspendLayout()
        CType(Me.dgvL4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvL3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFormat.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbCallSetup.SuspendLayout()
        CType(Me.ndLine4Int, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTiming.SuspendLayout()
        CType(Me.ndOutboundStartOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndInboundOffOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndInboundStartOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbParameters.SuspendLayout()
        Me.gbUnit.SuspendLayout()
        Me.gbCallAccounting.SuspendLayout()
        CType(Me.ndL4TBA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndL3TBA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndL4TimeOnHold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndL3TimeOnHold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbProgress
        '
        Me.gbProgress.Controls.Add(Me.btnRawData)
        Me.gbProgress.Controls.Add(Me.dgvL4)
        Me.gbProgress.Controls.Add(Me.dgvL3)
        Me.gbProgress.Controls.Add(Me.dgvL2)
        Me.gbProgress.Controls.Add(Me.dgvL1)
        Me.gbProgress.Controls.Add(Me.lbL4)
        Me.gbProgress.Controls.Add(Me.Label25)
        Me.gbProgress.Controls.Add(Me.Label24)
        Me.gbProgress.Controls.Add(Me.Label23)
        Me.gbProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProgress.Location = New System.Drawing.Point(379, 80)
        Me.gbProgress.Name = "gbProgress"
        Me.gbProgress.Size = New System.Drawing.Size(582, 175)
        Me.gbProgress.TabIndex = 0
        Me.gbProgress.TabStop = False
        Me.gbProgress.Text = "Progress"
        '
        'btnRawData
        '
        Me.btnRawData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawData.Location = New System.Drawing.Point(11, 32)
        Me.btnRawData.Name = "btnRawData"
        Me.btnRawData.Size = New System.Drawing.Size(88, 44)
        Me.btnRawData.TabIndex = 12
        Me.btnRawData.Text = "Show UDP Raw Data"
        Me.btnRawData.UseVisualStyleBackColor = True
        '
        'dgvL4
        '
        Me.dgvL4.AllowUserToAddRows = False
        Me.dgvL4.AllowUserToDeleteRows = False
        Me.dgvL4.AllowUserToResizeColumns = False
        Me.dgvL4.AllowUserToResizeRows = False
        Me.dgvL4.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvL4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvL4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvL4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvL4.ColumnHeadersVisible = False
        Me.dgvL4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.dgvL4.GridColor = System.Drawing.SystemColors.Control
        Me.dgvL4.Location = New System.Drawing.Point(459, 32)
        Me.dgvL4.Name = "dgvL4"
        Me.dgvL4.ReadOnly = True
        Me.dgvL4.RowHeadersVisible = False
        Me.dgvL4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvL4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvL4.Size = New System.Drawing.Size(112, 137)
        Me.dgvL4.TabIndex = 11
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'dgvL3
        '
        Me.dgvL3.AllowUserToAddRows = False
        Me.dgvL3.AllowUserToDeleteRows = False
        Me.dgvL3.AllowUserToResizeColumns = False
        Me.dgvL3.AllowUserToResizeRows = False
        Me.dgvL3.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvL3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvL3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvL3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvL3.ColumnHeadersVisible = False
        Me.dgvL3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.dgvL3.GridColor = System.Drawing.SystemColors.Control
        Me.dgvL3.Location = New System.Drawing.Point(341, 32)
        Me.dgvL3.Name = "dgvL3"
        Me.dgvL3.ReadOnly = True
        Me.dgvL3.RowHeadersVisible = False
        Me.dgvL3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvL3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvL3.Size = New System.Drawing.Size(112, 137)
        Me.dgvL3.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'dgvL2
        '
        Me.dgvL2.AllowUserToAddRows = False
        Me.dgvL2.AllowUserToDeleteRows = False
        Me.dgvL2.AllowUserToResizeColumns = False
        Me.dgvL2.AllowUserToResizeRows = False
        Me.dgvL2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvL2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvL2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvL2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvL2.ColumnHeadersVisible = False
        Me.dgvL2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dgvL2.GridColor = System.Drawing.SystemColors.Control
        Me.dgvL2.Location = New System.Drawing.Point(223, 32)
        Me.dgvL2.Name = "dgvL2"
        Me.dgvL2.ReadOnly = True
        Me.dgvL2.RowHeadersVisible = False
        Me.dgvL2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvL2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvL2.Size = New System.Drawing.Size(112, 137)
        Me.dgvL2.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dgvL1
        '
        Me.dgvL1.AllowUserToAddRows = False
        Me.dgvL1.AllowUserToDeleteRows = False
        Me.dgvL1.AllowUserToResizeColumns = False
        Me.dgvL1.AllowUserToResizeRows = False
        Me.dgvL1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvL1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvL1.ColumnHeadersVisible = False
        Me.dgvL1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem})
        Me.dgvL1.GridColor = System.Drawing.SystemColors.Control
        Me.dgvL1.Location = New System.Drawing.Point(105, 32)
        Me.dgvL1.Name = "dgvL1"
        Me.dgvL1.ReadOnly = True
        Me.dgvL1.RowHeadersVisible = False
        Me.dgvL1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvL1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvL1.Size = New System.Drawing.Size(112, 137)
        Me.dgvL1.TabIndex = 8
        '
        'colItem
        '
        Me.colItem.HeaderText = "Item"
        Me.colItem.Name = "colItem"
        Me.colItem.ReadOnly = True
        '
        'lbL4
        '
        Me.lbL4.AutoSize = True
        Me.lbL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbL4.Location = New System.Drawing.Point(491, 12)
        Me.lbL4.Name = "lbL4"
        Me.lbL4.Size = New System.Drawing.Size(43, 16)
        Me.lbL4.TabIndex = 7
        Me.lbL4.Text = "Line 4"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(374, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 16)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Line 3"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(256, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 16)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Line 2"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(138, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 16)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Line 1"
        '
        'pbLine1
        '
        Me.pbLine1.Location = New System.Drawing.Point(684, 38)
        Me.pbLine1.Name = "pbLine1"
        Me.pbLine1.Size = New System.Drawing.Size(259, 20)
        Me.pbLine1.Step = 1
        Me.pbLine1.TabIndex = 1
        '
        'gbFormat
        '
        Me.gbFormat.Controls.Add(Me.Label27)
        Me.gbFormat.Controls.Add(Me.btnFormatEdit)
        Me.gbFormat.Controls.Add(Me.Panel1)
        Me.gbFormat.Controls.Add(Me.btnFormatContinue)
        Me.gbFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFormat.Location = New System.Drawing.Point(428, 261)
        Me.gbFormat.Name = "gbFormat"
        Me.gbFormat.Size = New System.Drawing.Size(199, 183)
        Me.gbFormat.TabIndex = 1
        Me.gbFormat.TabStop = False
        Me.gbFormat.Text = "Format"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(7, 61)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(186, 78)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = resources.GetString("Label27.Text")
        '
        'btnFormatEdit
        '
        Me.btnFormatEdit.Location = New System.Drawing.Point(127, 154)
        Me.btnFormatEdit.Name = "btnFormatEdit"
        Me.btnFormatEdit.Size = New System.Drawing.Size(66, 23)
        Me.btnFormatEdit.TabIndex = 63
        Me.btnFormatEdit.Text = "Edit"
        Me.btnFormatEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbETSIFormat)
        Me.Panel1.Controls.Add(Me.rbUSAFormat)
        Me.Panel1.Location = New System.Drawing.Point(33, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 25)
        Me.Panel1.TabIndex = 0
        '
        'rbETSIFormat
        '
        Me.rbETSIFormat.AutoSize = True
        Me.rbETSIFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbETSIFormat.Location = New System.Drawing.Point(70, 3)
        Me.rbETSIFormat.Name = "rbETSIFormat"
        Me.rbETSIFormat.Size = New System.Drawing.Size(49, 17)
        Me.rbETSIFormat.TabIndex = 3
        Me.rbETSIFormat.Text = "ETSI"
        Me.rbETSIFormat.UseVisualStyleBackColor = True
        '
        'rbUSAFormat
        '
        Me.rbUSAFormat.AutoSize = True
        Me.rbUSAFormat.Checked = True
        Me.rbUSAFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUSAFormat.Location = New System.Drawing.Point(17, 3)
        Me.rbUSAFormat.Name = "rbUSAFormat"
        Me.rbUSAFormat.Size = New System.Drawing.Size(47, 17)
        Me.rbUSAFormat.TabIndex = 2
        Me.rbUSAFormat.TabStop = True
        Me.rbUSAFormat.Text = "USA"
        Me.rbUSAFormat.UseVisualStyleBackColor = True
        '
        'btnFormatContinue
        '
        Me.btnFormatContinue.Location = New System.Drawing.Point(46, 154)
        Me.btnFormatContinue.Name = "btnFormatContinue"
        Me.btnFormatContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnFormatContinue.TabIndex = 62
        Me.btnFormatContinue.Text = "Continue"
        Me.btnFormatContinue.UseVisualStyleBackColor = True
        '
        'gbCallSetup
        '
        Me.gbCallSetup.Controls.Add(Me.ndLine4Int)
        Me.gbCallSetup.Controls.Add(Me.Label22)
        Me.gbCallSetup.Controls.Add(Me.Label21)
        Me.gbCallSetup.Controls.Add(Me.Label20)
        Me.gbCallSetup.Controls.Add(Me.Label19)
        Me.gbCallSetup.Controls.Add(Me.Label18)
        Me.gbCallSetup.Controls.Add(Me.pbLine4)
        Me.gbCallSetup.Controls.Add(Me.pbLine3)
        Me.gbCallSetup.Controls.Add(Me.pbLine2)
        Me.gbCallSetup.Controls.Add(Me.cbL4Name)
        Me.gbCallSetup.Controls.Add(Me.pbLine1)
        Me.gbCallSetup.Controls.Add(Me.cbL3Name)
        Me.gbCallSetup.Controls.Add(Me.cbL2Name)
        Me.gbCallSetup.Controls.Add(Me.cbL4Num)
        Me.gbCallSetup.Controls.Add(Me.cbL3Num)
        Me.gbCallSetup.Controls.Add(Me.cbL2Num)
        Me.gbCallSetup.Controls.Add(Me.cbL4AU)
        Me.gbCallSetup.Controls.Add(Me.cbL3AU)
        Me.gbCallSetup.Controls.Add(Me.cbL2AU)
        Me.gbCallSetup.Controls.Add(Me.cbL4IO)
        Me.gbCallSetup.Controls.Add(Me.cbL3IO)
        Me.gbCallSetup.Controls.Add(Me.cbL2IO)
        Me.gbCallSetup.Controls.Add(Me.Label17)
        Me.gbCallSetup.Controls.Add(Me.cbL1Name)
        Me.gbCallSetup.Controls.Add(Me.Label16)
        Me.gbCallSetup.Controls.Add(Me.cbL1Num)
        Me.gbCallSetup.Controls.Add(Me.btnL4Send)
        Me.gbCallSetup.Controls.Add(Me.btnL3Send)
        Me.gbCallSetup.Controls.Add(Me.btnL2Send)
        Me.gbCallSetup.Controls.Add(Me.btnL1Send)
        Me.gbCallSetup.Controls.Add(Me.Label5)
        Me.gbCallSetup.Controls.Add(Me.cbL1AU)
        Me.gbCallSetup.Controls.Add(Me.Label7)
        Me.gbCallSetup.Controls.Add(Me.Label10)
        Me.gbCallSetup.Controls.Add(Me.Label2)
        Me.gbCallSetup.Controls.Add(Me.cbL1IO)
        Me.gbCallSetup.Controls.Add(Me.Label1)
        Me.gbCallSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCallSetup.Location = New System.Drawing.Point(12, 450)
        Me.gbCallSetup.Name = "gbCallSetup"
        Me.gbCallSetup.Size = New System.Drawing.Size(949, 163)
        Me.gbCallSetup.TabIndex = 2
        Me.gbCallSetup.TabStop = False
        Me.gbCallSetup.Text = "Call Setup"
        '
        'ndLine4Int
        '
        Me.ndLine4Int.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndLine4Int.Location = New System.Drawing.Point(21, 121)
        Me.ndLine4Int.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ndLine4Int.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.ndLine4Int.Name = "ndLine4Int"
        Me.ndLine4Int.Size = New System.Drawing.Size(47, 20)
        Me.ndLine4Int.TabIndex = 12
        Me.ndLine4Int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndLine4Int.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(572, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Shortcut"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(585, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 16)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "F12"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(585, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 16)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "F11"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(585, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 16)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "F10"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(585, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 16)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "F9"
        '
        'pbLine4
        '
        Me.pbLine4.Location = New System.Drawing.Point(684, 118)
        Me.pbLine4.Name = "pbLine4"
        Me.pbLine4.Size = New System.Drawing.Size(259, 20)
        Me.pbLine4.Step = 1
        Me.pbLine4.TabIndex = 49
        '
        'pbLine3
        '
        Me.pbLine3.Location = New System.Drawing.Point(684, 91)
        Me.pbLine3.Name = "pbLine3"
        Me.pbLine3.Size = New System.Drawing.Size(259, 20)
        Me.pbLine3.Step = 1
        Me.pbLine3.TabIndex = 48
        '
        'pbLine2
        '
        Me.pbLine2.Location = New System.Drawing.Point(684, 64)
        Me.pbLine2.Name = "pbLine2"
        Me.pbLine2.Size = New System.Drawing.Size(259, 20)
        Me.pbLine2.Step = 1
        Me.pbLine2.TabIndex = 47
        '
        'cbL4Name
        '
        Me.cbL4Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL4Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL4Name.FormattingEnabled = True
        Me.cbL4Name.Items.AddRange(New Object() {"Answered", "Unanswered"})
        Me.cbL4Name.Location = New System.Drawing.Point(448, 119)
        Me.cbL4Name.Name = "cbL4Name"
        Me.cbL4Name.Size = New System.Drawing.Size(116, 21)
        Me.cbL4Name.TabIndex = 46
        '
        'cbL3Name
        '
        Me.cbL3Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL3Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL3Name.FormattingEnabled = True
        Me.cbL3Name.Items.AddRange(New Object() {"Answered", "Unanswered"})
        Me.cbL3Name.Location = New System.Drawing.Point(448, 93)
        Me.cbL3Name.Name = "cbL3Name"
        Me.cbL3Name.Size = New System.Drawing.Size(116, 21)
        Me.cbL3Name.TabIndex = 45
        '
        'cbL2Name
        '
        Me.cbL2Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL2Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL2Name.FormattingEnabled = True
        Me.cbL2Name.Items.AddRange(New Object() {"Answered", "Unanswered"})
        Me.cbL2Name.Location = New System.Drawing.Point(448, 66)
        Me.cbL2Name.Name = "cbL2Name"
        Me.cbL2Name.Size = New System.Drawing.Size(116, 21)
        Me.cbL2Name.TabIndex = 44
        '
        'cbL4Num
        '
        Me.cbL4Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL4Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL4Num.FormattingEnabled = True
        Me.cbL4Num.Items.AddRange(New Object() {"706-263-7111", "PRIVATE", "Out-of-Area", "No CallerID"})
        Me.cbL4Num.Location = New System.Drawing.Point(326, 119)
        Me.cbL4Num.Name = "cbL4Num"
        Me.cbL4Num.Size = New System.Drawing.Size(116, 21)
        Me.cbL4Num.TabIndex = 43
        '
        'cbL3Num
        '
        Me.cbL3Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL3Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL3Num.FormattingEnabled = True
        Me.cbL3Num.Items.AddRange(New Object() {"706-263-7111", "PRIVATE", "Out-of-Area", "No CallerID"})
        Me.cbL3Num.Location = New System.Drawing.Point(326, 93)
        Me.cbL3Num.Name = "cbL3Num"
        Me.cbL3Num.Size = New System.Drawing.Size(116, 21)
        Me.cbL3Num.TabIndex = 42
        '
        'cbL2Num
        '
        Me.cbL2Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL2Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL2Num.FormattingEnabled = True
        Me.cbL2Num.Items.AddRange(New Object() {"706-263-7111", "PRIVATE", "Out-of-Area", "No CallerID"})
        Me.cbL2Num.Location = New System.Drawing.Point(326, 66)
        Me.cbL2Num.Name = "cbL2Num"
        Me.cbL2Num.Size = New System.Drawing.Size(116, 21)
        Me.cbL2Num.TabIndex = 41
        '
        'cbL4AU
        '
        Me.cbL4AU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL4AU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL4AU.FormattingEnabled = True
        Me.cbL4AU.Location = New System.Drawing.Point(201, 119)
        Me.cbL4AU.Name = "cbL4AU"
        Me.cbL4AU.Size = New System.Drawing.Size(116, 21)
        Me.cbL4AU.TabIndex = 40
        '
        'cbL3AU
        '
        Me.cbL3AU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL3AU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL3AU.FormattingEnabled = True
        Me.cbL3AU.Location = New System.Drawing.Point(201, 93)
        Me.cbL3AU.Name = "cbL3AU"
        Me.cbL3AU.Size = New System.Drawing.Size(116, 21)
        Me.cbL3AU.TabIndex = 39
        '
        'cbL2AU
        '
        Me.cbL2AU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL2AU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL2AU.FormattingEnabled = True
        Me.cbL2AU.Location = New System.Drawing.Point(201, 66)
        Me.cbL2AU.Name = "cbL2AU"
        Me.cbL2AU.Size = New System.Drawing.Size(116, 21)
        Me.cbL2AU.TabIndex = 38
        '
        'cbL4IO
        '
        Me.cbL4IO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL4IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL4IO.FormattingEnabled = True
        Me.cbL4IO.Location = New System.Drawing.Point(74, 119)
        Me.cbL4IO.Name = "cbL4IO"
        Me.cbL4IO.Size = New System.Drawing.Size(121, 21)
        Me.cbL4IO.TabIndex = 37
        '
        'cbL3IO
        '
        Me.cbL3IO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL3IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL3IO.FormattingEnabled = True
        Me.cbL3IO.Location = New System.Drawing.Point(74, 93)
        Me.cbL3IO.Name = "cbL3IO"
        Me.cbL3IO.Size = New System.Drawing.Size(121, 21)
        Me.cbL3IO.TabIndex = 36
        '
        'cbL2IO
        '
        Me.cbL2IO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL2IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL2IO.FormattingEnabled = True
        Me.cbL2IO.Location = New System.Drawing.Point(74, 66)
        Me.cbL2IO.Name = "cbL2IO"
        Me.cbL2IO.Size = New System.Drawing.Size(121, 21)
        Me.cbL2IO.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(448, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Name"
        '
        'cbL1Name
        '
        Me.cbL1Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL1Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL1Name.FormattingEnabled = True
        Me.cbL1Name.Items.AddRange(New Object() {"Answered", "Unanswered"})
        Me.cbL1Name.Location = New System.Drawing.Point(448, 38)
        Me.cbL1Name.Name = "cbL1Name"
        Me.cbL1Name.Size = New System.Drawing.Size(116, 21)
        Me.cbL1Name.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(326, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Number"
        '
        'cbL1Num
        '
        Me.cbL1Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL1Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL1Num.FormattingEnabled = True
        Me.cbL1Num.Items.AddRange(New Object() {"706-263-7111", "PRIVATE", "Out-of-Area", "No CallerID"})
        Me.cbL1Num.Location = New System.Drawing.Point(326, 38)
        Me.cbL1Num.Name = "cbL1Num"
        Me.cbL1Num.Size = New System.Drawing.Size(116, 21)
        Me.cbL1Num.TabIndex = 31
        '
        'btnL4Send
        '
        Me.btnL4Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL4Send.Location = New System.Drawing.Point(621, 118)
        Me.btnL4Send.Name = "btnL4Send"
        Me.btnL4Send.Size = New System.Drawing.Size(57, 22)
        Me.btnL4Send.TabIndex = 30
        Me.btnL4Send.Text = "Send"
        Me.btnL4Send.UseVisualStyleBackColor = True
        '
        'btnL3Send
        '
        Me.btnL3Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL3Send.Location = New System.Drawing.Point(621, 91)
        Me.btnL3Send.Name = "btnL3Send"
        Me.btnL3Send.Size = New System.Drawing.Size(57, 22)
        Me.btnL3Send.TabIndex = 29
        Me.btnL3Send.Text = "Send"
        Me.btnL3Send.UseVisualStyleBackColor = True
        '
        'btnL2Send
        '
        Me.btnL2Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL2Send.Location = New System.Drawing.Point(621, 64)
        Me.btnL2Send.Name = "btnL2Send"
        Me.btnL2Send.Size = New System.Drawing.Size(57, 22)
        Me.btnL2Send.TabIndex = 28
        Me.btnL2Send.Text = "Send"
        Me.btnL2Send.UseVisualStyleBackColor = True
        '
        'btnL1Send
        '
        Me.btnL1Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL1Send.Location = New System.Drawing.Point(621, 37)
        Me.btnL1Send.Name = "btnL1Send"
        Me.btnL1Send.Size = New System.Drawing.Size(57, 21)
        Me.btnL1Send.TabIndex = 27
        Me.btnL1Send.Text = "Send"
        Me.btnL1Send.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Answered/Unanswered"
        '
        'cbL1AU
        '
        Me.cbL1AU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL1AU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL1AU.FormattingEnabled = True
        Me.cbL1AU.Location = New System.Drawing.Point(201, 38)
        Me.cbL1AU.Name = "cbL1AU"
        Me.cbL1AU.Size = New System.Drawing.Size(116, 21)
        Me.cbL1AU.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Line 3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Line 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inbound/Outbound"
        '
        'cbL1IO
        '
        Me.cbL1IO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL1IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL1IO.FormattingEnabled = True
        Me.cbL1IO.Location = New System.Drawing.Point(74, 38)
        Me.cbL1IO.Name = "cbL1IO"
        Me.cbL1IO.Size = New System.Drawing.Size(121, 21)
        Me.cbL1IO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Line 1"
        '
        'cbDetailed
        '
        Me.cbDetailed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDetailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDetailed.FormattingEnabled = True
        Me.cbDetailed.Items.AddRange(New Object() {"On", "Off"})
        Me.cbDetailed.Location = New System.Drawing.Point(182, 42)
        Me.cbDetailed.Name = "cbDetailed"
        Me.cbDetailed.Size = New System.Drawing.Size(53, 21)
        Me.cbDetailed.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Detailed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start/End/Both"
        '
        'cbSEB
        '
        Me.cbSEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSEB.FormattingEnabled = True
        Me.cbSEB.Items.AddRange(New Object() {"Start", "End", "Both"})
        Me.cbSEB.Location = New System.Drawing.Point(216, 75)
        Me.cbSEB.Name = "cbSEB"
        Me.cbSEB.Size = New System.Drawing.Size(91, 21)
        Me.cbSEB.TabIndex = 2
        '
        'gbTiming
        '
        Me.gbTiming.Controls.Add(Me.btnTimingEdit)
        Me.gbTiming.Controls.Add(Me.btnTimingContinue)
        Me.gbTiming.Controls.Add(Me.Label9)
        Me.gbTiming.Controls.Add(Me.Label15)
        Me.gbTiming.Controls.Add(Me.ndOutboundStartOff)
        Me.gbTiming.Controls.Add(Me.Label13)
        Me.gbTiming.Controls.Add(Me.Label12)
        Me.gbTiming.Controls.Add(Me.ndInboundOffOn)
        Me.gbTiming.Controls.Add(Me.Label11)
        Me.gbTiming.Controls.Add(Me.ndInboundStartOff)
        Me.gbTiming.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTiming.Location = New System.Drawing.Point(12, 261)
        Me.gbTiming.Name = "gbTiming"
        Me.gbTiming.Size = New System.Drawing.Size(410, 183)
        Me.gbTiming.TabIndex = 3
        Me.gbTiming.TabStop = False
        Me.gbTiming.Text = "Timing (Detailed Only)"
        '
        'btnTimingEdit
        '
        Me.btnTimingEdit.Location = New System.Drawing.Point(338, 154)
        Me.btnTimingEdit.Name = "btnTimingEdit"
        Me.btnTimingEdit.Size = New System.Drawing.Size(66, 23)
        Me.btnTimingEdit.TabIndex = 11
        Me.btnTimingEdit.Text = "Edit"
        Me.btnTimingEdit.UseVisualStyleBackColor = True
        '
        'btnTimingContinue
        '
        Me.btnTimingContinue.Location = New System.Drawing.Point(257, 154)
        Me.btnTimingContinue.Name = "btnTimingContinue"
        Me.btnTimingContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnTimingContinue.TabIndex = 10
        Me.btnTimingContinue.Text = "Continue"
        Me.btnTimingContinue.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Outbound Options"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(67, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(303, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "second(s) between Outbound Start and On-hook (call duration)"
        '
        'ndOutboundStartOff
        '
        Me.ndOutboundStartOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndOutboundStartOff.Location = New System.Drawing.Point(14, 120)
        Me.ndOutboundStartOff.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndOutboundStartOff.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndOutboundStartOff.Name = "ndOutboundStartOff"
        Me.ndOutboundStartOff.Size = New System.Drawing.Size(47, 20)
        Me.ndOutboundStartOff.TabIndex = 7
        Me.ndOutboundStartOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndOutboundStartOff.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Inbound Options"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(67, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(272, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "second(s) between Off-hook and On-hook (call duration)"
        '
        'ndInboundOffOn
        '
        Me.ndInboundOffOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndInboundOffOn.Location = New System.Drawing.Point(14, 70)
        Me.ndInboundOffOn.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndInboundOffOn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndInboundOffOn.Name = "ndInboundOffOn"
        Me.ndInboundOffOn.Size = New System.Drawing.Size(47, 20)
        Me.ndInboundOffOn.TabIndex = 2
        Me.ndInboundOffOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndInboundOffOn.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(67, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(327, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "second(s) between Inbound Start and Off-hook (time before answer)"
        '
        'ndInboundStartOff
        '
        Me.ndInboundStartOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndInboundStartOff.Location = New System.Drawing.Point(14, 44)
        Me.ndInboundStartOff.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndInboundStartOff.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndInboundStartOff.Name = "ndInboundStartOff"
        Me.ndInboundStartOff.Size = New System.Drawing.Size(47, 20)
        Me.ndInboundStartOff.TabIndex = 0
        Me.ndInboundStartOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndInboundStartOff.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'gbParameters
        '
        Me.gbParameters.Controls.Add(Me.lbSEB)
        Me.gbParameters.Controls.Add(Me.lbDetailed)
        Me.gbParameters.Controls.Add(Me.btnParametersEdit)
        Me.gbParameters.Controls.Add(Me.btnParameterContinue)
        Me.gbParameters.Controls.Add(Me.ckbCallAccounting)
        Me.gbParameters.Controls.Add(Me.ckbOutboundOn)
        Me.gbParameters.Controls.Add(Me.Label4)
        Me.gbParameters.Controls.Add(Me.cbDetailed)
        Me.gbParameters.Controls.Add(Me.Label3)
        Me.gbParameters.Controls.Add(Me.cbSEB)
        Me.gbParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbParameters.Location = New System.Drawing.Point(12, 80)
        Me.gbParameters.Name = "gbParameters"
        Me.gbParameters.Size = New System.Drawing.Size(361, 175)
        Me.gbParameters.TabIndex = 4
        Me.gbParameters.TabStop = False
        Me.gbParameters.Text = "Parameter Setup"
        '
        'lbSEB
        '
        Me.lbSEB.AutoSize = True
        Me.lbSEB.Cursor = System.Windows.Forms.Cursors.Help
        Me.lbSEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSEB.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbSEB.Location = New System.Drawing.Point(313, 78)
        Me.lbSEB.Name = "lbSEB"
        Me.lbSEB.Size = New System.Drawing.Size(29, 13)
        Me.lbSEB.TabIndex = 11
        Me.lbSEB.Text = "Help"
        '
        'lbDetailed
        '
        Me.lbDetailed.AutoSize = True
        Me.lbDetailed.Cursor = System.Windows.Forms.Cursors.Help
        Me.lbDetailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDetailed.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbDetailed.Location = New System.Drawing.Point(241, 45)
        Me.lbDetailed.Name = "lbDetailed"
        Me.lbDetailed.Size = New System.Drawing.Size(29, 13)
        Me.lbDetailed.TabIndex = 10
        Me.lbDetailed.Text = "Help"
        '
        'btnParametersEdit
        '
        Me.btnParametersEdit.Location = New System.Drawing.Point(289, 124)
        Me.btnParametersEdit.Name = "btnParametersEdit"
        Me.btnParametersEdit.Size = New System.Drawing.Size(66, 23)
        Me.btnParametersEdit.TabIndex = 9
        Me.btnParametersEdit.Text = "Edit"
        Me.btnParametersEdit.UseVisualStyleBackColor = True
        '
        'btnParameterContinue
        '
        Me.btnParameterContinue.Location = New System.Drawing.Point(208, 124)
        Me.btnParameterContinue.Name = "btnParameterContinue"
        Me.btnParameterContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnParameterContinue.TabIndex = 8
        Me.btnParameterContinue.Text = "Continue"
        Me.btnParameterContinue.UseVisualStyleBackColor = True
        '
        'ckbCallAccounting
        '
        Me.ckbCallAccounting.AutoSize = True
        Me.ckbCallAccounting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbCallAccounting.Location = New System.Drawing.Point(16, 77)
        Me.ckbCallAccounting.Name = "ckbCallAccounting"
        Me.ckbCallAccounting.Size = New System.Drawing.Size(100, 17)
        Me.ckbCallAccounting.TabIndex = 7
        Me.ckbCallAccounting.Text = "Call Accounting"
        Me.ckbCallAccounting.UseVisualStyleBackColor = True
        '
        'ckbOutboundOn
        '
        Me.ckbOutboundOn.AutoSize = True
        Me.ckbOutboundOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbOutboundOn.Location = New System.Drawing.Point(16, 44)
        Me.ckbOutboundOn.Name = "ckbOutboundOn"
        Me.ckbOutboundOn.Size = New System.Drawing.Size(90, 17)
        Me.ckbOutboundOn.TabIndex = 0
        Me.ckbOutboundOn.Text = "Outbound On"
        Me.ckbOutboundOn.UseVisualStyleBackColor = True
        '
        'cbUnit
        '
        Me.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnit.FormattingEnabled = True
        Me.cbUnit.Items.AddRange(New Object() {"Select Type of Unit", "Basic", "Deluxe", "Vertex"})
        Me.cbUnit.Location = New System.Drawing.Point(6, 19)
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Size = New System.Drawing.Size(127, 21)
        Me.cbUnit.TabIndex = 0
        '
        'gbUnit
        '
        Me.gbUnit.Controls.Add(Me.btnChangeUnit)
        Me.gbUnit.Controls.Add(Me.cbUnit)
        Me.gbUnit.Location = New System.Drawing.Point(12, 22)
        Me.gbUnit.Name = "gbUnit"
        Me.gbUnit.Size = New System.Drawing.Size(220, 47)
        Me.gbUnit.TabIndex = 8
        Me.gbUnit.TabStop = False
        Me.gbUnit.Text = "Unit Type"
        '
        'btnChangeUnit
        '
        Me.btnChangeUnit.Location = New System.Drawing.Point(139, 19)
        Me.btnChangeUnit.Name = "btnChangeUnit"
        Me.btnChangeUnit.Size = New System.Drawing.Size(75, 21)
        Me.btnChangeUnit.TabIndex = 1
        Me.btnChangeUnit.Text = "Change Unit"
        Me.btnChangeUnit.UseVisualStyleBackColor = True
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(849, 618)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(67, 13)
        Me.lbVersion.TabIndex = 9
        Me.lbVersion.Text = "CallerID.com"
        '
        'gbCallAccounting
        '
        Me.gbCallAccounting.Controls.Add(Me.Label30)
        Me.gbCallAccounting.Controls.Add(Me.Label26)
        Me.gbCallAccounting.Controls.Add(Me.ndL4TBA)
        Me.gbCallAccounting.Controls.Add(Me.ndL3TBA)
        Me.gbCallAccounting.Controls.Add(Me.Label8)
        Me.gbCallAccounting.Controls.Add(Me.ndL4TimeOnHold)
        Me.gbCallAccounting.Controls.Add(Me.ndL3TimeOnHold)
        Me.gbCallAccounting.Controls.Add(Me.cbL4SIPCode)
        Me.gbCallAccounting.Controls.Add(Me.cbL3SIPCode)
        Me.gbCallAccounting.Controls.Add(Me.Label29)
        Me.gbCallAccounting.Controls.Add(Me.LbCAL4)
        Me.gbCallAccounting.Controls.Add(Me.btnCallAccountingEdit)
        Me.gbCallAccounting.Controls.Add(Me.Label28)
        Me.gbCallAccounting.Controls.Add(Me.btnCallAccountingContinue)
        Me.gbCallAccounting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCallAccounting.Location = New System.Drawing.Point(633, 261)
        Me.gbCallAccounting.Name = "gbCallAccounting"
        Me.gbCallAccounting.Size = New System.Drawing.Size(328, 183)
        Me.gbCallAccounting.TabIndex = 10
        Me.gbCallAccounting.TabStop = False
        Me.gbCallAccounting.Text = "Call Accounting (Vertex Only)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 113)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(301, 26)
        Me.Label30.TabIndex = 67
        Me.Label30.Text = "When a call is complete, a call accounting record is generated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with additional d" & _
    "ata pertaining to the phone call."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(61, 33)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Time B4 Answer"
        '
        'ndL4TBA
        '
        Me.ndL4TBA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndL4TBA.Location = New System.Drawing.Point(64, 76)
        Me.ndL4TBA.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndL4TBA.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndL4TBA.Name = "ndL4TBA"
        Me.ndL4TBA.Size = New System.Drawing.Size(47, 20)
        Me.ndL4TBA.TabIndex = 65
        Me.ndL4TBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndL4TBA.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ndL3TBA
        '
        Me.ndL3TBA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndL3TBA.Location = New System.Drawing.Point(64, 49)
        Me.ndL3TBA.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndL3TBA.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndL3TBA.Name = "ndL3TBA"
        Me.ndL3TBA.Size = New System.Drawing.Size(47, 20)
        Me.ndL3TBA.TabIndex = 64
        Me.ndL3TBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndL3TBA.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(151, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Time on Hold"
        '
        'ndL4TimeOnHold
        '
        Me.ndL4TimeOnHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndL4TimeOnHold.Location = New System.Drawing.Point(154, 76)
        Me.ndL4TimeOnHold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndL4TimeOnHold.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndL4TimeOnHold.Name = "ndL4TimeOnHold"
        Me.ndL4TimeOnHold.Size = New System.Drawing.Size(47, 20)
        Me.ndL4TimeOnHold.TabIndex = 62
        Me.ndL4TimeOnHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndL4TimeOnHold.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ndL3TimeOnHold
        '
        Me.ndL3TimeOnHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndL3TimeOnHold.Location = New System.Drawing.Point(154, 49)
        Me.ndL3TimeOnHold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ndL3TimeOnHold.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ndL3TimeOnHold.Name = "ndL3TimeOnHold"
        Me.ndL3TimeOnHold.Size = New System.Drawing.Size(47, 20)
        Me.ndL3TimeOnHold.TabIndex = 12
        Me.ndL3TimeOnHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ndL3TimeOnHold.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cbL4SIPCode
        '
        Me.cbL4SIPCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL4SIPCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL4SIPCode.FormattingEnabled = True
        Me.cbL4SIPCode.Items.AddRange(New Object() {"000", "001", "002", "003", "400", "408", "486", "487"})
        Me.cbL4SIPCode.Location = New System.Drawing.Point(230, 75)
        Me.cbL4SIPCode.Name = "cbL4SIPCode"
        Me.cbL4SIPCode.Size = New System.Drawing.Size(68, 21)
        Me.cbL4SIPCode.TabIndex = 61
        '
        'cbL3SIPCode
        '
        Me.cbL3SIPCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL3SIPCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL3SIPCode.FormattingEnabled = True
        Me.cbL3SIPCode.Items.AddRange(New Object() {"000", "001", "002", "003", "400", "408", "486", "487"})
        Me.cbL3SIPCode.Location = New System.Drawing.Point(230, 48)
        Me.cbL3SIPCode.Name = "cbL3SIPCode"
        Me.cbL3SIPCode.Size = New System.Drawing.Size(68, 21)
        Me.cbL3SIPCode.TabIndex = 60
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(227, 33)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "SIP Code"
        '
        'LbCAL4
        '
        Me.LbCAL4.AutoSize = True
        Me.LbCAL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCAL4.Location = New System.Drawing.Point(22, 78)
        Me.LbCAL4.Name = "LbCAL4"
        Me.LbCAL4.Size = New System.Drawing.Size(36, 13)
        Me.LbCAL4.TabIndex = 58
        Me.LbCAL4.Text = "Line 4"
        '
        'btnCallAccountingEdit
        '
        Me.btnCallAccountingEdit.Location = New System.Drawing.Point(256, 154)
        Me.btnCallAccountingEdit.Name = "btnCallAccountingEdit"
        Me.btnCallAccountingEdit.Size = New System.Drawing.Size(66, 23)
        Me.btnCallAccountingEdit.TabIndex = 13
        Me.btnCallAccountingEdit.Text = "Edit"
        Me.btnCallAccountingEdit.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(22, 51)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 13)
        Me.Label28.TabIndex = 57
        Me.Label28.Text = "Line 3"
        '
        'btnCallAccountingContinue
        '
        Me.btnCallAccountingContinue.Location = New System.Drawing.Point(175, 154)
        Me.btnCallAccountingContinue.Name = "btnCallAccountingContinue"
        Me.btnCallAccountingContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnCallAccountingContinue.TabIndex = 12
        Me.btnCallAccountingContinue.Text = "Continue"
        Me.btnCallAccountingContinue.UseVisualStyleBackColor = True
        '
        'ipSend
        '
        Me.ipSend.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ipSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ipSend.HexIP = "FFFFFFFF"
        Me.ipSend.Location = New System.Drawing.Point(247, 42)
        Me.ipSend.MinimumSize = New System.Drawing.Size(125, 20)
        Me.ipSend.Name = "ipSend"
        Me.ipSend.Size = New System.Drawing.Size(126, 20)
        Me.ipSend.TabIndex = 11
        '
        'lbIPAddress
        '
        Me.lbIPAddress.AutoSize = True
        Me.lbIPAddress.Location = New System.Drawing.Point(247, 26)
        Me.lbIPAddress.Name = "lbIPAddress"
        Me.lbIPAddress.Size = New System.Drawing.Size(102, 13)
        Me.lbIPAddress.TabIndex = 12
        Me.lbIPAddress.Text = "IP Address To Send"
        '
        'lbHelp
        '
        Me.lbHelp.AutoSize = True
        Me.lbHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHelp.Location = New System.Drawing.Point(425, 24)
        Me.lbHelp.Name = "lbHelp"
        Me.lbHelp.Size = New System.Drawing.Size(522, 32)
        Me.lbHelp.TabIndex = 13
        Me.lbHelp.Text = "This tool generates the exact same output as any CallerID.com Ethernet connected " & _
    "unit." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It emulates each of the 3 standard types of units CallerID.com manufactur" & _
    "es."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(973, 640)
        Me.Controls.Add(Me.lbHelp)
        Me.Controls.Add(Me.lbIPAddress)
        Me.Controls.Add(Me.ipSend)
        Me.Controls.Add(Me.gbCallAccounting)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.gbUnit)
        Me.Controls.Add(Me.gbParameters)
        Me.Controls.Add(Me.gbTiming)
        Me.Controls.Add(Me.gbCallSetup)
        Me.Controls.Add(Me.gbFormat)
        Me.Controls.Add(Me.gbProgress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(989, 678)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ethernet Emulator Deluxe"
        Me.gbProgress.ResumeLayout(False)
        Me.gbProgress.PerformLayout()
        CType(Me.dgvL4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvL3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFormat.ResumeLayout(False)
        Me.gbFormat.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbCallSetup.ResumeLayout(False)
        Me.gbCallSetup.PerformLayout()
        CType(Me.ndLine4Int, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTiming.ResumeLayout(False)
        Me.gbTiming.PerformLayout()
        CType(Me.ndOutboundStartOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndInboundOffOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndInboundStartOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbParameters.ResumeLayout(False)
        Me.gbParameters.PerformLayout()
        Me.gbUnit.ResumeLayout(False)
        Me.gbCallAccounting.ResumeLayout(False)
        Me.gbCallAccounting.PerformLayout()
        CType(Me.ndL4TBA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndL3TBA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndL4TimeOnHold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndL3TimeOnHold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbProgress As System.Windows.Forms.GroupBox
    Friend WithEvents gbFormat As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbETSIFormat As System.Windows.Forms.RadioButton
    Friend WithEvents rbUSAFormat As System.Windows.Forms.RadioButton
    Friend WithEvents gbCallSetup As System.Windows.Forms.GroupBox
    Friend WithEvents cbDetailed As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbSEB As System.Windows.Forms.ComboBox
    Friend WithEvents cbL1IO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbLine1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbL1AU As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnL4Send As System.Windows.Forms.Button
    Friend WithEvents btnL3Send As System.Windows.Forms.Button
    Friend WithEvents btnL2Send As System.Windows.Forms.Button
    Friend WithEvents btnL1Send As System.Windows.Forms.Button
    Friend WithEvents gbTiming As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ndOutboundStartOff As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ndInboundOffOn As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ndInboundStartOff As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbParameters As System.Windows.Forms.GroupBox
    Friend WithEvents ckbOutboundOn As System.Windows.Forms.CheckBox
    Friend WithEvents cbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbL1Name As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbL1Num As System.Windows.Forms.ComboBox
    Friend WithEvents ckbCallAccounting As System.Windows.Forms.CheckBox
    Friend WithEvents cbL4IO As System.Windows.Forms.ComboBox
    Friend WithEvents cbL3IO As System.Windows.Forms.ComboBox
    Friend WithEvents cbL2IO As System.Windows.Forms.ComboBox
    Friend WithEvents cbL4AU As System.Windows.Forms.ComboBox
    Friend WithEvents cbL3AU As System.Windows.Forms.ComboBox
    Friend WithEvents cbL2AU As System.Windows.Forms.ComboBox
    Friend WithEvents cbL4Num As System.Windows.Forms.ComboBox
    Friend WithEvents cbL3Num As System.Windows.Forms.ComboBox
    Friend WithEvents cbL2Num As System.Windows.Forms.ComboBox
    Friend WithEvents cbL4Name As System.Windows.Forms.ComboBox
    Friend WithEvents cbL3Name As System.Windows.Forms.ComboBox
    Friend WithEvents cbL2Name As System.Windows.Forms.ComboBox
    Friend WithEvents btnParameterContinue As System.Windows.Forms.Button
    Friend WithEvents gbUnit As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangeUnit As System.Windows.Forms.Button
    Friend WithEvents btnParametersEdit As System.Windows.Forms.Button
    Friend WithEvents btnTimingEdit As System.Windows.Forms.Button
    Friend WithEvents btnTimingContinue As System.Windows.Forms.Button
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents pbLine4 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbLine3 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbLine2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbL4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents gbCallAccounting As System.Windows.Forms.GroupBox
    Friend WithEvents cbL4SIPCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbL3SIPCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents LbCAL4 As System.Windows.Forms.Label
    Friend WithEvents btnCallAccountingEdit As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnCallAccountingContinue As System.Windows.Forms.Button
    Friend WithEvents btnFormatEdit As System.Windows.Forms.Button
    Friend WithEvents btnFormatContinue As System.Windows.Forms.Button
    Friend WithEvents ndLine4Int As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ndL4TimeOnHold As System.Windows.Forms.NumericUpDown
    Friend WithEvents ndL3TimeOnHold As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvL1 As System.Windows.Forms.DataGridView
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvL4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvL3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvL2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ndL4TBA As System.Windows.Forms.NumericUpDown
    Friend WithEvents ndL3TBA As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbSEB As System.Windows.Forms.Label
    Friend WithEvents lbDetailed As System.Windows.Forms.Label
    Friend WithEvents ipSend As IPControlsClass.IPInput
    Friend WithEvents lbIPAddress As System.Windows.Forms.Label
    Friend WithEvents lbHelp As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnRawData As System.Windows.Forms.Button

End Class
