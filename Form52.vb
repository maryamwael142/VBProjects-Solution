Public Class Form52
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim result As String = ""

        For i = 1 To 10
            result &= "تحيا مصر "
        Next

        Label1.Text = result

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
