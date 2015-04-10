Public Class prop
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Aceptar y Guardar"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Porcentaje de Taper (estrechamiento) para aplicar al principio y al final de la s" & _
        "eñal antes de aplicar la FFT: [en porcentaje]"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(297, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Factor de suavizado Fs"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(297, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(297, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = ""
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Número de polos para utilizar en el filtrado="
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Cancelar"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(174, 139)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = ""
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(10, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(387, 36)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Rango predeterminado para el filtrado="
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(297, 139)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = ""
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 34)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Acerca &de ARSis"
        '
        'prop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(412, 343)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "prop"
        Me.Text = "Propiedades"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.tap = CSng(TextBox1.Text)
        Form1.Fs = CSng(TextBox2.Text)
        Form1.Npol = CSng(TextBox3.Text)
        Form1.Infbound = CSng(TextBox4.Text)
        Form1.Supbound = CSng(TextBox5.Text)
        Me.Close()
    End Sub

    Private Sub prop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.tap.ToString
        TextBox2.Text = Form1.Fs.ToString
        TextBox3.Text = Form1.Npol.ToString
        TextBox4.Text = Form1.Infbound.ToString
        TextBox5.Text = Form1.Supbound.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim v As New about
        v.ShowDialog()
    End Sub
End Class
