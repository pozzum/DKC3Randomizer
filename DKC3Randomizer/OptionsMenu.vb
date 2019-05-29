Imports System.IO    'Files
Public Class OptionsMenu
    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        CurrentXMLCount = -1
        XMLTrimPending = False
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
        TextBoxSpoilerPath.Text = My.Settings.XMLSaveLocation
        If TextBoxSpoilerPath.Text = "" Then
            CheckBoxXMLLimit.Enabled = False
        Else
            CheckBoxXMLLimit.Enabled = True
        End If
        TrackBarXML.Value = My.Settings.XMLLimitCount
        LabelXML.Text = TrackBarXML.Value.ToString
        LabelXML.Enabled = CheckBoxXMLLimit.Checked
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

    Private Sub ButtonGetSpoilerPath_Click(sender As Object, e As EventArgs) Handles ButtonGetSpoilerPath.Click
        SpoilerForm.SaveFileDialog1.FileName = "Save Files Here..."
        If Not My.Settings.XMLSaveLocation = "" Then
            If Directory.Exists(My.Settings.XMLSaveLocation) Then
                SpoilerForm.SaveFileDialog1.InitialDirectory = My.Settings.XMLSaveLocation
            End If
        End If
        If SpoilerForm.SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Settings.XMLSaveLocation = Path.GetDirectoryName(SpoilerForm.SaveFileDialog1.FileName) & Path.DirectorySeparatorChar
            TextBoxSpoilerPath.Text = My.Settings.XMLSaveLocation
            If Directory.Exists(My.Settings.XMLSaveLocation) Then
                CheckBoxXMLLimit.Enabled = True
            End If
        Else
            Exit Sub
        End If
    End Sub
    Dim CurrentXMLCount As Integer = -1
    Dim XMLTrimPending As Boolean = False
    Private Sub CheckBoxXMLLimit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxXMLLimit.CheckedChanged
        If My.Settings.XMLSaveLocation = "" Then
            Exit Sub
        End If
        If CheckBoxXMLLimit.Checked Then
            TrackBarXML.Enabled = True
            LabelXML.Enabled = True
            If CurrentXMLCount = -1 Then
                CurrentXMLCount = XMLTools.GetXMLCount(My.Settings.XMLSaveLocation)
            End If
            If CurrentXMLCount > TrackBarXML.Value Then
                If Not My.Settings.XMLLimited Then
                    If MessageBox.Show("Your XML folder currently has " & CurrentXMLCount & " XML files." & vbNewLine & "Would you like to set the limit to this value?",
                                     "Change XML Limit?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        TrackBarXML.Value = CurrentXMLCount
                    Else
                        XMLTrimPending = True
                    End If
                Else
                    XMLTrimPending = True
                End If
            End If
        Else
            TrackBarXML.Enabled = False
            LabelXML.Enabled = False
        End If
        My.Settings.XMLLimited = CheckBoxXMLLimit.Checked
    End Sub

    Private Sub TrackBarXML_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarXML.ValueChanged
        LabelXML.Text = TrackBarXML.Value.ToString
        My.Settings.XMLLimitCount = TrackBarXML.Value
        If CurrentXMLCount = -1 Then
            CurrentXMLCount = XMLTools.GetXMLCount(My.Settings.XMLSaveLocation)
        End If
        If CurrentXMLCount > TrackBarXML.Value Then
            XMLTrimPending = True
        End If
    End Sub
End Class