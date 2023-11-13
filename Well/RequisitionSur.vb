Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx

Public Class RequisitionSur

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)


    ' Dim oDate As DateTime = Convert.ToDateTime(selectRwquiDate.Text)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เตรียมข้อมูลใน ComboBox
        For i As Integer = 1 To 10
            ComboBoxQuan.Items.Add(i.ToString())
        Next

        ' สร้าง query
        Dim query1 As String = "SELECT RequiNO, *  FROM RequisitionSur"

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
        Try
            'Dim nextID As String = GetNextID()

            Dim sqlin As String = "INSERT INTO RequisitionSur (WardNumber, WardName, Requisionby, Requidate, ItemNumber, Iname, DesCrip, QunInStock, MethOfUse, CostperUnit, Quanti) " &
                                  "VALUES('" & txtWardNumber.Text & "','" & txtWardName.Text & "', '" & txtRequi.Text & "', '" & selectRwquiDate.Value.ToString("yyyy-MM-dd") & "', '" & txtItemNum.Text & "', '" & txtName.Text & "','" & txtDes.Text & "','" & txtQuan.Text & "','" & txtMethod.Text & "','" & txtCostperU.Text & "','" & ComboBoxQuan.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1_Load(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConnection.Close()
        End Try
        ' เปิดการเชื่อมต่อ
        sqlConnection.Open()

        'Dim WardNumber As String = txtWardNumber.Text
        'Dim WardName As String = txtWardName.Text
        'Dim Requi As String = txtRequi.Text
        'Dim SselectRwquiDate As DateTime = Convert.ToDateTime(selectRwquiDate.Text)

        'Dim itemNumber As String = txtItemNum.Text
        'Dim itemName As String = txtName.Text
        'Dim itemDescription As String = txtDes.Text
        'Dim quantity As Integer = Integer.Parse(txtQuan.Text) ' กำหนดให้เป็นตัวเลข
        'Dim method As String = txtMethod.Text
        'Dim CostperU As String = txtCostperU.Text

        'Dim Unitcou As Integer = Integer.Parse(ComboBoxQuan.Text)

        ' คำสั่ง SQL INSERT
        'Dim query As String = "INSERT INTO RequisitionSur (WardNumber, WardName, Requisionby, Requidate, ItemNumber, Iname, DesCrip, QunInStock, MethOfUse, CostperUnit, Quanti) VALUES (@WardNumber, @WardName, @Requi, @SselectRwquiDate, @ItemNumber, @ItemName, @ItemDescription, @Quantity, @method, @CostPerUnit, @Unitcou)"
        'Dim command As New SqlCommand(query, sqlConnection)

        ' กำหนดค่าให้กับพารามิเตอร์
        'Command.Parameters.AddWithValue("@WardNumber", WardNumber)
        'Command.Parameters.AddWithValue("@WardName", WardName)
        'Command.Parameters.AddWithValue("@Requi", Requi)
        'Command.Parameters.AddWithValue("@SselectRwquiDate", SselectRwquiDate)

        'Command.Parameters.AddWithValue("@ItemNumber", itemNumber)
        'Command.Parameters.AddWithValue("@ItemName", itemName)
        'Command.Parameters.AddWithValue("@ItemDescription", itemDescription)
        'Command.Parameters.AddWithValue("@Quantity", quantity)
        'Command.Parameters.AddWithValue("method", method)
        'Command.Parameters.AddWithValue("@CostPerUnit", CostperU)

        'Command.Parameters.AddWithValue("@Unitcou", Unitcou)

        ' ทำการ execute คำสั่ง SQL
        'Command.ExecuteNonQuery()
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
            MessageBox.Show("Not Found")
        End If

        ' ปิดการเชื่อมต่อ
        reader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' NEW DEL 
        Try
            If DataGridViewRequiSer.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Do you want to delete the selected row(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim selectedKeys As New List(Of String)

                    For Each selectedRow As DataGridViewRow In DataGridViewRequiSer.SelectedRows
                        Dim primaryKeyValue As String = selectedRow.Cells("RequiNO").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    Dim deleteQuery As String = "DELETE FROM RequisitionSur WHERE RequiNO = @PrimaryKey"

                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(deleteQuery, connection)
                            command.Parameters.Add("@PrimaryKey", SqlDbType.VarChar)

                            connection.Open()

                            For Each key As String In selectedKeys
                                command.Parameters("@PrimaryKey").Value = key
                                command.ExecuteNonQuery()

                                Dim selectedRow As DataGridViewRow = DataGridViewRequiSer.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("RequiNO").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridViewRequiSer.Rows.Remove(selectedRow)
                                End If
                            Next

                            connection.Close()
                        End Using
                    End Using
                End If
                MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1_Load(Nothing, Nothing)
            Else
                MessageBox.Show("Please select rows to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' OLD DEL BUTTON
        'Dim newForm As New RequisitionSurDel() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        'newForm.StartPosition = FormStartPosition.CenterScreen
        'newForm.Show() ' แสดงฟอร์มใหม่
    End Sub

    Private Sub DataGridViewRequiSer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRequiSer.CellClick
        If e.RowIndex >= 0 AndAlso DataGridViewRequiSer.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridViewRequiSer.SelectedRows(0)
            Dim cell0Value As String = selectedRow.Cells(0).Value.ToString() ' Assuming column index 0
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString() ' Assuming column index 0
            Dim cell2Value As String = selectedRow.Cells(2).Value.ToString() ' Assuming column index 1
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() ' Assuming column index 2
            Dim cell4Value As String = selectedRow.Cells(4).Value.ToString()
            Dim cell5Value As String = selectedRow.Cells(5).Value.ToString()
            Dim cell6Value As String = selectedRow.Cells(6).Value.ToString()
            Dim cell7Value As String = selectedRow.Cells(7).Value.ToString()
            Dim cell8Value As String = selectedRow.Cells(8).Value.ToString()
            Dim cell9Value As String = selectedRow.Cells(9).Value.ToString()
            Dim cell10Value As String = selectedRow.Cells(10).Value.ToString()
            Dim cell11Value As String = selectedRow.Cells(11).Value.ToString()

            ' Populate data into text boxes
            txtWardNumber.Text = cell1Value
            txtWardName.Text = cell2Value
            txtRequi.Text = cell3Value
            selectRwquiDate.Text = cell4Value
            txtItemNum.Text = cell5Value
            txtName.Text = cell6Value
            txtDes.Text = cell7Value
            txtQuan.Text = cell8Value
            txtMethod.Text = cell9Value
            txtCostperU.Text = cell10Value
            ComboBoxQuan.Text = cell11Value

        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        txtWardNumber.Text = newFormSChoPatien.PatientId
        txtWardName.Text = newFormSChoPatien.PatientName
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoStaff As ChooseStaffName ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoStaff = New ChooseStaffName()
        newFormSChoStaff.ShowDialog()
        txtRequi.Text = newFormSChoStaff.txtStaffID
    End Sub
End Class