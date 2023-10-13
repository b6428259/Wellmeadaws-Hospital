<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InPatient
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(InPatient))
        ExpectedLeavetxt = New TextBox()
        LabelExpectedLeave = New Label()
        WardIDtxt = New TextBox()
        DataGridView1 = New DataGridView()
        ButDelete = New Button()
        butEdit = New Button()
        butAdd = New Button()
        LabelActualLeft = New Label()
        LabelWardID = New Label()
        LabelDurationOfStay = New Label()
        LabelPatientID = New Label()
        LabelWaitingDate = New Label()
        LabelPatients = New Label()
        WaitingDatetxt = New TextBox()
        DatePlacedtxt = New TextBox()
        LabelDatePlaced = New Label()
        PatientIDtxt = New TextBox()
        DurationOfStaytxt = New TextBox()
        ActualLefttxt = New TextBox()
        btnsearch = New PictureBox()
        txtboxsearch = New TextBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExpectedLeavetxt
        ' 
        ExpectedLeavetxt.BorderStyle = BorderStyle.FixedSingle
        ExpectedLeavetxt.Location = New Point(137, 121)
        ExpectedLeavetxt.Margin = New Padding(3, 4, 3, 4)
        ExpectedLeavetxt.Name = "ExpectedLeavetxt"
        ExpectedLeavetxt.Size = New Size(151, 27)
        ExpectedLeavetxt.TabIndex = 76
        ' 
        ' LabelExpectedLeave
        ' 
        LabelExpectedLeave.AutoSize = True
        LabelExpectedLeave.Location = New Point(9, 132)
        LabelExpectedLeave.Name = "LabelExpectedLeave"
        LabelExpectedLeave.Size = New Size(115, 20)
        LabelExpectedLeave.TabIndex = 75
        LabelExpectedLeave.Text = "ExpectedLeave :"
        ' 
        ' WardIDtxt
        ' 
        WardIDtxt.BorderStyle = BorderStyle.FixedSingle
        WardIDtxt.Location = New Point(531, 27)
        WardIDtxt.Margin = New Padding(3, 4, 3, 4)
        WardIDtxt.Name = "WardIDtxt"
        WardIDtxt.Size = New Size(187, 27)
        WardIDtxt.TabIndex = 73
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(41, 464)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1181, 303)
        DataGridView1.TabIndex = 71
        ' 
        ' ButDelete
        ' 
        ButDelete.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        ButDelete.Location = New Point(690, 196)
        ButDelete.Margin = New Padding(3, 4, 3, 4)
        ButDelete.Name = "ButDelete"
        ButDelete.Size = New Size(86, 31)
        ButDelete.TabIndex = 70
        ButDelete.Text = "DELETE"
        ButDelete.UseVisualStyleBackColor = False
        ' 
        ' butEdit
        ' 
        butEdit.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        butEdit.Location = New Point(567, 196)
        butEdit.Margin = New Padding(3, 4, 3, 4)
        butEdit.Name = "butEdit"
        butEdit.Size = New Size(86, 31)
        butEdit.TabIndex = 69
        butEdit.Text = "EDIT"
        butEdit.UseVisualStyleBackColor = False
        ' 
        ' butAdd
        ' 
        butAdd.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        butAdd.Location = New Point(439, 196)
        butAdd.Margin = New Padding(3, 4, 3, 4)
        butAdd.Name = "butAdd"
        butAdd.Size = New Size(86, 31)
        butAdd.TabIndex = 68
        butAdd.Text = "ADD"
        butAdd.UseVisualStyleBackColor = False
        ' 
        ' LabelActualLeft
        ' 
        LabelActualLeft.AutoSize = True
        LabelActualLeft.Location = New Point(475, 125)
        LabelActualLeft.Name = "LabelActualLeft"
        LabelActualLeft.Size = New Size(83, 20)
        LabelActualLeft.TabIndex = 60
        LabelActualLeft.Text = "ActualLeft :"
        ' 
        ' LabelWardID
        ' 
        LabelWardID.AutoSize = True
        LabelWardID.Location = New Point(457, 34)
        LabelWardID.Name = "LabelWardID"
        LabelWardID.Size = New Size(66, 20)
        LabelWardID.TabIndex = 59
        LabelWardID.Text = "WardID :"
        ' 
        ' LabelDurationOfStay
        ' 
        LabelDurationOfStay.AutoSize = True
        LabelDurationOfStay.Location = New Point(445, 60)
        LabelDurationOfStay.Name = "LabelDurationOfStay"
        LabelDurationOfStay.Size = New Size(118, 20)
        LabelDurationOfStay.TabIndex = 58
        LabelDurationOfStay.Text = "DurationOfStay :"
        ' 
        ' LabelPatientID
        ' 
        LabelPatientID.AutoSize = True
        LabelPatientID.Location = New Point(56, 29)
        LabelPatientID.Name = "LabelPatientID"
        LabelPatientID.Size = New Size(76, 20)
        LabelPatientID.TabIndex = 57
        LabelPatientID.Text = "PatientID :"
        ' 
        ' LabelWaitingDate
        ' 
        LabelWaitingDate.AutoSize = True
        LabelWaitingDate.Location = New Point(26, 60)
        LabelWaitingDate.Name = "LabelWaitingDate"
        LabelWaitingDate.Size = New Size(99, 20)
        LabelWaitingDate.TabIndex = 56
        LabelWaitingDate.Text = "WaitingDate :"
        ' 
        ' LabelPatients
        ' 
        LabelPatients.AutoSize = True
        LabelPatients.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPatients.Location = New Point(537, 25)
        LabelPatients.Name = "LabelPatients"
        LabelPatients.Size = New Size(140, 37)
        LabelPatients.TabIndex = 53
        LabelPatients.Text = "PATIENTS"
        ' 
        ' WaitingDatetxt
        ' 
        WaitingDatetxt.BorderStyle = BorderStyle.FixedSingle
        WaitingDatetxt.Location = New Point(137, 56)
        WaitingDatetxt.Margin = New Padding(3, 4, 3, 4)
        WaitingDatetxt.Name = "WaitingDatetxt"
        WaitingDatetxt.Size = New Size(151, 27)
        WaitingDatetxt.TabIndex = 78
        ' 
        ' DatePlacedtxt
        ' 
        DatePlacedtxt.BorderStyle = BorderStyle.FixedSingle
        DatePlacedtxt.Location = New Point(928, 56)
        DatePlacedtxt.Margin = New Padding(3, 4, 3, 4)
        DatePlacedtxt.Name = "DatePlacedtxt"
        DatePlacedtxt.Size = New Size(187, 27)
        DatePlacedtxt.TabIndex = 80
        ' 
        ' LabelDatePlaced
        ' 
        LabelDatePlaced.AutoSize = True
        LabelDatePlaced.Location = New Point(831, 59)
        LabelDatePlaced.Name = "LabelDatePlaced"
        LabelDatePlaced.Size = New Size(92, 20)
        LabelDatePlaced.TabIndex = 79
        LabelDatePlaced.Text = "DatePlaced :"
        ' 
        ' PatientIDtxt
        ' 
        PatientIDtxt.BorderStyle = BorderStyle.FixedSingle
        PatientIDtxt.Location = New Point(137, 27)
        PatientIDtxt.Margin = New Padding(3, 4, 3, 4)
        PatientIDtxt.Name = "PatientIDtxt"
        PatientIDtxt.Size = New Size(151, 27)
        PatientIDtxt.TabIndex = 81
        ' 
        ' DurationOfStaytxt
        ' 
        DurationOfStaytxt.BorderStyle = BorderStyle.FixedSingle
        DurationOfStaytxt.Location = New Point(567, 56)
        DurationOfStaytxt.Margin = New Padding(3, 4, 3, 4)
        DurationOfStaytxt.Name = "DurationOfStaytxt"
        DurationOfStaytxt.Size = New Size(151, 27)
        DurationOfStaytxt.TabIndex = 82
        ' 
        ' ActualLefttxt
        ' 
        ActualLefttxt.BorderStyle = BorderStyle.FixedSingle
        ActualLefttxt.Location = New Point(567, 121)
        ActualLefttxt.Margin = New Padding(3, 4, 3, 4)
        ActualLefttxt.Name = "ActualLefttxt"
        ActualLefttxt.Size = New Size(151, 27)
        ActualLefttxt.TabIndex = 83
        ' 
        ' btnsearch
        ' 
        btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), Image)
        btnsearch.Location = New Point(1129, 192)
        btnsearch.Margin = New Padding(3, 4, 3, 4)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(61, 36)
        btnsearch.SizeMode = PictureBoxSizeMode.Zoom
        btnsearch.TabIndex = 0
        btnsearch.TabStop = False
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Location = New Point(928, 192)
        txtboxsearch.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch.Multiline = True
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(212, 34)
        txtboxsearch.TabIndex = 38
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtboxsearch)
        Panel2.Controls.Add(LabelWaitingDate)
        Panel2.Controls.Add(btnsearch)
        Panel2.Controls.Add(ActualLefttxt)
        Panel2.Controls.Add(LabelDurationOfStay)
        Panel2.Controls.Add(DurationOfStaytxt)
        Panel2.Controls.Add(LabelActualLeft)
        Panel2.Controls.Add(DatePlacedtxt)
        Panel2.Controls.Add(butAdd)
        Panel2.Controls.Add(LabelDatePlaced)
        Panel2.Controls.Add(butEdit)
        Panel2.Controls.Add(WaitingDatetxt)
        Panel2.Controls.Add(ButDelete)
        Panel2.Controls.Add(ExpectedLeavetxt)
        Panel2.Controls.Add(LabelExpectedLeave)
        Panel2.Location = New Point(41, 189)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1179, 249)
        Panel2.TabIndex = 86
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PatientIDtxt)
        Panel1.Controls.Add(WardIDtxt)
        Panel1.Controls.Add(LabelWardID)
        Panel1.Controls.Add(LabelPatientID)
        Panel1.Location = New Point(41, 105)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1178, 75)
        Panel1.TabIndex = 87
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(535, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 38)
        Label1.TabIndex = 88
        Label1.Text = "IN PATIENTS"
        ' 
        ' InPatient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1285, 819)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(LabelPatients)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "InPatient"
        Text = "InPatient"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ExpectedLeavetxt As TextBox
    Friend WithEvents LabelExpectedLeave As Label
    Friend WithEvents WardIDtxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButDelete As Button
    Friend WithEvents butEdit As Button
    Friend WithEvents butAdd As Button
    Friend WithEvents LabelActualLeft As Label
    Friend WithEvents LabelWardID As Label
    Friend WithEvents LabelDurationOfStay As Label
    Friend WithEvents LabelPatientID As Label
    Friend WithEvents LabelWaitingDate As Label
    Friend WithEvents LabelPatients As Label
    Friend WithEvents WaitingDatetxt As TextBox
    Friend WithEvents DatePlacedtxt As TextBox
    Friend WithEvents LabelDatePlaced As Label
    Friend WithEvents PatientIDtxt As TextBox
    Friend WithEvents DurationOfStaytxt As TextBox
    Friend WithEvents ActualLefttxt As TextBox
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
