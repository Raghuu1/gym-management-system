Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" AndAlso TextBox2.Text = "" Then
            ' Display a message indicating both fields are empty
            MessageBox.Show("Please enter username and password")
        ElseIf TextBox1.Text = "" Then
            ' Display a message indicating username is empty
            MessageBox.Show("Please enter username")
        ElseIf TextBox2.Text = "" Then
            ' Display a message indicating password is empty
            MessageBox.Show("Please enter password")
        ElseIf TextBox1.Text = "kjc" AndAlso TextBox2.Text = "abc" Then
            ' Simulate a login process (replace this with your actual login logic)
            Dim username As String = TextBox1.Text
            Dim password As String = TextBox2.Text

            ' Display a message indicating successful login
            ProgressBar1.Value = 100
            MessageBox.Show("Login Successful")

            ' Open the next form
            Dim form2 As New Form2
            form2.Show()
            ' Close this form after the next form is closed
            Me.Hide()
        Else
            ' Display a message indicating unsuccessful login
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub Button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ProgressBar1.Value = 0
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if Enter key was pressed
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            ' Set focus to the next control
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if Enter key was pressed
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            ' Set focus to the next control
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
