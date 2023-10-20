<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnMoveIn_1 = New System.Windows.Forms.Button()
        Me.tUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnMoveOut_1 = New System.Windows.Forms.Button()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsslPosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbStepSize_1 = New System.Windows.Forms.TextBox()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDLLPath = New System.Windows.Forms.TextBox()
        Me.tbStepSize_2 = New System.Windows.Forms.TextBox()
        Me.btnMoveOut_2 = New System.Windows.Forms.Button()
        Me.btnMoveIn_2 = New System.Windows.Forms.Button()
        Me.btnGoTo = New System.Windows.Forms.Button()
        Me.tsslRequested = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(559, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(91, 20)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open focuser"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnMoveIn_1
        '
        Me.btnMoveIn_1.Location = New System.Drawing.Point(12, 38)
        Me.btnMoveIn_1.Name = "btnMoveIn_1"
        Me.btnMoveIn_1.Size = New System.Drawing.Size(72, 23)
        Me.btnMoveIn_1.TabIndex = 1
        Me.btnMoveIn_1.Text = "Move IN"
        Me.btnMoveIn_1.UseVisualStyleBackColor = True
        '
        'tUpdate
        '
        '
        'btnMoveOut_1
        '
        Me.btnMoveOut_1.Location = New System.Drawing.Point(12, 93)
        Me.btnMoveOut_1.Name = "btnMoveOut_1"
        Me.btnMoveOut_1.Size = New System.Drawing.Size(72, 24)
        Me.btnMoveOut_1.TabIndex = 2
        Me.btnMoveOut_1.Text = "Move OUT"
        Me.btnMoveOut_1.UseVisualStyleBackColor = True
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslPosition, Me.tsslRequested})
        Me.ssMain.Location = New System.Drawing.Point(0, 373)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(662, 22)
        Me.ssMain.TabIndex = 3
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsslPosition
        '
        Me.tsslPosition.Name = "tsslPosition"
        Me.tsslPosition.Size = New System.Drawing.Size(71, 17)
        Me.tsslPosition.Text = "Position: ???"
        '
        'tbStepSize_1
        '
        Me.tbStepSize_1.Location = New System.Drawing.Point(12, 67)
        Me.tbStepSize_1.Name = "tbStepSize_1"
        Me.tbStepSize_1.Size = New System.Drawing.Size(72, 20)
        Me.tbStepSize_1.TabIndex = 4
        Me.tbStepSize_1.Text = "100"
        Me.tbStepSize_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbLog
        '
        Me.tbLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLog.Location = New System.Drawing.Point(12, 123)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLog.Size = New System.Drawing.Size(638, 238)
        Me.tbLog.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DLL path:"
        '
        'tbDLLPath
        '
        Me.tbDLLPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDLLPath.Location = New System.Drawing.Point(72, 12)
        Me.tbDLLPath.Name = "tbDLLPath"
        Me.tbDLLPath.Size = New System.Drawing.Size(481, 20)
        Me.tbDLLPath.TabIndex = 7
        Me.tbDLLPath.Text = "???"
        '
        'tbStepSize_2
        '
        Me.tbStepSize_2.Location = New System.Drawing.Point(90, 67)
        Me.tbStepSize_2.Name = "tbStepSize_2"
        Me.tbStepSize_2.Size = New System.Drawing.Size(72, 20)
        Me.tbStepSize_2.TabIndex = 11
        Me.tbStepSize_2.Text = "1000"
        Me.tbStepSize_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMoveOut_2
        '
        Me.btnMoveOut_2.Location = New System.Drawing.Point(90, 93)
        Me.btnMoveOut_2.Name = "btnMoveOut_2"
        Me.btnMoveOut_2.Size = New System.Drawing.Size(72, 24)
        Me.btnMoveOut_2.TabIndex = 10
        Me.btnMoveOut_2.Text = "Move OUT"
        Me.btnMoveOut_2.UseVisualStyleBackColor = True
        '
        'btnMoveIn_2
        '
        Me.btnMoveIn_2.Location = New System.Drawing.Point(90, 38)
        Me.btnMoveIn_2.Name = "btnMoveIn_2"
        Me.btnMoveIn_2.Size = New System.Drawing.Size(72, 23)
        Me.btnMoveIn_2.TabIndex = 9
        Me.btnMoveIn_2.Text = "Move IN"
        Me.btnMoveIn_2.UseVisualStyleBackColor = True
        '
        'btnGoTo
        '
        Me.btnGoTo.Location = New System.Drawing.Point(168, 38)
        Me.btnGoTo.Name = "btnGoTo"
        Me.btnGoTo.Size = New System.Drawing.Size(72, 79)
        Me.btnGoTo.TabIndex = 12
        Me.btnGoTo.Text = "GoTo"
        Me.btnGoTo.UseVisualStyleBackColor = True
        '
        'tsslRequested
        '
        Me.tsslRequested.Name = "tsslRequested"
        Me.tsslRequested.Size = New System.Drawing.Size(127, 17)
        Me.tsslRequested.Text = "Requestes Position: ---"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 395)
        Me.Controls.Add(Me.btnGoTo)
        Me.Controls.Add(Me.tbStepSize_2)
        Me.Controls.Add(Me.btnMoveOut_2)
        Me.Controls.Add(Me.btnMoveIn_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDLLPath)
        Me.Controls.Add(Me.tbLog)
        Me.Controls.Add(Me.tbStepSize_1)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.btnMoveOut_1)
        Me.Controls.Add(Me.btnMoveIn_1)
        Me.Controls.Add(Me.btnOpen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "ZWO_EAF_control Version 1.1.0"
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents btnMoveIn_1 As Button
    Friend WithEvents tUpdate As Timer
    Friend WithEvents btnMoveOut_1 As Button
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tsslPosition As ToolStripStatusLabel
    Friend WithEvents tbStepSize_1 As TextBox
    Friend WithEvents tbLog As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDLLPath As TextBox
    Friend WithEvents tbStepSize_2 As TextBox
    Friend WithEvents btnMoveOut_2 As Button
    Friend WithEvents btnMoveIn_2 As Button
    Friend WithEvents btnGoTo As Button
    Friend WithEvents tsslRequested As ToolStripStatusLabel
End Class
