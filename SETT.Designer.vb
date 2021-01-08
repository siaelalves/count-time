<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SETT
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
        Me.lblTt = New System.Windows.Forms.Label()
        Me.lblEv = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.txtTt = New System.Windows.Forms.TextBox()
        Me.txtEv = New System.Windows.Forms.TextBox()
        Me.cmdSv = New System.Windows.Forms.Button()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.txtDt = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblTt
        '
        Me.lblTt.AutoSize = True
        Me.lblTt.Location = New System.Drawing.Point(13, 15)
        Me.lblTt.Name = "lblTt"
        Me.lblTt.Size = New System.Drawing.Size(38, 13)
        Me.lblTt.TabIndex = 1
        Me.lblTt.Text = "Título:"
        '
        'lblEv
        '
        Me.lblEv.AutoSize = True
        Me.lblEv.Location = New System.Drawing.Point(13, 41)
        Me.lblEv.Name = "lblEv"
        Me.lblEv.Size = New System.Drawing.Size(44, 13)
        Me.lblEv.TabIndex = 2
        Me.lblEv.Text = "Evento:"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Location = New System.Drawing.Point(13, 66)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(33, 13)
        Me.lblDt.TabIndex = 3
        Me.lblDt.Text = "Data:"
        '
        'txtTt
        '
        Me.txtTt.Location = New System.Drawing.Point(57, 12)
        Me.txtTt.Name = "txtTt"
        Me.txtTt.Size = New System.Drawing.Size(156, 20)
        Me.txtTt.TabIndex = 4
        '
        'txtEv
        '
        Me.txtEv.Location = New System.Drawing.Point(57, 38)
        Me.txtEv.Name = "txtEv"
        Me.txtEv.Size = New System.Drawing.Size(156, 20)
        Me.txtEv.TabIndex = 6
        '
        'cmdSv
        '
        Me.cmdSv.Location = New System.Drawing.Point(57, 89)
        Me.cmdSv.Name = "cmdSv"
        Me.cmdSv.Size = New System.Drawing.Size(75, 23)
        Me.cmdSv.TabIndex = 7
        Me.cmdSv.Text = "Sal&var"
        Me.cmdSv.UseVisualStyleBackColor = True
        '
        'cmdCnc
        '
        Me.cmdCnc.Location = New System.Drawing.Point(138, 89)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(75, 23)
        Me.cmdCnc.TabIndex = 8
        Me.cmdCnc.Text = "&Cancelar"
        Me.cmdCnc.UseVisualStyleBackColor = True
        '
        'txtDt
        '
        Me.txtDt.Location = New System.Drawing.Point(57, 64)
        Me.txtDt.Name = "txtDt"
        Me.txtDt.Size = New System.Drawing.Size(156, 20)
        Me.txtDt.TabIndex = 9
        '
        'SETT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 128)
        Me.Controls.Add(Me.txtDt)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.cmdSv)
        Me.Controls.Add(Me.txtEv)
        Me.Controls.Add(Me.txtTt)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.lblEv)
        Me.Controls.Add(Me.lblTt)
        Me.Name = "SETT"
        Me.Text = "Configurações"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTt As System.Windows.Forms.Label
    Friend WithEvents lblEv As System.Windows.Forms.Label
    Friend WithEvents lblDt As System.Windows.Forms.Label
    Friend WithEvents txtTt As System.Windows.Forms.TextBox
    Friend WithEvents txtEv As System.Windows.Forms.TextBox
    Friend WithEvents cmdSv As System.Windows.Forms.Button
    Friend WithEvents cmdCnc As System.Windows.Forms.Button
    Friend WithEvents txtDt As System.Windows.Forms.DateTimePicker
End Class
