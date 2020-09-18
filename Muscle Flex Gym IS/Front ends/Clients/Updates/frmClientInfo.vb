Imports System.IO.MemoryStream

Public Class frmClientInfo


#Region "Properties"
    Private cliID As Integer
    Private Property ClientID As Integer
        Get
            Return cliID
        End Get
        Set(value As Integer)
            cliID = value
        End Set
    End Property
#End Region

#Region "Functions"

    Private Function checkLockerNum() As Boolean
        SQLstr = String.Format("SELECT LockerNumber FROM Player WHERE LockerNumber != 0 AND PlayerID != {0}", txtClientID.Text)
        sqlQueryCMD(SQLstr)
        Dim bool As Boolean

        Do While rdDB.Read
            If rdDB!LockerNumber = cbLockers.Text Then
                bool = True
            Else
                bool = False
            End If
        Loop
        closeDBAll()
        Return bool
    End Function
#End Region

#Region "Subs"

    Private Sub loadAvailLockers()
        SQLstr = String.Format("SELECT LockerID, PlayerID FROM Locker")
        sqlQueryCMD(SQLstr)

        cbLockers.Items.Clear()
        cbLockers.Items.Add("")
        Do While rdDB.Read
            If IsDBNull(rdDB!PlayerID) Then
                cbLockers.Items.Add(rdDB!LockerID)
            ElseIf CStr(rdDB!PlayerID).Length < 2 Then
                cbLockers.Items.Add(rdDB!LockerID)
            End If
    Loop
        closeDBAll()
    End Sub

    Private Sub loadTrainers()
        SQLstr = String.Format("SELECT Trainer From Trainer WHERE LEN(Trainer) > 1")
        sqlQueryCMD(SQLstr)

        cbTrainer.Items.Clear()
        cbTrainer.Items.Add("")
        Do While rdDB.Read
            cbTrainer.Items.Add(rdDB!Trainer)
        Loop
        closeDBAll()
    End Sub


    Friend Sub setClientID(ByVal val As Integer)
        ClientID = val
    End Sub

    Protected Friend Sub loadClientInfo(ByVal playerID As Integer)
        Try
            updateMobileNum(playerID)
        Catch ex As Exception
        End Try
        SQLstr = String.Format("SELECT PlayerID, LName, FName, MI, BDate, Gender, ContactNum, Height, Weight, GuardianName, GuardianContactNum, Brgy, City, Province, PlayerPic, MoreInfo, MedicalIssues, TrainerID, LockerNumber FROM Player WHERE PlayerID = {0}", playerID)
        sqlQueryCMD(SQLstr)
        Dim trainerID As Integer = Nothing

        If rdDB.HasRows Then
            rdDB.Read()
            txtClientID.Text = rdDB!PlayerID
            txtClientName.Text = String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI)
            txtBdate.Text = rdDB!BDate
            If rdDB!Gender = "M" Then
                txtGender.Text = "Male"
            Else
                txtGender.Text = "Female"
            End If
            txtContactNum.Text = String.Format("{0}", rdDB!ContactNum)
            If rdDB!Height.ToString.Substring(2, 2) = 10 Or rdDB!Height.ToString.Substring(2, 2) = 11 Then
                txtHeight.Text = rdDB!Height
            Else
                txtHeight.Text = rdDB!Height.ToString.Substring(0, 3)
            End If
            If txtGender.Text = "Male" Then
                txtBMI.Text = getBMI(True, txtHeight.Text)
            ElseIf txtGender.Text = "Female" Then
                txtBMI.Text = getBMI(False, txtHeight.Text)
            End If
            txtWeight.Text = rdDB!Weight
            txtGuardianName.Text = rdDB!GuardianName
            txtGuardianContact.Text = rdDB!GuardianContactNum
            txtAddress.Text = String.Format("{0}, {1}, {2}", rdDB!Brgy, rdDB!City, rdDB!Province)
            txtMoreInfo.Text = rdDB!MoreInfo
            txtMedIssues.Text = rdDB!MedicalIssues
            If Not IsDBNull(rdDB!TrainerID) Then
                trainerID = rdDB!TrainerID
            End If
            If rdDB!LockerNumber <> 0 Then
                cbLockers.Text = rdDB!LockerNumber
            End If

            Try
                If Not IsDBNull(rdDB!PlayerPic) Then
                    Dim data As Byte() = DirectCast(rdDB!PlayerPic, Byte())
                    Dim ms As New IO.MemoryStream(data)
                    picClient.Image = Image.FromStream(ms)
                End If
            Catch ex As Exception
                picClient.Image = My.Resources.LogoNoPic
            End Try
        End If
        closeDBAll()

        SQLstr = String.Format("SELECT Trainer FROM Trainer WHERE TrainerID = {0}", trainerID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            If rdDB.Read Then
                cbTrainer.Text = rdDB!Trainer
            End If
        End If
        closeDBAll()
        loadPackages()
    End Sub

    Protected Friend Sub loadPackages() Handles rbActive.CheckedChanged, rbAll.CheckedChanged, rbExpired.CheckedChanged

        If rbAll.Checked = True Then
            SQLstr = String.Format("SELECT Transactions.TransacID, Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, Package.Package, Package.PackagePrice " & _
                                   "FROM Transactions INNER JOIN Package ON Transactions.PackageID = Package.PackageID WHERE Transactions.PlayerID = {0}", txtClientID.Text)
        ElseIf rbActive.Checked = True Then
            SQLstr = String.Format("SELECT Transactions.TransacID, Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, Package.Package, Package.PackagePrice " & _
                                   "FROM Transactions INNER JOIN Package ON Transactions.PackageID = Package.PackageID WHERE Transactions.PlayerID = {0} AND Status = 'True'", txtClientID.Text)
        ElseIf rbExpired.Checked Then
            SQLstr = String.Format("SELECT Transactions.TransacID, Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, Package.Package, Package.PackagePrice " & _
                                   "FROM Transactions INNER JOIN Package ON Transactions.PackageID = Package.PackageID WHERE Transactions.PlayerID = {0} AND Status = 'False'", txtClientID.Text)
        End If
        sqlQueryCMD(SQLstr)

        Dim lstItem As New ListViewItem
        lvPackages.Items.Clear()

        Do While rdDB.Read
            lstItem = lvPackages.Items.Add(rdDB!TransacID)
            lstItem.SubItems.Add(rdDB!Package)
            lstItem.SubItems.Add(CDate(rdDB!PackStartDate).ToString("MMM dd, yyyy"))
            lstItem.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
            lstItem.SubItems.Add(rdDB!PackagePrice)
            If rdDB!Status = True Then
                lstItem.SubItems.Add("Active")
            Else
                lstItem.SubItems.Add("Expired")
            End If
        Loop

        closeDBAll()
    End Sub

    Protected Friend Sub grabPackage(ByVal id As Integer)
        SQLstr = String.Format("SELECT PackageID, Package, PackagePrice, Limit, TimeUnit FROM Package WHERE PackageID = {0}", id)

        sqlQueryCMD(SQLstr)

        Dim lvItem As New ListViewItem

        If rdDB.HasRows Then
            rdDB.Read()
            If lvPackages.Items.Count > 0 Then
                For i As Integer = 0 To lvPackages.Items.Count - 1
                    If lvPackages.Items.Item(i).SubItems(0).Text = rdDB!PackageID Then
                        MessageBox.Show("Package is already in the list!" & vbCrLf & "Select a different package!")
                        GoTo closeLine

                    End If
                Next
            End If
            lvItem = lvPackages.Items.Add(rdDB!PackageID)
            lvItem.SubItems.Add(rdDB!Package)
            lvItem.SubItems.Add(Now.ToShortDateString)
            Select Case rdDB!TimeUnit
                Case "M"
                    lvItem.SubItems.Add(Now.AddMonths(rdDB!Limit).ToShortDateString)
                Case "D"
                    lvItem.SubItems.Add(Now.AddDays(rdDB!Limit).ToShortDateString)
                Case "W"
                    lvItem.SubItems.Add(Now.AddDays(CInt(rdDB!Limit) * 7).ToShortDateString)
            End Select
            lvItem.SubItems.Add(rdDB!PackagePrice)

        End If
closeLine:
        closeDBAll()
    End Sub

    Protected Friend Sub saveNewPackage()
        If lvPackages.Items.Count > 0 Then
            For i As Integer = 0 To lvPackages.Items.Count() - 1
                SQLstr = String.Format("INSERT INTO Transactions(TransacDate, PackageID, PlayerID, PackStartDate, PackExpireDate, Status) " & _
                                      "VALUES('{0}', {1}, '{2}', '{3}', '{4}', 'True')",
                                      dateValue(Now.Date), lvPackages.Items(i).SubItems(0).Text, txtClientID.Text, lvPackages.Items(i).SubItems(2).Text, lvPackages.Items(i).SubItems(3).Text)
                sqlNonQueryCMD(SQLstr)
            Next
        End If
    End Sub
#End Region

    Friend Sub frmCheckin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadAvailLockers()
        loadTrainers()
        oldLocker = Val(cbLockers.Text)
        'Delay(2)
        'btnClose_Click(sender, e)
    End Sub




    Friend Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        frmMain.Enabled = True
        Me.Close()
    End Sub


    Private Function isMember(ByVal id As Integer) As Boolean
        SQLstr = String.Format("SELECT isMember FROM Player WHERE PlayerID = {0}", id)
        sqlQueryCMD(SQLstr)
        Dim bool As Boolean = False
        If rdDB.HasRows Then
            rdDB.Read()
            bool = rdDB!isMember
        End If
        closeDBAll()
        Return bool
    End Function

    Private Sub btnNewPackage_Click(sender As System.Object, e As System.EventArgs) Handles btnNewPackage.Click
        Me.Enabled = False
        Me.TopMost = False
        If isMember(txtClientID.Text) Then
            frmPackageSelector.loadMemberPackages()
        Else
            frmPackageSelector.loadNonMemberPackages()
        End If
        frmPackageSelector.Show()
        'frmPackageSelector.TopMost = True
    End Sub

    Private Sub btnEditInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditFingerID.Click
        Me.Enabled = False
        Me.TopMost = False
        frmClientUpdateInfo.loadClientInfo(txtClientID.Text)
        frmClientUpdateInfo.ShowDialog()
        ' frmUpdateFingerID.TopMost = True
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If lvPackages.SelectedItems.Count = 1 Then
            Dim msg = MsgBox("Are you sure to delete this member package?", MsgBoxStyle.YesNo, "Delete package")
            If msg = MsgBoxResult.Yes Then
                SQLstr = String.Format("DELETE FROM Transactions WHERE TransacID = {0}", lvPackages.SelectedItems(0).SubItems(0).Text)
                sqlNonQueryCMD(SQLstr)
                MessageBox.Show("Package has been successfully deleted.", "Operation success!")
                loadPackages()
                frmMonitoringList.loadMonthlySubs()
            Else
                MessageBox.Show("No changes made!", "Operation cancelled?")
            End If
        End If
    End Sub


    Private Function Trainer() As Integer
        SQLstr = String.Format("SELECT TrainerID FROM Trainer WHERE Trainer = '{0}'", cbTrainer.Text)
        sqlQueryCMD(SQLstr)
        Dim val As Integer = Nothing
        If rdDB.HasRows Then
            rdDB.Read()
            val = rdDB!TrainerID
        End If
        closeDBAll()
        Return val
    End Function

    Private Sub btnUpdateTrainer_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateTrainer.Click
        Try
            SQLstr = String.Format("UPDATE Player SET TrainerID = {0} WHERE PlayerID ='{1}'", Trainer, txtClientID.Text)
            sqlNonQueryCMD(SQLstr)
            If cbTrainer.Text.Length > 2 Then
                MessageBox.Show("Client is now assigned to a trainer!", "Save success")
            Else
                MessageBox.Show("Trainer is now removed from client!", "Save success")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving trainer!", "Save Error")
        End Try
    End Sub


    Dim oldLocker As Integer = Nothing
    Private Sub btnUpdateLocker_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateLocker.Click
        If cbLockers.Text.Trim(" ") = "" Then
            MessageBox.Show(String.Format("Locker assignment is now removed!", cbLockers.Text))
            Dim lockerNum As Integer = 0
            SQLstr = String.Format("UPDATE Player SET LockerNumber = '{0}' WHERE PlayerID ='{1}'", lockerNum, txtClientID.Text)
            sqlNonQueryCMD(SQLstr)
            SQLstr = String.Format("Update Locker Set PlayerID = 0 WHERE LockerID = {0}", oldLocker)
            sqlNonQueryCMD(SQLstr)
            Exit Sub
        End If

        ''Following code group needs to be with each other 
        If oldLocker <> 0 Then
            SQLstr = String.Format("UPDATE Locker SET PlayerID = 0 WHERE LockerID ='{0}'", oldLocker)
            sqlNonQueryCMD(SQLstr)

        End If
        SQLstr = String.Format("UPDATE Player SET LockerNumber = '{0}' WHERE PlayerID ='{1}'", cbLockers.Text, txtClientID.Text)
        sqlNonQueryCMD(SQLstr)

        SQLstr = String.Format("UPDATE Locker SET PlayerID = '{0}' WHERE LockerID ='{1}'", txtClientID.Text, cbLockers.Text)
        sqlNonQueryCMD(SQLstr)
        oldLocker = Val(cbLockers.Text)
        MessageBox.Show(String.Format("Locker {0} is now assigned", cbLockers.Text))
        ''until here

    End Sub


    Private Sub btnMeasurement_Click(sender As System.Object, e As System.EventArgs) Handles btnMeasurement.Click
        Me.Enabled = False
        Me.TopMost = False
        frmMeasurement.ShowDialog()
    End Sub


End Class