<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Panel1 = New Panel()
        lbl_Qpatienttoday = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        lbl_staff = New Label()
        Label4 = New Label()
        Panel6 = New Panel()
        Label8 = New Label()
        Panel3 = New Panel()
        lbl_BedUnava = New Label()
        lbl_Bedava = New Label()
        Label13 = New Label()
        Panel7 = New Panel()
        Label9 = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        lblUnpay = New Label()
        lblPay = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Label7 = New Label()
        Panel8 = New Panel()
        Label10 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(181), CByte(55), CByte(55))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(lbl_Qpatienttoday)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(60, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 0
        ' 
        ' lbl_Qpatienttoday
        ' 
        lbl_Qpatienttoday.AutoSize = True
        lbl_Qpatienttoday.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Qpatienttoday.ForeColor = SystemColors.ControlLightLight
        lbl_Qpatienttoday.Location = New Point(76, 32)
        lbl_Qpatienttoday.Name = "lbl_Qpatienttoday"
        lbl_Qpatienttoday.Size = New Size(51, 40)
        lbl_Qpatienttoday.TabIndex = 1
        lbl_Qpatienttoday.Text = "00"
        lbl_Qpatienttoday.TextAlign = ContentAlignment.MiddleCenter
        lbl_Qpatienttoday.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(36, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 17)
        Label3.TabIndex = 0
        Label3.Text = "New Patient in today"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(181), CByte(55), CByte(55))
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(lbl_staff)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel6)
        Panel2.Location = New Point(282, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 1
        ' 
        ' lbl_staff
        ' 
        lbl_staff.AutoSize = True
        lbl_staff.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_staff.ForeColor = SystemColors.ControlLightLight
        lbl_staff.Location = New Point(78, 32)
        lbl_staff.Name = "lbl_staff"
        lbl_staff.Size = New Size(51, 40)
        lbl_staff.TabIndex = 2
        lbl_staff.Text = "00"
        lbl_staff.TextAlign = ContentAlignment.MiddleCenter
        lbl_staff.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(54, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 17)
        Label4.TabIndex = 10
        Label4.Text = "Staff in hospital"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(206), CByte(90), CByte(90))
        Panel6.Controls.Add(Label8)
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 29)
        Panel6.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(75, 4)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 21)
        Label8.TabIndex = 10
        Label8.Text = "STAFF"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(181), CByte(55), CByte(55))
        Panel3.BackgroundImageLayout = ImageLayout.None
        Panel3.Controls.Add(lbl_BedUnava)
        Panel3.Controls.Add(lbl_Bedava)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(498, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(223, 100)
        Panel3.TabIndex = 2
        ' 
        ' lbl_BedUnava
        ' 
        lbl_BedUnava.AutoSize = True
        lbl_BedUnava.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_BedUnava.ForeColor = SystemColors.ControlLightLight
        lbl_BedUnava.Location = New Point(138, 32)
        lbl_BedUnava.Name = "lbl_BedUnava"
        lbl_BedUnava.Size = New Size(51, 40)
        lbl_BedUnava.TabIndex = 12
        lbl_BedUnava.Text = "00"
        lbl_BedUnava.TextAlign = ContentAlignment.MiddleCenter
        lbl_BedUnava.UseWaitCursor = True
        ' 
        ' lbl_Bedava
        ' 
        lbl_Bedava.AutoSize = True
        lbl_Bedava.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Bedava.ForeColor = SystemColors.ControlLightLight
        lbl_Bedava.Location = New Point(31, 32)
        lbl_Bedava.Name = "lbl_Bedava"
        lbl_Bedava.Size = New Size(51, 40)
        lbl_Bedava.TabIndex = 11
        lbl_Bedava.Text = "00"
        lbl_Bedava.TextAlign = ContentAlignment.MiddleCenter
        lbl_Bedava.UseWaitCursor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(110, 76)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 17)
        Label13.TabIndex = 11
        Label13.Text = "Unavailable Bed"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(206), CByte(90), CByte(90))
        Panel7.Controls.Add(Label9)
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(223, 29)
        Panel7.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(89, 4)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 21)
        Label9.TabIndex = 0
        Label9.Text = "BED"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(15, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 17)
        Label5.TabIndex = 0
        Label5.Text = "Available bed"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(181), CByte(55), CByte(55))
        Panel4.BackgroundImageLayout = ImageLayout.None
        Panel4.Controls.Add(lblUnpay)
        Panel4.Controls.Add(lblPay)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(739, 83)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 100)
        Panel4.TabIndex = 3
        ' 
        ' lblUnpay
        ' 
        lblUnpay.AutoSize = True
        lblUnpay.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblUnpay.ForeColor = SystemColors.ControlLightLight
        lblUnpay.Location = New Point(134, 32)
        lblUnpay.Name = "lblUnpay"
        lblUnpay.Size = New Size(51, 40)
        lblUnpay.TabIndex = 14
        lblUnpay.Text = "00"
        lblUnpay.TextAlign = ContentAlignment.MiddleCenter
        lblUnpay.UseWaitCursor = True
        ' 
        ' lblPay
        ' 
        lblPay.AutoSize = True
        lblPay.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblPay.ForeColor = SystemColors.ControlLightLight
        lblPay.Location = New Point(29, 33)
        lblPay.Name = "lblPay"
        lblPay.Size = New Size(51, 40)
        lblPay.TabIndex = 13
        lblPay.Text = "00"
        lblPay.TextAlign = ContentAlignment.MiddleCenter
        lblPay.UseWaitCursor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(126, 76)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 17)
        Label11.TabIndex = 10
        Label11.Text = "UNPAID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(29, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 17)
        Label6.TabIndex = 0
        Label6.Text = "PAID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(415, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 45)
        Label1.TabIndex = 7
        Label1.Text = "Dashboard"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(206), CByte(90), CByte(90))
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(60, 83)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 29)
        Panel5.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(67, 4)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 21)
        Label7.TabIndex = 10
        Label7.Text = "PATIENT"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(206), CByte(90), CByte(90))
        Panel8.Controls.Add(Label10)
        Panel8.Location = New Point(739, 83)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(200, 29)
        Panel8.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(61, 4)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 21)
        Label10.TabIndex = 10
        Label10.Text = "PAYMENT"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1038, 663)
        Controls.Add(Panel8)
        Controls.Add(Panel5)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_Qpatienttoday As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_Bedava As Label
    Friend WithEvents lbl_BedUnava As Label
    Friend WithEvents lblUnpay As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
