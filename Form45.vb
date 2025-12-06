Public Class Form45
    Private Sub button1_click(sender As Object, e As EventArgs) Handles button1.click
        Dim n As String
        n = InputBox("enter name", "name")
        If n = "Tia" Then
            MsgBox("Program will end ")

        End If

        Label2.Text = n
    End Sub
    Private Sub button2_click(sender As Object, e As EventArgs) Handles button2.click
        End
    End Sub

End Class
