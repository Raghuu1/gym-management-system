<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        GroupBox1 = New GroupBox()
        ComboBox2 = New ComboBox()
        TextBox4 = New TextBox()
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(36, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1682, 676)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "TRAINER   REGISTRATION   "
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {" 1  -  5  Years", " 6  - 10 Years", "11 - 15 Years", "16 - 20 Years", "21 - 25 Years", ""})
        ComboBox2.Location = New Point(1136, 428)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(214, 49)
        ComboBox2.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.Font = New Font("Microsoft Sans Serif", 18F)
        TextBox4.Location = New Point(1148, 162)
        TextBox4.MaxLength = 50
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(367, 143)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Font = New Font("Segoe UI", 18F)
        TextBox3.Location = New Point(465, 431)
        TextBox3.MaxLength = 10
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(264, 47)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 18F)
        TextBox2.Location = New Point(465, 296)
        TextBox2.MaxLength = 20
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(264, 47)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(465, 162)
        TextBox1.MaxLength = 6
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(264, 47)
        TextBox1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(851, 432)
        Label5.Name = "Label5"
        Label5.Size = New Size(226, 46)
        Label5.TabIndex = 4
        Label5.Text = "EXPERIENCE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(777, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(340, 46)
        Label4.TabIndex = 3
        Label4.Text = "TRAINER ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(31, 431)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 46)
        Label3.TabIndex = 2
        Label3.Text = "TRAINER PHONE NO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(78, 297)
        Label2.Name = "Label2"
        Label2.Size = New Size(289, 46)
        Label2.TabIndex = 1
        Label2.Text = "TRAINER NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(116, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 46)
        Label1.TabIndex = 0
        Label1.Tag = ""
        Label1.Text = "TRAINER'S ID"
        ' 
        ' Button3
        ' 
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.MenuText
        Button3.Location = New Point(86, 841)
        Button3.Name = "Button3"
        Button3.Size = New Size(204, 57)
        Button3.TabIndex = 12
        Button3.Text = " 👈BACK"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(764, 841)
        Button2.Name = "Button2"
        Button2.Size = New Size(204, 59)
        Button2.TabIndex = 6
        Button2.Text = "🔃RESET"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Button1.ForeColor = Color.Green
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1432, 841)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 59)
        Button1.TabIndex = 5
        Button1.Text = "💾 SAVE        "
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1838, 1055)
        Controls.Add(GroupBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "Form3"
        Text = "Form3"
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
