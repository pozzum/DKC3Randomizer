<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsMenu
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
        Me.GroupBoxSeedOnLoad = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNewSeed = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLastSeed = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEmulatorPath = New System.Windows.Forms.TextBox()
        Me.ButtonGetEmulatorExe = New System.Windows.Forms.Button()
        Me.GroupBoxSettingsOnLoad = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSaveSettings = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDefaultSettings = New System.Windows.Forms.RadioButton()
        Me.GroupBoxSeedOnLoad.SuspendLayout()
        Me.GroupBoxSettingsOnLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSeedOnLoad
        '
        Me.GroupBoxSeedOnLoad.Controls.Add(Me.RadioButtonNewSeed)
        Me.GroupBoxSeedOnLoad.Controls.Add(Me.RadioButtonLastSeed)
        Me.GroupBoxSeedOnLoad.Location = New System.Drawing.Point(5, 3)
        Me.GroupBoxSeedOnLoad.Name = "GroupBoxSeedOnLoad"
        Me.GroupBoxSeedOnLoad.Size = New System.Drawing.Size(171, 44)
        Me.GroupBoxSeedOnLoad.TabIndex = 0
        Me.GroupBoxSeedOnLoad.TabStop = False
        Me.GroupBoxSeedOnLoad.Text = "Seed on Load"
        '
        'RadioButtonNewSeed
        '
        Me.RadioButtonNewSeed.AutoSize = True
        Me.RadioButtonNewSeed.Location = New System.Drawing.Point(98, 19)
        Me.RadioButtonNewSeed.Name = "RadioButtonNewSeed"
        Me.RadioButtonNewSeed.Size = New System.Drawing.Size(75, 17)
        Me.RadioButtonNewSeed.TabIndex = 1
        Me.RadioButtonNewSeed.Text = "New Seed"
        Me.RadioButtonNewSeed.UseVisualStyleBackColor = True
        '
        'RadioButtonLastSeed
        '
        Me.RadioButtonLastSeed.AutoSize = True
        Me.RadioButtonLastSeed.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonLastSeed.Name = "RadioButtonLastSeed"
        Me.RadioButtonLastSeed.Size = New System.Drawing.Size(73, 17)
        Me.RadioButtonLastSeed.TabIndex = 0
        Me.RadioButtonLastSeed.Text = "Last Seed"
        Me.RadioButtonLastSeed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Emulator Path:"
        '
        'TextBoxEmulatorPath
        '
        Me.TextBoxEmulatorPath.Location = New System.Drawing.Point(5, 116)
        Me.TextBoxEmulatorPath.Name = "TextBoxEmulatorPath"
        Me.TextBoxEmulatorPath.ReadOnly = True
        Me.TextBoxEmulatorPath.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxEmulatorPath.TabIndex = 2
        '
        'ButtonGetEmulatorExe
        '
        Me.ButtonGetEmulatorExe.Location = New System.Drawing.Point(149, 114)
        Me.ButtonGetEmulatorExe.Name = "ButtonGetEmulatorExe"
        Me.ButtonGetEmulatorExe.Size = New System.Drawing.Size(25, 23)
        Me.ButtonGetEmulatorExe.TabIndex = 3
        Me.ButtonGetEmulatorExe.Text = "..."
        Me.ButtonGetEmulatorExe.UseVisualStyleBackColor = True
        '
        'GroupBoxSettingsOnLoad
        '
        Me.GroupBoxSettingsOnLoad.Controls.Add(Me.RadioButtonDefaultSettings)
        Me.GroupBoxSettingsOnLoad.Controls.Add(Me.RadioButtonSaveSettings)
        Me.GroupBoxSettingsOnLoad.Location = New System.Drawing.Point(5, 53)
        Me.GroupBoxSettingsOnLoad.Name = "GroupBoxSettingsOnLoad"
        Me.GroupBoxSettingsOnLoad.Size = New System.Drawing.Size(173, 44)
        Me.GroupBoxSettingsOnLoad.TabIndex = 2
        Me.GroupBoxSettingsOnLoad.TabStop = False
        Me.GroupBoxSettingsOnLoad.Text = "Settings on Load"
        '
        'RadioButtonSaveSettings
        '
        Me.RadioButtonSaveSettings.AutoSize = True
        Me.RadioButtonSaveSettings.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonSaveSettings.Name = "RadioButtonSaveSettings"
        Me.RadioButtonSaveSettings.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonSaveSettings.TabIndex = 0
        Me.RadioButtonSaveSettings.TabStop = True
        Me.RadioButtonSaveSettings.Text = "Last Settings"
        Me.RadioButtonSaveSettings.UseVisualStyleBackColor = True
        '
        'RadioButtonDefaultSettings
        '
        Me.RadioButtonDefaultSettings.AutoSize = True
        Me.RadioButtonDefaultSettings.Location = New System.Drawing.Point(98, 19)
        Me.RadioButtonDefaultSettings.Name = "RadioButtonDefaultSettings"
        Me.RadioButtonDefaultSettings.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDefaultSettings.TabIndex = 1
        Me.RadioButtonDefaultSettings.TabStop = True
        Me.RadioButtonDefaultSettings.Text = "Default"
        Me.RadioButtonDefaultSettings.UseVisualStyleBackColor = True
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 161)
        Me.Controls.Add(Me.GroupBoxSettingsOnLoad)
        Me.Controls.Add(Me.ButtonGetEmulatorExe)
        Me.Controls.Add(Me.TextBoxEmulatorPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxSeedOnLoad)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.GroupBoxSeedOnLoad.ResumeLayout(False)
        Me.GroupBoxSeedOnLoad.PerformLayout()
        Me.GroupBoxSettingsOnLoad.ResumeLayout(False)
        Me.GroupBoxSettingsOnLoad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxSeedOnLoad As GroupBox
    Friend WithEvents RadioButtonNewSeed As RadioButton
    Friend WithEvents RadioButtonLastSeed As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEmulatorPath As TextBox
    Friend WithEvents ButtonGetEmulatorExe As Button
    Friend WithEvents GroupBoxSettingsOnLoad As GroupBox
    Friend WithEvents RadioButtonDefaultSettings As RadioButton
    Friend WithEvents RadioButtonSaveSettings As RadioButton
End Class
