Imports System.IO
Imports Editor_de_Registros_Sísmicos.ClassDibujo
Imports System.Drawing.Printing
Imports Editor_de_Registros_Sísmicos.Utilidades
Public Class Transf 'Cálculo de la función de transferencia
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
    Friend WithEvents BTguardarTransf As System.Windows.Forms.Button
    Friend WithEvents ST As System.Windows.Forms.StatusBar
    Friend WithEvents PIC As System.Windows.Forms.PictureBox
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ckLOG As System.Windows.Forms.CheckBox
    Friend WithEvents ckCONJ As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB As System.Windows.Forms.TextBox
    Friend WithEvents BTcopy As System.Windows.Forms.Button
    Friend WithEvents TT As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Amort1 As System.Windows.Forms.RadioButton
    Friend WithEvents Amort2 As System.Windows.Forms.RadioButton
    Friend WithEvents BTcoher As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabTransf As System.Windows.Forms.TabPage
    Friend WithEvents TabCoher As System.Windows.Forms.TabPage
    Friend WithEvents TabDatos As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxTamaño As System.Windows.Forms.TextBox
    Friend WithEvents Bartlett As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ChB_Color_pres As System.Windows.Forms.CheckBox
    Friend WithEvents radtamaño As System.Windows.Forms.CheckBox
    Friend WithEvents TBventana As System.Windows.Forms.TextBox
    Friend WithEvents radForz As System.Windows.Forms.CheckBox
    Friend WithEvents LA As System.Windows.Forms.StatusBarPanel
    Friend WithEvents rb_Hann As System.Windows.Forms.RadioButton
    Friend WithEvents ch_Traslape As System.Windows.Forms.CheckBox
    Friend WithEvents tb_traslape As System.Windows.Forms.TextBox
    Friend WithEvents noborrar As System.Windows.Forms.CheckBox
    Friend WithEvents horzLog As System.Windows.Forms.CheckBox
    Friend WithEvents BTcopiar As System.Windows.Forms.Button
    Friend WithEvents TabTransf2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTguardarTransf2 As System.Windows.Forms.Button
    Friend WithEvents FTruidoso As System.Windows.Forms.Button
    Friend WithEvents ch_Traslape2 As System.Windows.Forms.CheckBox
    Friend WithEvents tb_traslape2 As System.Windows.Forms.TextBox
    Friend WithEvents rb_Hann2 As System.Windows.Forms.RadioButton
    Friend WithEvents radForz2 As System.Windows.Forms.CheckBox
    Friend WithEvents TBventana2 As System.Windows.Forms.TextBox
    Friend WithEvents radtamaño2 As System.Windows.Forms.CheckBox
    Friend WithEvents TxTamaño2 As System.Windows.Forms.TextBox
    Friend WithEvents Bartlett2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rectangular As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Hamming As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Hamming2 As System.Windows.Forms.RadioButton
    Friend WithEvents BTguardarCoh As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transf))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.BTguardarTransf = New System.Windows.Forms.Button
        Me.ST = New System.Windows.Forms.StatusBar
        Me.LA = New System.Windows.Forms.StatusBarPanel
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.ckLOG = New System.Windows.Forms.CheckBox
        Me.ckCONJ = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TB = New System.Windows.Forms.TextBox
        Me.TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxTamaño = New System.Windows.Forms.TextBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.noborrar = New System.Windows.Forms.CheckBox
        Me.BTtransf = New System.Windows.Forms.Button
        Me.BTcopy = New System.Windows.Forms.Button
        Me.FTruidoso = New System.Windows.Forms.Button
        Me.TxTamaño2 = New System.Windows.Forms.TextBox
        Me.Bartlett = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Amort2 = New System.Windows.Forms.RadioButton
        Me.Amort1 = New System.Windows.Forms.RadioButton
        Me.BTcoher = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabDatos = New System.Windows.Forms.TabPage
        Me.TabTransf = New System.Windows.Forms.TabPage
        Me.TabTransf2 = New System.Windows.Forms.TabPage
        Me.rb_Hamming2 = New System.Windows.Forms.RadioButton
        Me.Rectangular = New System.Windows.Forms.RadioButton
        Me.ch_Traslape2 = New System.Windows.Forms.CheckBox
        Me.tb_traslape2 = New System.Windows.Forms.TextBox
        Me.rb_Hann2 = New System.Windows.Forms.RadioButton
        Me.radForz2 = New System.Windows.Forms.CheckBox
        Me.TBventana2 = New System.Windows.Forms.TextBox
        Me.radtamaño2 = New System.Windows.Forms.CheckBox
        Me.Bartlett2 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.BTguardarTransf2 = New System.Windows.Forms.Button
        Me.TabCoher = New System.Windows.Forms.TabPage
        Me.rb_Hamming = New System.Windows.Forms.RadioButton
        Me.ch_Traslape = New System.Windows.Forms.CheckBox
        Me.tb_traslape = New System.Windows.Forms.TextBox
        Me.rb_Hann = New System.Windows.Forms.RadioButton
        Me.radForz = New System.Windows.Forms.CheckBox
        Me.TBventana = New System.Windows.Forms.TextBox
        Me.radtamaño = New System.Windows.Forms.CheckBox
        Me.BTguardarCoh = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.BTcopiar = New System.Windows.Forms.Button
        Me.horzLog = New System.Windows.Forms.CheckBox
        Me.ChB_Color_pres = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PIC = New System.Windows.Forms.PictureBox
        CType(Me.LA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabDatos.SuspendLayout()
        Me.TabTransf.SuspendLayout()
        Me.TabTransf2.SuspendLayout()
        Me.TabCoher.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox1.Location = New System.Drawing.Point(3, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(953, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Func. Transf.: numerador:  (Salida)                       ///                Cohe" & _
            "rencia: Y"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.ComboBox2.Location = New System.Drawing.Point(3, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(953, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.Text = "Func. Transf.: denominador: (Entrada)                 ///                 Coheren" & _
            "cia: X"
        '
        'BTguardarTransf
        '
        Me.BTguardarTransf.BackColor = System.Drawing.SystemColors.Control
        Me.BTguardarTransf.Location = New System.Drawing.Point(869, 50)
        Me.BTguardarTransf.Name = "BTguardarTransf"
        Me.BTguardarTransf.Size = New System.Drawing.Size(95, 27)
        Me.BTguardarTransf.TabIndex = 4
        Me.BTguardarTransf.Text = "Guardar Función de Transferencia"
        Me.BTguardarTransf.UseVisualStyleBackColor = False
        '
        'ST
        '
        Me.ST.Location = New System.Drawing.Point(0, 524)
        Me.ST.Name = "ST"
        Me.ST.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.LA})
        Me.ST.ShowPanels = True
        Me.ST.Size = New System.Drawing.Size(972, 21)
        Me.ST.TabIndex = 5
        '
        'LA
        '
        Me.LA.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.LA.MinWidth = 330
        Me.LA.Name = "LA"
        Me.LA.Text = "Ok"
        Me.LA.Width = 330
        '
        'SFD
        '
        Me.SFD.DefaultExt = "txt"
        Me.SFD.Title = "Guardar función de transferencia"
        '
        'ckLOG
        '
        Me.ckLOG.Location = New System.Drawing.Point(389, 9)
        Me.ckLOG.Name = "ckLOG"
        Me.ckLOG.Size = New System.Drawing.Size(128, 22)
        Me.ckLOG.TabIndex = 7
        Me.ckLOG.Text = "Vertical logarítmico"
        '
        'ckCONJ
        '
        Me.ckCONJ.Location = New System.Drawing.Point(389, 57)
        Me.ckCONJ.Name = "ckCONJ"
        Me.ckCONJ.Size = New System.Drawing.Size(128, 22)
        Me.ckCONJ.TabIndex = 8
        Me.ckCONJ.Text = "Mostrar conjugado"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(135, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Zoom y Amortiguamiento"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TB
        '
        Me.TB.Location = New System.Drawing.Point(280, 8)
        Me.TB.Multiline = True
        Me.TB.Name = "TB"
        Me.TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB.Size = New System.Drawing.Size(587, 69)
        Me.TB.TabIndex = 11
        '
        'TxTamaño
        '
        Me.TxTamaño.Location = New System.Drawing.Point(527, 12)
        Me.TxTamaño.Name = "TxTamaño"
        Me.TxTamaño.Size = New System.Drawing.Size(78, 20)
        Me.TxTamaño.TabIndex = 1
        Me.TxTamaño.Text = "1024"
        Me.TT.SetToolTip(Me.TxTamaño, "En puntos en el dominio del tiempo")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(136, 60)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(34, 20)
        Me.NumericUpDown1.TabIndex = 25
        Me.TT.SetToolTip(Me.NumericUpDown1, "Cantidad de veces que se ejecuta el suavizado seleccionado")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.TrackBar1.Location = New System.Drawing.Point(26, 26)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(144, 33)
        Me.TrackBar1.TabIndex = 21
        Me.TT.SetToolTip(Me.TrackBar1, "Valor Fs del suavizado de la magnitud espectral")
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(117, 59)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton4.TabIndex = 24
        Me.RadioButton4.Text = "3"
        Me.TT.SetToolTip(Me.RadioButton4, "Suavizado 1 y luego suavizado 2")
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(88, 59)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton3.TabIndex = 23
        Me.RadioButton3.Text = "2"
        Me.TT.SetToolTip(Me.RadioButton3, "Suavizado con tamaño de ventana en función de la frecuencia y media cuadrática pa" & _
                "ra el punto y su vecindad. (castiga las frecuencias altas). Toma algo de tiempo")
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(59, 59)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1"
        Me.TT.SetToolTip(Me.RadioButton2, "Suavizado con una ventana rectangular de tamaño fijo y media cuadrática para cada" & _
                " elemento y su vecindad")
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(26, 59)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(30, 22)
        Me.RadioButton1.TabIndex = 26
        Me.RadioButton1.Text = "0"
        Me.TT.SetToolTip(Me.RadioButton1, "Sin suavizado")
        '
        'noborrar
        '
        Me.noborrar.AutoSize = True
        Me.noborrar.Enabled = False
        Me.noborrar.Location = New System.Drawing.Point(579, 36)
        Me.noborrar.Name = "noborrar"
        Me.noborrar.Size = New System.Drawing.Size(216, 17)
        Me.noborrar.TabIndex = 30
        Me.noborrar.Text = "trazar varios gráf. de coherencia a la vez"
        Me.TT.SetToolTip(Me.noborrar, "solo con Coherencia")
        Me.noborrar.UseVisualStyleBackColor = True
        '
        'BTtransf
        '
        Me.BTtransf.BackColor = System.Drawing.SystemColors.Control
        Me.BTtransf.Image = CType(resources.GetObject("BTtransf.Image"), System.Drawing.Image)
        Me.BTtransf.Location = New System.Drawing.Point(6, 6)
        Me.BTtransf.Name = "BTtransf"
        Me.BTtransf.Size = New System.Drawing.Size(56, 44)
        Me.BTtransf.TabIndex = 3
        Me.TT.SetToolTip(Me.BTtransf, "Calcular la función de transferencia entre los seleccionados")
        Me.BTtransf.UseVisualStyleBackColor = False
        '
        'BTcopy
        '
        Me.BTcopy.Image = CType(resources.GetObject("BTcopy.Image"), System.Drawing.Image)
        Me.BTcopy.Location = New System.Drawing.Point(873, 6)
        Me.BTcopy.Name = "BTcopy"
        Me.BTcopy.Size = New System.Drawing.Size(39, 35)
        Me.BTcopy.TabIndex = 12
        Me.TT.SetToolTip(Me.BTcopy, "Copiar al portapapeles las frecuencias y amortiguamientos identificados")
        Me.BTcopy.Visible = False
        '
        'FTruidoso
        '
        Me.FTruidoso.BackColor = System.Drawing.SystemColors.Control
        Me.FTruidoso.Image = CType(resources.GetObject("FTruidoso.Image"), System.Drawing.Image)
        Me.FTruidoso.Location = New System.Drawing.Point(3, 18)
        Me.FTruidoso.Name = "FTruidoso"
        Me.FTruidoso.Size = New System.Drawing.Size(56, 44)
        Me.FTruidoso.TabIndex = 13
        Me.TT.SetToolTip(Me.FTruidoso, "Calcular la función de transferencia entre los seleccionados")
        Me.FTruidoso.UseVisualStyleBackColor = False
        '
        'TxTamaño2
        '
        Me.TxTamaño2.Location = New System.Drawing.Point(539, 16)
        Me.TxTamaño2.Name = "TxTamaño2"
        Me.TxTamaño2.Size = New System.Drawing.Size(78, 20)
        Me.TxTamaño2.TabIndex = 38
        Me.TxTamaño2.Text = "1024"
        Me.TT.SetToolTip(Me.TxTamaño2, "En puntos en el dominio del tiempo")
        '
        'Bartlett
        '
        Me.Bartlett.AutoSize = True
        Me.Bartlett.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bartlett.Location = New System.Drawing.Point(82, 35)
        Me.Bartlett.Name = "Bartlett"
        Me.Bartlett.Size = New System.Drawing.Size(107, 17)
        Me.Bartlett.TabIndex = 30
        Me.Bartlett.Text = "Bartlett - Hanning"
        Me.Bartlett.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Amort2)
        Me.GroupBox1.Controls.Add(Me.Amort1)
        Me.GroupBox1.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(235, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(39, 61)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "x"
        '
        'Amort2
        '
        Me.Amort2.Enabled = False
        Me.Amort2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amort2.Location = New System.Drawing.Point(6, 36)
        Me.Amort2.Name = "Amort2"
        Me.Amort2.Size = New System.Drawing.Size(29, 22)
        Me.Amort2.TabIndex = 1
        Me.Amort2.Text = "2"
        '
        'Amort1
        '
        Me.Amort1.Checked = True
        Me.Amort1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amort1.Location = New System.Drawing.Point(6, 15)
        Me.Amort1.Name = "Amort1"
        Me.Amort1.Size = New System.Drawing.Size(29, 22)
        Me.Amort1.TabIndex = 0
        Me.Amort1.TabStop = True
        Me.Amort1.Text = "1"
        '
        'BTcoher
        '
        Me.BTcoher.Location = New System.Drawing.Point(6, 6)
        Me.BTcoher.Name = "BTcoher"
        Me.BTcoher.Size = New System.Drawing.Size(56, 44)
        Me.BTcoher.TabIndex = 21
        Me.BTcoher.Text = "Coh"
        Me.BTcoher.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabDatos)
        Me.TabControl1.Controls.Add(Me.TabTransf)
        Me.TabControl1.Controls.Add(Me.TabTransf2)
        Me.TabControl1.Controls.Add(Me.TabCoher)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 415)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(972, 109)
        Me.TabControl1.TabIndex = 25
        '
        'TabDatos
        '
        Me.TabDatos.Controls.Add(Me.ComboBox1)
        Me.TabDatos.Controls.Add(Me.ComboBox2)
        Me.TabDatos.Location = New System.Drawing.Point(4, 22)
        Me.TabDatos.Name = "TabDatos"
        Me.TabDatos.Size = New System.Drawing.Size(964, 83)
        Me.TabDatos.TabIndex = 2
        Me.TabDatos.Text = "Datos"
        Me.TabDatos.UseVisualStyleBackColor = True
        '
        'TabTransf
        '
        Me.TabTransf.Controls.Add(Me.BTguardarTransf)
        Me.TabTransf.Controls.Add(Me.TB)
        Me.TabTransf.Controls.Add(Me.GroupBox1)
        Me.TabTransf.Controls.Add(Me.Button1)
        Me.TabTransf.Controls.Add(Me.BTtransf)
        Me.TabTransf.Controls.Add(Me.BTcopy)
        Me.TabTransf.Location = New System.Drawing.Point(4, 22)
        Me.TabTransf.Name = "TabTransf"
        Me.TabTransf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTransf.Size = New System.Drawing.Size(964, 83)
        Me.TabTransf.TabIndex = 0
        Me.TabTransf.Text = "F. de Transferencia"
        Me.TabTransf.UseVisualStyleBackColor = True
        '
        'TabTransf2
        '
        Me.TabTransf2.Controls.Add(Me.rb_Hamming2)
        Me.TabTransf2.Controls.Add(Me.Rectangular)
        Me.TabTransf2.Controls.Add(Me.ch_Traslape2)
        Me.TabTransf2.Controls.Add(Me.tb_traslape2)
        Me.TabTransf2.Controls.Add(Me.rb_Hann2)
        Me.TabTransf2.Controls.Add(Me.radForz2)
        Me.TabTransf2.Controls.Add(Me.TBventana2)
        Me.TabTransf2.Controls.Add(Me.radtamaño2)
        Me.TabTransf2.Controls.Add(Me.TxTamaño2)
        Me.TabTransf2.Controls.Add(Me.Bartlett2)
        Me.TabTransf2.Controls.Add(Me.Label1)
        Me.TabTransf2.Controls.Add(Me.BTguardarTransf2)
        Me.TabTransf2.Controls.Add(Me.FTruidoso)
        Me.TabTransf2.Location = New System.Drawing.Point(4, 22)
        Me.TabTransf2.Name = "TabTransf2"
        Me.TabTransf2.Size = New System.Drawing.Size(964, 83)
        Me.TabTransf2.TabIndex = 4
        Me.TabTransf2.Text = "FT (ruidoso)"
        Me.TabTransf2.UseVisualStyleBackColor = True
        '
        'rb_Hamming2
        '
        Me.rb_Hamming2.AutoSize = True
        Me.rb_Hamming2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rb_Hamming2.Location = New System.Drawing.Point(79, 64)
        Me.rb_Hamming2.Name = "rb_Hamming2"
        Me.rb_Hamming2.Size = New System.Drawing.Size(69, 17)
        Me.rb_Hamming2.TabIndex = 47
        Me.rb_Hamming2.Text = "Hamming"
        Me.rb_Hamming2.UseVisualStyleBackColor = True
        '
        'Rectangular
        '
        Me.Rectangular.AutoSize = True
        Me.Rectangular.Checked = True
        Me.Rectangular.Location = New System.Drawing.Point(79, 12)
        Me.Rectangular.Name = "Rectangular"
        Me.Rectangular.Size = New System.Drawing.Size(83, 17)
        Me.Rectangular.TabIndex = 46
        Me.Rectangular.TabStop = True
        Me.Rectangular.Text = "Rectangular"
        Me.Rectangular.UseVisualStyleBackColor = True
        '
        'ch_Traslape2
        '
        Me.ch_Traslape2.AutoSize = True
        Me.ch_Traslape2.Location = New System.Drawing.Point(268, 62)
        Me.ch_Traslape2.Name = "ch_Traslape2"
        Me.ch_Traslape2.Size = New System.Drawing.Size(219, 17)
        Me.ch_Traslape2.TabIndex = 45
        Me.ch_Traslape2.Text = "Forzar el traslape de la ventana (puntos)="
        Me.ch_Traslape2.UseVisualStyleBackColor = True
        '
        'tb_traslape2
        '
        Me.tb_traslape2.Location = New System.Drawing.Point(499, 58)
        Me.tb_traslape2.Name = "tb_traslape2"
        Me.tb_traslape2.Size = New System.Drawing.Size(75, 20)
        Me.tb_traslape2.TabIndex = 44
        '
        'rb_Hann2
        '
        Me.rb_Hann2.AutoSize = True
        Me.rb_Hann2.Checked = True
        Me.rb_Hann2.Location = New System.Drawing.Point(79, 29)
        Me.rb_Hann2.Name = "rb_Hann2"
        Me.rb_Hann2.Size = New System.Drawing.Size(65, 17)
        Me.rb_Hann2.TabIndex = 43
        Me.rb_Hann2.TabStop = True
        Me.rb_Hann2.Text = "Hanning"
        Me.rb_Hann2.UseVisualStyleBackColor = True
        '
        'radForz2
        '
        Me.radForz2.AutoSize = True
        Me.radForz2.Location = New System.Drawing.Point(268, 40)
        Me.radForz2.Name = "radForz2"
        Me.radForz2.Size = New System.Drawing.Size(241, 17)
        Me.radForz2.TabIndex = 42
        Me.radForz2.Text = "Forzar el tamaño de la ventana (2^p  puntos)="
        Me.radForz2.UseVisualStyleBackColor = True
        '
        'TBventana2
        '
        Me.TBventana2.Location = New System.Drawing.Point(515, 37)
        Me.TBventana2.Name = "TBventana2"
        Me.TBventana2.Size = New System.Drawing.Size(84, 20)
        Me.TBventana2.TabIndex = 41
        Me.TBventana2.Text = "512"
        '
        'radtamaño2
        '
        Me.radtamaño2.AutoSize = True
        Me.radtamaño2.Location = New System.Drawing.Point(268, 18)
        Me.radtamaño2.Name = "radtamaño2"
        Me.radtamaño2.Size = New System.Drawing.Size(265, 17)
        Me.radtamaño2.TabIndex = 39
        Me.radtamaño2.Text = "Limitar la cantidad de datos leidos en las señales a:"
        Me.radtamaño2.UseVisualStyleBackColor = True
        '
        'Bartlett2
        '
        Me.Bartlett2.AutoSize = True
        Me.Bartlett2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bartlett2.Location = New System.Drawing.Point(79, 46)
        Me.Bartlett2.Name = "Bartlett2"
        Me.Bartlett2.Size = New System.Drawing.Size(107, 17)
        Me.Bartlett2.TabIndex = 40
        Me.Bartlett2.Text = "Bartlett - Hanning"
        Me.Bartlett2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cociente entre el espectro cruzado de las señales y el autoespectro de la entrada" & _
            " (Halvorsen y Brown 1977)."
        '
        'BTguardarTransf2
        '
        Me.BTguardarTransf2.BackColor = System.Drawing.SystemColors.Control
        Me.BTguardarTransf2.Location = New System.Drawing.Point(866, 50)
        Me.BTguardarTransf2.Name = "BTguardarTransf2"
        Me.BTguardarTransf2.Size = New System.Drawing.Size(95, 27)
        Me.BTguardarTransf2.TabIndex = 14
        Me.BTguardarTransf2.Text = "Guardar Función de Transferencia"
        Me.BTguardarTransf2.UseVisualStyleBackColor = False
        '
        'TabCoher
        '
        Me.TabCoher.Controls.Add(Me.rb_Hamming)
        Me.TabCoher.Controls.Add(Me.ch_Traslape)
        Me.TabCoher.Controls.Add(Me.tb_traslape)
        Me.TabCoher.Controls.Add(Me.rb_Hann)
        Me.TabCoher.Controls.Add(Me.radForz)
        Me.TabCoher.Controls.Add(Me.TBventana)
        Me.TabCoher.Controls.Add(Me.radtamaño)
        Me.TabCoher.Controls.Add(Me.TxTamaño)
        Me.TabCoher.Controls.Add(Me.Bartlett)
        Me.TabCoher.Controls.Add(Me.BTguardarCoh)
        Me.TabCoher.Controls.Add(Me.BTcoher)
        Me.TabCoher.Location = New System.Drawing.Point(4, 22)
        Me.TabCoher.Name = "TabCoher"
        Me.TabCoher.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCoher.Size = New System.Drawing.Size(964, 83)
        Me.TabCoher.TabIndex = 1
        Me.TabCoher.Text = "Coherencia"
        Me.TabCoher.UseVisualStyleBackColor = True
        '
        'rb_Hamming
        '
        Me.rb_Hamming.AutoSize = True
        Me.rb_Hamming.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rb_Hamming.Location = New System.Drawing.Point(82, 58)
        Me.rb_Hamming.Name = "rb_Hamming"
        Me.rb_Hamming.Size = New System.Drawing.Size(69, 17)
        Me.rb_Hamming.TabIndex = 38
        Me.rb_Hamming.Text = "Hamming"
        Me.rb_Hamming.UseVisualStyleBackColor = True
        '
        'ch_Traslape
        '
        Me.ch_Traslape.AutoSize = True
        Me.ch_Traslape.Location = New System.Drawing.Point(638, 14)
        Me.ch_Traslape.Name = "ch_Traslape"
        Me.ch_Traslape.Size = New System.Drawing.Size(219, 17)
        Me.ch_Traslape.TabIndex = 37
        Me.ch_Traslape.Text = "Forzar el traslape de la ventana (puntos)="
        Me.ch_Traslape.UseVisualStyleBackColor = True
        '
        'tb_traslape
        '
        Me.tb_traslape.Location = New System.Drawing.Point(869, 12)
        Me.tb_traslape.Name = "tb_traslape"
        Me.tb_traslape.Size = New System.Drawing.Size(75, 20)
        Me.tb_traslape.TabIndex = 36
        '
        'rb_Hann
        '
        Me.rb_Hann.AutoSize = True
        Me.rb_Hann.Checked = True
        Me.rb_Hann.Location = New System.Drawing.Point(82, 11)
        Me.rb_Hann.Name = "rb_Hann"
        Me.rb_Hann.Size = New System.Drawing.Size(65, 17)
        Me.rb_Hann.TabIndex = 35
        Me.rb_Hann.TabStop = True
        Me.rb_Hann.Text = "Hanning"
        Me.rb_Hann.UseVisualStyleBackColor = True
        '
        'radForz
        '
        Me.radForz.AutoSize = True
        Me.radForz.Location = New System.Drawing.Point(256, 48)
        Me.radForz.Name = "radForz"
        Me.radForz.Size = New System.Drawing.Size(241, 17)
        Me.radForz.TabIndex = 34
        Me.radForz.Text = "Forzar el tamaño de la ventana (2^p  puntos)="
        Me.radForz.UseVisualStyleBackColor = True
        '
        'TBventana
        '
        Me.TBventana.Location = New System.Drawing.Point(503, 45)
        Me.TBventana.Name = "TBventana"
        Me.TBventana.Size = New System.Drawing.Size(84, 20)
        Me.TBventana.TabIndex = 33
        Me.TBventana.Text = "512"
        '
        'radtamaño
        '
        Me.radtamaño.AutoSize = True
        Me.radtamaño.Location = New System.Drawing.Point(256, 14)
        Me.radtamaño.Name = "radtamaño"
        Me.radtamaño.Size = New System.Drawing.Size(265, 17)
        Me.radtamaño.TabIndex = 2
        Me.radtamaño.Text = "Limitar la cantidad de datos leidos en las señales a:"
        Me.radtamaño.UseVisualStyleBackColor = True
        '
        'BTguardarCoh
        '
        Me.BTguardarCoh.BackColor = System.Drawing.SystemColors.Control
        Me.BTguardarCoh.Location = New System.Drawing.Point(869, 50)
        Me.BTguardarCoh.Name = "BTguardarCoh"
        Me.BTguardarCoh.Size = New System.Drawing.Size(95, 27)
        Me.BTguardarCoh.TabIndex = 29
        Me.BTguardarCoh.Text = "Guardar Función de Transferencia"
        Me.BTguardarCoh.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BTcopiar)
        Me.TabPage1.Controls.Add(Me.horzLog)
        Me.TabPage1.Controls.Add(Me.noborrar)
        Me.TabPage1.Controls.Add(Me.ChB_Color_pres)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Controls.Add(Me.NumericUpDown1)
        Me.TabPage1.Controls.Add(Me.TrackBar1)
        Me.TabPage1.Controls.Add(Me.RadioButton4)
        Me.TabPage1.Controls.Add(Me.RadioButton3)
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.ckCONJ)
        Me.TabPage1.Controls.Add(Me.ckLOG)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(964, 83)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Opciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BTcopiar
        '
        Me.BTcopiar.Location = New System.Drawing.Point(579, 56)
        Me.BTcopiar.Name = "BTcopiar"
        Me.BTcopiar.Size = New System.Drawing.Size(109, 23)
        Me.BTcopiar.TabIndex = 32
        Me.BTcopiar.Text = "Copiar Imagen"
        Me.BTcopiar.UseVisualStyleBackColor = True
        '
        'horzLog
        '
        Me.horzLog.Enabled = False
        Me.horzLog.Location = New System.Drawing.Point(389, 33)
        Me.horzLog.Name = "horzLog"
        Me.horzLog.Size = New System.Drawing.Size(128, 22)
        Me.horzLog.TabIndex = 31
        Me.horzLog.Text = "Horizontal logarítmico"
        '
        'ChB_Color_pres
        '
        Me.ChB_Color_pres.AutoSize = True
        Me.ChB_Color_pres.Location = New System.Drawing.Point(579, 12)
        Me.ChB_Color_pres.Name = "ChB_Color_pres"
        Me.ChB_Color_pres.Size = New System.Drawing.Size(138, 17)
        Me.ChB_Color_pres.TabIndex = 29
        Me.ChB_Color_pres.Text = "Colores de presentación"
        Me.ChB_Color_pres.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Suavizado"
        '
        'PIC
        '
        Me.PIC.BackColor = System.Drawing.Color.Black
        Me.PIC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PIC.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIC.Location = New System.Drawing.Point(0, 0)
        Me.PIC.Name = "PIC"
        Me.PIC.Size = New System.Drawing.Size(972, 415)
        Me.PIC.TabIndex = 0
        Me.PIC.TabStop = False
        '
        'Transf
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 545)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ST)
        Me.Controls.Add(Me.PIC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Identificación no paramétrica: Función de transferencia y Coherencia"
        CType(Me.LA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabDatos.ResumeLayout(False)
        Me.TabTransf.ResumeLayout(False)
        Me.TabTransf.PerformLayout()
        Me.TabTransf2.ResumeLayout(False)
        Me.TabTransf2.PerformLayout()
        Me.TabCoher.ResumeLayout(False)
        Me.TabCoher.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"
    Dim ftransfMAG(,), ftransfMAGtaper(,), Cohe(,), ftruido(,) As Double 'Los vectores que guardan la 
    'función de transferencia y la función de transferencia con taper y la coherencia y la ft 2
    Dim bugger As New bugger 'Utilizado durante la evaluación del algoritmo
    Public Shared handleDAMPING As Boolean = False
    Public Shared T1, T2 As Integer 'índices
    Public Shared max(0), dmp(0) As Double  'los índice de los máximos en el espectro en
    ' puntos y los respectivos amortiguamientos convencionales
    Dim Tx As Integer
    Dim calculado As Boolean = False
    Dim Tam_Orig As Single
    Dim modo As Int16 = 1  '1 para funcion de transferencia, 2 para coherencia
    Dim colorBack As Color = Color.Black
    Dim colorGraf As Color = Color.YellowGreen
    Private WithEvents printdocument1 As New PrintDocument
    Dim sta As New Stack
    Dim ColList() As Color
    Dim nombSta As New Stack
    Dim ley As New Colores
    Dim gráfico As New Bitmap(972, 415)
#End Region

#Region "Eventos de objeto"
    Private Sub Transf_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TrackBar1.Value = Form1.Fs 'Se recupera el valor de suavizado predefinido
        max(0) = -1
        handleDAMPING = False
        T1 = 0
        T2 = 0
        Tx = 0
        ColList = llenarCoList()
    End Sub

    Private Sub actualiza_la_lista(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'las referencias a los registros abiertos, se cargan a las listas despegables
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
        'Cálculo de la función de transferencia
        modo = 1
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
        'se calcula el espectro real y complejo del numerador y del denominador, luego se hace la división.
        Dim num(,), den(,), i, numMAG(), denMAG() As Double

        If ComboBox1.SelectedItem Is Nothing Or ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Primero es necesario seleccionar un registro como numerador y otro como denominador", "ups", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        num = reg_o_espectro(ComboBox1.SelectedItem) 'real (#,0) e imaginario (#,1)
        den = reg_o_espectro(ComboBox2.SelectedItem)
        ST.Text = "Calculando y Suavizando la magnitud espectral"
        numMAG = magnitud_(num)
        denMAG = magnitud_(den)

        ST.Text = "Calculando la función de transferencia"

        'Se prepara el vector que recibirá la función de transferencia
        ReDim ftransfMAG(denMAG.Length - 1, 1)
        ftransfMAG(0, 0) = 0
        ftransfMAG(0, 1) = numMAG(0) / denMAG(0)
        If Double.IsNaN(ftransfMAG(0, 1)) Then
            ftransfMAG(0, 1) = 0
        End If

        Dim df As Double = 0 'para el Delta f

        'La función de transferencia es el cociente de las magnitudes de los espectros de fourier
        For i = 0 To ftransfMAG.Length / 2 - 1
            ftransfMAG(i, 0) = df
            df = df + Form1.SPS / ((ftransfMAG.Length / 2))
            On Error Resume Next
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

    Private Sub BTcoher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcoher.Click
        'cálculo de la coherencia suavizada
        modo = 2
        T1 = 0
        T2 = 0
        Tx = 0
        calculado = False
        Button1.FlatStyle = FlatStyle.Standard
        handleDAMPING = False
        ST.Text = ""
        ckCONJ.Enabled = False
        Amort2.Enabled = False

        TB.Text = ""
        BTcopy.Visible = False

        Dim X(,), Y(,), i As Double

        If ComboBox1.SelectedItem Is Nothing Or ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Primero es necesario seleccionar un par de registros", "ups", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim S12(,), S11(,), S22(,) As Double
        Dim mS12(), mS11(), mS22() As Double
        'Harichandran R. y Vanmarcke E. (1984), “Space-time variation of earthquake ground motion”,
        ' Research Report R84-12, Massachusetts Institute of Technology, Cambridge, Massachusetts.
        '                       S12                                   X*(f) Y(f) 
        '     Gamma(f)x-y=------------------     =   -----------------------------------------
        '                  sqrt( S11  S22)              sqrt( [X*(f) X(f)]  [Y*(f) Y(f)] )
        '
        'Donde * denota el conjugado del espectro 

        'se leen los registros
        If checkBool(radtamaño) Then
            X = reg_o_espectro(ComboBox1.SelectedItem, False, CInt(TxTamaño.Text))
            Y = reg_o_espectro(ComboBox2.SelectedItem, False, CInt(TxTamaño.Text))
        Else
            X = reg_o_espectro(ComboBox1.SelectedItem, False)
            Y = reg_o_espectro(ComboBox2.SelectedItem, False)
        End If
        Dim tam As Integer 'el tamaño de la ventana
        If radForz.Checked = True Then
            tam = CInt(TBventana.Text) 'indicado
        Else
            'se decide
            tam = Math.Truncate(X.Length / 6)
            Dim P As Single = Math.Log(tam) / Math.Log(2)
            If P <> CInt(P) Then '¿La potencia no es un entero?
                Dim supe As Int16
                'El tamaño de N se rectifica a el número superior más próximo que 
                'puede expresarse como potencia entera de 2.
                supe = CInt(P.ToString.Substring(0, P.ToString.IndexOf("."))) + 1
                tam = 2 ^ supe
            End If
        End If

        'Se decide el valor de traslape de las ventanas
        Dim traslape As Integer
        If ch_Traslape.Checked = True Then
            traslape = CInt(tb_traslape.Text) 'indicado
            If traslape >= tam - 1 Then
                traslape = tam / 2
            End If
        Else
            traslape = tam / 2 'la mitad de la ventana se traslapa
        End If
        tb_traslape.Text = traslape

        'Se prepara un vector con la ventana del tamaño indicado
        Dim Vent(0) As Double
        If Bartlett.Checked = True Then
            Vent = BartlettHanning(tam - 1)
        ElseIf rb_Hann.Checked = True Then
            Vent = Hanning(tam - 1)
        ElseIf rb_Hamming.Checked = True Then
            Vent = Hamming(tam - 1)
        End If

        Dim j As Integer = 0
        ReDim mS11(tam - 1)
        ReDim mS22(tam - 1)
        ReDim mS12(tam - 1)
        Dim x_Hann(tam - 1, 1) As Double
        Dim y_Hann(tam - 1, 1) As Double
        For i = 0 To X.Length / 2 - 1
            'se aplica la ventana
            x_Hann(j, 0) = X(i, 0) * Vent(j)
            x_Hann(j, 1) = X(i, 1)
            y_Hann(j, 0) = Y(i, 0) * Vent(j)
            y_Hann(j, 1) = Y(i, 1)
            If j = Vent.Length - 1 Then
                'se calcula el espectro de Fourier
                x_Hann = TransformadaRápidaDeFourier(x_Hann, tam - 1)
                y_Hann = TransformadaRápidaDeFourier(y_Hann, tam - 1)
                'y los autoespectros
                ST.Text = "Función de densidad espectral X, o autoespectro X"
                S11 = Mult_Complx(conju_complx(x_Hann), x_Hann)
                ST.Text = "Función de densidad espectral Y o autoespectro Y"
                S22 = Mult_Complx(conju_complx(y_Hann), y_Hann)
                ST.Text = "Función de densidad espectral cruzada"
                S12 = Mult_Complx(conju_complx(x_Hann), y_Hann)
                'acumular los autoespectros
                mS11 = sumar_elementos(mS11, magCohe(S11))
                mS22 = sumar_elementos(mS22, magCohe(S22))
                mS12 = sumar_elementos(mS12, magCohe(S12))
                'restablecer variables para la siguiente ventana
                j = 0
                i = i - traslape
                ReDim x_Hann(tam - 1, 1)
                ReDim y_Hann(tam - 1, 1)
            End If
            j += 1
        Next

        'se calcula la magnitud al cuadrado de la coherencia:
        ST.Text = "calculando la Coherencia"
        ReDim Cohe(mS12.Length - 1, 1)
        Dim df As Double = 0 'para el Delta t
        For i = 0 To Cohe.Length / 2 - 1
            Cohe(i, 0) = df
            df = df + Form1.SPS / (Cohe.Length / 2)
            Cohe(i, 1) = mS12(i) ^ 2 / (mS11(i) * mS22(i))
        Next
        ST.Text = "Trazando"
        ST.Text = ""
        Me.Text = "Coherencia entre " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1) & " / " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1)
        ckCONJ.Enabled = True
        If noborrar.Checked = True Then
            sta.Push(Cohe)
            nombSta.Push(Me.Text)
            LA.Text = "acumulando"
        End If
        PIC.Refresh()
    End Sub

    Private Sub FTruidoso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTruidoso.Click
        ' Cálculo de la función de respuesta en frecuencia como el cociente entre el espectro cruzado entre
        ' las señales y el autoespectro de la señal de salida. Tomado de:
        ' Halvorsen, W.G., y Brown, D.L. (1977). "Impulse technique for structural frequency response testing."
        ' Sound and Vibration, Nov.
        modo = 3
        T1 = 0
        T2 = 0
        Tx = 0
        calculado = False
        Button1.FlatStyle = FlatStyle.Standard
        handleDAMPING = False
        ST.Text = ""
        ckCONJ.Enabled = False
        Amort2.Enabled = False

        TB.Text = ""
        BTcopy.Visible = False

        Dim X(,), Y(,), i As Double

        If ComboBox1.SelectedItem Is Nothing Or ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Primero es necesario seleccionar un par de registros", "ups", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim S12(,), S11(,) As Double
        Dim mS12(), mS11() As Double

        'se leen los registros
        If checkBool(radtamaño2) Then
            X = reg_o_espectro(ComboBox1.SelectedItem, False, CInt(TxTamaño.Text))
            Y = reg_o_espectro(ComboBox2.SelectedItem, False, CInt(TxTamaño.Text))
        Else
            X = reg_o_espectro(ComboBox1.SelectedItem, False)
            Y = reg_o_espectro(ComboBox2.SelectedItem, False)
        End If
        Dim tam As Integer 'el tamaño de la ventana
        If radForz2.Checked = True Then
            tam = CInt(TBventana2.Text) 'indicado
        Else
            'se decide
            tam = Math.Truncate(X.Length / 6)
            Dim P As Single = Math.Log(tam) / Math.Log(2)
            If P <> CInt(P) Then '¿La potencia no es un entero?
                Dim supe As Int16
                'El tamaño de N se rectifica a el número superior más próximo que 
                'puede expresarse como potencia entera de 2.
                supe = CInt(P.ToString.Substring(0, P.ToString.IndexOf("."))) + 1
                tam = 2 ^ supe
            End If
        End If

        'Se decide el valor de traslape de las ventanas
        Dim traslape As Integer
        If ch_Traslape2.Checked = True Then
            traslape = CInt(tb_traslape2.Text) 'indicado
            If traslape >= tam - 1 Then
                traslape = tam / 2
            End If
        Else
            traslape = tam / 2 'la mitad de la ventana se traslapa
        End If
        tb_traslape2.Text = traslape

        'Se prepara un vector con la ventana del tamaño indicado
        Dim Vent(0) As Double
        If Bartlett2.Checked = True Then
            Vent = BartlettHanning(tam - 1)
        ElseIf rb_Hann2.Checked = True Then
            Vent = Hanning(tam - 1)
        ElseIf Rectangular.Checked = True Then
            Vent = Rectang(tam - 1)
        ElseIf rb_Hamming2.Checked = True Then
            Vent = Hamming(tam - 1)
        End If

        Dim j As Integer = 0
        ReDim mS11(tam - 1)
        ReDim mS12(tam - 1)
        Dim x_Hann(tam - 1, 1) As Double
        Dim y_Hann(tam - 1, 1) As Double
        For i = 0 To X.Length / 2 - 1
            'se aplica la ventana
            x_Hann(j, 0) = X(i, 0) * Vent(j)
            x_Hann(j, 1) = X(i, 1)
            y_Hann(j, 0) = Y(i, 0) * Vent(j)
            y_Hann(j, 1) = Y(i, 1)
            If j = Vent.Length - 1 Then
                'se calcula el espectro de Fourier
                x_Hann = TransformadaRápidaDeFourier(x_Hann, tam - 1)
                y_Hann = TransformadaRápidaDeFourier(y_Hann, tam - 1)
                'y los autoespectros
                ST.Text = "Función de densidad espectral Y, o autoespectro Y"
                S11 = Mult_Complx(conju_complx(y_Hann), y_Hann)
                ST.Text = "Función de densidad espectral cruzada"
                S12 = Mult_Complx(conju_complx(x_Hann), y_Hann)
                'acumular los autoespectros
                mS11 = sumar_elementos(mS11, magCohe(S11))
                mS12 = sumar_elementos(mS12, magCohe(S12))
                'restablecer variables para la siguiente ventana
                j = 0
                i = i - traslape
                ReDim x_Hann(tam - 1, 1)
                ReDim y_Hann(tam - 1, 1)
            End If
            j += 1
        Next

        'se calcula la función de transferencia entre el espectro cruzado y el autoespectro:
        ST.Text = "calculando la Funciónd e Transferencia"
        ReDim ftruido(mS12.Length - 1, 1)
        Dim df As Double = 0 'para el Delta t
        For i = 0 To ftruido.Length / 2 - 1
            ftruido(i, 0) = df
            df = df + Form1.SPS / (ftruido.Length / 2)
            ftruido(i, 1) = mS12(i) / mS11(i)
        Next
        ST.Text = "Trazando"
        ST.Text = ""
        Me.Text = "FT entre " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1) & " / " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1)
        ckCONJ.Enabled = True
        If noborrar.Checked = True Then
            sta.Push(ftruido)
            nombSta.Push(Me.Text)
            LA.Text = "acumulando"
        End If
        PIC.Refresh()
    End Sub

    Private Sub BTguardarTransf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTguardarTransf.Click
inicio:

        SFD.FileName = "Ftransf " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_") & " a " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_")
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
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
                If MessageBox.Show("Debe asignar un nombre de archivo válido", "Ups", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Retry Then
                    GoTo inicio
                End If
            End If
        End If
    End Sub

    Private Sub BTguardarTransf2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTguardarTransf2.Click
inicio:

        SFD.FileName = "Ftransf2 " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_") & " a " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_")
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        If SFD.FileName <> "" And Not ftruido Is Nothing Then
            Dim sw As New StreamWriter(SFD.FileName)
            Dim i As Double

            For i = 0 To ftruido.Length / 4 - 1
                sw.Write(ftruido(i, 0).ToString & " " & ftruido(i, 1).ToString & vbNewLine)
            Next
            sw.Flush()
            sw.Close()
        Else
            If ftruido Is Nothing Then
                MessageBox.Show("No hay función de transferencia que guardar", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If SFD.FileName = "" Then
                If MessageBox.Show("Debe asignar un nombre de archivo válido", "Ups", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Retry Then
                    GoTo inicio
                End If
            End If
        End If
    End Sub

    Private Sub BTguardarCoh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTguardarCoh.Click
inicio:

        SFD.FileName = "Coher " & CStr(ComboBox1.SelectedItem).Substring(CStr(ComboBox1.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_") & " a " & CStr(ComboBox2.SelectedItem).Substring(CStr(ComboBox2.SelectedItem).LastIndexOf("\") + 1).Replace(".", "_")
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        If SFD.FileName <> "" And Not Cohe Is Nothing Then
            Dim sw As New StreamWriter(SFD.FileName)
            Dim i As Double

            For i = 0 To Cohe.Length / 4 - 1
                sw.Write(Cohe(i, 0).ToString & " " & Cohe(i, 1).ToString & vbNewLine)
            Next
            sw.Flush()
            sw.Close()
        Else
            If ftransfMAG Is Nothing Then
                MessageBox.Show("No hay función de coherencia que guardar", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If SFD.FileName = "" Then
                If MessageBox.Show("Debe asignar un nombre de archivo válido", "Ups", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Retry Then
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
        'controla la forma en que se va a calcular el amortiguamiento
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

    Private Sub ChB_Color_pres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Color_pres.CheckedChanged
        If ChB_Color_pres.Checked = True Then
            colorGraf = Color.DarkGray
            colorBack = Color.White
            noborrar.Enabled = True
        Else
            colorGraf = Color.GreenYellow
            colorBack = Color.Black
            noborrar.Checked = False
            noborrar.Enabled = False
        End If
    End Sub

    Private Sub noborrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noborrar.CheckedChanged
        If noborrar.Checked = False Then
            sta.Clear()
            nombSta.Clear()
            ley.Visible = False
            PIC.Refresh()
        End If
    End Sub

    'Private Sub RadioBut_Coher_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bartlett.CheckedChanged, rb_Hann.CheckedChanged

    '    If rb_Hann.Checked = True Then
    '        TBventana.Enabled = True
    '        radForz.Enabled = True
    '        radtamaño.Enabled = False
    '        TxTamaño.Enabled = False
    '    Else
    '        TBventana.Enabled = False
    '        radForz.Enabled = False
    '        radtamaño.Enabled = True
    '        TxTamaño.Enabled = True
    '    End If
    'End Sub

#End Region

#Region "PIC"
    Private Sub PIC_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PIC.Paint
        If modo = 1 Then
            If ftransfMAG Is Nothing Then
                Exit Sub
            End If
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            If checkBool(ckLOG) Then
                DrawTransflog(e.Graphics, PIC, ftransfMAG, colorGraf, colorBack, True, checkBool(horzLog), checkBool(ckCONJ))
            Else
                DrawTransf(e.Graphics, PIC, ftransfMAG, colorGraf, colorBack, True, checkBool(ckCONJ))
            End If
            If checkBool(ckCONJ) Then
                ST.ShowPanels = False
            Else
                ST.ShowPanels = True
            End If
        End If
        If modo = 3 Then
            If ftruido Is Nothing Then
                Exit Sub
            End If
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            If checkBool(ckLOG) Then
                DrawTransflog(e.Graphics, PIC, ftruido, colorGraf, colorBack, True, checkBool(horzLog), checkBool(ckCONJ))
            Else
                DrawTransf(e.Graphics, PIC, ftruido, colorGraf, colorBack, True, checkBool(ckCONJ))
            End If
            If checkBool(ckCONJ) Then
                ST.ShowPanels = False
            Else
                ST.ShowPanels = True
            End If
        End If
        If modo = 2 Then
            If Cohe Is Nothing Then
                Exit Sub
            End If
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            If checkBool(ckLOG) Then
                DrawTransflog(e.Graphics, PIC, Cohe, colorGraf, colorBack, True, checkBool(horzLog), checkBool(ckCONJ))
            Else
                If noborrar.Checked = True Then
                    If sta.Count > 1 Then
                        Dim limpia As Boolean = True
                        Dim rr As New Stack
                        Dim i As Int16
                        rr = sta.Clone
                        i = 0
                        Do While rr.Count > 0
                            Cohe = rr.Pop
                            DrawTransf(e.Graphics, PIC, Cohe, ColList(i), colorBack, limpia, checkBool(ckCONJ))
                            i += 1
                            limpia = False
                        Loop
                        Dim nn As New Stack
                        nn = nombSta.Clone
                        ley.t.Text = ""
                        Do While nn.Count > 0
                            ley.t.Text = ley.t.Text & nn.Pop.ToString & vbNewLine
                        Loop
                        ley.Show()
                        LA.Text = ""
                    End If
                Else
                    DrawTransf(e.Graphics, PIC, Cohe, colorGraf, colorBack, True, checkBool(ckCONJ))
                    'Dim f As New Font("Arial", 8, System.Drawing.GraphicsUnit.Point)
                    'Aquí se agregará el texto en futuras versiones
                End If
            End If

            If checkBool(ckCONJ) Then
                ST.ShowPanels = False
            Else
                ST.ShowPanels = True
            End If
        End If
    End Sub

    Private Sub ckbox_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckCONJ.Click, ckLOG.Click, ChB_Color_pres.Click, horzLog.Click
        PIC.Refresh()
    End Sub

    Private Sub PIC_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PIC.MouseMove
        If horzLog.Checked = False Then
            If modo = 1 Then 'si se mostrará la fucnión de transferencia
                If ftransfMAG Is Nothing Then
                    Exit Sub
                End If
                Tx = e.X * (ftransfMAG.Length / 4 - 1) / PIC.Width
                LA.Text = "f: " & Format(ftransfMAG(Tx, 0), "0.###E+0") & " Hz .: T= " & Format(1 / ftransfMAG(Tx, 0), "#.0000") & " s => |FT(f)|=" & Format(ftransfMAG(Tx, 1), "000.00")
            End If
            If modo = 3 Then 'si se mostrará la fucnión de transferencia2
                If ftruido Is Nothing Then
                    Exit Sub
                End If
                Tx = e.X * (ftruido.Length / 4 - 1) / PIC.Width
                LA.Text = "f: " & Format(ftruido(Tx, 0), "0.###E+0") & " Hz .: T= " & Format(1 / ftruido(Tx, 0), "#.0000") & " s => |FT(f)|=" & Format(ftruido(Tx, 1), "000.00")
            End If
            If modo = 2 Then 'si se mostrará la coherencia
                If Cohe Is Nothing Then
                    Exit Sub
                End If
                Tx = e.X * (Cohe.Length / 4 - 1) / PIC.Width
                LA.Text = "f: " & Format(Cohe(Tx, 0), "0.###E+0") & " Hz .: T= " & Format(1 / Cohe(Tx, 0), "#.0000") & " s => |Gamma(f)|=" & Format(Cohe(Tx, 1), "000.00")
            End If
        Else
            LA.Text = ""
        End If
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
                ' Dim ind As Short
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

    Private Sub TrackBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        TT.SetToolTip(TrackBar1, TrackBar1.Value.ToString)
        Form1.Fs = TrackBar1.Value
        ST.Text = "Valor de Fs= " & TrackBar1.Value.ToString & " ... Recalcule para observar los cambios"
        'PIC.Refresh()
        BTtransf.Select()
    End Sub

    Private Sub ckLOG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckLOG.CheckedChanged
        If ckLOG.Checked = True Then
            horzLog.Enabled = True
        Else
            horzLog.Enabled = False
        End If
    End Sub

    Private Sub BTcopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcopiar.Click
        Dim g As Graphics = Graphics.FromImage(gráfico)
        Dim mx As Double = Double.MinValue
        Dim font As New Font("Arial", 7)
        Dim colNeg As New Pen(Color.DarkGray, 0.005)
        If modo = 1 Then
            If ftransfMAG Is Nothing Then
                Exit Sub
            End If
            Dim i As Integer
            For i = 0 To (ftransfMAG.Length / 2 - 1)
                If ftransfMAG(i, 1) > mx Then
                    mx = ftransfMAG(i, 1)
                End If
            Next
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            If checkBool(ckLOG) Then
                DrawTransflog(g, PIC, ftransfMAG, colorGraf, colorBack, True, checkBool(horzLog), checkBool(ckCONJ))
            Else
                DrawTransf(g, PIC, ftransfMAG, colorGraf, colorBack, True, checkBool(ckCONJ))
                For i = 1 To 9 'El eje horizontal
                    g.DrawLine(colNeg, 0 + CInt((ftransfMAG.Length / 2 - 1) * (i / 20)), 0, 0 + CInt((ftransfMAG.Length / 2 - 1) * (i / 20)), CInt(mx / 60)) 'Las rayitas de división rojas en el eje horizontal
                Next
                g.ResetTransform()
                For i = 1 To 9 'El eje horizontal
                    g.DrawString(Format(ftransfMAG(CInt((ftransfMAG.Length / 2 - 1) * (i / 20)), 0), "F"), _
                    font, Brushes.Gray, 0 + CInt(972 * (i / 10)), 390) 'Los números del eje horizonal
                Next
            End If
            If checkBool(ckCONJ) Then
                ST.ShowPanels = False
            Else
                ST.ShowPanels = True
            End If
        End If
        If modo = 2 Then
            If Cohe Is Nothing Then
                Exit Sub
            End If
            Dim i As Integer
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            If checkBool(ckLOG) Then
                DrawTransflog(g, PIC, Cohe, colorGraf, colorBack, True, checkBool(horzLog), checkBool(ckCONJ))
            Else
                If noborrar.Checked = True Then
                    If sta.Count > 1 Then
                        Dim limpia As Boolean = True
                        Dim rr As New Stack
                        rr = sta.Clone
                        i = 0
                        Do While rr.Count > 0
                            Cohe = rr.Pop
                            DrawTransf(g, PIC, Cohe, ColList(i), colorBack, limpia, checkBool(ckCONJ))
                            i += 1
                            limpia = False
                        Loop
                    End If
                Else
                    DrawTransf(g, PIC, Cohe, colorGraf, colorBack, True, checkBool(ckCONJ))
                End If
                For i = 1 To 9 'El eje horizontal
                    g.DrawLine(colNeg, 0 + CSng((Cohe.Length / 2 - 1) * (i / 20)), CSng(0), 0 + CSng((Cohe.Length / 2 - 1) * (i / 20)), CSng(0.03)) 'Las rayitas de división rojas en el eje horizontal
                Next
                g.ResetTransform()
                For i = 1 To 9 'El eje horizontal
                    g.DrawString(Format(Cohe(CInt((Cohe.Length / 2 - 1) * (i / 20)), 0), "F"), _
                    font, Brushes.Gray, 0 + CInt(972 * (i / 10)), 390) 'Los números del eje horizonal
                Next
            End If
        End If
        Dim memoria As String = SFD.DefaultExt
        SFD.DefaultExt = ".jpg"
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            gráfico.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            gráfico.Dispose()
            g.Dispose()
        End If
        SFD.DefaultExt = memoria
    End Sub

#End Region

#Region "Funciones"
    <DebuggerStepThrough()> Sub lista(ByVal t As String, ByVal d() As Double)
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

    End Sub

    Function reg_o_espectro(ByVal ruta As String, Optional ByVal calc_espectro As Boolean = True, Optional ByVal maxN As Integer = 0) As Double(,)
        Dim rg(,) As Double
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
            If maxN <> 0 Then
                N = maxN
            End If
            ReDim rg(N - 1, 1)
            reg = reg.Remove(0, reg.IndexOf("Delta=") + 6)

            If Form1.Pdecim = "," Then
                reg = reg.Replace(".", ",")
            Else
                reg = reg.Replace(",", ".")
            End If

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

            If Form1.Pdecim = "," Then
                reg = reg.Replace(".", ",")
            Else
                reg = reg.Replace(",", ".")
            End If

            'el ancho de la columna es fijo=12 en el formado ascii
            ReDim rg((reg.Length) * 1 / (12 * Form1.diezmado) - 1, 1)
            If maxN <> 0 Then
                ReDim rg(maxN, 1)
            End If
            'rg(i, 1) = 0
            For j = 0 To ((reg.Length - 1)) Step (12 * Form1.diezmado / 1)
                Try
                    rg(i, 0) = reg.Substring(j, 12)
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Catch ex As Exception
                    Err.Clear()
                    If j >= maxN Then
                        Exit For
                    End If
                End Try
                i += 1
            Next
        End If
        ST.Text = "Calculando la FFT"
        ' cálculo de la transformada de fourier
        Tam_Orig = rg.Length / 2 - 1
        If calc_espectro = False Then
            Return rg
        Else
            reg_o_espectro = TransformadaRápidaDeFourier(rg, Tam_Orig)
        End If
    End Function

    Function magnitud_(ByVal rgf(,) As Double, _
    Optional ByVal force As Int16 = -1) As Double() '0 no suav, 1 cuadrat, 2 ventana f(frec)
        'Cálculo de la amplitud suavizada del espectro.

        ST.Text = "Evaluando módulo del espectro"
        Dim mag() As Double
        Dim i, j As Double
        Dim ka As Integer = (Form1.SPS / 100)
        If ka < 1 Then
            ka = 1
        End If
        ReDim mag((rgf.Length / (2 * ka)) - 1)
        For i = 0 To mag.Length - 1
            mag(i) = (Math.Sqrt(rgf(j, 0) ^ 2 + rgf(j, 1) ^ 2)) / (Form1.SPS)
            j += ka
        Next

        'Revisamos si hay un override
        '*si no se indica force, entonces se decide por los RadioButtons
        If force = 0 Then
            magnitud_ = mag.Clone
            Exit Function
        ElseIf force = 1 Then
            GoTo dos
        ElseIf force = 2 Then
            GoTo tres
        End If

        If RadioButton1.Checked = True Then
            'no se suaviza
        ElseIf RadioButton2.Checked = True Then
dos:
            ST.Text = "Suavizando con un promedio cuadrático de cada punto con sus vecinos"
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
            magnitud_ = mag.Clone
            Exit Function
        ElseIf RadioButton3.Checked = True Then
tres:
            ST.Text = "Suavizando con una ventana en función de la frecuencia y el parámetro de suavizado Fs"
            Dim s As Int16
            For s = 1 To NumericUpDown1.Value
                'El mismo suavizado utilizado por Degtra, Tomado del Archivo de ayuda
                'LA VENTANA SE HACE MAS GRANDE ENTRE MAYÓR ES LA FRECUENCIA, POR ENDE LAS FRECUENCIAS ALTAS SE ALIZAN EN EXCESO.
                ' suavizado de la magnitud del espectro de frecuencia  
                'La amplitud suavizada para la frecuencia f, As(f)
                '               1   f2                                 f2= f * 2^(1/(2 Fs)) 
                '    [As(f)]= ( -  E [ A(f)]^2 )^0.5
                '               N   f1                                 f1= f * 2^(-1/(2 Fs))
                'N es el número de puntos comprendidos enre f1 y f2
                Dim Fs As Single = Form1.Fs
                Dim aux(), Df As Double
                aux = mag.Clone
                Dim tamaño As Single = mag.Length
                'el máximo en frecuencia es:
                Dim maxf As Single = CInt(tamaño / 2) * Form1.SPS / tamaño

                For i = 1 To mag.Length - 2
                    Dim f1, f2 As Double
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
            magnitud_ = mag.Clone
            Exit Function
        ElseIf RadioButton4.Checked = True Then
            'Una convinación entre el suavizado 1 y el 2
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

        End If
        magnitud_ = mag.Clone
    End Function

    Function checkBool(ByVal ck As CheckBox) As Boolean
        checkBool = ck.Checked
    End Function

    Function erri(ByVal i As Int16, ByVal r(,) As Double, ByVal mx() As Double, ByVal dm() As Double, ByVal g() As Double, ByVal which As Int16) As Double

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

    Function Hanning(ByVal tamaño As Int16) As Double()
        Dim i As Integer
        Dim Hann(tamaño) As Double
        For i = 0 To tamaño - 1
            Hann(i) = 0.5 * (1 - Math.Cos(2 * Math.PI * (i / tamaño)))
        Next
        Return Hann
    End Function

    Function BartlettHanning(ByVal tamaño As Int16) As Double()
        Dim i As Integer
        Dim Hann(tamaño) As Double
        For i = 0 To tamaño - 1
            Hann(i) = 0.62 - 0.48 * Math.Abs(i / tamaño - 0.5) + 0.38 * Math.Cos(2 * Math.PI * (i / tamaño - 0.5))
        Next
        Return Hann
    End Function

    Function Rectang(ByVal tamaño As Int16) As Double()
        Dim i As Integer
        Dim Rect(tamaño) As Double
        For i = 0 To tamaño - 1
            Rect(i) = 1
        Next
        Return Rect
    End Function

    Function Hamming(ByVal tamaño As Int16) As Double()
        Dim i As Integer
        Dim Hamm(tamaño) As Double
        For i = 0 To tamaño - 1
            Hamm(i) = 0.53836 - 0.46164 * Math.Cos(2 * Math.PI * i / tamaño)
        Next
        Return Hamm
    End Function

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTamaño.KeyPress
        e.Handled = Solonum(Asc(e.KeyChar))
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Form1.Fs = TrackBar1.Value
    End Sub

    Function sumar_elementos(ByVal r() As Double, ByVal g() As Double) As Double()
        If r.Length <> g.Length Then
            Beep()
            Err.Raise(vbObjectError + 513, "suma de elementos", "No tienen el mismo tamaño")
        Else
            Dim i As Integer
            For i = 0 To r.Length - 1
                r(i) = r(i) + g(i)
            Next
        End If
        Return r
    End Function

    Function magCohe(ByVal rgf(,) As Double) As Double()
        'magnitud
        Dim i, j, k As Integer
        Dim mag() As Double

        ReDim mag((rgf.Length / 2) - 1)

        For i = 0 To mag.Length - 1
            On Error Resume Next
            mag(i) = Math.Sqrt(rgf(i, 0) ^ 2 + rgf(i, 1) ^ 2)
        Next
        magCohe = mag.Clone
    End Function

    Function llenarCoList() As Color()
        Dim s(17) As Color
        s(0) = Color.FromArgb(128, 128, 128)
        s(1) = Color.FromArgb(0, 40, 81)
        s(2) = Color.FromArgb(0, 73, 147)
        s(3) = Color.FromArgb(0, 112, 223)
        s(4) = Color.FromArgb(89, 172, 255)
        s(5) = Color.FromArgb(0, 83, 0)
        s(6) = Color.FromArgb(0, 176, 0)
        s(7) = Color.FromArgb(0, 255, 0)
        s(8) = Color.FromArgb(81, 255, 81)
        s(9) = Color.FromArgb(102, 0, 0)
        s(10) = Color.FromArgb(187, 0, 0)
        s(11) = Color.FromArgb(255, 0, 0)
        s(12) = Color.FromArgb(255, 74, 74)
        s(13) = Color.FromArgb(83, 41, 0)
        s(14) = Color.FromArgb(89, 45, 0)
        s(15) = Color.FromArgb(193, 97, 0)
        s(16) = Color.FromArgb(255, 157, 60)
        Return s
    End Function
#End Region

    
   
End Class
