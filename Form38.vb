Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 10 Step 2
            i = i + 1
        Next
        ListBox1.Items.Add(i)

    End Sub

    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
