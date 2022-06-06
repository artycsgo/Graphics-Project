Public Class Form1
    'Martin Bassett
    'Period 7, 5/23/2022
    'Simulates sun rising and setting, and moon rising and setting

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        Me.CreateGraphics.FillRectangle(Brushes.Green, 0, Me.Height - 150, Me.Width, 150) 'draws the grass
        Static count As Double = 0 'counter to show the value of the timer
        count += 1
        Static time As Double 'counter to show the time
        If count <= 24 Then
            time = count
        Else
            time = count Mod 2
        End If
        txtTime.Text = time & ":00" 'outputs the time
        Select Case time 'For the sun during daytime
            Case 6 Or 7
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Blue, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillEllipse(Brushes.Orange, 50, Me.Height - 200, 50, 50) 'draws the sun
                Me.CreateGraphics.DrawEllipse(Pens.Black, 50, Me.Height - 200, 50, 50) 'draws the outline of the sun
            Case 8 Or 9
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Blue, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillEllipse(Brushes.Orange, CInt(Me.Width / 5) - 25, Me.Height - 275, 50, 50) 'draws the sun
                Me.CreateGraphics.DrawEllipse(Pens.Black, CInt(Me.Width / 5) - 25, Me.Height - 275, 50, 50) 'draws the outline of the sun
            Case 10 Or 11
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Blue, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillEllipse(Brushes.Orange, 2 * CInt((Me.Width) / 5) - 25, 50, 50, 50) 'draws the sun
                Me.CreateGraphics.DrawEllipse(Pens.Black, 2 * CInt((Me.Width) / 5) - 25, 50, 50, 50) 'draws the outline of the sun
            Case 12 Or 13
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Blue, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillEllipse(Brushes.Orange, 3 * CInt((Me.Width) / 5) - 25, 50, 50, 50) 'draws the sun
                Me.CreateGraphics.DrawEllipse(Pens.Black, 3 * CInt((Me.Width) / 5) - 25, 50, 50, 50) 'draws the outline of the sun
            Case 14 Or 15
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Blue, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillEllipse(Brushes.Orange, 4 * CInt((Me.Width / 5) - 25), Me.Height - 275, 50, 50) 'draws the sun
                Me.CreateGraphics.DrawEllipse(Pens.Black, 4 * CInt((Me.Width / 5) - 25), Me.Height - 275, 50, 50) 'draws the outline of the sun
            Case 16 Or 17
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Blue, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillEllipse(Brushes.Orange, Me.Width - 50, Me.Height - 200, 50, 50) 'draws the sun
                Me.CreateGraphics.DrawEllipse(Pens.Black, Me.Width - 50, Me.Height - 200, 50, 50) 'draws the outline of the sun
        End Select

        Select Case time 'For the moon during nighttime
            Case 18 Or 19
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Black, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillPie(Brushes.Yellow, 50, Me.Height - 200, 50, 50, 90, 180) 'draws the moon
                Me.CreateGraphics.DrawPie(Pens.Black, 50, Me.Height - 200, 50, 50, 90, 180) 'draws the outline of the moon
            Case 20 Or 21
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Black, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillPie(Brushes.Yellow, CInt(Me.Width / 5) - 25, Me.Height - 275, 50, 50, 90, 180) 'draws the moon
                Me.CreateGraphics.DrawPie(Pens.Black, CInt(Me.Width / 5) - 25, Me.Height - 275, 50, 50, 90, 180) 'draws the outline of the moon
            Case 22 Or 23
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Black, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillPie(Brushes.Yellow, 2 * CInt((Me.Width) / 5) - 25, 50, 50, 50, 90, 180) 'draws the moon
                Me.CreateGraphics.DrawPie(Pens.Black, 2 * CInt((Me.Width) / 5) - 25, 50, 50, 50, 90, 180) 'draws the outline of the moon
            Case 24 Or 1
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Black, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillPie(Brushes.Yellow, 3 * CInt((Me.Width) / 5) - 25, 50, 50, 50, 90, 180) 'draws the moon
                Me.CreateGraphics.DrawPie(Pens.Black, 3 * CInt((Me.Width) / 5) - 25, 50, 50, 50, 90, 180) 'draws the outline of the moon
            Case 2 Or 3
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Black, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillPie(Brushes.Yellow, 4 * CInt((Me.Width) / 5) - 25, Me.Height - 275, 50, 50, 90, 180) 'draws the moon
                Me.CreateGraphics.DrawPie(Pens.Black, 4 * CInt((Me.Width) / 5) - 25, 50, Me.Height - 275, 50, 90, 180) 'draws the outline of the moon
            Case 4 Or 5
                Me.Refresh() 'clears the form
                Me.CreateGraphics.FillRectangle(Brushes.Black, 0, 0, Me.Width, Me.Height - 150) 'draws the sky
                Me.CreateGraphics.FillPie(Brushes.Yellow, Me.Width - 50, Me.Height - 200, 50, 50, 90, 180) 'draws the moon
                Me.CreateGraphics.DrawPie(Pens.Black, Me.Width - 50, Me.Height - 200, 50, 50, 90, 180) 'draws the outline of the moon
        End Select
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrTimer.Enabled = True 'enables the timer
        lblTime.Visible = True 'makes the label visible
        txtTime.Visible = True 'makes the textbox visible
        Me.CreateGraphics.FillRectangle(Brushes.Green, 0, Me.Height - 150, Me.Width, 150) 'draws the grass
    End Sub
End Class



