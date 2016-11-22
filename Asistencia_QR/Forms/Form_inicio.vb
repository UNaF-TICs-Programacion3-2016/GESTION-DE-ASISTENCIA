Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports AForge.Video
Public Class Form_inicio
    Inherits MetroForm
    Friend camara As New lector_qr
    Private punto As Integer
    Private CONT_TIMER As Int16

    Public Sub New()
        'disenio fom

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebBrowserClima.Navigate("https://www.google.com.ar/search?sourceid=chrome-psyapi2&ion=1&espv=2&ie=UTF-8&q=clima%20formosa&oq=clima&rlz=1C1CHZL_esAR713AR713&aqs=chrome.1.69i57j0l5.2100j0j8")
        camara.cargar_comb()
        Timer_Clima.Start()

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
    Private Sub Btn_detener_Click(sender As Object, e As EventArgs)
        'camara.desconectar()
        ' oconeccion.Validar_presente(21, 10)
        'Form_Profesor.Show()


    End Sub

    Private Sub Cbo_Camaras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Camaras.SelectedIndexChanged
        'DESCONECTA LAS CAMARA
        camara.desconectar()
    End Sub
    Private Sub HORA_TIMER_Tick(sender As System.Object, e As System.EventArgs) Handles HORA_TIMER.Tick
        'ACA VAMOS A LLAMAR A LA FUNCION TEMPORIZADOR
        'TEMPORIZADOR()
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
    'Public Sub TEMPORIZADOR()
    '    If hora = 0 And minuto = 0 And segundo = 0 Then
    '        HORA_TIMER.Stop()
    '        MsgBox("Clase FINALIZADA")
    '        'estado_clase = 0 'clase terminada
    '    Else
    '        If Not segundo = 0 Then
    '            segundo -= 1
    '        Else
    '            If Not minuto = 0 Then
    '                minuto -= 1
    '                segundo = 59
    '            Else
    '                hora -= 1
    '                minuto = 59
    '                segundo = 59
    '            End If
    '        End If
    '    End If
    'End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Private Sub actualizar_clima()
        Try
            LabelCiudad.Text = WebBrowserClima.Document.GetElementById("wob_loc").InnerText
            LabelTemp.Text = WebBrowserClima.Document.GetElementById("wob_tm").InnerText
            LabelClima.Text = WebBrowserClima.Document.GetElementById("wob_dc").InnerText
            LabelPrecip.Text = "Precipitaciones: " & WebBrowserClima.Document.GetElementById("wob_pp").InnerText
            LabelHumedad.Text = "Humedad: " & WebBrowserClima.Document.GetElementById("wob_hm").InnerText
            LabelViento.Text = "Viento: " & WebBrowserClima.Document.GetElementById("wob_ws").InnerText
            LabelDia.Text = WebBrowserClima.Document.GetElementById("wob_dts").InnerText
            PBClima.ImageLocation = WebBrowserClima.Document.GetElementById("wob_tci").GetAttribute("src")
        Catch ex As Exception
        End Try


    End Sub

    Private Sub Timer_Clima_Tick(sender As Object, e As EventArgs) Handles Timer_Clima.Tick
        actualizar_clima()
        Timer_Clima.Stop()

    End Sub

    Private Sub Timer_nombre_desaparece_Tick(sender As Object, e As EventArgs) Handles Timer_nombre_desaparece.Tick
        CONT_TIMER += 1
        If CONT_TIMER = 2 Then
            Pic_perfil.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\profile.jpg")
            lbl_nombre.Text = "Ingresa Tu Codigo de Asistencia"
            Timer_nombre_desaparece.Stop()
            CONT_TIMER = 0
        End If
    End Sub
End Class
