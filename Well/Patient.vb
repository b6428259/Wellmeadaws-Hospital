Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Patient

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Patients"

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString() ' Assuming column index 0
            Dim cell2Value As String = selectedRow.Cells(2).Value.ToString() ' Assuming column index 1
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() ' Assuming column index 2
            Dim cell4Value As String = selectedRow.Cells(4).Value.ToString()
            Dim cell5Value As String = selectedRow.Cells(5).Value.ToString()
            Dim cell6Value As String = selectedRow.Cells(6).Value.ToString()
            Dim cell7Value As String = selectedRow.Cells(7).Value.ToString()
            Dim cell8Value As String = selectedRow.Cells(8).Value.ToString()

            ' Populate data into text boxes
            txtboxName.Text = cell1Value
            txtboxLastname.Text = cell2Value
            txtboxAddress.Text = cell3Value
            TxtBoxTel.Text = cell4Value
            DateTimePickerDob.Text = cell5Value
            TxtBoxSex.Text = cell6Value
            TextBoxMarittal.Text = cell7Value
            TxtBoxRegisDate.Text = cell8Value

        End If
    End Sub

    Private Sub txtBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSearch.TextChanged
        ' Call the btnsearchpatient_Click method to refresh the DataGridView
        btnsearchpatient_Click(sender, e)
    End Sub

    Private Sub btnsearchpatient_Click(sender As Object, e As EventArgs) Handles btnsearchpatient.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient informationr
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM Patients"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM Patients WHERE FirstName LIKE @SearchText OR LastName LIKE @SearchText OR Tel LIKE @SearchText"
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
        Dim query As String = "SELECT MAX(PatientID) FROM Patients"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "P0001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "P" & nextID.ToString("D4")
                End If
            End Using
        End Using
    End Function

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click
        'Dim oDate As DateTime = Convert.ToDateTime(TxtBoxRegisDate.Text)
        Try
            ' Get the next available patient ID
            Dim nextID As String = GetNextID()

            ' Create a SQL INSERT statement with the formatted patient ID
            Dim sqlin As String = "INSERT INTO Patients (PatientID, FirstName, LastName, Address, Tel, DateOfBirth, Sex, MaritalStatus, DateRegistered) " &
                                  "VALUES('" & nextID & "','" & txtboxName.Text & "', '" & txtboxLastname.Text & "', '" & txtboxAddress.Text & "', '" & TxtBoxTel.Text & "', '" & DateTimePickerDob.Value.ToString("yyyy-MM-dd HH:mm:ss") & "','" & TxtBoxSex.Text & "','" & TextBoxMarittal.Text & "','" & TxtBoxRegisDate.Value.ToString("yyyy-MM-dd HH:mm:ss") & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormData_Load(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub butEdit_Click(sender As Object, e As EventArgs) Handles butEdit.Click
        Try
            ' Check if a row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Check if only one row is selected
                If DataGridView1.SelectedRows.Count = 1 Then
                    ' Get the selected row
                    Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                    ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                    Dim primaryKeyValue As String = selectedRow.Cells("PatientID").Value.ToString()

                    ' Create a SQL UPDATE statement
                    Dim updateQuery As String = "UPDATE Patients SET FirstName = @FirstName,
                                              LastName = @LastName,
                                              Address = @Address,
                                              Tel = @Tel,
                                              DateOfBirth = @DateOfBirth,
                                              Sex = @Sex,
                                              MaritalStatus = @MaritalStatus,
                                              DateRegistered = @DateRegistered
                                              WHERE PatientID = @PrimaryKey"

                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(updateQuery, connection)
                            ' Add parameters for the primary key and TextBox values
                            command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                            command.Parameters.AddWithValue("@FirstName", txtboxName.Text)
                            command.Parameters.AddWithValue("@LastName", txtboxLastname.Text)
                            command.Parameters.AddWithValue("@Address", txtboxAddress.Text)
                            command.Parameters.AddWithValue("@Tel", TxtBoxTel.Text)
                            command.Parameters.AddWithValue("@DateOfBirth", DateTimePickerDob.Value.ToString("yyyy-MM-dd"))
                            command.Parameters.AddWithValue("@Sex", TxtBoxSex.Text)
                            command.Parameters.AddWithValue("@MaritalStatus", TextBoxMarittal.Text)
                            command.Parameters.AddWithValue("@DateRegistered", TxtBoxRegisDate.Value.ToString("yyyy-MM-dd"))

                            ' Add more parameters for other columns as needed

                            connection.Open()
                            command.ExecuteNonQuery()
                            connection.Close()
                        End Using
                    End Using

                    ' Inform the user that changes have been saved
                    MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the data to reflect the changes
                    FormData_Load(Nothing, Nothing)
                Else
                    ' Inform the user to select only one row for editing
                    MessageBox.Show("Please select only one row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ' Inform the user that no row is selected
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Try
            ' Check if any rows are selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Ask the user to confirm the deletion
                Dim result As DialogResult = MessageBox.Show("Do you want to delete the selected row(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Create a list to store the selected primary key values
                    Dim selectedKeys As New List(Of String)

                    ' Collect the selected primary key values
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim primaryKeyValue As String = selectedRow.Cells("PatientID").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM Patients WHERE PatientID = @PrimaryKey"

                    ' Create a SqlConnection and SqlCommand
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(deleteQuery, connection)
                            ' Add a parameter for the primary key value
                            command.Parameters.Add("@PrimaryKey", SqlDbType.VarChar)

                            connection.Open()

                            ' Iterate through the list of selected primary keys and delete rows
                            For Each key As String In selectedKeys
                                command.Parameters("@PrimaryKey").Value = key
                                command.ExecuteNonQuery()

                                ' Remove the selected row from the DataGridView
                                Dim selectedRow As DataGridViewRow = DataGridView1.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("PatientID").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridView1.Rows.Remove(selectedRow)
                                End If
                            Next

                            connection.Close()
                        End Using
                    End Using
                End If
                MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormData_Load(Nothing, Nothing)
            Else
                MessageBox.Show("Please select rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New OutPatientsList() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New PatientsInWards() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub

End Class