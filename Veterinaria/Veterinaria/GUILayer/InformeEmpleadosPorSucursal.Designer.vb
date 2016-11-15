<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeEmpleadosPorSucursal
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
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.cbo_Rsucursal = New System.Windows.Forms.ComboBox()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New Veterinaria.DataSet1()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesTableAdapter = New Veterinaria.DataSet1TableAdapters.SucursalesTableAdapter()
        Me.InformeEmleadosPorSucursalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformeEmleadosPorSucursalTableAdapter = New Veterinaria.DataSet1TableAdapters.InformeEmleadosPorSucursalTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformeEmleadosPorSucursalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(369, 12)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'cbo_Rsucursal
        '
        Me.cbo_Rsucursal.DataSource = Me.SucursalesBindingSource
        Me.cbo_Rsucursal.DisplayMember = "nombre"
        Me.cbo_Rsucursal.FormattingEnabled = True
        Me.cbo_Rsucursal.Location = New System.Drawing.Point(231, 13)
        Me.cbo_Rsucursal.Name = "cbo_Rsucursal"
        Me.cbo_Rsucursal.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Rsucursal.TabIndex = 1
        Me.cbo_Rsucursal.ValueMember = "id_sucursal"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(118, 17)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(107, 13)
        Me.lbl_sucursal.TabIndex = 2
        Me.lbl_sucursal.Text = "Seleccione Sucursal:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.InformeEmleadosPorSucursalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(524, 318)
        Me.ReportViewer1.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.DataSet1
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'InformeEmleadosPorSucursalBindingSource
        '
        Me.InformeEmleadosPorSucursalBindingSource.DataMember = "InformeEmleadosPorSucursal"
        Me.InformeEmleadosPorSucursalBindingSource.DataSource = Me.DataSet1
        '
        'InformeEmleadosPorSucursalTableAdapter
        '
        Me.InformeEmleadosPorSucursalTableAdapter.ClearBeforeFill = True
        '
        'InformeEmpleadosPorSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 371)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Controls.Add(Me.cbo_Rsucursal)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "InformeEmpleadosPorSucursal"
        Me.Text = ".:. Informe Empleados Por Sucursal .:."
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformeEmleadosPorSucursalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents cbo_Rsucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1 As Veterinaria.DataSet1
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As Veterinaria.DataSet1TableAdapters.SucursalesTableAdapter
    Friend WithEvents InformeEmleadosPorSucursalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InformeEmleadosPorSucursalTableAdapter As Veterinaria.DataSet1TableAdapters.InformeEmleadosPorSucursalTableAdapter
End Class
