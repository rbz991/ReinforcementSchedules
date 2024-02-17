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


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rdoComponentStimLight1.Checked = True Then ComponentStimType = "Light 1"
        If rdoComponentStimLight2.Checked = True Then ComponentStimType = "Light 2"
        If rdoComponentTone.Checked = True Then ComponentStimType = "Tone"
        If rdoComponentHouselight.Checked = True Then ComponentStimType = "Houselight"

        If rdoFRL1.Checked = True Then ScheduleType1 = "Fixed Ratio"
        If rdoVRL1.Checked = True Then ScheduleType1 = "Variable Ratio"
        If rdoFIL1.Checked = True Then ScheduleType1 = "Fixed Interval"
        If rdoVIL1.Checked = True Then ScheduleType1 = "Variable Interval"
        If rdoFRL2.Checked = True Then ScheduleType2 = "Fixed Ratio"
        If rdoVRL2.Checked = True Then ScheduleType2 = "Variable Ratio"
        If rdoFIL2.Checked = True Then ScheduleType2 = "Fixed Interval"
        If rdoVIL2.Checked = True Then ScheduleType2 = "Variable Interval"

        If rdoLight1L1.Checked = True Then FeedbackType1 = "Light 1"
        If rdoLight2L1.Checked = True Then FeedbackType1 = "Light 2"
        If rdoToneL1.Checked = True Then FeedbackType1 = "Tone"
        If rdoHouselightL1.Checked = True Then FeedbackType1 = "Houselight"
        If rdoLight1L2.Checked = True Then FeedbackType2 = "Light 1"
        If rdoLight2L2.Checked = True Then FeedbackType2 = "Light 2"
        If rdoToneL2.Checked = True Then FeedbackType2 = "Tone"
        If rdoHouselightL2.Checked = True Then FeedbackType2 = "Houselight"

        If rdoLightDelay1L1.Checked = True Then DelayStimType1 = "Light 1"
        If rdoLightDelay2L1.Checked = True Then DelayStimType1 = "Light 2"
        If rdoToneDelayL1.Checked = True Then DelayStimType1 = "Tone"
        If rdoHouselightDelayL1.Checked = True Then DelayStimType1 = "Houselight"
        If rdoLightDelay1L2.Checked = True Then DelayStimType2 = "Light 1"
        If rdoLightDelay2L2.Checked = True Then DelayStimType2 = "Light 2"
        If rdoToneDelayL2.Checked = True Then DelayStimType2 = "Tone"
        If rdoHouselightDelayL2.Checked = True Then DelayStimType2 = "Houselight"

        If txbComponentDuration.Text = "" Or txbComponentDuration.Text = 0 Then
            MsgBox("Please input Component duration.")
        Else
            AC(vCC).ComponentDuration = txbComponentDuration.Text
            If txbComponentIterations.Text = "" Or txbComponentIterations.Text = 0 Then
                MsgBox("Please input Component iterations.")
            Else
                AC(vCC).ComponentIteration = txbComponentIterations.Text
                If txbComponentStimulation.Text = "" Then
                    MsgBox("Please input Component stimulation. Select 0 for always on.")
                Else
                    AC(vCC).ComponentStimDuration = txbComponentStimulation.Text
                    AC(vCC).ComponentStimType = ComponentStimType
                    ReDim AC(vCC).ScheduleType(1)
                    ReDim AC(vCC).ScheduleValue(1)
                    ReDim AC(vCC).Magnitude(1)
                    ReDim AC(vCC).FeedbackDuration(1)
                    ReDim AC(vCC).FeedbackType(1)
                    ReDim AC(vCC).DelayDuration(1)
                    ReDim AC(vCC).DelayType(1)
                    AC(vCC).ScheduleType(0) = ScheduleType1
                    If txbValueL1.Text = "" Then txbValueL1.Text = 0
                    AC(vCC).ScheduleValue(0) = txbValueL1.Text
                    If txbMagL1.Text = "" Then txbMagL1.Text = 0
                    AC(vCC).Magnitude(0) = txbMagL1.Text
                    If txbStimDurL1.Text = "" Then txbStimDurL1.Text = 0
                    AC(vCC).FeedbackDuration(0) = txbStimDurL1.Text
                    AC(vCC).FeedbackType(0) = FeedbackType1
                    If txbDelayDurL1.Text = "" Then txbDelayDurL1.Text = 0
                    AC(vCC).DelayDuration(0) = txbDelayDurL1.Text
                    AC(vCC).DelayType(0) = DelayStimType1
                    AC(vCC).ScheduleType(1) = ScheduleType2
                    If txbValueL2.Text = "" Then txbValueL2.Text = 0
                    AC(vCC).ScheduleValue(1) = txbValueL2.Text
                    If txbMagL2.Text = "" Then txbMagL2.Text = 0
                    AC(vCC).Magnitude(1) = txbMagL2.Text
                    If txbStimDurL2.Text = "" Then txbStimDurL2.Text = 0
                    AC(vCC).FeedbackDuration(1) = txbStimDurL2.Text
                    AC(vCC).FeedbackType(1) = FeedbackType2
                    If txbDelayDurL2.Text = "" Then txbDelayDurL2.Text = 0
                    AC(vCC).DelayDuration(1) = txbDelayDurL2.Text
                    AC(vCC).DelayType(1) = DelayStimType2
                    AC(vCC).HouselightOnOff = HouselightOnOff


                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblComponent.Location.X + vPadding, SetUp.lblComponent.Location.Y),
            .AutoSize = True,
            .Text = "Component " & vCC,
            .Font = New Font("Microsoft Sans Serif", 11.0!, FontStyle.Bold)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblComponentD.Location.X + vPadding, SetUp.lblComponentD.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).ComponentDuration & " seconds",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblComponentI.Location.X + vPadding, SetUp.lblComponentI.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).ComponentIteration + 1 & " times",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblComponentS.Location.X + vPadding, SetUp.lblComponentS.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).ComponentStimType & ": " & AC(vCC).ComponentStimDuration & " seconds",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblSchedule1.Location.X + vPadding, SetUp.lblSchedule1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).ScheduleType(0) & " " & AC(vCC).ScheduleValue(0),
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblMagnitude1.Location.X + vPadding, SetUp.lblMagnitude1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).Magnitude(0) & " delivery",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblFeedback1.Location.X + vPadding, SetUp.lblFeedback1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).FeedbackType(0) & ": " & AC(vCC).FeedbackDuration(0) & " seconds",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblDelay1.Location.X + vPadding, SetUp.lblDelay1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).DelayType(0) & ": " & AC(vCC).DelayDuration(0) & " seconds",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblSchedule2.Location.X + vPadding, SetUp.lblSchedule2.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).ScheduleType(1) & " " & AC(vCC).ScheduleValue(1),
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblMagnitude2.Location.X + vPadding, SetUp.lblMagnitude2.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).Magnitude(1) & " delivery",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblFeedback2.Location.X + vPadding, SetUp.lblFeedback2.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).FeedbackType(1) & ": " & AC(vCC).FeedbackDuration(1) & " seconds",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1
                    SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblDelay2.Location.X + vPadding, SetUp.lblDelay2.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).DelayType(1) & ": " & AC(vCC).DelayDuration(1) & " seconds",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }


                    SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
                    PreviewCounter += 1

                    vPadding += 180

                End If
            End If
        End If
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txbComponentDuration.Text = ""
        txbComponentIterations.Text = ""
        txbComponentStimulation.Text = ""
        txbValueL1.Text = ""
        txbMagL1.Text = ""
        txbStimDurL1.Text = ""
        txbDelayDurL1.Text = ""
        txbValueL2.Text = ""
        txbMagL2.Text = ""
        txbStimDurL2.Text = ""
        txbDelayDurL2.Text = ""
        rdoFRL1.Checked = False
        rdoVRL1.Checked = False
        rdoFIL1.Checked = False
        rdoVIL1.Checked = False
        rdoFRL2.Checked = False
        rdoVRL2.Checked = False
        rdoFIL2.Checked = False
        rdoVIL2.Checked = False
        rdoLight1L1.Checked = False
        rdoLight2L1.Checked = False
        rdoToneL1.Checked = False
        rdoHouselightL1.Checked = False
        rdoLightDelay1L1.Checked = False
        rdoLightDelay2L1.Checked = False
        rdoToneDelayL1.Checked = False
        rdoHouselightDelayL1.Checked = False
        rdoLight1L2.Checked = False
        rdoLight2L2.Checked = False
        rdoToneL2.Checked = False
        rdoHouselightL2.Checked = False
        rdoLightDelay1L2.Checked = False
        rdoLightDelay2L2.Checked = False
        rdoToneDelayL2.Checked = False
        rdoHouselightDelayL2.Checked = False
    End Sub

End Class