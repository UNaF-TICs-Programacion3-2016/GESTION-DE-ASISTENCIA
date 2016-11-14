Imports AForge.Video.DirectShow
Imports ZXing
Imports AForge.Video
Public Class lector_qr
    Private FUENTES As FilterInfoCollection 'CAMARAS DISPONIBLES
    Private WithEvents CAMARA As VideoCaptureDevice 'CAMARA 
    Private IMAGEN As Bitmap 'IMAGENES CAMARA
    Private contenedor As String = 0
    Sub New()

    End Sub

    Public Sub cargar_comb()
        FUENTES = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If FUENTES.Count > 0 Then
            For i As Integer = 0 To FUENTES.Count - 1
                Form1.Cbo_Camaras.Items.Add(FUENTES(i).Name.ToString())
            Next
            Form1.Cbo_Camaras.SelectedIndex = 0
        Else
            MsgBox("NO HAY CAMARAS DISPONIBLES")
        End If

    End Sub
    Public Sub iniciar_camara()
        'INICIA LA CAMARA 
        CAMARA = New VideoCaptureDevice(FUENTES(Form1.Cbo_Camaras.SelectedIndex).MonikerString)
        AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf Form1.video_NuevoFrame1)
        CAMARA.Start()
        'INICIA ESCANEO
        Form1.Btn_Iniciar.BackColor = Color.LawnGreen
        Form1.Timer1.Interval = 650
        Form1.Timer1.Start()
    End Sub

    Public Sub desconectar()
        'DESCONECTA LAS CAMARA
        Try
            CAMARA.SignalToStop()
        Catch ex As Exception
        End Try
        Form1.Btn_Iniciar.BackColor = Color.LightGray
    End Sub
    Public Sub DECODIFICAR_IMG()
        Try
            Dim DECODER As BarcodeReader = New BarcodeReader
            Dim resultado As String = DECODER.Decode(IMAGEN).ToString
            If contenedor <> resultado Then Form1.list_codigos.Items.Add(resultado)
            contenedor = resultado
            Form1.codigo_obtenido(resultado)
        Catch ex As Exception
        End Try
    End Sub

    Public Property IMAGEN_ As Bitmap
        Get
            Return Me.IMAGEN
        End Get
        Set(value As Bitmap)
            Me.IMAGEN = value
        End Set
    End Property
End Class
