Imports System.IO
Public Class Filtro
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents st As System.Windows.Forms.Label
    Friend WithEvents RBcreac As System.Windows.Forms.RadioButton
    Friend WithEvents RBmodif As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVaux As System.Windows.Forms.ListView
    Friend WithEvents LVf As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Co As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filtro))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RBcreac = New System.Windows.Forms.RadioButton
        Me.RBmodif = New System.Windows.Forms.RadioButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.LV3 = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.st = New System.Windows.Forms.Label
        Me.LVaux = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.LVf = New System.Windows.Forms.ListView
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.Co = New System.Windows.Forms.Label
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(559, 96)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.RBcreac)
        Me.TabPage1.Controls.Add(Me.RBmodif)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(551, 70)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1° - Fecha"
        Me.TabPage1.ToolTipText = "Filtrado en base al rango de fechas de creación o modificación de los archivos"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(120, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Filtrar por fecha"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(323, 31)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(323, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2006, 11, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(281, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(281, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'RBcreac
        '
        Me.RBcreac.Location = New System.Drawing.Point(8, 31)
        Me.RBcreac.Name = "RBcreac"
        Me.RBcreac.Size = New System.Drawing.Size(104, 24)
        Me.RBcreac.TabIndex = 5
        Me.RBcreac.Text = "Creación"
        '
        'RBmodif
        '
        Me.RBmodif.Checked = True
        Me.RBmodif.Location = New System.Drawing.Point(8, 7)
        Me.RBmodif.Name = "RBmodif"
        Me.RBmodif.Size = New System.Drawing.Size(104, 24)
        Me.RBmodif.TabIndex = 4
        Me.RBmodif.TabStop = True
        Me.RBmodif.Text = "Modificación"
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.CheckBox3)
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(551, 70)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2° - Acelerógrafo"
        Me.TabPage2.ToolTipText = "Seleccione los acelerógrafos cuyos registros integrarán la consulta"
        '
        'CheckBox3
        '
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(4, 7)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(46, 15)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "C"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(4, 26)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 15)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "B"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(233, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 66)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripción"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(4, 45)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(46, 15)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "A"
        '
        'TabPage4
        '
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.CheckBox12)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.CheckBox8)
        Me.TabPage4.Controls.Add(Me.CheckBox7)
        Me.TabPage4.Controls.Add(Me.CheckBox9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(551, 70)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "3° - Tipo de archivo"
        Me.TabPage4.ToolTipText = "Otros tipos de archivo como encabezados o de evento."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 59)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de los registros sísmicos, mostrar:"
        '
        'RadioButton3
        '
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(264, 20)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(117, 30)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Todos los registros"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(136, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(127, 30)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Solo registros procesados"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(8, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(127, 30)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Solo registros en bruto"
        '
        'CheckBox8
        '
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Location = New System.Drawing.Point(428, 45)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(104, 24)
        Me.CheckBox8.TabIndex = 8
        Me.CheckBox8.Text = "Header simple"
        '
        'CheckBox7
        '
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Location = New System.Drawing.Point(428, 21)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(121, 24)
        Me.CheckBox7.TabIndex = 7
        Me.CheckBox7.Text = "Header con formato"
        '
        'CheckBox9
        '
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(395, -2)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(49, 24)
        Me.CheckBox9.TabIndex = 6
        Me.CheckBox9.Text = "EVT"
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.CheckBox11)
        Me.TabPage3.Controls.Add(Me.CheckBox6)
        Me.TabPage3.Controls.Add(Me.CheckBox10)
        Me.TabPage3.Controls.Add(Me.CheckBox5)
        Me.TabPage3.Controls.Add(Me.CheckBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(551, 70)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "4° - Canal"
        Me.TabPage3.ToolTipText = "Selección de canales disponibles."
        '
        'CheckBox11
        '
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(296, 39)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(110, 24)
        Me.CheckBox11.TabIndex = 12
        Me.CheckBox11.Text = "Canales 13 al 24"
        '
        'CheckBox6
        '
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(127, -2)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(62, 24)
        Me.CheckBox6.TabIndex = 2
        Me.CheckBox6.Text = "Canal 3"
        '
        'CheckBox10
        '
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(296, 9)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(110, 24)
        Me.CheckBox10.TabIndex = 3
        Me.CheckBox10.Text = "Canales 4 al 12"
        '
        'CheckBox5
        '
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(65, -2)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(62, 24)
        Me.CheckBox5.TabIndex = 1
        Me.CheckBox5.Text = "Canal 2"
        '
        'CheckBox4
        '
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(3, -2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(62, 24)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "Canal 1"
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
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SoloLectura"
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ruta"
        Me.ColumnHeader5.Width = 260
        '
        'LV3
        '
        Me.LV3.AllowColumnReorder = True
        Me.LV3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader12})
        Me.LV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV3.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV3.FullRowSelect = True
        Me.LV3.GridLines = True
        Me.LV3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LV3.HideSelection = False
        Me.LV3.Location = New System.Drawing.Point(3, 16)
        Me.LV3.MultiSelect = False
        Me.LV3.Name = "LV3"
        Me.LV3.Size = New System.Drawing.Size(553, 272)
        Me.LV3.SmallImageList = Me.ImageList
        Me.LV3.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LV3.TabIndex = 2
        Me.LV3.UseCompatibleStateImageBehavior = False
        Me.LV3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nombre"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Tamaño"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Modificado"
        Me.ColumnHeader9.Width = 110
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Creado"
        Me.ColumnHeader10.Width = 110
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Ruta"
        Me.ColumnHeader12.Width = 260
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LV3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 291)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista Previa"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Aceptar"
        '
        'st
        '
        Me.st.Location = New System.Drawing.Point(256, 393)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(311, 33)
        Me.st.TabIndex = 6
        '
        'LVaux
        '
        Me.LVaux.AllowColumnReorder = True
        Me.LVaux.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.LVaux.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVaux.FullRowSelect = True
        Me.LVaux.GridLines = True
        Me.LVaux.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVaux.HideSelection = False
        Me.LVaux.Location = New System.Drawing.Point(384, 202)
        Me.LVaux.MultiSelect = False
        Me.LVaux.Name = "LVaux"
        Me.LVaux.Size = New System.Drawing.Size(158, 104)
        Me.LVaux.SmallImageList = Me.ImageList
        Me.LVaux.TabIndex = 7
        Me.LVaux.UseCompatibleStateImageBehavior = False
        Me.LVaux.View = System.Windows.Forms.View.Details
        Me.LVaux.Visible = False
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Nombre"
        Me.ColumnHeader13.Width = 150
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Tamaño"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Modificado"
        Me.ColumnHeader15.Width = 110
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Creado"
        Me.ColumnHeader16.Width = 110
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "SoloLectura"
        Me.ColumnHeader17.Width = 90
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Ruta"
        Me.ColumnHeader18.Width = 260
        '
        'LVf
        '
        Me.LVf.AllowColumnReorder = True
        Me.LVf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.LVf.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVf.FullRowSelect = True
        Me.LVf.GridLines = True
        Me.LVf.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVf.HideSelection = False
        Me.LVf.Location = New System.Drawing.Point(216, 202)
        Me.LVf.MultiSelect = False
        Me.LVf.Name = "LVf"
        Me.LVf.Size = New System.Drawing.Size(158, 104)
        Me.LVf.SmallImageList = Me.ImageList
        Me.LVf.TabIndex = 8
        Me.LVf.UseCompatibleStateImageBehavior = False
        Me.LVf.View = System.Windows.Forms.View.Details
        Me.LVf.Visible = False
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Nombre"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Tamaño"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Modificado"
        Me.ColumnHeader21.Width = 110
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Creado"
        Me.ColumnHeader22.Width = 110
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "SoloLectura"
        Me.ColumnHeader23.Width = 90
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Ruta"
        Me.ColumnHeader24.Width = 260
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(5, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Reiniciar"
        '
        'Co
        '
        Me.Co.Location = New System.Drawing.Point(186, 392)
        Me.Co.Name = "Co"
        Me.Co.Size = New System.Drawing.Size(62, 33)
        Me.Co.TabIndex = 11
        Me.Co.Text = "Elementos:"
        '
        'CheckBox12
        '
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(450, -2)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox12.TabIndex = 10
        Me.CheckBox12.Text = ".Consulta"
        '
        'Filtro
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(559, 430)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LVf)
        Me.Controls.Add(Me.LVaux)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Filtro"
        Me.ShowInTaskbar = False
        Me.Text = "Filtro"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim lvitm As ListViewItem 'auxiliar

#Region "Eventos de formulario"
    Private Sub Filtro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker2.Value = Now
        Co.Text = "Elementos:   " & LV3.Items.Count
    End Sub

    Private Sub LV3_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV3.ItemActivate
        Dim LVitem As ListViewItem
        For Each LVitem In LV3.SelectedItems
            If Not LVitem.Text.StartsWith("->") Then
                Try
                    st.Text = "Abrientdo: " + LVitem.SubItems.Item(5).Text
                    Process.Start(LVitem.SubItems.Item(5).Text)
                Catch
                    st.Text = Err.Description.ToString
                    Err.Clear()
                    Exit Sub
                End Try
            End If
            st.Text = ""
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'botón de reiniciar
        RBcreac.Checked = True
        DateTimePicker1.Value = CDate("01/11/2006")
        DateTimePicker2.Value = Now
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        CheckBox7.Checked = True
        CheckBox8.Checked = True
        CheckBox9.Checked = True
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        CheckBox11.Checked = True
        RadioButton3.Select()
        copiar(LVf, LV3)
        Co.Text = "Elemntos:   " & LV3.Items.Count
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'boton aceptar
        ReDim Main.lv(LV3.Items.Count - 1)
        Dim k As Int32 = 0
        For Each lvitm In LV3.Items
            Main.lv.SetValue(lvitm, k)
            k += 1
        Next
        Main.FrmConslt.LV2.Items.Clear()
        For Each lvitm In Main.lv
            Main.FrmConslt.LV2.Items.Add(lvitm.Clone)
            Main.FrmConslt.S1.Text = "Cantidad: " & k.ToString
        Next
        Me.Dispose()

    End Sub
#End Region

#Region "Descripción del instrumento"
    Private Sub CheckBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.MouseHover
        Label3.Text = "Descripción:" & vbNewLine & vbCr & _
        "Nivel: Estacionamiento 1" & vbCr & "StationId: EAE1"
    End Sub
    Private Sub CheckBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.MouseHover
        Label3.Text = "Descripción:" & vbNewLine & vbCr & _
     "Nivel: 2o" & vbCr & "StationId: EAN2"
    End Sub
    Private Sub CheckBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.MouseHover
        Label3.Text = "Descripción:" & vbNewLine & vbCr & _
        "Nivel: Penthouse" & vbCr & "StationId: EAPH"
    End Sub
    Private Sub CheckBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.MouseLeave
        Label3.Text = ""
    End Sub

    Private Sub CheckBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.MouseLeave
        Label3.Text = ""
    End Sub

    Private Sub CheckBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.MouseLeave
        Label3.Text = ""
    End Sub
#End Region

#Region "Filtro por fecha"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LVaux.Items.Clear()
        'boton filtrar por fecha  
        'RANGO D FECHAS
        If RBmodif.Checked = True Then
            'de la fecha de modificación
            For Each lvitm In LV3.Items
                If Date.Compare(CDate(lvitm.SubItems(2).Text), DateTimePicker1.Value) >= 0 _
                And Date.Compare(CDate(lvitm.SubItems(2).Text), DateTimePicker2.Value) <= 0 Then
                    LVaux.Items.Add(lvitm.Clone)
                End If
            Next
        Else
            'de la fecha de creación
            For Each lvitm In LV3.Items
                If Date.Compare(CDate(lvitm.SubItems(3).Text), DateTimePicker1.Value) >= 0 _
                And Date.Compare(CDate(lvitm.SubItems(3).Text), DateTimePicker2.Value) <= 0 Then
                    LVaux.Items.Add(lvitm.Clone)
                End If
            Next
        End If
        copiar(LVaux, LV3)
        clrep()
    End Sub
#End Region

    <System.Diagnostics.DebuggerStepThrough()> Sub copiar(ByVal lvOrigen As ListView, ByVal lvDestino As ListView)
        lvDestino.Items.Clear()

        For Each lvitm In lvOrigen.Items
            lvDestino.Items.Add(lvitm.Clone)
        Next
    End Sub

#Region "filtro por acelerógrafo"
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            For Each lvitm In LV3.Items
                If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                    'solo si los canales están activados
                    If CheckBox4.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("1") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("1P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox5.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("2") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("2P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox6.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("3") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("3P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox10.Checked = True Then
                        If checar4_12(Path.GetExtension(lvitm.Text).ToUpper) Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox11.Checked = True Then
                        If checar13_24(Path.GetExtension(lvitm.Text).ToUpper) Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            'si acelr B
            For Each lvitm In LV3.Items
                If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                    'solo si los canales están activados
                    If CheckBox4.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("1") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("1P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox5.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("2") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("2P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox6.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("3") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("3P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox10.Checked = True Then
                        If checar4_12(Path.GetExtension(lvitm.Text).ToUpper) Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox11.Checked = True Then
                        If checar13_24(Path.GetExtension(lvitm.Text).ToUpper) Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            'si acelr C
            For Each lvitm In LV3.Items
                If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                    'solo si los canales están activados
                    If CheckBox4.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("1") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("1P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox5.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("2") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("2P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox6.Checked = True Then
                        If Path.GetExtension(lvitm.Text).EndsWith("3") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("3P") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox10.Checked = True Then
                        If checar4_12(Path.GetExtension(lvitm.Text).ToUpper) Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox11.Checked = True Then
                        If checar13_24(Path.GetExtension(lvitm.Text).ToUpper) Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
#End Region

#Region "filtro por canal"
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = False Then
            For Each lvitm In LV3.Items
                If Path.GetExtension(lvitm.Text).EndsWith("1") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("1P") Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If Path.GetExtension(lvitm.Text).EndsWith("1") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("1P") Then
                    If CheckBox1.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox2.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox3.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If Path.GetExtension(lvitm.Text).StartsWith(".0") Then
                        LV3.Items.Add(lvitm.Clone)
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = False Then
            For Each lvitm In LV3.Items
                If Path.GetExtension(lvitm.Text).EndsWith("2") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("2P") Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If Path.GetExtension(lvitm.Text).EndsWith("2") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("2P") Then
                    If CheckBox1.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox2.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox3.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If Path.GetExtension(lvitm.Text).StartsWith(".0") Then
                        LV3.Items.Add(lvitm.Clone)
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = False Then
            For Each lvitm In LV3.Items
                If Path.GetExtension(lvitm.Text).EndsWith("3") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("3P") Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If Path.GetExtension(lvitm.Text).EndsWith("3") Or Path.GetExtension(lvitm.Text).ToUpper.EndsWith("3P") Then
                    If CheckBox1.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox2.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox3.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If Path.GetExtension(lvitm.Text).StartsWith(".0") Then
                        LV3.Items.Add(lvitm.Clone)
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox6.Checked = False Then
            For Each lvitm In LV3.Items
                If checar4_12(Path.GetExtension(lvitm.Text).ToUpper) Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If checar4_12(Path.GetExtension(lvitm.Text).ToUpper) Then
                    If CheckBox1.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox2.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox3.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If Path.GetExtension(lvitm.Text).StartsWith(".0") Then
                        LV3.Items.Add(lvitm.Clone)
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox6.Checked = False Then
            For Each lvitm In LV3.Items
                If checar13_24(Path.GetExtension(lvitm.Text).ToUpper) Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                If checar13_24(Path.GetExtension(lvitm.Text).ToUpper) Then
                    If CheckBox1.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".A") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox2.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".B") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If CheckBox3.Checked = True Then
                        If Path.GetExtension(lvitm.Text).ToUpper.StartsWith(".C") Then
                            LV3.Items.Add(lvitm.Clone)
                        End If
                    End If
                    If Path.GetExtension(lvitm.Text).StartsWith(".0") Then
                        LV3.Items.Add(lvitm.Clone)
                    End If
                End If
            Next
        End If
        clrep()
    End Sub
#End Region

#Region "filtro por tipo de archivo"
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        cEVT()
        clrep()
    End Sub
    'Sub cHD_()
    '    Dim pruev As String
    '    If CheckBox7.Checked = False Then
    '        For Each lvitm In LV3.Items
    '            pruev = Path.GetExtension(lvitm.Text).ToUpper
    '            If pruev.StartsWith(".HD") Then
    '                lvitm.Remove()
    '            End If
    '        Next
    '    Else
    '        For Each lvitm In LVf.Items
    '            pruev = Path.GetExtension(lvitm.Text).ToUpper
    '            If pruev.StartsWith(".HD") Then
    '                LV3.Items.Add(lvitm.Clone)
    '            End If
    '        Next
    '    End If
    'End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        chkext(".HD", CheckBox7)
        clrep()
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        chkext(".SH", CheckBox8)
        clrep()
    End Sub
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        chkext(".CONSULTA", CheckBox12)
        clrep()
    End Sub

    Sub chkext(ByVal EXT As String, ByVal ckbx_dev As CheckBox)
        EXT = EXT.ToUpper
        Dim pruev As String
        If ckbx_dev.Checked = False Then
            For Each lvitm In LV3.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If pruev.StartsWith(EXT) Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If pruev.StartsWith(EXT) Then
                    LV3.Items.Add(lvitm.Clone)
                End If
            Next
        End If
    End Sub

    Sub cEVT()
        Dim pruev As String
        If CheckBox9.Checked = False Then
            For Each lvitm In LV3.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If pruev = ".EVT" Then
                    lvitm.Remove()
                End If
            Next
        Else
            For Each lvitm In LVf.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If pruev = ".EVT" Then
                    LV3.Items.Add(lvitm.Clone)
                End If
            Next
        End If
    End Sub


    'por el estado de los registros        los procesados agregan una p al final de la extensión
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        'todos los registros
        If RadioButton3.Checked = True Then
            LV3.Items.Clear()
            For Each lvitm In LVf.Items
                LV3.Items.Add(lvitm.Clone)
            Next
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True
            CheckBox9.Checked = True
            CheckBox10.Checked = True
            CheckBox11.Checked = True
            CheckBox12.Checked = True
        End If
        cEVT()
        chkext(".HD", CheckBox7)
        chkext(".SH", CheckBox8)
        clrep()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'solo registros en bruto
        Dim pruev As String
        If RadioButton1.Checked = True Then
            For Each lvitm In LV3.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If pruev.EndsWith("P") Or pruev.EndsWith(".CONSULTA") Then
                    lvitm.Remove()
                End If

            Next
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox11.Checked = False

        Else
            For Each lvitm In LVf.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If pruev.EndsWith("P") Then
                    LV3.Items.Add(lvitm.Clone)
                End If
            Next
        End If
        cEVT()
        chkext(".HD", CheckBox7)
        chkext(".SH", CheckBox8)
        clrep()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'solo registros tratados
        Dim pruev As String
        If RadioButton2.Checked = True Then
            For Each lvitm In LV3.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If Not pruev.EndsWith("P") Then
                    lvitm.Remove()
                End If
            Next
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox11.Checked = False
        Else
            For Each lvitm In LVf.Items
                pruev = Path.GetExtension(lvitm.Text).ToUpper
                If Not pruev.EndsWith("P") Then
                    LV3.Items.Add(lvitm.Clone)
                End If
            Next
        End If
        cEVT()
        chkext(".HD", CheckBox7)
        chkext(".SH", CheckBox8)
        clrep()
    End Sub
#End Region


    Private Sub clrep()                   'para quitar los repetidos, es necesario porque la consulta es cruzada
        LV3.Sorting = SortOrder.Ascending
        LV3.Sort()
        Dim lvitm2 As ListViewItem
        Dim k As Int16
        'en modo de borrar
        For Each lvitm In LV3.Items
            For Each lvitm2 In LV3.Items
                'If lvitm.Index < 0 Then
                '    GoTo siguiente
                'End If
                If lvitm.Text = lvitm2.Text And lvitm.Index <> lvitm2.Index Then
                    lvitm2.Remove()
                    On Error Resume Next
                End If
            Next
            'siguiente:
        Next
        Co.Text = "Elementos:   " & LV3.Items.Count
    End Sub

    Private Function checar4_12(ByVal tx As String) As Boolean
        If tx.EndsWith("04") Or tx.EndsWith("05") Or tx.EndsWith("06") _
        Or tx.EndsWith("07") Or tx.EndsWith("08") Or tx.EndsWith("09") _
        Or tx.EndsWith("10") Or tx.EndsWith("11") Or tx.EndsWith("12") _
        Or tx.ToUpper.EndsWith("04P") Or tx.ToUpper.EndsWith("05P") Or tx.ToUpper.EndsWith("06P") _
        Or tx.ToUpper.EndsWith("07P") Or tx.ToUpper.EndsWith("08P") Or tx.ToUpper.EndsWith("09P") _
        Or tx.ToUpper.EndsWith("10P") Or tx.ToUpper.EndsWith("11P") Or tx.ToUpper.EndsWith("12P") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function checar13_24(ByVal tx As String) As Boolean
        If tx.EndsWith("14") Or tx.EndsWith("15") Or tx.EndsWith("16") _
        Or tx.EndsWith("17") Or tx.EndsWith("18") Or tx.EndsWith("19") _
        Or tx.EndsWith("20") Or tx.EndsWith("21") Or tx.EndsWith("22") _
        Or tx.EndsWith("23") Or tx.EndsWith("24") Or tx.EndsWith("13") _
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
