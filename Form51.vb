Public Class Form51
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim i As Integer

        Label2.Text = " "

        a = Val(InputBox("Enter first number"))
        b = Val(InputBox("Enter second number"))

        For i = a To b
            If i Mod 5 = 0 Then
                Label2.Text = Label2.Text & i & " "
            End If
        Next i
    End Sub
    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
