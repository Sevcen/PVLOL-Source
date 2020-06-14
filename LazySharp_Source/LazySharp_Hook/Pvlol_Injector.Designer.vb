<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Inject1
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
        Dim Bloom2 As LazySharp_Hook.Bloom = New LazySharp_Hook.Bloom()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Inject1))
        Me.Inject_Auto = New System.Windows.Forms.Timer(Me.components)
        Me.Inject_Manual = New System.Windows.Forms.Timer(Me.components)
        Me.Export = New System.Windows.Forms.Timer(Me.components)
        Me.Form_Inject2 = New LazySharp_Hook.BeyondTheme()
        Me.Text_Status = New System.Windows.Forms.TextBox()
        Me.Text_Client = New System.Windows.Forms.TextBox()
        Me.Buton_Close = New System.Windows.Forms.Button()
        Me.Buton_Manuel = New System.Windows.Forms.RadioButton()
        Me.Buton_Auto = New System.Windows.Forms.RadioButton()
        Me.Label_ExeName = New System.Windows.Forms.Label()
        Me.Label_Wait = New System.Windows.Forms.Label()
        Me.Buton_Inject = New LazySharp_Hook.BeyondButton2()
        Me.Text_Select = New System.Windows.Forms.TextBox()
        Me.Form_Inject2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inject_Auto
        '
        '
        'Inject_Manual
        '
        '
        'Export
        '
        Me.Export.Enabled = True
        '
        'Form_Inject2
        '
        Me.Form_Inject2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Bloom1.Name = "BackColor"
        Bloom1.Value = System.Drawing.Color.White
        Me.Form_Inject2.Colors = New LazySharp_Hook.Bloom() {Bloom1}
        Me.Form_Inject2.Controls.Add(Me.Text_Select)
        Me.Form_Inject2.Controls.Add(Me.Text_Status)
        Me.Form_Inject2.Controls.Add(Me.Text_Client)
        Me.Form_Inject2.Controls.Add(Me.Buton_Close)
        Me.Form_Inject2.Controls.Add(Me.Buton_Manuel)
        Me.Form_Inject2.Controls.Add(Me.Buton_Auto)
        Me.Form_Inject2.Controls.Add(Me.Label_ExeName)
        Me.Form_Inject2.Controls.Add(Me.Label_Wait)
        Me.Form_Inject2.Controls.Add(Me.Buton_Inject)
        Me.Form_Inject2.Customization = "/////w=="
        Me.Form_Inject2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Form_Inject2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Form_Inject2.Image = Nothing
        Me.Form_Inject2.Location = New System.Drawing.Point(0, 0)
        Me.Form_Inject2.Movable = True
        Me.Form_Inject2.Name = "Form_Inject2"
        Me.Form_Inject2.NoRounding = False
        Me.Form_Inject2.Sizable = True
        Me.Form_Inject2.Size = New System.Drawing.Size(291, 178)
        Me.Form_Inject2.TabIndex = 0
        Me.Form_Inject2.Text = "LazySharp Injector"
        Me.Form_Inject2.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Text_Status
        '
        Me.Text_Status.Location = New System.Drawing.Point(145, 80)
        Me.Text_Status.Name = "Text_Status"
        Me.Text_Status.Size = New System.Drawing.Size(0, 20)
        Me.Text_Status.TabIndex = 6
        Me.Text_Status.Visible = False
        '
        'Text_Client
        '
        Me.Text_Client.Location = New System.Drawing.Point(38, 19)
        Me.Text_Client.Name = "Text_Client"
        Me.Text_Client.Size = New System.Drawing.Size(0, 20)
        Me.Text_Client.TabIndex = 5
        Me.Text_Client.Text = "League of Legends"
        Me.Text_Client.Visible = False
        '
        'Buton_Close
        '
        Me.Buton_Close.BackColor = System.Drawing.Color.Red
        Me.Buton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buton_Close.Font = New System.Drawing.Font("Verdana", 1.0!)
        Me.Buton_Close.Location = New System.Drawing.Point(274, 4)
        Me.Buton_Close.Name = "Buton_Close"
        Me.Buton_Close.Size = New System.Drawing.Size(12, 12)
        Me.Buton_Close.TabIndex = 4
        Me.Buton_Close.UseVisualStyleBackColor = False
        '
        'Buton_Manuel
        '
        Me.Buton_Manuel.AutoSize = True
        Me.Buton_Manuel.BackColor = System.Drawing.Color.Transparent
        Me.Buton_Manuel.ForeColor = System.Drawing.Color.Khaki
        Me.Buton_Manuel.Location = New System.Drawing.Point(159, 72)
        Me.Buton_Manuel.Name = "Buton_Manuel"
        Me.Buton_Manuel.Size = New System.Drawing.Size(65, 17)
        Me.Buton_Manuel.TabIndex = 3
        Me.Buton_Manuel.Text = "Manuel"
        Me.Buton_Manuel.UseVisualStyleBackColor = False
        '
        'Buton_Auto
        '
        Me.Buton_Auto.AutoSize = True
        Me.Buton_Auto.BackColor = System.Drawing.Color.Transparent
        Me.Buton_Auto.Checked = True
        Me.Buton_Auto.ForeColor = System.Drawing.Color.Khaki
        Me.Buton_Auto.Location = New System.Drawing.Point(57, 72)
        Me.Buton_Auto.Name = "Buton_Auto"
        Me.Buton_Auto.Size = New System.Drawing.Size(82, 17)
        Me.Buton_Auto.TabIndex = 3
        Me.Buton_Auto.TabStop = True
        Me.Buton_Auto.Text = "Automatic"
        Me.Buton_Auto.UseVisualStyleBackColor = False
        '
        'Label_ExeName
        '
        Me.Label_ExeName.AutoSize = True
        Me.Label_ExeName.BackColor = System.Drawing.Color.Transparent
        Me.Label_ExeName.ForeColor = System.Drawing.Color.LightCoral
        Me.Label_ExeName.Location = New System.Drawing.Point(105, 42)
        Me.Label_ExeName.Name = "Label_ExeName"
        Me.Label_ExeName.Size = New System.Drawing.Size(139, 13)
        Me.Label_ExeName.TabIndex = 2
        Me.Label_ExeName.Text = "League of Legends.exe"
        '
        'Label_Wait
        '
        Me.Label_Wait.AutoSize = True
        Me.Label_Wait.BackColor = System.Drawing.Color.Transparent
        Me.Label_Wait.ForeColor = System.Drawing.Color.White
        Me.Label_Wait.Location = New System.Drawing.Point(43, 42)
        Me.Label_Wait.Name = "Label_Wait"
        Me.Label_Wait.Size = New System.Drawing.Size(63, 13)
        Me.Label_Wait.TabIndex = 1
        Me.Label_Wait.Text = "Waiting of"
        '
        'Buton_Inject
        '
        Bloom2.Name = "BackColor"
        Bloom2.Value = System.Drawing.Color.White
        Me.Buton_Inject.Colors = New LazySharp_Hook.Bloom() {Bloom2}
        Me.Buton_Inject.Customization = "/////w=="
        Me.Buton_Inject.Enabled = False
        Me.Buton_Inject.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Buton_Inject.Image = Nothing
        Me.Buton_Inject.Location = New System.Drawing.Point(28, 106)
        Me.Buton_Inject.Name = "Buton_Inject"
        Me.Buton_Inject.NoRounding = False
        Me.Buton_Inject.Size = New System.Drawing.Size(234, 45)
        Me.Buton_Inject.TabIndex = 0
        Me.Buton_Inject.Text = "INJECT"
        Me.Buton_Inject.Transparent = False
        '
        'Text_Select
        '
        Me.Text_Select.Location = New System.Drawing.Point(145, 79)
        Me.Text_Select.Name = "Text_Select"
        Me.Text_Select.Size = New System.Drawing.Size(0, 20)
        Me.Text_Select.TabIndex = 7
        Me.Text_Select.Text = "Global Recoil 1.0.exe"
        Me.Text_Select.Visible = False
        '
        'Form_Inject1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 178)
        Me.Controls.Add(Me.Form_Inject2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(291, 178)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(291, 178)
        Me.Name = "Form_Inject1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LazySharp Injector"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Form_Inject2.ResumeLayout(False)
        Me.Form_Inject2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Form_Inject2 As BeyondTheme
    Friend WithEvents Buton_Inject As BeyondButton2
    Friend WithEvents Label_ExeName As Label
    Friend WithEvents Label_Wait As Label
    Friend WithEvents Buton_Manuel As RadioButton
    Friend WithEvents Buton_Auto As RadioButton
    Friend WithEvents Buton_Close As Button
    Friend WithEvents Inject_Auto As Timer
    Friend WithEvents Inject_Manual As Timer
    Friend WithEvents Text_Client As TextBox
    Friend WithEvents Text_Status As TextBox
    Friend WithEvents Export As Timer
    Friend WithEvents Text_Select As TextBox
End Class
