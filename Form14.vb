Public Class Form14
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalsum As Integer = 0
        For i As Integer = 101 To 199
            totalsum = totalsum + i
        Next

        ListBox1.Items.Add(totalsum.ToString())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
