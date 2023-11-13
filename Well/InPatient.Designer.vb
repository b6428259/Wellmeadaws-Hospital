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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InPatient))
        Me.LabelExpectedLeave = New System.Windows.Forms.Label()
        Me.WardIDtxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.butEdit = New System.Windows.Forms.Button()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.LabelActualLeft = New System.Windows.Forms.Label()
        Me.LabelWardID = New System.Windows.Forms.Label()
        Me.LabelDurationOfStay = New System.Windows.Forms.Label()
        Me.LabelPatientID = New System.Windows.Forms.Label()
        Me.LabelWaitingDate = New System.Windows.Forms.Label()
        Me.LabelPatients = New System.Windows.Forms.Label()
        Me.LabelDatePlaced = New System.Windows.Forms.Label()
        Me.PatientIDtxt = New System.Windows.Forms.TextBox()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDurationOfStay = New System.Windows.Forms.NumericUpDown()
        Me.lblActualLeft = New System.Windows.Forms.DateTimePicker()
        Me.lblExpectedLeave = New System.Windows.Forms.DateTimePicker()
        Me.lblDatePlaced = New System.Windows.Forms.DateTimePicker()
        Me.lblWaitingDate = New System.Windows.Forms.DateTimePicker()
        Me.btnsearch = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.lblDurationOfStay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelExpectedLeave
        '
        Me.LabelExpectedLeave.AutoSize = True
        Me.LabelExpectedLeave.Location = New System.Drawing.Point(32, 84)
        Me.LabelExpectedLeave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelExpectedLeave.Name = "LabelExpectedLeave"
        Me.LabelExpectedLeave.Size = New System.Drawing.Size(88, 13)
        Me.LabelExpectedLeave.TabIndex = 75
        Me.LabelExpectedLeave.Text = "ExpectedLeave :"
        '
        'WardIDtxt
        '
        Me.WardIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WardIDtxt.Location = New System.Drawing.Point(56, 15)
        Me.WardIDtxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.WardIDtxt.Name = "WardIDtxt"
        Me.WardIDtxt.Size = New System.Drawing.Size(92, 20)
        Me.WardIDtxt.TabIndex = 73
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 342)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 238)
        Me.DataGridView1.TabIndex = 71
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(604, 133)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(64, 20)
        Me.ButDelete.TabIndex = 70
        Me.ButDelete.Text = "DELETE"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'butEdit
        '
        Me.butEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.butEdit.Location = New System.Drawing.Point(511, 133)
        Me.butEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butEdit.Name = "butEdit"
        Me.butEdit.Size = New System.Drawing.Size(64, 20)
        Me.butEdit.TabIndex = 69
        Me.butEdit.Text = "EDIT"
        Me.butEdit.UseVisualStyleBackColor = False
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(415, 133)
        Me.butAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(64, 20)
        Me.butAdd.TabIndex = 68
        Me.butAdd.Text = "ADD"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'LabelActualLeft
        '
        Me.LabelActualLeft.AutoSize = True
        Me.LabelActualLeft.Location = New System.Drawing.Point(381, 79)
        Me.LabelActualLeft.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActualLeft.Name = "LabelActualLeft"
        Me.LabelActualLeft.Size = New System.Drawing.Size(61, 13)
        Me.LabelActualLeft.TabIndex = 60
        Me.LabelActualLeft.Text = "ActualLeft :"
        '
        'LabelWardID
        '
        Me.LabelWardID.AutoSize = True
        Me.LabelWardID.Location = New System.Drawing.Point(2, 17)
        Me.LabelWardID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWardID.Name = "LabelWardID"
        Me.LabelWardID.Size = New System.Drawing.Size(50, 13)
        Me.LabelWardID.TabIndex = 59
        Me.LabelWardID.Text = "WardID :"
        '
        'LabelDurationOfStay
        '
        Me.LabelDurationOfStay.AutoSize = True
        Me.LabelDurationOfStay.Location = New System.Drawing.Point(359, 37)
        Me.LabelDurationOfStay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDurationOfStay.Name = "LabelDurationOfStay"
        Me.LabelDurationOfStay.Size = New System.Drawing.Size(85, 13)
        Me.LabelDurationOfStay.TabIndex = 58
        Me.LabelDurationOfStay.Text = "DurationOfStay :"
        '
        'LabelPatientID
        '
        Me.LabelPatientID.AutoSize = True
        Me.LabelPatientID.Location = New System.Drawing.Point(3, 16)
        Me.LabelPatientID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPatientID.Name = "LabelPatientID"
        Me.LabelPatientID.Size = New System.Drawing.Size(57, 13)
        Me.LabelPatientID.TabIndex = 57
        Me.LabelPatientID.Text = "PatientID :"
        '
        'LabelWaitingDate
        '
        Me.LabelWaitingDate.AutoSize = True
        Me.LabelWaitingDate.Location = New System.Drawing.Point(45, 37)
        Me.LabelWaitingDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWaitingDate.Name = "LabelWaitingDate"
        Me.LabelWaitingDate.Size = New System.Drawing.Size(72, 13)
        Me.LabelWaitingDate.TabIndex = 56
        Me.LabelWaitingDate.Text = "WaitingDate :"
        '
        'LabelPatients
        '
        Me.LabelPatients.AutoSize = True
        Me.LabelPatients.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPatients.Location = New System.Drawing.Point(509, 5)
        Me.LabelPatients.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPatients.Name = "LabelPatients"
        Me.LabelPatients.Size = New System.Drawing.Size(110, 30)
        Me.LabelPatients.TabIndex = 53
        Me.LabelPatients.Text = "PATIENTS"
        '
        'LabelDatePlaced
        '
        Me.LabelDatePlaced.AutoSize = True
        Me.LabelDatePlaced.Location = New System.Drawing.Point(648, 36)
        Me.LabelDatePlaced.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDatePlaced.Name = "LabelDatePlaced"
        Me.LabelDatePlaced.Size = New System.Drawing.Size(69, 13)
        Me.LabelDatePlaced.TabIndex = 79
        Me.LabelDatePlaced.Text = "DatePlaced :"
        '
        'PatientIDtxt
        '
        Me.PatientIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientIDtxt.Location = New System.Drawing.Point(59, 14)
        Me.PatientIDtxt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PatientIDtxt.Name = "PatientIDtxt"
        Me.PatientIDtxt.Size = New System.Drawing.Size(114, 20)
        Me.PatientIDtxt.TabIndex = 81
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Location = New System.Drawing.Point(860, 313)
        Me.txtboxsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch.Multiline = True
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(150, 23)
        Me.txtboxsearch.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblDurationOfStay)
        Me.Panel2.Controls.Add(Me.lblActualLeft)
        Me.Panel2.Controls.Add(Me.lblExpectedLeave)
        Me.Panel2.Controls.Add(Me.lblDatePlaced)
        Me.Panel2.Controls.Add(Me.lblWaitingDate)
        Me.Panel2.Controls.Add(Me.LabelWaitingDate)
        Me.Panel2.Controls.Add(Me.LabelDurationOfStay)
        Me.Panel2.Controls.Add(Me.LabelActualLeft)
        Me.Panel2.Controls.Add(Me.LabelDatePlaced)
        Me.Panel2.Controls.Add(Me.ButDelete)
        Me.Panel2.Controls.Add(Me.butEdit)
        Me.Panel2.Controls.Add(Me.butAdd)
        Me.Panel2.Controls.Add(Me.LabelExpectedLeave)
        Me.Panel2.Location = New System.Drawing.Point(18, 123)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1035, 177)
        Me.Panel2.TabIndex = 86
        '
        'lblDurationOfStay
        '
        Me.lblDurationOfStay.Location = New System.Drawing.Point(447, 35)
        Me.lblDurationOfStay.Name = "lblDurationOfStay"
        Me.lblDurationOfStay.Size = New System.Drawing.Size(120, 20)
        Me.lblDurationOfStay.TabIndex = 87
        '
        'lblActualLeft
        '
        Me.lblActualLeft.CustomFormat = "dd-MM-yyyy"
        Me.lblActualLeft.Location = New System.Drawing.Point(447, 77)
        Me.lblActualLeft.Name = "lblActualLeft"
        Me.lblActualLeft.Size = New System.Drawing.Size(200, 20)
        Me.lblActualLeft.TabIndex = 86
        Me.lblActualLeft.Value = New Date(2023, 10, 16, 0, 0, 0, 0)
        '
        'lblExpectedLeave
        '
        Me.lblExpectedLeave.CustomFormat = "dd-MM-yyyy"
        Me.lblExpectedLeave.Location = New System.Drawing.Point(122, 79)
        Me.lblExpectedLeave.Name = "lblExpectedLeave"
        Me.lblExpectedLeave.Size = New System.Drawing.Size(200, 20)
        Me.lblExpectedLeave.TabIndex = 85
        Me.lblExpectedLeave.Value = New Date(2023, 10, 16, 0, 0, 0, 0)
        '
        'lblDatePlaced
        '
        Me.lblDatePlaced.CustomFormat = "dd-MM-yyyy"
        Me.lblDatePlaced.Location = New System.Drawing.Point(722, 31)
        Me.lblDatePlaced.Name = "lblDatePlaced"
        Me.lblDatePlaced.Size = New System.Drawing.Size(200, 20)
        Me.lblDatePlaced.TabIndex = 84
        Me.lblDatePlaced.Value = New Date(2023, 10, 16, 0, 0, 0, 0)
        '
        'lblWaitingDate
        '
        Me.lblWaitingDate.CustomFormat = "dd-MM-yyyy"
        Me.lblWaitingDate.Location = New System.Drawing.Point(122, 34)
        Me.lblWaitingDate.Name = "lblWaitingDate"
        Me.lblWaitingDate.Size = New System.Drawing.Size(200, 20)
        Me.lblWaitingDate.TabIndex = 83
        Me.lblWaitingDate.Value = New Date(2023, 10, 16, 0, 0, 0, 0)
        '
        'btnsearch
        '
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(1011, 313)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(36, 23)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PatientIDtxt)
        Me.Panel1.Controls.Add(Me.LabelPatientID)
        Me.Panel1.Location = New System.Drawing.Point(18, 68)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 49)
        Me.Panel1.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Lastname :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Firstname :"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(492, 14)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 86
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(283, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 85
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(173, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.2!)
        Me.Label1.Location = New System.Drawing.Point(503, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 30)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "IN PATIENTS"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.LabelWardID)
        Me.Panel3.Controls.Add(Me.WardIDtxt)
        Me.Panel3.Location = New System.Drawing.Point(660, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 49)
        Me.Panel3.TabIndex = 89
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(152, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(272, 13)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 20)
        Me.TextBox3.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Ward Name :"
        '
        'InPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.LabelPatients)
        Me.Controls.Add(Me.btnsearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "InPatient"
        Me.Text = "InPatient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.lblDurationOfStay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents LabelDatePlaced As Label
    Friend WithEvents PatientIDtxt As TextBox
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblExpectedLeave As DateTimePicker
    Friend WithEvents lblDatePlaced As DateTimePicker
    Friend WithEvents lblWaitingDate As DateTimePicker
    Friend WithEvents lblDurationOfStay As NumericUpDown
    Friend WithEvents lblActualLeft As DateTimePicker
End Class
