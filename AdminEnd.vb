'Imports the MySql Library
Imports MySql.Data.MySqlClient
Public Class AdminEnd
    'Declare variables for the MySql connection, command, reader, and test-query
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String
    Sub Connect()
        conn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=healthcaredb;"
            }
        conn.Open()
    End Sub
    Private Sub AdminEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        query = "select * from admin_info"
        With command
            .CommandText = query
            .Connection = conn
        End With
        reader = command.ExecuteReader
        While reader.Read
            lblWelcome.Text = ("Welcome back, " & reader.GetString("name"))
            lblName.Text = reader.GetString("name")
        End While
    End Sub


End Class