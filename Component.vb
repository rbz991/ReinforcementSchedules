Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class Component
    Dim ComponentStimType = 0
    Dim ScheduleType1 = 0
    Dim ScheduleType2 = 0
    Dim FeedbackType1 = 0
    Dim FeedbackType2 = 0
    Dim DelayStimType1 = 0
    Dim DelayStimType2 = 0

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txbComponentDuration.Text = "" Then
            MsgBox("Please input Component duration.")
        Else
            AC(vCC).ComponentDuration = txbComponentDuration.Text
            If txbComponentIterations.Text = "" Then txbComponentIterations.Text = 1
            AC(vCC).ComponentIteration = txbComponentIterations.Text
            If txbComponentStimulation.Text = "" Then txbComponentStimulation.Text = 0
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
            If txbMagL1.Text = "" Then txbMagL1.Text = 1
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
            If txbMagL2.Text = "" Then txbMagL2.Text = 1
            AC(vCC).Magnitude(1) = txbMagL2.Text
            If txbStimDurL2.Text = "" Then txbStimDurL2.Text = 0
            AC(vCC).FeedbackDuration(1) = txbStimDurL2.Text
            AC(vCC).FeedbackType(1) = FeedbackType2
            If txbDelayDurL2.Text = "" Then txbDelayDurL2.Text = 0
            AC(vCC).DelayDuration(1) = txbDelayDurL2.Text
            AC(vCC).DelayType(1) = DelayStimType2



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
            .Location = New Point(SetUp.lblSchedule1.Location.X + vPadding, SetUp.lblSchedule1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).ScheduleType(0) & " " & AC(vCC).ScheduleValue(0) & " / " & AC(vCC).ScheduleType(1) & " " & AC(vCC).ScheduleValue(1),
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

            SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
            PreviewCounter += 1
            SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblMagnitude1.Location.X + vPadding, SetUp.lblMagnitude1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).Magnitude(0) & " / " & AC(vCC).Magnitude(1) & "pellets",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

            SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
            PreviewCounter += 1
            SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblFeedback1.Location.X + vPadding, SetUp.lblFeedback1.Location.Y),
            .AutoSize = True,
            .Text = AC(vCC).FeedbackType(0) & " " & AC(vCC).FeedbackDuration(0) & " / " & AC(vCC).FeedbackType(1) & " " & AC(vCC).FeedbackDuration(1),
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

            SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
            PreviewCounter += 1
            SetUp.LabelPreview(PreviewCounter) = New Label With {
            .Location = New Point(SetUp.lblDelay1.Location.X + vPadding, SetUp.lblDelay1.Location.Y),
            .AutoSize = True,
            .Text = "Delay",
            .Font = New Font("Microsoft Sans Serif", 11.0!)
            }

            SetUp.Controls.Add(SetUp.LabelPreview(PreviewCounter))
            PreviewCounter += 1

            vPadding += 200

        End If
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Box Characteristics" & vbCrLf &
              "Length:" & vbCrLf &
              "Width:" & vbCrLf &
              "Height:")
    End Sub
    Private Sub rdoComponentStimLight1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoComponentStimLight1.CheckedChanged, rdoComponentTone.CheckedChanged, rdoComponentStimLight2.CheckedChanged, rdoComponentHouselight.CheckedChanged
        ComponentStimType = sender.Text
    End Sub
    Private Sub rdoFRL1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFRL1.CheckedChanged, rdoVRL1.CheckedChanged, rdoFIL1.CheckedChanged, rdoVIL1.CheckedChanged
        ScheduleType1 = sender.Text
    End Sub
    Private Sub rdoFRL2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFRL2.CheckedChanged, rdoVRL2.CheckedChanged, rdoFIL2.CheckedChanged, rdoVIL2.CheckedChanged
        ScheduleType2 = sender.Text
    End Sub
    Private Sub rdoLight1L1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLight1L1.CheckedChanged, rdoLight2L1.CheckedChanged, rdoToneL1.CheckedChanged, rdoHouselightL1.CheckedChanged
        FeedbackType1 = sender.Text
    End Sub
    Private Sub rdoLight1L2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLight1L2.CheckedChanged, rdoLight2L2.CheckedChanged, rdoToneL2.CheckedChanged, rdoHouselightL2.CheckedChanged
        FeedbackType2 = sender.Text
    End Sub
    Private Sub rdoUnsignaledL1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUnsignaledL1.CheckedChanged, rdoLightDelay1L1.CheckedChanged, rdoLightDelay2L1.CheckedChanged, rdoToneDelayL1.CheckedChanged, rdoHouselightDelayL1.CheckedChanged
        DelayStimType1 = sender.Text
    End Sub
    Private Sub rdoUnsignaledL2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUnsignaledL2.CheckedChanged, rdoLightDelay1L2.CheckedChanged, rdoLightDelay2L2.CheckedChanged, rdoToneDelayL2.CheckedChanged, rdoHouselightDelayL2.CheckedChanged
        DelayStimType2 = sender.Text
    End Sub

    Private Sub Component_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(370, 570)
    End Sub
End Class