Imports MySql.Data.MySqlClient
Public Class home
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        getCountries()
        getAccomodationTypes()
        getPaymentOptions()
        getMealTypes()

        If accommodation.Checked Then
            accommodation_type.Enabled = True
        Else
            accommodation_type.Enabled = False
        End If

        If food.Checked Then
            meal_type.Enabled = True
        Else
            meal_type.Enabled = False
        End If
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

    Public Sub getCountries()
        Try
            Dim Str As String = "SELECT * FROM countries"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As New DataTable("countries")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                customer_country.DataSource = dt
                customer_country.DisplayMember = "country_name"
                customer_country.ValueMember = "country_id"
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getAccomodationTypes()
        Try
            Dim Str As String = "SELECT * FROM accommodation_types"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As New DataTable("accommodation_types")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                accommodation_type.DataSource = dt
                accommodation_type.DisplayMember = "accommodation_type"
                accommodation_type.ValueMember = "accommodation_id"
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getPaymentOptions()
        Try
            Dim Str As String = "SELECT * FROM payment_options"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As New DataTable("payment_options")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                payment_option.DataSource = dt
                payment_option.DisplayMember = "payment_option_option"
                payment_option.ValueMember = "payment_option_id"
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub getMealTypes()
        Try
            Dim Str As String = "SELECT * FROM meal_types"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As New DataTable("meal_types")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                meal_type.DataSource = dt
                meal_type.DisplayMember = "meal_type"
                meal_type.ValueMember = "meal_id"
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub clearForm()
        customer_name.Text = ""
        customer_phone_number.Text = ""
        customer_address.Text = ""
        customer_town.Text = ""
        accommodation.Enabled = False
        food.Enabled = False
        transport.Enabled = False
    End Sub

    Private Sub bookings_button_Click(sender As Object, e As EventArgs) Handles bookings_button.Click
        Dim bookings_page As New bookings()
        Me.Hide()
        bookings_page.Show()
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        Dim settings_page As New settings()
        Me.Hide()
        settings_page.Show()
    End Sub

    Private Sub home_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
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

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        clearForm()
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
                .CommandText = "INSERT INTO `bookings` (`customer_name`, `customer_phone_number`, `customer_address`, `customer_town`, `customer_country`, `date_of_trip`, `accommodation`, `accommodation_type`, `food`, `meal_type`, `transport`, `payment_option`) VALUES ('" & customer_name.Text & "', '" & customer_phone_number.Text & "', '" & customer_address.Text & "', '" & customer_town.Text & "', '" & customer_country.SelectedValue & "', '" & date_of_trip.Value & "', '" & accommodation & "', '" & accommodation_type.SelectedValue & "', '" & food & "', '" & meal_type.SelectedValue & "', '" & transport & "', '" & payment_option.SelectedValue & "');"
                result = .ExecuteNonQuery()
                If result > 0 Then
                    clearForm()
                    MsgBox("Booking Added Successfully")
                Else
                    MsgBox("Booking Couldn't be added")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
End Class
