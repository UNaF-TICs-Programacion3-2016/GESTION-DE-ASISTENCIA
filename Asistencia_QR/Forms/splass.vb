Public Class splass
    Dim contador As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        contador = contador + 10
        If ProgressBar1.Value < 100 Then

            ProgressBar1.Value = contador
        Else
            Me.Hide()

            Form_inicio.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub splass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class