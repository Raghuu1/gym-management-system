Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4

    Private Sub PrintMemberDetails()
        ' Retrieve data from the form controls
        Dim memberId As String = TextBox1.Text
        Dim memberName As String = TextBox2.Text
        Dim phoneNumber As String = TextBox3.Text
        Dim joinDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim membershipPlan As String = ComboBox1.SelectedItem?.ToString()
        Dim amount As String = TextBox4.Text

        ' Check if all necessary fields are filled
        If Not String.IsNullOrWhiteSpace(memberId) AndAlso
           Not String.IsNullOrWhiteSpace(memberName) AndAlso
           Not String.IsNullOrWhiteSpace(phoneNumber) AndAlso
           Not String.IsNullOrWhiteSpace(joinDate) AndAlso
           Not String.IsNullOrWhiteSpace(membershipPlan) AndAlso
           Not String.IsNullOrWhiteSpace(amount) Then

            ' Create a new PDF document
            Dim doc As New iTextSharp.text.Document()
            Dim directoryPath As String = "C:\PDF Generated"
            Dim fileName As String = $"MemberDetails_{memberId}.pdf"
            Dim filePath As String = Path.Combine(directoryPath, fileName)

            Try
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
                doc.Open()

                ' Add content to the PDF document
                Dim para As New Paragraph()
                para.Add("Member ID: " & memberId & vbCrLf)
                para.Add("Member Name: " & memberName & vbCrLf)
                para.Add("Phone Number: " & phoneNumber & vbCrLf)
                para.Add("Join Date: " & joinDate & vbCrLf)
                para.Add("Membership Plan: " & membershipPlan & vbCrLf)
                para.Add("Amount: " & amount & vbCrLf)
                para.Add("Payment Status: Paid" & vbCrLf)

                doc.Add(para)
            Catch ex As Exception
                MessageBox.Show("Error creating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                doc.Close()
            End Try

        Else
            MessageBox.Show("Please fill all member details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private form5Instance As Form5

    Private paymentDone As Boolean = False ' Variable to track payment status

    Private Shared _memberId1 As Integer ' Private shared field
    Public Shared Property MemberId1 As Integer ' Public shared property
        Get
            Return _memberId1
        End Get
        Set(value As Integer)
            _memberId1 = value
        End Set
    End Property

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Allow only numbers, backspace, and delete
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Delete) Then
            e.Handled = True
            MessageBox.Show("THIS FIELD ALLOWS ONLY NUMBERS  🔢")
        End If

        ' Check if the length of the TextBox is 6
        If TextBox1.Text.Replace(" ", "").Length = 6 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("MEMBER ID CONTAINS ONLY 6 DIGITS")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Call the method to update the member ID
            UpdateMemberID()
            ' Clear all fields

            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.SelectedIndex = -1
            TextBox4.Text = ""
            paymentDone = False ' Reset payment status
        Catch ex As Exception
            MessageBox.Show("Error generating member ID: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox3_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
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

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = ""
        Me.WindowState = FormWindowState.Maximized
        DateTimePicker1.Value = Date.Today
        DateTimePicker1.MinDate = Date.Today
        DateTimePicker1.MaxDate = Date.Today
        ComboBox1.SelectedIndex = -1
        ' Set ComboBox1 to non-editable
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

        ' Fetch the last member ID from the database and increment it by 1
        Try
            Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT MAX([MEMBER ID]) FROM [Member registration]"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Dim lastMemberID As Integer = Convert.ToInt32(result)
                        TextBox1.Text = (lastMemberID + 1).ToString("D6")
                    Else
                        TextBox1.Text = "111111"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching member ID: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("THIS FIELD ALLOWS ONLY LETTERS  🔠")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("PLEASE FILL IN ALL REQUIRED FIELD 😊!")
            Exit Sub
        End If

        ' Validate Phone Number
        If Not ValidatePhoneNumber(TextBox3.Text) Then
            MessageBox.Show("INVALID PHONE NUMBER ❌")
            Exit Sub
        End If

        ' Check if payment is done
        If Not paymentDone Then
            MessageBox.Show("PAYMENT NOT DONE YET! PLEASE COMPLETE THE PAYMENT FIRST 😊.")
            Exit Sub
        End If

        ' Connection string for your SQL Server
        Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if the Member ID already exists
                Dim idExistsQuery As String = "SELECT COUNT(*) FROM [Member registration] WHERE [MEMBER ID] = @MemberID"
                Using idExistsCommand As New SqlCommand(idExistsQuery, connection)
                    idExistsCommand.Parameters.AddWithValue("@MemberID", TextBox1.Text)
                    Dim idCount As Integer = Convert.ToInt32(idExistsCommand.ExecuteScalar())

                    If idCount > 0 Then
                        MessageBox.Show("MEMBER ID ALREADY EXISTS IN THE DATABASE. PLEASE CHOOSE A DIFFERENT ID.")

                        Exit Sub
                    End If
                End Using

                ' Check if the Phone Number already exists
                Dim phoneExistsQuery As String = "SELECT COUNT(*) FROM [Member registration] WHERE [MEMBER PHONE NO] = @MemberPhoneNo"
                Using phoneExistsCommand As New SqlCommand(phoneExistsQuery, connection)
                    phoneExistsCommand.Parameters.AddWithValue("@MemberPhoneNo", TextBox3.Text)
                    Dim phoneCount As Integer = Convert.ToInt32(phoneExistsCommand.ExecuteScalar())

                    If phoneCount > 0 Then
                        MessageBox.Show("PHONE NUMBER ALREADY EXISTS IN THE DATABASE. PLEASE ENTER A DIFFERENT PHONE NUMBER.")
                        Form6.Close()
                        Exit Sub
                    End If
                End Using

                ' SQL query to insert data into the database
                Dim query As String = "INSERT INTO [Member registration] ([MEMBER ID], [MEMBER NAME], [MEMBER PHONE NO], [MEMBERSHIP PLAN], [JOIN DATE],[amount]) VALUES (@MemberID, @MemberName, @MemberPhoneNo, @Membershipplan, @Joindate,@amount)"

                Using command As New SqlCommand(query, connection)
                    ' Replace @MemberID, @MemberName, @MemberPhoneNo, @Membershipplan, @Joindate with actual parameter names (e.g., TextBox1.Text)
                    command.Parameters.AddWithValue("@MemberID", TextBox1.Text)
                    command.Parameters.AddWithValue("@MemberName", TextBox2.Text)
                    command.Parameters.AddWithValue("@MemberPhoneNo", TextBox3.Text)
                    command.Parameters.AddWithValue("@Membershipplan", ComboBox1.Text)
                    command.Parameters.AddWithValue("@Joindate", DateTimePicker1.Value)
                    command.Parameters.AddWithValue("@amount", TextBox4.Text)
                    command.ExecuteNonQuery()
                    MemberId1 = TextBox1.Text ' Set the MemberId1 property
                    MessageBox.Show("DATA SAVED SUCCESSFULLY 😊.")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    'ComboBox1.SelectedIndex = -1
                    paymentDone = False ' Reset payment status
                    Form2.Show()
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub UpdateMemberID()
        Try
            Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Get the last Member ID from the database
                Dim query As String = "SELECT MAX([MEMBER ID]) FROM [Member registration]"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Dim lastMemberID As Integer = Convert.ToInt32(result)
                        ' Increment the last Member ID to get the new ID
                        Dim newMemberID As Integer = lastMemberID + 1

                        ' Update the Member ID in the database
                        Dim updateQuery As String = "UPDATE [Member registration] SET [MEMBER ID] = @NewMemberID WHERE [MEMBER ID] = @LastMemberID"
                        Using updateCommand As New SqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@NewMemberID", newMemberID)
                            updateCommand.Parameters.AddWithValue("@LastMemberID", lastMemberID)
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating Member ID: " & ex.Message)
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

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        ' Set e.Handled to True to ignore keyboard input
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Update TextBox4 based on the selected item in ComboBox1
        Select Case ComboBox1.SelectedItem.ToString().ToUpper().Trim()
            Case "SILVER"
                TextBox4.Text = "1500"
            Case "GOLD"
                TextBox4.Text = "3000"
            Case "PLATINUM"
                TextBox4.Text = "7500"
            Case Else
                TextBox4.Text = "" ' Clear TextBox4 if no valid option is selected
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.ReadOnly = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.ReadOnly = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("PLEASE FILL IN ALL REQUIRED FIELDS BEFORE PROCEEDING 😊! ")
            Exit Sub
        End If

        ' Check if TextBox3 contains exactly 10 digits
        If TextBox3.Text.Length <> 10 Then
            MessageBox.Show("Please enter a 10-digit phone number.")
            Exit Sub
        End If

        ' Check if the member phone number already exists in the database
        If MemberPhoneExists(TextBox3.Text) Then
            MessageBox.Show("The phone number already exists in the database. Please enter a different phone number.")
            Exit Sub
        End If

        ' Validate the phone number using the function
        If Not ValidatePhoneNumber(TextBox3.Text) Then
            Exit Sub
        End If

        ' Display payment successful message
        MessageBox.Show("PAYMENT SUCCESSFUL .PDF Generated Successfully😊.")

        ' Set payment status to true
        paymentDone = True

        ' Enable Button1 only if payment is done
        If paymentDone Then
            Button3.Enabled = False
            Button2.Enabled = False

        End If

        ' Now, you can fetch additional details from the Member details table
        Dim memberId As String = TextBox1.Text
        Dim memberName As String = TextBox2.Text
        Dim memberPhoneNo As String = TextBox3.Text
        Dim membershipPlan As String = ComboBox1.Text ' Use ComboBox1.Text directly
        Dim joinDate As Date = DateTimePicker1.Value ' Use DateTimePicker1.Value for join date
        Dim amount As String = TextBox4.Text ' Use TextBox4.Text for amount

        ' Optionally, you can perform further operations with these details

        ' Call the function to print member details
        PrintMemberDetails()

        ' Make textboxes and combobox non-editable
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        ComboBox1.Enabled = False
    End Sub

    Private Function MemberPhoneExists(phoneNumber As String) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim phoneExistsQuery As String = "SELECT COUNT(*) FROM [Member registration] WHERE [MEMBER PHONE NO] = @MemberPhoneNo"
                Using phoneExistsCommand As New SqlCommand(phoneExistsQuery, connection)
                    phoneExistsCommand.Parameters.AddWithValue("@MemberPhoneNo", phoneNumber)
                    Dim phoneCount As Integer = Convert.ToInt32(phoneExistsCommand.ExecuteScalar())

                    Return phoneCount > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking member phone number: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
