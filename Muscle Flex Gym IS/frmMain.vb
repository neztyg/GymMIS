Imports System.Threading
Imports DPUruNet
Imports DPUruNet.Constants


Public Class frmMain
    Dim WithEvents timer1 As New System.Windows.Forms.Timer
    Dim WithEvents timer2 As New System.Windows.Forms.Timer
    Friend WithEvents timerRFID As New System.Windows.Forms.Timer
    Dim addSub As Boolean = False

#Region "Properties"
    Private pid As Integer
    Protected Friend Property PlayerID As Integer
        Get
            Return pid
        End Get
        Set(value As Integer)
            pid = value
        End Set
    End Property


#End Region

#Region "Functions"

#End Region

#Region "Subs"

    Public Sub loadClientInfo(ByVal playerID As Integer)
        SQLstr = String.Format("SELECT PlayerID, LName, FName, MI, BDate, Gender, ContactNum, Height, Weight, GuardianName, GuardianContactNum, Brgy, City, Province, PlayerPic, isMember FROM Player WHERE PlayerID = {0}", playerID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            lblClientID.Text = rdDB!PlayerID
            lblClientName.Text = String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname)

            If Not IsDBNull(rdDB!PlayerPic) Then
                Try
                    Dim data As Byte() = DirectCast(rdDB!PlayerPic, Byte())
                    Dim ms As New IO.MemoryStream(data)
                    picClient.Image = Image.FromStream(ms)
                Catch ex As Exception
                    picClient.Image = My.Resources.LogoNoPic
                End Try
            Else
                picClient.Image = My.Resources.LogoNoPic
            End If

            If Not rdDB!isMember Then
                btnConvertMember.Visible = True
            Else
                btnConvertMember.Visible = False
            End If
        End If
        closeDBAll()

        'SQLstr = String.Format("SELECT Package, PackExpireDate FROM viewPackageSubscription WHERE PlayerID = {0} AND TimeUnit = 'M' AND isExpired = Null", playerID)
        'sqlQueryCMD(SQLstr)

        'If rdDB.HasRows Then
        '    rdDB.Read()
        '    lblPackage.Text = rdDB!Package
        '    lblPackExpiryDate.Text = String.Format("Until: {0}", rdDB!PackExpireDate)
        'End If
        'closeDBAll()
        updateAttendance(lblClientID.Text)

        loadActiveSubs(playerID)
        frmClientList.loadCheckIns(frmClientList.dtpSelector.Value.ToShortDateString)
    End Sub

    Protected Friend Sub loadActiveSubs(ByVal playerID As String)

        SQLstr = String.Format("SELECT Transactions.TransacID, Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, Package.Package, Package.PackagePrice " & _
                               "FROM Transactions INNER JOIN Package ON Transactions.PackageID = Package.PackageID " + _
                               "WHERE Transactions.PlayerID = '{0}' AND Transactions.Status = 1 " + _
                               "ORDER BY Transactions.PackExpireDate", playerID)
        sqlQueryCMD(SQLstr)

        Dim lstItem As New ListViewItem
        lvPackages.Items.Clear()
        Do While rdDB.Read
            lstItem = lvPackages.Items.Add(rdDB!TransacID)
            lstItem.SubItems.Add(rdDB!Package)
            If Not IsDBNull(rdDB!PackExpireDate) Then
                If CDate(rdDB!PackExpireDate).ToShortDateString = Now.ToShortDateString Then
                    lstItem.BackColor = Color.Crimson
                    lstItem.ForeColor = Color.White
                    lstItem.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
                Else
                    lstItem.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
                End If
            End If
        Loop

    End Sub

    Protected Friend Sub updateAttendance(ByVal id)
        SQLstr = String.Format("SELECT LoginTime FROM Attendance WHERE PlayerID = {0} AND LogDate = '{1}'", id, dateValue(Now.Date))
        sqlQueryCMD(SQLstr)
        Dim playTimeIn As Date
        If rdDB.HasRows Then
            rdDB.Read()
            playTimeIn = rdDB!LoginTime.ToString
        End If
        closeDBAll()

        SQLstr = String.Format("SELECT COUNT(PlayerID) AS pid FROM Attendance WHERE PlayerID = {0} AND LogDate = '{1}'", id, dateValue(Now.Date))
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            If rdDB!pid < 1 Then
                closeDBAll()
                SQLstr = String.Format("INSERT INTO Attendance(PlayerID, LogDate, LoginTime) VALUES({0},'{1}', '{2}')", id, dateValue(Now.Date), Now.ToShortTimeString)
                sqlNonQueryCMD(SQLstr)
            End If
        End If

    End Sub


#End Region

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        MyBase.Dispose(True)
        Application.Exit()
    End Sub

    Private Sub btnClose_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnClose.MouseHover
        btnClose.Image = My.Resources.icons8_x_mark_lg
    End Sub

    Private Sub btnClose_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = My.Resources.icons8_x_mark
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Start Timer
        'MessageBox.Show(IPv4Address)

        timer1.Start()
        lblDate.Text = Now.ToLongDateString
        timer2.Interval = 1

        'timerRFID.Interval = 2000
        'timerRFID.Start()

        Transac_StatusCheck_Changer()
        Membership_StatusCheck_Changer()
        'AddBlankTrainer()

        'connectGSM()


        'Dim splash = New frmSplashScreen
        'splash.ShowDialog()
        'Delay(1)
        'splash.Close()
        'frmLogin.ShowDialog()
        'frmRegistration.loadCustomSourceList()

        MonitoringToolStripMenuItem_Click(sender, e)

        'If My.Settings.isLoopPlay Then
        '    tscbTimer.Text = My.Settings.playTime
        '    My.Computer.Audio.Play(My.Resources.Muscleflex_reminder, AudioPlayMode.BackgroundLoop)
        '    targetTime = 180000 * Val(tscbTimer.Text)
        '    timer2.Start()
        'Else
        '    timer2.Stop()
        '    My.Computer.Audio.Stop()
        'End If
        closeDBAll()
        MyBase.WindowState = FormWindowState.Maximized
        

    End Sub


    Protected Friend Sub sendExpire()
        If Not My.Settings.hasSentExpired Then
            If sendtoExpiringMonthly() Then
                My.Settings.hasSentExpired = True
                MessageBox.Show("All Expire has been updated!")
            End If
        End If
    End Sub


    Private Sub timer1_tick() Handles timer1.Tick
        lblTime.Text = Now.ToLongTimeString
        frmMonitoringList.lblTotalCheckins.Text = String.Format("TOTAL CHECK-INS: {0}", frmMonitoringList.lvCheckedinClients.Items.Count)

        If gsmSerialPort.IsOpen = True Then
            picGSMstatus.Image = My.Resources.icons8_connection_status_on
        Else
            picGSMstatus.Image = My.Resources.icons8_minus
        End If
        If lblClientID.Text.Length = 0 Then
            pnlSubs.Visible = False
        Else
            pnlSubs.Visible = True
        End If

    End Sub

    Private Sub checkRFIDAttendance(ByVal rfid As String)
        SQLstr = String.Format("SELECT PlayerID FROM Player WHERE RFIDnum = '{0}'", rfid)
        Dim id As Integer = 0

        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            rdDB.Read()
            id = rdDB!PlayerID
        End If
        closeDBAll()
        If id = 0 Then
            frmConfirmPopper.SetPromptTexts("RFID not Recognized", "RFID is not registred to a client, Please try again!")
            frmConfirmPopper.ShowDialog()
        Else
            loadClientInfo(id)
            Dim checkIns = frmMonitoringList
            If checkIns.Visible = True Then
                checkIns.loadCheckIns(checkIns.dtpSelector.Value)
            End If
        End If
        Delay(1)
        txtRFIDnum.Enabled = True
    End Sub

    Private Sub timerRFID_tick() Handles timerRFID.Tick
        If frmMonitoringList.txtSearchMonthly.Focused Or frmMonitoringList.txtSearchClient.Focused Then
            timerRFID.Interval = 3000
        Else
            timerRFID.Interval = 1000
            txtRFIDnum.Focus()
        End If
        If frmClientList.txtSearch.Focused Then
            timerRFID.Interval = 3000
        Else
            timerRFID.Interval = 1000
            txtRFIDnum.Focus()
        End If

        If txtRFIDnum.Focused Then
            txtRFIDnum.BackColor = Color.GreenYellow
            If txtRFIDnum.Text.Length > 3 Then
                'checkRFIDAttendance(txtRFIDnum.Text)
                txtRFIDnum.Clear()
                txtRFIDnum.Enabled = True
            End If
        Else
            txtRFIDnum.BackColor = Color.Crimson
            txtRFIDnum.Clear()
            txtRFIDnum.Enabled = True
        End If
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        timerRFID.Stop()

        If Not frmSales.Visible = True Then
            Dim mdi As New clsWindowMods
            mdi.mdiGetter(Me, frmSales)
            frmSales.WindowState = FormWindowState.Normal
        Else
            frmSales.Close()
            ProductsToolStripMenuItem_Click(sender, e)
        End If
    End Sub


    ''' <summary>
    ''' TEMPLATE
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(Now.AddMonths(1).ToLongDateString)

    End Sub

    Private Sub AddYearsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(Now.AddYears(1).ToLongDateString)

    End Sub

    Private Sub ExpireInAWeekToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(DateDiff(DateInterval.Day, Now, Now.AddDays(10)))

    End Sub
    ''' <summary>
    ''' END
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Protected Friend Sub NewMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMemberToolStripMenuItem.Click
        'CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
        timerRFID.Stop()
        If Not frmRegistration.Visible = True Then
            Dim mdi As New clsWindowMods
            frmRegistration.isForUpdate = False
            frmRegistration.clientType = True

            mdi.mdiGetter(Me, frmRegistration)
            'frmRegistration.Location = New Point(Panel3.Width, Panel1.Height + MenuStrip1.Height)
            'frmRegistration.TopMost = True
            'frmRegistration.Show()
        Else
            frmRegistration.Close()
            NewMemberToolStripMenuItem_Click(sender, e)
        End If


    End Sub

    Protected Friend Sub NewNonMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewNonMemberToolStripMenuItem.Click
        'CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
        timerRFID.Stop()
        If Not frmRegistration.Visible = True Then
            Dim mdi As New clsWindowMods
            frmRegistration.isForUpdate = False
            frmRegistration.clientType = False

            mdi.mdiGetter(Me, frmRegistration)
        Else
            frmRegistration.Close()
            NewNonMemberToolStripMenuItem_Click(sender, e)
        End If

    End Sub

    Private Sub PackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackagesToolStripMenuItem.Click
        timerRFID.Stop()
        If Not frmPackages.Visible = True Then
            Dim mdi As New clsWindowMods

            mdi.mdiGetter(Me, frmPackages)
            frmPackages.WindowState = FormWindowState.Normal
        Else
            frmPackages.Close()
            PackagesToolStripMenuItem_Click(sender, e)
        End If

    End Sub

    Friend Sub MonitoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitoringToolStripMenuItem.Click
        ''NEW UPDATE
        'If Not frmClientCheckins.Visible = True Then
        '    Dim mdi As New clsWindowMods

        '    mdi.mdiGetter(Me, frmClientCheckins)
        '    'CancelCaptureAndCloseReader(AddressOf OnCaptured)
        '    btnRefresh_Click(sender, e)
        '    'frmClientList.WindowState = FormWindowState.Normal
        'Else
        '    frmClientCheckins.Close()
        '    MonitoringToolStripMenuItem_Click(sender, e)
        'End If

        ''VERSION 1
        If Not frmClientList.Visible = True Then
            Dim mdi As New clsWindowMods

            mdi.mdiGetter(Me, frmClientList)
            'CancelCaptureAndCloseReader(AddressOf OnCaptured)
            'btnRefresh_Click(sender, e)
            'frmClientList.WindowState = FormWindowState.Normal
            timerRFID.Start()
            timerRFID.Interval = 2000
        Else
            frmClientList.Close()
            MonitoringToolStripMenuItem_Click(sender, e)
        End If

        'If Not frmMonitoringList.Visible = True Then
        '    Dim mdi As New clsWindowMods

        '    mdi.mdiGetter(Me, frmMonitoringList)
        '    'CancelCaptureAndCloseReader(AddressOf OnCaptured)
        '    'btnRefresh_Click(sender, e)
        '    'frmClientList.WindowState = FormWindowState.Normal
        '    timerRFID.Start()
        '    timerRFID.Interval = 2000
        'Else
        '    frmMonitoringList.Close()
        '    MonitoringToolStripMenuItem_Click(sender, e)
        'End If



    End Sub

    Private Sub txtSearchClient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub AboutApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutApplicationToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub RegistrationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim printRpt As New clsPrintReport
        printRpt.printBlankRegForm()

    End Sub

    Private Sub txtSearchClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LockerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockerToolStripMenuItem.Click
        frmLockerList.ShowDialog()
    End Sub

    Private Sub TrainerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainerToolStripMenuItem.Click
        frmTrainers.ShowDialog()
    End Sub

    Private Sub btnPlayReminder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayReminder.Click
        My.Computer.Audio.Play(My.Resources.Muscleflex_reminder, AudioPlayMode.Background)
    End Sub

    Private Sub PlayEvery1HourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayEvery1HourToolStripMenuItem.Click
        targetTime = 180000
        timer2.Start()
        My.Computer.Audio.Play(My.Resources.Muscleflex_reminder, AudioPlayMode.Background)
        My.Settings.playTime = 1
        My.Settings.isLoopPlay = True
    End Sub

    Private Sub SetPlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPlayToolStripMenuItem.Click
        If tscbTimer.Text = "" Then
            MessageBox.Show("Select timer interval", "No time set")
            Exit Sub
        End If
        My.Computer.Audio.Play(My.Resources.Muscleflex_reminder, AudioPlayMode.Background)
        targetTime = 180000 * Val(tscbTimer.Text)
        timer2.Start()
        My.Settings.playTime = tscbTimer.Text
        My.Settings.isLoopPlay = True
    End Sub


    Private Sub StopPlayingSoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopPlayingSoundToolStripMenuItem.Click
        My.Settings.isLoopPlay = False
        My.Settings.playTime = 0
        My.Computer.Audio.Stop()
        timer2.Stop()
    End Sub

    Dim counter As Integer = 0
    Dim targetTime As Double

    Private Sub timer2_Timer() Handles timer2.Tick
        counter += 1
        If counter = targetTime Then
            My.Computer.Audio.Play(My.Resources.Muscleflex_reminder, AudioPlayMode.Background)
            counter = 0
        End If
    End Sub

    Private Sub picGSMstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGSMstatus.Click
        connectGSM()
        If gsmSerialPort.IsOpen Then
            picGSMstatus.Image = My.Resources.icons8_connection_status_on
        Else
            picGSMstatus.Image = My.Resources.icons8_minus
        End If

    End Sub

    Private Sub gsmSerialPort_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles gsmSerialPort.DataReceived
        Dim data As String = String.Empty
        Dim numBytes As Integer = gsmSerialPort.BytesToRead
        For i As Integer = 1 To numBytes
            data &= Chr(gsmSerialPort.ReadChar)
        Next
        setPortData(data)
    End Sub

    Private Sub AnnualAttendanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportsView.ShowDialog()
    End Sub

    Private Sub txtRFIDnum_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRFIDnum.GotFocus
        timerRFID.Interval = 1500
    End Sub

    Private Sub txtRFIDnum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRFIDnum.LostFocus
        timerRFID.Interval = 5000
    End Sub

    Private Sub txtRFIDnum_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRFIDnum.KeyDown
        If e.KeyCode = Keys.Enter And txtRFIDnum.Text.Length > 3 Then
            checkRFIDAttendance(txtRFIDnum.Text)
            txtRFIDnum.Enabled = False
        End If
    End Sub

    Private Sub DailyTransactionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim printRpt As New clsPrintReport
        printRpt = New clsPrintReport

        printRpt.printDailyTransactions(Container, Now.ToShortDateString)
    End Sub

    Private Sub TransactionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        timerRFID.Stop()

        If Not frmReportsView.Visible = True Then
            Dim mdi As New clsWindowMods
            mdi.mdiGetter(Me, frmReportsView)
            frmReportsView.WindowState = FormWindowState.Normal
        Else
            frmReportsView.Close()
            ProductsToolStripMenuItem_Click(sender, e)
        End If

    End Sub

    Private Sub txtRFIDnum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRFIDnum.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddPack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPack.Click
        If lblClientID.Text.Length > 0 Then
            If frmClientList.isClientMember(lblClientID.Text) Then
                frmPackageSelector.loadMemberPackages()
            Else
                frmPackageSelector.loadNonMemberPackages()
            End If
            frmPackageSelector.ShowDialog()
        End If
    End Sub

    Private Sub Panel1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AddTrainerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTrainerToolStripMenuItem.Click
        If lvPackages.SelectedItems.Count = 1 Then
            frmTrainer.transacID = lvPackages.SelectedItems(0).SubItems(0).Text
            frmTrainer.ShowDialog()
            frmClientList.loadDailyTransac(frmClientList.dtpSelector.Value.ToShortDateString)
        End If
    End Sub

    Private Sub btnConvertMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertMember.Click
        'frmClientMembershipUpdate.loadPlayer(lblClientID.Text)
        'frmClientMembershipUpdate.ShowDialog()
        initDBconn()
        sqlNonQueryCMD(String.Format("UPDATE Player SET IsMember = '{0}', MemShipStart = null, MemShipEnd = null WHERE PlayerID = '{0}'", lblClientID.Text))
        loadClientInfo(lblClientID.Text)

    End Sub
End Class
