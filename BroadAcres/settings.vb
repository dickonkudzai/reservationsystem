Imports MySql.Data.MySqlClient
Public Class settings
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        loadCountries()
        loadAccommodationTypes()
        loadPaymentOptions()
        loadMealTypes()
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

    Public Sub loadCountries()
        Try
            Dim Str As String = "SELECT * FROM countries"
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
    Public Sub loadAccommodationTypes()
        Try
            Dim Str As String = "SELECT * FROM accommodation_types"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub loadPaymentOptions()
        Try
            Dim Str As String = "SELECT * FROM payment_options"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView3.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub loadMealTypes()
        Try
            Dim Str As String = "SELECT * FROM meal_types"
            conn.Open()
            Dim da As New MySqlDataAdapter(Str, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView4.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim home_page As New home()
        Me.Hide()
        home_page.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim DatabaseName As String = "broadacres"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=" & server & ";user id =" & userName & ";" & "password=" & password & ";database=" & DatabaseName & ""
        Try
            conn.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub country_save_Click(sender As Object, e As EventArgs) Handles country_save.Click
        Dim result As Integer
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `countries` (`country_name`) VALUES ('" & country_name_txt.Text & "');"
                result = .ExecuteNonQuery()
                If result > 0 Then
                    MsgBox("Country Added Successfully")
                Else
                    MsgBox("Country Couldn't be added")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub accommodation_type_save_Click(sender As Object, e As EventArgs) Handles accommodation_type_save.Click
        Dim result As Integer
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `accommodation_types` (`accommodation_type`) VALUES ('" & accommodation_type_txt.Text & "');"
                result = .ExecuteNonQuery()
                If result > 0 Then
                    MsgBox("Accommodation Type Added Successfully")
                Else
                    MsgBox("Accommodation Type Couldn't be added")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub payment_option_save_Click(sender As Object, e As EventArgs) Handles payment_option_save.Click
        Dim result As Integer
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `payment_options` (`payment_option_option`) VALUES ('" & payment_option_txt.Text & "');"
                result = .ExecuteNonQuery()
                If result > 0 Then
                    MsgBox("Payment Option Added Successfully")
                Else
                    MsgBox("Payment Option Couldn't be added")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub meal_type_save_Click(sender As Object, e As EventArgs) Handles meal_type_save.Click
        Dim result As Integer
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `meal_types` (`meal_type`) VALUES ('" & meal_type_type_txt.Text & "');"
                result = .ExecuteNonQuery()
                If result > 0 Then
                    MsgBox("Meal Type Added Successfully")
                Else
                    MsgBox("Meal Type Couldn't be added")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub refresh_tables_Click(sender As Object, e As EventArgs) Handles refresh_tables.Click
        loadCountries()
        loadAccommodationTypes()
        loadPaymentOptions()
        loadMealTypes()
    End Sub
End Class