Public Class alumno
    Inherits Persona
    Private fecha_hora As String



    Public Sub New(ByVal codigo As String)
        'cargar los datos del alumno de la bd
        Dim fila As DataRow
        Try
            fila = oconeccion.consultar_datos(codigo).Rows(0)
            MyBase.Apellido_y_Nombre = fila.ItemArray(2)
            MyBase.DNI_ = fila.ItemArray(3)
            MyBase.ID = fila.ItemArray(0)
            If fila.ItemArray(7) = "" Then
            Else
                Me.foto = fila.ItemArray(7)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'cargar datos de la hora
        fecha_hora = String.Format("{0:G}", DateTime.Now)
    End Sub
    Public Sub PRESENTE()



        oconeccion.Insertar_Asistencia(fecha_hora, ID_CLASE, ID)
    End Sub
    Public Sub insertar_PRESENTE()

        Dim fecha_y_hora As Date = String.Format("{0:G}", DateTime.Now)

        oconeccion.Insertar_Asistencia(fecha_y_hora, ID_CLASE, ID)

    End Sub
    Public Sub validar()
        If oconeccion.Validar_presente(ID, ID_CLASE) = 1 Then
            Form_inicio.lbl_nombre.Text = "Alumno se encuentra presente"
        End If
    End Sub
End Class
