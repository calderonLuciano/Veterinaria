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
        Me.SuspendLayout()
        '
        'btn_salir_logueo
        '
        Me.btn_salir_logueo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_salir_logueo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir_logueo.Image = Global.Veterinaria.My.Resources.Resources.down
        Me.btn_salir_logueo.Location = New System.Drawing.Point(102, 176)
        Me.btn_salir_logueo.Name = "btn_salir_logueo"
        Me.btn_salir_logueo.Size = New System.Drawing.Size(52, 23)
        Me.btn_salir_logueo.TabIndex = 4
        Me.btn_salir_logueo.UseVisualStyleBackColor = False
        '
        'btn_iniciar_sesion
        '
        Me.btn_iniciar_sesion.BackColor = System.Drawing.Color.Blue
        Me.btn_iniciar_sesion.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_iniciar_sesion.FlatAppearance.BorderSize = 0
        Me.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_iniciar_sesion.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btn_iniciar_sesion.Image = Global.Veterinaria.My.Resources.Resources.up
        Me.btn_iniciar_sesion.Location = New System.Drawing.Point(34, 176)
        Me.btn_iniciar_sesion.Name = "btn_iniciar_sesion"
        Me.btn_iniciar_sesion.Size = New System.Drawing.Size(52, 23)
        Me.btn_iniciar_sesion.TabIndex = 3
        Me.btn_iniciar_sesion.UseVisualStyleBackColor = False
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre_usuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_usuario.ForeColor = System.Drawing.Color.Black
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(126, 69)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(191, 20)
        Me.txt_nombre_usuario.TabIndex = 1
        Me.txt_nombre_usuario.Text = "Usuario"
        Me.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_contraseña
        '
        Me.txt_contraseña.BackColor = System.Drawing.SystemColors.Control
        Me.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_contraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contraseña.Location = New System.Drawing.Point(126, 115)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(191, 20)
        Me.txt_contraseña.TabIndex = 2
        Me.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_contraseña.UseSystemPasswordChar = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Veterinaria.My.Resources.Resources.login
        Me.ClientSize = New System.Drawing.Size(434, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.btn_iniciar_sesion)
        Me.Controls.Add(Me.btn_salir_logueo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. Login .:."
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salir_logueo As System.Windows.Forms.Button
    Friend WithEvents btn_iniciar_sesion As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox

End Class
