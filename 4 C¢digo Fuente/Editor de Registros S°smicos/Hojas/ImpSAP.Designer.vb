<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpSAP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tX = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(0, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Importar archivo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Abrir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tX
        '
        Me.tX.AllowDrop = True
        Me.tX.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tX.Location = New System.Drawing.Point(0, 134)
        Me.tX.Multiline = True
        Me.tX.Name = "tX"
        Me.tX.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tX.Size = New System.Drawing.Size(498, 264)
        Me.tX.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(442, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Importar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SFD
        '
        Me.SFD.DefaultExt = "001p"
        '
        'ImpSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Editor_de_Registros_Sísmicos.My.Resources.Resources.banner
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(498, 398)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ImpSAP"
        Me.Text = "Importar Time History de SAP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tX As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
End Class
