Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx
Imports Org.BouncyCastle.Ocsp
Public Class FormSuppiler
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Suppliers"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, sqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGV_sup.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub


    Private Sub btn_addSup_Click(sender As Object, e As EventArgs) Handles btn_addSup.Click

        sqlConnection.Open()

        Dim FormSup_SuppilerID As String = txt_SupId.Text
        Dim FormSup_SuppilerName As String = txt_subName.Text
        Dim FormSup_SuppilerAddr As String = txt_Addr.Text
        Dim FormSup_suppilerFaxNum As String = txt_FaxNum.Text
        Dim FormSup_suppilerPhoneNum As String = txt_PhoneNum.Text

        Dim query As String = "INSERT INTO Suppliers (SupplierID, SupplierName, Address, PhoneNumber, FaxNumber) VALUES (@SupplierID, @SupplierName, @Address, @PhoneNumber, @FaxNumber)"
        Dim command As New SqlCommand(query, sqlConnection)

        ' กำหนดค่าให้กับพารามิเตอร์
        command.Parameters.AddWithValue("@SupplierID", FormSup_SuppilerID)
        command.Parameters.AddWithValue("@SupplierName", FormSup_SuppilerName)
        command.Parameters.AddWithValue("@Address", FormSup_SuppilerAddr)
        command.Parameters.AddWithValue("@PhoneNumber", FormSup_suppilerFaxNum)
        command.Parameters.AddWithValue("@FaxNumber", FormSup_suppilerPhoneNum)

        command.ExecuteNonQuery()



        ' แจ้งเตือนบันทึกสำเร็จ
        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว")

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Suppliers"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, sqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGV_sup.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub
End Class