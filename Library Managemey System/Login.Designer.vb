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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.llkforgotpassword = New System.Windows.Forms.LinkLabel()
        Me.llkSignup = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 593)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.llkforgotpassword)
        Me.Panel3.Controls.Add(Me.llkSignup)
        Me.Panel3.Controls.Add(Me.btnLogin)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtUsername)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(36, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 411)
        Me.Panel3.TabIndex = 6
        '
        'llkforgotpassword
        '
        Me.llkforgotpassword.AutoSize = True
        Me.llkforgotpassword.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.llkforgotpassword.Location = New System.Drawing.Point(275, 248)
        Me.llkforgotpassword.Name = "llkforgotpassword"
        Me.llkforgotpassword.Size = New System.Drawing.Size(107, 17)
        Me.llkforgotpassword.TabIndex = 10
        Me.llkforgotpassword.TabStop = True
        Me.llkforgotpassword.Text = "Fogot password "
        '
        'llkSignup
        '
        Me.llkSignup.AutoSize = True
        Me.llkSignup.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.llkSignup.Location = New System.Drawing.Point(25, 250)
        Me.llkSignup.Name = "llkSignup"
        Me.llkSignup.Size = New System.Drawing.Size(191, 17)
        Me.llkSignup.TabIndex = 10
        Me.llkSignup.TabStop = True
        Me.llkSignup.Text = "Don't have an account? Sign up"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Maroon
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogin.Location = New System.Drawing.Point(21, 295)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(373, 50)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(191, 149)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(203, 34)
        Me.txtPassword.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(191, 63)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(203, 34)
        Me.txtUsername.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 95)
        Me.Panel2.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.BackColor = System.Drawing.Color.Maroon
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(410, 26)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(201, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 38)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 593)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents llkSignup As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents llkforgotpassword As LinkLabel
End Class
