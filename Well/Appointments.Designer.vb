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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointments))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PatientIDtxt = New System.Windows.Forms.TextBox()
        Me.LabelPatientID = New System.Windows.Forms.Label()
        Me.WardIDtxt = New System.Windows.Forms.TextBox()
        Me.LabelWardID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.appointmentdate = New System.Windows.Forms.DateTimePicker()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.LabelAppointmentDate = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.PictureBox()
        Me.LabelDiagnosis = New System.Windows.Forms.Label()
        Me.Diagnosistxt = New System.Windows.Forms.TextBox()
        Me.TreatmentPlantxt = New System.Windows.Forms.TextBox()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.LabelTreatmentPlan = New System.Windows.Forms.Label()
        Me.butEdit = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelPatients = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PatientIDtxt)
        Me.Panel1.Controls.Add(Me.LabelPatientID)
        Me.Panel1.Location = New System.Drawing.Point(21, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 49)
        Me.Panel1.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Lastname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Firstname :"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(488, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 90
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(269, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 89
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(153, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'PatientIDtxt
        '
        Me.PatientIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientIDtxt.Location = New System.Drawing.Point(66, 12)
        Me.PatientIDtxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PatientIDtxt.Name = "PatientIDtxt"
        Me.PatientIDtxt.Size = New System.Drawing.Size(82, 20)
        Me.PatientIDtxt.TabIndex = 81
        '
        'LabelPatientID
        '
        Me.LabelPatientID.AutoSize = True
        Me.LabelPatientID.Location = New System.Drawing.Point(2, 14)
        Me.LabelPatientID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPatientID.Name = "LabelPatientID"
        Me.LabelPatientID.Size = New System.Drawing.Size(60, 13)
        Me.LabelPatientID.TabIndex = 57
        Me.LabelPatientID.Text = "Patient ID :"
        '
        'WardIDtxt
        '
        Me.WardIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WardIDtxt.Location = New System.Drawing.Point(59, 13)
        Me.WardIDtxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.WardIDtxt.Name = "WardIDtxt"
        Me.WardIDtxt.Size = New System.Drawing.Size(97, 20)
        Me.WardIDtxt.TabIndex = 73
        '
        'LabelWardID
        '
        Me.LabelWardID.AutoSize = True
        Me.LabelWardID.Location = New System.Drawing.Point(2, 17)
        Me.LabelWardID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWardID.Name = "LabelWardID"
        Me.LabelWardID.Size = New System.Drawing.Size(53, 13)
        Me.LabelWardID.TabIndex = 59
        Me.LabelWardID.Text = "Ward ID :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.appointmentdate)
        Me.Panel2.Controls.Add(Me.LabelAppointmentDate)
        Me.Panel2.Controls.Add(Me.LabelDiagnosis)
        Me.Panel2.Controls.Add(Me.Diagnosistxt)
        Me.Panel2.Controls.Add(Me.TreatmentPlantxt)
        Me.Panel2.Controls.Add(Me.butAdd)
        Me.Panel2.Controls.Add(Me.LabelTreatmentPlan)
        Me.Panel2.Controls.Add(Me.butEdit)
        Me.Panel2.Controls.Add(Me.ButDelete)
        Me.Panel2.Location = New System.Drawing.Point(21, 112)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 110)
        Me.Panel2.TabIndex = 90
        '
        'appointmentdate
        '
        Me.appointmentdate.CustomFormat = "yyyy-MM-dd"
        Me.appointmentdate.Location = New System.Drawing.Point(121, 18)
        Me.appointmentdate.Margin = New System.Windows.Forms.Padding(2)
        Me.appointmentdate.Name = "appointmentdate"
        Me.appointmentdate.Size = New System.Drawing.Size(183, 20)
        Me.appointmentdate.TabIndex = 83
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Location = New System.Drawing.Point(850, 238)
        Me.txtboxsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch.Multiline = True
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(160, 23)
        Me.txtboxsearch.TabIndex = 38
        '
        'LabelAppointmentDate
        '
        Me.LabelAppointmentDate.AutoSize = True
        Me.LabelAppointmentDate.Location = New System.Drawing.Point(14, 20)
        Me.LabelAppointmentDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAppointmentDate.Name = "LabelAppointmentDate"
        Me.LabelAppointmentDate.Size = New System.Drawing.Size(95, 13)
        Me.LabelAppointmentDate.TabIndex = 56
        Me.LabelAppointmentDate.Text = "AppointmentDate :"
        '
        'btnsearch
        '
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(1014, 237)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(38, 23)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.TabStop = False
        '
        'LabelDiagnosis
        '
        Me.LabelDiagnosis.AutoSize = True
        Me.LabelDiagnosis.Location = New System.Drawing.Point(417, 20)
        Me.LabelDiagnosis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDiagnosis.Name = "LabelDiagnosis"
        Me.LabelDiagnosis.Size = New System.Drawing.Size(59, 13)
        Me.LabelDiagnosis.TabIndex = 58
        Me.LabelDiagnosis.Text = "Diagnosis :"
        '
        'Diagnosistxt
        '
        Me.Diagnosistxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Diagnosistxt.Location = New System.Drawing.Point(480, 18)
        Me.Diagnosistxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Diagnosistxt.Name = "Diagnosistxt"
        Me.Diagnosistxt.Size = New System.Drawing.Size(212, 20)
        Me.Diagnosistxt.TabIndex = 82
        '
        'TreatmentPlantxt
        '
        Me.TreatmentPlantxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreatmentPlantxt.Location = New System.Drawing.Point(864, 18)
        Me.TreatmentPlantxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TreatmentPlantxt.Name = "TreatmentPlantxt"
        Me.TreatmentPlantxt.Size = New System.Drawing.Size(141, 20)
        Me.TreatmentPlantxt.TabIndex = 80
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(412, 67)
        Me.butAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(64, 20)
        Me.butAdd.TabIndex = 68
        Me.butAdd.Text = "ADD"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'LabelTreatmentPlan
        '
        Me.LabelTreatmentPlan.AutoSize = True
        Me.LabelTreatmentPlan.Location = New System.Drawing.Point(783, 20)
        Me.LabelTreatmentPlan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTreatmentPlan.Name = "LabelTreatmentPlan"
        Me.LabelTreatmentPlan.Size = New System.Drawing.Size(82, 13)
        Me.LabelTreatmentPlan.TabIndex = 79
        Me.LabelTreatmentPlan.Text = "TreatmentPlan :"
        '
        'butEdit
        '
        Me.butEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.butEdit.Location = New System.Drawing.Point(508, 67)
        Me.butEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butEdit.Name = "butEdit"
        Me.butEdit.Size = New System.Drawing.Size(64, 20)
        Me.butEdit.TabIndex = 69
        Me.butEdit.Text = "EDIT"
        Me.butEdit.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(601, 67)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(64, 20)
        Me.ButDelete.TabIndex = 70
        Me.ButDelete.Text = "DELETE"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 273)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1030, 300)
        Me.DataGridView1.TabIndex = 89
        '
        'LabelPatients
        '
        Me.LabelPatients.AutoSize = True
        Me.LabelPatients.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPatients.Location = New System.Drawing.Point(392, 29)
        Me.LabelPatients.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPatients.Name = "LabelPatients"
        Me.LabelPatients.Size = New System.Drawing.Size(0, 30)
        Me.LabelPatients.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(501, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 30)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "PATIENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(491, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Appointments"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.LabelWardID)
        Me.Panel3.Controls.Add(Me.WardIDtxt)
        Me.Panel3.Location = New System.Drawing.Point(659, 58)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 49)
        Me.Panel3.TabIndex = 92
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(274, 14)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 20)
        Me.TextBox3.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Ward Name :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(160, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 93
        Me.PictureBox2.TabStop = False
        '
        'Appointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelPatients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Appointments"
        Me.Text = "Appointments"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
End Class
