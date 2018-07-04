Option Strict Off
Option Explicit On

Public Class Settings
    Public Enum SeparatorMode
        Tag
        Tag2
        None
    End Enum

    Private m_Mode As SeparatorMode

    Private m_OkClicked As Boolean = False

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opt_None.Checked = True
        m_Mode = SeparatorMode.None

        chk_WriteFileName.Checked = False
        tb_h.Value = 2
    End Sub

    Public ReadOnly Property Mode As SeparatorMode
        Get
            Return m_Mode
        End Get
    End Property

    Public ReadOnly Property UseFileName As Boolean
        Get
            Return chk_WriteFileName.Checked
        End Get
    End Property

    Public ReadOnly Property HValue As Integer
        Get
            Return tb_h.Value
        End Get
    End Property

    Public ReadOnly Property OkClicked As Boolean
        Get
            Return m_OkClicked
        End Get
    End Property

    Private Sub opt_None_Click(sender As Object, e As EventArgs) Handles opt_None.Click
        m_Mode = SeparatorMode.None
    End Sub

    Private Sub opt_Tag_Click(sender As Object, e As EventArgs) Handles opt_Tag.Click
        m_Mode = SeparatorMode.Tag
    End Sub

    Private Sub opt_Tag2_Click(sender As Object, e As EventArgs) Handles opt_Tag2.Click
        m_Mode = SeparatorMode.Tag2
    End Sub

    Private Sub btn__Ok_Click(sender As Object, e As EventArgs) Handles btn__Ok.Click
        m_OkClicked = True
        Me.Close()
    End Sub
End Class