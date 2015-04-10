Option Strict On
Imports System.IO
Imports System.Windows.Forms
Public Class FolderBrowser
    Inherits System.Windows.Forms.Design.FolderNameEditor

    Public Shared Function ShowDialog() As String
        Dim fb As New FolderBrowser
        fb.Description = "Seleccione el directorio /seismic con los registros almacenados por fechas"
        fb.Style = Design.FolderNameEditor.FolderBrowserStyles.RestrictToFilesystem

        If Main.stt = "" Then
            fb.StartLocation = Design.FolderNameEditor.FolderBrowserFolder.MyComputer
            fb.Style = Design.FolderNameEditor.FolderBrowserStyles.ShowTextBox
            fb.ShowDialog()
            ShowDialog = fb.DirectoryPath
        Else
            ShowDialog = Main.stt
        End If
        Dim strwtr As New StreamWriter("C:\Archivos de programa\UAEMex\ARSis v1.2\Consult.inf")
        strwtr.Write("!Path=" & ShowDialog)
        strwtr.Flush()
        strwtr.Close()

        Return ShowDialog
    End Function
End Class
