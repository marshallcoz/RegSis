Public Class FiltrBound
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "0"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(24, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "PasaBaja"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(24, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PasaBanda"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(24, 76)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.Text = "PasaAlta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "filtrar"
        '
        'FiltrBound
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(263, 114)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FiltrBound"
        Me.Opacity = 0.7
        Me.Text = "Filtrar señal"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PasaBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Text = "0"
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox2.Focus()
    End Sub

    Private Sub PasaBanda_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Text = "0"
        TextBox2.Enabled = False
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        ElseIf TextBox2.Text = "" Then
            TextBox2.Text = "0"
        End If
        Me.Visible = False
    End Sub


    Public Function Solonum(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            Solonum = False
        Else
            Solonum = True
        End If
        'If (Key = 45) Or (Key = 46) Then
        '    Solonum = False
        'End If
    End Function

    Private Sub TB_KyPrsS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        e.Handled = Solonum(Asc(e.KeyChar))
    End Sub
End Class
