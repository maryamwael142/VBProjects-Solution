Public Class Form16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim sum As Integer
        For i = 10 To 70 Step 5
            sum = sum + i
        Next
        Label2.Text = sum
    End Sub
End Class
