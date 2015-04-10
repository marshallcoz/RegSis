Imports Editor_de_Registros_Sísmicos.ClassDibujo
Imports System.Drawing.Printing
Imports System.IO

Public Class Zm
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
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MAX As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MIN As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MED As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DIST As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ST As System.Windows.Forms.StatusBarPanel
    Friend WithEvents IZQ As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DER As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Te As System.Windows.Forms.StatusBarPanel
    Friend WithEvents VAL As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Amort As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VistaPreviaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Pico As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zm))
        Me.pic = New System.Windows.Forms.PictureBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.MAX = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.MIN = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.MED = New System.Windows.Forms.StatusBarPanel
        Me.DIST = New System.Windows.Forms.StatusBarPanel
        Me.Pico = New System.Windows.Forms.StatusBarPanel
        Me.Amort = New System.Windows.Forms.StatusBarPanel
        Me.ST = New System.Windows.Forms.StatusBarPanel
        Me.IZQ = New System.Windows.Forms.StatusBarPanel
        Me.DER = New System.Windows.Forms.StatusBarPanel
        Me.Te = New System.Windows.Forms.StatusBarPanel
        Me.VAL = New System.Windows.Forms.StatusBarPanel
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VistaPreviaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IZQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.Black
        Me.pic.ContextMenuStrip = Me.ContextMenuStrip1
        Me.pic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic.Location = New System.Drawing.Point(0, 22)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(832, 448)
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.MAX, Me.StatusBarPanel2, Me.MIN, Me.StatusBarPanel3, Me.MED, Me.DIST, Me.Pico, Me.Amort, Me.ST, Me.IZQ, Me.DER, Me.Te, Me.VAL})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(832, 22)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Mx="
        Me.StatusBarPanel1.Width = 36
        '
        'MAX
        '
        Me.MAX.Name = "MAX"
        Me.MAX.Width = 80
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Mn="
        Me.StatusBarPanel2.Width = 37
        '
        'MIN
        '
        Me.MIN.Name = "MIN"
        Me.MIN.Width = 80
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "Md="
        Me.StatusBarPanel3.Width = 37
        '
        'MED
        '
        Me.MED.Name = "MED"
        Me.MED.Width = 80
        '
        'DIST
        '
        Me.DIST.Name = "DIST"
        Me.DIST.Text = "P2P="
        '
        'Pico
        '
        Me.Pico.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Pico.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Pico.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.Pico.Icon = CType(resources.GetObject("Pico.Icon"), System.Drawing.Icon)
        Me.Pico.Name = "Pico"
        Me.Pico.Text = "    Máximo    "
        Me.Pico.ToolTipText = "Encontrar máximo local (modo)"
        Me.Pico.Width = 103
        '
        'Amort
        '
        Me.Amort.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Amort.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Amort.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.Amort.Icon = CType(resources.GetObject("Amort.Icon"), System.Drawing.Icon)
        Me.Amort.Name = "Amort"
        Me.Amort.Text = "Amortiguamiento"
        Me.Amort.ToolTipText = "Encontrar el amortiguamiento"
        Me.Amort.Width = 137
        '
        'ST
        '
        Me.ST.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.ST.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.ST.Name = "ST"
        Me.ST.Width = 10
        '
        'IZQ
        '
        Me.IZQ.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.IZQ.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.IZQ.Icon = CType(resources.GetObject("IZQ.Icon"), System.Drawing.Icon)
        Me.IZQ.MinWidth = 5
        Me.IZQ.Name = "IZQ"
        Me.IZQ.ToolTipText = "Izquierda"
        Me.IZQ.Width = 40
        '
        'DER
        '
        Me.DER.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DER.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.DER.Icon = CType(resources.GetObject("DER.Icon"), System.Drawing.Icon)
        Me.DER.MinWidth = 5
        Me.DER.Name = "DER"
        Me.DER.ToolTipText = "Derecha"
        Me.DER.Width = 40
        '
        'Te
        '
        Me.Te.Name = "Te"
        Me.Te.ToolTipText = "Tiempo"
        Me.Te.Width = 50
        '
        'VAL
        '
        Me.VAL.Name = "VAL"
        Me.VAL.ToolTipText = "Valor"
        Me.VAL.Width = 60
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VistaPreviaToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator1, Me.GuardarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(142, 76)
        '
        'VistaPreviaToolStripMenuItem
        '
        Me.VistaPreviaToolStripMenuItem.Name = "VistaPreviaToolStripMenuItem"
        Me.VistaPreviaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VistaPreviaToolStripMenuItem.Text = "Vista Previa"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SFD
        '
        Me.SFD.Title = "Guardar como"
        '
        'Zm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(832, 470)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.StatusBar1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Zm"
        Me.ShowInTaskbar = False
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IZQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public rgZ(,) As Double
    Public t1, t2, imax As Single
    Dim tX As Long
    Public Shared di As Integer = 0
    Dim maxim As Double ' la magnitud del máximo
    Private WithEvents printdocument1 As New PrintDocument

    Private Sub Zm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If di = 1 Then
            Dim k, j As Integer
            For k = t1 To t2
                If rgZ(k, 1) > maxim Then
                    maxim = rgZ(k, 1)
                    imax = k
                    j += 1
                End If
            Next
            ST.Text = "Máximo encontrado en: f= " & rgZ(imax, 0).ToString & "   T: " & Format(1 / rgZ(imax, 0), "#.0000")
            Exit Sub
        End If
        MMM()
    End Sub

    Private Sub pic_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pic.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        DrawOnPictureBoxRANGO(e.Graphics, pic, rgZ, Color.YellowGreen, True, t1, t2, di)
        Dim fz As New Pen(Color.DarkGray, 0.005)
        If di = 1 Then
            e.Graphics.DrawLine(fz, t1, CSng(rgZ(imax, di) / Math.Sqrt(2)), t2, CSng(rgZ(imax, di) / Math.Sqrt(2)))
        End If

    End Sub

    Private Sub Zm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        pic.Refresh()
    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick
        If e.StatusBarPanel.ToolTipText = "Izquierda" Then
            '   e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
            'a la izquierda
            Try
                Te.Text = rgZ(tX - 1, 1)
                VAL.Text = rgZ(tX - 1, 0)
                ST.Text = "Cursor a la izquierda"
                tX -= 1
            Catch ex As Exception
                Err.Clear()
            End Try
            '  e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Raised
            Exit Sub
        ElseIf e.StatusBarPanel.ToolTipText = "Derecha" Then
            '    e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
            'a la derecha
            Try
                Te.Text = rgZ(tX + 1, 1)
                VAL.Text = rgZ(tX + 1, 0)
                ST.Text = "Cursor a la derecha"
                tX += 1
            Catch ex As Exception
                Err.Clear()
            End Try
            ' e.StatusBarPanel.BorderStyle = StatusBarPanelBorderStyle.Raised
            Exit Sub
        ElseIf e.StatusBarPanel.ToolTipText = "Encontrar el amortiguamiento" Then
            botton_amort()
        End If
        StatusBar1.Update()
    End Sub

    Sub botton_amort()
        If maxim <> 0 Then
            If Transf.max(0) <> -1 Then
                Dim aux() As Double
                aux = Transf.max.Clone
                ReDim Transf.max(Transf.max.Length)
                Array.Copy(aux, Transf.max, aux.Length)
                Transf.max(Transf.max.Length - 1) = imax

                aux = Transf.dmp.Clone
                ReDim Transf.dmp(Transf.dmp.Length)
                Array.Copy(aux, Transf.dmp, aux.Length)
                Transf.dmp(Transf.dmp.Length - 1) = Damping(rgZ, imax)
            Else
                Transf.max(0) = imax
                Transf.dmp(0) = Damping(rgZ, imax)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub pic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseMove
        Try
            pic.SuspendLayout()
            tX = CInt((e.X * (t2 - t1)) / (pic.Width - 1)) + t1
            Te.Text = rgZ(tX, 1)
            VAL.Text = rgZ(tX, 0)
            pic.ResumeLayout()
        Catch ex As Exception
            pic.ResumeLayout()
        End Try
    End Sub

    Sub MMM()
        Dim i, var, segund As Double
        'rgZ(i, 1) = 0
        Me.SuspendLayout()
        Dim Vmax, Vmin, Vmed, Vdist As Double
        Vmax = Decimal.MinValue
        Vmin = Decimal.MaxValue
        For i = t1 To t2 'For i = 0 To CInt(rgZ.Length / 2) - 1
            var = rgZ(i, 0)
            If var > Vmax Then
                Vmax = var
                Vdist = rgZ(i, 1)
            End If
            If var < Vmin Then
                Vmin = var
                segund = rgZ(i, 1)
            End If
            Vmed = Vmed + var
        Next
        Me.ResumeLayout()
        MED.Text = Format(Vmed / i, "#.0000000000")
        MAX.Text = Format(Vmax / 1, "#.0000000000")
        MAX.ToolTipText = Vdist.ToString & " Seg"
        MIN.Text = Format(Vmin / 1, "#.0000000000")
        MIN.ToolTipText = segund.ToString & " Seg"
        DIST.Text = "P2P=" & Format(Math.Abs(Math.Abs(segund) - Math.Abs(Vdist)), "##.00000 seg")
    End Sub

    Function Damping(ByVal r(,) As Double, ByVal imx As Double) As Double
        Dim j, modDP, Iiz, Idr As Double

        modDP = r(imx, 1) / Math.Sqrt(2)
        'a la izquierda (antes)
        j = imx
        Do
            j -= 1
            If r(j, 1) < modDP Then
                Iiz = j
                Exit Do
            End If
        Loop While j >= 1
        ' a la derecha (después)
        j = imx
        Do
            j += 1
            If r(j, 1) < modDP Then
                Idr = j
                Exit Do
            End If
        Loop While j < r.Length / 2 - 2
        ' cálculo
        Damping = (r(Iiz, 0) ^ 2 - r(Idr, 0) ^ 2) / (2 * r(imx, 0) ^ 2)
    End Function

    Private Sub Zm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = CChar(" ") Or e.KeyChar = CChar(vbNewLine) Then
            botton_amort()
        End If
    End Sub

#Region "Impresión"
    Private Sub MenuClick__Imprimir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim printdialog1 As New PrintDialog
        printdialog1.Document = printdocument1
        printdocument1.DefaultPageSettings.Landscape = True
        printdocument1.DocumentName = Me.Text.TrimEnd(".").TrimStart(" ")
        If printdialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
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
        Dim i, j As Integer
        Dim rg(,) As Double = cortar(rgZ)

        'ejes del acelerograma
        For i = 1 To 9 'El eje horizontal
            e.Graphics.DrawLine(rojo, 140 + CInt(840 * (i / 10)), 355, 140 + CInt(840 * (i / 10)), 350) 'Las rayitas de división rojas en el eje horizontal
            e.Graphics.DrawString(Format(rg(CInt((rg.Length / 2 - 1) * (i / 10)), 1), "F"), _
            fontchica, Brushes.Gray, 140 + CInt(840 * (i / 10)), 355) 'Los números del eje horizonal
        Next
        For i = 0 To 12 'El eje vertical 
            e.Graphics.DrawLine(rojo, 135, 100 + CInt(250 * (i / 12)), 140, 100 + CInt(250 * (i / 12))) 'Las rayitas
            e.Graphics.DrawString(Format(CSng(MAX.Text) - Math.Abs(CSng(MAX.Text) - CSng(MIN.Text)) * (i / 12), "0.###E+00"), _
            fontchica, Brushes.Gray, 85, 100 + CInt(250 * (i / 12))) 'Los números
        Next

        'información del archivo
        Dim largo As Int16
        If Me.Text.Length >= 90 Then
            largo = 90
        Else
            largo = Me.Text.Length
        End If
        e.Graphics.DrawString("[" & Format(rg(0, 1), "F") & ";" & Format(rg(rg.Length / 2 - 1, 1), "F") & "]..." _
        & Me.Text.Substring(Me.Text.Length - largo), fonttitulo, Brushes.Black, 100, 390)
        e.Graphics.DrawString("Max= " & MAX.Text & " (" & MAX.ToolTipText & ")    Min= " & MIN.Text & _
        " (" & MIN.ToolTipText & ")", font, Brushes.Black, 100, 420)
        e.Graphics.DrawString("Med= " & MED.Text & "        SPS: " & Form1.SPS & "          Diezmado: " & _
        Form1.diezmado, font, Brushes.Black, 100, 440)
        e.Graphics.DrawString("Duración= " & rg(rg.Length / 2 - 1, 1) - rg(0, 1) & " segundos", font, Brushes.Black, 100, 460)

        'ejes del espectro
        e.Graphics.DrawString("Espectro de amplitudes", font, Brushes.Black, 400, 480)
        For i = 1 To (Form1.SPS / 20) 'El eje horizontal. Dependiendo del SPS
            e.Graphics.DrawLine(rojo, 140 + CInt(840 * (i / (Form1.SPS / 20))), 500, 140 + CInt(840 * (i / (Form1.SPS / 20))), 505) 'Las rayitas de división rojas en el eje horizontal
            e.Graphics.DrawLine(rojo, 140 + CInt(840 * (i / (Form1.SPS / 20))), 750, 140 + CInt(840 * (i / (Form1.SPS / 20))), 755) 'Las rayitas de división rojas en el eje horizontal
            e.Graphics.DrawString(CStr(i * 10) & " Hz", fontchica, Brushes.Gray, 120 + CInt(840 * (i / (Form1.SPS / 20))), 755)
        Next

        'ejecutar la FFT para obtener la MaG (el vector del módulo)
        Dim rgf(,) As Double = TransformadaRápidaDeFourier(rg)
        Dim MaG() As Double = magnitud(rgf)
        'magnitud
        ReDim MaG(rgF.Length / 8 - 1)
        For i = 0 To MaG.Length - 1
            On Error Resume Next
            'Se obtiene la magnitud del número complejo y se multiplica por Dt para escalarlo
            MaG(i) = (Math.Sqrt(rgF(j, 0) ^ 2 + rgF(j, 1) ^ 2) + Math.Sqrt(rgF(j + 1, 0) ^ 2 + rgF(j + 1, 1) ^ 2) + Math.Sqrt(rgF(j + 2, 0) ^ 2 + rgF(j + 2, 1) ^ 2) + Math.Sqrt(rgF(j + 3, 0) ^ 2 + rgF(j + 3, 1) ^ 2)) / (8 * Form1.SPS)
            j += 4
        Next
        'encontrar la magnitud máxima
        Dim modulomax As Double = 0
        For i = 0 To MaG.Length - 1
            If MaG(i) > modulomax Then
                modulomax = MaG(i)
            End If
        Next

        For i = 0 To 12  'El eje vertical 
            e.Graphics.DrawLine(rojo, 135, 500 + CInt(250 * (i / 12)), 140, 500 + CInt(250 * (i / 12))) 'Las rayitas
            e.Graphics.DrawString(Format(modulomax * (i / 12), "0.###E+00"), _
            fontchica, Brushes.Gray, 85, 750 - CInt(250 * (i / 12))) 'Los números
        Next

        'Lo anterior se ha hecho con las coordenadas originales del papel, ahora se transforma el mapeo para facilitar el gráfico.
        MapGraphicsWindow(e.Graphics, CSng(rg.Length / 2) - 1, CSng(MIN.Text) * 100000, 0, CSng(MAX.Text) * 100000, _
    980, _
    350, _
    140, _
    100)

        DrawOnPictureBox(e.Graphics, pic, rg, Color.Black, False) 'cuando se dibuja el gráfico 
        e.Graphics.DrawRectangle(grisborde, 0, CSng(MIN.Text) * 100000, CInt(rg.Length / 2) - 1, _
        100000 * (Math.Abs(CSng(MAX.Text) - CSng(MIN.Text)))) 'El rectángulo del borde del gráfico
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

        e.Graphics.ResetTransform()
        MapGraphicsWindow(e.Graphics, CSng(MaG.Length / 2) - 1, 0, 0, modulomax, _
            980, _
            750, _
            140, _
            500)

        e.Graphics.DrawRectangle(grisborde, 0, 0, CInt(MaG.Length / 2) - 1, _
       CSng(modulomax)) 'El rectángulo del borde del gráfico
        'para trazar el espectro
        'solo parte positiva
        DrawFourier(e.Graphics, pic, MaG, Color.Black, False, True)
    End Sub

    Private Sub VistaPrevia_de_Impresión(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaPreviaToolStripMenuItem.Click
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

    Function cortar(ByVal r(,) As Double) As Double(,)
        ReDim r(t2 - t1, 1)
        Dim i, j As Integer
        j = 0
        For i = t1 To t2
            r(j, 0) = rgZ(i, 0)
            r(j, 1) = rgZ(i, 1)
            j += 1
        Next
        cortar = r.Clone
    End Function

    Function TransformadaRápidaDeFourier(ByVal rg(,) As Double) As Double(,)
        Dim rgf(0, 0) As Double
        Dim Tam_Orig As Single
        Tam_Orig = rg.Length / 2 - 1

        Dim i, k As Integer 'contadores
        Dim N As Integer = rg.Length / 2    'El número de elementos, en realidad se tendrán 2n elementos(n reales y n imag)
        Dim rgaux(,) As Double
        rgaux = rg.Clone
        'antes de aplicar la transformada, se realiza un tapering
        'vamos a multiplicar  ambos extremos (5% del registro al principio y 5% al final) por un taper de Hannig 
        '           1                2 Pi() t
        '     f(t)= - (1-Cos[--------])            con T= N* Delta t    con N:num de puntos N=2^p, p entero
        '           2                    T

        'el vector viene 'aceleración (#,0) e tiempo (#,1)
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
        magnitud = mag.Clone
    End Function

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim rg(,) As Double = cortar(rgZ)
        If Not Me.Text.EndsWith("p") Then
            SFD.FileName = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1) & "p"
        Else
            SFD.FileName = Me.Text.Substring(Me.Text.LastIndexOf(":") - 1)
        End If
        If SFD.ShowDialog = Windows.Forms.DialogResult.Cancel Then
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
    End Sub
End Class
