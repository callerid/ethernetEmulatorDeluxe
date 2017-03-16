<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUDPRawTraffic
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvUDP = New System.Windows.Forms.DataGridView()
        Me.colLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pt8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pt10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pt12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbSymbol = New System.Windows.Forms.Label()
        CType(Me.dgvUDP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUDP
        '
        Me.dgvUDP.AllowUserToAddRows = False
        Me.dgvUDP.AllowUserToDeleteRows = False
        Me.dgvUDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUDP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLine, Me.colData})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUDP.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUDP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUDP.Location = New System.Drawing.Point(0, 24)
        Me.dgvUDP.Name = "dgvUDP"
        Me.dgvUDP.ReadOnly = True
        Me.dgvUDP.RowHeadersVisible = False
        Me.dgvUDP.Size = New System.Drawing.Size(964, 325)
        Me.dgvUDP.TabIndex = 0
        '
        'colLine
        '
        Me.colLine.HeaderText = "Ln"
        Me.colLine.Name = "colLine"
        Me.colLine.ReadOnly = True
        Me.colLine.Width = 30
        '
        'colData
        '
        Me.colData.HeaderText = "Data"
        Me.colData.Name = "colData"
        Me.colData.ReadOnly = True
        Me.colData.Width = 1600
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pt8, Me.pt10, Me.pt12})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'pt8
        '
        Me.pt8.Checked = True
        Me.pt8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pt8.Name = "pt8"
        Me.pt8.Size = New System.Drawing.Size(152, 22)
        Me.pt8.Text = "8pt"
        '
        'pt10
        '
        Me.pt10.Name = "pt10"
        Me.pt10.Size = New System.Drawing.Size(152, 22)
        Me.pt10.Text = "10pt"
        '
        'pt12
        '
        Me.pt12.Name = "pt12"
        Me.pt12.Size = New System.Drawing.Size(152, 22)
        Me.pt12.Text = "12pt"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'lbSymbol
        '
        Me.lbSymbol.AutoSize = True
        Me.lbSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSymbol.Location = New System.Drawing.Point(128, 8)
        Me.lbSymbol.Name = "lbSymbol"
        Me.lbSymbol.Size = New System.Drawing.Size(16, 13)
        Me.lbSymbol.TabIndex = 2
        Me.lbSymbol.Text = "..."
        '
        'frmUDPRawTraffic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 349)
        Me.Controls.Add(Me.lbSymbol)
        Me.Controls.Add(Me.dgvUDP)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUDPRawTraffic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAW UDP Traffic"
        CType(Me.dgvUDP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUDP As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbSymbol As System.Windows.Forms.Label
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pt8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pt10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pt12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colData As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
