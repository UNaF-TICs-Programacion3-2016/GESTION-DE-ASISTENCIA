﻿
Imports AForge.Video
Public Class Form_inicio
    Friend oconeccion As New coneccion
    Private camara As New lector_qr
    Friend opersona As New Persona
    Friend oclase As New Clase
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
        'camara.desconectar()

        'Form_Profesor.Show()


    End Sub

    Private Sub Cbo_Camaras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Camaras.SelectedIndexChanged
        'DESCONECTA LAS CAMARA
        camara.desconectar()
    End Sub
    Private Sub HORA_TIMER_Tick(sender As System.Object, e As System.EventArgs) Handles HORA_TIMER.Tick
        punto += 1
        'temporizador del tiempo ingresado

        oclase.TEMPORIZADOR()
        lbl_hora.Text = oclase.Hora_
        lbl_minuto.Text = oclase.Minuto_
        Lbl_segundo.Text = oclase.Segundo_
        'el punto del reloj titile
        If punto = 2 Then
            Punto1.Visible = False
            punto2.Visible = False
            punto = 0
        Else
            Punto1.Visible = True
            punto2.Visible = True
        End If
    End Sub
    Public Sub Mostrar_datos_Clase()
        lbl_clase_Tema.Text = oclase.nombre_clase_  ' carga en el form1 el tema 

        lbl_claseNoIniciada.Text = "" ' ocultar txt de clase no iniciada

        lbl_nombre.Text = "Ingresar Asistencia" 'lbl bajo la camara que muestra el inicio de asistencia

        oclase.ID_ = oconeccion.consultar_iD_clase ' obtener id de la clase

    End Sub
    Public Sub codigo_obtenido(codigo1 As String)
        'METODO CARGA LOS ATRIBUTOS PERSONAS  DE LA BD
        opersona.caragar_datos(codigo1)

        'VALIDACION PERSONA
        If opersona.TipoDePersona = 3 Then 'NO ESTA EN LA BD =3
            lbl_nombre.Text = "NO SE ENCUENTRA EN LA BASE DE DATOS"
            Pic_perfil = Nothing

        ElseIf opersona.TipoDePersona = 1 Then 'alumno=1

            If oclase.Estado_Clase_ = 0 Then
                MsgBox("Clase no iniciada")
                Exit Sub 'valida si la clase esta iniciada
            End If
           

            lbl_nombre.Text = "BIENVENIDO ALUMNO: " + opersona.ApellidoyNombre
            'ingresa la foto del alumno
            If opersona.FOTO_ = "1" Then
                Pic_perfil.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\usuario.jpg")
            Else
                Pic_perfil.ImageLocation = (opersona.FOTO_)
            End If

            opersona.insertar_PRESENTE() ' inserta presente a alumno

            'llamar metodo que de de alta a la persona en la tabla asistencia 

        ElseIf opersona.TipoDePersona = 2 Then 'PROFESOR_________________________________________
            If oclase.Estado_Clase_ = 1 Then
                MsgBox("Clase se encuentra Iniciada")
                Exit Sub 'valida si la clase esta iniciada
            End If
            Form_Profesor.Show()

        End If

    End Sub

End Class
