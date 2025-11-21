Public Class Form34
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim sum As Integer
        sum = 0

        For i = 0 To 100 Step 2
            sum = sum + i
        Next i
        Label2.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
