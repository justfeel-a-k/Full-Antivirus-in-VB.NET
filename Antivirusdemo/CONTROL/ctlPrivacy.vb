Public Class ctlPrivacy
    Dim username As String
    Dim password As String
    Dim host As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ctlPrivacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        username = "freevpn"
        host = "83.170.115.92"
        password = "accounts"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        username = "free"
        host = "65.111.173.161"
        password = "1234"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        username = "free"
        host = "108.163.169.44"
        password = "1234"
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Try
            Dim vpnFolderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector"
            If Not IO.Directory.Exists(vpnFolderPath) Then
                IO.Directory.CreateDirectory(vpnFolderPath)
            End If

            IO.File.WriteAllText(vpnFolderPath & "\connection.pbk", "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "PhoneNumber=" & host)
            IO.File.WriteAllText(vpnFolderPath & "\connection.bat", "rasdial ""VPN"" " & username & " " & password & " /phonebook:" & vpnFolderPath & "\connection.pbk")

            Dim connect As New System.Diagnostics.Process()
            connect.StartInfo.FileName = vpnFolderPath & "\connection.bat"
            connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            connect.Start()
            connect.WaitForExit()

            If connect.ExitCode = 0 Then
                Label2.Text = "CONNECTED TO " & host
                Label2.ForeColor = Color.Green
                PictureBox3.Image = My.Resources.connected
                PictureBox3.BringToFront()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Try
            Dim vpnFolderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector"
            IO.File.WriteAllText(vpnFolderPath & "\disconnect.bat", "rasdial /d")

            Dim disconnect As New System.Diagnostics.Process()
            disconnect.StartInfo.FileName = vpnFolderPath & "\disconnect.bat"
            disconnect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            disconnect.Start()
            disconnect.WaitForExit()

            If disconnect.ExitCode = 0 Then
                Label2.Text = "VPN Disconnected"
                Label2.ForeColor = Color.White
                PictureBox3.Image = My.Resources.disconnected
                PictureBox3.BringToFront()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class



