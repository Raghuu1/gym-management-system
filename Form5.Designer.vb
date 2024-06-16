<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(270, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 31)
        Label2.TabIndex = 1
        Label2.Text = "MEMBER ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label3.Location = New Point(236, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 32)
        Label3.TabIndex = 2
        Label3.Text = "HEIGHT (in CM)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label4.Location = New Point(236, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 32)
        Label4.TabIndex = 3
        Label4.Text = "WEIGHT (in KG)"
        ' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        TextBox2.Location = New Point(552, 218)
        TextBox2.MaxLength = 3
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 39)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        TextBox3.Location = New Point(552, 326)
        TextBox3.MaxLength = 3
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 39)
        TextBox3.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(638, 636)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 61)
        Button1.TabIndex = 7
        Button1.Text = "📅   CALCULATE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(162, 636)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 61)
        Button2.TabIndex = 8
        Button2.Text = " ❌  CLEAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1197, 275)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(530, 269)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Window
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Desktop
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(1428, 875)
        Button3.Name = "Button3"
        Button3.Size = New Size(219, 76)
        Button3.TabIndex = 10
        Button3.Text = "👈BACK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label5.Location = New Point(271, 419)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 32)
        Label5.TabIndex = 11
        Label5.Text = "BMI VALUE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label6.Location = New Point(552, 419)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 32)
        Label6.TabIndex = 12
        Label6.Text = "            ?"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label7.Location = New Point(552, 520)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 32)
        Label7.TabIndex = 13
        Label7.Text = "            ?"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(ProgressBar1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(175, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(970, 752)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "BMI CALCULATOR"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(554, 126)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(174, 39)
        ComboBox1.TabIndex = 16
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(-31, 725)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1091, 25)
        ProgressBar1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(287, 520)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 32)
        Label1.TabIndex = 14
        Label1.Text = "RESULT"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1151, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(635, 268)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1820, 1055)
        Controls.Add(PictureBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Button3)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ComboBox1 As ComboBox
End Class
