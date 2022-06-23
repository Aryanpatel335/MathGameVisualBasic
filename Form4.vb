Imports System.IO
'Level One
Public Class frmLvlOne
    'Determines m as intger for minutes of timer
    Dim m As Integer = 1
    's for the seconds
    Dim s As Integer = 60
    'For the number of random numbers
    Dim one(9) As Integer
    'Scores added up
    Dim scores As Integer
    'Move pcb 
    Dim x As Integer = 3
    Dim y As Integer = 3
    'When the form loads pcb moves, timer starts, and numbers are randomly generated
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer2.Start()
        random()
        TimerBounce.Start()

    End Sub
    'The timer countdown for 2 minutes
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        s -= 1
        lblTimer.Text = (m & " : " & s)
        If s = 0 Then
            s = 59
            m -= 1
            lblTimer.Text = (m & " : " & s)
            'when timer reaches -1 the questions get locked
            If m = -1 Then
                Timer2.Stop()
                lblTimer.Text = "Times Up"
                txtFive.Enabled = False
                txtFour.Enabled = False
                txtThree.Enabled = False
                txtTwo.Enabled = False
                txtOne.Enabled = False
            End If
        End If

    End Sub

    'Determines position of the form when loads
    Private Sub frmLvlOne_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(150, 150)
    End Sub


    'Sub procedure to randomize the numbers for the question
    Sub random()

        'Randomly choses from 1 to 100 and store in array
        Randomize()
        Dim RandNum(9) As Integer
        For i As Integer = 0 To RandNum.Length - 1
            RandNum(i) = Int((100 - 1 + 1) * Rnd() + 1)
        Next
        'put numbers into the one array 
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

        'Display on labels
        Label1.Text = one(0)
        Label2.Text = one(1)
        Label3.Text = one(2)
        Label4.Text = one(3)
        Label5.Text = one(4)
        Label6.Text = one(5)
        Label7.Text = one(6)
        Label8.Text = one(7)
        Label9.Text = one(8)
        Label10.Text = one(9)


    End Sub
    'check if the number entered by user is correct
    Sub check()


        'If the number is correct than add one to the score
        'show the check mark picture
        'tells user if they got the question wrong
        'by showing the picture
        'Same for each question
        If one(0) + one(1) = Val(txtOne.Text) Then
            scores = scores + 1
            lblScore.Text = "Score:" & scores
            Me.pcbOne.Image = My.Resources.check_mark
        Else
            Me.pcbOne.Image = My.Resources.wrong
        End If

        If one(2) + one(3) = Val(txtTwo.Text) Then
            scores = scores + 1
            lblScore.Text = "Score:" & scores
            Me.pcbTwo.Image = My.Resources.check_mark
        Else
            Me.pcbTwo.Image = My.Resources.wrong
        End If
        If one(4) + one(5) = Val(txtThree.Text) Then
            scores = scores + 1
            lblScore.Text = "Score:" & scores
            Me.pcbThree.Image = My.Resources.check_mark
        Else
            Me.pcbThree.Image = My.Resources.wrong
        End If
        If one(6) + one(7) = Val(txtFour.Text) Then
            scores = scores + 1
            lblScore.Text = "Score:" & scores
            Me.pcbFour.Image = My.Resources.check_mark
        Else
            Me.pcbFour.Image = My.Resources.wrong
        End If
        If one(8) + one(9) = Val(txtFive.Text) Then
            scores = scores + 1
            lblScore.Text = "Score:" & scores
            Me.pcbFive.Image = My.Resources.check_mark
        Else
            Me.pcbFive.Image = My.Resources.wrong
        End If


    End Sub
    'user clicks check
    'in order to check if the questions are right
    'when user is confident in their answers
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'calls the procedure for the checking
        check()
        'makes scores set to the public variable in the module
        scoresss = scores
        btnCheck.Enabled = False
        'if score is 5 then user can more on to the next level 
        If scores = 5 Then
            btnNxtLevel.Enabled = True
            MessageBox.Show("You Passed Level One")
            'user has to go back to the start
            'score is recorded on file through addtofile function
        Else
            btnExit.Enabled = True
            MessageBox.Show("You Failed, Please Exit")
            addtofile()

        End If
        'if there is nothing then the score is 0 and user has to move to main page

        If txtOne.Text = Nothing And txtTwo.Text = Nothing And txtThree.Text = Nothing And txtFour.Text = Nothing And txtFive.Text = Nothing Then
            scoresss = 0
            lblScore.Text = "Score: " & scoresss
        End If
        'disables textboxes preventing user from entering values
        'Stops timer
        txtFive.Enabled = False
        txtFour.Enabled = False
        txtThree.Enabled = False
        txtTwo.Enabled = False
        txtOne.Enabled = False
        Timer2.Stop()

    End Sub

    'Stops the bouncing pcb
    'goes back to main form

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        TimerBounce.Stop()


        frmStart.Show()
        Me.Close()

    End Sub
    'Stop the bouncing 
    'go to next level
    'close current level
    Private Sub btnNxtLevel_Click(sender As Object, e As EventArgs) Handles btnNxtLevel.Click

        TimerBounce.Stop()
        frmLvl2.Show()
        Me.Close()

    End Sub
    'move pcb when the timer ticks
    Private Sub TimerBounce_Tick(sender As Object, e As EventArgs) Handles TimerBounce.Tick
        movepcb(pcbPlus)
    End Sub
    'move picture box left right up down
    'picture box hits walls and randomly shots back other way

    Sub movepcb(ByVal one As PictureBox)
        'add by x to move 
        'add by y to move 
        one.Left = one.Left + x
        one.Top = one.Top + y
        'max on the y axis
        'if edge hit then bounce back
        If one.Top > (Me.Height - one.Height - (one.Height - 0)) Then
            y = y * -1

        End If

        If one.Top < 0 Then
            y = y * -1

        End If
        'max on left to right
        'if max reached then go the other way
        If one.Left > (Me.Width - one.Width - (one.Height - 20)) Then
            x = x * -1


        End If

        If one.Left < 0 Then
            x = x * -1

        End If



    End Sub

End Class