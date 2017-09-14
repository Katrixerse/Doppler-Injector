<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaterialFlatButton6 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialFlatButton10 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton16 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton15 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton14 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton13 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton12 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton11 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton9 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton8 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton7 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialCheckBox7 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaterialCheckBox6 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox5 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox4 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox3 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaterialFlatButton5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.FilterIndex = 2
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(90, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "None"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-2, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(723, 40)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(-12, 100)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(589, 260)
        Me.MaterialTabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.MaterialFlatButton6)
        Me.TabPage1.Controls.Add(Me.MaterialFlatButton4)
        Me.TabPage1.Controls.Add(Me.MaterialFlatButton3)
        Me.TabPage1.Controls.Add(Me.MaterialFlatButton2)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.MaterialLabel2)
        Me.TabPage1.Controls.Add(Me.MaterialFlatButton1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.MaterialLabel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(581, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Injector"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(111, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(299, 19)
        Me.TextBox1.TabIndex = 35
        '
        'MaterialFlatButton6
        '
        Me.MaterialFlatButton6.AutoSize = True
        Me.MaterialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton6.Depth = 0
        Me.MaterialFlatButton6.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton6.Icon = Nothing
        Me.MaterialFlatButton6.Location = New System.Drawing.Point(426, 15)
        Me.MaterialFlatButton6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton6.Name = "MaterialFlatButton6"
        Me.MaterialFlatButton6.Primary = False
        Me.MaterialFlatButton6.Size = New System.Drawing.Size(133, 36)
        Me.MaterialFlatButton6.TabIndex = 34
        Me.MaterialFlatButton6.Text = "Select process"
        Me.MaterialFlatButton6.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton4.Icon = Nothing
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(426, 146)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(95, 36)
        Me.MaterialFlatButton4.TabIndex = 31
        Me.MaterialFlatButton4.Text = "Inject dll"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = False
        Me.MaterialFlatButton4.Visible = False
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton3.Icon = Nothing
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(426, 109)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(126, 36)
        Me.MaterialFlatButton3.TabIndex = 30
        Me.MaterialFlatButton3.Text = "Clear Process"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(426, 76)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(103, 36)
        Me.MaterialFlatButton2.TabIndex = 29
        Me.MaterialFlatButton2.Text = "Remove Dll"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(111, 56)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(299, 126)
        Me.TextBox2.TabIndex = 27
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(38, 22)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MaterialLabel2.TabIndex = 0
        Me.MaterialLabel2.Text = "Process:"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(426, 45)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(75, 36)
        Me.MaterialFlatButton1.TabIndex = 23
        Me.MaterialFlatButton1.Text = "Add Dll"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(157, -19)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(94, 19)
        Me.MaterialLabel1.TabIndex = 24
        Me.MaterialLabel1.Text = "Lynx Injector"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(38, 53)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(67, 19)
        Me.MaterialLabel3.TabIndex = 28
        Me.MaterialLabel3.Text = "DLLS:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton10)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton16)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton15)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton14)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton13)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton12)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton11)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton9)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton8)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton7)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox7)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox6)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox5)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox4)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox3)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox2)
        Me.TabPage2.Controls.Add(Me.MaterialCheckBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(581, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        '
        'MaterialFlatButton10
        '
        Me.MaterialFlatButton10.AutoSize = True
        Me.MaterialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton10.Depth = 0
        Me.MaterialFlatButton10.Icon = Nothing
        Me.MaterialFlatButton10.Location = New System.Drawing.Point(441, 149)
        Me.MaterialFlatButton10.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton10.Name = "MaterialFlatButton10"
        Me.MaterialFlatButton10.Primary = False
        Me.MaterialFlatButton10.Size = New System.Drawing.Size(101, 36)
        Me.MaterialFlatButton10.TabIndex = 52
        Me.MaterialFlatButton10.Text = "PINK Theme"
        Me.MaterialFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton10.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton16
        '
        Me.MaterialFlatButton16.AutoSize = True
        Me.MaterialFlatButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton16.Depth = 0
        Me.MaterialFlatButton16.Icon = Nothing
        Me.MaterialFlatButton16.Location = New System.Drawing.Point(307, 37)
        Me.MaterialFlatButton16.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton16.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton16.Name = "MaterialFlatButton16"
        Me.MaterialFlatButton16.Primary = False
        Me.MaterialFlatButton16.Size = New System.Drawing.Size(103, 36)
        Me.MaterialFlatButton16.TabIndex = 51
        Me.MaterialFlatButton16.Text = "Blue Theme"
        Me.MaterialFlatButton16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton16.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton15
        '
        Me.MaterialFlatButton15.AutoSize = True
        Me.MaterialFlatButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton15.Depth = 0
        Me.MaterialFlatButton15.Icon = Nothing
        Me.MaterialFlatButton15.Location = New System.Drawing.Point(307, 71)
        Me.MaterialFlatButton15.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton15.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton15.Name = "MaterialFlatButton15"
        Me.MaterialFlatButton15.Primary = False
        Me.MaterialFlatButton15.Size = New System.Drawing.Size(120, 36)
        Me.MaterialFlatButton15.TabIndex = 50
        Me.MaterialFlatButton15.Text = "PURPLE Theme"
        Me.MaterialFlatButton15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton15.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton14
        '
        Me.MaterialFlatButton14.AutoSize = True
        Me.MaterialFlatButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton14.Depth = 0
        Me.MaterialFlatButton14.Icon = Nothing
        Me.MaterialFlatButton14.Location = New System.Drawing.Point(308, 110)
        Me.MaterialFlatButton14.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton14.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton14.Name = "MaterialFlatButton14"
        Me.MaterialFlatButton14.Primary = False
        Me.MaterialFlatButton14.Size = New System.Drawing.Size(123, 36)
        Me.MaterialFlatButton14.TabIndex = 49
        Me.MaterialFlatButton14.Text = "Yellow Theme"
        Me.MaterialFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton14.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton13
        '
        Me.MaterialFlatButton13.AutoSize = True
        Me.MaterialFlatButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton13.Depth = 0
        Me.MaterialFlatButton13.Icon = Nothing
        Me.MaterialFlatButton13.Location = New System.Drawing.Point(307, 183)
        Me.MaterialFlatButton13.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton13.Name = "MaterialFlatButton13"
        Me.MaterialFlatButton13.Primary = False
        Me.MaterialFlatButton13.Size = New System.Drawing.Size(115, 36)
        Me.MaterialFlatButton13.TabIndex = 48
        Me.MaterialFlatButton13.Text = "INDIGO Theme"
        Me.MaterialFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton13.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton12
        '
        Me.MaterialFlatButton12.AutoSize = True
        Me.MaterialFlatButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton12.Depth = 0
        Me.MaterialFlatButton12.Icon = Nothing
        Me.MaterialFlatButton12.Location = New System.Drawing.Point(441, 183)
        Me.MaterialFlatButton12.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton12.Name = "MaterialFlatButton12"
        Me.MaterialFlatButton12.Primary = False
        Me.MaterialFlatButton12.Size = New System.Drawing.Size(106, 36)
        Me.MaterialFlatButton12.TabIndex = 47
        Me.MaterialFlatButton12.Text = "CYAN Theme"
        Me.MaterialFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton12.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton11
        '
        Me.MaterialFlatButton11.AutoSize = True
        Me.MaterialFlatButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton11.Depth = 0
        Me.MaterialFlatButton11.Icon = Nothing
        Me.MaterialFlatButton11.Location = New System.Drawing.Point(308, 149)
        Me.MaterialFlatButton11.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton11.Name = "MaterialFlatButton11"
        Me.MaterialFlatButton11.Primary = False
        Me.MaterialFlatButton11.Size = New System.Drawing.Size(124, 36)
        Me.MaterialFlatButton11.TabIndex = 47
        Me.MaterialFlatButton11.Text = "ORANGE Theme"
        Me.MaterialFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton11.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton9
        '
        Me.MaterialFlatButton9.AutoSize = True
        Me.MaterialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton9.Depth = 0
        Me.MaterialFlatButton9.Icon = Nothing
        Me.MaterialFlatButton9.Location = New System.Drawing.Point(440, 110)
        Me.MaterialFlatButton9.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton9.Name = "MaterialFlatButton9"
        Me.MaterialFlatButton9.Primary = False
        Me.MaterialFlatButton9.Size = New System.Drawing.Size(101, 36)
        Me.MaterialFlatButton9.TabIndex = 45
        Me.MaterialFlatButton9.Text = "LIME THEME"
        Me.MaterialFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton9.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton8
        '
        Me.MaterialFlatButton8.AutoSize = True
        Me.MaterialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton8.Depth = 0
        Me.MaterialFlatButton8.Icon = Nothing
        Me.MaterialFlatButton8.Location = New System.Drawing.Point(441, 71)
        Me.MaterialFlatButton8.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton8.Name = "MaterialFlatButton8"
        Me.MaterialFlatButton8.Primary = False
        Me.MaterialFlatButton8.Size = New System.Drawing.Size(113, 36)
        Me.MaterialFlatButton8.TabIndex = 44
        Me.MaterialFlatButton8.Text = "GREEN Theme"
        Me.MaterialFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton8.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton7
        '
        Me.MaterialFlatButton7.AutoSize = True
        Me.MaterialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton7.Depth = 0
        Me.MaterialFlatButton7.Icon = Nothing
        Me.MaterialFlatButton7.Location = New System.Drawing.Point(441, 35)
        Me.MaterialFlatButton7.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton7.Name = "MaterialFlatButton7"
        Me.MaterialFlatButton7.Primary = False
        Me.MaterialFlatButton7.Size = New System.Drawing.Size(95, 36)
        Me.MaterialFlatButton7.TabIndex = 43
        Me.MaterialFlatButton7.Text = "Red Theme"
        Me.MaterialFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton7.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox7
        '
        Me.MaterialCheckBox7.AutoSize = True
        Me.MaterialCheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.MaterialCheckBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialCheckBox7.Depth = 0
        Me.MaterialCheckBox7.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox7.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialCheckBox7.Location = New System.Drawing.Point(27, 135)
        Me.MaterialCheckBox7.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox7.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox7.Name = "MaterialCheckBox7"
        Me.MaterialCheckBox7.Ripple = True
        Me.MaterialCheckBox7.Size = New System.Drawing.Size(111, 30)
        Me.MaterialCheckBox7.TabIndex = 42
        Me.MaterialCheckBox7.Text = "Roblox Mode"
        Me.MaterialCheckBox7.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 33)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Themes:"
        '
        'MaterialCheckBox6
        '
        Me.MaterialCheckBox6.AutoSize = True
        Me.MaterialCheckBox6.Checked = True
        Me.MaterialCheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaterialCheckBox6.Depth = 0
        Me.MaterialCheckBox6.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox6.Location = New System.Drawing.Point(27, 11)
        Me.MaterialCheckBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox6.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox6.Name = "MaterialCheckBox6"
        Me.MaterialCheckBox6.Ripple = True
        Me.MaterialCheckBox6.Size = New System.Drawing.Size(116, 30)
        Me.MaterialCheckBox6.TabIndex = 28
        Me.MaterialCheckBox6.Text = "Auto Injection"
        Me.MaterialCheckBox6.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox5
        '
        Me.MaterialCheckBox5.AutoSize = True
        Me.MaterialCheckBox5.Depth = 0
        Me.MaterialCheckBox5.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox5.Location = New System.Drawing.Point(27, 165)
        Me.MaterialCheckBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox5.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox5.Name = "MaterialCheckBox5"
        Me.MaterialCheckBox5.Ripple = True
        Me.MaterialCheckBox5.Size = New System.Drawing.Size(162, 30)
        Me.MaterialCheckBox5.TabIndex = 27
        Me.MaterialCheckBox5.Text = "Kill RobloxPlayerBeta"
        Me.MaterialCheckBox5.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox4
        '
        Me.MaterialCheckBox4.AutoSize = True
        Me.MaterialCheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialCheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialCheckBox4.Depth = 0
        Me.MaterialCheckBox4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox4.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialCheckBox4.Location = New System.Drawing.Point(27, 195)
        Me.MaterialCheckBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox4.Name = "MaterialCheckBox4"
        Me.MaterialCheckBox4.Ripple = True
        Me.MaterialCheckBox4.Size = New System.Drawing.Size(241, 30)
        Me.MaterialCheckBox4.TabIndex = 26
        Me.MaterialCheckBox4.Text = "Compact Version (comming soon)"
        Me.MaterialCheckBox4.UseVisualStyleBackColor = False
        Me.MaterialCheckBox4.Visible = False
        '
        'MaterialCheckBox3
        '
        Me.MaterialCheckBox3.AutoSize = True
        Me.MaterialCheckBox3.Depth = 0
        Me.MaterialCheckBox3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox3.Location = New System.Drawing.Point(27, 41)
        Me.MaterialCheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox3.Name = "MaterialCheckBox3"
        Me.MaterialCheckBox3.Ripple = True
        Me.MaterialCheckBox3.Size = New System.Drawing.Size(132, 30)
        Me.MaterialCheckBox3.TabIndex = 25
        Me.MaterialCheckBox3.Text = "Manual Injection"
        Me.MaterialCheckBox3.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox2
        '
        Me.MaterialCheckBox2.AutoSize = True
        Me.MaterialCheckBox2.Depth = 0
        Me.MaterialCheckBox2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox2.Location = New System.Drawing.Point(27, 101)
        Me.MaterialCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox2.Name = "MaterialCheckBox2"
        Me.MaterialCheckBox2.Ripple = True
        Me.MaterialCheckBox2.Size = New System.Drawing.Size(105, 30)
        Me.MaterialCheckBox2.TabIndex = 24
        Me.MaterialCheckBox2.Text = "Stay On Top"
        Me.MaterialCheckBox2.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(27, 71)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(155, 30)
        Me.MaterialCheckBox1.TabIndex = 23
        Me.MaterialCheckBox1.Text = "Close After Injection"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(581, 234)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Credits"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(34, 126)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(240, 104)
        Me.TextBox5.TabIndex = 23
        Me.TextBox5.Text = "◾Doppler Injector v0.1, A Great Injector with a simple gui made easy to use. Crea" &
    "ted By Doppler#3837 (head dev)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Gabriola", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(379, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 48)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Help:"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(300, 126)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 104)
        Me.TextBox6.TabIndex = 21
        Me.TextBox6.Text = resources.GetString("TextBox6.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gabriola", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 65)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "About:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gabriola", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 88)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Created by: Doppler#3837"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.MaterialFlatButton5)
        Me.TabPage4.Controls.Add(Me.WebBrowser1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(581, 234)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "UPDATE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(403, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "NaN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "1.0.0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "NEWEST:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "CURRENT:"
        '
        'MaterialFlatButton5
        '
        Me.MaterialFlatButton5.AutoSize = True
        Me.MaterialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton5.Depth = 0
        Me.MaterialFlatButton5.ForeColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton5.Icon = Nothing
        Me.MaterialFlatButton5.Location = New System.Drawing.Point(230, 81)
        Me.MaterialFlatButton5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton5.Name = "MaterialFlatButton5"
        Me.MaterialFlatButton5.Primary = False
        Me.MaterialFlatButton5.Size = New System.Drawing.Size(119, 36)
        Me.MaterialFlatButton5.TabIndex = 32
        Me.MaterialFlatButton5.Text = "Update check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MaterialFlatButton5.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(472, 182)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(103, 20)
        Me.WebBrowser1.TabIndex = 33
        Me.WebBrowser1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(571, 336)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Sizable = False
        Me.Text = "Doppler Injector v0.1"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialCheckBox6 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox5 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox4 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox3 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox2 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents MaterialFlatButton6 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaterialCheckBox7 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialFlatButton7 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton16 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton15 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton14 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton13 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton12 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton11 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton10 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton9 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton8 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
End Class
