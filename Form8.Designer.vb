<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLvl4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLvl4))
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.lblDivideFive = New System.Windows.Forms.Label()
        Me.lblDivideFour = New System.Windows.Forms.Label()
        Me.lblDivideThree = New System.Windows.Forms.Label()
        Me.lblDivideTwo = New System.Windows.Forms.Label()
        Me.lblDivideOne = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.lblNine = New System.Windows.Forms.Label()
        Me.lblEight = New System.Windows.Forms.Label()
        Me.lblSeven = New System.Windows.Forms.Label()
        Me.lblSix = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.pcbFive = New System.Windows.Forms.PictureBox()
        Me.pcbFour = New System.Windows.Forms.PictureBox()
        Me.pcbThree = New System.Windows.Forms.PictureBox()
        Me.pcbTwo = New System.Windows.Forms.PictureBox()
        Me.pcbOne = New System.Windows.Forms.PictureBox()
        Me.pcbDivide = New System.Windows.Forms.PictureBox()
        Me.TimerBounce = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbDivide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(280, 495)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(82, 38)
        Me.btnCheck.TabIndex = 47
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(69, 495)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 38)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(296, 415)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(66, 26)
        Me.txtFive.TabIndex = 45
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(296, 343)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.Size = New System.Drawing.Size(66, 26)
        Me.txtFour.TabIndex = 44
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(296, 262)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(66, 26)
        Me.txtThree.TabIndex = 43
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(296, 175)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(66, 26)
        Me.txtTwo.TabIndex = 42
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(296, 95)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(66, 26)
        Me.txtOne.TabIndex = 41
        '
        'lblDivideFive
        '
        Me.lblDivideFive.AutoSize = True
        Me.lblDivideFive.Location = New System.Drawing.Point(134, 422)
        Me.lblDivideFive.Name = "lblDivideFive"
        Me.lblDivideFive.Size = New System.Drawing.Size(13, 20)
        Me.lblDivideFive.TabIndex = 40
        Me.lblDivideFive.Text = "/"
        '
        'lblDivideFour
        '
        Me.lblDivideFour.AutoSize = True
        Me.lblDivideFour.Location = New System.Drawing.Point(134, 349)
        Me.lblDivideFour.Name = "lblDivideFour"
        Me.lblDivideFour.Size = New System.Drawing.Size(13, 20)
        Me.lblDivideFour.TabIndex = 39
        Me.lblDivideFour.Text = "/"
        '
        'lblDivideThree
        '
        Me.lblDivideThree.AutoSize = True
        Me.lblDivideThree.Location = New System.Drawing.Point(134, 262)
        Me.lblDivideThree.Name = "lblDivideThree"
        Me.lblDivideThree.Size = New System.Drawing.Size(13, 20)
        Me.lblDivideThree.TabIndex = 38
        Me.lblDivideThree.Text = "/"
        '
        'lblDivideTwo
        '
        Me.lblDivideTwo.AutoSize = True
        Me.lblDivideTwo.Location = New System.Drawing.Point(134, 192)
        Me.lblDivideTwo.Name = "lblDivideTwo"
        Me.lblDivideTwo.Size = New System.Drawing.Size(13, 20)
        Me.lblDivideTwo.TabIndex = 37
        Me.lblDivideTwo.Text = "/"
        '
        'lblDivideOne
        '
        Me.lblDivideOne.AutoSize = True
        Me.lblDivideOne.Location = New System.Drawing.Point(134, 101)
        Me.lblDivideOne.Name = "lblDivideOne"
        Me.lblDivideOne.Size = New System.Drawing.Size(13, 20)
        Me.lblDivideOne.TabIndex = 36
        Me.lblDivideOne.Text = "/"
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.Location = New System.Drawing.Point(184, 422)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(66, 20)
        Me.lblTen.TabIndex = 35
        Me.lblTen.Text = "Label10"
        '
        'lblNine
        '
        Me.lblNine.AutoSize = True
        Me.lblNine.Location = New System.Drawing.Point(46, 422)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(57, 20)
        Me.lblNine.TabIndex = 34
        Me.lblNine.Text = "Label9"
        '
        'lblEight
        '
        Me.lblEight.AutoSize = True
        Me.lblEight.Location = New System.Drawing.Point(194, 349)
        Me.lblEight.Name = "lblEight"
        Me.lblEight.Size = New System.Drawing.Size(57, 20)
        Me.lblEight.TabIndex = 33
        Me.lblEight.Text = "Label8"
        '
        'lblSeven
        '
        Me.lblSeven.AutoSize = True
        Me.lblSeven.Location = New System.Drawing.Point(46, 349)
        Me.lblSeven.Name = "lblSeven"
        Me.lblSeven.Size = New System.Drawing.Size(57, 20)
        Me.lblSeven.TabIndex = 32
        Me.lblSeven.Text = "Label7"
        '
        'lblSix
        '
        Me.lblSix.AutoSize = True
        Me.lblSix.Location = New System.Drawing.Point(194, 262)
        Me.lblSix.Name = "lblSix"
        Me.lblSix.Size = New System.Drawing.Size(57, 20)
        Me.lblSix.TabIndex = 31
        Me.lblSix.Text = "Label6"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(46, 262)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(57, 20)
        Me.lblFive.TabIndex = 30
        Me.lblFive.Text = "Label5"
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Location = New System.Drawing.Point(194, 179)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(57, 20)
        Me.lblFour.TabIndex = 29
        Me.lblFour.Text = "Label4"
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Location = New System.Drawing.Point(46, 179)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(57, 20)
        Me.lblThree.TabIndex = 28
        Me.lblThree.Text = "Label3"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(194, 101)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(57, 20)
        Me.lblTwo.TabIndex = 27
        Me.lblTwo.Text = "Label2"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Location = New System.Drawing.Point(46, 101)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(57, 20)
        Me.lblOne.TabIndex = 26
        Me.lblOne.Text = "Label1"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(350, 22)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 25)
        Me.lblScore.TabIndex = 25
        Me.lblScore.Text = "---"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Modern No. 20", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(96, 14)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(101, 58)
        Me.lblTimer.TabIndex = 49
        Me.lblTimer.Text = "GO"
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'pcbFive
        '
        Me.pcbFive.Location = New System.Drawing.Point(410, 399)
        Me.pcbFive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbFive.Name = "pcbFive"
        Me.pcbFive.Size = New System.Drawing.Size(50, 43)
        Me.pcbFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFive.TabIndex = 54
        Me.pcbFive.TabStop = False
        '
        'pcbFour
        '
        Me.pcbFour.Location = New System.Drawing.Point(410, 326)
        Me.pcbFour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbFour.Name = "pcbFour"
        Me.pcbFour.Size = New System.Drawing.Size(50, 43)
        Me.pcbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFour.TabIndex = 53
        Me.pcbFour.TabStop = False
        '
        'pcbThree
        '
        Me.pcbThree.Location = New System.Drawing.Point(410, 262)
        Me.pcbThree.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbThree.Name = "pcbThree"
        Me.pcbThree.Size = New System.Drawing.Size(50, 43)
        Me.pcbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbThree.TabIndex = 52
        Me.pcbThree.TabStop = False
        '
        'pcbTwo
        '
        Me.pcbTwo.Location = New System.Drawing.Point(410, 169)
        Me.pcbTwo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbTwo.Name = "pcbTwo"
        Me.pcbTwo.Size = New System.Drawing.Size(50, 43)
        Me.pcbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTwo.TabIndex = 51
        Me.pcbTwo.TabStop = False
        '
        'pcbOne
        '
        Me.pcbOne.Location = New System.Drawing.Point(410, 95)
        Me.pcbOne.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pcbOne.Name = "pcbOne"
        Me.pcbOne.Size = New System.Drawing.Size(50, 43)
        Me.pcbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbOne.TabIndex = 50
        Me.pcbOne.TabStop = False
        '
        'pcbDivide
        '
        Me.pcbDivide.BackColor = System.Drawing.Color.Transparent
        Me.pcbDivide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbDivide.Image = CType(resources.GetObject("pcbDivide.Image"), System.Drawing.Image)
        Me.pcbDivide.Location = New System.Drawing.Point(-3, 485)
        Me.pcbDivide.Name = "pcbDivide"
        Me.pcbDivide.Size = New System.Drawing.Size(76, 82)
        Me.pcbDivide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbDivide.TabIndex = 55
        Me.pcbDivide.TabStop = False
        '
        'TimerBounce
        '
        Me.TimerBounce.Interval = 50
        '
        'frmLvl4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 568)
        Me.Controls.Add(Me.pcbFive)
        Me.Controls.Add(Me.pcbFour)
        Me.Controls.Add(Me.pcbThree)
        Me.Controls.Add(Me.pcbTwo)
        Me.Controls.Add(Me.pcbOne)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.txtFour)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.lblDivideFive)
        Me.Controls.Add(Me.lblDivideFour)
        Me.Controls.Add(Me.lblDivideThree)
        Me.Controls.Add(Me.lblDivideTwo)
        Me.Controls.Add(Me.lblDivideOne)
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
        Me.Controls.Add(Me.pcbDivide)
        Me.Name = "frmLvl4"
        Me.Text = "Level 4"
        CType(Me.pcbFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbDivide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFive As TextBox
    Friend WithEvents txtFour As TextBox
    Friend WithEvents txtThree As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents txtOne As TextBox
    Friend WithEvents lblDivideFive As Label
    Friend WithEvents lblDivideFour As Label
    Friend WithEvents lblDivideThree As Label
    Friend WithEvents lblDivideTwo As Label
    Friend WithEvents lblDivideOne As Label
    Friend WithEvents lblTen As Label
    Friend WithEvents lblNine As Label
    Friend WithEvents lblEight As Label
    Friend WithEvents lblSeven As Label
    Friend WithEvents lblSix As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents lblFour As Label
    Friend WithEvents lblThree As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer5 As Timer
    Friend WithEvents pcbFive As PictureBox
    Friend WithEvents pcbFour As PictureBox
    Friend WithEvents pcbThree As PictureBox
    Friend WithEvents pcbTwo As PictureBox
    Friend WithEvents pcbOne As PictureBox
    Friend WithEvents pcbDivide As PictureBox
    Friend WithEvents TimerBounce As Timer
End Class
