<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequistionPhamaDel
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(232, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 47
        DataGridView1.RowTemplate.Height = 28
        DataGridView1.Size = New Size(556, 426)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 25)
        Label1.TabIndex = 1
        Label1.Text = "เลือกข้อมูลที่ต้องการจะลบ"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 26)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9.163636F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(12, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 26)
        Button1.TabIndex = 3
        Button1.Text = "ลบข้อมูล"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RequistionPhamaDel
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "RequistionPhamaDel"
        Text = "RequistionPhamaDel"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
