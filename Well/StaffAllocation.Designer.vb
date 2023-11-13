<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffAllocation))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBoxWardID = New System.Windows.Forms.TextBox()
        Me.wardtoallocate = New System.Windows.Forms.Label()
        Me.weekend = New System.Windows.Forms.Label()
        Me.shift = New System.Windows.Forms.Label()
        Me.weekbegin = New System.Windows.Forms.Label()
        Me.txtBoxStaffID = New System.Windows.Forms.TextBox()
        Me.staffid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBoxShift = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpWeekEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpWeekBegin = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchstaffallo = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearchstaffallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 260)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(978, 231)
        Me.DataGridView1.TabIndex = 65
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Location = New System.Drawing.Point(860, 226)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(126, 20)
        Me.TextBox11.TabIndex = 64
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btndel.Location = New System.Drawing.Point(615, 222)
        Me.btndel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(64, 20)
        Me.btndel.TabIndex = 60
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(539, 222)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 20)
        Me.btnEdit.TabIndex = 59
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(459, 222)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 20)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBoxWardID
        '
        Me.txtBoxWardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxWardID.Location = New System.Drawing.Point(799, 16)
        Me.txtBoxWardID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxWardID.Name = "txtBoxWardID"
        Me.txtBoxWardID.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxWardID.TabIndex = 54
        '
        'wardtoallocate
        '
        Me.wardtoallocate.AutoSize = True
        Me.wardtoallocate.Location = New System.Drawing.Point(704, 18)
        Me.wardtoallocate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.wardtoallocate.Name = "wardtoallocate"
        Me.wardtoallocate.Size = New System.Drawing.Size(96, 13)
        Me.wardtoallocate.TabIndex = 46
        Me.wardtoallocate.Text = "Ward To Allocate :"
        '
        'weekend
        '
        Me.weekend.AutoSize = True
        Me.weekend.Location = New System.Drawing.Point(364, 68)
        Me.weekend.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.weekend.Name = "weekend"
        Me.weekend.Size = New System.Drawing.Size(78, 13)
        Me.weekend.TabIndex = 42
        Me.weekend.Text = "Week Ending :"
        '
        'shift
        '
        Me.shift.AutoSize = True
        Me.shift.Location = New System.Drawing.Point(418, 18)
        Me.shift.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shift.Name = "shift"
        Me.shift.Size = New System.Drawing.Size(34, 13)
        Me.shift.TabIndex = 41
        Me.shift.Text = "Shift :"
        '
        'weekbegin
        '
        Me.weekbegin.AutoSize = True
        Me.weekbegin.Location = New System.Drawing.Point(34, 68)
        Me.weekbegin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.weekbegin.Name = "weekbegin"
        Me.weekbegin.Size = New System.Drawing.Size(92, 13)
        Me.weekbegin.TabIndex = 38
        Me.weekbegin.Text = "Week Beginning :"
        '
        'txtBoxStaffID
        '
        Me.txtBoxStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxStaffID.Location = New System.Drawing.Point(130, 17)
        Me.txtBoxStaffID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBoxStaffID.Name = "txtBoxStaffID"
        Me.txtBoxStaffID.Size = New System.Drawing.Size(110, 20)
        Me.txtBoxStaffID.TabIndex = 37
        '
        'staffid
        '
        Me.staffid.AutoSize = True
        Me.staffid.Location = New System.Drawing.Point(76, 21)
        Me.staffid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.staffid.Name = "staffid"
        Me.staffid.Size = New System.Drawing.Size(49, 13)
        Me.staffid.TabIndex = 36
        Me.staffid.Text = "Staff ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(483, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "STAFF ALLOCATION"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtBoxShift)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.dtpWeekEnd)
        Me.Panel1.Controls.Add(Me.dtpWeekBegin)
        Me.Panel1.Controls.Add(Me.txtBoxStaffID)
        Me.Panel1.Controls.Add(Me.staffid)
        Me.Panel1.Controls.Add(Me.weekbegin)
        Me.Panel1.Controls.Add(Me.shift)
        Me.Panel1.Controls.Add(Me.weekend)
        Me.Panel1.Controls.Add(Me.txtBoxWardID)
        Me.Panel1.Controls.Add(Me.wardtoallocate)
        Me.Panel1.Location = New System.Drawing.Point(60, 55)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(966, 107)
        Me.Panel1.TabIndex = 67
        '
        'txtBoxShift
        '
        Me.txtBoxShift.FormattingEnabled = True
        Me.txtBoxShift.Items.AddRange(New Object() {"Day Shift", "Night Shift"})
        Me.txtBoxShift.Location = New System.Drawing.Point(457, 16)
        Me.txtBoxShift.Name = "txtBoxShift"
        Me.txtBoxShift.Size = New System.Drawing.Size(123, 21)
        Me.txtBoxShift.TabIndex = 70
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(927, 16)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(244, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'dtpWeekEnd
        '
        Me.dtpWeekEnd.Location = New System.Drawing.Point(457, 65)
        Me.dtpWeekEnd.Name = "dtpWeekEnd"
        Me.dtpWeekEnd.Size = New System.Drawing.Size(123, 20)
        Me.dtpWeekEnd.TabIndex = 56
        '
        'dtpWeekBegin
        '
        Me.dtpWeekBegin.Location = New System.Drawing.Point(131, 65)
        Me.dtpWeekBegin.Name = "dtpWeekBegin"
        Me.dtpWeekBegin.Size = New System.Drawing.Size(110, 20)
        Me.dtpWeekBegin.TabIndex = 55
        '
        'btnsearchstaffallo
        '
        Me.btnsearchstaffallo.Image = CType(resources.GetObject("btnsearchstaffallo.Image"), System.Drawing.Image)
        Me.btnsearchstaffallo.Location = New System.Drawing.Point(990, 226)
        Me.btnsearchstaffallo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearchstaffallo.Name = "btnsearchstaffallo"
        Me.btnsearchstaffallo.Size = New System.Drawing.Size(31, 23)
        Me.btnsearchstaffallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearchstaffallo.TabIndex = 68
        Me.btnsearchstaffallo.TabStop = False
        '
        'StaffAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.btnsearchstaffallo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffAllocation"
        Me.Text = "StaffAllocation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearchstaffallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents btndel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBoxWardID As TextBox
    Friend WithEvents wardtoallocate As Label
    Friend WithEvents weekend As Label
    Friend WithEvents shift As Label
    Friend WithEvents weekbegin As Label
    Friend WithEvents txtBoxStaffID As TextBox
    Friend WithEvents staffid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearchstaffallo As PictureBox
    Friend WithEvents dtpWeekEnd As DateTimePicker
    Friend WithEvents dtpWeekBegin As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBoxShift As ComboBox
End Class
