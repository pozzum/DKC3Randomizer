<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

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
        Me.TextBoxRomLocation = New System.Windows.Forms.TextBox()
        Me.ButtonGetRomAndHash = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSeed = New System.Windows.Forms.TextBox()
        Me.ButtonRandomSeed = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenEmulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileRom = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileEmulatorExe = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSetRandomizedRomLocation = New System.Windows.Forms.Button()
        Me.TextBoxRandomizedRomLocation = New System.Windows.Forms.TextBox()
        Me.ButtonRandomizeRom = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxAllowBosses = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllowFriends = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxDeleteMurkyEllie = New System.Windows.Forms.CheckBox()
        Me.CheckBoxReduceGimmicks = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteBobbingEllie = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteSneeksinWheels = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxRomLocation
        '
        Me.TextBoxRomLocation.Location = New System.Drawing.Point(12, 40)
        Me.TextBoxRomLocation.Name = "TextBoxRomLocation"
        Me.TextBoxRomLocation.ReadOnly = True
        Me.TextBoxRomLocation.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxRomLocation.TabIndex = 0
        '
        'ButtonGetRomAndHash
        '
        Me.ButtonGetRomAndHash.Location = New System.Drawing.Point(147, 38)
        Me.ButtonGetRomAndHash.Name = "ButtonGetRomAndHash"
        Me.ButtonGetRomAndHash.Size = New System.Drawing.Size(25, 23)
        Me.ButtonGetRomAndHash.TabIndex = 1
        Me.ButtonGetRomAndHash.Text = "..."
        Me.ButtonGetRomAndHash.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rom Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seed:"
        '
        'TextBoxSeed
        '
        Me.TextBoxSeed.Enabled = False
        Me.TextBoxSeed.Location = New System.Drawing.Point(12, 118)
        Me.TextBoxSeed.Name = "TextBoxSeed"
        Me.TextBoxSeed.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxSeed.TabIndex = 4
        '
        'ButtonRandomSeed
        '
        Me.ButtonRandomSeed.Enabled = False
        Me.ButtonRandomSeed.Location = New System.Drawing.Point(112, 116)
        Me.ButtonRandomSeed.Name = "ButtonRandomSeed"
        Me.ButtonRandomSeed.Size = New System.Drawing.Size(60, 23)
        Me.ButtonRandomSeed.TabIndex = 5
        Me.ButtonRandomSeed.Text = "Random"
        Me.ButtonRandomSeed.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(184, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.OpenEmulatorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'OpenEmulatorToolStripMenuItem
        '
        Me.OpenEmulatorToolStripMenuItem.Name = "OpenEmulatorToolStripMenuItem"
        Me.OpenEmulatorToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.OpenEmulatorToolStripMenuItem.Text = "Open Emulator"
        '
        'OpenFileRom
        '
        Me.OpenFileRom.FileName = "Donkey Kong Country 3.smc"
        Me.OpenFileRom.Filter = "DKC3 Rom File|*.smc"
        Me.OpenFileRom.Title = "Select DKC3 Rom File"
        '
        'OpenFileEmulatorExe
        '
        Me.OpenFileEmulatorExe.FileName = "SnesEmulator.exe"
        Me.OpenFileEmulatorExe.Filter = "Snes Emulator Executable|*.exe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Randomized Rom Location"
        '
        'ButtonSetRandomizedRomLocation
        '
        Me.ButtonSetRandomizedRomLocation.Location = New System.Drawing.Point(147, 77)
        Me.ButtonSetRandomizedRomLocation.Name = "ButtonSetRandomizedRomLocation"
        Me.ButtonSetRandomizedRomLocation.Size = New System.Drawing.Size(25, 23)
        Me.ButtonSetRandomizedRomLocation.TabIndex = 9
        Me.ButtonSetRandomizedRomLocation.Text = "..."
        Me.ButtonSetRandomizedRomLocation.UseVisualStyleBackColor = True
        '
        'TextBoxRandomizedRomLocation
        '
        Me.TextBoxRandomizedRomLocation.Location = New System.Drawing.Point(12, 79)
        Me.TextBoxRandomizedRomLocation.Name = "TextBoxRandomizedRomLocation"
        Me.TextBoxRandomizedRomLocation.ReadOnly = True
        Me.TextBoxRandomizedRomLocation.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxRandomizedRomLocation.TabIndex = 8
        '
        'ButtonRandomizeRom
        '
        Me.ButtonRandomizeRom.Location = New System.Drawing.Point(12, 194)
        Me.ButtonRandomizeRom.Name = "ButtonRandomizeRom"
        Me.ButtonRandomizeRom.Size = New System.Drawing.Size(94, 23)
        Me.ButtonRandomizeRom.TabIndex = 10
        Me.ButtonRandomizeRom.Text = "Randomize Rom"
        Me.ButtonRandomizeRom.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Spoiler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxAllowBosses
        '
        Me.CheckBoxAllowBosses.AutoSize = True
        Me.CheckBoxAllowBosses.Location = New System.Drawing.Point(9, 148)
        Me.CheckBoxAllowBosses.Name = "CheckBoxAllowBosses"
        Me.CheckBoxAllowBosses.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxAllowBosses.TabIndex = 12
        Me.CheckBoxAllowBosses.Text = "Allow Bosses"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAllowBosses, "Adds Arich & KAOS to the Enemy Pool")
        Me.CheckBoxAllowBosses.UseVisualStyleBackColor = True
        '
        'CheckBoxAllowFriends
        '
        Me.CheckBoxAllowFriends.AutoSize = True
        Me.CheckBoxAllowFriends.Location = New System.Drawing.Point(95, 148)
        Me.CheckBoxAllowFriends.Name = "CheckBoxAllowFriends"
        Me.CheckBoxAllowFriends.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxAllowFriends.TabIndex = 13
        Me.CheckBoxAllowFriends.Text = "Allow Friends"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAllowFriends, "Adds the kong buddies & hungry nibbla to the enemy pool.")
        Me.CheckBoxAllowFriends.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteMurkyEllie
        '
        Me.CheckBoxDeleteMurkyEllie.AutoSize = True
        Me.CheckBoxDeleteMurkyEllie.Location = New System.Drawing.Point(9, 228)
        Me.CheckBoxDeleteMurkyEllie.Name = "CheckBoxDeleteMurkyEllie"
        Me.CheckBoxDeleteMurkyEllie.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxDeleteMurkyEllie.TabIndex = 14
        Me.CheckBoxDeleteMurkyEllie.Text = "Remove Murky Ellie"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDeleteMurkyEllie, "Replaces the Ellie barrel in Murky Mill with a DK Barrel.")
        Me.CheckBoxDeleteMurkyEllie.UseVisualStyleBackColor = True
        '
        'CheckBoxReduceGimmicks
        '
        Me.CheckBoxReduceGimmicks.AutoSize = True
        Me.CheckBoxReduceGimmicks.Location = New System.Drawing.Point(9, 171)
        Me.CheckBoxReduceGimmicks.Name = "CheckBoxReduceGimmicks"
        Me.CheckBoxReduceGimmicks.Size = New System.Drawing.Size(141, 17)
        Me.CheckBoxReduceGimmicks.TabIndex = 15
        Me.CheckBoxReduceGimmicks.Text = "Reduce Level Gimmicks"
        Me.CheckBoxReduceGimmicks.ThreeState = True
        Me.ToolTip1.SetToolTip(Me.CheckBoxReduceGimmicks, "Replaces the Ellie barrel in Murkey Mill with a DK Barrel.")
        Me.CheckBoxReduceGimmicks.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteBobbingEllie
        '
        Me.CheckBoxDeleteBobbingEllie.AutoSize = True
        Me.CheckBoxDeleteBobbingEllie.Location = New System.Drawing.Point(9, 251)
        Me.CheckBoxDeleteBobbingEllie.Name = "CheckBoxDeleteBobbingEllie"
        Me.CheckBoxDeleteBobbingEllie.Size = New System.Drawing.Size(130, 17)
        Me.CheckBoxDeleteBobbingEllie.TabIndex = 16
        Me.CheckBoxDeleteBobbingEllie.Text = "Remove Bobbing Ellie"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDeleteBobbingEllie, "Replaces the Ellie barrel in Murkey Mill with a DK Barrel.")
        Me.CheckBoxDeleteBobbingEllie.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteSneeksinWheels
        '
        Me.CheckBoxDeleteSneeksinWheels.AutoSize = True
        Me.CheckBoxDeleteSneeksinWheels.Location = New System.Drawing.Point(9, 274)
        Me.CheckBoxDeleteSneeksinWheels.Name = "CheckBoxDeleteSneeksinWheels"
        Me.CheckBoxDeleteSneeksinWheels.Size = New System.Drawing.Size(155, 17)
        Me.CheckBoxDeleteSneeksinWheels.TabIndex = 17
        Me.CheckBoxDeleteSneeksinWheels.Text = "Remove Sneeks in Wheels"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDeleteSneeksinWheels, "Replaces the Ellie barrel in Murkey Mill with a DK Barrel.")
        Me.CheckBoxDeleteSneeksinWheels.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 296)
        Me.Controls.Add(Me.CheckBoxDeleteSneeksinWheels)
        Me.Controls.Add(Me.CheckBoxDeleteBobbingEllie)
        Me.Controls.Add(Me.CheckBoxReduceGimmicks)
        Me.Controls.Add(Me.CheckBoxDeleteMurkyEllie)
        Me.Controls.Add(Me.CheckBoxAllowFriends)
        Me.Controls.Add(Me.CheckBoxAllowBosses)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonRandomizeRom)
        Me.Controls.Add(Me.ButtonSetRandomizedRomLocation)
        Me.Controls.Add(Me.TextBoxRandomizedRomLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonRandomSeed)
        Me.Controls.Add(Me.TextBoxSeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGetRomAndHash)
        Me.Controls.Add(Me.TextBoxRomLocation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxRomLocation As TextBox
    Friend WithEvents ButtonGetRomAndHash As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSeed As TextBox
    Friend WithEvents ButtonRandomSeed As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenEmulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileRom As OpenFileDialog
    Friend WithEvents OpenFileEmulatorExe As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSetRandomizedRomLocation As Button
    Friend WithEvents TextBoxRandomizedRomLocation As TextBox
    Friend WithEvents ButtonRandomizeRom As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxAllowBosses As CheckBox
    Friend WithEvents CheckBoxAllowFriends As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxDeleteMurkyEllie As CheckBox
    Friend WithEvents CheckBoxReduceGimmicks As CheckBox
    Friend WithEvents CheckBoxDeleteBobbingEllie As CheckBox
    Friend WithEvents CheckBoxDeleteSneeksinWheels As CheckBox
End Class
