<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.cmdCpyToClp = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbSHA1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDate = New System.Windows.Forms.MaskedTextBox()
        Me.cmdCurrent = New System.Windows.Forms.Button()
        Me.btnDownloadBuild = New System.Windows.Forms.Button()
        Me.lblNameAndSpeed = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'cmdDownload
        '
        Me.cmdDownload.Location = New System.Drawing.Point(12, 160)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(132, 23)
        Me.cmdDownload.TabIndex = 3
        Me.cmdDownload.Text = "Get Download Link"
        Me.cmdDownload.UseVisualStyleBackColor = True
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(12, 189)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(496, 20)
        Me.txtLink.TabIndex = 4
        '
        'cmdCpyToClp
        '
        Me.cmdCpyToClp.Location = New System.Drawing.Point(150, 160)
        Me.cmdCpyToClp.Name = "cmdCpyToClp"
        Me.cmdCpyToClp.Size = New System.Drawing.Size(132, 23)
        Me.cmdCpyToClp.TabIndex = 5
        Me.cmdCpyToClp.Text = "Copy Link to Clipboard"
        Me.cmdCpyToClp.UseVisualStyleBackColor = True
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(12, 12)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(132, 23)
        Me.cmdAbout.TabIndex = 6
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(12, 41)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(333, 20)
        Me.tbName.TabIndex = 7
        '
        'tbSHA1
        '
        Me.tbSHA1.Location = New System.Drawing.Point(12, 67)
        Me.tbSHA1.Name = "tbSHA1"
        Me.tbSHA1.Size = New System.Drawing.Size(333, 20)
        Me.tbSHA1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Name of the ESD that you want"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SHA1 Of the ESD that you want"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Date of the ESD"
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(12, 93)
        Me.tbDate.Mask = "####/##"
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(51, 20)
        Me.tbDate.TabIndex = 14
        '
        'cmdCurrent
        '
        Me.cmdCurrent.Location = New System.Drawing.Point(150, 12)
        Me.cmdCurrent.Name = "cmdCurrent"
        Me.cmdCurrent.Size = New System.Drawing.Size(172, 23)
        Me.cmdCurrent.TabIndex = 15
        Me.cmdCurrent.Text = "Get Currently Downloading Build"
        Me.cmdCurrent.UseVisualStyleBackColor = True
        '
        'btnDownloadBuild
        '
        Me.btnDownloadBuild.Enabled = False
        Me.btnDownloadBuild.Location = New System.Drawing.Point(288, 160)
        Me.btnDownloadBuild.Name = "btnDownloadBuild"
        Me.btnDownloadBuild.Size = New System.Drawing.Size(168, 23)
        Me.btnDownloadBuild.TabIndex = 16
        Me.btnDownloadBuild.Text = "Download this Build"
        Me.btnDownloadBuild.UseVisualStyleBackColor = True
        '
        'lblNameAndSpeed
        '
        Me.lblNameAndSpeed.AutoSize = True
        Me.lblNameAndSpeed.Location = New System.Drawing.Point(12, 264)
        Me.lblNameAndSpeed.Name = "lblNameAndSpeed"
        Me.lblNameAndSpeed.Size = New System.Drawing.Size(39, 13)
        Me.lblNameAndSpeed.TabIndex = 17
        Me.lblNameAndSpeed.Text = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 238)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(352, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 220)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblNameAndSpeed)
        Me.Controls.Add(Me.btnDownloadBuild)
        Me.Controls.Add(Me.cmdCurrent)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSHA1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdCpyToClp)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.cmdDownload)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents cmdCpyToClp As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbSHA1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdCurrent As System.Windows.Forms.Button
    Friend WithEvents btnDownloadBuild As System.Windows.Forms.Button
    Friend WithEvents lblNameAndSpeed As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
