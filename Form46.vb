Public Class Form46
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Integer = 1

        For i As Integer = 1 To 7
            f = f * i
        Next

        Label2.Text = "7! = " & f
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
