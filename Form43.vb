Public Class Form43
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x, y As Integer

        x = InputBox("Enter value of X", "Input X")
        y = InputBox("Enter value of Y", "Input Y")

        If x >= y Then
            Label3.Text = (x + y) & "   True"
        Else
            Label4.Text = (x - y) & "   False"
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
