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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormBills))
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        LabelDrugname = New Label()
        LabelDrugnum = New Label()
        Panel1 = New Panel()
        patid_txt = New TextBox()
        BillID_Combo = New ComboBox()
        PatientSearch = New PictureBox()
        Label2 = New Label()
        PaymentStatusComboBox = New ComboBox()
        pat_name = New Label()
        SubmitButton = New Button()
        txtboxsearch = New TextBox()
        btnsearch = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PatientSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(285, 297)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(757, 425)
        DataGridView1.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.WindowText
        Label1.Location = New Point(570, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 37)
        Label1.TabIndex = 34
        Label1.Text = "BILLS"
        ' 
        ' LabelDrugname
        ' 
        LabelDrugname.AutoSize = True
        LabelDrugname.Location = New Point(115, 55)
        LabelDrugname.Name = "LabelDrugname"
        LabelDrugname.Size = New Size(56, 20)
        LabelDrugname.TabIndex = 41
        LabelDrugname.Text = "Bill ID :"
        ' 
        ' LabelDrugnum
        ' 
        LabelDrugnum.AutoSize = True
        LabelDrugnum.Location = New Point(862, 55)
        LabelDrugnum.Name = "LabelDrugnum"
        LabelDrugnum.Size = New Size(116, 20)
        LabelDrugnum.TabIndex = 38
        LabelDrugnum.Text = "Payment Status :"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(patid_txt)
        Panel1.Controls.Add(BillID_Combo)
        Panel1.Controls.Add(PatientSearch)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PaymentStatusComboBox)
        Panel1.Controls.Add(LabelDrugnum)
        Panel1.Controls.Add(LabelDrugname)
        Panel1.Controls.Add(pat_name)
        Panel1.Location = New Point(25, 88)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1216, 133)
        Panel1.TabIndex = 50
        ' 
        ' patid_txt
        ' 
        patid_txt.BorderStyle = BorderStyle.FixedSingle
        patid_txt.Location = New Point(544, 53)
        patid_txt.Margin = New Padding(3, 4, 3, 4)
        patid_txt.Name = "patid_txt"
        patid_txt.Size = New Size(173, 27)
        patid_txt.TabIndex = 52
        ' 
        ' BillID_Combo
        ' 
        BillID_Combo.FormattingEnabled = True
        BillID_Combo.Items.AddRange(New Object() {"PLEASE SELECT PATIENT"})
        BillID_Combo.Location = New Point(177, 52)
        BillID_Combo.Name = "BillID_Combo"
        BillID_Combo.Size = New Size(151, 28)
        BillID_Combo.TabIndex = 70
        ' 
        ' PatientSearch
        ' 
        PatientSearch.Image = CType(resources.GetObject("PatientSearch.Image"), Image)
        PatientSearch.Location = New Point(713, 51)
        PatientSearch.Margin = New Padding(3, 4, 3, 4)
        PatientSearch.Name = "PatientSearch"
        PatientSearch.Size = New Size(61, 31)
        PatientSearch.SizeMode = PictureBoxSizeMode.Zoom
        PatientSearch.TabIndex = 68
        PatientSearch.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(462, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 51
        Label2.Text = "Patient ID:"
        ' 
        ' PaymentStatusComboBox
        ' 
        PaymentStatusComboBox.FormattingEnabled = True
        PaymentStatusComboBox.Items.AddRange(New Object() {"Paid", "Unpaid"})
        PaymentStatusComboBox.Location = New Point(984, 51)
        PaymentStatusComboBox.Name = "PaymentStatusComboBox"
        PaymentStatusComboBox.Size = New Size(151, 28)
        PaymentStatusComboBox.TabIndex = 50
        ' 
        ' pat_name
        ' 
        pat_name.AutoSize = True
        pat_name.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        pat_name.Location = New Point(544, 24)
        pat_name.Name = "pat_name"
        pat_name.Size = New Size(220, 25)
        pat_name.TabIndex = 69
        pat_name.Text = "PLEASE SELECT PATIENT"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(601, 251)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(94, 29)
        SubmitButton.TabIndex = 51
        SubmitButton.Text = "SUBMIT"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        txtboxsearch.Location = New Point(981, 262)
        txtboxsearch.Margin = New Padding(3, 4, 3, 4)
        txtboxsearch.Name = "txtboxsearch"
        txtboxsearch.Size = New Size(148, 27)
        txtboxsearch.TabIndex = 65
        ' 
        ' btnsearch
        ' 
        btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), Image)
        btnsearch.Location = New Point(1137, 262)
        btnsearch.Margin = New Padding(3, 4, 3, 4)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(61, 31)
        btnsearch.SizeMode = PictureBoxSizeMode.Zoom
        btnsearch.TabIndex = 66
        btnsearch.TabStop = False
        ' 
        ' FormBills
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1266, 767)
        Controls.Add(txtboxsearch)
        Controls.Add(btnsearch)
        Controls.Add(SubmitButton)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormBills"
        Text = "FormBills"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PatientSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
