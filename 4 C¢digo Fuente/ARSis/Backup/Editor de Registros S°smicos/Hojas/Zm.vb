Imports Editor_de_Registros_Sísmicos.ClassDibujo
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
    Friend WithEvents Pico As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Zm))
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
        Me.SuspendLayout()
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.Black
        Me.pic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic.Location = New System.Drawing.Point(0, 24)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(832, 446)
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
        Me.StatusBar1.Size = New System.Drawing.Size(832, 24)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Text = "Mx="
        Me.StatusBarPanel1.Width = 37
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
        'Pico
        '
        Me.Pico.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Pico.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Pico.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.Pico.Icon = CType(resources.GetObject("Pico.Icon"), System.Drawing.Icon)
        Me.Pico.Text = "    Máximo    "
        Me.Pico.ToolTipText = "Encontrar máximo local (modo)"
        Me.Pico.Width = 104
        '
        'Amort
        '
        Me.Amort.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Amort.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Amort.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.Amort.Icon = CType(resources.GetObject("Amort.Icon"), System.Drawing.Icon)
        Me.Amort.Text = "Amortiguamiento"
        Me.Amort.ToolTipText = "Encontrar el amortiguamiento"
        Me.Amort.Width = 137
        '
        'ST
        '
        Me.ST.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.ST.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.ST.Width = 10
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
        Me.VAL.Width = 60
        '
        'Zm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(832, 470)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.StatusBar1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Zm"
        Me.ShowInTaskbar = False
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
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public rgZ(,) As Double
    Public t1, t2, imax As Single
    Dim tX As Long
    Public Shared di As Integer = 0
    Dim maxim As Double ' la magnitud del máximo

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
        e.Graphics.DrawLine(fz, t1, CSng(rgZ(imax, di) / Math.Sqrt(2)), t2, CSng(rgZ(imax, di) / Math.Sqrt(2)))
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

    Function botton_amort()
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
    End Function

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

    Function MMM()
        Dim i, var, segund As Double
        'rgZ(i, 1) = 0
        Me.SuspendLayout()
        Dim Vmax, Vmin, Vmed, Vdist As Double
        Vmax = Decimal.MinValue
        Vmin = Decimal.MaxValue
        For i = 0 To CInt(rgZ.Length / 2) - 1
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
    End Function

    Function Damping(ByVal r(,) As Double, ByVal imx As Double) As Double
        Dim j, modDP, Iiz, Idr As Double
        Dim i As Single
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
End Class
