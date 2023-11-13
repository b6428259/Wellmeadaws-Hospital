Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class StaffAllocation

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub btnsearchstaffallo_Click(sender As Object, e As EventArgs) Handles btnsearchstaffallo.Click
        'Dim query As String = "SELECT W.WardID, W.WardName, SA.StaffID, CONCAT(S.FirstName, ' ', S.LastName) AS Name, W.Location, W.TelExt FROM StaffAllocation SA INNER JOIN Wards W ON SA.WardID = W.WardID INNER JOIN Staff S ON SA.StaffID = S.StaffID; "
        Dim query As String = "SELECT SA.AllocationID, W.WardID, W.WardName, SA.StaffID, CONCAT(S.FirstName, ' ', S.LastName) AS Name, W.Location, W.TelExt, SA.Shift, SA.WeekBeginning, SA.WeekEnding FROM StaffAllocation SA INNER JOIN Wards W ON SA.WardID = W.WardID INNER JOIN Staff S ON SA.StaffID = S.StaffID; "
        ' สร้าง SqlDataAdapter เพื่อดึงข้อมูลจากฐานข้อมูล
        Dim dataAdapter As New SqlDataAdapter(query, sqlConnection)

        ' สร้าง DataTable เพื่อเก็บข้อมูล
        Dim dataTable As New DataTable()

        ' เปิดเชื่อมต่อฐานข้อมูล
        sqlConnection.Open()

        ' ใช้ SqlDataAdapter เพื่อเติมข้อมูลลงใน DataTable
        dataAdapter.Fill(dataTable)

        ' ปิดเชื่อมต่อฐานข้อมูล
        sqlConnection.Close()

        ' กำหนด DataGridView ให้แสดงข้อมูลจาก DataTable
        DataGridView1.DataSource = dataTable

    End Sub

    Private Function GetNextID() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(AllocationID) FROM StaffAllocation"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxAllocationID As Object = command.ExecuteScalar()

                If maxAllocationID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ SA001
                    Return "SA001"
                Else
                    Dim lastID As String = maxAllocationID.ToString()
                    Dim prefix As String = lastID.Substring(0, 2) ' จะเป็น "SA"
                    Dim numericPart As String = lastID.Substring(2)

                    If Integer.TryParse(numericPart, Nothing) Then
                        Dim currentID As Integer = Integer.Parse(numericPart)
                        Dim nextID As Integer = currentID + 1
                        Return prefix & nextID.ToString("D3")
                    Else
                        ' ถ้าไม่สามารถแปลงตัวเลขได้ ให้เริ่มที่ SA001
                        Return "SA001"
                    End If
                End If
            End Using
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nextID As String = GetNextID()
            ' สร้างคำสั่ง SQL ด้วยพารามิเตอร์
            Dim sqlin As String = "INSERT INTO StaffAllocation (AllocationID ,StaffID, Shift, WeekBeginning, WeekEnding, WardID) VALUES('" & nextID & "','" & txtBoxStaffID.Text & "', '" & txtBoxShift.Text & "', '" & dtpWeekBegin.Value.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & dtpWeekEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & txtBoxWardID.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()
            sqlConnection.Close()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StaffAllocation_Load(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConnection.Close() ' ตรวจสอบเพื่อให้แน่ใจว่าการเชื่อมต่อถูกปิดในทุกกรณี
        End Try
    End Sub


    Private Sub StaffAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT SA.AllocationID, W.WardID, W.WardName, SA.StaffID, CONCAT(S.FirstName, ' ', S.LastName) AS Name, W.Location, W.TelExt, SA.Shift, SA.WeekBeginning, SA.WeekEnding FROM StaffAllocation SA INNER JOIN Wards W ON SA.WardID = W.WardID INNER JOIN Staff S ON SA.StaffID = S.StaffID; "

        ' สร้าง SqlDataAdapter เพื่อดึงข้อมูลจากฐานข้อมูล
        Dim dataAdapter As New SqlDataAdapter(query, sqlConnection)

        ' สร้าง DataTable เพื่อเก็บข้อมูล
        Dim dataTable As New DataTable()

        ' เปิดเชื่อมต่อฐานข้อมูล
        sqlConnection.Open()

        ' ใช้ SqlDataAdapter เพื่อเติมข้อมูลลงใน DataTable
        dataAdapter.Fill(dataTable)

        ' ปิดเชื่อมต่อฐานข้อมูล
        sqlConnection.Close()

        ' กำหนด DataGridView ให้แสดงข้อมูลจาก DataTable
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' ข้อความยืนยันการลบ
            Dim confirmResult As DialogResult = MessageBox.Show("Do you want to delete the selected row(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                Try
                    ' วนลูปผ่านแถวที่เลือกใน DataGridView
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim allocationID As String = selectedRow.Cells("AllocationID").Value.ToString()

                        ' สร้างคำสั่ง SQL สำหรับลบข้อมูล
                        Dim sqlDelete As String = "DELETE FROM StaffAllocation WHERE AllocationID = @AllocationID"

                        Using sqlCmd As New SqlCommand(sqlDelete, sqlConnection)
                            sqlCmd.Parameters.AddWithValue("@AllocationID", allocationID)
                            sqlConnection.Open()
                            sqlCmd.ExecuteNonQuery()
                            sqlConnection.Close()
                        End Using

                        ' ลบแถวที่เลือกจาก DataGridView
                        DataGridView1.Rows.Remove(selectedRow)
                    Next

                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    StaffAllocation_Load(Nothing, Nothing)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    sqlConnection.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString()
            Dim cell2Value As String = selectedRow.Cells(3).Value.ToString()
            Dim cell3Value As String = selectedRow.Cells(7).Value.ToString()

            txtBoxStaffID.Text = cell2Value
            txtBoxWardID.Text = cell1Value
            txtBoxShift.Text = cell3Value

            If DateTime.TryParse(selectedRow.Cells(8).Value.ToString(), Nothing) Then
                dtpWeekBegin.Value = DateTime.Parse(selectedRow.Cells(8).Value.ToString())
            End If

            If DateTime.TryParse(selectedRow.Cells(9).Value.ToString(), Nothing) Then
                dtpWeekEnd.Value = DateTime.Parse(selectedRow.Cells(9).Value.ToString())
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim columnIndex As Integer = 0 ' เปลี่ยนตำแหน่งตามคอลัมน์ที่ต้องการแก้ไข (เริ่มที่ 0)

            If DataGridView1.Columns(columnIndex).Name = "AllocationID" Then
                Dim allocationID As String = selectedRow.Cells(columnIndex).Value.ToString()

                ' สร้างคำสั่ง SQL สำหรับการแก้ไขข้อมูล
                Dim sqlUpdate As String = "UPDATE StaffAllocation SET StaffID = @StaffID, Shift = @Shift, WeekBeginning = @WeekBeginning, WeekEnding = @WeekEnding, WardID = @WardID WHERE AllocationID = @AllocationID"

                Using sqlCmd As New SqlCommand(sqlUpdate, sqlConnection)
                    sqlCmd.Parameters.AddWithValue("@StaffID", txtBoxStaffID.Text)
                    sqlCmd.Parameters.AddWithValue("@Shift", txtBoxShift.Text)
                    sqlCmd.Parameters.AddWithValue("@WeekBeginning", dtpWeekBegin.Value)
                    sqlCmd.Parameters.AddWithValue("@WeekEnding", dtpWeekEnd.Value)
                    sqlCmd.Parameters.AddWithValue("@WardID", txtBoxWardID.Text)
                    sqlCmd.Parameters.AddWithValue("@AllocationID", allocationID)

                    sqlConnection.Open()
                    sqlCmd.ExecuteNonQuery()
                    sqlConnection.Close()
                End Using

                ' อัปเดตค่าใน DataGridView
                selectedRow.Cells(columnIndex).Value = txtBoxStaffID.Text ' เปลี่ยนตำแหน่งตามคอลัมน์ที่ต้องการแก้ไข
                ' อัปเดตค่าใน DataGridView สำหรับคอลัมน์อื่น ๆ เช่น Shift, WeekBeginning, WeekEnding, WardID ด้วยวิธีเดียวกัน
                MessageBox.Show("Edited data Successfully.")
                StaffAllocation_Load(Nothing, Nothing)
            Else
                MessageBox.Show("Not found 'AllocationID' in DataGridView")
            End If
        ElseIf DataGridView1.SelectedRows.Count > 1 Then
            MessageBox.Show("Please select only one row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoStaff As ChooseStaffName ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoStaff = New ChooseStaffName()
        newFormSChoStaff.ShowDialog()
        txtBoxStaffID.Text = newFormSChoStaff.txtStaffID
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        txtBoxWardID.Text = newFormSChoPatien.PatientId
    End Sub
End Class