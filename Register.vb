'Imports the MySql Library
Imports MySql.Data.MySqlClient


Public Class Register
    'Declare variables for the MySql connection, command, reader, and test-query
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

    'Creates a Function for Database Connection
    Sub Connect()
        conn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=healthcaredb;"
            }
        conn.Open()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            'Tests if the Textboxes are filled-in with correct and complete Information
            If txtName.Text = "" Or txtMobileNum.Text = "" Or txtEmail.Text = "" Or
                txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Please Fill-in the TextBoxes with Complete Information!",
                                    "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                'Tests if the Password and Confirm password have matched
                If txtPassword.Text <> txtConfirmPassword.Text Then
                    MessageBox.Show("Password and Confirm Password does not Match!",
                                   "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else

                    'Connects with the data base to test if the Product Code is already listed
                    Connect()
                    query = "select name from user_info where name = @name"
                    With command
                        .CommandText = query
                        .Connection = conn
                        .Parameters.Clear()
                        .Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text.Trim
                    End With
                    'Reads from the data base and check if the data is already present
                    reader = command.ExecuteReader
                    If reader.Read Then
                        'Displays an Exclamation Message if the Product code is already Present in the Database
                        MsgBox("Information for the Product Code is already in the Database", MsgBoxStyle.Exclamation)
                    Else
                        'If the product code is unique or no prior similar inputs, Then,
                        'Perform Insert Query
                        'Adds information into the database (tbl_productinfo)
                        Connect()
                        query = "insert into user_info (name, mobile_num, email, password) values 
                                (@name, @mobile_num, @email, @password)"
                        command.CommandText = query
                        command.Connection = conn
                        command.Parameters.Clear()
                        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text.Trim
                        command.Parameters.Add("@mobile_num", MySqlDbType.Int64).Value = txtMobileNum.Text.Trim
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text.Trim
                        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text.Trim
                        command.ExecuteNonQuery()
                        MsgBox("Successfully Registered!", MsgBoxStyle.Information)

                        Me.Close()

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim response As DialogResult = MessageBox.Show(" Do you wat to exit the User Registration?", " Close", MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If response = DialogResult.Yes Then
            Me.Close()
            Login.Visible = True
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class