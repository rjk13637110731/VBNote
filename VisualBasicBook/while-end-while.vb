Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Long, i As Long, sum As Long
        Dim k As Double
        Dim sumk As Long

        i = 1
        k = 1
        sumk = 1
        sum = 0
        While i <= 15
            While k <= i
                sumk = sumk * k
                k = k + 1
            End While
            sum = sum + sumk
            sumk = 1
            k = 1
            i = i + 1
        End While

        Label1.Text = "1! + 2! + ... + 20! = " & sum
    End Sub
End Class
