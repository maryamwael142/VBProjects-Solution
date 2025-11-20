Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        Dim i As Integer

        For i = 100 To 200 Step 10
            sum = sum + i
        Next

        ListBox1.Items.Add("       ")
        ListBox1.Items.Add("Sum: " & sum.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
