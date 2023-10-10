Public Class Dashboard
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
End Class