Public Class frmTrainer
    Private tranID As Integer
    Protected Friend Property transacID As Integer
        Get
            Return tranID
        End Get
        Set(ByVal value As Integer)
            tranID = value
        End Set
    End Property

    Private Sub loadTrainers()
        SQLstr = String.Format("SELECT Trainer From Trainer WHERE LEN(Trainer) > 1")
        sqlQueryCMD(SQLstr)

        cbTrainers.Items.Clear()
        Do While rdDB.Read
            cbTrainers.Items.Add(rdDB!Trainer)
        Loop
        closeDBAll()
    End Sub

    Private Sub updateTrainerAssign(ByVal TransactionID As Integer)
        SQLstr = String.Format("SELECT TrainerID FROM Trainer WHERE Trainer = '{0}'", cbTrainers.Text)
        sqlQueryCMD(SQLstr)
        Dim trainerID As Integer = 0
        If rdDB.HasRows Then
            rdDB.Read()
            trainerID = rdDB!TrainerID
        End If

        SQLstr = String.Format("UPDATE Transactions SET TrainerID = {0} WHERE TransacID = {1}", trainerID, TransactionID)
        sqlNonQueryCMD(SQLstr)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmTrainer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTrainers()
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        'MessageBox.Show(transacID)
        Try
            updateTrainerAssign(transacID)
            frmConfirmPopper.SetPromptTexts("Trainer assigned to session!", "Save Success")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lnkAddTrainer_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAddTrainer.LinkClicked
        frmTrainerUpdate.ShowDialog()
        loadTrainers()
    End Sub
End Class