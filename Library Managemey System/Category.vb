Imports System.Data
Imports System.Data.SqlClient
Public Class Category
    Dim dbconn = New SqlConnection("Data Source=.;Initial Catalog=LMS;Integrated Security=True")
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("DO you want to close the application", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        Else
            'keep using the application
        End If
    End Sub
    Public Sub Reset()
        txtCategoryID.Clear()
        txtName.Clear()
        dtpDateAdded.Text = ""
        cmbCreatedBy.SelectedIndex = -1
    End Sub

    Public Sub FetchData()
        'feching data into combo box 
        Dim querryCommand As New SqlCommand("SELECT Staff_ID, FirstName, LastName  FROM Staff", dbconn)
        Dim Adapter As New SqlDataAdapter(querryCommand)
        Dim Table As New DataTable
        Adapter.Fill(Table)
        cmbCreatedBy.DataSource = Table
        cmbCreatedBy.DisplayMember = "Staff_ID"
        'valu member helps with non duplicate names 
        cmbCreatedBy.ValueMember = "Staff_ID"
    End Sub

    Public Sub FetchCategory()
        Dim querryCommand As New SqlCommand("SELECT Cat_ID, NAME, CONCAT(FirstName ,' ', LastName) AS CreatedBy_LastName  FROM Category INNER JOIN Staff ON Category.Staff_ID = Staff.Staff_ID", dbconn)
        Dim Adapter As New SqlDataAdapter(querryCommand)
        Dim Table As New DataTable
        Adapter.Fill(Table)
        dvgStaffTable.DataSource = Table
    End Sub

    Private Sub txtReset_Click(sender As Object, e As EventArgs) Handles txtReset.Click
        Reset()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim CategoryName As String = txtName.Text
        Dim DateAdded As String = dtpDateAdded.Value
        'Dim SraffID As Integer = cmbCreatedBy.SelectedItem
        Dim querryCommand As New SqlCommand("INSERT INTO Category(NAME, DateAdded, Staff_ID) VALUES ('" + CategoryName + "', '" + DateAdded + "', '" & cmbCreatedBy.SelectedItem(0) & "') ", dbconn)

        dbconn.Open
        If querryCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show("New Category Added Successfully", "New Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FetchCategory()
            Reset()
        Else
            MessageBox.Show("Fail to add Category ", " Category", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub dvgStaffTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgStaffTable.CellContentClick

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()
        FetchCategory()
    End Sub
End Class