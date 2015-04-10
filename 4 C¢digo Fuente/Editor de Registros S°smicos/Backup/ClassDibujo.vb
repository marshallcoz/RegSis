Imports System.Drawing.Drawing2D
Imports System.IO

Public Class ClassDibujo
    Public Shared ymax, ymin As Single
    Public Shared Sub DrawOnPictureBox(ByVal gr As Graphics, _
    ByVal pb As Object, ByVal rg(,) As Double, ByVal col As Color, _
    ByVal limpiar As Boolean, Optional ByVal St As Int16 = 1)
        'On Error GoTo EvaluateError
        Dim i As Integer
        'Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        ymax = 0
        ymin = 0
        For i = 0 To CInt(rg.Length / 2) - 1
            If rg(i, 0) > ymax Then
                ymax = rg(i, 0)
            End If
            If rg(i, 0) < ymin Then
                ymin = rg(i, 0)
            End If
        Next
        If limpiar = True Then
            gr.Clear(pb.BackColor) 'Para limpiar el picturebox
            MapGraphicsWindow(gr, 0, ymin * 100000, CSng(rg.Length / 2) - 1, ymax * 100000, 0, pb.Height - 1, pb.Width - 1, 0)
        End If
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo
        'Dim i As Integer                                              
        Dim fn As New Pen(col, 0.01)
        Dim fz As New Pen(Color.WhiteSmoke, 0.005)

        gr.DrawLine(fz, 0, 0, CInt(rg.Length / 2) - 1, 0) 'linea de cero
        For i = 0 To CInt(rg.Length / 2) - 2 Step St    'el gráfico
            Try
                gr.DrawLine(fn, CSng(i), CSng(rg(i, 0) * 100000), CSng(i + 1), CSng(rg(i + 1, 0) * 100000))
            Catch ex As Exception
                Err.Clear()
            End Try

        Next
        Exit Sub

        'EvaluateError: Err.Clear()
    End Sub

    ' Map the world coordinates wxmin, wymin, wxmax, wymax to 
    ' the device coordinates dxmin, dymin, dxmax, dymax.
    <System.Diagnostics.DebuggerStepThrough()> Public Shared Sub MapGraphicsWindow(ByVal gr As Graphics, _
     ByVal wxmin As Double, ByVal wymin As Double, ByVal wxmax As Double, ByVal wymax As Double, _
     ByVal dxmin As Double, ByVal dymin As Double, ByVal dxmax As Double, ByVal dymax As Double)
        ' Clear any current transformation.
        gr.ResetTransform()

        ' Translate the world coordinate center to the origin.
        gr.TranslateTransform( _
            -(wxmax + wxmin) / 2, _
            -(wymax + wymin) / 2, _
            MatrixOrder.Append)

        ' Scale.
        Dim sx As Double = CDbl((dxmax - dxmin) / (wxmax - wxmin))
        Dim sy As Double = CDbl((dymax - dymin) / (wymax - wymin))
        gr.ScaleTransform(sx, sy, MatrixOrder.Append)

        ' Translate the origin to the device coordinate center.
        gr.TranslateTransform( _
            (dxmax + dxmin) / 2, _
            (dymax + dymin) / 2, _
            MatrixOrder.Append)
    End Sub
    Public Shared Sub DrawOnPictureBox2(ByVal gr As Graphics, _
     ByVal pb As Object, ByVal rg(,) As Double, ByVal col As Color)
        'On Error GoTo EvaluateError
        Dim i As Integer
        'Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        ymax = 0
        ymin = 0
        For i = 0 To CInt(rg.Length / 2) - 1
            If rg(i, 0) > ymax Then
                ymax = rg(i, 0)
            End If
            If rg(i, 0) < ymin Then
                ymin = rg(i, 0)
            End If
        Next

        MapGraphicsWindow(gr, 0, ymin * 100000, CSng(rg.Length / 2) - 1, ymax * 100000, 0, pb.Height - 1, pb.Width - 1, 0)

    End Sub
    Public Shared Sub DrawOnPictureBox3(ByVal gr As Graphics, _
     ByVal pb As Object, ByVal rg(,) As Double, ByVal col As Color, Optional ByVal St As Int16 = 1)
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo
        'Dim i As Integer                                              
        Dim fn As New Pen(col, 0.01)
        Dim fz As New Pen(Color.WhiteSmoke, 0.005)
        Dim i As Integer
        gr.DrawLine(fz, 0, 0, CInt(rg.Length / 2) - 1, 0) 'linea de cero
        For i = 0 To CInt(rg.Length / 2) - 2 Step St   'el gráfico
            Try
                gr.DrawLine(fn, CSng(i), CSng(rg(i, 0) * 100000), CSng(i + 1), CSng(rg(i + 1, 0) * 100000))
            Catch ex As Exception
                Err.Clear()
            End Try
        Next
        Exit Sub

        'EvaluateError: Err.Clear()
    End Sub
    Public Shared Sub DrawFourier(ByVal gr As Graphics, _
ByVal pb As Object, ByVal rgB() As Double, ByVal col As Color, _
ByVal limpiar As Boolean, Optional ByVal DesdeLaMitad As Boolean = False, Optional ByVal SuaV As Int16 = 0)
        'On Error GoTo EvaluateError
        'rgB es un vector con la magnitud
        Dim i, j, k As Double
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
        'Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        ymax = 0
        ymin = 0
        Dim final As Integer
        If DesdeLaMitad = True Then
            final = rg.Length / 2 - 1
        Else
            final = rg.Length - 1
        End If
        For i = 0 To final
            If rg(i) > ymax Then
                ymax = rg(i)
            End If
            If rg(i) < ymin Then
                ymin = rg(i)
            End If
        Next
        'If ymax = 0 And ymin = 0 Then
        '    Exit Sub
        'End If

        Dim valor As Double = 1
        'valor = 10000000 / (1.5 * Math.Max(Math.Abs(ymin), Math.Abs(ymax)))
        '10000000
        If limpiar = True Then
            gr.Clear(pb.BackColor) 'Para limpiar el picturebox
            MapGraphicsWindow(gr, 0, ymin * valor, final, ymax * valor, 0, pb.Height - 1, pb.Width - 1, 0)
        End If
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo
        'Dim i As Integer                                              
        Dim fn As New Pen(col, 0.01)
        Dim fz As New Pen(Color.WhiteSmoke, 0.005)

        gr.DrawLine(fz, CSng(0), CSng(0), CSng(rg.Length - 1), CSng(0)) 'linea de cero
        For i = 1 To final - 1 'el gráfico
            Try
                gr.DrawLine(fn, CSng(i), CSng(rg(i) * valor), CSng(i + 1), CSng(rg(i + 1) * valor))
            Catch ex As Exception
                Err.Clear()
            End Try
        Next
        Exit Sub

        'EvaluateError: Err.Clear()
    End Sub
    Public Shared Sub DrawOnPictureBoxRANGO(ByVal gr As Graphics, _
ByVal pb As Object, ByVal rg(,) As Double, ByVal col As Color, _
ByVal limpiar As Boolean, ByVal t1 As Single, ByVal t2 As Single, ByVal Di As Integer)
        'On Error GoTo EvaluateError
        Dim i As Integer
        'Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        ymax = 0
        ymin = 0
        For i = t1 To t2
            If rg(i, Di) > ymax Then
                ymax = rg(i, Di)
            End If
            If rg(i, Di) < ymin Then
                ymin = rg(i, Di)
            End If
        Next
        If limpiar = True Then
            gr.Clear(pb.BackColor) 'Para limpiar el picturebox
            MapGraphicsWindow(gr, t1, ymin, t2, ymax, 0, pb.Height - 1, pb.Width - 1, 0)
        End If
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo
        'Dim i As Integer                                              
        Dim fn As New Pen(col, 0.01)
        Dim fz As New Pen(Color.WhiteSmoke, 0.005)

        gr.DrawLine(fz, t1, 0, t2, 0)  'linea de cero
        For i = t1 To t2   'el gráfico
            Try
                gr.DrawLine(fn, CSng(i), CSng(rg(i, Di)), CSng(i + 1), CSng(rg(i + 1, Di)))
            Catch ex As Exception
                Err.Clear()
            End Try
        Next
        Exit Sub

        'EvaluateError: Err.Clear()
    End Sub

    Public Shared Sub DrawTransf(ByVal gr As Graphics, _
    ByVal pb As Object, ByVal rgB(,) As Double, ByVal col As Color, _
    ByVal limpiar As Boolean, Optional ByVal MostrarConjugado As Boolean = True, Optional ByVal SuaV As Int16 = 0)
        '   On Error GoTo EvaluateError
        'rgB es un vector con la magnitud
        Dim i, j, k As Double
        Dim rg((rgB.Length / 2 - 1) / (SuaV * 2 + 1)) As Double
        Dim val As Double

        For i = 0 To rgB.Length / 2 - 1
            val += rgB(i, 1)
            j += 1
            If j = SuaV * 2 + 1 Then
                rg(k) = val / j
                val = 0
                j = 0
                k += 1
            End If
        Next
        'Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        ymax = 0
        ymin = 0
        Dim final As Integer
        If MostrarConjugado = False Then
            final = rg.Length / 2 - 1
        Else
            final = rg.Length - 1
        End If
        For i = 0 To final
            If rg(i) > ymax Then
                ymax = rg(i)
            End If
            If rg(i) < ymin Then
                ymin = rg(i)
            End If
        Next
        'If ymax = 0 And ymin = 0 Then
        '    Exit Sub
        'End If

        Dim valor As Double = 1
        '        valor = 10000000 / (1.5 * Math.Max(Math.Abs(ymin), Math.Abs(ymax)))

        '10000000
        If limpiar = True Then
            gr.Clear(pb.BackColor) 'Para limpiar el picturebox
            MapGraphicsWindow(gr, 0, ymin * valor, final, CInt(ymax * valor), 0, pb.Height - 1, pb.Width - 1, 0)
        End If
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo

        Dim fn As New Pen(col, 0.01)
        Dim fz As New Pen(Color.WhiteSmoke, 0.005)
        Dim ln As New Pen(Color.Yellow, 0.005)
        If Transf.handleDAMPING = True Then
            If Transf.T1 <> 0 Then
                gr.DrawLine(ln, CSng(Transf.T1 / (SuaV * 2 + 1)), CSng(ymin * valor), CSng(Transf.T1 / (SuaV * 2 + 1)), CSng(ymax * valor))
            End If
            If Transf.T2 <> 0 Then
                gr.DrawLine(ln, CSng(Transf.T2 / (SuaV * 2 + 1)), CSng(ymin * valor), CSng(Transf.T2 / (SuaV * 2 + 1)), CSng(ymax * valor))
            End If
        End If
        gr.DrawLine(fz, 0, 0, rg.Length - 1, 0) 'linea de cero
        For i = 1 To final - 1  'el gráfico
            Try
                gr.DrawLine(fn, CSng(i), CSng(rg(i) * valor), CSng(i + 1), CSng(rg(i + 1) * valor))
                '                gr.DrawBezier(fn, CSng(i), CSng(rg(i)), CSng(i + 1), CSng(rg(i + 1)), CSng(i + 2), CSng(rg(i + 2)), CSng(i + 3), CSng(rg(i + 3)))
            Catch ex As Exception
                Err.Clear()
            End Try
        Next
        Exit Sub

EvaluateError: Err.Clear()
    End Sub
    Public Shared Sub DrawTransflog(ByVal gr As Graphics, _
        ByVal pb As Object, ByVal rgB(,) As Double, ByVal col As Color, _
        ByVal limpiar As Boolean, Optional ByVal MostrarConjugado As Boolean = True, Optional ByVal SuaV As Int16 = 0)
        '   On Error GoTo EvaluateError
        'rgB es un vector con la magnitud
        Dim i, j, k As Double
        Dim rg((rgB.Length / 2 - 1) / (SuaV * 2 + 1)) As Double
        Dim val As Double



        For i = 1 To rgB.Length / 2 - 1
            If Not Double.IsNaN(rgB(i, 1)) Then
                val += rgB(i, 1)
                j += 1
                If j >= SuaV * 2 + 1 Then
                    'If Double.IsNaN(val) Then
                    '    val = 0
                    'End If
                    'rg(k) = Math.Log10(val / j) * 1000000
                    'val = 0
                    'j = 0
                    'k += 1
                    If Double.IsNaN(val) Or val = 0 Then
                        rg(k) = 0
                    Else
                        rg(k) = Math.Log10(val / j) * 1000000
                    End If
                    val = 0
                    j = 0
                    k += 1
                End If
            Else
                j += 1
            End If

        Next
        'Dim ymax, ymin As Single
        'identificar valores máximos y duración del registro para poder trazarlo alineado
        'la x va de 0 a rg.length-1
        'la y va del valor ymín al ymáx  
        ymax = 0
        ymin = Single.MaxValue
        Dim final As Integer
        If MostrarConjugado = False Then
            final = rg.Length / 2 - 1
        Else
            final = rg.Length - 1
        End If
        For i = 0 To final
            If rg(i) > ymax Then
                ymax = rg(i)
            End If
            If rg(i) < ymin Then
                ymin = rg(i)
            End If
        Next
        'If ymax = 0 And ymin = 0 Then
        '    Exit Sub
        'End If

        'Dim valor As Double
        'valor = 10000000 / (1.5 * Math.Max(Math.Abs(ymin), Math.Abs(ymax)))
        ' valor = Math.Log10(ymax) / ymax
        'valor = 1
        'valor = 10 / (1.5 * Math.Max(Math.Abs(ymin), Math.Abs(ymax)))
        '10000000
        If limpiar = True Then
            gr.Clear(pb.BackColor) 'Para limpiar el picturebox
            MapGraphicsWindow(gr, 0, ymin, final, ymax, 0, pb.Height - 1, pb.Width - 1, 0)
        End If
        'Los límites del gráfico se toman de los valores extremos de los datos finales en form1
        ' Map xmin <= X <= xmax, ymin <= Y <= ymax to the PictureBox.
        'Está definida en el módulo anexo

        Dim fn As New Pen(col, 0.01)
        Dim fz As New Pen(Color.WhiteSmoke, 0.005)
        Dim ln As New Pen(Color.Yellow, 0.005)
        If Transf.handleDAMPING = True Then
            If Transf.T1 <> 0 Then
                gr.DrawLine(ln, CSng(Transf.T1 / (SuaV * 2 + 1)), CSng(ymin), CSng(Transf.T1 / (SuaV * 2 + 1)), CSng(ymax))
            End If
            If Transf.T2 <> 0 Then
                gr.DrawLine(ln, CSng(Transf.T2 / (SuaV * 2 + 1)), CSng(ymin), CSng(Transf.T2 / (SuaV * 2 + 1)), CSng(ymax))
            End If
        End If

        gr.DrawLine(fz, 0, 0, rg.Length - 1, 0) 'linea de cero
        For i = 1 To final - 1 Step 3 'el gráfico

            Try
                'con escala vertical logarítmica
                'gr.DrawLine(fn, CInt(i), CInt(rg(i) * valor), CInt(i + 1), CInt(rg(i + 1) * valor))
                gr.DrawBezier(fn, CSng(i), CSng(rg(i)), CSng(i + 1), CSng(rg(i + 1)), CSng(i + 2), CSng(rg(i + 2)), CSng(i + 3), CSng(rg(i + 3)))

            Catch ex As Exception
                Err.Clear()
            End Try
        Next
        Exit Sub

EvaluateError: Err.Clear()
    End Sub
End Class
