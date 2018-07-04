Option Strict Off
Option Explicit On

Public Class ChildSortKeys
    Private m_Top As Integer
    Private m_Left As Integer
    Private m_FileName As String = vbNullString
    Private m_EnabledFlag As Boolean
    Private m_Height As Integer
    Private m_Width As Integer

    Public Sub New(ByVal top As Integer, ByVal left As Integer, ByVal fileName As String, ByVal enabledFlag As Boolean, ByVal height As Integer, ByVal width As Integer)
        m_Top = top
        m_Left = left
        m_FileName = fileName
        m_EnabledFlag = enabledFlag
        m_Height = height
        m_Width = width
    End Sub

    Public ReadOnly Property Top As Integer
        Get
            Return m_Top
        End Get
    End Property

    Public ReadOnly Property Left As Integer
        Get
            Return m_Left
        End Get
    End Property

    Public ReadOnly Property FileName As String
        Get
            Return m_FileName
        End Get
    End Property

    Public ReadOnly Property EnabledFlag As Boolean
        Get
            Return m_EnabledFlag
        End Get
    End Property

    Public ReadOnly Property Height As Integer
        Get
            Return m_Height
        End Get
    End Property

    Public ReadOnly Property Width As Integer
        Get
            Return m_Width
        End Get
    End Property
End Class
