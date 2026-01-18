Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports WMPLib


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
    ' Patch 1.1.0

    ' ========================
    ' GAME DATA
    ' ========================
    Private score As Integer = 0
    Private mamboSound As SoundPlayer
    Private mamboExit As SoundPlayer
    Private lastClick As DateTime
    Private bgmPlayer As WindowsMediaPlayer
    Private mamboSounds As List(Of SoundPlayer)
    Private rnd As New Random()


    ' ========================
    ' POP EFFECT DATA
    ' ========================
    Private originalSize As Size
    Private originalLocation As Point
    Private popTimer As Timer
    Private isPopped As Boolean = False
    Private layoutOriginalSize As Size
    Private layoutOriginalLocation As Point
    Private statBoxes As RichTextBox()


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


        ' PictureBox setup done
        Mambo.SizeMode = PictureBoxSizeMode.Zoom
        layout.SizeMode = PictureBoxSizeMode.Zoom
        layout.Parent = Mambo
        layout.BackColor = Color.Transparent
        layout.Location = New Point(20, 10)
        layout.BringToFront()

        layoutOriginalSize = layout.Size
        layoutOriginalLocation = layout.Location

        ' Score
        lblGoal.Text = "Goal: Touch Mambo"
        lblTurn.Text = "1"
        Stat1.Text = "0"
        Stat2.Text = "0"
        Stat3.Text = "0"
        Stat4.Text = "0"
        Stat5.Text = "0"

        statBoxes = {Stat1, Stat2, Stat3, Stat4, Stat5, Stat6, lblGoal, lblTurn}

        ' Save original size & position
        originalSize = Mambo.Size
        originalLocation = Mambo.Location

        ' Init pop timer
        popTimer = New Timer()
        popTimer.Interval = 80 ' ms
        AddHandler popTimer.Tick, AddressOf PopBack

        ' Init sound 
        bgmPlayer = New WindowsMediaPlayer()
        bgmPlayer.URL = IO.Path.Combine(Application.StartupPath, "SRC\videoplayback.mp3")
        bgmPlayer.settings.setMode("loop", True)
        bgmPlayer.settings.volume = 40
        bgmPlayer.controls.play()

        mamboSounds = New List(Of SoundPlayer)

        Dim mamboFiles = {
                "SRC\Mambo1.wav",
                "SRC\Mambo1.wav",
                "SRC\Mambo1.wav",
                "SRC\Mambo2.wav",
                "SRC\Mambo3.wav",
                "SRC\Mambo4.wav"
                }

        For Each file In mamboFiles
            Dim path = IO.Path.Combine(Application.StartupPath, file)

            If IO.File.Exists(path) Then
                Dim sp As New SoundPlayer(path)
                sp.Load()
                mamboSounds.Add(sp)
            End If
        Next



        Dim soundPathExit As String =
            IO.Path.Combine(Application.StartupPath, "SRC\MamboUh.wav")







        mamboExit = New SoundPlayer(soundPathExit)
        mamboExit.Load()
        For Each tb In statBoxes
            tb.ReadOnly = True
            tb.TabStop = False

        Next
        Me.ActiveControl = Nothing

        btn15.BackColor = Color.Transparent
        btn15.ForeColor = Color.Transparent
        btn15.Text = ""
        btn15.BringToFront()


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
        For Each tb In statBoxes
            tb.Visible = False
        Next

        Dim scale As Double = 1.07 ' pop size

        Dim newW As Integer = CInt(originalSize.Width * scale)
        Dim newH As Integer = CInt(originalSize.Height * scale)

        ' Keep center
        Mambo.Size = New Size(newW, newH)
        Mambo.Location = New Point(
            originalLocation.X - (newW - originalSize.Width) \ 2,
            originalLocation.Y - (newH - originalSize.Height) \ 2
        )

        popTimer.Start()


        Dim invScale As Double = 1 / scale

        layout.Size = New Size(
            CInt(layoutOriginalSize.Width * invScale),
            CInt(layoutOriginalSize.Height * invScale)
        )


        layout.Location = New Point(
        layoutOriginalLocation.X + (layoutOriginalSize.Width - layout.Width) \ 2,
        layoutOriginalLocation.Y + (layoutOriginalSize.Height - layout.Height) \ 2
        )

    End Sub

    Private Sub PopBack(sender As Object, e As EventArgs)
        popTimer.Stop()

        Mambo.Size = originalSize
        Mambo.Location = originalLocation
        layout.Size = layoutOriginalSize
        layout.Location = layoutOriginalLocation
        For Each tb In statBoxes
            tb.Visible = True
        Next
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
        'mamboSound.Stop()
        'mamboSound.Play()
        If mamboSounds.Count > 0 Then
            Dim index = rnd.Next(mamboSounds.Count)
            mamboSounds(index).Stop()
            mamboSounds(index).Play()
            Debug.WriteLine("Sound index = " & index)
            Debug.WriteLine("Total sounds = " & mamboSounds.Count)

        End If

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

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        mamboExit.Stop()
        mamboExit.Play()
    End Sub
End Class
