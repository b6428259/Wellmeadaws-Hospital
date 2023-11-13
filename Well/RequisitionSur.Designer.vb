<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequisitionSur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequisitionSur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.selectRwquiDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRequi = New System.Windows.Forms.TextBox()
        Me.txtWardName = New System.Windows.Forms.TextBox()
        Me.txtWardNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxQuan = New System.Windows.Forms.ComboBox()
        Me.txtSearchItem = New System.Windows.Forms.TextBox()
        Me.txtItemNum = New System.Windows.Forms.TextBox()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMethod = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtCostperU = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnsearchResur = New System.Windows.Forms.PictureBox()
        Me.DataGridViewRequiSer = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnsearchResur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRequiSer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(481, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REQUISITION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(444, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surgical or Non-Surgical"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ward Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ward Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Requisitioned By :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(706, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Requisition Date :"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.selectRwquiDate)
        Me.Panel1.Controls.Add(Me.txtRequi)
        Me.Panel1.Controls.Add(Me.txtWardName)
        Me.Panel1.Controls.Add(Me.txtWardNumber)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(38, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 50)
        Me.Panel1.TabIndex = 6
        '
        'selectRwquiDate
        '
        Me.selectRwquiDate.Location = New System.Drawing.Point(796, 16)
        Me.selectRwquiDate.Name = "selectRwquiDate"
        Me.selectRwquiDate.Size = New System.Drawing.Size(194, 20)
        Me.selectRwquiDate.TabIndex = 9
        '
        'txtRequi
        '
        Me.txtRequi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRequi.Location = New System.Drawing.Point(529, 16)
        Me.txtRequi.Name = "txtRequi"
        Me.txtRequi.Size = New System.Drawing.Size(131, 20)
        Me.txtRequi.TabIndex = 8
        '
        'txtWardName
        '
        Me.txtWardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWardName.Location = New System.Drawing.Point(292, 16)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.Size = New System.Drawing.Size(125, 20)
        Me.txtWardName.TabIndex = 7
        '
        'txtWardNumber
        '
        Me.txtWardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWardNumber.Location = New System.Drawing.Point(106, 16)
        Me.txtWardNumber.Name = "txtWardNumber"
        Me.txtWardNumber.Size = New System.Drawing.Size(77, 20)
        Me.txtWardNumber.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Item Search :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Item Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Quantity in Stock :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(405, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(366, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Method of Use :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(754, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Description :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(746, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cost per Unit :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(88, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Quantity :"
        '
        'ComboBoxQuan
        '
        Me.ComboBoxQuan.FormattingEnabled = True
        Me.ComboBoxQuan.Location = New System.Drawing.Point(143, 127)
        Me.ComboBoxQuan.Name = "ComboBoxQuan"
        Me.ComboBoxQuan.Size = New System.Drawing.Size(73, 21)
        Me.ComboBoxQuan.TabIndex = 15
        '
        'txtSearchItem
        '
        Me.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchItem.Location = New System.Drawing.Point(143, 11)
        Me.txtSearchItem.Name = "txtSearchItem"
        Me.txtSearchItem.Size = New System.Drawing.Size(143, 20)
        Me.txtSearchItem.TabIndex = 16
        '
        'txtItemNum
        '
        Me.txtItemNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemNum.Location = New System.Drawing.Point(143, 48)
        Me.txtItemNum.Name = "txtItemNum"
        Me.txtItemNum.Size = New System.Drawing.Size(143, 20)
        Me.txtItemNum.TabIndex = 17
        '
        'txtQuan
        '
        Me.txtQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuan.Location = New System.Drawing.Point(143, 86)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.Size = New System.Drawing.Size(143, 20)
        Me.txtQuan.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(449, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 20)
        Me.txtName.TabIndex = 19
        '
        'txtMethod
        '
        Me.txtMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMethod.Location = New System.Drawing.Point(449, 84)
        Me.txtMethod.Name = "txtMethod"
        Me.txtMethod.Size = New System.Drawing.Size(154, 20)
        Me.txtMethod.TabIndex = 20
        '
        'txtDes
        '
        Me.txtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDes.Location = New System.Drawing.Point(821, 48)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(169, 20)
        Me.txtDes.TabIndex = 21
        '
        'txtCostperU
        '
        Me.txtCostperU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostperU.Location = New System.Drawing.Point(821, 84)
        Me.txtCostperU.Name = "txtCostperU"
        Me.txtCostperU.Size = New System.Drawing.Size(169, 20)
        Me.txtCostperU.TabIndex = 22
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(472, 317)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 20)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(555, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 20)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnsearchResur)
        Me.Panel2.Controls.Add(Me.txtCostperU)
        Me.Panel2.Controls.Add(Me.txtDes)
        Me.Panel2.Controls.Add(Me.txtMethod)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.txtQuan)
        Me.Panel2.Controls.Add(Me.txtItemNum)
        Me.Panel2.Controls.Add(Me.txtSearchItem)
        Me.Panel2.Controls.Add(Me.ComboBoxQuan)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(38, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 160)
        Me.Panel2.TabIndex = 26
        '
        'btnsearchResur
        '
        Me.btnsearchResur.Image = CType(resources.GetObject("btnsearchResur.Image"), System.Drawing.Image)
        Me.btnsearchResur.Location = New System.Drawing.Point(303, 11)
        Me.btnsearchResur.Name = "btnsearchResur"
        Me.btnsearchResur.Size = New System.Drawing.Size(27, 20)
        Me.btnsearchResur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchResur.TabIndex = 71
        Me.btnsearchResur.TabStop = False
        '
        'DataGridViewRequiSer
        '
        Me.DataGridViewRequiSer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewRequiSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRequiSer.Location = New System.Drawing.Point(38, 365)
        Me.DataGridViewRequiSer.Name = "DataGridViewRequiSer"
        Me.DataGridViewRequiSer.RowHeadersWidth = 47
        Me.DataGridViewRequiSer.RowTemplate.Height = 25
        Me.DataGridViewRequiSer.Size = New System.Drawing.Size(1006, 197)
        Me.DataGridViewRequiSer.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(189, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(666, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'RequisitionSur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.DataGridViewRequiSer)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequisitionSur"
        Me.Text = "RequisitionSur"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnsearchResur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRequiSer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents selectRwquiDate As DateTimePicker
    Friend WithEvents txtRequi As TextBox
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents txtWardNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBoxQuan As ComboBox
    Friend WithEvents txtSearchItem As TextBox
    Friend WithEvents txtItemNum As TextBox
    Friend WithEvents txtQuan As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMethod As TextBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtCostperU As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewRequiSer As DataGridView
    Friend WithEvents btnsearchResur As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
