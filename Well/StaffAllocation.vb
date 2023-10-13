Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class StaffAllocation

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub btnsearchstaffallo_Click(sender As Object, e As EventArgs) Handles btnsearchstaffallo.Click
        Dim query As String = "SELECT
    W.WardID,
    W.WardName,
    SA.StaffID,
    CONCAT(S.FirstName, ' ', S.LastName) AS Name,
    W.Location,
    W.TelExt
FROM
    StaffAllocation SA
INNER JOIN
    Wards W ON SA.WardID = W.WardID
INNER JOIN
    Staff S ON SA.StaffID = S.StaffID;

"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            ' สร้างคำสั่ง SQL ด้วยพารามิเตอร์
            Dim sqlin As String = "INSERT INTO StaffAllocation (AllocationID ,StaffID, Shift, WeekBeginning, WeekEnding, WardID) VALUES('" & TextBoxAllocateID.Text & "','" & txtBoxStaffID.Text & "', '" & txtBoxShift.Text & "', '" & txtBoxWeekBegin.Text & "', '" & txtBoxWeekEnd.Text & "', '" & txtBoxWardID.Text & "')"

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

    Private Sub StaffAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT
    W.WardID,
    W.WardName,
    SA.StaffID,
    CONCAT(S.FirstName, ' ', S.LastName) AS Name,
    W.Location,
    W.TelExt
FROM
    StaffAllocation SA
INNER JOIN
    Wards W ON SA.WardID = W.WardID
INNER JOIN
    Staff S ON SA.StaffID = S.StaffID;

"

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
End Class