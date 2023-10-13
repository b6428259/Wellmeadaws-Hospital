Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Staff

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load(sender As Object, e As EventArgs)


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Staff"

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


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM Staff"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM Staff WHERE StaffID LIKE @SearchText OR FirstName LIKE @SearchText OR LastName LIKE @SearchText OR Tel LIKE @SearchText"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(selectQuery, connection)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        ' Add a parameter for the search term
                        command.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                    End If

                    connection.Open()

                    ' Create a DataTable to store the retrieved data
                    Dim dataTable As New DataTable()

                    ' Execute the query and fill the DataTable with the patient information
                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable

                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions and display an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetNextID() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(StaffID) FROM Staff"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "S001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "S" & nextID.ToString("D3")
                End If
            End Using
        End Using
    End Function
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim oDate As DateTime = Convert.ToDateTime(DateTimeB.Text)


        Try

            Dim nextID As String = GetNextID()

            ' สร้างคำสั่ง SQL ด้วยพารามิเตอร์
            'Dim sqlin As String = "INSERT INTO staff VALUES(@staffid, @firstname, @lastname, @sex, @nin, @currentsalary, @address, @position, @telephonenumber, @dateofbirth, @wards_wardid)"
            Dim sqlin As String = "INSERT INTO staff (StaffID ,FirstName, LastName, Address, Tel, DateOfBirth, Sex, NationalInsuranceNumber, Position, CurrentSalary, HoursWorkedPerWeek) VALUES('" & nextID & "','" & txtBoxFirstname.Text & "', '" & txtBoxLastname.Text & "', '" & txtBoxAddr.Text & "', '" & txtBoxTele.Text & "', '" & oDate & "', '" & ComboBoxSex2.Text & "', '" & txtBoxNIN.Text & "', '" & txtBoxPosit.Text & "', '" & txtBoxSalary.Text & "','" & txtBoxHPWNum.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            ' เพิ่มพารามิเตอร์และกำหนดค่าให้กับพารามิเตอร์
            'sqlCmd.Parameters.AddWithValue("@staffid", staffid)
            'sqlCmd.Parameters.AddWithValue("@firstname", firstname)
            'sqlCmd.Parameters.AddWithValue("@lastname", lastname)
            'sqlCmd.Parameters.AddWithValue("@sex", sex)
            'sqlCmd.Parameters.AddWithValue("@nin", nin)
            'sqlCmd.Parameters.AddWithValue("@currentsalary", currentsalary)
            'sqlCmd.Parameters.AddWithValue("@address", address)
            'sqlCmd.Parameters.AddWithValue("@position", position)
            'sqlCmd.Parameters.AddWithValue("@telephonenumber", telephonenumber)
            'sqlCmd.Parameters.AddWithValue("@dateofbirth", dateofbirth)
            'sqlCmd.Parameters.AddWithValue("@WorkEID", WorkEID)
            'sqlCmd.Parameters.AddWithValue("@wards_wardid", wards_wardid)

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()


            MessageBox.Show("บันทึกข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message)

        End Try
        sqlConnection.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not a header cell and a row is selected
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell1Value As String = selectedRow.Cells(0).Value.ToString() ' Assuming column index 0
            Dim cell2Value As String = selectedRow.Cells(1).Value.ToString() ' Assuming column index 1
            Dim cell3Value As String = selectedRow.Cells(2).Value.ToString() ' Assuming column index 2

            ' Populate data into text boxes
            txtBoxFirstname.Text = cell2Value
            txtBoxLastname.Text = cell3Value
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            ' Check if any rows are selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("StaffID").Value.ToString()

                ' Create a SQL DELETE statement
                Dim deleteQuery As String = "DELETE FROM Staff WHERE StaffID = @PrimaryKey"

                ' Create a SqlConnection and SqlCommand
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(deleteQuery, connection)
                        ' Add a parameter for the primary key value
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)

                        ' Open the database connection
                        connection.Open()

                        ' Execute the DELETE query
                        command.ExecuteNonQuery()

                        ' Close the database connection
                        connection.Close()
                    End Using
                End Using

                ' Remove the selected row from the DataGridView
                DataGridView1.Rows.Remove(selectedRow)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            ' Check if a row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("StaffID").Value.ToString()

                ' Create a SQL UPDATE statement
                Dim updateQuery As String = "UPDATE Staff SET StaffID = @Column1, FirstName = @Column2, LastName = @Column3 WHERE StaffID = @PrimaryKey"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for the primary key and TextBox values
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                        command.Parameters.AddWithValue("@Column2", txtBoxFirstname.Text)
                        command.Parameters.AddWithValue("@Column3", txtBoxLastname.Text)
                        ' Add more parameters for other columns as needed

                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using

                ' Update the selected row in the DataGridView with edited data
                selectedRow.Cells("FirstName").Value = txtBoxFirstname.Text
                selectedRow.Cells("LastName").Value = txtBoxLastname.Text
                ' Update other columns as needed

                ' Inform the user that changes have been saved
                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Inform the user that no row is selected
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchText As String = txtboxsearch.Text.Trim()


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Staff"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Qualification() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New WorkExperience() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub
End Class