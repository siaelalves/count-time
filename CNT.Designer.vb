Public Class frmMain

    Public Dt As Date = DateValue(IO.File.ReadAllLines("settings.txt", System.Text.Encoding.Default)(3).Split("=")(1))
    Public Ev As String = IO.File.ReadAllLines("settings.txt", System.Text.Encoding.Default)(2).Split("=")(1)
    Public Tt As String = IO.File.ReadAllLines("settings.txt", System.Text.Encoding.Default)(1).Split("=")(1)

    Public Sub ref()
        If Dias.Text = "0 dias" And Horas.Text = "0:0:0:0" Then
            MsgBox("O programa do congresso acaba de começar.", MsgBoxStyle.Information, "Congresso de Distrito")
            Exit Sub
        Else
            Dias.Text = (Dt - DateAndTime.Now).Days.ToString & " dias"
            Horas.Text = (Dt - DateAndTime.Now).Hours.ToString & ":" & _
            (Dt - DateAndTime.Now).Minutes.ToString & ":" & _
            (Dt - DateAndTime.Now).Seconds.ToString
            NotifyIcon.Text = Dias.Text & Chr(13) & Horas.Text
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTt.Text = Tt
        lblEv.Text = Ev
        ref()
    End Sub

    Private Sub Tempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tempo.Tick
        ref()
    End Sub

    Private Sub NotifyIcon_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        Me.Show()
    End Sub

    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ConfigurarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarToolStripMenuItem.Click
        SETT.ShowDialog()
    End Sub
End Class
