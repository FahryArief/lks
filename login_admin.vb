Imports System.Data.SqlClient
Public Class login_admin

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan Masukkan Username dan Password")
        Else
            Call koneksi()
            cmd = New SqlCommand("SELECT * FROM petugas WHERE username = '" & TextBox2.Text & "' AND password = '" & TextBox1.Text & "'", Conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr.Item("level").ToString = "admin" Then
                    form_admin.Show()
                Else
                    form_petugas.Show()
                End If
            Else
                MessageBox.Show("Akun anda belum terdaftar!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        form_master.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
        form_login.Show()
    End Sub

    Private Sub login_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"


    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class