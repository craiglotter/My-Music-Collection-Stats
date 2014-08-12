Imports System.IO
Imports System.Net

Public Class Main_Screen

    Private busyworking As Boolean = False
    Private AutoUpdate As Boolean = False

    Private precountArtists As Long = 0
    Private precountAlbums As Long = 0
    Private countArtists As Long = 0
    Private countAlbums As Long = 0
    Private countAlbumsSorted As Long = 0
    Private countTracks As Long = 0
    Private countAlbumArt As Long = 0
    Private countSize As Long = 0
    Private countMP3 As Long = 0
    Private countWMA As Long = 0

    Private UnsortedAlbums As ArrayList

    Private Setting_CollectionFolder As String = ""


    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ": " & ex.ToString
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ": " & ex.ToString)
                filewriter.WriteLine("")
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
            StatusLabel.Text = "Error Reported"
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error." & vbCrLf & vbCrLf & exc.ToString, MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub Activity_Handler(ByVal message As String)
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & message)
            filewriter.WriteLine("")
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
            StatusLabel.Text = "Activity Logged"
        Catch ex As Exception
            Error_Handler(ex, "Activity Handler")
        End Try
    End Sub

   

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UnsortedAlbums = New ArrayList
            Control.CheckForIllegalCrossThreadCalls = False
            Me.Text = My.Application.Info.ProductName & " (" & Format(My.Application.Info.Version.Major, "0000") & Format(My.Application.Info.Version.Minor, "00") & Format(My.Application.Info.Version.Build, "00") & "." & Format(My.Application.Info.Version.Revision, "00") & ")"
            loadSettings()
            StatusLabel.Text = "Application Loaded"
            runworker()
        Catch ex As Exception
            Error_Handler(ex, "Application Loading")
        End Try
    End Sub

    Private Sub loadSettings()
        Try

            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            If My.Computer.FileSystem.FileExists(configfile) Then
                Dim reader As StreamReader = New StreamReader(configfile)
                Dim lineread As String
                Dim variablevalue As String
                While reader.Peek <> -1
                    lineread = reader.ReadLine
                    If lineread.IndexOf("=") <> -1 Then
                        variablevalue = lineread.Remove(0, lineread.IndexOf("=") + 1)
                        If lineread.StartsWith("Setting_CollectionFolder=") Then
                            If My.Computer.FileSystem.DirectoryExists(variablevalue) = True Then
                                Setting_CollectionFolder = variablevalue
                            End If
                        End If
                     
                    End If
                End While
                reader.Close()
                reader = Nothing

            End If
            StatusLabel.Text = "Application Settings Loaded"
        Catch ex As Exception
            Error_Handler(ex, "Load Settings")
        End Try
    End Sub

    Private Sub SaveSettings()
        Try
            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            Dim writer As StreamWriter = New StreamWriter(configfile, False)
            writer.WriteLine("Setting_CollectionFolder=" & Setting_CollectionFolder)
            writer.Flush()
            writer.Close()
            writer = Nothing
            StatusLabel.Text = "Application Settings Saved"
        Catch ex As Exception
            Error_Handler(ex, "Save Settings")
        End Try
    End Sub

    Private Sub Main_Screen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            SaveSettings()
           
            If AutoUpdate = True Then
                If My.Computer.FileSystem.FileExists((Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")) = True Then
                    Dim startinfo As ProcessStartInfo = New ProcessStartInfo
                    startinfo.FileName = (Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")
                    startinfo.Arguments = "force"
                    startinfo.CreateNoWindow = False
                    Process.Start(startinfo)
                End If
            End If
            StatusLabel.Text = "Application Shutting Down"
        Catch ex As Exception
            Error_Handler(ex, "Closing Application")
        End Try
    End Sub


    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Try
            HelpBox1.ShowDialog()
            StatusLabel.Text = "Help Dialog Viewed"
        Catch ex As Exception
            Error_Handler(ex, "Display Help Screen")
        End Try
    End Sub

    Private Sub AutoUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoUpdateToolStripMenuItem.Click
        Try
            StatusLabel.Text = "AutoUpdate Requested"
            AutoUpdate = True
            Me.Close()
        Catch ex As Exception
            Error_Handler(ex, "AutoUpdate")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Try
            AboutBox1.ShowDialog()
            StatusLabel.Text = "About Dialog Viewed"
        Catch ex As Exception
            Error_Handler(ex, "Display About Screen")
        End Try
    End Sub

    Private Sub Control_Enabler(ByVal IsEnabled As Boolean)
        Try
            Select Case IsEnabled
                Case True
                    MenuStrip1.Enabled = True
                    Me.ControlBox = True
                    ProgressBar1.Enabled = False
                Case False
                    MenuStrip1.Enabled = False
                    Me.ControlBox = False
                    ProgressBar1.Enabled = True
            End Select
            StatusLabel.Text = "Control Enabler Run"
        Catch ex As Exception
            Error_Handler(ex, "Control Enabler")
        End Try
    End Sub

    Private Sub runworker()
        Try
            If busyworking = False Then
                If Setting_CollectionFolder.Length < 1 Or My.Computer.FileSystem.DirectoryExists(Setting_CollectionFolder) = False Then
                    FolderBrowserDialog1.Description = "Please select the folder containing your Music Collection:"
                    'If My.Computer.FileSystem.DirectoryExists(Setting_CollectionFolder) = True Then
                    '    FolderBrowserDialog1.SelectedPath = Setting_CollectionFolder
                    'End If
                    If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Setting_CollectionFolder = FolderBrowserDialog1.SelectedPath
                    End If
                End If

                If My.Computer.FileSystem.DirectoryExists(Setting_CollectionFolder) = True Then
                    precountArtists = 0
                    precountAlbums = 0
                    countArtists = 0
                    countAlbums = 0
                    countAlbumsSorted = 0
                    countTracks = 0
                    countAlbumArt = 0
                    countSize = 0
                    countMP3 = 0
                    countWMA = 0


                    LabelAlbumArt.Text = countAlbumArt
                    LabelAlbums.Text = countAlbums
                    LabelAlbumsSorted.Text = countAlbumsSorted
                    LabelArtists.Text = countArtists
                    LabelFolder.Text = ""
                    LabelSize.Text = countSize
                    LabelTracks.Text = countTracks

                    ProgressBar1.Value = 0
                    ProgressBar1.Refresh()
                    StatusLabel.Refresh()
                    If BackgroundWorker1 Is Nothing Then
                        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
                        BackgroundWorker1.WorkerReportsProgress = True
                        BackgroundWorker1.WorkerSupportsCancellation = True
                    End If
                    busyworking = True

                    UnsortedAlbums.Clear()

                    Control_Enabler(False)
                    BackgroundWorker1.RunWorkerAsync()
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Run Worker")
        End Try
    End Sub

    Private Sub RunPrecount()
        Try
            BackgroundWorker1.ReportProgress(50)
            Dim dinfo As DirectoryInfo = New DirectoryInfo(Setting_CollectionFolder)
            precountArtists = dinfo.GetDirectories.Length
            For Each subdir As DirectoryInfo In dinfo.GetDirectories
                For Each subsubdir As DirectoryInfo In subdir.GetDirectories
                    precountAlbums = precountAlbums + 1
                    BackgroundWorker1.ReportProgress(50)
                    subsubdir = Nothing
                Next
                subdir = Nothing
            Next
            dinfo = Nothing
            BackgroundWorker1.ReportProgress(50)
        Catch ex As Exception
            Error_Handler(ex, "Precount Function")
        End Try
    End Sub


    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            If e.ProgressPercentage = 100 Then
                ProgressBar1.Value = Math.Round(((countAlbums / precountAlbums) * 100), 0)
                StatusLabel.Text = "Processing Music Collection: " & countArtists & " (of " & precountArtists & ") artists | " & countAlbums & " (of " & precountAlbums & ") albums"
            Else
                StatusLabel.Text = "Running Precount: " & precountArtists & " artists | " & precountAlbums & " albums"
            End If
        Catch ex As Exception
            Error_Handler(ex, "Report Progress")
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If BackgroundWorker1.CancellationPending = False Then
                StatusLabel.Text = "Starting up Precount Operation"
                RunPrecount()
            Else
                e.Cancel = True
            End If

            If BackgroundWorker1.CancellationPending = False Then
                StatusLabel.Text = "Precount Operation Complete"
                StatusLabel.Text = "Processing Music Collection"
                BackgroundWorker1.ReportProgress(100)
                Dim basedir As DirectoryInfo = New DirectoryInfo(Setting_CollectionFolder)
                LabelFolder.Text = basedir.FullName
                For Each dinfo As DirectoryInfo In basedir.GetDirectories
                    countArtists = countArtists + 1
                    LabelArtists.Text = countArtists & " bands/artists"
                    For Each subdir As DirectoryInfo In dinfo.GetDirectories
                        countAlbums = countAlbums + 1
                        LabelAlbums.Text = countAlbums & " albums"
                        If dinfo.Name.ToLower.Trim.EndsWith("(sorted)") = True Then
                            countAlbumsSorted = countAlbumsSorted + 1
                            LabelAlbumsSorted.Text = countAlbumsSorted & " albums (" & Math.Round(((countAlbumsSorted / countAlbums) * 100), 0) & "%)"
                        Else
                            If UnsortedAlbums.IndexOf(dinfo.Name.Trim) = -1 Then
                                UnsortedAlbums.Add(dinfo.Name.Trim)
                            End If
                        End If
                        For Each finfo As FileInfo In subdir.GetFiles
                            If finfo.Extension.ToLower = ".mp3" Or finfo.Extension.ToLower = ".mp4" Or finfo.Extension.ToLower = ".wma" Then
                                If finfo.Extension.ToLower = ".mp3" Then
                                    countMP3 = countMP3 + 1
                                End If
                                If finfo.Extension.ToLower = ".wma" Then
                                    countWMA = countWMA + 1
                                End If
                                countTracks = countTracks + 1
                                LabelTracks.Text = countTracks & " music files (" & countMP3 & " MP3s) (" & countWMA & " WMAs)"
                                countSize = countSize + finfo.Length
                                LabelSize.Text = ByteConverter(countSize) & " (" & countSize & " bytes)"
                            End If
                            If finfo.Extension.ToLower = ".jpg" Or finfo.Extension.ToLower = ".bmp" Or finfo.Extension.ToLower = ".png" Or finfo.Extension.ToLower = ".gif" Then
                                countAlbumArt = countAlbumArt + 1
                                LabelAlbumArt.Text = countAlbumArt & " images"
                            End If
                        Next
                        subdir = Nothing
                        BackgroundWorker1.ReportProgress(100)
                    Next
                    dinfo = Nothing
                Next
                basedir = Nothing
                BackgroundWorker1.ReportProgress(100)
            Else
                e.Cancel = True
            End If
            If BackgroundWorker1.CancellationPending = False Then
                StatusLabel.Text = "Music Collection Processed"
                e.Result = "Success"
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            Error_Handler(ex, "Music Collection Processing")
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Control_Enabler(True)
            If e.Cancelled = False And e.Error Is Nothing Then
                If e.Result = "Success" Then
                    StatusLabel.Text = "Music Collection Processed: " & countArtists & " (of " & precountArtists & ") artists | " & countAlbums & " (of " & precountAlbums & ") albums"
                End If
            Else
                StatusLabel.Text = "Music Collection Processing Cancelled: " & countArtists & " (of " & precountArtists & ") artists | " & countAlbums & " (of " & precountAlbums & ") albums"
            End If
            busyworking = False
            BackgroundWorker1.Dispose()
            BackgroundWorker1 = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Music Collection Processing Complete")
        End Try
    End Sub

    Private Function ByteConverter(ByVal inputbytes As Long) As String
        Dim filesize As Decimal = inputbytes
        Dim filesize_string As String = ""
        Try
            If filesize < 1024 Then
                filesize_string = filesize & " bytes"
            End If
            If filesize < 1048576 And filesize >= 1024 Then
                filesize = Math.Round(filesize / 1024, 2)
                filesize_string = filesize & " KB"
            End If
            If filesize < 1073741824 And filesize >= 1048576 Then
                filesize = Math.Round(filesize / 1048576, 2)
                filesize_string = filesize & " MB"
            End If
            If filesize >= 1073741824 Then
                filesize = Math.Round(filesize / 1073741824, 2)
                filesize_string = filesize & " GB"
            End If
        Catch ex As Exception
            Error_Handler(ex, "ByteConverter: Bytes=" & inputbytes)
        End Try
        Return filesize_string
    End Function

    Private Sub LoadMusicCollectionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadMusicCollectionToolStripMenuItem1.Click
        Try
            FolderBrowserDialog1.Description = "Please select the folder containing your Music Collection:"
            If My.Computer.FileSystem.DirectoryExists(Setting_CollectionFolder) = True Then
                FolderBrowserDialog1.SelectedPath = Setting_CollectionFolder
            End If
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Setting_CollectionFolder = FolderBrowserDialog1.SelectedPath
                runworker()
            End If
        Catch ex As Exception
            Error_Handler(ex, "Load Music Collection")
        End Try
    End Sub

    Private Sub ShowUnsortedFoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowUnsortedFoldersToolStripMenuItem.Click
        Try
            Dim UnsortedAlbums_Dialog1 = New UnsortedArtists_Dialog()
            UnsortedAlbums_Dialog1.Setting_CollectionFolder = Setting_CollectionFolder
            UnsortedAlbums_Dialog1.LoadAlbumList(UnsortedAlbums)
            UnsortedAlbums_Dialog1.ShowDialog()
            UnsortedAlbums_Dialog1.Dispose()
            UnsortedAlbums_Dialog1 = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Show Unsorted Albums")
        End Try
    End Sub
End Class
