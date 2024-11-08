<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManagement
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
        Me.btnapproval = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGVrooms = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrname = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pic = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnapproval
        '
        Me.btnapproval.AutoSize = True
        Me.btnapproval.BackColor = System.Drawing.Color.Transparent
        Me.btnapproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnapproval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapproval.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnapproval.Location = New System.Drawing.Point(109, 360)
        Me.btnapproval.Name = "btnapproval"
        Me.btnapproval.Size = New System.Drawing.Size(86, 43)
        Me.btnapproval.TabIndex = 31
        Me.btnapproval.Text = "Modify"
        Me.btnapproval.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button1.Location = New System.Drawing.Point(575, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 43)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button2.Location = New System.Drawing.Point(19, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 43)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DGVrooms
        '
        Me.DGVrooms.AllowUserToAddRows = False
        Me.DGVrooms.AllowUserToDeleteRows = False
        Me.DGVrooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVrooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVrooms.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVrooms.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVrooms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.AccountLevel, Me.Pic})
        Me.DGVrooms.Location = New System.Drawing.Point(14, 129)
        Me.DGVrooms.MultiSelect = False
        Me.DGVrooms.Name = "DGVrooms"
        Me.DGVrooms.ReadOnly = True
        Me.DGVrooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVrooms.Size = New System.Drawing.Size(414, 225)
        Me.DGVrooms.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button3.Location = New System.Drawing.Point(496, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 43)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button4.Location = New System.Drawing.Point(715, 395)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 43)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button5.Location = New System.Drawing.Point(681, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 26)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Add Pic"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(453, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Account Pic:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(575, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 91)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(575, 274)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 29)
        Me.TextBox1.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(472, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(434, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Account Level:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtrname
        '
        Me.txtrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrname.Location = New System.Drawing.Point(575, 236)
        Me.txtrname.Name = "txtrname"
        Me.txtrname.Size = New System.Drawing.Size(200, 29)
        Me.txtrname.TabIndex = 41
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.BackColor = System.Drawing.Color.Transparent
        Me.txtcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.NavajoWhite
        Me.txtcode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtcode.Location = New System.Drawing.Point(467, 238)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(102, 24)
        Me.txtcode.TabIndex = 42
        Me.txtcode.Text = "Username:"
        Me.txtcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(575, 310)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 50
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'AccountLevel
        '
        Me.AccountLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AccountLevel.HeaderText = "Account Level"
        Me.AccountLevel.Name = "AccountLevel"
        Me.AccountLevel.ReadOnly = True
        '
        'Pic
        '
        Me.Pic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Pic.HeaderText = "Account Picture"
        Me.Pic.Name = "Pic"
        Me.Pic.ReadOnly = True
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtrname)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DGVrooms)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnapproval)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountManagement"
        Me.Text = "AccountManagement"
        CType(Me.DGVrooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnapproval As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DGVrooms As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrname As TextBox
    Friend WithEvents txtcode As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents AccountLevel As DataGridViewTextBoxColumn
    Friend WithEvents Pic As DataGridViewImageColumn
End Class
