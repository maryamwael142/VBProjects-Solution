Public Class Form22
    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer

        For i = 1 To 10 Step 2
            i = i + 2

        Next
        Label2.Text = i

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
