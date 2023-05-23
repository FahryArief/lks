Public Class form_pengunjung
    Sub lock()
        BerandaToolStripMenuItem.Enabled = True
        TiketToolStripMenuItem.Enabled = True
        HistoryToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = True
    End Sub
    Private Sub form_pengunjung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        form_master.Show()
    End Sub

    Private Sub TiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiketToolStripMenuItem.Click
        tiket_p.Show()
    End Sub
End Class