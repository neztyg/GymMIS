Public Class frmConfirmPopper
    Protected Friend WithEvents timer1 As New System.Windows.Forms.Timer

    Private headText As String = ""
    Private msgText As String = ""

    Public Sub SetPromptTexts(ByVal head As String, ByVal msg As String)
        lblHeader.Text = head
        lblMsg.Text = msg
        Me.ShowDialog()
    End Sub

    Private Sub frmConfirmPopper_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        timer1.Start()
        timer1.Interval = 1000
    End Sub

    Private Sub timer1_Tick() Handles timer1.Tick
        Me.Close()
    End Sub
End Class