<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLanguage
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
        Me.btnCont = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCont
        '
        Me.btnCont.Location = New System.Drawing.Point(150, 10)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(75, 23)
        Me.btnCont.TabIndex = 0
        Me.btnCont.Text = "Continue"
        Me.btnCont.UseVisualStyleBackColor = True
        '
        'FormLanguage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 192)
        Me.Controls.Add(Me.btnCont)
        Me.Name = "FormLanguage"
        Me.Text = "Language"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCont As System.Windows.Forms.Button
End Class
