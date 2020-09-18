Module CustomsConsts

#Region "GSM Module Codes"
    Private port As String
    Private prtData As String = Nothing

    Private Property portNumber As String
        Get
            Return port
        End Get
        Set(ByVal value As String)
            port = value
        End Set
    End Property

    Private Property portData As String
        Get
            Return prtData
        End Get
        Set(ByVal value As String)
            prtData = value
        End Set
    End Property

    Sub setPortData(ByVal data)
        portData = data
    End Sub

    Public Function ModemsConnected() As String
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    'MessageBox.Show(Chr(34))
                    If queryObj("Description").ToString.Contains("HUAWEI") Then
                        portNumber = queryObj("AttachedTo")
                    End If

                    'modems = modems & (queryObj("AttachedTo")) ' & " - " & queryObj("Description") & "***")
                    'MessageBox.Show(modems)
                End If
            Next
        Catch ex As ManagementException
            'MessageBox.Show("An error occurred while querying for WMI data:" & ex.Message)
            'Return ""
        End Try
        Return portNumber
    End Function

    Sub connectGSM()
        Try

            With frmMain.gsmSerialPort
                If Not .IsOpen Then
                    .PortName = ModemsConnected()
                    .BaudRate = 9600
                    .Parity = IO.Ports.Parity.None
                    .DataBits = 8
                    .StopBits = IO.Ports.StopBits.One
                    .Handshake = IO.Ports.Handshake.None
                    .RtsEnable = True
                    .ReceivedBytesThreshold = 1
                    .NewLine = vbCr
                    .ReadTimeout = 1000
                    .Open()
                End If
            End With
            'If frmMain.gsmSerialPort.IsOpen Then
            '    frmMain.picGSMstatus.Image = My.Resources.icons8_connection_status_on
            'Else
            '    frmMain.picGSMstatus.Image = My.Resources.icons8_minus
            'End If
        Catch ex As Exception
            'frmMain.picGSMstatus.Image
            'MsgBox(ex.Message)
            'MessageBox.Show("Error connecting to GSM Modem!")
        End Try
    End Sub


    Function sendNoticeSMS(ByVal MobileNum As String, ByVal msg As String) As Boolean
        Try
            'If MobileNum.Length <> 11 Then
            '    MessageBox.Show("Mobile number is invalid." + vbCr + "Please check and Try again!", "Operation cancelled")
            '    Return False
            '    Exit Function
            'End If


            With frmMain.gsmSerialPort
                .Write("at" & vbCrLf)
                Threading.Thread.Sleep(500)
                .Write("at+cmgf=1" & vbCrLf)
                Threading.Thread.Sleep(500)
                .Write("at+cmgs=" & Chr(34) & MobileNum & Chr(34) & vbCrLf)
                .Write(msg & Chr(26))
                Threading.Thread.Sleep(500)

                'MessageBox.Show(portData)
            End With
            If portData.Contains("ERROR") Then
                Return False
            Else
                Return True
            End If


        Catch ex As Exception
            Return False
        End Try
    End Function


    Function msgRegInfo(ByVal client As String, ByVal startDate As String, ByVal endDate As String) As String
        Dim msg As String = String.Format("Hi {0}, Your now a member of Muscle Flex Fitness Gym." _
                            + vbCrLf _
                            + "FROM: {1}" _
                            + vbCrLf _
                            + "UNTIL: {2}" _
                            + vbCrLf _
                            + "Thank you! Stay fit and healthy!", _
                              client, startDate, endDate)
        Return msg
    End Function

    Function msgRegistrationRenew(ByVal client As String, ByVal startDate As String, ByVal endDate As String) As String
        Dim msg As String = String.Format("Hi {0}, your membership is now renewed." _
                            + vbCrLf _
                            + "FROM: {1}" _
                            + vbCrLf _
                            + "UNTIL: {2}" _
                            + vbCrLf _
                            + "Thank you for you continued support! " _
                            + vbCrLf _
                            + "Stay fit and healthy!", _
                              client, startDate, endDate)
        Return msg
    End Function

    Function msgExpireMembership(ByVal client As String, ByVal startDate As String, ByVal endDate As String) As String
        Dim msg As String = String.Format("Hi {0}, a friendly reminder that your membership is now expired." _
                            + vbCrLf _
                            + "FROM: {1}" _
                            + vbCrLf _
                            + "UNTIL: {2}" _
                            + vbCrLf _
                            + "To renew your membership play visit the gym.", _
                            +vbCrLf _
                            + "Thank you! Stay fit and healthy!", _
                              client, startDate, endDate)
        Return msg
    End Function

    Function msgMonthlySubsInfo(ByVal client As String, ByVal startDate As String, ByVal endDate As String, ByVal package As String) As String
        Dim msg As String = String.Format("Hi {0}, here is your package info." _
                            + vbCrLf _
                            + "Package: {1}" _
                            + vbCrLf _
                            + "Start: {2}" _
                            + vbCrLf _
                            + "Until: {3}" _
                            + vbCrLf _
                            + "Thank you!", _
                            client, package, startDate, endDate)

        Return msg
    End Function

    Function msgMonthlyRenewInfo(ByVal client As String, ByVal startDate As String, ByVal endDate As String, ByVal package As String) As String
        Dim msg As String = String.Format("Hi {0}, you're package is now renewed." _
                            + vbCrLf _
                            + "Package: {1}" _
                            + vbCrLf _
                            + "Start: {2}" _
                            + vbCrLf _
                            + "Until: {3}" _
                            + vbCrLf _
                            + "" _
                            + vbCrLf _
                            + "Thank you!", _
                            client, package, startDate, endDate)

        Return msg
    End Function

    Function msgMonthlyExpiryInfo(ByVal client As String, ByVal endDate As String, ByVal package As String) As String
        Dim msg As String = String.Format("Hi {0}, a friendly reminder from Muscle Flex." _
                            + vbCrLf _
                            + "your monthly package is about to expire tomorrow! " _
                            + vbCrLf _
                            + "Package: {1}" _
                            + vbCrLf _
                            + "You will now be reverted to paying per session basis." _
                            + vbCrLf _
                            + "To enjoy the monthly package privileges with storage locker please feel free and renew your package." _
                            + vbCrLf _
                            + "Please visit us at Muscle Flex Fitness Gym.", _
                            +vbCrLf _
                            + "Thank you!", _
                            client, package, endDate)
        Return msg
    End Function

    Function msgMonthlyExpiredInfo(ByVal client As String, ByVal endDate As String, ByVal package As String) As String
        Dim msg As String = String.Format("Hi {0}, a friendly reminder from Muscle Flex." _
                            + vbCrLf _
                            + "your monthly package is now expired! " _
                            + vbCrLf _
                            + "Package: {1}" _
                            + vbCrLf _
                            + "You will now be reverted to paying per session basis." _
                            + vbCrLf _
                            + "To enjoy the monthly package privileges with storage locker please renew your package." _
                            + vbCrLf _
                            + "Please feel free to visit us at Muscle Flex Fitness Gym.", _
                            +vbCrLf _
                            + "Thank you!", _
                            client, package, endDate)
        Return msg
    End Function

    Function getPlayerMobile(ByVal playerID As String) As String
        SQLstr = String.Format("SELECT ContactNum From Player WHERE PlayerID = '{0}'", playerID)
        sqlQueryCMD(SQLstr)
        Dim MobileNum As String = Nothing

        If rdDB.HasRows Then
            rdDB.Read()
            If rdDB!ContactNum.ToString.Length = 11 Then
                If rdDB!ContactNum.ToString.Substring(0, 2) = "09" Then
                    MobileNum = rdDB!ContactNum
                End If
            ElseIf rdDB!ContactNum.ToString.Length = 10 Then
                MobileNum = "0" + rdDB!ContactNum
            End If

        End If
        closeDBAll()
        Return MobileNum
    End Function


#End Region

    Function sendtoExpiringMonthly() As Boolean
        Try

            SQLstr = String.Format("SELECT     Transactions.TransacID, Player.Lname, Player.Fname, Player.MI, Package.Package, " & _
                                      "Transactions.PackStartDate, Transactions.PackExpireDate, Transactions.Status, " & _
                                      "DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) + 1 as DaysRemain " & _
                           "FROM         Player INNER JOIN " & _
                                      "Transactions ON Player.PlayerID = Transactions.PlayerID INNER JOIN " & _
                                      "Package ON Transactions.PackageID = Package.PackageID " & _
                           "WHERE     (Package.TimeUnit = 'M') AND (Transactions.Status = 0) AND  DATEDIFF(day, CONVERT(date, GetDate()), Transactions.PackExpireDate) + 1 = 1 ")

            sqlQueryCMD(SQLstr)

            Dim contactNum As String = ""
            Dim msgAll As String
            Dim msg1 As String
            Dim msg2 As String

            Do While rdDB.Read
                If Not IsDBNull(rdDB!ContactNum) Then
                    If rdDB!ContactNum.ToString.Length = 11 Then
                        If rdDB!ContactNum.ToString.Substring(0, 2) = "09" Then
                            contactNum = rdDB!ContactNum
                        End If
                    ElseIf rdDB!ContactNum.ToString.Length = 10 Then
                        contactNum = "0" & rdDB!ContactNum
                    End If
                End If
                msgAll = msgMonthlyExpiryInfo(String.Format("{1} {0}", rdDB!Fname, rdDB!Lname),
                                                   CDate(rdDB!PackExpireDate).ToString("mm/dd/yyyy"),
                                                   rdDB!Package)
                Try
                    If msgAll.Length > 160 Then
                        msg1 = msgAll.Substring(0, 156)
                        msg2 = msgAll.Substring(msg1.Length, msgAll.Length - msg1.Length)
                        sendNoticeSMS(getPlayerMobile(contactNum), msg1 + vbCr + "1/2")
                        sendNoticeSMS(getPlayerMobile(contactNum), msg2 + vbCr + "2/2")
                        ' MessageBox.Show("Message Sent!")
                    Else
                        sendNoticeSMS(getPlayerMobile(contactNum), msgAll)
                        ' MessageBox.Show("Message Sent!")
                    End If
                Catch ex As Exception
                    '  MessageBox.Show("There is an error sending the notice")
                End Try
            Loop
            closeDBAll()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Sub Transac_StatusCheck_Changer()
        SQLstr = "UPDATE Transactions SET Transactions.Status = 'False', Transactions.isExpired = 'True' WHERE PackExpireDate < CONVERT(date, GETDATE())"
        sqlNonQueryCMD(SQLstr)
    End Sub

    Sub Membership_StatusCheck_Changer()
        SQLstr = "UPDATE Player SET isMember = 'False' WHERE MemShipEnd < CONVERT(date, GETDATE())"
        sqlNonQueryCMD(SQLstr)
    End Sub



    Sub AddBlankTrainer()
        SQLstr = "SELECT TrainerID FROM Trainer WHERE Trainer = ''"
        sqlQueryCMD(SQLstr)
        Dim hasData As Boolean = False
        If rdDB.HasRows Then
            rdDB.Read()
            hasData = True
        End If
        closeDBAll()
        If Not hasData Then
            SQLstr = "INSERT INTO Trainer(Trainer) VALUES('')"
            sqlNonQueryCMD(SQLstr)
        End If
    End Sub

    Sub updateMobileNum(ByVal PlayerID As String)
        SQLstr = String.Format("UPDATE Player SET ContactNum = '0' + ContactNum WHERE SUBSTRING(ContactNum, 1, 1) = 9 AND PlayerID = '{0}'", PlayerID)
        sqlNonQueryCMD(SQLstr)
    End Sub


    Function dateValue(ByVal dateVal As Date) As String
        Dim dateSet As String = String.Format("{0}-{1}-{2}", dateVal.Year, dateVal.Month, dateVal.Day)
        Return dateSet
    End Function

    Function getNotNullSTR(ByVal val) As String
        Dim txt As String = ""
        If Not IsDBNull(val) Then
            txt = val
            Return txt
        Else
            Return txt
        End If
    End Function




    Function getBMI(ByVal isMale As Boolean, ByVal height As String) As String
        Dim bmi As String = Nothing
        If isMale = True Then
            If height = "4.6" Then
                bmi = "28-35 KG"
            ElseIf height = "4.7" Then
                bmi = "30-39 KG"
            ElseIf height = "4.8" Then
                bmi = "33-40 KG"
            ElseIf height = "4.9" Then
                bmi = "35-44 KG"
            ElseIf height = "4.10" Then
                bmi = "38-46 KG"
            ElseIf height = "4.11" Then
                bmi = "40-50 KG"
            ElseIf height = "5" Or height = "5.0" Then
                bmi = "43-53 KG"
            ElseIf height = "5.1" Then
                bmi = "45-55 KG"
            ElseIf height = "5.2" Then
                bmi = "48-59 KG"
            ElseIf height = "5.3" Then
                bmi = "50-61 KG"
            ElseIf height = "5.4" Then
                bmi = "53-65 KG"
            ElseIf height = "5.5" Then
                bmi = "55-68 KG"
            ElseIf height = "5.6" Then
                bmi = "58-70 KG"
            ElseIf height = "5.7" Then
                bmi = "60-74 KG"
            ElseIf height = "5.8" Then
                bmi = "63-76 KG"
            ElseIf height = "5.9" Then
                bmi = "65-80 KG"
            ElseIf height = "5.10" Then
                bmi = "67-83 KG"
            ElseIf height = "5.11" Then
                bmi = "70-85 KG"
            ElseIf height >= "6" Or height = "6.0" Then
                bmi = "72-89 KG"
            End If
        Else
            If height = "4.6" Then
                bmi = "28-35 KG"
            ElseIf height = "4.7" Then
                bmi = "30-37 KG"
            ElseIf height = "4.8" Then
                bmi = "32-40 KG"
            ElseIf height = "4.9" Then
                bmi = "35-42 KG"
            ElseIf height = "4.10" Then
                bmi = "36-45 KG"
            ElseIf height = "4.11" Then
                bmi = "39-47 KG"
            ElseIf height = "5" Or height = "5.0" Then
                bmi = "40-50 KG"
            ElseIf height = "5.1" Then
                bmi = "43-52 KG"
            ElseIf height = "5.2" Then
                bmi = "45-55 KG"
            ElseIf height = "5.3" Then
                bmi = "47-57 KG"
            ElseIf height = "5.4" Then
                bmi = "49-60 KG"
            ElseIf height = "5.5" Then
                bmi = "51-62 KG"
            ElseIf height = "5.6" Then
                bmi = "53-65 KG"
            ElseIf height = "5.7" Then
                bmi = "55-67 KG"
            ElseIf height = "5.8" Then
                bmi = "57-70 KG"
            ElseIf height = "5.9" Then
                bmi = "59-72 KG"
            ElseIf height = "5.10" Then
                bmi = "61-75 KG"
            ElseIf height = "5.11" Then
                bmi = "63-77 KG"
            ElseIf height >= "6" Or height = "6.0" Then
                bmi = "65-80 KG"
            End If
        End If
        Return bmi
    End Function


    Friend tempFname,
           tempLname,
           tempMI,
           tempExtName,
           tempCivStat,
           tempCitizenship,
           tempEmailAdd,
           tempEmailServ,
           tempMobilNum,
           tempOccupation,
           tempHeight,
           tempWeight,
           tempContactName,
           tempContactNum,
           tempBrgy,
           tempCity,
           tempProvince,
           tempAddInfo,
           tempMedIssues,
           tempTrainer,
           tempLocker As String

    Friend tempGender As Boolean

    Friend tempBdate,
           tempMembershipStart,
           tempMembershipEnd As Date





End Module
