Public Class Form_Profesor
    Private Sub Form_Inicio_clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Bienvenida.Text = "Bienvenido Profesor :" + Form_inicio.opersona.ApellidoyNombre

        If Form_inicio.opersona.FOTO_ = "1" Then 'si es 1 no tiene foto
            pic_profesor.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\usuario.jpg")
        Else
            pic_profesor.ImageLocation = Form_inicio.opersona.FOTO_
        End If
        ingresar_combo()
    End Sub
    Public Sub ingresar_combo()

        Dim Tabla As New DataTable()
        Dim reader2 As OracleDataReader
        Dim FILA As DataRow
        reader2 = Form_inicio.oconeccion.CargarCombo_Materia(Form_inicio.opersona.id_)

        Try
            Tabla.Load(reader2, LoadOption.OverwriteChanges)
            comb_materias.DataSource = Tabla
            comb_materias.DisplayMember = "NOMBRE_MATERIA"
            FILA = Tabla.Rows(0)

            Form_inicio.oclase.ID_Materia_ = FILA.ItemArray(2)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        comb_comision.Items.Add("Comision A")
        comb_comision.Items.Add("Comision B")
        comb_comision.Items.Add("Comision C")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_inicio.oclase.Estado_Clase_ = 1 'estado de la clase iniciado

        Form_inicio.oclase.Hora_ = 2 'ingresa tiempo de la clase

        Form_inicio.HORA_TIMER.Start()  ' inicia el temporizador

        Form_inicio.lbl_clase.Text = "Clase iniciada:  " + comb_materias.Text + "  " + comb_comision.Text 'carga el titulo del form1

        Form_inicio.oclase.nombre_clase_ = "Tema: " + txt_descripcion.Text 'carga el nombre de la clase

        Form_inicio.oclase.ID_COMISION = comb_comision.SelectedIndex + 1 'ingresar la comision en el atributo

        Form_inicio.opersona.INSERTAR_NUEVA_CLASE() 'inserta clase a oracle

        Form_inicio.Mostrar_datos_Clase() ' muestralos label

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class