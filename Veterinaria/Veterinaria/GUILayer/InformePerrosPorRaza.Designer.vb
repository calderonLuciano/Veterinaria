<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformePerrosPorRaza
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.InformePerrosPorRazaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Veterinaria.DataSet1()
        Me.btn_rAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_PerrosRaza = New System.Windows.Forms.ComboBox()
        Me.RazasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformePerrosPorRazaTableAdapter = New Veterinaria.DataSet1TableAdapters.InformePerrosPorRazaTableAdapter()
        Me.RazasTableAdapter = New Veterinaria.DataSet1TableAdapters.RazasTableAdapter()
        CType(Me.InformePerrosPorRazaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RazasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InformePerrosPorRazaBindingSource
        '
        Me.InformePerrosPorRazaBindingSource.DataMember = "InformePerrosPorRaza"
        Me.InformePerrosPorRazaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_rAceptar
        '
        Me.btn_rAceptar.Location = New System.Drawing.Point(304, 23)
        Me.btn_rAceptar.Name = "btn_rAceptar"
        Me.btn_rAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_rAceptar.TabIndex = 0
        Me.btn_rAceptar.Text = "Aceptar"
        Me.btn_rAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Raza:"
        '
        'cbo_PerrosRaza
        '
        Me.cbo_PerrosRaza.DataSource = Me.RazasBindingSource
        Me.cbo_PerrosRaza.DisplayMember = "denominacion"
        Me.cbo_PerrosRaza.FormattingEnabled = True
        Me.cbo_PerrosRaza.Location = New System.Drawing.Point(131, 23)
        Me.cbo_PerrosRaza.Name = "cbo_PerrosRaza"
        Me.cbo_PerrosRaza.Size = New System.Drawing.Size(121, 21)
        Me.cbo_PerrosRaza.TabIndex = 2
        Me.cbo_PerrosRaza.ValueMember = "Razas.id_raza"
        '
        'RazasBindingSource
        '
        Me.RazasBindingSource.DataMember = "Razas"
        Me.RazasBindingSource.DataSource = Me.DataSet1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Enabled = False
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.InformePerrosPorRazaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(38, 68)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(564, 246)
        Me.ReportViewer1.TabIndex = 3
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'InformePerrosPorRazaTableAdapter
        '
        Me.InformePerrosPorRazaTableAdapter.ClearBeforeFill = True
        '
        'RazasTableAdapter
        '
        Me.RazasTableAdapter.ClearBeforeFill = True
        '
        'InformePerrosPorRaza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 340)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cbo_PerrosRaza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_rAceptar)
        Me.Name = "InformePerrosPorRaza"
        Me.Text = "InformePerrosPorRaza"
        CType(Me.InformePerrosPorRazaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RazasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_rAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_PerrosRaza As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1 As Veterinaria.DataSet1
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InformePerrosPorRazaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InformePerrosPorRazaTableAdapter As Veterinaria.DataSet1TableAdapters.InformePerrosPorRazaTableAdapter
    Friend WithEvents RazasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RazasTableAdapter As Veterinaria.DataSet1TableAdapters.RazasTableAdapter
End Class
