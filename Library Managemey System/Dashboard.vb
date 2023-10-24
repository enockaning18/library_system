Imports System.Data
Imports System.Data.SqlClient
Public Class Dashboard
    Dim dbconn = New SqlConnection("Data Source=.;Initial Catalog=LMS;Integrated Security=True")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the application 

        If MessageBox.Show("Do you want to exit the application?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        Else
            'Do not close the application 
        End If

    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        'Code to hide form 
        WindowState = FormWindowState.Minimized

        'check the state of the window to decide
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized

        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'COde to hide form
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblTotalStaff.Click
        CountTotalStaff()
    End Sub

    Public Sub CountTotalStaff()
        Dim querryCommand As New SqlCommand("SELECT COUNT(*) FROM Staff", dbconn)
        dbconn.Open()
        Dim TotalStaff As String = querryCommand.ExecuteScalar
        lblTotalStaff.Text = TotalStaff
        dbconn.Close()


    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs)
        'calling count staff method 
        CountTotalStaff()
    End Sub

    Private Sub Dashboard_Load_1(sender As Object, e As EventArgs)

    End Sub
End Class