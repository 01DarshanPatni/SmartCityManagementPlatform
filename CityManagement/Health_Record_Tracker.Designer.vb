﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Health_Record_Tracker
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
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel3 = New Panel()
        Label20 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1097, 60)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Segoe UI", 18.0F)
        Label4.ForeColor = SystemColors.GrayText
        Label4.Location = New Point(65, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 32)
        Label4.TabIndex = 3
        Label4.Text = "Specialization"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Segoe UI", 18.0F)
        Label3.ForeColor = SystemColors.GrayText
        Label3.Location = New Point(629, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 32)
        Label3.TabIndex = 2
        Label3.Text = "Health Record"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Segoe UI", 18.0F)
        Label2.ForeColor = SystemColors.GrayText
        Label2.Location = New Point(371, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 32)
        Label2.TabIndex = 1
        Label2.Text = "Hospitals"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 18.0F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(921, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 32)
        Label1.TabIndex = 0
        Label1.Text = "Work"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.arrow_icons
        PictureBox1.Location = New Point(60, 76)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(13, 11)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label5.Location = New Point(74, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 15)
        Label5.TabIndex = 26
        Label5.Text = "Health record tracker"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 25
        Label6.Text = "Health"
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.LightSteelBlue
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(24, 103)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(478, 242)
        Panel2.TabIndex = 28
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12.0F)
        Label13.Location = New Point(27, 84)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 21)
        Label13.TabIndex = 6
        Label13.Text = "Gender : Male"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12.0F)
        Label12.Location = New Point(27, 205)
        Label12.Name = "Label12"
        Label12.Size = New Size(253, 21)
        Label12.TabIndex = 5
        Label12.Text = "Address : Lohit Hostel, IIT Guwahati"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12.0F)
        Label11.Location = New Point(27, 144)
        Label11.Name = "Label11"
        Label11.Size = New Size(105, 21)
        Label11.TabIndex = 4
        Label11.Text = "Weight : 75kg"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12.0F)
        Label10.Location = New Point(27, 174)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 21)
        Label10.TabIndex = 3
        Label10.Text = "Blood Group : B+"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F)
        Label9.Location = New Point(27, 53)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 21)
        Label9.TabIndex = 2
        Label9.Text = "Age : 21"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F)
        Label8.Location = New Point(27, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 21)
        Label8.TabIndex = 1
        Label8.Text = "Height : 168 cm"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F)
        Label7.Location = New Point(27, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 21)
        Label7.TabIndex = 0
        Label7.Text = "Name : Anand Keshav"
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.Controls.Add(Label20)
        Panel3.Location = New Point(24, 351)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(266, 39)
        Panel3.TabIndex = 29
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.LightSteelBlue
        Label20.Font = New Font("Segoe UI", 20.0F)
        Label20.Location = New Point(0, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(265, 37)
        Label20.TabIndex = 0
        Label20.Text = "Appointment History"
        ' 
        ' Health_Record_Tracker
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1097, 690)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Health_Record_Tracker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Health_ViewAppointment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
End Class
