<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        STAFFToolStripMenuItem = New ToolStripMenuItem()
        STAFFALLOCATIONToolStripMenuItem = New ToolStripMenuItem()
        wardnav = New ToolStripMenuItem()
        BEDToolStripMenuItem = New ToolStripMenuItem()
        PATIENTToolStripMenuItem = New ToolStripMenuItem()
        PATIENTALLOCATIONToolStripMenuItem = New ToolStripMenuItem()
        INPATIENTToolStripMenuItem = New ToolStripMenuItem()
        APPOINTMENTSToolStripMenuItem = New ToolStripMenuItem()
        MEDICATIONToolStripMenuItem = New ToolStripMenuItem()
        supplyList = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        SURGICALToolStripMenuItem = New ToolStripMenuItem()
        PHARMACEUTICALToolStripMenuItem = New ToolStripMenuItem()
        SUPPILERToolStripMenuItem = New ToolStripMenuItem()
        BILLSToolStripMenuItem = New ToolStripMenuItem()
        PROFILEToolStripMenuItem = New ToolStripMenuItem()
        StaffPanel = New Panel()
        SURGICALSUPPLYToolStripMenuItem = New ToolStripMenuItem()
        PHAMASUToolStripMenuItem = New ToolStripMenuItem()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = SystemColors.ButtonHighlight
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.6832733F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 81.31673F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(MenuStrip1, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 49F))
        TableLayoutPanel1.Size = New Size(1285, 145)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(3, 4)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(234, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(12), CByte(53), CByte(106))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(240, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1045, 96)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(242, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 55)
        Label1.TabIndex = 0
        Label1.Text = " Wellmeadows Hospital"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightSkyBlue
        MenuStrip1.Dock = DockStyle.Fill
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {STAFFToolStripMenuItem, wardnav, PATIENTToolStripMenuItem, MEDICATIONToolStripMenuItem, supplyList, ToolStripMenuItem1, BILLSToolStripMenuItem, PROFILEToolStripMenuItem})
        MenuStrip1.Location = New Point(240, 96)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(0)
        MenuStrip1.Size = New Size(1045, 49)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' STAFFToolStripMenuItem
        ' 
        STAFFToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {STAFFALLOCATIONToolStripMenuItem})
        STAFFToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        STAFFToolStripMenuItem.Name = "STAFFToolStripMenuItem"
        STAFFToolStripMenuItem.Padding = New Padding(20, 0, 20, 0)
        STAFFToolStripMenuItem.Size = New Size(110, 49)
        STAFFToolStripMenuItem.Text = "STAFF"
        ' 
        ' STAFFALLOCATIONToolStripMenuItem
        ' 
        STAFFALLOCATIONToolStripMenuItem.Name = "STAFFALLOCATIONToolStripMenuItem"
        STAFFALLOCATIONToolStripMenuItem.Size = New Size(268, 30)
        STAFFALLOCATIONToolStripMenuItem.Text = "STAFF ALLOCATION"
        ' 
        ' wardnav
        ' 
        wardnav.BackColor = Color.LightSkyBlue
        wardnav.DropDownItems.AddRange(New ToolStripItem() {BEDToolStripMenuItem})
        wardnav.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        wardnav.Name = "wardnav"
        wardnav.Padding = New Padding(20, 0, 20, 0)
        wardnav.Size = New Size(113, 49)
        wardnav.Text = "WARD"
        ' 
        ' BEDToolStripMenuItem
        ' 
        BEDToolStripMenuItem.Name = "BEDToolStripMenuItem"
        BEDToolStripMenuItem.Size = New Size(128, 30)
        BEDToolStripMenuItem.Text = "BED"
        ' 
        ' PATIENTToolStripMenuItem
        ' 
        PATIENTToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PATIENTALLOCATIONToolStripMenuItem, INPATIENTToolStripMenuItem, APPOINTMENTSToolStripMenuItem})
        PATIENTToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PATIENTToolStripMenuItem.Name = "PATIENTToolStripMenuItem"
        PATIENTToolStripMenuItem.Padding = New Padding(20, 0, 20, 0)
        PATIENTToolStripMenuItem.Size = New Size(132, 49)
        PATIENTToolStripMenuItem.Text = "PATIENT"
        ' 
        ' PATIENTALLOCATIONToolStripMenuItem
        ' 
        PATIENTALLOCATIONToolStripMenuItem.Name = "PATIENTALLOCATIONToolStripMenuItem"
        PATIENTALLOCATIONToolStripMenuItem.Size = New Size(290, 30)
        PATIENTALLOCATIONToolStripMenuItem.Text = "PATIENT ALLOCATION"
        ' 
        ' INPATIENTToolStripMenuItem
        ' 
        INPATIENTToolStripMenuItem.Name = "INPATIENTToolStripMenuItem"
        INPATIENTToolStripMenuItem.Size = New Size(290, 30)
        INPATIENTToolStripMenuItem.Text = "INPATIENT"
        ' 
        ' APPOINTMENTSToolStripMenuItem
        ' 
        APPOINTMENTSToolStripMenuItem.Name = "APPOINTMENTSToolStripMenuItem"
        APPOINTMENTSToolStripMenuItem.Size = New Size(290, 30)
        APPOINTMENTSToolStripMenuItem.Text = "APPOINTMENTS"
        ' 
        ' MEDICATIONToolStripMenuItem
        ' 
        MEDICATIONToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MEDICATIONToolStripMenuItem.Name = "MEDICATIONToolStripMenuItem"
        MEDICATIONToolStripMenuItem.Padding = New Padding(20, 0, 20, 0)
        MEDICATIONToolStripMenuItem.Size = New Size(174, 49)
        MEDICATIONToolStripMenuItem.Text = "MEDICATION"
        ' 
        ' supplyList
        ' 
        supplyList.DropDownItems.AddRange(New ToolStripItem() {SURGICALSUPPLYToolStripMenuItem, PHAMASUToolStripMenuItem})
        supplyList.Font = New Font("Segoe UI", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point)
        supplyList.Name = "supplyList"
        supplyList.Size = New Size(90, 49)
        supplyList.Text = "SUPPLY"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {SURGICALToolStripMenuItem, PHARMACEUTICALToolStripMenuItem, SUPPILERToolStripMenuItem})
        ToolStripMenuItem1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Padding = New Padding(20, 0, 20, 0)
        ToolStripMenuItem1.Size = New Size(175, 49)
        ToolStripMenuItem1.Text = "REQUISITION"
        ' 
        ' SURGICALToolStripMenuItem
        ' 
        SURGICALToolStripMenuItem.Name = "SURGICALToolStripMenuItem"
        SURGICALToolStripMenuItem.Size = New Size(263, 30)
        SURGICALToolStripMenuItem.Text = "SURGICAL"
        ' 
        ' PHARMACEUTICALToolStripMenuItem
        ' 
        PHARMACEUTICALToolStripMenuItem.Name = "PHARMACEUTICALToolStripMenuItem"
        PHARMACEUTICALToolStripMenuItem.Size = New Size(263, 30)
        PHARMACEUTICALToolStripMenuItem.Text = "PHARMACEUTICAL"
        ' 
        ' SUPPILERToolStripMenuItem
        ' 
        SUPPILERToolStripMenuItem.Name = "SUPPILERToolStripMenuItem"
        SUPPILERToolStripMenuItem.Size = New Size(263, 30)
        SUPPILERToolStripMenuItem.Text = "SUPPILER"
        ' 
        ' BILLSToolStripMenuItem
        ' 
        BILLSToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BILLSToolStripMenuItem.Name = "BILLSToolStripMenuItem"
        BILLSToolStripMenuItem.Padding = New Padding(20, 0, 20, 0)
        BILLSToolStripMenuItem.Size = New Size(105, 49)
        BILLSToolStripMenuItem.Text = "BILLS"
        ' 
        ' PROFILEToolStripMenuItem
        ' 
        PROFILEToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PROFILEToolStripMenuItem.Name = "PROFILEToolStripMenuItem"
        PROFILEToolStripMenuItem.Padding = New Padding(20, 0, 20, 0)
        PROFILEToolStripMenuItem.Size = New Size(130, 49)
        PROFILEToolStripMenuItem.Text = "PROFILE"
        ' 
        ' StaffPanel
        ' 
        StaffPanel.Dock = DockStyle.Fill
        StaffPanel.Location = New Point(0, 145)
        StaffPanel.Margin = New Padding(3, 4, 3, 4)
        StaffPanel.Name = "StaffPanel"
        StaffPanel.Size = New Size(1285, 778)
        StaffPanel.TabIndex = 1
        ' 
        ' SURGICALSUPPLYToolStripMenuItem
        ' 
        SURGICALSUPPLYToolStripMenuItem.Name = "SURGICALSUPPLYToolStripMenuItem"
        SURGICALSUPPLYToolStripMenuItem.Size = New Size(313, 30)
        SURGICALSUPPLYToolStripMenuItem.Text = "SURGICAL SUPPLY"
        ' 
        ' PHAMASUToolStripMenuItem
        ' 
        PHAMASUToolStripMenuItem.Name = "PHAMASUToolStripMenuItem"
        PHAMASUToolStripMenuItem.Size = New Size(313, 30)
        PHAMASUToolStripMenuItem.Text = "PHAMACEUTICAL SUPPLY"
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1285, 923)
        Controls.Add(StaffPanel)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormMain"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STAFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wardnav As ToolStripMenuItem
    Friend WithEvents PATIENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MEDICATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SURGICALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PHARMACEUTICALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BILLSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROFILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffPanel As Panel
    Friend WithEvents BEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STAFFALLOCATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PATIENTALLOCATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INPATIENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPILERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APPOINTMENTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents supplyList As ToolStripMenuItem
    Friend WithEvents SURGICALSUPPLYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PHAMASUToolStripMenuItem As ToolStripMenuItem
End Class
