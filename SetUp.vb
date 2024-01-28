Public Class SetUp
    Public LabelPreview(35) As Label

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        'This checks for errors or missing data in the set up and prompts the user for corrections. If no problem is found the selected programs are initiated.
        If txtSubject.Text = "" Or txtSession.Text = "" Or txtCOM.Text = "" Then
            MessageBox.Show("Some session data is missing.")
        Else

            vFile = "C:\Data\Raw\" & txtSubject.Text & "_" & txtSession.Text & "_Raw.txt"
            vFile2 = "C:\Data\Summary\" & txtSubject.Text & "_" & txtSession.Text & "Summary.txt"
            FileOpen(1, vFile, OpenMode.Append)
            FileOpen(2, vFile2, OpenMode.Append)
            WriteLine(1, Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
            WriteLine(1, "Subject: " & txtSubject.Text)
            WriteLine(1, "Session: " & txtSession.Text)
            WriteLine(1, "COM Port: " & txtCOM.Text)
            WriteLine(2, Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
            WriteLine(2, "Subject: " & txtSubject.Text)
            WriteLine(2, "Session: " & txtSession.Text)
            WriteLine(2, "COM Port: " & txtCOM.Text)
            WriteLine(1, "Lever 1 response: 1")
            WriteLine(1, "Lever 2 response: 2")
            WriteLine(1, "Tray response: 3")
            WriteLine(1, "Lever 1 reinforcer: 11")
            WriteLine(1, "Lever 2 reinforcer: 12")
            WriteLine(1, "Lever 1 r on Delay: 21")
            WriteLine(1, "Lever 2 r on Delay: 22")
            WriteLine(1, "Tray r on Delay: 23")
            Dim x As New Main
            Me.WindowState = FormWindowState.Minimized
            x.Show()
            x.ArduinoVB()

        End If
    End Sub

    Private Sub btnAddComponent_Click(sender As Object, e As EventArgs) Handles btnAddComponent.Click
        Dim f As New Component
        vCC += 1
        f.Text = "Component " & vCC
        f.ShowDialog()
    End Sub


End Class
