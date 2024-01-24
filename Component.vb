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
        Dim frm = New Component
        frm.Text = Me.Text
        frm.ShowDialog()
        Me.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ActiveComponent(vCurrentComponentSetup).ComponentDuration = txbComponentDuration.Text
        If txbComponentStimulation.Text = "" Then txbComponentStimulation.Text = 0
        ActiveComponent(vCurrentComponentSetup).ComponentStimDuration = txbComponentStimulation.Text
        ActiveComponent(vCurrentComponentSetup).ComponentStimType = ComponentStimType
        ReDim ActiveComponent(vCurrentComponentSetup).ScheduleType(1)
        ReDim ActiveComponent(vCurrentComponentSetup).ScheduleValue(1)
        ReDim ActiveComponent(vCurrentComponentSetup).Magnitude(1)
        ReDim ActiveComponent(vCurrentComponentSetup).FeedbackDuration(1)
        ReDim ActiveComponent(vCurrentComponentSetup).FeedbackType(1)
        ReDim ActiveComponent(vCurrentComponentSetup).DelayDuration(1)
        ReDim ActiveComponent(vCurrentComponentSetup).DelayType(1)
        ActiveComponent(vCurrentComponentSetup).ScheduleType(0) = ScheduleType1
        If txbValueL1.Text = "" Then txbValueL1.Text = 0
        ActiveComponent(vCurrentComponentSetup).ScheduleValue(0) = txbValueL1.Text
        If txbMagL1.Text = "" Then txbMagL1.Text = 1
        ActiveComponent(vCurrentComponentSetup).Magnitude(0) = txbMagL1.Text
        If txbStimDurL1.Text = "" Then txbStimDurL1.Text = 0
        ActiveComponent(vCurrentComponentSetup).FeedbackDuration(0) = txbStimDurL1.Text
        ActiveComponent(vCurrentComponentSetup).FeedbackType(0) = FeedbackType1
        If txbDelayDurL1.Text = "" Then txbDelayDurL1.Text = 0
        ActiveComponent(vCurrentComponentSetup).DelayDuration(0) = txbDelayDurL1.Text
        ActiveComponent(vCurrentComponentSetup).DelayType(0) = DelayStimType1
        ActiveComponent(vCurrentComponentSetup).ScheduleType(1) = ScheduleType2
        If txbValueL2.Text = "" Then txbValueL2.Text = 0
        ActiveComponent(vCurrentComponentSetup).ScheduleValue(1) = txbValueL2.Text
        If txbMagL2.Text = "" Then txbMagL2.Text = 1
        ActiveComponent(vCurrentComponentSetup).Magnitude(1) = txbMagL2.Text
        If txbStimDurL2.Text = "" Then txbStimDurL2.Text = 0
        ActiveComponent(vCurrentComponentSetup).FeedbackDuration(1) = txbStimDurL2.Text
        ActiveComponent(vCurrentComponentSetup).FeedbackType(1) = FeedbackType2
        If txbDelayDurL2.Text = "" Then txbDelayDurL2.Text = 0
        ActiveComponent(vCurrentComponentSetup).DelayDuration(1) = txbDelayDurL2.Text
        ActiveComponent(vCurrentComponentSetup).DelayType(1) = DelayStimType2
        vCurrentComponentSetup += 1
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
End Class