<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Patient))
        LabelPatients = New Label()
        txtboxName = New TextBox()
        LabelName = New Label()
        LabelAddress = New Label()
        LabelLastname = New Label()
        LabelStatus = New Label()
        LabelDateofbirth = New Label()
        LabelTel = New Label()
        Label7 = New Label()
        LabelRegdate = New Label()
        txtboxAddress = New TextBox()
        txtboxLastname = New TextBox()
        TextBoxMarittal = New TextBox()
        TxtBoxTel = New TextBox()
        TxtBoxSex = New TextBox()
        butAdd = New Button()
        butEdit = New Button()
        ButDelete = New Button()
        DataGridView1 = New DataGridView()
        TextBoxDoB = New TextBox()
        txtBoxSearch = New TextBox()
        Panel1 = New Panel()
        TxtBoxRegisDate = New DateTimePicker()
        btnsearchpatient = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnsearchpatient, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelPatients
        ' 
        LabelPatients.AutoSize = True
        LabelPatients.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPatients.ForeColor = SystemColors.WindowText
        LabelPatients.Location = New Point(561, 12)
        LabelPatients.Name = "LabelPatients"
        LabelPatients.Size = New Size(140, 37)
        LabelPatients.TabIndex = 0
        LabelPatients.Text = "PATIENTS"
        ' 
        ' txtboxName
        ' 
        txtboxName.BorderStyle = BorderStyle.FixedSingle
        txtboxName.Location = New Point(98, 37)
        txtboxName.Margin = New Padding(3, 4, 3, 4)
        txtboxName.Name = "txtboxName"
        txtboxName.Size = New Size(151, 27)
        txtboxName.TabIndex = 2
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(29, 41)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(56, 20)
        LabelName.TabIndex = 3
        LabelName.Text = "Name :"
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Location = New Point(29, 108)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(69, 20)
        LabelAddress.TabIndex = 4
        LabelAddress.Text = "Address :"
        ' 
        ' LabelLastname
        ' 
        LabelLastname.AutoSize = True
        LabelLastname.Location = New Point(358, 45)
        LabelLastname.Name = "LabelLastname"
        LabelLastname.Size = New Size(79, 20)
        LabelLastname.TabIndex = 5
        LabelLastname.Text = "Lastname :"
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Location = New Point(329, 109)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(107, 20)
        LabelStatus.TabIndex = 6
        LabelStatus.Text = "Marital Status :"
        ' 
        ' LabelDateofbirth
        ' 
        LabelDateofbirth.AutoSize = True
        LabelDateofbirth.Location = New Point(606, 45)
        LabelDateofbirth.Name = "LabelDateofbirth"
        LabelDateofbirth.Size = New Size(101, 20)
        LabelDateofbirth.TabIndex = 7
        LabelDateofbirth.Text = "Date of Birth :"
        ' 
        ' LabelTel
        ' 
        LabelTel.AutoSize = True
        LabelTel.Location = New Point(665, 112)
        LabelTel.Name = "LabelTel"
        LabelTel.Size = New Size(35, 20)
        LabelTel.TabIndex = 8
        LabelTel.Text = "Tel :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(962, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 20)
        Label7.TabIndex = 9
        Label7.Text = "Sex :"
        ' 
        ' LabelRegdate
        ' 
        LabelRegdate.AutoSize = True
        LabelRegdate.Location = New Point(880, 111)
        LabelRegdate.Name = "LabelRegdate"
        LabelRegdate.Size = New Size(132, 20)
        LabelRegdate.TabIndex = 10
        LabelRegdate.Text = "Registration Date :"
        ' 
        ' txtboxAddress
        ' 
        txtboxAddress.BorderStyle = BorderStyle.FixedSingle
        txtboxAddress.Location = New Point(98, 105)
        txtboxAddress.Margin = New Padding(3, 4, 3, 4)
        txtboxAddress.Multiline = True
        txtboxAddress.Name = "txtboxAddress"
        txtboxAddress.Size = New Size(207, 121)
        txtboxAddress.TabIndex = 11
        ' 
        ' txtboxLastname
        ' 
        txtboxLastname.BorderStyle = BorderStyle.FixedSingle
        txtboxLastname.Location = New Point(442, 37)
        txtboxLastname.Margin = New Padding(3, 4, 3, 4)
        txtboxLastname.Name = "txtboxLastname"
        txtboxLastname.Size = New Size(125, 27)
        txtboxLastname.TabIndex = 12
        ' 
        ' TextBoxMarittal
        ' 
        TextBoxMarittal.BorderStyle = BorderStyle.FixedSingle
        TextBoxMarittal.Location = New Point(442, 103)
        TextBoxMarittal.Margin = New Padding(3, 4, 3, 4)
        TextBoxMarittal.Name = "TextBoxMarittal"
        TextBoxMarittal.Size = New Size(125, 27)
        TextBoxMarittal.TabIndex = 13
        ' 
        ' TxtBoxTel
        ' 
        TxtBoxTel.BorderStyle = BorderStyle.FixedSingle
        TxtBoxTel.Location = New Point(703, 107)
        TxtBoxTel.Margin = New Padding(3, 4, 3, 4)
        TxtBoxTel.Name = "TxtBoxTel"
        TxtBoxTel.Size = New Size(163, 27)
        TxtBoxTel.TabIndex = 15
        ' 
        ' TxtBoxSex
        ' 
        TxtBoxSex.BorderStyle = BorderStyle.FixedSingle
        TxtBoxSex.Location = New Point(1007, 39)
        TxtBoxSex.Margin = New Padding(3, 4, 3, 4)
        TxtBoxSex.Name = "TxtBoxSex"
        TxtBoxSex.Size = New Size(109, 27)
        TxtBoxSex.TabIndex = 16
        ' 
        ' butAdd
        ' 
        butAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        butAdd.Location = New Point(457, 335)
        butAdd.Margin = New Padding(3, 4, 3, 4)
        butAdd.Name = "butAdd"
        butAdd.Size = New Size(86, 31)
        butAdd.TabIndex = 21
        butAdd.Text = "ADD"
        butAdd.UseVisualStyleBackColor = False
        ' 
        ' butEdit
        ' 
        butEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        butEdit.Location = New Point(585, 335)
        butEdit.Margin = New Padding(3, 4, 3, 4)
        butEdit.Name = "butEdit"
        butEdit.Size = New Size(86, 31)
        butEdit.TabIndex = 22
        butEdit.Text = "EDIT"
        butEdit.UseVisualStyleBackColor = False
        ' 
        ' ButDelete
        ' 
        ButDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        ButDelete.Location = New Point(709, 335)
        ButDelete.Margin = New Padding(3, 4, 3, 4)
        ButDelete.Name = "ButDelete"
        ButDelete.Size = New Size(86, 31)
        ButDelete.TabIndex = 23
        ButDelete.Text = "DELETE"
        ButDelete.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(59, 400)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1147, 291)
        DataGridView1.TabIndex = 24
        ' 
        ' TextBoxDoB
        ' 
        TextBoxDoB.BorderStyle = BorderStyle.FixedSingle
        TextBoxDoB.Location = New Point(703, 43)
        TextBoxDoB.Margin = New Padding(3, 4, 3, 4)
        TextBoxDoB.Name = "TextBoxDoB"
        TextBoxDoB.Size = New Size(163, 27)
        TextBoxDoB.TabIndex = 48
        ' 
        ' txtBoxSearch
        ' 
        txtBoxSearch.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearch.Location = New Point(997, 351)
        txtBoxSearch.Margin = New Padding(3, 4, 3, 4)
        txtBoxSearch.Name = "txtBoxSearch"
        txtBoxSearch.Size = New Size(165, 27)
        txtBoxSearch.TabIndex = 52
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TxtBoxRegisDate)
        Panel1.Controls.Add(txtboxAddress)
        Panel1.Controls.Add(txtboxName)
        Panel1.Controls.Add(LabelName)
        Panel1.Controls.Add(LabelAddress)
        Panel1.Controls.Add(txtboxLastname)
        Panel1.Controls.Add(TextBoxDoB)
        Panel1.Controls.Add(LabelLastname)
        Panel1.Controls.Add(LabelStatus)
        Panel1.Controls.Add(TextBoxMarittal)
        Panel1.Controls.Add(TxtBoxSex)
        Panel1.Controls.Add(LabelDateofbirth)
        Panel1.Controls.Add(LabelRegdate)
        Panel1.Controls.Add(LabelTel)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TxtBoxTel)
        Panel1.Location = New Point(45, 71)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1175, 241)
        Panel1.TabIndex = 53
        ' 
        ' TxtBoxRegisDate
        ' 
        TxtBoxRegisDate.CustomFormat = "yyyy-MM-dd"
        TxtBoxRegisDate.Location = New Point(1007, 104)
        TxtBoxRegisDate.Margin = New Padding(3, 4, 3, 4)
        TxtBoxRegisDate.Name = "TxtBoxRegisDate"
        TxtBoxRegisDate.Size = New Size(117, 27)
        TxtBoxRegisDate.TabIndex = 49
        ' 
        ' btnsearchpatient
        ' 
        btnsearchpatient.Image = CType(resources.GetObject("btnsearchpatient.Image"), Image)
        btnsearchpatient.Location = New Point(1169, 349)
        btnsearchpatient.Margin = New Padding(3, 4, 3, 4)
        btnsearchpatient.Name = "btnsearchpatient"
        btnsearchpatient.Size = New Size(41, 36)
        btnsearchpatient.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchpatient.TabIndex = 69
        btnsearchpatient.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        Button1.Location = New Point(74, 355)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 31)
        Button1.TabIndex = 70
        Button1.Text = "OUT PATIENTS LIST"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        Button2.Location = New Point(239, 355)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 31)
        Button2.TabIndex = 71
        Button2.Text = "PATIENTS IN WARD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Patient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1266, 709)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnsearchpatient)
        Controls.Add(Panel1)
        Controls.Add(txtBoxSearch)
        Controls.Add(DataGridView1)
        Controls.Add(ButDelete)
        Controls.Add(butEdit)
        Controls.Add(butAdd)
        Controls.Add(LabelPatients)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Patient"
        Text = "Patient"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnsearchpatient, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelPatients As Label
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelLastname As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelDateofbirth As Label
    Friend WithEvents LabelTel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelRegdate As Label
    Friend WithEvents txtboxAddress As TextBox
    Friend WithEvents txtboxLastname As TextBox
    Friend WithEvents TextBoxMarittal As TextBox
    Friend WithEvents TxtBoxTel As TextBox
    Friend WithEvents TxtBoxSex As TextBox
    Friend WithEvents butAdd As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents ButDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxDoB As TextBox
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearchpatient As PictureBox
    Friend WithEvents TxtBoxRegisDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
