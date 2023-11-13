Public Class Login

    Dim WithEvents backgroundWorker As New System.ComponentModel.BackgroundWorker()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set placeholder text for Tboxuser
        Tboxuser.Text = "Enter your Username"
        ' Center the placeholder text
        Tboxuser.TextAlign = HorizontalAlignment.Center
        ' Set a slightly larger font size for the placeholder text
        Tboxuser.Font = New Font(Tboxuser.Font.FontFamily, 12.0F)
        ' Adjust left padding to move text further to the left
        Tboxuser.Padding = New Padding(20, Tboxuser.Padding.Top, Tboxuser.Padding.Right, Tboxuser.Padding.Bottom)

        ' Set placeholder text for Tboxpass
        Tboxpass.Text = "Enter your Password"
        ' Center the placeholder text
        Tboxpass.TextAlign = HorizontalAlignment.Center
        ' Set a slightly larger font size for the placeholder text
        Tboxpass.Font = New Font(Tboxpass.Font.FontFamily, 12.0F)
        ' Adjust left padding to move text further to the left
        Tboxpass.Padding = New Padding(20, Tboxpass.Padding.Top, Tboxpass.Padding.Right, Tboxpass.Padding.Bottom)

        Tboxuser.Focus()



    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        ' Get the entered username and password
        Dim enteredUsername As String = Tboxuser.Text
        Dim enteredPassword As String = Tboxpass.Text

        ' Check if the entered username and password match the valid credentials
        If enteredUsername = "1" AndAlso enteredPassword = "1" Then
            ' Successful login
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Hide the login form
            Me.Hide()

            ' Create an instance of FormMain and show it
            Dim mainForm As New FormMain()
            mainForm.ShowDialog()

            ' Close the application after the main form is closed (if needed)
            Application.Exit()
        Else
            ' Invalid login
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class
