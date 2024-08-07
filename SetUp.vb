﻿Public Class SetUp
    Public LabelPreview(60) As Label

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Dim ask As MsgBoxResult = MsgBox("Did you test everything?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then



            'This checks for errors or missing data in the set up and prompts the user for corrections. If no problem is found the selected programs are initiated.
            If txtSubject.Text = "" Or txtSession.Text = "" Or txtCOM.Text = "" Then
                MessageBox.Show("Some session data is missing.")
            Else

                vFile(0) = "C:\Data\Raw\" & txtSubject.Text & "_" & txtSession.Text & "_Raw.txt"
                vFile(1) = "C:\Data\Summary\" & txtSubject.Text & "_" & txtSession.Text & "Summary.txt"
                FileOpen(1, vFile(0), OpenMode.Append)
                FileOpen(2, vFile(1), OpenMode.Append)
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
                WindowState = FormWindowState.Minimized
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
        If vCC > 0 Then
            vFile(2) = "C:\SavedPrograms\NewProgram(Rename me please)_" & Strings.Right(CStr(Environment.TickCount), 5) & ".txt"
            FileOpen(3, vFile(2), OpenMode.Append)
            WriteLine(3, Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
            WriteLine(3, vCC)
            WriteLine(3, txbStart.Text)
            WriteLine(3, txbPostSession.Text)
            WriteLine(3, txbICI.Text)
            WriteLine(3, CheckBox1.Checked)
            For i = 1 To vCC
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
                WriteLine(3, AC(i).DelayRetract(0))
                WriteLine(3, AC(i).DelayRetract(1))
            Next
            FileClose(3)
        Else
            MessageBox.Show("Nothing to save.")
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Select Macro"
        fd.InitialDirectory = "C:\SavedPrograms\"
        fd.Filter = "Text files (*.txt)|*.txt"
        fd.FilterIndex = 1
        fd.RestoreDirectory = False

        If fd.ShowDialog() = DialogResult.OK Then
            vFile(3) = fd.FileName
            Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(vFile(3))
            Dim stringReader = fileReader.ReadLine()
            stringReader = fileReader.ReadLine()
            vCC = stringReader.Replace("""", "")
            txbStart.Text = fileReader.ReadLine().Replace("""", "")
            txbPostSession.Text = fileReader.ReadLine().Replace("""", "")
            txbICI.Text = fileReader.ReadLine().Replace("""", "")
            CheckBox1.Checked = fileReader.ReadLine().Replace("#", "")
            For i = 1 To vCC
                ReDim AC(i).ScheduleType(1)
                ReDim AC(i).ScheduleValue(1)
                ReDim AC(i).Magnitude(1)
                ReDim AC(i).Reinforcer(1)
                ReDim AC(i).PelletP(1)
                ReDim AC(i).FeedbackDuration(1)
                ReDim AC(i).FeedbackType(1)
                ReDim AC(i).DelayDuration(1)
                ReDim AC(i).DelayType(1)
                ReDim AC(i).ComponentDuration_measured(AC(i).ComponentIteration)
                AC(i).HouselightOnOff = fileReader.ReadLine().Replace("#", "")
                AC(i).COD = fileReader.ReadLine()
                AC(i).MaxRefs = fileReader.ReadLine()
                AC(i).ComponentDuration = fileReader.ReadLine()
                AC(i).ComponentIteration = fileReader.ReadLine()
                AC(i).ComponentStimDuration = fileReader.ReadLine()
                AC(i).ComponentStimType = fileReader.ReadLine().Replace("""", "")
                AC(i).ScheduleType(0) = fileReader.ReadLine().Replace("""", "")
                AC(i).ScheduleType(1) = fileReader.ReadLine().Replace("""", "")
                AC(i).ScheduleValue(0) = fileReader.ReadLine()
                AC(i).ScheduleValue(1) = fileReader.ReadLine()
                AC(i).Magnitude(0) = fileReader.ReadLine()
                AC(i).Magnitude(1) = fileReader.ReadLine()
                AC(i).Reinforcer(0) = fileReader.ReadLine().Replace("""", "")
                AC(i).Reinforcer(1) = fileReader.ReadLine().Replace("""", "")
                AC(i).PelletP(0) = fileReader.ReadLine()
                AC(i).PelletP(1) = fileReader.ReadLine()
                AC(i).FeedbackDuration(0) = fileReader.ReadLine()
                AC(i).FeedbackDuration(1) = fileReader.ReadLine()
                AC(i).FeedbackType(0) = fileReader.ReadLine().Replace("""", "")
                AC(i).FeedbackType(1) = fileReader.ReadLine().Replace("""", "")
                AC(i).DelayDuration(0) = fileReader.ReadLine()
                AC(i).DelayDuration(1) = fileReader.ReadLine()
                AC(i).DelayType(0) = fileReader.ReadLine().Replace("""", "")
                AC(i).DelayType(1) = fileReader.ReadLine().Replace("""", "")

                PrintInfo(lblComponent.Location.X, lblComponent.Location.Y, "Component " & i)
                PrintInfo(lblComponentD.Location.X, lblComponentD.Location.Y, AC(i).ComponentDuration & " seconds")
                PrintInfo(lblComponentI.Location.X, lblComponentI.Location.Y, AC(i).ComponentIteration & " times")
                PrintInfo(lblComponentS.Location.X, lblComponentS.Location.Y, AC(i).ComponentStimType & ": " & AC(i).ComponentStimDuration & " seconds")

                PrintInfo(lblSchedule1.Location.X, lblSchedule1.Location.Y, AC(i).ScheduleType(0) & " " & AC(i).ScheduleValue(0))
                PrintInfo(lblMagnitude1.Location.X, lblMagnitude1.Location.Y, AC(i).Magnitude(0) & " " & AC(i).Reinforcer(0) & " " & AC(i).PelletP(0))
                PrintInfo(lblFeedback1.Location.X, lblFeedback1.Location.Y, AC(i).FeedbackType(0) & ": " & AC(i).FeedbackDuration(0) & " seconds")
                PrintInfo(lblDelay1.Location.X, lblDelay1.Location.Y, AC(i).DelayType(0) & ": " & AC(i).DelayDuration(0) & " seconds")

                PrintInfo(lblSchedule2.Location.X, lblSchedule2.Location.Y, AC(i).ScheduleType(1) & " " & AC(i).ScheduleValue(1))
                PrintInfo(lblMagnitude2.Location.X, lblMagnitude2.Location.Y, AC(i).Magnitude(1) & " " & AC(i).Reinforcer(1) & " " & AC(i).PelletP(1))
                PrintInfo(lblFeedback2.Location.X, lblFeedback2.Location.Y, AC(i).FeedbackType(1) & ": " & AC(i).FeedbackDuration(1) & " seconds")
                PrintInfo(lblDelay2.Location.X, lblDelay2.Location.Y, AC(i).DelayType(1) & ": " & AC(i).DelayDuration(1) & " seconds")

                For Each lb In Me.Controls
                    If lb.Text.Contains("Component ") Then
                        lb.Font = New Font("Microsoft Sans Serif", 11.0!, FontStyle.Bold)
                    End If
                Next

                Me.Controls.Add(Me.LabelPreview(PreviewCounter))
                PreviewCounter += 1

                vPadding += 180

            Next

            If vCC >= 2 Then
                CheckBox1.Enabled = True
                CheckBox1.Checked = True
            End If

        End If
    End Sub




End Class
