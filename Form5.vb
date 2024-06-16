Imports System.Data.SqlClient

Public Class Form5
    Public Property MemberID As String
    Dim memberid1 As String = Form4.MemberId1
    Private bmiCalculated As Boolean = False ' Variable to track whether BMI calculation is done

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        ProgressBar1.Value = 0
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox3.KeyPress
        ' Allow only numbers, backspace, and delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Delete) Then
            e.Handled = True
            MessageBox.Show("ONLY NUMBERS ARE ALLOWED 📟")
        End If

        ' Disallow space input
        If e.KeyChar = " " Then
            e.Handled = True
            MessageBox.Show("SPACE IS NOT ALLOWED")
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with Member IDs from the Member registration table
        PopulateMemberIDs()
        ' Set the selected Member ID from Form4
        ComboBox1.SelectedItem = memberid1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Me.WindowState = FormWindowState.Maximized

        ' Make ComboBox1 non-editable
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim H, W, R As Double
        ' Check if ComboBox1 is selected
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("PLEASE SELECT A MEMBER ID 😊!")
            Return
        End If

        ' Validate TextBox2 for numbers between 100 and 250
        Dim userInput As String = TextBox2.Text.Trim()
        If Not IsNumeric(userInput) Then
            MessageBox.Show("INVALID HEIGHT. PLEASE ENTER A NUMBER.")
            Return
        End If
        Dim height As Double = Double.Parse(userInput)
        If height < 100 OrElse height > 250 Then
            MessageBox.Show("INVALID HEIGHT. PLEASE ENTER A NUMBER BETWEEN 100 AND 250.")
            Return
        End If

        ' Validate TextBox3 for numbers between 30 and 250
        userInput = TextBox3.Text.Trim()
        If Not IsNumeric(userInput) Then
            MessageBox.Show("INVALID WEIGHT. PLEASE ENTER A NUMBER.")
            Return
        End If
        Dim weight As Double = Double.Parse(userInput)
        If weight < 30 OrElse weight > 250 Then
            MessageBox.Show("INVALID WEIGHT. PLEASE ENTER A NUMBER BETWEEN 30 AND 250.")
            Return
        End If

        ' Convert TextBox2 and TextBox3 values to Double
        H = height
        W = weight
        H = H / 100
        R = W / (H) ^ 2
        R = Math.Round(R, 1)
        Label6.Text = R

        If (R <= 18.5) Then
            Label7.Text = "UNDERWEIGHT"
            Label7.BackColor = Color.Blue
        ElseIf ((R > 18.6) And (R < 24.9)) Then
            Label7.Text = "HEALTHY"
            Label7.BackColor = Color.Green
        ElseIf ((R > 25.0) And (R < 29.9)) Then
            Label7.Text = "OVERWEIGHT"
            Label7.BackColor = Color.Yellow
        ElseIf ((R > 30.0) And (R < 39.9)) Then
            Label7.Text = "OBESE"
            Label7.BackColor = Color.Orange
        ElseIf (R > 40) Then
            Label7.Text = "SEVERELY OBESE"
            Label7.BackColor = Color.Red
        End If
        Try
            ' Connection string for your SQL Server
            Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"

            ' SQL query to insert data into the BMI calculator table
            Dim query As String = "INSERT INTO [BMI calculator] ([MEMBER ID], [HEIGHT(in cm)], [WEIGHT(in kg)], [BMI VALUE], [RESULT]) VALUES (@MemberID, @Height, @Weight, @BMIValue, @RESULT)"

            ' Create a connection object
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command object with the SQL query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@MemberID", ComboBox1.SelectedItem.ToString())
                    ' Save height as an integer
                    command.Parameters.AddWithValue("@Height", CInt(H * 100))
                    command.Parameters.AddWithValue("@Weight", W)
                    command.Parameters.AddWithValue("@BMIValue", R)
                    command.Parameters.AddWithValue("@RESULT", Label7.Text)

                    ' Execute the command
                    command.ExecuteNonQuery()

                    ' Set bmiCalculated to true after successful BMI calculation and data saving
                    bmiCalculated = True
                    ProgressBar1.Value = 100
                    ' Show success message
                    MessageBox.Show("DATA SAVED SUCCESSFULLY 😊.")
                End Using
            End Using
            ProgressBar1.Value = 0
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateMemberIDs()
        Try
            ' Connection string for your SQL Server
            Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"

            ' SQL query to select all Member IDs from the Member registration table
            Dim query As String = "SELECT [MEMBER ID] FROM [Member registration]"

            ' Create a connection object
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command object with the SQL query and connection
                Using command As New SqlCommand(query, connection)
                    ' Create a data reader to read the result of the command
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Loop through each row in the result set
                        While reader.Read()
                            ' Add the Member ID to the ComboBox
                            ComboBox1.Items.Add(reader("MEMBER ID").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Member IDs: " & ex.Message)
        End Try
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub
End Class
