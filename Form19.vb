Public Class Form19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer

        x = InputBox("enter x ", "x")
        y = InputBox("enter y ", "y")

        Label5.Text = x + y
        Label6.Text = x - y
        Label7.Text = x * y
        Label8.Text = x / y


    End Sub

    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
