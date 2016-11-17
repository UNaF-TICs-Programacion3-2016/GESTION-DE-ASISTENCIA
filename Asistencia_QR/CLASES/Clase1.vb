Public Enum estado_de_la_clase As Byte
    no_iniciado = 0
    iniciado = 1
End Enum
Public Class Clase
    Private Nombre_Clase As String
    Private fecha_inicio As Date
    Private ID As Long
    Private oconeccion As New coneccion
    Private hora, minuto, segundo As Integer
    Private estado_clase As estado_de_la_clase
    Private COMISION As Integer
    Private ID_materia As Long

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
    Public Property nombre_clase_ As String
        Get
            Return Nombre_Clase

        End Get
        Set(value As String)
            Nombre_Clase = value
        End Set

    End Property
    Public Property ID_ As Long
        Get
            Return ID
        End Get
        Set(value As Long)
            ID = value
        End Set

    End Property
    Public Property ID_COMISION As Integer
        Get
            Return COMISION
        End Get
        Set(value As Integer)
            COMISION = value
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
    Public Sub TEMPORIZADOR()
        If hora = 0 And minuto = 0 And segundo = 0 Then
            Form_inicio.HORA_TIMER.Stop()
            MsgBox("Clase FINALIZADA")
            estado_clase = 0 'clase terminada
        Else
            If Not segundo = 0 Then
                segundo -= 1
            Else
                If Not minuto = 0 Then
                    minuto -= 1
                    segundo = 59
                Else
                    hora -= 1
                    minuto = 59
                    segundo = 59
                End If
            End If
        End If
    End Sub

End Class
