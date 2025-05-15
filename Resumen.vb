Imports System.Math
Public Class Resumen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Resumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += ResponseCount(1, 0)
        Label2.Text += ResponseCount(1, 1)
        'Label3.Text += ResponseCount(1, 2)
        'Label4.Text += ResponseCount(1, 3)
        Label5.Text += RefCount(1, 0)
        Label6.Text += RefCount(1, 1)
        Label7.Text += Round(vTimeNow / 1000)

    End Sub
End Class