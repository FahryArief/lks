Public Class form_master

    Sub lock()
        HomeToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        DaftarToolStripMenuItem.Enabled = True
    End Sub
    Private Sub form_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LksDataSet.transportasi' table. You can move, or remove it, as needed.
        Me.TransportasiTableAdapter.Fill(Me.LksDataSet.transportasi)
        'TODO: This line of code loads data into the 'LksDataSet.tipe_transportasi' table. You can move, or remove it, as needed.
        Me.Tipe_transportasiTableAdapter.Fill(Me.LksDataSet.tipe_transportasi)
        'TODO: This line of code loads data into the 'LksDataSet.rute' table. You can move, or remove it, as needed.
        Me.RuteTableAdapter.Fill(Me.LksDataSet.rute)
        Call lock()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        form_login.Show()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub




    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Left >= Me.Width Then
            Label1.Left = -Label1.Width
        Else
            Label1.Left = Label1.Left + 10
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DaftarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarToolStripMenuItem.Click
        register.Show()
    End Sub
End Class