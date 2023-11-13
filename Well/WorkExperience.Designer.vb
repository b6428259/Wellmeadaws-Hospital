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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkExperience))
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.startDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.organi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.staffid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exid = New System.Windows.Forms.TextBox()
        Me.btnsearchmed = New System.Windows.Forms.PictureBox()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.btnsearchmed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonDelete
        '
        Me.buttonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.buttonDelete.Location = New System.Drawing.Point(496, 264)
        Me.buttonDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(53, 20)
        Me.buttonDelete.TabIndex = 88
        Me.buttonDelete.Text = "DELETE"
        Me.buttonDelete.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ButtonEdit.Location = New System.Drawing.Point(440, 264)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(53, 20)
        Me.ButtonEdit.TabIndex = 87
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ButtonAdd.Location = New System.Drawing.Point(382, 264)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(53, 20)
        Me.ButtonAdd.TabIndex = 86
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'startDate
        '
        Me.startDate.CustomFormat = "yyyy-MM-dd"
        Me.startDate.Location = New System.Drawing.Point(114, 226)
        Me.startDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.startDate.Name = "startDate"
        Me.startDate.Size = New System.Drawing.Size(134, 20)
        Me.startDate.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 148)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Search :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 227)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Start Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 227)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Position :"
        '
        'pos
        '
        Me.pos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pos.Location = New System.Drawing.Point(398, 226)
        Me.pos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pos.Name = "pos"
        Me.pos.Size = New System.Drawing.Size(110, 20)
        Me.pos.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Organization :"
        '
        'organi
        '
        Me.organi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.organi.Location = New System.Drawing.Point(398, 190)
        Me.organi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.organi.Name = "organi"
        Me.organi.Size = New System.Drawing.Size(133, 20)
        Me.organi.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Staff ID :"
        '
        'staffid
        '
        Me.staffid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.staffid.Location = New System.Drawing.Point(137, 189)
        Me.staffid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.staffid.Name = "staffid"
        Me.staffid.Size = New System.Drawing.Size(110, 20)
        Me.staffid.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Experience ID :"
        '
        'exid
        '
        Me.exid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exid.Location = New System.Drawing.Point(137, 147)
        Me.exid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.exid.Name = "exid"
        Me.exid.Size = New System.Drawing.Size(110, 20)
        Me.exid.TabIndex = 76
        '
        'btnsearchmed
        '
        Me.btnsearchmed.Image = CType(resources.GetObject("btnsearchmed.Image"), System.Drawing.Image)
        Me.btnsearchmed.Location = New System.Drawing.Point(536, 145)
        Me.btnsearchmed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearchmed.Name = "btnsearchmed"
        Me.btnsearchmed.Size = New System.Drawing.Size(34, 23)
        Me.btnsearchmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchmed.TabIndex = 74
        Me.btnsearchmed.TabStop = False
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearch.Location = New System.Drawing.Point(398, 149)
        Me.txtBoxSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxSearch.Multiline = True
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(133, 20)
        Me.txtBoxSearch.TabIndex = 73
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(520, 122)
        Me.DataGridView1.TabIndex = 72
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "yyyy-MM-dd"
        Me.EndDate.Location = New System.Drawing.Point(114, 256)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(134, 20)
        Me.EndDate.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "End Date :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(251, 187)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'WorkExperience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(600, 292)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.startDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.organi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.staffid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exid)
        Me.Controls.Add(Me.btnsearchmed)
        Me.Controls.Add(Me.txtBoxSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "WorkExperience"
        Me.Text = "WorkExperience"
        CType(Me.btnsearchmed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PictureBox1 As PictureBox
End Class
