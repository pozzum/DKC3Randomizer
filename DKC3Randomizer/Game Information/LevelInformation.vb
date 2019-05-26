Public Class LevelInformation
    Public Enum Worlds
        LakeOrangatanga
        KremwoodForest
        CottonTopCove
        Mekanos
        K3
        RazorRidge
        KAOSKore
        Krematoa
    End Enum
    Public Enum Levels
        LakesideLimbo
        DoorstopDash
        TidalTrouble
        SkiddasRow
        MurkyMill
        '
        BarrelShieldBustUp
        RiversideRace
        SquealsonWheels
        SpringinSpiders
        BobbingBarrelBrawl
        '
        BazzaBlockade
        RocketBarrelRide
        KreepingKlasps
        TrackerBarrelTrek
        FishFoodFrenzy
        '
        FireBallFrenzy
        DemolitionDrainPipe
        RipsawRage
        BlazingBazukas
        LowGLabyrinth
        '
        KreviceKreepers
        TearawayToboggan
        BarrelDropBounce
        KrackShotKroc
        LemguinLunge
        '
        BuzzerBarrage
        KongFusedCliffs
        FloodlitFish
        PotHolePanic
        RopeyRumpus
        '
        KonveyorRopeKlash
        CreepyCaverns
        LightningLookout
        KoindozerKlamber
        PoisonousPipeline
        '
        StampedeSprint
        CrissKrossCliffs
        TyrantTwinTussle
        SwoopySalvo
        RocketRush
    End Enum
    Public Class SpawnClass
        Public WorldName As Worlds
        Public LevelName As Levels
        Public DefaultID As Int32
        Public USOffset As Int64
        Public PlatformReq As Boolean = False
        Public WoodBarrelKillableReq As Boolean = False
        Public NewID As Int32 = -1
    End Class
    Public FullSpawnList As List(Of SpawnClass)
    Public Sub Initialize()
        FullSpawnList = New List(Of SpawnClass)
#Region "World 1 - LakeOrangatanga"
#Region "1-1 Lakeside Limbo"
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E05E0,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E05F8,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0600,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0608,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0628,
                  .DefaultID = &H580})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0648,
                  .DefaultID = &H578})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0650,
                  .DefaultID = &H57A})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0680,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E0698,
                  .DefaultID = &H574})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E06C0,
                  .DefaultID = &H572})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E06D8,
                  .DefaultID = &H6CA})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.LakesideLimbo,
                  .USOffset = &H3E06F8,
                  .DefaultID = &H580})
#End Region
#Region "1-2 Doorstop Dash"
        'missing some mid level enemies
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0B5E,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0B66,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0B6E,
                  .DefaultID = &H376}) '2
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0B76,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0B7E,
                  .DefaultID = &H376}) '4
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0BAE,
                  .DefaultID = &H376})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0BB6,
                  .DefaultID = &H378})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0BBE,
                  .DefaultID = &H39C}) '7
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0BC6,
                  .DefaultID = &H39E})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0BCE,
                  .DefaultID = &H3A0})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0C86,
                  .DefaultID = &H3A0}) '10
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0C8E,
                  .DefaultID = &H39E}) '11
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0C96,
                  .DefaultID = &H39C})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0C9E,
                  .DefaultID = &H3A2})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0CA6,
                  .DefaultID = &H3A4}) '14
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0CAE,
                  .DefaultID = &H3A6}) '15
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0CC6,
                  .DefaultID = &H376}) '16
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0CE6,
                  .DefaultID = &H378}) '17
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0D46,
                  .DefaultID = &H3D2}) '18
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0D66,
                  .DefaultID = &H3B4}) '19
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0D76,
                  .DefaultID = &H3CE}) '20
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0D8E,
                  .DefaultID = &H386}) '21
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0DDE,
                  .DefaultID = &H376}) '22
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0E1E,
                  .DefaultID = &H3CA}) '23
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.DoorstopDash,
                  .USOffset = &H3E0E66,
                  .DefaultID = &H3BA}) '24
#End Region
#Region "1-3 Tidal Trouble"
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.TidalTrouble,
                  .USOffset = &H3E0944,
                  .DefaultID = &H57C})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.TidalTrouble,
                  .USOffset = &H3E0954,
                  .DefaultID = &H398})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.TidalTrouble,
                  .USOffset = &H3E0964,
                  .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.TidalTrouble,
                  .USOffset = &H3E0974,
                  .DefaultID = &H5A6})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E097C,
                 .DefaultID = &H5A6})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E0994,
                 .DefaultID = &H30A})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09A4,
                 .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09AC,
                 .DefaultID = &H30A})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09B4,
                 .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09BC,
                 .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09C4,
                 .DefaultID = &H30A})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09E4,
                 .DefaultID = &H30A})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E09EC,
                 .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                 .WorldName = Worlds.LakeOrangatanga,
                 .LevelName = Levels.TidalTrouble,
                 .USOffset = &H3E0A0C,
                 .DefaultID = &H398})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A1C,
                .DefaultID = &H3A8})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A24,
                .DefaultID = &H3BC})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A34,
                .DefaultID = &H2C8})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A44,
                .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A3C,
                .DefaultID = &H398})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A4C,
                .DefaultID = &H2D2})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A54,
                .DefaultID = &H656})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A5C,
                .DefaultID = &H656})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A6C,
                .DefaultID = &H5A6})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A64,
                .DefaultID = &H6CC})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A74,
                .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A7C,
                .DefaultID = &H30A})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A94,
                .DefaultID = &H30A})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0A9C,
                .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0AA4,
                .DefaultID = &H3A8})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0AB4,
                .DefaultID = &H2D2})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0AC4,
                .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0ABC,
                .DefaultID = &H398})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0AD4,
                .DefaultID = &H308})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0ACC,
                .DefaultID = &H398})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0AE4,
                .DefaultID = &H2C8})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.TidalTrouble,
                .USOffset = &H3E0AEC,
                .DefaultID = &H5A8})
#End Region
#Region "1-4 Skidda's Row"
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E15C4,
                .DefaultID = &H586})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E15E4,
                .DefaultID = &H5AE})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E15F4,
                .DefaultID = &H582})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E15FC,
                .DefaultID = &H584})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E1614,
                .DefaultID = &H582})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E161C,
                .DefaultID = &H5B0})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E1634,
                .DefaultID = &H582})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E164C,
                .DefaultID = &H588})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E1664,
                .DefaultID = &H586})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E168C,
                .DefaultID = &H586})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E1694,
                .DefaultID = &H584})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E169C,
                .DefaultID = &H582})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E16A4,
                .DefaultID = &H586})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E16CC,
                .DefaultID = &H656})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E16EC,
                .DefaultID = &H582})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E16F4,
                .DefaultID = &H586})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E16FC,
                .DefaultID = &H588})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E1704,
                .DefaultID = &H58A})
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.SkiddasRow,
                .USOffset = &H3E1714,
                .DefaultID = &H5AE})
#End Region
#Region "1-5 Murky Mill"
        FullSpawnList.Add(New SpawnClass() With {
                .WorldName = Worlds.LakeOrangatanga,
                .LevelName = Levels.MurkyMill,
                .USOffset = &H3E1372,
                .DefaultID = &H376}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E137A,
               .DefaultID = &H376}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1392,
               .DefaultID = &H384}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E139A,
               .DefaultID = &H99E}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E13C2,
               .DefaultID = &H384}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E13D2,
               .DefaultID = &H9B6}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E13EA,
               .DefaultID = &H530}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E13F2,
               .DefaultID = &H384}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E140A,
               .DefaultID = &H9B6}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E142A,
               .DefaultID = &H384}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1442,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1462,
               .DefaultID = &H384}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E149A,
               .DefaultID = &H400}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14A2,
               .DefaultID = &H38C}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14AA,
               .DefaultID = &H400}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14C2,
               .DefaultID = &H400}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14D2,
               .DefaultID = &H400}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14EA,
               .DefaultID = &H9AA}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14F2,
               .DefaultID = &H9AA}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E14FA,
               .DefaultID = &H99A}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1512,
               .DefaultID = &H38C,
               .WoodBarrelKillableReq = True}) '20 if ellie is in the level this must be wood-barrel killable
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1522,
               .DefaultID = &H398}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E152A,
               .DefaultID = &H398}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E155A,
               .DefaultID = &H404}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1562,
               .DefaultID = &H384}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E156A,
               .DefaultID = &H384}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1572,
               .DefaultID = &H52E}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E157A,
               .DefaultID = &H52E}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E1592,
               .DefaultID = &H99C}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.LakeOrangatanga,
               .LevelName = Levels.MurkyMill,
               .USOffset = &H3E159A,
               .DefaultID = &H99C}) '29
#End Region
#End Region
#Region "World 2 - Kremwood Forest"
#Region "2-1 Barrel Shield Bust-Up"
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E20EE,
               .DefaultID = &H388}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2106,
               .DefaultID = &H398}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2126,
               .DefaultID = &H35A}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E212E,
               .DefaultID = &H358}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2136,
               .DefaultID = &H380}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E213E,
               .DefaultID = &H384}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2146,
               .DefaultID = &H346}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E214E,
               .DefaultID = &H348}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2156,
               .DefaultID = &H346}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E216E,
               .DefaultID = &H350}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2176,
               .DefaultID = &H352}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E217E,
               .DefaultID = &H354}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2186,
               .DefaultID = &H356}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E218E,
               .DefaultID = &H358}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E219E,
               .DefaultID = &H35A}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21A6,
               .DefaultID = &H358}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21AE,
               .DefaultID = &H35A}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21BE,
               .DefaultID = &H358}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21CE,
               .DefaultID = &H3D8}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21D6,
               .DefaultID = &H3DA}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21F6,
               .DefaultID = &H35C}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E21FE,
               .DefaultID = &H35E}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2206,
               .DefaultID = &H360}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E220E,
               .DefaultID = &H362}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2216,
               .DefaultID = &H364}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2236,
               .DefaultID = &H34E}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E223E,
               .DefaultID = &H350}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2246,
               .DefaultID = &H352}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E224E,
               .DefaultID = &H354}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2256,
               .DefaultID = &H356}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E225E,
               .DefaultID = &H378}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2276,
               .DefaultID = &H38E}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2286,
               .DefaultID = &H348}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E228E,
               .DefaultID = &H35A}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2296,
               .DefaultID = &H358}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22A6,
               .DefaultID = &H35A}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22AE,
               .DefaultID = &H358}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22BE,
               .DefaultID = &H348}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22C6,
               .DefaultID = &H378}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22CE,
               .DefaultID = &H34A}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22D6,
               .DefaultID = &H34C}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22DE,
               .DefaultID = &H34A}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22EE,
               .DefaultID = &H34C}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22F6,
               .DefaultID = &H34A}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E22FE,
               .DefaultID = &H35E}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2306,
               .DefaultID = &H360}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E230E,
               .DefaultID = &H362}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2316,
               .DefaultID = &H364}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E231E,
               .DefaultID = &H34A}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2326,
               .DefaultID = &H34C}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E232E,
               .DefaultID = &H34A}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E233E,
               .DefaultID = &H34C}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2346,
               .DefaultID = &H34A}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2376,
               .DefaultID = &H360}) '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E237E,
               .DefaultID = &H362}) '55
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2386,
               .DefaultID = &H364}) '56
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E238E,
               .DefaultID = &H906}) '57
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23A6,
               .DefaultID = &H358}) '58
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23AE,
               .DefaultID = &H35A}) '59
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23B6,
               .DefaultID = &H358}) '60
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23C6,
               .DefaultID = &H35A}) '62
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23CE,
               .DefaultID = &H358}) '63
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23D6,
               .DefaultID = &H346}) '64
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23DE,
               .DefaultID = &H348}) '65
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23E6,
               .DefaultID = &H346}) '66
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23F6,
               .DefaultID = &H348}) '67
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E23FE,
               .DefaultID = &H346}) '68
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2406,
               .DefaultID = &H358}) '69
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E240E,
               .DefaultID = &H35A}) '70
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2416,
               .DefaultID = &H358}) '71
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2426,
               .DefaultID = &H35A}) '72
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E242E,
               .DefaultID = &H358}) '73
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BarrelShieldBustUp,
               .USOffset = &H3E2446,
               .DefaultID = &H388}) '74
#End Region
#Region "2-2 Riverside Race"
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2762,
               .DefaultID = &HA84}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2772,
               .DefaultID = &H376}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E277A,
               .DefaultID = &H376}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E278A,
               .DefaultID = &H52E}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27A2,
               .DefaultID = &H37E}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27B2,
               .DefaultID = &H2CE}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27BA,
               .DefaultID = &HA86}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27DA,
               .DefaultID = &HA88}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27EA,
               .DefaultID = &H53C}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27F2,
               .DefaultID = &H530}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E27FA,
               .DefaultID = &H8C0}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2802,
               .DefaultID = &HA8A}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2822,
               .DefaultID = &H656}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2832,
               .DefaultID = &H656}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E283A,
               .DefaultID = &HA8C}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E284A,
               .DefaultID = &H9B4}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2852,
               .DefaultID = &H9B4}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E286A,
               .DefaultID = &H2C8}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E288A,
               .DefaultID = &H308}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2892,
               .DefaultID = &H400}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E289A,
               .DefaultID = &H400}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28A2,
               .DefaultID = &H400}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28AA,
               .DefaultID = &HA8E}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28C2,
               .DefaultID = &HA90}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28CA,
               .DefaultID = &H308}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28D2,
               .DefaultID = &H308}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28DA,
               .DefaultID = &H308}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E28F2,
               .DefaultID = &HA92}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2902,
               .DefaultID = &HA92}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E290A,
               .DefaultID = &HA92}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E292A,
               .DefaultID = &HA94}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2932,
               .DefaultID = &H2FC}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2942,
               .DefaultID = &H376}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E294A,
               .DefaultID = &H376}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E2952,
               .DefaultID = &H376}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.RiversideRace,
               .USOffset = &H3E295A,
               .DefaultID = &HA96}) '35
#End Region
#Region "2-3 Squeals on Wheels"
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1058,
               .DefaultID = &H376}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1068,
               .DefaultID = &H53A}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10A0,
               .DefaultID = &H42C}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10A8,
               .DefaultID = &H524}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10C0,
               .DefaultID = &H432}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10C8,
               .DefaultID = &H43A}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10D0,
               .DefaultID = &H52E}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10E8,
               .DefaultID = &H434}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10F0,
               .DefaultID = &H526}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E10F8,
               .DefaultID = &H378}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1178,
               .DefaultID = &H376}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1180,
               .DefaultID = &H524}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1198,
               .DefaultID = &H450}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E11A0,
               .DefaultID = &H452}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E11D8,
               .DefaultID = &H3F0}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E11E0,
               .DefaultID = &H3F2}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E11F8,
               .DefaultID = &H406}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1200,
               .DefaultID = &H404}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1238,
               .DefaultID = &H432}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1240,
               .DefaultID = &H43A}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1260,
               .DefaultID = &H378}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1288,
               .DefaultID = &H524}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1298,
               .DefaultID = &H526}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E12A8,
               .DefaultID = &H42E}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E12B0,
               .DefaultID = &H430}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E12D8,
               .DefaultID = &H454}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E12E0,
               .DefaultID = &H456}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1308,
               .DefaultID = &H6CA}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1310,
               .DefaultID = &H376}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SquealsonWheels,
               .USOffset = &H3E1318,
               .DefaultID = &H400}) '29
#End Region
#Region "2-4 Springin Spiders"
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D3C,
               .DefaultID = &H8B6}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D44,
               .DefaultID = &H8AE}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D4C,
               .DefaultID = &H400}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D54,
               .DefaultID = &H400}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D64,
               .DefaultID = &H832}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D6C,
               .DefaultID = &H3A6}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D7C,
               .DefaultID = &H840}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D84,
               .DefaultID = &H80A}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D8C,
               .DefaultID = &H7E4}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D94,
               .DefaultID = &H398}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1D9C,
               .DefaultID = &H8C4}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1DA4,
               .DefaultID = &H400}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1DEC,
               .DefaultID = &H8D0}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E14,
               .DefaultID = &H398}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E34,
               .DefaultID = &H39A}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E3C,
               .DefaultID = &H398}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E4C,
               .DefaultID = &H656}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E64,
               .DefaultID = &H400}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E6C,
               .DefaultID = &H400}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E84,
               .DefaultID = &H398}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1E9C,
               .DefaultID = &H398}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1EC4,
               .DefaultID = &H640}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1EFC,
               .DefaultID = &H400}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1F0C,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1F5C,
               .DefaultID = &H398}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1F6C,
               .DefaultID = &H398}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1F8C,
               .DefaultID = &H400}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1F94,
               .DefaultID = &H400}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1F9C,
               .DefaultID = &H80A}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1FBC,
               .DefaultID = &H400}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1FDC,
               .DefaultID = &H400}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1FE4,
               .DefaultID = &H400}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1FEC,
               .DefaultID = &H398}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E1FF4,
               .DefaultID = &H376}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E2024,
               .DefaultID = &H398}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E2084,
               .DefaultID = &H400}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.SpringinSpiders,
               .USOffset = &H3E20AC,
               .DefaultID = &H8C2}) '36
#End Region
#Region "2-5 Bobbing Barrel Brawl" '51 w/ nibblas...
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2C56,
               .DefaultID = &H6D0}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2C66,
               .DefaultID = &H400}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2C76,
               .DefaultID = &H770}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2C8E,
               .DefaultID = &H5B4}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2C96,
               .DefaultID = &H5B6}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2C9E,
               .DefaultID = &H772}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CA6,
               .DefaultID = &H772}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CB6,
               .DefaultID = &H398}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CC6,
               .DefaultID = &H774}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CCE,
               .DefaultID = &H774}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CDE,
               .DefaultID = &H6D2}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CF6,
               .DefaultID = &H776}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2CFE,
               .DefaultID = &H776}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D06,
               .DefaultID = &H6D0}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D16,
               .DefaultID = &H400}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D2E,
               .DefaultID = &H778}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D36,
               .DefaultID = &H778}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D46,
               .DefaultID = &H3D4}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D56,
               .DefaultID = &H400}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D5E,
               .DefaultID = &H400}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D6E,
               .DefaultID = &H660}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D86,
               .DefaultID = &H77A}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D8E,
               .DefaultID = &H77A}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2D9E,
               .DefaultID = &H5B4}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2DAE,
               .DefaultID = &H416}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2DB6,
               .DefaultID = &H418}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2DBE,
               .DefaultID = &H400}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2DF6,
               .DefaultID = &H77C}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2DFE,
               .DefaultID = &H77C}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E16,
               .DefaultID = &H77E}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E1E,
               .DefaultID = &H77E}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E2E,
               .DefaultID = &H6D2}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E36,
               .DefaultID = &H3E6}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E3E,
               .DefaultID = &H3E8}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E4E,
               .DefaultID = &H3B2}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E66,
               .DefaultID = &H666}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E6E,
               .DefaultID = &H668}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E7E,
               .DefaultID = &H398}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E8E,
               .DefaultID = &H780}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2E96,
               .DefaultID = &H780}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2EAE,
               .DefaultID = &H5B8}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2EB6,
               .DefaultID = &H782}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2EBE,
               .DefaultID = &H782}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2ECE,
               .DefaultID = &H6D2}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2EDE,
               .DefaultID = &H3B0}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2EE6,
               .DefaultID = &H400}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2EEE,
               .DefaultID = &H398}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2F16,
               .DefaultID = &H5BA}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2F1E,
               .DefaultID = &H784}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2F26,
               .DefaultID = &H784}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2F36,
               .DefaultID = &H3D4}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KremwoodForest,
               .LevelName = Levels.BobbingBarrelBrawl,
               .USOffset = &H3E2F4E,
               .DefaultID = &H3B0}) '51

#End Region
#End Region
#Region "World 3 - Cotton Top Cove"
#Region "3-1 Bazza Blockade" '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E2FA8,
               .DefaultID = &H670}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E2FB0,
               .DefaultID = &H2BA}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E2FB8,
               .DefaultID = &H672}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E2FE8,
               .DefaultID = &H2BC}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E2FF0,
               .DefaultID = &H2BC}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E2FF8,
               .DefaultID = &H2BC}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3000,
               .DefaultID = &H2BC}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3010,
               .DefaultID = &H674}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3020,
               .DefaultID = &H676}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3038,
               .DefaultID = &H67A}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3040,
               .DefaultID = &H678}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3048,
               .DefaultID = &H682}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3050,
               .DefaultID = &H680}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3058,
               .DefaultID = &H67E}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3060,
               .DefaultID = &H67C}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3068,
               .DefaultID = &H684}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3090,
               .DefaultID = &H2BA}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E30D0,
               .DefaultID = &H686}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E30E0,
               .DefaultID = &H688}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E30E8,
               .DefaultID = &H690}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E30F0,
               .DefaultID = &H68E}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E30F8,
               .DefaultID = &H68C}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3100,
               .DefaultID = &H68A}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3108,
               .DefaultID = &H692}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3120,
               .DefaultID = &H694}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3128,
               .DefaultID = &H696}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3130,
               .DefaultID = &H698}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3138,
               .DefaultID = &H69A}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3148,
               .DefaultID = &H69C}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3168,
               .DefaultID = &H6A0}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3170,
               .DefaultID = &H69E}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3188,
               .DefaultID = &H6A2}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E31B0,
               .DefaultID = &H6A4}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E31B8,
               .DefaultID = &H2CE}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E31C8,
               .DefaultID = &H2CE}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E31D8,
               .DefaultID = &H2C8}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E31E0,
               .DefaultID = &H6A6}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E31F8,
               .DefaultID = &H2C8}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3200,
               .DefaultID = &H6A8}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3208,
               .DefaultID = &H6AA}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3210,
               .DefaultID = &H6AC}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3218,
               .DefaultID = &H6AE}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3228,
               .DefaultID = &H6E6}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3230,
               .DefaultID = &H6B0}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3248,
               .DefaultID = &H6B2}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3250,
               .DefaultID = &H6B4}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3258,
               .DefaultID = &H2BA}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.BazzaBlockade,
               .USOffset = &H3E3260,
               .DefaultID = &H2BA}) '47
#End Region
#Region "3-2 Rocket Barrel Ride" '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E382E,
               .DefaultID = &H974}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3836,
               .DefaultID = &H5FC}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3866,
               .DefaultID = &H5C8}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E38D6,
               .DefaultID = &H978}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E38EE,
               .DefaultID = &H398}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E38FE,
               .DefaultID = &H802}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E390E,
               .DefaultID = &H800}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E391E,
               .DefaultID = &H804}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E392E,
               .DefaultID = &H97A}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3936,
               .DefaultID = &H990}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3956,
               .DefaultID = &H396}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E395E,
               .DefaultID = &H5C4}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E397E,
               .DefaultID = &H656}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3986,
               .DefaultID = &H656}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E398E,
               .DefaultID = &H656}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3996,
               .DefaultID = &H398}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E39C6,
               .DefaultID = &H982}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E39E6,
               .DefaultID = &H5B0}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A06,
               .DefaultID = &H7FE}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A16,
               .DefaultID = &H398}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A26,
               .DefaultID = &H7FC}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A56,
               .DefaultID = &H390}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A5E,
               .DefaultID = &H392}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A66,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A6E,
               .DefaultID = &H39A}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A76,
               .DefaultID = &H390}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A7E,
               .DefaultID = &H392}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A86,
               .DefaultID = &H398}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A8E,
               .DefaultID = &H7E8}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A96,
               .DefaultID = &H988}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3A9E,
               .DefaultID = &H988}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3AA6,
               .DefaultID = &H806}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3AAE,
               .DefaultID = &H976}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3AD6,
               .DefaultID = &H390}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3ADE,
               .DefaultID = &H8A4}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3B16,
               .DefaultID = &H390}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.RocketBarrelRide,
               .USOffset = &H3E3B1E,
               .DefaultID = &H808}) '36

#End Region
#Region "3-3 Kreeping Klasps" '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E073A,
               .DefaultID = &H76C}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0742,
               .DefaultID = &H76C}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E074A,
               .DefaultID = &H76C}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0752,
               .DefaultID = &H76C}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E075A,
               .DefaultID = &H76E}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0762,
               .DefaultID = &H76E}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0792,
               .DefaultID = &H530}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07A2,
               .DefaultID = &H572}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07AA,
               .DefaultID = &H4B8}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07B2,
               .DefaultID = &H4BA}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07C2,
               .DefaultID = &H3FC}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07CA,
               .DefaultID = &H3FE}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07E2,
               .DefaultID = &H574}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07F2,
               .DefaultID = &H4BC}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E07FA,
               .DefaultID = &H4BC}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0802,
               .DefaultID = &H4BC}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E080A,
               .DefaultID = &H4BC}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0832,
               .DefaultID = &H576}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0842,
               .DefaultID = &H4BC}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0852,
               .DefaultID = &H4BE}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E085A,
               .DefaultID = &H4C0}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E086A,
               .DefaultID = &H4C2}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0882,
               .DefaultID = &H572}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0892,
               .DefaultID = &H53C}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E089A,
               .DefaultID = &H4BC}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08A2,
               .DefaultID = &H398}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08B2,
               .DefaultID = &H4C4}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08BA,
               .DefaultID = &H4C6}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08C2,
               .DefaultID = &H4BC}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08CA,
               .DefaultID = &H398}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08D2,
               .DefaultID = &H4BC}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08DA,
               .DefaultID = &H398}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08E2,
               .DefaultID = &H53C}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08EA,
               .DefaultID = &H53C}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08F2,
               .DefaultID = &H53C}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E08FA,
               .DefaultID = &H4BC}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E0902,
               .DefaultID = &H398}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.KreepingKlasps,
               .USOffset = &H3E090A,
               .DefaultID = &H4BC}) '37
#End Region
#Region "3-4 Tracker Barrel Trek" '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3B50,
               .DefaultID = &H5E4}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3B58,
               .DefaultID = &H5E4}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3B78,
               .DefaultID = &H602}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3B98,
               .DefaultID = &H5F6}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3BA0,
               .DefaultID = &H5F6}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3BB0,
               .DefaultID = &H5D6}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3BB8,
               .DefaultID = &H5D6}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3BD8,
               .DefaultID = &H390}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3BF8,
               .DefaultID = &H394}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C08,
               .DefaultID = &H5E6}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C10,
               .DefaultID = &H5E6}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C30,
               .DefaultID = &H3C2}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C70,
               .DefaultID = &H60A}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C80,
               .DefaultID = &H5F8}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C88,
               .DefaultID = &H5F8}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3C90,
               .DefaultID = &H390}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3CA8,
               .DefaultID = &H390}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3CB8,
               .DefaultID = &H52A}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3CC0,
               .DefaultID = &H528}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3CF8,
               .DefaultID = &H600}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D00,
               .DefaultID = &H3AC}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D08,
               .DefaultID = &H3AC}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D18,
               .DefaultID = &H604}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D28,
               .DefaultID = &H390}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D30,
               .DefaultID = &H390}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D68,
               .DefaultID = &H3EE}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D78,
               .DefaultID = &H5FE}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D80,
               .DefaultID = &H5FE}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3D98,
               .DefaultID = &H398}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3DA0,
               .DefaultID = &H398}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3DA8,
               .DefaultID = &H398}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.TrackerBarrelTrek,
               .USOffset = &H3E3DB0,
               .DefaultID = &H398}) '31
#End Region
#Region "3-5 Fish Food Frenzy" '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3272,
               .DefaultID = &H7B2}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E327A,
               .DefaultID = &H308}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E328A,
               .DefaultID = &H344}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3292,
               .DefaultID = &H308}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E329A,
               .DefaultID = &H344}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32A2,
               .DefaultID = &H344}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32BA,
               .DefaultID = &H308}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32C2,
               .DefaultID = &H344}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32D2,
               .DefaultID = &H344}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32E2,
               .DefaultID = &H30C}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32EA,
               .DefaultID = &H2FE}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32F2,
               .DefaultID = &H2FE}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E32FA,
               .DefaultID = &H344}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3302,
               .DefaultID = &H344}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E330A,
               .DefaultID = &H344}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3312,
               .DefaultID = &H7B2}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E331A,
               .DefaultID = &H30E}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3332,
               .DefaultID = &H308}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E333A,
               .DefaultID = &H308}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3342,
               .DefaultID = &H308}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E334A,
               .DefaultID = &H308}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3352,
               .DefaultID = &H338}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E335A,
               .DefaultID = &H2FE}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3362,
               .DefaultID = &H33A}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E336A,
               .DefaultID = &H33A}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3372,
               .DefaultID = &H7B2}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E338A,
               .DefaultID = &H2F4}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3392,
               .DefaultID = &H2F2}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33A2,
               .DefaultID = &H312}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33AA,
               .DefaultID = &H308}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33B2,
               .DefaultID = &H30E}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33C2,
               .DefaultID = &H2CA}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33CA,
               .DefaultID = &H2D0}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33D2,
               .DefaultID = &H344}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33E2,
               .DefaultID = &H314}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33F2,
               .DefaultID = &H2CA}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E33FA,
               .DefaultID = &H300}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3402,
               .DefaultID = &H308}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E340A,
               .DefaultID = &H312}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3412,
               .DefaultID = &H314}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E341A,
               .DefaultID = &H344}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E342A,
               .DefaultID = &H2F6}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3432,
               .DefaultID = &H2F6}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E343A,
               .DefaultID = &H308}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3442,
               .DefaultID = &H344}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E344A,
               .DefaultID = &H344}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3452,
               .DefaultID = &H340}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E345A,
               .DefaultID = &H340}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3462,
               .DefaultID = &H2F8}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E346A,
               .DefaultID = &H2D8}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3472,
               .DefaultID = &H2F8}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E347A,
               .DefaultID = &H33E}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E3482,
               .DefaultID = &H33C}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E348A,
               .DefaultID = &H33E}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.CottonTopCove,
               .LevelName = Levels.FishFoodFrenzy,
               .USOffset = &H3E34A2,
               .DefaultID = &H7B2}) '54
#End Region
#End Region
#Region "World 4 - Mekanos"
#Region "3-1 Fire Ball Frenzy" '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FBC,
               .DefaultID = &H91A}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FC4,
               .DefaultID = &H91A}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FCC,
               .DefaultID = &H91A}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FDC,
               .DefaultID = &H91A}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FE4,
               .DefaultID = &H91C}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FF4,
               .DefaultID = &H656}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E3FFC,
               .DefaultID = &H8CC}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4004,
               .DefaultID = &H8CC}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4014,
               .DefaultID = &H940}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4024,
               .DefaultID = &H942}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4074,
               .DefaultID = &H944}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E407C,
               .DefaultID = &H92A}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4084,
               .DefaultID = &H928}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4094,
               .DefaultID = &H926}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E409C,
               .DefaultID = &H398}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E40AC,
               .DefaultID = &H922}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E40B4,
               .DefaultID = &H920}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E40BC,
               .DefaultID = &H91E}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E40CC,
               .DefaultID = &H8CA}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E40DC,
               .DefaultID = &H8CC}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E410C,
               .DefaultID = &H948}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4114,
               .DefaultID = &H92C}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E411C,
               .DefaultID = &H92E}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E414C,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4154,
               .DefaultID = &H930}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E415C,
               .DefaultID = &H398}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4164,
               .DefaultID = &H932}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4174,
               .DefaultID = &H94C}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E417C,
               .DefaultID = &H94A}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4194,
               .DefaultID = &H95C}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E419C,
               .DefaultID = &H95E}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41A4,
               .DefaultID = &H95C}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41B4,
               .DefaultID = &H95A}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41BC,
               .DefaultID = &H958}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41C4,
               .DefaultID = &H956}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41CC,
               .DefaultID = &H954}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41D4,
               .DefaultID = &H952}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E41F4,
               .DefaultID = &H934}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4224,
               .DefaultID = &H936}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4234,
               .DefaultID = &H94E}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E424C,
               .DefaultID = &H8C8}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E425C,
               .DefaultID = &H93A}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4264,
               .DefaultID = &H93C}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E426C,
               .DefaultID = &H93A}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.FireBallFrenzy,
               .USOffset = &H3E4274,
               .DefaultID = &H93C}) '44
#End Region
#Region "3-2 Demolition Drain Pipe" '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5086,
               .DefaultID = &H398}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E508E,
               .DefaultID = &H656}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E509E,
               .DefaultID = &H398}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E50A6,
               .DefaultID = &H398}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E50AE,
               .DefaultID = &H398}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E50CE,
               .DefaultID = &H398}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E50F6,
               .DefaultID = &H398}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E511E,
               .DefaultID = &H398}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5126,
               .DefaultID = &H398}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E512E,
               .DefaultID = &H398}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5136,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E515E,
               .DefaultID = &H656}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E516E,
               .DefaultID = &H398}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5176,
               .DefaultID = &H656}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5186,
               .DefaultID = &H398}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E519E,
               .DefaultID = &H398}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E51B6,
               .DefaultID = &H398}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E51C6,
               .DefaultID = &H398}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E51CE,
               .DefaultID = &H656}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E51F6,
               .DefaultID = &H398}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E51FE,
               .DefaultID = &H398}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5206,
               .DefaultID = &H398}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E520E,
               .DefaultID = &H398}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5216,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E521E,
               .DefaultID = &H398}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5226,
               .DefaultID = &H398}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E522E,
               .DefaultID = &H398}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5236,
               .DefaultID = &H398}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5246,
               .DefaultID = &H398}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E525E,
               .DefaultID = &H398}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5266,
               .DefaultID = &H398}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E528E,
               .DefaultID = &H398}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5296,
               .DefaultID = &H656}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E52A6,
               .DefaultID = &H398}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E52C6,
               .DefaultID = &H656}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E52D6,
               .DefaultID = &H656}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E52EE,
               .DefaultID = &H398}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E530E,
               .DefaultID = &H398}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E5316,
               .DefaultID = &H398}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.DemolitionDrainPipe,
               .USOffset = &H3E531E,
               .DefaultID = &H398}) '39
#End Region
#Region "3-3 Ripsaw Rage" '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1B8A,
               .DefaultID = &H398}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1B9A,
               .DefaultID = &H37C}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1BA2,
               .DefaultID = &H37A}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1BB2,
               .DefaultID = &H37A}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1BD2,
               .DefaultID = &H398}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1BE2,
               .DefaultID = &H37E}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1BEA,
               .DefaultID = &H37C}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1BF2,
               .DefaultID = &H37E}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C1A,
               .DefaultID = &H380}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C2A,
               .DefaultID = &H386}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C42,
               .DefaultID = &H37E}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C4A,
               .DefaultID = &H386}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C52,
               .DefaultID = &H378}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C5A,
               .DefaultID = &H378}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1C7A,
               .DefaultID = &H398}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.RipsawRage,
               .USOffset = &H3E1CC2,
               .DefaultID = &H386}) '15
#End Region
#Region "3-4 Blazing Bazukas" '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E42E6,
               .DefaultID = &H6EE}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E42F6,
               .DefaultID = &H5D2}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E430E,
               .DefaultID = &H6F0}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E431E,
               .DefaultID = &H6F2}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E4366,
               .DefaultID = &H71A}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E4376,
               .DefaultID = &H6F6}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E43AE,
               .DefaultID = &H6F4}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E43DE,
               .DefaultID = &H5D0}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E43E6,
               .DefaultID = &H5D0}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E4406,
               .DefaultID = &H70A}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E441E,
               .DefaultID = &H71A}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E442E,
               .DefaultID = &H3F8}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E446E,
               .DefaultID = &H6F8}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E447E,
               .DefaultID = &H5D2}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E44AE,
               .DefaultID = &H6FA}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E44BE,
               .DefaultID = &H700}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E44E6,
               .DefaultID = &H5D0}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E44EE,
               .DefaultID = &H5D0}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E450E,
               .DefaultID = &H6FE}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E451E,
               .DefaultID = &H5D0}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E4526,
               .DefaultID = &H5D0}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E455E,
               .DefaultID = &H6FC}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E4576,
               .DefaultID = &H702}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E458E,
               .DefaultID = &H5D2}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E4596,
               .DefaultID = &H5D2}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E45B6,
               .DefaultID = &H704}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E45C6,
               .DefaultID = &H706}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.BlazingBazukas,
               .USOffset = &H3E460E,
               .DefaultID = &H708}) '27
#End Region
#Region "3-5 Low-G Labyrinth" '80
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E491A,
               .DefaultID = &H400}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4922,
               .DefaultID = &H83E}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E492A,
               .DefaultID = &H84A}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4932,
               .DefaultID = &H83E}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E494A,
               .DefaultID = &H7D4}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4952,
               .DefaultID = &H7D4}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E495A,
               .DefaultID = &H848}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4962,
               .DefaultID = &H848}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E496A,
               .DefaultID = &H848}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4972,
               .DefaultID = &H97E}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E497A,
               .DefaultID = &H400}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4982,
               .DefaultID = &H400}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E498A,
               .DefaultID = &H400}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4992,
               .DefaultID = &H400}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49A2,
               .DefaultID = &H400}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49AA,
               .DefaultID = &H400}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49B2,
               .DefaultID = &H400}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49BA,
               .DefaultID = &H400}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49C2,
               .DefaultID = &H400}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49CA,
               .DefaultID = &H896}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49E2,
               .DefaultID = &H84E}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E49FA,
               .DefaultID = &H850}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A0A,
               .DefaultID = &H812}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A12,
               .DefaultID = &H812}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A1A,
               .DefaultID = &H812}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A3A,
               .DefaultID = &H400}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A4A,
               .DefaultID = &H400}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A62,
               .DefaultID = &H80E}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A6A,
               .DefaultID = &H83E}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A72,
               .DefaultID = &H83E}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A8A,
               .DefaultID = &H83C}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A92,
               .DefaultID = &H83C}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4A9A,
               .DefaultID = &H83C}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H33,
               .DefaultID = &H7D4}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4AAA,
               .DefaultID = &H7D4}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4AB2,
               .DefaultID = &H7D6}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4ABA,
               .DefaultID = &H7D8}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4ACA,
               .DefaultID = &H7DA}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4AD2,
               .DefaultID = &H7DA}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4ADA,
               .DefaultID = &H400}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4AE2,
               .DefaultID = &H400}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4AF2,
               .DefaultID = &H83E}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4AFA,
               .DefaultID = &H818}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B0A,
               .DefaultID = &H400}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B12,
               .DefaultID = &H400}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B2A,
               .DefaultID = &H81A}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B32,
               .DefaultID = &H80C}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B3A,
               .DefaultID = &H81C}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B4A,
               .DefaultID = &H3D6}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B52,
               .DefaultID = &H84C}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B62,
               .DefaultID = &H854}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B6A,
               .DefaultID = &H856}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B82,
               .DefaultID = &H854}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B8A,
               .DefaultID = &H856}) '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B92,
               .DefaultID = &H400}) '55
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4B9A,
               .DefaultID = &H400}) '56
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BB2,
               .DefaultID = &H400}) '57
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BBA,
               .DefaultID = &H400}) '58
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BCA,
               .DefaultID = &H7DC}) '59
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BE2,
               .DefaultID = &H7E0}) '60
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BEA,
               .DefaultID = &H7DE}) '61
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BF2,
               .DefaultID = &H7E4}) '62
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4BFA,
               .DefaultID = &H7E4}) '63
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C2A,
               .DefaultID = &H398}) '64
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C32,
               .DefaultID = &H398}) '65
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C3A,
               .DefaultID = &H398}) '66
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C42,
               .DefaultID = &H398}) '67
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C4A,
               .DefaultID = &H398}) '68
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C62,
               .DefaultID = &H7E6}) '69
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C6A,
               .DefaultID = &H7E6}) '70
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C7A,
               .DefaultID = &H7E2}) '71
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4C92,
               .DefaultID = &H7E2}) '72
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CAA,
               .DefaultID = &H400}) '73
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CB2,
               .DefaultID = &H402}) '74
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CBA,
               .DefaultID = &H400}) '75
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CC2,
               .DefaultID = &H400}) '76
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CCA,
               .DefaultID = &H402}) '77
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CD2,
               .DefaultID = &H400}) '78
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CDA,
               .DefaultID = &H402}) '79
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Mekanos,
               .LevelName = Levels.LowGLabyrinth,
               .USOffset = &H3E4CE2,
               .DefaultID = &H400}) '80
#End Region
#End Region
#Region "World 5 - K3"
#Region "5-1 Krevice Kreepers" '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5388,
               .DefaultID = &H476}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5398,
               .DefaultID = &H478}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E53A0,
               .DefaultID = &H47C}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E53C0,
               .DefaultID = &H47C}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E53D0,
               .DefaultID = &H47E}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5400,
               .DefaultID = &H38A}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5408,
               .DefaultID = &H378}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5410,
               .DefaultID = &H47A}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5418,
               .DefaultID = &H47C}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5428,
               .DefaultID = &H484}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5430,
               .DefaultID = &H482}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5438,
               .DefaultID = &H480}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5440,
               .DefaultID = &H486}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5478,
               .DefaultID = &H490}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5480,
               .DefaultID = &H492}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E54B0,
               .DefaultID = &H488}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E54C0,
               .DefaultID = &H48E}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E54C8,
               .DefaultID = &H48C}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E54D0,
               .DefaultID = &H48A}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E54E0,
               .DefaultID = &H5A6}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5500,
               .DefaultID = &H496}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5508,
               .DefaultID = &H498}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5510,
               .DefaultID = &H494}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5520,
               .DefaultID = &H4A2}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5538,
               .DefaultID = &H398}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5540,
               .DefaultID = &H49A}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5548,
               .DefaultID = &H49C}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5568,
               .DefaultID = &H4A0}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5570,
               .DefaultID = &H49E}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5588,
               .DefaultID = &H4A4}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E5598,
               .DefaultID = &H398}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E55A0,
               .DefaultID = &H398}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E55A8,
               .DefaultID = &H4A6}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E55B0,
               .DefaultID = &H4A8}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KreviceKreepers,
               .USOffset = &H3E55B8,
               .DefaultID = &H4AA}) '34
#End Region
#Region "5-2 Tearaway Toboggan" '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1920,
               .DefaultID = &H400}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1950,
               .DefaultID = &H582}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1958,
               .DefaultID = &H398}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1968,
               .DefaultID = &H398}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1970,
               .DefaultID = &H398}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1978,
               .DefaultID = &H398}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1988,
               .DefaultID = &H398}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1998,
               .DefaultID = &H582}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19A0,
               .DefaultID = &H582}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19A8,
               .DefaultID = &H656}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19B0,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19B8,
               .DefaultID = &H584}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19D0,
               .DefaultID = &H398}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19D8,
               .DefaultID = &H398}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19E8,
               .DefaultID = &H398}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E19F8,
               .DefaultID = &H582}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A00,
               .DefaultID = &H398}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A18,
               .DefaultID = &H656}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A48,
               .DefaultID = &H584}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A50,
               .DefaultID = &H398}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A58,
               .DefaultID = &H656}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A68,
               .DefaultID = &H656}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A70,
               .DefaultID = &H398}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A78,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1A90,
               .DefaultID = &H656}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AA0,
               .DefaultID = &H584}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AA8,
               .DefaultID = &H584}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AB0,
               .DefaultID = &H584}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AC0,
               .DefaultID = &H584}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AC8,
               .DefaultID = &H584}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AD0,
               .DefaultID = &H584}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AD8,
               .DefaultID = &H398}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AE8,
               .DefaultID = &H398}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AF0,
               .DefaultID = &H398}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1AF8,
               .DefaultID = &H398}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1B10,
               .DefaultID = &H398}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1B20,
               .DefaultID = &H398}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.TearawayToboggan,
               .USOffset = &H3E1B50,
               .DefaultID = &H6C8}) '37
#End Region
#Region "5-3 Barrel Drop Bounce" '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3DD2,
               .DefaultID = &H5CE}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3DEA,
               .DefaultID = &H5CE}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E22,
               .DefaultID = &H5CC}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E32,
               .DefaultID = &H5CC}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E42,
               .DefaultID = &H5C6}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E4A,
               .DefaultID = &H5E2}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E52,
               .DefaultID = &H5E2}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E6A,
               .DefaultID = &H5CC}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3E8A,
               .DefaultID = &H6CE}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3EA2,
               .DefaultID = &H398}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3EAA,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3EB2,
               .DefaultID = &H5CC}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3EBA,
               .DefaultID = &H398}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3ECA,
               .DefaultID = &H398}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3ED2,
               .DefaultID = &H5CC}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3F0A,
               .DefaultID = &H3AA}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3F2A,
               .DefaultID = &H5E0}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3F32,
               .DefaultID = &H5E0}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.BarrelDropBounce,
               .USOffset = &H3E3F42,
               .DefaultID = &H6CA}) '18
#End Region
#Region "5-4 Krack Shot Kroc" '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E46B0,
               .DefaultID = &H7AE}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E46C0,
               .DefaultID = &H440}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E46F0,
               .DefaultID = &H5EC}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4700,
               .DefaultID = &H398}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4708,
               .DefaultID = &H39A}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4710,
               .DefaultID = &H398}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4718,
               .DefaultID = &H542}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4720,
               .DefaultID = &H542}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4728,
               .DefaultID = &H542}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4740,
               .DefaultID = &H44C}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4758,
               .DefaultID = &H44E}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4788,
               .DefaultID = &H400}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4790,
               .DefaultID = &H400}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E47A8,
               .DefaultID = &H540}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E47B0,
               .DefaultID = &H540}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E47B8,
               .DefaultID = &H540}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E47C8,
               .DefaultID = &H44A}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E47E0,
               .DefaultID = &H53E}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E47F0,
               .DefaultID = &H400}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4818,
               .DefaultID = &H7AE}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4820,
               .DefaultID = &H534}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4830,
               .DefaultID = &H3AE}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4838,
               .DefaultID = &H3B0}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4840,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4848,
               .DefaultID = &H39A}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4850,
               .DefaultID = &H534}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4858,
               .DefaultID = &H534}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4868,
               .DefaultID = &H534}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4880,
               .DefaultID = &H7AE}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4888,
               .DefaultID = &H5DC}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E4890,
               .DefaultID = &H5DC}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E48C0,
               .DefaultID = &H5E8}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E48C8,
               .DefaultID = &H5EC}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E48D0,
               .DefaultID = &H5EC}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E48E0,
               .DefaultID = &H7AC}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.KrackShotKroc,
               .USOffset = &H3E48F0,
               .DefaultID = &H5EC}) '35
#End Region
#Region "5-5 Lemguin Lunge" '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E173E,
               .DefaultID = &H400}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1746,
               .DefaultID = &H584}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E177E,
               .DefaultID = &H58C}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1786,
               .DefaultID = &H586}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E17CE,
               .DefaultID = &H58E}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1806,
               .DefaultID = &H590}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1816,
               .DefaultID = &H592}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1866,
               .DefaultID = &H594}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1876,
               .DefaultID = &H582}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E187E,
               .DefaultID = &H596}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E18A6,
               .DefaultID = &H584}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E18DE,
               .DefaultID = &H598}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E18E6,
               .DefaultID = &H584}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.K3,
               .LevelName = Levels.LemguinLunge,
               .USOffset = &H3E1906,
               .DefaultID = &H59A}) '13
#End Region
#End Region
#Region "World 6 - Razor Ridge"
#Region "6-1 Buzzer Barrage" '69
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5C66,
               .DefaultID = &H6BE}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5C8E,
               .DefaultID = &H398}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5C96,
               .DefaultID = &H768}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5C9E,
               .DefaultID = &H73E}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CA6,
               .DefaultID = &H6C0}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CB6,
               .DefaultID = &H740}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CBE,
               .DefaultID = &H742}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CC6,
               .DefaultID = &H8BC}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CCE,
               .DefaultID = &H398}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CF6,
               .DefaultID = &H746}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5CFE,
               .DefaultID = &H746}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D06,
               .DefaultID = &H398}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D0E,
               .DefaultID = &H400}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D16,
               .DefaultID = &H402}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D1E,
               .DefaultID = &H400}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D36,
               .DefaultID = &H768}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D46,
               .DefaultID = &H768}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D56,
               .DefaultID = &H400}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D5E,
               .DefaultID = &H6D8}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D66,
               .DefaultID = &H400}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D76,
               .DefaultID = &H744}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D7E,
               .DefaultID = &H744}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D86,
               .DefaultID = &H3DA}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D96,
               .DefaultID = &H768}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5D9E,
               .DefaultID = &H3C0}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5DA6,
               .DefaultID = &H748}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5DAE,
               .DefaultID = &H768}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5DB6,
               .DefaultID = &H74E}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5DEE,
               .DefaultID = &H3D6}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5DF6,
               .DefaultID = &H3D6}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5DFE,
               .DefaultID = &H84C}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E06,
               .DefaultID = &H84C}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E0E,
               .DefaultID = &H84C}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E16,
               .DefaultID = &H84C}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E1E,
               .DefaultID = &H74A}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E26,
               .DefaultID = &H74A}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E3E,
               .DefaultID = &H398}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E46,
               .DefaultID = &H398}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E56,
               .DefaultID = &H74C}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E76,
               .DefaultID = &H400}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E86,
               .DefaultID = &H402}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5E8E,
               .DefaultID = &H400}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5EA6,
               .DefaultID = &H726}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5EAE,
               .DefaultID = &H764}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5EB6,
               .DefaultID = &H398}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5ECE,
               .DefaultID = &H756}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5ED6,
               .DefaultID = &H756}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5EE6,
               .DefaultID = &H42A}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5EEE,
               .DefaultID = &H398}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5EF6,
               .DefaultID = &H76A}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F06,
               .DefaultID = &H754}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F0E,
               .DefaultID = &H398}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F1E,
               .DefaultID = &H398}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F26,
               .DefaultID = &H398}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F36,
               .DefaultID = &H752}) '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F46,
               .DefaultID = &H750}) '55
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F66,
               .DefaultID = &H758}) '56
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F76,
               .DefaultID = &H398}) '57
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F7E,
               .DefaultID = &H398}) '58
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F86,
               .DefaultID = &H398}) '59
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F8E,
               .DefaultID = &H75C}) '60
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F96,
               .DefaultID = &H768}) '61
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5F9E,
               .DefaultID = &H768}) '62
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5FB6,
               .DefaultID = &H728}) '63
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5FC6,
               .DefaultID = &H72A}) '64
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5FDE,
               .DefaultID = &H400}) '65
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5FE6,
               .DefaultID = &H426}) '66
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5FEE,
               .DefaultID = &H400}) '67
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E5FF6,
               .DefaultID = &H398}) '68
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.BuzzerBarrage,
               .USOffset = &H3E6006,
               .DefaultID = &H72C}) '69
#End Region
#Region "6-2 Kong Fused Cliffs" '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5622,
               .DefaultID = &H3B8}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E562A,
               .DefaultID = &H968}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5632,
               .DefaultID = &H968}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5652,
               .DefaultID = &H96C}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E565A,
               .DefaultID = &H96C}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5682,
               .DefaultID = &H3B8}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56A2,
               .DefaultID = &H824}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56AA,
               .DefaultID = &H822}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56B2,
               .DefaultID = &H860}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56BA,
               .DefaultID = &H862}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56CA,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56D2,
               .DefaultID = &H398}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56DA,
               .DefaultID = &H7F4}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56EA,
               .DefaultID = &H970}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56F2,
               .DefaultID = &H970}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E56FA,
               .DefaultID = &H968}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5702,
               .DefaultID = &H968}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E571A,
               .DefaultID = &H3F4}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5722,
               .DefaultID = &H3F6}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5732,
               .DefaultID = &H842}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E573A,
               .DefaultID = &H844}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E575A,
               .DefaultID = &H3B6}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E576A,
               .DefaultID = &H398}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5772,
               .DefaultID = &H826}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E577A,
               .DefaultID = &H81E}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5782,
               .DefaultID = &H972}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E578A,
               .DefaultID = &H972}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5792,
               .DefaultID = &H970}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E579A,
               .DefaultID = &H968}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57A2,
               .DefaultID = &H968}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57B2,
               .DefaultID = &H398}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57CA,
               .DefaultID = &H7EC}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57D2,
               .DefaultID = &H7EE}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57DA,
               .DefaultID = &H7D0}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57EA,
               .DefaultID = &H3B8}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E57F2,
               .DefaultID = &H3B8}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E5822,
               .DefaultID = &H96E}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.KongFusedCliffs,
               .USOffset = &H3E582A,
               .DefaultID = &H96E}) '37
#End Region
#Region "6-3 Floodlit Fish" '82? -Double Check
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E34C4,
               .DefaultID = &H790}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E34DC,
               .DefaultID = &H6EA}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E34E4,
               .DefaultID = &H790}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E34EC,
               .DefaultID = &H2B8}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E34F4,
               .DefaultID = &H2B8}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E34FC,
               .DefaultID = &H2B8}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3504,
               .DefaultID = &H2C2}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E350C,
               .DefaultID = &H2C2}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3514,
               .DefaultID = &H2C2}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E351C,
               .DefaultID = &H2B8}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3524,
               .DefaultID = &H2B8}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E352C,
               .DefaultID = &H2B8}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3534,
               .DefaultID = &H790}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E353C,
               .DefaultID = &H344}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3544,
               .DefaultID = &H344}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E354C,
               .DefaultID = &H2DC}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3554,
               .DefaultID = &H344}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3564,
               .DefaultID = &H2DC}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E356C,
               .DefaultID = &H2DC}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3574,
               .DefaultID = &H344}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E357C,
               .DefaultID = &H344}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3584,
               .DefaultID = &H344}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E358C,
               .DefaultID = &H790}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3594,
               .DefaultID = &H324}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E359C,
               .DefaultID = &H324}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35A4,
               .DefaultID = &H2D6}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35AC,
               .DefaultID = &H2D4}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35B4,
               .DefaultID = &H2D6}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35C4,
               .DefaultID = &H2DE}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35CC,
               .DefaultID = &H2E0}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35DC,
               .DefaultID = &H790}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35E4,
               .DefaultID = &H344}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35EC,
               .DefaultID = &H344}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35F4,
               .DefaultID = &H344}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E35FC,
               .DefaultID = &H344}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3604,
               .DefaultID = &H344}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E360C,
               .DefaultID = &H344}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E361C,
               .DefaultID = &H344}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3644,
               .DefaultID = &H78E}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E364C,
               .DefaultID = &H342}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3654,
               .DefaultID = &H342}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E365C,
               .DefaultID = &H32A}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3664,
               .DefaultID = &H32A}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E366C,
               .DefaultID = &H32A}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3674,
               .DefaultID = &H32A}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3684,
               .DefaultID = &H790}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E369C,
               .DefaultID = &H2E2}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36A4,
               .DefaultID = &H2E4}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36B4,
               .DefaultID = &H2E6}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36BC,
               .DefaultID = &H2E8}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36C4,
               .DefaultID = &H2EA}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36CC,
               .DefaultID = &H2EC}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36D4,
               .DefaultID = &H2EE}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36DC,
               .DefaultID = &H2EE}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36E4,
               .DefaultID = &H78E}) '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36F4,
               .DefaultID = &H32A}) '55
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E36FC,
               .DefaultID = &H32A}) '56
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3704,
               .DefaultID = &H32A}) '57
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E370C,
               .DefaultID = &H32A}) '58
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3714,
               .DefaultID = &H790}) '59
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E371C,
               .DefaultID = &H2D4}) '60
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E372C,
               .DefaultID = &H318}) '61
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3734,
               .DefaultID = &H318}) '62
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E373C,
               .DefaultID = &H32E}) '63
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3744,
               .DefaultID = &H32E}) '64
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E374C,
               .DefaultID = &H342}) '65
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3754,
               .DefaultID = &H342}) '66
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E375C,
               .DefaultID = &H790}) '67
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3764,
               .DefaultID = &H32A}) '68
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E376C,
               .DefaultID = &H32A}) '69
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3774,
               .DefaultID = &H32A}) '70
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E377C,
               .DefaultID = &H32A}) '71
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E3784,
               .DefaultID = &H32C}) '72
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E378C,
               .DefaultID = &H32C}) '73
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37B4,
               .DefaultID = &H78E}) '74
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37C4,
               .DefaultID = &H330}) '75
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37CC,
               .DefaultID = &H330}) '76
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37D4,
               .DefaultID = &H330}) '77
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37DC,
               .DefaultID = &H330}) '78
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37E4,
               .DefaultID = &H330}) '79
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37EC,
               .DefaultID = &H330}) '80
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37F4,
               .DefaultID = &H330}) '81
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.FloodlitFish,
               .USOffset = &H3E37FC,
               .DefaultID = &H330}) '82

#End Region
#Region "6-4 Pot Hole Panic" '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6038,
               .DefaultID = &H6D6}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6068,
               .DefaultID = &H64A}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6078,
               .DefaultID = &H64E}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6090,
               .DefaultID = &H72E}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60A0,
               .DefaultID = &H730}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60B0,
               .DefaultID = &H344}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60C0,
               .DefaultID = &H30A}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60C8,
               .DefaultID = &H30A}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60D0,
               .DefaultID = &H732}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60D8,
               .DefaultID = &H734}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60E8,
               .DefaultID = &H6C4}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60F0,
               .DefaultID = &H6C2}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E60F8,
               .DefaultID = &H6C2}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6100,
               .DefaultID = &H344}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6108,
               .DefaultID = &H6DA}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6110,
               .DefaultID = &H344}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6118,
               .DefaultID = &H344}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6120,
               .DefaultID = &H6DE}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6128,
               .DefaultID = &H6DE}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6130,
               .DefaultID = &H6E0}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6140,
               .DefaultID = &H6DE}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6150,
               .DefaultID = &H328}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6158,
               .DefaultID = &H336}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6160,
               .DefaultID = &H334}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6168,
               .DefaultID = &H328}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6170,
               .DefaultID = &H332}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6178,
               .DefaultID = &H332}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6180,
               .DefaultID = &H6E0}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6188,
               .DefaultID = &H6DE}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E61C0,
               .DefaultID = &H644}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E61E0,
               .DefaultID = &H736}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E61E8,
               .DefaultID = &H760}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E61F8,
               .DefaultID = &H650}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6248,
               .DefaultID = &H738}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6250,
               .DefaultID = &H738}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6260,
               .DefaultID = &H400}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6268,
               .DefaultID = &H73A}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6270,
               .DefaultID = &H6C8}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.PotHolePanic,
               .USOffset = &H3E6288,
               .DefaultID = &H646}) '38
#End Region
#Region "6-5 Ropey Rumpus" '55
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58A4,
               .DefaultID = &H398}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58B4,
               .DefaultID = &H89C}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58C4,
               .DefaultID = &H400}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58CC,
               .DefaultID = &H7FA}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58D4,
               .DefaultID = &H398}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58DC,
               .DefaultID = &H89E}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E58E4,
               .DefaultID = &H8A0}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E591C,
               .DefaultID = &H830}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5924,
               .DefaultID = &H400}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E592C,
               .DefaultID = &H82E}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5934,
               .DefaultID = &H402}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E593C,
               .DefaultID = &H398}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5944,
               .DefaultID = &H398}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5954,
               .DefaultID = &H7FA}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E595C,
               .DefaultID = &H7F8}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5964,
               .DefaultID = &H862}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E596C,
               .DefaultID = &H868}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E597C,
               .DefaultID = &H7FA}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5984,
               .DefaultID = &H400}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E598C,
               .DefaultID = &H398}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E59B4,
               .DefaultID = &H86E}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E59BC,
               .DefaultID = &H862}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E59DC,
               .DefaultID = &H7FA}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E59E4,
               .DefaultID = &H400}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E59F4,
               .DefaultID = &H402}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E59FC,
               .DefaultID = &H89A}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A04,
               .DefaultID = &H86A}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A0C,
               .DefaultID = &H86C}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A44,
               .DefaultID = &H398}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A4C,
               .DefaultID = &H398}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A54,
               .DefaultID = &H400}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A64,
               .DefaultID = &H872}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A84,
               .DefaultID = &H874}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5A8C,
               .DefaultID = &H876}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5AC4,
               .DefaultID = &H400}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5ACC,
               .DefaultID = &H898}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5AD4,
               .DefaultID = &H398}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5ADC,
               .DefaultID = &H398}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5AE4,
               .DefaultID = &H398}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5AEC,
               .DefaultID = &H398}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B0C,
               .DefaultID = &H878}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B14,
               .DefaultID = &H87A}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B4C,
               .DefaultID = &H87C}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B54,
               .DefaultID = &H87E}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B74,
               .DefaultID = &H400}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B7C,
               .DefaultID = &H86A}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5B84,
               .DefaultID = &H86C}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BB4,
               .DefaultID = &H398}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BBC,
               .DefaultID = &H402}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BCC,
               .DefaultID = &H882}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BDC,
               .DefaultID = &H398}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BE4,
               .DefaultID = &H398}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BF4,
               .DefaultID = &H400}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5BFC,
               .DefaultID = &H882}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5C04,
               .DefaultID = &H402}) '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.RazorRidge,
               .LevelName = Levels.RopeyRumpus,
               .USOffset = &H3E5C0C,
               .DefaultID = &H884}) '55

#End Region
#End Region
#Region "World 7 - KAOS Kore"
#Region "7-1 Konveyor Rope Klash" '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E688E,
               .DefaultID = &H8D4}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68A6,
               .DefaultID = &H962}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68AE,
               .DefaultID = &H398}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68B6,
               .DefaultID = &H398}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68C6,
               .DefaultID = &H398}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68CE,
               .DefaultID = &H8D4}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68D6,
               .DefaultID = &H8D4}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68DE,
               .DefaultID = &H834}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68E6,
               .DefaultID = &H398}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68EE,
               .DefaultID = &H964}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68F6,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E68FE,
               .DefaultID = &H834}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6906,
               .DefaultID = &H398}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E691E,
               .DefaultID = &H966}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6926,
               .DefaultID = &H836}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E692E,
               .DefaultID = &H838}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E693E,
               .DefaultID = &H8D6}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6946,
               .DefaultID = &H8D6}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E694E,
               .DefaultID = &H83A}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6956,
               .DefaultID = &H398}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E695E,
               .DefaultID = &H83A}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6966,
               .DefaultID = &H966}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E698E,
               .DefaultID = &H398}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6996,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E699E,
               .DefaultID = &H398}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69AE,
               .DefaultID = &H6CC}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69B6,
               .DefaultID = &H966}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69BE,
               .DefaultID = &H966}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69C6,
               .DefaultID = &H398}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69CE,
               .DefaultID = &H398}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69D6,
               .DefaultID = &H398}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69DE,
               .DefaultID = &H398}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69E6,
               .DefaultID = &H398}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E69FE,
               .DefaultID = &H3DC}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A06,
               .DefaultID = &H3DE}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A1E,
               .DefaultID = &H3DC}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A26,
               .DefaultID = &H3DE}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A36,
               .DefaultID = &H398}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A3E,
               .DefaultID = &H398}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A46,
               .DefaultID = &H398}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A4E,
               .DefaultID = &H8D8}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A56,
               .DefaultID = &H8D8}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A5E,
               .DefaultID = &H398}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A66,
               .DefaultID = &H398}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A6E,
               .DefaultID = &H3D8}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A86,
               .DefaultID = &H888}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A8E,
               .DefaultID = &H88A}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6A9E,
               .DefaultID = &H88C}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6ABE,
               .DefaultID = &H398}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6AC6,
               .DefaultID = &H398}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6ACE,
               .DefaultID = &H398}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6AD6,
               .DefaultID = &H8A2}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KonveyorRopeKlash,
               .USOffset = &H3E6AFE,
               .DefaultID = &H398}) '53
#End Region
#Region "7-2 Creepy Caverns" '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E62DA,
               .DefaultID = &H606}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E62E2,
               .DefaultID = &H6C8}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E62FA,
               .DefaultID = &H5AA}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6322,
               .DefaultID = &H400}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6342,
               .DefaultID = &H5FA}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E634A,
               .DefaultID = &H5FA}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6352,
               .DefaultID = &H606}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6372,
               .DefaultID = &H400}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6392,
               .DefaultID = &H400}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E63AA,
               .DefaultID = &H400}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E63B2,
               .DefaultID = &H400}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E63C2,
               .DefaultID = &H608}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E63CA,
               .DefaultID = &H608}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E63EA,
               .DefaultID = &H400}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6402,
               .DefaultID = &H608}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6412,
               .DefaultID = &H400}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E644A,
               .DefaultID = &H400}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E645A,
               .DefaultID = &H5AC}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6462,
               .DefaultID = &H5AA}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E648A,
               .DefaultID = &H606}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6492,
               .DefaultID = &H398}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E64AA,
               .DefaultID = &H398}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E64C2,
               .DefaultID = &H400}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E64DA,
               .DefaultID = &H400}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E64EA,
               .DefaultID = &H400}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E650A,
               .DefaultID = &H400}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E651A,
               .DefaultID = &H608}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6522,
               .DefaultID = &H606}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6532,
               .DefaultID = &H400}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E654A,
               .DefaultID = &H5AC}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6552,
               .DefaultID = &H5AC}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E655A,
               .DefaultID = &H5AC}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6582,
               .DefaultID = &H608}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E65BA,
               .DefaultID = &H5AC}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E65C2,
               .DefaultID = &H400}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E65DA,
               .DefaultID = &H400}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E65F2,
               .DefaultID = &H400}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6602,
               .DefaultID = &H400}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6612,
               .DefaultID = &H400}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E661A,
               .DefaultID = &H5AA}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6622,
               .DefaultID = &H5AA}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E662A,
               .DefaultID = &H400}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6632,
               .DefaultID = &H400}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.CreepyCaverns,
               .USOffset = &H3E6642,
               .DefaultID = &H400}) '43
#End Region
#Region "7-3 Lightning Lookout" '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2984,
               .DefaultID = &H398}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2994,
               .DefaultID = &H39A}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E299C,
               .DefaultID = &H398}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29B4,
               .DefaultID = &H39A}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29BC,
               .DefaultID = &H65C}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29C4,
               .DefaultID = &H65C}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29CC,
               .DefaultID = &H65C}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29D4,
               .DefaultID = &H65C}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29EC,
               .DefaultID = &H398}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E29FC,
               .DefaultID = &H39A}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A04,
               .DefaultID = &H65C}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A14,
               .DefaultID = &H39A}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A24,
               .DefaultID = &H398}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A34,
               .DefaultID = &H40E}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A3C,
               .DefaultID = &H40E}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A74,
               .DefaultID = &H40E}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A7C,
               .DefaultID = &H40E}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A8C,
               .DefaultID = &H424}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2A94,
               .DefaultID = &H6BC}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2ACC,
               .DefaultID = &H398}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2AD4,
               .DefaultID = &H39A}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2ADC,
               .DefaultID = &H398}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2AF4,
               .DefaultID = &H398}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2AFC,
               .DefaultID = &H400}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B04,
               .DefaultID = &H402}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B0C,
               .DefaultID = &H400}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B1C,
               .DefaultID = &H65A}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B24,
               .DefaultID = &H65A}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B34,
               .DefaultID = &H410}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B3C,
               .DefaultID = &H410}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B4C,
               .DefaultID = &H65E}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B94,
               .DefaultID = &H410}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2B9C,
               .DefaultID = &H410}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2BB4,
               .DefaultID = &H65C}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2BBC,
               .DefaultID = &H402}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2BC4,
               .DefaultID = &H400}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2BEC,
               .DefaultID = &H39A}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2BFC,
               .DefaultID = &H410}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2C04,
               .DefaultID = &H410}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2C0C,
               .DefaultID = &H65C}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2C14,
               .DefaultID = &H65C}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2C1C,
               .DefaultID = &H414}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.LightningLookout,
               .USOffset = &H3E2C24,
               .DefaultID = &H412}) '41
#End Region
#Region "7-4 Koindozer Klamber" '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E668C,
               .DefaultID = &H794}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6694,
               .DefaultID = &H796}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E669C,
               .DefaultID = &H5BC}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66A4,
               .DefaultID = &H798}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66BC,
               .DefaultID = &H79A}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66C4,
               .DefaultID = &H79C}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66D4,
               .DefaultID = &H7A4}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66E4,
               .DefaultID = &H7A6}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66EC,
               .DefaultID = &H7A6}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66F4,
               .DefaultID = &H79E}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E66FC,
               .DefaultID = &H7A6}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E671C,
               .DefaultID = &H70C}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E674C,
               .DefaultID = &H7A0}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6754,
               .DefaultID = &H792}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6764,
               .DefaultID = &H7A8}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6774,
               .DefaultID = &H5BE}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6784,
               .DefaultID = &H792}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E678C,
               .DefaultID = &H792}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6794,
               .DefaultID = &H792}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E679C,
               .DefaultID = &H5C2}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67A4,
               .DefaultID = &H792}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67AC,
               .DefaultID = &H792}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67B4,
               .DefaultID = &H792}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67C4,
               .DefaultID = &H5BC}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67CC,
               .DefaultID = &H792}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67E4,
               .DefaultID = &H52E}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67EC,
               .DefaultID = &H792}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E67F4,
               .DefaultID = &H7AA}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E682C,
               .DefaultID = &H71A}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E683C,
               .DefaultID = &H70E}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6854,
               .DefaultID = &H5C0}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E685C,
               .DefaultID = &H7A6}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E6864,
               .DefaultID = &H7A6}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.KoindozerKlamber,
               .USOffset = &H3E686C,
               .DefaultID = &H7A6}) '33
#End Region
#Region "7-5 Poisonous Pipeline" '85
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4CFC,
               .DefaultID = &H344}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D04,
               .DefaultID = &H344}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D14,
               .DefaultID = &H2BC}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D1C,
               .DefaultID = &H344}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D24,
               .DefaultID = &H344}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D2C,
               .DefaultID = &H2B8}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D34,
               .DefaultID = &H2B8}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D44,
               .DefaultID = &H5B2}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D4C,
               .DefaultID = &H2B8}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D54,
               .DefaultID = &H2B8}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D5C,
               .DefaultID = &H2C2}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D64,
               .DefaultID = &H30E}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D6C,
               .DefaultID = &H2C2}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D74,
               .DefaultID = &H30C}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D8C,
               .DefaultID = &H310}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D94,
               .DefaultID = &H310}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4D9C,
               .DefaultID = &H2C4}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DA4,
               .DefaultID = &H2C4}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DAC,
               .DefaultID = &H2C2}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DB4,
               .DefaultID = &H2C2}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DBC,
               .DefaultID = &H344}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DC4,
               .DefaultID = &H2D4}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DCC,
               .DefaultID = &H344}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DE4,
               .DefaultID = &H2B8}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DEC,
               .DefaultID = &H2B8}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DF4,
               .DefaultID = &H2B8}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4DFC,
               .DefaultID = &H344}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E04,
               .DefaultID = &H2D4}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E0C,
               .DefaultID = &H2D6}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E14,
               .DefaultID = &H344}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E34,
               .DefaultID = &H2B8}) '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E3C,
               .DefaultID = &H2B8}) '31
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E44,
               .DefaultID = &H2B8}) '32
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E4C,
               .DefaultID = &H344}) '33
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E54,
               .DefaultID = &H344}) '34
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E5C,
               .DefaultID = &H344}) '35
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E64,
               .DefaultID = &H314}) '36
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E6C,
               .DefaultID = &H344}) '37
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E74,
               .DefaultID = &H344}) '38
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E7C,
               .DefaultID = &H312}) '39
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4E84,
               .DefaultID = &H2FA}) '40
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EA4,
               .DefaultID = &H2C4}) '41
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EAC,
               .DefaultID = &H2C4}) '42
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EB4,
               .DefaultID = &H2C4}) '43
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EBC,
               .DefaultID = &H2C4}) '44
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EC4,
               .DefaultID = &H31A}) '45
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4ECC,
               .DefaultID = &H318}) '46
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4ED4,
               .DefaultID = &H31A}) '47
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EDC,
               .DefaultID = &H2C4}) '48
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EE4,
               .DefaultID = &H316}) '49
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EEC,
               .DefaultID = &H316}) '50
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4EFC,
               .DefaultID = &H2C6}) '51
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F04,
               .DefaultID = &H2C6}) '52
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F0C,
               .DefaultID = &H2C6}) '53
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F14,
               .DefaultID = &H2C6}) '54
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F1C,
               .DefaultID = &H2C6}) '55
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F24,
               .DefaultID = &H2C6}) '56
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F3C,
               .DefaultID = &H344}) '57
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F44,
               .DefaultID = &H312}) '58
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F4C,
               .DefaultID = &H344}) '59
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F54,
               .DefaultID = &H344}) '60
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F5C,
               .DefaultID = &H2D6}) '61
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F64,
               .DefaultID = &H344}) '62
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F6C,
               .DefaultID = &H31A}) '63
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F74,
               .DefaultID = &H318}) '64
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F7C,
               .DefaultID = &H31A}) '65
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F8C,
               .DefaultID = &H2D6}) '66
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F94,
               .DefaultID = &H2D6}) '67
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4F9C,
               .DefaultID = &H2D6}) '68
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FA4,
               .DefaultID = &H344}) '69
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FAC,
               .DefaultID = &H2D6}) '70
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FB4,
               .DefaultID = &H344}) '71
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FBC,
               .DefaultID = &H31C}) '72
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FC4,
               .DefaultID = &H344}) '73
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FCC,
               .DefaultID = &H344}) '74
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FD4,
               .DefaultID = &H2D8}) '75
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FDC,
               .DefaultID = &H344}) '76
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FE4,
               .DefaultID = &H344}) '77
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FEC,
               .DefaultID = &H2DA}) '78
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FF4,
               .DefaultID = &H2DA}) '79
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E4FFC,
               .DefaultID = &H344}) '80
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E5004,
               .DefaultID = &H31E}) '81
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E500C,
               .DefaultID = &H320}) '82
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E501C,
               .DefaultID = &H31A}) '83
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E5024,
               .DefaultID = &H318}) '84
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.KAOSKore,
               .LevelName = Levels.PoisonousPipeline,
               .USOffset = &H3E502C,
               .DefaultID = &H31A}) '85
#End Region
#End Region
#Region "World 8 - Krematoa"
#Region "8-1 Stampede Sprint" '30
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BA0,
               .DefaultID = &H5E8}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BA8,
               .DefaultID = &H5E8}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BB0,
               .DefaultID = &H400}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BB8,
               .DefaultID = &H5E8}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BC0,
               .DefaultID = &H5E8}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BC8,
               .DefaultID = &H55C}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BD0,
               .DefaultID = &H974}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BD8,
               .DefaultID = &H974}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BE0,
               .DefaultID = &H5E8}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BE8,
               .DefaultID = &H5E8}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BF0,
               .DefaultID = &H398}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6BF8,
               .DefaultID = &H974}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C00,
               .DefaultID = &H55E}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C08,
               .DefaultID = &H398}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C10,
               .DefaultID = &H5E8}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C18,
               .DefaultID = &H398}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C20,
               .DefaultID = &H974}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C28,
               .DefaultID = &H974}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C40,
               .DefaultID = &H55E}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C48,
               .DefaultID = &H55E}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C58,
               .DefaultID = &H55E}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C60,
               .DefaultID = &H5E8}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C68,
               .DefaultID = &H5E8}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C70,
               .DefaultID = &H398}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C78,
               .DefaultID = &H5E8}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C80,
               .DefaultID = &H5E8}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C88,
               .DefaultID = &H5E8}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6C98,
               .DefaultID = &H55E}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6CA0,
               .DefaultID = &H400}) '28
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6CA8,
               .DefaultID = &H55E}) '29
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.StampedeSprint,
               .USOffset = &H3E6CB0,
               .DefaultID = &H55E}) '30
#End Region
#Region "8-2 Criss Kross Cliffs" '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D22,
               .DefaultID = &H400}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D3A,
               .DefaultID = &H4B6}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D42,
               .DefaultID = &H400}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D52,
               .DefaultID = &H4B2}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D5A,
               .DefaultID = &H4B4}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D7A,
               .DefaultID = &H536}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D82,
               .DefaultID = &H55A}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6D8A,
               .DefaultID = &H400}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6DC2,
               .DefaultID = &H536}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6DCA,
               .DefaultID = &H536}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6DD2,
               .DefaultID = &H536}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6DFA,
               .DefaultID = &H400}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6E2A,
               .DefaultID = &H400}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6E32,
               .DefaultID = &H558}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6E4A,
               .DefaultID = &H4B2}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6E52,
               .DefaultID = &H4B2}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6E72,
               .DefaultID = &H538}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6EAA,
               .DefaultID = &H536}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6EB2,
               .DefaultID = &H536}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6EBA,
               .DefaultID = &H536}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6EC2,
               .DefaultID = &H536}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6EEA,
               .DefaultID = &H52C}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6EF2,
               .DefaultID = &H400}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6F0A,
               .DefaultID = &H536}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6F12,
               .DefaultID = &H400}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6F1A,
               .DefaultID = &H400}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6F22,
               .DefaultID = &H3E4}) '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6F3A,
               .DefaultID = &H400}) '27
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.CrissKrossCliffs,
               .USOffset = &H3E6F42,
               .DefaultID = &H402}) '28
#End Region
#Region "8-3 Tyrant Twin Tussle" '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E6F9C,
               .DefaultID = &H564}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E6FBC,
               .DefaultID = &H546}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E6FCC,
               .DefaultID = &H5BC}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E6FDC,
               .DefaultID = &H6C6}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E6FEC,
               .DefaultID = &H566}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7014,
               .DefaultID = &H3EC}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7024,
               .DefaultID = &H56C}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E706C,
               .DefaultID = &H548}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7094,
               .DefaultID = &H568}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E70BC,
               .DefaultID = &H710}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E70FC,
               .DefaultID = &H56E}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E712C,
               .DefaultID = &H54A}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7144,
               .DefaultID = &H54C}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7174,
               .DefaultID = &H400}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E717C,
               .DefaultID = &H400}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7184,
               .DefaultID = &H5BC}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E718C,
               .DefaultID = &H5BC}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E71B4,
               .DefaultID = &H54E}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E71C4,
               .DefaultID = &H400}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E71CC,
               .DefaultID = &H400}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E71EC,
               .DefaultID = &H550}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E721C,
               .DefaultID = &H552}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7234,
               .DefaultID = &H554}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7254,
               .DefaultID = &H5B0}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E7264,
               .DefaultID = &H556}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.TyrantTwinTussle,
               .USOffset = &H3E727C,
               .DefaultID = &H400}) '24
#End Region
#Region "8-4 Swoopy Salvo" '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2478,
               .DefaultID = &H5E8}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2588,
               .DefaultID = &H5D4}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2590,
               .DefaultID = &H5E6}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2620,
               .DefaultID = &H446}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2628,
               .DefaultID = &H448}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2650,
               .DefaultID = &H43C}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2658,
               .DefaultID = &H43E}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2660,
               .DefaultID = &H398}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2698,
               .DefaultID = &H43C}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E26A8,
               .DefaultID = &H43E}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E26B0,
               .DefaultID = &H422}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E26B8,
               .DefaultID = &H408}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E26C0,
               .DefaultID = &H408}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E26D8,
               .DefaultID = &H398}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2710,
               .DefaultID = &H6C8}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2718,
               .DefaultID = &H408}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2728,
               .DefaultID = &H398}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.SwoopySalvo,
               .USOffset = &H3E2748,
               .DefaultID = &H5E8}) '17
#End Region
#Region "8-5 Rocket Rush" '26
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72BE,
               .DefaultID = &H5A}) '0
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72C6,
               .DefaultID = &H5A}) '1
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72DE,
               .DefaultID = &H5A}) '2
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72E6,
               .DefaultID = &H5A}) '3
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72EE,
               .DefaultID = &H5A}) '4
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72F6,
               .DefaultID = &H5A}) '5
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E72FE,
               .DefaultID = &H5A}) '6
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7306,
               .DefaultID = &H5A}) '7
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E730E,
               .DefaultID = &H5A}) '8
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E731E,
               .DefaultID = &H5A}) '9
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7326,
               .DefaultID = &H5A}) '10
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E732E,
               .DefaultID = &H5A}) '11
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7336,
               .DefaultID = &H5A}) '12
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E733E,
               .DefaultID = &H5A}) '13
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7346,
               .DefaultID = &H5A}) '14
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E734E,
               .DefaultID = &H5A}) '15
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7356,
               .DefaultID = &H5C}) '16
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7366,
               .DefaultID = &H5C}) '17
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E736E,
               .DefaultID = &H5C}) '18
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7376,
               .DefaultID = &H5C}) '19
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7386,
               .DefaultID = &H5A}) '20
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E738E,
               .DefaultID = &H5A}) '21
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E7396,
               .DefaultID = &H5A}) '22
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E739E,
               .DefaultID = &H5A}) '23
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E73A6,
               .DefaultID = &H5A}) '24
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E73AE,
               .DefaultID = &H5A}) '25
        FullSpawnList.Add(New SpawnClass() With {
               .WorldName = Worlds.Krematoa,
               .LevelName = Levels.RocketRush,
               .USOffset = &H3E73B6,
               .DefaultID = &H5A}) '26
#End Region
#End Region
    End Sub
    Public Sub DeleteMurkyEllie()
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.LakeOrangatanga,
                  .LevelName = Levels.MurkyMill,
                  .USOffset = &H3E1362,
                  .DefaultID = &H164,
                  .NewID = &H260})
    End Sub
    Public Sub DeleteBobbingEllie()
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.BobbingBarrelBrawl,
                  .USOffset = &H3E2C86,
                  .DefaultID = &H16E,
                  .NewID = &H260})
    End Sub
    Public Sub RandomizeWheels()
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1028,
                  .DefaultID = &H4EE}) '0
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1080,
                  .DefaultID = &H4F0}) '1
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1098,
                  .DefaultID = &H4F2}) '2
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E10B8,
                  .DefaultID = &H4F4}) '3
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E10E0,
                  .DefaultID = &H4F6}) '4
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1110,
                  .DefaultID = &H4F8}) '5
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1130,
                  .DefaultID = &H4FA}) '6
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1158,
                  .DefaultID = &H4FC}) '7
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1160,
                  .DefaultID = &H4FE}) '8
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1190,
                  .DefaultID = &H500}) '9
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E11D0,
                  .DefaultID = &H502}) '10
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1220,
                  .DefaultID = &H504}) '11
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1230,
                  .DefaultID = &H506}) '12
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1270,
                  .DefaultID = &H508}) '13
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1278,
                  .DefaultID = &H50A}) '14
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E12A0,
                  .DefaultID = &H50C}) '15
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E12D0,
                  .DefaultID = &H50E}) '16
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1038,
                  .DefaultID = &H514,
                  .NewID = &H260}) 'Steel Door 1
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E1138,
                  .DefaultID = &H516,
                  .NewID = &H260}) 'Steel Door 2
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E12E8,
                  .DefaultID = &H518,
                  .NewID = &H514}) 'Steel Door Top
        FullSpawnList.Add(New SpawnClass() With {
                  .WorldName = Worlds.KremwoodForest,
                  .LevelName = Levels.SquealsonWheels,
                  .USOffset = &H3E12F0,
                  .DefaultID = &H51A,
                  .NewID = &H514}) 'Steel Door Top

    End Sub
End Class
