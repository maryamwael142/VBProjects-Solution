Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer

        Label2.Text = ""

        For i = 1 To 3
            Label2.Text = "I love Egypt" & vbOKOnly
        Next

        Label2.Text = "***" & vbOKOnly
        Label2.Text = i

    End Sub

    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
