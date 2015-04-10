Public Class bugger
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
    Friend WithEvents TB As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TB = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TB
        '
        Me.TB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB.Location = New System.Drawing.Point(0, 0)
        Me.TB.Multiline = True
        Me.TB.Name = "TB"
        Me.TB.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TB.Size = New System.Drawing.Size(313, 317)
        Me.TB.TabIndex = 0
        Me.TB.Text = ""
        '
        'bugger
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(313, 317)
        Me.Controls.Add(Me.TB)
        Me.Name = "bugger"
        Me.Text = "bugger"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Esta ventana exciste para propósitos de desarrollo del software
End Class
