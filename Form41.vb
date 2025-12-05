Public Class Form41
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
200:
        n = InputBox("enter name", "name")

        If n = "sandra" Then
            GoTo 100
        Else
            GoTo 200
        End If

100:
        ListBox1.Items.Add("welcome " & n)
    End Sub
    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
