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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Bed))
        DataGridView1 = New DataGridView()
        butAdd = New Button()
        butEdit = New Button()
        ButDelete = New Button()
        LabelBedstatus = New Label()
        LabelWard = New Label()
        wardtxt = New TextBox()
        bedstatus = New TextBox()
        txtboxsearch = New TextBox()
        btnsearchbed = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearchbed, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(51, 367)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1168, 349)
        DataGridView1.TabIndex = 2
        ' 
        ' butAdd
        ' 
        butAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        butAdd.Location = New Point(462, 303)
        butAdd.Margin = New Padding(3, 4, 3, 4)
        butAdd.Name = "butAdd"
        butAdd.Size = New Size(86, 31)
        butAdd.TabIndex = 22
        butAdd.Text = "ADD"
        butAdd.UseVisualStyleBackColor = False
        ' 
        ' butEdit
        ' 
        butEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        butEdit.Location = New Point(577, 303)
        butEdit.Margin = New Padding(3, 4, 3, 4)
        butEdit.Name = "butEdit"
        butEdit.Size = New Size(86, 31)
        butEdit.TabIndex = 23
        butEdit.Text = "EDIT"
        butEdit.UseVisualStyleBackColor = False
        ' 
        ' ButDelete
        ' 
        ButDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        ButDelete.Location = New Point(693, 303)
        ButDelete.Margin = New Padding(3, 4, 3, 4)
        ButDelete.Name = "ButDelete"
        ButDelete.Size = New Size(86, 31)
        ButDelete.TabIndex = 24
        ButDelete.Text = "DELETE"
        ButDelete.UseVisualStyleBackColor = False
        ' 
        ' LabelBedstatus
        ' 
        LabelBedstatus.AutoSize = True
        LabelBedstatus.Location = New Point(130, 49)
        LabelBedstatus.Name = "LabelBedstatus"
        LabelBedstatus.Size = New Size(86, 20)
        LabelBedstatus.TabIndex = 26
        LabelBedstatus.Text = "Bed Status :"
        ' 
        ' LabelWard
        ' 
        LabelWard.AutoSize = True
        LabelWard.Location = New Point(752, 50)
        LabelWard.Name = "LabelWard"
        LabelWard.Size = New Size(51, 20)
        LabelWard.TabIndex = 28
        LabelWard.Text = "Ward :"
        ' 
        ' wardtxt
        ' 
        wardtxt.BorderStyle = BorderStyle.FixedSingle
        wardtxt.Location = New Point(806, 45)
        wardtxt.Margin = New Padding(3, 4, 3, 4)
        wardtxt.Name = "wardtxt"
        wardtxt.Size = New Size(169, 27)
        wardtxt.TabIndex = 37
        ' 
        ' bedstatus
        ' 
        bedstatus.BorderStyle = BorderStyle.FixedSingle
        bedstatus.Location = New Point(215, 45)
        bedstatus.Margin = New Padding(3, 4, 3, 4)
        bedstatus.Name = "bedstatus"
        bedstatus.Size = New Size(169, 27)
        bedstatus.TabIndex = 38
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Location = New Point(967, 305)
        txtboxsearch.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(175, 27)
        txtboxsearch.TabIndex = 40
        ' 
        ' btnsearchbed
        ' 
        btnsearchbed.Image = CType(resources.GetObject("btnsearchbed.Image"), Image)
        btnsearchbed.Location = New Point(1149, 305)
        btnsearchbed.Margin = New Padding(3, 4, 3, 4)
        btnsearchbed.Name = "btnsearchbed"
        btnsearchbed.Size = New Size(46, 31)
        btnsearchbed.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchbed.TabIndex = 41
        btnsearchbed.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(585, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 32)
        Label1.TabIndex = 43
        Label1.Text = "BEDS"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(LabelBedstatus)
        Panel1.Controls.Add(LabelWard)
        Panel1.Controls.Add(bedstatus)
        Panel1.Controls.Add(wardtxt)
        Panel1.Location = New Point(51, 107)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1168, 133)
        Panel1.TabIndex = 44
        ' 
        ' Bed
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1266, 767)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(btnsearchbed)
        Controls.Add(txtboxsearch)
        Controls.Add(ButDelete)
        Controls.Add(butEdit)
        Controls.Add(butAdd)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Bed"
        Text = "Bed"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearchbed, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents butAdd As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents ButDelete As Button
    Friend WithEvents LabelBedstatus As Label
    Friend WithEvents LabelWard As Label
    Friend WithEvents wardtxt As TextBox
    Friend WithEvents bedstatus As TextBox
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents btnsearchbed As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
