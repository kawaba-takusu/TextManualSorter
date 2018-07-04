Option Strict Off
Option Explicit On

Module Utils
    Public Const G_KO_LENGTH As Integer = 350
    Public Const G_KO_YOKO_KOSUU As Integer = 4

    Public Const G_SETTING_XML As String = "_sortkun_setting.xml"
    Public Const G_TXT_EXTENSION As String = ".txt"

    Public Const G_EXE_NAME As String = "テキストファイル手動ソートくん"

    Public Const G_YOUSO_FILENAME As String = "name"
    Public Const G_YOUSO_HEIGHT As String = "height"
    Public Const G_YOUSO_WIDTH As String = "width"
    Public Const G_YOUSO_TOP As String = "top"
    Public Const G_YOUSO_LEFT As String = "left"
    Public Const G_YOUSO_ENABLED_FLAG As String = "yuko"

    Public Function getFolder() As String
        Dim result As String = vbNullString

        Using fbd As New FolderBrowserDialog()
            'fbd.RootFolder = Environment.SpecialFolder.MyDocuments
            If fbd.ShowDialog() = DialogResult.OK Then
                result = fbd.SelectedPath
            End If
        End Using

        Return result
    End Function

    Public Function getFilePath() As String
        Dim result As String = vbNullString

        Using sfd As New SaveFileDialog()
            sfd.Filter = "テキストドキュメント|*.txt|マークダウン形式|*.md|すべてのファイル|*.*"
            If sfd.ShowDialog() = DialogResult.OK Then
                result = sfd.FileName
            End If
        End Using

        Return result
    End Function

    Public Function checkFileName(ByVal fileName As String) As Boolean
        Dim result As Boolean = True
        Dim dameFileMoji As Char() = System.IO.Path.GetInvalidFileNameChars()

        If result Then
            If 0 < InStr(fileName, "\") Then
                result = False
            End If
        End If

        If result Then
            For Each dameChar As Char In dameFileMoji
                If 0 < InStr(fileName, dameChar.ToString()) Then
                    result = False
                    Exit For
                End If
            Next
        End If

        If result Then
            Dim dameFileNames() As String = {"CON", "PRN", "AUX", "NUL", "COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT0", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9", "CLOCK$"}
            For Each dameFileName As String In dameFileNames
                If IO.Path.GetFileNameWithoutExtension(fileName).ToUpper() = dameFileName Then
                    result = False
                    Exit For
                End If
            Next
        End If

        If result Then
            If fileName.Substring(0, 1) = "." Then
                result = False
            End If
        End If

        Return result
    End Function

End Module



