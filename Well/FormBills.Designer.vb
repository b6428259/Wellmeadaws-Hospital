<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBills))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDrugname = New System.Windows.Forms.Label()
        Me.LabelDrugnum = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.patid_txt = New System.Windows.Forms.TextBox()
        Me.BillID_Combo = New System.Windows.Forms.ComboBox()
        Me.PatientSearch = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaymentStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.pat_name = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PatientSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(214, 193)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(634, 276)
        Me.DataGridView1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(534, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 30)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "BILLS"
        '
        'LabelDrugname
        '
        Me.LabelDrugname.AutoSize = True
        Me.LabelDrugname.Location = New System.Drawing.Point(116, 35)
        Me.LabelDrugname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDrugname.Name = "LabelDrugname"
        Me.LabelDrugname.Size = New System.Drawing.Size(40, 13)
        Me.LabelDrugname.TabIndex = 41
        Me.LabelDrugname.Text = "Bill ID :"
        '
        'LabelDrugnum
        '
        Me.LabelDrugnum.AutoSize = True
        Me.LabelDrugnum.Location = New System.Drawing.Point(801, 36)
        Me.LabelDrugnum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDrugnum.Name = "LabelDrugnum"
        Me.LabelDrugnum.Size = New System.Drawing.Size(87, 13)
        Me.LabelDrugnum.TabIndex = 38
        Me.LabelDrugnum.Text = "Payment Status :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.patid_txt)
        Me.Panel1.Controls.Add(Me.BillID_Combo)
        Me.Panel1.Controls.Add(Me.PatientSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PaymentStatusComboBox)
        Me.Panel1.Controls.Add(Me.LabelDrugnum)
        Me.Panel1.Controls.Add(Me.LabelDrugname)
        Me.Panel1.Controls.Add(Me.pat_name)
        Me.Panel1.Location = New System.Drawing.Point(19, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 87)
        Me.Panel1.TabIndex = 50
        '
        'patid_txt
        '
        Me.patid_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.patid_txt.Location = New System.Drawing.Point(475, 35)
        Me.patid_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.patid_txt.Name = "patid_txt"
        Me.patid_txt.Size = New System.Drawing.Size(130, 20)
        Me.patid_txt.TabIndex = 52
        '
        'BillID_Combo
        '
        Me.BillID_Combo.FormattingEnabled = True
        Me.BillID_Combo.Items.AddRange(New Object() {"PLEASE SELECT PATIENT"})
        Me.BillID_Combo.Location = New System.Drawing.Point(163, 33)
        Me.BillID_Combo.Margin = New System.Windows.Forms.Padding(2)
        Me.BillID_Combo.Name = "BillID_Combo"
        Me.BillID_Combo.Size = New System.Drawing.Size(114, 21)
        Me.BillID_Combo.TabIndex = 70
        '
        'PatientSearch
        '
        Me.PatientSearch.Image = CType(resources.GetObject("PatientSearch.Image"), System.Drawing.Image)
        Me.PatientSearch.Location = New System.Drawing.Point(602, 34)
        Me.PatientSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PatientSearch.Name = "PatientSearch"
        Me.PatientSearch.Size = New System.Drawing.Size(46, 20)
        Me.PatientSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PatientSearch.TabIndex = 68
        Me.PatientSearch.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Patient ID:"
        '
        'PaymentStatusComboBox
        '
        Me.PaymentStatusComboBox.FormattingEnabled = True
        Me.PaymentStatusComboBox.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.PaymentStatusComboBox.Location = New System.Drawing.Point(893, 33)
        Me.PaymentStatusComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PaymentStatusComboBox.Name = "PaymentStatusComboBox"
        Me.PaymentStatusComboBox.Size = New System.Drawing.Size(114, 21)
        Me.PaymentStatusComboBox.TabIndex = 50
        '
        'pat_name
        '
        Me.pat_name.AutoSize = True
        Me.pat_name.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.pat_name.Location = New System.Drawing.Point(453, 7)
        Me.pat_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pat_name.Name = "pat_name"
        Me.pat_name.Size = New System.Drawing.Size(180, 20)
        Me.pat_name.TabIndex = 69
        Me.pat_name.Text = "PLEASE SELECT PATIENT"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(531, 161)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(70, 19)
        Me.SubmitButton.TabIndex = 51
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'txtboxsearch
        '
        Me.txtboxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxsearch.Location = New System.Drawing.Point(694, 162)
        Me.txtboxsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(112, 20)
        Me.txtboxsearch.TabIndex = 65
        '
        'btnsearch
        '
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(811, 162)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(46, 20)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnsearch.TabIndex = 66
        Me.btnsearch.TabStop = False
        '
        'FormBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1073, 602)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormBills"
        Me.Text = "FormBills"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PatientSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDrugname As Label
    Friend WithEvents LabelDrugnum As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PaymentStatusComboBox As ComboBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents txtboxsearch As TextBox
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents PatientSearch As PictureBox
    Friend WithEvents patid_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pat_name As Label
    Friend WithEvents BillID_Combo As ComboBox
End Class
