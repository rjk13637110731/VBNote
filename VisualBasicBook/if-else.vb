Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Single
        Dim y As Single
        x = Val(TextBox1.Text)

        If x < 300 Then
            y = x
        ElseIf x < 500 Then
            y = x * 0.9
        ElseIf x < 1000 Then
            y = x * 0.8
        ElseIf x < 200 Then
            y = x * 0.7
        Else
            y = x * 0.6
        End If
        TextBox2.Text = y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
