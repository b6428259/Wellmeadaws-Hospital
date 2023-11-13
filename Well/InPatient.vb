Imports System.Data.SqlClient
Imports System.Globalization

Public Class InPatient
    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub InPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM ViewInPatients"

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
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        PatientIDtxt.ReadOnly = True
        WardIDtxt.ReadOnly = True

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM ViewInPatients"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM ViewInPatients WHERE AdmitID LIKE @SearchText OR PatientID LIKE @SearchText OR FirstName LIKE @SearchText OR LastName LIKE @SearchText OR WardID LIKE @SearchText OR WardName LIKE @SearchText OR DatePlacedOnWaitingList LIKE @SearchText OR DatePlacedInWard LIKE @SearchText OR DateExpectedToLeaveWard LIKE @SearchText OR ActualDatePatientLeftWard LIKE @SearchText"
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
        Dim query As String = "SELECT MAX(AdmitID) FROM InPatients"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ A0001
                    Return "A0001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "A" & nextID.ToString("D4")
                End If
            End Using
        End Using
    End Function

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click
        ' Assuming the date format is "dd/MM/yyyy"
        Dim waitingDateString As String = lblWaitingDate.Value
        Dim datePlacedString As String = lblDatePlaced.Value
        Dim expectedLeaveString As String = lblExpectedLeave.Value
        Dim actualLeftString As String = lblActualLeft.Value

        Dim dateFormat As String = "dd/MM/yyyy"
        Dim waitingDate As DateTime
        Dim datePlaced As DateTime
        Dim expectedLeave As DateTime
        Dim actualLeft As DateTime

        If DateTime.TryParseExact(waitingDateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, waitingDate) AndAlso
           DateTime.TryParseExact(datePlacedString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, datePlaced) AndAlso
           DateTime.TryParseExact(expectedLeaveString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, expectedLeave) AndAlso
           DateTime.TryParseExact(actualLeftString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, actualLeft) Then

            Try
                ' Get the next available patient ID
                Dim nextID As String = GetNextID()

                ' Create a SQL INSERT statement with the formatted patient ID
                Dim sqlin As String = "INSERT INTO InPatients (AdmitID, PatientID, WardID, DatePlacedOnWaitingList, ExpectedDurationOfStay, DatePlacedInWard, DateExpectedToLeaveWard, ActualDatePatientLeftWard) " &
                                      "VALUES('" & nextID & "','" & PatientIDtxt.Text & "', '" & WardIDtxt.Text & "', '" & waitingDate.ToString("MM/dd/yyyy") & "', '" & lblDurationOfStay.Value & "', '" & datePlaced.ToString("MM/dd/yyyy") & "','" & expectedLeave.ToString("MM/dd/yyyy") & "','" & actualLeft.ToString("MM/dd/yyyy") & "')"

                Dim sqlCmd = sqlConnection.CreateCommand()
                sqlCmd.CommandText = sqlin

                sqlConnection.Open()
                sqlCmd.ExecuteNonQuery()

                MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                InPatient_Load(Nothing, Nothing)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                sqlConnection.Close()
            End Try
        Else
            MessageBox.Show("Invalid date format.")
        End If
    End Sub

    Private Sub butEdit_Click(sender As Object, e As EventArgs) Handles butEdit.Click
        Try
            ' Check if only one row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("AdmitID").Value.ToString()

                ' Create a SQL UPDATE statement
                Dim updateQuery As String = "UPDATE InPatients SET PatientID = @PatientID,
                                                  WardID = @WardID,
                                                  DatePlacedOnWaitingList = @DatePlacedOnWaitingList,
                                                  ExpectedDurationOfStay = @ExpectedDurationOfStay,
                                                  DatePlacedInWard = @DatePlacedInWard,
                                                  DateExpectedToLeaveWard = @DateExpectedToLeaveWard,
                                                  ActualDatePatientLeftWard = @ActualDatePatientLeftWard
                                                  WHERE AdmitID = @PrimaryKey"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for the primary key and TextBox values
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                        command.Parameters.AddWithValue("@PatientID", PatientIDtxt.Text)
                        command.Parameters.AddWithValue("@WardID", WardIDtxt.Text)
                        command.Parameters.AddWithValue("@DatePlacedOnWaitingList", lblWaitingDate.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@ExpectedDurationOfStay", lblDurationOfStay.Text)
                        ' Convert and format DateTimeB.Value to match SQL Server's expected format
                        command.Parameters.AddWithValue("@DatePlacedInWard", lblDatePlaced.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@DateExpectedToLeaveWard", lblExpectedLeave.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@ActualDatePatientLeftWard", lblActualLeft.Value.ToString("yyyy-MM-dd"))

                        ' Add more parameters for other columns as needed

                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using

                ' Inform the user that changes have been saved
                MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                InPatient_Load(Nothing, Nothing)
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
                    ' Create a list to store the selected primary key values
                    Dim selectedKeys As New List(Of String)

                    ' Collect the selected primary key values
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim primaryKeyValue As String = selectedRow.Cells("AdmitID").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM InPatients WHERE AdmitID = @PrimaryKey"

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
                                Dim selectedRow As DataGridViewRow = DataGridView1.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("AdmitID").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridView1.Rows.Remove(selectedRow)
                                End If
                            Next

                            connection.Close()
                        End Using
                    End Using

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    InPatient_Load(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Please select rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim cell1Value As String = selectedRow.Cells(0).Value.ToString() ' AdmitID
            Dim cell2Value As String = selectedRow.Cells(1).Value.ToString() ' PatientID
            Dim cell3Value As String = selectedRow.Cells(2).Value.ToString() ' FirstName
            Dim cell4Value As String = selectedRow.Cells(3).Value.ToString() ' LastName
            Dim cell5Value As String = selectedRow.Cells(4).Value.ToString() ' WardID
            Dim cell6Value As String = selectedRow.Cells(5).Value.ToString() ' WardName
            Dim cell7Value As String = selectedRow.Cells(6).Value.ToString() ' DatePlacedOnWaitting
            Dim cell8Value As String = selectedRow.Cells(7).Value.ToString() ' ExpectedDurationOfStay
            Dim cell9Value As String = selectedRow.Cells(8).Value.ToString() ' DatePlacedInWard
            Dim cell10Value As String = selectedRow.Cells(9).Value.ToString() ' DateExpectedToLeave
            Dim cell11Value As String = selectedRow.Cells(10).Value.ToString() ' ActualDatePetientLeft

            ' Populate data into text boxes
            PatientIDtxt.Text = cell2Value
            TextBox1.Text = cell3Value
            TextBox2.Text = cell4Value
            WardIDtxt.Text = cell5Value
            TextBox3.Text = cell6Value
            lblWaitingDate.Text = cell7Value
            lblDurationOfStay.Text = cell8Value
            lblDatePlaced.Text = cell9Value
            lblExpectedLeave.Text = cell10Value
            lblActualLeft.Text = cell11Value

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChoosPatien ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChoosPatien()
        newFormSChoPatien.ShowDialog()
        PatientIDtxt.Text = newFormSChoPatien.PatienID
        TextBox1.Text = newFormSChoPatien.PatienName
        TextBox2.Text = newFormSChoPatien.PatienLastname

        PatientIDtxt.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        WardIDtxt.Text = newFormSChoPatien.PatientId
        TextBox3.Text = newFormSChoPatien.PatientName

        WardIDtxt.ReadOnly = True
        TextBox3.ReadOnly = True

    End Sub
End Class