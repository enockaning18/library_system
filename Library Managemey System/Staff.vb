Imports System.DateTime
Imports System.Data.SqlClient
Public Class Staff
    Dim dbconn = New SqlConnection("Data Source=.;Initial Catalog=LMS;Integrated Security=True")
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        'Hide the window 
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        'checking state beofre maximixing it 
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'terminale the app on click 
        If MessageBox.Show("Do you want to exit application", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        Else
            'keep using the application 
        End If

    End Sub

    Private Sub txtReset_Click(sender As Object, e As EventArgs) Handles txtReset.Click

    End Sub

    'RESET METHOD 
    Public Sub Reset()
        txtStaffID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtDesignation.Clear()
        rbnMale.Checked = False
        rbnFemale.Checked = False
        picboxProfile.Image = Nothing

    End Sub

    Private Sub picboxProfile_Paint(sender As Object, e As PaintEventArgs)
        Dim OpenFD = New OpenFileDialog

        OpenFD.Filter = "Choose Image(*.JPG; *.PNG; *.JPEG; *.GIF) |  *.JPG; *.PNG; *.JPEG; *.GIF"

        If OpenFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            picboxProfile.Image.FromFile(OpenFD.FileName)
        End If
    End Sub

    Private Sub OpenFD_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFD.FileOk

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim querryCommand As New SqlCommand("INSERT INTO Staff(FirstName, LastName, Gender, Address, Designation, Phone, profileImage VALUES(@FirstName, @LastName, @Gender, @Address, @Designation, @Phone, @profileImage)", dbconn)
        'get values from fields into variables 
        Dim FirstName As String = FirstName
        Dim LastName As String = LastName
        Dim Gender As String = Gender
        Dim Address As String = Address
        Dim Designation As String = Designation
        Dim Phone As String = Phone
        Dim profileImage As New MemoryStream
    End Sub
End Class