<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeRazasMasAtendidas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_fechaDesde = New System.Windows.Forms.Label()
        Me.lbl_fechaHasta = New System.Windows.Forms.Label()
        Me.mkb_desde = New System.Windows.Forms.MaskedTextBox()
        Me.mkb_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'lbl_fechaDesde
        '
        Me.lbl_fechaDesde.AutoSize = True
        Me.lbl_fechaDesde.Location = New System.Drawing.Point(13, 13)
        Me.lbl_fechaDesde.Name = "lbl_fechaDesde"
        Me.lbl_fechaDesde.Size = New System.Drawing.Size(74, 13)
        Me.lbl_fechaDesde.TabIndex = 0
        Me.lbl_fechaDesde.Text = "Fecha Desde:"
        '
        'lbl_fechaHasta
        '
        Me.lbl_fechaHasta.AutoSize = True
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(208, 13)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(71, 13)
        Me.lbl_fechaHasta.TabIndex = 1
        Me.lbl_fechaHasta.Text = "Fecha Hasta:"
        '
        'mkb_desde
        '
        Me.mkb_desde.Location = New System.Drawing.Point(93, 6)
        Me.mkb_desde.Mask = "00/00/0000"
        Me.mkb_desde.Name = "mkb_desde"
        Me.mkb_desde.Size = New System.Drawing.Size(100, 20)
        Me.mkb_desde.TabIndex = 2
        Me.mkb_desde.ValidatingType = GetType(Date)
        '
        'mkb_hasta
        '
        Me.mkb_hasta.Location = New System.Drawing.Point(285, 6)
        Me.mkb_hasta.Mask = "00/00/0000"
        Me.mkb_hasta.Name = "mkb_hasta"
        Me.mkb_hasta.Size = New System.Drawing.Size(100, 20)
        Me.mkb_hasta.TabIndex = 3
        Me.mkb_hasta.ValidatingType = GetType(Date)
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(417, 6)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 4
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 35)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(537, 318)
        Me.ReportViewer1.TabIndex = 5
        '
        'InformeRazasMasAtendidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 365)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.mkb_hasta)
        Me.Controls.Add(Me.mkb_desde)
        Me.Controls.Add(Me.lbl_fechaHasta)
        Me.Controls.Add(Me.lbl_fechaDesde)
        Me.Name = "InformeRazasMasAtendidas"
        Me.Text = "InformeRazasMasAtendidas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_fechaDesde As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaHasta As System.Windows.Forms.Label
    Friend WithEvents mkb_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkb_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
