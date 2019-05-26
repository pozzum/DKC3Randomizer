Imports System.IO    'Files
Public Class OptionsMenu
    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        LoadSettings()
    End Sub
    Private Sub OptionsMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Application.OpenForms().OfType(Of MainForm).Any Then
            MainForm.Show()
        End If
    End Sub
    Private Sub LoadSettings()
        If My.Settings.KeepLastSeed Then
            RadioButtonLastSeed.Checked = True
        Else
            RadioButtonNewSeed.Checked = True
        End If
        If My.Settings.SaveSettings Then
            RadioButtonSaveSettings.Checked = True
        Else
            RadioButtonDefaultSettings.Checked = True
        End If
        TextBoxEmulatorPath.Text = My.Settings.EmulatorPath
    End Sub

    Private Sub RadioButtonLastSeed_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLastSeed.CheckedChanged, RadioButtonNewSeed.CheckedChanged
        My.Settings.KeepLastSeed = RadioButtonLastSeed.Checked
    End Sub
    Private Sub RadioButtonSaveSettings_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSaveSettings.CheckedChanged, RadioButtonDefaultSettings.CheckedChanged
        My.Settings.SaveSettings = RadioButtonSaveSettings.Checked
    End Sub
    Private Sub ButtonGetEmulatorExe_Click(sender As Object, e As EventArgs) Handles ButtonGetEmulatorExe.Click
        If Not My.Settings.EmulatorPath = "" Then
            If File.Exists(My.Settings.EmulatorPath) Then
                MainForm.OpenFileEmulatorExe.InitialDirectory = Path.GetDirectoryName(My.Settings.EmulatorPath)
            End If
        End If
        If MainForm.OpenFileEmulatorExe.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Settings.EmulatorPath = MainForm.OpenFileEmulatorExe.FileName
            TextBoxEmulatorPath.Text = My.Settings.EmulatorPath
        Else
            Exit Sub
        End If
    End Sub
End Class