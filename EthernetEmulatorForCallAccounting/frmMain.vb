Public Class frmMain

    '----------------------------

#Region "Setup"

    ' Settings setup
    Public cbLIO(4) As ComboBox
    Public cbLAU(4) As ComboBox
    Public cbLNum(4) As ComboBox
    Public cbLName(4) As ComboBox

    ' Progress bars and data grid views
    Public pbLine(4) As ProgressBar
    Public dgvL(4) As DataGridView

    ' Thread setup
    Public WithEvents smartSendLine1 As SmartSend
    Public WithEvents smartSendLine2 As SmartSend
    Public WithEvents smartSendLine3 As SmartSend
    Public WithEvents smartSendLine4 As SmartSend
    Public sendThread(4) As System.Threading.Thread
    '--> Delegates
    Private Delegate Sub updateProgressBarsCallback(ByVal myObject As Object)
    Private Delegate Sub updateProgressDGVCallback(ByVal line As Integer, ByVal currentItem As String, ByVal clear As Boolean, ByVal itemColor As Color)
    Private Delegate Sub updateTrafficDGVCallback(ByVal line As Integer, ByVal text As String, ByVal thisColor As Color)

    ' Keyboard hook
    Private WithEvents kbhook As New KeyboardHook

    ' Tool tips for help
    Private tt As ToolTip = New ToolTip()

#End Region

    '----------------------------

#Region "Form Events"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Open traffic window for logging
        frmUDPRawTraffic.Show()
        frmUDPRawTraffic.Hide()
        
        ' Define version number
        lbVersion.Text = "CallerID.com - V " + Application.ProductVersion.ToString.Substring(0, 3)

        ' Disable all fields except type of unit
        toggleFields(Me, False)
        toggleGroup(gbUnit, True)
        cbUnit.SelectedIndex = 0
        highlightObject(gbUnit, True)

        ' Associate arrays to objects
        ' --> Inbound/outbound combo boxes
        cbLIO(1) = cbL1IO
        cbLIO(2) = cbL2IO
        cbLIO(3) = cbL3IO
        cbLIO(4) = cbL4IO
        ' --> Answered/Unanswered combo boxes
        cbLAU(1) = cbL1AU
        cbLAU(2) = cbL2AU
        cbLAU(3) = cbL3AU
        cbLAU(4) = cbL4AU
        ' --> Number combo boxes
        cbLNum(1) = cbL1Num
        cbLNum(2) = cbL2Num
        cbLNum(3) = cbL3Num
        cbLNum(4) = cbL4Num
        ' --> Name combo boxes
        cbLName(1) = cbL1Name
        cbLName(2) = cbL2Name
        cbLName(3) = cbL3Name
        cbLName(4) = cbL4Name
        '--> Progress bars
        pbLine(1) = pbLine1
        pbLine(2) = pbLine2
        pbLine(3) = pbLine3
        pbLine(4) = pbLine4
        '--> Data grid views
        dgvL(1) = dgvL1
        dgvL(2) = dgvL2
        dgvL(3) = dgvL3
        dgvL(4) = dgvL4
        '-----------------------------

        ' Select default SIP codes
        cbL3SIPCode.SelectedIndex = 0
        cbL4SIPCode.SelectedIndex = 0

        ' Select default values for Detail and Start/End/Both
        cbDetailed.SelectedItem = "Off"
        cbSEB.SelectedItem = "Both"

        ' Populate name and number combo boxes
        ' and select default values
        populateName()
        populateNumber()
        populateNameNumberDefaults()

        ' Set IP for sending
        Dim ipHEntry As Net.IPHostEntry
        Dim ipAdd() As Net.IPAddress
        Dim localhost As String
        localhost = Net.Dns.GetHostName()
        ipHEntry = Net.Dns.GetHostEntry(localhost)
        ipAdd = ipHEntry.AddressList
        For i = 0 To ipAdd.GetUpperBound(0)
            If InStr(ipAdd(i).ToString, ".") Then
                ipSend.Text = ipAdd(i).ToString
                Exit For
            End If
        Next

        ' Show version
        Me.Text = "Ethernet Emulator Deluxe - Version " + EthernetEmulatorForCallAccounting.My.Application.Info.Version.ToString

    End Sub

#End Region

    '----------------------------

#Region "Population"

    Private Sub populateInboundOutbound(ByVal outboundOn As Boolean)

        For i = 1 To 4

            ' Clear items
            cbLIO(i).Items.Clear()

            ' Add correct items
            If outboundOn = True And Not (cbUnit.SelectedItem.ToString = "Basic") Then
                cbLIO(i).Items.Add("Inbound")
                cbLIO(i).Items.Add("Outbound")
            Else
                cbLIO(i).Items.Add("Inbound")
            End If
            cbLIO(i).SelectedIndex = 0

        Next

    End Sub

    Private Sub populateAnsweredUnanswered()

        For i = 1 To 4

            ' Clear items
            cbLAU(i).Items.Clear()

            ' Add correct items
            cbLAU(i).Items.Add("Answered")
            cbLAU(i).Items.Add("Unanswered")
            cbLAU(i).SelectedIndex = 0

            If cbDetailed.SelectedItem = "Off" Then
                cbLAU(i).Enabled = False
            End If
        Next

    End Sub

    Private Sub populateNumber()

        For i = 1 To 4

            ' Clear items
            cbLNum(i).Items.Clear()

            ' Add correct items
            cbLNum(i).Items.Add("800-240-4637   ")
            cbLNum(i).Items.Add("770-263-7111   ")
            cbLNum(i).Items.Add("770-263-7278   ")
            cbLNum(i).Items.Add("OUT-OF-AREA    ")
            cbLNum(i).Items.Add("PRIVATE        ")
            cbLNum(i).Items.Add("No-CallerID    ")

        Next

    End Sub

    Private Sub populateName()

        For i = 1 To 4

            ' Clear items
            cbLName(i).Items.Clear()

            ' Add correct items
            cbLName(i).Items.Add("CallerID.com   ")
            cbLName(i).Items.Add("Atlanta, GA    ")
            cbLName(i).Items.Add("Smith, John    ")
            cbLName(i).Items.Add("OUT-OF-AREA    ")
            cbLName(i).Items.Add("PRIVATE        ")
            cbLName(i).Items.Add("               ")

        Next

    End Sub

    Private Sub populateNameNumberDefaults()

        cbLName(1).SelectedIndex = 0
        cbLNum(1).SelectedIndex = 0

        cbLName(2).SelectedIndex = 3
        cbLNum(2).SelectedIndex = 1

        cbLName(3).SelectedIndex = 4
        cbLNum(3).SelectedIndex = 3

        cbLName(4).SelectedIndex = 5
        cbLNum(4).SelectedIndex = 5

    End Sub

#End Region

    '----------------------------

#Region "Custom Subs"

    Public Sub updateTrafficDGV(ByVal line As Integer, ByVal text As String, ByVal thisColor As Color) Handles smartSendLine1.updateTraffic, smartSendLine2.updateTraffic, smartSendLine3.updateTraffic, smartSendLine4.updateTraffic

        If Me.InvokeRequired Then
            Dim d As New updateTrafficDGVCallback(AddressOf updateTrafficDGV)
            Me.Invoke(d, New Object() {line, text, thisColor})
        Else

            ' Replace all spaces
            text = text.Replace(" ", Chr(149))

            ' Add space every other character
            Dim newText As String = ""
            For i = 0 To text.Length - 1
                newText += text(i) + " "
            Next

            frmUDPRawTraffic.dgvUDP.Rows.Add()
            frmUDPRawTraffic.dgvUDP.Rows(frmUDPRawTraffic.dgvUDP.Rows.Count - 1).Cells(0).Value = line.ToString
            frmUDPRawTraffic.dgvUDP.Rows(frmUDPRawTraffic.dgvUDP.Rows.Count - 1).Cells(0).Style.ForeColor = thisColor
            frmUDPRawTraffic.dgvUDP.Rows(frmUDPRawTraffic.dgvUDP.Rows.Count - 1).Cells(1).Value = newText
            frmUDPRawTraffic.dgvUDP.Rows(frmUDPRawTraffic.dgvUDP.Rows.Count - 1).Cells(1).Style.ForeColor = thisColor
            frmUDPRawTraffic.dgvUDP.Rows(frmUDPRawTraffic.dgvUDP.Rows.Count - 1).Height = 35

        End If
    End Sub

    Private Sub highlightObject(ByVal thisObj As Object, ByVal highlight As Boolean)

        If highlight = True Then
            thisObj.BackColor = Color.LightYellow
        Else
            thisObj.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub toggleGroup(ByVal thisGroup As GroupBox, ByVal enabled As Boolean)

        For Each ctrl In thisGroup.Controls

            If enabled = True Then
                ctrl.Enabled = True
            Else
                ctrl.Enabled = False
            End If

        Next

    End Sub

    Public Sub updateProgressBars(ByVal myObject As Object) Handles smartSendLine1.updateProgressBars, smartSendLine2.updateProgressBars, smartSendLine3.updateProgressBars, smartSendLine4.updateProgressBars

        If Me.InvokeRequired Then
            Dim d As New updateProgressBarsCallback(AddressOf updateProgressBars)
            Me.Invoke(d, New Object() {myObject})
        Else

            Dim line As Integer = myObject.line
            If line > 4 Then line = 4

            ' Look at each client and if they are active update their progress bars
            If myObject IsNot Nothing Then
                pbLine(line).Maximum = myObject.myProgressBarMax
                If myObject.myProgressBarMax + 1 > myObject.myProgressBarValue Then
                    pbLine(line).Value = myObject.myProgressBarValue
                End If
            End If

            ' Enable/disable buttons for sending depending on status of sending process
            If myObject.inProgress = False Then
                Select Case line
                    Case 1
                        btnL1Send.Enabled = True
                    Case 2
                        btnL2Send.Enabled = True
                    Case 3
                        btnL3Send.Enabled = True
                    Case 4
                        btnL4Send.Enabled = True
                    Case Else
                        btnL4Send.Enabled = True
                End Select
            Else
                Select Case line
                    Case 1
                        btnL1Send.Enabled = False
                    Case 2
                        btnL2Send.Enabled = False
                    Case 3
                        btnL3Send.Enabled = False
                    Case 4
                        btnL4Send.Enabled = False
                    Case Else
                        btnL4Send.Enabled = False
                End Select
            End If

        End If

    End Sub

    Public Sub updateProgressDGV(ByVal line As Integer, ByVal currentItem As String, ByVal clear As Boolean, ByVal itemColor As Color) Handles smartSendLine1.updateProgressDGV, smartSendLine2.updateProgressDGV, smartSendLine3.updateProgressDGV, smartSendLine4.updateProgressDGV

        If Me.InvokeRequired Then
            Dim d As New updateProgressDGVCallback(AddressOf updateProgressDGV)
            Me.Invoke(d, New Object() {line, currentItem, clear, itemColor})
        Else

            ' Limit line count
            If line > 4 Then line = 4

            ' Update line progress 
            If clear = True Then
                dgvL(line).Rows.Clear()
            End If

            ' Add item to data grid view
            dgvL(line).Rows.Add()
            dgvL(line).Rows.Item(dgvL(line).RowCount - 1).Cells(0).Value = currentItem
            dgvL(line).Rows.Item(dgvL(line).RowCount - 1).Cells(0).Style.ForeColor = itemColor
            dgvL(line).Rows.Item(dgvL(line).RowCount - 1).Cells(0).Style.BackColor = Color.FromKnownColor(KnownColor.Control)
            dgvL(line).CurrentCell = Nothing

        End If

    End Sub

    Private Sub kbhook_event(ByVal Key As Keys) Handles kbhook.KeyDown

        ' Catch shortcuts and click buttons for correct line
        If Key = Keys.F9 Then
            btnL1Send_Click(btnL1Send, EventArgs.Empty)
        ElseIf Key = Keys.F10 Then
            btnL2Send.PerformClick()
        ElseIf Key = Keys.F11 Then
            btnL3Send.PerformClick()
        ElseIf Key = Keys.F12 Then
            btnL4Send.PerformClick()
        End If

    End Sub

#End Region

    '----------------------------

#Region "Control Events"

    Private Sub btnRawData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawData.Click

        frmUDPRawTraffic.Show()
        frmUDPRawTraffic.Focus()

    End Sub

    Private Sub lbDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDetailed.Click
        MsgBox("Deluxe units are capable of sending detailed real-time phone events:" + vbCrLf + "Ring, On Hook, and Off-Hook.", vbOKOnly, "Help")
    End Sub

    Private Sub lbSEB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSEB.Click
        MsgBox("Deluxe and Vertex units are capable of sending Start records, End records, or both." + vbCrLf + "Start records are sent when the Caller ID signal is received." + vbCrLf + "End Records are sent when the phone call is complete.", vbOKOnly, "Help")
    End Sub

    Private Sub ipSend_ipTextChanged() Handles ipSend.ipTextChanged
        boxIP = ipSend.Text
    End Sub

    Private Sub ndLine4Int_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndLine4Int.ValueChanged

        ' Just keep display up to date
        lbL4.Text = "Line " + ndLine4Int.Value.ToString
        LbCAL4.Text = "Line " + ndLine4Int.Value.ToString

    End Sub

    Private Sub btnCallAccountingEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallAccountingEdit.Click

        ' Unhighlight all groups
        For Each ctrl In Me.Controls
            highlightObject(ctrl, False)
        Next
        highlightObject(gbCallAccounting, True)

        ' Disable all and enable call accounting
        toggleGroup(gbCallSetup, False)
        toggleGroup(gbTiming, False)

        ' If detailed enabled enable edit of timing
        If cbDetailed.SelectedItem = "On" Then
            btnTimingEdit.Enabled = True
        Else
            btnTimingEdit.Enabled = False
        End If

        toggleGroup(gbCallAccounting, True)
        btnCallAccountingEdit.Enabled = False
        toggleGroup(gbFormat, False)

        ' Enable format if needed
        If cbUnit.SelectedItem = "Vertex" Then
            btnFormatEdit.Enabled = False
        Else
            btnFormatEdit.Enabled = True
        End If

    End Sub

    Private Sub btnTimingEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimingEdit.Click

        ' Unhighlight all groups
        For Each ctrl In Me.Controls
            highlightObject(ctrl, False)
        Next
        highlightObject(gbTiming, True)

        ' Disable all and enable timing
        toggleGroup(gbCallSetup, False)
        toggleGroup(gbCallAccounting, False)
        toggleGroup(gbFormat, False)
        toggleGroup(gbTiming, True)

    End Sub

    Private Sub btnTimingContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimingContinue.Click


        If cbUnit.SelectedItem = "Vertex" Then

            ' Skip formatting
            If ckbCallAccounting.Checked = True Then

                ' Unhighlight format
                highlightObject(gbTiming, False)

                ' Enable edit button, disable continue button
                toggleGroup(gbTiming, False)
                btnTimingEdit.Enabled = True

                ' Enable call accounting group
                toggleGroup(gbCallAccounting, True)
                btnCallAccountingEdit.Enabled = False

                ' Switch to call accounting group
                highlightObject(gbCallAccounting, True)

            Else

                ' Unhighlight format
                highlightObject(gbTiming, False)

                ' Enable edit button, disable continue button
                toggleGroup(gbTiming, False)
                btnTimingEdit.Enabled = True

                ' Enable call setup group
                toggleGroup(gbCallSetup, True)

                ' Switch to call setup group
                highlightObject(gbCallSetup, True)
                
            End If
            
        Else

            ' Unhighlight timing
            highlightObject(gbTiming, False)

            ' Enable edit button, disable continue button
            toggleGroup(gbTiming, False)
            btnTimingEdit.Enabled = True

            ' Enable format group
            toggleGroup(gbFormat, True)
            btnFormatEdit.Enabled = False

            ' Switch to format group
            highlightObject(gbFormat, True)
            
        End If
        
    End Sub

    Private Sub btnParametersEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParametersEdit.Click

        ' Unhighlight all groups
        For Each ctrl In Me.Controls
            highlightObject(ctrl, False)
        Next
        highlightObject(gbParameters, True)

        ' Disable all and enable parameters
        toggleGroup(gbTiming, False)
        toggleGroup(gbCallSetup, False)
        toggleGroup(gbFormat, False)
        toggleGroup(gbCallAccounting, False)
        toggleGroup(gbParameters, True)
        btnParametersEdit.Enabled = False

        If cbUnit.SelectedItem.ToString = "Vertex" Then
            ckbCallAccounting.Enabled = True
        Else
            ckbCallAccounting.Enabled = False
        End If
        
    End Sub

    Private Sub btnParameterContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParameterContinue.Click

        If cbDetailed.SelectedItem.ToString = "On" Then

            ' Unhighlight parameterrs
            highlightObject(gbParameters, False)

            ' Enable edit button, disable continue button
            toggleGroup(gbParameters, False)
            btnParametersEdit.Enabled = True

            ' Enable timing group
            toggleGroup(gbTiming, True)

            ' Switch to timing group
            highlightObject(gbTiming, True)
            btnTimingEdit.Enabled = False

            ' Select defaults
            populateNameNumberDefaults()

        Else

            ' If Unit is Vertex skip formatting
            If cbUnit.SelectedItem = "Vertex" Then

                ' Unhighlight parameterrs
                highlightObject(gbParameters, False)

                ' Enable edit button, disable continue button
                toggleGroup(gbParameters, False)
                btnParametersEdit.Enabled = True

                If ckbCallAccounting.Checked = True Then

                    ' Enable call accounting group
                    toggleGroup(gbCallAccounting, True)
                    btnCallAccountingEdit.Enabled = False

                    ' Switch to call accounting group
                    highlightObject(gbCallAccounting, True)

                Else

                    ' Enable call setup group
                    toggleGroup(gbCallSetup, True)

                    ' Switch to call setup group
                    highlightObject(gbCallSetup, True)

                End If

                

            Else

                ' Unhighlight parameterrs
                highlightObject(gbParameters, False)

                ' Enable edit button, disable continue button
                toggleGroup(gbParameters, False)
                btnParametersEdit.Enabled = True

                ' Enable call setup group
                toggleGroup(gbFormat, True)
                btnFormatEdit.Enabled = False

                ' Switch to timing group
                highlightObject(gbFormat, True)

            End If

        End If

        ' Populate combo boxes
        If cbDetailed.SelectedItem.ToString = "On" Then
            populateAnsweredUnanswered()
        End If
        populateInboundOutbound(ckbOutboundOn.Checked)
        
    End Sub

    Private Sub btnChangeUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeUnit.Click

        toggleGroup(gbUnit, True)
        cbUnit.SelectedIndex = 0

        ' Unhighligh all groups
        For Each ctrl In Me.Controls
            highlightObject(ctrl, False)
        Next
        highlightObject(gbUnit, True)

    End Sub

    Private Sub cbUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnit.SelectedIndexChanged

        Select Case cbUnit.SelectedItem.ToString

            Case "Select Type of Unit"

                ' Disable all
                toggleFields(Me, False)
                toggleGroup(gbUnit, True)
                cbUnit.SelectedIndex = 0
                highlightObject(gbUnit, True)

            Case "Basic"

                ' Disable changing unit
                cbUnit.Enabled = False

                ' Un-highlight unit type selection
                highlightObject(gbUnit, False)

                ' Enable certain parameters
                ckbOutboundOn.Checked = False
                ckbOutboundOn.Enabled = False
                ckbCallAccounting.Checked = False
                ckbCallAccounting.Enabled = False
                cbDetailed.SelectedItem = "Off"
                cbDetailed.Enabled = False
                cbSEB.SelectedItem = "Start"
                cbSEB.Enabled = False
                btnChangeUnit.Enabled = True

                ' Enable Call setup group box
                toggleGroup(gbCallSetup, True)
                toggleGroup(gbProgress, True)

                ' Populate call setup
                populateInboundOutbound(False)
                populateAnsweredUnanswered()

                ' Highlight call setup
                highlightObject(gbCallSetup, True)

            Case "Deluxe"

                ' Disable changing unit
                cbUnit.Enabled = False

                ' Un-highlight unit type selection
                highlightObject(gbUnit, False)

                ' Enable parameters
                toggleGroup(gbParameters, True)
                cbDetailed.SelectedItem = "Off"
                cbSEB.SelectedItem = "Both"
                ckbCallAccounting.Checked = False
                ckbCallAccounting.Enabled = False
                ckbOutboundOn.Enabled = True
                ckbOutboundOn.Checked = True

                ' Highlight group
                highlightObject(gbParameters, True)
                btnParametersEdit.Enabled = False

                ' Populate answered
                populateAnsweredUnanswered()
                
            Case "Vertex"

                ' Disable changing unit
                cbUnit.Enabled = False

                ' Un-highlight unit type selection
                highlightObject(gbUnit, False)

                ' Enable parameters
                toggleGroup(gbParameters, True)
                cbDetailed.SelectedItem = "Off"
                cbSEB.SelectedItem = "Both"
                ckbOutboundOn.Enabled = True
                ckbOutboundOn.Checked = True

                ' Highlight group
                highlightObject(gbParameters, True)
                btnParametersEdit.Enabled = False

                ' Populate answered
                populateAnsweredUnanswered()

        End Select

    End Sub

    Private Sub btnFormatContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormatContinue.Click

        If ckbCallAccounting.Checked = True Then

            ' Unhighlight format
            highlightObject(gbFormat, False)

            ' Enable edit button, disable continue button
            toggleGroup(gbFormat, False)
            btnFormatEdit.Enabled = True

            ' Enable call accounting group
            toggleGroup(gbCallAccounting, True)
            btnCallAccountingEdit.Enabled = False

            ' Switch to call accounting group
            highlightObject(gbCallAccounting, True)

        Else

            ' Unhighlight format
            highlightObject(gbFormat, False)

            ' Enable edit button, disable continue button
            toggleGroup(gbFormat, False)
            btnFormatEdit.Enabled = True

            ' Enable call setup group
            toggleGroup(gbCallSetup, True)

            ' Switch to call setup group
            highlightObject(gbCallSetup, True)

        End If
        
    End Sub

    Private Sub btnFormatEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormatEdit.Click

        ' Unhighlight all groups
        For Each ctrl In Me.Controls
            highlightObject(ctrl, False)
        Next
        highlightObject(gbFormat, True)

        ' Disable all and enable format
        toggleGroup(gbCallSetup, False)
        toggleGroup(gbTiming, False)
        toggleGroup(gbParameters, False)
        btnParametersEdit.Enabled = True
        toggleGroup(gbCallAccounting, False)
        If cbDetailed.SelectedItem = "On" Then
            btnTimingEdit.Enabled = True
        Else
            btnTimingEdit.Enabled = False
        End If

        toggleGroup(gbFormat, True)
        btnFormatEdit.Enabled = False

    End Sub

    Private Sub btnCallAccountingContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallAccountingContinue.Click

        ' Unhighlight call accounting
        highlightObject(gbCallAccounting, False)

        ' Enable edit button, disable continue button
        toggleGroup(gbCallAccounting, False)
        btnCallAccountingEdit.Enabled = True

        ' Enable call setup group
        toggleGroup(gbCallSetup, True)

        ' Switch to call setup group
        highlightObject(gbCallSetup, True)

        ' Handle answered/unanswered combo box
        For i = 1 To 4
            cbLAU(i).Items.Clear()
            If cbDetailed.SelectedItem.ToString = "Off" Then
                cbLAU(i).Enabled = False
            Else
                cbLAU(i).Enabled = True
            End If
        Next
        populateAnsweredUnanswered()

    End Sub

#End Region

    '----------------------------

#Region "Send Buttons"

    Public Sub btnL1Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL1Send.Click

        ' Create new SmartSend
        '--> Format
        Dim myFormat As String = ""
        If rbUSAFormat.Checked = True Then myFormat = "USA"
        If rbETSIFormat.Checked = True Then myFormat = "ETSI"
        
        '--> Create SmartSend record
        If cbL1AU.SelectedItem IsNot Nothing Then
            smartSendLine1 = New SmartSend("1", myFormat, cbL1IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL1Num.SelectedItem.ToString, cbL1Name.SelectedItem.ToString, cbL1AU.SelectedItem.ToString, cbUnit.SelectedItem.ToString)
        Else
            smartSendLine1 = New SmartSend("1", myFormat, cbL1IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL1Num.SelectedItem.ToString, cbL1Name.SelectedItem.ToString, "none", cbUnit.SelectedItem.ToString)
        End If
        
        '--> Timing
        smartSendLine1.timeInboundOffOn = ndInboundOffOn.Value.ToString
        smartSendLine1.timeInboundStartOff = ndInboundStartOff.Value.ToString
        smartSendLine1.timeOutboundStartOff = ndOutboundStartOff.Value.ToString

        '--> Thread setup
        sendThread(1) = New System.Threading.Thread(AddressOf smartSendLine1.send)
        sendThread(1).IsBackground = True
        sendThread(1).Start()

        ' Disable button/renable after completion
        btnL1Send.Enabled = False

    End Sub

    Private Sub btnL2Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL2Send.Click

        ' Create new SmartSend
        '--> Format
        Dim myFormat As String = ""
        If rbUSAFormat.Checked = True Then myFormat = "USA"
        If rbETSIFormat.Checked = True Then myFormat = "ETSI"

        '--> Create SmartSend record
        If cbL2AU.SelectedItem IsNot Nothing Then
            smartSendLine2 = New SmartSend("2", myFormat, cbL2IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL2Num.SelectedItem.ToString, cbL2Name.SelectedItem.ToString, cbL2AU.SelectedItem.ToString, cbUnit.SelectedItem.ToString)
        Else
            smartSendLine2 = New SmartSend("2", myFormat, cbL2IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL2Num.SelectedItem.ToString, cbL2Name.SelectedItem.ToString, "none", cbUnit.SelectedItem.ToString)
        End If

        '--> Timing
        smartSendLine2.timeInboundOffOn = ndInboundOffOn.Value.ToString
        smartSendLine2.timeInboundStartOff = ndInboundStartOff.Value.ToString
        smartSendLine2.timeOutboundStartOff = ndOutboundStartOff.Value.ToString

        '--> Thread setup
        sendThread(2) = New System.Threading.Thread(AddressOf smartSendLine2.send)
        sendThread(2).IsBackground = True
        sendThread(2).Start()

        ' Disable button/renable after completion
        btnL2Send.Enabled = False

    End Sub

    Private Sub btnL3Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL3Send.Click

        ' Create new SmartSend
        '--> Format
        Dim myFormat As String = ""
        If rbUSAFormat.Checked = True Then myFormat = "USA"
        If rbETSIFormat.Checked = True Then myFormat = "ETSI"

        '--> Create SmartSend record
        If cbL3AU.SelectedItem IsNot Nothing Then
            smartSendLine3 = New SmartSend("3", myFormat, cbL3IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL3Num.SelectedItem.ToString, cbL3Name.SelectedItem.ToString, cbL3AU.SelectedItem.ToString, cbUnit.SelectedItem.ToString)
        Else
            smartSendLine3 = New SmartSend("3", myFormat, cbL3IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL3Num.SelectedItem.ToString, cbL3Name.SelectedItem.ToString, "none", cbUnit.SelectedItem.ToString)
        End If

        '--> Special Call Accounting possibility
        smartSendLine3.caTimeB4Answer = ndL3TBA.Value.ToString
        smartSendLine3.caTimeOnHold = ndL3TimeOnHold.Value.ToString
        smartSendLine3.sipCode = cbL3SIPCode.SelectedItem.ToString
        '--> Timing
        smartSendLine3.timeInboundOffOn = ndInboundOffOn.Value.ToString
        smartSendLine3.timeInboundStartOff = ndInboundStartOff.Value.ToString
        smartSendLine3.timeOutboundStartOff = ndOutboundStartOff.Value.ToString
        '--> Thread setup
        sendThread(3) = New System.Threading.Thread(AddressOf smartSendLine3.send)
        sendThread(3).IsBackground = True
        sendThread(3).Start()

        ' Disable button/renable after completion
        btnL3Send.Enabled = False

    End Sub

    Private Sub btnL4Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL4Send.Click

        ' Create new SmartSend
        '--> Format
        Dim myFormat As String = ""
        If rbUSAFormat.Checked = True Then myFormat = "USA"
        If rbETSIFormat.Checked = True Then myFormat = "ETSI"
        '--> Create SmartSend record
        If cbL4AU.SelectedItem IsNot Nothing Then
            smartSendLine4 = New SmartSend(ndLine4Int.Value.ToString, myFormat, cbL4IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL4Num.SelectedItem.ToString, cbL4Name.SelectedItem.ToString, cbL4AU.SelectedItem.ToString, cbUnit.SelectedItem.ToString)
        Else
            smartSendLine4 = New SmartSend(ndLine4Int.Value.ToString, myFormat, cbL4IO.SelectedItem.ToString, cbDetailed.SelectedItem.ToString, ckbCallAccounting.Checked, cbSEB.SelectedItem.ToString, cbL4Num.SelectedItem.ToString, cbL4Name.SelectedItem.ToString, "none", cbUnit.SelectedItem.ToString)
        End If

        '--> Special Call Accounting possibility
        smartSendLine4.caTimeB4Answer = ndL4TBA.Value.ToString
        smartSendLine4.caTimeOnHold = ndL4TimeOnHold.Value.ToString
        smartSendLine4.sipCode = cbL4SIPCode.SelectedItem.ToString
        '--> Timing
        smartSendLine4.timeInboundOffOn = ndInboundOffOn.Value.ToString
        smartSendLine4.timeInboundStartOff = ndInboundStartOff.Value.ToString
        smartSendLine4.timeOutboundStartOff = ndOutboundStartOff.Value.ToString
        '--> Thread setup
        sendThread(4) = New System.Threading.Thread(AddressOf smartSendLine4.send)
        sendThread(4).IsBackground = True
        sendThread(4).Start()

        ' Disable button/renable after completion
        btnL4Send.Enabled = False

    End Sub

#End Region

    '----------------------------
End Class
