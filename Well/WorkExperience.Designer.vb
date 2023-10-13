<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkExperience
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(WorkExperience))
        buttonDelete = New Button()
        ButtonEdit = New Button()
        ButtonAdd = New Button()
        startDate = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        pos = New TextBox()
        Label2 = New Label()
        organi = New TextBox()
        Label1 = New Label()
        staffid = New TextBox()
        Label3 = New Label()
        exid = New TextBox()
        btnsearchmed = New PictureBox()
        txtBoxSearch = New TextBox()
        DataGridView1 = New DataGridView()
        EndDate = New DateTimePicker()
        Label7 = New Label()
        CType(btnsearchmed, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' buttonDelete
        ' 
        buttonDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        buttonDelete.Location = New Point(661, 406)
        buttonDelete.Margin = New Padding(3, 4, 3, 4)
        buttonDelete.Name = "buttonDelete"
        buttonDelete.Size = New Size(71, 31)
        buttonDelete.TabIndex = 88
        buttonDelete.Text = "DELETE"
        buttonDelete.UseVisualStyleBackColor = False
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        ButtonEdit.Location = New Point(586, 406)
        ButtonEdit.Margin = New Padding(3, 4, 3, 4)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(71, 31)
        ButtonEdit.TabIndex = 87
        ButtonEdit.Text = "EDIT"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        ButtonAdd.Location = New Point(509, 406)
        ButtonAdd.Margin = New Padding(3, 4, 3, 4)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(71, 31)
        ButtonAdd.TabIndex = 86
        ButtonAdd.Text = "ADD"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' startDate
        ' 
        startDate.CustomFormat = "yyyy-MM-dd"
        startDate.Location = New Point(152, 348)
        startDate.Name = "startDate"
        startDate.Size = New Size(177, 27)
        startDate.TabIndex = 85
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(464, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 84
        Label6.Text = "Search :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 83
        Label5.Text = "Start Date :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(456, 350)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 81
        Label4.Text = "Position :"
        ' 
        ' pos
        ' 
        pos.BorderStyle = BorderStyle.FixedSingle
        pos.Location = New Point(530, 348)
        pos.Margin = New Padding(3, 4, 3, 4)
        pos.Name = "pos"
        pos.Size = New Size(146, 27)
        pos.TabIndex = 82
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(422, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 79
        Label2.Text = "Organization :"
        ' 
        ' organi
        ' 
        organi.BorderStyle = BorderStyle.FixedSingle
        organi.Location = New Point(530, 293)
        organi.Margin = New Padding(3, 4, 3, 4)
        organi.Name = "organi"
        organi.Size = New Size(177, 27)
        organi.TabIndex = 80
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(111, 293)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 77
        Label1.Text = "Staff ID :"
        ' 
        ' staffid
        ' 
        staffid.BorderStyle = BorderStyle.FixedSingle
        staffid.Location = New Point(183, 291)
        staffid.Margin = New Padding(3, 4, 3, 4)
        staffid.Name = "staffid"
        staffid.Size = New Size(146, 27)
        staffid.TabIndex = 78
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 20)
        Label3.TabIndex = 75
        Label3.Text = "Experience ID :"
        ' 
        ' exid
        ' 
        exid.BorderStyle = BorderStyle.FixedSingle
        exid.Location = New Point(183, 226)
        exid.Margin = New Padding(3, 4, 3, 4)
        exid.Name = "exid"
        exid.Size = New Size(146, 27)
        exid.TabIndex = 76
        ' 
        ' btnsearchmed
        ' 
        btnsearchmed.Image = CType(resources.GetObject("btnsearchmed.Image"), Image)
        btnsearchmed.Location = New Point(714, 223)
        btnsearchmed.Margin = New Padding(3, 4, 3, 4)
        btnsearchmed.Name = "btnsearchmed"
        btnsearchmed.Size = New Size(45, 36)
        btnsearchmed.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchmed.TabIndex = 74
        btnsearchmed.TabStop = False
        ' 
        ' txtBoxSearch
        ' 
        txtBoxSearch.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearch.Location = New Point(530, 229)
        txtBoxSearch.Margin = New Padding(3, 4, 3, 4)
        txtBoxSearch.Multiline = True
        txtBoxSearch.Name = "txtBoxSearch"
        txtBoxSearch.Size = New Size(177, 30)
        txtBoxSearch.TabIndex = 73
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(65, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(694, 188)
        DataGridView1.TabIndex = 72
        ' 
        ' EndDate
        ' 
        EndDate.CustomFormat = "yyyy-MM-dd"
        EndDate.Location = New Point(152, 394)
        EndDate.Name = "EndDate"
        EndDate.Size = New Size(177, 27)
        EndDate.TabIndex = 90
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(63, 396)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 20)
        Label7.TabIndex = 89
        Label7.Text = "End Date :"
        ' 
        ' WorkExperience
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(EndDate)
        Controls.Add(Label7)
        Controls.Add(buttonDelete)
        Controls.Add(ButtonEdit)
        Controls.Add(ButtonAdd)
        Controls.Add(startDate)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(pos)
        Controls.Add(Label2)
        Controls.Add(organi)
        Controls.Add(Label1)
        Controls.Add(staffid)
        Controls.Add(Label3)
        Controls.Add(exid)
        Controls.Add(btnsearchmed)
        Controls.Add(txtBoxSearch)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "WorkExperience"
        Text = "WorkExperience"
        CType(btnsearchmed, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents buttonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents startDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents organi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents staffid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents exid As TextBox
    Friend WithEvents btnsearchmed As PictureBox
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
