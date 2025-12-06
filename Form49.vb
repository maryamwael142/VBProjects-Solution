Public Class Form49
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, f, n As Integer
        f = 1
        i = 1

100:    n = InputBox("enter number", "factorial")
        If n > 10 Then
            GoTo 100
        Else
            Do Until i > n
                f = f * i
                i = i + 1

            Loop
            Label2.Text = f
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
