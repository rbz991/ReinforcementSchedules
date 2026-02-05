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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series25 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series26 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series27 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.lblResponses2 = New System.Windows.Forms.Label()
        Me.lblReinforcers1 = New System.Windows.Forms.Label()
        Me.lblReinforcers2 = New System.Windows.Forms.Label()
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
        Me.lblTrayRs = New System.Windows.Forms.Label()
        Me.tmrNosepoke = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponentDuration = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponentStim = New System.Windows.Forms.Timer(Me.components)
        Me.lblActiveComponent = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblComponentDuration = New System.Windows.Forms.Label()
        Me.lblComponentStim = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIterationsLeft = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tmrICI = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCOD = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelaySignal1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelaySignal2 = New System.Windows.Forms.Timer(Me.components)
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
        Me.lblSujeto.Location = New System.Drawing.Point(4, 2)
        Me.lblSujeto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(67, 20)
        Me.lblSujeto.TabIndex = 6
        Me.lblSujeto.Text = "Subject:"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSesion.Location = New System.Drawing.Point(4, 21)
        Me.lblSesion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(70, 20)
        Me.lblSesion.TabIndex = 7
        Me.lblSesion.Text = "Session:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(97, 2)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(18, 20)
        Me.lblSubject.TabIndex = 8
        Me.lblSubject.Text = "0"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(97, 21)
        Me.lblSession.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(18, 20)
        Me.lblSession.TabIndex = 9
        Me.lblSession.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(4, 40)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(42, 20)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "Port:"
        '
        'lblCOM
        '
        Me.lblCOM.AutoSize = True
        Me.lblCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOM.Location = New System.Drawing.Point(97, 40)
        Me.lblCOM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCOM.Name = "lblCOM"
        Me.lblCOM.Size = New System.Drawing.Size(18, 20)
        Me.lblCOM.TabIndex = 11
        Me.lblCOM.Text = "0"
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL2.Location = New System.Drawing.Point(557, 43)
        Me.lblL2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(40, 20)
        Me.lblL2.TabIndex = 15
        Me.lblL2.Text = "EXT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lever 2:"
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL1.Location = New System.Drawing.Point(557, 5)
        Me.lblL1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(40, 20)
        Me.lblL1.TabIndex = 13
        Me.lblL1.Text = "EXT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(459, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Lever 1:"
        '
        'lblResponses1
        '
        Me.lblResponses1.AutoSize = True
        Me.lblResponses1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponses1.Location = New System.Drawing.Point(583, 98)
        Me.lblResponses1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResponses1.Name = "lblResponses1"
        Me.lblResponses1.Size = New System.Drawing.Size(16, 17)
        Me.lblResponses1.TabIndex = 17
        Me.lblResponses1.Text = "0"
        '
        'lblResponses2
        '
        Me.lblResponses2.AutoSize = True
        Me.lblResponses2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponses2.Location = New System.Drawing.Point(583, 131)
        Me.lblResponses2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResponses2.Name = "lblResponses2"
        Me.lblResponses2.Size = New System.Drawing.Size(16, 17)
        Me.lblResponses2.TabIndex = 19
        Me.lblResponses2.Text = "0"
        '
        'lblReinforcers1
        '
        Me.lblReinforcers1.AutoSize = True
        Me.lblReinforcers1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReinforcers1.Location = New System.Drawing.Point(583, 114)
        Me.lblReinforcers1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReinforcers1.Name = "lblReinforcers1"
        Me.lblReinforcers1.Size = New System.Drawing.Size(16, 17)
        Me.lblReinforcers1.TabIndex = 21
        Me.lblReinforcers1.Text = "0"
        '
        'lblReinforcers2
        '
        Me.lblReinforcers2.AutoSize = True
        Me.lblReinforcers2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReinforcers2.Location = New System.Drawing.Point(583, 149)
        Me.lblReinforcers2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReinforcers2.Name = "lblReinforcers2"
        Me.lblReinforcers2.Size = New System.Drawing.Size(16, 17)
        Me.lblReinforcers2.TabIndex = 23
        Me.lblReinforcers2.Text = "0"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(97, 59)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(18, 20)
        Me.lblTime.TabIndex = 25
        Me.lblTime.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 59)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Time:"
        '
        'lblRfR1
        '
        Me.lblRfR1.AutoSize = True
        Me.lblRfR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfR1.Location = New System.Drawing.Point(557, 24)
        Me.lblRfR1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRfR1.Name = "lblRfR1"
        Me.lblRfR1.Size = New System.Drawing.Size(18, 20)
        Me.lblRfR1.TabIndex = 27
        Me.lblRfR1.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(459, 24)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Rf Ready:"
        '
        'lblRfR2
        '
        Me.lblRfR2.AutoSize = True
        Me.lblRfR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfR2.Location = New System.Drawing.Point(557, 62)
        Me.lblRfR2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRfR2.Name = "lblRfR2"
        Me.lblRfR2.Size = New System.Drawing.Size(18, 20)
        Me.lblRfR2.TabIndex = 29
        Me.lblRfR2.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(459, 62)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
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
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea3.AxisX2.TitleForeColor = System.Drawing.Color.Bisque
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea3.BackSecondaryColor = System.Drawing.Color.White
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Legend3.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(-21, 84)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chart1.Name = "Chart1"
        Series19.ChartArea = "ChartArea1"
        Series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series19.Color = System.Drawing.Color.Black
        Series19.Legend = "Legend1"
        Series19.Name = "Lever 1"
        Series20.BorderColor = System.Drawing.Color.Black
        Series20.ChartArea = "ChartArea1"
        Series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series20.Color = System.Drawing.Color.Black
        Series20.Legend = "Legend1"
        Series20.MarkerBorderColor = System.Drawing.Color.White
        Series20.MarkerColor = System.Drawing.Color.Black
        Series20.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
        Series20.Name = "Reinforcers 1"
        Series21.ChartArea = "ChartArea1"
        Series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series21.Color = System.Drawing.Color.DeepSkyBlue
        Series21.Legend = "Legend1"
        Series21.Name = "Lever 2"
        Series22.BorderColor = System.Drawing.Color.Black
        Series22.ChartArea = "ChartArea1"
        Series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series22.Color = System.Drawing.Color.White
        Series22.Legend = "Legend1"
        Series22.MarkerBorderColor = System.Drawing.Color.White
        Series22.MarkerColor = System.Drawing.Color.Silver
        Series22.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
        Series22.Name = "Reinforcers 2"
        Series23.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        Series23.ChartArea = "ChartArea1"
        Series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series23.Color = System.Drawing.Color.Lime
        Series23.Legend = "Legend1"
        Series23.Name = "Tray"
        Series24.ChartArea = "ChartArea1"
        Series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series24.Color = System.Drawing.Color.Blue
        Series24.Legend = "Legend1"
        Series24.Name = "Component 1"
        Series25.ChartArea = "ChartArea1"
        Series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series25.Color = System.Drawing.Color.Red
        Series25.Legend = "Legend1"
        Series25.Name = "Component 2"
        Series25.YValuesPerPoint = 2
        Series26.ChartArea = "ChartArea1"
        Series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series26.Color = System.Drawing.Color.Yellow
        Series26.Legend = "Legend1"
        Series26.Name = "Component 3"
        Series27.ChartArea = "ChartArea1"
        Series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series27.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series27.Legend = "Legend1"
        Series27.Name = "Component 4"
        Me.Chart1.Series.Add(Series19)
        Me.Chart1.Series.Add(Series20)
        Me.Chart1.Series.Add(Series21)
        Me.Chart1.Series.Add(Series22)
        Me.Chart1.Series.Add(Series23)
        Me.Chart1.Series.Add(Series24)
        Me.Chart1.Series.Add(Series25)
        Me.Chart1.Series.Add(Series26)
        Me.Chart1.Series.Add(Series27)
        Me.Chart1.Size = New System.Drawing.Size(626, 196)
        Me.Chart1.TabIndex = 32
        '
        'btnL2IO
        '
        Me.btnL2IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL2IO.Location = New System.Drawing.Point(691, 153)
        Me.btnL2IO.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnL2IO.Name = "btnL2IO"
        Me.btnL2IO.Size = New System.Drawing.Size(80, 30)
        Me.btnL2IO.TabIndex = 42
        Me.btnL2IO.Text = "L 2 I/O"
        Me.btnL2IO.UseVisualStyleBackColor = True
        '
        'btnL1IO
        '
        Me.btnL1IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL1IO.Location = New System.Drawing.Point(607, 153)
        Me.btnL1IO.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnL1IO.Name = "btnL1IO"
        Me.btnL1IO.Size = New System.Drawing.Size(80, 30)
        Me.btnL1IO.TabIndex = 41
        Me.btnL1IO.Text = "L 1 I/O"
        Me.btnL1IO.UseVisualStyleBackColor = True
        '
        'btnReinforce
        '
        Me.btnReinforce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinforce.Location = New System.Drawing.Point(607, 217)
        Me.btnReinforce.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnReinforce.Name = "btnReinforce"
        Me.btnReinforce.Size = New System.Drawing.Size(164, 28)
        Me.btnReinforce.TabIndex = 40
        Me.btnReinforce.Text = "Reinforce"
        Me.btnReinforce.UseVisualStyleBackColor = True
        '
        'btnLever2
        '
        Me.btnLever2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLever2.Location = New System.Drawing.Point(691, 185)
        Me.btnLever2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnLever2.Name = "btnLever2"
        Me.btnLever2.Size = New System.Drawing.Size(80, 30)
        Me.btnLever2.TabIndex = 39
        Me.btnLever2.Text = "Lever 2"
        Me.btnLever2.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(607, 246)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(164, 28)
        Me.btnFinish.TabIndex = 37
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnLever1
        '
        Me.btnLever1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLever1.Location = New System.Drawing.Point(607, 185)
        Me.btnLever1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnLever1.Name = "btnLever1"
        Me.btnLever1.Size = New System.Drawing.Size(80, 30)
        Me.btnLever1.TabIndex = 38
        Me.btnLever1.Text = "Lever 1"
        Me.btnLever1.UseVisualStyleBackColor = True
        '
        'tmrPostSession
        '
        Me.tmrPostSession.Interval = 10000
        '
        'lblTrayRs
        '
        Me.lblTrayRs.AutoSize = True
        Me.lblTrayRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrayRs.Location = New System.Drawing.Point(583, 166)
        Me.lblTrayRs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTrayRs.Name = "lblTrayRs"
        Me.lblTrayRs.Size = New System.Drawing.Size(16, 17)
        Me.lblTrayRs.TabIndex = 48
        Me.lblTrayRs.Text = "0"
        '
        'tmrNosepoke
        '
        Me.tmrNosepoke.Interval = 150
        '
        'tmrComponentDuration
        '
        '
        'tmrComponentStim
        '
        '
        'lblActiveComponent
        '
        Me.lblActiveComponent.AutoSize = True
        Me.lblActiveComponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveComponent.Location = New System.Drawing.Point(357, 2)
        Me.lblActiveComponent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActiveComponent.Name = "lblActiveComponent"
        Me.lblActiveComponent.Size = New System.Drawing.Size(18, 20)
        Me.lblActiveComponent.TabIndex = 50
        Me.lblActiveComponent.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(193, 2)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Current Component:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Component Duration:"
        '
        'lblComponentDuration
        '
        Me.lblComponentDuration.AutoSize = True
        Me.lblComponentDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponentDuration.Location = New System.Drawing.Point(357, 21)
        Me.lblComponentDuration.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComponentDuration.Name = "lblComponentDuration"
        Me.lblComponentDuration.Size = New System.Drawing.Size(18, 20)
        Me.lblComponentDuration.TabIndex = 52
        Me.lblComponentDuration.Text = "0"
        '
        'lblComponentStim
        '
        Me.lblComponentStim.AutoSize = True
        Me.lblComponentStim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponentStim.Location = New System.Drawing.Point(357, 40)
        Me.lblComponentStim.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComponentStim.Name = "lblComponentStim"
        Me.lblComponentStim.Size = New System.Drawing.Size(18, 20)
        Me.lblComponentStim.TabIndex = 54
        Me.lblComponentStim.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Component Stim:"
        '
        'lblIterationsLeft
        '
        Me.lblIterationsLeft.AutoSize = True
        Me.lblIterationsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIterationsLeft.Location = New System.Drawing.Point(357, 59)
        Me.lblIterationsLeft.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIterationsLeft.Name = "lblIterationsLeft"
        Me.lblIterationsLeft.Size = New System.Drawing.Size(18, 20)
        Me.lblIterationsLeft.TabIndex = 56
        Me.lblIterationsLeft.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(193, 59)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Iterations Left:"
        '
        'tmrICI
        '
        '
        'tmrCOD
        '
        '
        'tmrDelaySignal1
        '
        Me.tmrDelaySignal1.Interval = 1000
        '
        'tmrDelaySignal2
        '
        Me.tmrDelaySignal2.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(778, 280)
        Me.Controls.Add(Me.lblIterationsLeft)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblComponentStim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblComponentDuration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblReinforcers2)
        Me.Controls.Add(Me.lblReinforcers1)
        Me.Controls.Add(Me.lblResponses2)
        Me.Controls.Add(Me.lblResponses1)
        Me.Controls.Add(Me.lblActiveComponent)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTrayRs)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
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
    Friend WithEvents lblResponses2 As Label
    Friend WithEvents lblReinforcers1 As Label
    Friend WithEvents lblReinforcers2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblRfR1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblRfR2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tmrStart As Timer
    Friend WithEvents tmrChart As Timer
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
    Friend WithEvents lblTrayRs As Label
    Friend WithEvents tmrNosepoke As Timer
    Friend WithEvents tmrComponentDuration As Timer
    Friend WithEvents tmrComponentStim As Timer
    Friend WithEvents lblActiveComponent As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblComponentDuration As Label
    Friend WithEvents lblComponentStim As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblIterationsLeft As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tmrICI As Timer
    Friend WithEvents tmrDelay1 As Timer
    Friend WithEvents tmrDelay2 As Timer
    Friend WithEvents tmrCOD As Timer
    Friend WithEvents tmrDelaySignal1 As Timer
    Friend WithEvents tmrDelaySignal2 As Timer
End Class
