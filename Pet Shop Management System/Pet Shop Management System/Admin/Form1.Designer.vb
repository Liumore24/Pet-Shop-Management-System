﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_loginuser = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_changePassword = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_managePets = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_logintime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_logintime)
        Me.Panel1.Controls.Add(Me.lbl_loginuser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 56)
        Me.Panel1.TabIndex = 0
        '
        'lbl_loginuser
        '
        Me.lbl_loginuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_loginuser.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_loginuser.Location = New System.Drawing.Point(814, 8)
        Me.lbl_loginuser.Name = "lbl_loginuser"
        Me.lbl_loginuser.Size = New System.Drawing.Size(203, 17)
        Me.lbl_loginuser.TabIndex = 0
        Me.lbl_loginuser.Text = "Admin"
        Me.lbl_loginuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_managePets, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_user, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_changePassword, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.293682!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.94424!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 598)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.White
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_report.Location = New System.Drawing.Point(3, 168)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_report.Size = New System.Drawing.Size(194, 49)
        Me.btn_report.TabIndex = 7
        Me.btn_report.Text = "Report"
        Me.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'btn_changePassword
        '
        Me.btn_changePassword.BackColor = System.Drawing.Color.White
        Me.btn_changePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changePassword.FlatAppearance.BorderSize = 0
        Me.btn_changePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_changePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_changePassword.Location = New System.Drawing.Point(3, 113)
        Me.btn_changePassword.Name = "btn_changePassword"
        Me.btn_changePassword.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_changePassword.Size = New System.Drawing.Size(194, 49)
        Me.btn_changePassword.TabIndex = 5
        Me.btn_changePassword.Text = "Change Password"
        Me.btn_changePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_changePassword.UseVisualStyleBackColor = False
        '
        'btn_user
        '
        Me.btn_user.BackColor = System.Drawing.Color.White
        Me.btn_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_user.FlatAppearance.BorderSize = 0
        Me.btn_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_user.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_user.Location = New System.Drawing.Point(3, 58)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_user.Size = New System.Drawing.Size(194, 49)
        Me.btn_user.TabIndex = 4
        Me.btn_user.Text = "User's"
        Me.btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_user.UseVisualStyleBackColor = False
        '
        'btn_managePets
        '
        Me.btn_managePets.BackColor = System.Drawing.Color.White
        Me.btn_managePets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_managePets.FlatAppearance.BorderSize = 0
        Me.btn_managePets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_managePets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_managePets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_managePets.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_managePets.Location = New System.Drawing.Point(3, 3)
        Me.btn_managePets.Name = "btn_managePets"
        Me.btn_managePets.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_managePets.Size = New System.Drawing.Size(194, 49)
        Me.btn_managePets.TabIndex = 3
        Me.btn_managePets.Text = "Pet's"
        Me.btn_managePets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_managePets.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(3, 541)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(194, 54)
        Me.btn_logout.TabIndex = 6
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(216, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 571)
        Me.Panel2.TabIndex = 2
        '
        'lbl_logintime
        '
        Me.lbl_logintime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_logintime.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_logintime.Location = New System.Drawing.Point(817, 28)
        Me.lbl_logintime.Name = "lbl_logintime"
        Me.lbl_logintime.Size = New System.Drawing.Size(200, 25)
        Me.lbl_logintime.TabIndex = 1
        Me.lbl_logintime.Text = "Admin"
        Me.lbl_logintime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Shop"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(60, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "P e t"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 654)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_changePassword As System.Windows.Forms.Button
    Friend WithEvents btn_user As System.Windows.Forms.Button
    Friend WithEvents btn_managePets As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_report As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_loginuser As System.Windows.Forms.Label
    Friend WithEvents lbl_logintime As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
