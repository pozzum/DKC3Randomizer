Imports DKC3Randomizer.EnemyInformation
Public Class SpoilerForm
    Private Sub SpoilerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        ToolStripMenuItem1.Text = "Seed: " & My.Settings.PreviousSeed
        LoadEnemies()
    End Sub
    Sub LoadEnemies()
        DataGridView1.Rows.Clear()
        Randomizer.ActiveLevelInformation.FullSpawnList.Sort(Function(x, y) x.USOffset.CompareTo(y.USOffset))
        Randomizer.ActiveLevelInformation.FullSpawnList.Sort(Function(x, y) x.LevelName.CompareTo(y.LevelName))

        For i As Integer = 0 To Randomizer.ActiveLevelInformation.FullSpawnList.Count - 1
            DataGridView1.Rows.Add(Hex(Randomizer.ActiveLevelInformation.FullSpawnList(i).USOffset),
                                   Randomizer.ActiveLevelInformation.FullSpawnList(i).WorldName,
                                   Randomizer.ActiveLevelInformation.FullSpawnList(i).LevelName,
                                Randomizer.ActiveEnemyInformation.GetEnemyObject(Randomizer.ActiveLevelInformation.FullSpawnList(i).DefaultID).Name,
                                Randomizer.ActiveEnemyInformation.GetEnemyObject(Randomizer.ActiveLevelInformation.FullSpawnList(i).NewID).Name,
                                Hex(Randomizer.ActiveLevelInformation.FullSpawnList(i).NewID))
        Next
    End Sub

    Private Sub ExportLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportLocationsToolStripMenuItem.Click
        SaveFileDialog1.FileName = My.Settings.PreviousSeed & ".xml"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            XMLTools.ExportXMLFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ImportLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportLocationsToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            XMLTools.ImportXMLFile(OpenFileDialog1.FileName)
            ToolStripMenuItem1.Text = "Seed: Loaded File"
            LoadEnemies()
        End If
    End Sub
End Class