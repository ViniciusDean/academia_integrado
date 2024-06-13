Public Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        txt_senha.Text = UCase(txt_senha.Text)

        sql = "select * from tb_login where (usuario='" & txt_usuario.Text & "' or email='" & txt_usuario.Text & "')"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            MsgBox("Usuario incorreto", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
        Else
            aux_rec = rs.Fields(3).Value
            If aux_rec = txt_senha.Text Then
                MsgBox("Login efetuado com sucesso!! ")
            Else
                MsgBox("Senha incorreta")
            End If
        End If
    End Sub
End Class