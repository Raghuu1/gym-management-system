Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form3
    Private Sub Button3_click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Textbox3_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If TextBox3.Text.Length = 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("THIS FIELD ACCEPTS ONLY 10 DIGITS  🔢")
            End If
        End If
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Allowing only digits, backspace, and delete
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> Chr(Keys.Delete) Then
            e.Handled = True
            MessageBox.Show("THIS FIELD ACCEPTS ONLY NUMERIC INPUT 🔢.")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("THIS FIELD ALLOWS ONLY LETTERS  🔠")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Set e.Handled to True to prevent editing or backspacing in TextBox1
        e.Handled = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch the last Trainer ID from the database and auto-generate the next Trainer ID
        FetchLastTrainerID()
        Me.WindowState = FormWindowState.Maximized

        ' Set ComboBox1 to non-editable
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub FetchLastTrainerID()
        Try
            Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT MAX([TRAINER ID]) FROM [Trainer registration]"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Dim lastTrainerID As Integer = Convert.ToInt32(result)
                        TextBox1.Text = (lastTrainerID + 1).ToString("D6")
                    Else
                        TextBox1.Text = "123456"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching Trainer ID: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox2.Text = "" Then
            MessageBox.Show("PLEASE FILL IN ALL REQUIRED FIELD 😊!")
            Exit Sub
        End If

        ' Check if Trainer ID contains exactly 6 digits
        If TextBox1.Text.Length <> 6 Then
            MessageBox.Show("TRAINER ID SHOULD CONTAIN EXACTLY 6 DIGITS.")
            Exit Sub
        End If


        ' Check if Phone Number contains exactly 10 digits and satisfies the additional constraints
        If Not ValidatePhoneNumber(TextBox3.Text) Then
            MessageBox.Show("INVALID PHONE NO✖️.")
            Exit Sub
        End If

        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if the Trainer ID already exists
                Dim idExistsQuery As String = "SELECT COUNT(*) FROM [Trainer registration] WHERE [TRAINER ID] = @TrainerID"
                Using idExistsCommand As New SqlCommand(idExistsQuery, connection)
                    idExistsCommand.Parameters.AddWithValue("@TrainerID", TextBox1.Text)
                    Dim idCount As Integer = Convert.ToInt32(idExistsCommand.ExecuteScalar())

                    If idCount > 0 Then
                        MessageBox.Show("Trainer ID already exists in the database. Please choose a different ID.")
                        Exit Sub
                    End If
                End Using

                ' Check if the Phone Number already exists
                Dim phoneExistsQuery As String = "SELECT COUNT(*) FROM [Trainer registration] WHERE [TRAINER PHONE NO] = @TrainerPhoneNo"
                Using phoneExistsCommand As New SqlCommand(phoneExistsQuery, connection)
                    phoneExistsCommand.Parameters.AddWithValue("@TrainerPhoneNo", TextBox3.Text)
                    Dim phoneCount As Integer = Convert.ToInt32(phoneExistsCommand.ExecuteScalar())

                    If phoneCount > 0 Then
                        MessageBox.Show("Phone number already exists in the database. Please enter a different phone number.")
                        Exit Sub
                    End If
                End Using

                ' SQL query to insert data into the database
                Dim query As String = "INSERT INTO [Trainer registration] ([TRAINER ID], [TRAINER NAME], [TRAINER PHONE NO], [TRAINER ADDRESS], [EXPERIENCE]) VALUES (@TrainerID, @TrainerName, @TrainerPhoneNo, @TrainerAddress, @Experience)"

                Using command As New SqlCommand(query, connection)
                    ' Replace @TrainerID, @TrainerName, @TrainerPhoneNo, @TrainerAddress, @Experience with actual parameter names (e.g., TextBox1.Text)
                    command.Parameters.AddWithValue("@TrainerID", TextBox1.Text)
                    command.Parameters.AddWithValue("@TrainerName", TextBox2.Text)
                    command.Parameters.AddWithValue("@TrainerPhoneNo", TextBox3.Text)
                    command.Parameters.AddWithValue("@TrainerAddress", TextBox4.Text)
                    command.Parameters.AddWithValue("@Experience", ComboBox2.Text)

                    command.ExecuteNonQuery()
                    MessageBox.Show("DATA SAVED SUCCESSFULLY 😊.")
                    Form2.Show()
                    Me.Close()
                    ' Update Trainer ID for the next registration
                    FetchLastTrainerID()

                    ' Clear all text boxes and the combo box
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    ComboBox2.SelectedIndex = -1 ' Reset combo box selection
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateTrainerID()
        Try
            Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Get the last Trainer ID from the database
                Dim query As String = "SELECT MAX([TRAINER ID]) FROM [Trainer registration]"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Dim lastTrainerID As Integer = Convert.ToInt32(result)
                        ' Increment the last Trainer ID to get the new ID
                        Dim newTrainerID As Integer = lastTrainerID + 1

                        ' Update the Trainer ID in the database
                        Dim updateQuery As String = "UPDATE [Trainer registration] SET [TRAINER ID] = @NewTrainerID WHERE [TRAINER ID] = @LastTrainerID"
                        Using updateCommand As New SqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@NewTrainerID", newTrainerID)
                            updateCommand.Parameters.AddWithValue("@LastTrainerID", lastTrainerID)
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating Trainer ID: " & ex.Message)
        End Try
    End Sub

    Shared Function ValidatePhoneNumber(phoneNumber As String) As Boolean
        ' Check if the phone number starts with 0-5
        If Regex.IsMatch(phoneNumber, "^[0-5]") Then
            MessageBox.Show("INVALID INPUT")
            Return False
        End If
        ' Check if the phone number contains only 10 digits
        If Not Regex.IsMatch(phoneNumber, "^\d{10}$") Then
            MessageBox.Show("INVALID PHONE NO ❌")
            Return False
        End If
        ' Check if the phone number has repeating digits more than 3 times consecutively
        If Regex.IsMatch(phoneNumber, "(.)\1{4,}") Then
            MessageBox.Show("INVALID PHONE NO ❌ ")
            Return False
        End If
        Return True
    End Function

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        ' Suppress the key press event to prevent changing the selected item in ComboBox2 using the keyboard
        e.SuppressKeyPress = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ' Regular expression to match allowed characters in an address
        Dim allowedCharsRegex As String = "^[a-zA-Z0-9\s.,#-]+$"

        ' Check if the entered text contains only allowed characters
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBox4.Text, allowedCharsRegex) Then
            ' If not, remove the last entered character
            TextBox4.Text = Regex.Replace(TextBox4.Text, "[^a-zA-Z0-9\s.,#-]", "")
            ' Set the cursor position to the end of the text
            TextBox4.SelectionStart = TextBox4.TextLength
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
