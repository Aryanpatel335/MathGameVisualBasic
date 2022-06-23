<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsturctions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsturctions))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pcbFour = New System.Windows.Forms.PictureBox()
        Me.pcbThree = New System.Windows.Forms.PictureBox()
        Me.pcbTwo = New System.Windows.Forms.PictureBox()
        Me.pcbOne = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 126)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(498, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(51, 29)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pcbFour
        '
        Me.pcbFour.BackColor = System.Drawing.Color.Transparent
        Me.pcbFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbFour.Image = CType(resources.GetObject("pcbFour.Image"), System.Drawing.Image)
        Me.pcbFour.Location = New System.Drawing.Point(274, 171)
        Me.pcbFour.Name = "pcbFour"
        Me.pcbFour.Size = New System.Drawing.Size(76, 82)
        Me.pcbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFour.TabIndex = 20
        Me.pcbFour.TabStop = False
        '
        'pcbThree
        '
        Me.pcbThree.BackColor = System.Drawing.Color.White
        Me.pcbThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbThree.Image = Global.Final_Project.My.Resources.Resources.minus22
        Me.pcbThree.Location = New System.Drawing.Point(375, 266)
        Me.pcbThree.Name = "pcbThree"
        Me.pcbThree.Size = New System.Drawing.Size(89, 96)
        Me.pcbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbThree.TabIndex = 19
        Me.pcbThree.TabStop = False
        '
        'pcbTwo
        '
        Me.pcbTwo.BackColor = System.Drawing.Color.White
        Me.pcbTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbTwo.Image = Global.Final_Project.My.Resources.Resources.mulitply
        Me.pcbTwo.Location = New System.Drawing.Point(144, 288)
        Me.pcbTwo.Name = "pcbTwo"
        Me.pcbTwo.Size = New System.Drawing.Size(86, 74)
        Me.pcbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTwo.TabIndex = 18
        Me.pcbTwo.TabStop = False
        '
        'pcbOne
        '
        Me.pcbOne.BackColor = System.Drawing.Color.White
        Me.pcbOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbOne.Image = Global.Final_Project.My.Resources.Resources.plus_red
        Me.pcbOne.Location = New System.Drawing.Point(16, 211)
        Me.pcbOne.Name = "pcbOne"
        Me.pcbOne.Size = New System.Drawing.Size(89, 64)
        Me.pcbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbOne.TabIndex = 17
        Me.pcbOne.TabStop = False
        '
        'frmInsturctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 395)
        Me.Controls.Add(Me.pcbFour)
        Me.Controls.Add(Me.pcbThree)
        Me.Controls.Add(Me.pcbTwo)
        Me.Controls.Add(Me.pcbOne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInsturctions"
        Me.Text = "Instructions"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pcbFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents pcbFour As PictureBox
    Friend WithEvents pcbThree As PictureBox
    Friend WithEvents pcbTwo As PictureBox
    Friend WithEvents pcbOne As PictureBox
End Class
