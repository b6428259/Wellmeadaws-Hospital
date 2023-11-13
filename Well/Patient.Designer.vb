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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient))
        Me.LabelPatients = New System.Windows.Forms.Label()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelLastname = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelDateofbirth = New System.Windows.Forms.Label()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelRegdate = New System.Windows.Forms.Label()
        Me.txtboxAddress = New System.Windows.Forms.TextBox()
        Me.txtboxLastname = New System.Windows.Forms.TextBox()
        Me.TextBoxMarittal = New System.Windows.Forms.TextBox()
        Me.TxtBoxTel = New System.Windows.Forms.TextBox()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.butEdit = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtBoxSex = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDob = New System.Windows.Forms.DateTimePicker()
        Me.TxtBoxRegisDate = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchpatient = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnsearchpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPatients
        '
        Me.LabelPatients.AutoSize = True
        Me.LabelPatients.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPatients.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelPatients.Location = New System.Drawing.Point(498, 9)
        Me.LabelPatients.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPatients.Name = "LabelPatients"
        Me.LabelPatients.Size = New System.Drawing.Size(110, 30)
        Me.LabelPatients.TabIndex = 0
        Me.LabelPatients.Text = "PATIENTS"
        '
        'txtboxName
        '
        Me.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxName.Location = New System.Drawing.Point(74, 24)
        Me.txtboxName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(156, 20)
        Me.txtboxName.TabIndex = 2
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(22, 27)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(41, 13)
        Me.LabelName.TabIndex = 3
        Me.LabelName.Text = "Name :"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(22, 70)
        Me.LabelAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(51, 13)
        Me.LabelAddress.TabIndex = 4
        Me.LabelAddress.Text = "Address :"
        '
        'LabelLastname
        '
        Me.LabelLastname.AutoSize = True
        Me.LabelLastname.Location = New System.Drawing.Point(298, 28)
        Me.LabelLastname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLastname.Name = "LabelLastname"
        Me.LabelLastname.Size = New System.Drawing.Size(59, 13)
        Me.LabelLastname.TabIndex = 5
        Me.LabelLastname.Text = "Lastname :"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(277, 70)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(77, 13)
        Me.LabelStatus.TabIndex = 6
        Me.LabelStatus.Text = "Marital Status :"
        '
        'LabelDateofbirth
        '
        Me.LabelDateofbirth.AutoSize = True
        Me.LabelDateofbirth.Location = New System.Drawing.Point(532, 29)
        Me.LabelDateofbirth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDateofbirth.Name = "LabelDateofbirth"
        Me.LabelDateofbirth.Size = New System.Drawing.Size(72, 13)
        Me.LabelDateofbirth.TabIndex = 7
        Me.LabelDateofbirth.Text = "Date of Birth :"
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Location = New System.Drawing.Point(577, 73)
        Me.LabelTel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(28, 13)
        Me.LabelTel.TabIndex = 8
        Me.LabelTel.Text = "Tel :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(846, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sex :"
        '
        'LabelRegdate
        '
        Me.LabelRegdate.AutoSize = True
        Me.LabelRegdate.Location = New System.Drawing.Point(784, 74)
        Me.LabelRegdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRegdate.Name = "LabelRegdate"
        Me.LabelRegdate.Size = New System.Drawing.Size(95, 13)
        Me.LabelRegdate.TabIndex = 10
        Me.LabelRegdate.Text = "Registration Date :"
        '
        'txtboxAddress
        '
        Me.txtboxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxAddress.Location = New System.Drawing.Point(74, 68)
        Me.txtboxAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxAddress.Multiline = True
        Me.txtboxAddress.Name = "txtboxAddress"
        Me.txtboxAddress.Size = New System.Drawing.Size(156, 79)
        Me.txtboxAddress.TabIndex = 11
        '
        'txtboxLastname
        '
        Me.txtboxLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxLastname.Location = New System.Drawing.Point(362, 23)
        Me.txtboxLastname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxLastname.Name = "txtboxLastname"
        Me.txtboxLastname.Size = New System.Drawing.Size(134, 20)
        Me.txtboxLastname.TabIndex = 12
        '
        'TextBoxMarittal
        '
        Me.TextBoxMarittal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxMarittal.Location = New System.Drawing.Point(362, 66)
        Me.TextBoxMarittal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBoxMarittal.Name = "TextBoxMarittal"
        Me.TextBoxMarittal.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxMarittal.TabIndex = 13
        '
        'TxtBoxTel
        '
        Me.TxtBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBoxTel.Location = New System.Drawing.Point(605, 70)
        Me.TxtBoxTel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtBoxTel.Name = "TxtBoxTel"
        Me.TxtBoxTel.Size = New System.Drawing.Size(123, 20)
        Me.TxtBoxTel.TabIndex = 15
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(427, 229)
        Me.butAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(64, 20)
        Me.butAdd.TabIndex = 21
        Me.butAdd.Text = "ADD"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'butEdit
        '
        Me.butEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.butEdit.Location = New System.Drawing.Point(523, 229)
        Me.butEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butEdit.Name = "butEdit"
        Me.butEdit.Size = New System.Drawing.Size(64, 20)
        Me.butEdit.TabIndex = 22
        Me.butEdit.Text = "EDIT"
        Me.butEdit.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(616, 229)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(64, 20)
        Me.ButDelete.TabIndex = 23
        Me.ButDelete.Text = "DELETE"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(44, 260)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(992, 312)
        Me.DataGridView1.TabIndex = 24
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearch.Location = New System.Drawing.Point(879, 231)
        Me.txtBoxSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxSearch.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtBoxSex)
        Me.Panel1.Controls.Add(Me.DateTimePickerDob)
        Me.Panel1.Controls.Add(Me.TxtBoxRegisDate)
        Me.Panel1.Controls.Add(Me.txtboxAddress)
        Me.Panel1.Controls.Add(Me.txtboxName)
        Me.Panel1.Controls.Add(Me.LabelName)
        Me.Panel1.Controls.Add(Me.LabelAddress)
        Me.Panel1.Controls.Add(Me.txtboxLastname)
        Me.Panel1.Controls.Add(Me.LabelLastname)
        Me.Panel1.Controls.Add(Me.LabelStatus)
        Me.Panel1.Controls.Add(Me.TextBoxMarittal)
        Me.Panel1.Controls.Add(Me.LabelDateofbirth)
        Me.Panel1.Controls.Add(Me.LabelRegdate)
        Me.Panel1.Controls.Add(Me.LabelTel)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtBoxTel)
        Me.Panel1.Location = New System.Drawing.Point(34, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 157)
        Me.Panel1.TabIndex = 53
        '
        'TxtBoxSex
        '
        Me.TxtBoxSex.FormattingEnabled = True
        Me.TxtBoxSex.Items.AddRange(New Object() {"M", "F"})
        Me.TxtBoxSex.Location = New System.Drawing.Point(882, 26)
        Me.TxtBoxSex.Name = "TxtBoxSex"
        Me.TxtBoxSex.Size = New System.Drawing.Size(82, 21)
        Me.TxtBoxSex.TabIndex = 51
        '
        'DateTimePickerDob
        '
        Me.DateTimePickerDob.Location = New System.Drawing.Point(605, 24)
        Me.DateTimePickerDob.Name = "DateTimePickerDob"
        Me.DateTimePickerDob.Size = New System.Drawing.Size(123, 20)
        Me.DateTimePickerDob.TabIndex = 50
        '
        'TxtBoxRegisDate
        '
        Me.TxtBoxRegisDate.CustomFormat = "yyyy-MM-dd"
        Me.TxtBoxRegisDate.Location = New System.Drawing.Point(879, 70)
        Me.TxtBoxRegisDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtBoxRegisDate.Name = "TxtBoxRegisDate"
        Me.TxtBoxRegisDate.Size = New System.Drawing.Size(89, 20)
        Me.TxtBoxRegisDate.TabIndex = 49
        '
        'btnsearchpatient
        '
        Me.btnsearchpatient.Image = CType(resources.GetObject("btnsearchpatient.Image"), System.Drawing.Image)
        Me.btnsearchpatient.Location = New System.Drawing.Point(1008, 230)
        Me.btnsearchpatient.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearchpatient.Name = "btnsearchpatient"
        Me.btnsearchpatient.Size = New System.Drawing.Size(31, 23)
        Me.btnsearchpatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchpatient.TabIndex = 69
        Me.btnsearchpatient.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(56, 231)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 20)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "OUT PATIENTS LIST"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(179, 231)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 20)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "PATIENTS IN WARD"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsearchpatient)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBoxSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.butEdit)
        Me.Controls.Add(Me.butAdd)
        Me.Controls.Add(Me.LabelPatients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Patient"
        Me.Text = "Patient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnsearchpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents butAdd As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents ButDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearchpatient As PictureBox
    Friend WithEvents TxtBoxRegisDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePickerDob As DateTimePicker
    Friend WithEvents TxtBoxSex As ComboBox
End Class
