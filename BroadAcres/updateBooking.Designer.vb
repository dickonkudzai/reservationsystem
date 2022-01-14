<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateBooking
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.payment_option = New System.Windows.Forms.ComboBox()
        Me.transport = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.meal_type = New System.Windows.Forms.ComboBox()
        Me.food = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.accommodation_type = New System.Windows.Forms.ComboBox()
        Me.accommodation = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_of_trip = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.customer_country = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.customer_town = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.customer_address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customer_phone_number = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customer_name = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.payment_option)
        Me.GroupBox2.Controls.Add(Me.transport)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.meal_type)
        Me.GroupBox2.Controls.Add(Me.food)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.accommodation_type)
        Me.GroupBox2.Controls.Add(Me.accommodation)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.date_of_trip)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(962, 182)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(681, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Payment Option"
        '
        'payment_option
        '
        Me.payment_option.FormattingEnabled = True
        Me.payment_option.Location = New System.Drawing.Point(681, 120)
        Me.payment_option.Name = "payment_option"
        Me.payment_option.Size = New System.Drawing.Size(261, 21)
        Me.payment_option.TabIndex = 9
        '
        'transport
        '
        Me.transport.AutoSize = True
        Me.transport.Location = New System.Drawing.Point(368, 120)
        Me.transport.Name = "transport"
        Me.transport.Size = New System.Drawing.Size(71, 17)
        Me.transport.TabIndex = 8
        Me.transport.Text = "Transport"
        Me.transport.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(116, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Meal Type"
        '
        'meal_type
        '
        Me.meal_type.FormattingEnabled = True
        Me.meal_type.Location = New System.Drawing.Point(116, 116)
        Me.meal_type.Name = "meal_type"
        Me.meal_type.Size = New System.Drawing.Size(121, 21)
        Me.meal_type.TabIndex = 6
        '
        'food
        '
        Me.food.AutoSize = True
        Me.food.Location = New System.Drawing.Point(37, 120)
        Me.food.Name = "food"
        Me.food.Size = New System.Drawing.Size(50, 17)
        Me.food.TabIndex = 5
        Me.food.Text = "Food"
        Me.food.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(684, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Accommodation Type"
        '
        'accommodation_type
        '
        Me.accommodation_type.FormattingEnabled = True
        Me.accommodation_type.Location = New System.Drawing.Point(681, 65)
        Me.accommodation_type.Name = "accommodation_type"
        Me.accommodation_type.Size = New System.Drawing.Size(261, 21)
        Me.accommodation_type.TabIndex = 3
        '
        'accommodation
        '
        Me.accommodation.AutoSize = True
        Me.accommodation.Location = New System.Drawing.Point(368, 67)
        Me.accommodation.Name = "accommodation"
        Me.accommodation.Size = New System.Drawing.Size(102, 17)
        Me.accommodation.TabIndex = 2
        Me.accommodation.Text = "Accommodation"
        Me.accommodation.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Date of the Trip"
        '
        'date_of_trip
        '
        Me.date_of_trip.Location = New System.Drawing.Point(37, 65)
        Me.date_of_trip.Name = "date_of_trip"
        Me.date_of_trip.Size = New System.Drawing.Size(200, 20)
        Me.date_of_trip.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.customer_country)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.customer_town)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.customer_address)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.customer_phone_number)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.customer_name)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(962, 194)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Country"
        '
        'customer_country
        '
        Me.customer_country.FormattingEnabled = True
        Me.customer_country.Location = New System.Drawing.Point(368, 128)
        Me.customer_country.Name = "customer_country"
        Me.customer_country.Size = New System.Drawing.Size(216, 21)
        Me.customer_country.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Town/City"
        '
        'customer_town
        '
        Me.customer_town.Location = New System.Drawing.Point(34, 129)
        Me.customer_town.Name = "customer_town"
        Me.customer_town.Size = New System.Drawing.Size(236, 20)
        Me.customer_town.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(681, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Address"
        '
        'customer_address
        '
        Me.customer_address.Location = New System.Drawing.Point(681, 62)
        Me.customer_address.Multiline = True
        Me.customer_address.Name = "customer_address"
        Me.customer_address.Size = New System.Drawing.Size(261, 88)
        Me.customer_address.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone Number"
        '
        'customer_phone_number
        '
        Me.customer_phone_number.Location = New System.Drawing.Point(368, 62)
        Me.customer_phone_number.Name = "customer_phone_number"
        Me.customer_phone_number.Size = New System.Drawing.Size(216, 20)
        Me.customer_phone_number.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'customer_name
        '
        Me.customer_name.Location = New System.Drawing.Point(31, 63)
        Me.customer_name.Name = "customer_name"
        Me.customer_name.Size = New System.Drawing.Size(239, 20)
        Me.customer_name.TabIndex = 2
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(833, 481)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(140, 23)
        Me.save.TabIndex = 7
        Me.save.Text = "Save Booking"
        Me.save.UseVisualStyleBackColor = True
        '
        'updateBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 613)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "updateBooking"
        Me.Text = "updateBooking"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents payment_option As ComboBox
    Friend WithEvents transport As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents meal_type As ComboBox
    Friend WithEvents food As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents accommodation_type As ComboBox
    Friend WithEvents accommodation As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents date_of_trip As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents customer_country As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents customer_town As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents customer_address As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents customer_phone_number As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents customer_name As TextBox
    Friend WithEvents save As Button
End Class
