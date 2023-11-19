Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    Public Function AbsCal(dbll As Double) As Double
        If dbll > 0 Then
            AbsCal = dbll
        Else
            AbsCal = -dbll
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Double
        n = TextBox1.Text
        Label2.Text = n & "的绝对值是：" & AbsCal(n)
    End Sub
End Class
