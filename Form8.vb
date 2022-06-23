Imports System.IO
Public Class frmLvl4
    'same as before 
    'from previous levels
    Dim m As Integer = 1
    Dim s As Integer = 60
    Dim one(9) As Integer
    Dim x As Integer = 3
    Dim y As Integer = 3
    'shows user score
    'timer starts
    'bouncing of picture box starts
    Private Sub frmLvl4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = "Score: " & scoresss
        Timer5.Start()
        'random numbers generated and put on the labels
        random()
        TimerBounce.Start()

    End Sub
    'two minute timer procedure
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        s -= 1
        lblTimer.Text = (m & " : " & s)
        If s = 0 Then
            s = 59
            m -= 1
            lblTimer.Text = (m & " : " & s)
            If m = -1 Then
                Timer5.Stop()
                lblTimer.Text = "Times Up"
                txtFive.Enabled = False
                txtFour.Enabled = False
                txtThree.Enabled = False
                txtTwo.Enabled = False
                txtOne.Enabled = False
            End If
        End If

    End Sub
    'location of the form
    Private Sub frmLvl4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(150, 150)

    End Sub
    'randomize the numbers
    Sub random()

        'determines all the numbers on the left side
        Randomize()
        Dim RandNumleft(4) As Integer
        For i As Integer = 0 To RandNumleft.Length - 1
            RandNumleft(i) = Int((1000 - 2 + 1) * Rnd() + 2)
        Next
        one(0) = RandNumleft(0)
        one(1) = RandNumleft(1)
        one(2) = RandNumleft(2)
        one(3) = RandNumleft(3)
        one(4) = RandNumleft(4)


        'puts the numbers on the left intot the labels
        lblOne.Text = one(0)

        lblThree.Text = one(1)

        lblFive.Text = one(2)

        lblSeven.Text = one(3)

        lblNine.Text = one(4)

        'Randomize the right numbers
        Randomize()
        Dim randomNumright(4) As Integer
        For i As Integer = 0 To randomNumright.Length - 1
            randomNumright(i) = Int((1000 - 2 + 1) * Rnd() + 2)
        Next



        'loop for the generation of the numbers on the right
        'ensures that the answers can be given in whole numbers
        'no decimal answers will be needed 
        'numbers generated will have whole number answers
        'Mod used to see if division gives remainder that is not 0
        'if it is the right side number get regenarated until no remainder required
        'means no decimal answer
        Do While one(0) Mod randomNumright(0) <> 0
            Randomize()
            randomNumright(0) = Int((1000 - 2 + 1) * Rnd() + 2)
        Loop

        Do While one(1) Mod randomNumright(1) <> 0
            Randomize()
            randomNumright(1) = Int((1000 - 2 + 1) * Rnd() + 2)
        Loop
        Do While one(2) Mod randomNumright(2) <> 0
            Randomize()
            randomNumright(2) = Int((1000 - 2 + 1) * Rnd() + 2)
        Loop
        Do While one(3) Mod randomNumright(3) <> 0
            Randomize()
            randomNumright(3) = Int((1000 - 2 + 1) * Rnd() + 2)
        Loop
        Do While one(4) Mod randomNumright(4) <> 0
            Randomize()
            randomNumright(4) = Int((1000 - 2 + 1) * Rnd() + 2)
        Loop
        'Randomize numbers for the denominator and set them to the one array
        one(5) = randomNumright(0)
        one(6) = randomNumright(1)
        one(7) = randomNumright(2)
        one(8) = randomNumright(3)
        one(9) = randomNumright(4)



        'For the right side of the divison display text
        lblTwo.Text = one(5)
        lblFour.Text = one(6)
        lblSix.Text = one(7)
        lblEight.Text = one(8)
        lblTen.Text = one(9)


    End Sub
    'same check funtion
    'uses the division operator
    'shows which questions are wrong
    Sub check()



        If one(0) / one(5) = Val(txtOne.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbOne.Image = My.Resources.check_mark
        Else
            Me.pcbOne.Image = My.Resources.wrong
        End If

        If one(1) / one(6) = Val(txtTwo.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbTwo.Image = My.Resources.check_mark
        Else
            Me.pcbTwo.Image = My.Resources.wrong

        End If
        If one(2) / one(7) = Val(txtThree.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbThree.Image = My.Resources.check_mark
        Else
            Me.pcbThree.Image = My.Resources.wrong
        End If
        If one(3) / one(8) = Val(txtFour.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbFour.Image = My.Resources.check_mark
        Else
            Me.pcbFour.Image = My.Resources.wrong

        End If
        If one(4) / one(9) = Val(txtFive.Text) Then
            scoresss = scoresss + 1
            lblScore.Text = "Score:" & scoresss
            Me.pcbFive.Image = My.Resources.check_mark
        Else
            Me.pcbFive.Image = My.Resources.wrong


        End If


    End Sub
    'check button clicked
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        check()
        Timer5.Stop()
        txtFive.Enabled = False
        txtFour.Enabled = False
        txtThree.Enabled = False
        txtTwo.Enabled = False
        txtOne.Enabled = False
        btnCheck.Enabled = False
        'score is added to the file
        'user finished game
        'sent back to main screen
        If scoresss = 20 Then
            btnExit.Enabled = True
            MessageBox.Show("You Have Completed the Game Congratualtions")
            addtofile()
            'user failed level
            'sent back to main screen
        Else
            btnExit.Enabled = True
            MessageBox.Show("You Failed, Please Exit")
            addtofile()

        End If

    End Sub
    'exit click sends user back to start
    'bouncing pcb timer stops
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmStart.Show()
        Me.Close()
        TimerBounce.Stop()

    End Sub
    'calls movepcb procedure during timer start

    Private Sub TimerBounce_Tick(sender As Object, e As EventArgs) Handles TimerBounce.Tick
        movepcb(pcbDivide)


    End Sub
    'move pcb around on the form 
    'bouncing around
    Sub movepcb(ByVal one As PictureBox)
        one.Left = one.Left + x
        one.Top = one.Top + y
        If one.Top > (Me.Height - one.Height - 25) Then
            y = y * -1

        End If

        If one.Top < 0 Then
            y = y * -1

        End If
        If one.Left > (Me.Width - one.Width - 2) Then
            x = x * -1


        End If

        If one.Left < 0 Then
            x = x * -1

        End If



    End Sub



End Class