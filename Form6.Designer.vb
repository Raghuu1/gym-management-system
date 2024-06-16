<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label8 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 41)
        Label1.TabIndex = 0
        Label1.Text = "RECEIPT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 1
        Label2.Text = "MEMBER ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(192, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 2
        Label3.Text = "MEMBER NAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(192, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 20)
        Label4.TabIndex = 3
        Label4.Text = "MEMBER PHONE NO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(192, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 4
        Label5.Text = "JOIN DATE "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(192, 350)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 20)
        Label6.TabIndex = 5
        Label6.Text = "MEMBERSHIP PLAN"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(192, 407)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 20)
        Label7.TabIndex = 6
        Label7.Text = "AMOUNT"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(411, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(140, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(411, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(140, 27)
        TextBox2.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(326, 478)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 37)
        Button1.TabIndex = 13
        Button1.Text = "DONE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(192, 89)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 20)
        Label8.TabIndex = 15
        Label8.Text = "RECEIPT ID"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(411, 190)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(140, 27)
        TextBox3.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(411, 247)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(140, 27)
        TextBox4.TabIndex = 17
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(411, 350)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(140, 27)
        TextBox5.TabIndex = 18
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(411, 407)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(140, 27)
        TextBox6.TabIndex = 19
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(411, 304)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(184, 27)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(761, 537)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
