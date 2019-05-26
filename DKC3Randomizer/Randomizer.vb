Imports System.IO    'Files
Public Class Randomizer
    'I used a lot of information from my Axiom Verge Randomizer which has evolved from other randomizers
    'https://github.com/pozzum/AxiomRandomizer
    Public Shared Generator As System.Random
    Public Shared ActiveEnemyInformation As New EnemyInformation
    Public Shared ActiveLevelInformation As LevelInformation
    Public Shared Sub Initialize(Seed As Integer, AllowBosses As Boolean, AllowFriends As Boolean,
                                 DeleteMurkyEllie As Boolean, DeleteBobbingEllie As Boolean, DeleteSneekyWheels As Boolean)
        Generator = New System.Random(Seed:=Seed)
        ActiveEnemyInformation = New EnemyInformation
        ActiveEnemyInformation.Initialize(AllowBosses, AllowFriends)
        ActiveLevelInformation = New LevelInformation
        ActiveLevelInformation.Initialize()
        If DeleteMurkyEllie Then ActiveLevelInformation.DeleteMurkyEllie()
        If DeleteBobbingEllie Then ActiveLevelInformation.DeleteBobbingEllie()
        If DeleteSneekyWheels Then ActiveLevelInformation.RandomizeWheels()
        For i As Integer = 0 To ActiveLevelInformation.FullSpawnList.Count - 1
            If ActiveLevelInformation.FullSpawnList(i).NewID = -1 Then
                ActiveLevelInformation.FullSpawnList(i).NewID = GetNewEnemyID()
            End If
        Next
    End Sub
    Public Shared Function GetNewEnemyID(Optional WoodBarrelKillableReq As Boolean = False, Optional PlatformRequired As Boolean = False)
        Dim TempRand As Integer = -1
        Dim IDRand As Integer = -1
        Do While IDRand = -1
            TempRand = Generator.Next(ActiveEnemyInformation.FullEnemyList.Count)
            If Not ActiveEnemyInformation.FullEnemyList(TempRand).Placeable Then
                Continue Do
                If WoodBarrelKillableReq AndAlso (ActiveEnemyInformation.FullEnemyList(TempRand).BarrellKillable = False) Then
                    Continue Do
                End If
            End If
                IDRand = Generator.Next(ActiveEnemyInformation.FullEnemyList(TempRand).IDNum.Count)
                Exit Do
        Loop
        Return ActiveEnemyInformation.FullEnemyList(TempRand).IDNum(IDRand)
        'TO DO Add in auto no krosshair sign..
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
