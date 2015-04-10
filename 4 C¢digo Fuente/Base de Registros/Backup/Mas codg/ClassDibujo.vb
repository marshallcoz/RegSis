Imports System.Drawing.Drawing2D
Imports System.IO

Public Class ClassDibujo
    
    Public Shared Sub DrawOnPictureBox(ByVal gr As Graphics, ByVal pb As PictureBox, ByVal rgB() As Double, Optional ByVal SuaV As Int16 = 0)
        On Error GoTo EvaluateError
        Dim i, j, k As Integer
        Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        Dim rg((rgB.Length - 1) / (SuaV * 2 + 1)) As Double
        Dim val As Double

        For i = 0 To rgB.Length - 1
            val += rgB(i)
            j += 1
            If j = SuaV * 2 + 1 Then
                rg(k) = val / j
                val = 0
                j = 0
                k += 1
            End If
        Next

        ymax = 0
        ymin = 0
        For i = 0 To rg.Length - 1
            If rg(i) > ymax Then
                ymax = rg(i)
            End If
            If rg(i) < ymin Then
                ymin = rg(i)
            End If
        Next
        gr.Clear(pb.BackColor)   'Para limpiar el picturebox
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo
        'Dim i As Integer
        Dim fn As New Pen(Color.Yellow, 0.01)
        MapGraphicsWindow(gr, 0, ymin * 1000, rg.Length - 1, ymax * 1000, 0, pb.Height - 1, pb.Width - 1, 0)
        gr.DrawLine(fn, 0, 0, rg.Length - 1, 0) 'linea de cero
        For i = 0 To rg.Length - 2      'el gráfico
            gr.DrawLine(fn, CSng(i), CSng(rg(i) * 1000), CSng(i + 1), CSng(rg(i + 1) * 1000))
        Next
        Exit Sub

EvaluateError: Err.Clear()
    End Sub

    ' Map the world coordinates wxmin, wymin, wxmax, wymax to 
    ' the device coordinates dxmin, dymin, dxmax, dymax.
    <System.Diagnostics.DebuggerStepThrough()> Public Shared Sub MapGraphicsWindow(ByVal gr As Graphics, _
     ByVal wxmin As Single, ByVal wymin As Single, ByVal wxmax As Single, ByVal wymax As Single, _
     ByVal dxmin As Single, ByVal dymin As Single, ByVal dxmax As Single, ByVal dymax As Single)
        ' Clear any current transformation.
        gr.ResetTransform()

        ' Translate the world coordinate center to the origin.
        gr.TranslateTransform( _
            -(wxmax + wxmin) / 2, _
            -(wymax + wymin) / 2, _
            MatrixOrder.Append)

        ' Scale.
        Dim sx As Single = CSng((dxmax - dxmin) / (wxmax - wxmin))
        Dim sy As Single = CSng((dymax - dymin) / (wymax - wymin))
        gr.ScaleTransform(sx, sy, MatrixOrder.Append)

        ' Translate the origin to the device coordinate center.
        gr.TranslateTransform( _
            (dxmax + dxmin) / 2, _
            (dymax + dymin) / 2, _
            MatrixOrder.Append)
    End Sub
End Class
