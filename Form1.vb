Imports MaterialSkin

Public Class Form1

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
    Dim DLLFileName As String
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
ByRef lpThreadId As Integer) As Integer

    Public Declare Function OpenProcess Lib "kernel32" (
ByVal dwDesiredAccess As Integer,
ByVal bInheritHandle As Integer,
ByVal dwProcessId As Integer) As Integer

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
ByVal lpClassName As String,
ByVal lpWindowName As String) As Integer

    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
ByVal hObject As Integer) As Integer




    Dim ExeName As String = IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)

    Private Sub Inject()
        On Error GoTo 1 ' If error occurs, app will close without any error messages
        Timer1.Stop()
        Dim TargetProcess As Process() = Process.GetProcessesByName(TextBox1.Text)
        TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
        pszLibFileRemote = OpenFileDialog1.FileName
        pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
        TargetBufferSize = 1 + Len(pszLibFileRemote)
        Dim Rtn As Integer
        Dim LoadLibParamAdr As Integer
        LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
        Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
        CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0)
        CloseHandle(TargetProcessHandle)
1:      Me.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "DLL (*.dll) |*.dll"
        OpenFileDialog1.ShowDialog()
        Dim FileName As String
        FileName = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\"))
        Dim DllFileName As String = FileName.Replace("\", "")
        Me.TextBox2.Text = (DllFileName)
    End Sub

    Public Sub CheckForUpdates()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.robot-hamster.win/Injector/version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Me.Label10.Text = currentversion
                MessageBox.Show("Doppler injector is up to date!")
            Else
                Me.Label11.Text = newestversion
                MsgBox("There is a new update " + newestversion + " would you like to download it?.", MsgBoxStyle.YesNo, "Injector update!")
                WebBrowser1.Navigate("http://www.mediafire.com/file/x4cko80xg8zelbj/Doppler.exe")
                WebBrowser1.Navigate("")
            End If
        Catch
            MsgBox("There was a error fetching the latest update?.", MsgBoxStyle.OkOnly, "Injector update failed!")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialFlatButton1.Text = "Add Dll"
        Label1.Text = "Waiting for Dll..."
        Timer1.Interval = 50
        Timer1.Start()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IO.File.Exists(OpenFileDialog1.FileName) Then
            Dim TargetProcess As Process() = Process.GetProcessesByName(TextBox1.Text)
            If TargetProcess.Length = 0 Then
                Me.Label1.Text = ("Waiting for " + TextBox1.Text + ".exe")

            Else
                If MaterialCheckBox3.Checked = True Then
                    MaterialFlatButton1.Visible = True
                    MaterialCheckBox6.Checked = False
                End If
                If MaterialCheckBox6.Checked = True Then
                    MaterialFlatButton1.Visible = False
                    Timer1.Stop()
                    Me.Label1.Text = "Successfully Injected!"
                    Call Inject()
                    If MaterialCheckBox1.Checked = True Then
                        End
                    Else
                    End If
                End If
            End If
        Else
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
        TextBox2.Clear()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "EXE (*.exe) |*.exe"
        OpenFileDialog1.ShowDialog()
        Dim FileName As String
        FileName = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\"))
        Dim DllFileName As String = FileName.Replace("\", "")
        Me.TextBox2.Text = (DllFileName)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        TextBox2.Clear()
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Try
            OpenFileDialog1.Filter = "DLL (*.dll) |*.dll"
            OpenFileDialog1.ShowDialog()
            Dim FileName As String
            FileName = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\"))
            Dim DllFileName As String = FileName.Replace("\", "")
            Me.TextBox2.Text = (DllFileName)
        Catch
            MessageBox.Show("No Dll selected!", "Doppler Injector Error!")
        End Try
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        TextBox2.Clear()
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox2.CheckedChanged
        If (TopMost = True) Then
            TopMost = False
        End If
        If (TopMost = False) Then
            TopMost = True
        End If
    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged

    End Sub

    Private Sub MaterialCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox3.CheckedChanged
        If MaterialCheckBox3.Checked = True Then
            MaterialFlatButton4.Show()
        Else
            If MaterialCheckBox3.Checked = False Then
                MaterialFlatButton4.Hide()
            End If
        End If
    End Sub

    Private Sub MaterialFlatButton4_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        Try
            Timer1.Stop()
            Call Inject()
            Me.Label1.Text = "Successfully Injected!"
        Catch
            MessageBox.Show("Error injecting dll into: " + TextBox1.Text, "Doppler Injector Error!")
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MaterialCheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox5.CheckedChanged
        Try
            MaterialCheckBox5.Checked = True
            Process.GetProcessesByName("RobloxPlayerBeta")(0).Kill()
            MaterialCheckBox5.Checked = False
        Catch
            MessageBox.Show("RobloxPlayerBeta.exe has been killed if it was running", "Doppler Injector!")
        End Try
    End Sub

    Private Sub MaterialCheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox6.CheckedChanged
        Timer1.Enabled = True
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        CheckForUpdates()
    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Form2.Show()
    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialCheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox7.CheckedChanged
        If MaterialCheckBox6.Checked = True Then
            TextBox1.Text = ("RobloxPlayerBeta")
            MaterialFlatButton6.Visible = False
            If MaterialCheckBox6.Checked = False Then
                MaterialFlatButton6.Visible = True
            End If
        End If
    End Sub

    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton16_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton16.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton15_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton15.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton8_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton8.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton12_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton12.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton11_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton11.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton14_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton14.Click
        Try
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE)
        Catch
            MessageBox.Show("Error applying the theme selected!", "Doppler Injector Error!")
        End Try
    End Sub

    Private Sub MaterialFlatButton10_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton10.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton9_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton9.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Lime800, Primary.Lime900, Primary.Lime500, Accent.Lime200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton13_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton13.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE)
    End Sub

    Private Sub Label10_Click_1(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    End Sub
End Class
