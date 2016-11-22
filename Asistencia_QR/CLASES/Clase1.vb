Public Enum estado_de_la_clase As Byte
    no_iniciado = 0
    iniciado = 1
End Enum
Public Class Clase
    Private ID_materia As Long
    Private estado_clase As estado_de_la_clase
    Private ID_Clase_ As Long
    Private hora As Integer
    Private minuto As Integer
    Private segundo As Integer

    Sub New()

    End Sub

    Public Property Hora_ As Integer
        Get
            Return hora
        End Get
        Set(value As Integer)
            hora = value
        End Set

    End Property
    Public Property Minuto_ As Integer
        Get
            Return minuto

        End Get
        Set(value As Integer)
            minuto = value
        End Set

    End Property
    Public Property Segundo_ As Integer
        Get
            Return segundo

        End Get
        Set(value As Integer)
            segundo = value
        End Set

    End Property

    Public Property ID_CLASE As Long
        Get
            Return ID_CLASE
        End Get
        Set(value As Long)
            ID_Clase_ = value
        End Set

    End Property

    Public Property ID_Materia_ As Long
        Get
            Return Me.ID_materia
        End Get
        Set(value As Long)
            Me.ID_materia = value
        End Set

    End Property
    Public Property Estado_Clase_() As estado_de_la_clase
        Get
            Return estado_clase
        End Get
        Set(ByVal value As estado_de_la_clase)
            estado_clase = value
        End Set
    End Property


End Class
