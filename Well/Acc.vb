Imports System.Data.SqlClient

Public Class Acc

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load() Handles MyBase.Load
        ' สร้าง query
        Dim query1 As String = "SELECT * FROM userinhere"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, sqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGridView1.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBox9.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoStaff As ChooseStaffName ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoStaff = New ChooseStaffName()
        newFormSChoStaff.ShowDialog()

        TextBox1.Text = newFormSChoStaff.txtStaffID
        TextBox2.Text = newFormSChoStaff.txtStaffName
        TextBox3.Text = newFormSChoStaff.txtLastName

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoStaff As ChooseToEditAcc ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoStaff = New ChooseToEditAcc()
        newFormSChoStaff.ShowDialog()

        TextBox8.Text = newFormSChoStaff.txtStaffID
        TextBox7.Text = newFormSChoStaff.txtStaffName
        TextBox6.Text = newFormSChoStaff.txtLastName
        TextBox5.Text = newFormSChoStaff.txtPasswd
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firstName As String = TextBox1.Text
        Dim lastName As String = TextBox4.Text

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO authent (staffID, passwd) VALUES (@FirstName, @LastName)"

            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            FormData_Load()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM authent WHERE staffID = @StaffID"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@StaffID", TextBox9.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("DELETE SUCCESFULLY", "COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("GOT ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            FormData_Load()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim firstName As String = TextBox8.Text
        Dim lastName As String = TextBox5.Text

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE authent SET passwd = @LastName WHERE staffID = @FirstName"

            Using command As New SqlCommand(query, connection)
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            FormData_Load()
        End Using

    End Sub

End Class