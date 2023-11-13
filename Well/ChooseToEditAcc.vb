Imports System.Data.SqlClient

Public Class ChooseToEditAcc
    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Public txtStaffName As String
    Public txtStaffID As String
    Public txtLastName As String
    Public txtPasswd As String

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM userinherewithpass"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' เปิดการเชื่อมต่อกับฐานข้อมูล
        sqlConnection.Open()

        Dim v_txt_StaffName As String = txtStaffNameSearch.Text


        ' ดึงข้อมูลจากฐานข้อมูล
        Dim query As String = "SELECT * FROM userinherewithpass WHERE FirstName = @ValueSearch OR LastName = @ValueSearch"
        Dim command As New SqlCommand(query, sqlConnection)
        command.Parameters.AddWithValue("@ValueSearch", v_txt_StaffName)

        Dim reader As SqlDataReader = command.ExecuteReader()

        ' ปิดการเชื่อมต่อ
        reader.Close()

        ' Create a DataTable to store the retrieved data
        Dim dataTable As New DataTable()

        ' Execute the query and fill the DataTable with the patient information
        Dim dataAdapter As New SqlDataAdapter(command)
        dataAdapter.Fill(dataTable)

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dataTable

        sqlConnection.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As EventArgs) Handles DataGridView1.Click
        txtStaffID = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        txtStaffName = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        txtLastName = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        txtPasswd = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        Me.Close()
    End Sub

End Class