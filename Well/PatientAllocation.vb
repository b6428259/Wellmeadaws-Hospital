Imports System.Data.SqlClient

Public Class PatientAllocation
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM PatientAllocation"

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

    Private Sub btnsearchpatientallo_Click(sender As Object, e As EventArgs) Handles btnsearchpatientallo.Click

        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtboxsearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM PatientAllocation"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM PatientAllocation WHERE AllocationID LIKE @SearchText OR PatientID LIKE @SearchText OR WardID LIKE @SearchText OR AllocationDate LIKE @SearchText OR DischargeDate LIKE @SearchText"
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
        Try

            Dim sqlin As String = "INSERT INTO PatientAllocation (AllocationID ,PatientID, WardID, AllocationDate, DischargeDate) VALUES('" & txtAllocationID.Text & "','" & txtBoxPatient.Text & "', '" & txtBoxWard.Text & "', '" & txtBoxAllocateDate.Text & "', '" & txtBoxDischarge.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()


            MessageBox.Show("บันทึกข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message)

        End Try
        sqlConnection.Close()
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Try
            ' Check if any rows are selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("AllocationID").Value.ToString()

                ' Create a SQL DELETE statement
                Dim deleteQuery As String = "DELETE FROM PatientAllocation WHERE AllocationID = @PrimaryKey"

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
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not a header cell and a row is selected
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell1Value As String = selectedRow.Cells(0).Value.ToString() ' Assuming column index 0
            Dim cell2Value As String = selectedRow.Cells(1).Value.ToString() ' Assuming column index 1
            Dim cell3Value As String = selectedRow.Cells(2).Value.ToString() ' Assuming column index 2
            Dim cell4Value As String = selectedRow.Cells(3).Value.ToString() ' Assuming column index 3
            Dim cell5Value As String = selectedRow.Cells(4).Value.ToString() ' Assuming column index 4
            ' Populate data into text boxes
            txtAllocationID.Text = cell1Value
            txtBoxPatient.Text = cell2Value
            txtBoxWard.Text = cell3Value
            txtBoxAllocateDate.Text = cell4Value
            txtBoxDischarge.Text = cell5Value
        End If
    End Sub
End Class