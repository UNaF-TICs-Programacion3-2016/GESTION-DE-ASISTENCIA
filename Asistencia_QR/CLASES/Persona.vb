Imports Oracle.DataAccess.Client


Public Enum tipo_de_persona As Byte
    NO_EXISTE = 3
    alumno = 1
    profesor = 2
End Enum

Public Class Persona
    Inherits Clase
    'ATRIBUTOS
    Friend Apellido_y_Nombre As String
    Friend DNI_ As Long
    Friend ID As Long
    Friend foto As String
    Friend oconeccion As New coneccion

    'constructor
    Sub New()

    End Sub
    Public Sub New(ByVal Codigo As String)
        ' validar persona mediante los metodos heredados de conexion
        Dim Tipo_Persona As tipo_de_persona = oconeccion.consultar_Tpo_Persona(Codigo)

        If Tipo_Persona = tipo_de_persona.NO_EXISTE Then

            Form_inicio.lbl_nombre.Text = "NO SE ENCUENTRA EN LA BASE DE DATOS"
            Form_inicio.Pic_perfil.Image = Image.FromFile("C:\Users\gasss\Desktop\Proyecto Asistencia\Asistencia_QR\profile.jpg")

        ElseIf Tipo_Persona = tipo_de_persona.alumno Then
            If Estado_Clase_ = estado_de_la_clase.no_iniciado Then
               
                Dim oalumno As New alumno(Codigo)
            End If
        End If
        If Tipo_Persona = tipo_de_persona.profesor Then
            If Estado_Clase_ = estado_de_la_clase.iniciado Then
                Form_inicio.lbl_nombre.Text = "Clase se encuentra iniciada"
                Exit Sub
            End If
            Form_Profesor.Show()
        End If

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

    Friend ReadOnly Property id_() As Long
        Get
            Return Me.ID
        End Get
    End Property




End Class