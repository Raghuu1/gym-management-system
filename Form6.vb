Imports System.Data.SqlClient

Public Class Form6
    Dim connectionString As String = "Data Source=LAPTOP-LLE7RUDV\SQLEXPRESS;Initial Catalog=gym db;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if the member ID already exists in the RECEIPT table
                Dim checkQuery As String = "SELECT COUNT(*) FROM [RECEIPT] WHERE [MEMBER ID] = @MemberID"
                Using checkCommand As New SqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@MemberID", TextBox2.Text)
                    Dim memberCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                End Using

                ' Fetch the last receipt ID from the database
                FetchLastReceiptID()

                ' Insert the details into the database
                Dim insertQuery As String = "INSERT INTO [RECEIPT] ([RECEIPT ID], [MEMBER ID], [MEMBER NAME], [MEMBER PHONE NO], [JOIN DATE], [MEMBERSHIP PLAN], [AMOUNT]) VALUES (@ReceiptID, @MemberID, @MemberName, @MemberPhoneNo, @JoinDate, @MembershipPlan, @Amount)"
                Using insertCommand As New SqlCommand(insertQuery, connection)
                    ' Add parameters to the insert command
                    insertCommand.Parameters.AddWithValue("@ReceiptID", TextBox1.Text)
                    insertCommand.Parameters.AddWithValue("@MemberID", TextBox2.Text)
                    insertCommand.Parameters.AddWithValue("@MemberName", TextBox3.Text)
                    insertCommand.Parameters.AddWithValue("@MemberPhoneNo", TextBox4.Text)
                    insertCommand.Parameters.AddWithValue("@JoinDate", DateTimePicker1.Value)
                    insertCommand.Parameters.AddWithValue("@MembershipPlan", TextBox5.Text)
                    insertCommand.Parameters.AddWithValue("@Amount", TextBox6.Text)

                    ' Execute the insert command
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("DETAILS SAVED SUCCESSFULLY")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving details to the database: " & ex.Message)
        End Try
    End Sub

    Private Sub FetchLastReceiptID()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Fetch the last receipt ID from the database
                Dim query As String = "SELECT MAX([RECEIPT ID]) FROM [RECEIPT]"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()

                    ' Check if the result is DBNull or Nothing
                    Dim receiptId As Integer
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        receiptId = Convert.ToInt32(result)
                        receiptId = If(receiptId >= 123456, receiptId + 1, 123456) ' Start from 123456 if no receipts exist or if the last receipt ID is less than 123456
                    Else
                        receiptId = 123456 ' Start from 123456 if no receipts exist
                    End If

                    TextBox1.Text = receiptId.ToString("D6") ' Display receipt ID with 6 digits
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching or generating receipt ID: " & ex.Message)
        End Try
    End Sub

    Public Sub FillDetails(memberId As Integer, memberName As String, memberPhoneNo As String, membershipPlan As String, joinDate As Date, amount As String)
        ' Fetch the last receipt ID from the database
        FetchLastReceiptID()

        TextBox2.Text = memberId.ToString() ' Display member ID
        TextBox3.Text = memberName
        TextBox4.Text = memberPhoneNo
        TextBox5.Text = membershipPlan
        TextBox6.Text = amount ' Display amount
        DateTimePicker1.Value = joinDate

        ' You can add more details as needed
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        DateTimePicker1.Value = Date.Today
        DateTimePicker1.MinDate = Date.Today
        DateTimePicker1.MaxDate = Date.Today
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Close()
    End Sub
End Class
