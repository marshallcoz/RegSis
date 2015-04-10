Imports System.IO
Public Class Form1
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
    Friend WithEvents BTabrir As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTcopiar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTclonar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTpegar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTdiezmar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTescalar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTfiltrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTlineabase As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTceros As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BTdeshacer As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTrehacer As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents st As System.Windows.Forms.StatusBarPanel
    Friend WithEvents st2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ProG As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents BTguardar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BTsps As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTabrirreciente As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTzoommas As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTzoommenos As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTabrirvarios As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTfft As System.Windows.Forms.ToolBarButton
    Public WithEvents TB As System.Windows.Forms.ToolBar
    Friend WithEvents BTtransf As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTabrirrecientevar As System.Windows.Forms.ToolBarButton
    Friend WithEvents BTprop As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.TB = New System.Windows.Forms.ToolBar
        Me.BTabrir = New System.Windows.Forms.ToolBarButton
        Me.BTabrirreciente = New System.Windows.Forms.ToolBarButton
        Me.BTabrirvarios = New System.Windows.Forms.ToolBarButton
        Me.BTabrirrecientevar = New System.Windows.Forms.ToolBarButton
        Me.BTguardar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.BTcopiar = New System.Windows.Forms.ToolBarButton
        Me.BTclonar = New System.Windows.Forms.ToolBarButton
        Me.BTpegar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.BTsps = New System.Windows.Forms.ToolBarButton
        Me.BTlineabase = New System.Windows.Forms.ToolBarButton
        Me.BTdiezmar = New System.Windows.Forms.ToolBarButton
        Me.BTescalar = New System.Windows.Forms.ToolBarButton
        Me.BTceros = New System.Windows.Forms.ToolBarButton
        Me.BTfft = New System.Windows.Forms.ToolBarButton
        Me.BTfiltrar = New System.Windows.Forms.ToolBarButton
        Me.BTtransf = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.BTdeshacer = New System.Windows.Forms.ToolBarButton
        Me.BTrehacer = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.BTzoommas = New System.Windows.Forms.ToolBarButton
        Me.BTzoommenos = New System.Windows.Forms.ToolBarButton
        Me.BTprop = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.st = New System.Windows.Forms.StatusBarPanel
        Me.st2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.ProG = New System.Windows.Forms.ProgressBar
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        CType(Me.st, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.st2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB
        '
        Me.TB.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.TB.AutoSize = False
        Me.TB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TB.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.BTabrir, Me.BTabrirreciente, Me.BTabrirvarios, Me.BTabrirrecientevar, Me.BTguardar, Me.ToolBarButton1, Me.BTcopiar, Me.BTclonar, Me.BTpegar, Me.ToolBarButton2, Me.BTsps, Me.BTlineabase, Me.BTdiezmar, Me.BTescalar, Me.BTceros, Me.BTfft, Me.BTfiltrar, Me.BTtransf, Me.ToolBarButton3, Me.BTdeshacer, Me.BTrehacer, Me.ToolBarButton4, Me.BTzoommas, Me.BTzoommenos, Me.BTprop})
        Me.TB.ButtonSize = New System.Drawing.Size(16, 16)
        Me.TB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TB.DropDownArrows = True
        Me.TB.ImageList = Me.ImageList1
        Me.TB.Location = New System.Drawing.Point(0, 0)
        Me.TB.Name = "TB"
        Me.TB.ShowToolTips = True
        Me.TB.Size = New System.Drawing.Size(1065, 33)
        Me.TB.TabIndex = 0
        '
        'BTabrir
        '
        Me.BTabrir.ImageIndex = 0
        Me.BTabrir.Tag = "BTabrir"
        Me.BTabrir.ToolTipText = "Editar un registro"
        '
        'BTabrirreciente
        '
        Me.BTabrirreciente.ImageIndex = 14
        Me.BTabrirreciente.Tag = "BTabrirreciente"
        Me.BTabrirreciente.ToolTipText = "Editar el último registro consultado"
        '
        'BTabrirvarios
        '
        Me.BTabrirvarios.ImageIndex = 17
        Me.BTabrirvarios.Tag = "BTabrirvarios"
        Me.BTabrirvarios.ToolTipText = "Editar varios registros al mismo tiempo"
        '
        'BTabrirrecientevar
        '
        Me.BTabrirrecientevar.ImageIndex = 20
        Me.BTabrirrecientevar.Tag = "BTabrirrecientevar"
        '
        'BTguardar
        '
        Me.BTguardar.ImageIndex = 13
        Me.BTguardar.Tag = "BTguardar"
        Me.BTguardar.ToolTipText = "Guardar los cambios"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'BTcopiar
        '
        Me.BTcopiar.ImageIndex = 1
        Me.BTcopiar.Tag = "BTcopiar"
        Me.BTcopiar.ToolTipText = "Copiar el registro actual (para pegarlo sobre otro)"
        '
        'BTclonar
        '
        Me.BTclonar.ImageIndex = 2
        Me.BTclonar.Tag = "BTclonar"
        Me.BTclonar.ToolTipText = "Duplicar el registro seleccionado"
        '
        'BTpegar
        '
        Me.BTpegar.ImageIndex = 3
        Me.BTpegar.Tag = "BTpegar"
        Me.BTpegar.ToolTipText = "Pegar el registro copiado"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'BTsps
        '
        Me.BTsps.ImageIndex = 5
        Me.BTsps.Tag = "BTsps"
        Me.BTsps.ToolTipText = "Cambiar la taza de SPS "
        '
        'BTlineabase
        '
        Me.BTlineabase.ImageIndex = 6
        Me.BTlineabase.Tag = "BTlineabase"
        Me.BTlineabase.ToolTipText = "Corregir por línea base"
        '
        'BTdiezmar
        '
        Me.BTdiezmar.ImageIndex = 7
        Me.BTdiezmar.Tag = "BTdiezmar"
        Me.BTdiezmar.ToolTipText = "Diezmar los datos"
        '
        'BTescalar
        '
        Me.BTescalar.ImageIndex = 8
        Me.BTescalar.Tag = "BTescalar"
        Me.BTescalar.ToolTipText = "Escalar: Multiplicar por una constante todo el registro"
        '
        'BTceros
        '
        Me.BTceros.ImageIndex = 10
        Me.BTceros.Tag = "BTceros"
        Me.BTceros.ToolTipText = "Agregar Ceros"
        '
        'BTfft
        '
        Me.BTfft.ImageIndex = 18
        Me.BTfft.Tag = "BTfft"
        Me.BTfft.ToolTipText = "Fast Fourier Transform"
        '
        'BTfiltrar
        '
        Me.BTfiltrar.ImageIndex = 9
        Me.BTfiltrar.Tag = "BTfiltrar"
        Me.BTfiltrar.ToolTipText = "Filtrar el registro"
        '
        'BTtransf
        '
        Me.BTtransf.ImageIndex = 19
        Me.BTtransf.Tag = "BTtransf"
        Me.BTtransf.ToolTipText = "Función de transferencia"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'BTdeshacer
        '
        Me.BTdeshacer.ImageIndex = 11
        Me.BTdeshacer.Tag = "BTdeshacer"
        Me.BTdeshacer.ToolTipText = "Deshacer la última acción"
        Me.BTdeshacer.Visible = False
        '
        'BTrehacer
        '
        Me.BTrehacer.ImageIndex = 12
        Me.BTrehacer.Tag = "BTrehacer"
        Me.BTrehacer.ToolTipText = "Rehacer la acción enmendada"
        Me.BTrehacer.Visible = False
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        Me.ToolBarButton4.Visible = False
        '
        'BTzoommas
        '
        Me.BTzoommas.ImageIndex = 15
        Me.BTzoommas.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.BTzoommas.Tag = "BTzoommas"
        Me.BTzoommas.ToolTipText = "Mostrar Detalle"
        '
        'BTzoommenos
        '
        Me.BTzoommenos.ImageIndex = 16
        Me.BTzoommenos.Tag = "BTzoommenos"
        Me.BTzoommenos.Visible = False
        '
        'BTprop
        '
        Me.BTprop.ImageIndex = 21
        Me.BTprop.Tag = "BTprop"
        Me.BTprop.ToolTipText = "Ajustar algunas propiedades"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(20, 20)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusBar1
        '
        Me.StatusBar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 363)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.st, Me.st2, Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1065, 22)
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Text = "StatusBar1"
        '
        'st
        '
        Me.st.Width = 60
        '
        'st2
        '
        Me.st2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.st2.Width = 743
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 246
        '
        'ProG
        '
        Me.ProG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProG.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ProG.Enabled = False
        Me.ProG.Location = New System.Drawing.Point(805, 366)
        Me.ProG.Name = "ProG"
        Me.ProG.Size = New System.Drawing.Size(244, 22)
        Me.ProG.Step = 1
        Me.ProG.TabIndex = 6
        '
        'OFD
        '
        Me.OFD.Filter = "Todos los canales posibles [1 al 12] |*01;*01p;*01P;*02;*02p;*02P;*03;*03p;*03P;*" & _
        "04;*04p;*04P;*05;*05p;*05P;*06;*06p;*06P;*07;*07p;*08P;*08;*08p;*08P;*09;*09p;*0" & _
        "9P;*10;*10p;*10P;*11;*11p;*11P;*12;*12p;*12P|Canal1 (Todo) [*01;*01p;*01P] |*01;" & _
        "*01p;*01P| Canal2 (Todo) [*02;*02p;*02P] |*02;*02p;*02P|  Canal3 (Todo) [*03;*03" & _
        "p;*03P ] |*03;*03p;*03P|Canal1 (raw) [*01] |*01| Canal2 (raw) [*02] |*02|  Canal" & _
        "3 (raw) [*03] |*03|Canal1 (editado) [*01p;*01P ] |*01p;*01P| Canal2 (editado) [*" & _
        "02p;*02P ] |*02p;*02P|  Canal3 (editado) [*03p;*03P ] |*03p;*03P|Mostrar todos l" & _
        "os archivos|*.*"
        Me.OFD.InitialDirectory = "C:"
        Me.OFD.Title = "Archivos por editar"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1065, 385)
        Me.Controls.Add(Me.ProG)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.TB)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Opacity = 0.9
        Me.Text = "ARSis v1.2 -Editor de Registros Sísmicos"
        CType(Me.st, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.st2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones "
    Public Shared diezmado As Int16 = 1  'sin diezmado inicial
    Public Shared SPS As Int16 = 200
    Public Shared VentanaActiva, Fs As Int16
    Dim stt As String
    Public Shared directorioinf As String
    Public Shared clonrg(,) As Double
    Public Shared HandleZoom As Boolean = False
    Public Shared tap, Npol, Infbound, Supbound As Single
#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Static Ind As Int16
        tap = 5
        Fs = 6
        Npol = 4
        Infbound = 0.1
        Supbound = 90
        Try
            reader()
        Catch ex As Exception
            Dim sw As New StreamWriter("C:\Archivos de programa\UAEMex\ARSis v1.2\Eco.inf")
            directorioinf = "C:\Archivos de programa\UAEMex\ARSis v1.2\Eco.inf"
            sw.Write("Archivo reciente=")
            sw.Flush()
            sw.Close()
        End Try
        Dim BoX As New ClassBox
        BoX.Lea_los_datos_EXPORTADOS()
        If BoX.RutaExportada <> "No" Then
            Dim LsT As New Lista
            Ind += 1
            LsT.Tag = Me.MdiChildren.Length
            LsT.MdiParent = Me
            Static listind As Int16
            LsT.Text = "Lista (" & CStr(listind + 1) & ")"
            listind += 1
            LsT.Show()
        End If
    End Sub

    Private Sub TB_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles TB.ButtonClick
        Static listind As Int16
        Static Ind As Int16
        If e.Button.Tag = "BTabrir" Then  '-------------------------------------------------abrir------
abrir:
            OFD.FileName = ""
            If OFD.ShowDialog = DialogResult.OK And OFD.FileName <> "" Then
                Dim st As String
                ProG.Maximum = OFD.FileNames.Length
                For Each st In OFD.FileNames
                    ProG.PerformStep()
                    Dim VnT As New Ventana
                    Ind += 1
                    vnt.Tag = Me.MdiChildren.Length
                    VnT.MdiParent = Me
                    vnt.Text = st
                    VnT.Show()
                Next
                ProG.Value = 0
                ProG.Maximum = 100
            End If
        ElseIf e.Button.Tag = "BTabrirreciente" Then       '------------------------------------abrir reciente-----
            reader()
            If stt <> "" Then
                Dim VnT As New Ventana
                Ind += 1
                vnt.Tag = Me.MdiChildren.Length
                vnt.MdiParent = Me
                vnt.Text = stt
                Try
                    vnt.Show()
                Catch ex As Exception
                    GoTo abrir
                End Try
            Else
                st.Text = "Error"
            End If
        ElseIf e.Button.Tag = "BTabrirvarios" Then       '--------------------------------------abrir varios-----
abrirvarios:
            Dim box As New ClassBox
            Dim LsTa As New Lista
            Ind += 1
            LsTa.Tag = Me.MdiChildren.Length
            LsTa.MdiParent = Me
            'Static listind As Int16
            LsTa.Text = "Lista (" & CStr(listind + 1) & ")"
            listind += 1
            LsTa.Show()

        ElseIf e.Button.Tag = "BTabrirrecientevar" Then   '-------------------------abrir consulta -------
            'que habra archivos de consulta
            Dim Box As New ClassBox
            OFD.FileName = ""
            OFD.Filter = "Archivos de Consulta|*.consulta|Mostrar todos los archivos|*.*"
            OFD.InitialDirectory = Environment.SpecialFolder.MyComputer

            If OFD.ShowDialog = DialogResult.OK And OFD.FileName <> "" Then
                Box.RutaExportada = OFD.FileName
                Box.GuardarOpciones()

                Dim LsT As New Lista
                Ind += 1
                LsT.Tag = Me.MdiChildren.Length
                LsT.MdiParent = Me

                LsT.Text = "Lista (" & CStr(listind + 1) & ")"
                listind += 1
                LsT.Show()
            End If
            OFD.Filter = "Todos los canales posibles [1 al 12] |*01;*01p;*01P;*02;*02p;*02P;*03;*03p;*03P;*04;*04p;*04P;*05;*05p;*05P;*06;*06p;*06P;*07;*07p;*08P;*08;*08p;*08P;*09;*09p;*09P;*10;*10p;*10P;*11;*11p;*11P;*12;*12p;*12P|Canal1 (Todo) [*01;*01p;*01P] |*01;*01p;*01P| Canal2 (Todo) [*02;*02p;*02P] |*02;*02p;*02P|  Canal3 (Todo) [*03;*03p;*03P ] |*03;*03p;*03P|Canal1 (raw) [*01] |*01| Canal2 (raw) [*02] |*02|  Canal3 (raw) [*03] |*03|Canal1 (editado) [*01p;*01P ] |*01p;*01P| Canal2 (editado) [*02p;*02P ] |*02p;*02P|  Canal3 (editado) [*03p;*03P ] |*03p;*03P|Mostrar todos los archivos|*.*"
        ElseIf e.Button.Tag = "BTguardar" Then       '--------------------------------------guardar----------
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[Gu] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If

            'ElseIf e.Button.Tag = "BTnuevo" Then       '-------------------------------------------------------
            '    Dim VnT As New Ventana
            '    Ind += 1
            '    vnt.Tag = Me.MdiChildren.Length
            '    VnT.MdiParent = Me
            '    VnT.Text = "Nueva ventana (" & Ind.ToString & ")"
            '    VnT.Show()
        ElseIf e.Button.Tag = "BTcopiar" Then       '----------------------------------------copiar---------
            If Not Me.MdiChildren.Length = Nothing Then
                If Me.MdiChildren(VentanaActiva).Text.LastIndexOf("Lista") >= 0 Then
                    st2.Text = "No es un comando accesible para una lista"
                    Exit Sub
                End If
                st2.Text = "[CP] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTclonar" Then       '------------------------------------------clonar-------
            If Not Me.MdiChildren.Length = Nothing Then
                If Me.MdiChildren(VentanaActiva).Text.LastIndexOf("Lista") >= 0 Then
                    st2.Text = "No es un comando accesible para una lista"
                    Exit Sub
                End If
                st2.Text = "[CL] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
                Dim VnT As New Ventana
                Ind += 1
                vnt.Tag = Me.MdiChildren.Length
                VnT.MdiParent = Me
                VnT.Text = "Clon de " & st2.Text
                VnT.Show()
            End If
        ElseIf e.Button.Tag = "BTpegar" Then       '----------------------------------------pegar----------
            If Not Me.MdiChildren.Length = Nothing Or Not clonrg Is Nothing Then
                If Me.MdiChildren(VentanaActiva).Text.LastIndexOf("Lista") >= 0 Then
                    st2.Text = "No es un comando accesible para una lista"
                    Exit Sub
                End If
                st2.Text = "[Pg] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTsps" Then       '------------------------------------------sps----------
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[SP] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTlineabase" Then       '-------------------------------------------linea base---
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[LB] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTdiezmar" Then       '-----------------------------------------diezmar-------
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[Dz] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTescalar" Then       '-----------------------------------------escalar-------
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[Es] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTceros" Then       '-----------------------------------agregar ceros----------
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[Cr] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
            'ElseIf e.Button.Tag = "BTdeshacer" Then       '--------------------------------deshacer---------------
            'ElseIf e.Button.Tag = "BTrehacer" Then        '--------------------------------rehacer----------------
        ElseIf e.Button.Tag = "BTzoommas" Then        '--------------------------------zoom-------------------
            If e.Button.Pushed = True Then
                HandleZoom = True
            Else
                HandleZoom = False
            End If
        ElseIf e.Button.Tag = "BTfft" Then            '------------------------------fastfouriertransform-----
            If Not Me.MdiChildren.Length = Nothing Then
                If Me.MdiChildren(VentanaActiva).Text.LastIndexOf("Lista") >= 0 Then
                    st2.Text = "No es un comando accesible para una lista"
                    Exit Sub
                End If
                st2.Text = "[FT] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTfiltrar" Then       '----------------------------------------filtrar--------
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "[Ft] " & Me.MdiChildren(VentanaActiva).Text
                Me.MdiChildren(VentanaActiva).Text = st2.Text
            End If
        ElseIf e.Button.Tag = "BTtransf" Then        '---------------------------función de transferencia-----
            If Not Me.MdiChildren.Length = Nothing Then
                st2.Text = "Función de transferencia"
                'Se prepara la lista de elementos abiertos
                Dim elementos(), aux() As String
                Dim i As Int16

                For i = 0 To Me.MdiChildren.Length - 1
                    If Me.MdiChildren(i).Name = "Lista" And Me.MdiChildren(i).Visible = True Then
                        Dim obj As Object = Me.MdiChildren(i)
                        If Not obj.elem Is Nothing Then
                            If elementos Is Nothing Then
                                elementos = obj.elem.clone
                            Else
                                aux = elementos.Clone
                                ReDim elementos(aux.Length + obj.elem.length - 1)
                                Array.Copy(aux, elementos, aux.Length)
                                Array.Copy(obj.elem, 0, elementos, aux.Length, obj.elem.length)
                            End If
                        End If
                    ElseIf Me.MdiChildren(i).Name = "Ventana" And Me.MdiChildren(i).Visible = True Then
                        Dim obj As Object = Me.MdiChildren(i)
                        If elementos Is Nothing Then
                            ReDim elementos(0)
                            elementos(0) = obj.ruta
                        Else
                            aux = elementos.Clone
                            ReDim elementos(aux.Length)
                            Array.Copy(aux, elementos, aux.Length)
                            elementos(elementos.Length - 1) = obj.ruta
                        End If
                    End If
                Next
                Dim transf As New Transf
                transf.ComboBox1.Items.AddRange(elementos)
                transf.ComboBox2.Items.AddRange(elementos)
                transf.Show()
            End If
        ElseIf e.Button.Tag = "BTprop" Then '----------------------ajustar las propiedades------------
            Dim prop As New prop
            prop.ShowDialog()
        End If
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = False
    End Sub

    Function reader()         'leer directorio base
        Dim strd As New StreamReader("C:\Archivos de programa\UAEMex\ARSis v1.2\Eco.inf")
        directorioinf = "C:\Archivos de programa\UAEMex\ARSis v1.2\Eco.inf"
        stt = strd.ReadLine
        strd.Close()
        stt = stt.Remove(0, stt.LastIndexOf("=") + 1)
    End Function


End Class
