Public Class Asistencia
    Inherits coneccion
    Private clase As Clase
    Private coneccion As coneccion
    Private alumno As alumno

    Public Sub New(ByVal hora As String, ByVal id_alumno As Long)

    End Sub
    Public Sub insertar_PRESENTE()

        Dim fecha_y_hora As Date = String.Format("{0:G}", DateTime.Now)

        coneccion.Insertar_Asistencia(fecha_y_hora, clase.ID_CLASE, alumno.ID)
    End Sub
    Public Sub validar()
        If Validar_presente(alumno.ID, clase.ID_CLASE) = 1 Then
            Form_inicio.lbl_nombre.Text = "Alumno se encuentra presente"
        End If
    End Sub

End Class
