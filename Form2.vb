Imports MaterialSkin

Public Class Form2
    Public Sub Refreshlist() 'Refresh processlist
        ListBox1.Items.Clear() 'Clear listbox1 items
        ListBox2.Items.Clear() 'Clear listbox1 items
        For Each Proc As Process In Process.GetProcesses 'Get list of processes
            ListBox1.Items.Add(Proc.ProcessName) 'Add process name to listbox1 item
            ListBox2.Items.Add(Proc.Id)
        Next
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refreshlist() 'Refresh processlist sub

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex 'Set listbox2 selected item to listbox1 selected item
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Refreshlist()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Try 'Get rid of errors
            Form1.TextBox1.Clear()
            For Each Item As Object In ListBox1.SelectedItems
                Form1.TextBox1.AppendText(Item.ToString)
                Me.Close()
            Next
        Catch ex As Exception 'Get rid of errors
        End Try 'Get rid of errors
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Refreshlist()
    End Sub
End Class