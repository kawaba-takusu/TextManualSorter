Option Strict Off
Option Explicit On

Public Class ParentForm
    Private m_Current_Folder As String = vbNullString

    Public m_ChildMovedFlag As Boolean = False

    Private Sub OyaForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If mnu_Save_Locations.Enabled AndAlso m_ChildMovedFlag Then
                If MsgBox("各ファイルの位置を保存しますか？", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    saveLocations()
                End If
            End If
        End If
    End Sub

    Private Sub OyaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_Current_Folder = vbNullString
        mnu_Open_Folder.Enabled = True
        mnu_Output.Enabled = False
        mnu_Save_Locations.Enabled = False
        mnu_Reset_Locations.Enabled = False

        Dim cmdArgs = My.Application.CommandLineArgs

        If 1 < cmdArgs.Count Then
            MessageBox.Show("複数の引数が指定されています。")
        End If

        For Each oneCommand As String In cmdArgs
            If IO.Directory.Exists(oneCommand) Then
                setFolder(oneCommand)
                Exit For
            End If
        Next

    End Sub

    Private Sub mnu_Open_Folder_Click(sender As Object, e As EventArgs) Handles mnu_Open_Folder.Click
        Dim currentFolder As String = getFolder()
        If currentFolder <> vbNullString Then
            setFolder(currentFolder)
        End If
    End Sub

    Private Function getSavedChildrenLocations(ByVal xmlPath As String) As Dictionary(Of String, ChildSortKeys)
        Dim dic As New Dictionary(Of String, ChildSortKeys)

        Using reader As System.Xml.XmlReader = System.Xml.XmlReader.Create(xmlPath)
            Dim key As String = vbNullString
            Dim top As Integer
            Dim left As Integer
            Dim enabledFlag As Boolean
            Dim initHeight As Integer
            Dim initWidth As Integer
            Do While reader.Read()
                If reader.NodeType = Xml.XmlNodeType.Element Then
                    Select Case reader.LocalName
                        Case G_YOUSO_FILENAME
                            key = reader.NamespaceURI
                        Case G_YOUSO_HEIGHT
                            initHeight = Integer.Parse(reader.NamespaceURI)
                        Case G_YOUSO_WIDTH
                            initWidth = Integer.Parse(reader.NamespaceURI)
                        Case G_YOUSO_TOP
                            top = Integer.Parse(reader.NamespaceURI)
                        Case G_YOUSO_LEFT
                            left = Integer.Parse(reader.NamespaceURI)
                        Case G_YOUSO_ENABLED_FLAG
                            enabledFlag = Boolean.Parse(reader.NamespaceURI)
                            dic.Add(m_Current_Folder & "\" & key, New ChildSortKeys(top, left, key, enabledFlag, initHeight, initWidth))
                        Case Else

                    End Select

                End If
            Loop
            'リーダーを閉じる
            reader.Close()
        End Using

        Return dic
    End Function

    Private Sub addChild(ByVal filePath As String, ByVal newFlag As Boolean, ByVal yukoFlag As Boolean, ByVal initTop As Integer, ByVal initLeft As Integer, ByVal initHeight As Integer, ByVal initWidth As Integer)
        Dim child As New ChildTextForm(filePath, newFlag, yukoFlag, initTop, initLeft, initHeight, initWidth)
        child.MdiParent = Me
        child.Show()
        addEvents(child)
    End Sub

    Private Sub setChildrenFromDic(ByRef dic As Dictionary(Of String, ChildSortKeys), ByRef files() As String)
        Dim newFiles As New List(Of String)
        Dim maxTopLocate As Integer = 0
        For Each oneFile As String In files
            If IO.Path.GetExtension(oneFile).ToLower() = G_TXT_EXTENSION.ToLower() Then
                If dic.ContainsKey(oneFile) Then
                    addChild(oneFile, False, dic(oneFile).EnabledFlag, dic(oneFile).Top, dic(oneFile).Left, dic(oneFile).Height, dic(oneFile).Width)

                    If maxTopLocate < (dic(oneFile).Top + dic(oneFile).Height) Then
                        maxTopLocate = dic(oneFile).Top + dic(oneFile).Height
                    End If
                Else
                    newFiles.Add(oneFile)
                End If
            End If
        Next
        If 0 < newFiles.Count Then
            Dim topIndex As Integer = 0
            Dim leftIndex As Integer = 0
            For Each newFile As String In newFiles
                addChild(newFile, False, True, maxTopLocate + topIndex * G_KO_LENGTH, leftIndex * G_KO_LENGTH, G_KO_LENGTH, G_KO_LENGTH)

                leftIndex += 1
                If leftIndex = G_KO_YOKO_KOSUU Then
                    leftIndex = 0
                    topIndex += 1
                End If
            Next
        End If
    End Sub

    Private Sub setChildrenFromFiles(ByRef files() As String)
        Dim topIndex As Integer = 0
        Dim leftIndex As Integer = 0
        For Each oneFile As String In files
            If IO.Path.GetExtension(oneFile).ToLower() = G_TXT_EXTENSION.ToLower() Then
                addChild(oneFile, False, True, topIndex * G_KO_LENGTH, leftIndex * G_KO_LENGTH, G_KO_LENGTH, G_KO_LENGTH)

                leftIndex += 1
                If leftIndex = G_KO_YOKO_KOSUU Then
                    leftIndex = 0
                    topIndex += 1
                End If
            End If
        Next
    End Sub

    Private Sub setFolder(ByVal currentFolder As String)
        m_Current_Folder = currentFolder
        If m_Current_Folder <> vbNullString Then
            Dim dic As New Dictionary(Of String, ChildSortKeys)

            If IO.File.Exists(m_Current_Folder & "\" & G_SETTING_XML) Then
                dic = getSavedChildrenLocations(m_Current_Folder & "\" & G_SETTING_XML)
            End If

            Dim files() As String = IO.Directory.GetFiles(m_Current_Folder)
            If 0 < dic.Count Then
                setChildrenFromDic(dic, files)
            Else
                setChildrenFromFiles(files)
            End If

            Me.Text = m_Current_Folder
            mnu_Open_Folder.Enabled = False
            mnu_Output.Enabled = True
            mnu_Save_Locations.Enabled = True
            mnu_Reset_Locations.Enabled = True
        End If
    End Sub


    Private Sub mnu_Save_Locations_Click(sender As Object, e As EventArgs) Handles mnu_Save_Locations.Click
        saveLocations()
    End Sub

    Private Sub saveLocations()
        Dim sortKeys As New List(Of ChildSortKeys)

        For Each child As ChildTextForm In Me.MdiChildren
            sortKeys.Add(New ChildSortKeys(child.Top, child.Left, child.Text, child.YukoFlag, child.Height, child.Width))
        Next

        Dim settings As New Xml.XmlWriterSettings()
        settings.Indent = True
        settings.NewLineOnAttributes = True
        settings.OmitXmlDeclaration = True
        Dim writer As Xml.XmlWriter = Xml.XmlWriter.Create(m_Current_Folder & "\" & G_SETTING_XML, settings)
        writer.WriteStartDocument()
        writer.WriteStartElement("book", Nothing)
        writer.WriteStartElement("data", Nothing)
        For Each youso As ChildSortKeys In sortKeys
            writer.WriteStartElement(G_YOUSO_FILENAME, youso.FileName)
            writer.WriteStartElement(G_YOUSO_HEIGHT, youso.Height.ToString())
            writer.WriteEndElement()
            writer.WriteStartElement(G_YOUSO_WIDTH, youso.Width.ToString())
            writer.WriteEndElement()
            writer.WriteStartElement(G_YOUSO_TOP, youso.Top.ToString())
            writer.WriteEndElement()
            writer.WriteStartElement(G_YOUSO_LEFT, youso.Left.ToString())
            writer.WriteEndElement()
            writer.WriteStartElement(G_YOUSO_ENABLED_FLAG, youso.EnabledFlag.ToString())
            writer.WriteEndElement()
            writer.WriteEndElement()
        Next
        writer.WriteEndDocument()
        writer.Flush()
        writer.Close()
        writer.Dispose()

        m_ChildMovedFlag = False

    End Sub

    Private Function getSetteingsForMerge(ByRef mode As Settings.SeparatorMode, ByRef useFileNameFlag As Boolean, ByRef hValue As Integer) As Boolean
        Dim okClicked As Boolean = False
        Using st As New Settings()
            st.ShowDialog(Me)
            mode = st.Mode
            useFileNameFlag = st.UseFileName
            hValue = st.HValue
            okClicked = st.OkClicked
        End Using
        Return okClicked
    End Function

    Private Sub writeMergeText(ByVal saveFileName As String,
                               ByRef sorted As IOrderedEnumerable(Of ChildSortKeys),
                               ByVal mode As Settings.SeparatorMode,
                               ByVal useFileNameFlag As Boolean,
                               ByVal hValue As Integer)
        Dim firstFlag As Boolean = True
        Using writer As New IO.StreamWriter(saveFileName)
            For Each c As ChildSortKeys In sorted
                If IO.File.Exists(m_Current_Folder & "\" & c.FileName) Then
                    If Not firstFlag Then
                        Select Case mode
                            Case Settings.SeparatorMode.Tag
                                writer.WriteLine("<p> <br /> </p>")
                            Case Settings.SeparatorMode.Tag2
                                writer.WriteLine("<p> <br /> </p> <p> <br /> </p>")
                            Case Settings.SeparatorMode.None
                        End Select
                    End If
                    Using reader As New IO.StreamReader(m_Current_Folder & "\" & c.FileName)
                        If useFileNameFlag Then
                            writer.WriteLine(Strings.StrDup(hValue, "#") & " " & IO.Path.GetFileNameWithoutExtension(c.FileName))
                        End If
                        writer.WriteLine(reader.ReadToEnd())
                    End Using
                    firstFlag = False
                Else
                    MsgBox(c.FileName & "は削除された可能性があります。", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly)
                End If
            Next
        End Using
    End Sub

    Private Sub writeRenketuText()
        Dim saveFileName As String = getFilePath()
        If saveFileName <> vbNullString Then
            Dim mode As Settings.SeparatorMode
            Dim useFileNameFlag As Boolean
            Dim hValue As Integer
            Dim okClicked As Boolean = False

            If getSetteingsForMerge(mode, useFileNameFlag, hValue) Then
                Dim sortKeys As New List(Of ChildSortKeys)

                For Each child As ChildTextForm In Me.MdiChildren
                    If child.YukoFlag Then
                        sortKeys.Add(New ChildSortKeys(child.Top, child.Left, child.Text, child.YukoFlag, child.Height, child.Width))
                    End If
                Next

                Dim sorted = From c In sortKeys
                             Order By c.Top, c.Left

                writeMergeText(saveFileName, sorted, mode, useFileNameFlag, hValue)

                MsgBox("ファイルが作成されました。", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly)
            Else
                MsgBox("キャンセルされました。", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly)
            End If
        Else
            MsgBox("キャンセルされました。", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub mnu_Output_Click(sender As Object, e As EventArgs) Handles mnu_Output.Click
        writeRenketuText()
    End Sub

    Private Sub sortKoForms(ByVal colCount As Integer)
        Dim sortKeys As New List(Of ChildSortKeys)

        For Each ko As ChildTextForm In Me.MdiChildren
            sortKeys.Add(New ChildSortKeys(ko.Top, ko.Left, ko.Text, ko.YukoFlag, ko.Height, ko.Width))
        Next

        Dim sorted = From c In sortKeys
                     Order By c.Top, c.Left

        Dim topIndex As Integer = 0
        Dim leftIndex As Integer = 0
        For Each target As ChildSortKeys In sorted
            For Each child As ChildTextForm In Me.MdiChildren
                If target.FileName = child.Text Then
                    child.resetLocation(topIndex * G_KO_LENGTH, leftIndex * G_KO_LENGTH)
                    leftIndex += 1
                    If leftIndex = colCount Then
                        leftIndex = 0
                        topIndex += 1
                    End If
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub mnu_Reset_Locations_Click(sender As Object, e As EventArgs) Handles mnu_Reset_Locations.Click
        'sortKoForms()
    End Sub

    Private Sub mnu_Sort_Col_1_Click(sender As Object, e As EventArgs) Handles mnu_Sort_Col_1.Click
        sortKoForms(1)
    End Sub

    Private Sub mnu_Sort_Col_2_Click(sender As Object, e As EventArgs) Handles mnu_Sort_Col_2.Click
        sortKoForms(2)
    End Sub

    Private Sub mnu_Sort_Col_3_Click(sender As Object, e As EventArgs) Handles mnu_Sort_Col_3.Click
        sortKoForms(3)
    End Sub

    Private Sub mnu_Sort_Col_4_Click(sender As Object, e As EventArgs) Handles mnu_Sort_Col_4.Click
        sortKoForms(4)
    End Sub

    Private Sub mnu_Sort_Col_5_Click(sender As Object, e As EventArgs) Handles mnu_Sort_Col_5.Click
        sortKoForms(5)
    End Sub

    Private Sub mnu_Version_Click(sender As Object, e As EventArgs) Handles mnu_Version.Click
        Dim versionMoji As String = String.Empty
        versionMoji = G_EXE_NAME & vbCrLf &
                      "Ver." & My.Application.Info.Version.ToString() & vbCrLf &
                      My.Application.Info.Copyright


        MsgBox(versionMoji, MsgBoxStyle.Information)
    End Sub

    Private Sub ChildTextFormMove(sender As Object, e As EventArgs)
        m_ChildMovedFlag = True
    End Sub

    Private Sub chkYukoCheckedChanged(sender As Object, e As EventArgs)
        m_ChildMovedFlag = True
    End Sub

    Private Sub addEvents(ByRef child As ChildTextForm)
        AddHandler child.Move, AddressOf Me.ChildTextFormMove
        AddHandler child.chk_Yuko.CheckedChanged, AddressOf Me.chkYukoCheckedChanged
    End Sub
End Class


