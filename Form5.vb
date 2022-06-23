
'countdown 3,2,1
Public Class frmCountDown
    Dim s As Integer = 4



    'countdown when form loads
    Private Sub frmCountDown_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        Me.SetDesktopLocation(300, 300)
    End Sub


    'timer tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'subtract 1 
        s -= 1
        'show on label 
        lblTextCountDown.Text = s
        If s = 0 Then
            'top timer when 0 is reached
            Timer1.Stop()
            'show level one
            Me.Close()
            frmLvlOne.Show()
        End If


    End Sub




End Class