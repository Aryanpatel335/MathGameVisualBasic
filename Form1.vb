'Aryan Patel
'June 15 2019
'Math game for Kids
'Answer math questions with different operators
Imports System.IO
Public Class frmStart

    'When Instructions button is clicked
    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click
        Me.Hide() 'hides the current form
        My.Computer.Audio.Stop()
        frmInsturctions.Show() 'tells the form 2 to appear
    End Sub
    'Shows leaderboard to user
    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Me.Hide() 'hides the current form
        frmLeaderBoard.Show() 'tells form 3 to appear
        My.Computer.Audio.Stop()

    End Sub
    'when the form starts up
    Private Sub frmStart_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(100, 100) 'set where the form will position on the screen
        'Music plays
        My.Computer.Audio.Play(My.Resources.Off_Limits, AudioPlayMode.BackgroundLoop)
        'Enable the right buttons
        btnOK.Enabled = True
        txtUserName.Enabled = True
        btnPlay.Enabled = False




    End Sub
    'When user clicks play
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Audio stop
        My.Computer.Audio.Stop()
        Me.Hide()
        'Load countdown 3,2,1

        frmCountDown.Show()


    End Sub




    'Ok button to write username to the file
    'Used so that the user can confirm their name is right
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'if nothing entered user gets message box
        If txtUserName.Text = Nothing Then
            MessageBox.Show("Please enter you name")
        Else
            'Informs user of name and then enables user to continue
            MessageBox.Show("Name entered: " & txtUserName.Text)
            btnPlay.Enabled = True
            btnOK.Enabled = False
            txtUserName.Enabled = False

        End If
        ' Create an instance of StreamWriter to write text to a file.
        Dim FS As New FileStream("Scores.txt", FileMode.Append, FileAccess.Write)
        Dim SW As New StreamWriter(FS)

        ' Add username text to the file.
        SW.WriteLine(txtUserName.Text)

        SW.Close()    ' closes the StreamWriter
        FS.Close()    ' closes the FileStream
        txtUserName.Clear()
    End Sub








End Class

