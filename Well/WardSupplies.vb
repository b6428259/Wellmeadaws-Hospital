Imports System.Data.SqlClient

Public Class WardSupplies
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub WardSupplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the ComboBox with the list of wards
        Dim wardAdapter As New SqlDataAdapter("SELECT WardName FROM RequitsitionPhama GROUP BY WardName", sqlConnection)
        Dim wardTable As New DataTable()
        wardAdapter.Fill(wardTable)

        ComboBox1.DataSource = wardTable
        ComboBox1.DisplayMember = "WardName"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' When the ComboBox selection changes, load supplies for the selected ward
        Dim selectedWard As String = ComboBox1.Text

        Dim suppliesAdapter As New SqlDataAdapter($"SELECT DrugNumber, Name, Description, Dosage, Method_of_Use, Cost_per_Unit, Quantity FROM RequitsitionPhama WHERE WardName = '{selectedWard}'", sqlConnection)
        Dim suppliesTable As New DataTable()
        suppliesAdapter.Fill(suppliesTable)

        DataGridView1.DataSource = suppliesTable
    End Sub
End Class
