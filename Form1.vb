Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        I = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        I = I + 1

        If I >= 4 Then
            LoginForm.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub
End Class
