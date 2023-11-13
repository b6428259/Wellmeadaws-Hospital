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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBoxNIN = New System.Windows.Forms.TextBox()
        Me.ComboBoxSex2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBoxFirstname = New System.Windows.Forms.TextBox()
        Me.txtBoxLastname = New System.Windows.Forms.TextBox()
        Me.txtBoxSalary = New System.Windows.Forms.TextBox()
        Me.txtBoxAddr = New System.Windows.Forms.TextBox()
        Me.txtBoxPosit = New System.Windows.Forms.TextBox()
        Me.txtBoxTele = New System.Windows.Forms.TextBox()
        Me.txtBoxHPWNum = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtboxsearch1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimeB = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(533, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Firstname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lastname :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sex :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(781, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NIN :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(772, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Salary :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Address :"
        '
        'txtBoxNIN
        '
        Me.txtBoxNIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxNIN.Location = New System.Drawing.Point(835, 151)
        Me.txtBoxNIN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxNIN.Multiline = True
        Me.txtBoxNIN.Name = "txtBoxNIN"
        Me.txtBoxNIN.Size = New System.Drawing.Size(123, 20)
        Me.txtBoxNIN.TabIndex = 9
        '
        'ComboBoxSex2
        '
        Me.ComboBoxSex2.FormattingEnabled = True
        Me.ComboBoxSex2.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBoxSex2.Location = New System.Drawing.Point(160, 113)
        Me.ComboBoxSex2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboBoxSex2.Name = "ComboBoxSex2"
        Me.ComboBoxSex2.Size = New System.Drawing.Size(86, 21)
        Me.ComboBoxSex2.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(761, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Position :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 153)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Telephone :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(373, 110)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Date of Birth :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(727, 77)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Hours Per Week :"
        '
        'txtBoxFirstname
        '
        Me.txtBoxFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxFirstname.Location = New System.Drawing.Point(160, 27)
        Me.txtBoxFirstname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxFirstname.Multiline = True
        Me.txtBoxFirstname.Name = "txtBoxFirstname"
        Me.txtBoxFirstname.Size = New System.Drawing.Size(133, 20)
        Me.txtBoxFirstname.TabIndex = 15
        '
        'txtBoxLastname
        '
        Me.txtBoxLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxLastname.Location = New System.Drawing.Point(160, 66)
        Me.txtBoxLastname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxLastname.Name = "txtBoxLastname"
        Me.txtBoxLastname.Size = New System.Drawing.Size(133, 20)
        Me.txtBoxLastname.TabIndex = 16
        '
        'txtBoxSalary
        '
        Me.txtBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSalary.Location = New System.Drawing.Point(835, 110)
        Me.txtBoxSalary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxSalary.Name = "txtBoxSalary"
        Me.txtBoxSalary.Size = New System.Drawing.Size(123, 20)
        Me.txtBoxSalary.TabIndex = 17
        '
        'txtBoxAddr
        '
        Me.txtBoxAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxAddr.Location = New System.Drawing.Point(465, 24)
        Me.txtBoxAddr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxAddr.Multiline = True
        Me.txtBoxAddr.Name = "txtBoxAddr"
        Me.txtBoxAddr.Size = New System.Drawing.Size(187, 62)
        Me.txtBoxAddr.TabIndex = 18
        '
        'txtBoxPosit
        '
        Me.txtBoxPosit.BackColor = System.Drawing.Color.White
        Me.txtBoxPosit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxPosit.Location = New System.Drawing.Point(835, 25)
        Me.txtBoxPosit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxPosit.Multiline = True
        Me.txtBoxPosit.Name = "txtBoxPosit"
        Me.txtBoxPosit.Size = New System.Drawing.Size(123, 20)
        Me.txtBoxPosit.TabIndex = 19
        '
        'txtBoxTele
        '
        Me.txtBoxTele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxTele.Location = New System.Drawing.Point(465, 152)
        Me.txtBoxTele.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxTele.Name = "txtBoxTele"
        Me.txtBoxTele.Size = New System.Drawing.Size(187, 20)
        Me.txtBoxTele.TabIndex = 20
        '
        'txtBoxHPWNum
        '
        Me.txtBoxHPWNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxHPWNum.Location = New System.Drawing.Point(835, 69)
        Me.txtBoxHPWNum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxHPWNum.Multiline = True
        Me.txtBoxHPWNum.Name = "txtBoxHPWNum"
        Me.txtBoxHPWNum.Size = New System.Drawing.Size(123, 20)
        Me.txtBoxHPWNum.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 307)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(994, 200)
        Me.DataGridView1.TabIndex = 30
        '
        'txtboxsearch1
        '
        Me.txtboxsearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch1.Location = New System.Drawing.Point(-149, 0)
        Me.txtboxsearch1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch1.Multiline = True
        Me.txtboxsearch1.Name = "txtboxsearch1"
        Me.txtboxsearch1.Size = New System.Drawing.Size(160, 23)
        Me.txtboxsearch1.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.txtboxsearch1)
        Me.Panel1.Location = New System.Drawing.Point(999, 277)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(34, 24)
        Me.Panel1.TabIndex = 39
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxsearch.Location = New System.Drawing.Point(879, 278)
        Me.txtboxsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch.Multiline = True
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(114, 20)
        Me.txtboxsearch.TabIndex = 40
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(631, 275)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(64, 20)
        Me.BtnDelete.TabIndex = 43
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(544, 275)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 20)
        Me.btnEdit.TabIndex = 42
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnADD.Location = New System.Drawing.Point(457, 275)
        Me.btnADD.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(64, 20)
        Me.btnADD.TabIndex = 41
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DateTimeB)
        Me.Panel2.Controls.Add(Me.txtBoxLastname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ComboBoxSex2)
        Me.Panel2.Controls.Add(Me.txtBoxFirstname)
        Me.Panel2.Controls.Add(Me.txtBoxHPWNum)
        Me.Panel2.Controls.Add(Me.txtBoxPosit)
        Me.Panel2.Controls.Add(Me.txtBoxSalary)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtBoxAddr)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtBoxTele)
        Me.Panel2.Controls.Add(Me.txtBoxNIN)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(42, 49)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 204)
        Me.Panel2.TabIndex = 44
        '
        'DateTimeB
        '
        Me.DateTimeB.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeB.Location = New System.Drawing.Point(465, 108)
        Me.DateTimeB.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimeB.Name = "DateTimeB"
        Me.DateTimeB.Size = New System.Drawing.Size(187, 20)
        Me.DateTimeB.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(42, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 20)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Qualification"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(146, 278)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 20)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Work Experience"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(0, 0)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(34, 24)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(265, 278)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 20)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Log-in management"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button3 As Button
End Class
