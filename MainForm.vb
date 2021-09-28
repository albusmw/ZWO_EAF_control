Option Explicit On
Option Strict On
Imports System.ComponentModel

Public Class MainForm

    Private MyPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)

    Private ID As Integer = Integer.MinValue
    Private Position As Integer = Integer.MinValue

    Private MaxStep As Integer = Integer.MinValue
    Private FirmwareVersion As String = String.Empty

    Private ZWOEAF As Ato.cZWOEAF

    Private RequestedPosition As Integer = Integer.MinValue

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        'Check for DLL
        tbLog.Text = String.Empty
        If System.IO.File.Exists(tbDLLPath.Text) = False Then
            LogCall("DLL file <" & tbDLLPath.Text & "> Not found!")
            Exit Sub
        End If

        ZWOEAF = New Ato.cZWOEAF(tbDLLPath.Text)

        LogCall("Calling EAFGetNum")
        Dim Number As Integer = ZWOEAF.EAFGetNum
        LogCall("  -> Found EAF's: " & Number.ValRegIndep)
        If Number = 0 Then Exit Sub

        LogCall("EAFGetID(0)", ZWOEAF.EAFGetID(0, ID))
        LogCall("  -> ID: <" & ID & ">")

        LogCall("EAFOpen(" & ID & ")", ZWOEAF.EAFOpen(ID))

        LogCall("EAFGetFirmwareVersion(0)", ZWOEAF.EAFGetFirmwareVersion(0, FirmwareVersion))
        LogCall("  -> FirmwareVersion: <" & FirmwareVersion & ">")

        LogCall("EAFGetMaxStep", ZWOEAF.EAFGetMaxStep(ID, MaxStep))
        LogCall("  -> " & MaxStep.ValRegIndep)

        tUpdate.Enabled = True

    End Sub

    Private Sub tUpdate_Tick(sender As Object, e As EventArgs) Handles tUpdate.Tick
        Dim Temp As Single = Single.NaN
        Dim Moving As Boolean = True
        Dim HandController As Boolean = True
        ZWOEAF.EAFGetPosition(ID, Position)
        ZWOEAF.EAFGetTemp(ID, Temp)
        ZWOEAF.EAFIsMoving(ID, Moving, HandController)
        If RequestedPosition <> Integer.MinValue Then
            If RequestedPosition <> Position Then
                Dim RetVal As Ato.cZWOEAF.EAF_ERROR_CODE = ZWOEAF.EAFMove(ID, RequestedPosition)
            End If
        End If
        tsslPosition.Text = "Position: " & Position.ValRegIndep
        tsslPosition.Text &= ", Temperature: " & Temp.ValRegIndep & " °C"
        If Moving = True Then tsslPosition.BackColor = Color.Red Else tsslPosition.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control)
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ID <> Integer.MinValue Then ZWOEAF.EAFClose(ID)
    End Sub

    Private Sub btnMoveIn_Click(sender As Object, e As EventArgs) Handles btnMoveIn.Click
        RequestedPosition = Position + CInt(tbStepSize.Text)
    End Sub

    Private Sub btnMoveOut_Click(sender As Object, e As EventArgs) Handles btnMoveOut.Click
        RequestedPosition = Position - CInt(tbStepSize.Text)
    End Sub

    Private Sub LogCall(ByVal FunName As String, ByVal Result As Ato.cZWOEAF.EAF_ERROR_CODE)
        LogCall((FunName).PadRight(25, " "c) & " -> " & Result.ToString.Trim)
    End Sub

    Private Sub LogCall(ByVal Message As String)
        Dim FirstLine As Boolean = False
        If tbLog.Text.Length = 0 Then FirstLine = True
        If Not FirstLine Then Message = System.Environment.NewLine & Message
        tbLog.Text &= Message
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbDLLPath.Text = System.IO.Path.Combine(MyPath, "EAF_focuser.dll")
    End Sub

End Class
