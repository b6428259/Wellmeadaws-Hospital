<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Loginbtn = New System.Windows.Forms.TextBox()
        Me.Forgotpasstxt = New System.Windows.Forms.Label()
        Me.Remembertxt = New System.Windows.Forms.Label()
        Me.Tboxpass = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Tboxuser = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Passwordtxt = New System.Windows.Forms.Label()
        Me.Usernametxt = New System.Windows.Forms.Label()
        Me.logintxt = New System.Windows.Forms.Label()
        Me.privatetext = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-35, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 70)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Loginbtn)
        Me.Panel1.Controls.Add(Me.Forgotpasstxt)
        Me.Panel1.Controls.Add(Me.Remembertxt)
        Me.Panel1.Controls.Add(Me.Tboxpass)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Tboxuser)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Passwordtxt)
        Me.Panel1.Controls.Add(Me.Usernametxt)
        Me.Panel1.Controls.Add(Me.logintxt)
        Me.Panel1.Location = New System.Drawing.Point(271, 265)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 267)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(145, 164)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 208)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LOGIN"
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Loginbtn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Loginbtn.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!)
        Me.Loginbtn.ForeColor = System.Drawing.Color.White
        Me.Loginbtn.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Loginbtn.Location = New System.Drawing.Point(145, 205)
        Me.Loginbtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Loginbtn.Multiline = True
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(190, 27)
        Me.Loginbtn.TabIndex = 9
        Me.Loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Forgotpasstxt
        '
        Me.Forgotpasstxt.AutoSize = True
        Me.Forgotpasstxt.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!)
        Me.Forgotpasstxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Forgotpasstxt.Location = New System.Drawing.Point(232, 161)
        Me.Forgotpasstxt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Forgotpasstxt.Name = "Forgotpasstxt"
        Me.Forgotpasstxt.Size = New System.Drawing.Size(119, 14)
        Me.Forgotpasstxt.TabIndex = 8
        Me.Forgotpasstxt.Text = "Forgot your password ?"
        '
        'Remembertxt
        '
        Me.Remembertxt.AutoSize = True
        Me.Remembertxt.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!)
        Me.Remembertxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Remembertxt.Location = New System.Drawing.Point(155, 161)
        Me.Remembertxt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Remembertxt.Name = "Remembertxt"
        Me.Remembertxt.Size = New System.Drawing.Size(78, 14)
        Me.Remembertxt.TabIndex = 6
        Me.Remembertxt.Text = "Remember me"
        '
        'Tboxpass
        '
        Me.Tboxpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tboxpass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Tboxpass.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tboxpass.Location = New System.Drawing.Point(145, 132)
        Me.Tboxpass.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tboxpass.Name = "Tboxpass"
        Me.Tboxpass.Size = New System.Drawing.Size(190, 22)
        Me.Tboxpass.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(121, 132)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Tboxuser
        '
        Me.Tboxuser.BackColor = System.Drawing.Color.White
        Me.Tboxuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tboxuser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Tboxuser.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tboxuser.Location = New System.Drawing.Point(145, 76)
        Me.Tboxuser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tboxuser.Name = "Tboxuser"
        Me.Tboxuser.Size = New System.Drawing.Size(190, 22)
        Me.Tboxuser.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(121, 76)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Passwordtxt
        '
        Me.Passwordtxt.AutoSize = True
        Me.Passwordtxt.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!)
        Me.Passwordtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Passwordtxt.Location = New System.Drawing.Point(145, 115)
        Me.Passwordtxt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.Size = New System.Drawing.Size(57, 16)
        Me.Passwordtxt.TabIndex = 4
        Me.Passwordtxt.Text = "Password"
        '
        'Usernametxt
        '
        Me.Usernametxt.AutoSize = True
        Me.Usernametxt.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!)
        Me.Usernametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Usernametxt.Location = New System.Drawing.Point(145, 59)
        Me.Usernametxt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Usernametxt.Name = "Usernametxt"
        Me.Usernametxt.Size = New System.Drawing.Size(59, 16)
        Me.Usernametxt.TabIndex = 1
        Me.Usernametxt.Text = "Username"
        '
        'logintxt
        '
        Me.logintxt.AutoSize = True
        Me.logintxt.Font = New System.Drawing.Font("Microsoft PhagsPa", 21.75!, System.Drawing.FontStyle.Bold)
        Me.logintxt.Location = New System.Drawing.Point(184, 20)
        Me.logintxt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.logintxt.Name = "logintxt"
        Me.logintxt.Size = New System.Drawing.Size(94, 38)
        Me.logintxt.TabIndex = 0
        Me.logintxt.Text = "Login"
        '
        'privatetext
        '
        Me.privatetext.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.privatetext.BackColor = System.Drawing.Color.White
        Me.privatetext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.privatetext.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!)
        Me.privatetext.Location = New System.Drawing.Point(310, 229)
        Me.privatetext.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.privatetext.Multiline = True
        Me.privatetext.Name = "privatetext"
        Me.privatetext.ReadOnly = True
        Me.privatetext.Size = New System.Drawing.Size(368, 31)
        Me.privatetext.TabIndex = 6
        Me.privatetext.Text = "This is a private database. Unauthorized access, use, or disclosure of any inform" &
    "ation contained herein is strictly prohibited. "
        Me.privatetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(284, 106)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(964, 632)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.privatetext)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Loginbtn As TextBox
    Friend WithEvents Tboxpass As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents Tboxuser As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Passwordtxt As Label
    Friend WithEvents Usernametxt As Label
    Friend WithEvents logintxt As Label
    Friend WithEvents privatetext As TextBox
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Forgotpasstxt As Label
    Friend WithEvents Remembertxt As Label
End Class
