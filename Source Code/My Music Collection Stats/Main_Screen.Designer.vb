<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LoadMusicCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadMusicCollectionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowUnsortedFoldersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelSize = New System.Windows.Forms.Label
        Me.LabelTracks = New System.Windows.Forms.Label
        Me.LabelAlbumArt = New System.Windows.Forms.Label
        Me.LabelAlbumsSorted = New System.Windows.Forms.Label
        Me.LabelAlbums = New System.Windows.Forms.Label
        Me.LabelArtists = New System.Windows.Forms.Label
        Me.LabelFolder = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadMusicCollectionToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadMusicCollectionToolStripMenuItem
        '
        Me.LoadMusicCollectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadMusicCollectionToolStripMenuItem1, Me.ShowUnsortedFoldersToolStripMenuItem})
        Me.LoadMusicCollectionToolStripMenuItem.Name = "LoadMusicCollectionToolStripMenuItem"
        Me.LoadMusicCollectionToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.LoadMusicCollectionToolStripMenuItem.Text = "Music Collection"
        '
        'LoadMusicCollectionToolStripMenuItem1
        '
        Me.LoadMusicCollectionToolStripMenuItem1.Name = "LoadMusicCollectionToolStripMenuItem1"
        Me.LoadMusicCollectionToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.LoadMusicCollectionToolStripMenuItem1.Text = "Load Music Collection"
        '
        'ShowUnsortedFoldersToolStripMenuItem
        '
        Me.ShowUnsortedFoldersToolStripMenuItem.Name = "ShowUnsortedFoldersToolStripMenuItem"
        Me.ShowUnsortedFoldersToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ShowUnsortedFoldersToolStripMenuItem.Text = "Show Unsorted Artists"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AutoUpdateToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AutoUpdateToolStripMenuItem
        '
        Me.AutoUpdateToolStripMenuItem.Name = "AutoUpdateToolStripMenuItem"
        Me.AutoUpdateToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AutoUpdateToolStripMenuItem.Text = "AutoUpdate"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.StatusLabel.Location = New System.Drawing.Point(0, 310)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.StatusLabel.Size = New System.Drawing.Size(449, 25)
        Me.StatusLabel.TabIndex = 21
        Me.StatusLabel.Text = "Application Loaded"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 277)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(407, 23)
        Me.ProgressBar1.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelSize)
        Me.GroupBox1.Controls.Add(Me.LabelTracks)
        Me.GroupBox1.Controls.Add(Me.LabelAlbumArt)
        Me.GroupBox1.Controls.Add(Me.LabelAlbumsSorted)
        Me.GroupBox1.Controls.Add(Me.LabelAlbums)
        Me.GroupBox1.Controls.Add(Me.LabelArtists)
        Me.GroupBox1.Controls.Add(Me.LabelFolder)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(21, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 149)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "My Music Collection"
        '
        'LabelSize
        '
        Me.LabelSize.AutoEllipsis = True
        Me.LabelSize.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelSize.Location = New System.Drawing.Point(112, 116)
        Me.LabelSize.Name = "LabelSize"
        Me.LabelSize.Size = New System.Drawing.Size(275, 13)
        Me.LabelSize.TabIndex = 13
        '
        'LabelTracks
        '
        Me.LabelTracks.AutoEllipsis = True
        Me.LabelTracks.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelTracks.Location = New System.Drawing.Point(112, 101)
        Me.LabelTracks.Name = "LabelTracks"
        Me.LabelTracks.Size = New System.Drawing.Size(275, 13)
        Me.LabelTracks.TabIndex = 12
        '
        'LabelAlbumArt
        '
        Me.LabelAlbumArt.AutoEllipsis = True
        Me.LabelAlbumArt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelAlbumArt.Location = New System.Drawing.Point(112, 86)
        Me.LabelAlbumArt.Name = "LabelAlbumArt"
        Me.LabelAlbumArt.Size = New System.Drawing.Size(275, 13)
        Me.LabelAlbumArt.TabIndex = 11
        '
        'LabelAlbumsSorted
        '
        Me.LabelAlbumsSorted.AutoEllipsis = True
        Me.LabelAlbumsSorted.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelAlbumsSorted.Location = New System.Drawing.Point(112, 71)
        Me.LabelAlbumsSorted.Name = "LabelAlbumsSorted"
        Me.LabelAlbumsSorted.Size = New System.Drawing.Size(275, 13)
        Me.LabelAlbumsSorted.TabIndex = 10
        '
        'LabelAlbums
        '
        Me.LabelAlbums.AutoEllipsis = True
        Me.LabelAlbums.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelAlbums.Location = New System.Drawing.Point(112, 56)
        Me.LabelAlbums.Name = "LabelAlbums"
        Me.LabelAlbums.Size = New System.Drawing.Size(275, 13)
        Me.LabelAlbums.TabIndex = 9
        '
        'LabelArtists
        '
        Me.LabelArtists.AutoEllipsis = True
        Me.LabelArtists.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelArtists.Location = New System.Drawing.Point(112, 41)
        Me.LabelArtists.Name = "LabelArtists"
        Me.LabelArtists.Size = New System.Drawing.Size(275, 13)
        Me.LabelArtists.TabIndex = 8
        '
        'LabelFolder
        '
        Me.LabelFolder.AutoEllipsis = True
        Me.LabelFolder.ForeColor = System.Drawing.Color.SaddleBrown
        Me.LabelFolder.Location = New System.Drawing.Point(112, 26)
        Me.LabelFolder.Name = "LabelFolder"
        Me.LabelFolder.Size = New System.Drawing.Size(275, 13)
        Me.LabelFolder.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Collection Size:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Album Art:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of Tracks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sorted Albums:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Albums:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Artists:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Collection Folder:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.My_Music_Collection_Stats.My.Resources.Resources.Form_Banner
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 69)
        Me.Panel1.TabIndex = 11
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadMusicCollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelFolder As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelSize As System.Windows.Forms.Label
    Friend WithEvents LabelTracks As System.Windows.Forms.Label
    Friend WithEvents LabelAlbumArt As System.Windows.Forms.Label
    Friend WithEvents LabelAlbumsSorted As System.Windows.Forms.Label
    Friend WithEvents LabelAlbums As System.Windows.Forms.Label
    Friend WithEvents LabelArtists As System.Windows.Forms.Label
    Friend WithEvents LoadMusicCollectionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowUnsortedFoldersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
