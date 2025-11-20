Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim sum As Integer = 0
        For i = 101 To 300 Step 2
            sum = sum + i

        Next
        ListBox1.Items.Add(sum.ToString())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub





















End Class
