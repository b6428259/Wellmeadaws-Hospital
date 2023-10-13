<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequisitionSurDel
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
        DataGridToDel = New DataGridView()
        inputNumDel = New TextBox()
        Label1 = New Label()
        btn_Del = New Button()
        CType(DataGridToDel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridToDel
        ' 
        DataGridToDel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridToDel.Location = New Point(211, 12)
        DataGridToDel.Name = "DataGridToDel"
        DataGridToDel.RowHeadersWidth = 47
        DataGridToDel.RowTemplate.Height = 28
        DataGridToDel.Size = New Size(577, 426)
        DataGridToDel.TabIndex = 0
        ' 
        ' inputNumDel
        ' 
        inputNumDel.Location = New Point(12, 58)
        inputNumDel.Name = "inputNumDel"
        inputNumDel.Size = New Size(193, 26)
        inputNumDel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 25)
        Label1.TabIndex = 2
        Label1.Text = "เลือกข้อมูลที่ต้องการลบ"
        ' 
        ' btn_Del
        ' 
        btn_Del.Location = New Point(12, 102)
        btn_Del.Name = "btn_Del"
        btn_Del.Size = New Size(105, 26)
        btn_Del.TabIndex = 3
        btn_Del.Text = "ลบข้อมูล"
        btn_Del.UseVisualStyleBackColor = True
        ' 
        ' RequisitionSurDel
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_Del)
        Controls.Add(Label1)
        Controls.Add(inputNumDel)
        Controls.Add(DataGridToDel)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "RequisitionSurDel"
        Text = "RequisitionSurDel"
        CType(DataGridToDel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridToDel As DataGridView
    Friend WithEvents inputNumDel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Del As Button
End Class
