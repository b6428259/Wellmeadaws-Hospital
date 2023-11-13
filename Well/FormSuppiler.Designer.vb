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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSuppiler))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGV_sup = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_Addr = New System.Windows.Forms.TextBox()
        Me.txt_PhoneNum = New System.Windows.Forms.TextBox()
        Me.txt_subName = New System.Windows.Forms.TextBox()
        Me.txt_FaxNum = New System.Windows.Forms.TextBox()
        Me.txt_SupId = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.btn_addSup = New System.Windows.Forms.Button()
        Me.btnsearchsup = New System.Windows.Forms.PictureBox()
        Me.txtBoxSearchsup = New System.Windows.Forms.TextBox()
        CType(Me.DataGV_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnsearchsup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(518, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Suppiler"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(490, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 30)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "REQUISITION"
        '
        'DataGV_sup
        '
        Me.DataGV_sup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGV_sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV_sup.Location = New System.Drawing.Point(29, 281)
        Me.DataGV_sup.Name = "DataGV_sup"
        Me.DataGV_sup.RowHeadersWidth = 51
        Me.DataGV_sup.RowTemplate.Height = 25
        Me.DataGV_sup.Size = New System.Drawing.Size(1016, 298)
        Me.DataGV_sup.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_Addr)
        Me.Panel2.Controls.Add(Me.txt_PhoneNum)
        Me.Panel2.Controls.Add(Me.txt_subName)
        Me.Panel2.Controls.Add(Me.txt_FaxNum)
        Me.Panel2.Controls.Add(Me.txt_SupId)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(30, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1015, 147)
        Me.Panel2.TabIndex = 34
        '
        'txt_Addr
        '
        Me.txt_Addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Addr.Location = New System.Drawing.Point(830, 23)
        Me.txt_Addr.Multiline = True
        Me.txt_Addr.Name = "txt_Addr"
        Me.txt_Addr.Size = New System.Drawing.Size(169, 109)
        Me.txt_Addr.TabIndex = 21
        '
        'txt_PhoneNum
        '
        Me.txt_PhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PhoneNum.Location = New System.Drawing.Point(464, 62)
        Me.txt_PhoneNum.Name = "txt_PhoneNum"
        Me.txt_PhoneNum.Size = New System.Drawing.Size(154, 20)
        Me.txt_PhoneNum.TabIndex = 20
        '
        'txt_subName
        '
        Me.txt_subName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subName.Location = New System.Drawing.Point(464, 23)
        Me.txt_subName.Name = "txt_subName"
        Me.txt_subName.Size = New System.Drawing.Size(154, 20)
        Me.txt_subName.TabIndex = 19
        '
        'txt_FaxNum
        '
        Me.txt_FaxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FaxNum.Location = New System.Drawing.Point(135, 60)
        Me.txt_FaxNum.Name = "txt_FaxNum"
        Me.txt_FaxNum.Size = New System.Drawing.Size(143, 20)
        Me.txt_FaxNum.TabIndex = 17
        '
        'txt_SupId
        '
        Me.txt_SupId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SupId.Location = New System.Drawing.Point(135, 24)
        Me.txt_SupId.Name = "txt_SupId"
        Me.txt_SupId.Size = New System.Drawing.Size(143, 20)
        Me.txt_SupId.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(761, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Address :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(381, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Phone Number  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(381, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Supplier Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fax Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Suppiler ID :"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ButtonEdit.Location = New System.Drawing.Point(535, 243)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(64, 20)
        Me.ButtonEdit.TabIndex = 26
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonDel
        '
        Me.ButtonDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButtonDel.Location = New System.Drawing.Point(615, 243)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(64, 20)
        Me.ButtonDel.TabIndex = 25
        Me.ButtonDel.Text = "DELETE"
        Me.ButtonDel.UseVisualStyleBackColor = False
        '
        'btn_addSup
        '
        Me.btn_addSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btn_addSup.Location = New System.Drawing.Point(455, 243)
        Me.btn_addSup.Name = "btn_addSup"
        Me.btn_addSup.Size = New System.Drawing.Size(64, 20)
        Me.btn_addSup.TabIndex = 24
        Me.btn_addSup.Text = "ADD"
        Me.btn_addSup.UseVisualStyleBackColor = False
        '
        'btnsearchsup
        '
        Me.btnsearchsup.Image = CType(resources.GetObject("btnsearchsup.Image"), System.Drawing.Image)
        Me.btnsearchsup.Location = New System.Drawing.Point(1016, 254)
        Me.btnsearchsup.Name = "btnsearchsup"
        Me.btnsearchsup.Size = New System.Drawing.Size(31, 23)
        Me.btnsearchsup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchsup.TabIndex = 71
        Me.btnsearchsup.TabStop = False
        '
        'txtBoxSearchsup
        '
        Me.txtBoxSearchsup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSearchsup.Location = New System.Drawing.Point(886, 255)
        Me.txtBoxSearchsup.Name = "txtBoxSearchsup"
        Me.txtBoxSearchsup.Size = New System.Drawing.Size(125, 20)
        Me.txtBoxSearchsup.TabIndex = 70
        '
        'FormSuppiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.btnsearchsup)
        Me.Controls.Add(Me.txtBoxSearchsup)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.btn_addSup)
        Me.Controls.Add(Me.DataGV_sup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSuppiler"
        Me.Text = "Form1"
        CType(Me.DataGV_sup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnsearchsup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGV_sup As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonDel As Button
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
