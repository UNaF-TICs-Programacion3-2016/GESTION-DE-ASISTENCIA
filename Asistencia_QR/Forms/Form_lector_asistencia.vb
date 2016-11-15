
Imports AForge.Video
Public Class Form_lector_asistencia
    Private oconeccion As New coneccion
    Private camara As New lector_qr
    Private opersona As New Persona
    Private oclase As New Clase
    Private punto As Integer
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
    Public Sub clase_finalizada()
        HORA_TIMER.Stop()
    End Sub
    Private Sub Btn_detener_Click(sender As Object, e As EventArgs) Handles Btn_detener.Click
        camara.desconectar()
        'oconeccion.Insertar_clase()
        'oconeccion.Insertar_Asistencia(#12/11/2000#, 1, 1)
        Pic_perfil.ImageLocation = "http://www.mathiaspereira.com/yoreciclo/img/alexis.jpg"


    End Sub

    Private Sub Cbo_Camaras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Camaras.SelectedIndexChanged
        'DESCONECTA LAS CAMARA
        camara.desconectar()
    End Sub
    Private Sub HORA_TIMER_Tick(sender As System.Object, e As System.EventArgs) Handles HORA_TIMER.Tick
        punto += 1
        oclase.TEMPORIZADOR()
        lbl_hora.Text = oclase.Hora_
        lbl_minuto.Text = oclase.Minuto_
        Lbl_segundo.Text = oclase.Segundo_
        If punto = 2 Then
            Punto1.Visible = False
            punto2.Visible = False
            punto = 0
        Else
            Punto1.Visible = True
            punto2.Visible = True
        End If
    End Sub
    Public Sub codigo_obtenido(codigo1 As String)
        'METODO CARGA LOS ATRIBUTOS PERSONAS  DE LA BD
        opersona.caragar_datos(codigo1)
        'VALIDACION PERSONA
        If opersona.TipoDePersona = 3 Then 'NO ESTA EN LA BD =3
            lbl_nombre.Text = "NO SE ENCUENTRA EN LA BASE DE DATOS"


        ElseIf opersona.TipoDePersona = 1 Then 'alumno=1
            lbl_nombre.Text = "BIENVENIDO ALUMNO: " + opersona.ApellidoyNombre

            Pic_perfil.ImageLocation = opersona.FOTO_
            'llamar metodo que de de alta a la persona en la tabla asistencia 

        ElseIf opersona.TipoDePersona = 2 Then 'Profesor =2
            lbl_nombre.Text = "Bienvenido Profesor: " + opersona.ApellidoyNombre
            If opersona.FOTO_ = 1 Then
                Pic_perfil.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\usuario.jpg")
            Else
                Pic_perfil.ImageLocation = opersona.FOTO_
            End If
            oclase.Segundo_ = 10
            ' HORA_TIMER.Start()
            'insertar una nueva clase en la tabla clase
        End If

    End Sub


End Class
