Imports System.Data.SqlClient
Public Class form_login

    Private Sub form_login_load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        form_master.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan Masukkan Username dan Password")
        Else
            Call koneksi()
            cmd = New SqlCommand("SELECT * FROM penumpang WHERE username = '" & TextBox2.Text & "' AND password = '" & TextBox1.Text & "'", Conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Username Atau Password Salah")
            Else
                Close()
                form_pengunjung.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
        login_admin.Show()
    End Sub
End Class
