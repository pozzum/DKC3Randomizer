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
        Me.RadioButtonDefaultSettings = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSaveSettings = New System.Windows.Forms.RadioButton()
        Me.LabelXML = New System.Windows.Forms.Label()
        Me.TrackBarXML = New System.Windows.Forms.TrackBar()
        Me.CheckBoxXMLLimit = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonGetSpoilerPath = New System.Windows.Forms.Button()
        Me.TextBoxSpoilerPath = New System.Windows.Forms.TextBox()
        Me.GroupBoxSeedOnLoad.SuspendLayout()
        Me.GroupBoxSettingsOnLoad.SuspendLayout()
        CType(Me.TrackBarXML, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelXML
        '
        Me.LabelXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelXML.Location = New System.Drawing.Point(135, 182)
        Me.LabelXML.Name = "LabelXML"
        Me.LabelXML.Size = New System.Drawing.Size(39, 13)
        Me.LabelXML.TabIndex = 7
        Me.LabelXML.Text = "0"
        Me.LabelXML.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TrackBarXML
        '
        Me.TrackBarXML.Enabled = False
        Me.TrackBarXML.Location = New System.Drawing.Point(5, 204)
        Me.TrackBarXML.Maximum = 100
        Me.TrackBarXML.Name = "TrackBarXML"
        Me.TrackBarXML.Size = New System.Drawing.Size(169, 45)
        Me.TrackBarXML.TabIndex = 6
        Me.TrackBarXML.TickFrequency = 10
        '
        'CheckBoxXMLLimit
        '
        Me.CheckBoxXMLLimit.AutoSize = True
        Me.CheckBoxXMLLimit.Checked = True
        Me.CheckBoxXMLLimit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxXMLLimit.Location = New System.Drawing.Point(5, 181)
        Me.CheckBoxXMLLimit.Name = "CheckBoxXMLLimit"
        Me.CheckBoxXMLLimit.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxXMLLimit.TabIndex = 5
        Me.CheckBoxXMLLimit.Text = "Limit XMLS"
        Me.CheckBoxXMLLimit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Spoiler Save Path:"
        '
        'ButtonGetSpoilerPath
        '
        Me.ButtonGetSpoilerPath.Location = New System.Drawing.Point(149, 153)
        Me.ButtonGetSpoilerPath.Name = "ButtonGetSpoilerPath"
        Me.ButtonGetSpoilerPath.Size = New System.Drawing.Size(25, 23)
        Me.ButtonGetSpoilerPath.TabIndex = 10
        Me.ButtonGetSpoilerPath.Text = "..."
        Me.ButtonGetSpoilerPath.UseVisualStyleBackColor = True
        '
        'TextBoxSpoilerPath
        '
        Me.TextBoxSpoilerPath.Location = New System.Drawing.Point(5, 155)
        Me.TextBoxSpoilerPath.Name = "TextBoxSpoilerPath"
        Me.TextBoxSpoilerPath.ReadOnly = True
        Me.TextBoxSpoilerPath.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxSpoilerPath.TabIndex = 9
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 241)
        Me.Controls.Add(Me.ButtonGetSpoilerPath)
        Me.Controls.Add(Me.TextBoxSpoilerPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelXML)
        Me.Controls.Add(Me.TrackBarXML)
        Me.Controls.Add(Me.CheckBoxXMLLimit)
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
        CType(Me.TrackBarXML, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelXML As Label
    Friend WithEvents TrackBarXML As TrackBar
    Friend WithEvents CheckBoxXMLLimit As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonGetSpoilerPath As Button
    Friend WithEvents TextBoxSpoilerPath As TextBox
End Class
