<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.update_booking = New System.Windows.Forms.Button()
        Me.delete_booking = New System.Windows.Forms.Button()
        Me.refresh_bookings = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1211, 484)
        Me.DataGridView1.TabIndex = 1
        '
        'update_booking
        '
        Me.update_booking.Location = New System.Drawing.Point(16, 69)
        Me.update_booking.Name = "update_booking"
        Me.update_booking.Size = New System.Drawing.Size(75, 23)
        Me.update_booking.TabIndex = 2
        Me.update_booking.Text = "Update"
        Me.update_booking.UseVisualStyleBackColor = True
        '
        'delete_booking
        '
        Me.delete_booking.Location = New System.Drawing.Point(116, 69)
        Me.delete_booking.Name = "delete_booking"
        Me.delete_booking.Size = New System.Drawing.Size(75, 23)
        Me.delete_booking.TabIndex = 3
        Me.delete_booking.Text = "Delete"
        Me.delete_booking.UseVisualStyleBackColor = True
        '
        'refresh_bookings
        '
        Me.refresh_bookings.Location = New System.Drawing.Point(213, 68)
        Me.refresh_bookings.Name = "refresh_bookings"
        Me.refresh_bookings.Size = New System.Drawing.Size(75, 23)
        Me.refresh_bookings.TabIndex = 4
        Me.refresh_bookings.Text = "Refresh"
        Me.refresh_bookings.UseVisualStyleBackColor = True
        '
        'bookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 613)
        Me.Controls.Add(Me.refresh_bookings)
        Me.Controls.Add(Me.delete_booking)
        Me.Controls.Add(Me.update_booking)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bookings"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents update_booking As Button
    Friend WithEvents delete_booking As Button
    Friend WithEvents refresh_bookings As Button
End Class
