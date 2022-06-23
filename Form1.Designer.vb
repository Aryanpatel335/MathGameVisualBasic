<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPromptUsername = New System.Windows.Forms.Label()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPromptUsername
        '
        Me.lblPromptUsername.AutoSize = True
        Me.lblPromptUsername.BackColor = System.Drawing.Color.Yellow
        Me.lblPromptUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromptUsername.Location = New System.Drawing.Point(24, 204)
        Me.lblPromptUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPromptUsername.Name = "lblPromptUsername"
        Me.lblPromptUsername.Size = New System.Drawing.Size(153, 25)
        Me.lblPromptUsername.TabIndex = 11
        Me.lblPromptUsername.Text = "Player Name:"
        '
        'btnScores
        '
        Me.btnScores.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScores.Location = New System.Drawing.Point(293, 51)
        Me.btnScores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(84, 62)
        Me.btnScores.TabIndex = 9
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.Red
        Me.btnInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(44, 51)
        Me.btnInstructions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(119, 62)
        Me.btnInstructions.TabIndex = 8
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(166, 300)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(117, 76)
        Me.btnPlay.TabIndex = 7
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Lime
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(313, 204)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 27)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(191, 208)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(92, 20)
        Me.txtUserName.TabIndex = 13
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.math
        Me.ClientSize = New System.Drawing.Size(449, 410)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblPromptUsername)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnPlay)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmStart"
        Me.Text = "Math Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPromptUsername As Label
    Friend WithEvents btnScores As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtUserName As TextBox
End Class
