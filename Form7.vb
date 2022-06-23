Imports System.IO
Public Class frmLvl3
    'same as before
    Dim m As Integer = 1
    Dim s As Integer = 60
    Dim one(9) As Integer
    Dim x As Integer = 3
    Dim y As Integer = 3

    Private Sub frmLvl3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'score of user up to the level
        lblScore.Text = "Score: " & scoresss
        Timer4.Start()
        'random numbers generated
        random()
        'start bouncing of pcb
        TimerBounce.Start()

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'timer same as before
        s -= 1
        lblTimer.Text = (m & " : " & s)
        If s = 0 Then
            s = 59
            m -= 1
            lblTimer.Text = (m & " : " & s)
            If m = -1 Then
                Timer4.Stop()
                lblTimer.Text = "Times Up"
                txtFive.Enabled = False
                txtFour.Enabled = False
                txtThree.Enabled = False
                txtTwo.Enabled = False
                txtOne.Enabled = False
            End If
        End If


    End Sub
    'form location
    Private Sub frmLvl3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(150, 150)
    End Sub
    'randomize the numbers
    'same as previous
    'except the numbers are from 10-1 to make it easier for the user
    Sub random()


        Randomize()
        Dim RandNum(9) As Integer
        For i As Integer = 0 To RandNum.Length - 1
            RandNum(i) = Int((10 - 0 + 1) * Rnd() + 0)
        Next
        one(0) = RandNum(0)
        one(1) = RandNum(1)
        one(2) = RandNum(2)
        one(3) = RandNum(3)
        one(4) = RandNum(4)
        one(5) = RandNum(5)
        one(6) = RandNum(6)
        one(7) = RandNum(7)
        one(8) = RandNum(8)
        one(9) = RandNum(9)


        lblOne.Text = one(0)
        lblTwo.Text = one(1)
        lblThree.Text = one(2)
        lblFour.Text = one(3)
        lblFive.Text = one(4)
        lblSix.Text = one(5)
        lblSeven.Text = one(6)
        lblEight.Text = one(7)
        lblNine.Text = one(8)
        lblTen.Text = one(9)


    End Sub
    'check if the user answers are correct
    'this time it uses the multiplication operator
    Sub check()



        If one(0) * one(1) = Val(txtOne.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbOne.Image = My.Resources.check_mark
        Else
            Me.pcbOne.Image = My.Resources.wrong

        End If

        If one(2) * one(3) = Val(txtTwo.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbTwo.Image = My.Resources.check_mark
        Else
            Me.pcbTwo.Image = My.Resources.wrong
        End If
        If one(4) * one(5) = Val(txtThree.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbThree.Image = My.Resources.check_mark
        Else
            Me.pcbThree.Image = My.Resources.wrong

        End If

        If one(6) * one(7) = Val(txtFour.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbFour.Image = My.Resources.check_mark
        Else
            Me.pcbFour.Image = My.Resources.wrong

        End If

        If one(8) * one(9) = Val(txtFive.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbFive.Image = My.Resources.check_mark
        Else
            Me.pcbFive.Image = My.Resources.wrong
        End If


    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'same as before
        check()
        Timer4.Stop()
        txtFive.Enabled = False
        txtFour.Enabled = False
        txtThree.Enabled = False
        txtTwo.Enabled = False
        txtOne.Enabled = False
        btnCheck.Enabled = False
        'if perfect score user moves on
        If scoresss = 15 Then
            btnNxtlvl.Enabled = True
            MessageBox.Show("You Passed Level Three")
            ' if not perfect score user has to go back
            'user final scores is added to the text file

        Else
            btnExit.Enabled = True
            MessageBox.Show("You Failed, Please Exit")
            addtofile()

        End If



    End Sub
    'close form and go back to start
    'stop bouncing
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmStart.Show()
        Me.Close()
        TimerBounce.Stop()
    End Sub
    'next level shown
    'stop bouncing timer
    Private Sub btnNxtlvl_Click(sender As Object, e As EventArgs) Handles btnNxtlvl.Click
        frmLvl4.Show()
        Me.Close()
        TimerBounce.Stop()
    End Sub
    'move pcb 
    'same as before 
    'moves multiplication picuture box
    Sub movepcb(ByVal one As PictureBox)
        one.Left = one.Left + x
        one.Top = one.Top + y
        If one.Top > (Me.Height - one.Height - 35) Then
            y = y * -1

        End If

        If one.Top < 0 Then
            y = y * -1

        End If
        If one.Left > (Me.Width - one.Width - 5) Then
            x = x * -1


        End If

        If one.Left < 0 Then
            x = x * -1

        End If



    End Sub
    'calls the move procedure for the picture box
    Private Sub TimerBounce_Tick(sender As Object, e As EventArgs) Handles TimerBounce.Tick
        movepcb(pcbMultiply)
    End Sub

End Class