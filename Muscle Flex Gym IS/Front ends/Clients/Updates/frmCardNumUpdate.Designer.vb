<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardNumUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtRFIDnum = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.picClient = New System.Windows.Forms.PictureBox()
        Me.lblPlayerID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIDstatus = New System.Windows.Forms.Label()
        Me.picStatIndicator = New System.Windows.Forms.PictureBox()
        Me.btnRenew = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStatIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRenew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 366)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 25)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(54, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RFID UPDATE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_badge
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Gym_IS.My.Resources.Resources.icons8_x_mark
        Me.btnClose.Location = New System.Drawing.Point(596, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 43)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtRFIDnum
        '
        Me.txtRFIDnum.BackColor = System.Drawing.Color.White
        Me.txtRFIDnum.Location = New System.Drawing.Point(413, 130)
        Me.txtRFIDnum.Name = "txtRFIDnum"
        Me.txtRFIDnum.Size = New System.Drawing.Size(175, 24)
        Me.txtRFIDnum.TabIndex = 4
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Tai Le", 17.0!)
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Image = Global.Gym_IS.My.Resources.Resources.icons8_save_button_sm
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(424, 298)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(195, 53)
        Me.btnConfirm.TabIndex = 20
        Me.btnConfirm.Text = "SAVE CARD"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'picClient
        '
        Me.picClient.Image = Global.Gym_IS.My.Resources.Resources.icons8_member
        Me.picClient.Location = New System.Drawing.Point(12, 56)
        Me.picClient.Name = "picClient"
        Me.picClient.Size = New System.Drawing.Size(280, 295)
        Me.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClient.TabIndex = 4
        Me.picClient.TabStop = False
        '
        'lblPlayerID
        '
        Me.lblPlayerID.AutoSize = True
        Me.lblPlayerID.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerID.Location = New System.Drawing.Point(298, 56)
        Me.lblPlayerID.Name = "lblPlayerID"
        Me.lblPlayerID.Size = New System.Drawing.Size(74, 26)
        Me.lblPlayerID.TabIndex = 21
        Me.lblPlayerID.Text = "Label2"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(298, 94)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 25)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "CARD Number:"
        '
        'lblIDstatus
        '
        Me.lblIDstatus.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDstatus.Location = New System.Drawing.Point(303, 157)
        Me.lblIDstatus.Name = "lblIDstatus"
        Me.lblIDstatus.Size = New System.Drawing.Size(285, 18)
        Me.lblIDstatus.TabIndex = 22
        Me.lblIDstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picStatIndicator
        '
        Me.picStatIndicator.Location = New System.Drawing.Point(413, 178)
        Me.picStatIndicator.Name = "picStatIndicator"
        Me.picStatIndicator.Size = New System.Drawing.Size(175, 102)
        Me.picStatIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStatIndicator.TabIndex = 23
        Me.picStatIndicator.TabStop = False
        '
        'btnRenew
        '
        Me.btnRenew.Image = Global.Gym_IS.My.Resources.Resources.renew
        Me.btnRenew.Location = New System.Drawing.Point(589, 126)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(30, 30)
        Me.btnRenew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRenew.TabIndex = 24
        Me.btnRenew.TabStop = False
        '
        'frmCardNumUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(646, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.txtRFIDnum)
        Me.Controls.Add(Me.picStatIndicator)
        Me.Controls.Add(Me.lblIDstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblPlayerID)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.picClient)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCardNumUpdate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStatIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRenew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRFIDnum As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents picClient As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIDstatus As System.Windows.Forms.Label
    Friend WithEvents picStatIndicator As System.Windows.Forms.PictureBox
    Friend WithEvents btnRenew As System.Windows.Forms.PictureBox
End Class
