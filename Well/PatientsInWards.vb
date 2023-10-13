Imports System.Data.SqlClient

Public Class PatientsInWards
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub LoadWardsComboBox()
        Dim query As String = "SELECT WardID, WardName FROM Wards"
        Dim command As New SqlCommand(query, sqlConnection)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        adapter.Fill(dataSet)
        ComboBox1.DataSource = dataSet.Tables(0)
        ComboBox1.DisplayMember = "WardName"
        ComboBox1.ValueMember = "WardID"
        sqlConnection.Close()
    End Sub

    Private Sub DisplayPatientsInWard(WardID As String)
        Dim query As String = "SELECT p.PatientID, CONCAT(p.FirstName, ' ', p.LastName) AS Name, p.Sex, p.Tel " &
                              "FROM PatientAllocation pa " &
                              "JOIN Patients p ON pa.PatientID = p.PatientID " &
                              "WHERE pa.WardID = @WardID"
        Dim command As New SqlCommand(query, sqlConnection)
        command.Parameters.AddWithValue("@WardID", WardID)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        adapter.Fill(dataSet)
        DataGridView1.DataSource = dataSet.Tables(0)
        sqlConnection.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedWardID As String = ComboBox1.SelectedValue.ToString()
        DisplayPatientsInWard(selectedWardID)
    End Sub

    Private Sub PatientsInWards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWardsComboBox()
    End Sub
End Class
