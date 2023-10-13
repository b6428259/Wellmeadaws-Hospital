Imports System.Data.SqlClient

Public Class WardSupplies
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub LoadWardsComboBox()
        Dim query As String = "SELECT WardNumber, WardName FROM Wards"
        Dim command As New SqlCommand(query, sqlConnection)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        adapter.Fill(dataSet)
        ComboBox1.DataSource = dataSet.Tables(0)
        ComboBox1.DisplayMember = "WardName"
        ComboBox1.ValueMember = "WardNumber"
        sqlConnection.Close()
    End Sub

    Private Sub DisplaySuppliesInWard(WardNumber As String)
        Dim query As String = "SELECT DrugNumber, Name, Description, Dosage, Method_of_Use, Cost_per_Unit, Quantity " &
                              "FROM RequitsitionPhama " &
                              "WHERE WardNumber = @WardNumber"
        Dim command As New SqlCommand(query, sqlConnection)
        command.Parameters.AddWithValue("@WardNumber", WardNumber)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        adapter.Fill(dataSet)
        DataGridView1.DataSource = dataSet.Tables(0)
        sqlConnection.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then ' Check if an item is selected
            Dim selectedRow As DataRowView = CType(ComboBox1.SelectedItem, DataRowView)
            Dim selectedWardNumber As String = selectedRow("WardNumber").ToString()
            DisplaySuppliesInWard(selectedWardNumber)
        End If
    End Sub

    Private Sub WardSupplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWardsComboBox()
    End Sub
End Class
