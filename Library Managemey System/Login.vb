Imports System.Data
Imports System.Data.SqlClient

Public Class Login

    Dim dbconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=LMS;Integrated Security=True")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Close the app 
            Me.Close()
        Else
            'Do not close te app
        End If
    End Sub

    Private Sub llkforgotpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llkforgotpassword.LinkClicked
        MessageBox.Show("Kidly contact the staf to rest password", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub llkSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llkSignup.LinkClicked
        Me.Hide()

        Sgnup.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'check when fields are empty 
        If txtUsername.Text = String.Empty And txtPassword.Text = String.Empty Then
            MessageBox.Show("Fields can't be empty please provide logins", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

        Else
            'Featch username and passwords fields from the database and compare before giving acces 
            Dim Username As String
            Dim Password As String

            Username = txtUsername.Text
            Password = txtPassword.Text

            Dim queryCommand As SqlCommand = New SqlCommand("SELECT Username, Password FROM Users  WHERE Username = @Username AND Password = @Password", dbconn)
            queryCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username
            queryCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password

            'bridge for data to be stored in the table 
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryCommand)
            Dim table As DataTable = New DataTable

            'store fecth data in table 
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                MessageBox.Show("Welcome " + Username + ", access granted ", "Account Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Dashboard.Show()

            Else
                MessageBox.Show("Sorry" + Username + ", access not grated", "Login ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            End If

        End If
    End Sub
End Class