Public Class frmInsturctions
    'openes the instructions form
    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.SetDesktopLocation(300, 300)
        'changing the score variable


    End Sub
    'Exit the application
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'closing the application
    End Sub
    'go to the main page
    Private Sub ReturnHomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide() 'hiding the current form
        frmStart.Show() 'telling form1 to re-appear, will call activate event method
    End Sub
    'When closed go back to main page.
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmStart.Show() 'opening main form
    End Sub

End Class