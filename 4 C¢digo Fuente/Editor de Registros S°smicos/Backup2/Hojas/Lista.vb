Imports System.IO
Public Class Lista
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Public WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ProG As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista))
        Me.LV = New System.Windows.Forms.ListView
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
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.ProG = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.AllowColumnReorder = True
        Me.LV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LV.CheckBoxes = True
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader6, Me.ColumnHeader10})
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(0, 0)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(701, 230)
        Me.LV.SmallImageList = Me.ImageList
        Me.LV.TabIndex = 2
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 166
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
        Me.ColumnHeader4.Width = 111
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ruta"
        Me.ColumnHeader5.Width = 266
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
        'OFD
        '
        Me.OFD.Filter = resources.GetString("OFD.Filter")
        Me.OFD.Multiselect = True
        Me.OFD.Title = "Archivos por editar"
        '
        'ProG
        '
        Me.ProG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProG.Location = New System.Drawing.Point(0, 213)
        Me.ProG.Name = "ProG"
        Me.ProG.Size = New System.Drawing.Size(701, 17)
        Me.ProG.Step = 1
        Me.ProG.TabIndex = 3
        Me.ProG.Visible = False
        '
        'Lista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(701, 230)
        Me.Controls.Add(Me.ProG)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lista"
        Me.Opacity = 0.8
        Me.ShowInTaskbar = False
        Me.Text = "Lista"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const KB As Integer = 1024
    Private Const MB As Integer = 1024 * 1024
    Dim VnT() As Ventana
    Public Shared elem() As String
    Dim current As Int16

    Private Sub Lista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BoX As New ClassBox 'se revisa encaso de que existan datos exportados para abrir
        BoX.Lea_los_datos_EXPORTADOS()
        If BoX.RutaExportada <> "No" Then
            Dim lvIT() As ListViewItem
            Dim str(0), aux(), s As String
            Dim errstr As String = ""
            Dim sr As New StreamReader(BoX.RutaExportada)
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
            'revisar que todos los archivos existan
            Dim z As Int16
            Dim auxS() As String
            For z = 0 To str.Length - 1
                Dim FileInf As New FileInfo(str(z))
                If fileinf.Exists = True Then
                    Dim au() As String
                    If auxS Is Nothing Then
                        ReDim auxS(0)
                        auxS(0) = str(z)
                    Else
                        au = auxS.Clone
                        ReDim auxS(au.Length)
                        Array.Copy(au, auxS, au.Length)
                        auxS(auxS.Length - 1) = str(z)
                    End If
                Else
                    errstr = errstr & vbNewLine & str(z)
                End If
            Next
            If errstr <> "" Then
                MessageBox.Show("El (los) elemento (s): " & errstr & vbNewLine & " no se encuentra (n) y serán omitidos", "Archivo faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If auxS Is Nothing Then
                GoTo inicio
            End If
            str = auxS.Clone
            ReDim lvIT(str.Length - 1)

            elem = str.Clone

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

                lvIT.SetValue(LVitm, z)
            Next
            'revisar si todos los elementos tienen cosas, si no hay que decirlo y quitar los nothing

            LV.Items.AddRange(lvIT)

            'de salida
            BoX.RutaExportada = "No"
            BoX.GuardarOpciones()
            Dim lvitem As ListViewItem
            Dim index As Int16
            ProG.Maximum = (LV.Items.Count - 1)
            ProG.Visible = True
            ProG.Update()
            Me.Show()
            ReDim VnT(LV.Items.Count - 1)
            For Each lvitem In LV.Items
                VnT(index) = New Ventana
                VnT(index).Owner = Me
                VnT(index).Text = lvitem.SubItems(4).Text
                VnT(index).Opacity = 0
                VnT(index).ControlBox = False
                VnT(index).Show()
                VnT(index).Visible = False
                VnT(index).Opacity = 0.8
                VnT(index).MenuItem14.Enabled = True
                index += 1
                ProG.PerformStep()
                LV.Update()
            Next
            ProG.Value = 0
            ProG.Visible = False
            ProG.Update()
            Form1.VentanaActiva = Me.Tag
            Exit Sub
        End If

inicio:
        'si no hay datos exportados, cuando se abre la lista, se piden los archivos que se van a contener
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK And OFD.FileNames.Length > 0 Then
            Dim st As String
            Dim index As Int16
            ReDim VnT(OFD.FileNames.Length - 1)
            ProG.Maximum = (OFD.FileNames.Length - 1) * 2
            ProG.Visible = True
            ProG.Update()
            Me.Show()

            elem = OFD.FileNames.Clone

            For Each st In OFD.FileNames
                Dim fileinf As New FileInfo(st)
                Dim lvitm As New ListViewItem(fileinf.Name)
                Select Case Path.GetExtension(fileinf.Name).ToUpper.ToString
                    Case ".EVT"
                        lvitm.ImageIndex = 0
                    Case ".TXT"
                        lvitm.ImageIndex = 1
                    Case ".EXE"
                        lvitm.ImageIndex = 2
                    Case ".DWG"
                        lvitm.ImageIndex = 3
                    Case ".PDF"
                        lvitm.ImageIndex = 4
                    Case ".001P", ".A01P", ".B01P", ".C01P"
                        lvitm.ImageIndex = 8
                    Case ".002P", ".A02P", ".B02P", ".C02P"
                        lvitm.ImageIndex = 9
                    Case ".003P", ".A03P", ".B03P", ".C03P"
                        lvitm.ImageIndex = 10
                    Case ".HDR", ".HDA", ".HDB", ".HDC"
                        lvitm.ImageIndex = 11
                    Case ".SHD", ".SHA", ".SHB", ".SHC"
                        lvitm.ImageIndex = 12
                    Case ".001", ".A01", ".B01", ".C01"
                        lvitm.ImageIndex = 13
                    Case ".002", ".A02", ".B02", ".C02"
                        lvitm.ImageIndex = 14
                    Case ".003", ".A03", ".B03", ".C03"
                        lvitm.ImageIndex = 15
                    Case ".004", ".005", ".006", ".007", ".008", ".009", ".010", ".011", ".012", ".013", ".014", ".015", ".016", ".017", ".018", ".019", ".020", ".021", ".022", ".023", ".024"
                        'cualquier otro canal adicional
                        lvitm.ImageIndex = 16
                    Case ".004P", ".005P", ".006P", ".007P", ".008P", ".009P", ".010P", ".011P", ".012P", ".013P", ".014P", ".015P", ".016P", ".017P", ".018P", ".019P", ".020P", ".021P", ".022P", ".023P", ".024P"
                        'cualquier otro canal adicional procesado
                        lvitm.ImageIndex = 17
                    Case Else
                        lvitm.ImageIndex = 5
                End Select

                'agregar subelementos 
                'tamaño
                If fileinf.Length / MB >= 1 Then
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / MB), "F") + "mb")
                    lvitm.SubItems.Add(Format(fileinf.Length / MB, "F") + "mb")
                Else
                    'LVitm.SubItems.Add(Format(Str(FileInf.Length / KB), "F") + "kb")
                    lvitm.SubItems.Add(Format(fileinf.Length / KB, "F") + "kb")
                End If
                lvitm.SubItems.Add(fileinf.LastWriteTime.ToString)
                lvitm.SubItems.Add(fileinf.CreationTime.ToString)
                lvitm.SubItems.Add(fileinf.FullName.ToString)
                VnT(index) = New Ventana
                VnT(index).Owner = Me
                VnT(index).Text = fileinf.FullName.ToString
                VnT(index).Opacity = 0
                VnT(index).ControlBox = False
                ProG.PerformStep()
                VnT(index).Show()
                VnT(index).Visible = False
                VnT(index).Opacity = 0.8
                VnT(index).MenuItem14.Enabled = True
                index += 1
                LV.Items.Add(lvitm)
                ProG.PerformStep()
                LV.Update()
            Next
            ProG.Value = 0
            ProG.Visible = False
        Else
            If MessageBox.Show("No seleccionó ningún archivo; si elige 'Reintentar' podrá elegir uno o varios archivos para trabajar", Me.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = Windows.Forms.DialogResult.Retry Then
                GoTo inicio
            End If
        End If
        Form1.VentanaActiva = Me.Tag
    End Sub

    Private Sub Lista_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Form1.VentanaActiva = Me.Tag
    End Sub

    Private Sub Lista_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        'por este método se ingresan los comandos a los elementos
        If VnT Is Nothing Then
            Exit Sub
        End If
        Dim index As Int16
        With ProG
            .Value = 0
            .Visible = True
            .Maximum = VnT.Length - 1
            .Step = 1
        End With

        Select Case Me.Text.Substring(0, 4)
            Case "[Gu]"                   '----------------------guardar-------------
                Dim dlg As New guardar
                dlg.ShowDialog()
                If dlg.RadioButton1.Checked = True Then
                    'guadar todos juntos
                    For index = 0 To VnT.Length - 1
                        VnT(index).Text = "[Gp] " & VnT(index).Text
                        ProG.PerformStep()
                    Next
                ElseIf dlg.RadioButton2.Checked = True Then
                    'guardar uno por uno
                    For index = 0 To VnT.Length - 1
                        VnT(index).Text = "[Gu] " & VnT(index).Text
                        ProG.PerformStep()
                    Next
                Else
                    Exit Select
                End If
                dlg.Dispose()

                Dim lvit(VnT.Length - 1) As ListViewItem
                LV.Items.Clear()
                For index = 0 To VnT.Length - 1
                    Dim fileinf As New FileInfo(VnT(index).ruta)
                    Dim lvitm As New ListViewItem(fileinf.Name)
                    'se ponen los íconos
                    Select Case Path.GetExtension(fileinf.Name).ToUpper
                        Case ".EVT"
                            lvitm.ImageIndex = 0
                        Case ".TXT"
                            lvitm.ImageIndex = 1
                        Case ".EXE"
                            lvitm.ImageIndex = 2
                        Case ".DWG"
                            lvitm.ImageIndex = 3
                        Case ".PDF"
                            lvitm.ImageIndex = 4
                        Case ".001P", ".A01P", ".B01P", ".C01P"
                            lvitm.ImageIndex = 8
                        Case ".002P", ".A02P", ".B02P", ".C02P"
                            lvitm.ImageIndex = 9
                        Case ".003P", ".A03P", ".B03P", ".C03P"
                            lvitm.ImageIndex = 10
                        Case ".HDR", ".HDA", ".HDB", ".HDC"
                            lvitm.ImageIndex = 11
                        Case ".SHD", ".SHA", ".SHB", ".SHC"
                            lvitm.ImageIndex = 12
                        Case ".001", ".A01", ".B01", ".C01"
                            lvitm.ImageIndex = 13
                        Case ".002", ".A02", ".B02", ".C02"
                            lvitm.ImageIndex = 14
                        Case ".003", ".A03", ".B03", ".C03"
                            lvitm.ImageIndex = 15
                        Case ".004", ".005", ".006", ".007", ".008", ".009", ".010", ".011", ".012", ".013", ".014", ".015", ".016", ".017", ".018", ".019", ".020", ".021", ".022", ".023", ".024"
                            'cualquier otro canal adicional
                            lvitm.ImageIndex = 16
                        Case ".004P", ".005P", ".006P", ".007P", ".008P", ".009P", ".010P", ".011P", ".012P", ".013P", ".014P", ".015P", ".016P", ".017P", ".018P", ".019P", ".020P", ".021P", ".022P", ".023P", ".024P"
                            'cualquier otro canal adicional procesado
                            lvitm.ImageIndex = 17
                        Case Else
                            lvitm.ImageIndex = 5
                    End Select
                    'agregar subelementos 
                    If fileinf.Length / MB >= 1 Then
                        'LVitm.SubItems.Add(Format(Str(FileInf.Length / MB), "F") + "mb")
                        lvitm.SubItems.Add(Format(fileinf.Length / MB, "F") + "mb")
                    Else
                        'LVitm.SubItems.Add(Format(Str(FileInf.Length / KB), "F") + "kb")
                        lvitm.SubItems.Add(Format(fileinf.Length / KB, "F") + "kb")
                    End If
                    lvitm.SubItems.Add(fileinf.LastWriteTime.ToString)
                    lvitm.SubItems.Add(fileinf.CreationTime.ToString)
                    'LVitm.SubItems.Add(FileInf.Attributes.ReadOnly.ToString)
                    lvitm.SubItems.Add(fileinf.FullName)

                    lvit.SetValue(lvitm, index)
                Next

                LV.Items.AddRange(lvit)

                ReDim elem(VnT.Length - 1)
                For index = 0 To VnT.Length - 1
                    elem(index) = VnT(index).ruta
                Next

            Case "[SP]", "[Dz]", "[Es]", "[Cr]"    '-----vel de muestreo, diezmado, escalar, agretar ceros ---
                Dim val As String
                val = PreguntarValor(Me.Text.Substring(0, 4))
                For index = 0 To VnT.Length - 1
                    VnT(index).Text = Me.Text.Substring(0, 3) & "=" & val & "] " & VnT(index).Text
                    ProG.PerformStep()
                Next
                
            Case Else
                For index = 0 To VnT.Length - 1
                    VnT(index).Text = Me.Text.Substring(0, 5) & VnT(index).Text
                    ProG.PerformStep()
                Next
        End Select
        Me.Focus()
        ProG.Visible = False
    End Sub

    Private Sub LV_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles LV.ItemCheck
        Form1.VentanaActiva = Me.Tag
        If Not e.CurrentValue = CheckState.Checked Then
            VnT(e.Index).Show()
            current = e.Index
        Else
            VnT(e.Index).Visible = False
        End If

    End Sub

    Function PreguntarValor(ByVal t As String) As String
        Dim esc As New Escalar
        esc.Owner = Me
        Select Case t
            Case "[SP]"
                esc.Text = "Scans Per Second"
                esc.Button1.Text = "SPS"
                esc.Label1.Text = "Valor de SPS del registro:"
                esc.TextBox1.Text = Form1.SPS
            Case "[Dz]"
                esc.Text = "Diezmado"
                esc.Button1.Text = "Diezmado"
                esc.Label1.Text = "Se leeran N de cada 10 muestras"
                esc.TextBox1.Text = "10"
            Case "[Es]"
                esc.Text = "Escalar"
                esc.Button1.Text = "Escalar"
                esc.Label1.Text = "Valor por el cual se multiplicará el registro:"
                esc.TextBox1.Text = "392.4"
            Case "[Cr]"
                esc.Text = "Agregar ceros"
                esc.Button1.Text = "Agregar"
                esc.Label1.Text = "Segundos que se agregan al inicio"
                esc.TextBox1.Text = "0"
        End Select
        esc.ShowDialog()
        PreguntarValor = esc.TextBox1.Text
        esc.Dispose()
        Select Case t
            Case "[SP]"
                Form1.SPS = PreguntarValor
            Case "[Dz]"
                Form1.diezmado = PreguntarValor
        End Select
    End Function

    Private Sub Lista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Form1.VentanaActiva = Me.Tag
    End Sub

End Class
