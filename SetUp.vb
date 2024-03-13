Public Class SetUp
    Public LabelPreview(50) As Label

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Dim ask As MsgBoxResult = MsgBox("Did you test everything?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then



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
                WriteLine(1, "Lever 1 reinforcer: R1")
                WriteLine(1, "Lever 2 reinforcer: R2")
                WriteLine(1, "Lever 1 r on Delay: D1")
                WriteLine(1, "Lever 2 r on Delay: D2")
                WriteLine(1, "Tray r on Delay: D3")
                MAXvCC = vCC
                vCC = 1
                For i = 1 To MAXvCC
                    AC(i).IterationsLeft = AC(i).ComponentIteration
                Next


                Dim x As New Main
                Me.WindowState = FormWindowState.Minimized
                x.Show()
                x.ArduinoVB()

            End If
        End If
    End Sub

    Private Sub btnAddComponent_Click(sender As Object, e As EventArgs) Handles btnAddComponent.Click
        Dim f As New Component
        vCC += 1
        f.Text = "Component " & vCC
        f.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then RandomCPres = True
        If CheckBox1.Checked = False Then RandomCPres = False
    End Sub

    Private Sub btnTests_Click(sender As Object, e As EventArgs) Handles btnTests.Click
        Dim f As New Tests
        f.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        vFile3 = "C:\SavedPrograms\NewProgram(Rename me please).txt"
        FileOpen(3, vFile3, OpenMode.Append)
        WriteLine(3, Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
        WriteLine(3, txbStart.Text)
        WriteLine(3, txbPostSession.Text)
        WriteLine(3, txbICI.Text)
        WriteLine(3, CheckBox1.Checked)
        For i = 1 To MAXvCC
            WriteLine(3, AC(i).HouselightOnOff)
            WriteLine(3, AC(i).COD)
            WriteLine(3, AC(i).MaxRefs)
            WriteLine(3, AC(i).ComponentDuration)
            WriteLine(3, AC(i).ComponentIteration)
            WriteLine(3, AC(i).ComponentStimDuration)
            WriteLine(3, AC(i).ComponentStimType)
            WriteLine(3, AC(i).ScheduleType(0))
            WriteLine(3, AC(i).ScheduleType(1))
            WriteLine(3, AC(i).ScheduleValue(0))
            WriteLine(3, AC(i).ScheduleValue(1))
            WriteLine(3, AC(i).Magnitude(0))
            WriteLine(3, AC(i).Magnitude(1))
            WriteLine(3, AC(i).Reinforcer(0))
            WriteLine(3, AC(i).Reinforcer(1))
            WriteLine(3, AC(i).PelletP(0))
            WriteLine(3, AC(i).PelletP(1))
            WriteLine(3, AC(i).FeedbackDuration(0))
            WriteLine(3, AC(i).FeedbackDuration(1))
            WriteLine(3, AC(i).FeedbackType(0))
            WriteLine(3, AC(i).FeedbackType(1))
            WriteLine(3, AC(i).DelayDuration(0))
            WriteLine(3, AC(i).DelayDuration(1))
            WriteLine(3, AC(i).DelayType(0))
            WriteLine(3, AC(i).DelayType(1))
        Next
    End Sub
End Class
