Imports System.Data.SqlClient

Module ModuleLogin
    Public Conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public MyDB As String
    Public Sub koneksi()
        MyDB = "Data Source=FAHRY;Initial Catalog=lks;Integrated Security=True"

        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
