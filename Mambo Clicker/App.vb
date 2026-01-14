Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class App

    ' =========================================================
    ' Project : Umamusume: Mambo Clicker (Parody Fan Project)
    ' Author  : HungNQ2005
    '
    ' Disclaimer:
    ' This is a fan-made parody project created for fun and
    ' educational purposes only. All original characters,
    ' visual styles, and intellectual property referenced or
    ' inspired by Umamusume: Pretty Derby are the property of
    ' Cygames, Inc.
    '
    ' Non-commercial use only.
    ' =========================================================


    ' ========================
    ' GAME DATA
    ' ========================
    Private score As Integer = 0
    Private mamboSound As SoundPlayer
    Private lastClick As DateTime

    ' ========================
    ' POP EFFECT DATA
    ' ========================
    Private originalSize As Size
    Private originalLocation As Point
    Private popTimer As Timer
    Private isPopped As Boolean = False

    ' ========================
    ' FORM LOAD.
    ' == ======================
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        lblGoal.BorderStyle = BorderStyle.None
        Stat1.BorderStyle = BorderStyle.None
        Stat2.BorderStyle = BorderStyle.None
        Stat3.BorderStyle = BorderStyle.None
        Stat4.BorderStyle = BorderStyle.None
        Stat5.BorderStyle = BorderStyle.None
        Stat6.BorderStyle = BorderStyle.None
        lblTurn.BorderStyle = BorderStyle.None


        ' PictureBox setup
        Mambo.SizeMode = PictureBoxSizeMode.Zoom
        layout.SizeMode = PictureBoxSizeMode.Zoom
        layout.Parent = Mambo
        layout.BackColor = Color.Transparent
        layout.Location = New Point(20, 10)
        layout.BringToFront()




        ' Score
        lblGoal.Text = "Goal: Touch Mambo"
        lblGoal.Text = "1"
        Stat1.Text = "0"
        Stat2.Text = "0"
        Stat3.Text = "0"
        Stat4.Text = "0"
        Stat5.Text = "0"

        ' Save original size & position
        originalSize = Mambo.Size
        originalLocation = Mambo.Location

        ' Init pop timer
        popTimer = New Timer()
        popTimer.Interval = 80 ' ms
        AddHandler popTimer.Tick, AddressOf PopBack

        ' Init sound 
        Dim soundPath As String =
            IO.Path.Combine(Application.StartupPath, "SRC\Mambo.wav")

        If Not IO.File.Exists(soundPath) Then
            MessageBox.Show("Không tìm thấy file:" & vbCrLf & soundPath,
                            "Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        mamboSound = New SoundPlayer(soundPath)
        mamboSound.Load()

    End Sub

    ' ========================
    ' CLICK MAMBO
    ' ========================
    Private Sub Mambo_Click(sender As Object, e As EventArgs) Handles Mambo.Click
        DoMambo()
    End Sub

    ' ========================
    ' POP EFFECT METHODS
    ' ========================
    Private Sub PopMambo()

        If isPopped Then Exit Sub
        isPopped = True

        Dim scale As Double = 1.15 ' pop size

        Dim newW As Integer = CInt(originalSize.Width * scale)
        Dim newH As Integer = CInt(originalSize.Height * scale)

        ' Keep center
        Mambo.Size = New Size(newW, newH)
        Mambo.Location = New Point(
            originalLocation.X - (newW - originalSize.Width) \ 2,
            originalLocation.Y - (newH - originalSize.Height) \ 2
        )

        popTimer.Start()

    End Sub

    Private Sub PopBack(sender As Object, e As EventArgs)
        popTimer.Stop()

        Mambo.Size = originalSize
        Mambo.Location = originalLocation

        isPopped = False
    End Sub

    Private Sub credit1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles credit1.LinkClicked
        Dim url As String = "https://github.com/HungNQ2005/Umamusume-Mambo-Clicker"

        Try
            Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Cannot open link.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub layout_Click(sender As Object, e As EventArgs) Handles layout.Click
        DoMambo()
    End Sub


    Sub DoMambo()
        ' Anti spam click
        If (DateTime.Now - lastClick).TotalMilliseconds < 200 Then Exit Sub
        lastClick = DateTime.Now

        ' POP EFFECT
        PopMambo()

        ' Play sound
        mamboSound.Stop()
        mamboSound.Play()

        ' You will never reach the goal hahaha
        score += 1
        lblGoal.Text = "Reach " & 1 + score.ToString() & " in every stats."
        Stat1.Text = score.ToString()
        Stat2.Text = score.ToString()
        Stat3.Text = score.ToString()
        Stat4.Text = score.ToString()
        Stat5.Text = score.ToString()
        Stat6.Text = score.ToString()
        lblTurn.Text = 2 + score.ToString()
    End Sub
End Class
