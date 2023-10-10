Imports System.Data
Imports System.Data.SqlClient
Public Class Sgnup
    'Declearing connection string 
    Dim dbconn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=LMS;Integrated Security=True")



    Dim gender As String
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Close the app 
            Me.Close()
        Else
            'Do not close te app
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        'get data fom fields into variables 
        Dim Username As String = txtUsername.Text
        Dim Password As String = txtPassword.Text
        Dim Email As String = txtEmail.Text
        Dim Phone As String = txtPhone.Text
        Dim ConPassword = txtConPassword.Text

        If rbnMale.Checked = True Then
            gender = "Male"

        Else
            gender = "Female"

        End If


        'Check wheahther confirm password mtaches with the inputted password 

        If Password = ConPassword Then
            'send data to datatbase
            Dim queryCommand As SqlCommand = New SqlCommand("INSERT INTO Users (Username, Password, Email, Phone, Gender) VALUES ('" + Username + "', '" + Password + "' , '" + Email + "', '" + Phone + "', '" + gender + "'  )", dbconn)

            'open dbconn 
            dbconn.Open()
            queryCommand.ExecuteNonQuery()
            MessageBox.Show("Account Created", "Signup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'close db
            dbconn.Close()
            'clear fields
            Reset()

            Me.Hide()
            Login.Show()



        Else
            MessageBox.Show("Password Mismatched ", "Passwod Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            txtConPassword.Clear()

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reset()
    End Sub
    'method to clear fields 
    Public Sub Reset()
        'CLear all data from felds 
        txtUsername.Clear()
        txtPassword.Clear()
        txtConPassword.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        rbnMale.Checked = False
        rbnFemale.Checked = False



        If rbnMale.Checked = True Then
            gender = "Male"

        ElseIf rbnFemale.Checked = True Then
            gender = "Female"

        Else
            MessageBox.Show("Please Select Gender", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Hode current form 
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class