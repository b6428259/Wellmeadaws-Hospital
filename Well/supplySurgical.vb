Imports System.Data.SqlClient

Public Class supplySurgical

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
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

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        Dim nextID As String = GetNextID()

        Try
            sqlConnection.Open()

            Dim Supplier_id As String = txt_supplierID.Text
            Dim ItemNum As String = itemnumtxt.Text
            Dim ItemName As String = itemnametxt.Text
            Dim ItemDes As String = txt_Desc.Text
            Dim QIS As String = txt_QoS.Text
            Dim CPU As String = txt_CostUnit.Text



            Dim query As String = "INSERT INTO SurgicalSupplies (SupplyID, SupplierID, ItemNumber, ItemName, ItemDescription, QuantityInStock, CostPerUnit) " &
                                  "VALUES ('" & nextID & "', '" & Supplier_id & "', '" & ItemNum & "', '" & ItemName & "', '" & ItemDes & "', '" & QIS & "', '" & CPU & "')"
            Dim command As New SqlCommand(query, sqlConnection)

            command.ExecuteNonQuery()

            MessageBox.Show("บันทึกข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

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
End Class