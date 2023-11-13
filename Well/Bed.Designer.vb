<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bed))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.butEdit = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.LabelBedstatus = New System.Windows.Forms.Label()
        Me.LabelWard = New System.Windows.Forms.Label()
        Me.wardtxt = New System.Windows.Forms.TextBox()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.btnsearchbed = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bedstatus = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearchbed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 239)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(993, 276)
        Me.DataGridView1.TabIndex = 2
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(442, 195)
        Me.butAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(64, 20)
        Me.butAdd.TabIndex = 22
        Me.butAdd.Text = "ADD"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'butEdit
        '
        Me.butEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.butEdit.Location = New System.Drawing.Point(529, 195)
        Me.butEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butEdit.Name = "butEdit"
        Me.butEdit.Size = New System.Drawing.Size(64, 20)
        Me.butEdit.TabIndex = 23
        Me.butEdit.Text = "EDIT"
        Me.butEdit.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(616, 195)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(64, 20)
        Me.ButDelete.TabIndex = 24
        Me.ButDelete.Text = "DELETE"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'LabelBedstatus
        '
        Me.LabelBedstatus.AutoSize = True
        Me.LabelBedstatus.Location = New System.Drawing.Point(430, 32)
        Me.LabelBedstatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBedstatus.Name = "LabelBedstatus"
        Me.LabelBedstatus.Size = New System.Drawing.Size(65, 13)
        Me.LabelBedstatus.TabIndex = 26
        Me.LabelBedstatus.Text = "Bed Status :"
        '
        'LabelWard
        '
        Me.LabelWard.AutoSize = True
        Me.LabelWard.Location = New System.Drawing.Point(779, 32)
        Me.LabelWard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWard.Name = "LabelWard"
        Me.LabelWard.Size = New System.Drawing.Size(39, 13)
        Me.LabelWard.TabIndex = 28
        Me.LabelWard.Text = "Ward :"
        '
        'wardtxt
        '
        Me.wardtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wardtxt.Location = New System.Drawing.Point(819, 29)
        Me.wardtxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.wardtxt.Name = "wardtxt"
        Me.wardtxt.Size = New System.Drawing.Size(127, 20)
        Me.wardtxt.TabIndex = 37
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Location = New System.Drawing.Point(858, 197)
        Me.txtboxsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(132, 20)
        Me.txtboxsearch.TabIndex = 40
        '
        'btnsearchbed
        '
        Me.btnsearchbed.Image = CType(resources.GetObject("btnsearchbed.Image"), System.Drawing.Image)
        Me.btnsearchbed.Location = New System.Drawing.Point(995, 197)
        Me.btnsearchbed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearchbed.Name = "btnsearchbed"
        Me.btnsearchbed.Size = New System.Drawing.Size(34, 20)
        Me.btnsearchbed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchbed.TabIndex = 41
        Me.btnsearchbed.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(532, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "BEDS"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bedstatus)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelBedstatus)
        Me.Panel1.Controls.Add(Me.LabelWard)
        Me.Panel1.Controls.Add(Me.wardtxt)
        Me.Panel1.Location = New System.Drawing.Point(38, 70)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 87)
        Me.Panel1.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "BedID :"
        '
        'bedstatus
        '
        Me.bedstatus.FormattingEnabled = True
        Me.bedstatus.Items.AddRange(New Object() {"Occupied", "Vacant"})
        Me.bedstatus.Location = New System.Drawing.Point(498, 28)
        Me.bedstatus.Name = "bedstatus"
        Me.bedstatus.Size = New System.Drawing.Size(127, 21)
        Me.bedstatus.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(146, 29)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(950, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Bed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsearchbed)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.butEdit)
        Me.Controls.Add(Me.butAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Bed"
        Me.Text = "Bed"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearchbed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents butAdd As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents ButDelete As Button
    Friend WithEvents LabelBedstatus As Label
    Friend WithEvents LabelWard As Label
    Friend WithEvents wardtxt As TextBox
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents btnsearchbed As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bedstatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
