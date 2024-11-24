Imports System.Runtime.InteropServices

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ActivationStatus = False Then
            CtlSubscription1.BringToFront()
            CtlSubscription1.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, HeaderPanel.MouseDown, LblTitle.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CtlDashboard1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub HeaderPanel_Paint(sender As Object, e As PaintEventArgs) Handles HeaderPanel.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles imgNotification.Click

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        frmpopup.ShowDialog()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        CtlDashboard1.BringToFront()
        CtlDashboard1.Visible = True
        With btnDashboard
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With

        imgDashboard.BackColor = MyColors.imageActiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnprivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotification
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotification.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor

        imgPref.BackColor = MyColors.imageDeactiveColor


        imgHelp.BackColor = MyColors.imageDeactiveColor

    End Sub

    Private Sub btnProtection_Click(sender As Object, e As EventArgs) Handles btnProtection.Click
        CtlScanCenter1.BringToFront()
        CtlScanCenter1.Visible = True
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With

        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgProtection.BackColor = MyColors.imageActiveColor

        With btnprivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotification
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotification.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor


        imgPref.BackColor = MyColors.imageDeactiveColor


        imgHelp.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnprivacy_Click(sender As Object, e As EventArgs) Handles btnprivacy.Click
        MyFunctions.privacyClick()

        CtlPrivacy1.BringToFront()
        CtlPrivacy1.Visible = True
    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        MyFunctions.systemPerformance()
        CtlSystemPerformance1.BringToFront()
        CtlSystemPerformance1.Visible = True
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        ctlAccount1.Bringtofront()
        ctlAccount1.visible = True
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnprivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotification
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotification.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgAccount.BackColor = MyColors.imageActiveColor


        imgPref.BackColor = MyColors.imageDeactiveColor


        imgHelp.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnPref_Click(sender As Object, e As EventArgs)
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnprivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotification
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotification.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor


        imgPref.BackColor = MyColors.imageActiveColor


        imgHelp.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnprivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotification
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotification.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor


        imgPref.BackColor = MyColors.imageDeactiveColor

        
        imgHelp.BackColor = MyColors.imageActiveColor
    End Sub

    Private Sub imgHelp_Click(sender As Object, e As EventArgs) Handles imgHelp.Click
        Process.Start("https://www.google.com")
    End Sub

    Private Sub imgPref_Click(sender As Object, e As EventArgs) Handles imgPref.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        CtlSubscription1.BringToFront()
        CtlSubscription1.Visible = True
    End Sub
End Class
