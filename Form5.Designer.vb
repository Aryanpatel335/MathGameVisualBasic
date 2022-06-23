<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountDown
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTextCountDown = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTextCountDown
        '
        Me.lblTextCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTextCountDown.Font = New System.Drawing.Font("Modern No. 20", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextCountDown.Location = New System.Drawing.Point(75, 125)
        Me.lblTextCountDown.Name = "lblTextCountDown"
        Me.lblTextCountDown.Size = New System.Drawing.Size(263, 58)
        Me.lblTextCountDown.TabIndex = 0
        Me.lblTextCountDown.Text = "READY"
        Me.lblTextCountDown.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmCountDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 362)
        Me.Controls.Add(Me.lblTextCountDown)
        Me.Name = "frmCountDown"
        Me.Text = "Count Down"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTextCountDown As Label
    Friend WithEvents Timer1 As Timer
End Class
