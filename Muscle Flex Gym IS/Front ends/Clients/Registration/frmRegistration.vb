'Imports System.Threading
'Imports DPUruNet
'Imports DPUruNet.Constants

Public Class frmRegistration
    Private WithEvents camModule As New clsCamModule

    Private WithEvents ticker As New Windows.Forms.Timer


#Region "Properties"
    Private pID As Integer
    Private Property playerID As String
        Get
            Return pID
        End Get
        Set(value As String)
            pID = value
        End Set
    End Property

    Private sex As String
    Private Property Gender As String
        Get
            Return sex
        End Get
        Set(value As String)
            sex = value
        End Set
    End Property


    Private picCapture As Boolean
    Private Property imgHasCaptured As Boolean
        Get
            Return picCapture
        End Get
        Set(value As Boolean)
            picCapture = value
        End Set
    End Property

    Private forUpdate As Boolean
    Friend Property isForUpdate As Boolean
        Get
            Return forUpdate
        End Get
        Set(value As Boolean)
            forUpdate = value
        End Set
    End Property

    Private cliType As Boolean
    Public Property clientType As Boolean
        Get
            Return cliType
        End Get
        Set(value As Boolean)
            cliType = value
        End Set
    End Property

#End Region

#Region "Functions"
    Private Function ClientNum() As String
        Dim id As String = ""

        'Dim SQLstr As String = String.Format("SELECT MAX(Substring(PlayerID, 5, 3)) as PlayerID FROM Player WHERE Substring(PlayerID, 1, 2) = '{0}'", CInt(Now.Year.ToString.Substring(2, 2)))
        Dim SQLstr As String = String.Format("SELECT COUNT(PlayerID) as PlayerID FROM Player WHERE Substring(PlayerID, 1, 2) = '{0}'", CInt(Now.Year.ToString.Substring(2, 2)))
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            If Not IsDBNull(rdDB!PlayerID) Then
                id = CInt(rdDB!PlayerID) + 1
            Else
                id = "1"
            End If
        End If
        closeDBAll()

        Dim mon As String = Now.Month
        If mon.Length = 1 Then
            mon = "0" + mon
        Else
            mon = mon
        End If

        Do Until id.Length = 4
            id = "0" + id
        Loop

        Return String.Format("{0}{1}{2}", (Now.Date.Year.ToString.Substring(2, 2)), mon, id) 'to be edited
    End Function

    Private Function checkDuplicate() As Boolean
        Dim val As Boolean
        SQLstr = String.Format("SELECT PlayerID FROM Player WHERE Lname = '{0}' AND Fname = '{1}' AND MI = '{2}' AND Brgy = '{3}'",
                                                                    txtLname.Text, txtFname.Text, txtMname.Text, txtBrgy.Text)
        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            val = True
        Else
            val = False
        End If
        closeDBAll()
        Return val
    End Function

    Private Function dtpDateSetter(month As Integer, day As Integer, year As Integer) As Date
        Dim val As Date
        val = CDate(String.Format("{0}/{1}/{2}", month + 1, day, year))

        Return val
    End Function

    Private Function dtpBdate() As Date
        Return dtpDateSetter(cbMonth.SelectedIndex, cbDay.Text, cbYear.Text).ToShortDateString
    End Function


    Private Function getTrainerID(ByVal trainer) As Integer
        SQLstr = String.Format("SELECT TrainerID FROM Trainer WHERE Trainer = '{0}'", trainer)
        sqlQueryCMD(SQLstr)
        Dim val As Integer = Nothing
        If rdDB.HasRows Then
            rdDB.Read()
            val = rdDB!PlayerID
        End If
        Return val
    End Function
#End Region

#Region "Subs"

    Private Sub setDateValues()
        cbYear.Items.Clear()
        For i As Integer = 0 To 100 Step 1
            cbYear.Items.Add(Now.Year - i)
        Next

        cbDay.Text = Now.Day
        cbMonth.SelectedIndex = Now.Month - 1
        cbYear.Text = Now.Year
    End Sub

    Private Sub setGenderValue() Handles rbFemale.CheckedChanged, rbMale.CheckedChanged
        If rbMale.Checked Then
            Gender = rbMale.Text.Substring(0, 1)
        ElseIf rbFemale.Checked Then
            Gender = rbFemale.Text.Substring(0, 1)
        End If
    End Sub

    Private Sub saveClientProfile()
        If txtHeight.TextLength = 0 Or txtHeight.Text = "." Then
            txtHeight.Text = "5"
        End If
        If txtWeight.TextLength = 0 Or txtWeight.Text = "." Then
            txtWeight.Text = "50"
        End If
        If txtGuardianContact.TextLength < 5 Then
            txtGuardianContact.Text = "09464338325".Trim(" ")
        End If
        If txtMobileNum.TextLength < 5 Then
            txtMobileNum.Text = "09464338325".Trim(" ")
        End If

        SQLstr = String.Format("INSERT INTO Player(PlayerID, " & _
                                                  "Lname, Fname, MI, " & _
                                                  "Gender, ContactNum, CivilStatus, " & _
                                                  "Occupation, EmailAdd, Citizenship, " & _
                                                  "Height, Weight, " & _
                                                  "GuardianName, GuardianContactNum, " & _
                                                  "Brgy, City, Province, " & _
                                                  "MoreInfo, MedicalIssues, " & _
                                                  "IsMember, " & _
                                                  "LockerNumber, " & _
                                                  "Bdate) " & _
                                             "VALUES('{0}', " & _
                                                    "'{1}', '{2}', '{3}', " & _
                                                    "'{4}', '{5}', '{6}', " & _
                                                    "'{7}', '{8}', '{9}', " & _
                                                    "{10}, {11}, " & _
                                                    "'{12}', {13}, " & _
                                                    "'{14}', '{15}', '{16}', " & _
                                                    "'{17}', '{18}', " & _
                                                    "'{19}', " & _
                                                    "'{20}', " & _
                                                    "'{21}') ", lblClientID.Text,
                                                    txtLname.Text, txtFname.Text, txtMname.Text,
                                                    Gender, txtMobileNum.Text, cbCivilStatus.Text,
                                                    txtOccupation.Text, txtEmailAdd.Text, txtCitizenship.Text,
                                                    txtHeight.Text, txtWeight.Text,
                                                    txtGuardianName.Text, txtGuardianContact.Text,
                                                    txtBrgy.Text, txtCity.Text, txtProvince.Text,
                                                    txtAddInfo.Text, txtMedIssues.Text,
                                                    clientType,
                                                    Val(cbLockers.Text),
                                                    dtpBdate())

        sqlNonQueryCMD(SQLstr)
        If clientType = True Then
            updateMembership(lblClientID.Text)
        End If
        If imgHasCaptured Then
            updateProfilePic(lblClientID.Text)
        End If
        'If chkRegFinger.Checked And lblVerified.Text = "SUCCESS" Then
        '    updateFingerID(lblClientID.Text)
        'End If
        Try
            If cbTrainer.Text.Length <= 2 Then
                SQLstr = String.Format("SELECT TrainerID From Trainer WHERE Trainer = '{0}'", cbTrainer.Text)
                sqlQueryCMD(SQLstr)
                Dim trID As Integer = 0
                If rdDB.HasRows Then
                    rdDB.Read()
                    trID = rdDB!TrainerID
                Else
                    trID = 0
                End If
                closeDBAll()
                If trID <> 0 Then
                    updateTrainer(trID)
                End If
            End If
        Catch ex As Exception
        End Try

        saveMeasurement(lblClientID.Text)
    End Sub

    Private Sub updateRFID()
        SQLstr = String.Format("UPDATE Player SET RFIDnum = '{0}' WHERE PlayerID = {1}", txtRFIDnum.Text, lblClientID.Text)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private Sub updateTrainer(id As Integer)
        SQLstr = String.Format("UPDATE Player SET TrainerID = {0} WHERE PlayerID ='{1}'", id, playerID)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private Sub updateLocker(ByVal PlayerID)
        ''Following code group needs to be with each other
        SQLstr = String.Format("UPDATE Player SET LockerNumber = '{0}' WHERE PlayerID ='{1}'", cbLockers.Text, PlayerID)
        sqlNonQueryCMD(SQLstr)

        SQLstr = String.Format("UPDATE Locker SET PlayerID = '{0}' WHERE LockerID ='{1}'", PlayerID, cbLockers.Text)
        sqlNonQueryCMD(SQLstr)

        MessageBox.Show(String.Format("Locker {0} is now assigned", cbLockers.Text))
        ''until here
    End Sub

    Private Sub updateMembership(ByVal PlayerID)
        'SQLstr = String.Format("UPDATE Player SET MemshipStart = '{0}', MemshipEnd = '{1}', isMember = 'True' WHERE PlayerID = {2}", dateValue(dtpMembershipStart.Value), dateValue(dtpMembershipEnd.Value), PlayerID)
        'sqlNonQueryCMD(SQLstr)
    End Sub

    'Private Sub updateFingerID(ByVal id)
    '    SQLstr = String.Format("UPDATE Player SET FingerID = '{0}' WHERE PlayerID = {1}", Fmd.SerializeXml(fmdRightIndex), id)
    '    sqlNonQueryCMD(SQLstr)
    'End Sub

    Private Sub updateProfilePic(id As Integer)
        Dim rand As New Random
        Dim imgVar As String = "@img" + TimeOfDay.Second.ToString + rand.Next(0, 20).ToString

        SQLstr = String.Format("UPDATE Player SET PlayerPic = {0} WHERE PlayerID = {1}", imgVar, id)
        comDB.Parameters.Add(New SqlClient.SqlParameter(imgVar, SqlDbType.Image)).Value = IO.File.ReadAllBytes(camModule.imgURL)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private Sub saveMeasurement(ByVal id)
        SQLstr = String.Format("INSERT INTO PlayerStats(PlayerID, Weight, MeasurementDate) VALUES('{0}', {1}, '{2}')", id, txtWeight.Text, dateValue(Now.Date))
        sqlNonQueryCMD(SQLstr)
    End Sub

    Protected Friend Sub saveTransactions()
        For i As Integer = 0 To lvPacks.Items.Count() - 1
            SQLstr = String.Format("INSERT INTO Transactions(TransacDate, PackageID, PlayerID, PackStartDate, PackExpireDate, Status, isExpired, SessionRemain) " & _
                                  "VALUES('{0}', {1}, '{2}', '{3}', '{4}', 'True', 'False', DATEDIFF(day, CONVERT(date, '{3}'), '{4}'))",
                                  dateValue(Now.Date), lvPacks.Items(i).SubItems(0).Text, lblClientID.Text, lvPacks.Items(i).SubItems(2).Text, lvPacks.Items(i).SubItems(3).Text)
            sqlNonQueryCMD(SQLstr)
        Next
    End Sub

    Protected Friend Sub saveTransacRecord()
        For i As Integer = 0 To lvPacks.Items.Count() - 1
            SQLstr = String.Format("INSERT INTO TransacRecords(PackageID, PlayerID, DateRecorded) VALUES({0}, '{1}', '{2}')", _
                                                     lvPacks.Items(i).SubItems(0).Text,
                                                     lblClientID.Text,
                                                     dateValue(Now.Date))
            sqlNonQueryCMD(SQLstr)
        Next

    End Sub

    Private Sub saveTempClientInfo()
        tempFname = txtFname.Text
        tempLname = txtLname.Text
        tempMI = txtMname.Text

        tempBdate = dtpBdate()
        If rbMale.Checked = True Then
            tempGender = rbMale.Checked
        Else
            tempGender = rbFemale.Checked
        End If

        tempCivStat = cbCivilStatus.Text
        tempCitizenship = txtCitizenship.Text
        tempEmailAdd = txtEmailAdd.Text

        tempMobilNum = txtMobileNum.Text
        tempOccupation = txtOccupation.Text
        tempHeight = txtHeight.Text
        tempWeight = txtWeight.Text

        tempContactName = txtGuardianContact.Text
        tempContactNum = txtGuardianContact.Text

        tempBrgy = txtBrgy.Text
        tempCity = txtCity.Text
        tempProvince = txtProvince.Text
    End Sub

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
        SQLstr = String.Format("SELECT Trainer FROM Trainer WHERE LEN(Trainer) > 2")
        sqlQueryCMD(SQLstr)

        cbTrainer.Items.Clear()
        cbTrainer.Items.Add("")
        Do While rdDB.Read
            cbTrainer.Items.Add(rdDB!Trainer)
        Loop
        closeDBAll()
    End Sub

    Private Sub loadSuggestedList(ByVal reValue As String, ByVal txtObj As TextBox)
        SQLstr = String.Format("SELECT DISTINCT({0}) AS txt FROM Player WHERE {0} Like '{1}%'", reValue, txtObj.Text)
        sqlQueryCMD(SQLstr)

        Do While rdDB.Read()
            txtObj.AutoCompleteCustomSource.Add(rdDB!txt)
        Loop
        closeDBAll()
    End Sub

    Protected Friend Sub grabPackage(ByVal id As Integer)
        SQLstr = String.Format("SELECT PackageID, Package, PackagePrice, Limit, TimeUnit FROM Package WHERE PackageID = {0}", id)

        sqlQueryCMD(SQLstr)

        Dim lvItem As New ListViewItem

        If rdDB.HasRows Then
            rdDB.Read()
            If lvPacks.Items.Count > 0 Then
                For i As Integer = 0 To lvPacks.Items.Count - 1
                    If lvPacks.Items.Item(i).SubItems(0).Text = rdDB!PackageID Then
                        MessageBox.Show("Package is already in the list!" & vbCrLf & "Select a different package!")
                        GoTo closeLine

                    End If
                Next
            End If
            lvItem = lvPacks.Items.Add(rdDB!PackageID)
            lvItem.SubItems.Add(rdDB!Package)
            lvItem.SubItems.Add(Now.ToShortDateString)
            Select Case rdDB!TimeUnit
                Case "M"
                    lvItem.SubItems.Add(Now.AddMonths(rdDB!Limit).ToShortDateString)
                Case "D"
                    lvItem.SubItems.Add(Now.AddDays(0).ToShortDateString)
                Case "Y"
                    lvItem.SubItems.Add(Now.AddYears((rdDB!Limit).ToShortDateString))
            End Select
            lvItem.SubItems.Add(rdDB!PackagePrice)
        End If
closeLine:
        closeDBAll()

        isPackageHasLocker(id)
    End Sub

    Protected Friend Sub isPackageHasLocker(ByVal packageID As Integer)
        ''Check Package if hasLocker
        SQLstr = String.Format("Select hasLocker FROM Package WHERE PackageID = {0}", packageID)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            If rdDB!hasLocker = True Then
                cbLockers.Enabled = True
            Else
                cbLockers.Enabled = False
            End If
        End If
        closeDBAll()
    End Sub

    Protected Friend Sub loadCustomSourceList()
        loadSuggestedList("Lname", txtLname)
        loadSuggestedList("Fname", txtFname)
        loadSuggestedList("Brgy", txtBrgy)
        loadSuggestedList("City", txtCity)
        loadSuggestedList("Province", txtProvince)
        loadSuggestedList("Occupation", txtOccupation)
    End Sub



#End Region

    ''FP Reader

    '#Region "Fp Reader Handler"
    '    Dim fmdRightIndex As Fmd 'temporarily store enrollment data to be saved to db
    '    Private count As Integer

    '    Dim lblStatus As New System.Windows.Forms.Label
    '    'Dim WithEvents txtEnroll As System.Windows.Forms.TextBox

    '    Private _readers As ReaderCollection
    '    Dim fpReader As DPUruNet.Reader
    '    Dim preenrollmentFmds As List(Of Fmd) = New List(Of Fmd)
    '    Dim userIdList1 As List(Of String) = New List(Of String)
    '    Private Const DPFJ_PROBABILITY_ONE As Integer = &H7FFFFFFF

    '    ''' <summary>
    '    ''' Holds fmds enrolled by the enrollment GUI.
    '    ''' </summary>
    '    Public Property Fmds() As Dictionary(Of Int16, Fmd)
    '        Get
    '            Return _fmds
    '        End Get
    '        Set(ByVal value As Dictionary(Of Int16, Fmd))
    '            _fmds = value
    '        End Set
    '    End Property
    '    Private _fmds As Dictionary(Of Int16, Fmd) = New Dictionary(Of Int16, Fmd)

    '    ''' <summary>
    '    ''' Reset the UI causing the user to reselect a reader.
    '    ''' </summary>
    '    Public Property Reset() As Boolean
    '        Get
    '            Return _reset
    '        End Get
    '        Set(ByVal value As Boolean)
    '            _reset = value
    '        End Set
    '    End Property
    '    Private _reset As Boolean

    '    ' When set by child forms, shows s/n and enables buttons.
    '    Public Property CurrentReader() As Reader
    '        Get
    '            Return _currentReader
    '        End Get
    '        Set(ByVal value As Reader)
    '            _currentReader = value
    '            'SendMessage(Action.UpdateReaderState, value)
    '        End Set
    '    End Property
    '    Private _currentReader As Reader

    '    ''' <summary>
    '    ''' Open a device and check result for errors.
    '    ''' </summary>
    '    ''' <returns>Returns true if successful; false if unsuccessful</returns>
    '    Public Function OpenReader() As Boolean
    '        Reset = False
    '        Dim result As Constants.ResultCode = Constants.ResultCode.DP_DEVICE_FAILURE

    '        result = _currentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE)

    '        If result <> Constants.ResultCode.DP_SUCCESS Then
    '            MessageBox.Show("Error:  " & result.ToString())
    '            Reset = True
    '            Return False
    '        End If

    '        Return True
    '    End Function

    '    ''' <summary>
    '    ''' Hookup capture handler and start capture.
    '    ''' </summary>
    '    ''' <param name="OnCaptured">Delegate to hookup as handler of the On_Captured event</param>
    '    ''' <returns>Returns true if successful; false if unsuccessful</returns>
    '    Public Function StartCaptureAsync(ByVal OnCaptured As Reader.CaptureCallback) As Boolean
    '        AddHandler _currentReader.On_Captured, OnCaptured

    '        If Not CaptureFingerAsync() Then
    '            Return False
    '        End If

    '        Return True
    '    End Function


    '    ''' <summary>
    '    ''' Cancel the capture and then close the reader.
    '    ''' </summary>
    '    ''' <param name="OnCaptured">Delegate to unhook as handler of the On_Captured event </param>
    '    Public Sub CancelCaptureAndCloseReader(ByVal OnCaptured As Reader.CaptureCallback)
    '        If _currentReader IsNot Nothing Then
    '            ' Dispose of reader handle and unhook reader events.
    '            CurrentReader.Dispose()

    '            If (Reset) Then
    '                CurrentReader = Nothing
    '            End If
    '        End If
    '    End Sub

    '    ''' <summary>
    '    ''' Check the device status before starting capture.
    '    ''' </summary>
    '    Public Sub GetStatus()
    '        Dim result = _currentReader.GetStatus()

    '        If (result <> ResultCode.DP_SUCCESS) Then
    '            If CurrentReader IsNot Nothing Then
    '                Reset = True
    '                Throw New Exception("" & result.ToString())
    '            End If
    '        End If

    '        If (_currentReader.Status.Status = ReaderStatuses.DP_STATUS_BUSY) Then
    '            Thread.Sleep(50)
    '        ElseIf (_currentReader.Status.Status = ReaderStatuses.DP_STATUS_NEED_CALIBRATION) Then
    '            _currentReader.Calibrate()
    '        ElseIf (_currentReader.Status.Status <> ReaderStatuses.DP_STATUS_READY) Then
    '            Throw New Exception("Reader Status - " & CurrentReader.Status.Status.ToString())
    '        End If
    '    End Sub

    '    ''' <summary>
    '    ''' Check quality of the resulting capture.
    '    ''' </summary>
    '    Public Function CheckCaptureResult(ByVal captureResult As CaptureResult) As Boolean
    '        If captureResult.Data Is Nothing Then
    '            If captureResult.ResultCode <> Constants.ResultCode.DP_SUCCESS Then
    '                Reset = True
    '                Throw New Exception("" & captureResult.ResultCode.ToString())
    '            End If

    '            If captureResult.Quality <> Constants.CaptureQuality.DP_QUALITY_CANCELED Then
    '                Throw New Exception("Quality - " & captureResult.Quality.ToString())
    '            End If
    '            Return False
    '        End If
    '        Return True
    '    End Function

    '    ''' <summary>
    '    ''' Function to capture a finger. Always get status first and calibrate or wait if necessary.  Always check status and capture errors.
    '    ''' </summary>
    '    Public Function CaptureFingerAsync() As Boolean
    '        Try
    '            GetStatus()

    '            Dim captureResult = _currentReader.CaptureAsync(Formats.Fid.ANSI, _
    '                                                   CaptureProcessing.DP_IMG_PROC_DEFAULT, _
    '                                                    _currentReader.Capabilities.Resolutions(0))

    '            If captureResult <> ResultCode.DP_SUCCESS Then
    '                Reset = True
    '                Throw New Exception("" + captureResult.ToString())
    '            End If

    '            Return True
    '        Catch ex As Exception
    '            MessageBox.Show("Error:  " & ex.Message)
    '            Return False
    '        End Try
    '    End Function

    '    ''' <summary>
    '    ''' Create a bitmap from raw data in row/column format.
    '    ''' </summary>
    '    Public Function CreateBitmap(ByVal bytes As [Byte](), ByVal width As Integer, ByVal height As Integer) As Bitmap
    '        Dim rgbBytes As Byte() = New Byte(bytes.Length * 3 - 1) {}

    '        For i As Integer = 0 To bytes.Length - 1
    '            rgbBytes((i * 3)) = bytes(i)
    '            rgbBytes((i * 3) + 1) = bytes(i)
    '            rgbBytes((i * 3) + 2) = bytes(i)
    '        Next
    '        Dim bmp As New Bitmap(width, height, PixelFormat.Format24bppRgb)

    '        Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.[WriteOnly], PixelFormat.Format24bppRgb)

    '        For i As Integer = 0 To bmp.Height - 1
    '            Dim p As New IntPtr(data.Scan0.ToInt64() + data.Stride * i)
    '            System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3)
    '        Next

    '        bmp.UnlockBits(data)

    '        Return bmp
    '    End Function

    '    ''' <summary>
    '    ''' Handler for when a fingerprint is captured.
    '    ''' </summary>
    '    ''' <param name="captureResult">contains info and data on the fingerprint capture</param>
    '    Public Sub OnCaptured(ByVal captureResult As CaptureResult)
    '        Try
    '            ' Check capture quality and throw an error if bad.
    '            If Not CheckCaptureResult(captureResult) Then Return

    '            count += 1

    '            Dim resultConversion As DataResult(Of Fmd) = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Formats.Fmd.ANSI)

    '            If resultConversion.ResultCode <> Constants.ResultCode.DP_SUCCESS Then
    '                Reset = True
    '                Throw New Exception("" & resultConversion.ResultCode.ToString())
    '            End If

    '            preenrollmentFmds.Add(resultConversion.Data)
    '            fmdRightIndex = (resultConversion.Data)

    '            SendMessage(Action.SendMessage, "A finger was captured.")

    '            Dim FPBitmap As Bitmap = CreateBitmap(captureResult.Data.Views(0).RawImage, captureResult.Data.Views(0).Width, captureResult.Data.Views(0).Height)

    '            'Draw image to screen
    '            pbFingerprint.Image = New Bitmap(FPBitmap, pbFingerprint.Width, pbFingerprint.Height)

    '            BeginInvoke(Function()
    '                            SendMessage(Action.SendMessage, "Finger Print Captured")

    '                            lblSampCount.Text = String.Format("Needed Samples: {0} of 4", count.ToString)

    '                            Return True
    '                        End Function)

    '            'matchedClientFP()

    '            If count = 4 Then
    '                Dim resultEnrollment As DataResult(Of Fmd) = DPUruNet.Enrollment.CreateEnrollmentFmd(Formats.Fmd.ANSI, preenrollmentFmds)

    '                If resultEnrollment.ResultCode = ResultCode.DP_SUCCESS Then
    '                    SendMessage(Action.SendMessage, "An enrollment FMD was successfully created.")
    '                    Dim msg = MsgBox("Fingerprint template was created successfully." & vbNewLine & "Do you to continue with this template?", MsgBoxStyle.OkOnly)

    '                    SendMessage(Action.SendMessage, "Success")

    '                    If msg = MsgBoxResult.Ok Then
    '                        CancelCaptureAndCloseReader(AddressOf OnCaptured)
    '                    End If
    '                    count = 0

    '                    preenrollmentFmds.Clear()
    '                    Return
    '                ElseIf (resultEnrollment.ResultCode = Constants.ResultCode.DP_ENROLLMENT_INVALID_SET) Then
    '                    SendMessage(Action.SendMessage, "Enrollment was unsuccessful.  Please try again.")
    '                    SendMessage(Action.SendMessage, "Place a finger on the reader.")

    '                    count = 0

    '                    preenrollmentFmds.Clear()
    '                    Return
    '                End If
    '            End If

    '            SendMessage(Action.SendMessage, "Now place the same finger on the reader.")

    '        Catch ex As Exception
    '            SendMessage(Action.SendMessage, "Error:  " & ex.Message)
    '        End Try
    '    End Sub


    '    ''' <summary>
    '    ''' Close window.
    '    ''' </summary>
    '    Private Sub Enrollment_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '        CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
    '    End Sub

    '#Region "SendMessage"
    '    Public Enum Action
    '        SendMessage
    '    End Enum
    '    Private Delegate Sub SendMessageCallback(ByVal action As Action, ByVal payload As String)
    '    Private Sub SendMessage(ByVal action As Action, ByVal payload As String)
    '        On Error Resume Next

    '        If Me.txtEnroll.InvokeRequired Then
    '            Dim d As New SendMessageCallback(AddressOf SendMessage)
    '            Me.Invoke(d, New Object() {action, payload})
    '        Else
    '            Select Case action
    '                Case action.SendMessage
    '                    txtEnroll.Text += payload & vbCrLf & vbCrLf
    '                    txtEnroll.SelectionStart = txtEnroll.TextLength
    '                    txtEnroll.ScrollToCaret()
    '                    lblStatus.Text = payload

    '                    If lblStatus.Text = "Success" Then
    '                        lblVerified.Text = "SUCCESS"
    '                        pnlData.Enabled = True
    '                    End If
    '            End Select
    '        End If
    '    End Sub
    '#End Region

    '#End Region

    Private Sub frmRegistration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setDateValues()

        grpPage1.Size = New Size(928, 473)
        'loadPackages()
        ticker.Interval = 200
        ticker.Start()
        lblClientID.Text = ClientNum()

        camModule.OpenPreviewWindow(camModule.LoadDeviceList, picPreview)
        'MessageBox.Show(clientType)


        If clientType = True Then
            'connectGSM()

            lblClientType.Text = "MEMBERSHIP REGISTRATION"
            ' pnlPackage.Enabled = True
            loadAvailLockers()
            loadTrainers()
        Else
            lblClientType.Text = "NON-MEMBERSHIP REGISTRATION"
            ' pnlPackage.Enabled = False
        End If

        If isForUpdate = True Then
            btnConfirm.Image = My.Resources.icons8_edit_row_sm
            btnConfirm.Text = "UPDATE"
        Else
            btnConfirm.Image = My.Resources.icons8_save_button_sm
            btnConfirm.Text = "SAVE"
        End If
        txtRFIDnum.Focus()

    End Sub

    Protected Friend Sub totalPack()
        Dim total As Decimal = 0.0
        If lvPacks.Items.Count > 0 Then
            For x As Integer = 0 To lvPacks.Items.Count - 1
                total += lvPacks.Items(x).SubItems(4).Text
            Next
            lblTotalPack.Text = String.Format("Php {0:n}", total)
        Else
            lblTotalPack.Text = String.Format("Php {0:n}", total)
        End If
    End Sub

    Private Sub ticker_tick() Handles ticker.Tick
        If txtFname.Text = "" And txtLname.Text = "" Then
            btnConfirm.Enabled = False
        Else
            btnConfirm.Enabled = True
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If checkDuplicate() = True Then
            MessageBox.Show("Client already in the database!", "DUPLICATE CLIENT")
            Exit Sub
        End If

        Dim msgAll As String '= msgRegInfo(txtLname.Text + ", " + txtFname.Text,
        '                         CDate(dtpMembershipStart.Value.ToShortDateString).ToString("MMM dd, yyyy"),
        '                         CDate(dtpMembershipEnd.Value.ToShortDateString).ToString("MMM dd, yyyy"))
        Dim msg1 As String
        Dim msg2 As String

        If clientType Then
            'If txtMobileNum.Text.Length <> 11 Then
            '    Dim msg = MsgBox("The client mobile number is invalid and cannot be used to send SMS notice." + _
            '                     vbCr + "Click YES if you want to continue without sending notice." + _
            '                     vbCr + "Click NO to edit the mobile number and try again.", MsgBoxStyle.YesNo, "Invalid mobile number!")
            '    If msg = MsgBoxResult.Yes Then
            '        saveClientProfile()
            '        MessageBox.Show("New client will now be added into the system!", "SAVE SUCCESS")
            '    Else
            '        Exit Sub
            '    End If
            'Else
            saveClientProfile()
            MessageBox.Show("New client will now be added into the system!", "SAVE SUCCESS")
            '    If msgAll.Length > 160 Then
            '        msg1 = msgAll.Substring(0, 156)
            '        msg2 = msgAll.Substring(msg1.Length, msgAll.Length - msg1.Length)
            '        sendNoticeSMS(txtMobileNum.Text, msg1 + vbCr + "1/2")
            '        sendNoticeSMS(txtMobileNum.Text, msg2 + vbCr + "2/2")
            '        MessageBox.Show("Message Sent!")
            '    Else
            '        sendNoticeSMS(txtMobileNum.Text, msgAll)
            '        MessageBox.Show("Message Sent!")
            '    End If
            'End If
        Else
            saveClientProfile()
            MessageBox.Show("New client will now be added into the system!", "SAVE SUCCESS")
        End If

        updateRFID()
        If lvPacks.Items.Count > 0 Then
            saveTransactions()

            Dim itemData(5) As String
            For x As Integer = 0 To lvPacks.Items.Count - 1
                For y As Integer = 0 To lvPacks.Items(x).SubItems.Count - 1
                    itemData.SetValue(lvPacks.Items(x).SubItems(y).Text, y)
                Next
                msgAll = msgMonthlySubsInfo(txtLname.Text + ", " + txtFname.Text,
                                                itemData.GetValue(2),
                                                itemData.GetValue(3),
                                                itemData.GetValue(1))
                If msgAll.Length > 160 Then
                    msg1 = msgAll.Substring(0, 156)
                    msg2 = msgAll.Substring(msg1.Length, msgAll.Length - msg1.Length)
                    sendNoticeSMS(txtMobileNum.Text, msg1 + vbCr + "1/2")
                    sendNoticeSMS(txtMobileNum.Text, msg2 + vbCr + "2/2")
                Else
                    sendNoticeSMS(txtMobileNum.Text, msgAll)
                End If
            Next

        End If
        'CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)


        'Dim printRegForm = MsgBox("Do you want to print registration form?", MsgBoxStyle.YesNo, "Registration form!")
        'If printRegForm = MsgBoxResult.Yes Then
        '    Dim printRpt As New clsPrintReport
        '    printRpt.printRegForm(Container, lblClientID.Text)
        'End If

        btnClose_Click(sender, e)
    End Sub

    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        Try

            If imgHasCaptured = False Then
                picPreview.Image = My.Resources.icons8_camera_outline
                camModule.captureImage("img" & Now.ToFileTime.ToString & ".jpg", picPreview) 'Edit to Username when active directory
                camModule.ClosePreviewWindow()
                imgHasCaptured = True
            Else
                saveTempClientInfo()
                If lblClientType.Text = "MEMBERSHIP REGISTRATION" Then
                    frmMain.NewMemberToolStripMenuItem_Click(sender, e)
                ElseIf lblClientType.Text = "NON-MEMBERSHIP REGISTRATION" Then
                    frmMain.NewNonMemberToolStripMenuItem_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        grpPage1.Visible = True
        'CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
    End Sub

    Private Sub btnSelectImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectImage.Click
        Dim _ofd As New System.Windows.Forms.OpenFileDialog
        If _ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim filePath As String = IO.Path.GetFullPath(_ofd.FileName)
            Dim bmp As New Bitmap(filePath)

            If Not IsNothing(picPreview.Image) Then picPreview.Image.Dispose()
            picPreview.Image = bmp
            camModule.imgURL = filePath
            camModule.ClosePreviewWindow()
            imgHasCaptured = True
        End If

    End Sub

    Private Sub lnkTerms_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim frmTrm As New frmTerms
        frmTrm.ShowDialog()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        grpPage1.Visible = False
        'dtpMembershipEnd.Value = dtpMembershipStart.Value.AddYears(1)
        totalPack()
    End Sub


    'Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cbReaderSelect.Items.Count < 1 Then
    '        cbReaderSelect.Text = String.Empty
    '        cbReaderSelect.Items.Clear()
    '        cbReaderSelect.SelectedIndex = -1

    '        _readers = ReaderCollection.GetReaders()

    '        For Each Reader As Reader In _readers
    '            cbReaderSelect.Items.Add(Reader.Description.SerialNumber)
    '        Next
    '        If cbReaderSelect.Items.Count > 0 Then
    '            cbReaderSelect.Enabled = False
    '            btnRefresh.Hide()
    '            cbReaderSelect.SelectedIndex = 0
    '        Else
    '            btnRefresh.Show()
    '            cbReaderSelect.Enabled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub cbReaderSelect_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ''Reader
    '    CurrentReader = _readers(cbReaderSelect.SelectedIndex)
    '    SendMessage(Action.SendMessage, "Place a finger on the reader.")

    '    If Not OpenReader() Then
    '        Me.Close()
    '    End If

    '    If Not StartCaptureAsync(AddressOf Me.OnCaptured) Then
    '        Me.Close()
    '    End If
    '    ''End Reader
    'End Sub


    Private Sub dtpBdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbYear.SelectedIndexChanged
        If cbYear.Items.Count >= 100 Then
            txtAge.Clear()
            txtAge.Text = Now.Year - CDate(dtpBdate()).Year
            If Now.Month < CDate(dtpBdate()).Month Then
                txtAge.Text -= 1
            End If
        End If
    End Sub


    Private Sub txtMobileNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress, txtMobileNum.KeyPress, txtHeight.KeyPress, txtGuardianContact.KeyPress
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'frmMain.btnRefresh_Click(sender, e)
        Me.Dispose()
        frmMain.MonitoringToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnAddPackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPackage.Click
        If clientType = True Then
            frmPackageSelector.loadMemberPackages()
        Else
            frmPackageSelector.loadNonMemberPackages()
        End If

        frmPackageSelector.ShowDialog()
        totalPack()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If lvPacks.SelectedItems.Count = 1 Then
            For i As Integer = 0 To lvPacks.Items.Count() - 1
                If lvPacks.Items(i).Selected Then
                    lvPacks.Items(i).Remove()
                    Exit For
                End If
            Next
        End If
        totalPack()
    End Sub


    Private Sub dtpMembershipStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dtpMembershipEnd.Value = dtpMembershipStart.Value.AddYears(1)
    End Sub

    'Private Sub chkRegFinger_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If chkRegFinger.Checked = True Then
    '        preenrollmentFmds = New List(Of Fmd)
    '        count = 0

    '        lblSampCount.Text = String.Format("Needed Samples: {0} of 4", count.ToString)

    '        SendMessage(Action.SendMessage, "Place a finger on the reader.")

    '        btnRefresh_Click(sender, e)

    '    Else
    '        lblSampCount.Text = String.Format("Needed Samples: {0} of 4", count.ToString)
    '        lblVerified.Text = "STATUS"
    '        CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
    '    End If
    'End Sub

    Private Sub txtHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeight.TextChanged
        txtBMI.Text = CustomsConsts.getBMI(rbMale.Checked, (txtHeight.Text))
    End Sub

    Private Sub cbMonth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMonth.GotFocus

    End Sub

    Private Sub cbMonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMonth.KeyDown
        If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then
            cbMonth.SelectedIndex = 0
        ElseIf e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then
            cbMonth.SelectedIndex = 1
        ElseIf e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then
            cbMonth.SelectedIndex = 2
        ElseIf e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then
            cbMonth.SelectedIndex = 3
        ElseIf e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then
            cbMonth.SelectedIndex = 4
        ElseIf e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then
            cbMonth.SelectedIndex = 5
        ElseIf e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then
            cbMonth.SelectedIndex = 6
        ElseIf e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then
            cbMonth.SelectedIndex = 7
        ElseIf e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then
            cbMonth.SelectedIndex = 8
        ElseIf e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0 Then
            cbMonth.SelectedIndex = 9
        End If

    End Sub


    Private Sub btnRenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenew.Click
        txtRFIDnum.Clear()
    End Sub


    Private Function isRFIDAvail(ByVal rfid As String) As Boolean
        SQLstr = String.Format("SELECT PlayerID, Fname, Lname FROM Player WHERE RFIDnum = '{0}'", rfid)
        sqlQueryCMD(SQLstr)
        If Not rdDB.HasRows Then
            isRFIDAvail = True
        Else
            rdDB.Read()
            isRFIDAvail = False
        End If
        closeDBAll()
    End Function

    Dim RFIDAvail As Boolean = False

    Private Sub txtRFIDnum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRFIDnum.KeyDown
        If e.KeyCode = Keys.Enter Then
            RFIDAvail = isRFIDAvail(txtRFIDnum.Text)
            If RFIDAvail = False Then
                txtRFIDnum.BackColor = Color.Crimson
                Delay(1)
                Dim pop As New frmConfirmPopper
                pop = New frmConfirmPopper
                pop.SetPromptTexts("RFID is already Assigned to another client!", "Change RFID Card!")
                pop.Dispose()
                txtRFIDnum.Clear()
                txtRFIDnum.Focus()
                txtRFIDnum.BackColor = Color.White
            Else
                txtRFIDnum.BackColor = Color.LightGreen
                txtFname.Focus()
            End If
        End If

    End Sub

End Class