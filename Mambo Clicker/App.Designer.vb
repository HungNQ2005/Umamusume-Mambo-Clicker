<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.Mambo = New System.Windows.Forms.PictureBox()
        Me.credit1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.layout = New System.Windows.Forms.PictureBox()
        Me.lblGoal = New System.Windows.Forms.RichTextBox()
        Me.Stat1 = New System.Windows.Forms.RichTextBox()
        Me.Stat2 = New System.Windows.Forms.RichTextBox()
        Me.Stat3 = New System.Windows.Forms.RichTextBox()
        Me.Stat4 = New System.Windows.Forms.RichTextBox()
        Me.Stat5 = New System.Windows.Forms.RichTextBox()
        Me.Stat6 = New System.Windows.Forms.RichTextBox()
        Me.lblTurn = New System.Windows.Forms.RichTextBox()
        CType(Me.Mambo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mambo
        '
        Me.Mambo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mambo.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Mambo.Image = CType(resources.GetObject("Mambo.Image"), System.Drawing.Image)
        Me.Mambo.Location = New System.Drawing.Point(59, -6)
        Me.Mambo.Name = "Mambo"
        Me.Mambo.Size = New System.Drawing.Size(389, 513)
        Me.Mambo.TabIndex = 0
        Me.Mambo.TabStop = False
        Me.Mambo.UseWaitCursor = True
        Me.Mambo.WaitOnLoad = True
        '
        'credit1
        '
        Me.credit1.ActiveLinkColor = System.Drawing.Color.Peru
        Me.credit1.AutoSize = True
        Me.credit1.BackColor = System.Drawing.Color.Transparent
        Me.credit1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credit1.Location = New System.Drawing.Point(454, 459)
        Me.credit1.Name = "credit1"
        Me.credit1.Size = New System.Drawing.Size(315, 14)
        Me.credit1.TabIndex = 3
        Me.credit1.TabStop = True
        Me.credit1.Text = "Fan-made parody game by HungNQ2005 (non-commercial)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(457, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "All original rights belong to Cygames"
        '
        'layout
        '
        Me.layout.BackColor = System.Drawing.Color.Transparent
        Me.layout.BackgroundImage = CType(resources.GetObject("layout.BackgroundImage"), System.Drawing.Image)
        Me.layout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.layout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.layout.Location = New System.Drawing.Point(59, 12)
        Me.layout.Name = "layout"
        Me.layout.Size = New System.Drawing.Size(355, 495)
        Me.layout.TabIndex = 5
        Me.layout.TabStop = False
        '
        'lblGoal
        '
        Me.lblGoal.Cursor = System.Windows.Forms.Cursors.No
        Me.lblGoal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.ForeColor = System.Drawing.Color.Gold
        Me.lblGoal.Location = New System.Drawing.Point(220, 38)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.lblGoal.Size = New System.Drawing.Size(124, 16)
        Me.lblGoal.TabIndex = 6
        Me.lblGoal.Text = ""
        '
        'Stat1
        '
        Me.Stat1.Cursor = System.Windows.Forms.Cursors.No
        Me.Stat1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat1.ForeColor = System.Drawing.Color.Gold
        Me.Stat1.Location = New System.Drawing.Point(140, 338)
        Me.Stat1.Name = "Stat1"
        Me.Stat1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Stat1.Size = New System.Drawing.Size(23, 15)
        Me.Stat1.TabIndex = 7
        Me.Stat1.Text = ""
        '
        'Stat2
        '
        Me.Stat2.Cursor = System.Windows.Forms.Cursors.No
        Me.Stat2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat2.ForeColor = System.Drawing.Color.Gold
        Me.Stat2.Location = New System.Drawing.Point(180, 338)
        Me.Stat2.Name = "Stat2"
        Me.Stat2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Stat2.Size = New System.Drawing.Size(23, 15)
        Me.Stat2.TabIndex = 8
        Me.Stat2.Text = ""
        '
        'Stat3
        '
        Me.Stat3.Cursor = System.Windows.Forms.Cursors.No
        Me.Stat3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat3.ForeColor = System.Drawing.Color.Gold
        Me.Stat3.Location = New System.Drawing.Point(220, 338)
        Me.Stat3.Name = "Stat3"
        Me.Stat3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Stat3.Size = New System.Drawing.Size(23, 15)
        Me.Stat3.TabIndex = 9
        Me.Stat3.Text = ""
        '
        'Stat4
        '
        Me.Stat4.Cursor = System.Windows.Forms.Cursors.No
        Me.Stat4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat4.ForeColor = System.Drawing.Color.Gold
        Me.Stat4.Location = New System.Drawing.Point(264, 338)
        Me.Stat4.Name = "Stat4"
        Me.Stat4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Stat4.Size = New System.Drawing.Size(23, 15)
        Me.Stat4.TabIndex = 10
        Me.Stat4.Text = ""
        '
        'Stat5
        '
        Me.Stat5.Cursor = System.Windows.Forms.Cursors.No
        Me.Stat5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat5.ForeColor = System.Drawing.Color.Gold
        Me.Stat5.Location = New System.Drawing.Point(307, 338)
        Me.Stat5.Name = "Stat5"
        Me.Stat5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Stat5.Size = New System.Drawing.Size(23, 15)
        Me.Stat5.TabIndex = 11
        Me.Stat5.Text = ""
        '
        'Stat6
        '
        Me.Stat6.Cursor = System.Windows.Forms.Cursors.No
        Me.Stat6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat6.ForeColor = System.Drawing.Color.Black
        Me.Stat6.Location = New System.Drawing.Point(352, 338)
        Me.Stat6.Name = "Stat6"
        Me.Stat6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Stat6.Size = New System.Drawing.Size(23, 15)
        Me.Stat6.TabIndex = 12
        Me.Stat6.Text = ""
        '
        'lblTurn
        '
        Me.lblTurn.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTurn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.ForeColor = System.Drawing.Color.Gold
        Me.lblTurn.Location = New System.Drawing.Point(140, 47)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTurn.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.lblTurn.Size = New System.Drawing.Size(36, 18)
        Me.lblTurn.TabIndex = 13
        Me.lblTurn.Text = ""
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(886, 501)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.Stat6)
        Me.Controls.Add(Me.Stat5)
        Me.Controls.Add(Me.Stat4)
        Me.Controls.Add(Me.Stat3)
        Me.Controls.Add(Me.Stat2)
        Me.Controls.Add(Me.Stat1)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.layout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.credit1)
        Me.Controls.Add(Me.Mambo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "App"
        Me.Text = "Umamusume: Mambo Clicker"
        CType(Me.Mambo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mambo As PictureBox
    Friend WithEvents credit1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents layout As PictureBox
    Friend WithEvents lblGoal As RichTextBox
    Friend WithEvents Stat1 As RichTextBox
    Friend WithEvents Stat2 As RichTextBox
    Friend WithEvents Stat3 As RichTextBox
    Friend WithEvents Stat4 As RichTextBox
    Friend WithEvents Stat5 As RichTextBox
    Friend WithEvents Stat6 As RichTextBox
    Friend WithEvents lblTurn As RichTextBox
End Class
