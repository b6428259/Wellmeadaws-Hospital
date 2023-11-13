Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Appointments

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load()

    End Sub

    Protected Sub Load()
        ' สร้าง query
        Dim query1 As String = "SELECT * FROM AppointmentView" 'รอพี๋โยสร้างViewใหม่

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
        WardIDtxt.ReadOnly = True

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient informationr
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM AppointmentView" 'AppointmentView
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM AppointmentView WHERE AppointmentID LIKE @SearchText OR PatientID LIKE @SearchText OR FirstName LIKE @SearchText OR LastName LIKE @SearchText OR AppointmentDate LIKE @SearchText OR WardID LIKE @SearchText OR WardName LIKE @SearchText OR Diagnosis LIKE @SearchText OR TreatmentPlan LIKE @SearchText"
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
        Dim query As String = "SELECT MAX(AppointmentID) FROM Appointments"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "A001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "A" & nextID.ToString("D3")
                End If
            End Using
        End Using
    End Function

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click

        Dim waitingDateString As String = appointmentdate.Value
        Dim dateFormat As String = "dd/MM/yyyy"
        Dim waitingDate As DateTime

        Try
            ' Get the next available patient ID
            Dim nextID As String = GetNextID()

            ' Create a SQL INSERT statement with the formatted patient Diagnosis
            Dim sqlin As String = "INSERT INTO Appointments (AppointmentID, PatientID, AppointmentDate, WardID, Diagnosis, TreatmentPlan) " &
                                  "VALUES('" & nextID & "','" & PatientIDtxt.Text & "', '" & waitingDate & "', '" & WardIDtxt.Text & "', '" & Diagnosistxt.Text & "', '" & TreatmentPlantxt.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConnection.Close()
        End Try

        Load()

    End Sub

    Private Sub butEdit_Click(sender As Object, e As EventArgs) Handles butEdit.Click
        Try
            ' Check if only one row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("AppointmentID").Value.ToString()

                ' Create a SQL UPDATE statement
                Dim updateQuery As String = "UPDATE Appointments SET PatientID = @PatientID,
                                                  AppointmentDate = @AppointmentDate,
                                                  WardID = @WardID,
                                                  Diagnosis = @Diagnosis,
                                                  TreatmentPlan = @TreatmentPlan
                                                  WHERE AppointmentID = @PrimaryKey"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for the primary key and TextBox values
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                        command.Parameters.AddWithValue("@PatientID", PatientIDtxt.Text)
                        command.Parameters.AddWithValue("@AppointmentDate", appointmentdate.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@WardID", WardIDtxt.Text)
                        command.Parameters.AddWithValue("@Diagnosis", Diagnosistxt.Text)
                        command.Parameters.AddWithValue("@TreatmentPlan", TreatmentPlantxt.Text)

                        ' Add more parameters for other columns as needed

                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using

                ' Inform the user that changes have been saved
                MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Load()
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
                        Dim primaryKeyValue As String = selectedRow.Cells("AppointmentID").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM Appointments WHERE AppointmentID = @PrimaryKey"

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
                                Dim selectedRow As DataGridViewRow = DataGridView1.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("AppointmentID").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridView1.Rows.Remove(selectedRow)
                                End If
                            Next

                            connection.Close()
                        End Using
                    End Using

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load()
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
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then

            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell0Value As String = selectedRow.Cells(0).Value.ToString() ' AppointmentID
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString() ' PatientID
            Dim cell2Value As String = selectedRow.Cells(2).Value.ToString() ' FirstName
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() ' LastName
            Dim cell4Value As String = selectedRow.Cells(4).Value.ToString() ' AppointmentDate
            Dim cell5Value As String = selectedRow.Cells(5).Value.ToString() ' WardID
            Dim cell6Value As String = selectedRow.Cells(6).Value.ToString() ' WardName
            Dim cell7Value As String = selectedRow.Cells(7).Value.ToString() ' Diagnosis
            Dim cell8Value As String = selectedRow.Cells(8).Value.ToString() ' TreatmentPlan

            'ให้สร้างพี่โย View ที่แสดงข้อมูลเรียงตามนี้ AppointmentID, PatientID, FirstName, LastName, WardID, WardName, AppointmentDate, Diagnosis, TreatmentPlan
            'เสร็จแล้วมาลบที่เป็นคอมเมนให้ใช้งานได้

            PatientIDtxt.Text = cell1Value
            TextBox1.Text = cell2Value
            TextBox2.Text = cell3Value
            WardIDtxt.Text = cell5Value
            TextBox3.Text = cell6Value
            appointmentdate.Text = cell4Value
            Diagnosistxt.Text = cell7Value
            TreatmentPlantxt.Text = cell8Value
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