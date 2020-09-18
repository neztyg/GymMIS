Public Class frmClientList

#Region "Subs"

    Protected Friend Sub loadCheckIns(ByVal dtSelector As Date)


        SQLstr = String.Format("SELECT Player.PlayerID, Player.Lname, Player.Fname, Player.IsMember, Player.MemShipEnd, " + _
                                      "Attendance.AttendanceID, Attendance.LoginTime, Attendance.LogoutTime, Attendance.LockerNum, Attendance.isLockerReturned  " + _
                               "FROM Player RIGHT OUTER JOIN Attendance ON Player.PlayerID = Attendance.PlayerID " + _
                               "WHERE (Attendance.LogDate = '{0}') ORDER BY AttendanceID DESC", dateValue(dtSelector))
        sqlQueryCMD(SQLstr)

        lvCheckedinClients.Items.Clear()
        Dim lvi As New ListViewItem

        Do While rdDB.Read
            lvi = lvCheckedinClients.Items.Add(rdDB!PlayerID) '0
            lvi.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
        Loop
    End Sub

    Protected Friend Sub loadDailyTransac(ByVal dtArg As Date)
        SQLstr = String.Format("SELECT Player.PlayerID, Player.Lname + ', ' + Player.Fname + ' ' + Player.MI AS ClientName, Transactions.TransacDate, Package.Package, Package.PayMode, Package.PackagePrice, Trainer.Trainer " + _
                               "FROM Player INNER JOIN Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN Package ON Transactions.PackageID = Package.PackageID LEFT OUTER JOIN Trainer ON Transactions.TrainerID = Trainer.TrainerID  " + _
                               "WHERE Transactions.TransacDate = CONVERT(date,'{0}')", dtArg)
        sqlQueryCMD(SQLstr)

        lvTransacs.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvTransacs.Items.Add(rdDB!PlayerID)
            itemx.SubItems.Add(rdDB!ClientName)
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(rdDB!PackagePrice)
            If IsDBNull(rdDB!Trainer) Then
                itemx.SubItems.Add("")
            Else
                itemx.SubItems.Add(rdDB!Trainer)
            End If
        Loop
        closeDBAll()
        SQLstr = String.Format("SELECT SUM(Package.PackagePrice) AS totalSales FROM Transactions " + _
                                    "INNER JOIN Package ON Transactions.PackageID = Package.PackageID " + _
                                  " WHERE TransacDate = '{0}'", dtArg)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            If Not IsDBNull(rdDB!totalSales) Then
                lblTotalSales.Text = String.Format("TOTAL SALES: Php  {0:n}", CDec(rdDB!totalSales))
            Else
                lblTotalSales.Text = String.Empty
            End If
        End If

    End Sub

    Protected Friend Sub loadSearchedClient(ByVal searchVal As String)
        If txtSearch.TextLength = 0 Then
            loadDailyTransac(dtpSelector.Value)
        End If

        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI, FingerID, PlayerPic,  isMember, MemShipStart, MemShipEnd, DATEDIFF(day,CONVERT(date, GetDate()), MemShipEnd) + 1  as DaysRemain FROM Player WHERE CardNum LIKE '%{0}%' OR Lname LIKE '%{0}%' OR Fname LIKE '%{0}%'", searchVal)
        sqlQueryCMD(SQLstr)

        lvTransacs.Items.Clear()
        Dim itemx As New ListViewItem

        Dim count As Integer = 1

        Do While rdDB.Read
            itemx = lvTransacs.Items.Add(rdDB!PlayerID)
            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If

        Loop
        closeDBAll()
    End Sub

    Protected Friend Function isClientMember(ByVal playerID As String) As Boolean
        SQLstr = String.Format("SELECT isMember FROM Player WHERE PlayerID = '{0}'", playerID)
        sqlQueryCMD(SQLstr)
        Dim val As Boolean = False
        If rdDB.HasRows Then
            rdDB.Read()
            val = rdDB!isMember
        End If
        isClientMember = val
    End Function

    Protected Friend Function isLastSubValid(ByVal playerID As String) As Boolean
        sqlQueryCMD(String.Format("SELECT TOP(1) TransacDate, PackStartDate, PackExpireDate FROM Transactions " + _
                                  "WHERE PlayerID = '{0}'", playerID _
                                 ))

        Dim vals
    End Function

#End Region

    Private Sub frmClientList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpSelector_ValueChanged(sender, e)
    End Sub

    Private Sub dtpSelector_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSelector.ValueChanged
        loadCheckIns(dtpSelector.Value)
        loadDailyTransac(dtpSelector.Value)
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text = "Search here (Card number, Last name, First name)" Then
            txtSearch.Text = String.Empty
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.TextLength > 0 And txtSearch.Text <> "Search here (Card number, Last name, First name)" Then
            loadSearchedClient(txtSearch.Text)
        Else
            loadDailyTransac(dtpSelector.Value)
        End If
    End Sub

    Private Sub lvTransacs_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvTransacs.MouseDoubleClick
        If lvTransacs.SelectedItems.Count = 1 Then
            ''CHECKS
            '1'isMember
            If isClientMember(lvTransacs.SelectedItems(0).SubItems(0).Text) Then
                '2'isMonthly Subscribed

            End If

            frmMain.updateAttendance(lvTransacs.SelectedItems(0).SubItems(0).Text)
            frmMain.loadClientInfo(lvTransacs.SelectedItems(0).SubItems(0).Text)
            loadCheckIns(dtpSelector.Value)
        End If
    End Sub

    Private Sub ViewClientDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewClientDetailsToolStripMenuItem.Click
        If lvTransacs.SelectedItems.Count = 1 Then
            frmMain.Enabled = False
            frmClientInfo.loadClientInfo(lvTransacs.SelectedItems(0).SubItems(0).Text.Trim)
            frmClientInfo.Show()
        End If
    End Sub

    Private Sub RegisterRFIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterRFIDToolStripMenuItem.Click
        If lvTransacs.SelectedItems.Count = 1 Then
            frmRFIDUpdate.loadClientInfo(lvTransacs.SelectedItems(0).SubItems(0).Text)
            frmRFIDUpdate.ShowDialog()
        End If
    End Sub

    Private Sub UpdateCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCardToolStripMenuItem.Click
        If lvTransacs.SelectedItems.Count = 1 Then
            frmCardNumUpdate.loadClientInfo(lvTransacs.SelectedItems(0).SubItems(0).Text)
            frmCardNumUpdate.ShowDialog()
        End If
    End Sub

    Private Sub AssignTrainerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignTrainerToolStripMenuItem.Click
        frmTrainer.ShowDialog()
    End Sub

    Private Sub btnClearSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSearch.Click
        txtSearch.Text = "Search here (Card number, Last name, First name)"
    End Sub

    Private Sub RegisterAsMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterAsMemberToolStripMenuItem.Click

    End Sub

    Private Sub RenewMembershipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenewMembershipToolStripMenuItem.Click

    End Sub
End Class