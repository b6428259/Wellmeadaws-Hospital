Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx
Imports Org.BouncyCastle.Ocsp

Public Class RequisitionPharma

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เตรียมข้อมูลใน ComboBox
        For i As Integer = 1 To 10
            RE_pha_Quan.Items.Add(i.ToString())
        Next

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM RequitsitionPhama"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, sqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGridReqPhama.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub



    Private Sub RE_pha_btnAdd_Click(sender As Object, e As EventArgs) Handles RE_pha_btnAdd.Click

        sqlConnection.Open()
        ' Upper box
        Dim Req_pha_WardNumber As String = r_ph_WardNum.Text
        Dim Req_pha_WardName As String = r_ph_wardName.Text
        Dim Req_pha_Reqitby As String = r_ph_RequiBy.Text
        Dim Req_pha_date As DateTime = Convert.ToDateTime(ReQuiPhaDate.Text)

        ' Lower Box
        Dim Req_pha_DrugNumber As String = RE_pha_DraNumber.Text
        Dim Req_pha_DrungName As String = RE_pha_Name.Text
        Dim Req_pha_Descript As String = RE_pha_Desc.Text
        Dim Req_pha_Dosage As String = RE_pha_Dosage.Text
        Dim Req_pha_MetOfUse As String = RE_pha_mOus.Text
        Dim Req_pha_CostPerUnit As String = RE_pha_CPU.Text
        Dim Req_pha_Quantity As Integer = Integer.Parse(RE_pha_Quan.Text)

        ' คำสั่ง SQL INSERT
        Dim query As String = "INSERT INTO RequitsitionPhama (WardNumber, WardName, Requisitioned_By, Requisitioned_Date, Drug_Number, Name, Description, Dosage, Method_of_Use, Cost_per_Unit, Quantity) VALUES (@WardNumber, @WardName, @Requi, @SselectRwquiDate, @ItemNumber, @ItemName, @ItemDescription, @Quantity, @method, @CostPerUnit, @Unitcou)"
        Dim command As New SqlCommand(query, sqlConnection)

        ' กำหนดค่าให้กับพารามิเตอร์
        command.Parameters.AddWithValue("@WardNumber", Req_pha_WardNumber)
        command.Parameters.AddWithValue("@WardName", Req_pha_WardName)
        command.Parameters.AddWithValue("@Requi", Req_pha_Reqitby)
        command.Parameters.AddWithValue("@SselectRwquiDate", Req_pha_date)

        command.Parameters.AddWithValue("@ItemNumber", Req_pha_DrugNumber)
        command.Parameters.AddWithValue("@ItemName", Req_pha_DrungName)
        command.Parameters.AddWithValue("@ItemDescription", Req_pha_Descript)
        command.Parameters.AddWithValue("@Quantity", Req_pha_Dosage)
        command.Parameters.AddWithValue("method", Req_pha_MetOfUse)
        command.Parameters.AddWithValue("@CostPerUnit", Req_pha_CostPerUnit)

        command.Parameters.AddWithValue("@Unitcou", Req_pha_Quantity)
        ' ทำการ execute คำสั่ง SQL
        command.ExecuteNonQuery()



        ' แจ้งเตือนบันทึกสำเร็จ
        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว")

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM RequitsitionPhama"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, sqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGridReqPhama.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()




    End Sub

    Private Sub btnsearchRepharma_Click(sender As Object, e As EventArgs) Handles btnsearchRepharma.Click

        sqlConnection.Open()

        ' ดึงข้อมูลจากฐานข้อมูล
        Dim query As String = "SELECT * FROM PharmaceuticalSupplies WHERE DrugNumber = @ValueSearch"
        Dim command As New SqlCommand(query, sqlConnection)
        command.Parameters.AddWithValue("@ValueSearch", RE_pha_ItemSearch.Text)

        ' อ่านข้อมูล
        Dim reader As SqlDataReader = command.ExecuteReader()

        RE_pha_DraNumber.ReadOnly = True
        RE_pha_Name.ReadOnly = True
        RE_pha_Desc.ReadOnly = True
        RE_pha_Dosage.ReadOnly = True
        RE_pha_mOus.ReadOnly = True
        RE_pha_CPU.ReadOnly = True

        ' ตรวจสอบว่ามีข้อมูลหรือไม่
        If reader.HasRows Then
            ' อ่านข้อมูลและนำไปแสดงใน TextBox
            While reader.Read()
                RE_pha_DraNumber.Text = reader("DrugNumber").ToString()
                RE_pha_Name.Text = reader("DrugName").ToString()
                RE_pha_Desc.Text = reader("Description").ToString()
                RE_pha_Dosage.Text = reader("Dosage").ToString()
                RE_pha_mOus.Text = reader("MethodOfAdministration").ToString()
                RE_pha_CPU.Text = reader("CostPerUnit").ToString()
            End While
        Else
            ' ถ้าไม่มีข้อมูล
            MessageBox.Show("ไม่พบข้อมูล")
        End If

        ' ปิดการเชื่อมต่อ
        reader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newForm As New RequistionPhamaDel() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub
End Class