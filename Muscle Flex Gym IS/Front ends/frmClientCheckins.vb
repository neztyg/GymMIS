Public Class frmClientCheckins

#Region "Properties"
    Private pid As Integer
    Protected Property PlayerID As Integer
        Get
            Return pid
        End Get
        Set(ByVal value As Integer)
            pid = value
        End Set
    End Property
#End Region

#Region "Functions"

#End Region

#Region "Subs"


    Private Sub deleteClientPermanent(ByVal id As Integer)
        SQLstr = String.Format("DELETE FROM Transactions WHERE PlayerID = '{0}'; " & _
                               "DELETE FROM Attendance WHERE PlayerID = '{0}'; " & _
                               "DELETE FROM PlayerStats WHERE PlayerID = '{0}'; " & _
                               "DELETE FROM TransacRecords WHERE PlayerID = '{0}'; " & _
                               "DELETE FROM Player WHERE PlayerID = '{0}'", id)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Protected Friend Sub loadMonitoringLists()
        'Try
        ''Constant Changers
        Transac_StatusCheck_Changer()
        Membership_StatusCheck_Changer()

        ''Monthly
        'loadMonthlySubs()

        ''Checkins
        loadCheckIns(dtpSelector.Value)
        'loadAttendance(dtpSelector.Value)
        ''Membership
        'loadYearlyMembership()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Protected Friend Sub loadCheckIns(ByVal dtSelector As Date)


        SQLstr = String.Format("SELECT Player.PlayerID, Player.Lname, Player.Fname, Player.LockerNumber, Player.IsMember, Player.MemShipEnd, " + _
                                      "Attendance.LoginTime, Attendance.LogoutTime " + _
                               "FROM Player RIGHT OUTER JOIN Attendance ON Player.PlayerID = Attendance.PlayerID " + _
                               "WHERE (Attendance.LogDate = '{0}') ORDER BY LoginTime DESC", dateValue(dtSelector))
        sqlQueryCMD(SQLstr)

        lvCheckedinClients.Items.Clear()
        Dim lvi As New ListViewItem
        Dim count As Integer = 1


        Do While rdDB.Read
            lvi = lvCheckedinClients.Items.Add(rdDB!PlayerID) '0

            lvi.SubItems.Add(count)

            lvi.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))

            If Not IsDBNull(rdDB!LockerNumber) Then
                If rdDB!LockerNumber = 0 Then
                    lvi.SubItems.Add("")
                Else
                    lvi.SubItems.Add(rdDB!LockerNumber)
                End If
            Else
                lvi.SubItems.Add("")
            End If

            If rdDB!isMember = True Then
                lvi.SubItems.Add("Yes")
            Else
                lvi.SubItems.Add("No")
                lvi.BackColor = Color.Black
                lvi.ForeColor = Color.White
            End If

            If Not IsDBNull(rdDB!LogoutTime) Then
                lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
                lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LogoutTime.ToString)).ToShortTimeString)
            Else
                lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
                lvi.SubItems.Add("")
            End If
            count += 1
        Loop
        closeDBAll()

        For x As Integer = 0 To lvCheckedinClients.Items.Count - 1
            SQLstr = String.Format("SELECT Status FROM Transactions WHERE PlayerID = '{0}'", lvCheckedinClients.Items(x).SubItems(0).Text)
            sqlQueryCMD(SQLstr)

            If rdDB.HasRows Then
                rdDB.Read()
                If rdDB!Status = "False" Then
                    lvCheckedinClients.Items(x).BackColor = Color.Gray
                    lvCheckedinClients.Items(x).ForeColor = Color.White
                End If
            End If
            closeDBAll()
        Next
        For x As Integer = 0 To lvCheckedinClients.Items.Count - 1
            'Sqlstr   = String.Format("SELECT 
        Next

    End Sub

    Protected Friend Sub loadAttendance(ByVal dtValue As Date)
        SQLstr = String.Format("SELECT DISTINCT PlayerID, Name, LockerNumber, isMember, MemShipEnd, LoginTime,  " + _
                                      "LogoutTime, Package, PackStartDate, PackExpireDate,  " + _
                                      "isPackExpired, DATEDIFF(day, GetDAte(), PackExpireDate) AS MonthlyRemain " + _
                               "FROM viewCheckIns " + _
                               "WHERE (LogDate = '{0}') " + _
                               "ORDER BY LoginTime DESC", dateValue(dtValue))
        sqlQueryCMD(SQLstr)

        lvCheckedinClients.Items.Clear()
        Dim itemx As New ListViewItem
        Dim count As Integer = 1
        'MessageBox.Show(SQLstr)
        Do While rdDB.Read
            itemx = lvCheckedinClients.Items.Add(rdDB!PlayerID)
            itemx.SubItems.Add(count)
            itemx.SubItems.Add(rdDB!Name)
            If Not IsDBNull(rdDB!LockerNumber) Then
                If rdDB!LockerNumber = 0 Then
                    itemx.SubItems.Add("")
                Else
                    itemx.SubItems.Add(rdDB!LockerNumber)
                End If
            Else
                itemx.SubItems.Add("")
            End If

            If rdDB!isMember = True Then
                itemx.SubItems.Add("Yes")
            Else
                itemx.SubItems.Add("No")
                itemx.BackColor = Color.Black
                itemx.ForeColor = Color.White
            End If

            If Not IsDBNull(rdDB!LogoutTime) Then
                itemx.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
                itemx.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LogoutTime.ToString)).ToShortTimeString)
            Else
                itemx.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
                itemx.SubItems.Add("")
            End If
            If Not IsDBNull(rdDB!Package) Then
                itemx.SubItems.Add(rdDB!Package)
            Else
                itemx.SubItems.Add("")
            End If

            If Not IsDBNull(rdDB!isPackExpired) Then

            End If
            count += 1
        Loop

        closeDBAll()

        For x As Integer = 0 To lvCheckedinClients.Items.Count - 1
            SQLstr = String.Format("SELECT Status FROM Transactions WHERE PlayerID = '{0}'", lvCheckedinClients.Items(x).SubItems(0).Text)
            sqlQueryCMD(SQLstr)

            If rdDB.HasRows Then
                rdDB.Read()
                If rdDB!Status = "False" Then
                    lvCheckedinClients.Items(x).BackColor = Color.Gray
                    lvCheckedinClients.Items(x).ForeColor = Color.White
                End If
            End If
            closeDBAll()
        Next
    End Sub
#End Region

    Public Sub frmClientList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonitoringLists()
        'sendToExpiredMonthly()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim printRpt As New clsPrintReport
        printRpt.printAttendanceByDate(Container, dtpSelector.Value)
    End Sub

    Private Sub dtpSelector_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSelector.ValueChanged
        loadCheckIns(sender.value)
    End Sub
    Private Sub UpdateFingerprintIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFingerprintIDToolStripMenuItem.Click
        'frmMain.CancelCaptureAndCloseReader(AddressOf frmMain.OnCaptured)
        'frmUpdateFingerID.loadClientInfo(lvMembers.SelectedItems(0).SubItems(0).Text)
        frmUpdateFingerID.Show()
        'frmUpdateFingerID.TopMost = True
        frmMain.Enabled = False
    End Sub


    Private Sub CheckoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckoutToolStripMenuItem.Click
        If lvCheckedinClients.SelectedItems.Count = 1 Then
            frmMain.updateAttendance(lvCheckedinClients.SelectedItems(0).SubItems(0).Text)
            loadCheckIns(dtpSelector.Value)
        End If
    End Sub

    Private Sub btnClientList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmClientList.ShowDialog()
    End Sub

    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.sendExpire()
    End Sub

    Private Sub ViewClientDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub AssignRFIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignRFIDToolStripMenuItem.Click
        If lvCheckedinClients.SelectedItems.Count = 1 Then
            With frmRFIDUpdate
                .loadClientInfo(lvCheckedinClients.SelectedItems(0).SubItems(0).Text)
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub lvCheckedinClients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvCheckedinClients.SelectedIndexChanged
        If lvCheckedinClients.SelectedItems.Count = 1 Then
            txtSearch.Focus()
        End If
        txtSearch.Focus()
    End Sub
End Class
