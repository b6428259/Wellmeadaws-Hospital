<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Appointments))
        Panel1 = New Panel()
        PatientIDtxt = New TextBox()
        WardIDtxt = New TextBox()
        LabelWardID = New Label()
        LabelPatientID = New Label()
        Panel2 = New Panel()
        appointmentdate = New DateTimePicker()
        txtboxsearch = New TextBox()
        LabelAppointmentDate = New Label()
        btnsearch = New PictureBox()
        LabelDiagnosis = New Label()
        Diagnosistxt = New TextBox()
        TreatmentPlantxt = New TextBox()
        butAdd = New Button()
        LabelTreatmentPlan = New Label()
        butEdit = New Button()
        ButDelete = New Button()
        DataGridView1 = New DataGridView()
        LabelPatients = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(btnsearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PatientIDtxt)
        Panel1.Controls.Add(WardIDtxt)
        Panel1.Controls.Add(LabelWardID)
        Panel1.Controls.Add(LabelPatientID)
        Panel1.Location = New Point(43, 92)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1178, 75)
        Panel1.TabIndex = 91
        ' 
        ' PatientIDtxt
        ' 
        PatientIDtxt.BorderStyle = BorderStyle.FixedSingle
        PatientIDtxt.Location = New Point(161, 16)
        PatientIDtxt.Margin = New Padding(3, 4, 3, 4)
        PatientIDtxt.Name = "PatientIDtxt"
        PatientIDtxt.Size = New Size(151, 27)
        PatientIDtxt.TabIndex = 81
        ' 
        ' WardIDtxt
        ' 
        WardIDtxt.BorderStyle = BorderStyle.FixedSingle
        WardIDtxt.Location = New Point(553, 16)
        WardIDtxt.Margin = New Padding(3, 4, 3, 4)
        WardIDtxt.Name = "WardIDtxt"
        WardIDtxt.Size = New Size(187, 27)
        WardIDtxt.TabIndex = 73
        ' 
        ' LabelWardID
        ' 
        LabelWardID.AutoSize = True
        LabelWardID.Location = New Point(479, 23)
        LabelWardID.Name = "LabelWardID"
        LabelWardID.Size = New Size(70, 20)
        LabelWardID.TabIndex = 59
        LabelWardID.Text = "Ward ID :"
        ' 
        ' LabelPatientID
        ' 
        LabelPatientID.AutoSize = True
        LabelPatientID.Location = New Point(80, 19)
        LabelPatientID.Name = "LabelPatientID"
        LabelPatientID.Size = New Size(80, 20)
        LabelPatientID.TabIndex = 57
        LabelPatientID.Text = "Patient ID :"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(appointmentdate)
        Panel2.Controls.Add(txtboxsearch)
        Panel2.Controls.Add(LabelAppointmentDate)
        Panel2.Controls.Add(btnsearch)
        Panel2.Controls.Add(LabelDiagnosis)
        Panel2.Controls.Add(Diagnosistxt)
        Panel2.Controls.Add(TreatmentPlantxt)
        Panel2.Controls.Add(butAdd)
        Panel2.Controls.Add(LabelTreatmentPlan)
        Panel2.Controls.Add(butEdit)
        Panel2.Controls.Add(ButDelete)
        Panel2.Location = New Point(43, 176)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1179, 249)
        Panel2.TabIndex = 90
        ' 
        ' appointmentdate
        ' 
        appointmentdate.CustomFormat = "yyyy-MM-dd"
        appointmentdate.Location = New Point(161, 57)
        appointmentdate.Name = "appointmentdate"
        appointmentdate.Size = New Size(243, 27)
        appointmentdate.TabIndex = 83
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Location = New Point(928, 192)
        txtboxsearch.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch.Multiline = True
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(212, 34)
        txtboxsearch.TabIndex = 38
        ' 
        ' LabelAppointmentDate
        ' 
        LabelAppointmentDate.AutoSize = True
        LabelAppointmentDate.Location = New Point(19, 60)
        LabelAppointmentDate.Name = "LabelAppointmentDate"
        LabelAppointmentDate.Size = New Size(136, 20)
        LabelAppointmentDate.TabIndex = 56
        LabelAppointmentDate.Text = "AppointmentDate :"
        ' 
        ' btnsearch
        ' 
        btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), Image)
        btnsearch.Location = New Point(1129, 192)
        btnsearch.Margin = New Padding(3, 4, 3, 4)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(61, 36)
        btnsearch.SizeMode = PictureBoxSizeMode.Zoom
        btnsearch.TabIndex = 0
        btnsearch.TabStop = False
        ' 
        ' LabelDiagnosis
        ' 
        LabelDiagnosis.AutoSize = True
        LabelDiagnosis.Location = New Point(482, 60)
        LabelDiagnosis.Name = "LabelDiagnosis"
        LabelDiagnosis.Size = New Size(81, 20)
        LabelDiagnosis.TabIndex = 58
        LabelDiagnosis.Text = "Diagnosis :"
        ' 
        ' Diagnosistxt
        ' 
        Diagnosistxt.BorderStyle = BorderStyle.FixedSingle
        Diagnosistxt.Location = New Point(567, 57)
        Diagnosistxt.Margin = New Padding(3, 4, 3, 4)
        Diagnosistxt.Name = "Diagnosistxt"
        Diagnosistxt.Size = New Size(151, 27)
        Diagnosistxt.TabIndex = 82
        ' 
        ' TreatmentPlantxt
        ' 
        TreatmentPlantxt.BorderStyle = BorderStyle.FixedSingle
        TreatmentPlantxt.Location = New Point(953, 57)
        TreatmentPlantxt.Margin = New Padding(3, 4, 3, 4)
        TreatmentPlantxt.Name = "TreatmentPlantxt"
        TreatmentPlantxt.Size = New Size(187, 27)
        TreatmentPlantxt.TabIndex = 80
        ' 
        ' butAdd
        ' 
        butAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        butAdd.Location = New Point(439, 196)
        butAdd.Margin = New Padding(3, 4, 3, 4)
        butAdd.Name = "butAdd"
        butAdd.Size = New Size(86, 31)
        butAdd.TabIndex = 68
        butAdd.Text = "ADD"
        butAdd.UseVisualStyleBackColor = False
        ' 
        ' LabelTreatmentPlan
        ' 
        LabelTreatmentPlan.AutoSize = True
        LabelTreatmentPlan.Location = New Point(845, 60)
        LabelTreatmentPlan.Name = "LabelTreatmentPlan"
        LabelTreatmentPlan.Size = New Size(111, 20)
        LabelTreatmentPlan.TabIndex = 79
        LabelTreatmentPlan.Text = "TreatmentPlan :"
        ' 
        ' butEdit
        ' 
        butEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        butEdit.Location = New Point(567, 196)
        butEdit.Margin = New Padding(3, 4, 3, 4)
        butEdit.Name = "butEdit"
        butEdit.Size = New Size(86, 31)
        butEdit.TabIndex = 69
        butEdit.Text = "EDIT"
        butEdit.UseVisualStyleBackColor = False
        ' 
        ' ButDelete
        ' 
        ButDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        ButDelete.Location = New Point(690, 196)
        ButDelete.Margin = New Padding(3, 4, 3, 4)
        ButDelete.Name = "ButDelete"
        ButDelete.Size = New Size(86, 31)
        ButDelete.TabIndex = 70
        ButDelete.Text = "DELETE"
        ButDelete.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(43, 451)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1181, 303)
        DataGridView1.TabIndex = 89
        ' 
        ' LabelPatients
        ' 
        LabelPatients.AutoSize = True
        LabelPatients.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPatients.Location = New Point(537, 48)
        LabelPatients.Name = "LabelPatients"
        LabelPatients.Size = New Size(0, 37)
        LabelPatients.TabIndex = 88
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(571, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 37)
        Label1.TabIndex = 92
        Label1.Text = "PATIENTS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(559, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 32)
        Label2.TabIndex = 93
        Label2.Text = "Appointments"
        ' 
        ' Appointments
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 767)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(LabelPatients)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Appointments"
        Text = "Appointments"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(btnsearch, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PatientIDtxt As TextBox
    Friend WithEvents WardIDtxt As TextBox
    Friend WithEvents LabelWardID As Label
    Friend WithEvents LabelPatientID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents LabelAppointmentDate As Label
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents LabelDiagnosis As Label
    Friend WithEvents Diagnosistxt As TextBox
    Friend WithEvents TreatmentPlantxt As TextBox
    Friend WithEvents butAdd As Button
    Friend WithEvents LabelTreatmentPlan As Label
    Friend WithEvents butEdit As Button
    Friend WithEvents ButDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelPatients As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents appointmentdate As DateTimePicker
End Class
