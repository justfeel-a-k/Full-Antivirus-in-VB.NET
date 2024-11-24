Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ctlDashboard
    Dim isActive As Boolean

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If isActive = False Then
            isActive = True
            MyButton1.Text = "Disable"
            MyButton1.BottomColor = Color.Red
            MyButton1.TopColor = Color.DarkRed
            MyFunctions.Disable_Firewall()
        ElseIf isActive = True Then
            isActive = False
            MyButton1.Text = "Enable"
            MyButton1.BottomColor = Color.Blue
            MyButton1.TopColor = Color.Navy
            MyFunctions.Enable_Firewall()
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ctlDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.firewall = True Then
            isActive = True
            MyButton1.BottomColor = Color.Red
            MyButton1.TopColor = Color.DarkRed
            MyButton1.Text = "Disable"

        ElseIf My.Settings.firewall = False Then
            isActive = False
            MyButton1.BottomColor = Color.Blue
            MyButton1.TopColor = Color.Navy
            MyButton1.Text = "Enable"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmScan.ShowDialog()
        frmScan.FolderBrowserDialog1.SelectedPath = "C:\"

        On Error Resume Next
        For Each strDir As String In System.IO.Directory.GetDirectories(frmScan.FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.TopDirectoryOnly)
            For Each strFile As String In System.IO.Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                frmScan.ListBox1.Items.Add(strFile)
            Next
        Next

        frmScan.MyButton1.Enabled = False
        frmScan.MyButton3.Enabled = True
        frmScan.MyButton4.Enabled = True
        frmScan.Timer1.Start()
        frmScan.ProgressBar1.Visible = False

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmScan.ShowDialog()

        If frmScan.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmScan.ListBox1.Items.Clear()
            MyButton1.Enabled = True
        Else
            Exit Sub
        End If

        On Error Resume Next

        For Each strFile As String In System.IO.Directory.GetFiles(frmScan.FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
            frmScan.ListBox1.Items.Add(strFile)
        Next
        frmScan.Timer1.Start()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form1.btnprivacy.PerformClick()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(MyStrings.HelpLink)
    End Sub
End Class
