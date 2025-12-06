Public Class Form48
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, f As Integer
        f = 1
        i = 1
        Do Until i > 5
            f = f * i
            i = i + 1
        Loop
        Label2.Text = f
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
