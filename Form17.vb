Public Class Form17
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim startnum As Integer = 2
        Dim endnum As Integer = 6

        Dim totalsum As Long = 0

        For i As Integer = startnum To endnum
            totalsum += i
        Next
        Label2.Text = totalsum.ToString()
    End Sub
End Class
