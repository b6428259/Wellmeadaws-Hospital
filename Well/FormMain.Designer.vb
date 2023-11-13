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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STAFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAFFALLOCATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wardnav = New System.Windows.Forms.ToolStripMenuItem()
        Me.BEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PATIENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PATIENTALLOCATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INPATIENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APPOINTMENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEDICATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.supplyList = New System.Windows.Forms.ToolStripMenuItem()
        Me.SURGICALSUPPLYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHAMASUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SURGICALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHARMACEUTICALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPILERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BILLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffPanel = New System.Windows.Forms.Panel()
        Me.dashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.68327!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.31673!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1073, 99)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 65)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(204, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Wellmeadows Hospital"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashboard, Me.STAFFToolStripMenuItem, Me.wardnav, Me.PATIENTToolStripMenuItem, Me.MEDICATIONToolStripMenuItem, Me.supplyList, Me.ToolStripMenuItem1, Me.BILLSToolStripMenuItem, Me.PROFILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(200, 65)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(873, 34)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STAFFToolStripMenuItem
        '
        Me.STAFFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STAFFALLOCATIONToolStripMenuItem})
        Me.STAFFToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.STAFFToolStripMenuItem.Name = "STAFFToolStripMenuItem"
        Me.STAFFToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.STAFFToolStripMenuItem.Size = New System.Drawing.Size(98, 34)
        Me.STAFFToolStripMenuItem.Text = "STAFF"
        '
        'STAFFALLOCATIONToolStripMenuItem
        '
        Me.STAFFALLOCATIONToolStripMenuItem.Name = "STAFFALLOCATIONToolStripMenuItem"
        Me.STAFFALLOCATIONToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.STAFFALLOCATIONToolStripMenuItem.Text = "STAFF ALLOCATION"
        '
        'wardnav
        '
        Me.wardnav.BackColor = System.Drawing.Color.LightSkyBlue
        Me.wardnav.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BEDToolStripMenuItem})
        Me.wardnav.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.wardnav.Name = "wardnav"
        Me.wardnav.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.wardnav.Size = New System.Drawing.Size(102, 34)
        Me.wardnav.Text = "WARD"
        '
        'BEDToolStripMenuItem
        '
        Me.BEDToolStripMenuItem.Name = "BEDToolStripMenuItem"
        Me.BEDToolStripMenuItem.Size = New System.Drawing.Size(111, 26)
        Me.BEDToolStripMenuItem.Text = "BED"
        '
        'PATIENTToolStripMenuItem
        '
        Me.PATIENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PATIENTALLOCATIONToolStripMenuItem, Me.INPATIENTToolStripMenuItem, Me.APPOINTMENTSToolStripMenuItem})
        Me.PATIENTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PATIENTToolStripMenuItem.Name = "PATIENTToolStripMenuItem"
        Me.PATIENTToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.PATIENTToolStripMenuItem.Size = New System.Drawing.Size(118, 34)
        Me.PATIENTToolStripMenuItem.Text = "PATIENT"
        '
        'PATIENTALLOCATIONToolStripMenuItem
        '
        Me.PATIENTALLOCATIONToolStripMenuItem.Name = "PATIENTALLOCATIONToolStripMenuItem"
        Me.PATIENTALLOCATIONToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.PATIENTALLOCATIONToolStripMenuItem.Text = "PATIENT ALLOCATION"
        '
        'INPATIENTToolStripMenuItem
        '
        Me.INPATIENTToolStripMenuItem.Name = "INPATIENTToolStripMenuItem"
        Me.INPATIENTToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.INPATIENTToolStripMenuItem.Text = "INPATIENT"
        '
        'APPOINTMENTSToolStripMenuItem
        '
        Me.APPOINTMENTSToolStripMenuItem.Name = "APPOINTMENTSToolStripMenuItem"
        Me.APPOINTMENTSToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.APPOINTMENTSToolStripMenuItem.Text = "APPOINTMENTS"
        '
        'MEDICATIONToolStripMenuItem
        '
        Me.MEDICATIONToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MEDICATIONToolStripMenuItem.Name = "MEDICATIONToolStripMenuItem"
        Me.MEDICATIONToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.MEDICATIONToolStripMenuItem.Size = New System.Drawing.Size(154, 34)
        Me.MEDICATIONToolStripMenuItem.Text = "MEDICATION"
        '
        'supplyList
        '
        Me.supplyList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SURGICALSUPPLYToolStripMenuItem, Me.PHAMASUToolStripMenuItem})
        Me.supplyList.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Bold)
        Me.supplyList.Name = "supplyList"
        Me.supplyList.Size = New System.Drawing.Size(80, 34)
        Me.supplyList.Text = "SUPPLY"
        '
        'SURGICALSUPPLYToolStripMenuItem
        '
        Me.SURGICALSUPPLYToolStripMenuItem.Name = "SURGICALSUPPLYToolStripMenuItem"
        Me.SURGICALSUPPLYToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.SURGICALSUPPLYToolStripMenuItem.Text = "SURGICAL SUPPLY"
        '
        'PHAMASUToolStripMenuItem
        '
        Me.PHAMASUToolStripMenuItem.Name = "PHAMASUToolStripMenuItem"
        Me.PHAMASUToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.PHAMASUToolStripMenuItem.Text = "PHAMACEUTICAL SUPPLY"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SURGICALToolStripMenuItem, Me.PHARMACEUTICALToolStripMenuItem, Me.SUPPILERToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(155, 34)
        Me.ToolStripMenuItem1.Text = "REQUISITION"
        '
        'SURGICALToolStripMenuItem
        '
        Me.SURGICALToolStripMenuItem.Name = "SURGICALToolStripMenuItem"
        Me.SURGICALToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.SURGICALToolStripMenuItem.Text = "SURGICAL"
        '
        'PHARMACEUTICALToolStripMenuItem
        '
        Me.PHARMACEUTICALToolStripMenuItem.Name = "PHARMACEUTICALToolStripMenuItem"
        Me.PHARMACEUTICALToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.PHARMACEUTICALToolStripMenuItem.Text = "PHARMACEUTICAL"
        '
        'SUPPILERToolStripMenuItem
        '
        Me.SUPPILERToolStripMenuItem.Name = "SUPPILERToolStripMenuItem"
        Me.SUPPILERToolStripMenuItem.Size = New System.Drawing.Size(223, 26)
        Me.SUPPILERToolStripMenuItem.Text = "SUPPILER"
        '
        'BILLSToolStripMenuItem
        '
        Me.BILLSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BILLSToolStripMenuItem.Name = "BILLSToolStripMenuItem"
        Me.BILLSToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.BILLSToolStripMenuItem.Size = New System.Drawing.Size(94, 34)
        Me.BILLSToolStripMenuItem.Text = "BILLS"
        '
        'PROFILEToolStripMenuItem
        '
        Me.PROFILEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PROFILEToolStripMenuItem.Name = "PROFILEToolStripMenuItem"
        Me.PROFILEToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.PROFILEToolStripMenuItem.Size = New System.Drawing.Size(116, 34)
        Me.PROFILEToolStripMenuItem.Text = "PROFILE"
        '
        'StaffPanel
        '
        Me.StaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffPanel.Location = New System.Drawing.Point(0, 99)
        Me.StaffPanel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.StaffPanel.Name = "StaffPanel"
        Me.StaffPanel.Size = New System.Drawing.Size(1073, 602)
        Me.StaffPanel.TabIndex = 1
        '
        'dashboard
        '
        Me.dashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboard.Name = "dashboard"
        Me.dashboard.Size = New System.Drawing.Size(66, 34)
        Me.dashboard.Text = "MAIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Wellmeadaws.My.Resources.Resources._387490059_2007052539671796_122566097641315469_n2
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 701)
        Me.Controls.Add(Me.StaffPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents dashboard As ToolStripMenuItem
End Class
