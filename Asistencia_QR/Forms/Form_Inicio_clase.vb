Public Class Form_Inicio_clase
    Private opersona As Persona
    Private Sub Form_Inicio_clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Bienvenida.Text = "bienvenido Profesor" + opersona.ApellidoyNombre
    End Sub
End Class