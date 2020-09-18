Public Class frmPackageSelector


#Region "Properties"

    Private pckID As Integer
    Private Property PackageID As Integer
        Get
            Return pckID
        End Get
        Set(value As Integer)
            pckID = value
        End Set
    End Property
#End Region

#Region "Functions"

#End Region

#Region "Subs"

    Protected Friend Sub loadMemberPackages()
        SQLstr = String.Format("SELECT * FROM Package WHERE isForMember = 1")
        sqlQueryCMD(SQLstr)
        lvPackages.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvPackages.Items.Add(rdDB!PackageID)
            itemx.SubItems.Add(rdDB!CategoryName)
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(rdDB!Limit)
            itemx.SubItems.Add(rdDB!TimeUnit)
            itemx.SubItems.Add(rdDB!PayMode)
            itemx.SubItems.Add(rdDB!PackagePrice)
        Loop
        closeDBAll()
    End Sub


    Protected Friend Sub loadNonMemberPackages()
        SQLstr = String.Format("SELECT * FROM Package WHERE isForMember = 0")
        sqlQueryCMD(SQLstr)
        lvPackages.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvPackages.Items.Add(rdDB!PackageID)
            itemx.SubItems.Add(rdDB!CategoryName)
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(rdDB!Limit)
            itemx.SubItems.Add(rdDB!TimeUnit)
            itemx.SubItems.Add(rdDB!PayMode)
            itemx.SubItems.Add(rdDB!PackagePrice)
        Loop
        closeDBAll()
    End Sub

    Private Sub saveTransaction(ByVal playerID As String)
        PackageID = lvPackages.SelectedItems(0).SubItems(0).Text
        SQLstr = String.Format("SELECT TransacID FROM Transactions WHERE (PackageID = {0}) AND (PlayerID = '{1}') AND (Status = 1)", lvPackages.SelectedItems(0).SubItems(0).Text, playerID)
        sqlQueryCMD(SQLstr)
        Dim val As Boolean = False
        If rdDB.HasRows() Then
            rdDB.Read()
            val = True
        End If
        closeDBAll()
        If val = True Then
            MessageBox.Show("Cannot add the same package until expired.", "Selected package is still active!")
            Exit Sub
        End If

        SQLstr = String.Format("INSERT INTO Transactions(TransacDate, PackageID, PlayerID, PackStartDate, PackExpireDate, Status, isExpired, SessionRemain) " & _
                                            "VALUES('{0}', {1}, '{2}', '{3}', '{4}', 'True','False', DATEDIFF(day, CONVERT(date, '{3}'), '{4}'))",
                                            dateValue(dtpStartDate.Value), PackageID, playerID,
                                            dateValue(dtpStartDate.Value), dateValue(dtpExpireDate.Value))
        sqlNonQueryCMD(SQLstr)


        'sendNoticeSMS(getPlayerMobile(clientID),
        '              msgMonthlySubsInfo(frmClientInfo.txtClientName.Text,
        '                                 CDate(dtpStartDate.Value.ToShortDateString).ToString("MMM dd, yyyy"),
        '                                 CDate(dtpExpireDate.Value.ToShortDateString).ToString("MMM dd, yyyy"),
        '                                 lvPackages.SelectedItems(0).SubItems(2).Text))

        frmClientInfo.loadPackages()
        frmMonitoringList.loadMonthlySubs()
        frmClientList.loadDailyTransac(frmClientList.dtpSelector.Value)
        'MessageBox.Show("New package has been added to client!", "Save success.")
    End Sub


#End Region

    Private Sub frmPackages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loadPackages()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If frmClientInfo.Visible = True Then
            frmClientInfo.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If lvPackages.SelectedItems.Count = 1 Then

            If frmRegistration.Visible = False And frmClientInfo.Visible = False Then
                saveTransaction(frmMain.lblClientID.Text)
                MessageBox.Show("Subscription has been added successfully!", "Save Success!.")
                frmMain.loadActiveSubs(frmMain.lblClientID.Text)
                frmClientList.loadDailyTransac(frmClientList.dtpSelector.Value)
                Me.Close()
            ElseIf frmRegistration.Visible = True Then
                frmRegistration.grabPackage(lvPackages.SelectedItems(0).SubItems(0).Text)
                Me.Close()
            ElseIf frmClientInfo.Visible = True Then
                frmClientInfo.Enabled = True
                saveTransaction(frmClientInfo.txtClientID.Text)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub lvPackages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPackages.SelectedIndexChanged
        If lvPackages.SelectedItems.Count = 1 Then
            If lvPackages.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "M" Then
                dtpExpireDate.Value = dtpStartDate.Value.AddMonths(lvPackages.SelectedItems(0).SubItems(3).Text)
            ElseIf lvPackages.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "Y" Then
                dtpExpireDate.Value = dtpStartDate.Value.AddYears(lvPackages.SelectedItems(0).SubItems(3).Text * 1)
            ElseIf lvPackages.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "D" Then
                dtpExpireDate.Value = dtpStartDate.Value
            End If
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        If lvPackages.SelectedItems.Count = 1 Then
            If lvPackages.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "M" Then
                dtpExpireDate.Value = dtpStartDate.Value.AddMonths(lvPackages.SelectedItems(0).SubItems(3).Text)
            ElseIf lvPackages.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "Y" Then
                dtpExpireDate.Value = dtpStartDate.Value.AddYears(lvPackages.SelectedItems(0).SubItems(3).Text * 1)
            ElseIf lvPackages.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "D" Then
                dtpExpireDate.Value = dtpStartDate.Value
            End If
        End If

    End Sub
End Class