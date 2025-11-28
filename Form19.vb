Public Class Form19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        Dim y As Double

        x = Val(InputBox("x"))
        y = Val(InputBox("y"))

        MsgBox("x + y = " & (x + y))
        MsgBox("x - y = " & (x - y))
        MsgBox("x * y = " & (x * y))



        If y <> 0 Then
            MsgBox("x / y = " & (x / y))

        Else
            MsgBox("لا يمكن القسمة على صفر!")
        End If

    End Sub

    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
