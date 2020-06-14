Imports System.Media
Imports System.Threading.Thread
Imports System.IO
Imports System.Net

Public Class Succes_Form1
    Private Sub Succes_Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If (CInt(Process.GetProcessesByName("League of Legends").Length) <> 0) Then
            For Each CLOSE As Process In Process.GetProcessesByName("League of Legends")
                CLOSE.CloseMainWindow()
                CLOSE.Kill()
            Next
        End If
    End Sub

    Private Sub Succes_Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (CInt(Process.GetProcessesByName("League of Legends").Length) <> 0) Then
            For Each CLOSE As Process In Process.GetProcessesByName("League of Legends")
                CLOSE.CloseMainWindow()
                CLOSE.Kill()
            Next
        End If
    End Sub

    Private Sub Timer_Hook_Tick(sender As Object, e As EventArgs) Handles Timer_Hook.Tick
        If (CInt(Process.GetProcessesByName("League of Legends").Length) <> 0) Then
            ''' DLL ACCEPT '''
            WritePointerInteger(Form_Inject1.Text_Client.Text, &H6B47A0, "63816", &H2D8)
        Else
            Timer_Hook.Stop()
            MsgBox("The game is closed. Inject again.", MsgBoxStyle.Critical, "Error")
            Me.Hide()
            Form_Inject1.Show()
        End If
    End Sub

    Private Sub Succes_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_Hook.Start()
    End Sub
End Class