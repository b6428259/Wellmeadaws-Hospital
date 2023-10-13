<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplyPhama
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(supplyPhama))
        txt_supplierID = New TextBox()
        drugnametxt = New TextBox()
        txt_MoAd = New TextBox()
        txt_QoS = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txt_Desc = New RichTextBox()
        Label9 = New Label()
        txt_CostPerU = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label10 = New Label()
        drugnumtxt = New TextBox()
        dosagetxt = New TextBox()
        Label1 = New Label()
        btnsearch = New PictureBox()
        txtboxsearch = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_supplierID
        ' 
        txt_supplierID.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txt_supplierID, "txt_supplierID")
        txt_supplierID.Name = "txt_supplierID"
        ' 
        ' drugnametxt
        ' 
        drugnametxt.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(drugnametxt, "drugnametxt")
        drugnametxt.Name = "drugnametxt"
        ' 
        ' txt_MoAd
        ' 
        txt_MoAd.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txt_MoAd, "txt_MoAd")
        txt_MoAd.Name = "txt_MoAd"
        ' 
        ' txt_QoS
        ' 
        txt_QoS.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txt_QoS, "txt_QoS")
        txt_QoS.Name = "txt_QoS"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        Label5.Name = "Label5"
        ' 
        ' Label7
        ' 
        resources.ApplyResources(Label7, "Label7")
        Label7.Name = "Label7"
        ' 
        ' Label8
        ' 
        resources.ApplyResources(Label8, "Label8")
        Label8.Name = "Label8"
        ' 
        ' txt_Desc
        ' 
        txt_Desc.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txt_Desc, "txt_Desc")
        txt_Desc.Name = "txt_Desc"
        ' 
        ' Label9
        ' 
        resources.ApplyResources(Label9, "Label9")
        Label9.Name = "Label9"
        ' 
        ' txt_CostPerU
        ' 
        txt_CostPerU.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txt_CostPerU, "txt_CostPerU")
        txt_CostPerU.Name = "txt_CostPerU"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(DataGridView1, "DataGridView1")
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 28
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        resources.ApplyResources(Label10, "Label10")
        Label10.Name = "Label10"
        ' 
        ' drugnumtxt
        ' 
        drugnumtxt.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(drugnumtxt, "drugnumtxt")
        drugnumtxt.Name = "drugnumtxt"
        ' 
        ' dosagetxt
        ' 
        dosagetxt.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(dosagetxt, "dosagetxt")
        dosagetxt.Name = "dosagetxt"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' btnsearch
        ' 
        resources.ApplyResources(btnsearch, "btnsearch")
        btnsearch.Name = "btnsearch"
        btnsearch.TabStop = False
        ' 
        ' txtboxsearch
        ' 
        txtboxsearch.BackColor = SystemColors.Window
        txtboxsearch.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(txtboxsearch, "txtboxsearch")
        txtboxsearch.Name = "txtboxsearch"
        ' 
        ' supplyPhama
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnsearch)
        Controls.Add(txtboxsearch)
        Controls.Add(dosagetxt)
        Controls.Add(Label1)
        Controls.Add(drugnumtxt)
        Controls.Add(Label10)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(txt_CostPerU)
        Controls.Add(Label9)
        Controls.Add(txt_Desc)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_QoS)
        Controls.Add(txt_MoAd)
        Controls.Add(drugnametxt)
        Controls.Add(txt_supplierID)
        FormBorderStyle = FormBorderStyle.None
        Name = "supplyPhama"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnsearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_spplyID As TextBox
    Friend WithEvents txt_supplierID As TextBox
    Friend WithEvents txt_DrugNum As TextBox
    Friend WithEvents drugnametxt As TextBox
    Friend WithEvents txt_MoAd As TextBox
    Friend WithEvents txt_QoS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Desc As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_CostPerU As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents drugnumtxt As TextBox
    Friend WithEvents dosagetxt As TextBox
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents txtboxsearch As TextBox
End Class
