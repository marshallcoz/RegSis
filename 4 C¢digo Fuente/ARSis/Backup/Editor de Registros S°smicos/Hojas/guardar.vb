Public Class guardar
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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents La As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(guardar))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.La = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.Image = CType(resources.GetObject("RadioButton1.Image"), System.Drawing.Image)
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton1.Location = New System.Drawing.Point(1, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(151, 64)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Predeterminado"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RadioButton2
        '
        Me.RadioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.Image = CType(resources.GetObject("RadioButton2.Image"), System.Drawing.Image)
        Me.RadioButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton2.Location = New System.Drawing.Point(302, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(151, 64)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Individual"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'La
        '
        Me.La.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.La.Location = New System.Drawing.Point(0, 56)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(456, 45)
        Me.La.TabIndex = 2
        '
        'guardar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(456, 101)
        Me.Controls.Add(Me.La)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "guardar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modo de guardar los elementos en la lista"
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub RadioButton1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.MouseEnter
        La.Text = "Predeterminado: Se utilizan los mismos nombres pero se agrega 'p' al final de la extensión para todos. Ejemplo: AN001.A01p"
    End Sub

    Private Sub MouseLeave_de_los_radioB(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.MouseLeave, RadioButton2.MouseLeave
        La.Text = ""
    End Sub

    Private Sub RadioButton2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.MouseEnter
        La.Text = "Individual: Se especifican nombres y rutas para cada archivo"
    End Sub

    Private Sub guardar_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Me.Visible = False
    End Sub
End Class
