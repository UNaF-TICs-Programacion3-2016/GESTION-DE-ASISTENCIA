Public Class PRofesor
    Inherits Persona
    Private fecha_hora As String
    Public Sub New()

    End Sub
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
    Public Sub INSERTAR_NUEVA_CLASE(ByVal Nombre_clase As String, ByVal comision As String)
        Dim fecha_y_hora As String = String.Format("{0:G}", DateTime.Now)
        oconeccion.Insertar_clase(fecha_y_hora, Nombre_clase, comision, ID_Materia_)
        Estado_Clase_ = estado_de_la_clase.iniciado
    End Sub

    Public Sub cargar_componente_profesor()
        Form_Profesor.lbl_Bienvenida.Text = "Bienvenido Profesor :" + Me.Apellido_y_Nombre


        If Me.foto = "1" Then 'si es 1 no tiene foto
            Form_Profesor.pic_profesor.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\usuario.jpg")
        Else
            Form_Profesor.pic_profesor.ImageLocation = foto
        End If

    End Sub
    Public Sub ingresar_combo()

        Dim Tabla As New DataTable()
        Dim reader2 As OracleDataReader
        Dim FILA As DataRow
        reader2 = oconeccion.CargarCombo_Materia(ID)

        Try
            Tabla.Load(reader2, LoadOption.OverwriteChanges)
            Form_Profesor.comb_materias.DataSource = Tabla
            Form_Profesor.comb_materias.DisplayMember = "NOMBRE_MATERIA"
            FILA = Tabla.Rows(0)

            Me.ID_Materia_ = FILA.ItemArray(2)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        Form_Profesor.comb_comision.Items.Add("Comision A")
        Form_Profesor.comb_comision.Items.Add("Comision B")
        Form_Profesor.comb_comision.Items.Add("Comision C")
        Form_Profesor.comb_comision.SelectedItem = "Comision A"


    End Sub
End Class