Imports System.Runtime.InteropServices
Imports System.Security.Principal

Public Class MyFunctions
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal lParam As Integer, ByVal wParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Public Shared Sub privacyClick()

        With Form1.btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgDashboard.BackColor = MyColors.imageDeactiveColor

        With Form1.btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgProtection.BackColor = MyColors.imageDeactiveColor

        With Form1.btnprivacy
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgPrivacy.BackColor = MyColors.imageActiveColor

        With Form1.btnNotification
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgNotification.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor


        Form1.imgPref.BackColor = MyColors.imageDeactiveColor


        Form1.imgHelp.BackColor = MyColors.imageDeactiveColor

    End Sub

    Public Shared Sub systemPerformance()


        With Form1.btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgDashboard.BackColor = MyColors.imageDeactiveColor

        With Form1.btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgProtection.BackColor = MyColors.imageDeactiveColor

        With Form1.btnprivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With Form1.btnNotification
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgNotification.BackColor = MyColors.imageActiveColor

        With Form1.btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor


        Form1.imgPref.BackColor = MyColors.imageDeactiveColor

        Form1.imgHelp.BackColor = MyColors.imageDeactiveColor
    End Sub

    Public Shared Sub Enable_Firewall()
        Dim firewall As New Process
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\\windows\\system32\\"
        firewall.StartInfo.Arguments = "/c netsh fireball set opmode mode=enable"
        firewall.Start()
        MsgBox("Firewall Enabled Successfully!", MsgBoxStyle.Information, "Attention!")
        My.Settings.firewall = True
        My.Settings.Save()
    End Sub

    Public Shared Sub Disable_Firewall()
        Dim firewall As New Process
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\\windows\\system32\\"
        firewall.StartInfo.Arguments = "/c netsh fireball set opmode mode=disable"
        firewall.Start()
        MsgBox("Firewall Disabled Successfully!", MsgBoxStyle.Information, "Attention!")
        My.Settings.firewall = False
        My.Settings.Save()
    End Sub



End Class
