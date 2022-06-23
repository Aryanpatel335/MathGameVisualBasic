Imports System.IO
Module Module1


    'Public integer for the scores
    Public scoresss As Integer
    'function to add the user score to the file
    Function addtofile()
        'adds the score to the file scores
        Dim FS As New FileStream("Scores.txt", FileMode.Append, FileAccess.Write)
        Dim SW As New StreamWriter(FS)

        ' Add text to the file.
        'scores added to the file
        SW.WriteLine(scoresss)



        SW.Close()    ' closes the StreamWriter
        FS.Close()    ' closes the FileStream

        Return True
    End Function


End Module
