Imports System.IO    'Files
Imports System.Text.RegularExpressions 'Text Replace
Imports System.Threading 'Multithreading
Public Class MainForm
#Region "Menu Load Functions"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Save()
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        CheckUpdate()
        CheckSettings()
    End Sub
    Sub CheckUpdate()
        Dim checkUpdateThread = New Thread(AddressOf OnlineVersion.CheckUpdate)
        checkUpdateThread.SetApartmentState(ApartmentState.STA)
        checkUpdateThread.Start()
    End Sub
    Private Sub CheckSettings()
        If My.Settings.UpgradeRequired = True Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
            My.Settings.Save()
        End If
        If Not My.Settings.RomFilePath = "" Then
            TextBoxRomLocation.Text = My.Settings.RomFilePath
            CheckVersion()
        End If
        TextBoxRandomizedRomLocation.Text = My.Settings.RandoRomFilePath
        If My.Settings.KeepLastSeed Then
            TextBoxSeed.Text = My.Settings.PreviousSeed
        Else
            TextBoxSeed.Text = GetRandomNumber().ToString
        End If
        If My.Settings.SaveSettings Then
            CheckBoxAllowBosses.Checked = My.Settings.AllowBosses
            CheckBoxAllowFriends.Checked = My.Settings.AllowFriends
            CheckBoxReduceGimmicks.CheckState = My.Settings.ReduceGimmicks
            CheckBoxDeleteMurkyEllie.Checked = My.Settings.DeleteMurkyEllie
            CheckBoxDeleteBobbingEllie.Checked = My.Settings.DeleteBobbingEllie
            CheckBoxDeleteSneeksinWheels.Checked = My.Settings.DeleteSneekyWheels
        Else
            CheckBoxAllowBosses.Checked = False
            CheckBoxAllowFriends.Checked = False
            CheckBoxReduceGimmicks.Checked = False
            CheckBoxDeleteMurkyEllie.Checked = False
            CheckBoxDeleteBobbingEllie.Checked = False
            CheckBoxDeleteSneeksinWheels.Checked = False
        End If
        AdjustGimmicks()
    End Sub
#End Region
#Region "Rom File Select Buttons"
    Private Sub ButtonGetRomAndHash_Click(sender As Object, e As EventArgs) Handles ButtonGetRomAndHash.Click
        If Not My.Settings.RomFilePath = "" Then
            If File.Exists(My.Settings.RomFilePath) Then
                OpenFileRom.InitialDirectory = Path.GetDirectoryName(My.Settings.RomFilePath)
                OpenFileRom.FileName = "Donkey Kong Country 3.smc"
            End If
        End If
        If OpenFileRom.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            TextBoxRomLocation.Text = OpenFileRom.FileName
            CheckVersion()
        End If
    End Sub
    Private Sub ButtonSetRandomizedRomLocation_Click(sender As Object, e As EventArgs) Handles ButtonSetRandomizedRomLocation.Click
        If Not My.Settings.RandoRomFilePath = "" Then
            If File.Exists(My.Settings.RandoRomFilePath) Then
                OpenFileRom.InitialDirectory = Path.GetDirectoryName(My.Settings.RandoRomFilePath)
                OpenFileRom.FileName = Path.GetFileName(My.Settings.RandoRomFilePath)
            End If
        End If
        If OpenFileRom.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Settings.RandoRomFilePath = OpenFileRom.FileName
            TextBoxRandomizedRomLocation.Text = OpenFileRom.FileName
        End If
    End Sub
    Private Sub CheckVersion()
        RomVersions.CheckRomHash(TextBoxRomLocation.Text)
        If Not RomVersions.CurrentROMVersion = RomVersions.RomVersion.U_1_0 Then
            MessageBox.Show("Randomizer not compatible!" & vbNewLine &
                            "Randomizer requires US version 1.0" & vbNewLine &
                            "Your Version: " & RomVersions.GetVersionString())
            TextBoxSeed.Enabled = False
            ButtonRandomSeed.Enabled = False
            TextBoxRandomizedRomLocation.Enabled = False
            ButtonSetRandomizedRomLocation.Enabled = False
        Else
            My.Settings.RomFilePath = TextBoxRomLocation.Text
            If My.Settings.RandoRomFilePath = "" Then
                My.Settings.RandoRomFilePath = Path.GetDirectoryName(My.Settings.RomFilePath) & Path.DirectorySeparatorChar &
                                                "DKC3EnemyRando.smc"
            End If
            TextBoxSeed.Enabled = True
            ButtonRandomSeed.Enabled = True
            TextBoxRandomizedRomLocation.Enabled = True
            ButtonSetRandomizedRomLocation.Enabled = True
        End If
    End Sub
#End Region
    Private Sub ButtonRandomSeed_Click(sender As Object, e As EventArgs) Handles ButtonRandomSeed.Click
        TextBoxSeed.Text = GetRandomNumber().ToString
    End Sub
    Function GetRandomNumber() As Integer
        Randomize()
        If Rnd() > 0.5 Then
            Return CInt(Rnd() * Integer.MaxValue)
        Else
            Return CInt(-(Rnd() * Integer.MaxValue))
        End If
    End Function
    Private Sub TextBoxSeed_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSeed.TextChanged
        Dim SentTextBox As TextBox = CType(sender, TextBox)
        Dim CursorPosition As Integer = SentTextBox.SelectionStart
        SentTextBox.Text = Regex.Replace(SentTextBox.Text, "[^\d-]", "")
        If InStrRev(SentTextBox.Text, "-") > 1 Then
            SentTextBox.Text = Regex.Replace(SentTextBox.Text, "[-]", "")
        End If
        If SentTextBox.Text.Length > 0 Then
            If (SentTextBox.Text <> "-") Then
                If CLng(SentTextBox.Text) > Integer.MaxValue OrElse
                    CLng(SentTextBox.Text) < Integer.MinValue Then
                    SentTextBox.Text = SentTextBox.Text.Substring(0, SentTextBox.Text.Length - 1)
                End If
            End If
        End If
        SentTextBox.SelectionStart = CursorPosition
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Me.Hide()
        OptionsMenu.Show()
    End Sub
    Private Sub OpenEmulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenEmulatorToolStripMenuItem.Click
        If My.Settings.EmulatorPath = "" Then
            If OpenFileEmulatorExe.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                My.Settings.EmulatorPath = OpenFileEmulatorExe.FileName
            Else
                Exit Sub
            End If
        End If
        If File.Exists(My.Settings.EmulatorPath) Then
            Process.Start("""" & My.Settings.EmulatorPath & """")
            Me.Close()
        Else
            MessageBox.Show("File Not Found")
        End If
    End Sub
    Private Function StartRandomizer()
        If TextBoxSeed.Text = "" OrElse TextBoxSeed.Text = "-" Then
            MessageBox.Show("Seed Number Required")
            Return False
        End If
        My.Settings.PreviousSeed = TextBoxSeed.Text
        My.Settings.AllowBosses = CheckBoxAllowBosses.Checked
        My.Settings.AllowFriends = CheckBoxAllowFriends.Checked
        My.Settings.ReduceGimmicks = CheckBoxReduceGimmicks.CheckState
        My.Settings.DeleteMurkyEllie = CheckBoxDeleteMurkyEllie.Checked
        My.Settings.DeleteBobbingEllie = CheckBoxDeleteBobbingEllie.Checked
        My.Settings.DeleteSneekyWheels = CheckBoxDeleteSneeksinWheels.Checked
        My.Settings.RandomizeKoins = CheckBoxDeleteKoins.Checked
        Randomizer.Initialize(CInt(TextBoxSeed.Text), CheckBoxAllowBosses.Checked, CheckBoxAllowFriends.Checked,
                              CheckBoxDeleteMurkyEllie.Checked, CheckBoxDeleteBobbingEllie.Checked, CheckBoxDeleteSneeksinWheels.Checked, CheckBoxDeleteKoins.Checked)
        Return True
    End Function
    Private Sub ButtonRandomizeRom_Click(sender As Object, e As EventArgs) Handles ButtonRandomizeRom.Click
        If Not StartRandomizer() Then Exit Sub
        If Randomizer.SaveRandoRom(TextBoxRomLocation.Text, TextBoxRandomizedRomLocation.Text) Then
            If My.Settings.XMLLimited AndAlso My.Settings.XMLLimitCount = 0 Then
            Else
                XMLTools.ExportXMLFile(My.Settings.XMLSaveLocation)
            End If
            MessageBox.Show("Rom Built")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not StartRandomizer() Then Exit Sub
        SpoilerForm.Show()
    End Sub
    Private Sub AdjustGimmicks()
        If CheckBoxReduceGimmicks.CheckState = System.Windows.Forms.CheckState.Indeterminate Then
            Me.Height = 360
        ElseIf CheckBoxReduceGimmicks.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.Height = 265
            CheckBoxDeleteMurkyEllie.Checked = True
            CheckBoxDeleteBobbingEllie.Checked = True
            CheckBoxDeleteSneeksinWheels.Checked = True
            CheckBoxDeleteKoins.Checked = True
        Else 'not checked
            Me.Height = 265
            CheckBoxDeleteMurkyEllie.Checked = False
            CheckBoxDeleteBobbingEllie.Checked = False
            CheckBoxDeleteSneeksinWheels.Checked = False
            CheckBoxDeleteKoins.Checked = False
        End If
    End Sub
    Private Sub CheckBoxReduceGimmicks_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxReduceGimmicks.CheckStateChanged
        AdjustGimmicks()
    End Sub
End Class
