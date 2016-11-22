

Public Class Form_Profesor
    Private oconeccion As New coneccion
    Private oprofesor As New PRofesor(Form_inicio.camara.codigo_persona)


    Private Sub Form_Inicio_clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oprofesor.cargar_componente_profesor()
        oprofesor.ingresar_combo
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oclase As New Clase
        oclase.Estado_Clase_ = 1 'estado de la clase iniciado

        oclase.Hora_ = 2 'ingresa tiempo de la clase

        Form_inicio.HORA_TIMER.Start()  ' inicia el temporizador

        Form_inicio.lbl_clase.Text = "Clase iniciada:  " + comb_materias.Text + "  " + comb_comision.Text 'carga el titulo del form1
        Form_inicio.lbl_claseNoIniciada.Text = ""
        oprofesor.INSERTAR_NUEVA_CLASE("Tema: " + txt_descripcion.Text, comb_comision.SelectedIndex + 1) 'inserta clase a oracle


        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class