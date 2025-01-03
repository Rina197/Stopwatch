﻿Public Class Form1
    Private stopwatch As New Diagnostics.Stopwatch
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Button3.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        CircularProgressBar1.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                                    Math.Floor(elapsed.TotalHours),
                                                    elapsed.Minutes, elapsed.Seconds)
        Label1.Text = elapsed.Milliseconds
        CircularProgressBar1.Value = elapsed.Seconds
        If elapsed.Seconds = 0 Then
            CircularProgressBar1.Value = 60
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            Timer1.Start()
            stopwatch.Start()
            Button3.Enabled = False
            Button1.Text = "Stop"
        Else
            Timer1.Stop()
            stopwatch.Stop()
            Button3.Enabled = True
            Button1.Text = "Start"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add(ListBox1.Items.Count + 1 & "." & CircularProgressBar1.Text & ":" & Label1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        stopwatch.Reset()
        CircularProgressBar1.Text = "00:00:00"
        Label1.Text = "000"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        stopwatch.Reset()
        ListBox1.Items.Clear()
        CircularProgressBar1.Text = "00:00:00"
        Label1.Text = "000"

    End Sub
End Class
