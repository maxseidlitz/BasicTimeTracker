<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmZeiterfassung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblTrennung2 As System.Windows.Forms.Label
        Dim lblTrennung As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZeiterfassung))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStunden = New System.Windows.Forms.Label()
        Me.lblMinuten = New System.Windows.Forms.Label()
        Me.lblSekunden = New System.Windows.Forms.Label()
        Me.lblPauseSekunden = New System.Windows.Forms.Label()
        Me.lblPauseMinuten = New System.Windows.Forms.Label()
        Me.lblPauseStunden = New System.Windows.Forms.Label()
        Me.lbltrennungPause = New System.Windows.Forms.Label()
        Me.lblTrennungPause2 = New System.Windows.Forms.Label()
        Me.btnBeendeArbeitstag = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        lblTrennung2 = New System.Windows.Forms.Label()
        lblTrennung = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTrennung2
        '
        lblTrennung2.AutoSize = True
        lblTrennung2.BackColor = System.Drawing.Color.Transparent
        lblTrennung2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTrennung2.Location = New System.Drawing.Point(338, 81)
        lblTrennung2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblTrennung2.Name = "lblTrennung2"
        lblTrennung2.Size = New System.Drawing.Size(13, 20)
        lblTrennung2.TabIndex = 9
        lblTrennung2.Text = ":"
        '
        'lblTrennung
        '
        lblTrennung.AutoSize = True
        lblTrennung.BackColor = System.Drawing.Color.Transparent
        lblTrennung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTrennung.Location = New System.Drawing.Point(258, 81)
        lblTrennung.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblTrennung.Name = "lblTrennung"
        lblTrennung.Size = New System.Drawing.Size(13, 20)
        lblTrennung.TabIndex = 8
        lblTrennung.Text = ":"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(31, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Starte Arbeitszeit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(31, 50)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 61)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Pause"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.HotPink
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ProgressBar1.Location = New System.Drawing.Point(31, 158)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Maximum = 28800
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(382, 18)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 4
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'lblStunden
        '
        Me.lblStunden.AutoSize = True
        Me.lblStunden.BackColor = System.Drawing.Color.Transparent
        Me.lblStunden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblStunden.Location = New System.Drawing.Point(219, 81)
        Me.lblStunden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStunden.Name = "lblStunden"
        Me.lblStunden.Size = New System.Drawing.Size(27, 20)
        Me.lblStunden.TabIndex = 5
        Me.lblStunden.Text = "00"
        '
        'lblMinuten
        '
        Me.lblMinuten.AutoSize = True
        Me.lblMinuten.BackColor = System.Drawing.Color.Transparent
        Me.lblMinuten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblMinuten.Location = New System.Drawing.Point(295, 81)
        Me.lblMinuten.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMinuten.Name = "lblMinuten"
        Me.lblMinuten.Size = New System.Drawing.Size(27, 20)
        Me.lblMinuten.TabIndex = 6
        Me.lblMinuten.Text = "00"
        '
        'lblSekunden
        '
        Me.lblSekunden.AutoSize = True
        Me.lblSekunden.BackColor = System.Drawing.Color.Transparent
        Me.lblSekunden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSekunden.Location = New System.Drawing.Point(373, 81)
        Me.lblSekunden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSekunden.Name = "lblSekunden"
        Me.lblSekunden.Size = New System.Drawing.Size(27, 20)
        Me.lblSekunden.TabIndex = 7
        Me.lblSekunden.Text = "00"
        '
        'lblPauseSekunden
        '
        Me.lblPauseSekunden.AutoSize = True
        Me.lblPauseSekunden.BackColor = System.Drawing.Color.Transparent
        Me.lblPauseSekunden.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblPauseSekunden.ForeColor = System.Drawing.Color.Maroon
        Me.lblPauseSekunden.Location = New System.Drawing.Point(298, 115)
        Me.lblPauseSekunden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPauseSekunden.Name = "lblPauseSekunden"
        Me.lblPauseSekunden.Size = New System.Drawing.Size(19, 13)
        Me.lblPauseSekunden.TabIndex = 12
        Me.lblPauseSekunden.Text = "00"
        Me.lblPauseSekunden.Visible = False
        '
        'lblPauseMinuten
        '
        Me.lblPauseMinuten.AutoSize = True
        Me.lblPauseMinuten.BackColor = System.Drawing.Color.Transparent
        Me.lblPauseMinuten.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblPauseMinuten.ForeColor = System.Drawing.Color.Maroon
        Me.lblPauseMinuten.Location = New System.Drawing.Point(260, 115)
        Me.lblPauseMinuten.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPauseMinuten.Name = "lblPauseMinuten"
        Me.lblPauseMinuten.Size = New System.Drawing.Size(19, 13)
        Me.lblPauseMinuten.TabIndex = 11
        Me.lblPauseMinuten.Text = "00"
        Me.lblPauseMinuten.Visible = False
        '
        'lblPauseStunden
        '
        Me.lblPauseStunden.AutoSize = True
        Me.lblPauseStunden.BackColor = System.Drawing.Color.Transparent
        Me.lblPauseStunden.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblPauseStunden.ForeColor = System.Drawing.Color.Maroon
        Me.lblPauseStunden.Location = New System.Drawing.Point(221, 115)
        Me.lblPauseStunden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPauseStunden.Name = "lblPauseStunden"
        Me.lblPauseStunden.Size = New System.Drawing.Size(19, 13)
        Me.lblPauseStunden.TabIndex = 10
        Me.lblPauseStunden.Text = "00"
        Me.lblPauseStunden.Visible = False
        '
        'lbltrennungPause
        '
        Me.lbltrennungPause.AutoSize = True
        Me.lbltrennungPause.BackColor = System.Drawing.Color.Transparent
        Me.lbltrennungPause.Location = New System.Drawing.Point(245, 115)
        Me.lbltrennungPause.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltrennungPause.Name = "lbltrennungPause"
        Me.lbltrennungPause.Size = New System.Drawing.Size(10, 13)
        Me.lbltrennungPause.TabIndex = 13
        Me.lbltrennungPause.Text = ":"
        Me.lbltrennungPause.Visible = False
        '
        'lblTrennungPause2
        '
        Me.lblTrennungPause2.AutoSize = True
        Me.lblTrennungPause2.BackColor = System.Drawing.Color.Transparent
        Me.lblTrennungPause2.Location = New System.Drawing.Point(284, 115)
        Me.lblTrennungPause2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTrennungPause2.Name = "lblTrennungPause2"
        Me.lblTrennungPause2.Size = New System.Drawing.Size(10, 13)
        Me.lblTrennungPause2.TabIndex = 14
        Me.lblTrennungPause2.Text = ":"
        Me.lblTrennungPause2.Visible = False
        '
        'btnBeendeArbeitstag
        '
        Me.btnBeendeArbeitstag.BackColor = System.Drawing.Color.LightCoral
        Me.btnBeendeArbeitstag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeendeArbeitstag.FlatAppearance.BorderSize = 0
        Me.btnBeendeArbeitstag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBeendeArbeitstag.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeendeArbeitstag.Location = New System.Drawing.Point(31, 115)
        Me.btnBeendeArbeitstag.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBeendeArbeitstag.Name = "btnBeendeArbeitstag"
        Me.btnBeendeArbeitstag.Size = New System.Drawing.Size(140, 27)
        Me.btnBeendeArbeitstag.TabIndex = 15
        Me.btnBeendeArbeitstag.Text = "Beende Arbeitstag"
        Me.btnBeendeArbeitstag.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(212, 24)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(2, 22)
        Me.lblStatus.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GroupBox1.Location = New System.Drawing.Point(212, 56)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(201, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmZeiterfassung
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(438, 206)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnBeendeArbeitstag)
        Me.Controls.Add(Me.lblTrennungPause2)
        Me.Controls.Add(Me.lbltrennungPause)
        Me.Controls.Add(Me.lblPauseSekunden)
        Me.Controls.Add(Me.lblPauseMinuten)
        Me.Controls.Add(Me.lblPauseStunden)
        Me.Controls.Add(lblTrennung2)
        Me.Controls.Add(lblTrennung)
        Me.Controls.Add(Me.lblSekunden)
        Me.Controls.Add(Me.lblMinuten)
        Me.Controls.Add(Me.lblStunden)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmZeiterfassung"
        Me.Text = "Zeiterfassung"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblStunden As Label
    Friend WithEvents lblMinuten As Label
    Friend WithEvents lblSekunden As Label
    Friend WithEvents lblPauseSekunden As Label
    Friend WithEvents lblPauseMinuten As Label
    Friend WithEvents lblPauseStunden As Label
    Friend WithEvents lbltrennungPause As Label
    Friend WithEvents lblTrennungPause2 As Label
    Friend WithEvents btnBeendeArbeitstag As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
