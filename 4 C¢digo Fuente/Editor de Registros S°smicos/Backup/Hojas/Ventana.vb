Imports System.IO
Imports Editor_de_Registros_Sísmicos.ClassDibujo
Imports System.Drawing.Printing

Public Class Ventana
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    <Diagnostics.DebuggerStepThrough()> Public Sub New()
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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents MAX As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MIN As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MED As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DIST As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ST As System.Windows.Forms.StatusBarPanel
    Friend WithEvents VAL As System.Windows.Forms.StatusBarPanel
    Friend WithEvents PIC As System.Windows.Forms.PictureBox
    Friend WithEvents IZQ As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DER As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Te As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Ventana))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.MAX = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.MIN = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.MED = New System.Windows.Forms.StatusBarPanel
        Me.DIST = New System.Windows.Forms.StatusBarPanel
        Me.ST = New System.Windows.Forms.StatusBarPanel
        Me.IZQ = New System.Windows.Forms.StatusBarPanel
        Me.DER = New System.Windows.Forms.StatusBarPanel
        Me.Te = New System.Windows.Forms.StatusBarPanel
        Me.VAL = New System.Windows.Forms.StatusBarPanel
        Me.PIC = New System.Windows.Forms.PictureBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IZQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.MAX, Me.StatusBarPanel2, Me.MIN, Me.StatusBarPanel3, Me.MED, Me.DIST, Me.ST, Me.IZQ, Me.DER, Me.Te, Me.VAL})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(850, 22)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Text = "Mx="
        Me.StatusBarPanel1.Width = 36
        '
        'MAX
        '
        Me.MAX.Width = 80
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel2.Text = "Mn="
        Me.StatusBarPanel2.Width = 37
        '
        'MIN
        '
        Me.MIN.Width = 80
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Text = "Md="
        Me.StatusBarPanel3.Width = 37
        '
        'MED
        '
        Me.MED.Width = 80
        '
        'DIST
        '
        Me.DIST.Text = "P2P="
        '
        'ST
        '
        Me.ST.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.ST.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.ST.Width = 200
        '
        'IZQ
        '
        Me.IZQ.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.IZQ.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.IZQ.Icon = CType(resources.GetObject("IZQ.Icon"), System.Drawing.Icon)
        Me.IZQ.MinWidth = 5
        Me.IZQ.ToolTipText = "Izquierda"
        Me.IZQ.Width = 40
        '
        'DER
        '
        Me.DER.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DER.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.DER.Icon = CType(resources.GetObject("DER.Icon"), System.Drawing.Icon)
        Me.DER.MinWidth = 5
        Me.DER.ToolTipText = "Derecha"
        Me.DER.Width = 40
        '
        'Te
        '
        Me.Te.ToolTipText = "Tiempo"
        Me.Te.Width = 50
        '
        'VAL
        '
        Me.VAL.ToolTipText = "Valor"
        Me.VAL.Width = 70
        '
        'PIC
        '
        Me.PIC.ContextMenu = Me.ContextMenu1
        Me.PIC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PIC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PIC.Location = New System.Drawing.Point(0, 22)
        Me.PIC.Name = "PIC"
        Me.PIC.Size = New System.Drawing.Size(850, 198)
        Me.PIC.TabIndex = 1
        Me.PIC.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem7, Me.MenuItem6, Me.MenuItem8, Me.MenuItem9})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Antialias"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Rápido"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Alta callidad"
        '
        'MenuItem4
        '
        Me.MenuItem4.Checked = True
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Normal"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "Vista previa de impresión"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "Imprimir"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.Text = "Conf de Visualización"
        '
        'SFD
        '
        Me.SFD.Title = "Guardar como"
        '
        'Ventana
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(850, 220)
        Me.Controls.Add(Me.PIC)
        Me.Controls.Add(Me.StatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(220, 100)
        Me.Name = "Ventana"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IZQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"
    Dim rg(,) As Double
    Dim rgF(,) As Double
    Dim tX As Double
    Dim FEscala As Decimal
    Private WithEvents printdocument1 As New PrintDocument
    Dim DzVis As Int16 = 1
    Dim T1, T2 As Single
    Public Shared MaG() As Double
    Dim Tam_Orig As Single
    Public ruta As String
#End Region

#Region "Ventana events"
    Private Sub Ventana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.diezmado = 1
        Form1.SPS = 200
        If Me.Text.StartsWith("Nueva ventana") Then
            Exit Sub 'de hecho no se usa
        ElseIf Me.Text.StartsWith("Clon") Then
            rg = Form1.clonrg.Clone
            MMM()
            PIC.Refresh()
            Exit Sub
        End If
        ' StatusBar1.SuspendLayout()
        ruta = Me.Text
        Dim reg As String
        Try
            Dim strdr As New StreamReader(Me.Text)
            reg = strdr.ReadToEnd()
            strdr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Err.Clear()
            Me.Visible = False
            Exit Sub
        End Try



        Dim i, j, var, segund, VmaX, VmiN, VmeD, VdisT As Double
        VmaX = Decimal.MinValue
        VmiN = Decimal.MaxValue
        VmeD = "0"
        DIST.Text = "0"
        If reg.StartsWith("N=") Then
            'es un archivo degtra con la primera línea N,Dt y T(Xini)
            ST.Text = "Leyendo archivo ..."
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
                var = rg(i, 0)
                If var > VmaX Then
                    VmaX = var
                    VdisT = rg(i, 1)
                End If
                If var < VmiN Then
                    VmiN = var
                    segund = rg(i, 1)
                End If
                VmeD = VmeD + var
            Next
        Else
            'o si es en ascii: (Ejemplo: Recien descomprimido de un evt)
            reg = reg.Replace(vbNewLine, "")
            'el ancho de la columna es fijo=12 en el formado ascii
            ReDim rg((reg.Length) * 1 / (12 * Form1.diezmado) - 1, 1)
            rg(i, 1) = 0
            For j = 0 To ((reg.Length - 1)) Step (12 * Form1.diezmado / 1)
                rg(i, 0) = reg.Substring(j, 12)
                Try
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Catch ex As Exception
                    Err.Clear()
                End Try
                i += 1

                var = CDec(reg.Substring(j, 12))
                If var > VmaX Then
                    VmaX = var
                    VdisT = rg(i, 1)
                End If
                If var < VmiN Then
                    VmiN = var
                    segund = rg(i, 1)
                End If
                VmeD = VmeD + var
            Next
        End If

        '  StatusBar1.ResumeLayout()
        MED.Text = Format(VmeD / i, "#.0000000000")
        MAX.Text = Format(VmaX / 1, "#.0000000000")
        MAX.ToolTipText = VdisT & " Seg"
        MIN.Text = Format(VmiN / 1, "#.0000000000")
        MIN.ToolTipText = segund.ToString & " Seg"
        DIST.Text = "P2P=" & Format(Math.Abs(Math.Abs(segund) - Math.Abs(VdisT)), "##.00000 seg")
        Dim sw As New StreamWriter(Form1.directorioinf)
        sw.Write("Archivo reciente=" & Me.Text)
        sw.Flush()
        sw.Close()
    End Sub

    Private Sub Ventana_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Form1.VentanaActiva = Me.Tag
    End Sub

    Private Sub Ventana_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Form1.VentanaActiva = Me.Tag
    End Sub

    Private Sub Ventana_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        PIC.Refresh()
    End Sub

    Private Sub Ventana_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim form As Form
        For Each form In Me.OwnedForms
            form.Dispose()
        Next
        If Me.IsMdiChild = True Then    'Esto se usa para que la ventana sola (no de una lista) deje de importar pero, no se deseche, de modo que ocupe su lugar en el conjunto de hijos del programa y no tenga que cambiarse el índice a todos los demás.
            e.Cancel = True
            Me.Visible = False
        Else
            Lista.ActiveForm.Activate()
            e.Cancel = True    'si se trata de una ventana hija de una lista, que la borre.
            Me.Visible = False
        End If

    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick
        If e.StatusBarPanel.ToolTipText = "Izquierda" Then
            e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
            'a la izquierda
            Try
                Te.Text = rg(tX - 1, 1)
                VAL.Text = rg(tX - 1, 0)
                ST.Text = "Cursor a la izquierda"
                tX -= 1
            Catch ex As Exception
                Err.Clear()
            End Try
            e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Raised
            Exit Sub
        ElseIf e.StatusBarPanel.ToolTipText = "Derecha" Then
            e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
            'a la derecha
            Try
                Te.Text = rg(tX + 1, 1)
                VAL.Text = rg(tX + 1, 0)
                ST.Text = "Cursor a la derecha"
                tX += 1
            Catch ex As Exception
                Err.Clear()
            End Try
            e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Raised
            Exit Sub
        End If
        StatusBar1.Update()
    End Sub

    Private Sub Ventana_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Me.ControlBox = False And Asc(e.KeyChar) = 27 Then
            'entonces ésta ventana es hija de una lista y precionaron ESC
            Me.Close()
        End If
    End Sub

#End Region

    Private Sub Ventana_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        'StatusBar1.Visible = False
        Select Case Me.Text.Substring(0, 4)
            Case "[Gu]"            '---------------------------------------------guardar--------------------------
                If Not Me.Text.EndsWith("p") Then
                    SFD.FileName = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1) & "p"
                Else
                    SFD.FileName = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1)
                End If
                If SFD.ShowDialog = DialogResult.Cancel Then
                    Exit Sub
                ElseIf SFD.FileName = "" Then
                    Exit Sub
                End If
                Dim sw As New StreamWriter(SFD.FileName)
                Dim z As Single
                For z = 0 To CInt(rg.Length / 2) - 1
                    If rg(z, 0) < 0 Then
                        sw.WriteLine(Format(CStr(rg(z, 0)) / 1, "#.0000000000000").Substring(0, 12))
                    Else
                        sw.WriteLine(" " & Format(CStr(rg(z, 0)) / 1, "#.0000000000000").Substring(0, 11))
                    End If
                Next
                sw.Flush()
                sw.Close()
            Case "[Gp]"            '--------------------------------------------guardar todos juntos--------------
                Dim nombre As String
                If Not Me.Text.EndsWith("p") Then
                    nombre = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1) & "p"
                    ruta = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1) & "p"
                    Me.Text = Me.Text & "p"
                Else
                    nombre = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1)
                End If
                Dim sw As New StreamWriter(nombre)
                Dim z As Single
                For z = 0 To CInt(rg.Length / 2) - 1
                    If rg(z, 0) < 0 Then
                        'neg
                        sw.WriteLine(Format(CStr(rg(z, 0)) / 1, "#.0000000000000").Substring(0, 12))
                    Else
                        'pos
                        sw.WriteLine(" " & Format(CStr(rg(z, 0)) / 1, "#.0000000000000").Substring(0, 11))
                    End If
                Next
                sw.Flush()
                sw.Close()

            Case "[LB]"            '-----------------------------------------------linea base---------------------
                Dim z As Single
                Dim media As Double = MED.Text
                For z = 0 To CInt(rg.Length / 2) - 1
                    rg(z, 0) = rg(z, 0) - media
                Next
                StatusBar1.Visible = True
                ST.Text = "Encontrando picos ... "
                PIC.Refresh()
                MMM()
                ST.Text = ""
            Case "[Es]"            '-----------------------------------------------escalar------------------------
                Dim esc As New Escalar
                esc.Owner = Me
                esc.Text = "Escalar"
                esc.Button1.Text = "Escalar"
                esc.Label1.Text = "Valor por el cual se multiplicará el registro:"
                esc.TextBox1.Text = "392.4"
                esc.ShowDialog()
                FEscala = esc.Tag
                esc.Dispose()
                Dim z As Single
                For z = 0 To CInt(rg.Length / 2) - 1
                    rg(z, 0) = rg(z, 0) * FEscala
                Next
                MMM()
                PIC.Refresh()
            Case "[Es="            '-----------------------------------------------escalar-lista------------------
                Dim z As Single
                For z = 0 To CInt(rg.Length / 2) - 1
                    rg(z, 0) = rg(z, 0) * CSng(Me.Text.Substring(4, Me.Text.IndexOf("]", 4) - 4))
                Next
                MMM()
                PIC.Refresh()
            Case "[SP]"            '-----------------------------------------------------sps----------------------
                Dim esc As New Escalar
                esc.Owner = Me
                esc.Text = "Scans Per Second"
                esc.Button1.Text = "SPS"
                esc.Label1.Text = "Valor de SPS del registro:"
                esc.TextBox1.Text = "200"
                esc.ShowDialog()
                Form1.SPS = esc.Tag
                esc.Dispose()
                Dim i As Single
                On Error Resume Next
                rg(0, 1) = 0
                For i = 0 To CInt(rg.Length / 2) - 1
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Next
                MMM()
                PIC.Refresh()
            Case "[SP="            '-----------------------------------------------------sps--lista---------------
                Dim i As Single
                On Error Resume Next
                rg(0, 1) = 0
                For i = 0 To CInt(rg.Length / 2) - 1
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Next
                MMM()
                PIC.Refresh()
            Case "[CL]"            '------------------------------------------------clonar------------------------
                Form1.clonrg = rg.Clone
            Case "[CP]"            '-------------------------------------------------copiar-----------------------
                Form1.clonrg = rg.Clone
            Case "[Pg]"            '--------------------------------------------------pegar-----------------------
                PIC.Refresh()
            Case "[Dz]"            '-------------------------------------------------diezmar----------------------
                Dim esc As New Escalar
                esc.Owner = Me
                esc.Text = "Diezmado"
                esc.Button1.Text = "Diezmado"
                esc.Label1.Text = "1= Todo , 2= La mitad , ..."
                esc.TextBox1.Text = "1"
                esc.ShowDialog()
                Form1.diezmado = esc.Tag
                esc.Dispose()
                Dim aux(,) As Double
                aux = rg.Clone
                ReDim rg(CInt(((aux.Length / 2) - 1) * 1 / Form1.diezmado) - 1, 1)
                Dim i, j, df As Double

                'hace falta ajustar la sps
                Form1.SPS = Form1.SPS / Form1.diezmado

                On Error Resume Next
                For i = 0 To (aux.Length / 2) - 1 Step Form1.diezmado
                    df = df + (Form1.SPS / (aux.Length / 2 - 1))
                    rg(j, 0) = aux(i, 0)
                    rg(j, 1) = aux(i, 1)
                    j += 1
                Next


                MMM()
                PIC.Refresh()
            Case "[Dz="           '-------------------------------------------------diezmar---lista--------------
                Dim aux(,) As Double
                aux = rg.Clone
                ReDim rg(CInt(((aux.Length / 2) - 1) * 1 / Form1.diezmado - 1), 1)
                Dim i, j, df As Double
                'hace falta ajustar la sps
                Form1.SPS = Form1.SPS / Form1.diezmado
                On Error Resume Next
                For i = 0 To (rg.Length / 2) - 1 Step Form1.diezmado
                    df = df + (Form1.SPS / (aux.Length / 2 - 1))
                    rg(j, 0) = aux(i, 0)
                    rg(j, 1) = aux(i, 1)
                    j += 1
                Next


                MMM()
                PIC.Refresh()
            Case "[Cr]"            '---------------------------------------------agregar ceros--------------------
                Dim esc As New Escalar
                esc.Owner = Me
                esc.Text = "Agregar ceros"
                esc.Button1.Text = "Agregar"
                esc.Label1.Text = "Segundos que se agregan al inicio"
                esc.TextBox1.Text = "0"
                esc.ShowDialog()

                Dim aux(,) As Double
                aux = rg.Clone
                ReDim rg(CInt(esc.Tag * Form1.SPS) + CInt(aux.Length / 2) - 1, 1)
                Array.Copy(aux, 0, rg, 2 * (CInt(esc.Tag * Form1.SPS)), 2 * (CInt(aux.Length / 2)))
                Dim i As Double
                On Error Resume Next
                rg(0, 1) = 0
                For i = 0 To CInt(rg.Length / 2) - 1
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Next
                MMM()
                PIC.Refresh()
            Case "[Cr="            '---------------------------------------------agregar ceros--lista-------------
                Dim aux(,) As Double
                aux = rg.Clone
                ReDim rg(CInt(CSng(Me.Text.Substring(4, Me.Text.IndexOf("]", 4) - 4)) * Form1.SPS) + CInt(aux.Length / 2) - 1, 1)
                Array.Copy(aux, 0, rg, 2 * (CInt(CSng(Me.Text.Substring(4, Me.Text.IndexOf("]", 4) - 4)) * Form1.SPS)), 2 * (CInt(aux.Length / 2)))
                Dim i As Double
                On Error Resume Next
                rg(0, 1) = 0
                For i = 0 To CInt(rg.Length / 2) - 1
                    rg(i + 1, 1) = rg(i, 1) + (1 / Form1.SPS)
                Next
                MMM()
                PIC.Refresh()

            Case "[FT]"           '---------------------------------------fast-fourier-trasnform-------------------
filtrado:
                ')

                TransformadaRápidaDeFourier()
                'magnitud

                ReDim MaG(rgF.Length / 8 - 1)
                Dim i, j As Integer
                For i = 0 To MaG.Length - 1
                    On Error Resume Next
                    'Se obtiene la magnitud del número complejo y se multiplica por Dt para escalarlo
                    MaG(i) = (Math.Sqrt(rgF(j, 0) ^ 2 + rgF(j, 1) ^ 2) + Math.Sqrt(rgF(j + 1, 0) ^ 2 + rgF(j + 1, 1) ^ 2) + Math.Sqrt(rgF(j + 2, 0) ^ 2 + rgF(j + 2, 1) ^ 2) + Math.Sqrt(rgF(j + 3, 0) ^ 2 + rgF(j + 3, 1) ^ 2)) / (8 * Form1.SPS)
                    'MaG(i) = (Math.Sqrt(rgF(j, 0) ^ 2 + rgF(j, 1) ^ 2) + Math.Sqrt(rgF(j + 1, 0) ^ 2 + rgF(j + 1, 1) ^ 2)) / (2 * Form1.SPS)
                    j += 4
                Next



                Dim TRFwndw As New TRFview
                TRFwndw.MdiParent = Me.ParentForm
                TRFwndw.Text = "FFT : " & Me.Text
                TRFwndw.Show()
            Case "[Ft]"           '------------------------------------filtrar---------------------------------------------
                ' Dim FBnd As New FiltrBound
                'otravez:
                TransformadaRápidaDeFourier()
                Dim i, j As Integer

                ReDim MaG(rgF.Length / 8 - 1)
                For i = 0 To MaG.Length - 1

                    MaG(i) = (Math.Sqrt(rgF(j, 0) ^ 2 + rgF(j, 1) ^ 2) + Math.Sqrt(rgF(j + 1, 0) ^ 2 + rgF(j + 1, 1) ^ 2) + Math.Sqrt(rgF(j + 2, 0) ^ 2 + rgF(j + 2, 1) ^ 2) + Math.Sqrt(rgF(j + 3, 0) ^ 2 + rgF(j + 3, 1) ^ 2)) / (8 * Form1.SPS)

                    j += 4
                Next
                Dim TRFwndw As New TRFview
                ' TRFwndw.MdiParent = Me.ParentForm
                TRFwndw.Text = "FLTR: " & Me.Text
                trfwndw.rgF = rgF.Clone
                trfwndw.AcceptButton = trfwndw.Button2
                If trfwndw.Showdialog() = DialogResult.Cancel Then
                    Exit Select
                End If
                rgF = trfwndw.rgF.Clone

                For i = 0 To rgF.Length / 2 - 1
                    'rgF(i, 0) = rgF(i, 0) / (Tam_Orig) 'se usa para escalar el registro ,es erronea porque el verdadero tamaño lo lleva el tamaño
                    'rgF(i, 1) = rgF(i, 1) / (Tam_Orig) 'real del vector en cuestion. Tiene que escalarse con siguo mismo.

                    rgF(i, 0) = rgF(i, 0) / (rgF.Length / 4) 'se usa para escalar el registro, el tamaño de la parte positiva del espectro
                    rgF(i, 1) = rgF(i, 1) / (rgF.Length / 4)
                Next

                trfwndw.Dispose()
                AntiTransformadaRápidaDeFourier()

                Dim auxiliar(,) As Double
                auxiliar = rg.Clone
                ReDim rg(Tam_Orig, 1)
                rg(0, 0) = auxiliar(0, 0)
                For i = 1 To Tam_Orig
                    'For i = 1 To auxiliar.Length / 2 - 1
                    rg(i, 0) = auxiliar(i, 0)
                    rg(i, 1) = rg(i - 1, 1) + (1 / Form1.SPS)
                Next

                MMM()
                PIC.Refresh()

                'GoTo filtrado  'en caso de que se quiere mostrar el espectro otra vez.
        End Select
        '   StatusBar1.Visible = True
    End Sub

#Region "Pic"
    Private Sub PIC_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PIC.Paint

        If MenuItem1.Checked = True Then
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        ElseIf MenuItem2.Checked = True Then
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
        ElseIf MenuItem3.Checked = True Then
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Else
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.None
        End If
        If T2 <> 0 Then
            ' Dim fz As New Pen(Color.SteelBlue, 1)
            e.Graphics.Clear(PIC.BackColor)
            DrawOnPictureBox2(e.Graphics, PIC, rg, Color.Yellow)
            'e.Graphics.DrawLine(fz, T2, ClassDibujo.ymax * 100000, T2, ClassDibujo.ymin * 100000)
            e.Graphics.FillRectangle(Brushes.SteelBlue, T1, ClassDibujo.ymin * 100000, T2 - T1, (ClassDibujo.ymax - ClassDibujo.ymin) * 100000)
            DrawOnPictureBox3(e.Graphics, PIC, rg, Color.Yellow, DzVis)
            Exit Sub
        End If
        If Me.Text.StartsWith("Nueva ventana") Then
            Exit Sub
        ElseIf Me.Text.StartsWith("[Pg]") Then
            DrawOnPictureBox(e.Graphics, PIC, rg, Color.Yellow, True) 'cuando se dibuja el gráfico 
            DrawOnPictureBox(e.Graphics, PIC, Form1.clonrg, Color.GreenYellow, False) 'cuando se dibuja el gráfico el clon
        Else
            DrawOnPictureBox(e.Graphics, PIC, rg, Color.Yellow, True, DzVis) 'cuando se dibuja el gráfico 
        End If
        If T1 <> 0 Then
            Dim fz As New Pen(Color.LightBlue, 1)
            e.Graphics.DrawLine(fz, T1, ClassDibujo.ymax * 100000, T1, ClassDibujo.ymin * 100000)
        End If
    End Sub

    Private Sub PIC_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PIC.MouseMove
        Try
            PIC.SuspendLayout()
            tX = CInt((e.X * ((rg.Length / 2) - 1)) / (PIC.Width - 1))
            Te.Text = rg(tX, 1)
            VAL.Text = Format(CObj(rg(tX, 0)), "0.###E+000")
            PIC.ResumeLayout()
        Catch ex As Exception
            PIC.ResumeLayout()
        End Try
    End Sub

    Private Sub PIC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PIC.Click
        Form1.VentanaActiva = Me.Tag
        Static ConT As Int16 = 0
        If Form1.HandleZoom Then
            If ConT = 0 Then
                'el primer indice
                T1 = tX
                ST.Text = "T1= " & T1.ToString
                ConT = 1
            ElseIf ConT = 1 Then
                If tX <= T1 Then 'hacer el cambio, el t1 siempre será menor a t2
                    T2 = T1
                    T1 = tX
                Else
                    T2 = tX
                End If
                ST.Text = "T1= " & T1.ToString & "  T2= " & T2.ToString
                ConT = 2
                Dim zm As New Zm
                'ReDim zm.rgZ(T2 - T1 - 1, 1)
                'rg.Copy(rg, CLng(T1), zm.rgZ, 0, 2 * CLng(T2 - T1))
                zm.Owner = Me
                zm.Amort.Dispose()
                zm.Pico.Dispose()
                zm.rgZ = rg.Clone
                zm.di = 0
                zm.t1 = T1
                zm.t2 = T2
                zm.Text = "[Zoom {" & T1.ToString & "," & T2.ToString & "}] N=" & CStr(zm.rgZ.Length / 2 - 1) & "  " & Me.Text
                zm.Show()
            ElseIf ConT = 2 Then
                ST.Text = ""
                T2 = 0
                T1 = 0
                ConT = 0
            End If
        Else
            ST.Text = ""
            T2 = 0
            T1 = 0
            ConT = 0
        End If
        PIC.Refresh()
    End Sub

#End Region

#Region "Impresión"
    Private Sub MenuClick__Imprimir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim printdialog1 As New PrintDialog
        printdialog1.Document = printdocument1
        printdocument1.DefaultPageSettings.Landscape = True
        printdocument1.DocumentName = Me.Text.TrimEnd(".").TrimStart(" ")
        If printdialog1.ShowDialog = DialogResult.OK Then
            printdocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printdocument1.PrintPage
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(Color.White)
        Dim fonttitulo As New Font("Microsoft Sans Serif", 12, FontStyle.Underline)
        Dim font As New Font("Microsoft Sans Serif", 11)
        Dim fontchica As New Font("Arial", 8)
        Dim azul As New Pen(Color.DarkBlue, 0.005)
        Dim rojo As New Pen(Color.Red, 0.01)
        Dim grisborde As New Pen(Color.Gray, 0.1)
        Dim i As Int16
        For i = 1 To 9
            e.Graphics.DrawLine(rojo, 140 + CInt(840 * (i / 10)), 355, 140 + CInt(840 * (i / 10)), 350)
            e.Graphics.DrawString(Format(rg(CInt((rg.Length / 2 - 1) * (i / 10)), 1), "F"), _
            fontchica, Brushes.Gray, 140 + CInt(840 * (i / 10)), 355)
        Next
        For i = 0 To 12
            e.Graphics.DrawLine(rojo, 135, 100 + CInt(250 * (i / 12)), 140, 100 + CInt(250 * (i / 12)))
            e.Graphics.DrawString(Format(CSng(MAX.Text) - Math.Abs(CSng(MAX.Text) - CSng(MIN.Text)) * (i / 12), "0.###E+00"), _
            fontchica, Brushes.Gray, 85, 100 + CInt(250 * (i / 12)))
        Next
        e.Graphics.DrawString(Me.Text, fonttitulo, Brushes.Black, 100, 390)
        e.Graphics.DrawString("Max= " & MAX.Text & " (" & MAX.ToolTipText & ")    Min= " & MIN.Text & _
        " (" & MIN.ToolTipText & ")", font, Brushes.Black, 100, 420)
        e.Graphics.DrawString("Med= " & MED.Text & "        SPS: " & Form1.SPS & "          Diezmado: " & _
        Form1.diezmado & "            Fac. Escala: " & FEscala, font, Brushes.Black, 100, 440)
        e.Graphics.DrawString("Duración= " & rg((rg.Length / 2) - 1, 1) & " segundos", font, Brushes.Black, 100, 460)

        MapGraphicsWindow(e.Graphics, CSng(rg.Length / 2) - 1, CSng(MIN.Text) * 100000, 0, CSng(MAX.Text) * 100000, _
    980, _
    350, _
    140, _
    100)

        DrawOnPictureBox(e.Graphics, PIC, rg, Color.Black, False) 'cuando se dibuja el gráfico 
        e.Graphics.DrawRectangle(grisborde, 0, CSng(MIN.Text) * 100000, CInt(rg.Length / 2) - 1, _
        100000 * (Math.Abs(CSng(MAX.Text) - CSng(MIN.Text))))
        If CSng(MAX.Text) >= 0 And CSng(MIN.Text) <= 0 Then
            e.Graphics.DrawLine(rojo, 0, 0, CInt(rg.Length / 2) - 1, 0) 'linea de cero    solo si se ve
        End If

        'encontrar los indices en rg para el 10%,20%,...,90%   
        'la longitud total es rg.Length/2-1, entonces son 
        '10%=(rg.Length/2-1)*0.1 , 20%=(rg.Length/2-1)*0.2, ...
        'en cada uno dibujo una linea verde
        For i = 1 To 9
            e.Graphics.DrawLine(azul, CInt((rg.Length / 2 - 1) * (i / 10)), CInt(CSng(MIN.Text) * 100000), _
            CInt((rg.Length / 2 - 1) * (i / 10)), CInt(CSng(MAX.Text) * 100000))
        Next

        'ahora se hace lo mismo pero en las coord normales y en lugar de dibujar una raya se escribe el valor del tiempo
        ' e.Graphics.ResetTransform()
        'For i = 1 To 9
        '    e.Graphics.DrawLine(rojo, 140 + CInt(810 * (i / 10)), 355, 140 + CInt(810 * (i / 10)), 350)
        '    e.Graphics.DrawString(Format(rg(CInt((rg.Length / 2 - 1) * (i / 10)), 1), "F"), _
        '    fontchica, Brushes.Gray, 140 + CInt(810 * (i / 10)), 355)
        'Next
        'For i = 0 To 12
        '    e.Graphics.DrawLine(rojo, 135, 100 + CInt(250 * (i / 12)), 140, 100 + CInt(250 * (i / 12)))
        '    e.Graphics.DrawString(Format(CSng(MAX.Text) - Math.Abs(CSng(MAX.Text) - CSng(MIN.Text)) * (i / 12), "0.###E+00"), _
        '    fontchica, Brushes.Gray, 85, 100 + CInt(250 * (i / 12)))
        'Next

    End Sub

    Private Sub VistaPrevia_de_Impresión(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim printprev As New PrintPreviewDialog
        printprev.WindowState = FormWindowState.Maximized
        printprev.MdiParent = Me.ParentForm
        printprev.Document = printdocument1
        printdocument1.DefaultPageSettings.Landscape = True
        printdocument1.DocumentName = Me.Text.TrimEnd(".").TrimStart(" ")
        printprev.Icon = Me.Icon
        printprev.Visible = True
    End Sub

#End Region

#Region "Menu saltarin"
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'anti alias
        MenuItem1.Checked = True
        MenuItem2.Checked = False
        MenuItem3.Checked = False
        MenuItem4.Checked = False
        PIC.Refresh()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'rapido             
        MenuItem1.Checked = False
        MenuItem2.Checked = True
        MenuItem3.Checked = False
        MenuItem4.Checked = False
        PIC.Refresh()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        'alta calidad        
        MenuItem1.Checked = False
        MenuItem2.Checked = False
        MenuItem3.Checked = True
        MenuItem4.Checked = False
        PIC.Refresh()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        'normal           
        MenuItem1.Checked = False
        MenuItem2.Checked = False
        MenuItem3.Checked = False
        MenuItem4.Checked = True
        PIC.Refresh()
    End Sub

    Private Sub Conf_de_visualiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim cs As New Escalar
        cs.Text = "Diezmado para optimizar tiempo/calidad"
        cs.Label1.Text = "No afecta los cálculos, solo la Visualización"
        cs.TextBox1.Text = DzVis.ToString
        cs.Button1.Text = "Cambiar actual"
        cs.ShowDialog()
        DzVis = CInt(cs.TextBox1.Text)
        cs.Dispose()
        PIC.Refresh()
    End Sub
#End Region

    Function MMM()
        Dim i, var, segund As Double
        rg(i, 1) = 0
        Me.SuspendLayout()
        Dim Vmax, Vmin, Vmed, Vdist As Double
        Vmax = Decimal.MinValue
        Vmin = Decimal.MaxValue
        For i = 0 To CInt(rg.Length / 2) - 1
            var = rg(i, 0)
            If var > Vmax Then
                Vmax = var
                Vdist = rg(i, 1)
            End If
            If var < Vmin Then
                Vmin = var
                segund = rg(i, 1)
            End If
            Vmed = Vmed + var
        Next
        Me.ResumeLayout()
        MED.Text = Format(Vmed / i, "#.0000000")
        MAX.Text = Format(Vmax / 1, "#.0000000")
        MAX.ToolTipText = Vdist.ToString & " Seg"
        MIN.Text = Format(Vmin / 1, "#.0000000")
        MIN.ToolTipText = segund.ToString & " Seg"
        DIST.Text = "P2P=" & Format(Math.Abs(Math.Abs(segund) - Math.Abs(Vdist)), "##.00000 seg")
    End Function

#Region "Transformadas"

    Private Sub TransformadaRápidaDeFourier()
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
        'se toma siempre el 2^n inmediato superiór pero solo se muestra el rango original

        If P <> CInt(P) Then
            Dim supe As Int16
            supe = CInt(P.ToString.Substring(0, P.ToString.IndexOf("."))) + 1

            'Este el origen de las diferencias de resultados entre el Degtra y ARSis

            'lo que se hace aquí es suponer un registro mucho más largo del que se tiene; el tiempo que se agrega tiene puros ceros.
            'tal vez convenga identificar alguna parte representativa al final del registro y continuarla indefinidamente, pero no se como.

            'el degtra solo lee el registro el tamaño suficiente para tener el múltiplo P más cercano sin añadir tiempo

            'digamos que si P=15.34 entonces ARSis toma 16 y degtra toma 15

            'la ventaja de ARSis es que puede trabajarse con el registro completo sin diezmar

            'supe = CInt(P)
            N = 2 ^ supe
            ReDim rgF(N - 1, 1)
            For i = 0 To rg.Length / 2 - 1
                '    For i = 0 To rgF.Length / 2 - 1
                rgF(i, 0) = rgaux(i, 0)
            Next
        End If


        'For i = 0 To rgF.Length / 2 - 1
        '    rgF(i, 1) = 0
        'Next

        Dim J As Integer = N / 2
        Dim Aux_Real, Aux_Imag As Double
        'se invierte el orden de los datos de antemano pues el algoritmo 
        'de fft arroja los datos movidos. Tambien puede hacerse al final.
        For i = 1 To N - 2
            If i < J Then
                Aux_Real = rgF(J, 0)
                Aux_Imag = rgF(J, 1)
                rgF(J, 0) = rgF(i, 0)
                rgF(J, 1) = rgF(i, 1)
                rgF(i, 0) = Aux_Real
                rgF(i, 1) = Aux_Imag
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
                    Aux_Real = rgF(ip, 0) * UnitReal - rgF(ip, 1) * UnitImag
                    Aux_Imag = rgF(ip, 0) * UnitImag + rgF(ip, 1) * UnitReal
                    rgF(ip, 0) = rgF(i, 0) - Aux_Real
                    rgF(ip, 1) = rgF(i, 1) - Aux_Imag
                    rgF(i, 0) = rgF(i, 0) + Aux_Real
                    rgF(i, 1) = rgF(i, 1) + Aux_Imag
                Next
                Aux_Real = UnitReal
                UnitReal = Aux_Real * coseno - UnitImag * seno
                UnitImag = Aux_Real * seno + UnitImag * coseno
            Next
        Next


        ' la frecuencia cero está en realidad en rgf.length/4-1 (a la mitad) .'. la mitad son negativos (por los conjugados)
        ' podría desecharse la parte negativa (la segunda mitad)

    End Sub


    Private Sub AntiTransformadaRápidaDeFourier()
        rg = rgF.Clone 'se adquieren los valores

        Dim i, k As Integer 'contadores
        Dim N As Integer = rg.Length / 2    'El número de elementos, en realidad se tendrán 2n elementos(n reales y n imag)
        Dim P As Single
        P = Math.Log(N) / Math.Log(2) 'teóricamente siempre va a dar un entero

        Dim J As Integer = N / 2
        Dim Aux_Real, Aux_Imag As Double            'se invierte el orden de los datos de antemano pues el algoritmo
        For i = 1 To N - 2                        'de fft hace éste mismo cambio. Tambien puede hacerse al final.
            If i < J Then
                Aux_Real = rg(J, 0)
                Aux_Imag = rg(J, 1)
                rg(J, 0) = rg(i, 0)
                rg(J, 1) = rg(i, 1)
                rg(i, 0) = Aux_Real
                rg(i, 1) = Aux_Imag
            End If
            k = N / 2
            Do While k <= J
                J = J - k
                k = k / 2
            Loop
            J = J + k
        Next
        Dim Pe, ip As Integer
        'AntiFFT:
        Dim UnitReal, UnitImag, coseno, seno As Double
        For Pe = 1 To CInt(Math.Log(N) / Math.Log(2))
            UnitReal = 1
            UnitImag = 0
            coseno = Math.Cos(Math.PI / (CInt(2 ^ Pe) / 2))
            seno = Math.Sin(Math.PI / (CInt(2 ^ Pe) / 2))   ' cambio de signo
            For J = 1 To CInt(CInt(2 ^ Pe) / 2)

                For i = J - 1 To N - 1 Step CInt(2 ^ Pe)
                    ip = i + (CInt(2 ^ Pe) / 2)
                    Aux_Real = rg(ip, 0) * UnitReal - rg(ip, 1) * UnitImag
                    Aux_Imag = rg(ip, 0) * UnitImag + rg(ip, 1) * UnitReal
                    rg(ip, 0) = rg(i, 0) - Aux_Real
                    rg(ip, 1) = rg(i, 1) - Aux_Imag
                    rg(i, 0) = rg(i, 0) + Aux_Real
                    rg(i, 1) = rg(i, 1) + Aux_Imag
                Next
                Aux_Real = UnitReal
                UnitReal = Aux_Real * coseno - UnitImag * seno
                UnitImag = Aux_Real * seno + UnitImag * coseno
            Next
        Next

    End Sub

#End Region



End Class
