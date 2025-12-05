Public Class Form1
    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        x = InputBox("enter x", "x")
        y = InputBox("enter y", "y")
        If x > y Then
            MsgBox("yes")
        Else
            MsgBox("no")
        End If
        ListBox1.Items.Add("x=" & x & " y=" & y)
    End Sub
    Private Sub button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
