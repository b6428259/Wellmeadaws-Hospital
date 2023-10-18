Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting



Public Class Dashboard

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim connection As New SqlConnection(connectionString)

    Protected Sub Load_New_Patient()




        connection.Open()

        Dim today As Date = Date.Today
        Dim countPatients As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Patients WHERE DateRegistered = @Today", connection)
            cmd.Parameters.AddWithValue("@Today", today)
            countPatients = CInt(cmd.ExecuteScalar())

        End Using

        Dim query As String = "SELECT PatientID, CONCAT(FirstName, ' ',LastName) AS Patient_Name FROM Patients WHERE DateRegistered = @Today ORDER BY PatientID"
        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Today", today)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' กำหนดข้อมูลใน DataGridView
            DataGridView1.DataSource = dataTable
        End Using

        Dim query1 As String = "SELECT * FROM NEW_REQUIT ORDER BY Requisitioned_Date DESC;" 'SELECT * FROM NEW_REQUIT ORDER BY Requisitioned_Date DESC;
        Using command As New SqlCommand(query1, connection)
            command.Parameters.AddWithValue("@Today", today)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' กำหนดข้อมูลใน DataGridView
            DataGridView2.DataSource = dataTable
        End Using

        ' SQL query
        Dim sqlQuery2 As String = "SELECT TOP 1 DrugName FROM PharmaceuticalSupplies WHERE QuantityInStock < 6 ORDER BY QuantityInStock"

        ' สร้าง SqlConnection
        Using connection As New SqlConnection(connectionString)
            ' เปิดการเชื่อมต่อ
            connection.Open()

            ' สร้าง SqlCommand
            Using command As New SqlCommand(sqlQuery2, connection)
                ' ดึงข้อมูลจากฐานข้อมูล
                Dim result As Object = command.ExecuteScalar()

                ' ตรวจสอบผลลัพธ์และกำหนดให้ Label.Text
                If result IsNot Nothing Then
                    Label17.Text = result.ToString()
                Else
                    Label17.Text = "No result"
                End If
            End Using
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_Qpatienttoday.Text = "+" & countPatients.ToString()
    End Sub

    'Dim today As Date = Date.Today

    ' 

    'Using cmd As New SqlCommand("SELECT * FROM Patients WHERE DateRegistered = @Today", connection)
    '            cmd.Parameters.AddWithValue("@Today", today)
    '
    '            Dim adapter As New SqlDataAdapter(cmd)
    '            Dim table As New DataTable()
    '            adapter.Fill(table)

    '            ' แสดงผลลัพท์ใน DataGridView
    '            DataGridView1.DataSource = table
    '        End Using

    Protected Sub Load_New_staff()
        connection.Open()



        Dim countStaff As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM staff WHERE staffID IS NOT NULL", connection)
            countStaff = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_staff.Text = countStaff.ToString()
    End Sub

    Private Sub bed_ava()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM beds WHERE BedStatus = 'Occupied'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_Bedava.Text = countOccupiedBeds.ToString()
    End Sub

    Private Sub bed_unava()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Beds WHERE BedStatus = 'Vacant'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_BedUnava.Text = countOccupiedBeds.ToString()
    End Sub


    Private Sub pay()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Bills WHERE PaymentStatus = 'Paid'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lblPay.Text = countOccupiedBeds.ToString()
    End Sub




    Private Sub unpay()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Bills WHERE PaymentStatus = 'Unpaid'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lblUnpay.Text = countOccupiedBeds.ToString()
    End Sub

    Protected Sub Chart1_dis()
        Dim nightShiftCount As Integer = 0
        Dim dayShiftCount As Integer = 0

        ' เชื่อมต่อกับฐานข้อมูล SQL

        connection.Open()

            ' ดึงข้อมูล Night Shifts จากฐานข้อมูล
            Dim nightShiftQuery As String = "SELECT COUNT(*) FROM StaffAllocation WHERE Shift = 'Night Shift'"
            Using nightShiftCommand As New SqlCommand(nightShiftQuery, connection)
                nightShiftCount = CInt(nightShiftCommand.ExecuteScalar())
            End Using

            ' ดึงข้อมูล Day Shifts จากฐานข้อมูล
            Dim dayShiftQuery As String = "SELECT COUNT(*) FROM StaffAllocation WHERE Shift = 'Day Shift'"
            Using dayShiftCommand As New SqlCommand(dayShiftQuery, connection)
                dayShiftCount = CInt(dayShiftCommand.ExecuteScalar())
            End Using

            ' ปิดการเชื่อมต่อกับฐานข้อมูล SQL
            connection.Close()


        ' สร้าง Bar Chart
        ' สร้าง Bar Chart
        Chart1.Series.Clear()

        ' กำหนดชื่อแท่งและข้อมูลสำหรับแต่ละ Category
        Dim categories As String() = {"Night Shifts", "Day Shifts"}
        Dim dataPoints As Integer() = {nightShiftCount, dayShiftCount}

        ' เพิ่ม Categories และ DataPoints ลงในแผนภูมิ
        For i As Integer = 0 To categories.Length - 1
            Dim category As String = categories(i)
            Dim dataPointValue As Integer = dataPoints(i)

            ' เพิ่มแท่งและกำหนดค่าในแต่ละ Category
            Dim dataPoint As New DataPoint()
            dataPoint.SetValueY(dataPointValue)
            dataPoint.AxisLabel = category
            dataPoint.Label = dataPointValue.ToString()
            Chart1.Series.Add(category)
            Chart1.Series(category).Points.Add(dataPoint)
        Next

        ' กำหนดระยะห่างระหว่างแท่งในแกน X
        Chart1.ChartAreas(0).AxisX.Interval = 15
        Chart1.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Number
        Chart1.ChartAreas(0).AxisX.Minimum = 0

        ' กำหนดระยะห่างระหว่างแท่งในแกน Y
        Chart1.ChartAreas(0).AxisY.Interval = 1
        Chart1.ChartAreas(0).AxisY.IntervalType = DateTimeIntervalType.Number

        ' กำหนดชื่อแกน Y
        Chart1.ChartAreas(0).AxisY.Title = "Number of Staff"
        Chart1.ChartAreas(0).AxisX.Title = "Shift"
    End Sub


    'Chart1.ChartAreas(0).AxisX.Title = "Shifts" ' กำหนดชื่อแกน X

    Private Sub Chart_2()
        connection.Open()

        Dim wardCounts As New Dictionary(Of String, String)
        wardCounts.Add("Orthopaedic", 0)
        wardCounts.Add("Cardiology", 0)
        wardCounts.Add("Pediatrics", 0)
        wardCounts.Add("Oncology", 0)
        wardCounts.Add("Neurology", 0)
        wardCounts.Add("Gynecology", 0)
        wardCounts.Add("GeneralSurgery", 0)
        wardCounts.Add("ENT", 0)
        wardCounts.Add("Psychiatry", 0)

        Dim wardNames As New List(Of String)(wardCounts.Keys) ' สร้าง List เพื่อเก็บชื่อของห้อง

        For Each ward As String In wardNames
            Dim query As String = $"SELECT COUNT(*) FROM report_listing WHERE WardName = '{ward}'"
            Using command As New SqlCommand(query, connection)
                wardCounts(ward) = CInt(command.ExecuteScalar())
            End Using
        Next

        connection.Close()

        ' สร้าง Bar Chart
        Chart2.Series.Clear()

        For Each ward As String In wardNames
            Chart2.Series.Add(ward)
            Dim dataPoint As New DataPoint()
            dataPoint.SetValueY(wardCounts(ward))
            dataPoint.Color = GetColorForWard(ward) ' กำหนดสีของแท่ง
            dataPoint.Label = wardCounts(ward).ToString() ' กำหนดจำนวนบนแท่ง
            Chart2.Series(ward).Points.Add(dataPoint)
        Next

        ' กำหนดระยะห่างระหว่างแท่งในแกน X
        Chart2.ChartAreas(0).AxisX.Interval = 1 ' ระยะห่างระหว่างแท่ง 1 หน่วย
        Chart2.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Number ' ระยะห่างเป็นตัวเลข
        Chart2.ChartAreas(0).AxisX.Minimum = 0 ' ค่าต่ำสุดในแกน X
        Chart2.ChartAreas(0).AxisX.LabelStyle.Angle = -90 ' หมุนตัวหนังสือในแกน X

        Chart2.ChartAreas(0).AxisY.Title = "Number of Staff" ' กำหนดชื่อแกน Y
        Chart2.ChartAreas(0).AxisY.Interval = 1
        Chart2.ChartAreas(0).AxisY.IntervalType = DateTimeIntervalType.Number
    End Sub

    Private Function GetColorForWard(ward As String) As Color
        Select Case ward
            Case "Orthopaedic"
                Return Color.Blue
            Case "Cardiology"
                Return Color.Orange
            Case "Pediatrics"
                Return Color.Red
            Case "Oncology"
                Return Color.Green
            Case "Neurology"
                Return Color.Brown
            Case "Gynecology"
                Return Color.Pink
            Case "GeneralSurgery"
                Return Color.Black
            Case "ENT"
                Return Color.Purple
            Case "Psychiatry"
                Return Color.Gold
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Load_New_Patient()
        Load_New_staff()
        bed_ava()
        bed_unava()
        pay()
        unpay()
        Chart1_dis()
        Chart_2()

    End Sub


End Class
