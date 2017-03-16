Public Class SmartSend

#Region "Vaiables, Events, and Setup"

    ' Events
    Public Event updateProgressBars(ByVal thisObject As Object)
    Public Event updateProgressDGV(ByVal line As Integer, ByVal currentItem As String, ByVal clear As Boolean, ByVal itemColor As Color)
    Public Event updateTraffic(ByVal line As Integer, ByVal text As String, ByVal thisColor As Color)

    ' Public variables
    Public inProgress As Boolean = False
    Public myProgressBarMax As Integer
    Public myProgressBarValue As Integer
    Public unitType As String

    ' Mode variables
    Private callType As String
    Private detailed As String
    Private callAccounting As String
    Private startEndBoth As String

    ' Setting Variables
    Public line As String
    Private number As String
    Private name As String
    Private answered As String
    '--> Call Accounting
    Public caTimeOnHold As String
    Public caTimeB4Answer As String
    Public sipCode As String
    '--> Timing
    Public timeInboundStartOff As String
    Public timeInboundOffOn As String
    Public timeOutboundStartOff As String

    ' Private format variable
    Private format As String

    ' Header Format
    Private header As String = "^^<U>000001<S>345678$"

#End Region

    '-----------------------------------------------------

    ' Setup new Smart Send record to be queued to send on thread
    Public Sub New(ByVal inLine As String, ByVal inFormat As String, ByVal inCallType As String, ByVal inDetailed As String, ByVal inCallAccounting As Boolean, ByVal inStartEndBoth As String, ByVal inNumber As String, ByVal inName As String, ByVal inAnswered As String, ByVal inUnitType As String)

        '------------------------------------
        ' Aquire Variables
        '------------------------------------
        ' Get line
        line = inLine

        ' Get format
        format = inFormat

        ' Get inboundCall
        callType = inCallType

        ' Get detailed
        detailed = inDetailed

        ' Get call accounting 
        callAccounting = inCallAccounting

        ' Get start/end/both
        startEndBoth = inStartEndBoth

        ' Get number
        number = inNumber

        ' Get name
        name = inName

        ' Get unit type
        unitType = inUnitType
        
        ' Get answered/unanswered variable
        answered = inAnswered

        '-------------------------------------

        ' Set progress
        inProgress = False

        ' Set progress bar
        Dim maxValue As Integer = 1
        If detailed = "On" Then

            If callType = "Inbound" Then
                ' Add count for RING,ON-Hook, and OFF-Hook
                maxValue += 3
            Else
                ' Add count for ON-Hook and OFF-Hook
                maxValue += 2
            End If

        End If

        Select Case startEndBoth
            Case "Start"
                ' Add count for start record
                maxValue += 1
            Case "End"
                ' Add count for end record
                maxValue += 1
            Case "Both"
                ' Add count for start and end record
                maxValue += 2
        End Select

        ' Add count if call accounting record is going to be sent
        If callAccounting = True Then
            maxValue += 1
        End If

        ' Set progressbar
        myProgressBarMax = maxValue
        myProgressBarValue = 1

    End Sub

    '-----------------------------------------------------

    ' Send sub - thread sub
    Public Sub send()

        ' Start new data grid view row
        Dim cleared As Boolean = False

        ' Set progress to true for sending
        inProgress = True

        ' Update progress bar
        RaiseEvent updateProgressBars(Me)

        ' --> Get Line Number
        If Integer.Parse(line) < 10 Then
            line = "0" + line
        Else
            If Integer.Parse(line) > 20 Then
                line = "20"
            End If
        End If

        ' If USA/standard format

        If callType = "Inbound" Then

            '------------------------------
            ' SEND INBOUND CALL
            '------------------------------

            ' Check to see if sending RING
            If detailed = "On" And format = "USA" Then

                '--> Show on data grid view
                RaiseEvent updateProgressDGV(Integer.Parse(line), "Ring", True, Color.Red)
                cleared = True

                ' Create Record
                Dim ringRecord As String = ""

                ' Add Line Number and timestamp to ring record
                ringRecord = line + " R             " + getDateLong()

                ' Send RING record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + ringRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + ringRecord, Color.Red)

                '--> Disconnect
                udpDisconnect()

                ' Wait 3 seconds for Ring
                If Not unitType = "Vertex" Then
                    waitFor(3000)
                End If
                
                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            If startEndBoth = "Start" Or startEndBoth = "Both" Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Inbound Start", True, Color.Green)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Inbound Start", False, Color.Green)
                End If


                ' Create Inbound Start Record
                Dim inboundStartRecord As String = ""
                inboundStartRecord = line + " I S 0000 G A1 " + getDateShort() + " " + number + name

                ' Send Inbound Start
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + inboundStartRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + inboundStartRecord, Color.Green)

                '--> Disconnect
                udpDisconnect()

                ' Increase progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            ' Check to see if sending Off/On hooks
            If detailed = "On" And answered = "Answered" Then

                ' Delay before answer of phone
                waitFor(1000 * timeInboundStartOff)

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Off-Hook", True, Color.Black)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Off-Hook", False, Color.Black)
                End If

                ' Create off-hook record
                Dim offHookRecord As String = line + " F             " + getDateLong()

                ' Send off-hook record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + offHookRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + offHookRecord, Color.Black)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

                ' Wait for phone hang-up
                waitFor(1000 * timeInboundOffOn)

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "On-Hook", True, Color.Black)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "On-Hook", False, Color.Black)
                End If


                ' Create on-hook record
                Dim onHookRecord As String = line + " N             " + getDateLong()

                ' Send on-hook record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + onHookRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + onHookRecord, Color.Black)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            ' Declare duration for possible use in call accounting
            Dim duration As String = "0000"

            If startEndBoth = "End" Or startEndBoth = "Both" Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Inbound End", True, Color.Green)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Inbound End", False, Color.Green)
                End If

                ' Create Inbound End Record
                Dim inboundEndRecord As String = ""

                ' If detailed off and answered is true
                If detailed = "Off" And answered = "Answered" Then
                    duration = "0123"
                ElseIf detailed = "On" And answered = "Answered" Then
                    duration = timeInboundOffOn
                Else
                    duration = "0000"
                End If

                ' Format duration
                Select Case duration.Length
                    Case 1
                        duration = "000" + duration
                    Case 2
                        duration = "00" + duration
                    Case 3
                        duration = "0" + duration
                End Select
                inboundEndRecord = line + " I E " + duration + " G A1 " + getDateShort() + " " + number + name

                ' Send End Record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + inboundEndRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + inboundEndRecord, Color.Green)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            ' Check if sending call accounting record
            ' if so, add it to End Record and resend
            If callAccounting = True And (Integer.Parse(line) > 2) Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Call Accnt.", True, Color.DarkGoldenrod)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Call Accnt.", False, Color.DarkGoldenrod)
                End If

                ' Get time before answer
                Dim timeBeforeAnswer As String = caTimeB4Answer

                '--> Format time before answer
                Select Case timeBeforeAnswer.Length
                    Case 1
                        timeBeforeAnswer = "000" + timeBeforeAnswer
                    Case 2
                        timeBeforeAnswer = "00" + timeBeforeAnswer
                    Case 3
                        timeBeforeAnswer = "0" + timeBeforeAnswer
                End Select

                ' Get time before answer
                Dim timeOnHold As String = caTimeOnHold
                '--> Format time before answer
                Select Case timeOnHold.Length
                    Case 1
                        timeOnHold = "000" + timeOnHold
                    Case 2
                        timeOnHold = "00" + timeOnHold
                    Case 3
                        timeOnHold = "0" + timeOnHold
                End Select

                ' Decide description
                Dim description As String = ""
                Select Case sipCode
                    Case "000"
                        description = "OK Complete     "
                    Case "001"
                        description = "Hold >5 min     "
                    Case "002"
                        description = "Call Time-Out   "
                    Case "003"
                        description = "VC Exceeded     "
                    Case "400"
                        description = "Bad Request     "
                    Case "408"
                        description = "Request Timeout "
                    Case "486"
                        description = "Busy Here       "
                    Case "487"
                        description = "Request Termin. "
                    Case Else
                        description = "Unknown         "
                End Select

                ' Create call accounting record
                Dim callAccountingRecord As String = line + " I C " + duration + " G A1 " + getDateShort() + " " + number + name + " " + timeBeforeAnswer + " " + timeOnHold + " " + sipCode + " " + description

                ' Send call accounting record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + callAccountingRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + callAccountingRecord, Color.DarkGoldenrod)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            '------------------------------

        Else

            '------------------------------
            ' SEND OUTBOUND CALL
            '------------------------------

            ' Check to see if sending Off hook
            If detailed = "On" Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Off-Hook", True, Color.Black)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Off-Hook", False, Color.Black)
                End If


                ' Create off-hook record
                Dim offHookRecord As String = line + " F             " + getDateLong()

                ' Send off-hook record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + offHookRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + offHookRecord, Color.Black)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

                ' Wait for phone hang-up
                waitFor(2000)

            End If

            ' Send outbound start record
            If startEndBoth = "Start" Or startEndBoth = "Both" Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Outbound Start", True, Color.Blue)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Outbound Start", False, Color.Blue)
                End If


                ' Create Inbound Start Record
                Dim outboundStartRecord As String = ""
                outboundStartRecord = line + " O S 0000 G A1 " + getDateShort() + " " + number + name

                ' Send Inbound Start
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + outboundStartRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + outboundStartRecord, Color.Blue)

                '--> Disconnect
                udpDisconnect()

                ' Increase progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            ' Wait for on-hook
            waitFor(1000 * timeOutboundStartOff)

            ' Send on-hook
            If detailed = "On" Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "On-Hook", True, Color.Black)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "On-Hook", False, Color.Black)
                End If


                ' Create on-hook record
                Dim onHookRecord As String = line + " N             " + getDateLong()

                ' Send on-hook record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + onHookRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + onHookRecord, Color.Black)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            ' Send outbound end record
            Dim duration As String = "0123"
            If startEndBoth = "End" Or startEndBoth = "Both" Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Outbound End", True, Color.Blue)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Outbound End", False, Color.Blue)
                End If

                ' Create Inbound End Record
                Dim outboundEndRecord As String = ""

                ' Get duration
                If detailed = "Off" And answered = "Answered" Then
                    duration = "0123"
                ElseIf detailed = "On" And answered = "Answered" Then
                    duration = timeOutboundStartOff
                End If

                ' Format duration
                Select Case duration.Length
                    Case 1
                        duration = "000" + duration
                    Case 2
                        duration = "00" + duration
                    Case 3
                        duration = "0" + duration
                End Select
                outboundEndRecord = line + " O E " + duration + " G A1 " + getDateShort() + " " + number + name

                ' Send End Record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + outboundEndRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + outboundEndRecord, Color.Blue)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            ' Check if sending call accounting record
            ' if so, add it to End Record and resend
            If callAccounting = True And (Integer.Parse(line) > 2) Then

                '--> Show on data grid view
                If cleared = False Then
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Call Accnt.", True, Color.DarkGoldenrod)
                    cleared = True
                Else
                    RaiseEvent updateProgressDGV(Integer.Parse(line), "Call Accnt.", False, Color.DarkGoldenrod)
                End If

                ' Get time before answer
                Dim timeBeforeAnswer As String = caTimeB4Answer

                '--> Format time before answer
                Select Case timeBeforeAnswer.Length
                    Case 1
                        timeBeforeAnswer = "000" + timeBeforeAnswer
                    Case 2
                        timeBeforeAnswer = "00" + timeBeforeAnswer
                    Case 3
                        timeBeforeAnswer = "0" + timeBeforeAnswer
                End Select

                ' Get time before answer
                Dim timeOnHold As String = caTimeOnHold
                '--> Format time before answer
                Select Case timeOnHold.Length
                    Case 1
                        timeOnHold = "000" + timeOnHold
                    Case 2
                        timeOnHold = "00" + timeOnHold
                    Case 3
                        timeOnHold = "0" + timeOnHold
                End Select

                ' Decide description
                Dim description As String = ""
                Select Case sipCode
                    Case "000"
                        description = "OK Complete     "
                    Case "001"
                        description = "Hold >5 min     "
                    Case "002"
                        description = "Call Time-Out   "
                    Case "003"
                        description = "VC Exceeded     "
                    Case "400"
                        description = "Bad Request     "
                    Case "408"
                        description = "Request Timeout "
                    Case "486"
                        description = "Busy Here       "
                    Case "487"
                        description = "Request Termin. "
                    Case Else
                        description = "Unknown         "
                End Select

                ' Create call accounting record
                Dim callAccountingRecord As String = line + " O C " + duration + " G A1 " + getDateShort() + " " + number + name + " " + timeBeforeAnswer + " " + timeOnHold + " " + sipCode + " " + description

                ' Send call accounting record
                '--> Connect
                udpConnect(boxIP, boxPort)

                '--> Send
                udpSendMessage(header + callAccountingRecord)
                RaiseEvent updateTraffic(Integer.Parse(line), header + callAccountingRecord, Color.DarkGoldenrod)

                '--> Disconnect
                udpDisconnect()

                ' Update progress bar
                myProgressBarValue += 1
                RaiseEvent updateProgressBars(Me)

            End If

            '------------------------------

        End If

        ' Show completion
        myProgressBarValue = myProgressBarMax
        RaiseEvent updateProgressBars(Me)

        ' Wait a second
        waitFor(1000)

        ' Update progress bars
        inProgress = False
        myProgressBarValue = 0
        RaiseEvent updateProgressBars(Me)

    End Sub

    '-----------------------------------------------------

End Class
