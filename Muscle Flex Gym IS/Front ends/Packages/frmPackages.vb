Public Class frmPackages


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
    Private Function hasDuplicate() As Boolean
        Dim val As Boolean = False
        SQLstr = String.Format("SELECT PackageID FROM Package WHERE CategoryName = '{0}' AND Package = '{1}'", cbCategory.Text, txtName.Text)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            val = True
        Else : val = False
        End If
        closeDBAll()
        Return val
    End Function

    Private Function hasNoContent() As Boolean
        Dim val As Boolean = False
        If cbCategory.Text = "" Then
            val = True
        End If
        Return val
    End Function
#End Region

#Region "Subs"

    Private Sub loadCategories()
        SQLstr = String.Format("SELECT DISTINCT(CategoryName) as Category FROM Package")
        sqlQueryCMD(SQLstr)

        cbCategory.Items.Clear()

        Do While rdDB.Read
            cbCategory.Items.Add(rdDB!Category)
        Loop
        closeDBAll()
    End Sub

    Private Sub loadPackages()
        SQLstr = String.Format("SELECT * FROM Package ORDER BY TimeUnit DESC")
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
            If rdDB!isActive = True Then
                itemx.SubItems.Add("Active")
            Else
                itemx.SubItems.Add("Inactive")
            End If
        Loop
        closeDBAll()
    End Sub

    Private Sub loadPackforUpdate(ByVal id As Integer)
        SQLstr = String.Format("SELECT * FROM Package WHERE PackageID = {0}", id)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            If Not IsDBNull(rdDB!isFixed) Then
                If rdDB!isFixed = True Then
                    txtName.Enabled = False
                Else
                    txtName.Enabled = True
                End If
            End If
            cbCategory.Text = rdDB!CategoryName
            txtName.Text = rdDB!Package
            txtTimeLimit.Text = rdDB!Limit
            cbTimeUnit.Text = rdDB!TimeUnit
            cbPayMode.Text = rdDB!PayMode
            txtPrice.Text = rdDB!PackagePrice
            chkHasLocker.Checked = rdDB!hasLocker
            chkIsActive.Checked = rdDB!isActive
            chkIsForMember.Checked = rdDB!isForMember

        End If
        closeDBAll()

    End Sub

    Private Sub savePackage()
        If hasNoContent() Then
            MessageBox.Show("Fill in required values before continuing!", "Warning")
            Exit Sub
        End If
        If hasDuplicate() Then
            MessageBox.Show("Package already exist!", "Saved cancelled")
            Exit Sub
        End If

        SQLstr = String.Format("INSERT INTO Package(CategoryName, Package, PackagePrice, PayMode, isActive, Limit, TimeUnit, hasLocker, isForMember) " & _
                                           "VALUES('{0}','{1}',{2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}')",
                                                    cbCategory.Text, txtName.Text,
                                                    txtPrice.Text, cbPayMode.Text,
                                                    chkIsActive.Checked, txtTimeLimit.Text,
                                                    cbTimeUnit.Text, chkHasLocker.Checked,
                                                    chkIsForMember.Checked)
        Dim val As String = SQLstr
        sqlNonQueryCMD(SQLstr)
        MessageBox.Show("New Package has been saved successfully!", "Save success")

        clearInfo()
    End Sub

    Private Sub updatePackage()
        SQLstr = String.Format("UPDATE Package SET " & _
                                            "CategoryName = '{0}', " & _
                                            "Package = '{1}', " & _
                                            "PackagePrice = '{2}', " & _
                                            "PayMode = '{3}', " & _
                                            "isActive = '{4}', " & _
                                            "Limit = {5}, " & _
                                            "TimeUnit = '{6}', " & _
                                            "hasLocker = '{7}', " & _
                                            "isForMember = '{8}' " & _
                                            "WHERE PackageID = {9} ",
                                            cbCategory.Text, txtName.Text, txtPrice.Text,
                                            cbPayMode.Text, chkIsActive.Checked, txtTimeLimit.Text,
                                            cbTimeUnit.Text, chkHasLocker.Checked,
                                            chkIsForMember.Checked,
                                            PackageID)
        sqlNonQueryCMD(SQLstr)
        MessageBox.Show("Package information has been updated!", "Update Success")
        clearInfo()
        PackageID = Nothing
        btnConfirm.Text = "SAVE"
    End Sub

    Private Sub clearInfo()
        cbCategory.Text = ""
        txtName.Clear()
        txtPrice.Clear()
        cbTimeUnit.Text = ""
        cbPayMode.Text = ""
        chkIsActive.Checked = True
        chkHasLocker.Checked = False
        chkIsForMember.Checked = True
    End Sub
#End Region

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        If btnConfirm.Text = "SAVE" Then
            savePackage()
        ElseIf btnConfirm.Text = "UPDATE" Then
            updatePackage()
        End If
        txtName.Enabled = True
        frmPackages_Load(sender, e)
    End Sub

    Private Sub frmPackages_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCategories()
        loadPackages()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
        frmMain.MonitoringToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lvPackages_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lvPackages.MouseDoubleClick
        If lvPackages.SelectedItems.Count = 1 Then
            PackageID = lvPackages.SelectedItems(0).SubItems(0).Text
            loadPackforUpdate(PackageID)
            btnConfirm.Text = "UPDATE"
        End If
    End Sub

End Class