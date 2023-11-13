<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAllocation))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.butEdit = New System.Windows.Forms.Button()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.LabelPatients = New System.Windows.Forms.Label()
        Me.txtBoxWard = New System.Windows.Forms.TextBox()
        Me.wardtoallocate = New System.Windows.Forms.Label()
        Me.weekend = New System.Windows.Forms.Label()
        Me.weekbegin = New System.Windows.Forms.Label()
        Me.txtBoxPatient = New System.Windows.Forms.TextBox()
        Me.staffid = New System.Windows.Forms.Label()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.txtAllocationID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimeDis = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeAllocate = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchpatientallo = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearchpatientallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(986, 310)
        Me.DataGridView1.TabIndex = 45
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(622, 209)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(64, 20)
        Me.ButDelete.TabIndex = 44
        Me.ButDelete.Text = "DELETE"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'butEdit
        '
        Me.butEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.butEdit.Location = New System.Drawing.Point(530, 209)
        Me.butEdit.Name = "butEdit"
        Me.butEdit.Size = New System.Drawing.Size(64, 20)
        Me.butEdit.TabIndex = 43
        Me.butEdit.Text = "EDIT"
        Me.butEdit.UseVisualStyleBackColor = False
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(434, 209)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(64, 20)
        Me.butAdd.TabIndex = 42
        Me.butAdd.Text = "ADD"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'LabelPatients
        '
        Me.LabelPatients.AutoSize = True
        Me.LabelPatients.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPatients.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelPatients.Location = New System.Drawing.Point(429, 9)
        Me.LabelPatients.Name = "LabelPatients"
        Me.LabelPatients.Size = New System.Drawing.Size(247, 30)
        Me.LabelPatients.TabIndex = 25
        Me.LabelPatients.Text = "PATIENTS ALLOCATION"
        '
        'txtBoxWard
        '
        Me.txtBoxWard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxWard.Location = New System.Drawing.Point(813, 30)
        Me.txtBoxWard.Name = "txtBoxWard"
        Me.txtBoxWard.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxWard.TabIndex = 64
        '
        'wardtoallocate
        '
        Me.wardtoallocate.AutoSize = True
        Me.wardtoallocate.Location = New System.Drawing.Point(718, 33)
        Me.wardtoallocate.Name = "wardtoallocate"
        Me.wardtoallocate.Size = New System.Drawing.Size(96, 13)
        Me.wardtoallocate.TabIndex = 61
        Me.wardtoallocate.Text = "Ward To Allocate :"
        '
        'weekend
        '
        Me.weekend.AutoSize = True
        Me.weekend.Location = New System.Drawing.Point(368, 88)
        Me.weekend.Name = "weekend"
        Me.weekend.Size = New System.Drawing.Size(90, 13)
        Me.weekend.TabIndex = 59
        Me.weekend.Text = "Discharge Date  :"
        '
        'weekbegin
        '
        Me.weekbegin.AutoSize = True
        Me.weekbegin.Location = New System.Drawing.Point(38, 89)
        Me.weekbegin.Name = "weekbegin"
        Me.weekbegin.Size = New System.Drawing.Size(77, 13)
        Me.weekbegin.TabIndex = 57
        Me.weekbegin.Text = "Allocate Date :"
        '
        'txtBoxPatient
        '
        Me.txtBoxPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxPatient.Location = New System.Drawing.Point(463, 30)
        Me.txtBoxPatient.Name = "txtBoxPatient"
        Me.txtBoxPatient.Size = New System.Drawing.Size(123, 20)
        Me.txtBoxPatient.TabIndex = 56
        '
        'staffid
        '
        Me.staffid.AutoSize = True
        Me.staffid.Location = New System.Drawing.Point(401, 32)
        Me.staffid.Name = "staffid"
        Me.staffid.Size = New System.Drawing.Size(57, 13)
        Me.staffid.TabIndex = 55
        Me.staffid.Text = "PatientID :"
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Location = New System.Drawing.Point(870, 211)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(123, 20)
        Me.txtboxsearch.TabIndex = 65
        '
        'txtAllocationID
        '
        Me.txtAllocationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAllocationID.Location = New System.Drawing.Point(119, 31)
        Me.txtAllocationID.Name = "txtAllocationID"
        Me.txtAllocationID.Size = New System.Drawing.Size(110, 20)
        Me.txtAllocationID.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Allocation ID :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DateTimeDis)
        Me.Panel1.Controls.Add(Me.DateTimeAllocate)
        Me.Panel1.Controls.Add(Me.txtAllocationID)
        Me.Panel1.Controls.Add(Me.weekbegin)
        Me.Panel1.Controls.Add(Me.txtBoxWard)
        Me.Panel1.Controls.Add(Me.wardtoallocate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBoxPatient)
        Me.Panel1.Controls.Add(Me.weekend)
        Me.Panel1.Controls.Add(Me.staffid)
        Me.Panel1.Location = New System.Drawing.Point(40, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 149)
        Me.Panel1.TabIndex = 68
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(943, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(592, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'DateTimeDis
        '
        Me.DateTimeDis.Location = New System.Drawing.Point(461, 88)
        Me.DateTimeDis.Name = "DateTimeDis"
        Me.DateTimeDis.Size = New System.Drawing.Size(123, 20)
        Me.DateTimeDis.TabIndex = 69
        '
        'DateTimeAllocate
        '
        Me.DateTimeAllocate.Location = New System.Drawing.Point(119, 88)
        Me.DateTimeAllocate.Name = "DateTimeAllocate"
        Me.DateTimeAllocate.Size = New System.Drawing.Size(110, 20)
        Me.DateTimeAllocate.TabIndex = 68
        '
        'btnsearchpatientallo
        '
        Me.btnsearchpatientallo.Image = CType(resources.GetObject("btnsearchpatientallo.Image"), System.Drawing.Image)
        Me.btnsearchpatientallo.Location = New System.Drawing.Point(997, 211)
        Me.btnsearchpatientallo.Name = "btnsearchpatientallo"
        Me.btnsearchpatientallo.Size = New System.Drawing.Size(31, 20)
        Me.btnsearchpatientallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchpatientallo.TabIndex = 70
        Me.btnsearchpatientallo.TabStop = False
        '
        'PatientAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.btnsearchpatientallo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.butEdit)
        Me.Controls.Add(Me.butAdd)
        Me.Controls.Add(Me.LabelPatients)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PatientAllocation"
        Me.Text = "PatientAllocation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearchpatientallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButDelete As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents butAdd As Button
    Friend WithEvents LabelPatients As Label
    Friend WithEvents txtBoxWard As TextBox
    Friend WithEvents wardtoallocate As Label
    Friend WithEvents weekend As Label
    Friend WithEvents weekbegin As Label
    Friend WithEvents txtBoxPatient As TextBox
    Friend WithEvents staffid As Label
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents txtAllocationID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearchpatientallo As PictureBox
    Friend WithEvents DateTimeDis As DateTimePicker
    Friend WithEvents DateTimeAllocate As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
