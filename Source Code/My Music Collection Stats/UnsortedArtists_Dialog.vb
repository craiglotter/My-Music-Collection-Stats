Imports System.Windows.Forms
Imports System.IO

Public Class UnsortedArtists_Dialog

    Protected Friend Setting_CollectionFolder As String = ""

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
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error." & vbCrLf & vbCrLf & exc.ToString, MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Protected Friend Sub LoadAlbumList(ByVal albumlist As ArrayList)
        Try
            For Each value As String In albumlist
                ListBox1.Items.Add(value)
            Next
        Catch ex As Exception
            Error_Handler(ex, "Load Album List")
        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
            If ListBox1.SelectedIndex <> -1 Then
                If My.Computer.FileSystem.DirectoryExists((Setting_CollectionFolder & "\" & ListBox1.Items(ListBox1.SelectedIndex)).replace("\\", "\")) = True Then
                    Process.Start((Setting_CollectionFolder & "\" & ListBox1.Items(ListBox1.SelectedIndex)).replace("\\", "\"))
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Listbox Double Click")
        End Try
    End Sub
End Class
