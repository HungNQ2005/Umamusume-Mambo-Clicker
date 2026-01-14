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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.credit1 = New System.Windows.Forms.LinkLabel()
        CType(Me.Mambo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(611, 55)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(39, 13)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "Label1"
        '
        'credit1
        '
        Me.credit1.AutoSize = True
        Me.credit1.BackColor = System.Drawing.SystemColors.Window
        Me.credit1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credit1.Location = New System.Drawing.Point(454, 459)
        Me.credit1.Name = "credit1"
        Me.credit1.Size = New System.Drawing.Size(226, 14)
        Me.credit1.TabIndex = 3
        Me.credit1.TabStop = True
        Me.credit1.Text = "Fan-made parody game by HungNQ2005, "
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(886, 501)
        Me.Controls.Add(Me.credit1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Mambo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "App"
        Me.Text = "Umamusume: Mambo Clicker"
        CType(Me.Mambo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mambo As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents credit1 As LinkLabel
End Class
