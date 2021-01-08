Public Class SETT

    Private Sub SETT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sett(3) As String
        sett = IO.File.ReadAllLines("settings.txt", System.Text.Encoding.Default)
        If sett(0) <> "[CongressCounter]" Then
            MsgBox("Há um problema no arquivo de configuração. Tente reinstalar o programa.", _
                MsgBoxStyle.Critical, "Congress Counter")
            Exit Sub
        End If
        txtTt.Text = sett(1).Split("=")(1)
        txtEv.Text = sett(2).Split("=")(1)
        txtDt.Value = DateValue(sett(3).Split("=")(1).ToString)
    End Sub

    Private Sub cmdSv_Click(sender As System.Object, e As System.EventArgs) Handles cmdSv.Click
        FileOpen(1, "settings.txt", OpenMode.Output)
        PrintLine(1, "[CongressCounter]")
        PrintLine(1, "Title=" & txtTt.Text)
        PrintLine(1, "Event=" & txtEv.Text)
        PrintLine(1, "Date=#" & txtDt.Value.ToString & "#")
        FileClose(1)
        frmMain.ref()
        Me.Close()
    End Sub

    Private Sub cmdCnc_Click(sender As System.Object, e As System.EventArgs) Handles cmdCnc.Click
        Me.Close()
    End Sub
End Class