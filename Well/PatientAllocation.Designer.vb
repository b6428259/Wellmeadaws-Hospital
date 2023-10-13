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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PatientAllocation))
        DataGridView1 = New DataGridView()
        ButDelete = New Button()
        butEdit = New Button()
        butAdd = New Button()
        LabelPatients = New Label()
        txtBoxWard = New TextBox()
        txtBoxDischarge = New TextBox()
        txtBoxAllocateDate = New TextBox()
        wardtoallocate = New Label()
        weekend = New Label()
        weekbegin = New Label()
        txtBoxPatient = New TextBox()
        staffid = New Label()
        txtboxsearch = New TextBox()
        txtAllocationID = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        btnsearchpatientallo = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnsearchpatientallo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(47, 279)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(981, 253)
        DataGridView1.TabIndex = 45
        ' 
        ' ButDelete
        ' 
        ButDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        ButDelete.Location = New Point(614, 241)
        ButDelete.Name = "ButDelete"
        ButDelete.Size = New Size(75, 23)
        ButDelete.TabIndex = 44
        ButDelete.Text = "DELETE"
        ButDelete.UseVisualStyleBackColor = False
        ' 
        ' butEdit
        ' 
        butEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        butEdit.Location = New Point(506, 241)
        butEdit.Name = "butEdit"
        butEdit.Size = New Size(75, 23)
        butEdit.TabIndex = 43
        butEdit.Text = "EDIT"
        butEdit.UseVisualStyleBackColor = False
        ' 
        ' butAdd
        ' 
        butAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        butAdd.Location = New Point(394, 241)
        butAdd.Name = "butAdd"
        butAdd.Size = New Size(75, 23)
        butAdd.TabIndex = 42
        butAdd.Text = "ADD"
        butAdd.UseVisualStyleBackColor = False
        ' 
        ' LabelPatients
        ' 
        LabelPatients.AutoSize = True
        LabelPatients.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPatients.ForeColor = SystemColors.WindowText
        LabelPatients.Location = New Point(408, 9)
        LabelPatients.Name = "LabelPatients"
        LabelPatients.Size = New Size(247, 30)
        LabelPatients.TabIndex = 25
        LabelPatients.Text = "PATIENTS ALLOCATION"
        ' 
        ' txtBoxWard
        ' 
        txtBoxWard.BorderStyle = BorderStyle.FixedSingle
        txtBoxWard.Location = New Point(756, 36)
        txtBoxWard.Name = "txtBoxWard"
        txtBoxWard.Size = New Size(144, 23)
        txtBoxWard.TabIndex = 64
        ' 
        ' txtBoxDischarge
        ' 
        txtBoxDischarge.BorderStyle = BorderStyle.FixedSingle
        txtBoxDischarge.Location = New Point(434, 101)
        txtBoxDischarge.Name = "txtBoxDischarge"
        txtBoxDischarge.Size = New Size(143, 23)
        txtBoxDischarge.TabIndex = 63
        ' 
        ' txtBoxAllocateDate
        ' 
        txtBoxAllocateDate.BorderStyle = BorderStyle.FixedSingle
        txtBoxAllocateDate.Location = New Point(139, 100)
        txtBoxAllocateDate.Name = "txtBoxAllocateDate"
        txtBoxAllocateDate.Size = New Size(128, 23)
        txtBoxAllocateDate.TabIndex = 62
        ' 
        ' wardtoallocate
        ' 
        wardtoallocate.AutoSize = True
        wardtoallocate.Location = New Point(645, 39)
        wardtoallocate.Name = "wardtoallocate"
        wardtoallocate.Size = New Size(102, 15)
        wardtoallocate.TabIndex = 61
        wardtoallocate.Text = "Ward To Allocate :"
        ' 
        ' weekend
        ' 
        weekend.AutoSize = True
        weekend.Location = New Point(326, 103)
        weekend.Name = "weekend"
        weekend.Size = New Size(95, 15)
        weekend.TabIndex = 59
        weekend.Text = "Discharge Date  :"
        ' 
        ' weekbegin
        ' 
        weekbegin.AutoSize = True
        weekbegin.Location = New Point(44, 103)
        weekbegin.Name = "weekbegin"
        weekbegin.Size = New Size(83, 15)
        weekbegin.TabIndex = 57
        weekbegin.Text = "Allocate Date :"
        ' 
        ' txtBoxPatient
        ' 
        txtBoxPatient.BorderStyle = BorderStyle.FixedSingle
        txtBoxPatient.Location = New Point(434, 37)
        txtBoxPatient.Name = "txtBoxPatient"
        txtBoxPatient.Size = New Size(143, 23)
        txtBoxPatient.TabIndex = 56
        ' 
        ' staffid
        ' 
        staffid.AutoSize = True
        staffid.Location = New Point(362, 39)
        staffid.Name = "staffid"
        staffid.Size = New Size(61, 15)
        staffid.TabIndex = 55
        staffid.Text = "PatientID :"
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Location = New Point(843, 246)
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(143, 23)
        txtboxsearch.TabIndex = 65
        ' 
        ' txtAllocationID
        ' 
        txtAllocationID.BorderStyle = BorderStyle.FixedSingle
        txtAllocationID.Location = New Point(139, 36)
        txtAllocationID.Name = "txtAllocationID"
        txtAllocationID.Size = New Size(128, 23)
        txtAllocationID.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 66
        Label1.Text = "Allocation ID :"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtAllocationID)
        Panel1.Controls.Add(weekbegin)
        Panel1.Controls.Add(txtBoxWard)
        Panel1.Controls.Add(wardtoallocate)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBoxDischarge)
        Panel1.Controls.Add(txtBoxAllocateDate)
        Panel1.Controls.Add(txtBoxPatient)
        Panel1.Controls.Add(weekend)
        Panel1.Controls.Add(staffid)
        Panel1.Location = New Point(47, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(981, 172)
        Panel1.TabIndex = 68
        ' 
        ' btnsearchpatientallo
        ' 
        btnsearchpatientallo.Image = CType(resources.GetObject("btnsearchpatientallo.Image"), Image)
        btnsearchpatientallo.Location = New Point(992, 246)
        btnsearchpatientallo.Name = "btnsearchpatientallo"
        btnsearchpatientallo.Size = New Size(36, 23)
        btnsearchpatientallo.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchpatientallo.TabIndex = 70
        btnsearchpatientallo.TabStop = False
        ' 
        ' PatientAllocation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1093, 544)
        Controls.Add(btnsearchpatientallo)
        Controls.Add(Panel1)
        Controls.Add(txtboxsearch)
        Controls.Add(DataGridView1)
        Controls.Add(ButDelete)
        Controls.Add(butEdit)
        Controls.Add(butAdd)
        Controls.Add(LabelPatients)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "PatientAllocation"
        Text = "PatientAllocation"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnsearchpatientallo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButDelete As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents butAdd As Button
    Friend WithEvents LabelPatients As Label
    Friend WithEvents txtBoxWard As TextBox
    Friend WithEvents txtBoxDischarge As TextBox
    Friend WithEvents txtBoxAllocateDate As TextBox
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
End Class
