Imports System.Data.SqlClient
Public Class form_admin
    Private Sub form_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LksDataSet.penumpang' table. You can move, or remove it, as needed.
        Me.PenumpangTableAdapter.Fill(Me.LksDataSet.penumpang)
        'TODO: This line of code loads data into the 'LksDataSet.pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter.Fill(Me.LksDataSet.pemesanan)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM penumpang", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

    End Sub
End Class