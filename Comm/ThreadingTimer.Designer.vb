<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThreadingTimer
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
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.btnStartTimer = New System.Windows.Forms.Button()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMilliseconds = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSeconds
        '
        Me.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(232, 12)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(48, 33)
        Me.lblSeconds.TabIndex = 2
        Me.lblSeconds.Text = "00"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnStartTimer
        '
        Me.btnStartTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartTimer.Location = New System.Drawing.Point(12, 12)
        Me.btnStartTimer.Name = "btnStartTimer"
        Me.btnStartTimer.Size = New System.Drawing.Size(99, 33)
        Me.btnStartTimer.TabIndex = 4
        Me.btnStartTimer.Text = "Start"
        Me.btnStartTimer.UseVisualStyleBackColor = True
        '
        'lblMinutes
        '
        Me.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(313, 12)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(48, 33)
        Me.lblMinutes.TabIndex = 5
        Me.lblMinutes.Text = "00"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHours
        '
        Me.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(394, 11)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(48, 33)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "00"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(365, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = ":"
        '
        'lblMilliseconds
        '
        Me.lblMilliseconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMilliseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilliseconds.Location = New System.Drawing.Point(133, 12)
        Me.lblMilliseconds.Name = "lblMilliseconds"
        Me.lblMilliseconds.Size = New System.Drawing.Size(64, 33)
        Me.lblMilliseconds.TabIndex = 9
        Me.lblMilliseconds.Text = "000"
        Me.lblMilliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ThreadingTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 60)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMilliseconds)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.btnStartTimer)
        Me.Controls.Add(Me.lblSeconds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ThreadingTimer"
        Me.ShowIcon = False
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeconds As Label
    Friend WithEvents btnStartTimer As Button
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMilliseconds As Label
End Class
