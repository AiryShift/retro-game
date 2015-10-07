Public Class menu
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub PictureBox1_ImageLoad(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.Pipe
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        game.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub music() Handles Me.Load
        My.Computer.Audio.Play(My.Resources._01_super_mario_bros, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settingsbtn.Click
        settings.ShowDialog()
    End Sub
End Class