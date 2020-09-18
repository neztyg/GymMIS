Imports System.Threading
Imports DPUruNet
Imports DPUruNet.Constants

Public Class frmUpdateFingerID
#Region "Fp Reader Handler"
    Dim fmdRightIndex As Fmd 'temporarily store enrollment data to be saved to db
    Private count As Integer

    Dim lblStatus As New System.Windows.Forms.Label
    'Dim WithEvents txtEnroll As System.Windows.Forms.TextBox

    Private _readers As ReaderCollection
    Dim fpReader As DPUruNet.Reader
    Dim preenrollmentFmds As List(Of Fmd) = New List(Of Fmd)
    Dim userIdList1 As List(Of String) = New List(Of String)
    Private Const DPFJ_PROBABILITY_ONE As Integer = &H7FFFFFFF

    ''' <summary>
    ''' Holds fmds enrolled by the enrollment GUI.
    ''' </summary>
    Public Property Fmds() As Dictionary(Of Int16, Fmd)
        Get
            Return _fmds
        End Get
        Set(ByVal value As Dictionary(Of Int16, Fmd))
            _fmds = value
        End Set
    End Property
    Private _fmds As Dictionary(Of Int16, Fmd) = New Dictionary(Of Int16, Fmd)

    ''' <summary>
    ''' Reset the UI causing the user to reselect a reader.
    ''' </summary>
    Public Property Reset() As Boolean
        Get
            Return _reset
        End Get
        Set(ByVal value As Boolean)
            _reset = value
        End Set
    End Property
    Private _reset As Boolean

    ' When set by child forms, shows s/n and enables buttons.
    Public Property CurrentReader() As Reader
        Get
            Return _currentReader
        End Get
        Set(ByVal value As Reader)
            _currentReader = value
            'SendMessage(Action.UpdateReaderState, value)
        End Set
    End Property
    Private _currentReader As Reader

    ''' <summary>
    ''' Open a device and check result for errors.
    ''' </summary>
    ''' <returns>Returns true if successful; false if unsuccessful</returns>
    Public Function OpenReader() As Boolean
        Reset = False
        Dim result As Constants.ResultCode = Constants.ResultCode.DP_DEVICE_FAILURE

        result = _currentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE)

        If result <> Constants.ResultCode.DP_SUCCESS Then
            MessageBox.Show("Error:  " & result.ToString())
            Reset = True
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Hookup capture handler and start capture.
    ''' </summary>
    ''' <param name="OnCaptured">Delegate to hookup as handler of the On_Captured event</param>
    ''' <returns>Returns true if successful; false if unsuccessful</returns>
    Public Function StartCaptureAsync(ByVal OnCaptured As Reader.CaptureCallback) As Boolean
        AddHandler _currentReader.On_Captured, OnCaptured

        If Not CaptureFingerAsync() Then
            Return False
        End If

        Return True
    End Function


    ''' <summary>
    ''' Cancel the capture and then close the reader.
    ''' </summary>
    ''' <param name="OnCaptured">Delegate to unhook as handler of the On_Captured event </param>
    Public Sub CancelCaptureAndCloseReader(ByVal OnCaptured As Reader.CaptureCallback)
        If _currentReader IsNot Nothing Then
            ' Dispose of reader handle and unhook reader events.
            CurrentReader.Dispose()

            If (Reset) Then
                CurrentReader = Nothing
            End If
        End If
    End Sub

    ''' <summary>
    ''' Check the device status before starting capture.
    ''' </summary>
    Public Sub GetStatus()
        Dim result = _currentReader.GetStatus()

        If (result <> ResultCode.DP_SUCCESS) Then
            If CurrentReader IsNot Nothing Then
                Reset = True
                Throw New Exception("" & result.ToString())
            End If
        End If

        If (_currentReader.Status.Status = ReaderStatuses.DP_STATUS_BUSY) Then
            Thread.Sleep(50)
        ElseIf (_currentReader.Status.Status = ReaderStatuses.DP_STATUS_NEED_CALIBRATION) Then
            _currentReader.Calibrate()
        ElseIf (_currentReader.Status.Status <> ReaderStatuses.DP_STATUS_READY) Then
            Throw New Exception("Reader Status - " & CurrentReader.Status.Status.ToString())
        End If
    End Sub

    ''' <summary>
    ''' Check quality of the resulting capture.
    ''' </summary>
    Public Function CheckCaptureResult(ByVal captureResult As CaptureResult) As Boolean
        If captureResult.Data Is Nothing Then
            If captureResult.ResultCode <> Constants.ResultCode.DP_SUCCESS Then
                Reset = True
                Throw New Exception("" & captureResult.ResultCode.ToString())
            End If

            If captureResult.Quality <> Constants.CaptureQuality.DP_QUALITY_CANCELED Then
                Throw New Exception("Quality - " & captureResult.Quality.ToString())
            End If
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Function to capture a finger. Always get status first and calibrate or wait if necessary.  Always check status and capture errors.
    ''' </summary>
    Public Function CaptureFingerAsync() As Boolean
        Try
            GetStatus()

            Dim captureResult = _currentReader.CaptureAsync(Formats.Fid.ANSI, _
                                                   CaptureProcessing.DP_IMG_PROC_DEFAULT, _
                                                    _currentReader.Capabilities.Resolutions(0))

            If captureResult <> ResultCode.DP_SUCCESS Then
                Reset = True
                Throw New Exception("" + captureResult.ToString())
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Create a bitmap from raw data in row/column format.
    ''' </summary>
    Public Function CreateBitmap(ByVal bytes As [Byte](), ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim rgbBytes As Byte() = New Byte(bytes.Length * 3 - 1) {}

        For i As Integer = 0 To bytes.Length - 1
            rgbBytes((i * 3)) = bytes(i)
            rgbBytes((i * 3) + 1) = bytes(i)
            rgbBytes((i * 3) + 2) = bytes(i)
        Next
        Dim bmp As New Bitmap(width, height, PixelFormat.Format24bppRgb)

        Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.[WriteOnly], PixelFormat.Format24bppRgb)

        For i As Integer = 0 To bmp.Height - 1
            Dim p As New IntPtr(data.Scan0.ToInt64() + data.Stride * i)
            System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3)
        Next

        bmp.UnlockBits(data)

        Return bmp
    End Function

    ''' <summary>
    ''' Handler for when a fingerprint is captured.
    ''' </summary>
    ''' <param name="captureResult">contains info and data on the fingerprint capture</param>
    Public Sub OnCaptured(ByVal captureResult As CaptureResult)
        Try
            ' Check capture quality and throw an error if bad.
            If Not CheckCaptureResult(captureResult) Then Return

            count += 1

            Dim resultConversion As DataResult(Of Fmd) = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Formats.Fmd.ANSI)

            If resultConversion.ResultCode <> Constants.ResultCode.DP_SUCCESS Then
                Reset = True
                Throw New Exception("" & resultConversion.ResultCode.ToString())
            End If

            preenrollmentFmds.Add(resultConversion.Data)
            fmdRightIndex = (resultConversion.Data)

            SendMessage(Action.SendMessage, "A finger was captured.")

            Dim FPBitmap As Bitmap = CreateBitmap(captureResult.Data.Views(0).RawImage, captureResult.Data.Views(0).Width, captureResult.Data.Views(0).Height)

            'Draw image to screen
            pbFingerprint.Image = New Bitmap(FPBitmap, pbFingerprint.Width, pbFingerprint.Height)

            BeginInvoke(Function()
                            SendMessage(Action.SendMessage, "Finger Print Captured")

                            lblSampCount.Text = String.Format("Needed Samples: {0} of 4", count.ToString)

                            Return True
                        End Function)

            'matchedClientFP()

            If count = 4 Then
                Dim resultEnrollment As DataResult(Of Fmd) = DPUruNet.Enrollment.CreateEnrollmentFmd(Formats.Fmd.ANSI, preenrollmentFmds)

                If resultEnrollment.ResultCode = ResultCode.DP_SUCCESS Then
                    SendMessage(Action.SendMessage, "An enrollment FMD was successfully created.")

                    'Dim msg = MsgBox("Fingerprint template was created successfully." & vbNewLine & "Do you to continue with this template?", MsgBoxStyle.OkOnly)


                    SendMessage(Action.SendMessage, "Success")

                    frmConfirmPopper.ShowDialog()
                    frmConfirmPopper.SetPromptTexts("FINGERPRINT UPDATE", "Fingerprint sample was captured successfully!")
                    frmConfirmPopper.timer1.Interval = 1500

                    CancelCaptureAndCloseReader(AddressOf OnCaptured)


                    count = 0

                    preenrollmentFmds.Clear()
                    Return
                ElseIf (resultEnrollment.ResultCode = Constants.ResultCode.DP_ENROLLMENT_INVALID_SET) Then
                    SendMessage(Action.SendMessage, "Enrollment was unsuccessful.  Please try again.")
                    SendMessage(Action.SendMessage, "Place a finger on the reader.")

                    count = 0

                    preenrollmentFmds.Clear()
                    Return
                End If
            End If

            SendMessage(Action.SendMessage, "Now place the same finger on the reader.")

        Catch ex As Exception
            SendMessage(Action.SendMessage, "Error:  " & ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Close window.
    ''' </summary>
    Private Sub Enrollment_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
    End Sub

#Region "SendMessage"
    Public Enum Action
        SendMessage
    End Enum
    Private Delegate Sub SendMessageCallback(ByVal action As Action, ByVal payload As String)
    Private Sub SendMessage(ByVal action As Action, ByVal payload As String)
        On Error Resume Next

        If Me.txtEnroll.InvokeRequired Then
            Dim d As New SendMessageCallback(AddressOf SendMessage)
            Me.Invoke(d, New Object() {action, payload})
        Else
            Select Case action
                Case action.SendMessage
                    txtEnroll.Text += payload & vbCrLf & vbCrLf
                    txtEnroll.SelectionStart = txtEnroll.TextLength
                    txtEnroll.ScrollToCaret()
                    lblStatus.Text = payload

                    If lblStatus.Text = "Success" Then
                        lblVerified.Text = "SUCCESS"
                    End If
            End Select
        End If
    End Sub
#End Region



#End Region

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



#End Region

#Region "Subs"

    Protected Friend Sub loadClientInfo(ByVal playerID As Integer)
        SQLstr = String.Format("SELECT PlayerID, LName, FName, MI, BDate, Gender, ContactNum, Height, Weight, GuardianName, GuardianContactNum, Brgy, City, Province, PlayerPic FROM Player WHERE PlayerID = {0}", playerID)
        sqlQueryCMD(SQLstr)


        If rdDB.HasRows Then
            rdDB.Read()
            lblClientID.Text = rdDB!PlayerID
            txtClientName.Text = String.Format("{0}, {1} {2}.", rdDB!Lname, rdDB!Fname, rdDB!MI)

            If Not IsDBNull(rdDB!PlayerPic) Then

                Dim data As Byte() = DirectCast(rdDB!PlayerPic, Byte())
                Dim ms As New IO.MemoryStream(data)

                picClientImg.Image = Image.FromStream(ms)
            Else
                picClientImg.Image = My.Resources.LogoNoPic
            End If
        End If
        closeDBAll()
    End Sub

    Private Sub updateFingerID(ByVal id)
        SQLstr = String.Format("UPDATE Player SET FingerID = '{0}' WHERE PlayerID = {1}", Fmd.SerializeXml(fmdRightIndex), id)
        sqlNonQueryCMD(SQLstr)

    End Sub
#End Region


    Private Sub frmUpdateFinger_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            btnRefresh_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Fingerprint reader was unable to load!", "Contact Support!")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        If lblVerified.Text <> "SUCCESS" Then
            MessageBox.Show("Make sure fingerprint has successfully been enrolled!", "Fingerprint not yet enrolled!")
            Exit Sub
        End If
        'Try
        updateFingerID(lblClientID.Text)
        MessageBox.Show("Fingerprint has been updated successfully!", "Update Success!")
        btnClose_Click(sender, e)
        'Catch ex As Exception
        '    MessageBox.Show("Error updating Fingerprint" & vbCrLf & ex.ToString, "Update cancelled!")
        'End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        cbReaderSelect.Text = String.Empty
        cbReaderSelect.Items.Clear()
        cbReaderSelect.SelectedIndex = -1

        _readers = ReaderCollection.GetReaders()

        For Each Reader As Reader In _readers
            cbReaderSelect.Items.Add(Reader.Description.SerialNumber)
        Next
        If cbReaderSelect.Items.Count > 0 Then
            cbReaderSelect.Enabled = False
            btnRefresh.Hide()
            cbReaderSelect.SelectedIndex = 0
        Else
            btnRefresh.Show()
            cbReaderSelect.Enabled = True
        End If
    End Sub

    Private Sub cbReaderSelect_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbReaderSelect.SelectedValueChanged
        preenrollmentFmds = New List(Of Fmd)
        count = 0

        lblSampCount.Text = String.Format("Needed Samples: {0} of 4", count.ToString)

        SendMessage(Action.SendMessage, "Place a finger on the reader.")

        ''Reader
        CurrentReader = _readers(cbReaderSelect.SelectedIndex)
        SendMessage(Action.SendMessage, "Place a finger on the reader.")

        If Not OpenReader() Then
            Me.Close()
        End If

        If Not StartCaptureAsync(AddressOf Me.OnCaptured) Then
            Me.Close()
        End If
        ''End Reader
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        CancelCaptureAndCloseReader(AddressOf Me.OnCaptured)
        frmMain.Enabled = True
        'frmMain.btnRefresh_Click(sender, e)
        Me.Dispose()
        frmMain.MonitoringToolStripMenuItem_Click(sender, e)
    End Sub


End Class