<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Dias = New System.Windows.Forms.Label()
        Me.Tempo = New System.Windows.Forms.Timer(Me.components)
        Me.lblEv = New System.Windows.Forms.Label()
        Me.Horas = New System.Windows.Forms.Label()
        Me.lblTt = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cntIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cntSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cntIcon.SuspendLayout()
        Me.cntSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter)
        Me.Dias.Location = New System.Drawing.Point(186, 260)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(75, 35)
        Me.Dias.TabIndex = 0
        Me.Dias.Text = "Dias"
        '
        'Tempo
        '
        Me.Tempo.Enabled = True
        Me.Tempo.Interval = 1000
        '
        'lblEv
        '
        Me.lblEv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.lblEv.Location = New System.Drawing.Point(12, 142)
        Me.lblEv.Name = "lblEv"
        Me.lblEv.Size = New System.Drawing.Size(457, 118)
        Me.lblEv.TabIndex = 1
        Me.lblEv.Text = "Tempo até o congresso:"
        Me.lblEv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter)
        Me.Horas.Location = New System.Drawing.Point(178, 301)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(94, 35)
        Me.Horas.TabIndex = 4
        Me.Horas.Text = "Horas"
        '
        'lblTt
        '
        Me.lblTt.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.lblTt.Location = New System.Drawing.Point(20, 9)
        Me.lblTt.Name = "lblTt"
        Me.lblTt.Size = New System.Drawing.Size(454, 133)
        Me.lblTt.TabIndex = 7
        Me.lblTt.Text = "'A Palavra de Deus é a Verdade!'"
        Me.lblTt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipText = "Tempo até a Assembleia"
        Me.NotifyIcon.BalloonTipTitle = "Assembleia de Circuito"
        Me.NotifyIcon.ContextMenuStrip = Me.cntIcon
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Visible = True
        '
        'cntIcon
        '
        Me.cntIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.cntIcon.Name = "ContextMenuStrip1"
        Me.cntIcon.Size = New System.Drawing.Size(110, 48)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.FecharToolStripMenuItem.Text = "&Fechar"
        '
        'cntSettings
        '
        Me.cntSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarToolStripMenuItem})
        Me.cntSettings.Name = "cntSettings"
        Me.cntSettings.Size = New System.Drawing.Size(153, 48)
        '
        'ConfigurarToolStripMenuItem
        '
        Me.ConfigurarToolStripMenuItem.Name = "ConfigurarToolStripMenuItem"
        Me.ConfigurarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConfigurarToolStripMenuItem.Text = "&Configurar"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(486, 351)
        Me.ContextMenuStrip = Me.cntSettings
        Me.Controls.Add(Me.lblEv)
        Me.Controls.Add(Me.lblTt)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Horas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "Tempo até o Congresso"
        Me.cntIcon.ResumeLayout(False)
        Me.cntSettings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dias As System.Windows.Forms.Label
    Friend WithEvents Tempo As System.Windows.Forms.Timer
    Friend WithEvents lblEv As System.Windows.Forms.Label
    Friend WithEvents Horas As System.Windows.Forms.Label
    Friend WithEvents lblTt As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents cntIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cntSettings As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConfigurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
