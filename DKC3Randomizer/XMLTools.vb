Imports System.IO
Imports DKC3Randomizer.LevelInformation
Public Class XMLTools
    Shared Sub ExportXMLFile(SentPath As String)
        If SentPath = My.Settings.XMLSaveLocation AndAlso My.Settings.XMLLimited Then
            LimitXMLCount(SentPath, My.Settings.XMLLimitCount - 1)
        End If
        Dim SavedPath As String
        If SentPath.EndsWith(".xml") Then
            SavedPath = SentPath
        ElseIf SentPath.EndsWith(".exe") Then
            SavedPath = Path.GetDirectoryName(SentPath) & Path.DirectorySeparatorChar &
                My.Settings.PreviousSeed.ToString & ".xml"
        Else 'sent path should have directory already appended
            SavedPath = SentPath & Path.GetFileNameWithoutExtension(My.Settings.RandoRomFilePath) & " " & My.Settings.PreviousSeed.ToString & ".xml"
            'generaltools check file ''''will add (1) (2) ect instead of overwriting
        End If
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(List(Of SpawnClass)))
        Dim file As New System.IO.StreamWriter(
            SavedPath)
        writer.Serialize(file, Randomizer.ActiveLevelInformation.FullSpawnList)
        file.Close()
    End Sub
    Shared Sub ImportXMLFile(SentPath As String)
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(List(Of SpawnClass)))
        Dim file As New System.IO.StreamReader(
            SentPath)
        Randomizer.ActiveLevelInformation.FullSpawnList = reader.Deserialize(file)
        file.Close()
    End Sub
    Shared Function GetXMLCount(SentPath As String)
        Dim CountofXLMFiles As Integer = 0
        Dim TempDirectory As New DirectoryInfo(SentPath)
        Dim FileList() As FileInfo = TempDirectory.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
        For Each TempXML As FileInfo In FileList
            Dim TempLines As String() = IO.File.ReadAllLines(TempXML.FullName)
            If TempLines.Length > 2 Then
                If TempLines(1).StartsWith("<ArrayOfSpawnClass ") Then
                    CountofXLMFiles += 1
                End If
            End If
        Next
        Return CountofXLMFiles
    End Function
    Shared Sub LimitXMLCount(SentPath As String, LimitCount As Integer)
        Dim CountofXLMFiles As Integer = 0
        Dim TempDirectory As New DirectoryInfo(SentPath)
        Dim FileList() As FileInfo = TempDirectory.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
        Array.Sort(Of FileInfo) _
    (
    FileList,
    New Comparison(Of FileInfo) _
        (
        Function(f1 As FileInfo, f2 As FileInfo) File.GetCreationTime(f2.FullName).CompareTo(File.GetCreationTime(f1.FullName))
        )
    )
        Dim DeletionList As List(Of String) = New List(Of String)
        For Each TempXML As FileInfo In FileList
            Dim TempLines As String() = IO.File.ReadAllLines(TempXML.FullName)
            If TempLines.Length > 2 Then
                If TempLines(1).StartsWith("<ArrayOfSpawnClass ") Then
                    CountofXLMFiles += 1
                    If CountofXLMFiles > LimitCount Then
                        DeletionList.Add(TempXML.FullName)
                    End If
                End If
            End If
        Next
        If DeletionList.Count > 0 Then
            For i As Integer = 0 To DeletionList.Count - 1
                File.Delete(DeletionList(i))
            Next
        End If
    End Sub
End Class
