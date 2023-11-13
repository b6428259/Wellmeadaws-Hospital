Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx
Imports Org.BouncyCastle.Ocsp
Public Class FormSuppiler
    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
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
        txt_SupId.ReadOnly = True

    End Sub

    Private Function GetNextID() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(SupplierID) FROM Suppliers"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxID As Object = command.ExecuteScalar()

                If maxID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "S0001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "S" & nextID.ToString("D4")
                End If
            End Using
        End Using
    End Function

    Private Sub btn_addSup_Click(sender As Object, e As EventArgs) Handles btn_addSup.Click
        Try
            Dim nextID As String = GetNextID()

            Dim FormSup_SuppilerID As String = txt_SupId.Text
            Dim FormSup_SuppilerName As String = txt_subName.Text
            Dim FormSup_SuppilerAddr As String = txt_Addr.Text
            Dim FormSup_suppilerFaxNum As String = txt_FaxNum.Text
            Dim FormSup_suppilerPhoneNum As String = txt_PhoneNum.Text

            Dim query As String = "INSERT INTO Suppliers (SupplierID, SupplierName, Address, PhoneNumber, FaxNumber) VALUES ('" & nextID & "', '" & FormSup_SuppilerName & "', '" & FormSup_SuppilerAddr & "', '" & FormSup_suppilerPhoneNum & "', '" & FormSup_suppilerFaxNum & "')" '@SupplierID, @SupplierName, @Address, @PhoneNumber, @FaxNumber)"
            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = query

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1_Load(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            sqlConnection.Close()
        End Try

        sqlConnection.Open()

        'Dim command As New SqlCommand(query, sqlConnection)
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            ' Check if a row is selected in the DataGridView
            If DataGV_sup.SelectedRows.Count > 0 Then
                ' Check if only one row is selected
                If DataGV_sup.SelectedRows.Count = 1 Then
                    ' Get the selected row
                    Dim selectedRow As DataGridViewRow = DataGV_sup.SelectedRows(0)

                    ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                    Dim primaryKeyValue As String = selectedRow.Cells("SupplierID").Value.ToString()

                    ' Create a SQL UPDATE statement
                    Dim updateQuery As String = "UPDATE Suppliers SET SupplierName = @SupplierName,
                                              Address = @Address,
                                              PhoneNumber = @PhoneNumber,
                                              FaxNumber = @FaxNumber
                                              WHERE SupplierID = @PrimaryKey"

                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(updateQuery, connection)
                            ' Add parameters for the primary key and TextBox values
                            command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                            command.Parameters.AddWithValue("@SupplierName", txt_subName.Text)
                            command.Parameters.AddWithValue("@Address", txt_Addr.Text)
                            command.Parameters.AddWithValue("@PhoneNumber", txt_PhoneNum.Text)
                            command.Parameters.AddWithValue("@FaxNumber", txt_FaxNum.Text)

                            ' Add more parameters for other columns as needed

                            connection.Open()
                            command.ExecuteNonQuery()
                            connection.Close()
                        End Using
                    End Using

                    ' Inform the user that changes have been saved
                    MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload the data to reflect the changes
                    Form1_Load(Nothing, Nothing)
                Else
                    ' Inform the user to select only one row for editing
                    MessageBox.Show("Please select only one row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ' Inform the user that no row is selected
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Try
            ' Check if any rows are selected in the DataGridView
            If DataGV_sup.SelectedRows.Count > 0 Then
                ' Ask the user to confirm the deletion
                Dim result As DialogResult = MessageBox.Show("Do you want to delete the selected row(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Create a list to store the selected primary key values
                    Dim selectedKeys As New List(Of String)

                    ' Collect the selected primary key values
                    For Each selectedRow As DataGridViewRow In DataGV_sup.SelectedRows
                        Dim primaryKeyValue As String = selectedRow.Cells("SupplierID").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM Suppliers WHERE SupplierID = @PrimaryKey"

                    ' Create a SqlConnection and SqlCommand
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(deleteQuery, connection)
                            ' Add a parameter for the primary key value
                            command.Parameters.Add("@PrimaryKey", SqlDbType.VarChar)

                            connection.Open()

                            ' Iterate through the list of selected primary keys and delete rows
                            For Each key As String In selectedKeys
                                command.Parameters("@PrimaryKey").Value = key
                                command.ExecuteNonQuery()

                                ' Remove the selected row from the DataGridView
                                Dim selectedRow As DataGridViewRow = DataGV_sup.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("SupplierID").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGV_sup.Rows.Remove(selectedRow)
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
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGV_sup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGV_sup.CellClick
        If e.RowIndex >= 0 AndAlso DataGV_sup.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGV_sup.SelectedRows(0)
            Dim cell0Value As String = selectedRow.Cells(0).Value.ToString() ' SupleID
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString() ' SubleName
            Dim cell2Value As String = selectedRow.Cells(2).Value.ToString() ' Address
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() ' Phone
            Dim cell4Value As String = selectedRow.Cells(4).Value.ToString() ' Fax

            ' Populate data into text boxes
            txt_SupId.Text = cell0Value
            txt_subName.Text = cell1Value
            txt_Addr.Text = cell2Value
            txt_PhoneNum.Text = cell3Value
            txt_FaxNum.Text = cell4Value

        End If
    End Sub
End Class