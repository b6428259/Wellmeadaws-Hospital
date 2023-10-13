Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set placeholder text for Tboxuser
        SetPlaceholderText(Tboxuser, "Enter your Username")

        ' Set placeholder text for Tboxpass
        SetPlaceholderText(Tboxpass, "Enter your Password")

        ' Set focus to the Username textbox
        Me.ActiveControl = Tboxuser
    End Sub

    Private Sub SetPlaceholderText(textBox As TextBox, placeholder As String)
        textBox.Text = placeholder
        textBox.ForeColor = Color.Gray ' Set the placeholder text color
        textBox.Font = New Font(textBox.Font, FontStyle.Italic) ' Italicize the placeholder text
    End Sub

    Private Sub ClearPlaceholderText(textBox As TextBox, placeholder As String)
        If textBox.Text = placeholder Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black ' Restore the original text color
            textBox.Font = New Font(textBox.Font, FontStyle.Regular) ' Restore the original font style
        End If
    End Sub

    Private Sub Tboxuser_Enter(sender As Object, e As EventArgs) Handles Tboxuser.Enter
        ClearPlaceholderText(Tboxuser, "Enter your Username")
    End Sub

    Private Sub Tboxuser_Leave(sender As Object, e As EventArgs) Handles Tboxuser.Leave
        If String.IsNullOrWhiteSpace(Tboxuser.Text) Then
            SetPlaceholderText(Tboxuser, "Enter your Username")
        End If
    End Sub

    Private Sub Tboxpass_Enter(sender As Object, e As EventArgs) Handles Tboxpass.Enter
        ClearPlaceholderText(Tboxpass, "Enter your Password")
    End Sub

    Private Sub Tboxpass_Leave(sender As Object, e As EventArgs) Handles Tboxpass.Leave
        If String.IsNullOrWhiteSpace(Tboxpass.Text) Then
            SetPlaceholderText(Tboxpass, "Enter your Password")
        End If
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