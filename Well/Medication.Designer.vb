<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medication))
        Me.LabelMedication = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelUnitperday = New System.Windows.Forms.Label()
        Me.LabelMedofadmin = New System.Windows.Forms.Label()
        Me.LabelDrugnum = New System.Windows.Forms.Label()
        Me.LabelStartdate = New System.Windows.Forms.Label()
        Me.LabelPatientsID = New System.Windows.Forms.Label()
        Me.LabelDrugname = New System.Windows.Forms.Label()
        Me.LabelEnddate = New System.Windows.Forms.Label()
        Me.DrugNum = New System.Windows.Forms.TextBox()
        Me.PatientID = New System.Windows.Forms.TextBox()
        Me.DrugName = New System.Windows.Forms.TextBox()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.btnsearchmed = New System.Windows.Forms.PictureBox()
        Me.SearchStaffMed = New System.Windows.Forms.Panel()
        Me.txtPatienLastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_PatienName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchStaffNamebox = New System.Windows.Forms.TextBox()
        Me.Stafftxtboxmed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.updtxt = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Pickdatestart = New System.Windows.Forms.DateTimePicker()
        Me.Methee = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtStaffLastname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDEdit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearchmed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchStaffMed.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMedication
        '
        Me.LabelMedication.AutoSize = True
        Me.LabelMedication.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelMedication.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelMedication.Location = New System.Drawing.Point(553, 10)
        Me.LabelMedication.Name = "LabelMedication"
        Me.LabelMedication.Size = New System.Drawing.Size(186, 37)
        Me.LabelMedication.TabIndex = 0
        Me.LabelMedication.Text = "MEDICATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 363)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1111, 224)
        Me.DataGridView1.TabIndex = 1
        '
        'LabelUnitperday
        '
        Me.LabelUnitperday.AutoSize = True
        Me.LabelUnitperday.Location = New System.Drawing.Point(29, 80)
        Me.LabelUnitperday.Name = "LabelUnitperday"
        Me.LabelUnitperday.Size = New System.Drawing.Size(88, 16)
        Me.LabelUnitperday.TabIndex = 3
        Me.LabelUnitperday.Text = "Unit Per Day :"
        '
        'LabelMedofadmin
        '
        Me.LabelMedofadmin.AutoSize = True
        Me.LabelMedofadmin.Location = New System.Drawing.Point(743, 14)
        Me.LabelMedofadmin.Name = "LabelMedofadmin"
        Me.LabelMedofadmin.Size = New System.Drawing.Size(94, 32)
        Me.LabelMedofadmin.TabIndex = 4
        Me.LabelMedofadmin.Text = "Method Of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adminstration :"
        '
        'LabelDrugnum
        '
        Me.LabelDrugnum.AutoSize = True
        Me.LabelDrugnum.Location = New System.Drawing.Point(383, 26)
        Me.LabelDrugnum.Name = "LabelDrugnum"
        Me.LabelDrugnum.Size = New System.Drawing.Size(93, 16)
        Me.LabelDrugnum.TabIndex = 5
        Me.LabelDrugnum.Text = "Drug Number :"
        '
        'LabelStartdate
        '
        Me.LabelStartdate.AutoSize = True
        Me.LabelStartdate.Location = New System.Drawing.Point(408, 79)
        Me.LabelStartdate.Name = "LabelStartdate"
        Me.LabelStartdate.Size = New System.Drawing.Size(72, 16)
        Me.LabelStartdate.TabIndex = 6
        Me.LabelStartdate.Text = "Start Date :"
        '
        'LabelPatientsID
        '
        Me.LabelPatientsID.AutoSize = True
        Me.LabelPatientsID.Location = New System.Drawing.Point(352, 22)
        Me.LabelPatientsID.Name = "LabelPatientsID"
        Me.LabelPatientsID.Size = New System.Drawing.Size(70, 16)
        Me.LabelPatientsID.TabIndex = 7
        Me.LabelPatientsID.Text = "Patient ID :"
        '
        'LabelDrugname
        '
        Me.LabelDrugname.AutoSize = True
        Me.LabelDrugname.Location = New System.Drawing.Point(33, 23)
        Me.LabelDrugname.Name = "LabelDrugname"
        Me.LabelDrugname.Size = New System.Drawing.Size(82, 16)
        Me.LabelDrugname.TabIndex = 8
        Me.LabelDrugname.Text = "Drug Name :"
        '
        'LabelEnddate
        '
        Me.LabelEnddate.AutoSize = True
        Me.LabelEnddate.Location = New System.Drawing.Point(776, 79)
        Me.LabelEnddate.Name = "LabelEnddate"
        Me.LabelEnddate.Size = New System.Drawing.Size(69, 16)
        Me.LabelEnddate.TabIndex = 9
        Me.LabelEnddate.Text = "End Date :"
        '
        'DrugNum
        '
        Me.DrugNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrugNum.Location = New System.Drawing.Point(488, 21)
        Me.DrugNum.Name = "DrugNum"
        Me.DrugNum.Size = New System.Drawing.Size(236, 22)
        Me.DrugNum.TabIndex = 14
        '
        'PatientID
        '
        Me.PatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientID.Location = New System.Drawing.Point(432, 19)
        Me.PatientID.Multiline = True
        Me.PatientID.Name = "PatientID"
        Me.PatientID.Size = New System.Drawing.Size(111, 24)
        Me.PatientID.TabIndex = 16
        '
        'DrugName
        '
        Me.DrugName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrugName.Location = New System.Drawing.Point(125, 21)
        Me.DrugName.Name = "DrugName"
        Me.DrugName.Size = New System.Drawing.Size(173, 22)
        Me.DrugName.TabIndex = 17
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(851, 73)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(223, 22)
        Me.EndDate.TabIndex = 21
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonAdd.Location = New System.Drawing.Point(177, 325)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(86, 25)
        Me.ButtonAdd.TabIndex = 22
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ButtonEdit.Location = New System.Drawing.Point(587, 325)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(86, 25)
        Me.ButtonEdit.TabIndex = 23
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'buttonDelete
        '
        Me.buttonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.buttonDelete.Location = New System.Drawing.Point(758, 325)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(86, 25)
        Me.buttonDelete.TabIndex = 24
        Me.buttonDelete.Text = "DELETE"
        Me.buttonDelete.UseVisualStyleBackColor = False
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearch.Location = New System.Drawing.Point(920, 321)
        Me.txtBoxSearch.Multiline = True
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(177, 29)
        Me.txtBoxSearch.TabIndex = 54
        '
        'btnsearchmed
        '
        Me.btnsearchmed.Image = CType(resources.GetObject("btnsearchmed.Image"), System.Drawing.Image)
        Me.btnsearchmed.Location = New System.Drawing.Point(1104, 321)
        Me.btnsearchmed.Name = "btnsearchmed"
        Me.btnsearchmed.Size = New System.Drawing.Size(45, 29)
        Me.btnsearchmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchmed.TabIndex = 55
        Me.btnsearchmed.TabStop = False
        '
        'SearchStaffMed
        '
        Me.SearchStaffMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchStaffMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchStaffMed.Controls.Add(Me.txtPatienLastname)
        Me.SearchStaffMed.Controls.Add(Me.Label4)
        Me.SearchStaffMed.Controls.Add(Me.PictureBox1)
        Me.SearchStaffMed.Controls.Add(Me.txt_PatienName)
        Me.SearchStaffMed.Controls.Add(Me.Label1)
        Me.SearchStaffMed.Controls.Add(Me.PatientID)
        Me.SearchStaffMed.Controls.Add(Me.LabelPatientsID)
        Me.SearchStaffMed.Location = New System.Drawing.Point(38, 54)
        Me.SearchStaffMed.Name = "SearchStaffMed"
        Me.SearchStaffMed.Size = New System.Drawing.Size(573, 108)
        Me.SearchStaffMed.TabIndex = 56
        '
        'txtPatienLastname
        '
        Me.txtPatienLastname.Location = New System.Drawing.Point(152, 66)
        Me.txtPatienLastname.Name = "txtPatienLastname"
        Me.txtPatienLastname.Size = New System.Drawing.Size(141, 22)
        Me.txtPatienLastname.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Patient Lastname :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(301, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'txt_PatienName
        '
        Me.txt_PatienName.Location = New System.Drawing.Point(152, 19)
        Me.txt_PatienName.Name = "txt_PatienName"
        Me.txt_PatienName.Size = New System.Drawing.Size(141, 22)
        Me.txt_PatienName.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Patient Name :"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(278, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 63
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Staff Name :"
        '
        'SearchStaffNamebox
        '
        Me.SearchStaffNamebox.Location = New System.Drawing.Point(129, 25)
        Me.SearchStaffNamebox.Name = "SearchStaffNamebox"
        Me.SearchStaffNamebox.Size = New System.Drawing.Size(141, 22)
        Me.SearchStaffNamebox.TabIndex = 63
        '
        'Stafftxtboxmed
        '
        Me.Stafftxtboxmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Stafftxtboxmed.Location = New System.Drawing.Point(393, 25)
        Me.Stafftxtboxmed.Name = "Stafftxtboxmed"
        Me.Stafftxtboxmed.Size = New System.Drawing.Size(111, 22)
        Me.Stafftxtboxmed.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Staff ID :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.updtxt)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Pickdatestart)
        Me.Panel2.Controls.Add(Me.Methee)
        Me.Panel2.Controls.Add(Me.LabelUnitperday)
        Me.Panel2.Controls.Add(Me.LabelMedofadmin)
        Me.Panel2.Controls.Add(Me.DrugNum)
        Me.Panel2.Controls.Add(Me.EndDate)
        Me.Panel2.Controls.Add(Me.LabelDrugnum)
        Me.Panel2.Controls.Add(Me.LabelEnddate)
        Me.Panel2.Controls.Add(Me.LabelDrugname)
        Me.Panel2.Controls.Add(Me.LabelStartdate)
        Me.Panel2.Controls.Add(Me.DrugName)
        Me.Panel2.Location = New System.Drawing.Point(38, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1111, 128)
        Me.Panel2.TabIndex = 58
        '
        'updtxt
        '
        Me.updtxt.FormattingEnabled = True
        Me.updtxt.Location = New System.Drawing.Point(125, 77)
        Me.updtxt.Name = "updtxt"
        Me.updtxt.Size = New System.Drawing.Size(173, 24)
        Me.updtxt.TabIndex = 61
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(305, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'Pickdatestart
        '
        Me.Pickdatestart.Location = New System.Drawing.Point(488, 77)
        Me.Pickdatestart.Name = "Pickdatestart"
        Me.Pickdatestart.Size = New System.Drawing.Size(236, 22)
        Me.Pickdatestart.TabIndex = 24
        '
        'Methee
        '
        Me.Methee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Methee.Location = New System.Drawing.Point(851, 23)
        Me.Methee.Name = "Methee"
        Me.Methee.Size = New System.Drawing.Size(224, 22)
        Me.Methee.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtStaffLastname)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Stafftxtboxmed)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.SearchStaffNamebox)
        Me.Panel1.Location = New System.Drawing.Point(627, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 109)
        Me.Panel1.TabIndex = 65
        '
        'txtStaffLastname
        '
        Me.txtStaffLastname.Location = New System.Drawing.Point(129, 67)
        Me.txtStaffLastname.Name = "txtStaffLastname"
        Me.txtStaffLastname.Size = New System.Drawing.Size(141, 22)
        Me.txtStaffLastname.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Staff Lastname :"
        '
        'txtIDEdit
        '
        Me.txtIDEdit.Location = New System.Drawing.Point(466, 326)
        Me.txtIDEdit.Name = "txtIDEdit"
        Me.txtIDEdit.Size = New System.Drawing.Size(114, 22)
        Me.txtIDEdit.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Medication ID :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 25)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Medication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIDEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SearchStaffMed)
        Me.Controls.Add(Me.btnsearchmed)
        Me.Controls.Add(Me.txtBoxSearch)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelMedication)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medication"
        Me.Text = "Medication"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearchmed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchStaffMed.ResumeLayout(False)
        Me.SearchStaffMed.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMedication As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelMedID As Label
    Friend WithEvents LabelUnitperday As Label
    Friend WithEvents LabelMedofadmin As Label
    Friend WithEvents LabelDrugnum As Label
    Friend WithEvents LabelStartdate As Label
    Friend WithEvents LabelPatientsID As Label
    Friend WithEvents LabelDrugname As Label
    Friend WithEvents LabelEnddate As Label
    Friend WithEvents Methee As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DrugNum As TextBox
    Friend WithEvents PatientID As TextBox
    Friend WithEvents DrugName As TextBox
    Friend WithEvents Pickdatestart As DateTimePicker
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents btnsearchmed As PictureBox
    Friend WithEvents SearchStaffMed As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_PatienName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents updtxt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Stafftxtboxmed As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchStaffNamebox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPatienLastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStaffLastname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDEdit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
