Imports System.IO
Imports Editor_de_Registros_Sísmicos.ClassDibujo
Public Class Transf
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BTtransf As System.Windows.Forms.Button
    Friend WithEvents BTguardar As System.Windows.Forms.Button
    Friend WithEvents ST As System.Windows.Forms.StatusBar
    Friend WithEvents PIC As System.Windows.Forms.PictureBox
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents ckLOG As System.Windows.Forms.CheckBox
    Friend WithEvents ckCONJ As System.Windows.Forms.CheckBox
    Friend WithEvents LA As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB As System.Windows.Forms.TextBox
    Friend WithEvents BTcopy As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents TT As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Amort1 As System.Windows.Forms.RadioButton
    Friend WithEvents Amort2 As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Transf))
        Me.PIC = New System.Windows.Forms.PictureBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.BTtransf = New System.Windows.Forms.Button
        Me.BTguardar = New System.Windows.Forms.Button
        Me.ST = New System.Windows.Forms.StatusBar
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.ckLOG = New System.Windows.Forms.CheckBox
        Me.ckCONJ = New System.Windows.Forms.CheckBox
        Me.LA = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TB = New System.Windows.Forms.TextBox
        Me.BTcopy = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Amort2 = New System.Windows.Forms.RadioButton
        Me.Amort1 = New System.Windows.Forms.RadioButton
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIC
        '
        Me.PIC.BackColor = System.Drawing.Color.Black
        Me.PIC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PIC.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIC.Location = New System.Drawing.Point(0, 0)
        Me.PIC.Name = "PIC"
        Me.PIC.Size = New System.Drawing.Size(895, 416)
        Me.PIC.TabIndex = 0
        Me.PIC.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox1.Location = New System.Drawing.Point(8, 424)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(688, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "numerador:  (Salida)"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.ComboBox2.Location = New System.Drawing.Point(8, 451)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(688, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.Text = "denominador: (Entrada)"
        '
        'BTtransf
        '
        Me.BTtransf.BackColor = System.Drawing.SystemColors.Control
        Me.BTtransf.Image = CType(resources.GetObject("BTtransf.Image"), System.Drawing.Image)
        Me.BTtransf.Location = New System.Drawing.Point(696, 424)
        Me.BTtransf.Name = "BTtransf"
        Me.BTtransf.Size = New System.Drawing.Size(56, 48)
        Me.BTtransf.TabIndex = 3
        Me.TT.SetToolTip(Me.BTtransf, "Calcular la función de transferencia entre los seleccionados")
        '
        'BTguardar
        '
        Me.BTguardar.BackColor = System.Drawing.SystemColors.Control
        Me.BTguardar.Location = New System.Drawing.Point(4, 521)
        Me.BTguardar.Name = "BTguardar"
        Me.BTguardar.Size = New System.Drawing.Size(108, 29)
        Me.BTguardar.TabIndex = 4
        Me.BTguardar.Text = "Guardar Función de Transferencia"
        '
        'ST
        '
        Me.ST.Location = New System.Drawing.Point(0, 555)
        Me.ST.Name = "ST"
        Me.ST.Size = New System.Drawing.Size(895, 22)
        Me.ST.TabIndex = 5
        '
        'SFD
        '
        Me.SFD.DefaultExt = "txt"
        Me.SFD.Title = "Guardar función de transferencia"
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.TrackBar1.Location = New System.Drawing.Point(754, 416)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(140, 33)
        Me.TrackBar1.TabIndex = 6
        Me.TT.SetToolTip(Me.TrackBar1, "Valor Fs del suavizado de la magnitud espectral")
        '
        'ckLOG
        '
        Me.ckLOG.Location = New System.Drawing.Point(8, 475)
        Me.ckLOG.Name = "ckLOG"
        Me.ckLOG.Size = New System.Drawing.Size(128, 24)
        Me.ckLOG.TabIndex = 7
        Me.ckLOG.Text = "Vertical logarítmico"
        '
        'ckCONJ
        '
        Me.ckCONJ.Location = New System.Drawing.Point(8, 496)
        Me.ckCONJ.Name = "ckCONJ"
        Me.ckCONJ.Size = New System.Drawing.Size(128, 24)
        Me.ckCONJ.TabIndex = 8
        Me.ckCONJ.Text = "Mostrar conjugado"
        '
        'LA
        '
        Me.LA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LA.BackColor = System.Drawing.Color.Black
        Me.LA.ForeColor = System.Drawing.Color.LightGray
        Me.LA.Location = New System.Drawing.Point(571, 0)
        Me.LA.Name = "LA"
        Me.LA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LA.Size = New System.Drawing.Size(323, 23)
        Me.LA.TabIndex = 9
        Me.LA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(136, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 25)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Zoom y Amortiguamiento"
        '
        'TB
        '
        Me.TB.Location = New System.Drawing.Point(326, 484)
        Me.TB.Multiline = True
        Me.TB.Name = "TB"
        Me.TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB.Size = New System.Drawing.Size(564, 66)
        Me.TB.TabIndex = 11
        Me.TB.Text = ""
        '
        'BTcopy
        '
        Me.BTcopy.Image = CType(resources.GetObject("BTcopy.Image"), System.Drawing.Image)
        Me.BTcopy.Location = New System.Drawing.Point(829, 489)
        Me.BTcopy.Name = "BTcopy"
        Me.BTcopy.Size = New System.Drawing.Size(39, 38)
        Me.BTcopy.TabIndex = 12
        Me.TT.SetToolTip(Me.BTcopy, "Copiar al portapapeles las frecuencias y amortiguamientos identificados")
        Me.BTcopy.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(754, 452)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(30, 24)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.Text = "0"
        Me.TT.SetToolTip(Me.RadioButton1, "Sin suavizado")
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(783, 452)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(30, 24)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1"
        Me.TT.SetToolTip(Me.RadioButton2, "Suavizado con una ventana rectangular de tamaño fijo y media cuadrática para cada" & _
        " elemento y su vecindad")
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(812, 452)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(30, 24)
        Me.RadioButton3.TabIndex = 15
        Me.RadioButton3.Text = "2"
        Me.TT.SetToolTip(Me.RadioButton3, "Suavizado con tamaño de ventana en función de la frecuencia y media cuadrática pa" & _
        "ra el punto y su vecindad. (castiga las frecuencias altas). Toma algo de tiempo")
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(841, 452)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(30, 24)
        Me.RadioButton4.TabIndex = 16
        Me.RadioButton4.Text = "3"
        Me.TT.SetToolTip(Me.RadioButton4, "Suavizado 1 y luego suavizado 2")
        Me.RadioButton4.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(846, 453)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(34, 21)
        Me.NumericUpDown1.TabIndex = 20
        Me.TT.SetToolTip(Me.NumericUpDown1, "Cantidad de veces que se ejecuta el suavizado seleccionado")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Amort2)
        Me.GroupBox1.Controls.Add(Me.Amort1)
        Me.GroupBox1.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(283, 480)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(39, 66)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "x"
        '
        'Amort2
        '
        Me.Amort2.Enabled = False
        Me.Amort2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amort2.Location = New System.Drawing.Point(6, 39)
        Me.Amort2.Name = "Amort2"
        Me.Amort2.Size = New System.Drawing.Size(29, 24)
        Me.Amort2.TabIndex = 1
        Me.Amort2.Text = "2"
        '
        'Amort1
        '
        Me.Amort1.Checked = True
        Me.Amort1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amort1.Location = New System.Drawing.Point(6, 16)
        Me.Amort1.Name = "Amort1"
        Me.Amort1.Size = New System.Drawing.Size(29, 24)
        Me.Amort1.TabIndex = 0
        Me.Amort1.TabStop = True
        Me.Amort1.Text = "1"
        '
        'Transf
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(895, 577)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.BTguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTcopy)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.TB)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LA)
        Me.Controls.Add(Me.ckCONJ)
        Me.Controls.Add(Me.ckLOG)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ST)
        Me.Controls.Add(Me.BTtransf)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PIC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Función de transferencia"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"
    Dim ftransfMAG(,), ftransfMAGtaper(,) As Double
    Dim bugger As New bugger
    Public Shared handleDAMPING As Boolean = False
    Public Shared T1, T2 As Integer
    Public Shared max(0), dmp(0) As Double  'los índice de los máximos en el espectro en puntos y los respectivos amortiguamientos convencionales
    Dim Tx As Integer
    Dim calculado As Boolean = False
#End Region


#Region "Eventos de objeto"
    Private Sub Transf_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TrackBar1.Value = Form1.Fs
        max(0) = -1
        handleDAMPING = False
        T1 = 0
        T2 = 0
        Tx = 0

    End Sub

    Private Sub actualiza_la_lista(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Amort1.Checked = True Then
            If max(0) = -1 Then
                TB.Text = ""
                BTcopy.Visible = False
                Exit Sub
            End If
            lista("Frecuencias_periodos_y_amortiguamientos_identificadas_en_la_función_de_transferencia", dmp)
            BTcopy.Visible = True
        End If
    End Sub

    Private Sub BTtransf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTtransf.Click
        handleDAMPING = False
        T1 = 0
        T2 = 0
        Tx = 0
        calculado = False
        Button1.FlatStyle = FlatStyle.Standard
        handleDAMPING = False
        ST.Text = ""
        ckCONJ.Enabled = True
        Amort2.Enabled = False
        ReDim max(0)
        max(0) = -1
        ReDim dmp(0)

        TB.Text = ""
        BTcopy.Visible = False
        'se calcula el espectro real y compleja del numerador y del denominador, luego se hace la división.
        Dim num(,), den(,), i, numMAG(), denMAG() As Double
        If ComboBox1.SelectedItem Is Nothing Or ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Primero es necesario seleccionar un registro como numerador y otro como denominador", "ups", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        num = espectro(ComboBox1.SelectedItem) 'real (#,0) e imaginario (#,1)
        den = espectro(ComboBox2.SelectedItem)
        ST.Text = "Calculando y Suavizando la magnitud espectral"
        numMAG = magnitud(num)
        denMAG = magnitud(den)

        'esc(numMAG, "numMAG")
        'esc(numDEG,"numDEG")
        ST.Text = "Calculando la función de transferencia"

        ReDim ftransfMAG(denMAG.Length - 1, 1)
        ftransfMAG(0, 0) = 0
        ftransfMAG(0, 1) = numMAG(0) / denMAG(0)
        If Double.IsNaN(ftransfMAG(0, 1)) Then
            ftransfMAG(0, 1) = 0
        End If
        'para el Delta f
        Dim df As Double

        For i = 0 To ftransfMAG.Length / 2 - 1
            df = df + Form1.SPS / ((ftransfMAG.Length / 2))
            ftransfMAG(i, 0) = df
            ftransfMAG(i, 1) = numMAG(i) / denMAG(i)

            If Double.IsNaN(ftransfMAG(i, 1)) Then
                ftransfMAG(i, 1) = 0
            End If
        Next
        ST.Text = "Dibujando ... "
        Me.Text = "Función de transferencia " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1) & " / " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1)
        PIC.Refresh()
        ST.Text = ""

    End Sub

    Private Sub BTguardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTguardar.Click
inicio:

        SFD.FileName = "Ftransf " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_") & " a " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_")
        If SFD.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        If SFD.FileName <> "" And Not ftransfMAG Is Nothing Then
            Dim sw As New StreamWriter(SFD.FileName)
            Dim i As Double

            For i = 0 To ftransfMAG.Length / 4 - 1
                sw.Write(ftransfMAG(i, 0).ToString & " " & ftransfMAG(i, 1).ToString & vbNewLine)
            Next
            sw.Flush()
            sw.Close()
        Else
            If ftransfMAG Is Nothing Then
                MessageBox.Show("No hay función de transferencia que guardar", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If SFD.FileName = "" Then
                If MessageBox.Show("Debe asignar un nombre de archivo válido", "Ups", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                    GoTo inicio
                End If
            End If
        End If
    End Sub

    Private Sub Zoom_y_Amortiguamiento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'encontrar picos en la vecindad del click y con ésto el amortiguamiento
        If handleDAMPING = False Then
            ST.Text = "Seleccionar la región a revisar en Zoom en busca de una frecuencia interesante (máximo local) y de su amortiguamiento"
            Button1.FlatStyle = FlatStyle.Popup
            ckCONJ.Checked = False
            ckCONJ.Enabled = False
            handleDAMPING = True
            Amort2.Enabled = False
        Else
            Button1.FlatStyle = FlatStyle.Standard
            handleDAMPING = False
            T1 = 0
            T2 = 0
            Tx = 0
            ST.Text = ""
            ckCONJ.Enabled = True
            Amort2.Enabled = True
        End If
    End Sub

    Private Sub BTcopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTcopy.Click
        Clipboard.SetDataObject(TB.Text, True)
    End Sub


    '    Private Sub BTajustar_Click()
    '        'amortiguamiento estimado a partir de funcines de transferencia que proponen Ricardo Taborda Ríos y Mario Ordaz Schroeder en el XIV Congreso Nacional de Ingeniería Sísmica en León, Guanajuato. Artículo VI-03

    '        'De antemano ya se tienen las propuestas de amortiguamiento por el método anteriór y por ende los picos de la función de transferencia en determinadas frecuencias.

    '        ' se van a recorrer todos los modos identificados en el espectro 
    '        'ftransfMAG(max(i), 0)  : la frecuencia en Hertz de el pico
    '        'ftransfMAG(max(i), 1)  : la magnitud de la f transf en ese punto de espectro se usa como factor de participación
    '        Dim maxS(), dmpS() As Double
    '        Dim i, j As Int16
    '        maxS = max.Clone
    '        dmpS = dmp.Clone

    '        For i = 0 To dmpS.Length - 1
    '            dmpS(i) = dmp(i)     'se parte de la hipótesis (falsa de toda fdd) de que el amortiguamiento es el doble del inicialmente estimado. 
    '        Next

    '        'dmpS(dmpS.Length - 1) = 1

    '        Dim A, B, C, D, Ee, F, g(maxS.Length - 1) As Double
    '        Dim suma_de_mod As Double

    '        Dim recuerdo, delta As Double
    '        delta = 0.0001

    '        'los factores de participación modal
    '        For i = 0 To maxS.Length - 1
    '            suma_de_mod = suma_de_mod + ftransfMAG(maxS(i), 1)
    '        Next
    '        For i = 0 To maxS.Length - 1
    '            g(i) = ftransfMAG(maxS(i), 1) / suma_de_mod
    '            'g(i) = 1
    '        Next



    '        For i = 0 To maxS.Length - 2 'para todos los máximos menos el 'último porque si no la fórmulas no funcionan
    '            'Paso 1 se propne un valor para el amortiguamiento en cuestión. dmpS(i) en los puntos max(i)

    '            recuerdo = Double.MinValue
    'inicio:
    '            A = 0
    '            B = 0
    '            'Paso 2
    '            'suma de A
    '            For j = 0 To i
    '                'If i <> 0 Then
    '                A = A + ((ftransfMAG(maxS(i), 0) ^ 2 * g(j) * (ftransfMAG(maxS(j), 0) ^ 2 - ftransfMAG(maxS(i), 0) ^ 2)) / ((ftransfMAG(maxS(j), 0) ^ 2 - ftransfMAG(maxS(i), 0) ^ 2) ^ 2 + (2 * dmpS(j) * ftransfMAG(maxS(j), 0) * ftransfMAG(maxS(i), 0)) ^ 2))
    '                'Else
    '                '    A = 0
    '                'End If
    '            Next

    '            'suma de B
    '            For j = 0 To i
    '                'If i <> 0 Then
    '                B = B + ((-2 * dmpS(j) * ftransfMAG(maxS(j), 0) * ftransfMAG(maxS(i), 0) ^ 3 * g(j)) / ((ftransfMAG(maxS(j), 0) ^ 2 - ftransfMAG(maxS(i), 0) ^ 2) ^ 2 + (2 * dmpS(j) * ftransfMAG(maxS(j), 0) * ftransfMAG(maxS(i), 0)) ^ 2))
    '                'Else
    '                '    B = 0
    '                'End If
    '            Next

    '            'C
    '            C = ftransfMAG(maxS(i), 0) ^ 2 * g(i + 1) * (ftransfMAG(maxS(i + 1), 0) ^ 2 - ftransfMAG(maxS(i), 0) ^ 2)

    '            'D
    '            D = -2 * ftransfMAG(maxS(i + 1), 0) * ftransfMAG(maxS(i), 0) ^ 3 * g(i + 1)

    '            'E
    '            Ee = (ftransfMAG(maxS(i + 1), 0) ^ 2 - ftransfMAG(maxS(i), 0) ^ 2) ^ 2

    '            'F
    '            F = (2 * ftransfMAG(maxS(i + 1), 0) * ftransfMAG(maxS(i), 0)) ^ 2


    '            Dim error0, error1 As Double
    '            'error0 = (1 + A + (C / (Ee + F * dmpS(i + 1) ^ 2))) ^ 2 + _
    '            '((-g(i) / (2 * dmpS(i))) + B + ((-D * dmpS(i + 1)) / (Ee + F * dmpS(i + 1) ^ 2))) ^ 2 - _
    '            '(ftransfMAG(maxS(i), 1) ^ 2)

    '            'Paso 3   dmps(i+1)=0

    '            error0 = (1 + A + (C / (Ee))) ^ 2 + _
    '            ((-g(i) / (2 * dmpS(i))) + B) ^ 2 - _
    '            (ftransfMAG(maxS(i), 1) ^ 2)

    '            'Paso 4 dmps(i+1)=1

    '            error1 = (1 + A + (C / (Ee + F))) ^ 2 + _
    '            ((-g(i) / (2 * dmpS(i))) + B + ((-D) / (Ee + F))) ^ 2 - _
    '            (ftransfMAG(maxS(i), 1) ^ 2)

    '            'Paso 5
    '            If error0 * error1 > 0 Or Math.Max(error0, error1) >= 0 Then
    '                If error0 < recuerdo Then
    '                    'quiere decir que ya se pasó       'No tiene chiste iterar para ajustar valores de cienmilésimas
    '                    dmpS(i) = dmpS(i) - delta
    '                    GoTo siguiente
    '                End If
    '                dmpS(i) = dmpS(i) + delta

    '                recuerdo = error0
    '                'maxscount += 1
    '                GoTo inicio
    '            End If
    'siguiente:
    '        Next

    '        'ya se tienen los valores de dmps(i) ajustados
    '        lista("Frecuencias_identificadas_en_la_función_de_transferencia_y_amortiguamientos_ajustados", dmpS)
    '    End Sub
    Private Sub BTajustar_Click()
        'amortiguamiento estimado a partir de funcines de transferencia que proponen Ricardo Taborda Ríos y Mario Ordaz Schroeder en el XIV Congreso Nacional de Ingeniería Sísmica en León, Guanajuato. Artículo VI-03

        'De antemano ya se tienen las propuestas de amortiguamiento por el método anteriór y por ende los picos de la función de transferencia en determinadas frecuencias.

        ' se van a recorrer todos los modos identificados en el espectro 
        'ftransfMAG(max(i), 0)  : la frecuencia en Hertz de el pico
        'ftransfMAG(max(i), 1)  : la magnitud de la f transf en ese punto de espectro se usa como factor de participación
        Dim maxS(), dmpS() As Double
        Dim i As Int16
        maxS = max.Clone
        dmpS = dmp.Clone

        Dim g(maxS.Length - 1) As Double

        Dim recuerdo, delta As Double


        'los factores de participación modal normalizados respecto al último modo por identificarse

        Dim suma_de_mod As Double

        'los factores de participación modal
        For i = 0 To maxS.Length - 1
            suma_de_mod = suma_de_mod + ftransfMAG(maxS(i), 1)
        Next
        For i = 0 To maxS.Length - 1
            g(i) = ftransfMAG(maxS(i), 1) / suma_de_mod
        Next


        For i = 0 To maxS.Length - 2 'para todos los máximos menos el 'último porque si no la fórmulas no funcionan
            'Paso 1 se propne un valor para el amortiguamiento en cuestión. dmpS(i) en los puntos max(i)

            recuerdo = Double.MinValue
inicio:
            Dim error0, error1 As Double

            error0 = erri(i, ftransfMAG, maxS, dmpS, g, 0)
            error1 = erri(i, ftransfMAG, maxS, dmpS, g, 1)

            If error0 * error1 > 0 Then

                If recuerdo * error0 < 0 Then
                    GoTo siguiente
                End If

                If Math.Abs(error0) <= 5 Then
                    GoTo siguiente
                ElseIf Math.Abs(error0) > 100 Then
                    delta = 0.0001
                ElseIf Math.Abs(error0) <= 100 Then
                    delta = 0.00001
                ElseIf Math.Abs(error0) <= 10 Then
                    delta = 0.000001
                End If

                If Math.Min(error0, error1) >= 0 And delta > 0 Then
                    delta = delta * -1
                ElseIf Math.Max(error0, error1) <= 0 And delta < 0 Then
                    delta = Math.Abs(delta)
                End If

                dmpS(i) = dmpS(i) + delta
                recuerdo = error0
                'maxscount += 1
                GoTo inicio
            End If
siguiente:
            '   dmpS(i) = dmpS(i) - delta
            ST.Text = ST.Text & "* *" & erri(i, ftransfMAG, maxS, dmpS, g, 0).ToString & "   " & erri(i, ftransfMAG, maxS, dmpS, g, 1).ToString & vbNewLine
        Next

        'ya se tienen los valores de dmps(i) ajustados

        lista(ST.Text & vbNewLine & "Frecuencias_identificadas_en_la_función_de_transferencia_y_amortiguamientos_ajustados", dmpS)
        
    End Sub


    Private Sub Amort_i_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amort1.CheckedChanged, Amort2.CheckedChanged
        If Amort1.Checked = True Then
            'amortiguamiento clásico
            If dmp(0) <> 0 Then
                lista("Frecuencias_periodos_y_amortiguamientos_identificadas_en_la_función_de_transferencia", dmp)
            End If
        ElseIf Amort2.Checked = True And calculado = False Then
            'amortiguamiento ajustado
            'BTajustar.Enabled = True
            calculado = True
            BTajustar_Click()
            Exit Sub
        End If
    End Sub


#End Region

#Region "PIC"
    Private Sub PIC_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PIC.Paint
        If ftransfMAG Is Nothing Then
            Exit Sub
        End If
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        If checkBool(ckLOG) Then
            DrawTransflog(e.Graphics, PIC, ftransfMAG, Color.YellowGreen, True, checkBool(ckCONJ))
        Else
            DrawTransf(e.Graphics, PIC, ftransfMAG, Color.YellowGreen, True, checkBool(ckCONJ))
        End If
        If checkBool(ckCONJ) Then
            LA.Visible = False
        Else
            LA.Visible = True
        End If
    End Sub

    Private Sub ckCONJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckCONJ.Click, ckLOG.Click
        PIC.Refresh()
    End Sub

    Private Sub PIC_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PIC.MouseMove
        If ftransfMAG Is Nothing Then
            Exit Sub
        End If
        Tx = e.X * (ftransfMAG.Length / 4 - 1) / PIC.Width
        LA.Text = "w: " & Format(ftransfMAG(Tx, 0), "0.###E+0") & " Hz .: T= " & Format(1 / ftransfMAG(Tx, 0), "#.0000") & " s => |FT(w)|=" & Format(ftransfMAG(Tx, 1), "000.00")
    End Sub

    Private Sub PIC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PIC.Click
        Static ConT As Int16 = 0
        If handleDAMPING = True And Not ftransfMAG Is Nothing Then
            If ConT = 0 Then
                'el primer indice
                T1 = Tx
                ST.Text = "T1= " & T1.ToString
                ConT = 1
            ElseIf ConT = 1 Then
                If Tx <= T1 Then 'hacer el cambio, el t1 siempre será menor a t2
                    T2 = T1
                    T1 = Tx
                Else
                    T2 = Tx
                End If
                ST.Text = "T1= " & T1.ToString & "  T2= " & T2.ToString
                ConT = 2
                Dim zm As New Zm
                'ReDim zm.rgZ(T2 - T1 - 1, 1)
                'rg.Copy(rg, CLng(T1), zm.rgZ, 0, 2 * CLng(T2 - T1))
                zm.Owner = Me
                zm.rgZ = ftransfMAG.Clone
                zm.di = 1
                Dim ind As Short
                zm.StatusBarPanel1.Dispose()
                zm.StatusBarPanel2.Dispose()
                zm.StatusBarPanel3.Dispose()
                zm.MAX.Dispose()
                zm.MED.Dispose()
                zm.MIN.Dispose()
                zm.DIST.Dispose()
                zm.Te.Dispose()
                zm.Pico.Dispose()
                zm.t1 = T1
                zm.t2 = T2
                zm.Text = "[Zoom {" & T1.ToString & "," & T2.ToString & "}] N=" & CStr(zm.rgZ.Length / 2 - 1) & "  " & Me.Text
                PIC.Refresh()
                zm.ShowDialog()
                ST.Text = ""
                'y se prepara para el siguiente
                T1 = 0
                T2 = 0
                ConT = 0
            End If
        Else
            ST.Text = ""
            T1 = 0
            T2 = 0
            ConT = 0
        End If
        PIC.Refresh()
    End Sub

    Private Sub TrackBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseUp
        TT.SetToolTip(TrackBar1, TrackBar1.Value.ToString)
        Form1.Fs = TrackBar1.Value
        ST.Text = "Valor de Fs= " & TrackBar1.Value.ToString & " ... Recalcule para observar los cambios"
        'PIC.Refresh()
        BTtransf.Select()
    End Sub
#End Region

#Region "Funciones"
    <DebuggerStepThrough()> Function lista(ByVal t As String, ByVal d() As Double)
        Try
            TB.Text = t & vbNewLine & vbNewLine & ComboBox1.SelectedItem & vbNewLine & "-------------------------------" & vbNewLine & ComboBox2.SelectedItem & vbNewLine & vbNewLine
            Dim i As Int16
            For i = 0 To max.Length - 1
                If max(i) <> -1 Then
                    TB.Text = TB.Text & "w= " & Format(ftransfMAG(max(i), 0) / 1, "#.0000") & " Hz;  |FT(w)|= " & Format(ftransfMAG(max(i), 1) / 1, "#.00") & "    T: " & Format(1 / ftransfMAG(max(i), 0), "#.0000") & " s    xi: " & Format(d(i) * 100, "#.0000000") & "%" & vbNewLine
                End If
            Next
        Catch ex As Exception
            Err.Clear()
            TB.Text = ""
        End Try

    End Function

    Function espectro(ByVal ruta As String) As Double(,)
        Dim rg(,), Mag() As Double
        Dim reg As String
        ' se lee el registro
        Try
            Dim strdr As New StreamReader(ruta)
            reg = strdr.ReadToEnd()
            strdr.Close()
            ST.Text = "Leyendo archivo " & ruta
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Err.Clear()
            Me.Visible = False
            Exit Function
        End Try
        Dim i, j As Double
        If reg.StartsWith("N=") Then
            ST.Text = "Leyendo archivo Degtra ..."
            'es un archivo degtra con la primera línea N,Dt y T(Xini)
            reg = reg.Remove(0, 2)
            Dim N As Integer = CInt(reg.Substring(0, reg.IndexOf(" "))) 'se recupera el número de valores
            ReDim rg(N - 1, 1)
            reg = reg.Remove(0, reg.IndexOf("Delta=") + 6)
            ' ST.Text = reg.Substring(0, reg.IndexOf(" "))
            Form1.SPS = 1 / CDbl(reg.Substring(0, reg.IndexOf(" ")))   'se recupera el DeltaT .'. sps
            reg = reg.Remove(0, reg.IndexOf("Xini=") + 5)
            rg(0, 1) = CDbl(reg.Substring(0, reg.IndexOf(vbNewLine)))     'se recupera xini
            reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2) 'borra el primer renglón
            'ahora solo quedan los valores en cada renglón, así que se recuperan en el vector
            For i = 0 To N - 1
                rg(i, 0) = reg.Substring(0, reg.IndexOf(vbNewLine))
                reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2)
                Try
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Catch ex As Exception
                    Err.Clear()
                End Try
            Next
        Else
            ST.Text = "Leyendo archivo ascii de ancho de columna =12 fijo"
            'o si es en ascii: (Ejemplo: Recien descomprimido de un evt)
            reg = reg.Replace(vbNewLine, "")
            'el ancho de la columna es fijo=12 en el formado ascii
            ReDim rg((reg.Length) * 1 / (12 * Form1.diezmado) - 1, 1)
            'rg(i, 1) = 0
            For j = 0 To ((reg.Length - 1)) Step (12 * Form1.diezmado / 1)
                rg(i, 0) = reg.Substring(j, 12)
                Try
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Catch ex As Exception
                    Err.Clear()
                End Try
                i += 1
            Next
        End If
        ST.Text = "Calculando la FFT"
        ' cálculo de la transformada de fourier
        espectro = TransformadaRápidaDeFourier(rg)
    End Function

    Function magnitud(ByVal rgf(,) As Double) As Double()

        'magnitud
        Dim mag() As Double
        ReDim mag(rgf.Length / 8 - 1) '
        Dim i, j As Double
        For i = 0 To mag.Length - 1
            'mag(i) = (Math.Sqrt(rgf(j, 0) ^ 2 + rgf(j, 1) ^ 2) + Math.Sqrt(rgf(j + 1, 0) ^ 2 + rgf(j + 1, 1) ^ 2)) / (2 * Form1.SPS)
            'j += 2
            mag(i) = (Math.Sqrt(rgf(j, 0) ^ 2 + rgf(j, 1) ^ 2) + Math.Sqrt(rgf(j + 1, 0) ^ 2 + rgf(j + 1, 1) ^ 2) + Math.Sqrt(rgf(j + 2, 0) ^ 2 + rgf(j + 2, 1) ^ 2) + Math.Sqrt(rgf(j + 3, 0) ^ 2 + rgf(j + 3, 1) ^ 2)) / (8 * Form1.SPS)
            j += 4
        Next
        If RadioButton1.Checked = True Then
            'no se suaviza

        ElseIf RadioButton2.Checked = True Then
            Dim s As Int16
            For s = 1 To NumericUpDown1.Value

                'promedio cadratico de cada punto con sus vecinos
                Dim aux(), f1, f2 As Double
                aux = mag.Clone
                f1 = 0
                For i = 1 To mag.Length - 2
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
                    mag(i) = Math.Sqrt(suma / (Ene))
                Next
            Next
        ElseIf RadioButton3.Checked = True Then
            Dim s As Int16
            For s = 1 To NumericUpDown1.Value


                'Evangelio según Degtra, Suavizado 3:23 Archivo de ayuda
                'LA VENTANA SE HACE MAS GRANDE ENTRE MAYÓR ES LA FRECUENCIA, POR ENDE LAS FRECUENCIAS ALTAS SE ALIZAN EN EXCESO.
                ' suavizado de la magnitud del espectro de frecuencia  
                'La amplitud suavizada para la frecuencia f, As(f)
                '               1   f2                                 f2= f * 2^(1/(2 Fs)) 
                '    [As(f)]= ( -  E [ A(f)]^2 )^0.5
                '               N   f1                                 f1= f * 2^(-1/(2 Fs))
                'N es el número de puntos comprendidos enre f1 y f2
suavizado2:
                Dim Fs As Single = Form1.Fs '* 2
                Dim aux(), Df As Double
                aux = mag.Clone
                Dim tamaño As Single = mag.Length
                'el máximo en frecuencia es:
                Dim maxf As Single = CInt(tamaño / 2) * Form1.SPS / tamaño

                For i = 1 To mag.Length - 2
                    Dim f1, f2 As Double
                    ' On Error Resume Next
                    If i < mag.Length / 2 - 1 Then
                        Df = Df + (Form1.SPS / (mag.Length))   'Hz
                    ElseIf i = mag.Length / 2 - 1 Then
                        Df = Df  'Hz
                    Else
                        Df = Df - (Form1.SPS / (mag.Length))   'Hz
                    End If
                    ''de puntos a Hertz
                    f1 = Df * 2 ^ (-1 / (2 * Fs)) '[Hz]
                    f2 = Df * 2 ^ (1 / (2 * Fs)) '[Hz]
                    'de Hz a puntos
                    f1 = f1 * tamaño / (2 * maxf)
                    f2 = f2 * tamaño / (2 * maxf)
                    f1 = CInt(f1) '[puntos]
                    f2 = CInt(f2) '[puntos]
                    'If f1 <> f2 Then
                    '    Beep()
                    'End If
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
                    mag(i) = Math.Sqrt(suma / (Ene))
                Next
            Next
            magnitud = mag.Clone
            Exit Function
        ElseIf RadioButton4.Checked = True Then
            'Una super convinación entre el suavizado 1 y el 2
            Dim s As Int16
            For s = 0 To 2
                Dim aux(), f1, f2 As Double
                aux = mag.Clone
                f1 = 0
                For i = 1 To mag.Length - 2
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
                    mag(i) = Math.Sqrt(suma / (Ene))
                Next
            Next

            'GoTo suavizado2
        End If
        magnitud = mag.Clone
    End Function

    Function TransformadaRápidaDeFourier(ByVal rg(,) As Double) As Double(,)
        Dim rgf(,) As Double
        Dim Tam_Orig As Single
        Tam_Orig = rg.Length / 2 - 1

        Dim i, k As Integer 'contadores
        Dim N As Integer = rg.Length / 2    'El número de elementos, en realidad se tendrán 2n elementos(n reales y n imag)
        Dim rgaux(,) As Double
        rgaux = rg.Clone
        'antes de aplicar la transformada, se realiza un tapering
        'vamos a multiplicar  ambos extremos (5% del registro al principio y 5% al final) por un taper de Hannig 
        '           1        2 Pi() t
        '     f(t)= - (1-Cos[--------])            con T= N* Delta t    con N:num de puntos N=2^p, p entero
        '           2            T

        'el vector viene 'real (#,0) e imaginario (#,1)
        Dim T As Double
        T = N / Form1.SPS

        Dim tam As Short
        tam = Tam_Orig * Form1.tap / 100 'encontrar cuanto es % del tamaño de la señal total
        For i = 0 To tam
            rgaux(i, 0) = rgaux(i, 0) * (0.5 * (1 - Math.Cos((2 * Math.PI * rgaux(i, 1)) / T))) * 100
        Next
        For i = Tam_Orig - tam To Tam_Orig
            rgaux(i, 0) = rgaux(i, 0) * (0.5 * (1 - Math.Cos((2 * Math.PI * rgaux(i, 1)) / T))) * 100
        Next

        Dim P As Single
        P = Math.Log(N) / Math.Log(2)
        '27 abril nuevo criterio para manejar el filtrado: 
        'se toma siempre el 2^n inmediato superiór pero solo semuestra el rango original

        If P <> CInt(P) Then
            Dim supe As Int16
            supe = CInt(P.ToString.Substring(0, P.ToString.IndexOf("."))) + 1
            N = 2 ^ supe
            ReDim rgf(N - 1, 1)
            For i = 0 To rg.Length / 2 - 1
                rgf(i, 0) = rgaux(i, 0)
                ' rgf(i, 1) = rg(i, 1)
            Next
        End If


        'For i = 0 To rgf.Length / 2 - 1
        '    rgf(i, 1) = 0
        'Next

        Dim J As Integer = N / 2
        Dim Aux_Real, Aux_Imag As Double
        'se invierte el orden de los datos de antemano pues el algoritmo
        'de fft arroja los datos movidos. Tambien puede hacerse al final.
        For i = 1 To N - 2
            If i < J Then
                Aux_Real = rgf(J, 0)
                Aux_Imag = rgf(J, 1)
                rgf(J, 0) = rgf(i, 0)
                rgf(J, 1) = rgf(i, 1)
                rgf(i, 0) = Aux_Real
                rgf(i, 1) = Aux_Imag
            End If
            k = N / 2
            Do While k <= J
                J = J - k
                k = k / 2
            Loop
            J = J + k
        Next
        Dim Pe, ip As Integer
        'FFT:
        Dim UnitReal, UnitImag, coseno, seno As Double
        For Pe = 1 To CInt(Math.Log(N) / Math.Log(2))
            UnitReal = 1
            UnitImag = 0
            coseno = Math.Cos(Math.PI / (CInt(2 ^ Pe) / 2))
            seno = -Math.Sin(Math.PI / (CInt(2 ^ Pe) / 2))
            For J = 1 To CInt(CInt(2 ^ Pe) / 2)

                For i = J - 1 To N - 1 Step CInt(2 ^ Pe)
                    ip = i + (CInt(2 ^ Pe) / 2)
                    Aux_Real = rgf(ip, 0) * UnitReal - rgf(ip, 1) * UnitImag
                    Aux_Imag = rgf(ip, 0) * UnitImag + rgf(ip, 1) * UnitReal
                    rgf(ip, 0) = rgf(i, 0) - Aux_Real
                    rgf(ip, 1) = rgf(i, 1) - Aux_Imag
                    rgf(i, 0) = rgf(i, 0) + Aux_Real
                    rgf(i, 1) = rgf(i, 1) + Aux_Imag
                Next
                Aux_Real = UnitReal
                UnitReal = Aux_Real * coseno - UnitImag * seno
                UnitImag = Aux_Real * seno + UnitImag * coseno
            Next
        Next




        ' la frecuencia cero está en realidad en rgf.length/4-1 (a la mitad) .'. la mitad son negativos (por los conjugados)
        ' podría desecharse la parte negativa (la segunda mitad)
        TransformadaRápidaDeFourier = rgf
    End Function

    Function checkBool(ByVal ck As CheckBox) As Boolean
        checkBool = ck.Checked
    End Function
#End Region

    '#Region "Debugging"
    '    Function escrib(ByVal r(,) As Double, ByVal name As String)
    '        Dim sw As New StreamWriter("C:\Documents and Settings\Marshall\Mis documentos\" & name & ".txt")
    '        Dim i As Double
    '        For i = 0 To r.Length / 2 - 1
    '            sw.Write(r(i, 0).ToString & " " & r(i, 1).ToString & vbNewLine)
    '        Next
    '        sw.Flush()
    '        sw.Close()
    '    End Function

    '    Function esc(ByVal r() As Double, ByVal name As String)
    '        Dim sw As New StreamWriter("C:\Documents and Settings\Marshall\Mis documentos\" & name & ".txt")
    '        Dim i As Double
    '        Dim Df As Single
    '        For i = 0 To r.Length / 2 - 1
    '            Df = Df + (Form1.SPS / (r.Length))
    '            sw.Write(Format(Df / 1, "#.00000000000") & " " & r(i).ToString & vbNewLine)
    '        Next
    '        sw.Flush()
    '        sw.Close()
    '    End Function
    '#End Region



    'mousedown es al dar click


    <DebuggerStepThrough()> Function erri(ByVal i As Int16, ByVal r(,) As Double, ByVal mx() As Double, ByVal dm() As Double, ByVal g() As Double, ByVal which As Int16)
        Dim A, B, C, D, E, F, j As Double
        A = 0
        B = 0
        'A
        For j = 0 To i
            A = A + ((r(mx(i), 0) ^ 2 * g(j) * (r(mx(j), 0) ^ 2 - r(mx(i), 0) ^ 2)) / ((r(mx(j), 0) ^ 2 - r(mx(i), 0) ^ 2) ^ 2 + (2 * dm(j) * r(mx(j), 0) * r(mx(i), 0)) ^ 2))
        Next
        'B
        For j = 0 To i
            B = B + ((-2 * dm(j) * r(mx(j), 0) * r(mx(i), 0) ^ 3 * g(j)) / ((r(mx(j), 0) ^ 2 - r(mx(i), 0) ^ 2) ^ 2 + (2 * dm(j) * r(mx(j), 0) * r(mx(i), 0)) ^ 2))
        Next
        'C
        C = r(mx(i), 0) ^ 2 * g(i + 1) * (r(mx(i + 1), 0) ^ 2 - r(mx(i), 0) ^ 2)
        'D
        D = -2 * r(mx(i + 1), 0) * r(mx(i), 0) ^ 3 * g(i + 1)
        'E
        E = (r(mx(i + 1), 0) ^ 2 - r(mx(i), 0) ^ 2) ^ 2
        'F
        F = (2 * r(mx(i + 1), 0) * r(mx(i), 0)) ^ 2

        If which = 0 Then
            erri = (1 + A + (C / (E))) ^ 2 + _
                        ((-g(i) / (2 * dm(i))) + B) ^ 2 - _
                        (r(mx(i), 1) ^ 2)
        ElseIf which = 1 Then
            erri = (1 + A + (C / (E + F))) ^ 2 + _
            ((-g(i) / (2 * dm(i))) + B + ((-D) / (E + F))) ^ 2 - _
            (r(mx(i), 1) ^ 2)
        End If


    End Function


End Class
