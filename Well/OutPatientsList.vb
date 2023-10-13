Imports System.Data.SqlClient

Public Class OutPatientsList
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub OutPatientsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' สร้าง query
        Dim query1 As String = "SELECT *
FROM Patients
WHERE PatientID NOT IN (SELECT PatientID FROM InPatients)
"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, SqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGridView1.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        SqlConnection.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class