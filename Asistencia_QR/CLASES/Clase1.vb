Public Enum estado_de_la_clase As Byte
    no_iniciado = 0
    iniciado = 1
End Enum
Public Class Clase
    Private clase_nro As Integer
    Private fecha_inicio As Date
    Private opersona As New Persona
    Private oconeccion As New coneccion
    Private hora As Integer = 2
    Private minutos As Integer = 0
    Private segundo As Integer = 0
    Private estado_clase As estado_de_la_clase

    Sub New()

    End Sub

    Public ReadOnly Property consultar_Hora As String
        Get
            Return hora
        End Get

    End Property
    Public ReadOnly Property consultar_minuto As String
        Get
            Return minutos

        End Get

    End Property
    Public ReadOnly Property consultar_segundo As String
        Get
            Return segundo

        End Get

    End Property

    Public Property Estado_Clase_() As estado_de_la_clase
        Get
            Return estado_clase
        End Get
        Set(ByVal value As estado_de_la_clase)
            estado_clase = value
        End Set
    End Property
    Public Sub hora_de_inicio_()

        If (hora And minutos And segundo) = 0 Then
            MsgBox("Clase FINALIZADA")
            Form1.HORA_TIMER.Stop()
            estado_clase = 0 'clase terminada
        Else
            If Not segundo = 0 Then
                segundo -= 1
            Else
                If Not minutos = 0 Then
                    minutos -= 1
                Else
                    hora -= 1

                End If

            End If
        End If

    End Sub
End Class
