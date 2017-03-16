Public Class frmUDPRawTraffic

   Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        dgvUDP.Rows.Clear()
    End Sub

    Private Sub frmUDPRawTraffic_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If

    End Sub

    Private Sub frmUDPRawTraffic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbSymbol.Text = Chr(149) + " Denotes space (20h) in UDP string."
        changeFontSize(8)
    End Sub

    Private Sub pt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pt8.Click
        changeFontSize(8)
    End Sub

    Private Sub pt10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pt10.Click
        changeFontSize(10)
    End Sub

    Private Sub pt12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pt12.Click
        changeFontSize(12)
    End Sub

    Public Sub changeFontSize(ByVal size As Integer)
      
        dgvUDP.Font = New Font("Courier New", size, FontStyle.Bold)

        Select Case size
            Case 8
                dgvUDP.Columns(1).Width = 1600
                pt8.Checked = True
                pt10.Checked = False
                pt12.Checked = False
            Case 10
                dgvUDP.Columns(1).Width = 1820
                pt8.Checked = False
                pt10.Checked = True
                pt12.Checked = False
            Case 12
                dgvUDP.Columns(1).Width = 2300
                pt8.Checked = False
                pt10.Checked = False
                pt12.Checked = True
        End Select
        
    End Sub
End Class