Public Class Form27
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Integer = 20
        Dim B As Integer = 10
        Dim C As Integer = 30

        A = B
        B = A
        Label2.Text = A + B - C
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
