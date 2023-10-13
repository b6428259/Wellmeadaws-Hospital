Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx

Public Class RequisitionSur

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)


    ' Dim oDate As DateTime = Convert.ToDateTime(selectRwquiDate.Text)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เตรียมข้อมูลใน ComboBox
        For i As Integer = 1 To 10
            ComboBoxQuan.Items.Add(i.ToString())
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
        DataGridViewRequiSer.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click




        ' เปิดการเชื่อมต่อ
        sqlConnection.Open()

        Dim WardNumber As String = txtWardNumber.Text
        Dim WardName As String = txtWardName.Text
        Dim Requi As String = txtRequi.Text
        Dim SselectRwquiDate As DateTime = Convert.ToDateTime(selectRwquiDate.Text)

        Dim itemNumber As String = txtItemNum.Text
        Dim itemName As String = txtName.Text
        Dim itemDescription As String = txtDes.Text
        Dim quantity As Integer = Integer.Parse(txtQuan.Text) ' กำหนดให้เป็นตัวเลข
        Dim method As String = txtMethod.Text
        Dim CostperU As String = txtCostperU.Text

        Dim Unitcou As Integer = Integer.Parse(ComboBoxQuan.Text)

        ' คำสั่ง SQL INSERT
        Dim query As String = "INSERT INTO RequitsitionPhama (WardNumber, WardName, Requisionby, Requidate, ItemNumber, Iname, DesCrip, QunInStock, MethOfUse, CostperUnit, Quanti) VALUES (@WardNumber, @WardName, @Requi, @SselectRwquiDate, @ItemNumber, @ItemName, @ItemDescription, @Quantity, @method, @CostPerUnit, @Unitcou)"
        Dim command As New SqlCommand(query, sqlConnection)

        ' กำหนดค่าให้กับพารามิเตอร์
        command.Parameters.AddWithValue("@WardNumber", WardNumber)
        command.Parameters.AddWithValue("@WardName", WardName)
        command.Parameters.AddWithValue("@Requi", Requi)
        command.Parameters.AddWithValue("@SselectRwquiDate", SselectRwquiDate)

        command.Parameters.AddWithValue("@ItemNumber", itemNumber)
        command.Parameters.AddWithValue("@ItemName", itemName)
        command.Parameters.AddWithValue("@ItemDescription", itemDescription)
        command.Parameters.AddWithValue("@Quantity", quantity)
        command.Parameters.AddWithValue("method", method)
        command.Parameters.AddWithValue("@CostPerUnit", CostperU)

        command.Parameters.AddWithValue("@Unitcou", Unitcou)

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
        DataGridViewRequiSer.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub

    Private Sub btnsearchResur_Click(sender As Object, e As EventArgs) Handles btnsearchResur.Click


        ' เปิดการเชื่อมต่อ
        sqlConnection.Open()

        ' ดึงข้อมูลจากฐานข้อมูล
        Dim query As String = "SELECT * FROM NonSurgicalSupplies WHERE ItemNumber = @ValueSearch"
        Dim command As New SqlCommand(query, sqlConnection)
        command.Parameters.AddWithValue("@ValueSearch", txtSearchItem.Text)

        ' อ่านข้อมูล
        Dim reader As SqlDataReader = command.ExecuteReader()

        txtItemNum.ReadOnly = True
        txtName.ReadOnly = True
        txtDes.ReadOnly = True
        txtQuan.ReadOnly = True
        txtMethod.ReadOnly = True
        txtCostperU.ReadOnly = True

        ' ตรวจสอบว่ามีข้อมูลหรือไม่
        If reader.HasRows Then
            ' อ่านข้อมูลและนำไปแสดงใน TextBox
            While reader.Read()
                txtItemNum.Text = reader("ItemNumber").ToString()
                txtName.Text = reader("ItemName").ToString()
                txtDes.Text = reader("ItemDescription").ToString()
                txtQuan.Text = reader("QuantityInStock").ToString()
                txtMethod.Text = reader("ReorderLevel").ToString()
                txtCostperU.Text = reader("CostPerUnit").ToString()
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
        Dim newForm As New RequisitionSurDel() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show() ' แสดงฟอร์มใหม่
    End Sub
End Class