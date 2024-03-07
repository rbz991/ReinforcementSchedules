Module Module1
    Public TestsPerformed As Boolean
    Public CODL As Byte
    Public CompIndex As Byte = 10
    Public chartFlag(1) As Boolean
    Public ICIcounter As Integer
    Public vFile As String = ""
    Public vFile2 As String = ""
    Public Lever1 As String = ""
    Public Lever2 As String = ""
    Public vTimeStart As Integer
    Public vTimeNow As Integer
    Public DelayIndex(1) As Integer
    'Public DelayIndex2 As Integer
    Public Countdown As Integer
    Public Actual_Response(4) As String
    Public Previous_Response(4) As String
    Public RefCount(4, 1) As Integer
    Public refRdy(1) As Boolean
    Public VIList(1) As List(Of Integer)
    Public ObtainedDelays(1) As List(Of Integer)
    Public RatioCount(1) As Integer
    Public RatioGoal(1) As Integer
    Public ResponseCount(4, 1) As Integer
    Public ResponseCountDel(4, 1) As Integer
    Public NosepokeCount(2) As Integer
    Public NosepokeCountDel(2) As Integer
    Public chartTime(3) As Integer
    Public chartResponse(3) As Integer
    Public vPadding As Integer
    Public PreviewCounter As Integer
    Public StimInt As Boolean
    Public vCC As Byte 'vCurrentComponent - contador
    Public MAXvCC As Byte
    Public RandomCPres As Boolean
    Public PreviousComp(1) As Byte
    Public ComponentsDepleted As Boolean
    Public PalIO(1) As Boolean
    Public CompList As List(Of Integer)
    Public AC(4) As ComponentBlueprint ' ActualComponent
    Public Structure ComponentBlueprint
        Dim HouselightOnOff As Boolean
        Dim COD As Double
        Dim MaxRefs As Integer
        Dim ComponentDuration As Integer
        Dim ComponentIteration As Byte
        Dim ComponentStimDuration As Double
        Dim ComponentStimType As String
        Dim ScheduleType() As String
        Dim ScheduleValue() As Integer
        Dim Magnitude() As Integer
        Dim Reinforcer() As String
        Dim PelletP() As Integer
        Dim FeedbackDuration() As Integer
        Dim FeedbackType() As String
        Dim DelayDuration() As Integer
        Dim DelayType() As String
        Dim IterationsLeft As Byte
    End Structure





End Module
