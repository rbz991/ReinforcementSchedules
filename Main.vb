Imports System.Math
Imports System.IO.Ports
Imports Microsoft.SqlServer
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Main
    Public Arduino As SerialPort
    Function ArduinoVB() As Integer 'This function starts the Arduino-VB communication.
        Arduino = New SerialPort(SetUp.txtCOM.Text, 9600) 'Assigns the Arduino to the selected port at a 9600 baud rate. 
        Arduino.Open() 'Starts the Arduino-VB communication.
        tmrStart.Interval = SetUp.txbStart.Text * 1000
        Countdown = Environment.TickCount + SetUp.txbStart.Text * 1000
        tmrStart.Enabled = True

        Do 'This code will run throughout the session to allow response collection. 
            Try
                If Arduino.BytesToRead > 0 Then 'Checks for activity on the Arduino.
                    Actual_Response = Split(Arduino.ReadLine(), ",") 'Splits data from the arduino into separate responses.
                End If
                'The next following lines compare the state of the data stream of operanda 1 and 2 with previous observations to detect responses.
                If (Actual_Response(0) <> Previous_Response(0) And Actual_Response(0) <> 1) Then
                    Response(0) 'If a response is registered at operanda 1, this code will run.
                End If
                If (Actual_Response(1) <> Previous_Response(1) And Actual_Response(1) <> 1) Then
                    Response(1) 'The same happens for operanda 2.
                End If
                If (Actual_Response(2) <> Previous_Response(2) And Actual_Response(2) <> 1) Then
                    Nosepoke(0) 'The same happens for operanda 3.
                End If
                If (Actual_Response(3) <> Previous_Response(3) And Actual_Response(3) <> 1) Then
                    'Response(3) 'The same happens for operanda 4.
                End If
                If (Actual_Response(4) <> Previous_Response(4) And Actual_Response(4) <> 1) Then
                    'Response(4) 'The same happens for operanda 5.
                End If
                Previous_Response(0) = Actual_Response(0) 'This resets the data stream observation of operanda 1 to detect further responses. 
                Previous_Response(1) = Actual_Response(1) 'The same happens for operanda 2.
                Previous_Response(2) = Actual_Response(2)
                Previous_Response(3) = Actual_Response(3)
                Previous_Response(4) = Actual_Response(4)
                If tmrStart.Enabled = False Then vTimeNow = Environment.TickCount - vTimeStart  'This keeps track of time for the Data output file.
                If tmrStart.Enabled = True Then vTimeNow = (Countdown) - Environment.TickCount
                lblTime.Text = Round(vTimeNow / 1000) 'This and the following 6 lines update values of interest on the main form.
                If RefCount(0) + RefCount(1) >= SetUp.txbRefs.Text Then btnFinish.PerformClick() 'This sets the criteria to finish the session.

            Catch ex As Exception
            End Try
            My.Application.DoEvents() 'This will enable the rest of the program to run while executing the code from above.
        Loop
        Return 0
    End Function
    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        tmrStart.Enabled = False
        vTimeStart = Environment.TickCount 'Establishes a time index for timestamps.
        If AC(vCC).ComponentStimDuration <> 0 Then
            tmrComponentStim.Interval = AC(vCC).ComponentStimDuration * 1000
            tmrComponentStim.Enabled = True
        End If
        BeginPrograms() 'Set up for the schedules of reinforcement.
    End Sub
    Private Sub BeginPrograms() 'Llamar esto cada que inicie un componente.
        tmrLever1.Enabled = False
        tmrLever2.Enabled = False
        tmrDelay1.Enabled = False
        tmrDelay2.Enabled = False
        tmrStim1.Enabled = False
        tmrStim2.Enabled = False
        tmrNosepoke.Enabled = False
        Arduino.WriteLine("a")
        Arduino.WriteLine("b")
        Arduino.WriteLine("t")
        WriteLine(1, vTimeNow, "StartComponent" & vCC)
        tmrComponentDuration.Interval = AC(vCC).ComponentDuration
        tmrComponentDuration.Enabled = True
        VIList(0) = New List(Of Integer)
        VIList(1) = New List(Of Integer)
        ObtainedDelays(0) = New List(Of Integer)
        ObtainedDelays(1) = New List(Of Integer)
        lblSubject.Text = SetUp.txtSubject.Text
        lblSession.Text = SetUp.txtSession.Text
        lblCOM.Text = SetUp.txtCOM.Text

        If AC(vCC).HouselightOnOff = True Then Arduino.WriteLine("H")
        If AC(vCC).HouselightOnOff = False Then Arduino.WriteLine("h")

        If AC(vCC).DelayDuration(0) <> 0 Then tmrDelay1.Interval = AC(vCC).DelayDuration(0) * 1000
        If AC(vCC).DelayDuration(1) <> 0 Then tmrDelay2.Interval = AC(vCC).DelayDuration(1) * 1000

        If AC(vCC).FeedbackDuration(0) <> 0 Then tmrStim1.Interval = AC(vCC).FeedbackDuration(0) * 1000
        If AC(vCC).FeedbackDuration(1) <> 0 Then tmrStim2.Interval = AC(vCC).FeedbackDuration(1) * 1000

        If AC(vCC).ScheduleType(0) <> "" Then Arduino.WriteLine("L")
        If AC(vCC).ScheduleType(1) <> "" Then Arduino.WriteLine("M")

        If AC(vCC).ScheduleType(0) = "Fixed Ratio" Then FRGen(0)
        If AC(vCC).ScheduleType(1) = "Fixed Ratio" Then FRGen(1)
        If AC(vCC).ScheduleType(0) = "Variable Ratio" Then VRGen(0)
        If AC(vCC).ScheduleType(1) = "Variable Ratio" Then VRGen(1)
        If AC(vCC).ScheduleType(0) = "Fixed Interval" Then FIGen(0)
        If AC(vCC).ScheduleType(1) = "Fixed Interval" Then FIGen(1)
        If AC(vCC).ScheduleType(0).Contains("Variable Interval") Then VIGen(0) ' Verificar que esto funcione tanto con strings como con strings()
        If AC(vCC).ScheduleType(1).Contains("Variable Interval") Then VIGen(1)

        lblL1.Text = AC(vCC).ScheduleType(0) & " " & AC(vCC).ScheduleValue(0)
        lblL2.Text = AC(vCC).ScheduleType(1) & " " & AC(vCC).ScheduleValue(1)

        WriteLine(1, "Lever 1 Schedule: " & lblL1.Text)
        WriteLine(1, "Lever 2 Schedule: " & lblL2.Text)
        WriteLine(2, "Lever 1 Schedule: " & lblL1.Text)
        WriteLine(2, "Lever 2 Schedule: " & lblL2.Text)
        tmrChart.Enabled = True
    End Sub
    Private Sub Response(Lever As Integer) 'This registers responses and checks if the reinforcer is available for both ratio and interval schedules.
        If tmrStart.Enabled = False Then
            Stimulus(Lever)
            chartResponse(Lever) += 1
            If Lever = 0 Then
                If tmrDelay1.Enabled = False Then
                    WriteLine(1, vTimeNow, Lever + 1)
                    ResponseCount(Lever) += 1
                    lblResponses1.Text = ResponseCount(Lever)
                    If refRdy(Lever) = True Then Reinforce(Lever, False)
                    Ratio(Lever)
                ElseIf tmrDelay1.Enabled = True Then
                    WriteLine(1, vTimeNow, Lever + 21)
                    ResponseCountDel(Lever) += 1
                    lblDelayR1.Text = ResponseCountDel(Lever)
                    ObtainedDelays(0).Item(DelayIndex1) = vTimeNow
                End If
            End If
            If Lever = 1 Then
                If tmrDelay2.Enabled = False Then
                    WriteLine(1, vTimeNow, Lever + 1)
                    ResponseCount(Lever) += 1
                    lblResponses2.Text = ResponseCount(Lever)
                    If refRdy(Lever) = True Then Reinforce(Lever, False)
                    Ratio(Lever)
                ElseIf tmrDelay2.Enabled = True Then
                    WriteLine(1, vTimeNow, Lever + 21)
                    ResponseCountDel(Lever) += 1
                    lblDelayR2.Text = ResponseCountDel(Lever)
                    ObtainedDelays(1).Item(DelayIndex2) = vTimeNow
                End If
            End If
        End If
    End Sub
    Private Sub Nosepoke(Nose As Integer)
        If vTimeNow > 500 Then
            If tmrNosepoke.Enabled = False Then
                tmrNosepoke.Enabled = True
                If tmrDelay1.Enabled = True Or tmrDelay2.Enabled = True Then
                    WriteLine(1, vTimeNow, Nose + 23)
                    NosepokeCountDel(Nose) += 1
                Else
                    NosepokeCount(Nose) += 1
                    lblTrayRs.Text = NosepokeCount(Nose)
                    chartResponse(2) += 1
                    WriteLine(1, vTimeNow, Nose + 3)
                End If
            Else
            End If
        End If
    End Sub
    Private Sub Stimulus(Lever)
        If Lever = 0 Then
            If AC(vCC).FeedbackType(0).Contains("Light 1") = True Then Arduino.WriteLine("A")
            If AC(vCC).FeedbackType(0).Contains("Light 2") = True Then Arduino.WriteLine("B")
            If AC(vCC).FeedbackType(0).Contains("Tone") = True Then Arduino.WriteLine("T")
            If AC(vCC).FeedbackType(0).Contains("Houselight") = True Then Arduino.WriteLine("H")
            tmrStim1.Enabled = True
        ElseIf Lever = 1 Then
            If AC(vCC).FeedbackType(1).Contains("Light 1") = True Then Arduino.WriteLine("A")
            If AC(vCC).FeedbackType(1).Contains("Light 2") = True Then Arduino.WriteLine("B")
            If AC(vCC).FeedbackType(1).Contains("Tone") = True Then Arduino.WriteLine("T")
            If AC(vCC).FeedbackType(1).Contains("Houselight") = True Then Arduino.WriteLine("H")
            tmrStim2.Enabled = True
        End If
    End Sub
    Private Sub Ratio(Lever As Integer) 'This counts responses for ratio schedules.
        If RatioGoal(Lever) <> 0 Then
            RatioCount(Lever) += 1
            If RatioCount(Lever) >= RatioGoal(Lever) Then
                refRdy(Lever) = True
                If Lever = 0 Then lblRfR1.Text = refRdy(0)
                If Lever = 1 Then lblRfR2.Text = refRdy(1)
                Reinforce(Lever, False)
                RatioCount(Lever) = 0
            End If
        End If
    End Sub
    Private Sub Reinforce(Lever As Integer, Delay As Boolean) 'This registers reinforcer deliveries and sets up the next reinforcer conditions.
        If Lever = 0 And AC(vCC).DelayDuration(0) > 0 And Delay = False Then
            tmrDelay1.Enabled = True
            ObtainedDelays(0).Add(vTimeNow) 'The reponse that onsets the delay adds this time
            If AC(vCC).DelayType(0) <> "Unsignaled" Then
                If AC(vCC).DelayType(0).Contains("Light 1") = True Then Arduino.WriteLine("A")
                If AC(vCC).DelayType(0).Contains("Light 2") = True Then Arduino.WriteLine("B")
                If AC(vCC).DelayType(0).Contains("Tone") = True Then Arduino.WriteLine("T")
                If AC(vCC).DelayType(0).Contains("Houselight") = True Then Arduino.WriteLine("H")
            End If
        ElseIf Lever = 1 And AC(vCC).DelayDuration(1) > 0 = True And Delay = False Then
            tmrDelay2.Enabled = True
            ObtainedDelays(1).Add(vTimeNow)
            If AC(vCC).DelayType(1) <> "Unsignaled" Then
                If AC(vCC).DelayType(1).Contains("Light 1") = True Then Arduino.WriteLine("A")
                If AC(vCC).DelayType(1).Contains("Light 2") = True Then Arduino.WriteLine("B")
                If AC(vCC).DelayType(1).Contains("Tone") = True Then Arduino.WriteLine("T")
                If AC(vCC).DelayType(1).Contains("Houselight") = True Then Arduino.WriteLine("H")
            End If
        ElseIf Lever = 3 Then
            Arduino.WriteLine("R")
        Else
            refRdy(Lever) = False


            If Lever = 0 Then
                lblRfR1.Text = refRdy(0)
                Chart1.Series("Reinforcers 1").Points.AddXY(chartTime(0), chartResponse(0))
                For i = 1 To AC(vCC).Magnitude(0)
                    Arduino.WriteLine("R")
                    RefCount(Lever) += 1
                    lblReinforcers1.Text = RefCount(Lever)
                Next
            End If
            If Lever = 1 Then
                lblRfR2.Text = refRdy(1)
                Chart1.Series("Reinforcers 2").Points.AddXY(chartTime(1), chartResponse(1))
                For i = 1 To AC(vCC).Magnitude(1)
                    Arduino.WriteLine("R")
                    RefCount(Lever) += 1
                    lblReinforcers2.Text = RefCount(Lever)
                Next
            End If
            'This line activates the feeder through Arduino. "R" can mean any output connected to the Arduino.
            WriteLine(1, vTimeNow, Lever + 11)

            If Lever = 0 Then
                If AC(vCC).ScheduleType(0) = "Fixed Ratio" Then FRGen(0)
                If AC(vCC).ScheduleType(0) = "Variable Ratio" Then VRGen(0)
                If AC(vCC).ScheduleType(0) = "Fixed Interval" Then FIGen(0)
                If AC(vCC).ScheduleType(0).Contains("Variable Interval") Then VIGen(0) ' Verificar que esto funcione tanto con strings como con strings()
            ElseIf Lever = 1 Then
                If AC(vCC).ScheduleType(1) = "Fixed Ratio" Then FRGen(1)
                If AC(vCC).ScheduleType(1) = "Variable Ratio" Then VRGen(1)
                If AC(vCC).ScheduleType(1) = "Fixed Interval" Then FIGen(1)
                If AC(vCC).ScheduleType(1).Contains("Variable Interval") Then VIGen(1)
            End If
        End If
    End Sub
    Private Sub FRGen(x) 'This initializes Fixed Ratio schedules depending on the selected values / operanda.
        'FR schedules just check current responses against the specified schedule value.
        RatioGoal(x) = AC(vCC).ScheduleValue(x)
    End Sub
    Private Sub VRGen(x) 'This initializes Variable Ratio schedules depending on the selected values / operanda.
        'VR schedules calculate a range between half and 1.5 times the specified schedule value and pick a random value from that range. 
        Randomize()
        Dim Rand As New Random
        RatioGoal(x) = Rand.Next((AC(vCC).ScheduleValue(x) / 2), (AC(vCC).ScheduleValue(x) * 1.5))
    End Sub
    Private Sub FIGen(x) 'This initializes Fixed Interval schedules depending on the selected values / operanda.
        'FI schedules use a timer to check if the specified schedule value has elapsed.
        'Visual Basic manages time in miliseconds, so values are multiplied by 1000.
        If x = 0 Then
            tmrLever1.Interval = AC(vCC).ScheduleValue(0) * 1000
            tmrLever1.Enabled = True
        ElseIf x = 1 Then
            tmrLever2.Interval = AC(vCC).ScheduleValue(1) * 1000
            tmrLever2.Enabled = True
        End If
    End Sub
    Private Sub VIGen(list As Integer) 'This initializes Variable Interval schedules depending on the selected values / operanda.
        'VI schedules employ Hantula's (1991) method for Fleshler & Hoffman's (1968) iterative equation on Visual Basic.
        'This Subroutine takes 'list' as a value to allocate VI iterations on separate data arrays, allowing for concurrent and independent VI schedules.
        'VI values are selected at random from the lists without replacement. 
        Dim v
        Dim n = 10 'This value represents the VI iterations. 
        Dim rd(n)
        Dim vi(n)
        Dim order
        Randomize()
        If list = 0 Then v = AC(vCC).ScheduleValue(0)
        If list = 1 Then v = AC(vCC).ScheduleValue(1)
        If VIList(list).Count = 0 Then
            For m As Integer = 1 To n
                If m = n Then vi(m) = v * (1 + Log(n)) : GoTo 1
                vi(m) = v * (1 + (Log(n)) + (n - m) * (Log(n - m)) - (n - m + 1) * Log(n - m + 1))
1:              order = Int((n * Rnd() + 1))
                If rd(order) = 0 Then
                    rd(order) = vi(m)
                Else
                    GoTo 1
                End If
            Next
            For a As Integer = 1 To n
                VIList(list).Add(rd(a))
            Next
        End If
        Dim Rand As New Random
        Dim p As Integer = Rand.Next(VIList(list).Count)
        If list = 0 Then 'The first list saves VI values for schedules on operanda 1.
            tmrLever1.Interval = (VIList(list).Item(p) + 1) * 1000
            tmrLever1.Enabled = True
        End If
        If list = 1 Then 'The second list saves VI values for schedules on operanda 2.
            tmrLever2.Interval = (VIList(list).Item(p) + 1) * 1000
            tmrLever2.Enabled = True
        End If
        VIList(list).RemoveAt(p)
    End Sub
    Private Sub tmrSchedule1_Tick(sender As Object, e As EventArgs) Handles tmrLever1.Tick 'This keeps track of time for interval schedules on operanda 1.
        tmrLever1.Enabled = False
        refRdy(0) = True
        lblRfR1.Text = refRdy(0)
    End Sub
    Private Sub tmrSchedule2_Tick(sender As Object, e As EventArgs) Handles tmrLever2.Tick 'This keeps track of time for interval schedules on operanda 2.
        tmrLever2.Enabled = False
        refRdy(1) = True
        lblRfR2.Text = refRdy(0)
    End Sub
    Private Sub Finish()
        Arduino.WriteLine("nhtabcd") 'Turns off every output on the Arduino.
        Arduino.Close() 'Terminates Arduino-VB communication.
        For i = 0 To ObtainedDelays.Count - 1
            If ObtainedDelays(0).Count > 1 Then WriteLine(2, "Obtained delays L1: " & ObtainedDelays(0).Item(i))
            If ObtainedDelays(1).Count > 1 Then WriteLine(2, "Obtained delays L2: " & ObtainedDelays(1).Item(i))
        Next
        For i = 1 To 2
            WriteLine(i, "Responses on Lever 1: " & ResponseCount(0))
            WriteLine(i, "Response rate on Lever 1: " & ResponseCount(0) / (lblTime.Text / 60))
            WriteLine(i, "Responses on Lever 2: " & ResponseCount(1))
            WriteLine(i, "Response rate on Lever 2: " & ResponseCount(1) / (lblTime.Text / 60))
            WriteLine(i, "Reinforcers on Lever 1: " & RefCount(0))
            WriteLine(i, "Reinforcer rate on Lever 1: " & RefCount(0) / (lblTime.Text / 60))
            WriteLine(i, "Reinforcers on Lever 2: " & RefCount(1))
            WriteLine(i, "Reinforcer rate on Lever 2: " & RefCount(1) / (lblTime.Text / 60))
            WriteLine(i, "Total time in minutes: " & lblTime.Text / 60)
            WriteLine(i, Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
            WriteLine(i, "END") 'Signals that the session has ended on the data file.
            FileClose(i) 'Closes data file.
        Next
        End
    End Sub
    Private Sub tmrChart_Tick(sender As Object, e As EventArgs) Handles tmrChart.Tick
        For i = 0 To 2
            chartTime(i) += 1
        Next
        Chart1.Series("Lever 1").Points.AddXY(chartTime(0), chartResponse(0))
        Chart1.Series("Lever 2").Points.AddXY(chartTime(1), chartResponse(1))
        Chart1.Series("Tray").Points.AddXY(chartTime(2), chartResponse(2))
        'If chartTime(0) >= 900 Or chartTime(1) >= 900 Or chartTime(2) >= 900 Or ResponseCount(0) >= 200 Or ResponseCount(1) >= 200 Or ResponseCount(2) >= 200 Then
        '    Chart1.SaveImage("C:\Data\Charts\" & SetUp.txtSubject.Text & "_" & SetUp.txtSession.Text & "_chart_" & Format(Date.Now, "hh_mm_ss") & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        '    Chart1.Series("Lever 1").Points.Clear()
        '    Chart1.Series("Reinforcers 1").Points.Clear()
        '    Chart1.Series("Lever 2").Points.Clear()
        '    Chart1.Series("Reinforcers 2").Points.Clear()
        '    Chart1.Series("Tray").Points.Clear()
        '    Chart1.Printing.Print(True)
        '    For i = 0 To 2
        '        chartTime(i) = 0
        '        chartResponse(i) = 0
        '    Next
        'End If
    End Sub
    Private Sub tmrDelay1_Tick(sender As Object, e As EventArgs) Handles tmrDelay1.Tick
        tmrDelay1.Enabled = False
        If AC(vCC).DelayType(0) <> "Unsignaled" Then
            If AC(vCC).DelayType(0).Contains("Light 1") = True Then Arduino.WriteLine("a")
            If AC(vCC).DelayType(0).Contains("Light 2") = True Then Arduino.WriteLine("b")
            If AC(vCC).DelayType(0).Contains("Tone") = True Then Arduino.WriteLine("t")
            If AC(vCC).DelayType(0).Contains("Houselight") = True Then Arduino.WriteLine("h")
        End If
        Reinforce(0, True)
        'aqui va el marcador para calcular la demora obtenida
        ObtainedDelays(0).Item(DelayIndex1) = vTimeNow - ObtainedDelays(0).Item(DelayIndex1)
        DelayIndex1 += 1
    End Sub
    Private Sub tmrDelay2_Tick(sender As Object, e As EventArgs) Handles tmrDelay2.Tick
        tmrDelay2.Enabled = False
        If AC(vCC).DelayType(1) <> "Unsignaled" Then
            If AC(vCC).DelayType(1).Contains("Light 1") = True Then Arduino.WriteLine("a")
            If AC(vCC).DelayType(1).Contains("Light 2") = True Then Arduino.WriteLine("b")
            If AC(vCC).DelayType(1).Contains("Tone") = True Then Arduino.WriteLine("t")
            If AC(vCC).DelayType(1).Contains("Houselight") = True Then Arduino.WriteLine("h")
        End If
        Reinforce(1, True)
        ObtainedDelays(1).Item(DelayIndex2) = vTimeNow - ObtainedDelays(1).Item(DelayIndex2)
        DelayIndex2 += 1
    End Sub
    Private Sub tmrStim1_Tick(sender As Object, e As EventArgs) Handles tmrStim1.Tick
        tmrStim1.Enabled = False
        If AC(vCC).FeedbackType(0).Contains("Light 1") = True Then Arduino.WriteLine("a")
        If AC(vCC).FeedbackType(0).Contains("Light 2") = True Then Arduino.WriteLine("b")
        If AC(vCC).FeedbackType(0).Contains("Tone") = True Then Arduino.WriteLine("t")
        If AC(vCC).FeedbackType(0).Contains("Houselight") = True Then Arduino.WriteLine("h")
    End Sub
    Private Sub tmrStim2_Tick(sender As Object, e As EventArgs) Handles tmrStim2.Tick
        tmrStim2.Enabled = False
        If AC(vCC).FeedbackType(1).Contains("Light 1") = True Then Arduino.WriteLine("a")
        If AC(vCC).FeedbackType(1).Contains("Light 2") = True Then Arduino.WriteLine("b")
        If AC(vCC).FeedbackType(1).Contains("Tone") = True Then Arduino.WriteLine("t")
        If AC(vCC).FeedbackType(1).Contains("Houselight") = True Then Arduino.WriteLine("h")
    End Sub
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'This controls the 'Finish' button on the main form. Used to end the session by hand.
        tmrPostSession.Enabled = True
        btnFinish.Enabled = False
        btnLever1.Enabled = False
        btnLever2.Enabled = False
        btnL1IO.Enabled = False
        btnL2IO.Enabled = False
        btnReinforce.Enabled = False
        Chart1.SaveImage("C:\Data\Charts\" & SetUp.txtSubject.Text & "_" & SetUp.txtSession.Text & "_chart_" & Format(Date.Now, "hh_mm_ss") & ".png", ChartImageFormat.Png)
    End Sub
    Private Sub btnL1IO_Click(sender As Object, e As EventArgs) Handles btnL1IO.Click
        If PalIO(0) = True Then
            PalIO(0) = False
            Arduino.WriteLine("L")
        ElseIf PalIO(0) = False Then
            PalIO(0) = True
            Arduino.WriteLine("l")
        End If
    End Sub
    Private Sub btnL2IO_Click(sender As Object, e As EventArgs) Handles btnL2IO.Click
        If PalIO(1) = True Then
            PalIO(1) = False
            Arduino.WriteLine("M")
        ElseIf PalIO(1) = False Then
            PalIO(1) = True
            Arduino.WriteLine("m")
        End If
    End Sub
    Private Sub btnLever1_Click(sender As Object, e As EventArgs) Handles btnLever1.Click
        Response(0)
    End Sub
    Private Sub btnLever2_Click(sender As Object, e As EventArgs) Handles btnLever2.Click
        Response(1)
    End Sub
    Private Sub btnReinforce_Click(sender As Object, e As EventArgs) Handles btnReinforce.Click
        Reinforce(3, False)
    End Sub
    Private Sub tmrPostSession_Tick(sender As Object, e As EventArgs) Handles tmrPostSession.Tick
        Finish()
    End Sub
    Private Sub tmrNosepoke_Tick(sender As Object, e As EventArgs) Handles tmrNosepoke.Tick
        tmrNosepoke.Enabled = False
    End Sub

    Private Sub tmrComponentDuration_Tick(sender As Object, e As EventArgs) Handles tmrComponentDuration.Tick
        tmrComponentDuration.Enabled = False
        WriteLine(1, vTimeNow, "EndComponent" & vCC)
        If vCC = MAXvCC Then
            vCC = 1
        Else
            vCC += 1
        End If
        BeginPrograms()
    End Sub

    Private Sub tmrComponentStim_Tick(sender As Object, e As EventArgs) Handles tmrComponentStim.Tick
        If StimInt = False Then
            StimInt = True
            If AC(vCC).ComponentStimType.Contains("Light 1") = True Then Arduino.WriteLine("A")
            If AC(vCC).ComponentStimType.Contains("Light 2") = True Then Arduino.WriteLine("B")
            If AC(vCC).ComponentStimType.Contains("Tone") = True Then Arduino.WriteLine("T")
            If AC(vCC).ComponentStimType.Contains("Houselight") = True Then Arduino.WriteLine("H")
        ElseIf StimInt = True Then
            StimInt = False
            If AC(vCC).ComponentStimType.Contains("Light 1") = True Then Arduino.WriteLine("a")
            If AC(vCC).ComponentStimType.Contains("Light 2") = True Then Arduino.WriteLine("b")
            If AC(vCC).ComponentStimType.Contains("Tone") = True Then Arduino.WriteLine("t")
            If AC(vCC).ComponentStimType.Contains("Houselight") = True Then Arduino.WriteLine("h")
        End If
    End Sub


End Class