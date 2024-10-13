<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.welcome = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnforgot = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.28715!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.75439!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.50488!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.08187!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.371709!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtusername, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.username, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.password, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnlogin, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.welcome, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtpassword, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnforgot, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.444445!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.666667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtusername
        '
        Me.txtusername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtusername.Font = New System.Drawing.Font("Yeseva One", 16.0!)
        Me.txtusername.Location = New System.Drawing.Point(535, 191)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(242, 32)
        Me.txtusername.TabIndex = 15
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.BackColor = System.Drawing.Color.Transparent
        Me.username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.username.Font = New System.Drawing.Font("Yeseva One", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.NavajoWhite
        Me.username.Location = New System.Drawing.Point(395, 188)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(134, 32)
        Me.username.TabIndex = 17
        Me.username.Text = "Username:"
        Me.username.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.password.Font = New System.Drawing.Font("Yeseva One", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.NavajoWhite
        Me.password.Location = New System.Drawing.Point(395, 220)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(134, 34)
        Me.password.TabIndex = 19
        Me.password.Text = "Password:"
        Me.password.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnlogin
        '
        Me.btnlogin.AutoSize = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Yeseva One", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnlogin.Location = New System.Drawing.Point(535, 257)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(242, 29)
        Me.btnlogin.TabIndex = 20
        Me.btnlogin.Text = "LogIn"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.welcome.Font = New System.Drawing.Font("Yeseva One", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.ForeColor = System.Drawing.Color.NavajoWhite
        Me.welcome.Location = New System.Drawing.Point(535, 151)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(242, 37)
        Me.welcome.TabIndex = 16
        Me.welcome.Text = "Welcome"
        Me.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpassword
        '
        Me.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtpassword.Font = New System.Drawing.Font("Yeseva One", 16.0!)
        Me.txtpassword.Location = New System.Drawing.Point(535, 223)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(242, 32)
        Me.txtpassword.TabIndex = 18
        '
        'btnforgot
        '
        Me.btnforgot.AutoSize = True
        Me.btnforgot.BackColor = System.Drawing.Color.Transparent
        Me.btnforgot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnforgot.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnforgot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnforgot.Font = New System.Drawing.Font("Yeseva One", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnforgot.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnforgot.Location = New System.Drawing.Point(437, 257)
        Me.btnforgot.MaximumSize = New System.Drawing.Size(0, 35)
        Me.btnforgot.Name = "btnforgot"
        Me.btnforgot.Size = New System.Drawing.Size(92, 29)
        Me.btnforgot.TabIndex = 22
        Me.btnforgot.Text = "Forgot"
        Me.btnforgot.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log-In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents username As Label
    Friend WithEvents welcome As Label
    Friend WithEvents password As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnforgot As Button
End Class
