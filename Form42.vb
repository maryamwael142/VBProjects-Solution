Public Class Form42
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
200:    a = InputBox("enter name", "name")
        If a = "tia" Then
            GoTo 100
        Else
            GoTo 200
        End If
100:
        ListBox1.Items.Add("welcome " & a)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
