Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class Component

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim frm = New Component
        frm.Text = Me.Text
        frm.ShowDialog()
        Me.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ActiveComponent(vCurrentComponentSetup).ComponentDuration = 1
        ActiveComponent(vCurrentComponentSetup).ComponentStimDuration = 1
        ActiveComponent(vCurrentComponentSetup).ComponentStimType = 1
        ReDim ActiveComponent(vCurrentComponentSetup).ScheduleType(1)
        ReDim ActiveComponent(vCurrentComponentSetup).ScheduleValue(1)
        ReDim ActiveComponent(vCurrentComponentSetup).Magnitude(1)
        ReDim ActiveComponent(vCurrentComponentSetup).FeedbackDuration(1)
        ReDim ActiveComponent(vCurrentComponentSetup).FeedbackType(1)
        ReDim ActiveComponent(vCurrentComponentSetup).DelayDuration(1)
        ReDim ActiveComponent(vCurrentComponentSetup).DelayType(1)
        ActiveComponent(vCurrentComponentSetup).ScheduleType(0) = 1
        ActiveComponent(vCurrentComponentSetup).ScheduleValue(0) = 1
        ActiveComponent(vCurrentComponentSetup).Magnitude(0) = 1
        ActiveComponent(vCurrentComponentSetup).FeedbackDuration(0) = 1
        ActiveComponent(vCurrentComponentSetup).FeedbackType(0) = 1
        ActiveComponent(vCurrentComponentSetup).DelayDuration(0) = 1
        ActiveComponent(vCurrentComponentSetup).DelayType(0) = 1
        ActiveComponent(vCurrentComponentSetup).ScheduleType(1) = 1
        ActiveComponent(vCurrentComponentSetup).ScheduleValue(1) = 1
        ActiveComponent(vCurrentComponentSetup).Magnitude(1) = 1
        ActiveComponent(vCurrentComponentSetup).FeedbackDuration(1) = 1
        ActiveComponent(vCurrentComponentSetup).FeedbackType(1) = 1
        ActiveComponent(vCurrentComponentSetup).DelayDuration(1) = 1
        ActiveComponent(vCurrentComponentSetup).DelayType(1) = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Box Characteristics" & vbCrLf &
              "Length:" & vbCrLf &
              "Width:" & vbCrLf &
              "Height:")
    End Sub
End Class