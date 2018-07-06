Option Strict Off
Option Explicit On

Public Class ChildTextForm
    Private m_FilePath As String
    Private m_Saved As Boolean = False
    Private m_Init_Top As Integer
    Private m_Init_Left As Integer
    Private m_Init_Height As Integer
    Private m_Init_Width As Integer

    Public Sub New(ByVal filePath As String, ByVal newFlag As Boolean, ByVal yukoFlag As Boolean, ByVal top As Integer, ByVal left As Integer, ByVal initHeight As Integer, ByVal initWidth As Integer)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        m_FilePath = filePath
        Me.Text = System.IO.Path.GetFileName(m_FilePath)

        If newFlag Then
            IO.File.Create(m_FilePath).Dispose()
        End If

        chk_Yuko.Checked = yukoFlag
        If chk_Yuko.Checked Then
            Me.BackColor = Color.AliceBlue
        Else
            Me.BackColor = Color.Red
        End If

        m_Init_Top = top
        m_Init_Left = left

        m_Init_Height = initHeight
        m_Init_Width = initWidth
    End Sub

    Public ReadOnly Property YukoFlag As Boolean
        Get
            Return chk_Yuko.Checked
        End Get
    End Property

    Public ReadOnly Property Saved As Boolean
        Get
            Return m_Saved
        End Get
    End Property

    Private Sub KoTextForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static activated As Boolean
        If Not activated Then
            Me.Location = New Point(m_Init_Left, m_Init_Top)
            lbl_Locate.Text = "(" & Me.Left.ToString() & ", " & Me.Top.ToString() & ")"
            Me.Height = m_Init_Height
            Me.Width = m_Init_Width

            activated = True
        End If
    End Sub

    Private Sub KoTextForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getText()
    End Sub

    Private Sub getText()
        Using reader As New IO.StreamReader(m_FilePath)
            txt_Naiyo.Text = reader.ReadToEnd()
        End Using
        txt_Naiyo.BackColor = Color.White
        m_Saved = True
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        saveText()
    End Sub

    Private Sub saveText()
        Using writer As New IO.StreamWriter(m_FilePath)
            writer.Write(txt_Naiyo.Text)
        End Using
        txt_Naiyo.BackColor = Color.White
        m_Saved = True
    End Sub

    Private Sub btn_Re_Read_Click(sender As Object, e As EventArgs) Handles btn_Re_Read.Click
        getText()
    End Sub


    Private Sub txt_Naiyo_TextChanged(sender As Object, e As EventArgs) Handles txt_Naiyo.TextChanged
        txt_Naiyo.BackColor = Color.Beige
        m_Saved = False
    End Sub

    Public Sub resetLocation(ByVal top As Integer, ByVal left As Integer)
        Me.Top = top
        Me.Left = left
        Me.Width = G_KO_LENGTH
        Me.Height = G_KO_LENGTH
    End Sub

    Private Sub ChildTextForm_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        lbl_Locate.Text = "(" & Me.Left.ToString() & ", " & Me.Top.ToString() & ")"
    End Sub

    Private Sub chk_Yuko_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Yuko.CheckedChanged
        If chk_Yuko.Checked Then
            Me.BackColor = Color.AliceBlue
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class