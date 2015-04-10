Imports Registros_1a_Prop.ClassDibujo
Imports System.IO
Public Class FrmView
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
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Max As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Min As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Med As System.Windows.Forms.StatusBarPanel
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmView))
        Me.PB = New System.Windows.Forms.PictureBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.Max = New System.Windows.Forms.StatusBarPanel
        Me.Min = New System.Windows.Forms.StatusBarPanel
        Me.Med = New System.Windows.Forms.StatusBarPanel
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        CType(Me.Max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Med, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB.BackColor = System.Drawing.Color.Black
        Me.PB.Location = New System.Drawing.Point(0, 0)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(798, 158)
        Me.PB.TabIndex = 1
        Me.PB.TabStop = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 159)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.Max, Me.Min, Me.Med})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(798, 24)
        Me.StatusBar1.TabIndex = 2
        '
        'Max
        '
        Me.Max.MinWidth = 100
        Me.Max.Width = 150
        '
        'Min
        '
        Me.Min.MinWidth = 100
        Me.Min.Width = 150
        '
        'Med
        '
        Me.Med.Width = 150
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(454, 160)
        Me.TrackBar1.Maximum = 5
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(159, 19)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'FrmView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(798, 183)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.PB)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmView"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "FrmView"
        CType(Me.Max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Med, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim rg() As Double
    Private Sub FrmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LeerRegistro()
        Me.Show()
        Dim strdr As New StreamReader(Me.Text)
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
            ReDim rg(N - 1)
            reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2) 'borra el primer renglón
            'ahora solo quedan los valores en cada renglón, así que se recuperan en el vector
            For i = 0 To N - 1
                rg(i) = reg.Substring(0, reg.IndexOf(vbNewLine))
                reg = reg.Remove(0, reg.IndexOf(vbNewLine) + 2)
                var = rg(i)
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
            ReDim rg((reg.Length) * 1 / (12 * Main.diezmado) - 1)
            For j = 0 To ((reg.Length - 1)) Step (12 * Main.diezmado / 1)
                rg(i) = reg.Substring(j, 12)
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

        Med.Text = "Med= " & Format(VmeD / i, "#.0000000000")
        Max.Text = "Max= " & Format(VmaX / 1, "#.0000000000")
        Min.Text = "Min=" & Format(VmiN / 1, "#.0000000000")
    End Sub

    Private Sub PB_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PB.Paint
        'cuando se dibuja el gráfico en el picture box cada que éste necesita ser redibujado o dibujado por primera vez
        DrawOnPictureBox(e.Graphics, PB, rg, TrackBar1.Value)
        Me.Focus()
    End Sub

    
    Private Sub FrmView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, TrackBar1.KeyDown
        If (e.KeyValue) = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub TrackBar1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseUp
        PB.Refresh()
        Me.Focus()
    End Sub
End Class
  