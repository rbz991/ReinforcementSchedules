Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class Component
    Dim ComponentStimType = ""
    Dim ScheduleType1 = ""
    Dim ScheduleType2 = ""
    Dim FeedbackType1 = ""
    Dim FeedbackType2 = ""
    Dim DelayStimType1 = ""
    Dim DelayStimType2 = ""
    Dim HouselightOnOff = False
    Dim COD = False
    Dim DelayRetract1 = False
    Dim DelayRetract2 = False


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        If txbComponentDuration.Text = "" Or txbComponentDuration.Text = 0 Then
            MsgBox("Please input Component duration.")
            Exit Sub
        Else
            AC(vCC).ComponentDuration = txbComponentDuration.Text
            If txbComponentIterations.Text = "" Or txbComponentIterations.Text = 0 Then
                MsgBox("Please input Component iterations.")
                Exit Sub
            Else
                AC(vCC).ComponentIteration = txbComponentIterations.Text
                If txbComponentStimulation.Text = "" Then
                    MsgBox("Please input Component stimulation. Select 0 for always on.")
                    Exit Sub
                Else

                    If rdoComponentStimLight1.Checked = True Then ComponentStimType = "Light 1"
                    If rdoComponentStimLight2.Checked = True Then ComponentStimType = "Light 2"
                    If rdoComponentTone.Checked = True Then ComponentStimType = "Tone"
                    If rdoComponentHouselight.Checked = True Then ComponentStimType = "Houselight"

                    If rdoExt1.Checked = True Then ScheduleType1 = "Extinction"
                    If rdoFRL1.Checked = True Then ScheduleType1 = "Fixed Ratio"
                    If rdoVRL1.Checked = True Then ScheduleType1 = "Variable Ratio"
                    If rdoFIL1.Checked = True Then ScheduleType1 = "Fixed Interval"
                    If rdoVIL1.Checked = True Then ScheduleType1 = "Variable Interval"
                    If rdoExt2.Checked = True Then ScheduleType2 = "Extinction"
                    If rdoFRL2.Checked = True Then ScheduleType2 = "Fixed Ratio"
                    If rdoVRL2.Checked = True Then ScheduleType2 = "Variable Ratio"
                    If rdoFIL2.Checked = True Then ScheduleType2 = "Fixed Interval"
                    If rdoVIL2.Checked = True Then ScheduleType2 = "Variable Interval"

                    If rdoLight1L1.Checked = True Then FeedbackType1 = "Light 1"
                    If rdoLight2L1.Checked = True Then FeedbackType1 = "Light 2"
                    If rdoToneL1.Checked = True Then FeedbackType1 = "Tone"
                    If rdoHouselightL1.Checked = True Then FeedbackType1 = "Houselight"
                    If rdoTOL1.Checked = True Then FeedbackType1 = "Time Out"
                    If rdoLight1L2.Checked = True Then FeedbackType2 = "Light 1"
                    If rdoLight2L2.Checked = True Then FeedbackType2 = "Light 2"
                    If rdoToneL2.Checked = True Then FeedbackType2 = "Tone"
                    If rdoHouselightL2.Checked = True Then FeedbackType2 = "Houselight"
                    If rdoTOL2.Checked = True Then FeedbackType2 = "Time Out"

                    If chkRetractL1.Checked = True Then DelayRetract1 = True
                    If rdoLightDelay1L1.Checked = True Then DelayStimType1 = "Light 1"
                    If rdoLightDelay2L1.Checked = True Then DelayStimType1 = "Light 2"
                    If rdoToneDelayL1.Checked = True Then DelayStimType1 = "Tone"
                    If rdoHouselightDelayL1.Checked = True Then DelayStimType1 = "Houselight"
                    If chkRetractL2.Checked = True Then DelayRetract2 = True
                    If rdoLightDelay1L2.Checked = True Then DelayStimType2 = "Light 1"
                    If rdoLightDelay2L2.Checked = True Then DelayStimType2 = "Light 2"
                    If rdoToneDelayL2.Checked = True Then DelayStimType2 = "Tone"
                    If rdoHouselightDelayL2.Checked = True Then DelayStimType2 = "Houselight"

                    AC(vCC).ComponentStimDuration = txbComponentStimulation.Text
                    AC(vCC).ComponentStimType = ComponentStimType
                    ReDim AC(vCC).ScheduleType(1)
                    ReDim AC(vCC).ScheduleValue(1)
                    ReDim AC(vCC).Magnitude(1)
                    ReDim AC(vCC).Reinforcer(1)
                    ReDim AC(vCC).PelletP(1)
                    ReDim AC(vCC).FeedbackDuration(1)
                    ReDim AC(vCC).FeedbackType(1)
                    ReDim AC(vCC).DelayDuration(1)
                    ReDim AC(vCC).DelayType(1)
                    ReDim AC(vCC).ComponentDuration_measured(AC(vCC).ComponentIteration)
                    ReDim AC(vCC).DelayRetract(1)

                    AC(vCC).ScheduleType(0) = ScheduleType1
                    If txbValueL1.Text = "" Then txbValueL1.Text = 0
                    AC(vCC).ScheduleValue(0) = txbValueL1.Text
                    If cbbReinforcer1.Text = "" Then cbbReinforcer1.Text = "Pellet"
                    AC(vCC).Reinforcer(0) = cbbReinforcer1.Text
                    If txbMagL1.Text = "" Then txbMagL1.Text = 0
                    AC(vCC).Magnitude(0) = txbMagL1.Text
                    If txbPelletProbability1.Text = "" Then txbPelletProbability1.Text = 0
                    AC(vCC).PelletP(0) = txbPelletProbability1.Text
                    If txbStimDurL1.Text = "" Then txbStimDurL1.Text = 0
                    AC(vCC).FeedbackDuration(0) = txbStimDurL1.Text
                    AC(vCC).FeedbackType(0) = FeedbackType1
                    If txbDelayDurL1.Text = "" Then txbDelayDurL1.Text = 0
                    AC(vCC).DelayDuration(0) = txbDelayDurL1.Text
                    AC(vCC).DelayType(0) = DelayStimType1
                    AC(vCC).DelayRetract(0) = DelayRetract1

                    AC(vCC).ScheduleType(1) = ScheduleType2
                    If txbValueL2.Text = "" Then txbValueL2.Text = 0
                    AC(vCC).ScheduleValue(1) = txbValueL2.Text
                    If cbbReinforcer2.Text = "" Then cbbReinforcer2.Text = "Pellet"
                    AC(vCC).Reinforcer(1) = cbbReinforcer2.Text
                    If txbMagL2.Text = "" Then txbMagL2.Text = 0
                    AC(vCC).Magnitude(1) = txbMagL2.Text
                    If txbPelletProbability2.Text = "" Then txbPelletProbability2.Text = 0
                    AC(vCC).PelletP(1) = txbPelletProbability2.Text
                    If txbStimDurL2.Text = "" Then txbStimDurL2.Text = 0
                    AC(vCC).FeedbackDuration(1) = txbStimDurL2.Text
                    AC(vCC).FeedbackType(1) = FeedbackType2
                    If txbDelayDurL2.Text = "" Then txbDelayDurL2.Text = 0
                    AC(vCC).DelayDuration(1) = txbDelayDurL2.Text
                    AC(vCC).DelayType(1) = DelayStimType2
                    AC(vCC).DelayRetract(1) = DelayRetract2

                    AC(vCC).HouselightOnOff = HouselightOnOff
                    If txbCOD.Text = "" Then txbCOD.Text = 0
                    AC(vCC).COD = txbCOD.Text * 1000
                    If txbMaxRefs.Text = "" Then txbMaxRefs.Text = 0
                    AC(vCC).MaxRefs = txbMaxRefs.Text


                    PrintInfo(SetUp.lblComponent.Location.X, SetUp.lblComponent.Location.Y, "Component " & vCC)
                    PrintInfo(SetUp.lblComponentD.Location.X, SetUp.lblComponentD.Location.Y, AC(vCC).ComponentDuration & " seconds")
                    PrintInfo(SetUp.lblComponentI.Location.X, SetUp.lblComponentI.Location.Y, AC(vCC).ComponentIteration & " times")
                    PrintInfo(SetUp.lblComponentS.Location.X, SetUp.lblComponentS.Location.Y, AC(vCC).ComponentStimType & ": " & AC(vCC).ComponentStimDuration & " seconds")

                    PrintInfo(SetUp.lblSchedule1.Location.X, SetUp.lblSchedule1.Location.Y, AC(vCC).ScheduleType(0) & " " & AC(vCC).ScheduleValue(0))
                    PrintInfo(SetUp.lblMagnitude1.Location.X, SetUp.lblMagnitude1.Location.Y, AC(vCC).Magnitude(0) & " " & AC(vCC).Reinforcer(0) & " " & AC(vCC).PelletP(0))
                    PrintInfo(SetUp.lblFeedback1.Location.X, SetUp.lblFeedback1.Location.Y, AC(vCC).FeedbackType(0) & ": " & AC(vCC).FeedbackDuration(0) & " seconds")
                    PrintInfo(SetUp.lblDelay1.Location.X, SetUp.lblDelay1.Location.Y, AC(vCC).DelayType(0) & ": " & AC(vCC).DelayDuration(0) & " seconds - Ret: " & AC(vCC).DelayRetract(0))

                    PrintInfo(SetUp.lblSchedule2.Location.X, SetUp.lblSchedule2.Location.Y, AC(vCC).ScheduleType(1) & " " & AC(vCC).ScheduleValue(1))
                    PrintInfo(SetUp.lblMagnitude2.Location.X, SetUp.lblMagnitude2.Location.Y, AC(vCC).Magnitude(1) & " " & AC(vCC).Reinforcer(1) & " " & AC(vCC).PelletP(1))
                    PrintInfo(SetUp.lblFeedback2.Location.X, SetUp.lblFeedback2.Location.Y, AC(vCC).FeedbackType(1) & ": " & AC(vCC).FeedbackDuration(1) & " seconds")
                    PrintInfo(SetUp.lblDelay2.Location.X, SetUp.lblDelay2.Location.Y, AC(vCC).DelayType(1) & ": " & AC(vCC).DelayDuration(1) & " seconds - Ret: " & AC(vCC).DelayRetract(1))

                    For Each lb In SetUp.Controls
                        If lb.Text.Contains("Component ") Then
                            lb.Font = New Font("Microsoft Sans Serif", 11.0!, FontStyle.Bold)
                        End If
                    Next

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1

                    vPadding += 180

                End If
            End If
        End If
        If vCC >= 2 Then SetUp.CheckBox1.Enabled = True
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Box Characteristics" & vbCrLf &
              "Length:" & vbCrLf &
              "Width:" & vbCrLf &
              "Height:")
    End Sub
    Private Sub Component_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(370, 570)
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkHouselightOnOff.CheckedChanged
        If chkHouselightOnOff.Checked = True Then
            HouselightOnOff = True
        Else
            HouselightOnOff = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        vCC -= 1
        Me.Close()
    End Sub

    Private Sub cbbReinforcer1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbReinforcer1.SelectedIndexChanged
        If cbbReinforcer1.Text = "Random" Then
            txbPelletProbability1.Text = 50
            txbPelletProbability1.Enabled = True
        Else
            txbPelletProbability1.Text = ""
            txbPelletProbability1.Enabled = False
        End If
    End Sub

    Private Sub cbbReinforcer2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbReinforcer2.SelectedIndexChanged
        If cbbReinforcer2.Text = "Random" Then
            txbPelletProbability2.Text = 50
            txbPelletProbability2.Enabled = True
        Else
            txbPelletProbability2.Text = ""
            txbPelletProbability2.Enabled = False
        End If
    End Sub
End Class