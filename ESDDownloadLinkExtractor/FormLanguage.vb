Public Class FormLanguage
    Dim lang As New List(Of String)
    Private Sub FormLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        lang.Add("ar-sa")
        lang.Add("cz-cz")
        lang.Add("de-de")
        lang.Add("en-gb")
        lang.Add("en-us")
        lang.Add("es-es")
        lang.Add("fi-fi")
        lang.Add("fr-fr")
        lang.Add("it-it")
        lang.Add("ja-jp")
        lang.Add("ko-kr")
        lang.Add("nl-nl")
        lang.Add("pl-pl")
        lang.Add("pt-br")
        lang.Add("ru-ru")
        lang.Add("sv-se")
        lang.Add("th-th")
        lang.Add("tr-tr")
        lang.Add("zh-cn")
        lang.Add("zh-tw")
        Call SetRadioButtons(lang)
        lang.RemoveRange(0, lang.Count)
    End Sub

    Private Sub SetRadioButtons(ByVal Langs As List(Of String))
        Dim myRB As RadioButton
        Dim y As Integer = Langs.Count - 1
        For x As Integer = 0 To y
            myRB = New RadioButton
            myRB.Location = New Point(10, y)
            myRB.Text = Langs.Item(x)
            myRB.Name = Text
            Me.Controls.Add(myRB)
            y += 20
        Next
    End Sub

    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click
        Dim rButton As RadioButton = Me.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked = True)
        Dim CorD As String = Nothing
        Try
            If rButton.Text.ToString = "ar-sa" Or rButton.Text.ToString = "de-de" Or _
    rButton.Text.ToString = "en-us" Or rButton.Text.ToString = "es-es" Or rButton.Text.ToString = "fr-fr" Or rButton.Text.ToString = "it-it" Or _
    rButton.Text.ToString = "ja-jp" Or rButton.Text.ToString = "ko-kr" Or rButton.Text.ToString = "pt-br" Or rButton.Text.ToString = "tr-tr" = True Then
                CorD = "/d/updt"
            Else
                CorD = "/c/updt"
            End If
        Catch ex As Exception
            MsgBox("Please select a language!")
        End Try
        If CorD = Nothing = False Then
            Form1.CorD = CorD
            Me.Close()
        End If
    End Sub
End Class