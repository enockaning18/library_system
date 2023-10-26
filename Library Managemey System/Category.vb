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
        Dim querryCommand As New SqlCommand("SELECT Cat_ID, NAME, DateAdded, CONCAT(FirstName ,' ', LastName) AS CreatedBy_LastName  FROM Category INNER JOIN Staff ON Category.Staff_ID = Staff.Staff_ID", dbconn)
        Dim Adapter As New SqlDataAdapter(querryCommand)
        Dim Table As New DataTable
        Adapter.Fill(Table)
        dvgCategoryTable.DataSource = Table
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

    Private Sub dvgStaffTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgCategoryTable.CellContentClick

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()
        FetchCategory()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llkSearch.LinkClicked
        Dim SearchValue As String = txtSearch.Text
        Dim querryCommand As New SqlCommand("SELECT * FROM Category WHERE Cat_ID LIKE '%" + SearchValue + "%' OR NAME LIKE '%" + SearchValue + "%' OR DateAdded LIKE '%" + SearchValue + "%'", dbconn)

        Dim Adapter As New SqlDataAdapter(querryCommand)
        Dim Table As New DataTable
        Adapter.Fill(Table)
        dvgCategoryTable.DataSource = Table

        If Table.Rows.Count > 0 Then
            MessageBox.Show("Record Found", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Match Record", "Staff", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information)
            txtSearch.Focus()
            FetchCategory()
            txtSearch.Clear()

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim Edit As New DataGridViewRow
        Edit = dvgCategoryTable.SelectedRows(0)

        Dim CreatedBy As String = cmbCreatedBy.SelectedItem(0)

        txtCategoryID.Text = Edit.Cells(0).Value.ToString()
        txtName.Text = Edit.Cells(1).Value.ToString()
        dtpDateAdded.Text = Edit.Cells(2).Value.ToString()
        CreatedBy = Edit.Cells(3).Value.ToString()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim CategoryName As String = txtName.Text
        Dim DateAdded As String = dtpDateAdded.Value
        Dim CreatedBy As String = cmbCreatedBy.SelectedItem(0)

        Dim querryCommand As New SqlCommand("UPDATE Category SET NAME = '" + CategoryName + "', DateAdded = '" + DateAdded + "',Staff_ID = '" + CreatedBy + "' WHERE Cat_ID = '" + txtCategoryID.Text + "'", dbconn)


        dbconn.Open()
        If querryCommand.ExecuteNonQuery() Then
            MessageBox.Show("Category Record Updated Successfully", "Category ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FetchCategory()
            Reset()
        Else
            MessageBox.Show("Fail to Update Category", "Category ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
        dbconn.Close()
    End Sub
End Class