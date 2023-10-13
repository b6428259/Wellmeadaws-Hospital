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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RequisitionSur))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        selectRwquiDate = New DateTimePicker()
        txtRequi = New TextBox()
        txtWardName = New TextBox()
        txtWardNumber = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        ComboBoxQuan = New ComboBox()
        txtSearchItem = New TextBox()
        txtItemNum = New TextBox()
        txtQuan = New TextBox()
        txtName = New TextBox()
        txtMethod = New TextBox()
        txtDes = New TextBox()
        txtCostperU = New TextBox()
        btnAdd = New Button()
        Button3 = New Button()
        Panel2 = New Panel()
        DataGridViewRequiSer = New DataGridView()
        btnsearchResur = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridViewRequiSer, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearchResur, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(497, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 30)
        Label1.TabIndex = 0
        Label1.Text = "REQUISITION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.WindowText
        Label2.Location = New Point(454, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 25)
        Label2.TabIndex = 1
        Label2.Text = "Surgical or Non-Surgical"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 2
        Label3.Text = "Ward Number :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(202, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 3
        Label4.Text = "Ward Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(435, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 15)
        Label5.TabIndex = 4
        Label5.Text = "Requisitioned By :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(715, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 15)
        Label6.TabIndex = 5
        Label6.Text = "Requisition Date :"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(selectRwquiDate)
        Panel1.Controls.Add(txtRequi)
        Panel1.Controls.Add(txtWardName)
        Panel1.Controls.Add(txtWardNumber)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(44, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1031, 57)
        Panel1.TabIndex = 6
        ' 
        ' selectRwquiDate
        ' 
        selectRwquiDate.Location = New Point(820, 18)
        selectRwquiDate.Name = "selectRwquiDate"
        selectRwquiDate.Size = New Size(189, 23)
        selectRwquiDate.TabIndex = 9
        ' 
        ' txtRequi
        ' 
        txtRequi.BorderStyle = BorderStyle.FixedSingle
        txtRequi.Location = New Point(542, 18)
        txtRequi.Name = "txtRequi"
        txtRequi.Size = New Size(153, 23)
        txtRequi.TabIndex = 8
        ' 
        ' txtWardName
        ' 
        txtWardName.BorderStyle = BorderStyle.FixedSingle
        txtWardName.Location = New Point(284, 18)
        txtWardName.Name = "txtWardName"
        txtWardName.Size = New Size(145, 23)
        txtWardName.TabIndex = 7
        ' 
        ' txtWardNumber
        ' 
        txtWardNumber.BorderStyle = BorderStyle.FixedSingle
        txtWardNumber.Location = New Point(106, 18)
        txtWardNumber.Name = "txtWardNumber"
        txtWardNumber.Size = New Size(90, 23)
        txtWardNumber.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(70, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 15)
        Label7.TabIndex = 7
        Label7.Text = "Item Search :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(61, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 15)
        Label8.TabIndex = 8
        Label8.Text = "Item Number :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(41, 102)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 15)
        Label9.TabIndex = 9
        Label9.Text = "Quantity in Stock :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(413, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 15)
        Label10.TabIndex = 10
        Label10.Text = "Name :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(367, 100)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 15)
        Label11.TabIndex = 11
        Label11.Text = "Method of Use :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(703, 58)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 15)
        Label12.TabIndex = 12
        Label12.Text = "Description :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(694, 100)
        Label13.Name = "Label13"
        Label13.Size = New Size(82, 15)
        Label13.TabIndex = 13
        Label13.Text = "Cost per Unit :"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(86, 150)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 15)
        Label14.TabIndex = 14
        Label14.Text = "Quantity :"
        ' 
        ' ComboBoxQuan
        ' 
        ComboBoxQuan.FormattingEnabled = True
        ComboBoxQuan.Location = New Point(151, 147)
        ComboBoxQuan.Name = "ComboBoxQuan"
        ComboBoxQuan.Size = New Size(84, 23)
        ComboBoxQuan.TabIndex = 15
        ' 
        ' txtSearchItem
        ' 
        txtSearchItem.BorderStyle = BorderStyle.FixedSingle
        txtSearchItem.Location = New Point(151, 13)
        txtSearchItem.Name = "txtSearchItem"
        txtSearchItem.Size = New Size(166, 23)
        txtSearchItem.TabIndex = 16
        ' 
        ' txtItemNum
        ' 
        txtItemNum.BorderStyle = BorderStyle.FixedSingle
        txtItemNum.Location = New Point(151, 55)
        txtItemNum.Name = "txtItemNum"
        txtItemNum.Size = New Size(166, 23)
        txtItemNum.TabIndex = 17
        ' 
        ' txtQuan
        ' 
        txtQuan.BorderStyle = BorderStyle.FixedSingle
        txtQuan.Location = New Point(151, 99)
        txtQuan.Name = "txtQuan"
        txtQuan.Size = New Size(166, 23)
        txtQuan.TabIndex = 18
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(464, 55)
        txtName.Name = "txtName"
        txtName.Size = New Size(179, 23)
        txtName.TabIndex = 19
        ' 
        ' txtMethod
        ' 
        txtMethod.BorderStyle = BorderStyle.FixedSingle
        txtMethod.Location = New Point(464, 97)
        txtMethod.Name = "txtMethod"
        txtMethod.Size = New Size(179, 23)
        txtMethod.TabIndex = 20
        ' 
        ' txtDes
        ' 
        txtDes.BorderStyle = BorderStyle.FixedSingle
        txtDes.Location = New Point(782, 55)
        txtDes.Name = "txtDes"
        txtDes.Size = New Size(197, 23)
        txtDes.TabIndex = 21
        ' 
        ' txtCostperU
        ' 
        txtCostperU.BorderStyle = BorderStyle.FixedSingle
        txtCostperU.Location = New Point(782, 97)
        txtCostperU.Name = "txtCostperU"
        txtCostperU.Size = New Size(197, 23)
        txtCostperU.TabIndex = 22
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        btnAdd.Location = New Point(367, 147)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 24
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(464, 147)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 25
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnsearchResur)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(txtCostperU)
        Panel2.Controls.Add(txtDes)
        Panel2.Controls.Add(txtMethod)
        Panel2.Controls.Add(txtName)
        Panel2.Controls.Add(txtQuan)
        Panel2.Controls.Add(txtItemNum)
        Panel2.Controls.Add(txtSearchItem)
        Panel2.Controls.Add(ComboBoxQuan)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(44, 156)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 184)
        Panel2.TabIndex = 26
        ' 
        ' DataGridViewRequiSer
        ' 
        DataGridViewRequiSer.BorderStyle = BorderStyle.Fixed3D
        DataGridViewRequiSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRequiSer.Location = New Point(43, 362)
        DataGridViewRequiSer.Name = "DataGridViewRequiSer"
        DataGridViewRequiSer.RowHeadersWidth = 47
        DataGridViewRequiSer.RowTemplate.Height = 25
        DataGridViewRequiSer.Size = New Size(1033, 227)
        DataGridViewRequiSer.TabIndex = 27
        ' 
        ' btnsearchResur
        ' 
        btnsearchResur.Image = CType(resources.GetObject("btnsearchResur.Image"), Image)
        btnsearchResur.Location = New Point(323, 13)
        btnsearchResur.Name = "btnsearchResur"
        btnsearchResur.Size = New Size(32, 23)
        btnsearchResur.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchResur.TabIndex = 71
        btnsearchResur.TabStop = False
        ' 
        ' RequisitionSur
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1124, 614)
        Controls.Add(DataGridViewRequiSer)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RequisitionSur"
        Text = "RequisitionSur"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridViewRequiSer, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearchResur, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
End Class
