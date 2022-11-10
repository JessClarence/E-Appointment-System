Imports MySql.Data.MySqlClient
Public Class frmEditInformtion
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String

    Sub connect()
        conn = New MySqlConnection With {
            .ConnectionString = "server = localhost; userid = root; password =; database = healthcaredb"
        }
        conn.Open()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        mskMobileNumber.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        cboGenderF2.SelectedIndex = -1


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Form1.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text = String.Empty Then
            MsgBox(" Name is missing!", MsgBoxStyle.Exclamation, "ERROR")
        Else
            If mskMobileNumber.Text = String.Empty Then
                MsgBox(" Phone number is missing !", MsgBoxStyle.Exclamation, "ERROR")
            ElseIf mskMobileNumber.Text.Length <> 14 Then
                MsgBox(" Invalid phone number", MsgBoxStyle.Exclamation, "ERROR")
            Else
                If txtEmail.Text = String.Empty Then
                    MsgBox(" Email is missing!", MsgBoxStyle.Exclamation, "ERROR")
                Else
                    If txtPassword.Text = String.Empty Then
                        MsgBox(" Password is missing!", MsgBoxStyle.Exclamation, "ERROR")
                    Else
                        If cboGenderF2.SelectedIndex = -1 Then
                            MsgBox(" Gender is missing!", MsgBoxStyle.Exclamation, "ERROR")
                        Else
                            connect()


                            Form1.Enabled = True
                            Me.Close()
                        End If
                    End If

                End If

            End If
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskMobileNumber.MaskInputRejected

    End Sub
End Class