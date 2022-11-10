<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.btnUserLogin = New System.Windows.Forms.Button()
        Me.btnDoctorLogin = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(565, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(904, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Doctor"
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Location = New System.Drawing.Point(173, 278)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(143, 29)
        Me.btnAdminLogin.TabIndex = 3
        Me.btnAdminLogin.Text = "Admin Log in"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'btnUserLogin
        '
        Me.btnUserLogin.Location = New System.Drawing.Point(515, 278)
        Me.btnUserLogin.Name = "btnUserLogin"
        Me.btnUserLogin.Size = New System.Drawing.Size(143, 29)
        Me.btnUserLogin.TabIndex = 4
        Me.btnUserLogin.Text = "User Log in"
        Me.btnUserLogin.UseVisualStyleBackColor = True
        '
        'btnDoctorLogin
        '
        Me.btnDoctorLogin.Location = New System.Drawing.Point(866, 278)
        Me.btnDoctorLogin.Name = "btnDoctorLogin"
        Me.btnDoctorLogin.Size = New System.Drawing.Size(143, 29)
        Me.btnDoctorLogin.TabIndex = 5
        Me.btnDoctorLogin.Text = "Doctor Log in"
        Me.btnDoctorLogin.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(983, 724)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 14)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sign Up/Register as User"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 803)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnDoctorLogin)
        Me.Controls.Add(Me.btnUserLogin)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("SansSerif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents btnUserLogin As Button
    Friend WithEvents btnDoctorLogin As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
