Imports System.IO    'Files
Public Class Randomizer
    'I used a lot of information from my Axiom Verge Randomizer which has evolved from other randomizers
    'https://github.com/pozzum/AxiomRandomizer
    Public Shared Generator As System.Random
    Public Shared ActiveEnemyInformation As New EnemyInformation
    Public Shared ActiveLevelInformation As LevelInformation
    Public Shared Sub Initialize(Seed As Integer, AllowBosses As Boolean, AllowFriends As Boolean,
                                 DeleteMurkyEllie As Boolean, DeleteBobbingEllie As Boolean, DeleteSneekyWheels As Boolean, RandomizeCoins As Boolean)
        Generator = New System.Random(Seed:=Seed)
        ActiveEnemyInformation = New EnemyInformation
        ActiveEnemyInformation.Initialize(AllowBosses, AllowFriends, RandomizeCoins)
        ActiveLevelInformation = New LevelInformation
        ActiveLevelInformation.Initialize()
        If DeleteMurkyEllie Then ActiveLevelInformation.DeleteMurkyEllie()
        If DeleteBobbingEllie Then ActiveLevelInformation.DeleteBobbingEllie()
        If DeleteSneekyWheels Then ActiveLevelInformation.RandomizeWheels()
        If RandomizeCoins Then ActiveLevelInformation.RandomizeKoins()
        For i As Integer = 0 To ActiveLevelInformation.FullSpawnList.Count - 1
            If ActiveLevelInformation.FullSpawnList(i).NewID = -1 Then
                ActiveLevelInformation.FullSpawnList(i).NewID = GetNewEnemyID(ActiveLevelInformation.FullSpawnList(i))
            End If
        Next
    End Sub
    Public Shared Function GetNewEnemyID(PlacementLocation As LevelInformation.SpawnClass) 'Optional WoodBarrelKillableReq As Boolean = False, Optional PlatformRequired As Boolean = False)
        Dim TempRand As Integer = -1
        Dim IDRand As Integer = -1
        Do While IDRand = -1
            TempRand = Generator.Next(ActiveEnemyInformation.FullEnemyList.Count)
            If Not ActiveEnemyInformation.FullEnemyList(TempRand).Placeable Then
                Continue Do
            ElseIf PlacementLocation.WoodBarrelKillableReq AndAlso (ActiveEnemyInformation.FullEnemyList(TempRand).BarrellKillable = False) Then
                Continue Do
            ElseIf PlacementLocation.PlatformReq AndAlso (ActiveEnemyInformation.FullEnemyList(TempRand).JumpPlatform = False) Then
                Continue Do
            ElseIf PlacementLocation.WaterInLevel AndAlso (ActiveEnemyInformation.FullEnemyList(TempRand).Aquaphobic = True) Then
                Continue Do
            Else 'The ID works
                IDRand = Generator.Next(ActiveEnemyInformation.FullEnemyList(TempRand).IDNum.Count)
                Exit Do
            End If
        Loop
        'TO DO Add in auto no krosshair sign..
        Return ActiveEnemyInformation.FullEnemyList(TempRand).IDNum(IDRand)
    End Function
    Public Shared Function SaveRandoRom(BaseRomLocation As String, RandoRomLocation As String)
        If Not File.Exists(BaseRomLocation) Then
            MessageBox.Show("Base Rom File Not Found")
            Return False
        End If
        If File.Exists(RandoRomLocation) Then File.Delete(RandoRomLocation)
        If File.Exists(RandoRomLocation) Then Return False
        Dim RomBytes As Byte() = File.ReadAllBytes(BaseRomLocation)
        For i As Integer = 0 To ActiveLevelInformation.FullSpawnList.Count - 1
            Buffer.BlockCopy(BitConverter.GetBytes(ActiveLevelInformation.FullSpawnList(i).NewID), 0, RomBytes, ActiveLevelInformation.FullSpawnList(i).USOffset, 2)
        Next
        File.WriteAllBytes(RandoRomLocation, RomBytes)
        If File.Exists(RandoRomLocation) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
