Imports System.Data.SqlClient

Public Class supplySurgical

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เตรียมข้อมูลใน ComboBox


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM SurgicalSupplies"

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

    Public Function GetNextID() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(SupplyID) FROM SurgicalSupplies"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxSupplyID As Object = command.ExecuteScalar()

                If maxSupplyID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ PHA001
                    Return "SUR001"
                Else
                    Dim maxSupplyIDString As String = maxSupplyID.ToString()
                    If maxSupplyIDString.StartsWith("SUR") AndAlso Integer.TryParse(maxSupplyIDString.Substring(3), New Integer) Then
                        ' The format is "PHAxxx", where "xxx" is a numeric part
                        Dim currentID As Integer = Integer.Parse(maxSupplyIDString.Substring(3))
                        Dim nextID As Integer = currentID + 1
                        Return "SUR" & nextID.ToString("D3")
                    ElseIf Integer.TryParse(maxSupplyIDString, New Integer) Then
                        ' The format is numeric, increment it
                        Dim currentID As Integer = Integer.Parse(maxSupplyIDString)
                        Dim nextID As Integer = currentID + 1
                        Return nextID.ToString("D5")
                    Else
                        ' The format is not as expected
                        ' Handle this case or throw an exception
                        Throw New Exception("Invalid format for maxSupplyID")
                    End If
                End If
            End Using
        End Using
    End Function

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtboxsearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM SurgicalSupplies"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM SurgicalSupplies WHERE SupplyID LIKE @SearchText OR SupplierID LIKE @SearchText OR ItemNumber LIKE @SearchText OR ItemName LIKE @SearchText"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(selectQuery, connection)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        ' Add a parameter for the search term
                        command.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                    End If

                    connection.Open()

                    ' Create a DataTable to store the retrieved data
                    Dim dataTable As New DataTable()

                    ' Execute the query and fill the DataTable with the patient information
                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable

                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions and display an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim nextID As String = GetNextID()

        Try
            sqlConnection.Open()

            Dim Supplier_id As String = txt_supplierID.Text
            Dim ItemNum As String = itemnumtxt.Text
            Dim ItemName As String = itemnametxt.Text
            Dim ItemDes As String = txt_Desc.Text
            Dim QIS As String = txt_QoS.Text
            Dim Rol As String = txbRe.Text
            Dim CPU As String = txt_CostUnit.Text

            Dim query As String = "INSERT INTO SurgicalSupplies (SupplyID, SupplierID, ItemNumber, ItemName, ItemDescription, QuantityInStock, ReorderLevel, CostPerUnit) " &
                                  "VALUES ('" & nextID & "', '" & Supplier_id & "', '" & ItemNum & "', '" & ItemName & "', '" & ItemDes & "', '" & QIS & "', '" & Rol & "', '" & CPU & "')"
            Dim command As New SqlCommand(query, sqlConnection)

            command.ExecuteNonQuery()
            sqlConnection.Close()

            MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1_Load(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            ' Check if only one row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count = 1 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("SupplyID").Value.ToString()

                ' Create a SQL UPDATE statement
                Dim updateQuery As String = "UPDATE SurgicalSupplies SET SupplierID = @SupplierID,
                                                  ItemNumber = @ItemNumber,
                                                  ItemName = @ItemName,
                                                  ItemDescription = @ItemDescription,
                                                  QuantityInStock = @QuantityInStock,
                                                  ReorderLevel = @ReorderLevel,
                                                  CostPerUnit = @CostPerUnit
                                                  WHERE SupplyID = @PrimaryKey"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for the primary key and TextBox values
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                        command.Parameters.AddWithValue("@SupplierID", txt_supplierID.Text)
                        command.Parameters.AddWithValue("@ItemNumber", itemnumtxt.Text)
                        command.Parameters.AddWithValue("@ItemName", itemnametxt.Text)
                        command.Parameters.AddWithValue("@ItemDescription", txt_Desc.Text)
                        command.Parameters.AddWithValue("@QuantityInStock", txt_QoS.Text)
                        command.Parameters.AddWithValue("@ReorderLevel", txbRe.Text)
                        command.Parameters.AddWithValue("@CostPerUnit", txt_CostUnit.Text)

                        ' Add more parameters for other columns as needed

                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using
                ' Update other columns as needed

                ' Inform the user that changes have been saved
                MessageBox.Show("Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1_Load(Nothing, Nothing)
            ElseIf DataGridView1.SelectedRows.Count > 1 Then
                MessageBox.Show("Please select only one row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            ' Check if any rows are selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Ask the user to confirm the deletion
                Dim result As DialogResult = MessageBox.Show("Do you want to delete the selected row(s)?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Create a list to store the selected primary key values
                    Dim selectedKeys As New List(Of String)

                    ' Collect the selected primary key values
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim primaryKeyValue As String = selectedRow.Cells("SupplyID").Value.ToString()
                        selectedKeys.Add(primaryKeyValue)
                    Next

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM SurgicalSupplies WHERE SupplyID = @PrimaryKey"

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
                                Dim selectedRow As DataGridViewRow = DataGridView1.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells("SupplyID").Value.ToString() = key).FirstOrDefault()
                                If selectedRow IsNot Nothing Then
                                    DataGridView1.Rows.Remove(selectedRow)
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso DataGridView1.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim cell0Value As String = selectedRow.Cells(0).Value.ToString() ' SupID
            Dim cell1Value As String = selectedRow.Cells(1).Value.ToString() ' SuplerID
            Dim cell2Value As String = selectedRow.Cells(2).Value.ToString() ' DrugNum
            Dim cell3Value As String = selectedRow.Cells(3).Value.ToString() ' DrugName
            Dim cell4Value As String = selectedRow.Cells(4).Value.ToString() ' Des
            Dim cell5Value As String = selectedRow.Cells(5).Value.ToString() ' QuInSto
            Dim cell6Value As String = selectedRow.Cells(6).Value.ToString() ' Reclevel
            Dim cell7Value As String = selectedRow.Cells(7).Value.ToString() ' CostPerUnit

            ' Populate data into text boxes
            txt_supplierID.Text = cell1Value
            itemnumtxt.Text = cell2Value
            itemnametxt.Text = cell3Value
            txt_Desc.Text = cell4Value
            txt_QoS.Text = cell5Value
            txbRe.Text = cell6Value
            txt_CostUnit.Text = cell7Value

        End If
    End Sub

End Class