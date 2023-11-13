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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWard))
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.txtboxtotalbeds = New System.Windows.Forms.TextBox()
        Me.txttelext = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtboxlocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxwardname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.PictureBox()
        Me.txtboxwardnum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Location = New System.Drawing.Point(873, 250)
        Me.txtboxsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(112, 20)
        Me.txtboxsearch.TabIndex = 54
        '
        'txtboxtotalbeds
        '
        Me.txtboxtotalbeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxtotalbeds.Location = New System.Drawing.Point(466, 89)
        Me.txtboxtotalbeds.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxtotalbeds.Name = "txtboxtotalbeds"
        Me.txtboxtotalbeds.Size = New System.Drawing.Size(124, 20)
        Me.txtboxtotalbeds.TabIndex = 46
        '
        'txttelext
        '
        Me.txttelext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelext.Location = New System.Drawing.Point(168, 88)
        Me.txttelext.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txttelext.Name = "txttelext"
        Me.txttelext.Size = New System.Drawing.Size(110, 20)
        Me.txttelext.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(397, 93)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Total Beds :"
        '
        'txtboxlocation
        '
        Me.txtboxlocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxlocation.Location = New System.Drawing.Point(787, 34)
        Me.txtboxlocation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxlocation.Name = "txtboxlocation"
        Me.txtboxlocation.Size = New System.Drawing.Size(123, 20)
        Me.txtboxlocation.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(718, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Location :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tel Extention :"
        '
        'txtboxwardname
        '
        Me.txtboxwardname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxwardname.Location = New System.Drawing.Point(466, 35)
        Me.txtboxwardname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxwardname.Name = "txtboxwardname"
        Me.txtboxwardname.Size = New System.Drawing.Size(124, 20)
        Me.txtboxwardname.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Ward Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(536, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "WARD"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(74, 288)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(956, 226)
        Me.DataGridView1.TabIndex = 60
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnedit.Location = New System.Drawing.Point(548, 248)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(64, 20)
        Me.btnedit.TabIndex = 63
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(629, 248)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(64, 20)
        Me.btndelete.TabIndex = 62
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnadd.Location = New System.Drawing.Point(468, 248)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(64, 20)
        Me.btnadd.TabIndex = 61
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(989, 250)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(46, 20)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearch.TabIndex = 64
        Me.btnsearch.TabStop = False
        '
        'txtboxwardnum
        '
        Me.txtboxwardnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxwardnum.Location = New System.Drawing.Point(168, 35)
        Me.txtboxwardnum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxwardnum.Name = "txtboxwardnum"
        Me.txtboxwardnum.Size = New System.Drawing.Size(110, 20)
        Me.txtboxwardnum.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Ward Number:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtboxwardnum)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txttelext)
        Me.Panel1.Controls.Add(Me.txtboxwardname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtboxtotalbeds)
        Me.Panel1.Controls.Add(Me.txtboxlocation)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(74, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 148)
        Me.Panel1.TabIndex = 68
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Location = New System.Drawing.Point(74, 263)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 20)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "SUPPLIES IN WARDS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormWard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormWard"
        Me.Text = "FormWard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
