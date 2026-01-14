Imports System.Media

Public Class App

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
    ' ========================
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size

        ' PictureBox setup
        Mambo.SizeMode = PictureBoxSizeMode.Zoom

        ' Score
        lblScore.Text = "Score: 0"

        ' Save original size & position
        originalSize = Mambo.Size
        originalLocation = Mambo.Location

        ' Init pop timer
        popTimer = New Timer()
        popTimer.Interval = 80 ' ms
        AddHandler popTimer.Tick, AddressOf PopBack

        ' Init sound (SAFE PATH)
        Dim soundPath As String =
            IO.Path.Combine(Application.StartupPath, "Sources\Mambo.wav")

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

        ' Anti spam click
        If (DateTime.Now - lastClick).TotalMilliseconds < 200 Then Exit Sub
        lastClick = DateTime.Now

        ' POP EFFECT
        PopMambo()

        ' Play sound
        mamboSound.Stop()
        mamboSound.Play()

        ' +1 score
        score += 1
        lblScore.Text = "Score: " & score.ToString()

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
        Dim url As String = "https://github.com/HungNQ2005/ten-repo-cua-ban"

        Try
            Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Cannot open link.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
