Imports System.Windows.Forms

Public Class Colores


    Private Sub Colores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
        e.Cancel = True
    End Sub
End Class
