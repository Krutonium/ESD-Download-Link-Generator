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
        Me.rdoSlow = New System.Windows.Forms.RadioButton()
        Me.rdoFast = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.cmdCpyToClp = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoSlow
        '
        Me.rdoSlow.AutoSize = True
        Me.rdoSlow.Location = New System.Drawing.Point(9, 42)
        Me.rdoSlow.Name = "rdoSlow"
        Me.rdoSlow.Size = New System.Drawing.Size(143, 17)
        Me.rdoSlow.TabIndex = 0
        Me.rdoSlow.TabStop = True
        Me.rdoSlow.Text = "Generate Download Link"
        Me.rdoSlow.UseVisualStyleBackColor = True
        '
        'rdoFast
        '
        Me.rdoFast.AutoSize = True
        Me.rdoFast.Location = New System.Drawing.Point(9, 19)
        Me.rdoFast.Name = "rdoFast"
        Me.rdoFast.Size = New System.Drawing.Size(131, 17)
        Me.rdoFast.TabIndex = 1
        Me.rdoFast.TabStop = True
        Me.rdoFast.Text = "Currently Downloading"
        Me.rdoFast.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoFast)
        Me.GroupBox1.Controls.Add(Me.rdoSlow)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Rings"
        '
        'cmdDownload
        '
        Me.cmdDownload.Location = New System.Drawing.Point(179, 4)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(132, 23)
        Me.cmdDownload.TabIndex = 3
        Me.cmdDownload.Text = "Get Download Link"
        Me.cmdDownload.UseVisualStyleBackColor = True
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(12, 85)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(299, 20)
        Me.txtLink.TabIndex = 4
        '
        'cmdCpyToClp
        '
        Me.cmdCpyToClp.Location = New System.Drawing.Point(179, 56)
        Me.cmdCpyToClp.Name = "cmdCpyToClp"
        Me.cmdCpyToClp.Size = New System.Drawing.Size(132, 23)
        Me.cmdCpyToClp.TabIndex = 5
        Me.cmdCpyToClp.Text = "Copy Link to Clipboard"
        Me.cmdCpyToClp.UseVisualStyleBackColor = True
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(179, 30)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(132, 23)
        Me.cmdAbout.TabIndex = 6
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 116)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdCpyToClp)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoSlow As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFast As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents cmdCpyToClp As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button

End Class
