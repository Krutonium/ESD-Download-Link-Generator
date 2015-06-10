Imports System.IO
Imports System.Net.Http
Imports System.Net

Public Class Form1
    Dim WithEvents WS As New WebClient
    Dim Filename As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "ESD Download Link Extractor"
        txtLink.Enabled = False
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        Dim result = MsgBox("Open ESD Database?", MsgBoxStyle.YesNo, "Build List")
        If result = MsgBoxResult.Yes Then
            Process.Start("www.ms-vnext.net/Win10esds/")
        End If
        Call InfoBasedDL()
    End Sub
    Public Property CorD As String
    Public Property ESDName As String
    Public Property SHA1 As String = 0
    Public Property Datee As String = 0

    Private Sub InfoBasedDL()
        tbSHA1.Text = tbSHA1.Text.Trim
        tbName.Text = tbName.Text.Trim
        If tbName.TextLength = 0 Then
            MsgBox("Please insert the name of the ESD!")
            Exit Sub
        Else
            ESDName = tbName.Text
        End If
        If tbSHA1.TextLength = 40 = False Then
            MsgBox("SHA1 is not correct. It is either too long or too short.")
            Exit Sub
        Else
            SHA1 = tbSHA1.Text
        End If
        If tbDate.TextLength = 7 = False Then
            MsgBox("Bad Date!")
            Exit Sub
        Else
            Datee = tbDate.Text
        End If

        CorD = "/c/updt"
        Dim DLLink As String = "http://b1.download.windowsupdate.com" & CorD & "/" & Datee & "/" & ESDName & "_" & SHA1 & ".esd"
        If RemoteFileOk(DLLink) = False Then
            CorD = "/d/updt"
            DLLink = "http://b1.download.windowsupdate.com" & CorD & "/" & Datee & "/" & ESDName & "_" & SHA1 & ".esd"
            If RemoteFileOk(DLLink) = False Then
                MsgBox("Some of the info you entered appears to be wrong. Please try again!")
            Else
                txtLink.Text = DLLink
                txtLink.Enabled = True
            End If
        Else
            txtLink.Text = DLLink
            txtLink.Enabled = True
        End If
    End Sub

    Private Function RemoteFileOk(ByVal Url As String) As Boolean
        Using client As New HttpClient,
            responseTask As Task(Of HttpResponseMessage) = client.GetAsync(Url, HttpCompletionOption.ResponseHeadersRead)
            responseTask.Wait()
            Using response As HttpResponseMessage = responseTask.Result
                Return response.IsSuccessStatusCode
            End Using
        End Using
    End Function
    Private Sub CurrentlyDownloading()
        Dim ProcGo As New ProcessStartInfo
        ProcGo.Arguments = "–ExecutionPolicy Bypass Get-BitsTransfer -AllUsers | Select -ExpandProperty FileList | Select -ExpandProperty RemoteName"
        ProcGo.RedirectStandardOutput = True
        ProcGo.FileName = "C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe"
        ProcGo.UseShellExecute = False
        ProcGo.CreateNoWindow = True
        Dim ProcOut As Process = Process.Start(ProcGo)
        ProcOut.WaitForExit()
        Dim OutPut As String = ProcOut.StandardOutput.ReadToEnd
        Dim Split As List(Of String) = OutPut.Split("http").ToList
        For Each item In Split
            If item.ToUpper.Contains(".ESD") Then
                txtLink.Enabled = True
                txtLink.Text = "h" & item
                Exit For
            End If
        Next
        If txtLink.Enabled = False Then
            MsgBox("Sorry, failed to retrieve the link - is it currently downloading? It should be.")
        Else
            MsgBox("Please note that this download link is time sensitive.")
        End If
    End Sub

    Private Sub rdoSlow_CheckedChanged(sender As Object, e As EventArgs)
        'If rdoSlow.Checked = True Then
        '    MsgBox("Please keep in mind that this will only work for files that Microsoft has actually released!")
        'End If
    End Sub

    Private Sub cmdCpyToClp_Click(sender As Object, e As EventArgs) Handles cmdCpyToClp.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(txtLink.Text)
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub cmdCurrent_Click(sender As Object, e As EventArgs) Handles cmdCurrent.Click
        Call CurrentlyDownloading()
    End Sub

    Private Sub btnDownloadBuild_Click(sender As Object, e As EventArgs) Handles btnDownloadBuild.Click
        DownloadFile(txtLink.Text)
    End Sub

    Public Sub DownloadFile(ByVal URL As String)
        Filename = Path.GetFileName(URL)
        SaveFileDialog1.ShowDialog()
        WS.DownloadFileAsync(New Uri(URL), SaveFileDialog1.FileName)
        MsgBox("Downloading!")
    End Sub
    Private Sub WS_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WS.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Dim NandS As String = FileName & vbNewLine & (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000.0#)).ToString("#")
        lblNameAndSpeed.Text = NandS
    End Sub
End Class
