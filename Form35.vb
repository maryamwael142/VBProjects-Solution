Public Class Form35
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label6.Text = Val(TextBox1.Text) - TextBox2.Text + TextBox3.Text * TextBox4.Text / 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Label6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
