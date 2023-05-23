Imports System.Data.SqlClient

Public Class user_form
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Sub KondisiAwal()
        koneksi()
        da = New SqlDataAdapter("Select * from petugas", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "petugas")
        DataGridView1.DataSource = (ds.Tables("petugas"))
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Petugas")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into petugas values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            cmd = New SqlCommand(simpan, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
End Class