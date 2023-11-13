Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx
Imports Org.BouncyCastle.Ocsp

Public Class RequisitionPharma

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เตรียมข้อมูลใน ComboBox
        For i As Integer = 1 To 10
            RE_pha_Quan.Items.Add(i.ToString())
        Next

        ' สร้าง query
        Dim query1 As String = "SELECT Requi, * FROM RequitsitionPhama"

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
        Try
            'Dim nextID As String = GetNextID()

            Dim sqlin As String = "INSERT INTO RequitsitionPhama (WardNumber, WardName, Requisitioned_By, Requisitioned_Date, DrugNumber, Name, Description, Dosage, Method_of_Use, Cost_per_Unit, Quantity) " &
                                  "VALUES('" & r_ph_WardNum.Text & "','" & r_ph_wardName.Text & "', '" & r_ph_RequiBy.Text & "', '" & ReQuiPhaDate.Value.ToString("yyyy-MM-dd") & "', '" & RE_pha_DraNumber.Text & "', '" & RE_pha_Name.Text & "','" & RE_pha_Desc.Text & "','" & RE_pha_Dosage.Text & "','" & RE_pha_mOus.Text & "','" & RE_pha_CPU.Text & "','" & RE_pha_Quan.Text & "')"

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
            MessageBox.Show("Not Found")
        End If

        ' ปิดการเชื่อมต่อ
        reader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' NEW DEL 
        Try
            If DataGridReqPhama.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Do you want to delete the selected row(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim selectedKeys As New List(Of String)

                    For Each selectedRow As DataGridViewRow In DataGridReqPhama.SelectedRows
                        Dim primaryKeyValue As String = selectedRow.Cells("Requi").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    Dim deleteQuery As String = "DELETE FROM RequitsitionPhama WHERE Requi = @PrimaryKey"

                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(deleteQuery, connection)
                            command.Parameters.Add("@PrimaryKey", SqlDbType.VarChar)

                            connection.Open()

                            For Each key As String In selectedKeys
                                command.Parameters("@PrimaryKey").Value = key
                                command.ExecuteNonQuery()

                                Dim selectedRow As DataGridViewRow = DataGridReqPhama.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("Requi").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridReqPhama.Rows.Remove(selectedRow)
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
        'Dim newForm As New RequistionPhamaDel() ' สร้างตัวแปรสำหรับฟอร์มใหม่
        'newForm.StartPosition = FormStartPosition.CenterScreen
        'newForm.Show() ' แสดงฟอร์มใหม่
    End Sub

    Private Sub DataGridViewRequiSer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridReqPhama.CellClick
        If e.RowIndex >= 0 AndAlso DataGridReqPhama.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridReqPhama.SelectedRows(0)
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
            r_ph_WardNum.Text = cell1Value
            r_ph_wardName.Text = cell2Value
            r_ph_RequiBy.Text = cell3Value
            ReQuiPhaDate.Text = cell4Value
            RE_pha_DraNumber.Text = cell5Value
            RE_pha_Name.Text = cell6Value
            RE_pha_Desc.Text = cell7Value
            RE_pha_Dosage.Text = cell8Value
            RE_pha_mOus.Text = cell9Value
            RE_pha_CPU.Text = cell10Value
            RE_pha_Quan.Text = cell11Value

        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        r_ph_WardNum.Text = newFormSChoPatien.PatientId
        r_ph_wardName.Text = newFormSChoPatien.PatientName
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoStaff As ChooseStaffName ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoStaff = New ChooseStaffName()
        newFormSChoStaff.ShowDialog()
        r_ph_RequiBy.Text = newFormSChoStaff.txtStaffID
    End Sub
End Class