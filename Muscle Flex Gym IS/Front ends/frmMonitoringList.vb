Public Class frmMonitoringList
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
                               "DELETE FROM Player WHERE PlayerID = '{0}'", id)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Protected Friend Sub loadMonitoringLists()
        'Try
        ''Constant Changers 
        Transac_StatusCheck_Changer()
        Membership_StatusCheck_Changer()

        ''Checks
        chkNeedsRenew.Checked = False
        chkShowAllClients.Checked = False
        chkShowExpired.Checked = False
        txtSearchClient.Text = ""

        ''Monthly
        loadMonthlySubs()

        ''Checkins
        loadCheckIns(dtpSelector.Value)

        ''Membership
        loadYearlyMembership()
        'Catch ex As Exception

        'End Try

    End Sub

    Protected Friend Sub loadMonthlySubs()
        SQLstr = String.Format("SELECT     Transactions.TransacID, Player.Lname, Player.Fname, Player.MI, Package.Package, " & _
                                          "Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, " & _
                                          "DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) + 1 as DaysRemain " & _
                               "FROM         Player INNER JOIN " & _
                                          "Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN " & _
                                          "Package ON Transactions.PackageID = Package.PackageID " & _
                               "WHERE     (Package.TimeUnit = 'M') AND (Transactions.Status = 1) AND (isExpired = 0) " & _
                               "ORDER BY DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate)")
        sqlQueryCMD(SQLstr)

        lvMonthlyMonitor.Items.Clear()
        Dim itemx As New ListViewItem
        Do While rdDB.Read
            itemx = lvMonthlyMonitor.Items.Add(rdDB!TransacID)
            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
            itemx.SubItems.Add(rdDB!DaysRemain)
            If rdDB!DaysRemain <= 5 Then
                itemx.BackColor = Color.Crimson
                itemx.ForeColor = Color.White
            ElseIf rdDB!DaysRemain <= 10 Then
                itemx.BackColor = Color.DarkOrange
            Else
                itemx.BackColor = Color.LimeGreen
            End If
        Loop
        closeDBAll()
    End Sub

    Private Sub loadSearchedMonthly()
        SQLstr = String.Format("SELECT     Transactions.TransacID, Player.Lname, Player.Fname, Player.MI, Package.Package, " & _
                                  "Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, " & _
                                  "DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) + 1 as DaysRemain " & _
                       "FROM         Player INNER JOIN " & _
                                  "Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN " & _
                                  "Package ON Transactions.PackageID = Package.PackageID " & _
                       "WHERE     (Package.TimeUnit = 'M') AND (Transactions.Status = 0)  " & _
                       "ORDER BY DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate)")
        sqlQueryCMD(SQLstr)

        lvMonthlyMonitor.Items.Clear()
        Dim itemx As New ListViewItem
        Do While rdDB.Read
            itemx = lvMonthlyMonitor.Items.Add(rdDB!TransacID)
            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
            itemx.SubItems.Add(rdDB!DaysRemain)
            If rdDB!DaysRemain <= 0 Then
                itemx.BackColor = Color.Gray
                itemx.ForeColor = Color.White
            End If
        Loop
        closeDBAll()
    End Sub


    Private Sub loadExpiredMonthly()
        SQLstr = String.Format("SELECT     Transactions.TransacID, Player.Lname, Player.Fname, Player.MI, Package.Package, " & _
                                  "Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, " & _
                                  "DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) + 1 as DaysRemain " & _
                       "FROM         Player INNER JOIN " & _
                                  "Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN " & _
                                  "Package ON Transactions.PackageID = Package.PackageID " & _
                       "WHERE     (Package.TimeUnit = 'M') AND (Transactions.Status = 0)  " & _
                       "ORDER BY DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate)")
        sqlQueryCMD(SQLstr)

        lvMonthlyMonitor.Items.Clear()
        Dim itemx As New ListViewItem
        Do While rdDB.Read
            itemx = lvMonthlyMonitor.Items.Add(rdDB!TransacID)
            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
            itemx.SubItems.Add(rdDB!DaysRemain)
            If rdDB!DaysRemain <= 0 Then
                itemx.BackColor = Color.Gray
                itemx.ForeColor = Color.White
            End If
        Loop
        closeDBAll()
    End Sub

    Private Sub loadForRenew_Monthly()
        SQLstr = String.Format("SELECT     Transactions.TransacID, Player.Lname, Player.Fname, Player.MI, Package.Package, " & _
                                  "Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, " & _
                                  "DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) + 1 as DaysRemain " & _
                       "FROM         Player INNER JOIN " & _
                                  "Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN " & _
                                  "Package ON Transactions.PackageID = Package.PackageID " & _
                       "WHERE     (Package.TimeUnit = 'M') AND (Transactions.Status = 0) AND  DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) <= 15 " & _
                       "ORDER BY DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate)")
        sqlQueryCMD(SQLstr)

        lvMonthlyMonitor.Items.Clear()
        Dim itemx As New ListViewItem
        Do While rdDB.Read
            itemx = lvMonthlyMonitor.Items.Add(rdDB!TransacID)
            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If
            itemx.SubItems.Add(rdDB!Package)
            itemx.SubItems.Add(CDate(rdDB!PackExpireDate).ToString("MMM dd, yyyy"))
            itemx.SubItems.Add(rdDB!DaysRemain)
            If rdDB!DaysRemain <= 0 Then
                itemx.BackColor = Color.Crimson
                itemx.ForeColor = Color.White
            End If

            If rdDB!DaysRemain <= 5 Then
                itemx.BackColor = Color.Crimson
                itemx.ForeColor = Color.White
            ElseIf rdDB!DaysRemain <= 15 Then
                itemx.BackColor = Color.DarkOrange
            End If
        Loop
        closeDBAll()
    End Sub


    Protected Friend Sub loadYearlyMembership()
        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI, FingerID, isMember, MemShipStart, MemShipEnd, " & _
                                      "DATEDIFF(day,CONVERT(date, GetDate()), MemShipEnd) + 1 as DaysRemain, PlayerPic " & _
                               "FROM Player WHERE isMember = 'True' ORDER BY DaysRemain ASC")
        sqlQueryCMD(SQLstr)

        lvMembers.Items.Clear()
        Dim itemx As New ListViewItem

        Dim count As Integer = 1

        Do While rdDB.Read
            itemx = lvMembers.Items.Add(rdDB!PlayerID)

            itemx.SubItems.Add(count)

            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If


            If rdDB!DaysRemain <= 0 Then
                itemx.SubItems.Add("NON-MEMBER")
            End If

            If Not IsDBNull(rdDB!MemShipStart) Then
                If rdDB!DaysRemain <= 0 Then
                    itemx.SubItems.Add("NON-MEMBER")
                Else
                    itemx.SubItems.Add(CDate(rdDB!MemShipStart).ToString("MMM dd, yyyy"))
                    itemx.SubItems.Add(CDate(rdDB!MemShipEnd).ToString("MMM dd, yyyy"))

                    If rdDB!DaysRemain <= 365 Then
                        itemx.SubItems.Add(rdDB!DaysRemain)
                    ElseIf rdDB!DaysRemain = 366 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 1)
                    ElseIf rdDB!DaysRemain = 367 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 2)
                    End If


                    If rdDB!DaysRemain <= 10 Then
                        itemx.BackColor = Color.IndianRed
                    End If
                    If rdDB!DaysRemain <= 30 Then
                        itemx.BackColor = Color.DarkOrange
                    End If
                    If rdDB!DaysRemain > 30 Then
                        itemx.BackColor = Color.Lime
                    End If
                End If



                'If IsDBNull(rdDB!FingerID) Then
                '    itemx.BackColor = Color.Firebrick
                '    itemx.ForeColor = Color.White
                'End If
                'If IsDBNull(rdDB!PlayerPic) Then
                '    'itemx.ForeColor = Color.Gold
                '    itemx.BackColor = Color.Gold
                'End If
                'If IsDBNull(rdDB!FingerID) And IsDBNull(rdDB!PlayerPic) Then
                '    'itemx.ForeColor = Color.Black
                '    itemx.BackColor = Color.DarkViolet
                'End If

            Else
                itemx.SubItems.Add("NON-MEMBER")
                'itemx.BackColor = Color.Black
                'itemx.ForeColor = Color.White
            End If

            count += 1
        Loop
        closeDBAll()


        SQLstr = String.Format("SELECT COUNT(PlayerID) AS totalMem FROM Player WHERE isMember = 1")
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows() Then
            rdDB.Read()
            lblTotalMembers.Text = String.Format("TOTAL MEMBERS: {0}", rdDB!totalMem)
        End If
        closeDBAll()
    End Sub

    Private Sub loadAllClients()
        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI, FingerID, PlayerPic, isMember, MemShipStart, MemShipEnd, DATEDIFF(day,CONVERT(date, GetDate()), MemShipEnd)  + 1  as DaysRemain FROM Player ORDER BY PlayerID ASC")
        sqlQueryCMD(SQLstr)

        lvMembers.Items.Clear()
        Dim itemx As New ListViewItem
        Dim count As Integer = 1

        Do While rdDB.Read
            itemx = lvMembers.Items.Add(rdDB!PlayerID)

            itemx.SubItems.Add(count)

            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If

            If Not IsDBNull(rdDB!MemShipStart) Then
                If rdDB!DaysRemain <= 0 Then
                    itemx.SubItems.Add("NON-MEMBER")
                Else
                    itemx.SubItems.Add(CDate(rdDB!MemShipStart).ToString("MMM dd, yyyy"))
                    itemx.SubItems.Add(CDate(rdDB!MemShipEnd).ToString("MMM dd, yyyy"))

                    If rdDB!DaysRemain <= 365 Then
                        itemx.SubItems.Add(rdDB!DaysRemain)
                    ElseIf rdDB!DaysRemain = 366 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 1)
                    ElseIf rdDB!DaysRemain = 367 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 2)
                    End If


                    If rdDB!DaysRemain <= 10 Then
                        itemx.BackColor = Color.IndianRed
                    End If
                    If rdDB!DaysRemain <= 30 Then
                        itemx.BackColor = Color.DarkOrange
                    End If
                    If rdDB!DaysRemain > 30 Then
                        itemx.BackColor = Color.Lime
                    End If
                End If

                'If IsDBNull(rdDB!FingerID) Then
                '    itemx.BackColor = Color.Firebrick
                '    itemx.ForeColor = Color.White
                'End If
                'If IsDBNull(rdDB!PlayerPic) Then
                '    itemx.BackColor = Color.Gold
                'End If
                'If IsDBNull(rdDB!FingerID) And IsDBNull(rdDB!PlayerPic) Then
                '    itemx.BackColor = Color.DarkViolet
                'End If

                'If rdDB!DaysRemain <= 0 Then
                '    itemx.BackColor = Color.Black
                '    itemx.ForeColor = Color.White
                'End If
            Else
                itemx.SubItems.Add("NON-MEMBER")
                'itemx.BackColor = Color.Black
                'itemx.ForeColor = Color.White
            End If

            count += 1
        Loop

        closeDBAll()
    End Sub


    Protected Friend Sub loadClientsForRenew_Yearly()
        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI, FingerID, PlayerPic,  isMember, MemShipStart, MemShipEnd, DATEDIFF(day,CONVERT(date, GetDate()), MemShipEnd) + 1  as DaysRemain FROM Player WHERE isMember = 'False' ORDER BY DATEDIFF(day,MemShipStart, MemShipEnd) ASC")
        sqlQueryCMD(SQLstr)

        lvMembers.Items.Clear()
        Dim itemx As New ListViewItem

        Dim count As Integer = 1

        Do While rdDB.Read
            itemx = lvMembers.Items.Add(rdDB!PlayerID)

            itemx.SubItems.Add(count)

            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If


            If Not IsDBNull(rdDB!MemShipStart) Then
                If rdDB!DaysRemain <= 0 Then
                    itemx.SubItems.Add("NON-MEMBER")
                Else
                    itemx.SubItems.Add(CDate(rdDB!MemShipStart).ToString("MMM dd, yyyy"))
                    itemx.SubItems.Add(CDate(rdDB!MemShipEnd).ToString("MMM dd, yyyy"))

                    If rdDB!DaysRemain <= 365 Then
                        itemx.SubItems.Add(rdDB!DaysRemain)
                    ElseIf rdDB!DaysRemain = 366 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 1)
                    ElseIf rdDB!DaysRemain = 367 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 2)
                    End If


                    If rdDB!DaysRemain <= 10 Then
                        itemx.BackColor = Color.IndianRed
                    End If
                    If rdDB!DaysRemain <= 30 Then
                        itemx.BackColor = Color.DarkOrange
                    End If
                    If rdDB!DaysRemain > 30 Then
                        itemx.BackColor = Color.Lime
                    End If
                End If



                'If IsDBNull(rdDB!FingerID) Then
                '    itemx.BackColor = Color.Firebrick
                '    itemx.ForeColor = Color.White
                'End If
                'If IsDBNull(rdDB!PlayerPic) Then
                '    itemx.BackColor = Color.Gold
                'End If
                'If IsDBNull(rdDB!FingerID) And IsDBNull(rdDB!PlayerPic) Then
                '    itemx.BackColor = Color.DarkViolet
                'End If

                'If rdDB!DaysRemain <= 0 Then
                '    itemx.BackColor = Color.Black
                '    itemx.ForeColor = Color.White
                'End If
            Else
                itemx.SubItems.Add("NON-MEMBER")
                'itemx.BackColor = Color.Black
                'itemx.ForeColor = Color.White
            End If

            count += 1
        Loop
        closeDBAll()
    End Sub

    Protected Friend Sub loadSearchedClient(ByVal searchVal As String)
        If txtSearchClient.TextLength = 0 Then
            chkShowAllClients.Checked = False
            loadYearlyMembership()
        End If

        SQLstr = String.Format("SELECT PlayerID, Lname, Fname, MI, FingerID, PlayerPic,  isMember, MemShipStart, MemShipEnd, DATEDIFF(day,CONVERT(date, GetDate()), MemShipEnd) + 1  as DaysRemain FROM Player WHERE Lname LIKE '%{0}%' OR Fname LIKE '%{0}%'", searchVal)
        sqlQueryCMD(SQLstr)

        lvMembers.Items.Clear()
        Dim itemx As New ListViewItem

        Dim count As Integer = 1

        Do While rdDB.Read
            itemx = lvMembers.Items.Add(rdDB!PlayerID)

            itemx.SubItems.Add(count)

            If rdDB!MI.ToString.Length < 1 Then
                itemx.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))
            Else
                itemx.SubItems.Add(String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI))
            End If

            If Not IsDBNull(rdDB!MemShipStart) Then
                If rdDB!DaysRemain <= 0 Then
                    itemx.SubItems.Add("NON-MEMBER")
                Else
                    itemx.SubItems.Add(CDate(rdDB!MemShipStart).ToString("MMM dd, yyyy"))
                    itemx.SubItems.Add(CDate(rdDB!MemShipEnd).ToString("MMM dd, yyyy"))

                    If rdDB!DaysRemain <= 365 Then
                        itemx.SubItems.Add(rdDB!DaysRemain)
                    ElseIf rdDB!DaysRemain = 366 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 1)
                    ElseIf rdDB!DaysRemain = 367 Then
                        itemx.SubItems.Add(Val(rdDB!DaysRemain) - 2)
                    End If


                    If rdDB!DaysRemain <= 10 Then
                        itemx.BackColor = Color.IndianRed
                    End If
                    If rdDB!DaysRemain <= 30 Then
                        itemx.BackColor = Color.DarkOrange
                    End If
                    If rdDB!DaysRemain > 30 Then
                        itemx.BackColor = Color.Lime
                    End If
                End If


                'If IsDBNull(rdDB!FingerID) Then
                '    itemx.BackColor = Color.Firebrick
                '    itemx.ForeColor = Color.White
                'End If
                'If IsDBNull(rdDB!PlayerPic) Then
                '    itemx.BackColor = Color.Gold
                'End If
                'If IsDBNull(rdDB!FingerID) And IsDBNull(rdDB!PlayerPic) Then
                '    itemx.BackColor = Color.DarkViolet
                'End If

                'If rdDB!DaysRemain <= 0 Then
                '    itemx.BackColor = Color.Black
                '    itemx.ForeColor = Color.White
                'End If
            Else
                itemx.SubItems.Add("NON-MEMBER")
                'itemx.BackColor = Color.Black
                'itemx.ForeColor = Color.White
            End If

            count += 1
        Loop
        closeDBAll()
    End Sub

    Protected Friend Sub loadCheckIns(ByVal dtSelector As Date)


        SQLstr = String.Format("SELECT Player.PlayerID, Player.Lname, Player.Fname, Player.IsMember, Player.MemShipEnd, " + _
                                      "Attendance.AttendanceID, Attendance.LoginTime, Attendance.LogoutTime, Attendance.LockerNum, Attendance.isLockerReturned  " + _
                               "FROM Player RIGHT OUTER JOIN Attendance ON Player.PlayerID = Attendance.PlayerID " + _
                               "WHERE (Attendance.LogDate = '{0}') ORDER BY AttendanceID DESC", dateValue(dtSelector))
        sqlQueryCMD(SQLstr)

        lvCheckedinClients.Items.Clear()
        Dim lvi As New ListViewItem
        Dim count As Integer = 1


        Do While rdDB.Read
            lvi = lvCheckedinClients.Items.Add(rdDB!PlayerID) '0

            lvi.SubItems.Add(count)

            lvi.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))

            If Not IsDBNull(rdDB!LockerNum) Then
                If rdDB!LockerNum = 0 Then
                    lvi.SubItems.Add("")
                Else
                    lvi.SubItems.Add(rdDB!LockerNum)
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

        'For x As Integer = 0 To lvCheckedinClients.Items.Count - 1
        '    SQLstr = String.Format("SELECT Status, isExpired FROM Transactions WHERE PlayerID = '{0}'", lvCheckedinClients.Items(x).SubItems(0).Text)
        '    sqlQueryCMD(SQLstr)

        '    If rdDB.HasRows Then
        '        rdDB.Read()
        '        If rdDB!Status = "False" Then
        '            lvCheckedinClients.Items(x).BackColor = Color.Gray
        '            lvCheckedinClients.Items(x).ForeColor = Color.White
        '        End If
        '    End If
        '    closeDBAll()
        'Next
        If lvCheckedinClients.Items.Count > 0 Then
            If lvCheckedinClients.Items(0).SubItems(1).Text = 1 Then
                lvCheckedinClients.Items(0).ForeColor = Color.Blue
                lvCheckedinClients.Items(0).BackColor = Color.LawnGreen
            End If
        End If


    End Sub


    'Protected Friend Sub loadCheckIns(ByVal dtSelector As Date)


    '    SQLstr = String.Format("SELECT Player.PlayerID, Player.Lname, Player.Fname, Player.LockerNumber, Player.IsMember, Attendance.LoginTime, Attendance.LogoutTime FROM Player RIGHT OUTER JOIN Attendance ON Player.PlayerID = Attendance.PlayerID WHERE (Attendance.LogDate = '{0}') ORDER BY LoginTime DESC", dateValue(dtSelector))
    '    sqlQueryCMD(SQLstr)

    '    lvCheckedinClients.Items.Clear()
    '    Dim lvi As New ListViewItem
    '    Dim count As Integer = 1
    '    'Dim rdItems As New ArrayList

    '    'Do While rdDB.Read
    '    '    If Not rdItems.Contains(rdDB!PlayerID) Then
    '    '        rdItems.Add(rdDB!PlayerID)
    '    '    End If
    '    'Loop

    '    Do While rdDB.Read
    '        For x As Integer = 0 To lvCheckedinClients.Items.Count - 1

    '        Next
    '        If Not lvCheckedinClients.Items.Contains(rdDB!PlayerID) Then
    '            lvi = lvCheckedinClients.Items.Add(rdDB!PlayerID) '0

    '            lvi.SubItems.Add(count)   '1

    '            lvi.SubItems.Add(String.Format("{0}, {1}", rdDB!Lname, rdDB!Fname))

    '            If Not IsDBNull(rdDB!LockerNumber) Then
    '                If rdDB!LockerNumber = 0 Then
    '                    lvi.SubItems.Add("")
    '                Else
    '                    lvi.SubItems.Add(rdDB!LockerNumber)
    '                End If
    '            Else
    '                lvi.SubItems.Add("")
    '            End If


    '            If rdDB!isMember = True Then
    '                lvi.SubItems.Add("Yes")
    '            Else
    '                lvi.SubItems.Add("No")
    '                lvi.BackColor = Color.Black
    '                lvi.ForeColor = Color.White
    '            End If

    '            If Not IsDBNull(rdDB!LogoutTime) Then
    '                lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
    '                lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LogoutTime.ToString)).ToShortTimeString)
    '            Else
    '                lvi.SubItems.Add(CDate(String.Format("{0} {1}", dateValue(Now.Date), rdDB!LoginTime.ToString)).ToShortTimeString)
    '                lvi.SubItems.Add("")
    '            End If
    '            count += 1
    '        End If

    '    Loop
    '    closeDBAll()

    '    For x As Integer = 0 To lvCheckedinClients.Items.Count - 1
    '        SQLstr = String.Format("SELECT Status FROM Transactions WHERE PlayerID = '{0}'", lvCheckedinClients.Items(x).SubItems(0).Text)
    '        sqlQueryCMD(SQLstr)

    '        If rdDB.HasRows Then
    '            rdDB.Read()
    '            If rdDB!Status = "False" Then
    '                lvCheckedinClients.Items(x).BackColor = Color.Gray
    '                lvCheckedinClients.Items(x).ForeColor = Color.White
    '            End If
    '        End If
    '        closeDBAll()
    '    Next
    'End Sub


#End Region

    Public Sub frmClientList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonitoringLists()
        'sendToExpiredMonthly()
    End Sub

    Private Sub PrintRegistrationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintRegistrationFormToolStripMenuItem.Click
        If lvMembers.SelectedItems.Count = 1 Then
            If lvMembers.SelectedItems(0).SubItems(2).Text = "NON-MEMBER" Then
                MessageBox.Show("Selected client is not a official member!", "Operation cannot continue")
                Exit Sub
            End If
            PlayerID = lvMembers.SelectedItems(0).SubItems(0).Text.Trim

            Dim printRpt As New clsPrintReport
            printRpt.printRegForm(Container, PlayerID)
            frmReportViewer.lblReportHeader.Text = "Registration Form"
        End If

    End Sub

    Private Sub ViewClientDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewClientDetailsToolStripMenuItem.Click, ViewClientDetailsToolStripMenuItem.Click, lvMonthlyMonitor.MouseDoubleClick
        If lvMembers.SelectedItems.Count = 1 Then
            frmMain.Enabled = False
            frmClientInfo.loadClientInfo(lvMembers.SelectedItems(0).SubItems(0).Text.Trim)
            frmClientInfo.Show()
        End If
    End Sub


    Private Sub RegisterAsMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterAsMemberToolStripMenuItem.Click

        SQLstr = String.Format("SELECT isMember FROM Player WHERE PlayerID = {0}", lvMembers.SelectedItems(0).SubItems(0).Text)
        sqlQueryCMD(SQLstr)
        Dim isMember As Boolean

        If rdDB.HasRows Then
            rdDB.Read()
            isMember = rdDB!isMember
        End If
        closeDBAll()

        If lvMembers.SelectedItems.Count = 1 Then
            If isMember = False Then
                Dim msgDia = MsgBox("This will convert selected client to a member status" & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNo, "Confirm member registration")
                If msgDia = MsgBoxResult.Yes Then
                    Dim clientID As String = lvMembers.SelectedItems(0).SubItems(0).Text
                    SQLstr = String.Format("UPDATE Player SET isMember ='True', MemShipStart = '{0}', MemShipEnd = '{1}' WHERE PlayerID =  '{2}'", dateValue(Now.Date), Now.AddYears(1).ToShortDateString, clientID)
                    sqlNonQueryCMD(SQLstr)
                    chkShowAllClients_CheckedChanged(sender, e)
                    MessageBox.Show("Client is now an official member, Congratulations!")
                    frmClientInfo.loadClientInfo(clientID)
                    frmClientInfo.ShowDialog()
                End If
            Else
                MessageBox.Show("Client is already a member")
            End If
        End If
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim printRpt As New clsPrintReport
        printRpt.printAttendanceByDate(Container, dtpSelector.Value)

    End Sub

    Private Sub dtpSelector_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSelector.ValueChanged
        loadCheckIns(sender.value)
    End Sub

    Private Sub chkShowAllClients_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAllClients.CheckedChanged
        If chkShowAllClients.Checked = True Then
            chkNeedsRenew.Checked = False
            loadAllClients()
        Else
            loadYearlyMembership()
        End If
    End Sub

    Private Sub chkNeedsRenew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNeedsRenew.CheckedChanged
        If chkNeedsRenew.Checked = True Then
            chkShowAllClients.Checked = False
            loadClientsForRenew_Yearly()
        Else
            loadYearlyMembership()
        End If
    End Sub

    Private Sub UpdateFingerprintIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFingerprintIDToolStripMenuItem.Click
        'frmMain.CancelCaptureAndCloseReader(AddressOf frmMain.OnCaptured)
        frmUpdateFingerID.loadClientInfo(lvMembers.SelectedItems(0).SubItems(0).Text)
        frmUpdateFingerID.Show()
        'frmUpdateFingerID.TopMost = True
        frmMain.Enabled = False
    End Sub

    Private Sub btnPrintSubsforRenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSubsforRenew.Click
        Dim printRpt As New clsPrintReport
        printRpt.printSubsUnder14Days(Container)
    End Sub

    Private Sub chkShowExpired_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowExpired.CheckedChanged
        If chkShowExpired.Checked Then
            loadExpiredMonthly()
        Else
            loadMonthlySubs()
        End If
    End Sub

    Private Sub RenewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenewToolStripMenuItem.Click
        If lvMonthlyMonitor.SelectedItems.Count = 1 Then
            frmClientMonthlyRenew.loadClientPackage(lvMonthlyMonitor.SelectedItems(0).SubItems(0).Text)
            frmClientMonthlyRenew.ShowDialog()
        End If
    End Sub

    Private Sub chkShowforRenew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If chkShowforRenew.Checked = True Then
        '    chkShowExpired.Checked = False
        '    loadForRenew_Monthly()
        'Else
        '    loadMonthlySubs()
        'End If
    End Sub

    Private Sub txtSearchClient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchClient.TextChanged
        loadSearchedClient(sender.Text)
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

    Private Sub RenewMembershipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenewMembershipToolStripMenuItem.Click
        If lvMembers.SelectedItems.Count = 1 Then
            frmClientMembershipUpdate.loadPlayer(lvMembers.SelectedItems(0).SubItems(0).Text)
            frmClientMembershipUpdate.ShowDialog()
        End If
    End Sub

    Private Sub DeleteClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteClientToolStripMenuItem.Click
        If lvMembers.SelectedItems.Count = 1 Then
            Dim msg = MsgBox("This will DELETE the client's information in the database permanently." & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNo)
            If msg = MsgBoxResult.Yes Then
                deleteClientPermanent(lvMembers.SelectedItems(0).SubItems(0).Text)
                MessageBox.Show("All records of the client have been successfully deleted!", "Operation success")
                loadMonitoringLists()
            Else
                MessageBox.Show("Operation has been cancelled! No changes made", "Operation canceled")
            End If
        End If
    End Sub

    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMain.sendExpire()
    End Sub

    Private Sub txtSearchMonthly_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchMonthly.TextChanged

    End Sub

    Private Sub RegisterRFIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterRFIDToolStripMenuItem.Click
        If lvMembers.SelectedItems.Count = 1 Then
            frmRFIDUpdate.loadClientInfo(lvMembers.SelectedItems(0).SubItems(0).Text)
            frmRFIDUpdate.ShowDialog()
        End If
    End Sub

    Private Sub lvMembers_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvMembers.MouseDoubleClick
        If lvMembers.SelectedItems.Count = 1 Then
            frmMain.updateAttendance(lvMembers.SelectedItems(0).SubItems(0).Text)
            frmMain.loadClientInfo(lvMembers.SelectedItems(0).SubItems(0).Text)
            loadCheckIns(dtpSelector.Value)

            'updateTransaction(lvMembers.SelectedItems(0).SubItems(0).Text)
        End If
    End Sub

    Sub updateTransaction(ByVal id As String)
        SQLstr = String.Format("INSERT INTO Transactions() ")
    End Sub

    Private Sub AddLockerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLockerToolStripMenuItem.Click
        If lvCheckedinClients.SelectedItems.Count = 1 Then
            Dim frmLocker As New frmUpdateLockerAssign
            frmLocker.loadClientInfo(lvCheckedinClients.SelectedItems(0).SubItems(0).Text)
            frmLocker.ShowDialog()
        End If
    End Sub
End Class
