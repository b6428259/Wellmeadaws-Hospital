<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequisitionPharma
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RequisitionPharma))
        DataGridReqPhama = New DataGridView()
        Panel2 = New Panel()
        btnsearchRepharma = New PictureBox()
        Button3 = New Button()
        RE_pha_btnAdd = New Button()
        RE_pha_CPU = New TextBox()
        RE_pha_Desc = New TextBox()
        RE_pha_mOus = New TextBox()
        RE_pha_Name = New TextBox()
        RE_pha_Dosage = New TextBox()
        RE_pha_DraNumber = New TextBox()
        RE_pha_ItemSearch = New TextBox()
        RE_pha_Quan = New ComboBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        ReQuiPhaDate = New DateTimePicker()
        r_ph_RequiBy = New TextBox()
        r_ph_wardName = New TextBox()
        r_ph_WardNum = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(DataGridReqPhama, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(btnsearchRepharma, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridReqPhama
        ' 
        DataGridReqPhama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridReqPhama.Location = New Point(48, 365)
        DataGridReqPhama.Name = "DataGridReqPhama"
        DataGridReqPhama.RowHeadersWidth = 47
        DataGridReqPhama.RowTemplate.Height = 25
        DataGridReqPhama.Size = New Size(1033, 227)
        DataGridReqPhama.TabIndex = 32
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnsearchRepharma)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(RE_pha_btnAdd)
        Panel2.Controls.Add(RE_pha_CPU)
        Panel2.Controls.Add(RE_pha_Desc)
        Panel2.Controls.Add(RE_pha_mOus)
        Panel2.Controls.Add(RE_pha_Name)
        Panel2.Controls.Add(RE_pha_Dosage)
        Panel2.Controls.Add(RE_pha_DraNumber)
        Panel2.Controls.Add(RE_pha_ItemSearch)
        Panel2.Controls.Add(RE_pha_Quan)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(49, 159)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 184)
        Panel2.TabIndex = 31
        ' 
        ' btnsearchRepharma
        ' 
        btnsearchRepharma.Image = CType(resources.GetObject("btnsearchRepharma.Image"), Image)
        btnsearchRepharma.Location = New Point(323, 13)
        btnsearchRepharma.Name = "btnsearchRepharma"
        btnsearchRepharma.Size = New Size(32, 23)
        btnsearchRepharma.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchRepharma.TabIndex = 70
        btnsearchRepharma.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        Button3.Location = New Point(464, 147)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 25
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RE_pha_btnAdd
        ' 
        RE_pha_btnAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        RE_pha_btnAdd.Location = New Point(367, 147)
        RE_pha_btnAdd.Name = "RE_pha_btnAdd"
        RE_pha_btnAdd.Size = New Size(75, 23)
        RE_pha_btnAdd.TabIndex = 24
        RE_pha_btnAdd.Text = "Add"
        RE_pha_btnAdd.UseVisualStyleBackColor = False
        ' 
        ' RE_pha_CPU
        ' 
        RE_pha_CPU.BorderStyle = BorderStyle.FixedSingle
        RE_pha_CPU.Location = New Point(782, 97)
        RE_pha_CPU.Name = "RE_pha_CPU"
        RE_pha_CPU.Size = New Size(197, 23)
        RE_pha_CPU.TabIndex = 22
        ' 
        ' RE_pha_Desc
        ' 
        RE_pha_Desc.BorderStyle = BorderStyle.FixedSingle
        RE_pha_Desc.Location = New Point(782, 55)
        RE_pha_Desc.Name = "RE_pha_Desc"
        RE_pha_Desc.Size = New Size(197, 23)
        RE_pha_Desc.TabIndex = 21
        ' 
        ' RE_pha_mOus
        ' 
        RE_pha_mOus.BorderStyle = BorderStyle.FixedSingle
        RE_pha_mOus.Location = New Point(464, 97)
        RE_pha_mOus.Name = "RE_pha_mOus"
        RE_pha_mOus.Size = New Size(179, 23)
        RE_pha_mOus.TabIndex = 20
        ' 
        ' RE_pha_Name
        ' 
        RE_pha_Name.BorderStyle = BorderStyle.FixedSingle
        RE_pha_Name.Location = New Point(464, 55)
        RE_pha_Name.Name = "RE_pha_Name"
        RE_pha_Name.Size = New Size(179, 23)
        RE_pha_Name.TabIndex = 19
        ' 
        ' RE_pha_Dosage
        ' 
        RE_pha_Dosage.BorderStyle = BorderStyle.FixedSingle
        RE_pha_Dosage.Location = New Point(151, 99)
        RE_pha_Dosage.Name = "RE_pha_Dosage"
        RE_pha_Dosage.Size = New Size(166, 23)
        RE_pha_Dosage.TabIndex = 18
        ' 
        ' RE_pha_DraNumber
        ' 
        RE_pha_DraNumber.BorderStyle = BorderStyle.FixedSingle
        RE_pha_DraNumber.Location = New Point(151, 55)
        RE_pha_DraNumber.Name = "RE_pha_DraNumber"
        RE_pha_DraNumber.Size = New Size(166, 23)
        RE_pha_DraNumber.TabIndex = 17
        ' 
        ' RE_pha_ItemSearch
        ' 
        RE_pha_ItemSearch.BorderStyle = BorderStyle.FixedSingle
        RE_pha_ItemSearch.Location = New Point(151, 13)
        RE_pha_ItemSearch.Name = "RE_pha_ItemSearch"
        RE_pha_ItemSearch.Size = New Size(166, 23)
        RE_pha_ItemSearch.TabIndex = 16
        ' 
        ' RE_pha_Quan
        ' 
        RE_pha_Quan.FormattingEnabled = True
        RE_pha_Quan.Location = New Point(151, 147)
        RE_pha_Quan.Name = "RE_pha_Quan"
        RE_pha_Quan.Size = New Size(84, 23)
        RE_pha_Quan.TabIndex = 15
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
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(694, 100)
        Label13.Name = "Label13"
        Label13.Size = New Size(82, 15)
        Label13.TabIndex = 13
        Label13.Text = "Cost per Unit :"
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(367, 100)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 15)
        Label11.TabIndex = 11
        Label11.Text = "Method of Use :"
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(65, 92)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 30)
        Label9.TabIndex = 9
        Label9.Text = "Dosage " & vbLf & "(Drugs Only) :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(61, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 15)
        Label8.TabIndex = 8
        Label8.Text = "Drug Number :"
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
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ReQuiPhaDate)
        Panel1.Controls.Add(r_ph_RequiBy)
        Panel1.Controls.Add(r_ph_wardName)
        Panel1.Controls.Add(r_ph_WardNum)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(49, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1031, 57)
        Panel1.TabIndex = 30
        ' 
        ' ReQuiPhaDate
        ' 
        ReQuiPhaDate.Location = New Point(820, 18)
        ReQuiPhaDate.Name = "ReQuiPhaDate"
        ReQuiPhaDate.Size = New Size(189, 23)
        ReQuiPhaDate.TabIndex = 9
        ' 
        ' r_ph_RequiBy
        ' 
        r_ph_RequiBy.BorderStyle = BorderStyle.FixedSingle
        r_ph_RequiBy.Location = New Point(542, 18)
        r_ph_RequiBy.Name = "r_ph_RequiBy"
        r_ph_RequiBy.Size = New Size(153, 23)
        r_ph_RequiBy.TabIndex = 8
        ' 
        ' r_ph_wardName
        ' 
        r_ph_wardName.BorderStyle = BorderStyle.FixedSingle
        r_ph_wardName.Location = New Point(284, 18)
        r_ph_wardName.Name = "r_ph_wardName"
        r_ph_wardName.Size = New Size(145, 23)
        r_ph_wardName.TabIndex = 7
        ' 
        ' r_ph_WardNum
        ' 
        r_ph_WardNum.BorderStyle = BorderStyle.FixedSingle
        r_ph_WardNum.Location = New Point(106, 18)
        r_ph_WardNum.Name = "r_ph_WardNum"
        r_ph_WardNum.Size = New Size(90, 23)
        r_ph_WardNum.TabIndex = 6
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(715, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 15)
        Label6.TabIndex = 5
        Label6.Text = "Requisition Date :"
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.WindowText
        Label2.Location = New Point(459, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 25)
        Label2.TabIndex = 29
        Label2.Text = "Pharmaceutical Supply"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(502, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 30)
        Label1.TabIndex = 28
        Label1.Text = "REQUISITION"
        ' 
        ' RequisitionPharma
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1124, 614)
        Controls.Add(DataGridReqPhama)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RequisitionPharma"
        Text = "4"
        CType(DataGridReqPhama, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(btnsearchRepharma, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridReqPhama As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents RE_pha_btnAdd As Button
    Friend WithEvents RE_pha_CPU As TextBox
    Friend WithEvents RE_pha_Desc As TextBox
    Friend WithEvents RE_pha_mOus As TextBox
    Friend WithEvents RE_pha_Name As TextBox
    Friend WithEvents RE_pha_Dosage As TextBox
    Friend WithEvents RE_pha_DraNumber As TextBox
    Friend WithEvents RE_pha_ItemSearch As TextBox
    Friend WithEvents RE_pha_Quan As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReQuiPhaDate As DateTimePicker
    Friend WithEvents r_ph_RequiBy As TextBox
    Friend WithEvents r_ph_wardName As TextBox
    Friend WithEvents r_ph_WardNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsearchRepharma As PictureBox
End Class
