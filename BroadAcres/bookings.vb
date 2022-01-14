Imports MySql.Data.MySqlClient
Public Class bookings
    Dim conn As New MySqlConnection

    Private Sub bookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        loadBookings()
        getCountries()
        getAccomodationTypes()
        getPaymentOptions()
        getMealTypes()

        If updateBooking.accommodation.Checked Then
            updateBooking.accommodation_type.Enabled = True
        Else
            updateBooking.accommodation_type.Enabled = False
        End If

        If updateBooking.food.Checked Then
            updateBooking.meal_type.Enabled = True
        Else
            updateBooking.meal_type.Enabled = False
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
                updateBooking.customer_country.DataSource = dt
                updateBooking.customer_country.DisplayMember = "country_name"
                updateBooking.customer_country.ValueMember = "country_id"
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
                updateBooking.accommodation_type.DataSource = dt
                updateBooking.accommodation_type.DisplayMember = "accommodation_type"
                updateBooking.accommodation_type.ValueMember = "accommodation_id"
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
                updateBooking.payment_option.DataSource = dt
                updateBooking.payment_option.DisplayMember = "payment_option_option"
                updateBooking.payment_option.ValueMember = "payment_option_id"
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
                updateBooking.meal_type.DataSource = dt
                updateBooking.meal_type.DisplayMember = "meal_type"
                updateBooking.meal_type.ValueMember = "meal_id"
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub loadBookings()
        Try
            Dim Str As String = "SELECT * FROM bookings"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bookings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim home_page As New home()
        Me.Hide()
        home_page.Show()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update_booking.Click
        With updateBooking
            .Text = DataGridView1.CurrentRow.Cells(0).Value
            .customer_name.Text = DataGridView1.CurrentRow.Cells(1).Value
            .customer_phone_number.Text = DataGridView1.CurrentRow.Cells(2).Value
            .customer_address.Text = DataGridView1.CurrentRow.Cells(3).Value
            .customer_town.Text = DataGridView1.CurrentRow.Cells(4).Value
            .customer_country.SelectedValue = DataGridView1.CurrentRow.Cells(5).Value
            .date_of_trip.Value = DataGridView1.CurrentRow.Cells(6).Value
            .accommodation.Checked = DataGridView1.CurrentRow.Cells(7).Value
            .accommodation_type.SelectedValue = DataGridView1.CurrentRow.Cells(8).Value
            .food.Checked = DataGridView1.CurrentRow.Cells(9).Value
            .meal_type.SelectedValue = DataGridView1.CurrentRow.Cells(10).Value
            .transport.Checked = DataGridView1.CurrentRow.Cells(11).Value
            .payment_option.SelectedValue = DataGridView1.CurrentRow.Cells(12).Value
            .Show()
        End With
        'Me.Hide()
    End Sub

    Private Sub refresh_bookings_Click(sender As Object, e As EventArgs) Handles refresh_bookings.Click
        loadBookings()
    End Sub

    Private Sub delete_booking_Click(sender As Object, e As EventArgs) Handles delete_booking.Click
        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim dgresult As New DialogResult
        dgresult = MessageBox.Show("Are you sure you want to perform this action?", "Please Select action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgresult = System.Windows.Forms.DialogResult.Yes Then
            With cmd
                conn.Open()

                .Connection = conn
                .CommandText = "DELETE FROM bookings WHERE id = " & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
                result = .ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Record has been deleted successfully!")
                Else
                    MsgBox("No Record has been deleted successfully!")
                End If
                Me.Close()
            End With
        End If
    End Sub
End Class