Imports System.IO
Public Class ImpSAP
    Dim rgSAP() As Double 'El registro importado de SAP2000
    Public Shared expo As String

    'Se muestra una ventana para abrir el registro y se lee su contenido
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK And OFD.FileName <> "" Then
            Dim reg As String

            Try
                Dim strdr As New StreamReader(OFD.FileName)
                reg = strdr.ReadToEnd()
                strdr.Close()

            Catch ex As Exception
                MessageBox.Show(Err.Description, "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Err.Clear()
                Me.Visible = False
                Exit Sub
            End Try

            'El contenido se muestra en pantalla
            tX.Text = reg
            Label1.Text = OFD.FileName
            Button2.Enabled = True 'Se habilita el botón de importar
        End If
    End Sub

    'el botón de importar
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'se preparan los nombres para guardar cada registro del archivo. Los nombres serán los de las funciones
        Label1.Text = Label1.Text.Remove(Label1.Text.LastIndexOf("."), 4)
        Label1.Text = Label1.Text.Trim(".")
        Dim R, name(30) As String
        Dim ii, k As Int16
        R = tX.Text.ToUpper()
        R = R.Remove(0, R.IndexOf("FUNCTION  "))
        Do While R.StartsWith("FUNCTION") = True
            name(ii) = R.Substring(0, R.IndexOf(vbNewLine))
            name(ii) = name(ii).Replace(":", " ")
            name(ii) = name(ii).Replace("  ", "_")
            ii += 1 'i guarda el la cantidad de registros presentes
            R = R.Remove(0, R.IndexOf(vbNewLine) + 3)
        Loop
        ii -= 1
        If ii = 0 Then 'solo hay un registro
            solouno(R) 'solo se importa un registro 'véase la función
            Exit Sub
        End If

        R = R.Remove(0, R.IndexOf(vbNewLine) + 2)
        R = R.Remove(0, R.IndexOf(vbNewLine) + 2)
        R = R.Remove(0, R.IndexOf(vbNewLine) + 2)

        Form1.SPS = 1 / (CSng(R.Substring(25 + 12 * ii, 11)) - CSng(R.Substring(0, 11))) 'se recupera la tasa de muestreo
        Form1.st.Text = Form1.SPS.ToString & " SPS"

        Dim rSaP(R.Length / (25 + 12 * ii) - 1, ii) As Double   'se hace una matriz donde cada columna corresponde a un registro
        Dim t As String
        Dim i, j As Double

        If Form1.Pdecim = "," Then
            R = R.Replace(".", ",")
        Else
            R = R.Replace(",", ".")
        End If

        For k = 0 To ii
            Do
                t = R.Substring((11 + k * 12) + j, 12)
                rSaP(i, k) = CDbl(t)
                i += 1
                j += (25 + 12 * ii)
            Loop While i < (R.Length / (25 + 12 * ii))
            i = 0
            j = 0
        Next

        For k = 0 To ii
            'Guardarlo en un archivo con los nombres que se recuperaron anteriormente
            If Not name(k).EndsWith(".001p") Then
                SFD.FileName = name(k) & ".001p"
            Else
                SFD.FileName = name(k) & ".001"
            End If
            If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            ElseIf SFD.FileName = "" Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

            Dim sw As New StreamWriter(SFD.FileName)
            Dim z As Single
            For z = 0 To (rSaP.Length / (ii + 1)) - 1
                If rSaP(z, k) < 0 Then 'se garantiza el ancho de columna uniforme
                    sw.WriteLine(Format(CStr(rSaP(z, k)) / 1, "#.0000000000000").Substring(0, 12))
                Else
                    sw.WriteLine(" " & Format(CStr(rSaP(z, k)) / 1, "#.0000000000000").Substring(0, 11))
                End If
            Next
            sw.Flush()
            sw.Close()
            name(k) = SFD.FileName
        Next

        'exportarlo en una lista
        Dim Cadena As String = Path.GetTempPath & "\Reg" & Now.Second.ToString 'Lo que se exporta  : El xml no puede codificar vectores así que solo se pasa la dirección 
        Dim swC As New StreamWriter(Cadena)
        For k = 0 To ii
            swC.WriteLine(name(k))
        Next
        swC.Flush()
        swC.Close()
        Dim BoX As New ClassBox
        BoX.Lea_los_datos_EXPORTADOS()
        BoX.RutaExportada = Cadena
        BoX.GuardarOpciones()
        expo = "Lista"
    End Sub

    Sub solouno(ByVal R As String)
      
        R = R.Remove(0, R.IndexOf(vbNewLine) + 2)
        R = R.Remove(0, R.IndexOf(vbNewLine) + 2)
        R = R.Remove(0, R.IndexOf(vbNewLine) + 2)

        If Form1.Pdecim = "," Then
            R = R.Replace(".", ",")
        Else
            R = R.Replace(",", ".")
        End If

        Form1.SPS = 1 / (CSng(R.Substring(25, 11)) - CSng(R.Substring(0, 11))) 'se recupera la tasa de muestreo
        Form1.st.Text = Form1.SPS.ToString & " SPS"

        'para dimensionar el vector rgSAP hay que saber cuantos renglones hay. Cada renglon tiene 23 caracteres mas un vbnewline que equivale a dos =  25
        ReDim rgSAP(CInt(R.Length / 25))
        Dim i, j As Double
        Dim t As String
        Try
            Do
                t = R.Substring(11 + j, 12)
                rgSAP(i) = CDbl(R.Substring(11 + j, 12))
                i += 1
                j += 25
            Loop While i < rgSAP.Length - 1
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Err.Clear()
        End Try

        'Guardarlo en un archivo
        If Not Label1.Text.EndsWith("p") Then
            SFD.FileName = Label1.Text.Substring(Label1.Text.LastIndexOf(":") - 1) & ".001p"
        Else
            SFD.FileName = Label1.Text.Substring(Label1.Text.LastIndexOf(":") - 1) & ".001"
        End If
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        ElseIf SFD.FileName = "" Then
            Exit Sub
        End If
        Dim sw As New StreamWriter(SFD.FileName)
        Dim z As Single
        For z = 0 To rgSAP.Length - 1
            If rgSAP(z) < 0 Then
                sw.WriteLine(Format(CStr(rgSAP(z)) / 1, "#.0000000000000").Substring(0, 12))
            Else
                sw.WriteLine(" " & Format(CStr(rgSAP(z)) / 1, "#.0000000000000").Substring(0, 11))
            End If
        Next
        sw.Flush()
        sw.Close()
        expo = SFD.FileName
    End Sub

End Class