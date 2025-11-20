Public Class Form15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim sum As Integer

        For i = 1 To 50 Step 2
            sum = sum + i
        Next
        Label2.Text = sum
    End Sub
End Class
