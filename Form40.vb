Public Class Form40
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = InputBox("Enter name", "Name")

        If n = "rami" Then
            ListBox1.Items.Add("true")
        Else
            ListBox1.Items.Add("false")
        End If

    End Sub
    Private Sub button2_click(sender As Object, e As EventArgs) Handles button2.click
        End

    End Sub
End Class
