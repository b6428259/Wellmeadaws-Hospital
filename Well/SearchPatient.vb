Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SearchPatient

    Dim tablePatient As New DataTable
    Public PatientName As String
    Public PatientLastName As String
    Public PatientId As String

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    ' Variable to store the selected PatientID
    Private selectedPatientID As String = ""

    Private originalFormBills As FormBills

    Private Sub SearchPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillsData()
    End Sub

    Private Sub LoadBillsData()
        Try
            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String = "SELECT * FROM Patients"

            Using command As New SqlCommand(selectQuery, sqlConnection)
                sqlConnection.Open()

                ' Create a DataTable to store the retrieved data
                Dim dataTable As New DataTable()

                ' Execute the query and fill the DataTable with the patient information
                Dim dataAdapter As New SqlDataAdapter(command)
                dataAdapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dataTable

                sqlConnection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading patient data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        PatientId = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        PatientName = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        PatientLastName = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        Me.Close()
    End Sub

    Private Sub btnsearchpatient_Click(sender As Object, e As EventArgs) Handles btnsearchpatient.Click
        Dim searchText As String = txtBoxSearch.Text.Trim()

        If searchText.Length = 0 Then
            MessageBox.Show("โปรดใส่ข้อ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim sqlSelectQuery As String = "SELECT * FROM Patients WHERE " &
            "PatientID LIKE @searchText OR " &
            "FirstName LIKE @searchText OR " &
            "LastName LIKE @searchText OR " &
            "Address LIKE @searchText OR " &
            "Tel LIKE @searchText OR " &
            "DateOfBirth LIKE @searchText OR " &
            "Sex LIKE @searchText OR " &
            "MaritalStatus LIKE @searchText OR " &
            "DateRegistered LIKE @searchText"

        Try
            Using sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                sqlConnection.Open()

                Dim sqlReader As SqlDataReader = sqlCommand.ExecuteReader()

                tablePatient.Load(sqlReader)

                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = tablePatient
                DataGridView1.Refresh()

                sqlConnection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while searching for patients: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Function to retrieve the selected PatientID from DataGridView

End Class
