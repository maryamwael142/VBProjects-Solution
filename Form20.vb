Public Class Form20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim playerName As String

        playerName = InputBox("ادخل اسم اللاعب:")
        If (playerName) = "محمد صلاح" Then
            MsgBox("اهلا وسهلا بالنجم العالمي محمد صلاح ", vbOKOnly, "ترحيب حار")
        Else
            MsgBox(" هذا ليس محمد صلاح ", vbOKOnly, "تنبيه")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
