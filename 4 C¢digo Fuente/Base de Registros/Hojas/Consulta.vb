Imports System.IO
'Imports Excel
Imports Registros_1a_Prop.ClassDibujo
Public Class Consulta
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
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Public WithEvents LV2 As System.Windows.Forms.ListView
    Friend WithEvents S1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents ProG As System.Windows.Forms.ProgressBar
    Friend WithEvents S2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stbar As System.Windows.Forms.StatusBar
    Friend WithEvents st As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents SFDtext As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.stbar = New System.Windows.Forms.StatusBar
        Me.S1 = New System.Windows.Forms.StatusBarPanel
        Me.S2 = New System.Windows.Forms.StatusBarPanel
        Me.st = New System.Windows.Forms.StatusBarPanel
        Me.LV2 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.PB = New System.Windows.Forms.PictureBox
        Me.ProG = New System.Windows.Forms.ProgressBar
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.SFDtext = New System.Windows.Forms.SaveFileDialog
        CType(Me.S1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.st, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stbar
        '
        Me.stbar.Location = New System.Drawing.Point(0, 325)
        Me.stbar.Name = "stbar"
        Me.stbar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.S1, Me.S2, Me.st})
        Me.stbar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.stbar.ShowPanels = True
        Me.stbar.Size = New System.Drawing.Size(780, 22)
        Me.stbar.TabIndex = 0
        '
        'S1
        '
        Me.S1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.S1.Name = "S1"
        Me.S1.Text = "Cantidad:"
        Me.S1.Width = 70
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.ToolTipText = "Progreso del trabajo"
        Me.S2.Width = 90
        '
        'st
        '
        Me.st.Name = "st"
        Me.st.Width = 355
        '
        'LV2
        '
        Me.LV2.AllowColumnReorder = True
        Me.LV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LV2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader6, Me.ColumnHeader10})
        Me.LV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV2.FullRowSelect = True
        Me.LV2.GridLines = True
        Me.LV2.HideSelection = False
        Me.LV2.Location = New System.Drawing.Point(0, 0)
        Me.LV2.Name = "LV2"
        Me.LV2.Size = New System.Drawing.Size(780, 194)
        Me.LV2.SmallImageList = Me.ImageList
        Me.LV2.TabIndex = 1
        Me.LV2.UseCompatibleStateImageBehavior = False
        Me.LV2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tamaño"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modificado"
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Creado"
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ruta"
        Me.ColumnHeader5.Width = 260
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Max"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Min"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Media"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "{LB ok}Max [V]"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "{LB ok}Min [V]"
        Me.ColumnHeader10.Width = 0
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
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem6, Me.MenuItem8})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem14, Me.MenuItem2, Me.MenuItem18, Me.MenuItem7, Me.MenuItem4})
        Me.MenuItem1.Text = "&Registros                "
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Text = "Guardar Consulta"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Text = "Exportar elementos seleccionados al Editor"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "Exportar Consulta completa al Editor"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Text = "&Exportar consulta a hoja de Microsoft  Excel XP"
        Me.MenuItem2.Visible = False
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Text = "Exportar consulta a texto separado por espacios"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "&Cerra Consulta"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Filtrar &Consulta                 "
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem3, Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem5, Me.MenuItem13})
        Me.MenuItem8.Text = "VistaPrevia"
        '
        'MenuItem9
        '
        Me.MenuItem9.Checked = True
        Me.MenuItem9.Index = 0
        Me.MenuItem9.RadioCheck = True
        Me.MenuItem9.Text = "Mostrar Vista Previa de registros / Descompresión de .EVTs"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Mostrar Vista Previa en otra ventana"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 3
        Me.MenuItem11.RadioCheck = True
        Me.MenuItem11.Text = "Abrir con el programa predeterminado"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        Me.MenuItem12.Text = "Abrir carpeta contenedora"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 6
        Me.MenuItem13.Text = "Mostrar valores característicos"
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 194)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(780, 1)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        Me.Splitter1.Visible = False
        '
        'PB
        '
        Me.PB.BackColor = System.Drawing.Color.Black
        Me.PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB.Location = New System.Drawing.Point(0, 195)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(780, 130)
        Me.PB.TabIndex = 4
        Me.PB.TabStop = False
        '
        'ProG
        '
        Me.ProG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProG.Enabled = False
        Me.ProG.Location = New System.Drawing.Point(517, 328)
        Me.ProG.Name = "ProG"
        Me.ProG.Size = New System.Drawing.Size(242, 20)
        Me.ProG.Step = 1
        Me.ProG.TabIndex = 5
        '
        'SFD
        '
        Me.SFD.DefaultExt = "consulta"
        Me.SFD.Title = "Guardar la consulta como:"
        '
        'SFDtext
        '
        Me.SFDtext.DefaultExt = "txt"
        Me.SFDtext.FileName = "Consulta"
        Me.SFDtext.Title = "Guardar consulta en un archivo de texto delimitado por espacios"
        '
        'Consulta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(780, 347)
        Me.Controls.Add(Me.ProG)
        Me.Controls.Add(Me.LV2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.stbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.S1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.st, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Declaraciones generales"
    Const MB As Long = 1024 * 1024       'constante para transformar de bytes a mega bytes
    Const KB As Long = 1024              'constante para transformar de bytes a kilo bytes
    Dim CurrentDirInfo As DirectoryInfo  'colección de información sobre el directorio seleccionado
    Dim thread As Threading.Thread
    ' Dim EXap As Excel.Application
    Dim RG() As Double
#End Region

#Region "form events"
    Private Sub LV2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV2.SelectedIndexChanged
        Try
            st.Text = LV2.SelectedItems.Item(0).SubItems.Item(5).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LV2_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV2.ItemActivate
        ProG.Enabled = True
        ProG.Value = 0
        Dim LVitem As ListViewItem
        If MenuItem9.Checked = True Then
            'vista previa dentro de la misma ventana o descomprimir evts
            'se crea la carpeta temporal y se copia el programa de descompresión de Altus por si es necesario
            'Dim dr As Directory

            Directory.CreateDirectory(Path.Combine(Path.GetTempPath, "Sism"))
            'Dim fl As File
            File.Copy("C:\Archivos de programa\UAEMex\IdEst\KW2ASC32.exe", Path.Combine(Path.GetTempPath & "Sism", "prg.exe"), True)

            For Each LVitem In LV2.SelectedItems
                If LVitem.Text.ToUpper.EndsWith(".EVT") Then  'descomprimir evt
                    Me.Opacity = 0.6
                    ProG.Maximum = LV2.SelectedItems.Count()
                    S2.Text = ProG.Value.ToString & " / " & LV2.SelectedItems.Count.ToString
                    stbar.Update()
                    ProG.Update()
                    'Me.Refresh()
                    Me.TopMost = True
                    'copiar el archivo EVT que se va a descomprimir a la temporal
                    File.Copy(LVitem.SubItems.Item(4).Text, Path.Combine(Path.GetTempPath & "Sism", LVitem.Text), True)
                    Dim pr As New Process
                    'Try
                    pr = Process.Start(Path.Combine(Path.GetTempPath & "Sism", "prg.exe"), Path.Combine(Path.GetTempPath & "Sism", LVitem.Text))
                    pr.WaitForExit()
                    'Do
                    'Loop Until pr.WaitForExit(10)

                    'borrar lo que ya no se usa: el prg.exe de la temporal
                    'fl.Delete(Path.Combine(Path.GetTempPath & "Sism", "prg.exe"))  '''''''''''''''''''''''''''''''''''''
                    'If pr.HasExited Then
                    '    'continuar
                    'Else
                    '    pr.WaitForExit(1000)
                    'End If

                    'Catch ex As Exception
                    '    st.Text = ex.Message
                    '    Err.Clear()
                    '    'clrep()
                    '    Exit Sub
                    'End Try
                    Dim streg As String
                    streg = Path.Combine(Path.GetTempPath & "Sism", LVitem.Text)
                    streg = streg.Replace(".EVT", ".SHD")

                    Dim strd As New StreamReader(streg)
                    streg = strd.ReadToEnd
                    strd.Close()
                    streg = streg.Substring(streg.IndexOf("Station ID:") + 12, 10)
                    streg = streg.Substring(0, streg.IndexOf(" "))
                    st.Text = "Station ID: " & streg

                    'borrar lo que ya no se usa: el evt de la temporal
                    'Try

                    File.Delete(Path.Combine(Path.GetTempPath & "Sism", LVitem.Text))    ''''''''

                    'Catch ex As Exception
                    '    st.Text = ex.Message
                    '    Err.Clear()
                    'End Try

                    If streg = "EAE1" Then
                        st.Text = ".A"
                    ElseIf streg = "EAP2" Then
                        st.Text = ".B"
                    ElseIf streg = "EAPH" Then
                        st.Text = ".C"
                    Else
                        st.Text = ".0"
                    End If

                    Dim ArrFileInfo() As FileInfo
                    Dim DirInfo As New DirectoryInfo(Path.Combine(Path.GetTempPath, "Sism"))
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
                        tn = FileInf.ToString.Replace(".0", st.Text)
                        File.Copy(Path.Combine(Path.GetTempPath & "Sism", FileInf.Name), _
                        Path.Combine(LVitem.SubItems.Item(4).Text.Remove(LVitem.SubItems.Item(4).Text.LastIndexOf("\"), LVitem.SubItems.Item(4).Text.Length - LVitem.SubItems.Item(4).Text.LastIndexOf("\")), tn), True)

                        'se agrega cada uno de los archivos a la listview  con sus iconos
                        Dim LVitm As New ListViewItem(tn.Substring(tn.LastIndexOf("\") + 1))
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
                        If FileInf.Length / MB >= 1 Then
                            LVitm.SubItems.Add(Format(FileInf.Length / MB, "F") + "mb")
                        Else
                            LVitm.SubItems.Add(Format(FileInf.Length / KB, "F") + "kb")

                        End If
                        LVitm.SubItems.Add(FileInf.LastWriteTime.ToString)
                        LVitm.SubItems.Add(FileInf.CreationTime.ToString)
                        'LVitm.SubItems.Add(FileInf.Attributes.ReadOnly.ToString)
                        LVitm.SubItems.Add(Path.Combine(LVitem.SubItems.Item(4).Text.Remove(LVitem.SubItems.Item(4).Text.LastIndexOf("\"), LVitem.SubItems.Item(4).Text.Length - LVitem.SubItems.Item(4).Text.LastIndexOf("\")), tn))
                        'borramos lo que estorva, si no se hace lento el proceso después de los 30 y tantos archivos
                        File.Delete(Path.Combine(Path.GetTempPath & "Sism", FileInf.Name))
                        'pasamos el lvitm a la lista
                        LV2.Items.Add(LVitm)
siguiente:
                    Next

                ElseIf checarextensión(LVitem.Text) Then

                    ProG.Enabled = False
                    st.Text = "Mostrando registro " & LVitem.SubItems.Item(4).Text
                    ' y mostrar en la propia
                    mostrar_propia(LVitem)
                    Exit For  'para que solo muestre la primera en caso de selección múltiple
                Else
                    GoTo abrir
                End If
                ProG.PerformStep()
            Next
        ElseIf MenuItem3.Checked = True Then
            'vista previa en otra ventana y en la propia. la ventaja es que se conserva la imagen y se pueden comparar varias
            For Each LVitem In LV2.SelectedItems
                ProG.PerformStep()
                If checarextensión(LVitem.Text) Then
                    st.Text = "Mostrando registro " & LVitem.SubItems.Item(4).Text
                    Dim view As New FrmView            'ventana de visualización
                    view.Text = LVitem.SubItems.Item(4).Text
                    view.Show()
                    ' y mostrar en la propia
                    mostrar_propia(LVitem)
                Else
                    GoTo abrir
                End If
            Next
        ElseIf MenuItem11.Checked = True Then
            'abrir con el programa predeterminado por wndws
abrir:
            For Each LVitem In LV2.SelectedItems
                ProG.PerformStep()
                Try
                    st.Text = "Abriendo: " + LVitem.SubItems.Item(4).Text
                    Process.Start(LVitem.SubItems.Item(4).Text)
                Catch
                    st.Text = Err.Description.ToString
                    Err.Clear()
                    Exit Sub
                End Try
                st.Text = ""
            Next
        Else
            'abrir carpeta contenedora
            For Each LVitem In LV2.SelectedItems
                ProG.PerformStep()
                'LVitem.SubItems.Item(5).Text()
                Try
                    st.Text = "Abriendo carpeta: " + Path.GetDirectoryName(LVitem.SubItems.Item(4).Text)
                    Process.Start(Path.GetDirectoryName(LVitem.SubItems.Item(4).Text))
                Catch
                    st.Text = Err.Description.ToString
                    Err.Clear()
                    GoTo salida
                    Exit Sub
                End Try

                st.Text = ""
            Next
        End If

        'delete the temporary directory if exists just to prevent errors in future sessions
salida:
        'Dim dir As Directory
        If Directory.Exists(Path.Combine(Path.GetTempPath, "Sism")) Then
            st.Text = "Borrando el directorio temporal"
            Directory.Delete(Path.Combine(Path.GetTempPath, "Sism"), True)
            st.Text = st.Text & " ... Listo"
        End If
        S2.Text = ""
        st.Text = ""
        ProG.Value = 0
        ProG.Maximum = 100
        Me.TopMost = False
        Me.Opacity = 1
        clrep()
    End Sub

    Private Sub PB_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PB.Paint
        ProG.Value = 10
        DrawOnPictureBox(e.Graphics, PB, RG)
        ProG.Value = 90
        ProG.Value = 0
    End Sub

    Private Sub Consulta_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Visible = False
        MenuItem13.Checked = False
        LV2.Columns.Item(1).Width = 60
        LV2.Columns.Item(2).Width = 110
        LV2.Columns.Item(3).Width = 110
        LV2.Columns.Item(4).Width = 260
        LV2.Columns.Item(5).Width = 0
        LV2.Columns.Item(6).Width = 0
        LV2.Columns.Item(7).Width = 0
        LV2.Columns.Item(8).Width = 0
        LV2.Columns.Item(9).Width = 0
        ProG.Maximum = 100
        ProG.Value = 0
        st.Text = ""
    End Sub

#End Region

#Region "menú"
    'Private Sub Exportar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
    '    'registros ; exportar
    '    'un manejo de proceso diferente para excel
    '    thread = New Threading.Thread(AddressOf ex)
    '    thread.Start()
    'End Sub

    <System.Diagnostics.DebuggerStepThrough()> Private Sub Filtrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'filtrar; filtrar consulta
        Dim frm As New Filtro
        Dim itm As ListViewItem
        For Each itm In LV2.Items
            frm.LV3.Items.Add(itm.Clone)
            frm.LVf.Items.Add(itm.Clone)
        Next
        frm.Show()
    End Sub

    Private Sub VistaPrevia(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'mostrar vista previa
        MenuItem9.Checked = True
        MenuItem11.Checked = False
        MenuItem12.Checked = False
        MenuItem3.Checked = False
    End Sub

    Private Sub PreviaEnOtraVentana(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        'mostrar vista previa en otra ventana
        MenuItem9.Checked = False
        MenuItem11.Checked = False
        MenuItem12.Checked = False
        MenuItem3.Checked = True
    End Sub

    Private Sub Abrir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        'abrir
        MenuItem9.Checked = False
        MenuItem11.Checked = True
        MenuItem12.Checked = False
        MenuItem3.Checked = False
    End Sub

    Private Sub AbrirCarpeta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        'abrir carpeta
        MenuItem9.Checked = False
        MenuItem11.Checked = False
        MenuItem12.Checked = True
        MenuItem3.Checked = False
    End Sub

    Private Sub MaxMedMin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        'leer los registros de canal y encontrar el maximo el minimo y la media
        Try
            If MenuItem13.Checked = False Then
                st.Text = "Espere...Recabando valores máximos"
                MenuItem13.Checked = True
                LV2.Columns.Item(1).Width = 10
                LV2.Columns.Item(2).Width = 10
                LV2.Columns.Item(3).Width = 10
                LV2.Columns.Item(4).Width = 20
                LV2.Columns.Item(5).Width = 80
                LV2.Columns.Item(6).Width = 80
                LV2.Columns.Item(7).Width = 80
                LV2.Columns.Item(8).Width = 90
                LV2.Columns.Item(9).Width = 90
                Dim lvitem As ListViewItem
                ProG.Maximum = LV2.Items.Count
                For Each lvitem In LV2.Items
                    ProG.PerformStep()
                    If checarextensión(lvitem.Text) Then
                        'LeerRegistro()  
                        Dim strdr As New StreamReader(lvitem.SubItems.Item(4).Text)
                        Dim reg As String
                        reg = strdr.ReadToEnd()
                        strdr.Close()
                        Dim i, j, var, VmaX, VmiN, VmeD As Double
                        VmaX = Decimal.MinValue
                        VmiN = Decimal.MaxValue
                        VmeD = "0"
                        If reg.StartsWith("N=") Then
                            'es un archivo degtra con la primera línea N,Dt y T(Xini)
                            reg = reg.Remove(0, 2)
                            Dim N As Integer = CInt(reg.Substring(0, reg.IndexOf(" "))) 'se recupera el número de valores
                            ReDim RG(N - 1)
                            reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2) 'borra el primer renglón
                            'ahora solo quedan los valores en cada renglón, así que se recuperan en el vector
                            For i = 0 To N - 1
                                RG(i) = reg.Substring(0, reg.IndexOf(vbNewLine))
                                reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2)
                                var = RG(i)
                                If var > VmaX Then
                                    VmaX = var
                                End If
                                If var < VmiN Then
                                    VmiN = var
                                End If
                                VmeD = VmeD + var
                            Next
                        Else
                            'o si es en ascii: (Ejemplo: Recien descomprimido de un evt)
                            reg = reg.Replace(vbNewLine, "")
                            'el ancho de la columna es fijo=12 en el formado ascii
                            i = 0
                            ReDim RG((reg.Length) * 1 / (12) - 1)
                            For j = 0 To ((reg.Length - 1)) Step 12
                                RG(i) = reg.Substring(j, 12)
                                i += 1

                                var = CDec(reg.Substring(j, 12))
                                If var > VmaX Then
                                    VmaX = var
                                End If
                                If var < VmiN Then
                                    VmiN = var
                                End If
                                VmeD = VmeD + var
                            Next
                        End If

                        lvitem.SubItems.Add(Format(VmaX / 1, "#.0000000000"))
                        lvitem.SubItems.Add(Format(VmiN / 1, "#.0000000000"))
                        lvitem.SubItems.Add(Format(VmeD / i, "#.0000000000"))
                        lvitem.SubItems.Add(Format((VmaX - VmeD / i) / 1, "#.0000000000"))
                        lvitem.SubItems.Add(Format((VmiN - VmeD / i) / 1, "#.0000000000"))
                    End If
                Next
                ProG.Value = ProG.Maximum
                st.Text = st.Text & " ... Listo"
                ProG.Maximum = 100
                ProG.Value = 0
                Exit Sub
            End If
            If MenuItem13.Checked = True Then
                MenuItem13.Checked = False
                LV2.Columns.Item(1).Width = 60
                LV2.Columns.Item(2).Width = 110
                LV2.Columns.Item(3).Width = 110
                LV2.Columns.Item(4).Width = 260
                LV2.Columns.Item(5).Width = 0
                LV2.Columns.Item(6).Width = 0
                LV2.Columns.Item(7).Width = 0
                LV2.Columns.Item(8).Width = 0
                LV2.Columns.Item(9).Width = 0
                ProG.Maximum = 100
                ProG.Value = 0
                Exit Sub
            End If
        Catch ex As Exception
            st.Text = ex.Message
            Err.Clear()
            ProG.Maximum = 100
            ProG.Value = 0
        End Try
    End Sub

    Private Sub Exportar_a_texto_espacios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        'función exportar a un archivo de texto delimitado por espacios

        ProG.Value = 0
        st.Text = "Exportando a archivo de texto delimitado por espacios"
        Dim str As String
        'encabezado
        str = "Consulta a Registros Sísmicos realizada el " _
        + Now.ToShortDateString.ToLower + " a las " + Now.TimeOfDay.ToString
        str = str & vbNewLine
        str = str & "Nombre "  '0
        str = str & "Tamaño "                   '1
        str = str & ". "
        str = str & "Modificado "               '2
        str = str & ". . "
        str = str & "Creado "                   '3
        str = str & ". . "
        str = str & "Ruta "                     '4
        str = str & "Max[V] "                  '5
        str = str & "Min[V] "                  '6
        str = str & "Med[V] "                  '7
        str = str & "Max[V]{LB} "              '8
        str = str & "Min[V]{LB} "             '9
        'exportar datos de la tabla
        str = str & vbNewLine
        'nombre
        Dim i As Int16
        For i = 0 To LV2.Items.Count - 1
            str = str & vbNewLine
            str = str & LV2.Items(i).Text

            If LV2.Items(i).SubItems.Item(1).Text.ToUpper.EndsWith("KB") Then
                'si son kb
                str = str & " " & LV2.Items(i).SubItems.Item(1).Text.ToUpper.Replace("KB", "") & " kb"
            Else
                'son mb
                str = str & " " & CDec(LV2.Items(i).SubItems.Item(1).Text.ToUpper.Replace("MB", "")) * 1024 & " kb"
            End If

            str = str & " " & LV2.Items(i).SubItems.Item(2).Text
            str = str & " " & LV2.Items(i).SubItems.Item(3).Text
            str = str & " " & LV2.Items(i).SubItems.Item(4).Text
            Try
                str = str & " " & LV2.Items(i).SubItems.Item(5).Text
                str = str & " " & LV2.Items(i).SubItems.Item(6).Text
                str = str & " " & LV2.Items(i).SubItems.Item(7).Text
                str = str & " " & LV2.Items(i).SubItems.Item(8).Text
                str = str & " " & LV2.Items(i).SubItems.Item(9).Text
            Catch ex As Exception
                Err.Clear()
            End Try
        Next

        SFDtext.ShowDialog()
        If SFDtext.FileName <> "" Then
            Dim sw As New StreamWriter(SFDtext.FileName)
            sw.Write(str)
            sw.Flush()
            sw.Close()
            st.Text = st.Text & " ... Listo"
            st.Text = ""
        Else
            st.Text = "No se indicó el nombre para un archivo"
            Exit Sub
        End If
        st.Text = ""



    End Sub
#End Region

    'función para exportar a excel
    'Private Sub ex()
    '    ProG.Value = 0
    '    st.Text = "Exportando a Excel"
    '    Try
    '        st.Text = "Exportando a Excel"
    '        EXap = CreateObject("Excel.Application.10")
    '        EXap.Visible = True
    '    Catch ex As Exception
    '        st.Text = Err.Description
    '        Err.Clear()
    '    End Try
    '    Dim EXlib As Excel.Workbook
    '    Dim EXdoc As Excel.Worksheet
    '    EXlib = EXap.Workbooks.Add
    '    EXdoc = EXap.ActiveSheet
    '    EXdoc.Activate()
    '    'encabezado
    '    EXdoc.Range("A1").Value = "Consulta a Registros Sísmicos realizada el " _
    '    + Now.ToShortDateString.ToLower + " a las " + Now.TimeOfDay.ToString
    '    EXdoc.Range("A3").Value = "Nombre"                   '0
    '    EXdoc.Range("B3").Value = "Tamaño"                   '1
    '    EXdoc.Range("D3").Value = "Modificado"               '2
    '    EXdoc.Range("E3").Value = "Creado"                   '3
    '    EXdoc.Range("F3").Value = "Ruta"                     '4
    '    EXdoc.Range("H3").Value = "Max [V]"                  '5
    '    EXdoc.Range("I3").Value = "Min [V]"                  '6
    '    EXdoc.Range("J3").Value = "Med [V]"                  '7
    '    EXdoc.Range("K2").Value = "Corregido LB"
    '    EXdoc.Range("K3").Value = "Max [V] {LB}"             '8
    '    EXdoc.Range("L3").Value = "Min [V] {LB}"             '9
    '    'exportar datos de la tabla

    '    'nombre
    '    Dim i As Int16
    '    For i = 0 To LV2.Items.Count - 1
    '        EXdoc.Range("A" & i + 4).Value = LV2.Items(i).Text

    '        If LV2.Items(i).SubItems.Item(1).Text.ToUpper.EndsWith("KB") Then
    '            'si son kb
    '            EXdoc.Range("B" & i + 4).Value = LV2.Items(i).SubItems.Item(1).Text.ToUpper.Replace("KB", "")
    '            EXdoc.Range("C" & i + 4).Value = "kb"
    '        Else
    '            'son mb
    '            EXdoc.Range("B" & i + 4).Value = CDec(LV2.Items(i).SubItems.Item(1).Text.ToUpper.Replace("MB", "")) * 1024
    '            EXdoc.Range("C" & i + 4).Value = "kb"
    '        End If

    '        EXdoc.Range("D" & i + 4).Value = LV2.Items(i).SubItems.Item(2).Text
    '        EXdoc.Range("E" & i + 4).Value = LV2.Items(i).SubItems.Item(3).Text
    '        EXdoc.Range("F" & i + 4).Value = LV2.Items(i).SubItems.Item(4).Text
    '        EXdoc.Range("G" & i + 4).Value = "=Hipervinculo(F" & CStr(i + 4) & "," & Chr(34) & "vínculo" & Chr(34) & ")"
    '        Try
    '            EXdoc.Range("H" & i + 4).Value = LV2.Items(i).SubItems.Item(5).Text
    '            EXdoc.Range("I" & i + 4).Value = LV2.Items(i).SubItems.Item(6).Text
    '            EXdoc.Range("J" & i + 4).Value = LV2.Items(i).SubItems.Item(7).Text
    '            EXdoc.Range("K" & i + 4).Value = LV2.Items(i).SubItems.Item(8).Text
    '            EXdoc.Range("L" & i + 4).Value = LV2.Items(i).SubItems.Item(9).Text
    '            EXdoc.Range("K" & i + 4).Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous
    '            EXdoc.Range("L" & i + 4).Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous
    '        Catch ex As Exception
    '            Err.Clear()
    '        End Try
    '        'EXap.Visible = True
    '    Next
    '    st.Text = st.Text & " ... Listo"
    '    st.Text = ""
    'End Sub


    'función para trazar el registro en la ventana propia
    Sub mostrar_propia(ByVal lvitem As ListViewItem)
        'LeerRegistro()
        Me.Show()
        Dim strdr As New StreamReader(lvitem.SubItems(4).Text)
        Dim reg As String
        reg = strdr.ReadToEnd()
        strdr.Close()
        Dim i, j As Double
        If reg.StartsWith("N=") Then
            'es un archivo degtra con la primera línea N,Dt y T(Xini)
            reg = reg.Remove(0, 2)
            Dim N As Integer = CInt(reg.Substring(0, reg.IndexOf(" "))) 'se recupera el número de valores
            ReDim RG(N - 1)
            reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2) 'borra el primer renglón
            'ahora solo quedan los valores en cada renglón, así que se recuperan en el vector
            For i = 0 To N - 1
                RG(i) = reg.Substring(0, reg.IndexOf(vbNewLine))
                reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2)
            Next
        Else
            'o si es en ascii: (Ejemplo: Recien descomprimido de un evt)
            reg = reg.Replace(vbNewLine, "")
            'el ancho de la columna es fijo=12 en el formado ascii
            ReDim RG((reg.Length) * 1 / (12 * Main.diezmado) - 1)
            For j = 0 To ((reg.Length - 1)) Step (12 * Main.diezmado / 1)
                RG(i) = reg.Substring(j, 12)
                i += 1
            Next
        End If
        PB.Refresh()
    End Sub

    Private Sub clrep() 'para quitar los repetidos, es necesario porque la consulta es cruzada
        LV2.Sorting = SortOrder.Ascending
        LV2.Sort()
        Dim lvitm, lvitm2 As ListViewItem
        Dim k As Int16
        'en modo de borrar
        For Each lvitm In LV2.Items
            For Each lvitm2 In LV2.Items
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
        S1.Text = "Cantidad: " & LV2.Items.Count
    End Sub


    Private Sub BT_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        SFD.InitialDirectory = Environment.SpecialFolder.MyComputer
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sw As New StreamWriter(SFD.FileName)
            Dim lvitm As ListViewItem
            For Each lvitm In LV2.Items
                sw.WriteLine(lvitm.SubItems(4).Text)
            Next
            sw.Flush()
            sw.Close()
        End If
    End Sub

    Private Sub BT_Exportar_Completa_al_EDITOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim LVitem As ListViewItem
        Dim Cadena As String = Path.GetTempPath & "\Reg" & Now.Second.ToString 'Lo que se exporta  : El xml no puede codificar vectores así que solo se pasa la dirección 
        Dim sw As New StreamWriter(Cadena)
        For Each LVitem In LV2.Items
            If checarextensión(LVitem.Text) Then
                sw.WriteLine(LVitem.SubItems(4).Text)
            End If
        Next
        sw.Flush()
        sw.Close()
        Dim BoX As New ClassBox
        BoX.Lea_los_datos_EXPORTADOS()
        BoX.RutaExportada = Cadena
        BoX.GuardarOpciones()
        Dim p As New Process
        p = Process.Start("C:\Archivos de programa\UAEMex\IdEst\Editor de Registros Sísmicos.exe")

    End Sub

    Private Sub BY_Exportar_Seleccionados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If LV2.SelectedItems.Count > 0 Then
            Dim lvitm As ListViewItem
            Dim Cadena As String = Path.GetTempPath & "\Reg" & Now.Second.ToString 'Lo que se exporta  : El xml no puede codificar vectores así que solo se pasa la dirección 
            Dim sw As New StreamWriter(Cadena)
            For Each lvitm In LV2.SelectedItems
                sw.WriteLine(lvitm.SubItems(4).Text)
            Next
            sw.Flush()
            sw.Close()
            Dim BoX As New ClassBox
            BoX.Lea_los_datos_EXPORTADOS()
            BoX.RutaExportada = Cadena
            BoX.GuardarOpciones()
            Dim p As New Process
            p = Process.Start("C:\Archivos de programa\UAEMex\IdEst\Editor de Registros Sísmicos.exe")

        End If
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

End Class
