<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Qualification
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Qualification))
        DataGridView1 = New DataGridView()
        btnsearchmed = New PictureBox()
        txtBoxSearch = New TextBox()
        Label3 = New Label()
        quaID = New TextBox()
        Label1 = New Label()
        staffid = New TextBox()
        Label2 = New Label()
        institution = New TextBox()
        Label4 = New Label()
        qualitype = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        qualiDate = New DateTimePicker()
        buttonDelete = New Button()
        ButtonEdit = New Button()
        ButtonAdd = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearchmed, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(51, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(694, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' btnsearchmed
        ' 
        btnsearchmed.Image = CType(resources.GetObject("btnsearchmed.Image"), Image)
        btnsearchmed.Location = New Point(700, 207)
        btnsearchmed.Margin = New Padding(3, 4, 3, 4)
        btnsearchmed.Name = "btnsearchmed"
        btnsearchmed.Size = New Size(45, 36)
        btnsearchmed.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchmed.TabIndex = 57
        btnsearchmed.TabStop = False
        ' 
        ' txtBoxSearch
        ' 
        txtBoxSearch.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearch.Location = New Point(516, 207)
        txtBoxSearch.Margin = New Padding(3, 4, 3, 4)
        txtBoxSearch.Multiline = True
        txtBoxSearch.Name = "txtBoxSearch"
        txtBoxSearch.Size = New Size(177, 35)
        txtBoxSearch.TabIndex = 56
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 58
        Label3.Text = "Qulification ID :"
        ' 
        ' quaID
        ' 
        quaID.BorderStyle = BorderStyle.FixedSingle
        quaID.Location = New Point(169, 210)
        quaID.Margin = New Padding(3, 4, 3, 4)
        quaID.Name = "quaID"
        quaID.Size = New Size(146, 27)
        quaID.TabIndex = 59
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 277)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 60
        Label1.Text = "Staff ID :"
        ' 
        ' staffid
        ' 
        staffid.BorderStyle = BorderStyle.FixedSingle
        staffid.Location = New Point(169, 275)
        staffid.Margin = New Padding(3, 4, 3, 4)
        staffid.Name = "staffid"
        staffid.Size = New Size(146, 27)
        staffid.TabIndex = 61
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(428, 279)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 62
        Label2.Text = "Institution :"
        ' 
        ' institution
        ' 
        institution.BorderStyle = BorderStyle.FixedSingle
        institution.Location = New Point(516, 277)
        institution.Margin = New Padding(3, 4, 3, 4)
        institution.Name = "institution"
        institution.Size = New Size(177, 27)
        institution.TabIndex = 63
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 333)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 20)
        Label4.TabIndex = 64
        Label4.Text = "Qualification Type :"
        ' 
        ' qualitype
        ' 
        qualitype.BorderStyle = BorderStyle.FixedSingle
        qualitype.Location = New Point(169, 331)
        qualitype.Margin = New Padding(3, 4, 3, 4)
        qualitype.Name = "qualitype"
        qualitype.Size = New Size(146, 27)
        qualitype.TabIndex = 65
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(373, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 20)
        Label5.TabIndex = 66
        Label5.Text = "Qualification Date :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(450, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 67
        Label6.Text = "Search :"
        ' 
        ' qualiDate
        ' 
        qualiDate.CustomFormat = "yyyy-MM-dd"
        qualiDate.Location = New Point(516, 331)
        qualiDate.Name = "qualiDate"
        qualiDate.Size = New Size(177, 27)
        qualiDate.TabIndex = 68
        ' 
        ' buttonDelete
        ' 
        buttonDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        buttonDelete.Location = New Point(448, 375)
        buttonDelete.Margin = New Padding(3, 4, 3, 4)
        buttonDelete.Name = "buttonDelete"
        buttonDelete.Size = New Size(71, 31)
        buttonDelete.TabIndex = 71
        buttonDelete.Text = "DELETE"
        buttonDelete.UseVisualStyleBackColor = False
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        ButtonEdit.Location = New Point(373, 375)
        ButtonEdit.Margin = New Padding(3, 4, 3, 4)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(71, 31)
        ButtonEdit.TabIndex = 70
        ButtonEdit.Text = "EDIT"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        ButtonAdd.Location = New Point(296, 375)
        ButtonAdd.Margin = New Padding(3, 4, 3, 4)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(71, 31)
        ButtonAdd.TabIndex = 69
        ButtonAdd.Text = "ADD"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' Qualification
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 414)
        Controls.Add(buttonDelete)
        Controls.Add(ButtonEdit)
        Controls.Add(ButtonAdd)
        Controls.Add(qualiDate)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(qualitype)
        Controls.Add(Label2)
        Controls.Add(institution)
        Controls.Add(Label1)
        Controls.Add(staffid)
        Controls.Add(Label3)
        Controls.Add(quaID)
        Controls.Add(btnsearchmed)
        Controls.Add(txtBoxSearch)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Qualification"
        Text = "Qualification"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearchmed, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnsearchmed As PictureBox
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents quaID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents staffid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents institution As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents qualitype As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents qualiDate As DateTimePicker
    Friend WithEvents buttonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonAdd As Button
End Class
