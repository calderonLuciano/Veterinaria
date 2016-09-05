<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.btn_salir_logueo = New System.Windows.Forms.Button()
        Me.btn_iniciar_sesion = New System.Windows.Forms.Button()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_salir_logueo
        '
        Me.btn_salir_logueo.Location = New System.Drawing.Point(140, 81)
        Me.btn_salir_logueo.Name = "btn_salir_logueo"
        Me.btn_salir_logueo.Size = New System.Drawing.Size(103, 23)
        Me.btn_salir_logueo.TabIndex = 0
        Me.btn_salir_logueo.Text = "Salir"
        Me.btn_salir_logueo.UseVisualStyleBackColor = True
        '
        'btn_iniciar_sesion
        '
        Me.btn_iniciar_sesion.Location = New System.Drawing.Point(18, 81)
        Me.btn_iniciar_sesion.Name = "btn_iniciar_sesion"
        Me.btn_iniciar_sesion.Size = New System.Drawing.Size(103, 23)
        Me.btn_iniciar_sesion.TabIndex = 1
        Me.btn_iniciar_sesion.Text = "Iniciar Sesiòn"
        Me.btn_iniciar_sesion.UseVisualStyleBackColor = True
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(85, 10)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(158, 20)
        Me.txt_nombre_usuario.TabIndex = 2
        Me.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(85, 36)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(158, 20)
        Me.txt_contraseña.TabIndex = 3
        Me.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(33, 17)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(15, 43)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(64, 13)
        Me.lbl_contraseña.TabIndex = 5
        Me.lbl_contraseña.Text = "Contraseña:"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 116)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.btn_iniciar_sesion)
        Me.Controls.Add(Me.btn_salir_logueo)
        Me.Name = "frm_login"
        Me.Text = ".:. Login .:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salir_logueo As System.Windows.Forms.Button
    Friend WithEvents btn_iniciar_sesion As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_contraseña As System.Windows.Forms.Label

End Class
