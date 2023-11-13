Imports System.Data.SqlClient

Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tboxuser_Leave(Nothing, Nothing)
        Tboxpass_Leave(Nothing, Nothing)
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
        Tboxpass.PasswordChar = "*"
    End Sub

    Private Sub Tboxpass_Leave(sender As Object, e As EventArgs) Handles Tboxpass.Leave
        If String.IsNullOrWhiteSpace(Tboxpass.Text) Then
            SetPlaceholderText(Tboxpass, "Enter your Password")
            Tboxpass.PasswordChar = ""
        End If
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        PerformLogin()
    End Sub

    ' Handle the Enter key press to trigger login
    Private Sub Tboxpass_KeyDown(sender As Object, e As KeyEventArgs) Handles Tboxpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformLogin()
        End If
    End Sub

    Private Sub PerformLogin()
        Dim username As String = Tboxuser.Text
        Dim password As String = Tboxpass.Text

        Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
        'sql command
        Dim query As String = "SELECT * FROM authent WHERE staffID=@username AND passwd=@password"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
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
            End Using
        End Using
    End Sub
End Class
