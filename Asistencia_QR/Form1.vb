Imports AForge.Video.DirectShow
Imports ZXing
Imports AForge.Video
Public Class Form1
    Private oEntornoDB As New EntornoDB
    Dim FUENTES As FilterInfoCollection 'CAMARAS DISPONIBLES
    Dim WithEvents CAMARA As VideoCaptureDevice 'CAMARA 
    Dim IMAGEN As Bitmap 'IMAGENES CAMARA


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA LAS CAMARAS DISPONIBLES EN LOS 2 COMBOBOX
        FUENTES = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If FUENTES.Count > 0 Then
            For i As Integer = 0 To FUENTES.Count - 1
                Cbo_Camaras.Items.Add(FUENTES(i).Name.ToString())
            Next
            Cbo_Camaras.SelectedIndex = 0
        Else
            MsgBox("NO HAY CAMARAS DISPONIBLES")
        End If
    End Sub

    Private Sub Btn_Iniciar_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar.Click
        'INICIA LA CAMARA 
        CAMARA = New VideoCaptureDevice(FUENTES(Cbo_Camaras.SelectedIndex).MonikerString)
        AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf video_NuevoFrame1)
        CAMARA.Start()
        'INICIA ESCANEO
        Btn_Iniciar.BackColor = Color.LawnGreen
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub video_NuevoFrame1(sender As Object, eventArgs As NewFrameEventArgs)
        'PRESENTA LAS IMAGENES EN EL PICTUREBOX1
        IMAGEN = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        QR_Picture.Image = IMAGEN
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'DECODIFICA SI PUEDE Y PONE EL RESULTADO EN LA ETIQUETA
        Try
            Dim DECODER As BarcodeReader = New BarcodeReader
            Dim resultado As String = DECODER.Decode(IMAGEN).ToString
            If lbl_Codigo.Text <> resultado Then list_codigos.Items.Add(resultado)
            lbl_Codigo.Text = resultado
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Btn_detener_Click(sender As Object, e As EventArgs) Handles Btn_detener.Click
        'DESCONECTA LAS CAMARA
        Try
            CAMARA.SignalToStop()
        Catch ex As Exception
        End Try
        Btn_Iniciar.BackColor = Color.LightGray
    End Sub

    Private Sub Cbo_Camaras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Camaras.SelectedIndexChanged
        'DESCONECTA LAS CAMARA
        Try
            CAMARA.SignalToStop()
        Catch ex As Exception
        End Try
        Btn_Iniciar.BackColor = Color.LightGray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grid_persona.DataSource = oEntornoDB.ObtenerDatosDesdeSQL("SELECT nombre_persona from persona WHERE CODIGO_persona = 1234")
    End Sub
End Class
