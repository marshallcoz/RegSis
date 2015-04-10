Imports System.IO
Public Class Main

    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    <System.Diagnostics.DebuggerStepThrough()> Public Sub New()
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents St As System.Windows.Forms.StatusBar
    Friend WithEvents BtnDirectorioRaiz As System.Windows.Forms.MenuItem
    Friend WithEvents BtnActualizarBase As System.Windows.Forms.MenuItem
    Friend WithEvents BtnSalir As System.Windows.Forms.MenuItem
    Friend WithEvents LV1 As System.Windows.Forms.ListView
    Public WithEvents TV1 As System.Windows.Forms.TreeView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProG As System.Windows.Forms.ProgressBar
    Friend WithEvents S2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.BtnDirectorioRaiz = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.BtnActualizarBase = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.BtnSalir = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.TV1 = New System.Windows.Forms.TreeView
        Me.St = New System.Windows.Forms.StatusBar
        Me.S2 = New System.Windows.Forms.StatusBarPanel
        Me.LV1 = New System.Windows.Forms.ListView
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProG = New System.Windows.Forms.ProgressBar
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.S2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5, Me.MenuItem7, Me.MenuItem13, Me.MenuItem15})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.BtnDirectorioRaiz, Me.BtnActualizarBase, Me.MenuItem3, Me.BtnSalir})
        Me.MenuItem1.Text = "&Sistema de Archivos          "
        '
        'BtnDirectorioRaiz
        '
        Me.BtnDirectorioRaiz.Index = 1
        Me.BtnDirectorioRaiz.Text = "&Nuevo Directorio Base "
        '
        'MenuItem4
        '
        Me.MenuItem4.DefaultItem = True
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Directorio Base &Reciente"
        '
        'BtnActualizarBase
        '
        Me.BtnActualizarBase.Index = 2
        Me.BtnActualizarBase.Text = "&Actualizar Base"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "-"
        '
        'BtnSalir
        '
        Me.BtnSalir.Index = 4
        Me.BtnSalir.Text = "&Salir"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem6, Me.MenuItem12, Me.MenuItem14})
        Me.MenuItem5.Text = "&Consultar       "
        '
        'MenuItem2
        '
        Me.MenuItem2.DefaultItem = True
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Carpeta (s) palomeadas"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "&Borrar Selección"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "Abrir una Consulta Guardada"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem11, Me.MenuItem19, Me.MenuItem20, Me.MenuItem9, Me.MenuItem10, Me.MenuItem18, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem7.Text = "Acción         "
        '
        'MenuItem8
        '
        Me.MenuItem8.Checked = True
        Me.MenuItem8.Index = 0
        Me.MenuItem8.RadioCheck = True
        Me.MenuItem8.Text = "Mostrar Vista Previa de registros / Descompresión de .EVTs"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 2
        Me.MenuItem19.Text = "Abir Selección con el Editor de Registros Sísmicos"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.RadioCheck = True
        Me.MenuItem9.Text = "Abrir con el programa predeterminado por Windows"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Text = "Abrir carpeta contenedora"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MenuItem21.Text = "Eliminar elementos seleccionados"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Text = "Copiar elementos seleccionados a una ubicación distinta"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 9
        Me.MenuItem23.Text = "Asignar a un sensor en particular"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "Configuración"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem17})
        Me.MenuItem15.Text = "Ayuda              "
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem16.Text = "Ayuda"
        Me.MenuItem16.Visible = False
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "Información"
        '
        'TV1
        '
        Me.TV1.CheckBoxes = True
        Me.TV1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TV1.HideSelection = False
        Me.TV1.Location = New System.Drawing.Point(0, 0)
        Me.TV1.Name = "TV1"
        Me.TV1.Size = New System.Drawing.Size(158, 310)
        Me.TV1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TV1, resources.GetString("TV1.ToolTip"))
        '
        'St
        '
        Me.St.Location = New System.Drawing.Point(158, 288)
        Me.St.Name = "St"
        Me.St.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.S2})
        Me.St.Size = New System.Drawing.Size(583, 22)
        Me.St.TabIndex = 2
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Width = 80
        '
        'LV1
        '
        Me.LV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV1.FullRowSelect = True
        Me.LV1.GridLines = True
        Me.LV1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV1.Location = New System.Drawing.Point(158, 0)
        Me.LV1.Name = "LV1"
        Me.LV1.Size = New System.Drawing.Size(583, 288)
        Me.LV1.SmallImageList = Me.ImageList
        Me.LV1.TabIndex = 1
        Me.LV1.UseCompatibleStateImageBehavior = False
        Me.LV1.View = System.Windows.Forms.View.Details
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
        Me.ImageList.Images.SetKeyName(12, "")
        Me.ImageList.Images.SetKeyName(13, "")
        Me.ImageList.Images.SetKeyName(14, "")
        Me.ImageList.Images.SetKeyName(15, "")
        Me.ImageList.Images.SetKeyName(16, "Icon1RAW.ico")
        Me.ImageList.Images.SetKeyName(17, "Icon1PRO.ico")
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(158, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 288)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(77, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 129)
        Me.Panel1.TabIndex = 4
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(376, 76)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(130, 22)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.Text = "Formatted Header"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(236, 76)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 22)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Short Header"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(234, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo de Heder al descomprimir:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aceptar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Para la vista previa:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Factor de Diezmado"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(133, 52)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Tag = ""
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración de la consulta de registros"
        '
        'ProG
        '
        Me.ProG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProG.Location = New System.Drawing.Point(483, 291)
        Me.ProG.Name = "ProG"
        Me.ProG.Size = New System.Drawing.Size(238, 16)
        Me.ProG.Step = 1
        Me.ProG.TabIndex = 6
        '
        'OFD
        '
        Me.OFD.DefaultExt = "consulta"
        Me.OFD.Filter = "Archivos de consulta [*.consulta]|*.consulta"
        Me.OFD.Title = "Abrir un archivo de consulta"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(741, 310)
        Me.Controls.Add(Me.ProG)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.LV1)
        Me.Controls.Add(Me.St)
        Me.Controls.Add(Me.TV1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Main"
        Me.Text = "IdEst - Base de Registros"
        CType(Me.S2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones generales"
    Const MB As Long = 1024 * 1024       'constante para transformar de bytes a mega bytes
    Const KB As Long = 1024              'constante para transformar de bytes a kilo bytes
    Dim CurrentDirInfo As DirectoryInfo  'colección de información sobre el directorio seleccionado
    Public Shared stt As String          'texto que se lee del archivo que guarda la ruta al directorio anterior
    Public Shared lv() As ListViewItem   'arreglo de elementos de la lista para pasar los datos de un lado a otro
    Dim i As Int32 = 0                   'contador
    Public Shared FrmConslt As New Consulta   'ventana consulta
    Public Shared diezmado As Int16 = 5  'Factor de diezmado, la cantidad de muestras de cada diez
    Dim ArrFileInfo() As FileInfo
    Public Shared Pdecim As String
#End Region

#Region "Eventos de Objeto"

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LV1.Columns.Add("Nombre", 140, HorizontalAlignment.Left)
        LV1.Columns.Add("Tamaño", 90, HorizontalAlignment.Center)
        LV1.Columns.Add("Modificado", 90, HorizontalAlignment.Left)
        LV1.Columns.Add("Creado", 90, HorizontalAlignment.Left)
        'LV1.Columns.Add("SoloLectura", 90, HorizontalAlignment.Left)
        ReDim lv(0)
        Panel1.Visible = False

        'Dependiendo las librerìas, windows identifica el punto decimal como "." o bien ","
        'se hace una preuba para saber y no cometer errores
        If CDbl("0.2") = 0.2 Then
            'es con el punto
            Pdecim = "."
        Else
            'es la coma
            Pdecim = ","
        End If
    End Sub

    'menús
    '  Sistema de archivos
    Private Sub BtnDirectorioRaiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDirectorioRaiz.Click
        stt = ""
        botonraiz()
    End Sub

    Private Sub base_directorio_base_reciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        'base; directorio base reciente
        'cambiar con la instalación ->  al igual que el de folderlist
        reader()
        St.Text = "Ruta: " + stt
        botonraiz()
    End Sub

    Private Sub BtnActualizarBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizarBase.Click
        'actualizar sin solicitar la elección de un nuevo directorio base
        If stt = "" Then
            reader()
        End If
        Dim DndDirecSel As DirectoryNode 'tipo treenode extendido
        'borrar contenido
        TV1.Nodes.Clear()
        LV1.Items.Clear()
        Try
            DndDirecSel = New DirectoryNode
            DndDirecSel.Text = stt
            TV1.Nodes.Add(DndDirecSel) 'se agrega el nodo de directorio base
            'se calcula el tamaño
            DndDirecSel.Size += GetDirectorySize(stt, _
               DndDirecSel)
        Catch ex As Exception
            'Se evita el error pero no se resuelve
        End Try
        TV1.SelectedNode = TV1.TopNode
        TV1.SelectedNode.Expand()

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        'base; salir
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Configuración(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        'configuración
        TV1.Enabled = False
        LV1.Enabled = False
        Panel1.Visible = True

    End Sub
    '  Consultar
    Private Sub Consulta_EventosSeleccionados(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        consultar()
    End Sub

    Private Sub BorrarSelección(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        TV1.CheckBoxes = False
        TV1.CheckBoxes = True
        On Error Resume Next

        TV1.SelectedNode = TV1.TopNode
        TV1.SelectedNode.Expand()

        ReDim lv(0)
        i = 0
    End Sub

    Private Sub Abrir_Consulta_GUARDADA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        OFD.InitialDirectory = Environment.SpecialFolder.MyComputer
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim str(0), aux(), s As String
            Dim sr As New StreamReader(OFD.FileName)
            s = sr.ReadToEnd
            sr.Close()
            s = s.Replace(vbNewLine, "")
            Do
                If Not str(0) Is Nothing Then
                    aux = str.Clone
                    ReDim str(str.Length)
                    Array.Copy(aux, str, aux.Length)
                End If
                Try
                    str(str.Length - 1) = s.Substring(0, s.IndexOf(":", 2) - 1)
                Catch ex As Exception
                    str(str.Length - 1) = s
                End Try
                s = s.Substring(str(str.Length - 1).Length)
            Loop Until s = ""
            Dim z As Int16
            ReDim lv(str.Length - 1)
            For z = 0 To str.Length - 1
                Dim FileInf As New FileInfo(str(z))
                Dim LVitm As New ListViewItem(FileInf.Name)
                'se ponen los íconos
                Select Case Path.GetExtension(FileInf.Name).ToUpper
                    Case ".EVT"
                        LVitm.ImageIndex = 0
                    Case ".TXT"
                        LVitm.ImageIndex = 1
                    Case ".EXE"
                        LVitm.ImageIndex = 2
                    Case ".DWG"
                        LVitm.ImageIndex = 3
                    Case ".PDF"
                        LVitm.ImageIndex = 4
                    Case ".001P", ".A01P", ".B01P", ".C01P"
                        LVitm.ImageIndex = 8
                    Case ".002P", ".A02P", ".B02P", ".C02P"
                        LVitm.ImageIndex = 9
                    Case ".003P", ".A03P", ".B03P", ".C03P"
                        LVitm.ImageIndex = 10
                    Case ".HDR", ".HDA", ".HDB", ".HDC"
                        LVitm.ImageIndex = 11
                    Case ".SHD", ".SHA", ".SHB", ".SHC"
                        LVitm.ImageIndex = 12
                    Case ".001", ".A01", ".B01", ".C01"
                        LVitm.ImageIndex = 13
                    Case ".002", ".A02", ".B02", ".C02"
                        LVitm.ImageIndex = 14
                    Case ".003", ".A03", ".B03", ".C03"
                        LVitm.ImageIndex = 15
                    Case ".004", ".005", ".006", ".007", ".008", ".009", ".010", ".011", ".012", ".013", ".014", ".015", ".016", ".017", ".018", ".019", ".020", ".021", ".022", ".023", ".024"
                        'cualquier otro canal adicional
                        LVitm.ImageIndex = 16
                    Case ".004P", ".005P", ".006P", ".007P", ".008P", ".009P", ".010P", ".011P", ".012P", ".013P", ".014P", ".015P", ".016P", ".017P", ".018P", ".019P", ".020P", ".021P", ".022P", ".023P", ".024P"
                        'cualquier otro canal adicional procesado
                        LVitm.ImageIndex = 17
                    Case Else
                        LVitm.ImageIndex = 5
                End Select
                'agregar subelementos 
                If FileInf.Length / MB >= 1 Then
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / MB), "F") + "mb")
                    LVitm.SubItems.Add(Format(FileInf.Length / MB, "F") + "mb")
                Else
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / KB), "F") + "kb")
                    LVitm.SubItems.Add(Format(FileInf.Length / KB, "F") + "kb")
                End If
                LVitm.SubItems.Add(FileInf.LastWriteTime.ToString)
                LVitm.SubItems.Add(FileInf.CreationTime.ToString)
                'LVitm.SubItems.Add(FileInf.Attributes.ReadOnly.ToString)
                LVitm.SubItems.Add(FileInf.FullName)

                lv.SetValue(LVitm, z)
            Next
            consultar()

        End If
    End Sub
    '  Acción
    Private Sub Vistaprevia(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'vista previa
        MenuItem8.Checked = True
        MenuItem9.Checked = False
        MenuItem10.Checked = False
    End Sub

    Private Sub abrir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'abrir
        MenuItem8.Checked = False
        MenuItem9.Checked = True
        MenuItem10.Checked = False
    End Sub

    Private Sub abrircarpetacontenedora(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        'abrir carpeta contenedora
        MenuItem8.Checked = False
        MenuItem9.Checked = False
        MenuItem10.Checked = True
    End Sub

    Private Sub Abrir_selección_con_el_editor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Try
            Dim LVitem As ListViewItem
            Dim Cadena As String = Path.GetTempPath & "\Reg" & Now.Second.ToString 'Lo que se exporta  : El xml no puede codificar vectores así que solo se pasa la dirección 
            Dim sw As New StreamWriter(Cadena)
            For Each LVitem In LV1.SelectedItems
                If checarextensión(LVitem.Text.ToUpper) Then
                    St.Text = "Exportando registro " & Path.Combine(CurrentDirInfo.FullName, LVitem.Text)
                    sw.WriteLine(Path.Combine(CurrentDirInfo.FullName, LVitem.Text))
                End If
            Next
            sw.Flush()
            sw.Close()
            Dim BoX As New ClassBox
            BoX.Lea_los_datos_EXPORTADOS()
            BoX.RutaExportada = Cadena
            BoX.GuardarOpciones()
            St.Text = "Abriendo el Editor de Registros Sísmicos ..."
            Dim p As New Process
            p = Process.Start("C:\Archivos de programa\UAEMex\IdEst\Editor de Registros Sísmicos.exe")
            St.Text = ""
        Catch ex As Exception
            St.Text = Err.Description
            Err.Clear()
        End Try
    End Sub

    Private Sub Asignar_Sensor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim cual As New Dialog1
        St.Text = "Asingnando al sensor"
        If cual.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim LVitem As ListViewItem
                For Each LVitem In LV1.SelectedItems
                    If checarextensión(LVitem.Text.ToUpper) Then
                        'preparar nombre
                        Dim nombre_final, actual, cambio As String
                        actual = LVitem.Text.Substring(LVitem.Text.LastIndexOf("."), 2)
                        cambio = "." & cual.TextBox1.Text
                        nombre_final = LVitem.Text.Replace(actual, cambio)
                        File.Move(Path.Combine(CurrentDirInfo.FullName, LVitem.Text), Path.Combine(CurrentDirInfo.FullName, nombre_final))
                        File.Delete(Path.Combine(CurrentDirInfo.FullName, LVitem.Text))
                        LVitem.Text = nombre_final
                    End If
                Next
            Catch ex As Exception
                St.Text = Err.Description
                Err.Clear()
            End Try
        End If
        St.Text = ""
    End Sub

    'tree view
    Private Sub TV1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterSelect
        If Not e.Node.FullPath = "" Then
            Dim strSubDirectory As DirectoryNode = CType(e.Node, DirectoryNode)
            LV1.Items.Clear()
            AddToListView(Format(strSubDirectory.Size / (1024 * 1024), "F") + "MB", _
        strSubDirectory.Text, LV1, e.Node.FullPath)
            'agregar los archivos
            Dim DirInfo As New DirectoryInfo(e.Node.FullPath)
            CurrentDirInfo = DirInfo
            Dim ArrFileInfo() As FileInfo
            'se obtienen todos los archivos en el subdirectorio
            Try
                ArrFileInfo = DirInfo.GetFiles
            Catch ex As Exception
                Return
            End Try
            Dim FileInf As FileInfo
            'se agrega cada uno de los archivos a la listview  con sus iconos
            For Each FileInf In ArrFileInfo
                Dim LVitm As New ListViewItem(FileInf.Name)
                Select Case Path.GetExtension(FileInf.Name).ToUpper.ToString
                    Case ".EVT"
                        LVitm.ImageIndex = 0
                    Case ".TXT"
                        LVitm.ImageIndex = 1
                    Case ".EXE"
                        LVitm.ImageIndex = 2
                    Case ".DWG"
                        LVitm.ImageIndex = 3
                    Case ".PDF"
                        LVitm.ImageIndex = 4
                    Case ".001P", ".A01P", ".B01P", ".C01P"
                        LVitm.ImageIndex = 8
                    Case ".002P", ".A02P", ".B02P", ".C02P"
                        LVitm.ImageIndex = 9
                    Case ".003P", ".A03P", ".B03P", ".C03P"
                        LVitm.ImageIndex = 10
                    Case ".HDR", ".HDA", ".HDB", ".HDC"
                        LVitm.ImageIndex = 11
                    Case ".SHD", ".SHA", ".SHB", ".SHC"
                        LVitm.ImageIndex = 12
                    Case ".001", ".A01", ".B01", ".C01"
                        LVitm.ImageIndex = 13
                    Case ".002", ".A02", ".B02", ".C02"
                        LVitm.ImageIndex = 14
                    Case ".003", ".A03", ".B03", ".C03"
                        LVitm.ImageIndex = 15
                    Case ".004", ".005", ".006", ".007", ".008", ".009", ".010", ".011", ".012", ".013", ".014", ".015", ".016", ".017", ".018", ".019", ".020", ".021", ".022", ".023", ".024"
                        'cualquier otro canal adicional
                        LVitm.ImageIndex = 16
                    Case ".004P", ".005P", ".006P", ".007P", ".008P", ".009P", ".010P", ".011P", ".012P", ".013P", ".014P", ".015P", ".016P", ".017P", ".018P", ".019P", ".020P", ".021P", ".022P", ".023P", ".024P"
                        'cualquier otro canal adicional procesado
                        LVitm.ImageIndex = 17
                    Case Else
                        Try
                            If CInt(Path.GetExtension(FileInf.Name).ToUpper.ToString.Substring(2, 2)) > 0 Then
                                If Path.GetExtension(FileInf.Name).ToUpper.ToString.EndsWith("P") Then
                                    LVitm.ImageIndex = 17
                                Else
                                    LVitm.ImageIndex = 16
                                End If
                            End If
                        Catch ex As Exception
                            Err.Clear()
                            LVitm.ImageIndex = 5
                        End Try
                End Select

                'agregar subelementos 
                'tamaño
                If FileInf.Length / MB >= 1 Then
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / MB), "F") + "mb")
                    LVitm.SubItems.Add(Format(FileInf.Length / MB, "F") + "mb")
                Else
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / KB), "F") + "kb")
                    LVitm.SubItems.Add(Format(FileInf.Length / KB, "F") + "kb")
                End If
                LVitm.SubItems.Add(FileInf.LastWriteTime.ToString)
                LVitm.SubItems.Add(FileInf.CreationTime.ToString)
                'LVitm.SubItems.Add(FileInf.Attributes.ReadOnly.ToString)
                LV1.Items.Add(LVitm)
            Next
        End If

    End Sub

    Private Sub TV1_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterExpand
        e.Node.Expand()
        ShowSubDirectories(CType(e.Node, DirectoryNode))
    End Sub

    Private Sub TV1_BeforeCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TV1.BeforeCheck
        If e.Node.Checked = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TV1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterCheck
        If e.Node.Checked = True Then
            'Se seleccionan carpetas en realidad se eligen todos los eventos dentro 
            'de ésta y sus subcarpetas.

            'Agregar los archivos del propio directorio
            Dim DirInfo As New DirectoryInfo(e.Node.FullPath)
            'se obtienen todos los archivos en el directorio
            Try
                ArrFileInfo = DirInfo.GetFiles
                'y subdirectorios
                BuscarEnLosSubdirectorios(e.Node.FullPath)
            Catch ex As Exception
                St.Text = Err.Description
                Err.Clear()
            End Try

            Dim FileInf As FileInfo
            'se agrega cada uno de los archivos a la listview  con sus iconos

            If lv.Length >= 1 And i <> 0 Then
                Dim aux(i - 1) As ListViewItem
                Array.Copy(lv, aux, lv.Length)
                ReDim lv(lv.Length + ArrFileInfo.Length - 1)
                Array.Copy(aux, lv, aux.Length)
            Else
                ReDim lv(ArrFileInfo.Length - 1)
            End If

            For Each FileInf In ArrFileInfo
                Dim LVitm As New ListViewItem(FileInf.Name)
                'se ponen los íconos
                Select Case Path.GetExtension(FileInf.Name).ToUpper
                    Case ".EVT"
                        LVitm.ImageIndex = 0
                    Case ".TXT"
                        LVitm.ImageIndex = 1
                    Case ".EXE"
                        LVitm.ImageIndex = 2
                    Case ".DWG"
                        LVitm.ImageIndex = 3
                    Case ".PDF"
                        LVitm.ImageIndex = 4
                    Case ".001P", ".A01P", ".B01P", ".C01P"
                        LVitm.ImageIndex = 8
                    Case ".002P", ".A02P", ".B02P", ".C02P"
                        LVitm.ImageIndex = 9
                    Case ".003P", ".A03P", ".B03P", ".C03P"
                        LVitm.ImageIndex = 10
                    Case ".HDR", ".HDA", ".HDB", ".HDC"
                        LVitm.ImageIndex = 11
                    Case ".SHD", ".SHA", ".SHB", ".SHC"
                        LVitm.ImageIndex = 12
                    Case ".001", ".A01", ".B01", ".C01"
                        LVitm.ImageIndex = 13
                    Case ".002", ".A02", ".B02", ".C02"
                        LVitm.ImageIndex = 14
                    Case ".003", ".A03", ".B03", ".C03"
                        LVitm.ImageIndex = 15
                    Case ".004", ".005", ".006", ".007", ".008", ".009", ".010", ".011", ".012", ".013", ".014", ".015", ".016", ".017", ".018", ".019", ".020", ".021", ".022", ".023", ".024"
                        'cualquier otro canal adicional
                        LVitm.ImageIndex = 16
                    Case ".004P", ".005P", ".006P", ".007P", ".008P", ".009P", ".010P", ".011P", ".012P", ".013P", ".014P", ".015P", ".016P", ".017P", ".018P", ".019P", ".020P", ".021P", ".022P", ".023P", ".024P"
                        'cualquier otro canal adicional procesado
                        LVitm.ImageIndex = 17
                    Case Else
                        LVitm.ImageIndex = 5
                End Select
                'agregar subelementos 
                If FileInf.Length / MB >= 1 Then
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / MB), "F") + "mb")
                    LVitm.SubItems.Add(Format(FileInf.Length / MB, "F") + "mb")
                Else
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / KB), "F") + "kb")
                    LVitm.SubItems.Add(Format(FileInf.Length / KB, "F") + "kb")
                End If
                LVitm.SubItems.Add(FileInf.LastWriteTime.ToString)
                LVitm.SubItems.Add(FileInf.CreationTime.ToString)
                'LVitm.SubItems.Add(FileInf.Attributes.ReadOnly.ToString)
                LVitm.SubItems.Add(FileInf.FullName)

                lv.SetValue(LVitm, i)
                i += 1
            Next
        End If
    End Sub

    'list view
    Private Sub LV1_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV1.ItemActivate
        Dim LVitem As ListViewItem
        ProG.Maximum = LV1.SelectedItems.Count()
        If MenuItem8.Checked = True Then
            ProG.Value = 0
            'se crea la carpeta temporal y se copia el programa de descompresión de Altus por si es necesario
            Directory.CreateDirectory("C:\Sism")
            File.Copy("C:\Archivos de programa\UAEMex\IdEst\KW2ASC32.exe", Path.Combine("C:\Sism", "prg.exe"), True)
            For Each LVitem In LV1.SelectedItems
                If LVitem.Text.StartsWith("->") Then
                    TV1.SelectedNode = TV1.SelectedNode.Parent
                    Exit Sub
                End If
                If checarextensión(LVitem.Text.ToUpper) Then
                    'vista previa
                    St.Text = "Mostrando registro " & Path.Combine(CurrentDirInfo.FullName, LVitem.Text)
                    Me.Opacity = 1
                    Me.TopMost = False
                    Dim view As New FrmView            'ventana de visualización
                    view.Text = Path.Combine(CurrentDirInfo.FullName, LVitem.Text)
                    view.Show()

                ElseIf LVitem.Text.ToUpper.EndsWith(".EVT") Then
                    'descompresión
                    Me.Opacity = 0.6
                    ProG.PerformStep()
                    S2.Text = ProG.Value.ToString & " / " & LV1.SelectedItems.Count.ToString
                    St.Update()
                    ProG.Update()
                    'Me.Refresh()
                    ' Me.TopMost = True
                    'se descomprime un EVT con el KW2ASC32.exe y viene con el paquete de DOS SUPPORT, 
                    'programa de línea de comandos suministrado por Altus


                    File.Copy(Path.Combine(CurrentDirInfo.FullName, LVitem.Text), Path.Combine("C:\Sism", LVitem.Text), True)

                    'File.Copy(Path.Combine(CurrentDirInfo.FullName, LVitem.Text), Path.Combine(Path.GetTempPath & "Sism", LVitem.Text), True)
                    Dim pr As Process
                    If RadioButton1.Checked = True Then
                        ' pr = pr.Start(Path.Combine(Path.GetTempPath & "Sism", "prg.exe"), CStr(Path.Combine(Path.GetTempPath & "Sism", LVitem.Text)))
                        pr = Process.Start("C:\Sism\prg.exe", Path.Combine("C:\Sism", LVitem.Text))         'si fufa
                    Else
                        '     pr = Process.Start(Path.Combine(Path.GetTempPath & "Sism", "prg.exe"), Path.Combine(Path.GetTempPath & "Sism", LVitem.Text) & " -H")
                        pr = Process.Start("C:\Sism\prg.exe", Path.Combine("C:\Sism", LVitem.Text) & " -H")
                    End If
                    pr.WaitForExit()

                    Dim streg As String
                    streg = Path.Combine("C:\Sism", LVitem.Text)
                    streg = streg.Replace(".EVT", ".SHD")

                    Dim strd As New StreamReader(streg)
                    streg = strd.ReadToEnd
                    strd.Close()
                    streg = streg.Substring(streg.IndexOf("Station ID:") + 12, 10)
                    streg = streg.Substring(0, streg.IndexOf(" "))
                    St.Text = "Station ID: " & streg

                    'borrar lo que ya no se usa: el prg.exe y el evt de la temporal
                    '1fl.Delete(Path.Combine(Path.GetTempPath & "Sism", "prg.exe"))
                    File.Delete(Path.Combine("C:\Sism", LVitem.Text))
                    'Para el prefijo de la registradora
                    If streg <> "" Then
                        St.Text = "." & streg.Substring(0, 1).ToUpper
                        If "ABCDEFGHIJKL".Contains(St.Text.Substring(1)) = False Then
                            St.Text = ".0"
                        End If
                    Else
                        St.Text = ".0"
                    End If

                    Dim ArrFileInfo() As FileInfo
                    Dim DirInfo As New DirectoryInfo("C:\Sism")
                    'se obtienen todos los archivos en el subdirectorio
                    Try
                        ArrFileInfo = DirInfo.GetFiles
                    Catch ex As Exception
                        Return
                        Me.TopMost = False
                    End Try
                    Dim FileInf As FileInfo
                    'se agrega cada uno de los archivos a la listview  con sus iconos
                    For Each FileInf In ArrFileInfo
                        If FileInf.ToString.ToUpper.EndsWith(".EXE") Then 'Or FileInf.ToString.ToUpper.EndsWith(".EVT") Then
                            'evitarlo
                            GoTo siguiente
                        End If
                        'prepare the names para los archivos with the corresponding letter in the extension
                        Dim tn As String
                        tn = FileInf.ToString.Replace(".0", St.Text)
                        File.Copy(Path.Combine("C:\Sism", FileInf.Name), _
                        Path.Combine(CurrentDirInfo.FullName, tn), True)    ''''''''no camb

                        'se agrega cada uno de los archivos a la listview  con sus iconos
                        Dim LVitm As New ListViewItem(tn)                           ''''''''no camb
                        Select Case Path.GetExtension(tn).ToUpper.ToString
                            Case ".EVT"
                                LVitm.ImageIndex = 0
                            Case ".TXT"
                                LVitm.ImageIndex = 1
                            Case ".EXE"
                                LVitm.ImageIndex = 2
                            Case ".DWG"
                                LVitm.ImageIndex = 3
                            Case ".PDF"
                                LVitm.ImageIndex = 4
                            Case ".001P", ".A01P", ".B01P", ".C01P"
                                LVitm.ImageIndex = 8
                            Case ".002P", ".A02P", ".B02P", ".C02P"
                                LVitm.ImageIndex = 9
                            Case ".003P", ".A03P", ".B03P", ".C03P"
                                LVitm.ImageIndex = 10
                            Case ".HDR", ".HDA", ".HDB", ".HDC"
                                LVitm.ImageIndex = 11
                            Case ".SHD", ".SHA", ".SHB", ".SHC"
                                LVitm.ImageIndex = 12
                            Case ".001", ".A01", ".B01", ".C01"
                                LVitm.ImageIndex = 13
                            Case ".002", ".A02", ".B02", ".C02"
                                LVitm.ImageIndex = 14
                            Case ".003", ".A03", ".B03", ".C03"
                                LVitm.ImageIndex = 15
                            Case ".004", ".005", ".006", ".007", ".008", ".009", ".010", ".011", ".012", ".013", ".014", ".015", ".016", ".017", ".018", ".019", ".020", ".021", ".022", ".023", ".024"
                                'cualquier otro canal adicional
                                LVitm.ImageIndex = 16
                            Case ".004P", ".005P", ".006P", ".007P", ".008P", ".009P", ".010P", ".011P", ".012P", ".013P", ".014P", ".015P", ".016P", ".017P", ".018P", ".019P", ".020P", ".021P", ".022P", ".023P", ".024P"
                                'cualquier otro canal adicional procesado
                                LVitm.ImageIndex = 17
                            Case Else
                                LVitm.ImageIndex = 5
                        End Select

                        'agregar subelementos 
                        'tamaño
                        '1LVitm.SubItems.Add(Format("0#00", Str(FileInf.Length / MB)) + "MB")
                        If FileInf.Length / MB >= 1 Then
                            'LVitm.SubItems.Add(Format(Str(FileInf.Length / MB), "F") + "mb")
                            LVitm.SubItems.Add(Format(FileInf.Length / MB, "F") + "mb")
                        Else
                            'LVitm.SubItems.Add(Format(Str(FileInf.Length / KB), "F") + "kb")
                            LVitm.SubItems.Add(Format(FileInf.Length / KB, "F") + "kb")
                        End If
                        LVitm.SubItems.Add(FileInf.LastWriteTime.ToString)
                        LVitm.SubItems.Add(FileInf.CreationTime.ToString)
                        'LVitm.SubItems.Add(FileInf.Attributes.ReadOnly.ToString)
                        File.Delete(Path.Combine("C:\Sism", FileInf.Name))
                        LV1.Items.Add(LVitm)
siguiente:
                    Next
                Else
                    GoTo abrir1
                End If
            Next
        ElseIf MenuItem9.Checked = True Then
            'abrir
abrir1:
            For Each LVitem In LV1.SelectedItems
                If Not LVitem.Text.StartsWith("->") Then
                    Try
                        St.Text = "Abriendo: " + Path.Combine(CurrentDirInfo.FullName, LVitem.Text)
                        Process.Start(Path.Combine(CurrentDirInfo.FullName, LVitem.Text))
                    Catch
                        St.Text = Err.Description.ToString
                        Err.Clear()
                        Exit Sub
                    End Try
                Else
                    TV1.SelectedNode = TV1.SelectedNode.Parent
                End If
                St.Text = ""
            Next
        Else
            'abrir carpeta contenedora
            For Each LVitem In LV1.SelectedItems
                If Not LVitem.Text.StartsWith("->") Then
                    Try
                        St.Text = "Abriendo carpeta: " + CurrentDirInfo.FullName
                        Process.Start(CurrentDirInfo.FullName)
                    Catch
                        St.Text = Err.Description.ToString
                        Err.Clear()
                        Exit Sub
                    End Try
                Else
                    TV1.SelectedNode = TV1.SelectedNode.Parent
                End If
                St.Text = ""
            Next
        End If
        S2.Text = ""
        St.Text = ""
        ProG.Value = 0
        ProG.Maximum = 100
        Me.TopMost = False
        Me.Opacity = 1
        'clrep()
        If Directory.Exists("C:\Sism") Then
            St.Text = "Borrando el directorio temporal"
            Directory.Delete("C:\Sism", True)
            St.Text = St.Text & " ... Listo"
        End If
        St.Text = ""
    End Sub

    'numeric up down de diezmado
    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        'cambio en el factor de diezmado
        If NumericUpDown1.Value = 6 Then
            NumericUpDown1.Value = 5
        End If

    End Sub

    'boton aceptar configuración
    Private Sub AceptarConfiguración(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = False
        LV1.Enabled = True
        TV1.Enabled = True
    End Sub

#End Region

#Region "Funciones"
    Sub reader()         'leer directorio base
        Dim strd As New StreamReader("C:\Archivos de programa\UAEMex\IdEst\Consult.inf")
        stt = strd.ReadToEnd
        strd.Close()
        stt = stt.Remove(0, stt.LastIndexOf("=") + 1)
    End Sub

    Sub botonraiz()
        'mostrar el cuadro de diálogo para elegir el directorio de trabajo
        Dim StrDirecSel As String = FolderBrowser.ShowDialog
        Dim DndDirecSel As DirectoryNode 'tipo treenode extendido
        'borrar contenido
        TV1.Nodes.Clear()
        LV1.Items.Clear()
        Try
            DndDirecSel = New DirectoryNode
            DndDirecSel.Text = StrDirecSel
            TV1.Nodes.Add(DndDirecSel) 'se agrega el nodo de directorio base
            'se calcula el tamaño
            DndDirecSel.Size += GetDirectorySize(StrDirecSel, _
               DndDirecSel)
        Catch ex As Exception
            'Se evita el error pero no se resuelve
        End Try
        TV1.SelectedNode = TV1.TopNode
        TV1.SelectedNode.Expand()
    End Sub

    Function GetDirectorySize(ByVal strDirPath As String, ByVal dnDriveOrDirectory As DirectoryNode) As Long

        ' Show the current scan directory in the status bar.
        St.Text = "Scanning : " + strDirPath

        Try
            Dim astrSubDirectories As String() = Directory.GetDirectories(strDirPath)
            Dim strSubDirectory As String

            ' The size of the current directory is dependent on the size 
            ' of the sub-directories in the array astrSubDirectories. So iterate
            ' through the array and use recursion to end up with the total
            ' size of the current directory and all its sub-directories.
            For Each strSubDirectory In astrSubDirectories
                Dim dnSubDirectoryNode As DirectoryNode
                dnSubDirectoryNode = New DirectoryNode

                ' Set the node text = to only the last part of the full path.
                dnSubDirectoryNode.Text = _
                    strSubDirectory.Remove(0, strSubDirectory.LastIndexOf("\") + 1)

                ' Note that the following line is recursive.
                dnDriveOrDirectory.Size += _
                    GetDirectorySize(strSubDirectory, dnSubDirectoryNode)
                dnDriveOrDirectory.Nodes.Add(dnSubDirectoryNode)
            Next

            ' Add to the size calcutate above, all of the files in the current 
            ' directory.
            Dim astrFiles As String() = Directory.GetFiles(strDirPath)
            Dim strFileName As String
            Dim Size As Long = 0

            For Each strFileName In astrFiles
                dnDriveOrDirectory.Size += New FileInfo(strFileName).Length
            Next

        Catch exc As Exception
            ' Do nothing. Simply skip any directories that can't be read. Control
            ' passes to the first line after End Try.
        End Try

        ' Reset the StatusBar and Return the total size for this directory.
        St.Text = ""
        Return dnDriveOrDirectory.Size

    End Function

    Private Sub AddToListView(ByVal strSize As String, ByVal strFolderName As String, ByVal ListView As ListView, _
    Optional ByVal CompletePath As String = "NoDisponible")
        Dim lvi As New ListViewItem
        Dim lvsi As ListViewItem.ListViewSubItem
        If CompletePath.Remove(0, CompletePath.LastIndexOf("\") + 1) = strFolderName Then
            lvi.Text = "->" + strFolderName
            lvsi = New ListViewItem.ListViewSubItem
            lvsi.Text = strSize
            lvi.ImageIndex = 7
            lvi.ForeColor = Color.Blue
        Else
            lvi.Text = strFolderName
            lvsi = New ListViewItem.ListViewSubItem
            lvsi.Text = strSize
            lvi.ImageIndex = 7
        End If

        lvi.SubItems.Add(lvsi)
        ListView.Items.Add(lvi)
    End Sub

    Private Sub ShowSubDirectories(ByVal dnDrive As DirectoryNode)
        Dim strSubDirectory As DirectoryNode

        LV1.Items.Clear()

        For Each strSubDirectory In dnDrive.Nodes
            AddToListView(Format(strSubDirectory.Size / MB, "F") + "MB", _
                strSubDirectory.Text, LV1)
        Next
    End Sub

    Private Sub BuscarEnLosSubdirectorios(ByVal DirectorioBase As String)
        Dim astrsubdirectories As String() = Directory.GetDirectories(DirectorioBase)
        Dim strSubDirectory As String
        'se itera dentro de los subdirectorios para encontrar todos los archivos


        For Each strSubDirectory In astrsubdirectories
            Dim IDirInfo As New DirectoryInfo(strSubDirectory)
            Dim ArrFileInfoSub() As FileInfo
            ArrFileInfoSub = IDirInfo.GetFiles
            'se aumenta el tamaño de arrfileinfo para poder recibir a arrfileinfosub

            Try
                If ArrFileInfoSub(0).Exists Then
                End If
            Catch ex As Exception
                Err.Clear()
                GoTo siguiente
            End Try
            Try
                If ArrFileInfo(0).Exists Then
                End If
            Catch ex As Exception
                Err.Clear()
                ArrFileInfo = ArrFileInfoSub.Clone
                GoTo siguiente
            End Try

            Dim auxarr() As FileInfo
            auxarr = ArrFileInfo.Clone
            Dim tamuno As Int16 = ArrFileInfo.Length - 1
            If tamuno = 0 And ArrFileInfo(0).ToString <> "" Then
                tamuno = 1
            ElseIf tamuno = 0 And ArrFileInfo(0).ToString = "" Then
                tamuno = 0
            Else
                tamuno = ArrFileInfo.Length
            End If
            Dim tamdos As Int16 = ArrFileInfoSub.Length - 1
            If tamdos = 0 And ArrFileInfoSub(0).ToString <> "" Then
                tamdos = 1
            ElseIf tamdos = 0 And ArrFileInfo(0).ToString = "" Then
                tamdos = 0
            Else
                tamdos = ArrFileInfoSub.Length
            End If

            ReDim ArrFileInfo(tamuno + tamdos - 1)

            auxarr.CopyTo(ArrFileInfo, 0)
            ArrFileInfoSub.CopyTo(ArrFileInfo, tamuno)


siguiente:
            'y en los directorios subsecuentes
            BuscarEnLosSubdirectorios(strSubDirectory)
        Next
    End Sub

    Private Sub clrep()                   'para quitar los repetidos, es necesario porque la consulta es cruzada
        LV1.Sorting = SortOrder.Ascending
        LV1.Sort()
        Dim lvitm, lvitm2 As ListViewItem
        Dim k As Int16
        'en modo de borrar
        For Each lvitm In LV1.Items
            For Each lvitm2 In LV1.Items
                'If lvitm.Index < 0 Then
                '    GoTo siguiente
                'End If
                If lvitm.Text = lvitm2.Text And lvitm.Index <> lvitm2.Index And lvitm.Index > 0 Then
                    lvitm2.Remove()
                    On Error Resume Next
                End If
            Next
            'siguiente:
        Next
        St.Panels.Item(0).Text = "Cantidad: " & LV1.Items.Count
    End Sub

    Sub consultar()
        'Consulta; enventos seleccionados
        Try
            If Not lv(0) Is Nothing Then
                FrmConslt.LV2.Items.Clear()
                FrmConslt.LV2.Items.AddRange(lv)
                FrmConslt.Show()
                St.Text = ""
                ReDim lv(0)
                i = 0
            Else
                St.Text = "No hay elements seleccionados"
            End If
            TV1.CheckBoxes = False
            TV1.CheckBoxes = True
            TV1.SelectedNode = TV1.TopNode
            TV1.SelectedNode.Expand()
            FrmConslt.S1.Text = "Cantidad: " & FrmConslt.LV2.Items.Count.ToString
        Catch ex As Exception
            If St.Text <> "No hay elements seleccionados" Then
                St.Text = Err.Description
            End If
            Err.Clear()
        End Try
    End Sub

#End Region

#Region "Clicks"
    Private Sub about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim ab As New about
        ab.ShowDialog()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        St.Text = "Eliminar?"
        If MsgBox("Eliminar elementos seleccionados, por seguridad los .EVT no se borrarán", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.No Then
            St.Text = ""
            Exit Sub
        End If
        ' Dim fl As File
        Dim LVitem As ListViewItem
        For Each LVitem In LV1.SelectedItems
            If Not (LVitem.Text.StartsWith("->") Or LVitem.Text.ToUpper.EndsWith(".EVT")) Then
                Try
                    File.Delete(Path.Combine(CurrentDirInfo.FullName, LVitem.Text))
                    LVitem.Remove()
                Catch ex As Exception
                    MsgBox(Err.Description, MsgBoxStyle.Exclamation)
                    Err.Clear()
                End Try
            End If
        Next
        St.Text = "Eliminado"
    End Sub

    Private Sub CopiarElementos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        St.Text = "Copiar elementos seleccionados a una ubicación distinta"
        FBD.Description = "Carpeta a la que se va a copiar"
        FBD.ShowDialog()
        If (FBD.SelectedPath = "") Then
            St.Text = "No se seleccionó ningún destino"
            Exit Sub
        End If

        ' Dim fl As File
        Dim LVitem As ListViewItem
        For Each LVitem In LV1.SelectedItems
            If Not LVitem.Text.StartsWith("->") Then
                Try
                    File.Copy(Path.Combine(CurrentDirInfo.FullName, LVitem.Text), Path.Combine(FBD.SelectedPath, LVitem.Text))
                Catch ex As Exception
                    MsgBox(Err.Description, MsgBoxStyle.Exclamation)
                    Err.Clear()
                End Try
            End If
        Next
        St.Text = "Copiado exitoso"
    End Sub

    Private Function checarextensión(ByVal tx As String) As Boolean
        If tx.EndsWith("01") Or tx.EndsWith("02") Or tx.EndsWith("03") _
                    Or tx.ToUpper.EndsWith("01P") Or tx.ToUpper.EndsWith("02P") Or tx.ToUpper.EndsWith("03P") _
                    Or tx.EndsWith("04") Or tx.EndsWith("05") Or tx.EndsWith("06") _
                    Or tx.EndsWith("07") Or tx.EndsWith("08") Or tx.EndsWith("09") _
                    Or tx.EndsWith("10") Or tx.EndsWith("11") Or tx.EndsWith("12") _
                    Or tx.EndsWith("14") Or tx.EndsWith("15") Or tx.EndsWith("16") _
                    Or tx.EndsWith("17") Or tx.EndsWith("18") Or tx.EndsWith("19") _
                    Or tx.EndsWith("20") Or tx.EndsWith("21") Or tx.EndsWith("22") _
                    Or tx.EndsWith("23") Or tx.EndsWith("24") Or tx.EndsWith("13") _
                    Or tx.ToUpper.EndsWith("04P") Or tx.ToUpper.EndsWith("05P") Or tx.ToUpper.EndsWith("06P") _
                    Or tx.ToUpper.EndsWith("07P") Or tx.ToUpper.EndsWith("08P") Or tx.ToUpper.EndsWith("09P") _
                    Or tx.ToUpper.EndsWith("10P") Or tx.ToUpper.EndsWith("11P") Or tx.ToUpper.EndsWith("12P") _
                    Or tx.ToUpper.EndsWith("14P") Or tx.ToUpper.EndsWith("15P") Or tx.ToUpper.EndsWith("16P") _
                    Or tx.ToUpper.EndsWith("17P") Or tx.ToUpper.EndsWith("18P") Or tx.ToUpper.EndsWith("19P") _
                    Or tx.ToUpper.EndsWith("20P") Or tx.ToUpper.EndsWith("21P") Or tx.ToUpper.EndsWith("22P") _
                    Or tx.ToUpper.EndsWith("23P") Or tx.ToUpper.EndsWith("24P") Or tx.ToUpper.EndsWith("13P") Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region

End Class
