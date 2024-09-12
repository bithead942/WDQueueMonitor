Public Class Form1

    Dim iIrrigationQueue, iTempQueue, iBlindsQueue, iInsteonQueue As Integer
    Dim iIrrigationCount, iTempCount, iBlindsCount, iInsteonCount As Integer
    Dim bIrrigationQueue, bTempQueue, bBlindsQueue, bInsteonQueue As Boolean
    Dim dtIrrigationQueue, dtTempQueue, dtBlindsQueue, dtInsteonQueue As Date

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Event_HistoryTableAdapter.InsertQuery("9034")  'WDQueueMonitor Stopped
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Event_HistoryTableAdapter.InsertQuery("9033")  'WDQueueMonitor Started
        lblLastAlert.Text = ""

        iIrrigationCount = 0
        iTempCount = 0
        iBlindsCount = 0
        iInsteonCount = 0

        lblIrrigationFlag.Text = "."
        lblTempFlag.Text = "."
        lblBlindsFlag.Text = "."
        lblInsteonFlag.Text = "."

        bIrrigationQueue = False
        bTempQueue = False
        bBlindsQueue = False
        bInsteonQueue = False

        CheckQueues()

        tCheckQueue.Interval = ((60 - Now.Second) * 1000)
        tSendAlert.Interval = ((59 - Now.Minute) * 60000) + ((60 - Now.Second) * 1000)
        tCheckQueue.Start()
        tSendAlert.Start()
    End Sub

    Private Sub CheckQueues()
        'Check Irrigation
        iIrrigationQueue = Irrigation_ControlTableAdapter.Irrigation_Queue_Count()
        lblIrrigationQueue.Text = iIrrigationQueue.ToString
        If iIrrigationQueue > 0 And Not bIrrigationQueue Then
            iIrrigationCount = iIrrigationCount + 1
            If iIrrigationCount >= 3 Then
                bIrrigationQueue = True
                lblIrrigationFlag.Text = "x"
                Event_HistoryTableAdapter.InsertQuery("9915")  'Irrigation Error
                dtIrrigationQueue = Now
            End If
        End If
        If iIrrigationQueue = 0 Then
            iIrrigationCount = 0
            lblIrrigationFlag.Text = "."
            bIrrigationQueue = False
        End If

        'Check Temp
        iTempQueue = Temp_ControlTableAdapter.Temp_Queue_Count()
        lblTempQueue.Text = iTempQueue.ToString
        If iTempQueue > 0 And Not bTempQueue Then
            iTempCount = iTempCount + 1
            If iTempCount >= 3 Then
                bTempQueue = True
                lblTempFlag.Text = "x"
                Event_HistoryTableAdapter.InsertQuery("9905")  'NetChecker Error
                dtTempQueue = Now
            End If
        End If
        If iTempQueue = 0 Then
            iTempCount = 0
            lblTempFlag.Text = "."
            bTempQueue = False
        End If

        'Check Blinds
        iBlindsQueue = Blinds_ControlTableAdapter.Blinds_Queue_Count()
        lblBlindsQueue.Text = iBlindsQueue.ToString
        If iBlindsQueue > 0 And Not bBlindsQueue Then
            iBlindsCount = iBlindsCount + 1
            If iBlindsCount >= 3 Then
                bBlindsQueue = True
                lblBlindsFlag.Text = "-"
                Event_HistoryTableAdapter.InsertQuery("9950")  'Blinds Error
                dtBlindsQueue = Now
            End If
        End If
        If iBlindsQueue = 0 Then
            iBlindsCount = 0
            lblBlindsFlag.Text = "."
            bBlindsQueue = False
        End If

        'Check Insteon
        iInsteonQueue = Insteon_ControlTableAdapter.Insteon_Queue_Count
        lblInsteonQueue.Text = iInsteonQueue.ToString
        If iInsteonQueue > 0 And Not bInsteonQueue Then
            iInsteonCount = iInsteonCount + 1
            If iInsteonCount >= 3 Then
                bInsteonQueue = True
                lblInsteonFlag.Text = "x"
                Event_HistoryTableAdapter.InsertQuery("9945")  'Insteon Error
                dtInsteonQueue = Now
            End If
        End If
        If iInsteonQueue = 0 Then
            iInsteonCount = 0
            lblInsteonFlag.Text = "."
            bInsteonQueue = False
        End If

        lblLastChecked.Text = Now.ToString
    End Sub

    Private Sub SendMessage(strMessage As String)
        Dim Message As MailMessage
        Dim mySMTPClient As SmtpClient = New SmtpClient

        Try
            Message = New MailMessage("Watchdog@gmail.com", "gregspata@gmail.com")
            Message.Subject = "WATCHDOG QUEUE ERROR"
            Message.Priority = MailPriority.High
            mySMTPClient.Host = "smtp-server.cinci.rr.com"
            mySMTPClient.Port = 25
            Message.Body = strMessage
            mySMTPClient.Send(Message)

            lblLastAlert.Text = Now.ToString
            Event_HistoryTableAdapter.InsertQuery("5009")  'Text message sent
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

#Region "Timer"
    Private Sub tCheckQueue_Tick(sender As Object, e As EventArgs) Handles tCheckQueue.Tick
        'Triggers every 30 sec
        tCheckQueue.Interval = 30000

        CheckQueues()
        ''''Debug
        'tSendAlert_Tick(sender, e)
        ''''

    End Sub


    Private Sub tSendAlert_Tick(sender As Object, e As EventArgs) Handles tSendAlert.Tick
        'Triggers every 6 hours
        tSendAlert.Interval = 21600000

        Dim strMessage As String

        If bIrrigationQueue Then
            strMessage = "Irrigation Queue Error at " & dtIrrigationQueue.ToString & Chr(10) & Chr(13)
            strMessage = strMessage & "The following zones are unresponsive:  " & Chr(10) & Chr(13)
            Dim tBadZones As WatchdogDataSet.Irrigation_ControlDataTable
            tBadZones = Irrigation_ControlTableAdapter.Get_ZoneName
            For i = 0 To (tBadZones.Rows.Count - 1)
                strMessage = strMessage & tBadZones.Rows(i).Item(1) & Chr(10) & Chr(13)
            Next
            'Get list of names
            SendMessage(strMessage)
            bIrrigationQueue = False
            lblIrrigationFlag.Text = "-"
        End If
        If bBlindsQueue Then
            strMessage = "Blinds Queue Error at " & dtBlindsQueue.ToString & Chr(10) & Chr(13)
            strMessage = strMessage & "The following blinds are unresponsive:  " & Chr(10) & Chr(13)
            Dim tBadBlinds As WatchdogDataSet.Blinds_ControlDataTable
            tBadBlinds = Blinds_ControlTableAdapter.Get_BlindName
            For i = 0 To (tBadBlinds.Rows.Count - 1)
                strMessage = strMessage & tBadBlinds.Rows(i).Item(1) & Chr(10) & Chr(13)
            Next
            strMessage = strMessage & Chr(10) & Chr(13) & "Diagnostics:" & Chr(10) & Chr(13)
            If Not GetRomanShadeConnectStatus() Then
                strMessage = strMessage & "OFFLINE:  HD Roman Shade Controller (192.168.1.191)" & Chr(10) & Chr(13)
            Else
                strMessage = strMessage & "ONLINE:   HD Roman Shade Controller (192.168.1.191)" & Chr(10) & Chr(13)
            End If
            If Not GetSomfyConnectStatus() Then
                strMessage = strMessage & "OFFLINE:   HD Somfy Controller (192.168.1.190)"
            Else
                strMessage = strMessage & "ONLINE:   HD Somfy Controller (192.168.1.190)"
            End If

            SendMessage(strMessage)
            bBlindsQueue = False
            lblBlindsFlag.Text = "-"
        End If
        If bTempQueue Then
            strMessage = "Temp Queue Error at " & dtTempQueue.ToString & Chr(10) & Chr(13)
            strMessage = strMessage & "The Wifi Thermostat is unresponsive and needs to be reset"
            strMessage = strMessage & Chr(10) & Chr(13) & "Diagnostics:" & Chr(10) & Chr(13)
            If Not GetThermostatConnectStatus() Then
                strMessage = strMessage & "OFFLINE:  Wifi Thermostat (192.168.1.201)"
            Else
                strMessage = strMessage & "ONLINE:   Wifi Thermostat (192.168.1.201)"
            End If

            SendMessage(strMessage)
            bTempQueue = False
            lblTempFlag.Text = "-"
        End If
        If bInsteonQueue Then
            strMessage = "Insteon Queue Error at " & dtInsteonQueue.ToString & Chr(10) & Chr(13)
            strMessage = strMessage & "The following lights are unresponsive " & Chr(10) & Chr(13)
            Dim tBadLights As WatchdogDataSet.Insteon_ControlDataTable
            tBadLights = Insteon_ControlTableAdapter.Get_DeviceName
            For i = 0 To (tBadLights.Rows.Count - 1)
                strMessage = strMessage & tBadLights.Rows(i).Item(1) & Chr(10) & Chr(13)
            Next
            SendMessage(strMessage)
            bInsteonQueue = False
            lblInsteonFlag.Text = "-"
        End If

    End Sub
#End Region

#Region "Buttons"
    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        tCheckQueue.Interval = ((59 - Now.Second) * 1000)
        tSendAlert.Interval = ((59 - Now.Minute) * 60000) + ((60 - Now.Second) * 1000)

        tSendAlert.Start()
        tCheckQueue.Start()
        btnOn.Enabled = False
        btnOff.Enabled = True
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        tSendAlert.Stop()
        tCheckQueue.Stop()
        btnOn.Enabled = True
        btnOff.Enabled = False
    End Sub

#End Region

#Region "Diagnose"
    Private Function GetRomanShadeConnectStatus() As Boolean
        Dim ICSSend As New Ping
        Dim ICSReply As PingReply
        Dim bSuccess As Boolean

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        bSuccess = False

        Try
            Dim ipv4Addr As Net.IPAddress = Net.IPAddress.Parse("192.168.1.191")
            ICSReply = ICSSend.Send(ipv4Addr)  'HD Roman Shade Wifi Controller
            If ICSReply.Status = IPStatus.Success Then
                bSuccess = True
            Else
                bSuccess = False
            End If

        Catch ex As Exception
            Return False
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Return bSuccess

    End Function

    Private Function GetSomfyConnectStatus() As Boolean
        Dim ICSSend As New Ping
        Dim ICSReply As PingReply
        Dim bSuccess As Boolean

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        bSuccess = False

        Try
            Dim ipv4Addr As Net.IPAddress = Net.IPAddress.Parse("192.168.1.190")
            ICSReply = ICSSend.Send(ipv4Addr)  'Somfy Controller
            If ICSReply.Status = IPStatus.Success Then
                bSuccess = True
            Else
                bSuccess = False
            End If

        Catch ex As Exception
            Return False
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Return bSuccess

    End Function

    Private Function GetThermostatConnectStatus() As Boolean
        Dim ICSSend As New Ping
        Dim ICSReply As PingReply
        Dim bSuccess As Boolean

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        bSuccess = False

        Try
            Dim ipv4Addr As Net.IPAddress = Net.IPAddress.Parse("192.168.1.201")
            ICSReply = ICSSend.Send(ipv4Addr)  'Wifi Thermostat
            If ICSReply.Status = IPStatus.Success Then
                bSuccess = True
            Else
                bSuccess = False
            End If

        Catch ex As Exception
            Return False
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Return bSuccess

    End Function
#End Region

End Class
