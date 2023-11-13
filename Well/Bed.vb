Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Bed

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub Bed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' สร้าง query
        Dim query1 As String = "SELECT * FROM BedNWardName"

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

        TextBox1.ReadOnly = True

    End Sub

    Private Sub btnsearchbed_Click(sender As Object, e As EventArgs) Handles btnsearchbed.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtboxsearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient informationr
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM BedNWardName"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM BedNWardName WHERE BedID LIKE @SearchText OR WardID LIKE @SearchText OR WardName LIKE @SearchText OR BedNumber LIKE @SearchText OR BedStatus LIKE @SearchText"
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
        Dim query As String = "SELECT MAX(BedID) FROM Beds"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxID As Object = command.ExecuteScalar()

                If maxID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "B001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "B" & nextID.ToString("D3")
                End If
            End Using
        End Using
    End Function

    Private Function nextnum01() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(BedNumber) FROM Beds"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxNum As Object = command.ExecuteScalar()

                If maxNum Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "1"
                Else
                    Dim currentID As Integer = Integer.Parse(maxNum.ToString().Substring(1))
                    Dim nextnumb As Integer = currentID + 1
                    Return "" & nextnumb.ToString("D3")
                End If
            End Using
        End Using
    End Function

    Private Function nextnum(wardID As String) As String
        ' สร้างคำสั่ง SQL เพื่อตรวจสอบค่าสูงสุดของ BedNumber ใน WardID ที่ระบุ
        Dim query As String = "SELECT MAX(BedNumber) FROM Beds WHERE WardID = @WardID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@WardID", wardID)
                connection.Open()
                Dim maxNum As Object = command.ExecuteScalar()

                If maxNum Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลใน Ward ที่ระบุ ให้เริ่มที่ "xxx01" (xxx คือหมายเลข Ward จาก WardID)
                    Dim wardNumber As String = wardID.Substring(1)
                    Return wardNumber & "01"
                Else
                    ' หาเลขที่สูงสุดของ Ward ที่ระบุ
                    Dim currentID As Integer = Integer.Parse(maxNum.ToString()) + 1
                    Return currentID.ToString()
                End If
            End Using
        End Using
    End Function


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not a header cell and a row is selected
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell0Value As String = selectedRow.Cells(0).Value.ToString()
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString()
            Dim cell2Value As String = selectedRow.Cells(4).Value.ToString()

            ' Populate data into text boxes
            wardtxt.Text = cell1Value
            bedstatus.Text = cell2Value
            TextBox1.Text = cell0Value
        End If
    End Sub

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click
        Try
            ' Get the next available bed ID
            Dim nextID As String = GetNextID()

            ' ใช้ฟังก์ชัน nextnum เพื่อหาเลขใหม่ของเตียง
            Dim nextNumber As String = nextnum(wardtxt.Text)

            ' Create a SQL INSERT statement with the formatted bed ID
            Dim sqlin As String = "INSERT INTO Beds (BedID, WardID, BedNumber, BedStatus) " &
                              "VALUES('" & nextID & "','" & wardtxt.Text & "', '" & nextNumber & "', '" & bedstatus.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()
            sqlConnection.Close()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Bed_Load(Nothing, Nothing)
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
                    Dim primaryKeyValue As String = selectedRow.Cells("BedID").Value.ToString()

                    ' Create a SQL UPDATE statement
                    Dim updateQuery As String = "UPDATE Beds SET WardID = @WardID, BedStatus = @BedStatus WHERE BedID = @PrimaryKey"

                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(updateQuery, connection)
                            ' Add parameters for the primary key and TextBox values
                            command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                            command.Parameters.AddWithValue("@WardID", wardtxt.Text)
                            command.Parameters.AddWithValue("@BedStatus", bedstatus.Text)

                            ' Open the database connection
                            connection.Open()

                            ' Execute the UPDATE query
                            command.ExecuteNonQuery()

                            ' Close the database connection
                            connection.Close()
                        End Using
                    End Using

                    ' Inform the user that changes have been saved
                    MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the data to reflect the changes
                    Bed_Load(Nothing, Nothing)
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
                    ' Iterate through all selected rows and delete them
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                        Dim primaryKeyValue As String = selectedRow.Cells("BedID").Value.ToString()

                        ' Create a SQL DELETE statement
                        Dim deleteQuery As String = "DELETE FROM Beds WHERE BedID = @PrimaryKey"

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
                    Next

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Bed_Load(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Please select one or more rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        wardtxt.Text = newFormSChoPatien.PatientId
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        bedstatus.Text = newFormSChoPatien.PatientId
    End Sub

End Class