<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormWard))
        txtboxwardid = New TextBox()
        Label4 = New Label()
        txtboxsearch = New TextBox()
        txtboxtotalbeds = New TextBox()
        txttelext = New TextBox()
        Label9 = New Label()
        txtboxlocation = New TextBox()
        Label6 = New Label()
        Label3 = New Label()
        txtboxwardname = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        btnedit = New Button()
        btndelete = New Button()
        btnadd = New Button()
        btnsearch = New PictureBox()
        txtboxwardnum = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtboxwardid
        ' 
        txtboxwardid.BorderStyle = BorderStyle.FixedSingle
        txtboxwardid.Location = New Point(170, 348)
        txtboxwardid.Margin = New Padding(3, 4, 3, 4)
        txtboxwardid.Multiline = True
        txtboxwardid.Name = "txtboxwardid"
        txtboxwardid.Size = New Size(114, 30)
        txtboxwardid.TabIndex = 57
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 56
        Label4.Text = "WARD ID:"
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Location = New Point(954, 392)
        txtboxsearch.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(148, 27)
        txtboxsearch.TabIndex = 54
        ' 
        ' txtboxtotalbeds
        ' 
        txtboxtotalbeds.BorderStyle = BorderStyle.FixedSingle
        txtboxtotalbeds.Location = New Point(514, 141)
        txtboxtotalbeds.Margin = New Padding(3, 4, 3, 4)
        txtboxtotalbeds.Name = "txtboxtotalbeds"
        txtboxtotalbeds.Size = New Size(164, 27)
        txtboxtotalbeds.TabIndex = 46
        ' 
        ' txttelext
        ' 
        txttelext.BorderStyle = BorderStyle.FixedSingle
        txttelext.Location = New Point(160, 140)
        txttelext.Margin = New Padding(3, 4, 3, 4)
        txttelext.Name = "txttelext"
        txttelext.Size = New Size(146, 27)
        txttelext.TabIndex = 44
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(423, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 20)
        Label9.TabIndex = 42
        Label9.Text = "Total Beds :"
        ' 
        ' txtboxlocation
        ' 
        txtboxlocation.BorderStyle = BorderStyle.FixedSingle
        txtboxlocation.Location = New Point(855, 59)
        txtboxlocation.Margin = New Padding(3, 4, 3, 4)
        txtboxlocation.Name = "txtboxlocation"
        txtboxlocation.Size = New Size(163, 27)
        txtboxlocation.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(762, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 20)
        Label6.TabIndex = 39
        Label6.Text = "Location :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 38
        Label3.Text = "Tel Extention :"
        ' 
        ' txtboxwardname
        ' 
        txtboxwardname.BorderStyle = BorderStyle.FixedSingle
        txtboxwardname.Location = New Point(514, 59)
        txtboxwardname.Margin = New Padding(3, 4, 3, 4)
        txtboxwardname.Name = "txtboxwardname"
        txtboxwardname.Size = New Size(164, 27)
        txtboxwardname.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(414, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 36
        Label2.Text = "Ward Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(549, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 32)
        Label1.TabIndex = 35
        Label1.Text = "WARD"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(99, 443)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1070, 347)
        DataGridView1.TabIndex = 60
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        btnedit.Location = New Point(614, 384)
        btnedit.Margin = New Padding(3, 4, 3, 4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(86, 31)
        btnedit.TabIndex = 63
        btnedit.Text = "EDIT"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        btndelete.Location = New Point(721, 384)
        btndelete.Margin = New Padding(3, 4, 3, 4)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(86, 31)
        btndelete.TabIndex = 62
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        btnadd.Location = New Point(507, 384)
        btnadd.Margin = New Padding(3, 4, 3, 4)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(86, 31)
        btnadd.TabIndex = 61
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnsearch
        ' 
        btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), Image)
        btnsearch.Location = New Point(1110, 392)
        btnsearch.Margin = New Padding(3, 4, 3, 4)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(61, 31)
        btnsearch.SizeMode = PictureBoxSizeMode.Zoom
        btnsearch.TabIndex = 64
        btnsearch.TabStop = False
        ' 
        ' txtboxwardnum
        ' 
        txtboxwardnum.BorderStyle = BorderStyle.FixedSingle
        txtboxwardnum.Location = New Point(160, 59)
        txtboxwardnum.Margin = New Padding(3, 4, 3, 4)
        txtboxwardnum.Name = "txtboxwardnum"
        txtboxwardnum.Size = New Size(146, 27)
        txtboxwardnum.TabIndex = 66
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(54, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 20)
        Label5.TabIndex = 65
        Label5.Text = "Ward Number:"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtboxwardnum)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txttelext)
        Panel1.Controls.Add(txtboxwardname)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtboxtotalbeds)
        Panel1.Controls.Add(txtboxlocation)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(99, 91)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1069, 227)
        Panel1.TabIndex = 68
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.CornflowerBlue
        Button2.Location = New Point(99, 404)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 31)
        Button2.TabIndex = 72
        Button2.Text = "SUPPLIES IN WARDS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormWard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1285, 819)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(txtboxsearch)
        Controls.Add(btnsearch)
        Controls.Add(btnedit)
        Controls.Add(btndelete)
        Controls.Add(btnadd)
        Controls.Add(DataGridView1)
        Controls.Add(txtboxwardid)
        Controls.Add(Label4)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormWard"
        Text = "FormWard"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtboxwardid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents txtboxtotalbeds As TextBox
    Friend WithEvents txttelext As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtboxlocation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxwardname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents txtboxwardnum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
