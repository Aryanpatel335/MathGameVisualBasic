Imports System.IO
Public Class frmLvl2
    'same as previous level
    Dim m As Integer = 1
    Dim s As Integer = 60
    Dim one(9) As Integer
    Dim x As Integer = 3
    Dim y As Integer = 3


    Private Sub frmLvl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: " & scoresss
        Timer3.Start()
        'random generated numbers
        random()
        TimerBounce.Start()
    End Sub
    'timer for two minutes
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        s -= 1
        lblTimer.Text = (m & " : " & s)
        If s = 0 Then
            s = 59
            m -= 1
            lblTimer.Text = (m & " : " & s)
            If m = -1 Then
                Timer3.Stop()
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
    Private Sub frmLvl2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(150, 150)
    End Sub
    'randomize the numbers
    'same as before
    Sub random()


        Randomize()
        Dim RandNum(9) As Integer
        For i As Integer = 0 To RandNum.Length - 1
            RandNum(i) = Int((100 - 1 + 1) * Rnd() + 1)
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
    'check the inputted answers
    'this time uses the subtractions operator
    'same scoring system
    Sub check()



        If one(0) - one(1) = Val(txtOne.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbOne.Image = My.Resources.check_mark
        Else
            Me.pcbOne.Image = My.Resources.wrong
        End If

        If one(2) - one(3) = Val(txtTwo.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbTwo.Image = My.Resources.check_mark
        Else
            Me.pcbTwo.Image = My.Resources.wrong
        End If

        If one(4) - one(5) = Val(txtThree.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbThree.Image = My.Resources.check_mark
        Else
            Me.pcbThree.Image = My.Resources.wrong
        End If

        If one(6) - one(7) = Val(txtFour.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbFour.Image = My.Resources.check_mark
        Else
            Me.pcbFour.Image = My.Resources.wrong
        End If

        If one(8) - one(9) = Val(txtFive.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbFive.Image = My.Resources.check_mark
        Else
            Me.pcbFive.Image = My.Resources.wrong

        End If


    End Sub
    'same as before
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        check()
        Timer3.Stop()
        btnCheck.Enabled = False
        'if perfect score then user can move on to the next level
        If scoresss = 10 Then
            btnNextLvl.Enabled = True
            MessageBox.Show("You Passed Level Two")
        Else
            'if score is not prefect user has to return home
            btnExit.Enabled = True
            MessageBox.Show("You Failed, Please Exit")
            addtofile()

        End If
        'disable the textboxes so user cannot input values
        txtFive.Enabled = False
        txtFour.Enabled = False
        txtThree.Enabled = False
        txtTwo.Enabled = False
        txtOne.Enabled = False


    End Sub
    'exit application
    'stop bouncing pcb

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmStart.Show()
        Me.Close()
        TimerBounce.Stop()
    End Sub
    'Next level
    'close the form 
    'stop bouncing
    Private Sub btnNextLvl_Click(sender As Object, e As EventArgs) Handles btnNextLvl.Click
        frmLvl3.Show()
        Me.Close()
        TimerBounce.Stop()
    End Sub
    'move pcb around randomly
    Sub movepcb(ByVal one As PictureBox)
        'same as before
        one.Left = one.Left + x
        one.Top = one.Top + y
        If one.Top > (Me.Height - one.Height - 30) Then
            y = y * -1

        End If

        If one.Top < 0 Then
            y = y * -1

        End If
        If one.Left > (Me.Width - one.Width - 8) Then
            x = x * -1


        End If

        If one.Left < 0 Then
            x = x * -1

        End If



    End Sub
    'call the sub to move the minus pcb on form
    Private Sub TimerBounce_Tick(sender As Object, e As EventArgs) Handles TimerBounce.Tick
        movepcb(pcbMinus)
    End Sub

End Class