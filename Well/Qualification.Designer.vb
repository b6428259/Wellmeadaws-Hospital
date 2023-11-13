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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Qualification))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnsearchmed = New System.Windows.Forms.PictureBox()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quaID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.staffid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.institution = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.qualitype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qualiDate = New System.Windows.Forms.DateTimePicker()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearchmed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 8)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(520, 122)
        Me.DataGridView1.TabIndex = 0
        '
        'btnsearchmed
        '
        Me.btnsearchmed.Image = CType(resources.GetObject("btnsearchmed.Image"), System.Drawing.Image)
        Me.btnsearchmed.Location = New System.Drawing.Point(525, 135)
        Me.btnsearchmed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearchmed.Name = "btnsearchmed"
        Me.btnsearchmed.Size = New System.Drawing.Size(34, 23)
        Me.btnsearchmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchmed.TabIndex = 57
        Me.btnsearchmed.TabStop = False
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearch.Location = New System.Drawing.Point(387, 135)
        Me.txtBoxSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxSearch.Multiline = True
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(133, 23)
        Me.txtBoxSearch.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Qulification ID :"
        '
        'quaID
        '
        Me.quaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.quaID.Location = New System.Drawing.Point(127, 136)
        Me.quaID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.quaID.Name = "quaID"
        Me.quaID.Size = New System.Drawing.Size(110, 20)
        Me.quaID.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Staff ID :"
        '
        'staffid
        '
        Me.staffid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.staffid.Location = New System.Drawing.Point(127, 179)
        Me.staffid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.staffid.Name = "staffid"
        Me.staffid.Size = New System.Drawing.Size(110, 20)
        Me.staffid.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Institution :"
        '
        'institution
        '
        Me.institution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.institution.Location = New System.Drawing.Point(387, 180)
        Me.institution.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.institution.Name = "institution"
        Me.institution.Size = New System.Drawing.Size(133, 20)
        Me.institution.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 216)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Qualification Type :"
        '
        'qualitype
        '
        Me.qualitype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qualitype.Location = New System.Drawing.Point(127, 215)
        Me.qualitype.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.qualitype.Name = "qualitype"
        Me.qualitype.Size = New System.Drawing.Size(110, 20)
        Me.qualitype.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Qualification Date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Search :"
        '
        'qualiDate
        '
        Me.qualiDate.CustomFormat = "yyyy-MM-dd"
        Me.qualiDate.Location = New System.Drawing.Point(387, 215)
        Me.qualiDate.Margin = New System.Windows.Forms.Padding(2)
        Me.qualiDate.Name = "qualiDate"
        Me.qualiDate.Size = New System.Drawing.Size(134, 20)
        Me.qualiDate.TabIndex = 68
        '
        'buttonDelete
        '
        Me.buttonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.buttonDelete.Location = New System.Drawing.Point(336, 244)
        Me.buttonDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(53, 20)
        Me.buttonDelete.TabIndex = 71
        Me.buttonDelete.Text = "DELETE"
        Me.buttonDelete.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ButtonEdit.Location = New System.Drawing.Point(280, 244)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(53, 20)
        Me.ButtonEdit.TabIndex = 70
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonAdd.Location = New System.Drawing.Point(222, 244)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(53, 20)
        Me.ButtonAdd.TabIndex = 69
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(241, 176)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'Qualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(600, 269)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.qualiDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.qualitype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.institution)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.staffid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.quaID)
        Me.Controls.Add(Me.btnsearchmed)
        Me.Controls.Add(Me.txtBoxSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Qualification"
        Me.Text = "Qualification"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearchmed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PictureBox1 As PictureBox
End Class
