<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.LabelMedication.Location = New System.Drawing.Point(491, 9)
        Me.LabelMedication.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMedication.Name = "LabelMedication"
        Me.LabelMedication.Size = New System.Drawing.Size(145, 30)
        Me.LabelMedication.TabIndex = 0
        Me.LabelMedication.Text = "MEDICATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 295)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 271)
        Me.DataGridView1.TabIndex = 1
        '
        'LabelUnitperday
        '
        Me.LabelUnitperday.AutoSize = True
        Me.LabelUnitperday.Location = New System.Drawing.Point(57, 64)
        Me.LabelUnitperday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUnitperday.Name = "LabelUnitperday"
        Me.LabelUnitperday.Size = New System.Drawing.Size(73, 13)
        Me.LabelUnitperday.TabIndex = 3
        Me.LabelUnitperday.Text = "Unit Per Day :"
        '
        'LabelMedofadmin
        '
        Me.LabelMedofadmin.AutoSize = True
        Me.LabelMedofadmin.Location = New System.Drawing.Point(729, 10)
        Me.LabelMedofadmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMedofadmin.Name = "LabelMedofadmin"
        Me.LabelMedofadmin.Size = New System.Drawing.Size(76, 26)
        Me.LabelMedofadmin.TabIndex = 4
        Me.LabelMedofadmin.Text = "Method Of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adminstration :"
        '
        'LabelDrugnum
        '
        Me.LabelDrugnum.AutoSize = True
        Me.LabelDrugnum.Location = New System.Drawing.Point(388, 21)
        Me.LabelDrugnum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDrugnum.Name = "LabelDrugnum"
        Me.LabelDrugnum.Size = New System.Drawing.Size(76, 13)
        Me.LabelDrugnum.TabIndex = 5
        Me.LabelDrugnum.Text = "Drug Number :"
        '
        'LabelStartdate
        '
        Me.LabelStartdate.AutoSize = True
        Me.LabelStartdate.Location = New System.Drawing.Point(407, 64)
        Me.LabelStartdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelStartdate.Name = "LabelStartdate"
        Me.LabelStartdate.Size = New System.Drawing.Size(61, 13)
        Me.LabelStartdate.TabIndex = 6
        Me.LabelStartdate.Text = "Start Date :"
        '
        'LabelPatientsID
        '
        Me.LabelPatientsID.AutoSize = True
        Me.LabelPatientsID.Location = New System.Drawing.Point(94, 20)
        Me.LabelPatientsID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPatientsID.Name = "LabelPatientsID"
        Me.LabelPatientsID.Size = New System.Drawing.Size(60, 13)
        Me.LabelPatientsID.TabIndex = 7
        Me.LabelPatientsID.Text = "Patient ID :"
        '
        'LabelDrugname
        '
        Me.LabelDrugname.AutoSize = True
        Me.LabelDrugname.Location = New System.Drawing.Point(60, 18)
        Me.LabelDrugname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDrugname.Name = "LabelDrugname"
        Me.LabelDrugname.Size = New System.Drawing.Size(67, 13)
        Me.LabelDrugname.TabIndex = 8
        Me.LabelDrugname.Text = "Drug Name :"
        '
        'LabelEnddate
        '
        Me.LabelEnddate.AutoSize = True
        Me.LabelEnddate.Location = New System.Drawing.Point(754, 63)
        Me.LabelEnddate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEnddate.Name = "LabelEnddate"
        Me.LabelEnddate.Size = New System.Drawing.Size(58, 13)
        Me.LabelEnddate.TabIndex = 9
        Me.LabelEnddate.Text = "End Date :"
        '
        'DrugNum
        '
        Me.DrugNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrugNum.Location = New System.Drawing.Point(467, 17)
        Me.DrugNum.Margin = New System.Windows.Forms.Padding(2)
        Me.DrugNum.Name = "DrugNum"
        Me.DrugNum.Size = New System.Drawing.Size(178, 20)
        Me.DrugNum.TabIndex = 14
        '
        'PatientID
        '
        Me.PatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientID.Location = New System.Drawing.Point(159, 17)
        Me.PatientID.Margin = New System.Windows.Forms.Padding(2)
        Me.PatientID.Multiline = True
        Me.PatientID.Name = "PatientID"
        Me.PatientID.Size = New System.Drawing.Size(133, 20)
        Me.PatientID.TabIndex = 16
        '
        'DrugName
        '
        Me.DrugName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrugName.Location = New System.Drawing.Point(129, 16)
        Me.DrugName.Margin = New System.Windows.Forms.Padding(2)
        Me.DrugName.Name = "DrugName"
        Me.DrugName.Size = New System.Drawing.Size(130, 20)
        Me.DrugName.TabIndex = 17
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(822, 59)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(168, 20)
        Me.EndDate.TabIndex = 21
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonAdd.Location = New System.Drawing.Point(450, 263)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(64, 20)
        Me.ButtonAdd.TabIndex = 22
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ButtonEdit.Location = New System.Drawing.Point(544, 264)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(64, 20)
        Me.ButtonEdit.TabIndex = 23
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'buttonDelete
        '
        Me.buttonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.buttonDelete.Location = New System.Drawing.Point(635, 264)
        Me.buttonDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(64, 20)
        Me.buttonDelete.TabIndex = 24
        Me.buttonDelete.Text = "DELETE"
        Me.buttonDelete.UseVisualStyleBackColor = False
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearch.Location = New System.Drawing.Point(867, 264)
        Me.txtBoxSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(133, 20)
        Me.txtBoxSearch.TabIndex = 54
        '
        'btnsearchmed
        '
        Me.btnsearchmed.Image = CType(resources.GetObject("btnsearchmed.Image"), System.Drawing.Image)
        Me.btnsearchmed.Location = New System.Drawing.Point(1005, 264)
        Me.btnsearchmed.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearchmed.Name = "btnsearchmed"
        Me.btnsearchmed.Size = New System.Drawing.Size(34, 24)
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
        Me.SearchStaffMed.Location = New System.Drawing.Point(28, 44)
        Me.SearchStaffMed.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchStaffMed.Name = "SearchStaffMed"
        Me.SearchStaffMed.Size = New System.Drawing.Size(545, 88)
        Me.SearchStaffMed.TabIndex = 56
        '
        'txtPatienLastname
        '
        Me.txtPatienLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatienLastname.Location = New System.Drawing.Point(392, 55)
        Me.txtPatienLastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPatienLastname.Name = "txtPatienLastname"
        Me.txtPatienLastname.Size = New System.Drawing.Size(133, 20)
        Me.txtPatienLastname.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Patient Lastname :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(296, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'txt_PatienName
        '
        Me.txt_PatienName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PatienName.Location = New System.Drawing.Point(159, 54)
        Me.txt_PatienName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_PatienName.Name = "txt_PatienName"
        Me.txt_PatienName.Size = New System.Drawing.Size(133, 20)
        Me.txt_PatienName.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Patient Name :"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(222, 13)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 63
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Staff Name :"
        '
        'SearchStaffNamebox
        '
        Me.SearchStaffNamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchStaffNamebox.Location = New System.Drawing.Point(83, 53)
        Me.SearchStaffNamebox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchStaffNamebox.Name = "SearchStaffNamebox"
        Me.SearchStaffNamebox.Size = New System.Drawing.Size(133, 20)
        Me.SearchStaffNamebox.TabIndex = 63
        '
        'Stafftxtboxmed
        '
        Me.Stafftxtboxmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Stafftxtboxmed.Location = New System.Drawing.Point(83, 13)
        Me.Stafftxtboxmed.Margin = New System.Windows.Forms.Padding(2)
        Me.Stafftxtboxmed.Name = "Stafftxtboxmed"
        Me.Stafftxtboxmed.Size = New System.Drawing.Size(133, 20)
        Me.Stafftxtboxmed.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
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
        Me.Panel2.Location = New System.Drawing.Point(28, 147)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 104)
        Me.Panel2.TabIndex = 58
        '
        'updtxt
        '
        Me.updtxt.FormattingEnabled = True
        Me.updtxt.Location = New System.Drawing.Point(129, 62)
        Me.updtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.updtxt.Name = "updtxt"
        Me.updtxt.Size = New System.Drawing.Size(131, 21)
        Me.updtxt.TabIndex = 61
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(264, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'Pickdatestart
        '
        Me.Pickdatestart.Location = New System.Drawing.Point(467, 63)
        Me.Pickdatestart.Margin = New System.Windows.Forms.Padding(2)
        Me.Pickdatestart.Name = "Pickdatestart"
        Me.Pickdatestart.Size = New System.Drawing.Size(178, 20)
        Me.Pickdatestart.TabIndex = 24
        '
        'Methee
        '
        Me.Methee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Methee.Location = New System.Drawing.Point(822, 19)
        Me.Methee.Margin = New System.Windows.Forms.Padding(2)
        Me.Methee.Name = "Methee"
        Me.Methee.Size = New System.Drawing.Size(168, 20)
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
        Me.Panel1.Location = New System.Drawing.Point(577, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 89)
        Me.Panel1.TabIndex = 65
        '
        'txtStaffLastname
        '
        Me.txtStaffLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStaffLastname.Location = New System.Drawing.Point(308, 54)
        Me.txtStaffLastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStaffLastname.Name = "txtStaffLastname"
        Me.txtStaffLastname.Size = New System.Drawing.Size(133, 20)
        Me.txtStaffLastname.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Staff Lastname :"
        '
        'txtIDEdit
        '
        Me.txtIDEdit.Location = New System.Drawing.Point(157, 263)
        Me.txtIDEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDEdit.Name = "txtIDEdit"
        Me.txtIDEdit.Size = New System.Drawing.Size(86, 20)
        Me.txtIDEdit.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Medication ID :"
        '
        'Medication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Medication"
        Me.Text = "7"
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
End Class
