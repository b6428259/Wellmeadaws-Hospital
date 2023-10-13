<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSuppiler
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormSuppiler))
        Label2 = New Label()
        Label1 = New Label()
        DataGV_sup = New DataGridView()
        Panel2 = New Panel()
        ButtonEdit = New Button()
        Button3 = New Button()
        btn_addSup = New Button()
        txt_Addr = New TextBox()
        txt_PhoneNum = New TextBox()
        txt_subName = New TextBox()
        txt_FaxNum = New TextBox()
        txt_SupId = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        btnsearchsup = New PictureBox()
        txtBoxSearchsup = New TextBox()
        CType(DataGV_sup, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(btnsearchsup, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Leelawadee UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.WindowText
        Label2.Location = New Point(520, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 31
        Label2.Text = "Suppiler"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(488, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 30)
        Label1.TabIndex = 30
        Label1.Text = "REQUISITION"
        ' 
        ' DataGV_sup
        ' 
        DataGV_sup.BorderStyle = BorderStyle.Fixed3D
        DataGV_sup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGV_sup.Location = New Point(34, 324)
        DataGV_sup.Name = "DataGV_sup"
        DataGV_sup.RowHeadersWidth = 51
        DataGV_sup.RowTemplate.Height = 25
        DataGV_sup.Size = New Size(1033, 227)
        DataGV_sup.TabIndex = 33
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_Addr)
        Panel2.Controls.Add(txt_PhoneNum)
        Panel2.Controls.Add(txt_subName)
        Panel2.Controls.Add(txt_FaxNum)
        Panel2.Controls.Add(txt_SupId)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(35, 91)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 169)
        Panel2.TabIndex = 34
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        ButtonEdit.Location = New Point(517, 281)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(75, 23)
        ButtonEdit.TabIndex = 26
        ButtonEdit.Text = "EDIT"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        Button3.Location = New Point(610, 281)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 25
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btn_addSup
        ' 
        btn_addSup.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        btn_addSup.Location = New Point(424, 281)
        btn_addSup.Name = "btn_addSup"
        btn_addSup.Size = New Size(75, 23)
        btn_addSup.TabIndex = 24
        btn_addSup.Text = "ADD"
        btn_addSup.UseVisualStyleBackColor = False
        ' 
        ' txt_Addr
        ' 
        txt_Addr.BorderStyle = BorderStyle.FixedSingle
        txt_Addr.Location = New Point(793, 54)
        txt_Addr.Multiline = True
        txt_Addr.Name = "txt_Addr"
        txt_Addr.Size = New Size(197, 95)
        txt_Addr.TabIndex = 21
        ' 
        ' txt_PhoneNum
        ' 
        txt_PhoneNum.BorderStyle = BorderStyle.FixedSingle
        txt_PhoneNum.Location = New Point(510, 99)
        txt_PhoneNum.Name = "txt_PhoneNum"
        txt_PhoneNum.Size = New Size(179, 23)
        txt_PhoneNum.TabIndex = 20
        ' 
        ' txt_subName
        ' 
        txt_subName.BorderStyle = BorderStyle.FixedSingle
        txt_subName.Location = New Point(510, 54)
        txt_subName.Name = "txt_subName"
        txt_subName.Size = New Size(179, 23)
        txt_subName.TabIndex = 19
        ' 
        ' txt_FaxNum
        ' 
        txt_FaxNum.BorderStyle = BorderStyle.FixedSingle
        txt_FaxNum.Location = New Point(131, 99)
        txt_FaxNum.Name = "txt_FaxNum"
        txt_FaxNum.Size = New Size(166, 23)
        txt_FaxNum.TabIndex = 17
        ' 
        ' txt_SupId
        ' 
        txt_SupId.BorderStyle = BorderStyle.FixedSingle
        txt_SupId.Location = New Point(131, 58)
        txt_SupId.Name = "txt_SupId"
        txt_SupId.Size = New Size(166, 23)
        txt_SupId.TabIndex = 16
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(713, 58)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 15)
        Label12.TabIndex = 12
        Label12.Text = "Address :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(413, 102)
        Label11.Name = "Label11"
        Label11.Size = New Size(97, 15)
        Label11.TabIndex = 11
        Label11.Text = "Phone Number  :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(413, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 15)
        Label10.TabIndex = 10
        Label10.Text = "Supplier Name :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(41, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 15)
        Label8.TabIndex = 8
        Label8.Text = "Fax Number :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(50, 61)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 15)
        Label7.TabIndex = 7
        Label7.Text = "Suppiler ID :"
        ' 
        ' btnsearchsup
        ' 
        btnsearchsup.Image = CType(resources.GetObject("btnsearchsup.Image"), Image)
        btnsearchsup.Location = New Point(1031, 291)
        btnsearchsup.Name = "btnsearchsup"
        btnsearchsup.Size = New Size(36, 27)
        btnsearchsup.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchsup.TabIndex = 71
        btnsearchsup.TabStop = False
        ' 
        ' txtBoxSearchsup
        ' 
        txtBoxSearchsup.BorderStyle = BorderStyle.FixedSingle
        txtBoxSearchsup.Location = New Point(880, 292)
        txtBoxSearchsup.Name = "txtBoxSearchsup"
        txtBoxSearchsup.Size = New Size(145, 23)
        txtBoxSearchsup.TabIndex = 70
        ' 
        ' FormSuppiler
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1124, 614)
        Controls.Add(btnsearchsup)
        Controls.Add(txtBoxSearchsup)
        Controls.Add(ButtonEdit)
        Controls.Add(Panel2)
        Controls.Add(Button3)
        Controls.Add(btn_addSup)
        Controls.Add(DataGV_sup)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormSuppiler"
        Text = "Form1"
        CType(DataGV_sup, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(btnsearchsup, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGV_sup As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_addSup As Button
    Friend WithEvents txt_Addr As TextBox
    Friend WithEvents txt_PhoneNum As TextBox
    Friend WithEvents txt_subName As TextBox
    Friend WithEvents txt_FaxNum As TextBox
    Friend WithEvents txt_SupId As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents btnsearchsup As PictureBox
    Friend WithEvents txtBoxSearchsup As TextBox
End Class
