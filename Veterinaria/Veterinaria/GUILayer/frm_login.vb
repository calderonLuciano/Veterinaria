Public Class frm_login

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_iniciar_sesion.Click
        Dim oUserService As New UserService

        If String.IsNullOrEmpty(txt_contraseña.Text) Or String.IsNullOrEmpty(txt_nombre_usuario.Text) Then
            MsgBox("Usuario y Password son requeridos", vbCritical, "Aviso")
            Exit Sub
        End If

        If oUserService.validarUsuario(txt_nombre_usuario.Text, txt_contraseña.Text) Then
            frm_principal.ShowDialog()
            Me.Close()


        Else
            MsgBox("El Usuario o Clave son incorrectos", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btn_salir_logueo_Click(sender As Object, e As EventArgs) Handles btn_salir_logueo.Click
        If MessageBox.Show("¿Esta seguro que desea salir?",
                            "Aviso",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            frm_principal.Close()
            Me.Close()
        End If

    End Sub

   
End Class
