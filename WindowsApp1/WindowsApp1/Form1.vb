Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("Rrealmente quiere apagar el computador?", MsgBoxStyle.Information + vbYesNo) = vbYes Then

            ' lo que pasa si Yes
            End

        Else

            'lo que pasa si no


        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel3.Show()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel3.Hide()

    End Sub

    Private Sub Panel2_click(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel3.Hide()

    End Sub
End Class
