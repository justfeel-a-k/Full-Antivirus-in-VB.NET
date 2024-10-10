Public Class frmpopup
    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Application.Exit()
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Me.Hide()
    End Sub

    Private Sub frmpopup_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)
        End If
    End Sub
End Class