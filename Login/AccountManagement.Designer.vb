﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.DGVaccounts = New System.Windows.Forms.DataGridView()
        Me.accountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accesslevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.buttonpic = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBpic = New System.Windows.Forms.PictureBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbolevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        CType(Me.DGVaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmodify
        '
        Me.btnmodify.AutoSize = True
        Me.btnmodify.BackColor = System.Drawing.Color.Transparent
        Me.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnmodify.Location = New System.Drawing.Point(109, 360)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(86, 43)
        Me.btnmodify.TabIndex = 31
        Me.btnmodify.Text = "Modify"
        Me.btnmodify.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.AutoSize = True
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnadd.Location = New System.Drawing.Point(400, 360)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(60, 43)
        Me.btnadd.TabIndex = 32
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.AutoSize = True
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btndelete.Location = New System.Drawing.Point(19, 360)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(84, 43)
        Me.btndelete.TabIndex = 33
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'DGVaccounts
        '
        Me.DGVaccounts.AllowUserToAddRows = False
        Me.DGVaccounts.AllowUserToDeleteRows = False
        Me.DGVaccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVaccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVaccounts.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVaccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGVaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.accountID, Me.username, Me.Accesslevel})
        Me.DGVaccounts.Location = New System.Drawing.Point(14, 129)
        Me.DGVaccounts.MultiSelect = False
        Me.DGVaccounts.Name = "DGVaccounts"
        Me.DGVaccounts.ReadOnly = True
        Me.DGVaccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVaccounts.Size = New System.Drawing.Size(381, 225)
        Me.DGVaccounts.TabIndex = 34
        '
        'accountID
        '
        Me.accountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.accountID.HeaderText = "Account ID"
        Me.accountID.Name = "accountID"
        Me.accountID.ReadOnly = True
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'Accesslevel
        '
        Me.Accesslevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Accesslevel.HeaderText = "Access Level"
        Me.Accesslevel.Name = "Accesslevel"
        Me.Accesslevel.ReadOnly = True
        '
        'btnclear
        '
        Me.btnclear.AutoSize = True
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnclear.Location = New System.Drawing.Point(322, 360)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(73, 43)
        Me.btnclear.TabIndex = 35
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.AutoSize = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnback.Location = New System.Drawing.Point(715, 395)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(73, 43)
        Me.btnback.TabIndex = 36
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'buttonpic
        '
        Me.buttonpic.AutoSize = True
        Me.buttonpic.BackColor = System.Drawing.Color.Transparent
        Me.buttonpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonpic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonpic.ForeColor = System.Drawing.Color.NavajoWhite
        Me.buttonpic.Location = New System.Drawing.Point(676, 248)
        Me.buttonpic.Name = "buttonpic"
        Me.buttonpic.Size = New System.Drawing.Size(100, 26)
        Me.buttonpic.TabIndex = 49
        Me.buttonpic.Text = "Update Pic:"
        Me.buttonpic.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(672, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Account Pic:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PBpic
        '
        Me.PBpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBpic.Location = New System.Drawing.Point(676, 156)
        Me.PBpic.Name = "PBpic"
        Me.PBpic.Size = New System.Drawing.Size(100, 91)
        Me.PBpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBpic.TabIndex = 47
        Me.PBpic.TabStop = False
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(507, 270)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(140, 29)
        Me.txtpassword.TabIndex = 61
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(507, 130)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(140, 29)
        Me.txtID.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(399, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Account ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbolevel
        '
        Me.cbolevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cbolevel.FormattingEnabled = True
        Me.cbolevel.Location = New System.Drawing.Point(526, 305)
        Me.cbolevel.Name = "cbolevel"
        Me.cbolevel.Size = New System.Drawing.Size(121, 32)
        Me.cbolevel.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(404, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 57
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
        Me.Label1.Location = New System.Drawing.Point(396, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Access Level:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(507, 235)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(140, 29)
        Me.txtusername.TabIndex = 54
        '
        'txtcode
        '
        Me.txtcode.AutoSize = True
        Me.txtcode.BackColor = System.Drawing.Color.Transparent
        Me.txtcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.NavajoWhite
        Me.txtcode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtcode.Location = New System.Drawing.Point(399, 235)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(102, 24)
        Me.txtcode.TabIndex = 55
        Me.txtcode.Text = "Username:"
        Me.txtcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(507, 200)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(140, 29)
        Me.txtlname.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(399, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Last Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(507, 165)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(140, 29)
        Me.txtfname.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(399, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "First Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnupdate
        '
        Me.btnupdate.AutoSize = True
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.NavajoWhite
        Me.btnupdate.Location = New System.Drawing.Point(466, 360)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(91, 43)
        Me.btnupdate.TabIndex = 70
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbolevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.buttonpic)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PBpic)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.DGVaccounts)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnmodify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountManagement"
        Me.Text = "AccountManagement"
        CType(Me.DGVaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnmodify As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents DGVaccounts As DataGridView
    Friend WithEvents btnclear As Button
    Friend WithEvents btnback As Button
    Friend WithEvents buttonpic As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PBpic As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbolevel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtcode As Label
    Friend WithEvents accountID As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents Accesslevel As DataGridViewTextBoxColumn
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnupdate As Button
End Class
