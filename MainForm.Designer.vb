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
        Me.btnMoveIn = New System.Windows.Forms.Button()
        Me.tUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnMoveOut = New System.Windows.Forms.Button()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsslPosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbStepSize = New System.Windows.Forms.TextBox()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDLLPath = New System.Windows.Forms.TextBox()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 39)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(126, 70)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open focuser"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnMoveIn
        '
        Me.btnMoveIn.Location = New System.Drawing.Point(144, 39)
        Me.btnMoveIn.Name = "btnMoveIn"
        Me.btnMoveIn.Size = New System.Drawing.Size(84, 34)
        Me.btnMoveIn.TabIndex = 1
        Me.btnMoveIn.Text = "Move IN"
        Me.btnMoveIn.UseVisualStyleBackColor = True
        '
        'tUpdate
        '
        '
        'btnMoveOut
        '
        Me.btnMoveOut.Location = New System.Drawing.Point(144, 80)
        Me.btnMoveOut.Name = "btnMoveOut"
        Me.btnMoveOut.Size = New System.Drawing.Size(84, 30)
        Me.btnMoveOut.TabIndex = 2
        Me.btnMoveOut.Text = "Move OUT"
        Me.btnMoveOut.UseVisualStyleBackColor = True
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslPosition})
        Me.ssMain.Location = New System.Drawing.Point(0, 373)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(570, 22)
        Me.ssMain.TabIndex = 3
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsslPosition
        '
        Me.tsslPosition.Name = "tsslPosition"
        Me.tsslPosition.Size = New System.Drawing.Size(71, 17)
        Me.tsslPosition.Text = "Position: ???"
        '
        'tbStepSize
        '
        Me.tbStepSize.Location = New System.Drawing.Point(277, 65)
        Me.tbStepSize.Name = "tbStepSize"
        Me.tbStepSize.Size = New System.Drawing.Size(66, 20)
        Me.tbStepSize.TabIndex = 4
        Me.tbStepSize.Text = "100"
        Me.tbStepSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbLog
        '
        Me.tbLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLog.Location = New System.Drawing.Point(12, 116)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLog.Size = New System.Drawing.Size(546, 245)
        Me.tbLog.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Steps:"
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
        Me.tbDLLPath.Size = New System.Drawing.Size(486, 20)
        Me.tbDLLPath.TabIndex = 7
        Me.tbDLLPath.Text = "100"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 395)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDLLPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLog)
        Me.Controls.Add(Me.tbStepSize)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.btnMoveOut)
        Me.Controls.Add(Me.btnMoveIn)
        Me.Controls.Add(Me.btnOpen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "ZWO_EAF_control Version 1.0.0"
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents btnMoveIn As Button
    Friend WithEvents tUpdate As Timer
    Friend WithEvents btnMoveOut As Button
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tsslPosition As ToolStripStatusLabel
    Friend WithEvents tbStepSize As TextBox
    Friend WithEvents tbLog As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDLLPath As TextBox
End Class
