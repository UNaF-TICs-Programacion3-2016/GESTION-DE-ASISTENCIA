Imports Oracle.DataAccess.Client
'
Public Enum tipo_de_persona As Byte
    NO_EXISTE = 3
    alumno = 1
    profesor = 2
End Enum

Public Class Persona


    'ATRIBUTOS
    Private Apellido_y_Nombre As String
    Private DNI_ As Long
    Private TipoPersona As tipo_de_persona
    Private ID As Long
    Private foto As String
    Private oconeccion As New coneccion
    Private oclase As New Clase
    'constructor
    Public Sub New()
        '    Me.hora_ = TimeOfDay
    End Sub

    'PROPIEDADES DE ACCESO A LOS ATRIBUTOS
    Friend ReadOnly Property ApellidoyNombre() As String
        Get
            Return Me.Apellido_y_Nombre
        End Get

    End Property

    Friend ReadOnly Property DNI() As Long
        Get
            Return Me.DNI_
        End Get

    End Property
    Friend ReadOnly Property FOTO_() As String
        Get
            Return Me.foto
        End Get

    End Property
    Friend ReadOnly Property TipoDePersona() As tipo_de_persona
        Get
            Return Me.TipoPersona
        End Get

    End Property
    Friend ReadOnly Property id_() As Long
        Get
            Return Me.ID
        End Get
    End Property
    Friend Sub caragar_datos(ByVal codigo As String)
        Dim fila As DataRow
        'consultar tipo de persona
        Me.TipoPersona = CInt(oconeccion.consultar_Tpo_Persona(codigo))
        If Me.TipoPersona = 3 Then Exit Sub
        'cargar atributos
        Try
            fila = oconeccion.consultar_datos(codigo).Rows(0)

            Me.Apellido_y_Nombre = fila.ItemArray(2)
            Me.DNI_ = fila.ItemArray(3)
            Me.ID = fila.ItemArray(0)
            If fila.ItemArray(7) = "" Then
            Else
                Me.foto = fila.ItemArray(7)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub insertar_PRESENTE()

        Dim fecha_y_hora As Date = String.Format("{0:G}", DateTime.Now)

        oconeccion.Insertar_Asistencia(fecha_y_hora, oclase.ID_, ID)
    End Sub
    Public Sub INSERTAR_NUEVA_CLASE()
        Dim fecha_y_hora As Date = String.Format("{0:G}", DateTime.Now)
        oconeccion.Insertar_clase(fecha_y_hora, oclase.nombre_clase_, oclase.COMISION_)
    End Sub
End Class