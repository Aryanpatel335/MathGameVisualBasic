<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLvl2
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblSix = New System.Windows.Forms.Label()
        Me.lblSeven = New System.Windows.Forms.Label()
        Me.lblEight = New System.Windows.Forms.Label()
        Me.lblNine = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.lblMinusOne = New System.Windows.Forms.Label()
        Me.lblMinusTwo = New System.Windows.Forms.Label()
        Me.lblMinusThree = New System.Windows.Forms.Label()
        Me.lblMinusFour = New System.Windows.Forms.Label()
        Me.lblMinusFive = New System.Windows.Forms.Label()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnNextLvl = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pcbFive = New System.Windows.Forms.PictureBox()
        Me.pcbFour = New System.Windows.Forms.PictureBox()
        Me.pcbThree = New System.Windows.Forms.PictureBox()
        Me.pcbTwo = New System.Windows.Forms.PictureBox()
        Me.pcbOne = New System.Windows.Forms.PictureBox()
        Me.pcbMinus = New System.Windows.Forms.PictureBox()
        Me.TimerBounce = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(396, 29)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 25)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "---"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(58, 125)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(57, 20)
        Me.lblOne.TabIndex = 1
        Me.lblOne.Text = "Label1"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(206, 125)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(57, 20)
        Me.lblTwo.TabIndex = 2
        Me.lblTwo.Text = "Label2"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(58, 192)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(57, 20)
        Me.lblThree.TabIndex = 3
        Me.lblThree.Text = "Label3"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Location = New System.Drawing.Point(206, 192)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(57, 20)
        Me.lblFour.TabIndex = 4
        Me.lblFour.Text = "Label4"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(58, 254)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(57, 20)
        Me.lblFive.TabIndex = 5
        Me.lblFive.Text = "Label5"
        '
        'lblSix
        '
        Me.lblSix.AutoSize = True
        Me.lblSix.Location = New System.Drawing.Point(214, 254)
        Me.lblSix.Name = "lblSix"
        Me.lblSix.Size = New System.Drawing.Size(57, 20)
        Me.lblSix.TabIndex = 6
        Me.lblSix.Text = "Label6"
        '
        'lblSeven
        '
        Me.lblSeven.AutoSize = True
        Me.lblSeven.Location = New System.Drawing.Point(58, 328)
        Me.lblSeven.Name = "lblSeven"
        Me.lblSeven.Size = New System.Drawing.Size(57, 20)
        Me.lblSeven.TabIndex = 7
        Me.lblSeven.Text = "Label7"
        '
        'lblEight
        '
        Me.lblEight.AutoSize = True
        Me.lblEight.Location = New System.Drawing.Point(214, 328)
        Me.lblEight.Name = "lblEight"
        Me.lblEight.Size = New System.Drawing.Size(57, 20)
        Me.lblEight.TabIndex = 8
        Me.lblEight.Text = "Label8"
        '
        'lblNine
        '
        Me.lblNine.AutoSize = True
        Me.lblNine.Location = New System.Drawing.Point(58, 398)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(57, 20)
        Me.lblNine.TabIndex = 9
        Me.lblNine.Text = "Label9"
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.Location = New System.Drawing.Point(214, 398)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(66, 20)
        Me.lblTen.TabIndex = 10
        Me.lblTen.Text = "Label10"
        '
        'lblMinusOne
        '
        Me.lblMinusOne.AutoSize = True
        Me.lblMinusOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusOne.Location = New System.Drawing.Point(148, 112)
        Me.lblMinusOne.Name = "lblMinusOne"
        Me.lblMinusOne.Size = New System.Drawing.Size(27, 37)
        Me.lblMinusOne.TabIndex = 11
        Me.lblMinusOne.Text = "-"
        '
        'lblMinusTwo
        '
        Me.lblMinusTwo.AutoSize = True
        Me.lblMinusTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusTwo.Location = New System.Drawing.Point(148, 192)
        Me.lblMinusTwo.Name = "lblMinusTwo"
        Me.lblMinusTwo.Size = New System.Drawing.Size(27, 37)
        Me.lblMinusTwo.TabIndex = 12
        Me.lblMinusTwo.Text = "-"
        '
        'lblMinusThree
        '
        Me.lblMinusThree.AutoSize = True
        Me.lblMinusThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusThree.Location = New System.Drawing.Point(148, 254)
        Me.lblMinusThree.Name = "lblMinusThree"
        Me.lblMinusThree.Size = New System.Drawing.Size(27, 37)
        Me.lblMinusThree.TabIndex = 13
        Me.lblMinusThree.Text = "-"
        '
        'lblMinusFour
        '
        Me.lblMinusFour.AutoSize = True
        Me.lblMinusFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusFour.Location = New System.Drawing.Point(148, 328)
        Me.lblMinusFour.Name = "lblMinusFour"
        Me.lblMinusFour.Size = New System.Drawing.Size(27, 37)
        Me.lblMinusFour.TabIndex = 14
        Me.lblMinusFour.Text = "-"
        '
        'lblMinusFive
        '
        Me.lblMinusFive.AutoSize = True
        Me.lblMinusFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinusFive.Location = New System.Drawing.Point(148, 398)
        Me.lblMinusFive.Name = "lblMinusFive"
        Me.lblMinusFive.Size = New System.Drawing.Size(27, 37)
        Me.lblMinusFive.TabIndex = 15
        Me.lblMinusFive.Text = "-"
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(302, 122)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(70, 26)
        Me.txtOne.TabIndex = 16
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(302, 186)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(70, 26)
        Me.txtTwo.TabIndex = 17
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(302, 254)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(70, 26)
        Me.txtThree.TabIndex = 18
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(302, 322)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.Size = New System.Drawing.Size(70, 26)
        Me.txtFour.TabIndex = 19
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(302, 392)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(70, 26)
        Me.txtFive.TabIndex = 20
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(165, 474)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(98, 35)
        Me.btnCheck.TabIndex = 22
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnNextLvl
        '
        Me.btnNextLvl.Enabled = False
        Me.btnNextLvl.Location = New System.Drawing.Point(302, 474)
        Me.btnNextLvl.Name = "btnNextLvl"
        Me.btnNextLvl.Size = New System.Drawing.Size(98, 35)
        Me.btnNextLvl.TabIndex = 23
        Me.btnNextLvl.Text = "Level 3"
        Me.btnNextLvl.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(38, 474)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 35)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Modern No. 20", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(106, 14)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(101, 58)
        Me.lblTimer.TabIndex = 25
        Me.lblTimer.Text = "GO"
        '
        'pcbFive
        '
        Me.pcbFive.Location = New System.Drawing.Point(418, 385)
        Me.pcbFive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbFive.Name = "pcbFive"
        Me.pcbFive.Size = New System.Drawing.Size(50, 43)
        Me.pcbFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFive.TabIndex = 34
        Me.pcbFive.TabStop = False
        '
        'pcbFour
        '
        Me.pcbFour.Location = New System.Drawing.Point(418, 312)
        Me.pcbFour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbFour.Name = "pcbFour"
        Me.pcbFour.Size = New System.Drawing.Size(50, 43)
        Me.pcbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFour.TabIndex = 33
        Me.pcbFour.TabStop = False
        '
        'pcbThree
        '
        Me.pcbThree.Location = New System.Drawing.Point(418, 240)
        Me.pcbThree.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbThree.Name = "pcbThree"
        Me.pcbThree.Size = New System.Drawing.Size(50, 43)
        Me.pcbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbThree.TabIndex = 32
        Me.pcbThree.TabStop = False
        '
        'pcbTwo
        '
        Me.pcbTwo.Location = New System.Drawing.Point(418, 177)
        Me.pcbTwo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbTwo.Name = "pcbTwo"
        Me.pcbTwo.Size = New System.Drawing.Size(50, 43)
        Me.pcbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTwo.TabIndex = 31
        Me.pcbTwo.TabStop = False
        '
        'pcbOne
        '
        Me.pcbOne.Location = New System.Drawing.Point(418, 112)
        Me.pcbOne.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbOne.Name = "pcbOne"
        Me.pcbOne.Size = New System.Drawing.Size(50, 43)
        Me.pcbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbOne.TabIndex = 30
        Me.pcbOne.TabStop = False
        '
        'pcbMinus
        '
        Me.pcbMinus.BackColor = System.Drawing.Color.White
        Me.pcbMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbMinus.Image = Global.Final_Project.My.Resources.Resources.minus22
        Me.pcbMinus.Location = New System.Drawing.Point(418, -1)
        Me.pcbMinus.Name = "pcbMinus"
        Me.pcbMinus.Size = New System.Drawing.Size(76, 85)
        Me.pcbMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMinus.TabIndex = 35
        Me.pcbMinus.TabStop = False
        '
        'TimerBounce
        '
        Me.TimerBounce.Interval = 50
        '
        'frmLvl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 537)
        Me.Controls.Add(Me.pcbFive)
        Me.Controls.Add(Me.pcbFour)
        Me.Controls.Add(Me.pcbThree)
        Me.Controls.Add(Me.pcbTwo)
        Me.Controls.Add(Me.pcbOne)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNextLvl)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.txtFour)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.lblMinusFive)
        Me.Controls.Add(Me.lblMinusFour)
        Me.Controls.Add(Me.lblMinusThree)
        Me.Controls.Add(Me.lblMinusTwo)
        Me.Controls.Add(Me.lblMinusOne)
        Me.Controls.Add(Me.lblTen)
        Me.Controls.Add(Me.lblNine)
        Me.Controls.Add(Me.lblEight)
        Me.Controls.Add(Me.lblSeven)
        Me.Controls.Add(Me.lblSix)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pcbMinus)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLvl2"
        Me.Text = "Level 2"
        CType(Me.pcbFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMinus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblThree As Label
    Friend WithEvents lblFour As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents lblSix As Label
    Friend WithEvents lblSeven As Label
    Friend WithEvents lblEight As Label
    Friend WithEvents lblNine As Label
    Friend WithEvents lblTen As Label
    Friend WithEvents lblMinusOne As Label
    Friend WithEvents lblMinusTwo As Label
    Friend WithEvents lblMinusThree As Label
    Friend WithEvents lblMinusFour As Label
    Friend WithEvents lblMinusFive As Label
    Friend WithEvents txtOne As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents txtThree As TextBox
    Friend WithEvents txtFour As TextBox
    Friend WithEvents txtFive As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnNextLvl As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents pcbFive As PictureBox
    Friend WithEvents pcbFour As PictureBox
    Friend WithEvents pcbThree As PictureBox
    Friend WithEvents pcbTwo As PictureBox
    Friend WithEvents pcbOne As PictureBox
    Friend WithEvents pcbMinus As PictureBox
    Friend WithEvents TimerBounce As Timer
End Class
