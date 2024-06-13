Public Class Menu_func

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        If tipo_user = "FUNCIONARIO" Then
            MsgBox("Voce não pode cadastrar treinos! ", MsgBoxStyle.Exclamation + vbOKOnly, "AVISO")
        ElseIf tipo_user = "PERSONAL TRAINER" Then
            Cadastro.Show()
        End If

    End Sub

    Private Sub btn_cad_produtos_Click(sender As Object, e As EventArgs) Handles btn_cad_produtos.Click
        If tipo_user = "PERSONAL TRAINER" Then
            MsgBox("Voce não pode cadastrar vendas! ", MsgBoxStyle.Exclamation + vbOKOnly, "AVISO")
        ElseIf tipo_user = "FUNCIONARIO" Then
            vendas.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_cad_alunos_Click(sender As Object, e As EventArgs) Handles btn_cad_alunos.Click
        If tipo_user = "PERSONAL TRAINER" Then
            MsgBox("Voce não pode cadastrar alunos! ", MsgBoxStyle.Exclamation + vbOKOnly, "AVISO")
        ElseIf tipo_user = "FUNCIONARIO" Then
            Cadastro.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub

    Private Sub btn_aulas_Click(sender As Object, e As EventArgs)
        Cadastro.Show()
        Me.Hide()
    End Sub
End Class