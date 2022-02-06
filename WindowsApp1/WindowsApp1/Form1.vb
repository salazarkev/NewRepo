Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub picturebox2_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel3.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("Rrealmente quiere apagar el computador?", MsgBoxStyle.Information + vbYesNo) = vbYes Then

            En


        Else

            'no pasa nada

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel3.Show()


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
