Imports System.IO
Public Class frmLeaderBoard

    'For the counter
    Dim x As Integer = 0

    'Structure to hold the name and score of user 
    Structure scores
        Dim names As String
        Dim score As Integer

    End Structure
    'Put the structure into a string
    Dim namesandscores(9) As scores
    'sets the postion of where the form will open up
    Private Sub Form3_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(100, 200)

    End Sub
    'When you click exit on the tool strip you exit application
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'closing the application
    End Sub
    'return home tool strip allows you to go back to main page
    Private Sub ReturnHomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide() 'hiding the current form
        frmStart.Show() 'telling form1 to re-appear, will call activate event method
    End Sub

    'WHen the form loads
    Private Sub frmLeaderBoard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        'call subprocedure
        fillinfo()
        'The bubblesort procedure is called
        Call BubbleSort(namesandscores)
        For i As Integer = 0 To namesandscores.Length - 1
            'Put in the items into the respective listbox
            lstNames.Items.Add(namesandscores(i).names)
            lstScores.Items.Add(namesandscores(i).score)

        Next

    End Sub
    'Bubble Sort procedure
    Sub BubbleSort(ByRef ArrayReceived() As scores)

        'Sorts so that the highest goes ontop 
        Dim compare As scores 'temperory variable to compare to score variables
        For BubbledItem As Integer = 0 To ArrayReceived.Length - 1
            For sortItem As Integer = 0 To ArrayReceived.Length - 2
                'if less than means that it sorts greatest to lowest
                'used for the score value only 
                If ArrayReceived(sortItem).score < ArrayReceived(sortItem + 1).score Then
                    compare = ArrayReceived(sortItem)    ' switch items so that the highest is on top
                    ArrayReceived(sortItem) = ArrayReceived(sortItem + 1)
                    ArrayReceived(sortItem + 1) = compare
                End If
            Next sortItem
        Next BubbledItem

    End Sub




    'Read file and then read the information
    Sub fillinfo()

        'Create an object called FS of type FileStream that is set to Open and Read from a file called "temp.txt"        
        Dim FS As New FileStream("Scores.txt", FileMode.Open, FileAccess.Read)
        Dim textfile As New StreamReader(FS) 'Create an instance of StreamReader Classs to read from a file.

            Do While textfile.Peek <> -1 'keeps reading file while NOT end of file

                'Keeps reading and adding to the x variable so that the line is read and labeled respectively
                'x is used to keep reading the next line in the file and then to store date to get it ready to call up to the main load procedure

                namesandscores(x).names = textfile.ReadLine
                namesandscores(x).score = Val(textfile.ReadLine)
                x = x + 1
            Loop

            textfile.Close()     ' closes the StreamWriter
            FS.Close()    ' closes the FileStream 




        End Sub

    Private Sub frmLeaderBoard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmStart.Show()

    End Sub
End Class

