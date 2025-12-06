Public Class Form44
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer

        x = InputBox("enter x ", "x")
        If x > 10 Then
            Label2.Text = x & "  True"
        Else
            Label2.Text = x & "  False"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
