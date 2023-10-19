Imports System.DateTime
Imports System.Data.SqlClient
Imports System.IO

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
            picboxProfile.Image = Image.FromFile(OpenFD.FileName)
        End If
    End Sub

    Private Sub OpenFD_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFD.FileOk

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim querryCommand As New SqlCommand("INSERT INTO Staff(FirstName, LastName, Gender, Address, Designation, Phone, profileImage) VALUES(@FirstName, @LastName, @Gender, @Address, @Designation, @Phone, @profileImage)", dbconn)

        'get values from fields into variables 
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim Gender As String
        Dim Address As String = txtAddress.Text
        Dim Designation As String = txtDesignation.Text
        Dim Phone As String = txtPhone.Text


        Try
            Dim profileImage As New MemoryStream
            'store picture into vatiable 
            picboxProfile.Image.Save(profileImage, picboxProfile.Image.RawFormat)

            If picboxProfile.Image Is Nothing Then
                MessageBox.Show("Please select a image", "Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            If rbnMale.Checked = True Then
                Gender = "Male"
            Else
                Gender = "Female"
            End If



            querryCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName
            querryCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName
            querryCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender
            querryCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address
            querryCommand.Parameters.Add("@Designation", SqlDbType.VarChar).Value = Designation
            querryCommand.Parameters.Add("@Phone", SqlDbType.VarChar).Value = Phone
            querryCommand.Parameters.Add("@ProfileImage", SqlDbType.Image).Value = profileImage.ToArray

            'open database 
            dbconn.Open()
            If querryCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Staff Successfully", "New Staff ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FetchStaffData()
            Else
                MessageBox.Show("Fail to add new staf", "New Staff ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
            dbconn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: ")
        End Try


        Reset()

    End Sub

    Private Sub picboxProfile_Click(sender As Object, e As EventArgs) Handles picboxProfile.Click
        Dim OpenFD = New OpenFileDialog

        OpenFD.Filter = "Choose Image(*.JPG; *.PNG; *.JPEG; *.GIF) |  *.JPG; *.PNG; *.JPEG; *.GIF"

        If OpenFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            picboxProfile.Image = Image.FromFile(OpenFD.FileName)
        End If
    End Sub

    'method to fetch data from database 
    Public Sub FetchStaffData()
        Dim querryCommand As New SqlCommand("SELECT * FROM Staff", dbconn)
        Dim adapter As New SqlDataAdapter(querryCommand)
        Dim table As New DataTable

        'Fill records from data table 
        adapter.Fill(table)
        dvgStaffTable.DataSource = table




    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchStaffData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim searchValue As String = txtSearch.Text

        Dim querryCommand As New SqlCommand("SELECT * FROM Staff WHERE Staff_ID LIKE '" + searchValue + "' OR FirstName LIKE '" + searchValue + "' OR Phone LIKE '" + searchValue + "' OR Gender LIKE '" + searchValue + "' OR Phone Like '" + searchValue + "'", dbconn)
        'table adaper 
        Dim adapter As New SqlDataAdapter(querryCommand)
        Dim table As New DataTable
        adapter.Fill(table)
        dvgStaffTable.DataSource = table

        'check if there was a record match 
        If table.Rows.Count > 0 Then
            MessageBox.Show("Recod Found", "Seach", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Recod Not Found", "Seach", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)
        End If
    End Sub
End Class