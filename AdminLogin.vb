'Imports the MySql Library
Imports MySql.Data.MySqlClient
Public Class AdminLogin
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


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtEmail.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Please Fill-in the TextBoxes with Correct and Complete Inputs!",
                                        "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Connect()
                query = " select * from admin_info where email = @email AND password = @password  "
                With command
                    .CommandText = query
                    .Connection = conn
                    With .Parameters
                        .Clear()
                        .Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim
                        .Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text.Trim
                    End With
                End With
                reader = command.ExecuteReader

                If reader.Read Then
                    MsgBox(" Logged in Successfully as Admin!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Login.Visible = False
                    AdminEnd.Visible = True
                Else
                    MessageBox.Show("The account entered does not exist!",
                                       "Wrong Email or Password!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtEmail.Clear()
                    txtPassword.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class