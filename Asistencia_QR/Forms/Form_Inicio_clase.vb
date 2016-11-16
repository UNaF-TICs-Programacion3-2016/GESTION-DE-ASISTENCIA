Public Class Form_Inicio_clase


    Private Sub Form_Inicio_clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Bienvenida.Text = "Bienvenido Profesor :" + Form_lector_asistencia.opersona.ApellidoyNombre

        If Form_lector_asistencia.opersona.FOTO_ = 1 Then 'si es 1 no tiene foto
            pic_profesor.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\usuario.jpg")
        Else
            pic_profesor.ImageLocation = Form_lector_asistencia.opersona.FOTO_
        End If
        ingresar_combo()
    End Sub
    Public Sub ingresar_combo()

        comb_materias.Items.Add("Programacion III")
        comb_materias.Items.Add("Base de Datos")
        comb_materias.Items.Add("Sistema Operativo")

        comb_comision.Items.Add("1")
        comb_comision.Items.Add("2")
        comb_comision.Items.Add("3")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_lector_asistencia.oclase.Estado_Clase_ = 1 'estado de la clase iniciado

        Form_lector_asistencia.oclase.Segundo_ = 10 'ingresa tiempo de la clase

        Form_lector_asistencia.HORA_TIMER.Start()  ' inicia el temporizador

        'insertar una nueva clase en la tabla clase
    End Sub
End Class