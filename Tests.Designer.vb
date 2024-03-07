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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFeeder = New System.Windows.Forms.Button()
        Me.btnPump = New System.Windows.Forms.Button()
        Me.btnPumpOff = New System.Windows.Forms.Button()
        Me.btnPumpOn = New System.Windows.Forms.Button()
        Me.btnLeverLeft = New System.Windows.Forms.Button()
        Me.btnLeverRight = New System.Windows.Forms.Button()
        Me.btnLights = New System.Windows.Forms.Button()
        Me.btnTone = New System.Windows.Forms.Button()
        Me.tmrStart = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 256)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(156, 55)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFeeder
        '
        Me.btnFeeder.Location = New System.Drawing.Point(12, 12)
        Me.btnFeeder.Name = "btnFeeder"
        Me.btnFeeder.Size = New System.Drawing.Size(75, 55)
        Me.btnFeeder.TabIndex = 1
        Me.btnFeeder.Text = "Feeder"
        Me.btnFeeder.UseVisualStyleBackColor = True
        '
        'btnPump
        '
        Me.btnPump.Location = New System.Drawing.Point(12, 73)
        Me.btnPump.Name = "btnPump"
        Me.btnPump.Size = New System.Drawing.Size(75, 55)
        Me.btnPump.TabIndex = 2
        Me.btnPump.Text = "Pump "
        Me.btnPump.UseVisualStyleBackColor = True
        '
        'btnPumpOff
        '
        Me.btnPumpOff.Location = New System.Drawing.Point(12, 195)
        Me.btnPumpOff.Name = "btnPumpOff"
        Me.btnPumpOff.Size = New System.Drawing.Size(75, 55)
        Me.btnPumpOff.TabIndex = 3
        Me.btnPumpOff.Text = "Pump OFF"
        Me.btnPumpOff.UseVisualStyleBackColor = True
        '
        'btnPumpOn
        '
        Me.btnPumpOn.Location = New System.Drawing.Point(12, 134)
        Me.btnPumpOn.Name = "btnPumpOn"
        Me.btnPumpOn.Size = New System.Drawing.Size(75, 55)
        Me.btnPumpOn.TabIndex = 4
        Me.btnPumpOn.Text = "Pump ON"
        Me.btnPumpOn.UseVisualStyleBackColor = True
        '
        'btnLeverLeft
        '
        Me.btnLeverLeft.Location = New System.Drawing.Point(93, 12)
        Me.btnLeverLeft.Name = "btnLeverLeft"
        Me.btnLeverLeft.Size = New System.Drawing.Size(75, 55)
        Me.btnLeverLeft.TabIndex = 5
        Me.btnLeverLeft.Text = "Lever Left"
        Me.btnLeverLeft.UseVisualStyleBackColor = True
        '
        'btnLeverRight
        '
        Me.btnLeverRight.Location = New System.Drawing.Point(93, 73)
        Me.btnLeverRight.Name = "btnLeverRight"
        Me.btnLeverRight.Size = New System.Drawing.Size(75, 55)
        Me.btnLeverRight.TabIndex = 6
        Me.btnLeverRight.Text = "Lever Right"
        Me.btnLeverRight.UseVisualStyleBackColor = True
        '
        'btnLights
        '
        Me.btnLights.Location = New System.Drawing.Point(93, 134)
        Me.btnLights.Name = "btnLights"
        Me.btnLights.Size = New System.Drawing.Size(75, 55)
        Me.btnLights.TabIndex = 7
        Me.btnLights.Text = "Lights"
        Me.btnLights.UseVisualStyleBackColor = True
        '
        'btnTone
        '
        Me.btnTone.Location = New System.Drawing.Point(93, 195)
        Me.btnTone.Name = "btnTone"
        Me.btnTone.Size = New System.Drawing.Size(75, 55)
        Me.btnTone.TabIndex = 8
        Me.btnTone.Text = "Tone"
        Me.btnTone.UseVisualStyleBackColor = True
        '
        'tmrStart
        '
        Me.tmrStart.Enabled = True
        '
        'Tests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 324)
        Me.Controls.Add(Me.btnTone)
        Me.Controls.Add(Me.btnLights)
        Me.Controls.Add(Me.btnLeverRight)
        Me.Controls.Add(Me.btnLeverLeft)
        Me.Controls.Add(Me.btnPumpOn)
        Me.Controls.Add(Me.btnPumpOff)
        Me.Controls.Add(Me.btnPump)
        Me.Controls.Add(Me.btnFeeder)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Tests"
        Me.Text = "Tests"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnFeeder As Button
    Friend WithEvents btnPump As Button
    Friend WithEvents btnPumpOff As Button
    Friend WithEvents btnPumpOn As Button
    Friend WithEvents btnLeverLeft As Button
    Friend WithEvents btnLeverRight As Button
    Friend WithEvents btnLights As Button
    Friend WithEvents btnTone As Button
    Friend WithEvents tmrStart As Timer
End Class
