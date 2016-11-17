Imports Oracle.DataAccess.Client
Public Class coneccion
    Private Conexion As New OracleConnection()
    Private Comando As New OracleCommand()

    Public Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" + "User Id=asistencia;" + "Password=gaston12;"

    End Sub

    Private Sub Conectar()
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desconectar()
        Try
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function consultar_datos(CODIGO As String) As DataTable
      
        Dim PERSONAS As New DataSet
        Dim Tabla As New DataTable
        Dim Adaptador As New OracleDataAdapter("SELECT * from PERSONA WHERE CODIGO_PERSONA =" + CODIGO, Conexion)


        Adaptador.Fill(PERSONAS, "PERSONA")
        Tabla = PERSONAS.Tables("PERSONA")

        Return Tabla
    End Function
    Public Function consultar_Tpo_Persona(CODIGO As String) As tipo_de_persona

        Dim PERSONAS As New DataSet
        Dim Tabla As New DataTable
        Dim Adaptador As New OracleDataAdapter("SELECT  TIPO_PERSONA(" + CODIGO + ") From dual", Conexion)
        Dim fila As DataRow

        Try
            Adaptador.Fill(PERSONAS, "dual")
            Tabla = PERSONAS.Tables("dual")
            fila = Tabla.Rows(0)
            Return fila.ItemArray(0)
        Catch ex As Exception
            Return 3
        End Try
    End Function
    Public Function consultar_iD_clase() As Long
        Dim PERSONAS As New DataSet
        Dim Tabla As New DataTable
        Dim Adaptador As New OracleDataAdapter("SELECT MAX(ID_clase) FROM clase;", Conexion)
        Dim fila As DataRow


        Adaptador.Fill(PERSONAS, "dual")
        Tabla = PERSONAS.Tables("dual")
        fila = Tabla.Rows(0)
        Return fila.ItemArray(0)



    End Function

    Public Sub Insertar_Asistencia(ByVal fecha_hora As Date, ByVal ID_clase As Long, ByVal alumno_id As Long)
        Dim Comando As New OracleCommand()
        Dim Almacenamiento As New DataSet()
        Dim Fila As DataRow
        
        Almacenamiento.Clear()

        Dim Adaptador = New OracleDataAdapter("Select * From ASISTENCIA", Conexion)

        Try
            Adaptador.Fill(Almacenamiento, "ASISTENCIA")
            Fila = Almacenamiento.Tables("ASISTENCIA").NewRow()


            Fila("HORA_ASISTENCIA") =CStr ( fecha_hora)
            Fila("RELA_CLASE_ASISTENCIA") = ID_clase
            Fila("RELA_ALUMNO_ASISTENCIA") = alumno_id

            Comando.Connection = Conexion
            Almacenamiento.Tables("ASISTENCIA").Rows.Add(Fila)

            Comando.CommandText = "Insert Into ASISTENCIA VALUES(:id_ASISTENCIA,:HORA_ASISTENCIA,:RELA_CLASE_ASISTENCIA,:RELA_ALUMNO_ASISTENCIA)"
            Comando.Parameters.Add(New OracleParameter(":id_ASISTENCIA", OracleDbType.Long, 10, "id_ASISTENCIA"))
            Comando.Parameters.Add(New OracleParameter(":HORA_ASISTENCIA", OracleDbType.Varchar2, 100, "HORA_ASISTENCIA"))
            Comando.Parameters.Add(New OracleParameter(":RELA_CLASE_ASISTENCIA", OracleDbType.Long, 100, "RELA_CLASE_ASISTENCIA"))
            Comando.Parameters.Add(New OracleParameter(":RELA_ALUMNO_ASISTENCIA", OracleDbType.Long, 10, "RELA_ALUMNO_ASISTENCIA"))
            Adaptador.InsertCommand = Comando
            Adaptador.Update(Almacenamiento, "ASISTENCIA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Insertar_clase(ByVal fecha_clase As Date, ByVal DESCRIPCION_CLASE_ As String, ByVal comision_id As String, id_materia As String)
        Dim Comando As New OracleCommand()
        Dim Almacenamiento As New DataSet()
        Dim Fila As DataRow
        Conexion.ConnectionString = "Data Source=localhost;" + "User Id=asistencia;" + "Password=gaston12;"
        Almacenamiento.Clear()

        Dim Adaptador = New OracleDataAdapter("Select * From CLASE", Conexion)

        Try
            Adaptador.Fill(Almacenamiento, "CLASE")
            Fila = Almacenamiento.Tables("CLASE").NewRow()


            Fila("FECHA_CLASE") = fecha_clase
            Fila("RELA_COMISION_CLASE") = comision_id
            Fila("DESCRIPCION_CLASE") = DESCRIPCION_CLASE_
            Fila("RELA_MATERIA_CLASE") = id_materia
            Comando.Connection = Conexion
            Almacenamiento.Tables("CLASE").Rows.Add(Fila)

            Comando.CommandText = "Insert Into CLASE VALUES(:id_CLASE,:NOMBRE_CLASE,:RELA_COMISION_CLASE,:DESCIPCION_CLASE,:RELA_MATERIA_CLASE)"
            Comando.Parameters.Add(New OracleParameter(":ID_CLASE", OracleDbType.Long, 10, "ID_CLASE"))
            Comando.Parameters.Add(New OracleParameter(":FECHA_CLASE", OracleDbType.Date, 100, "FECHA_CLASE"))
            Comando.Parameters.Add(New OracleParameter(":RELA_COMISION_CLASE", OracleDbType.Long, 100, "RELA_COMISION_CLASE"))
            Comando.Parameters.Add(New OracleParameter(":DESCRIPCION_CLASE", OracleDbType.Varchar2, 100, "DESCRIPCION_CLASE"))
            Comando.Parameters.Add(New OracleParameter(":RELA_MATERIA_CLASE", OracleDbType.Varchar2, 100, "RELA_MATERIA_CLASE"))
            Adaptador.InsertCommand = Comando
            Adaptador.Update(Almacenamiento, "CLASE")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function CargarCombo_Materia(id_profesor As String) As OracleDataReader
        Dim Conexion As New OracleConnection()
        Dim Comando As New OracleCommand("SELECT * FROM profesor_materia,persona,materia  WHERE profesor_materia.RELA_PROFESOR=persona.ID_PERSONA AND profesor_materia.RELA_MATERIA= materia.id_materia and PROFESOR_MATERIA.RELA_PROFESOR =" + id_profesor, Conexion)
        Dim Reader As OracleDataReader
        Try

            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=asistencia;" _
                                        + "Password=gaston12;"
            Conexion.Open()

            Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch EX As Exception
            MessageBox.Show(EX.Message)

        End Try
        Return Reader
    End Function

End Class