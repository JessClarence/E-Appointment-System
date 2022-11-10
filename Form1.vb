Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnViewDoctor_Click(sender As Object, e As EventArgs) Handles btnViewDoctor.Click
        ViewDoctorTabPage.Show()
        RequestChatTab.Hide()
    End Sub

    Private Sub btnRequestChat_Click(sender As Object, e As EventArgs) Handles btnRequestChat.Click
        RequestChatTab.Show()
        ViewDoctorTabPage.Hide()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsersName.Clear()
        txtMobile.Clear()
        txtUserEmail.Clear()
        cboGender.Text = String.Empty
        cboDoctorsName.Text = String.Empty
        txtTypeOfDoctor.Text = String.Empty
        txtDoctorID.Clear()
        txtDoctorQualification.Clear()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnEditInformation.Click
        frmEditInformtion.Visible = True
        Me.Enabled = False

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        frmEditInformtion.Visible = True
        Me.Enabled = False

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim answer As DialogResult = MessageBox.Show(" You are currently sign-in as a member," & ControlChars.NewLine &
                        "Do you want to log out and sign-in as a doctor? ", " Switch User",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If answer = DialogResult.Yes Then
            MsgBox(" Barbelat")
        Else

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim answer As DialogResult = MessageBox.Show(" You are currently sign-in as a member," & ControlChars.NewLine &
                       "Do you want to log out and sign-in as a doctor? ", " Switch User",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If answer = DialogResult.Yes Then
            MsgBox(" Barbelat")
        Else

        End If
    End Sub
End Class
