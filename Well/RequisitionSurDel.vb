Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx

Public Class RequisitionSurDel

    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เตรียมข้อมูลใน ComboBox


        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Table_2"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, SqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGridToDel.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridToDel.CellClick
        ' Check if the clicked cell is not a header cell and a row is selected
        If e.RowIndex >= 0 AndAlso DataGridToDel.SelectedRows.Count > 0 Then
            ' Get data from the selected row
            Dim selectedRow = DataGridToDel.SelectedRows(0)
            Dim cell1Value As String = selectedRow.Cells(0).Value.ToString() ' Assuming column index 0

            ' Populate data into text boxes
            inputNumDel.Text = cell1Value

        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btn_Del.Click

        Dim result As DialogResult = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                ' Check if any rows are selected in the DataGridView
                If DataGridToDel.SelectedRows.Count > 0 Then
                    ' Get the selected row
                    Dim selectedRow As DataGridViewRow = DataGridToDel.SelectedRows(0)

                    ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                    Dim primaryKeyValue As String = inputNumDel.Text

                    ' Create a SQL DELETE statement
                    Dim deleteQuery As String = "DELETE FROM Table_2 WHERE WardNumber = @PrimaryKey"

                    ' Create a SqlConnection and SqlCommand
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(deleteQuery, connection)
                            ' Add a parameter for the primary key value
                            command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)

                            ' Open the database connection
                            connection.Open()

                            ' Execute the DELETE query
                            command.ExecuteNonQuery()

                            ' Close the database connection
                            connection.Close()
                        End Using
                    End Using

                    ' Remove the selected row from the DataGridView
                    DataGridToDel.Rows.Remove(selectedRow)
                End If
            Catch ex As Exception
                ' Handle any exceptions and show an error message
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            MessageBox.Show("ข้อมูลถูกลบแล้ว")
        Else
            ' ไม่ทำอะไรหากผู้ใช้ยกเลิกการลบ
            MessageBox.Show("การลบถูกยกเลิก")
        End If

    End Sub


End Class