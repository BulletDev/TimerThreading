Imports System.Threading

Public Class ThreadingTimer

    Dim ms As Thread
    Dim sec As Thread
    Dim min As Thread
    Dim hr As Thread

    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub btnStartTimer_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        If btnStartTimer.Text = "Start" Then
            ms = New Thread(AddressOf StartMilliseconds)
            ms.Start()
            sec = New Thread(AddressOf StartSeconds)
            sec.Start()
            min = New Thread(AddressOf StartMinutes)
            min.Start()
            hr = New Thread(AddressOf StartHours)
            hr.Start()
            btnStartTimer.Text = "Stop"
        ElseIf btnStartTimer.Text = "Stop" Then
            ms.Abort()
            sec.Abort()
            min.Abort()
            hr.Abort()
            btnStartTimer.Text = "Start New"
        Else
            btnStartTimer.Text = "Start"
            lblSeconds.Text = "00"
            lblMinutes.Text = "00"
            lblHours.Text = "00"
        End If
    End Sub
    Private Sub StartMilliseconds()
        For ms As Integer = 1 To 1000
            Thread.Sleep(1)
            lblMilliseconds.Text = ms.ToString()
            If ms = 1000 Then
                ms = 0
            End If
        Next
    End Sub
    Private Sub StartSeconds()
        For s As Integer = 1 To 60
            Thread.Sleep(1000)
            lblSeconds.Text = s.ToString()
            If s = 60 Then
                s = 0
            End If
        Next
    End Sub
    Private Sub StartMinutes()
        For m As Integer = 1 To 60
            Thread.Sleep(60000)
            lblMinutes.Text = m.ToString()
            If m = 60 Then
                m = 0
            End If
        Next
    End Sub
    Private Sub StartHours()
        For h As Integer = 1 To 12
            Thread.Sleep(3600000)
            lblHours.Text = h.ToString()
            If h = 12 Then
                h = 0
            End If
        Next
    End Sub

    Private Sub Timer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ms.Abort()
        sec.Abort()
        min.Abort()
        hr.Abort()
    End Sub

End Class
