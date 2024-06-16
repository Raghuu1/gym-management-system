<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        TextBox4 = New TextBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImageLayout = ImageLayout.Zoom
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.Info
        GroupBox1.Location = New Point(34, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1724, 744)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "MEMBER   REGISTRATION   "
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold Or FontStyle.Italic)
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(1242, 600)
        Button4.Name = "Button4"
        Button4.Size = New Size(228, 41)
        Button4.TabIndex = 16
        Button4.Text = "PAY AND PRINT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        TextBox4.Location = New Point(1197, 465)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(307, 47)
        TextBox4.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Black
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        Label6.Location = New Point(881, 466)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 46)
        Label6.TabIndex = 14
        Label6.Text = "Amount"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ButtonFace
        ComboBox1.Cursor = Cursors.Hand
        ComboBox1.Font = New Font("Segoe UI", 18F)
        ComboBox1.ForeColor = SystemColors.InfoText
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"SILVER", "GOLD ", "PLATINUM"})
        ComboBox1.Location = New Point(1197, 300)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(318, 49)
        ComboBox1.TabIndex = 13
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = SystemColors.Window
        DateTimePicker1.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        DateTimePicker1.CalendarTitleForeColor = SystemColors.ButtonHighlight
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(1197, 152)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(318, 47)
        DateTimePicker1.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ButtonFace
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Segoe UI", 18F)
        TextBox3.ForeColor = SystemColors.InfoText
        TextBox3.Location = New Point(410, 465)
        TextBox3.MaxLength = 10
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(242, 47)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ButtonFace
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 18F)
        TextBox2.ForeColor = SystemColors.InfoText
        TextBox2.Location = New Point(410, 302)
        TextBox2.MaxLength = 20
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(242, 47)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ButtonFace
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Segoe UI", 18F)
        TextBox1.ForeColor = SystemColors.InfoText
        TextBox1.Location = New Point(410, 151)
        TextBox1.MaxLength = 6
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(242, 47)
        TextBox1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.Info
        Label5.Location = New Point(803, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 46)
        Label5.TabIndex = 4
        Label5.Text = "JOIN DATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Info
        Label4.Location = New Point(759, 303)
        Label4.Name = "Label4"
        Label4.Size = New Size(342, 46)
        Label4.TabIndex = 3
        Label4.Text = "MEMBERSHIP PLAN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(16, 466)
        Label3.Name = "Label3"
        Label3.Size = New Size(355, 46)
        Label3.TabIndex = 2
        Label3.Text = "MEMBER PHONE NO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Info
        Label2.Location = New Point(39, 303)
        Label2.Name = "Label2"
        Label2.Size = New Size(277, 46)
        Label2.TabIndex = 1
        Label2.Text = "MEMBER NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(105, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 46)
        Label1.TabIndex = 0
        Label1.Text = "MEMBER ID"
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Window
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.Desktop
        Button3.Location = New Point(95, 868)
        Button3.Name = "Button3"
        Button3.Size = New Size(218, 59)
        Button3.TabIndex = 12
        Button3.Text = "👈BACK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(702, 868)
        Button2.Name = "Button2"
        Button2.Size = New Size(218, 59)
        Button2.TabIndex = 11
        Button2.Text = "🔃RESET"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Button1.ForeColor = Color.Green
        Button1.Location = New Point(1310, 868)
        Button1.Name = "Button1"
        Button1.RightToLeft = RightToLeft.No
        Button1.Size = New Size(433, 59)
        Button1.TabIndex = 10
        Button1.Text = "💾SAVE ＆ CONTINUE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1838, 1055)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        DoubleBuffered = True
        Name = "Form4"
        Text = " "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
End Class
