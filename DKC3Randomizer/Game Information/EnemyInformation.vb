Public Class EnemyInformation
    Public Class EnemyClass
        Public Name As String
        Public IDNum As List(Of Int32)
        Public Friendly As Boolean
        Public JumpPlatform As Boolean 'To Be added for those that can't be jump killed
        Public Floats As Boolean
        Public JumpKillable As Boolean
        Public SpinKillable As Boolean
        Public BarrellKillable As Boolean
        Public EnguardeKillable As Boolean
        Public SquaksKillable As Boolean 'To be checked on all enemies!
        Public NibblaFood As Boolean 'Test What enemies nibbla can eat...?
        Public Boss As Boolean 'to allow a checkbox disabling bosses to be included.
        Public NonKillable As Boolean
        Public Placeable As Boolean = True 'A note that these exist in the game but we shouldn't use them to randomly place
    End Class
    Public FullEnemyList As List(Of EnemyClass)
    Public Sub Initialize(AllowBosses As Boolean, AllowFriends As Boolean)
        FullEnemyList = New List(Of EnemyClass)
#Region "Friendlies"
        If AllowFriends Then
            FullEnemyList.Add(New EnemyClass() With {
                    .Name = "Ellie",
                    .IDNum = New List(Of Int32)(New Int32() {&H0}),
                    .Friendly = True,
                    .Floats = False,
                    .JumpKillable = False,
                    .SpinKillable = False,
                    .BarrellKillable = False,
                    .EnguardeKillable = False,
                    .NonKillable = False})
            FullEnemyList.Add(New EnemyClass() With {
                    .Name = "Enguarde",
                    .IDNum = New List(Of Int32)(New Int32() {&H2}),
                    .Friendly = True,
                    .Floats = True,
                    .JumpKillable = False,
                    .SpinKillable = False,
                    .BarrellKillable = False,
                    .EnguardeKillable = False,
                    .NonKillable = False})
            FullEnemyList.Add(New EnemyClass() With {
                    .Name = "Squawks",
                    .IDNum = New List(Of Int32)(New Int32() {&H6}),
                    .Friendly = True,
                    .Floats = True,
                    .JumpKillable = False,
                    .SpinKillable = False,
                    .BarrellKillable = False,
                    .EnguardeKillable = False,
                    .NonKillable = False})
            FullEnemyList.Add(New EnemyClass() With {
                    .Name = "Parry",
                    .IDNum = New List(Of Int32)(New Int32() {&H8}),
                    .Friendly = True,
                    .Floats = True,
                    .JumpKillable = False,
                    .SpinKillable = False,
                    .BarrellKillable = False,
                    .EnguardeKillable = False,
                    .NonKillable = False})
        End If
#End Region
#Region "Bosses"
        If AllowBosses Then
            'Squirt Disables all other items from spawning
            FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Arich",
                  .IDNum = New List(Of Int32)(New Int32() {&HAA4}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = True,
                  .EnguardeKillable = False,
                  .Boss = True,
                  .NonKillable = False})
            'Bleak is like an invisible timed damage that doesn't actually take a kong? idk if it should be included..
            'Barbos spawns some enmies but overall just lags the game out..
            FullEnemyList.Add(New EnemyClass() With {
                  .Name = "KAOS",
                  .IDNum = New List(Of Int32)(New Int32() {&HAAA}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .Boss = True,
                  .NonKillable = False}) ' An impenatrable wall if you don't get past him fast
        End If
#End Region
#Region "Unkillable"
        'Nibbla only enabled if you have friends to midigate danger.
        FullEnemyList.Add(New EnemyClass() With {
                    .Name = "Hungry Nibbla",
                    .IDNum = New List(Of Int32)(New Int32() {&H7B2}),
                    .Friendly = False,
                    .Floats = True,
                    .JumpKillable = False,
                    .SpinKillable = False,
                    .BarrellKillable = False,
                    .EnguardeKillable = False,
                    .NonKillable = True,
                    .Placeable = False}) 'requires nibbla food in the level...?
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Red Buzz",
                  .IDNum = New List(Of Int32)(New Int32() {&H400, &H402, &H404, &H406, &H408, &H40A,
                          &H40C, &H40E, &H410, &H412, &H414,
                          &H416, &H418, &H41A, &H41C, &H41E,
                          &H420, &H422, &H424, &H426, &H428,
                          &H42A, &H42C, &H42E, &H430, &H432,
                          &H434, &H436, &H438, &H43A, &H43C,
                          &H43E, &H440, &H442, &H444, &H446,
                          &H448, &H44A, &H44C, &H44E, &H450,
                          &H452, &H454, &H456, &H458, &H45A,
                          &H8A6, &H8A8, &H8AA, &H8AC, &H8AE,
                          &H8B0, &H8B2, &H8B4, &H8B6, &H8B8,
                          &H8BA, &H8BC}), ' &h005A  & &h005C are killable from Rocket Rush
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Minkey",
                  .IDNum = New List(Of Int32)(New Int32() {&H346, &H348, &H34A, &H34C, &H34E,
                          &H350, &H352, &H354, &H356, &H358,
                          &H35A, &H35C, &H35E, &H360, &H362, &H364}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Kuchuka",
                  .IDNum = New List(Of Int32)(New Int32() {&H644, &H646, &H648, &H64A, &H64C,
                          &H64E, &H650, &H652, &H654}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Bazuka",
                  .IDNum = New List(Of Int32)(New Int32() {&H6EE, &H6F0, &H6F2, &H6F4, &H6F6,
                          &H6F8, &H6FA, &H6FC, &H6FE, &H700,
                          &H702, &H704, &H706, &H708, &H70A,
                          &H70C, &H70E, &H710, &H712, &H714,
                          &H716, &H718, &H71A, &H71C, &H71E}), 'Engarude can bypass them in certain situations
                  .Friendly = False,
                  .JumpPlatform = True,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Kopter",
                  .IDNum = New List(Of Int32)(New Int32() {&H720, &H722, &H724, &H726, &H728,
                          &H72A, &H72C, &H72E, &H730, &H732,
                          &H734, &H736, &H738, &H73A, &H73C,
                          &H73E, &H740, &H742, &H744, &H746,
                          &H748, &H74A, &H74C, &H74E, &H750,
                          &H752, &H754, &H756, &H758, &H75A,
                          &H75C, &H75E, &H760, &H762, &H764,
                          &H766, &H768, &H76A, &H968, &H96A,
                          &H96C, &H96E, &H970, &H972}), 'Some don't seem to have actual hit detection.. the rest one at least
                  .Friendly = False,
                  .JumpPlatform = True,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Gleamin Bream",
                  .IDNum = New List(Of Int32)(New Int32() {&H78E, &H790}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Krosshair",
                  .IDNum = New List(Of Int32)(New Int32() {&H7AE}), '&H7AC doesn't seem to work
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Yellow Nid",
                  .IDNum = New List(Of Int32)(New Int32() {&H8DE, &H8E0, &H8E2, &H8E4, &H8E6,
                          &H8E8, &H8EA, &H8EC, &H8EE}),
                  .Friendly = False,
                  .JumpPlatform = True,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Red Nid",
                  .IDNum = New List(Of Int32)(New Int32() {&H8F0, &H8F2, &H8F4, &H8F8, &H8FA,
                          &H8FC, &H8FE, &H900, &H902, &H904,
                          &H906, &H908, &H90A, &H90C, &H90E,
                          &H910, &H912, &H914, &H916, &H918}),
                  .Friendly = False,
                  .JumpPlatform = True,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Karbine",
                  .IDNum = New List(Of Int32)(New Int32() {&H91A, &H91C, &H91E, &H920, &H922,
                          &H926, &H928, &H92A, &H92C, &H92E,
                          &H930, &H932, &H934, &H936, &H938,
                          &H93A, &H93C, &H93E, &H940, &H942,
                          &H944, &H946, &H948, &H94A, &H94C,
                          &H94E, &H950, &H952, &H954, &H956,
                          &H958, &H95A, &H95C, &H95E}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True})
#End Region
#Region "Buddy Killable"
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Red Koco",
                  .IDNum = New List(Of Int32)(New Int32() {&H2C8, &H2CA, &H2CC, &H2CE, &H2D0,
                          &H2D2, &H2D4, &H2D6, &H2D8, &H2DA,
                          &H2DC, &H2DE, &H2E0, &H2E2, &H2E4,
                          &H2E6, &H2E8, &H2EA, &H2EC, &H2EE,
                          &H2F0, &H2F2, &H2F4, &H2F6, &H2F8,
                          &H2FA, &H2FC, &H2FE, &H300, &H302,
                          &H304, &H306, &H8BE, &H8C0}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Green Koco",
                  .IDNum = New List(Of Int32)(New Int32() {&H2B8, &H2BA, &H2BC, &H2BE, &H2C0,
                          &H2C2, &H2C4, &H2C6, &H308, &H30A}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Lurchin",
                  .IDNum = New List(Of Int32)(New Int32() {&H30C, &H30E, &H310, &H312, &H314,
                          &H316, &H318, &H31A, &H31C, &H31E,
                          &H320, &H322, &H324, &H326, &H328,
                          &H32A, &H32C, &H32E, &H330, &H332,
                          &H334, &H336, &H338, &H33A, &H33C,
                          &H33E, &H340, &H342, &H344}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Bazza",
                  .IDNum = New List(Of Int32)(New Int32() {&H66E, &H670, &H672, &H674, &H676,
                          &H678, &H67A, &H67C, &H67E, &H680,
                          &H682, &H684, &H686, &H688, &H68A,
                          &H68C, &H68E, &H690, &H692, &H694,
                          &H696, &H698, &H69A, &H69C, &H69E,
                          &H6A0, &H6A2, &H6A4, &H6A6, &H6A8,
                          &H6AA, &H6AC, &H6AE, &H6B0, &H6B2,
                          &H6B4, &H6B6}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Bounty Bass",
                  .IDNum = New List(Of Int32)(New Int32() {&H6DA, &H6DC, &H6DE, &H6E0, &H6E2,
                          &H6E4, &H6E6, &H6E8, &H6EA, &H6EC}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Klasp",
                  .IDNum = New List(Of Int32)(New Int32() {&H476, &H478, &H47A, &H47C, &H47E,
                          &H480, &H482, &H484, &H486, &H488,
                          &H48A, &H48C, &H48E, &H490, &H492,
                          &H494, &H496, &H498, &H49A, &H49C,
                          &H49E, &H4A0, &H4A2, &H4A4, &H4A6,
                          &H4A8, &H4AA, &H4AC, &H4AE, &H4B0,
                          &H4B2, &H4B4, &H4B6, &H4B8, &H4BA,
                          &H4BC, &H4BE, &H4C0, &H4C2, &H4C4, &H4C6, &H960}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = True,
                  .NonKillable = False}) ' Exploding Barell Damages Enguard and is gone afterwards
#End Region
#Region "Barrel Killable"
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Green Buzz",
                  .IDNum = New List(Of Int32)(New Int32() {&H390, &H392, &H394, &H396,
                          &H398, &H39A, &H39C, &H39E, &H3A0,
                          &H3A2, &H3A4, &H3A6, &H3A8, &H3AA,
                          &H3AC, &H3AE, &H3B0, &H3B2, &H3B4,
                          &H3B6, &H3B8, &H3BA, &H3BC, &H3BE,
                          &H3C0, &H3C2, &H3C4, &H3C6, &H3C8,
                          &H3CA, &H3CC, &H3CE, &H3D0, &H3D2,
                          &H3D4, &H3D6, &H3D8, &H3DA, &H3DC,
                          &H3DE, &H3E0, &H3E2, &H3E4, &H3E6,
                          &H3E8, &H3EA, &H3EC, &H3EE, &H3F0,
                          &H3F2, &H3F4, &H3F6, &H3F8, &H3FA, &H3FC,
                          &H3FE, &H7CE, &H7D0, &H7D2, &H7D4,
                          &H7D6, &H7D8, &H7DA, &H7DC, &H7DE,
                          &H7E0, &H7E2, &H7E4, &H7E6, &H7E8,
                          &H7EA, &H7EC, &H7EE, &H7F0, &H7F2,
                          &H7F4, &H7F6, &H7F8, &H7FA, &H7FC,
                          &H7FE, &H800, &H802, &H804, &H806,
                          &H808, &H80A, &H80C, &H80E, &H810,
                          &H812, &H814, &H816, &H818, &H81A,
                          &H81C, &H81E, &H820, &H822, &H824,
                          &H826, &H828, &H82A, &H82C, &H82E,
                          &H830, &H832, &H834, &H836, &H838,
                          &H83A, &H83C, &H83E, &H840, &H842,
                          &H844, &H846, &H848, &H84A, &H84C,
                          &H84E, &H850, &H852, &H854, &H856,
                          &H858, &H85A, &H85C, &H85E, &H860,
                          &H862, &H864, &H866, &H868, &H86A,
                          &H86C, &H86E, &H870, &H872, &H874,
                          &H876, &H878, &H87A, &H87C, &H87E,
                          &H880, &H882, &H884, &H886, &H888,
                          &H88A, &H88C, &H88E, &H890, &H892,
                          &H894, &H896, &H898, &H89A, &H89C,
                          &H89E, &H8A0, &H8A2, &H89A, &H8A4}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Kuff 'n' Klout",
                  .IDNum = New List(Of Int32)(New Int32() {&H544, &H546, &H548, &H54A, &H54C,
                          &H54E, &H550, &H552, &H554, &H556,
                          &H558, &H55A, &H55C, &H55E, &H560,
                          &H562, &H564, &H566, &H568, &H56A,
                          &H56C, &H56E, &H570}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Koindozer",
                  .IDNum = New List(Of Int32)(New Int32() {&H792, &H794, &H796, &H798, &H79A,
                          &H79C, &H79E, &H7A0, &H7A2, &H7A4,
                          &H7A6, &H7A8, &H7AA}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = False}) 'need a seperate steel barrel eventually TO DO
#End Region
#Region "Killable"
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Sneek",
                  .IDNum = New List(Of Int32)(New Int32() {&H376, &H378, &H37A, &H37C, &H37E,
                          &H380, &H382, &H384, &H386, &H388,
                          &H38A, &H38C, &H38E, &H99A, &H99C}), '&HA9A is unkillable & &HA9C is an event trigger
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = True,
                  .SpinKillable = True,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Re-Koil",
                  .IDNum = New List(Of Int32)(New Int32() {&H524, &H526, &H528, &H52A, &H52C,
                          &H52E, &H530, &H532, &H534, &H536,
                          &H538, &H53A, &H53C, &H53E, &H540,
                          &H542, &H99E, &H9A0, &H9A2, &H9A4,
                          &H9A6, &H9A8, &H9AA, &H9AC, &H9AE,
                          &H9B0, &H9B2, &H9B4, &H9B6}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = True,
                  .SpinKillable = True,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Kobble",
                 .IDNum = New List(Of Int32)(New Int32() {&H572, &H574, &H576, &H578, &H57A,
                         &H57C, &H57E, &H580}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = True,
                 .BarrellKillable = True,
                 .EnguardeKillable = True,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Skidda",
                 .IDNum = New List(Of Int32)(New Int32() {&H582, &H584, &H586, &H588, &H58A}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = True,
                 .BarrellKillable = True,
                 .EnguardeKillable = True,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Lemguins",
                 .IDNum = New List(Of Int32)(New Int32() {&H58C, &H58E, &H590, &H592, &H594,
                         &H596, &H598, &H59A, &H59C, &H59E, &H5A0}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = False,
                 .BarrellKillable = True,
                 .EnguardeKillable = False,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Knocka",
                 .IDNum = New List(Of Int32)(New Int32() {&H5A6, &H5A8, &H5AA, &H5AC, &H962, &H964, &H966}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = False,
                 .BarrellKillable = False,
                 .EnguardeKillable = False,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Krimp",
                 .IDNum = New List(Of Int32)(New Int32() {&H5AE, &H5B0, &H5B2, &H5B4, &H5B6,
                         &H5B8, &H5BA, &H5BC, &H5BE, &H5C0, &H5C2,
                         &H5C4, &H5C6, &H5C8, &H5CA, &H5CC, &H5CE,
                         &H5D0, &H5D2, &H974, &H976, &H978, &H97A,
                         &H97C, &H97E, &H980, &H982}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = True,
                 .BarrellKillable = True,
                 .EnguardeKillable = True,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Bristles",
                 .IDNum = New List(Of Int32)(New Int32() {&H5D4, &H5D6, &H5D8, &H5DA, &H5DC,
                         &H5DE, &H5E0, &H5E2, &H5E4, &H5E6, &H5E8,
                         &H5EA, &H5EC, &H5EE, &H5F0, &H5F2, &H5F4,
                         &H8C2, &H8C4, &H8C6, &H8C8, &H8CA, &H8CC,
                         &H8CE, &H8D0, &H8D2, &H8D4, &H8D6, &H8D8,
                         &H8DA, &H8DC}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = True,
                 .BarrellKillable = True,
                 .EnguardeKillable = True,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                 .Name = "Krumple",
                 .IDNum = New List(Of Int32)(New Int32() {&H5F6, &H5F8, &H5FA, &H5FC, &H5FE,
                         &H600, &H602, &H604, &H606, &H608, &H60A, &H984,
                         &H986, &H988, &H98A, &H98C, &H98E, &H990,
                         &H992, &H994, &H996, &H998}),
                 .Friendly = False,
                 .Floats = False,
                 .JumpKillable = True,
                 .SpinKillable = False,
                 .BarrellKillable = True,
                 .EnguardeKillable = False,
                 .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Knik-Knak",
                  .IDNum = New List(Of Int32)(New Int32() {&H656, &H658, &H660, &H662, &H664,
                          &H666, &H668, &H66A, &H66C, &H7CA, &H7CC}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = True,
                  .SpinKillable = False,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Crawling Knik-Kank",
                  .IDNum = New List(Of Int32)(New Int32() {&H65A, &H65C, &H65E}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = True,
                  .SpinKillable = True,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Booty Bird",
                  .IDNum = New List(Of Int32)(New Int32() {&H6B8, &H6BA, &H6BC, &H6BE, &H6C0,
                          &H6C2, &H6C4, &H6C6, &H6C8, &H6CA,
                          &H6CC, &H6CE, &H6D0, &H6D2, &H6D4,
                          &H6D6, &H6D8}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = True,
                  .SpinKillable = True,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False})
#End Region
#Region "Temp Not Placeable"
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Sneek In Wheel",
                  .IDNum = New List(Of Int32)(New Int32() {&H4EE, &H4F0, &H4F2, &H4F4, &H4F6,
                          &H4F8, &H4FA, &H4FC, &H4FE, &H500,
                          &H502, &H504, &H506, &H508, &H50A,
                          &H50C, &H50E, &H510, &H512}),
                  .Friendly = False,
                  .Floats = False,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False,
                  .Placeable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Swoopy",
                  .IDNum = New List(Of Int32)(New Int32() {&H60C, &H60E, &H610, &H612, &H614,
                          &H616, &H618, &H61A, &H61C, &H61E,
                          &H620, &H622, &H624, &H626, &H628,
                          &H62A, &H62C, &H62E, &H630, &H632,
                          &H634, &H636, &H638, &H63A, &H63C,
                          &H63E, &H640, &H642}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = True,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .SquaksKillable = True,
                  .NonKillable = False,
                  .Placeable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "BEES",
                  .IDNum = New List(Of Int32)(New Int32() {&HA84, &HA86, &HA88, &HA8A, &HA8C,
                          &HA8E, &HA90, &HA92, &HA94, &HA96}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True,
                  .Placeable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Nibbla",
                  .IDNum = New List(Of Int32)(New Int32() {&H76C, &H76E, &H770, &H772, &H774,
                          &H776, &H778, &H77A, &H77C, &H77E,
                          &H780, &H782, &H784, &H786, &H788,
                          &H78A, &H78C}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True,
                  .Placeable = False}) 'I will need to add a lot more testing to avoid crashed with Nibbla..
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Krosshair",
                  .IDNum = New List(Of Int32)(New Int32() {&H7AC}), '&H7AC doesn't seem to work
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = False,
                  .EnguardeKillable = False,
                  .NonKillable = True,
                  .Placeable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Fake Red Buzz",
                  .IDNum = New List(Of Int32)(New Int32() {&H5A, &H5C}),
                  .Friendly = False,
                  .Floats = True,
                  .JumpKillable = False,
                  .SpinKillable = False,
                  .BarrellKillable = True,
                  .EnguardeKillable = True,
                  .NonKillable = False,
                  .Placeable = False})
#End Region
#Region "Non-Placeable"
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Ellie Barrel",
                  .IDNum = New List(Of Int32)(New Int32() {&H164, &H16E}),
                  .Placeable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "DK Barrel",
                  .IDNum = New List(Of Int32)(New Int32() {&H260}),
                  .Placeable = False})
        FullEnemyList.Add(New EnemyClass() With {
                  .Name = "Steel Door",
                  .IDNum = New List(Of Int32)(New Int32() {&H514, &H516, &H518, &H51A}),
                  .Placeable = False})
#End Region
    End Sub
    Public Function GetEnemyObject(RequestedID As Int32) As EnemyClass
        If FullEnemyList.Count = 0 Then Return Nothing
        For i As Integer = 0 To FullEnemyList.Count - 1
                If FullEnemyList(i).IDNum.Contains(RequestedID) Then
                    Return FullEnemyList(i)
                End If
            Next
            MessageBox.Show("Enemy ID: " & Hex(RequestedID) & " Not Found!")
        Return Nothing
    End Function
End Class
