Public Class Form1
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim p, t, r, si, ci As Double

        p = Val(textBox1.Text)
        t = Val(textBox2.Text)
        r = Val(textBox3.Text)

        si = (p * t * r) / 100
        ci = (p * (1 + r / 100) ^ t) - p

        If (radioButton1.Checked = True) Then
            textBox4.Text = si
        ElseIf (radioButton2.Checked = True) Then
            textBox4.Text = ci
        End If

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        End
    End Sub

    Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton1.CheckedChanged
        Label4.Text = "Simple Interest"
    End Sub

    Private Sub radioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton2.CheckedChanged
        Label4.Text = "Compound Interest"
    End Sub

End Class
