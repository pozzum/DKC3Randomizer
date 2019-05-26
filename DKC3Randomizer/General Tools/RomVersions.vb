Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms 'MessageBoxes
Public Class RomVersions
#Region "Hash Functions"
    'http://us.informatiweb.net/tutorials/programing/1-vb-net/36--generate-hashes-md5-sha-1-and-sha-256-of-a-file.html
    Shared Function Md5Hash(ByVal FileName As String)
        Return HashGenerator("md5", FileName)
    End Function
    Shared Function HashGenerator(ByVal HashType As String, ByVal FileName As String)
        ' We declare the variable: hash
        Dim Hash
        If HashType.ToLower = "md5" Then
            ' Initializes a hash object : md5
            Hash = MD5.Create
        ElseIf HashType.ToLower = "sha1" Then
            ' Initializes a hash object : SHA-1
            Hash = SHA1.Create()
        ElseIf HashType.ToLower = "sha256" Then
            ' Initializes a hash object : SHA-256
            Hash = SHA256.Create()
        Else
            MsgBox("Type of hash unknown : " & HashType, MsgBoxStyle.Critical)
            Return False
        End If
        ' We declare a variable that will be an array of bytes (bytes)
        Dim HashValue() As Byte
        Try
            ' We create a FileStream for the file passed as a parameter
            Dim FileStream As FileStream = File.OpenRead(FileName)
            ' We position the cursor at the beginning of the stream
            FileStream.Position = 0
            ' The hash of the file
            HashValue = Hash.ComputeHash(FileStream)
            ' The Byte array Is converted to hexadecimal for easy reading
            Dim HashHex = PrintByteArray(HashValue)
            ' The open file Is closed
            FileStream.Close()
            ' Return the hash
            Return HashHex
        Catch
            MessageBox.Show("Error occurred! Try Again.")
        End Try
        'if file open fails
        Return Nothing
    End Function
    ' One parses the array Of bytes (bytes) And converts Each Byte (Byte) To hexadecimal
    Public Shared Function PrintByteArray(ByVal Array() As Byte)
        Dim HexValue As String = ""
        ' The Byte array (bytes)
        Dim i As Integer
        For i = 0 To Array.Length - 1
            ' Each byte Is converted to hexadecimal
            HexValue += Array(i).ToString("X2")
        Next i
        ' Return the string to lowercase
        Return HexValue.ToUpper
    End Function
#End Region
    Public Enum RomVersion
        Unknown
        U_1_0
        U_1_1
        U_1_2
        J_1_0
        J_1_1
        E_1_0
    End Enum
    Public Shared CurrentHashString As String
    Public Shared CurrentROMVersion As RomVersion
    Shared Function CheckRomHash(EXEFilePath)
        CurrentHashString = Md5Hash(EXEFilePath)
        'MessageBox.Show(CurrentHashString)
        If CurrentHashString = "120ABF304F0C40FE059F6A192ED4F947" Then
            'Tool initially developeed for this version
            CurrentROMVersion = RomVersion.U_1_0
            Return True
        ElseIf CurrentHashString = "8020ED7A10BCCE0236E8497DF5318715" Then ' "0E94BDBA4CD4FA7A9D9B1C6BB312D144" Then
            CurrentROMVersion = RomVersion.J_1_0
            Return True
        ElseIf CurrentHashString = "D0CEFE1D11D0F84F98227A549E6E93B6" Then
            CurrentROMVersion = RomVersion.J_1_1
            Return True
        ElseIf CurrentHashString = "FC3333AF2F93D7DD0A4190A01D49A69E" Then
            CurrentROMVersion = RomVersion.E_1_0
            Return True
        Else MessageBox.Show("Game version is unknown randomizer will not run." & vbNewLine &
                                    "File Hash: " & CurrentHashString & vbNewLine)
            Return False
        End If
    End Function
    Shared Function GetVersionString() As String
        Select Case CurrentROMVersion
            Case RomVersion.Unknown
                Return "Unknown"
            Case RomVersion.U_1_0
                Return "US Version 1.0"
            Case RomVersion.U_1_1
                Return "US Version 1.1"
            Case RomVersion.U_1_2
                Return "US Version 1.2"
            Case RomVersion.J_1_0
                Return "JP Version 1.0"
            Case RomVersion.J_1_1
                Return "JP Version 1.1"
            Case RomVersion.E_1_0
                Return "EU Version 1.0"
            Case Else
                Return "Unkown"
        End Select
    End Function
End Class
