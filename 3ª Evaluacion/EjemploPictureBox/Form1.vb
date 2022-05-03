Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBox1.Image = My.Resources.Logo_Qbitia
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            PictureBox1.Image = My.Resources.bigo_solutions

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Desplazar PictureBox2 a la derecha
        If PictureBox2.Location.X = 800 Then
            Me.PictureBox2.Location = New Point(0, PictureBox2.Location.Y)
        Else
            Me.PictureBox2.Location = New Point(PictureBox2.Location.X + 10, PictureBox2.Location.Y)
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = PictureBox3
        Timer1.Start()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.A) Or e.KeyChar = Convert.ToChar(97) Then
            PictureBox3.Location = New Point(PictureBox3.Location.X - 5, PictureBox3.Location.Y)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            PictureBox3.Location = New Point(PictureBox3.Location.X - 5, PictureBox3.Location.Y)
        End If
    End Sub
End Class
