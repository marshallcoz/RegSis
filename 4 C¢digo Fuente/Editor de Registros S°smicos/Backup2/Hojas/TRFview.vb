Imports Editor_de_Registros_Sísmicos.ClassDibujo
Imports System.IO
Public Class TRFview
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents La As System.Windows.Forms.Label
    Friend WithEvents BTpositiv As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PiC As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRFview))
        Me.La = New System.Windows.Forms.Label
        Me.BTpositiv = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.PiC = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PiC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'La
        '
        Me.La.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.La.Location = New System.Drawing.Point(363, 13)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(290, 18)
        Me.La.TabIndex = 1
        Me.La.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.La, "Frecuencia ; Amplitud")
        '
        'BTpositiv
        '
        Me.BTpositiv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTpositiv.ImageIndex = 3
        Me.BTpositiv.ImageList = Me.ImageList1
        Me.BTpositiv.Location = New System.Drawing.Point(4, 4)
        Me.BTpositiv.Name = "BTpositiv"
        Me.BTpositiv.Size = New System.Drawing.Size(32, 32)
        Me.BTpositiv.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BTpositiv, "Cambiar entre: Todo el Espectro o solo la parte positiva")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(49, 11)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(161, 20)
        Me.TrackBar1.TabIndex = 4
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.ToolTip1.SetToolTip(Me.TrackBar1, "Fs: Factor de suavizado")
        Me.TrackBar1.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 2
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(212, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button1, "Guardar el espectro en un archivo")
        '
        'RadioButton7
        '
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(247, 11)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton7.TabIndex = 17
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "0"
        Me.ToolTip1.SetToolTip(Me.RadioButton7, "Sin suavizado")
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(276, 11)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton6.TabIndex = 18
        Me.RadioButton6.Text = "1"
        Me.ToolTip1.SetToolTip(Me.RadioButton6, "Suavizado: promedio cuadrático entre las cercanías con una ventana rectangular fi" & _
                "ja")
        '
        'RadioButton5
        '
        Me.RadioButton5.Location = New System.Drawing.Point(305, 11)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton5.TabIndex = 19
        Me.RadioButton5.Text = "2"
        Me.ToolTip1.SetToolTip(Me.RadioButton5, "Suavizado: Promedio de cada punto con sus cercanías, con una ventana rectangular " & _
                "en función de la frecuencia (castiga las frecuencias altas). Toma algo de tiempo" & _
                "")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.La)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Controls.Add(Me.BTpositiv)
        Me.Panel1.Controls.Add(Me.RadioButton7)
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 37)
        Me.Panel1.TabIndex = 5
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(334, 11)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton4.TabIndex = 20
        Me.RadioButton4.Text = "3"
        Me.RadioButton4.Visible = False
        '
        'SFD
        '
        Me.SFD.DefaultExt = "txt"
        Me.SFD.Title = "Guardar el espectro en un archivo"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(127, 237)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'PiC
        '
        Me.PiC.BackColor = System.Drawing.Color.Black
        Me.PiC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PiC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PiC.Location = New System.Drawing.Point(127, 0)
        Me.PiC.Name = "PiC"
        Me.PiC.Size = New System.Drawing.Size(527, 237)
        Me.PiC.TabIndex = 7
        Me.PiC.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "filtrar"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(13, 75)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.Text = "PasaAlta"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(13, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PasaBanda"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "90"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "0.1"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(13, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "PasaBaja"
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(12, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 22)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "no filtrar"
        '
        'TRFview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(654, 274)
        Me.Controls.Add(Me.PiC)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 251)
        Me.Name = "TRFview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PiC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim MaG(), MaGs() As Double 'Los vectores con el módulo de la FFT de la señal
    Public Shared rgF(,) As Double 'Vector con el número complejo de la FFT

#Region "Eventos de la ventana que siempre se ejecutan"
    Private Sub TRFview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaG = Ventana.MaG.Clone 'se copia el vector magnitud de la transformada (escalado RAiz(N/sps))
        TrackBar1.Value = Form1.Fs
        If Me.Text.StartsWith("FLTR") Then
            'se está en modo de filtrado
            'hay que pedir los rangos de filtrado
            TextBox1.Text = Form1.Infbound
            TextBox2.Text = Form1.Supbound
            Button2.Focus()
            Button1.Visible = False
            Splitter1.Width = 127
            '  TrackBar1.Visible = False
            RadioButton7.Visible = False
            RadioButton6.Visible = False
            RadioButton5.Visible = False
        ElseIf Me.Text.StartsWith("FFT") Then
            MaGs = MaG.Clone
            'se está en modo de solo mostrar el espectro
            Splitter1.Width = 0
            Button2.Visible = False
            Button3.Visible = False
        End If
    End Sub

    Private Sub PiC_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PiC.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim i As Int16 = BTpositiv.ImageIndex
        If Me.Text.StartsWith("FLTR") Then
            'se está en modo de filtrado
            'hay que pedir los rangos de filtrado
            If i = 0 Then ' se muestra todo el espectro
                DrawFourier(e.Graphics, PiC, MaG, Color.YellowGreen, True, False)
            Else 'solo parte positiva
                DrawFourier(e.Graphics, PiC, MaG, Color.YellowGreen, True, True)
            End If
        ElseIf Me.Text.StartsWith("FFT") Then
            'se está en modo de solo mostrar el espectro
            If i = 0 Then ' se muestra todo el espectro
                DrawFourier(e.Graphics, PiC, MaGs, Color.YellowGreen, True, False)
            Else 'solo parte positiva
                DrawFourier(e.Graphics, PiC, MaGs, Color.YellowGreen, True, True)
            End If
        End If

    End Sub

    Private Sub PiC_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PiC.Resize
        PiC.Update()
    End Sub

    Private Sub PiC_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PiC.MouseMove
        Dim i As Int16 = BTpositiv.ImageIndex
        'hace falta escalar el espectro, para las frecuencias va: ... , 2Df , Df , 0 , Df , 2Df , ...   siendo Df = 1/Ts = 1/N Dt 
        'Dt es 1/sps es el factor de escala por el que se multiplican las frecuencias para ajustarlas a valores reales. Salen normalizadas de el algoritmo.

        If i = 0 Then ' muestra  todo el espectro
            La.Text = ""  'Cuando se muestra todo el espectro no se muestran los valores
        Else 'la parte positiva del espectro
            Try
                If Me.Text.StartsWith("FLTR") Then
                    'se está en modo de filtrado
                    La.Text = "f: " & (CInt((e.X * ((MaG.Length) - 1) / 2) / (PiC.Width - 1))) * _
                                   (2 * Form1.SPS / (MaG.Length - 1) ^ 2) * ((MaG.Length - 1) / 2) & "   a: " & _
                                  (MaG(CInt((e.X * ((MaG.Length) - 1) / 2) / (PiC.Width - 1))))


                ElseIf Me.Text.StartsWith("FFT") Then
                    'se está en modo de solo mostrar el espectro
                    La.Text = "f: " & (CInt((e.X * ((MaGs.Length) - 1) / 2) / (PiC.Width - 1))) * _
                                   (2 * Form1.SPS / (MaGs.Length - 1) ^ 2) * ((MaGs.Length - 1) / 2) & "   a: " & _
                                  (MaGs(CInt((e.X * ((MaGs.Length) - 1) / 2) / (PiC.Width - 1))))
                End If
            Catch ex As Exception
                La.Text = "Dibujando ... "
            End Try
        End If
    End Sub

    Private Sub RadioButton_Suav_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click, RadioButton5.Click, RadioButton6.Click, RadioButton7.Click
        'coontrola la presencia de la barra deslizable donde se indican los valores para el suavizado
        MaGs = MaG.Clone
        If RadioButton7.Checked = True Then
            TrackBar1.Visible = False
            
        Else
            TrackBar1.Visible = True
            Form1.Fs = TrackBar1.Value

        End If
        suavizar()
        PiC.Refresh()
    End Sub


#End Region

#Region "funciones complementarias "
    Private Sub BTpositiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTpositiv.Click
        'Mostrar el espectro completo o solo la parte positiva
        Dim i As Int16 = BTpositiv.ImageIndex
        If i = 0 Then
            BTpositiv.ImageIndex = 3 'que solo se vea la parte positiva
        Else
            BTpositiv.ImageIndex = 0 'que se vea todo
        End If
        PiC.Refresh()
    End Sub

    Private Sub TrackBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseUp
        ToolTip1.SetToolTip(TrackBar1, "Fs= " & TrackBar1.Value & vbNewLine & "Factor de suavizado")
        If Me.Text.StartsWith("FFT") Then
            'se está en modo de solo mostrar el espectro
            Form1.Fs = TrackBar1.Value 'Se asigna el valor del suavizado al algoritmo
            suavizar()
            PiC.Refresh()
        End If
    End Sub

    Private Sub TRFview_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim form As Form
        For Each form In Me.OwnedForms
            form.Dispose()
        Next
        If Me.IsMdiChild = True Then
            e.Cancel = True
            Me.Visible = False
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub PasaBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Text = "0"
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox2.Focus()
    End Sub

    Private Sub PasaBanda_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub PasaAlta_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Text = "0"
        TextBox2.Enabled = False
        TextBox1.Focus()
    End Sub

    Public Function Solonum(ByVal Key As String) As Boolean
        'Función para que el usuario solo pueda ingresar números
        If (Key >= 48 And Key <= 57) Or Key = 8 Or Key = 46 Then
            Solonum = False
        Else
            Solonum = True
        End If
    End Function

    Private Sub TB_KyPrsS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        e.Handled = Solonum(Asc(e.KeyChar))
    End Sub

    Private Sub Guardar_Espectro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Se guarda el espectro en un archivo
        'el formato del archivo es asccii de dos columnas separadas por un espacio en la primera la frecuencia
        'y en la segunda la aceleración, la extensión será .txt
        'En la primera línea se guardará el nombre del archivo que aparece en la barra de título de ésta ventana


        SFD.FileName = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1) & ".txt"
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        ElseIf SFD.FileName = "" Then
            Exit Sub
        End If
        Dim Df As Single = 0

        Dim MaGg() As Double
       
        'guardar:
        ReDim MaGg(0) 'Se pasa el vector con la magnitud al vector que se va a grabar en el archivo
        If Me.Text.StartsWith("FLTR") Then
            'se está en modo de filtrado
            MaGg = MaG.Clone
        ElseIf Me.Text.StartsWith("FFT") Then
            'se está en modo de solo mostrar el espectro
            MaGg = MaGs.Clone
        Else
            MessageBox.Show("Error en TRFview, Guardar_Espectro_click")
        End If
        Dim sw As New StreamWriter(SFD.FileName)
        Dim z As Single
        Df = 0
        For z = 0 To MaGg.Length / 2 - 1  'Se escribe el archivo, garantizando el tamaño uniforme de las columnas
            Df = Df + (Form1.SPS / (MaGg.Length))
            If MaGg(z) < 0 Then
                sw.WriteLine(Format(Df / 1, "#.00000000000") & " " & Format(CStr(MaGg(z)) / 1, "#.0000000000000").Substring(0, 12))
            Else
                sw.WriteLine(Format(Df / 1, "#.00000000000") & "  " & Format(CStr(MaGg(z)) / 1, "#.0000000000000").Substring(0, 11))
            End If
        Next
        sw.Flush()
        sw.Close()
    End Sub

    Private Sub suavizar()
        Dim Df As Single = 0

        MaGs = MaG.Clone
        Dim i As Double
        If RadioButton7.Checked = True Then
            'no se suaviza, es la opción predefinida

        ElseIf RadioButton6.Checked = True Then
            'promedio cadratico de cada punto con sus vecinos
            Dim aux(), f1, f2 As Double
            aux = MaGs.Clone
            f1 = 0
            For i = 1 To MaGs.Length - 2
                f1 = i - Form1.Fs
                f2 = i + Form1.Fs
                Dim suma, k, Ene As Single
                If f1 <= 0 Then
                    f1 = 0
                End If
                If f2 >= aux.Length - 1 Then
                    f2 = aux.Length - 1
                End If
                suma = 0
                Ene = 0
                For k = f1 To f2
                    suma = suma + aux(k) ^ 2
                    Ene += 1
                Next
                MaGs(i) = Math.Sqrt(suma / (Ene))
            Next
        ElseIf RadioButton5.Checked = True Then
            La.Text = "Suavizando ..."
            'El mismo suavizado utilizado en Degtra
            'NOTA: LA VENTANA SE HACE MAS GRANDE ENTRE MAYÓR ES LA FRECUENCIA, POR ENDE LAS FRECUENCIAS ALTAS SE ALIZAN EN EXCESO.
            ' suavizado de la magnitud del espectro de frecuencia  
            'La amplitud suavizada para la frecuencia f: As(f)
            '               1   f2                                 f2= f * 2^(1/(2 Fs)) 
            '    [As(f)]= ( -  E [ A(f)]^2 )^0.5
            '               N   f1                                 f1= f * 2^(-1/(2 Fs))
            'N es el número de puntos comprendidos enre f1 y f2; E [] denota una suma desde f1 hata f2
            Dim Fs As Single = Form1.Fs
            Dim aux() As Double
            aux = MaGs.Clone
            Dim tamaño As Single = MaGs.Length
            'el máximo en frecuencia es:
            Dim maxf As Single = CInt(tamaño / 2) * Form1.SPS / tamaño
            ' Df = (Form1.SPS / (MaG.Length))    'Hz
            For i = 1 To MaGs.Length - 2
                Dim f1, f2 As Double
                ' On Error Resume Next
                ' Df = Df + (Form1.SPS / (MaGg.Length))   'Hz
                If i < MaG.Length / 2 - 1 Then
                    Df = Df + (Form1.SPS / (MaG.Length))   'Hz
                ElseIf i = MaG.Length / 2 - 1 Then
                    Df = Df  'Hz
                Else
                    Df = Df - (Form1.SPS / (MaG.Length))   'Hz
                End If
                ''de puntos a Hertz
                f1 = Df * 2 ^ (-1 / (2 * Fs)) 'Hz
                f2 = Df * 2 ^ (1 / (2 * Fs)) 'Hz
                'de Hz a puntos
                f1 = f1 * tamaño / (2 * maxf)
                f2 = f2 * tamaño / (2 * maxf)
                f1 = CInt(f1) 'puntos
                f2 = CInt(f2) 'puntos
                If f1 <> f2 Then
                    Beep()
                End If
                Dim suma, k, Ene As Single
                If f1 <= 0 Then
                    f1 = 0
                End If
                If f2 >= aux.Length - 1 Then
                    f2 = aux.Length - 1
                End If
                suma = 0
                Ene = 0
                For k = f1 To f2
                    suma = suma + aux(k) ^ 2
                    Ene += 1
                Next
                MaGs(i) = Math.Sqrt(suma / (Ene))
            Next
        End If
        La.Text = ""
    End Sub
#End Region

    Private Sub Button_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        La.Text = ""
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = "0"
        End If

        Dim inff, supp, i, Fmin, Fmax, f As Single
        Dim tamaño As Single = rgF.Length / 2  'tamaño de todo el espectro (incluye conjugado)
        'el máximo en frecuencia es:
        Dim maxf As Single
        maxf = CInt(tamaño / 2) * Form1.SPS / tamaño
        If RadioButton1.Checked = True Then
            'pasa baja
            supp = CSng(TextBox2.Text)
            If supp > maxf Then
                La.Text = "Valor demasiado grande"
                GoTo otravez
            End If
            Fmax = supp
            'cambiar de Hertz a puntos.
            supp = CInt(supp * tamaño / (2 * maxf))
            'para hacer el filtrado se multiplica la transformada original X(w) por H(w) que es el filtro,
            'la operación se hace hasta la frecuencia Fmax
            '            1
            ' H(f)=----------------                 donde N es el número de polos: Form1.npol
            '               f
            '  Raiz( 1+(---------)^2N)
            '             Fmax
            'todo de un jalón
            For i = 0 To tamaño - 1
                f = i * 2 * maxf / tamaño
                rgF(i, 0) = rgF(i, 0) / Math.Sqrt(1 + (f / Fmax) ^ (2 * Form1.Npol))
                rgF(i, 1) = rgF(i, 1) / Math.Sqrt(1 + (f / Fmax) ^ (2 * Form1.Npol))
            Next

        ElseIf RadioButton2.Checked = True Then
            'en pasabanda:
            inff = Math.Min(CSng(TextBox1.Text), CSng(TextBox2.Text))
            supp = Math.Max(CSng(TextBox1.Text), CSng(TextBox2.Text))
            If supp > maxf Then
                La.Text = "Valor demasiado grande"
                GoTo otravez
            End If

            Fmin = inff
            Fmax = supp
            'cambiar de Hertz a puntos.
            supp = CInt(supp * tamaño / (2 * maxf))
            inff = CInt(inff * tamaño / (2 * maxf))

            'para hacer el filtrado se multiplica la transformada original X(w) por H(w) que es el filtro,
            'la operación se hace entre las frecuencias Fmin y Fmax
            '            1
            ' H(f)=----------------                 donde N es el número de polos: Form1.npol
            '           f^2 - Fmin Fmax
            '  Raiz( 1+(---------------)^2N)
            '             f (Fmax-Fmin)
            'todo de un jalón
            For i = 0 To tamaño - 1
                'If i <= tamaño / 2 Then
                f = i * 2 * maxf / tamaño
                'Else
                '    f = maxf - (i - (tamaño - 1) / 2) * 2 * maxf / tamaño
                'End If
                rgF(i, 0) = rgF(i, 0) / Math.Sqrt(1 + ((f ^ 2 - Fmin * Fmax) / (f * (Fmax - Fmin))) ^ (2 * Form1.Npol))
                rgF(i, 1) = rgF(i, 1) / Math.Sqrt(1 + ((f ^ 2 - Fmin * Fmax) / (f * (Fmax - Fmin))) ^ (2 * Form1.Npol))
            Next

        ElseIf RadioButton3.Checked = True Then
            'pasa alta
            inff = CSng(TextBox1.Text)
            If inff > maxf Then
                La.Text = "Valor demasiado grande"
                GoTo otravez
            End If
            Fmin = inff
            'cambiar de Hertz a puntos
            inff = CInt(inff * tamaño / (2 * maxf))

            'para hacer el filtrado se multiplica la transformada original X(w) por H(w) que es el filtro,
            'la operación se hace desde la frecuencia Fmin
            '            1
            ' H(f)=----------------                 donde N es el número de polos: Form1.npol
            '            Fmin
            '  Raiz( 1+(------)^2N)
            '             f
            'todo de un jalón
            For i = 0 To tamaño - 1
                f = i * 2 * maxf / tamaño
                rgF(i, 0) = rgF(i, 0) / Math.Sqrt(1 + (Fmin / f) ^ (2 * Form1.Npol))
                rgF(i, 1) = rgF(i, 1) / Math.Sqrt(1 + (Fmin / f) ^ (2 * Form1.Npol))
            Next
        End If
        Form1.Infbound = CSng(TextBox1.Text)
        Form1.Supbound = CSng(TextBox2.Text)
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Exit Sub
otravez:
        If La.Text = "Valor demasiado grande" Then
            'Es decir que el índice la frecuencia indicada no se encuentra en el espectro,
            'pues la máxima frecuencia depende de la velocidad de muestreo SPS, en un factor 2 a 1
            '200sps : máximo 100Hz Téngase en cuenta que varios autores recomiendan que se utilice
            'con hasta el 60% del espectro, en este caso 60Hz. La razón es la pérdida de presicíon.
            If TextBox1.Enabled = True Then
                TextBox1.SelectAll()
            Else
                TextBox2.SelectAll()
            End If
        End If
    End Sub
End Class
