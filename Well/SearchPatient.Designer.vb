<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPatient
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SearchPatient))
        Label1 = New Label()
        txtBoxSearch = New TextBox()
        DataGridView1 = New DataGridView()
        btnsearchpatient = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearchpatient, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 0
        Label1.Text = "ค้นหา: "
        ' 
        ' txtBoxSearch
        ' 
        txtBoxSearch.Location = New Point(117, 18)
        txtBoxSearch.Name = "txtBoxSearch"
        txtBoxSearch.Size = New Size(391, 27)
        txtBoxSearch.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 54)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(549, 348)
        DataGridView1.TabIndex = 2
        ' 
        ' btnsearchpatient
        ' 
        btnsearchpatient.Image = CType(resources.GetObject("btnsearchpatient.Image"), Image)
        btnsearchpatient.Location = New Point(514, 13)
        btnsearchpatient.Margin = New Padding(3, 4, 3, 4)
        btnsearchpatient.Name = "btnsearchpatient"
        btnsearchpatient.Size = New Size(41, 36)
        btnsearchpatient.SizeMode = PictureBoxSizeMode.Zoom
        btnsearchpatient.TabIndex = 70
        btnsearchpatient.TabStop = False
        ' 
        ' SearchPatient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 404)
        Controls.Add(btnsearchpatient)
        Controls.Add(DataGridView1)
        Controls.Add(txtBoxSearch)
        Controls.Add(Label1)
        Name = "SearchPatient"
        Text = "SearchPatient"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearchpatient, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnsearchpatient As PictureBox
End Class
