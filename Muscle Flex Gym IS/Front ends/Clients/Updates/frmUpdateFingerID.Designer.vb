<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateFingerID
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lvlHeader = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpPage2 = New System.Windows.Forms.GroupBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.picClientImg = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cbReaderSelect = New System.Windows.Forms.ComboBox()
        Me.lblSampCount = New System.Windows.Forms.Label()
        Me.lblVerified = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pbFingerprint = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtEnroll = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPage2.SuspendLayout()
        CType(Me.picClientImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lvlHeader)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Gym_IS.My.Resources.Resources.icons8_minimize_window_sm
        Me.btnClose.Location = New System.Drawing.Point(720, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(44, 44)
        Me.btnClose.TabIndex = 6
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lvlHeader
        '
        Me.lvlHeader.AutoSize = True
        Me.lvlHeader.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!)
        Me.lvlHeader.Location = New System.Drawing.Point(58, 8)
        Me.lvlHeader.Name = "lvlHeader"
        Me.lvlHeader.Size = New System.Drawing.Size(297, 29)
        Me.lvlHeader.TabIndex = 5
        Me.lvlHeader.Text = "FINGERPRINT REGISTRATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gym_IS.My.Resources.Resources.icons8_registration
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblClientID
        '
        Me.lblClientID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblClientID.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientID.Location = New System.Drawing.Point(401, 23)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(202, 42)
        Me.lblClientID.TabIndex = 8
        Me.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label41.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(286, 23)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(114, 42)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "CLIENT ID:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(287, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 19)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Client Name:"
        '
        'grpPage2
        '
        Me.grpPage2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPage2.BackColor = System.Drawing.Color.White
        Me.grpPage2.Controls.Add(Me.txtClientName)
        Me.grpPage2.Controls.Add(Me.lblClientID)
        Me.grpPage2.Controls.Add(Me.Label41)
        Me.grpPage2.Controls.Add(Me.picClientImg)
        Me.grpPage2.Controls.Add(Me.Label16)
        Me.grpPage2.Controls.Add(Me.btnRefresh)
        Me.grpPage2.Controls.Add(Me.cbReaderSelect)
        Me.grpPage2.Controls.Add(Me.lblSampCount)
        Me.grpPage2.Controls.Add(Me.lblVerified)
        Me.grpPage2.Controls.Add(Me.Label21)
        Me.grpPage2.Controls.Add(Me.pbFingerprint)
        Me.grpPage2.Controls.Add(Me.btnConfirm)
        Me.grpPage2.Controls.Add(Me.txtEnroll)
        Me.grpPage2.Location = New System.Drawing.Point(63, 66)
        Me.grpPage2.Name = "grpPage2"
        Me.grpPage2.Size = New System.Drawing.Size(633, 446)
        Me.grpPage2.TabIndex = 13
        Me.grpPage2.TabStop = False
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(380, 72)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(223, 24)
        Me.txtClientName.TabIndex = 45
        '
        'picClientImg
        '
        Me.picClientImg.Location = New System.Drawing.Point(301, 107)
        Me.picClientImg.Name = "picClientImg"
        Me.picClientImg.Size = New System.Drawing.Size(302, 320)
        Me.picClientImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClientImg.TabIndex = 44
        Me.picClientImg.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(38, 46)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 24)
        Me.btnRefresh.TabIndex = 42
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Visible = False
        '
        'cbReaderSelect
        '
        Me.cbReaderSelect.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!)
        Me.cbReaderSelect.FormattingEnabled = True
        Me.cbReaderSelect.Location = New System.Drawing.Point(38, 23)
        Me.cbReaderSelect.Name = "cbReaderSelect"
        Me.cbReaderSelect.Size = New System.Drawing.Size(181, 21)
        Me.cbReaderSelect.TabIndex = 41
        Me.cbReaderSelect.Text = "Select reader..."
        '
        'lblSampCount
        '
        Me.lblSampCount.AutoSize = True
        Me.lblSampCount.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!)
        Me.lblSampCount.Location = New System.Drawing.Point(36, 330)
        Me.lblSampCount.Name = "lblSampCount"
        Me.lblSampCount.Size = New System.Drawing.Size(139, 16)
        Me.lblSampCount.TabIndex = 38
        Me.lblSampCount.Text = "Needed Samples: {0} of 4"
        '
        'lblVerified
        '
        Me.lblVerified.AutoSize = True
        Me.lblVerified.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!)
        Me.lblVerified.Location = New System.Drawing.Point(34, 343)
        Me.lblVerified.Name = "lblVerified"
        Me.lblVerified.Size = New System.Drawing.Size(75, 28)
        Me.lblVerified.TabIndex = 37
        Me.lblVerified.Text = "STATUS"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(185, 18)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Place a finger on the reader..."
        '
        'pbFingerprint
        '
        Me.pbFingerprint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pbFingerprint.Image = Global.Gym_IS.My.Resources.Resources.icons8_fingerprint_scan
        Me.pbFingerprint.Location = New System.Drawing.Point(39, 73)
        Me.pbFingerprint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbFingerprint.Name = "pbFingerprint"
        Me.pbFingerprint.Size = New System.Drawing.Size(241, 252)
        Me.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFingerprint.TabIndex = 35
        Me.pbFingerprint.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!)
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Image = Global.Gym_IS.My.Resources.Resources.icons8_save_button_sm
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(37, 374)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(243, 53)
        Me.btnConfirm.TabIndex = 19
        Me.btnConfirm.Text = "UPDATE FINGER ID"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtEnroll
        '
        Me.txtEnroll.Location = New System.Drawing.Point(6, 73)
        Me.txtEnroll.Multiline = True
        Me.txtEnroll.Name = "txtEnroll"
        Me.txtEnroll.ReadOnly = True
        Me.txtEnroll.Size = New System.Drawing.Size(26, 98)
        Me.txtEnroll.TabIndex = 43
        Me.txtEnroll.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'frmUpdateFingerID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpPage2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateFingerID"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPage2.ResumeLayout(False)
        Me.grpPage2.PerformLayout()
        CType(Me.picClientImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lvlHeader As System.Windows.Forms.Label
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grpPage2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents cbReaderSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblSampCount As System.Windows.Forms.Label
    Friend WithEvents lblVerified As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents pbFingerprint As System.Windows.Forms.PictureBox
    Friend WithEvents txtEnroll As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picClientImg As System.Windows.Forms.PictureBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
End Class
