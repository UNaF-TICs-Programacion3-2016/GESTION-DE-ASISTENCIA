Imports Oracle.DataAccess.Client
Public Enum tipodepersona As Byte
    profesor = 1
    ALumno = 2

End Enum
Public Class Persona
    Private nombre As String
    Private codigo As String
    Private id As Integer
    Private persona As tipodepersona




    'Public ReadOnly Property validarCodigo(ByVal codigo As String) As String

    '    Get
    '        Return newPropertyValue
    '    End Get

    'End Property
    Function ObptenerDatos()

    End Function

End Class
Public Class EntornoDB

    Private Conn As New OracleConnection

    Public Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=asistencia;" _
                                        + "Password=gaston12;"
    End Sub
    Public ReadOnly Property Conexion As OracleConnection
        Get
            Return Conn
        End Get
    End Property

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

    Public Function ObtenerDatosDesdeSQL(SQL As String) As DataTable

        Dim Inmueble As New DataSet
        Dim Tabla As New DataTable
        Dim Adaptador As New OracleDataAdapter(SQL, Conexion)

        Adaptador.Fill(Inmueble, "persona")

        Tabla = Inmueble.Tables("persona")

        Return Tabla
    End Function

End Class
