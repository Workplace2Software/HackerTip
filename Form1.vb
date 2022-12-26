Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("FUCK YOU")
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("An SSL error has occured and a secure connection to the server cannot be made. - Distrotube (Derek Taylor)")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Doubleclick on the video to fullscreen")
        Dim r As New Random
        Select Case r.Next(1, 3)
            Case 1
                Me.Hide()
                vid1.ShowDialog()
            Case 2
                Me.Hide()
                vid2.ShowDialog()
            Case 3
                Me.Hide()
                vid3.ShowDialog()
        End Select


    End Sub
End Class
