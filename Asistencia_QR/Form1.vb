
Imports AForge.Video
Public Class Form1
    Private oconeccion As New coneccion
    Private camara As New lector_qr
    Private opersona As New Persona
    Private oclase As New Clase



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        camara.cargar_comb()
    End Sub

    Private Sub Btn_Iniciar_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar.Click
        camara.iniciar_camara()
    End Sub
    Public Sub video_NuevoFrame1(sender As Object, eventArgs As NewFrameEventArgs)
        'PRESENTA LAS IMAGENES EN EL PICTUREBOX1
        camara.IMAGEN_ = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        QR_Picture.Image = camara.IMAGEN_
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'DECODIFICA SI PUEDE Y ENVIA CODIGO
        camara.DECODIFICAR_IMG()

    End Sub

    Private Sub Btn_detener_Click(sender As Object, e As EventArgs) Handles Btn_detener.Click
        camara.desconectar()
        oconeccion.Insertar_clase(#4/10/2018#, 2)
        oconeccion.Insertar_Asistencia(#12/11/2000#, 1, 1)
    End Sub

    Private Sub Cbo_Camaras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Camaras.SelectedIndexChanged
        'DESCONECTA LAS CAMARA
        camara.desconectar()
    End Sub
    Private Sub HORA_TIMER_Tick(sender As System.Object, e As System.EventArgs) Handles HORA_TIMER.Tick
        oclase.hora_de_inicio_()
        lbl_hora.Text = oclase.consultar_Hora
        lbl_minuto.Text = oclase.consultar_minuto
        Lbl_segundo.Text = oclase.consultar_segundo
    End Sub
    Public Sub codigo_obtenido(codigo1 As String)
        'METODO CARGA LOS ATRIBUTOS PERSONAS  DE LA BD
        opersona.caragar_datos(codigo1)
        'VALIDACION PERSONA
        If opersona.TipoDePersona = 3 Then 'NO ESTA EN LA BD =3
            lbl_nombre.Text = "NO SE ENCUENTRA EN LA BASE DE DATOS"


        ElseIf opersona.TipoDePersona = 1 Then 'alumno=1
            lbl_nombre.Text = "BIENVENIDO ALUMNO: " + opersona.ApellidoyNombre

            'llamar metodo que de de alta a la persona en la tabla asistencia 

        ElseIf opersona.TipoDePersona = 2 Then 'Profesor =2
            lbl_nombre.Text = "Bienvenido Profesor: " + opersona.ApellidoyNombre
            'insertar una nueva clase en la tabla clase
        End If

    End Sub
End Class
