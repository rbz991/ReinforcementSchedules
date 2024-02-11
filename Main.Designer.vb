<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tmrLever1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLever2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSujeto = New System.Windows.Forms.Label()
        Me.lblSesion = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lblCOM = New System.Windows.Forms.Label()
        Me.lblL2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblL1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResponses1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResponses2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblReinforcers1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblReinforcers2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblRfR1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRfR2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrChart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelay1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelay2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStim1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStim2 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnL2IO = New System.Windows.Forms.Button()
        Me.btnL1IO = New System.Windows.Forms.Button()
        Me.btnReinforce = New System.Windows.Forms.Button()
        Me.btnLever2 = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnLever1 = New System.Windows.Forms.Button()
        Me.tmrPostSession = New System.Windows.Forms.Timer(Me.components)
        Me.lblDelayR1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDelayR2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTrayRs = New System.Windows.Forms.Label()
        Me.tmrNosepoke = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponentDuration = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponentStim = New System.Windows.Forms.Timer(Me.components)
        Me.bgwArduinoVB = New System.ComponentModel.BackgroundWorker()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrLever1
        '
        '
        'tmrLever2
        '
        '
        'lblSujeto
        '
        Me.lblSujeto.AutoSize = True
        Me.lblSujeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSujeto.Location = New System.Drawing.Point(8, 4)
        Me.lblSujeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(132, 37)
        Me.lblSujeto.TabIndex = 6
        Me.lblSujeto.Text = "Subject:"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSesion.Location = New System.Drawing.Point(8, 40)
        Me.lblSesion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(139, 37)
        Me.lblSesion.TabIndex = 7
        Me.lblSesion.Text = "Session:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(157, 4)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(35, 37)
        Me.lblSubject.TabIndex = 8
        Me.lblSubject.Text = "0"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(157, 40)
        Me.lblSession.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(35, 37)
        Me.lblSession.TabIndex = 9
        Me.lblSession.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(8, 77)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(85, 37)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "Port:"
        '
        'lblCOM
        '
        Me.lblCOM.AutoSize = True
        Me.lblCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOM.Location = New System.Drawing.Point(157, 77)
        Me.lblCOM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCOM.Name = "lblCOM"
        Me.lblCOM.Size = New System.Drawing.Size(35, 37)
        Me.lblCOM.TabIndex = 11
        Me.lblCOM.Text = "0"
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL2.Location = New System.Drawing.Point(903, 4)
        Me.lblL2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(79, 37)
        Me.lblL2.TabIndex = 15
        Me.lblL2.Text = "EXT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(694, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lever 2:"
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL1.Location = New System.Drawing.Point(508, 4)
        Me.lblL1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(79, 37)
        Me.lblL1.TabIndex = 13
        Me.lblL1.Text = "EXT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Lever 1:"
        '
        'lblResponses1
        '
        Me.lblResponses1.AutoSize = True
        Me.lblResponses1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponses1.Location = New System.Drawing.Point(508, 40)
        Me.lblResponses1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResponses1.Name = "lblResponses1"
        Me.lblResponses1.Size = New System.Drawing.Size(35, 37)
        Me.lblResponses1.TabIndex = 17
        Me.lblResponses1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Responses:"
        '
        'lblResponses2
        '
        Me.lblResponses2.AutoSize = True
        Me.lblResponses2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponses2.Location = New System.Drawing.Point(903, 40)
        Me.lblResponses2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResponses2.Name = "lblResponses2"
        Me.lblResponses2.Size = New System.Drawing.Size(35, 37)
        Me.lblResponses2.TabIndex = 19
        Me.lblResponses2.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(694, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Responses:"
        '
        'lblReinforcers1
        '
        Me.lblReinforcers1.AutoSize = True
        Me.lblReinforcers1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReinforcers1.Location = New System.Drawing.Point(508, 113)
        Me.lblReinforcers1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReinforcers1.Name = "lblReinforcers1"
        Me.lblReinforcers1.Size = New System.Drawing.Size(35, 37)
        Me.lblReinforcers1.TabIndex = 21
        Me.lblReinforcers1.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 37)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Reinforcers:"
        '
        'lblReinforcers2
        '
        Me.lblReinforcers2.AutoSize = True
        Me.lblReinforcers2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReinforcers2.Location = New System.Drawing.Point(903, 113)
        Me.lblReinforcers2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReinforcers2.Name = "lblReinforcers2"
        Me.lblReinforcers2.Size = New System.Drawing.Size(35, 37)
        Me.lblReinforcers2.TabIndex = 23
        Me.lblReinforcers2.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(694, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 37)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Reinforcers:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(157, 113)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(35, 37)
        Me.lblTime.TabIndex = 25
        Me.lblTime.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 37)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Time:"
        '
        'lblRfR1
        '
        Me.lblRfR1.AutoSize = True
        Me.lblRfR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfR1.Location = New System.Drawing.Point(508, 149)
        Me.lblRfR1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRfR1.Name = "lblRfR1"
        Me.lblRfR1.Size = New System.Drawing.Size(35, 37)
        Me.lblRfR1.TabIndex = 27
        Me.lblRfR1.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(312, 149)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 37)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Rf Ready:"
        '
        'lblRfR2
        '
        Me.lblRfR2.AutoSize = True
        Me.lblRfR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfR2.Location = New System.Drawing.Point(903, 149)
        Me.lblRfR2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRfR2.Name = "lblRfR2"
        Me.lblRfR2.Size = New System.Drawing.Size(35, 37)
        Me.lblRfR2.TabIndex = 29
        Me.lblRfR2.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(694, 149)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 37)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Rf Ready:"
        '
        'tmrStart
        '
        '
        'tmrChart
        '
        Me.tmrChart.Interval = 1000
        '
        'tmrDelay1
        '
        Me.tmrDelay1.Interval = 1000
        '
        'tmrDelay2
        '
        Me.tmrDelay2.Interval = 1000
        '
        'tmrStim1
        '
        Me.tmrStim1.Interval = 1000
        '
        'tmrStim2
        '
        Me.tmrStim2.Interval = 1000
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Bisque
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-41, 190)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series1.Color = System.Drawing.Color.Black
        Series1.Legend = "Legend1"
        Series1.Name = "Lever 1"
        Series2.BorderColor = System.Drawing.Color.Black
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Color = System.Drawing.Color.Black
        Series2.Legend = "Legend1"
        Series2.MarkerSize = 4
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Reinforcers 1"
        Series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series3.Color = System.Drawing.Color.Black
        Series3.Legend = "Legend1"
        Series3.Name = "Lever 2"
        Series4.BorderColor = System.Drawing.Color.Black
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Color = System.Drawing.Color.White
        Series4.Legend = "Legend1"
        Series4.MarkerSize = 4
        Series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series4.Name = "Reinforcers 2"
        Series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series5.Color = System.Drawing.Color.Black
        Series5.Legend = "Legend1"
        Series5.Name = "Tray"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(1159, 433)
        Me.Chart1.TabIndex = 32
        '
        'btnL2IO
        '
        Me.btnL2IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL2IO.Location = New System.Drawing.Point(928, 379)
        Me.btnL2IO.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnL2IO.Name = "btnL2IO"
        Me.btnL2IO.Size = New System.Drawing.Size(160, 58)
        Me.btnL2IO.TabIndex = 42
        Me.btnL2IO.Text = "L 2 I/O"
        Me.btnL2IO.UseVisualStyleBackColor = True
        '
        'btnL1IO
        '
        Me.btnL1IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL1IO.Location = New System.Drawing.Point(760, 379)
        Me.btnL1IO.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnL1IO.Name = "btnL1IO"
        Me.btnL1IO.Size = New System.Drawing.Size(160, 58)
        Me.btnL1IO.TabIndex = 41
        Me.btnL1IO.Text = "L 1 I/O"
        Me.btnL1IO.UseVisualStyleBackColor = True
        '
        'btnReinforce
        '
        Me.btnReinforce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinforce.Location = New System.Drawing.Point(760, 502)
        Me.btnReinforce.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnReinforce.Name = "btnReinforce"
        Me.btnReinforce.Size = New System.Drawing.Size(328, 54)
        Me.btnReinforce.TabIndex = 40
        Me.btnReinforce.Text = "Reinforce"
        Me.btnReinforce.UseVisualStyleBackColor = True
        '
        'btnLever2
        '
        Me.btnLever2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLever2.Location = New System.Drawing.Point(928, 440)
        Me.btnLever2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnLever2.Name = "btnLever2"
        Me.btnLever2.Size = New System.Drawing.Size(160, 58)
        Me.btnLever2.TabIndex = 39
        Me.btnLever2.Text = "Lever 2"
        Me.btnLever2.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(760, 559)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(328, 54)
        Me.btnFinish.TabIndex = 37
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnLever1
        '
        Me.btnLever1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLever1.Location = New System.Drawing.Point(760, 440)
        Me.btnLever1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnLever1.Name = "btnLever1"
        Me.btnLever1.Size = New System.Drawing.Size(160, 58)
        Me.btnLever1.TabIndex = 38
        Me.btnLever1.Text = "Lever 1"
        Me.btnLever1.UseVisualStyleBackColor = True
        '
        'tmrPostSession
        '
        Me.tmrPostSession.Interval = 10000
        '
        'lblDelayR1
        '
        Me.lblDelayR1.AutoSize = True
        Me.lblDelayR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelayR1.Location = New System.Drawing.Point(508, 77)
        Me.lblDelayR1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelayR1.Name = "lblDelayR1"
        Me.lblDelayR1.Size = New System.Drawing.Size(35, 37)
        Me.lblDelayR1.TabIndex = 44
        Me.lblDelayR1.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 77)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 37)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Delay Rs:"
        '
        'lblDelayR2
        '
        Me.lblDelayR2.AutoSize = True
        Me.lblDelayR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelayR2.Location = New System.Drawing.Point(903, 77)
        Me.lblDelayR2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelayR2.Name = "lblDelayR2"
        Me.lblDelayR2.Size = New System.Drawing.Size(35, 37)
        Me.lblDelayR2.TabIndex = 46
        Me.lblDelayR2.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(694, 77)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 37)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Delay Rs:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 149)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 37)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Tray Rs:"
        '
        'lblTrayRs
        '
        Me.lblTrayRs.AutoSize = True
        Me.lblTrayRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrayRs.Location = New System.Drawing.Point(157, 149)
        Me.lblTrayRs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTrayRs.Name = "lblTrayRs"
        Me.lblTrayRs.Size = New System.Drawing.Size(35, 37)
        Me.lblTrayRs.TabIndex = 48
        Me.lblTrayRs.Text = "0"
        '
        'tmrNosepoke
        '
        '
        'tmrComponentDuration
        '
        '
        'tmrComponentStim
        '
        '
        'bgwArduinoVB
        '
        Me.bgwArduinoVB.WorkerReportsProgress = True
        Me.bgwArduinoVB.WorkerSupportsCancellation = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 630)
        Me.Controls.Add(Me.lblTrayRs)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblDelayR2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblDelayR1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnL2IO)
        Me.Controls.Add(Me.btnL1IO)
        Me.Controls.Add(Me.btnReinforce)
        Me.Controls.Add(Me.btnLever2)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnLever1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lblRfR2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblRfR1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblReinforcers2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblReinforcers1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblResponses2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblResponses1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblL2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblL1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCOM)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblSujeto)
        Me.Controls.Add(Me.lblSesion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Main"
        Me.Text = "Form2"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrLever1 As Timer
    Friend WithEvents tmrLever2 As Timer
    Friend WithEvents lblSujeto As Label
    Friend WithEvents lblSesion As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblSession As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lblCOM As Label
    Friend WithEvents lblL2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblL1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResponses1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResponses2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblReinforcers1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblReinforcers2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRfR1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblRfR2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tmrStart As Timer
    Friend WithEvents tmrChart As Timer
    Friend WithEvents tmrDelay1 As Timer
    Friend WithEvents tmrDelay2 As Timer
    Friend WithEvents tmrStim1 As Timer
    Friend WithEvents tmrStim2 As Timer
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnL2IO As Button
    Friend WithEvents btnL1IO As Button
    Friend WithEvents btnReinforce As Button
    Friend WithEvents btnLever2 As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnLever1 As Button
    Friend WithEvents tmrPostSession As Timer
    Friend WithEvents lblDelayR1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDelayR2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTrayRs As Label
    Friend WithEvents tmrNosepoke As Timer
    Friend WithEvents tmrComponentDuration As Timer
    Friend WithEvents tmrComponentStim As Timer
    Friend WithEvents bgwArduinoVB As System.ComponentModel.BackgroundWorker
End Class
