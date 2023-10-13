Imports System.Data.SqlClient
Imports Mysqlx
Imports System.Web.UI


Public Class Medication

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormData_Load()

        For i As Integer = 1 To 10
            updtxt.Items.Add(i.ToString())
        Next

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM MedicationView;"

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



    Private Sub btnsearchmedh_Click(sender As Object, e As EventArgs) Handles btnsearchmed.Click
        Try
            ' Retrieve the patient ID entered by the user
            Dim MedicationID As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(MedicationID) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM Medication"
            Else
                ' If a patient ID is entered, filter by that patient ID
                selectQuery = "SELECT * FROM Medication WHERE MedicationID = @MedicationID"
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
        Dim StartDate As DateTime = Convert.ToDateTime(Pickdatestart.Text)
        Dim EndDates As DateTime = Convert.ToDateTime(EndDate.Text)

        Dim Req_pha_Quantity As Integer = Integer.Parse(updtxt.Text)

        Try
            ' Get the next available patient ID
            Dim nextID As String = GetNextID()

            ' Create a SQL INSERT statement with the formatted patient ID
            Dim sqlin As String = "INSERT INTO Medication (MedicationID, PatientID, DrugNumber, UnitsPerDay, StartDate, FinishDate, StaffID) " &
                                  "VALUES('" & nextID & "','" & PatientID.Text & "', '" & DrugNum.Text & "', '" & Req_pha_Quantity & "', '" & Pickdatestart.Text & "','" & EndDate.Text & "','" & Stafftxtboxmed.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("บันทึกข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try

        FormData_Load()

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

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    ' Check if the clicked cell is not a header cell and a row is selected
    '    If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
    '        ' Get data from the selected row
    '        Dim selectedRow = DataGridView1.SelectedRows(0)
    '        Dim cell1Value As String = selectedRow.Cells(0).Value.ToString() ' Assuming column index 0
    '        Dim cell2Value As String = selectedRow.Cells(1).Value.ToString() ' Assuming column index 1
    '        Dim cell3Value As String = selectedRow.Cells(2).Value.ToString() ' Assuming column index 2

    '        ' Populate data into text boxes
    '        PatientID.Text = cell1Value
    '        txt_PatienName.Text = cell2Value
    '        txtPatienLastname.Text = cell3Value

    '        PatientID.ReadOnly = True
    '        txtPatienLastname.ReadOnly = True
    '    End If
    'End Sub

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

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        Dim StartDate As DateTime = Convert.ToDateTime(Pickdatestart.Text)
        Dim Ends As DateTime = Convert.ToDateTime(EndDate.Text)


        Try
            ' Create a SQL UPDATE statement with parameters
            Dim sqlupdate As String = "UPDATE Medication SET DrugNumber = @DrugNumber, " &
                              "UnitsPerDay = @UnitsPerDay, " &
                              "StartDate = @StartDate, " &
                              "FinishDate = @FinishDate, " &
                              "StaffID = @StaffID " &
                              "WHERE MedicationID = @MedicationID"

            Dim sqlCmd As New SqlCommand(sqlupdate, sqlConnection)
            sqlCmd.Parameters.AddWithValue("@DrugNumber", DrugNum.Text)
            sqlCmd.Parameters.AddWithValue("@UnitsPerDay", updtxt.SelectedItem.ToString())
            sqlCmd.Parameters.AddWithValue("@StartDate", StartDate)
            sqlCmd.Parameters.AddWithValue("@FinishDate", Ends)
            sqlCmd.Parameters.AddWithValue("@StaffID", Stafftxtboxmed.Text)
            sqlCmd.Parameters.AddWithValue("@MedicationID", txtIDEdit) ' Replace with the actual MedicationID

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("อัปเดตข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการอัปเดตข้อมูล: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try

        FormData_Load()
    End Sub

    Private Sub Medication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormData_Load()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        txtIDEdit.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Dashboard() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub
End Class