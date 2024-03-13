<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tests
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFeeder = New System.Windows.Forms.Button()
        Me.btnPumpOn = New System.Windows.Forms.Button()
        Me.btnLeverLeft = New System.Windows.Forms.Button()
        Me.btnLeverRight = New System.Windows.Forms.Button()
        Me.btnLights = New System.Windows.Forms.Button()
        Me.btnTone = New System.Windows.Forms.Button()
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(13, 558)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(230, 80)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFeeder
        '
        Me.btnFeeder.Location = New System.Drawing.Point(13, 378)
        Me.btnFeeder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFeeder.Name = "btnFeeder"
        Me.btnFeeder.Size = New System.Drawing.Size(230, 80)
        Me.btnFeeder.TabIndex = 1
        Me.btnFeeder.Text = "Feeder"
        Me.btnFeeder.UseVisualStyleBackColor = True
        '
        'btnPumpOn
        '
        Me.btnPumpOn.Location = New System.Drawing.Point(13, 468)
        Me.btnPumpOn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPumpOn.Name = "btnPumpOn"
        Me.btnPumpOn.Size = New System.Drawing.Size(230, 80)
        Me.btnPumpOn.TabIndex = 4
        Me.btnPumpOn.Text = "Pump"
        Me.btnPumpOn.UseVisualStyleBackColor = True
        '
        'btnLeverLeft
        '
        Me.btnLeverLeft.Location = New System.Drawing.Point(13, 198)
        Me.btnLeverLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeverLeft.Name = "btnLeverLeft"
        Me.btnLeverLeft.Size = New System.Drawing.Size(230, 80)
        Me.btnLeverLeft.TabIndex = 5
        Me.btnLeverLeft.Text = "Lever Left"
        Me.btnLeverLeft.UseVisualStyleBackColor = True
        '
        'btnLeverRight
        '
        Me.btnLeverRight.Location = New System.Drawing.Point(13, 288)
        Me.btnLeverRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeverRight.Name = "btnLeverRight"
        Me.btnLeverRight.Size = New System.Drawing.Size(230, 80)
        Me.btnLeverRight.TabIndex = 6
        Me.btnLeverRight.Text = "Lever Right"
        Me.btnLeverRight.UseVisualStyleBackColor = True
        '
        'btnLights
        '
        Me.btnLights.Location = New System.Drawing.Point(13, 18)
        Me.btnLights.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLights.Name = "btnLights"
        Me.btnLights.Size = New System.Drawing.Size(230, 80)
        Me.btnLights.TabIndex = 7
        Me.btnLights.Text = "Lights"
        Me.btnLights.UseVisualStyleBackColor = True
        '
        'btnTone
        '
        Me.btnTone.Location = New System.Drawing.Point(13, 108)
        Me.btnTone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTone.Name = "btnTone"
        Me.btnTone.Size = New System.Drawing.Size(230, 80)
        Me.btnTone.TabIndex = 8
        Me.btnTone.Text = "Tone"
        Me.btnTone.UseVisualStyleBackColor = True
        '
        'tmrStart
        '
        Me.tmrStart.Enabled = True
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
        Me.Chart1.Location = New System.Drawing.Point(263, 18)
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
        Series2.MarkerBorderColor = System.Drawing.Color.White
        Series2.MarkerColor = System.Drawing.Color.Black
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
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
        Series4.MarkerBorderColor = System.Drawing.Color.White
        Series4.MarkerColor = System.Drawing.Color.Silver
        Series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
        Series4.Name = "Reinforcers 2"
        Series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series5.Color = System.Drawing.Color.Lime
        Series5.Legend = "Legend1"
        Series5.Name = "Tray"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series6.Color = System.Drawing.Color.Blue
        Series6.Legend = "Legend1"
        Series6.Name = "Component 1"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series7.Color = System.Drawing.Color.Red
        Series7.Legend = "Legend1"
        Series7.Name = "Component 2"
        Series7.YValuesPerPoint = 2
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series8.Color = System.Drawing.Color.Yellow
        Series8.Legend = "Legend1"
        Series8.Name = "Component 3"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series9.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series9.Legend = "Legend1"
        Series9.Name = "Component 4"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Series.Add(Series9)
        Me.Chart1.Size = New System.Drawing.Size(832, 620)
        Me.Chart1.TabIndex = 33
        '
        'Tests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 655)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.btnTone)
        Me.Controls.Add(Me.btnLights)
        Me.Controls.Add(Me.btnLeverRight)
        Me.Controls.Add(Me.btnLeverLeft)
        Me.Controls.Add(Me.btnPumpOn)
        Me.Controls.Add(Me.btnFeeder)
        Me.Controls.Add(Me.btnClose)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Tests"
        Me.Text = "Tests"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnFeeder As Button
    Friend WithEvents btnPumpOn As Button
    Friend WithEvents btnLeverLeft As Button
    Friend WithEvents btnLeverRight As Button
    Friend WithEvents btnLights As Button
    Friend WithEvents btnTone As Button
    Friend WithEvents tmrStart As Timer
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
