Imports System.Data.SqlClient

Public Class PatientAllocation
    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Pallow"

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

        txtAllocationID.ReadOnly = True
        txtBoxPatient.ReadOnly = True
        txtBoxWard.ReadOnly = True

    End Sub

    Private Function GetNextID() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(AllocationID) FROM PatientAllocation"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "PA001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(2))
                    Dim nextID As Integer = currentID + 1
                    Return "PA" & nextID.ToString("D3")
                End If
            End Using
        End Using
    End Function

    Private Sub btnsearchpatientallo_Click(sender As Object, e As EventArgs) Handles btnsearchpatientallo.Click

        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtboxsearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM Pallow"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM Pallow WHERE AllocationID LIKE @SearchText OR PatientID LIKE @SearchText OR Pname LIKE @SearchText OR WardID LIKE @SearchText OR WardName LIKE @SearchText OR AllocationDate LIKE @SearchText OR DischargeDate LIKE @SearchText"
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

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click

        Dim nextID As String = GetNextID()

        Try

            Dim sqlin As String = "INSERT INTO PatientAllocation (AllocationID ,PatientID, WardID, AllocationDate, DischargeDate) VALUES('" & nextID & "','" & txtBoxPatient.Text & "', '" & txtBoxWard.Text & "', '" & DateTimeAllocate.Value.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & DateTimeDis.Value.ToString("yyyy-MM-dd HH:mm:ss") & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()


            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormData_Load(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        sqlConnection.Close()
    End Sub

    Private Sub butEdit_Click(sender As Object, e As EventArgs) Handles butEdit.Click
        Try
            ' Check if only one row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("AllocationID").Value.ToString()

                ' Create a SQL UPDATE statement
                Dim updateQuery As String = "UPDATE PatientAllocation SET PatientID = @PatientID,
                                                  WardID = @WardID,
                                                  AllocationDate = @AllocationDate,
                                                  DischargeDate = @DischargeDate
                                                  WHERE AllocationID = @PrimaryKey"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for the primary key and TextBox values
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                        command.Parameters.AddWithValue("@PatientID", txtBoxPatient.Text)
                        command.Parameters.AddWithValue("@WardID", txtBoxWard.Text)
                        command.Parameters.AddWithValue("@AllocationDate", DateTimeAllocate.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@DischargeDate", DateTimeDis.Value.ToString("yyyy-MM-dd"))
                        ' Add more parameters for other columns as needed
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using

                ' Inform the user that changes have been saved
                MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormData_Load(Nothing, Nothing)
            ElseIf DataGridView1.SelectedRows.Count > 1 Then
                MessageBox.Show("Please select only one row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
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
                    ' Create a list to store the selected AllocationIDs
                    Dim selectedAllocationIDs As New List(Of String)

                    ' Loop through the selected rows and collect the AllocationIDs
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim allocationID As String = selectedRow.Cells("AllocationID").Value.ToString()
                        selectedAllocationIDs.Add(allocationID)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM PatientAllocation WHERE AllocationID = @PrimaryKey"

                    ' Create a SqlConnection and SqlCommand
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        For Each allocationID As String In selectedAllocationIDs
                            Using command As New SqlCommand(deleteQuery, connection)
                                ' Add a parameter for the primary key value
                                command.Parameters.AddWithValue("@PrimaryKey", allocationID)

                                ' Execute the DELETE query
                                command.ExecuteNonQuery()
                            End Using
                        Next

                        ' Close the database connection
                        connection.Close()
                    End Using

                    ' Remove the selected rows from the DataGridView
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        DataGridView1.Rows.Remove(selectedRow)
                    Next

                    ' Inform the user that rows have been deleted
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormData_Load(Nothing, Nothing)
                End If
            Else
                ' Inform the user that no row is selected
                MessageBox.Show("Please select one or more rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not a header cell and a row is selected
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell1Value As String = selectedRow.Cells(0).Value.ToString() ' Assuming column index 0
            Dim cell2Value As String = selectedRow.Cells(1).Value.ToString() ' Assuming column index 1
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() ' Assuming column index 2
            Dim cell4Value As String = selectedRow.Cells(5).Value.ToString() ' Assuming column index 3
            Dim cell5Value As String = selectedRow.Cells(6).Value.ToString() ' Assuming column index 4
            ' Populate data into text boxes
            txtAllocationID.Text = cell1Value
            txtBoxPatient.Text = cell2Value
            txtBoxWard.Text = cell3Value
            DateTimeAllocate.Text = cell4Value
            DateTimeDis.Text = cell5Value
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChoosPatien ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChoosPatien()
        newFormSChoPatien.ShowDialog()
        txtBoxPatient.Text = newFormSChoPatien.PatienID
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        txtBoxWard.Text = newFormSChoPatien.PatientId
    End Sub
End Class