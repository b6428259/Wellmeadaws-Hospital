<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Staff))
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtBoxNIN = New TextBox()
        ComboBoxSex2 = New ComboBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        txtBoxFirstname = New TextBox()
        txtBoxLastname = New TextBox()
        txtBoxSalary = New TextBox()
        txtBoxAddr = New TextBox()
        txtBoxPosit = New TextBox()
        txtBoxTele = New TextBox()
        txtBoxHPWNum = New TextBox()
        DataGridView1 = New DataGridView()
        txtboxsearch1 = New TextBox()
        Panel1 = New Panel()
        btnsearch = New PictureBox()
        txtboxsearch = New TextBox()
        BtnDelete = New Button()
        btnEdit = New Button()
        btnADD = New Button()
        Panel2 = New Panel()
        DateTimeB = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnsearch, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(601, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 32)
        Label1.TabIndex = 0
        Label1.Text = "STAFF"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 3
        Label3.Text = "Firstname :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 4
        Label4.Text = "Lastname :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 20)
        Label5.TabIndex = 5
        Label5.Text = "Sex :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(845, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 6
        Label6.Text = "NIN :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(833, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 20)
        Label7.TabIndex = 7
        Label7.Text = "Salary :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(410, 57)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 8
        Label8.Text = "Address :"
        ' 
        ' txtBoxNIN
        ' 
        txtBoxNIN.BorderStyle = BorderStyle.FixedSingle
        txtBoxNIN.Location = New Point(917, 239)
        txtBoxNIN.Margin = New Padding(3, 4, 3, 4)
        txtBoxNIN.Multiline = True
        txtBoxNIN.Name = "txtBoxNIN"
        txtBoxNIN.Size = New Size(163, 30)
        txtBoxNIN.TabIndex = 9
        ' 
        ' ComboBoxSex2
        ' 
        ComboBoxSex2.FormattingEnabled = True
        ComboBoxSex2.Items.AddRange(New Object() {"M", "F"})
        ComboBoxSex2.Location = New Point(109, 183)
        ComboBoxSex2.Margin = New Padding(3, 4, 3, 4)
        ComboBoxSex2.Name = "ComboBoxSex2"
        ComboBoxSex2.Size = New Size(114, 28)
        ComboBoxSex2.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(819, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 20)
        Label9.TabIndex = 11
        Label9.Text = "Position :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(397, 249)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 20)
        Label10.TabIndex = 12
        Label10.Text = "Telephone :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(383, 183)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 20)
        Label11.TabIndex = 13
        Label11.Text = "Date of Birth :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(773, 125)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 20)
        Label12.TabIndex = 14
        Label12.Text = "Hours Per Week :"
        ' 
        ' txtBoxFirstname
        ' 
        txtBoxFirstname.BorderStyle = BorderStyle.FixedSingle
        txtBoxFirstname.Location = New Point(109, 51)
        txtBoxFirstname.Margin = New Padding(3, 4, 3, 4)
        txtBoxFirstname.Multiline = True
        txtBoxFirstname.Name = "txtBoxFirstname"
        txtBoxFirstname.Size = New Size(146, 30)
        txtBoxFirstname.TabIndex = 15
        ' 
        ' txtBoxLastname
        ' 
        txtBoxLastname.BorderStyle = BorderStyle.FixedSingle
        txtBoxLastname.Location = New Point(109, 110)
        txtBoxLastname.Margin = New Padding(3, 4, 3, 4)
        txtBoxLastname.Name = "txtBoxLastname"
        txtBoxLastname.Size = New Size(146, 27)
        txtBoxLastname.TabIndex = 16
        ' 
        ' txtBoxSalary
        ' 
        txtBoxSalary.BorderStyle = BorderStyle.FixedSingle
        txtBoxSalary.Location = New Point(917, 176)
        txtBoxSalary.Margin = New Padding(3, 4, 3, 4)
        txtBoxSalary.Name = "txtBoxSalary"
        txtBoxSalary.Size = New Size(163, 27)
        txtBoxSalary.TabIndex = 17
        ' 
        ' txtBoxAddr
        ' 
        txtBoxAddr.BorderStyle = BorderStyle.FixedSingle
        txtBoxAddr.Location = New Point(505, 51)
        txtBoxAddr.Margin = New Padding(3, 4, 3, 4)
        txtBoxAddr.Multiline = True
        txtBoxAddr.Name = "txtBoxAddr"
        txtBoxAddr.Size = New Size(164, 94)
        txtBoxAddr.TabIndex = 18
        ' 
        ' txtBoxPosit
        ' 
        txtBoxPosit.BackColor = Color.White
        txtBoxPosit.BorderStyle = BorderStyle.FixedSingle
        txtBoxPosit.Location = New Point(917, 45)
        txtBoxPosit.Margin = New Padding(3, 4, 3, 4)
        txtBoxPosit.Multiline = True
        txtBoxPosit.Name = "txtBoxPosit"
        txtBoxPosit.Size = New Size(163, 30)
        txtBoxPosit.TabIndex = 19
        ' 
        ' txtBoxTele
        ' 
        txtBoxTele.BorderStyle = BorderStyle.FixedSingle
        txtBoxTele.Location = New Point(505, 247)
        txtBoxTele.Margin = New Padding(3, 4, 3, 4)
        txtBoxTele.Name = "txtBoxTele"
        txtBoxTele.Size = New Size(164, 27)
        txtBoxTele.TabIndex = 20
        ' 
        ' txtBoxHPWNum
        ' 
        txtBoxHPWNum.BorderStyle = BorderStyle.FixedSingle
        txtBoxHPWNum.Location = New Point(917, 112)
        txtBoxHPWNum.Margin = New Padding(3, 4, 3, 4)
        txtBoxHPWNum.Multiline = True
        txtBoxHPWNum.Name = "txtBoxHPWNum"
        txtBoxHPWNum.Size = New Size(163, 30)
        txtBoxHPWNum.TabIndex = 21
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ControlDark
        DataGridView1.Location = New Point(56, 472)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1155, 308)
        DataGridView1.TabIndex = 30
        ' 
        ' txtboxsearch1
        ' 
        txtboxsearch1.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch1.Location = New Point(-199, 0)
        txtboxsearch1.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch1.Multiline = True
        txtboxsearch1.Name = "txtboxsearch1"
        txtboxsearch1.Size = New Size(212, 34)
        txtboxsearch1.TabIndex = 38
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnsearch)
        Panel1.Controls.Add(txtboxsearch1)
        Panel1.Location = New Point(1157, 427)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(46, 37)
        Panel1.TabIndex = 39
        ' 
        ' btnsearch
        ' 
        btnsearch.Dock = DockStyle.Fill
        btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), Image)
        btnsearch.Location = New Point(0, 0)
        btnsearch.Margin = New Padding(3, 4, 3, 4)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(46, 37)
        btnsearch.SizeMode = PictureBoxSizeMode.Zoom
        btnsearch.TabIndex = 0
        btnsearch.TabStop = False
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BackColor = SystemColors.Window
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxsearch.Location = New Point(998, 429)
        txtboxsearch.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch.Multiline = True
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(152, 30)
        txtboxsearch.TabIndex = 40
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        BtnDelete.Location = New Point(717, 429)
        BtnDelete.Margin = New Padding(3, 4, 3, 4)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(86, 31)
        BtnDelete.TabIndex = 43
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        btnEdit.Location = New Point(601, 429)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(86, 31)
        btnEdit.TabIndex = 42
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        btnADD.Location = New Point(486, 429)
        btnADD.Margin = New Padding(3, 4, 3, 4)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(86, 31)
        btnADD.TabIndex = 41
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(DateTimeB)
        Panel2.Controls.Add(txtBoxLastname)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(ComboBoxSex2)
        Panel2.Controls.Add(txtBoxFirstname)
        Panel2.Controls.Add(txtBoxHPWNum)
        Panel2.Controls.Add(txtBoxPosit)
        Panel2.Controls.Add(txtBoxSalary)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(txtBoxAddr)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txtBoxTele)
        Panel2.Controls.Add(txtBoxNIN)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(56, 76)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1146, 313)
        Panel2.TabIndex = 44
        ' 
        ' DateTimeB
        ' 
        DateTimeB.CustomFormat = "yyyy-MM-dd"
        DateTimeB.Location = New Point(505, 180)
        DateTimeB.Name = "DateTimeB"
        DateTimeB.Size = New Size(164, 27)
        DateTimeB.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        Button1.Location = New Point(56, 427)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 31)
        Button1.TabIndex = 45
        Button1.Text = "Qualification"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        Button2.Location = New Point(194, 427)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 31)
        Button2.TabIndex = 46
        Button2.Text = "Work Experience"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1263, 819)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(BtnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnADD)
        Controls.Add(txtboxsearch)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Staff"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnsearch, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBoxNIN As TextBox
    Friend WithEvents ComboBoxSex2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBoxFirstname As TextBox
    Friend WithEvents txtBoxLastname As TextBox
    Friend WithEvents txtBoxSalary As TextBox
    Friend WithEvents txtBoxAddr As TextBox
    Friend WithEvents txtBoxPosit As TextBox
    Friend WithEvents txtBoxTele As TextBox
    Friend WithEvents txtBoxHPWNum As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtboxsearch1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimeB As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
