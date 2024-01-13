Module Module1
    Public vFile As String = ""
    Public vFile2 As String = ""
    Public Lever1 As String = ""
    Public Lever2 As String = ""
    Public vTimeStart As Integer
    Public vTimeNow As Integer
    Public DelayIndex1 As Integer
    Public DelayIndex2 As Integer
    Public Actual_Response(4) As String
    Public Previous_Response(4) As String
    Public RefCount(1) As Integer
    Public refRdy(1) As Boolean
    Public VIList(1) As List(Of Integer)
    Public ObtainedDelays(1) As List(Of Integer)
    Public RatioCount(1) As Integer
    Public RatioGoal(1) As Integer
    Public ResponseCount(1) As Integer
    Public NosepokeCount(2) As Integer
    Public chartTime(1) As Integer
    Public chartResponse(1) As Integer
    Public vCurrentComponentSetup As Integer
    Public PalIO(1) As Boolean
    Public ActiveComponent(4) As ComponentBlueprint
    Public Structure ComponentBlueprint
        Dim ComponentDuration As Integer
        Dim ComponentStimDuration As Integer
        Dim ComponentStimType As String
        Dim ScheduleType() As String
        Dim ScheduleValue() As Integer
        Dim Magnitude() As Integer
        Dim FeedbackDuration() As Integer
        Dim FeedbackType() As String
        Dim DelayDuration() As Integer
        Dim DelayType() As String
    End Structure





End Module
