Imports MySql.Data.MySqlClient
Public Class updateBooking
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim bookingID As Integer

    Private Sub updateBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
    End Sub

    Public Sub ConnectDatabase()
        Dim DatabaseName As String = "broadacres"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=" & server & ";user id =" & userName & ";" & "password=" & password & ";database=" & DatabaseName & ""
        Try
            conn.Open()
            'MsgBox("Connected")
            Console.Write("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub accommodation_CheckedChanged(sender As Object, e As EventArgs) Handles accommodation.CheckedChanged
        If accommodation.Checked Then
            accommodation_type.Enabled = True
        Else
            accommodation_type.Enabled = False
        End If
    End Sub

    Private Sub food_CheckedChanged(sender As Object, e As EventArgs) Handles food.CheckedChanged
        If food.Checked Then
            meal_type.Enabled = True
        Else
            meal_type.Enabled = False
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim result As Integer
        Dim accommodation As Integer
        Dim food As Integer
        Dim transport As Integer

        If Me.accommodation.Checked Then
            accommodation = 1
        Else
            accommodation = 0
        End If

        If Me.food.Checked Then
            food = 1
        Else
            food = 0
        End If

        If Me.transport.Checked Then
            transport = 1
        Else
            transport = 0
        End If
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = "UPDATE `bookings` SET `customer_name` = '" & customer_name.Text & "', `customer_phone_number` = '" & customer_phone_number.Text & "', `customer_address` = '" & customer_address.Text & "', `customer_town` = '" & customer_town.Text & "', `customer_country` = '" & customer_country.SelectedValue & "', `date_of_trip` = '" & date_of_trip.Value & "', `accommodation` = '" & accommodation & "', `accommodation_type` = '" & accommodation_type.SelectedValue & "', `food` = '" & food & "', `meal_type` = '" & meal_type.SelectedValue & "', `transport` = '" & transport & "', `payment_option` = '" & payment_option.SelectedValue & "' WHERE id = " & Me.Text
                result = .ExecuteNonQuery()
                If result > 0 Then
                    Me.Close()
                    bookings.Refresh()
                    MsgBox("Booking Updated Successfully")
                Else
                    MsgBox("Booking Couldn't be updated")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class