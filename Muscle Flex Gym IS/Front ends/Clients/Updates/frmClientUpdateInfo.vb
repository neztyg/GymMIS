Imports System.Threading

Public Class frmClientUpdateInfo

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

    Private Function checkLockerAvailable() As Boolean
        Dim val As Boolean = False
        SQLstr = String.Format("SELECT LockerNumber FROM Player")
        sqlQueryCMD(SQLstr)

        Do While rdDB.Read
            'If txtLockerNum.Text = rdDB!LockerNumber Then
            '    MessageBox.Show("Locker is Already assigned to a client!", "Locker Assignment")
            '    val = True
            '    Exit Do
            'End If
        Loop
        closeDBAll()
        Return val
    End Function


    Private Function dtpDateSetter(month As Integer, day As Integer, year As Integer) As Date
        Dim val As Date
        val = CDate(String.Format("{0}/{1}/{2}", month + 1, day, year))

        Return val
    End Function

    Private Function dtpBdate() As Date
        Return dtpDateSetter(cbMonth.SelectedIndex, cbDay.Text, cbYear.Text)
    End Function

#End Region

#Region "Subs"
    Private Sub setDateValues()
        cbYear.Items.Clear()
        For i As Integer = 0 To 100 Step 1
            cbYear.Items.Add(Now.Year - i)
        Next
        cbDay.Items.Clear()
        For j As Integer = 1 To Date.DaysInMonth(cbYear.Text, cbMonth.SelectedIndex + 1)
            cbDay.Items.Add(j)
        Next
    End Sub

    Private Sub setGenderValue() Handles rbFemale.CheckedChanged, rbMale.CheckedChanged
        If rbMale.Checked Then
            Gender = rbMale.Text.Substring(0, 1)
        ElseIf rbFemale.Checked Then
            Gender = rbFemale.Text.Substring(0, 1)
        End If
    End Sub

    Protected Friend Sub loadClientInfo(id As Integer)
        SQLstr = String.Format("SELECT * FROM Player WHERE PlayerID = {0}", id)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            lblClientID.Text = id
            txtLname.Text = rdDB!Lname
            txtFname.Text = rdDB!Fname
            txtMname.Text = rdDB!MI
            cbMonth.SelectedIndex = CDate(rdDB!Bdate).Month - 1
            cbDay.Text = CDate(rdDB!Bdate).Day
            cbYear.Text = CDate(rdDB!Bdate).Year
            If rdDB!Gender = "M" Then
                rbMale.Checked = True
            Else
                rbFemale.Checked = True
            End If
            cbCivilStatus.Text = rdDB!CivilStatus
            txtCitizenship.Text = rdDB!Citizenship

            txtEmailAdd.Text = rdDB!EmailAdd
            txtOccupation.Text = rdDB!Occupation
            txtMobileNum.Text = String.Format("{0}", rdDB!ContactNum)
            txtHeight.Text = rdDB!Height
            txtWeight.Text = rdDB!Weight
            txtGuardianName.Text = rdDB!GuardianName
            txtGuardianContact.Text = String.Format("{0}", rdDB!GuardianContactNum)
            txtBrgy.Text = rdDB!Brgy
            txtCity.Text = rdDB!City
            txtProvince.Text = rdDB!Province
            txtAddInfo.Text = rdDB!MoreInfo
            txtMedIssues.Text = rdDB!MedicalIssues

        End If
        closeDBAll()

        loadClientPic(id)
    End Sub

    Private Sub loadClientPic(id As Integer)
        SQLstr = String.Format("SELECT PlayerPic FROM Player WHERE PlayerID = {0}", id)
        sqlQueryCMD(SQLstr)
        If rdDB.HasRows Then
            rdDB.Read()
            If Not IsDBNull(rdDB!PlayerPic) Then
                Try
                    Dim data As Byte() = DirectCast(rdDB!PlayerPic, Byte())
                    Dim ms As New IO.MemoryStream(data)
                    picPreview.Image = Image.FromStream(ms)
                Catch ex As Exception
                    picPreview.Image = My.Resources.LogoNoPic
                End Try
            End If
        End If
        closeDBAll()
    End Sub

    Private Sub updateClientInfo(id As Integer)
        SQLstr = String.Format("UPDATE Player SET " & _
                                            "Lname = '{0}', Fname = '{1}', MI = '{2}', " & _
                                            "Bdate = '{3}', Gender = '{4}', ContactNum = {5}, " & _
                                            "CivilStatus = '{6}', Occupation = '{7}', EmailAdd= '{8}', " & _
                                            "Citizenship = '{9}', Height = {10}, Weight = {11}, " & _
                                            "GuardianName = '{12}', GuardianContactNum = {13}, " & _
                                            "Brgy = '{14}', City = '{15}', Province = '{16}' " & _
                                "WHERE PlayerID = '{17}' ",
                                            txtLname.Text, txtFname.Text, txtMname.Text,
                                            dateValue(dtpBdate()), Gender, txtMobileNum.Text,
                                            cbCivilStatus.Text, txtOccupation.Text, txtEmailAdd.Text,
                                            txtCitizenship.Text, txtHeight.Text, txtWeight.Text,
                                            txtGuardianName.Text, txtGuardianContact.Text,
                                            txtBrgy.Text, txtCity.Text, txtProvince.Text,
                                            lblClientID.Text)
        sqlNonQueryCMD(SQLstr)

        If imgHasCaptured = True Then
            updateProfilePic(lblClientID.Text)
        End If
    End Sub

    Private Sub updateProfilePic(id As Integer)
        Dim rand As New Random
        Dim imgVar As String = "@img" + TimeOfDay.Second.ToString + rand.Next(0, 20).ToString

        SQLstr = String.Format("UPDATE Player SET PlayerPic = {0} WHERE PlayerID = {1}", imgVar, id)
        comDB.Parameters.Add(New SqlClient.SqlParameter(imgVar, SqlDbType.Image)).Value = IO.File.ReadAllBytes(camModule.imgURL)
        sqlNonQueryCMD(SQLstr)
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

    Private Sub loadSuggestedList(ByVal reValue As String, ByVal txtObj As TextBox)
        SQLstr = String.Format("SELECT DISTINCT({0}) AS txt FROM Player WHERE {0} Like '{1}%'", reValue, txtObj.Text)
        sqlQueryCMD(SQLstr)

        Do While rdDB.Read()
            txtObj.AutoCompleteCustomSource.Add(rdDB!txt)
        Loop
        closeDBAll()
    End Sub

    Private Sub loadCustomSourceList()
        loadSuggestedList("Lname", txtLname)
        loadSuggestedList("Fname", txtFname)
        loadSuggestedList("Brgy", txtBrgy)
        loadSuggestedList("City", txtCity)
        loadSuggestedList("Province", txtProvince)
        loadSuggestedList("Province", txtOccupation)
    End Sub

#End Region

    Private Sub frmRegistration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setDateValues()
        grpPage1.Size = New Size(928, 473)
        camModule.OpenPreviewWindow(camModule.LoadDeviceList, picPreview)
        imgHasCaptured = False

        'loadPackages()
        loadCustomSourceList()
        'chkChangeImage.Checked = False
        imgHasCaptured = False
        'dtpBdate_ValueChanged(sender, e)
    End Sub

    Private Sub btnCapture_Click(sender As System.Object, e As System.EventArgs) Handles btnCapture.Click
        If imgHasCaptured = False Then
            picPreview.Image = My.Resources.icons8_camera_outline
            camModule.captureImage("img" & Now.ToFileTime.ToString & ".jpg", picPreview) 'Edit to Username when active directory
            camModule.ClosePreviewWindow()
            imgHasCaptured = True
        End If
    End Sub

    Private Sub btnSelectImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectImage.Click
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

    Private Sub dtpBdate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cbYear.SelectedIndexChanged, cbYear.TextChanged
        txtAge.Clear()
        txtAge.Text = Now.Year - CDate(dtpBdate()).Year
        If Now.Month < Val(cbMonth.SelectedIndex - 1) Then
            txtAge.Text -= 1
        End If
    End Sub


    Private Sub txtMobileNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress, txtMobileNum.KeyPress, txtHeight.KeyPress, txtGuardianContact.KeyPress
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If frmClientInfo.Visible = True Then
            frmClientInfo.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub btnAddPackage_Click(sender As System.Object, e As System.EventArgs)
        frmPackageSelector.ShowDialog()
    End Sub

    Private Sub chkChangeImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If chkChangeImage.Checked = True Then
        '    camModule.OpenPreviewWindow(camModule.LoadDeviceList, picPreview)
        '    imgHasCaptured = False
        'Else
        '    camModule.ClosePreviewWindow()
        'End If
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        'Try
        updateClientInfo(lblClientID.Text)
        MessageBox.Show("Profile has successfully been updated!", "Update success!")
        frmClientInfo.loadClientInfo(frmClientInfo.txtClientID.Text)
        btnClose_Click(sender, e)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub
End Class