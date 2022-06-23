<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLvlOne
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPlusTwo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPlusThree = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPlusFour = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPlusFive = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNxtLevel = New System.Windows.Forms.Button()
        Me.pcbOne = New System.Windows.Forms.PictureBox()
        Me.pcbTwo = New System.Windows.Forms.PictureBox()
        Me.pcbThree = New System.Windows.Forms.PictureBox()
        Me.pcbFour = New System.Windows.Forms.PictureBox()
        Me.pcbFive = New System.Windows.Forms.PictureBox()
        Me.pcbPlus = New System.Windows.Forms.PictureBox()
        Me.TimerBounce = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Modern No. 20", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(128, 26)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(101, 58)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "GO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Location = New System.Drawing.Point(146, 129)
        Me.lblPlus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(18, 20)
        Me.lblPlus.TabIndex = 2
        Me.lblPlus.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(285, 125)
        Me.txtOne.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(96, 26)
        Me.txtOne.TabIndex = 4
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(150, 508)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(112, 35)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(285, 185)
        Me.txtTwo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(96, 26)
        Me.txtTwo.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'lblPlusTwo
        '
        Me.lblPlusTwo.AutoSize = True
        Me.lblPlusTwo.Location = New System.Drawing.Point(146, 189)
        Me.lblPlusTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlusTwo.Name = "lblPlusTwo"
        Me.lblPlusTwo.Size = New System.Drawing.Size(18, 20)
        Me.lblPlusTwo.TabIndex = 7
        Me.lblPlusTwo.Text = "+"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(285, 252)
        Me.txtThree.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(96, 26)
        Me.txtThree.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 255)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label6"
        '
        'lblPlusThree
        '
        Me.lblPlusThree.AutoSize = True
        Me.lblPlusThree.Location = New System.Drawing.Point(146, 257)
        Me.lblPlusThree.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlusThree.Name = "lblPlusThree"
        Me.lblPlusThree.Size = New System.Drawing.Size(18, 20)
        Me.lblPlusThree.TabIndex = 11
        Me.lblPlusThree.Text = "+"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 329)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Label8"
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(285, 325)
        Me.txtFour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.Size = New System.Drawing.Size(96, 26)
        Me.txtFour.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 403)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Label9"
        '
        'lblPlusFour
        '
        Me.lblPlusFour.AutoSize = True
        Me.lblPlusFour.Location = New System.Drawing.Point(146, 329)
        Me.lblPlusFour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlusFour.Name = "lblPlusFour"
        Me.lblPlusFour.Size = New System.Drawing.Size(18, 20)
        Me.lblPlusFour.TabIndex = 15
        Me.lblPlusFour.Text = "+"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 331)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(285, 397)
        Me.txtFive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(96, 26)
        Me.txtFive.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(192, 402)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Label10"
        '
        'lblPlusFive
        '
        Me.lblPlusFive.AutoSize = True
        Me.lblPlusFive.Location = New System.Drawing.Point(146, 402)
        Me.lblPlusFive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlusFive.Name = "lblPlusFive"
        Me.lblPlusFive.Size = New System.Drawing.Size(18, 20)
        Me.lblPlusFive.TabIndex = 19
        Me.lblPlusFive.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Label4"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(346, 26)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(88, 25)
        Me.lblScore.TabIndex = 22
        Me.lblScore.Text = "Score: 0"
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(22, 508)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 35)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNxtLevel
        '
        Me.btnNxtLevel.Enabled = False
        Me.btnNxtLevel.Location = New System.Drawing.Point(285, 508)
        Me.btnNxtLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNxtLevel.Name = "btnNxtLevel"
        Me.btnNxtLevel.Size = New System.Drawing.Size(118, 35)
        Me.btnNxtLevel.TabIndex = 24
        Me.btnNxtLevel.Text = "Level 2"
        Me.btnNxtLevel.UseVisualStyleBackColor = True
        '
        'pcbOne
        '
        Me.pcbOne.Location = New System.Drawing.Point(402, 112)
        Me.pcbOne.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbOne.Name = "pcbOne"
        Me.pcbOne.Size = New System.Drawing.Size(50, 43)
        Me.pcbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbOne.TabIndex = 25
        Me.pcbOne.TabStop = False
        '
        'pcbTwo
        '
        Me.pcbTwo.Location = New System.Drawing.Point(402, 177)
        Me.pcbTwo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbTwo.Name = "pcbTwo"
        Me.pcbTwo.Size = New System.Drawing.Size(50, 43)
        Me.pcbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTwo.TabIndex = 26
        Me.pcbTwo.TabStop = False
        '
        'pcbThree
        '
        Me.pcbThree.Location = New System.Drawing.Point(402, 240)
        Me.pcbThree.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbThree.Name = "pcbThree"
        Me.pcbThree.Size = New System.Drawing.Size(50, 43)
        Me.pcbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbThree.TabIndex = 27
        Me.pcbThree.TabStop = False
        '
        'pcbFour
        '
        Me.pcbFour.Location = New System.Drawing.Point(402, 312)
        Me.pcbFour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbFour.Name = "pcbFour"
        Me.pcbFour.Size = New System.Drawing.Size(50, 43)
        Me.pcbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFour.TabIndex = 28
        Me.pcbFour.TabStop = False
        '
        'pcbFive
        '
        Me.pcbFive.Location = New System.Drawing.Point(402, 385)
        Me.pcbFive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbFive.Name = "pcbFive"
        Me.pcbFive.Size = New System.Drawing.Size(50, 43)
        Me.pcbFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFive.TabIndex = 29
        Me.pcbFive.TabStop = False
        '
        'pcbPlus
        '
        Me.pcbPlus.BackColor = System.Drawing.Color.White
        Me.pcbPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbPlus.Image = Global.Final_Project.My.Resources.Resources.plus_red
        Me.pcbPlus.Location = New System.Drawing.Point(3, 12)
        Me.pcbPlus.Name = "pcbPlus"
        Me.pcbPlus.Size = New System.Drawing.Size(89, 64)
        Me.pcbPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlus.TabIndex = 30
        Me.pcbPlus.TabStop = False
        '
        'TimerBounce
        '
        Me.TimerBounce.Interval = 50
        '
        'frmLvlOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 572)
        Me.Controls.Add(Me.pcbFive)
        Me.Controls.Add(Me.pcbFour)
        Me.Controls.Add(Me.pcbThree)
        Me.Controls.Add(Me.pcbTwo)
        Me.Controls.Add(Me.pcbOne)
        Me.Controls.Add(Me.btnNxtLevel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblPlusFive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFour)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPlusFour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPlusThree)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPlusTwo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.pcbPlus)
        Me.Name = "frmLvlOne"
        Me.Text = "Level 1"
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOne As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPlusTwo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtThree As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPlusThree As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFour As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPlusFour As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFive As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPlusFive As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNxtLevel As Button
    Friend WithEvents pcbOne As PictureBox
    Friend WithEvents pcbTwo As PictureBox
    Friend WithEvents pcbThree As PictureBox
    Friend WithEvents pcbFour As PictureBox
    Friend WithEvents pcbFive As PictureBox
    Friend WithEvents pcbPlus As PictureBox
    Friend WithEvents TimerBounce As Timer
End Class
