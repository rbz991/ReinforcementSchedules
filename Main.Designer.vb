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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrChart = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tmrDelay1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelay2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStim1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStim2 = New System.Windows.Forms.Timer(Me.components)
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
        Me.lblSujeto.Location = New System.Drawing.Point(12, 9)
        Me.lblSujeto.Name = "lblSujeto"
        Me.lblSujeto.Size = New System.Drawing.Size(67, 20)
        Me.lblSujeto.TabIndex = 6
        Me.lblSujeto.Text = "Subject:"
        '
        'lblSesion
        '
        Me.lblSesion.AutoSize = True
        Me.lblSesion.Location = New System.Drawing.Point(12, 29)
        Me.lblSesion.Name = "lblSesion"
        Me.lblSesion.Size = New System.Drawing.Size(70, 20)
        Me.lblSesion.TabIndex = 7
        Me.lblSesion.Text = "Session:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(86, 9)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(18, 20)
        Me.lblSubject.TabIndex = 8
        Me.lblSubject.Text = "0"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Location = New System.Drawing.Point(86, 29)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(18, 20)
        Me.lblSession.TabIndex = 9
        Me.lblSession.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(12, 49)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(42, 20)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "Port:"
        '
        'lblCOM
        '
        Me.lblCOM.AutoSize = True
        Me.lblCOM.Location = New System.Drawing.Point(86, 49)
        Me.lblCOM.Name = "lblCOM"
        Me.lblCOM.Size = New System.Drawing.Size(18, 20)
        Me.lblCOM.TabIndex = 11
        Me.lblCOM.Text = "0"
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.Location = New System.Drawing.Point(466, 9)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(40, 20)
        Me.lblL2.TabIndex = 15
        Me.lblL2.Text = "EXT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lever 2:"
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.Location = New System.Drawing.Point(274, 9)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(40, 20)
        Me.lblL1.TabIndex = 13
        Me.lblL1.Text = "EXT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Lever 1:"
        '
        'lblResponses1
        '
        Me.lblResponses1.AutoSize = True
        Me.lblResponses1.Location = New System.Drawing.Point(274, 29)
        Me.lblResponses1.Name = "lblResponses1"
        Me.lblResponses1.Size = New System.Drawing.Size(18, 20)
        Me.lblResponses1.TabIndex = 17
        Me.lblResponses1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Responses:"
        '
        'lblResponses2
        '
        Me.lblResponses2.AutoSize = True
        Me.lblResponses2.Location = New System.Drawing.Point(466, 29)
        Me.lblResponses2.Name = "lblResponses2"
        Me.lblResponses2.Size = New System.Drawing.Size(18, 20)
        Me.lblResponses2.TabIndex = 19
        Me.lblResponses2.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Responses:"
        '
        'lblReinforcers1
        '
        Me.lblReinforcers1.AutoSize = True
        Me.lblReinforcers1.Location = New System.Drawing.Point(274, 49)
        Me.lblReinforcers1.Name = "lblReinforcers1"
        Me.lblReinforcers1.Size = New System.Drawing.Size(18, 20)
        Me.lblReinforcers1.TabIndex = 21
        Me.lblReinforcers1.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(181, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Reinforcers:"
        '
        'lblReinforcers2
        '
        Me.lblReinforcers2.AutoSize = True
        Me.lblReinforcers2.Location = New System.Drawing.Point(466, 49)
        Me.lblReinforcers2.Name = "lblReinforcers2"
        Me.lblReinforcers2.Size = New System.Drawing.Size(18, 20)
        Me.lblReinforcers2.TabIndex = 23
        Me.lblReinforcers2.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(374, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Reinforcers:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(86, 69)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(18, 20)
        Me.lblTime.TabIndex = 25
        Me.lblTime.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Time:"
        '
        'lblRfR1
        '
        Me.lblRfR1.AutoSize = True
        Me.lblRfR1.Location = New System.Drawing.Point(274, 69)
        Me.lblRfR1.Name = "lblRfR1"
        Me.lblRfR1.Size = New System.Drawing.Size(18, 20)
        Me.lblRfR1.TabIndex = 27
        Me.lblRfR1.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(181, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Rf Ready:"
        '
        'lblRfR2
        '
        Me.lblRfR2.AutoSize = True
        Me.lblRfR2.Location = New System.Drawing.Point(466, 69)
        Me.lblRfR2.Name = "lblRfR2"
        Me.lblRfR2.Size = New System.Drawing.Size(18, 20)
        Me.lblRfR2.TabIndex = 29
        Me.lblRfR2.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(374, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Rf Ready:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 85)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tmrStart
        '
        '
        'tmrChart
        '
        Me.tmrChart.Interval = 1000
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisX.Maximum = 900.0R
        ChartArea4.AxisX.Minimum = 0R
        ChartArea4.AxisX2.TitleForeColor = System.Drawing.Color.Bisque
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisY.Maximum = 200.0R
        ChartArea4.AxisY.Minimum = 0R
        ChartArea4.BackSecondaryColor = System.Drawing.Color.White
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(12, 120)
        Me.Chart1.Name = "Chart1"
        Series13.ChartArea = "ChartArea1"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series13.Legend = "Legend1"
        Series13.Name = "Lever 1"
        Series14.ChartArea = "ChartArea1"
        Series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series14.Legend = "Legend1"
        Series14.Name = "Reinforcers 1"
        Series15.ChartArea = "ChartArea1"
        Series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine
        Series15.Legend = "Legend1"
        Series15.Name = "Lever 2"
        Series16.ChartArea = "ChartArea1"
        Series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series16.Legend = "Legend1"
        Series16.Name = "Reinforcers 2"
        Me.Chart1.Series.Add(Series13)
        Me.Chart1.Series.Add(Series14)
        Me.Chart1.Series.Add(Series15)
        Me.Chart1.Series.Add(Series16)
        Me.Chart1.Size = New System.Drawing.Size(680, 320)
        Me.Chart1.TabIndex = 31
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 442)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrStart As Timer
    Friend WithEvents tmrChart As Timer
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents tmrDelay1 As Timer
    Friend WithEvents tmrDelay2 As Timer
    Friend WithEvents tmrStim1 As Timer
    Friend WithEvents tmrStim2 As Timer
End Class
