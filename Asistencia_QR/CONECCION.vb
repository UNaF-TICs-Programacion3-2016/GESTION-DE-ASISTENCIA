Imports Oracle.DataAccess.Client
Public Class coneccion


    Private Conexion As New OracleConnection()
    Private Comando As New OracleCommand()
    Private Adaptador As OracleDataAdapter
    Private Almacenamiento As New DataSet()
    Private Fila As DataRow





    Public Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" + "User Id=ASISTENCIA;" + "Password=gaston12;"
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

    Public Sub Insertar_Asistencia()

        Dim Adaptador = New OracleDataAdapter("Select * From ASISTENCIA", Conexion)

        Try
            Adaptador.Fill(Almacenamiento, "ASISTENCIA")
            Fila = Almacenamiento.Tables("ASISTENCIA").NewRow()


            Fila("HORA_ASISTENCIA") = #5/31/1993#
            Fila("RELA_CLASE_ASISTENCIA") = 1
            Fila("RELA_ALUMNO_ASISTENCIA") = 1

            Comando.Connection = Conexion
            Almacenamiento.Tables("ASISTENCIA").Rows.Add(Fila)


            Comando.CommandText = "Insert Into ASISTENCIA VALUES(:id_ASISTENCIA,:HORA_ASISTENCIA,:RELA_CLASE_ASISTENCIA,:RELA_ALUMNO_ASISTENCIA)"
            Comando.Parameters.Add(New OracleParameter(":id_ASISTENCIA", OracleDbType.Long, 10, "id_ASISTENCIA"))
            Comando.Parameters.Add(New OracleParameter(":HORA_ASISTENCIA", OracleDbType.Date, 10, "HORA_ASISTENCIA"))
            Comando.Parameters.Add(New OracleParameter(":RELA_CLASE_ASISTENCIA", OracleDbType.Long, 100, "RELA_CLASE_ASISTENCIA"))
            Comando.Parameters.Add(New OracleParameter(":RELA_ALUMNO_ASISTENCIA", OracleDbType.Long, 10, "RELA_ALUMNO_ASISTENCIA"))
            Adaptador.InsertCommand = Comando
            Adaptador.Update(Almacenamiento, "ASISTENCIA")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class