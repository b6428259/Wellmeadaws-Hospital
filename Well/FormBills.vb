Imports System.Data.SqlClient

Public Class FormBills

    'Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project;User Id=admin;Password=adminadminadmin"
    Dim connectionString As String = "Data Source=124.121.233.223\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private selectedPatientID As String = ""

    Private Sub FormBills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView as you've done in your code
        LoadBillsData()

        ' Check if the selected PatientID is not empty and set it in patid_txt
        If Not String.IsNullOrEmpty(selectedPatientID) Then
            patid_txt.Text = selectedPatientID
        End If

        ' Calculate TotalAmount for bills every time the form is loaded
        CalculateTotalAmount()
    End Sub

    Private Sub LoadBillIDsForPatient(patientID As String)
        Try
            ' Create a SQL SELECT statement to retrieve BillIDs for the given PatientID
            Dim selectQuery As String = "SELECT BillID FROM Bills WHERE PatientID = @PatientID"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(selectQuery, connection)
                    connection.Open()

                    ' Add a parameter for the PatientID
                    command.Parameters.AddWithValue("@PatientID", patientID)

                    ' Create a DataTable to store the retrieved data
                    Dim dataTable As New DataTable()

                    ' Execute the query and fill the DataTable with the BillIDs
                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    ' Bind the DataTable to the ComboBox
                    BillID_Combo.DataSource = dataTable
                    BillID_Combo.DisplayMember = "BillID"
                    BillID_Combo.ValueMember = "BillID"

                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading BillIDs for the patient: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadBillsData()
        Try
            ' Create a SQL SELECT statement to retrieve bill information with patient full name
            Dim selectQuery As String = "SELECT B.BillID, P.FirstName + ' ' + P.LastName AS Name, B.BillDate, B.TotalAmount, B.PaymentStatus, B.PaymentDate, B.PatientID " &
                                    "FROM Bills B " &
                                    "INNER JOIN Patients P ON B.PatientID = P.PatientID"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(selectQuery, connection)
                    connection.Open()

                    ' Create a DataTable to store the retrieved data
                    Dim dataTable As New DataTable()

                    ' Execute the query and fill the DataTable with the bill information
                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable

                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading bill data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            ' Get the selected PaymentStatus from the ComboBox
            Dim selectedPaymentStatus As String = PaymentStatusComboBox.SelectedItem.ToString()

            ' Get the entered BillID from the TextBox
            Dim billID As String = BillID_Combo.Text.Trim()

            ' Update the PaymentStatus and PaymentDate based on the selected PaymentStatus
            Dim updateQuery As String = ""

            If selectedPaymentStatus = "Paid" Then
                ' If PaymentStatus is set to Paid, update PaymentStatus to Paid and add PaymentDate
                updateQuery = "UPDATE Bills SET PaymentStatus = 'Paid', PaymentDate = GETDATE() WHERE BillID = @BillID"
            ElseIf selectedPaymentStatus = "Unpaid" Then
                ' If PaymentStatus is set to Unpaid, update PaymentStatus to Unpaid and remove PaymentDate
                updateQuery = "UPDATE Bills SET PaymentStatus = 'Unpaid', PaymentDate = NULL WHERE BillID = @BillID"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(updateQuery, connection)
                    connection.Open()

                    ' Add a parameter for the BillID
                    command.Parameters.AddWithValue("@BillID", billID)

                    ' Execute the UPDATE query
                    command.ExecuteNonQuery()

                    connection.Close()
                End Using
            End Using

            ' Reload the data to reflect the changes in the DataGridView
            LoadBillsData()

            MessageBox.Show("Payment status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Extract the values from the selected row
            Dim patientID As String = selectedRow.Cells("PatientID").Value.ToString()
            Dim patientName As String = selectedRow.Cells("Name").Value.ToString() ' Assuming you have a column named "Name"

            ' Update the controls with the extracted values
            patid_txt.Text = patientID
            pat_name.Text = patientName
            BillID_Combo.Text = selectedRow.Cells("BillID").Value.ToString()
            PaymentStatusComboBox.Text = selectedRow.Cells("PaymentStatus").Value.ToString()
        End If
    End Sub


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtboxsearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM Bills"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM Bills WHERE BillID LIKE @SearchText OR PatientID LIKE @SearchText OR BillDate LIKE @SearchText OR TotalAmount LIKE @SearchText OR PaymentStatus LIKE @SearchText OR PaymentDate LIKE @SearchText"
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

    Private Sub PatientSearch_Click(sender As Object, e As EventArgs) Handles PatientSearch.Click
        'Dim newFormSChoPatien As ChoosPatien ' สร้างตัวแปรสำหรับฟอร์มใหม่
        'newFormSChoPatien = New ChoosPatien()
        'newFormSChoPatien.ShowDialog()
        'patid_txt.Text = newFormSChoPatien.PatienID

        Try
            Dim sForm As New SearchPatient()
            sForm.ShowDialog()

            ' Check if PatientName and PatientLastName are not empty ''

            If Not String.IsNullOrEmpty(sForm.PatientName) AndAlso Not String.IsNullOrEmpty(sForm.PatientLastName) Then
                'Concatenate the first name And last name And display in pat_name TextBox
                pat_name.Text = sForm.PatientName & " " & sForm.PatientLastName
            Else
                'Handle the case where either PatientName Or PatientLastName Is empty
                pat_name.Text = ""
            End If

            'Update patid_txt with the selected PatientID ''

            patid_txt.Text = sForm.PatientId

            'Load BillIDs for the selected patient ''

            LoadBillIDsForPatient(sForm.PatientId)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateTotalAmount()
        Try
            ' Create a SQL query to calculate the TotalAmount for each bill
            Dim query As String = "
            UPDATE Bills
            SET TotalAmount = (
                SELECT SUM(Medication.UnitsPerDay * PharmaceuticalSupplies.CostPerUnit * 
                            (DATEDIFF(DAY, Medication.StartDate, Medication.FinishDate) + 1))
                FROM Medication
                INNER JOIN PharmaceuticalSupplies ON Medication.DrugNumber = PharmaceuticalSupplies.DrugNumber
                WHERE Medication.PatientID = Bills.PatientID
                AND Medication.FinishDate <= GETDATE()
            )
            WHERE EXISTS (
                SELECT 1
                FROM Medication
                WHERE Medication.PatientID = Bills.PatientID
                AND Medication.FinishDate <= GETDATE()
            )
        "

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using
            End Using

            ' Refresh the DataGridView to display updated data
            LoadBillsData()

        Catch ex As Exception
            MessageBox.Show("เกิดปัญหาในการคำนวนเงิน(Totalamount)")
        End Try
    End Sub

End Class
