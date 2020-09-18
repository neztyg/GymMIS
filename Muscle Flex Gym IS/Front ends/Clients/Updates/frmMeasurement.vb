Public Class frmMeasurement


#Region "Functions"

    Private Function isMeasured(ByVal id) As Boolean
        SQLstr = String.Format("SELECT StatID FROM PlayerStats WHERE PlayerID = '{0}' AND MeasurementDate = CONVERT(date,'{1}')", id, dtpDateMeasured.Value)
        sqlQueryCMD(SQLstr)
        Dim val As Boolean = False
        If rdDB.HasRows Then
            rdDB.Read()
            val = True
        Else
            val = False
        End If
        closeDBAll()
        Return val
    End Function
#End Region
#Region "Subs"
    Private sttID As Integer
    Private Property StatID As Integer
        Get
            Return sttID
        End Get
        Set(ByVal value As Integer)
            sttID = value
        End Set
    End Property

    Protected Friend Sub loadMeasures(ByVal id As Integer)
        SQLstr = String.Format("SELECT * From PlayerStats WHERE PlayerID = {0} ORDER BY MeasurementDate", id)
        sqlQueryCMD(SQLstr)

        lvMeasurements.Items.Clear()
        Dim itemx As New ListViewItem

        Do While rdDB.Read
            itemx = lvMeasurements.Items.Add(getNotNullSTR(rdDB!StatID))
            itemx.SubItems.Add(getNotNullSTR(rdDB!MeasurementDate))
            itemx.SubItems.Add(getNotNullSTR(rdDB!Weight))

            itemx.SubItems.Add(getNotNullSTR(rdDB!Neck))
            itemx.SubItems.Add(getNotNullSTR(rdDB!Waist))
            itemx.SubItems.Add(getNotNullSTR(rdDB!Hips))

            itemx.SubItems.Add(getNotNullSTR(rdDB!LeftForearm))
            itemx.SubItems.Add(getNotNullSTR(rdDB!RightForearm))

            itemx.SubItems.Add(getNotNullSTR(rdDB!LeftUpperarm))
            itemx.SubItems.Add(getNotNullSTR(rdDB!RightUpperarm))

            itemx.SubItems.Add(getNotNullSTR(rdDB!LeftThigh))
            itemx.SubItems.Add(getNotNullSTR(rdDB!RightThigh))

            itemx.SubItems.Add(getNotNullSTR(rdDB!LeftCalf))
            itemx.SubItems.Add(getNotNullSTR(rdDB!RightCalf))
        Loop
        closeDBAll()
    End Sub

    Private Sub setTxtValue(txt As Object, val As Object)
        txt.Text = val
    End Sub
    Private Sub loadMeasuredForUpdate(ByVal id)
        SQLstr = String.Format("SELECT * FROM PlayerStats WHERE StatID = {0}", id)
        sqlQueryCMD(SQLstr)

        If rdDB.HasRows Then
            rdDB.Read()
            setTxtValue(txtWeight, getNotNullSTR(rdDB!Weight))
            setTxtValue(txtNeck, getNotNullSTR(rdDB!Neck))
            setTxtValue(txtWaist, getNotNullSTR(rdDB!Waist))
            setTxtValue(txtHips, getNotNullSTR(rdDB!Hips))

            setTxtValue(txtLForeArm, getNotNullSTR(rdDB!LeftForearm))
            setTxtValue(txtRForeArm, getNotNullSTR(rdDB!RightForearm))

            setTxtValue(txtLUppArm, getNotNullSTR(rdDB!LeftUpperArm))
            setTxtValue(txtRUppArm, getNotNullSTR(rdDB!RightUpperArm))

            setTxtValue(txtLThigh, getNotNullSTR(rdDB!LeftThigh))
            setTxtValue(txtRThigh, getNotNullSTR(rdDB!RightThigh))

            setTxtValue(txtLCalf, getNotNullSTR(rdDB!LeftCalf))
            setTxtValue(txtRCalf, getNotNullSTR(rdDB!RightCalf))

            dtpDateMeasured.Value = rdDB!MeasurementDate
        End If
        closeDBAll()
    End Sub

    Private Function getValue(ByVal obj As System.Windows.Forms.TextBox)
        Dim val As Double = 0
        If obj.Text = "" Then
            val = 0
        Else
            val = obj.Text
        End If
        Return val
    End Function

    Private Sub saveMeasure()
        SQLstr = String.Format("INSERT INTO PlayerStats(Weight,  " &
                                                       "Neck, Waist, Hips, " &
                                                       "LeftForeArm, RightForeArm, " &
                                                       "LeftUpperArm, RightUpperArm, " &
                                                       "LeftThigh, RightThigh, " &
                                                       "LeftCalf, RightCalf, " &
                                                       "MeasurementDate, " &
                                                       "PlayerID) " &
                                                "VALUES({0},  " &
                                                       "{1}, {2}, {3},  " &
                                                       "{4}, {5},  " &
                                                       "{6}, {7},  " &
                                                       "{8}, {9},  " &
                                                       "{10}, {11},  " &
                                                       "'{12}',  " &
                                                       "'{13}')",
                                                       getValue(txtWeight),
                                                       getValue(txtNeck), getValue(txtWaist), getValue(txtHips),
                                                       getValue(txtLForeArm), getValue(txtRForeArm),
                                                       getValue(txtLUppArm), getValue(txtRUppArm),
                                                       getValue(txtLThigh), getValue(txtRThigh),
                                                       getValue(txtLCalf), getValue(txtRCalf),
                                                       dateValue(dtpDateMeasured.Value),
                                                       getValue(frmClientInfo.txtClientID))
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private Sub updateMeasure(id As Integer)
        SQLstr = String.Format("UPDATE PlayerStats SET Weight = {0}, " &
                                                       "Neck = {1}, Waist = {2}, Hips = {3},  " &
                                                       "LeftForearm = {4}, RightForearm = {5},  " &
                                                       "LeftUpperarm = {6}, RightUpperarm = {7},  " &
                                                       "LeftThigh = {8}, RightThigh = {9},  " &
                                                       "LeftCalf = {10}, RightCalf = {11},  " &
                                                       "MeasurementDate = '{12}'  " &
                                                  "WHERE StatID = {13}",
                                                        getValue(txtWeight),
                                                        getValue(txtNeck), getValue(txtWaist), getValue(txtHips),
                                                        getValue(txtLForeArm), getValue(txtRForeArm),
                                                        getValue(txtLUppArm), getValue(txtRUppArm),
                                                        getValue(txtLThigh), getValue(txtRThigh),
                                                        getValue(txtLCalf), getValue(txtRCalf),
                                                        dateValue(dtpDateMeasured.Value),
                                                        id)
        sqlNonQueryCMD(SQLstr)
    End Sub


    Private Sub deleteMeasure(ByVal id As Integer)
        SQLstr = String.Format("DELETE FROM PlayerStats WHERE StatID = {0}", id)
        sqlNonQueryCMD(SQLstr)
    End Sub

#End Region

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        If btnConfirm.Text = "SAVE" Then
            If isMeasured(frmClientInfo.txtClientID.Text) Then
                MessageBox.Show("Measurement already exist for this date!" + vbNewLine + "Select another date!", "Abort save")
                Exit Sub
            End If
            saveMeasure()
            MessageBox.Show("New measurement has been saved successfully", "Save Success")
        ElseIf btnConfirm.Text = "UPDATE" Then
            updateMeasure(StatID)
            MessageBox.Show("Measurement has been updated successfully", "Update Success")
            StatID = 0
        End If
        frmMeasurement_Load(sender, e)
    End Sub

    Private Sub lvMeasurements_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvMeasurements.MouseDoubleClick
        If lvMeasurements.SelectedItems.Count = 1 Then
            StatID = lvMeasurements.SelectedItems(0).SubItems(0).Text
            loadMeasuredForUpdate(StatID)
            btnConfirm.Text = "UPDATE"
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If frmClientInfo.Visible = True Then
            frmClientInfo.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.KeyPress, txtWaist.KeyPress, txtRUppArm.KeyPress, txtRThigh.KeyPress, txtRForeArm.KeyPress, txtRCalf.KeyPress, txtNeck.KeyPress, txtLUppArm.KeyPress, txtLThigh.KeyPress, txtLForeArm.KeyPress, txtLCalf.KeyPress, txtHips.KeyPress
        NumericTypeOnly(sender, e)
    End Sub

    Private Sub frmMeasurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMeasures(frmClientInfo.txtClientID.Text)
        btnReset_Click(sender, e)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtWeight.Clear()
        txtHips.Clear()
        txtNeck.Clear()
        txtWaist.Clear()
        txtLCalf.Clear()
        txtRCalf.Clear()
        txtLForeArm.Clear()
        txtRForeArm.Clear()
        txtLThigh.Clear()
        txtRThigh.Clear()
        txtLUppArm.Clear()
        txtRUppArm.Clear()
        btnConfirm.Text = "SAVE"
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If lvMeasurements.SelectedItems.Count = 1 Then
            Try
                deleteMeasure(lvMeasurements.SelectedItems(0).SubItems(0).Text)
                Dim msg = MsgBox("Are you sure to delete the measurement?", MsgBoxStyle.YesNo, "Delete?")
                If msg = MsgBoxResult.Yes Then
                    MessageBox.Show("A Measurement stat has been deleted!", "Delete Success")
                Else
                    MessageBox.Show("No changes have been made!", "Cancelled")
                End If
                frmMeasurement_Load(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub
End Class