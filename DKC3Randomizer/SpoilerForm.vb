Imports DKC3Randomizer.EnemyInformation
Public Class SpoilerForm
    Private Sub SpoilerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        ToolStripMenuItem1.Text = "Seed: " & My.Settings.PreviousSeed
        LoadLocations()
    End Sub
    Sub LoadLocations()
        DataGridView1.Rows.Clear()
        Randomizer.ActiveLevelInformation.FullSpawnList.Sort(Function(x, y) x.USOffset.CompareTo(y.USOffset))
        Randomizer.ActiveLevelInformation.FullSpawnList.Sort(Function(x, y) x.LevelName.CompareTo(y.LevelName))

        For i As Integer = 0 To Randomizer.ActiveLevelInformation.FullSpawnList.Count - 1
            DataGridView1.Rows.Add(Hex(Randomizer.ActiveLevelInformation.FullSpawnList(i).USOffset),
                                   Randomizer.ActiveLevelInformation.FullSpawnList(i).WorldName,
                                   Randomizer.ActiveLevelInformation.FullSpawnList(i).LevelName,
                                Randomizer.ActiveEnemyInformation.GetEnemyObject(Randomizer.ActiveLevelInformation.FullSpawnList(i).DefaultID).Name,
                                Randomizer.ActiveEnemyInformation.GetEnemyObject(Randomizer.ActiveLevelInformation.FullSpawnList(i).NewID).Name)
        Next
    End Sub
End Class