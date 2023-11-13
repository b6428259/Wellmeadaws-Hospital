Public Class FormMain

    Private selectedMenuItem As ToolStripMenuItem = Nothing
    Private Sub switchForm(form As Form)
        StaffPanel.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        StaffPanel.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub SetMenuItemBackgroundColor(menuItem As ToolStripMenuItem)
        ' Reset the background color of the previously selected menu item (if any)
        If selectedMenuItem IsNot Nothing Then
            selectedMenuItem.BackColor = Color.LightSkyBlue
        End If

        ' Set the background color of the clicked menu item to red
        menuItem.BackColor = Color.Red

        ' Update the selected menu item
        selectedMenuItem = menuItem
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        selectedMenuItem = dashboard
        dashboard.BackColor = Color.Red
        Dim dash = New Dashboard()
        switchForm(dash)

    End Sub

    Private Sub Staff_Dash()
        selectedMenuItem = STAFFToolStripMenuItem
        STAFFToolStripMenuItem.BackColor = Color.Red
        Dim Staff = New Staff()
        switchForm(Staff)
    End Sub

    Private Sub FormWard(sender As Object, e As EventArgs) Handles wardnav.Click
        SetMenuItemBackgroundColor(wardnav)

        Dim FormWard = New FormWard()
        switchForm(FormWard)
    End Sub
    Private Sub RequisitionSur_Form(sender As Object, e As EventArgs) Handles SURGICALToolStripMenuItem.Click
        SetMenuItemBackgroundColor(SURGICALToolStripMenuItem)

        Dim Requisition = New RequisitionSur()
        switchForm(Requisition)
    End Sub



    Private Sub PHARMACEUTICALToolStripMenuItem_Form(sender As Object, e As EventArgs) Handles PHARMACEUTICALToolStripMenuItem.Click
        SetMenuItemBackgroundColor(PHARMACEUTICALToolStripMenuItem)


        Dim PHARMACEUTICAL = New RequisitionPharma()
        switchForm(PHARMACEUTICAL)
    End Sub

    Private Sub PATIENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PATIENTToolStripMenuItem.Click
        SetMenuItemBackgroundColor(PATIENTToolStripMenuItem)

        Dim PATIENT = New Patient()
        switchForm(PATIENT)
    End Sub

    Private Sub MEDICATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEDICATIONToolStripMenuItem.Click
        SetMenuItemBackgroundColor(MEDICATIONToolStripMenuItem)
        Dim Medication = New Medication()
        switchForm(Medication)
    End Sub

    Private Sub BEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BEDToolStripMenuItem.Click
        SetMenuItemBackgroundColor(BEDToolStripMenuItem)


        Dim Bed = New Bed()
        switchForm(Bed)
    End Sub



    Private Sub PATIENTALLOCATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PATIENTALLOCATIONToolStripMenuItem.Click
        SetMenuItemBackgroundColor(PATIENTALLOCATIONToolStripMenuItem)


        Dim PatientAllocation = New PatientAllocation()
        switchForm(PatientAllocation)
    End Sub

    Private Sub SUPPILERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUPPILERToolStripMenuItem.Click
        SetMenuItemBackgroundColor(SUPPILERToolStripMenuItem)


        Dim FormSuppiler = New FormSuppiler()
        switchForm(FormSuppiler)
    End Sub

    Private Sub BILLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BILLSToolStripMenuItem.Click
        SetMenuItemBackgroundColor(BILLSToolStripMenuItem)


        Dim FormBills = New FormBills()
        switchForm(FormBills)
    End Sub

    Private Sub STAFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STAFFToolStripMenuItem.Click
        SetMenuItemBackgroundColor(STAFFToolStripMenuItem)


        Dim Staff = New Staff()
        switchForm(Staff)
    End Sub

    Private Sub STAFFALLOCATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STAFFALLOCATIONToolStripMenuItem.Click
        SetMenuItemBackgroundColor(STAFFALLOCATIONToolStripMenuItem)


        Dim StaffAllocation = New StaffAllocation()
        switchForm(StaffAllocation)
    End Sub

    Private Sub INPATIENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INPATIENTToolStripMenuItem.Click
        SetMenuItemBackgroundColor(INPATIENTToolStripMenuItem)


        Dim InPatient = New InPatient()
        switchForm(InPatient)
    End Sub

    Private Sub APPOINTMENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APPOINTMENTSToolStripMenuItem.Click
        SetMenuItemBackgroundColor(APPOINTMENTSToolStripMenuItem)


        Dim Appointments = New Appointments()
        switchForm(Appointments)
    End Sub

    Private Sub PHAMASUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PHAMASUToolStripMenuItem.Click
        Dim PhamaSupply = New supplyPhama()
        PhamaSupply.StartPosition = FormStartPosition.CenterScreen
        switchForm(PhamaSupply)
    End Sub

    Private Sub SURGICALSUPPLYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SURGICALSUPPLYToolStripMenuItem.Click
        Dim SurgicalSupply = New supplySurgical()
        SurgicalSupply.StartPosition = FormStartPosition.CenterParent
        switchForm(SurgicalSupply)
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        SetMenuItemBackgroundColor(dashboard)

        Dim ds = New Dashboard()
        switchForm(ds)
    End Sub
End Class
