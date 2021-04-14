Imports System

Public Class frmZeiterfassung
    Public Property Millisekunden As Byte
    Public Property Minuten As Byte
    Public Property Sekunden As Byte
    Public Property Stunden As Byte
    'Pause
    Public Property MillisekundenPause As Byte
    Public Property MinutenPause As Byte
    Public Property SekundenPause As Byte
    Public Property StundenPause As Byte
    'Kontrolle ob Timer an/aus
    Dim AktiverTimer As Boolean
    'Kontrolle ob Fenster transprent
    Dim Transparent As Boolean = False

    Private Sub StarteArbeitszeit(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        AktiverTimer = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Millisekunden = Millisekunden + 1

        'jede Sekunde +1 auf dem Ladebalken
        If Millisekunden = 10 Then
            ProgressBar1.Increment(1)
            Console.WriteLine("1 sek ist vergangen.")
        End If
        ' wenn 8h auf TIMER1 geschafft sind, dann fertig und Meldung
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MsgBox("8h geschafft!")
        End If

        If Millisekunden = 10 Then
            Sekunden = Sekunden + 1
            Millisekunden = 0
        End If
        If Sekunden = 60 Then
            Minuten = Minuten + 1
            Sekunden = 0
        End If
        If Minuten = 60 Then
            Stunden = Stunden + 1
            Minuten = 0
        End If
        Me.lblMinuten.Text = Minuten
        Me.lblSekunden.Text = Sekunden
        Me.lblStunden.Text = Stunden

        'jede Sekunde +1 auf dem Ladebalken
        If Millisekunden = 10 Then
            ProgressBar1.Increment(1)
            Console.WriteLine("1 sek ist vergangen.")
        End If
        ' wenn 8h auf TIMER1 geschafft sind, dann fertig und Meldung
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MsgBox("8h geschafft!")
        End If
    End Sub

    Private Sub Pause(sender As Object, e As EventArgs) Handles Button3.Click
        'Pausenzeit erscheinen lassen
        Me.lblPauseMinuten.Visible = True
        Me.lblPauseSekunden.Visible = True
        Me.lblPauseStunden.Visible = True
        Me.lbltrennungPause.Visible = True
        Me.lblTrennungPause2.Visible = True

        Select Case AktiverTimer
            Case True
                Timer1.Stop()
                Timer2.Start()
                Me.lblStatus.Text = "PAUSE!"
                Me.Button3.BackColor = Color.Yellow
                Me.Button3.Text = "Weiter"

                AktiverTimer = False
            Case False
                Timer1.Start()
                Timer2.Stop()
                Me.lblStatus.Text = "Weiter gehts..."
                Me.Button3.BackColor = Color.CornflowerBlue
                Me.Button3.Text = "Pause"

                AktiverTimer = True
        End Select

    End Sub
    'PausenTimer startet
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MillisekundenPause = MillisekundenPause + 1
        If MillisekundenPause = 10 Then
            SekundenPause = SekundenPause + 1
            MillisekundenPause = 0
        End If
        If SekundenPause = 60 Then
            MinutenPause = MinutenPause + 1
            SekundenPause = 0
        End If
        If MinutenPause = 60 Then
            StundenPause = StundenPause + 1
            MinutenPause = 0
        End If
        Me.lblPauseMinuten.Text = MinutenPause
        Me.lblPauseSekunden.Text = SekundenPause
        Me.lblPauseStunden.Text = StundenPause
    End Sub


    Private Sub btnBeendeArbeitstag_Click(sender As Object, e As EventArgs) Handles btnBeendeArbeitstag.Click
        Timer1.Stop()
        Timer2.Stop()
        MsgBox("Sie haben " & Stunden & " Stunden und " & Minuten & " Minuten gearbeitet. Pause davon waren " & StundenPause &
               " Stunden und " & MinutenPause & " Minuten!")
        Console.WriteLine(Stunden & " : " & Minuten & " : " & Sekunden & " ARBEIT")
        Console.WriteLine(StundenPause & " : " & MinutenPause & " : " & SekundenPause & " PAUSE")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmZeiterfassung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
