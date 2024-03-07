Imports System.IO.Ports

Public Class Tests
    Public Arduino As SerialPort
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Arduino.Close()
        Close()
    End Sub

    Private Sub btnFeeder_Click(sender As Object, e As EventArgs) Handles btnFeeder.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("R")
    End Sub

    Private Sub btnLeverLeft_Click(sender As Object, e As EventArgs) Handles btnLeverLeft.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("L")
    End Sub

    Private Sub btnPump_Click(sender As Object, e As EventArgs) Handles btnPump.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("W")
    End Sub

    Private Sub btnLeverRight_Click(sender As Object, e As EventArgs) Handles btnLeverRight.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("M")
    End Sub

    Private Sub btnPumpOn_Click(sender As Object, e As EventArgs) Handles btnPumpOn.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("P")
    End Sub

    Private Sub btnLights_Click(sender As Object, e As EventArgs) Handles btnLights.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("R")
    End Sub

    Private Sub btnPumpOff_Click(sender As Object, e As EventArgs) Handles btnPumpOff.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("p")
    End Sub

    Private Sub btnTone_Click(sender As Object, e As EventArgs) Handles btnTone.Click
        sender.backColor = Color.Green
        Arduino.WriteLine("Z")
    End Sub

    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        tmrStart.Enabled = False
        Arduino = New SerialPort(SetUp.txtCOM.Text, 9600)
        Arduino.Open()
        Arduino.WriteLine("p")
    End Sub
End Class