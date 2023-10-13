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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(StaffAllocation))
        DataGridView1 = New DataGridView()
        TextBox11 = New TextBox()
        TextBoxAllocateID = New TextBox()
        Label13 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        txtBoxWardID = New TextBox()
        txtBoxWeekEnd = New TextBox()
        txtBoxWeekBegin = New TextBox()
        wardtoallocate = New Label()
        txtBoxShift = New TextBox()
        weekend = New Label()
        shift = New Label()
        weekbegin = New Label()
        txtBoxStaffID = New TextBox()
        staffid = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        btnsearchstaffallo = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnsearchstaffallo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(64, 400)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1131, 356)
        DataGridView1.TabIndex = 65
        ' 
        ' TextBox11
        ' 
        TextBox11.BorderStyle = BorderStyle.FixedSingle
        TextBox11.Location = New Point(976, 348)
        TextBox11.Margin = New Padding(3, 4, 3, 4)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(167, 27)
        TextBox11.TabIndex = 64
        ' 
        ' TextBoxAllocateID
        ' 
        TextBoxAllocateID.BorderStyle = BorderStyle.FixedSingle
        TextBoxAllocateID.Location = New Point(103, 348)
        TextBoxAllocateID.Margin = New Padding(3, 4, 3, 4)
        TextBoxAllocateID.Name = "TextBoxAllocateID"
        TextBoxAllocateID.Size = New Size(114, 27)
        TextBoxAllocateID.TabIndex = 63
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(69, 353)
        Label13.Name = "Label13"
        Label13.Size = New Size(31, 20)
        Label13.TabIndex = 62
        Label13.Text = "ID :"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(252), CByte(136), CByte(136))
        Button3.Location = New Point(651, 309)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 31)
        Button3.TabIndex = 60
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(241), CByte(227), CByte(86))
        Button2.Location = New Point(549, 309)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 31)
        Button2.TabIndex = 59
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(143))
        Button1.Location = New Point(443, 309)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 58
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtBoxWardID
        ' 
        txtBoxWardID.BorderStyle = BorderStyle.FixedSingle
        txtBoxWardID.Location = New Point(895, 24)
        txtBoxWardID.Margin = New Padding(3, 4, 3, 4)
        txtBoxWardID.Name = "txtBoxWardID"
        txtBoxWardID.Size = New Size(164, 27)
        txtBoxWardID.TabIndex = 54
        ' 
        ' txtBoxWeekEnd
        ' 
        txtBoxWeekEnd.BorderStyle = BorderStyle.FixedSingle
        txtBoxWeekEnd.Location = New Point(510, 100)
        txtBoxWeekEnd.Margin = New Padding(3, 4, 3, 4)
        txtBoxWeekEnd.Name = "txtBoxWeekEnd"
        txtBoxWeekEnd.Size = New Size(163, 27)
        txtBoxWeekEnd.TabIndex = 52
        ' 
        ' txtBoxWeekBegin
        ' 
        txtBoxWeekBegin.BorderStyle = BorderStyle.FixedSingle
        txtBoxWeekBegin.Location = New Point(149, 100)
        txtBoxWeekBegin.Margin = New Padding(3, 4, 3, 4)
        txtBoxWeekBegin.Name = "txtBoxWeekBegin"
        txtBoxWeekBegin.Size = New Size(146, 27)
        txtBoxWeekBegin.TabIndex = 50
        ' 
        ' wardtoallocate
        ' 
        wardtoallocate.AutoSize = True
        wardtoallocate.Location = New Point(768, 28)
        wardtoallocate.Name = "wardtoallocate"
        wardtoallocate.Size = New Size(130, 20)
        wardtoallocate.TabIndex = 46
        wardtoallocate.Text = "Ward To Allocate :"
        ' 
        ' txtBoxShift
        ' 
        txtBoxShift.BorderStyle = BorderStyle.FixedSingle
        txtBoxShift.Location = New Point(510, 31)
        txtBoxShift.Margin = New Padding(3, 4, 3, 4)
        txtBoxShift.Name = "txtBoxShift"
        txtBoxShift.Size = New Size(163, 27)
        txtBoxShift.TabIndex = 44
        ' 
        ' weekend
        ' 
        weekend.AutoSize = True
        weekend.Location = New Point(393, 104)
        weekend.Name = "weekend"
        weekend.Size = New Size(102, 20)
        weekend.TabIndex = 42
        weekend.Text = "Week Ending :"
        ' 
        ' shift
        ' 
        shift.AutoSize = True
        shift.Location = New Point(445, 35)
        shift.Name = "shift"
        shift.Size = New Size(46, 20)
        shift.TabIndex = 41
        shift.Text = "Shift :"
        ' 
        ' weekbegin
        ' 
        weekbegin.AutoSize = True
        weekbegin.Location = New Point(22, 104)
        weekbegin.Name = "weekbegin"
        weekbegin.Size = New Size(123, 20)
        weekbegin.TabIndex = 38
        weekbegin.Text = "Week Beginning :"
        ' 
        ' txtBoxStaffID
        ' 
        txtBoxStaffID.BorderStyle = BorderStyle.FixedSingle
        txtBoxStaffID.Location = New Point(149, 31)
        txtBoxStaffID.Margin = New Padding(3, 4, 3, 4)
        txtBoxStaffID.Name = "txtBoxStaffID"
        txtBoxStaffID.Size = New Size(146, 27)
        txtBoxStaffID.TabIndex = 37
        ' 
        ' staffid
        ' 
        staffid.AutoSize = True
        staffid.Location = New Point(77, 33)
        staffid.Name = "staffid"
        staffid.Size = New Size(66, 20)
        staffid.TabIndex = 36
        staffid.Text = "Staff ID :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(512, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 32)
        Label1.TabIndex = 35
        Label1.Text = "STAFF ALLOCATION"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtBoxStaffID)
        Panel1.Controls.Add(staffid)
        Panel1.Controls.Add(weekbegin)
        Panel1.Controls.Add(txtBoxWeekBegin)
        Panel1.Controls.Add(txtBoxShift)
        Panel1.Controls.Add(shift)
        Panel1.Controls.Add(weekend)
        Panel1.Controls.Add(txtBoxWeekEnd)
        Panel1.Controls.Add(txtBoxWardID)
        Panel1.Controls.Add(wardtoallocate)
        Panel1.Location = New Point(80, 85)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1115, 163)
        Panel1.TabIndex = 67
        ' 
        ' btnsearchstaffallo
        ' 
        btnsearchstaffallo.Image = CType(resources.GetObject("btnsearchstaffallo.Image"), Image)
        btnsearchstaffallo.Location = New Point(1150, 348)
        btnsearchstaffallo.Margin = New Padding(3, 4, 3, 4)
        btnsearchstaffallo.Name = "btnsearchstaffallo"
        btnsearchstaffallo.Size = New Size(41, 36)
        btnsearchstaffallo.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchstaffallo.TabIndex = 68
        btnsearchstaffallo.TabStop = False
        ' 
        ' StaffAllocation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1267, 772)
        Controls.Add(btnsearchstaffallo)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox11)
        Controls.Add(TextBoxAllocateID)
        Controls.Add(Label13)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "StaffAllocation"
        Text = "StaffAllocation"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnsearchstaffallo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBoxAllocateID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBoxWardID As TextBox
    Friend WithEvents txtBoxWeekEnd As TextBox
    Friend WithEvents txtBoxWeekBegin As TextBox
    Friend WithEvents wardtoallocate As Label
    Friend WithEvents txtBoxShift As TextBox
    Friend WithEvents weekend As Label
    Friend WithEvents shift As Label
    Friend WithEvents weekbegin As Label
    Friend WithEvents txtBoxStaffID As TextBox
    Friend WithEvents staffid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearchstaffallo As PictureBox
End Class
