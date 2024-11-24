Public Class ctlSystemPerformance
    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ctlSystemPerformance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)
        lblComputerName.Text = name
        Dim speed As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "~MHz", Nothing) & " MHz"
        lblComputerSpeed.Text = speed
    End Sub

    Private Sub ctlSystemPerformance_DpiChangedBeforeParent(sender As Object, e As EventArgs) Handles Me.DpiChangedBeforeParent

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblComputerName.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fcpu As Single = pCPU.NextValue()
        Dim fram As Single = pRAM.NextValue()
        ProgressBar1.Value = CInt(fcpu)
        ProgressBar2.Value = CInt(fram)
        lblCPU.Text = String.Format("{0:0.00}%", fcpu)
        lblRAM.Text = String.Format("{0:0.00}%", fram)
        Chart1.Series("CPU").Points.AddY(fcpu)
        Chart1.Series("RAM").Points.AddY(fram)
    End Sub
End Class
