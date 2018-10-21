Public Class Form1
    Dim a(9), b(9), r(9) As Single

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        r11.Text = ""
        r12.Text = ""
        r13.Text = ""
        r21.Text = ""
        r22.Text = ""
        r23.Text = ""
        r31.Text = ""
        r32.Text = ""
        r33.Text = ""
        a11.Text = ""
        a12.Text = ""
        a13.Text = ""
        a21.Text = ""
        a22.Text = ""
        a23.Text = ""
        a31.Text = ""
        a32.Text = ""
        a33.Text = ""
        b11.Text = ""
        b12.Text = ""
        b13.Text = ""
        b21.Text = ""
        b22.Text = ""
        b23.Text = ""
        b31.Text = ""
        b32.Text = ""
        b33.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        a(0) = a11.Text
        a(1) = a12.Text
        a(2) = a13.Text
        a(3) = a21.Text
        a(4) = a22.Text
        a(5) = a23.Text
        a(6) = a31.Text
        a(7) = a32.Text
        a(8) = a33.Text
        b(0) = b11.Text
        b(1) = b12.Text
        b(2) = b13.Text
        b(3) = b21.Text
        b(4) = b22.Text
        b(5) = b23.Text
        b(6) = b31.Text
        b(7) = b32.Text
        b(8) = b33.Text
        If operando.Text = "+" Then
            r11.Text = a(0) + b(0)
            r12.Text = a(1) + b(1)
            r13.Text = a(2) + b(2)
            r21.Text = a(3) + b(3)
            r22.Text = a(4) + b(4)
            r23.Text = a(5) + b(5)
            r31.Text = a(6) + b(6)
            r32.Text = a(7) + b(7)
            r33.Text = a(8) + b(8)
        ElseIf operando.Text = "-" Then
            r11.Text = a(0) - b(0)
            r12.Text = a(1) - b(1)
            r13.Text = a(2) - b(2)
            r21.Text = a(3) - b(3)
            r22.Text = a(4) - b(4)
            r23.Text = a(5) - b(5)
            r31.Text = a(6) - b(6)
            r32.Text = a(7) - b(7)
            r33.Text = a(8) - b(8)
        ElseIf operando.Text = "*" Then
            r11.Text = a(0) * b(0)
            r12.Text = a(1) * b(3)
            r13.Text = a(2) * b(6)
            r21.Text = a(3) * b(1)
            r22.Text = a(4) * b(4)
            r23.Text = a(5) * b(7)
            r31.Text = a(6) * b(2)
            r32.Text = a(7) * b(5)
            r33.Text = a(8) * b(8)
        End If
    End Sub
End Class
