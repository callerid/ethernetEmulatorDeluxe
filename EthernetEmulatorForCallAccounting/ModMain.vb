Imports System.Text
Imports System.Net
Imports System.Net.Sockets

Module ModMain

    ' Global Variables
    Public myUdpClient As UdpClient
    Public boxIP As String = "255.255.255.255"
    Public boxPort As String = "3520"

    '------------------------------------------------------------------------------------

    ' Contains udpConnect, all udpSends, and udpDisconnect

#Region "Communications"

    ' Open connection with ip and port address
    Public Sub udpConnect(ByVal boxIp, ByVal boxPort)

        Try

            ' Setup endPoint
            Dim myEndPoint As New IPEndPoint(IPAddress.Parse(boxIp), Integer.Parse(boxPort))

            ' Connect
            myUdpClient = New UdpClient
            myUdpClient.Connect(myEndPoint)

        Catch ex As Exception

            MsgBox("Exception: " + ex.ToString, vbOK, "Expection Thrown")

        End Try

    End Sub

    ' Sends message string
    Public Sub udpSendMessage(ByVal myMessage As String)

        Try
            ' Declare local variables
            Dim dataToSend() As Byte

            ' Encode message
            dataToSend = Encoding.ASCII.GetBytes(myMessage)

            ' Send message
            myUdpClient.Send(dataToSend, dataToSend.Length)

        Catch ex As Exception

            MsgBox("Exceptions: ", ex.ToString, "Exception Thrown")

        End Try

    End Sub

    ' Sends message byte
    Public Sub udpSendMessageWByte(ByVal myMessage As String, ByVal byteNumber As Byte)

        Try
            ' Declare local variables
            Dim dataToSend() As Byte

            ' Encode message where C=byteNumber place holder
            dataToSend = Encoding.ASCII.GetBytes(myMessage + "C")
            dataToSend(dataToSend.Length - 1) = byteNumber

            ' Send message
            myUdpClient.Send(dataToSend, dataToSend.Length)

        Catch ex As Exception

            MsgBox("Exceptions: ", ex.ToString, "Exception Thrown")

        End Try

    End Sub

    ' Sends message byte array
    Public Sub udpSendMessageWByteArray(ByVal myMessage As String, ByVal byteNumber() As Byte)

        Try
            ' Declare local variables
            Dim dataToSend() As Byte
            Dim tempPlaceHolder As String = ""

            ' Fill place holders string
            For i = 0 To byteNumber.Length - 1

                ' Add character place holder
                tempPlaceHolder += "C"

            Next

            ' Encode message with place holders
            dataToSend = Encoding.ASCII.GetBytes(myMessage + tempPlaceHolder)

            ' Loop through place holder spots in array and fill with correct bytes
            For i = myMessage.Length To dataToSend.Length - 1

                ' Insert bytes into array
                dataToSend(i) = byteNumber(i - myMessage.Length)

            Next

            ' Send message
            myUdpClient.Send(dataToSend, dataToSend.Length)

        Catch ex As Exception

            MsgBox("Exceptions: ", ex.ToString, "Exception Thrown")

        End Try

    End Sub

    ' Closes connection
    Public Sub udpDisconnect()

        myUdpClient.Close()

    End Sub

#End Region

    '------------------------------------------------------------------------------------

    ' Custom Subs:
    '----------------> toggleFields: disables/enables all controls on form
    '----------------> waitFor: waits for a interval so x milliseconds
    '----------------> getDateShort: returns date in short format
    '----------------> getDateLong: returns date in long format

#Region "Custom Subs"

    ' Enable/Disable all buttons,numericupdown, and combo boxes on form
    Public Sub toggleFields(ByVal thisForm As Form, ByVal enable As Boolean)

        For Each myControl In thisForm.Controls

            If (Not myControl Is frmMain.gbProgress) And (Not myControl Is frmMain.lbHelp) And (Not myControl Is frmMain.lbIPAddress) And (Not myControl Is frmMain.ipSend) Then

                If Not TypeOf myControl Is GroupBox Then

                    If enable = True Then
                        myControl.Enabled = True
                    Else
                        myControl.Enabled = False
                    End If

                Else

                    For Each ctrl In myControl.Controls

                        If enable = True Then
                            ctrl.Enabled = True
                        Else
                            ctrl.Enabled = False
                        End If

                    Next

                End If

            End If

        Next

    End Sub

    ' Loops for a specificied period of time (milliseconds)
    Public Sub waitFor(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    ' Return short date in format MM/dd hh:mm tt
    Public Function getDateShort() As String
        Return Format(Date.Now, "MM/dd hh:mm tt")
    End Function

    ' Return long date in format MM/dd HH:mm:ss
    Public Function getDateLong() As String
        Return Format(Date.Now, "MM/dd HH:mm:ss")
    End Function
    
#End Region

    '------------------------------------------------------------------------------------

End Module
