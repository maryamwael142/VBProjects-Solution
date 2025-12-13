Public Class Form50
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        Do
            n = Val(InputBox("Enter a number (<= 10)", "Input"))
        Loop While n > 10

        Label2.Text = "The number is: " & n
    End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            End
        End Sub
    End Class


