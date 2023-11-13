Imports System.Data.SqlClient
Imports Mysqlx
Imports System.Web.UI


Public Class Medication

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load()

        For i As Integer = 1 To 10
            updtxt.Items.Add(i.ToString())
        Next

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM NewMedicationView;" 'รอ View ใหม่

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

        txtIDEdit.ReadOnly = True
        PatientID.ReadOnly = True
        txt_PatienName.ReadOnly = True
        txtPatienLastname.ReadOnly = True
        Stafftxtboxmed.ReadOnly = True
        SearchStaffNamebox.ReadOnly = True
        txtStaffLastname.ReadOnly = True

    End Sub



    Private Sub btnsearchmedh_Click(sender As Object, e As EventArgs) Handles btnsearchmed.Click
        Try
            ' Retrieve the patient ID entered by the user
            Dim MedicationID As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(MedicationID) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM NewMedicationView"
            Else
                ' If a patient ID is entered, filter by that patient ID
                selectQuery = "SELECT * FROM NewMedicationView WHERE MedicationID = @MedicationID"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(selectQuery, connection)
                    If Not String.IsNullOrWhiteSpace(MedicationID) Then
                        ' Add a parameter for the patient ID
                        command.Parameters.AddWithValue("@MedicationID", MedicationID)
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
        Dim query As String = "SELECT MAX(MedicationID) FROM Medication"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "M001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "M" & nextID.ToString("D3")
                End If
            End Using
        End Using
    End Function
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        '    Dim StartDate As DateTime = Convert.ToDateTime(Pickdatestart.Text)
        '   Dim EndDates As DateTime = Convert.ToDateTime(EndDate.Text)

        Dim Req_pha_Quantity As Integer = Integer.Parse(updtxt.Text)

        Try
            ' Get the next available patient ID
            Dim nextID As String = GetNextID()

            ' Create a SQL INSERT statement with the formatted patient ID
            Dim sqlin As String = "INSERT INTO Medication (MedicationID, PatientID, DrugNumber, UnitsPerDay, StartDate, FinishDate, StaffID) " &
                                  "VALUES('" & nextID & "','" & PatientID.Text & "', '" & DrugNum.Text & "', '" & Req_pha_Quantity & "', '" & Pickdatestart.Value.ToString("yyyy-MM-dd") & "','" & EndDate.Value.ToString("yyyy-MM-dd") & "','" & Stafftxtboxmed.Text & "')"

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

        FormData_Load()

    End Sub

    ' old edit
    '    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
    '
    '        Dim StartDate As DateTime = Convert.ToDateTime(Pickdatestart.Text)
    '        Dim Ends As DateTime = Convert.ToDateTime(EndDate.Text)
    '
    '
    '        Try
    '            ' Create a SQL UPDATE statement with parameters
    '            Dim sqlupdate As String = "UPDATE Medication SET DrugNumber = @DrugNumber, " &
    '                              "UnitsPerDay = @UnitsPerDay, " &
    '                              "StartDate = @StartDate, " &
    '                              "FinishDate = @FinishDate, " &
    '                              "StaffID = @StaffID " &
    '                              "WHERE MedicationID = @MedicationID"

    '            Dim sqlCmd As New SqlCommand(sqlupdate, sqlConnection)
    '            sqlCmd.Parameters.AddWithValue("@DrugNumber", DrugNum.Text)
    '            sqlCmd.Parameters.AddWithValue("@UnitsPerDay", updtxt.SelectedItem.ToString())
    '            sqlCmd.Parameters.AddWithValue("@StartDate", StartDate)
    '            sqlCmd.Parameters.AddWithValue("@FinishDate", Ends)
    '            sqlCmd.Parameters.AddWithValue("@StaffID", Stafftxtboxmed.Text)
    '            sqlCmd.Parameters.AddWithValue("@MedicationID", txtIDEdit) ' Replace with the actual MedicationID

    '            sqlConnection.Open()
    '            sqlCmd.ExecuteNonQuery()

    '            MessageBox.Show("อัปเดตข้อมูลสำเร็จ")
    '        Catch ex As Exception
    '            MessageBox.Show("เกิดข้อผิดพลาดในการอัปเดตข้อมูล: " & ex.Message)
    '        Finally
    '            sqlConnection.Close()
    '        End Try

    '        FormData_Load()
    '   End Sub

    ' New Edit ทำรอ รอลบอันเก่า
    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            ' Check if only one row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("MedicationID").Value.ToString()

                ' Create a SQL UPDATE statement
                Dim updateQuery As String = "UPDATE Medication SET DrugNumber = @DrugNumber,
                                                  UnitsPerDay = @UnitsPerDay,
                                                  StartDate = @StartDate,
                                                  FinishDate = @FinishDate,
                                                  StaffID = @StaffID
                                                  WHERE MedicationID = @PrimaryKey"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for the primary key and TextBox values
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                        command.Parameters.AddWithValue("@DrugNumber", DrugNum.Text)
                        command.Parameters.AddWithValue("@UnitsPerDay", updtxt.Text)
                        command.Parameters.AddWithValue("@StartDate", Pickdatestart.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@FinishDate", EndDate.Value.ToString("yyyy-MM-dd"))
                        ' Convert and format DateTimeB.Value to match SQL Server's expected format
                        command.Parameters.AddWithValue("@StaffID", Stafftxtboxmed.Text)
                        ' Add more parameters for other columns as needed

                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using
                ' Update other columns as needed

                ' Inform the user that changes have been saved
                MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormData_Load()
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

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
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
                        Dim primaryKeyValue As String = selectedRow.Cells("MedicationID").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM Medication WHERE MedicationID = @PrimaryKey"

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
                                Dim selectedRow As DataGridViewRow = DataGridView1.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("MedicationID").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridView1.Rows.Remove(selectedRow)
                                End If
                            Next

                            connection.Close()
                        End Using
                    End Using

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormData_Load()
                End If
            Else
                MessageBox.Show("Please select rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChoosPatien ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChoosPatien()
        newFormSChoPatien.ShowDialog()
        PatientID.Text = newFormSChoPatien.PatienID
        txt_PatienName.Text = newFormSChoPatien.PatienName
        txtPatienLastname.Text = newFormSChoPatien.PatienLastname

        PatientID.ReadOnly = True
        txt_PatienName.ReadOnly = True
        txtPatienLastname.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not a header cell and a row is selected
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell0Value As String = selectedRow.Cells(0).Value.ToString() 'MedicationID 0
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString() 'PatientID 1
            Dim cell2Value As String = selectedRow.Cells(2).Value.ToString() 'FisrtName 2
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() 'LastName 3
            Dim cell4Value As String = selectedRow.Cells(4).Value.ToString() 'DrugNumber 4
            Dim cell5Value As String = selectedRow.Cells(5).Value.ToString() 'DrugName 5
            Dim cell6Value As String = selectedRow.Cells(6).Value.ToString() 'UnitPerDay 6
            Dim cell7Value As String = selectedRow.Cells(7).Value.ToString() 'MethodOfAdmin 7
            Dim cell8Value As String = selectedRow.Cells(8).Value.ToString() 'StadDate 8
            Dim cell9Value As String = selectedRow.Cells(9).Value.ToString() 'FinishDate 9
            Dim cell10Value As String = selectedRow.Cells(10).Value.ToString() 'StaffID 10
            Dim cell11Value As String = selectedRow.Cells(11).Value.ToString() 'StaffFirstName 11
            Dim cell12Value As String = selectedRow.Cells(12).Value.ToString() 'StaffLastName 12

            ' สร้าง View ใหม่เรียงตามนี้ MedicationID, PatientID, FisrtName, LastName, DrugNumber, DrugName, UnitPerDay, MethodOfAdmin, StadDate, FinishDate, StaffID, StaffFirstName, StaffLastName
            ' เชื่อมตารางเองนะจ๊ะ

            ' Populate data into text boxes
            PatientID.Text = cell1Value
            txt_PatienName.Text = cell2Value
            txtPatienLastname.Text = cell3Value
            DrugNum.Text = cell4Value
            DrugName.Text = cell5Value
            updtxt.Text = cell6Value
            Methee.Text = cell7Value
            Pickdatestart.Text = cell8Value
            EndDate.Text = cell9Value
            Stafftxtboxmed.Text = cell10Value
            SearchStaffNamebox.Text = cell11Value
            txtStaffLastname.Text = cell12Value

            PatientID.ReadOnly = True
            txtPatienLastname.ReadOnly = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim newForm As ChooseDrung ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm = New ChooseDrung()
        newForm.ShowDialog()
        DrugNum.Text = newForm.txtDrungNum
        Methee.Text = newForm.txtMethodUse
        DrugName.Text = newForm.txtName

        DrugNum.ReadOnly = True
        Methee.ReadOnly = True
        DrugName.ReadOnly = True

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim newFormSChoStaff As ChooseStaffName ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoStaff = New ChooseStaffName()
        newFormSChoStaff.ShowDialog()
        Stafftxtboxmed.Text = newFormSChoStaff.txtStaffID
        SearchStaffNamebox.Text = newFormSChoStaff.txtStaffName
        txtStaffLastname.Text = newFormSChoStaff.txtLastName

        Stafftxtboxmed.ReadOnly = True
        SearchStaffNamebox.ReadOnly = True
        txtStaffLastname.ReadOnly = True
    End Sub

    Private Sub Medication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormData_Load()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        txtIDEdit.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

    End Sub

End Class