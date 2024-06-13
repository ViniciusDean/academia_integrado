Imports ns1

Public Class cadastrar_funcionarios

    Private Sub cadastrar_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        If TabControl1.TabPages.Contains(Tab_cadastro) Or
          TabControl1.TabPages.Contains(tab_gerenciar) Then
            TabControl1.TabPages.Remove(Tab_cadastro)
            TabControl1.TabPages.Remove(tab_gerenciar)
        End If
        txt_pass.isPassword = True

    End Sub


    Private Sub dgv_gerenciar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_gerenciar.CellContentClick

        Try
            With dgv_gerenciar
                aux_rec = .CurrentRow.Cells(1).Value
                If .CurrentRow.Cells(3).Selected = True Then
                    TabControl1.SelectTab(0)
                    sql = "Select * from tb_login where usuario='" & aux_rec & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_usuario.Text = rs.Fields(1).Value
                        txt_email.Text = rs.Fields(2).Value
                        txt_senha.Text = rs.Fields(3).Value
                        txt_repete.Text = rs.Fields(3).Value
                        cmb_tipo.Text = rs.Fields(4).Value
                    End If

                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    sql = "select * from tb_login where usuario='" & aux_rec & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                            "o user: " & aux_rec & "?!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_login where usuario= '" & aux_rec & "'"
                            rs = db.Execute(sql)
                        End If
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then

                    sql = "select * from tb_login where usuario='" & aux_rec & "'"
                    rs = db.Execute(sql)
                    If rs.Fields(5).Value = "ATIVO" Then

                        resp = MsgBox("Tem deseja que deseja bloquear o usuario: " & aux_rec & " ?", vbInformation + vbYesNo, "AVISO")
                        If resp = vbYes Then
                            sql = "update tb_login set status_conta = 'bloqueado' where usuario= '" & aux_rec & "' "
                            rs = db.Execute(UCase(sql))
                            MsgBox("CONTA BLOQUEDA COM SUCESSO!!")
                        End If
                    Else

                        resp = MsgBox("Tem deseja que deseja reativar o usuario: " & aux_rec & " ?", vbInformation + vbYesNo, "AVISO")
                        If resp = vbYes Then
                            sql = "update tb_login set status_conta = 'ATIVO' where usuario= '" & aux_rec & "' "
                            rs = db.Execute(UCase(sql))
                            MsgBox("CONTA DESBLOQUEDA COM SUCESSO!!")
                        End If
                    End If


                End If


            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tab_gerenciar_Enter(sender As Object, e As EventArgs) Handles tab_gerenciar.Enter
        carregar_login()
    End Sub

    'Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
    'If chk_visualizar.Checked = True Then
    '  txt_senha.PasswordChar = ""
    ' txt_repete.PasswordChar = ""
    'Else
    '       txt_senha.PasswordChar = "*"
    '      txt_repete.PasswordChar = "*"
    'End If
    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Menu_adm.Show()
    End Sub



    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        logout()
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        logout()

    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Menu_adm.Show()
        Me.Hide()
    End Sub


    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Try
            sql = "select * from tb_login where email='" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_login set usuario='" & txt_usuario.Text & "', " &
                    "tipo_conta='" & cmb_tipo.Text & "', " &
                    "email='" & txt_email.Text & "' where email='" & txt_email.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
                limpar_cadastro()
            Else
                sql = "insert into tb_login(usuario, email, senha, tipo_conta) values('" & txt_usuario.Text & "', " &
                      "'" & txt_email.Text & "', '" & txt_senha.Text & "','" & cmb_tipo.Text & "' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
                limpar_cadastro()
            End If

        Catch ex As Exception
            MsgBox("ERRO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked = True Then
            txt_pass.isPassword = False
        ElseIf chk_senha.Checked = False Then
            txt_pass.isPassword = True
        End If

    End Sub

    Private Sub lbl_senha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        aux_nome = InputBox("Digte o usuario ou email", "recuperar senha")
        sql = "select * from tb_login where usuario= '" & aux_nome & "' or email= '" & aux_nome & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            cell = rs.Fields(7).Value
            key = rs.Fields(6).Value
            aux_senha = rs.Fields(3).Value
            Process.Start("https://api.callmebot.com/whatsapp.php?phone=" & cell & "&text='prezado(a) funcionario(a) " & aux_nome & " sua senha é " & aux_senha & "'&apikey=" & key & "")
        Else
            MsgBox("conta invalida", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If


    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        txt_pass.Text = UCase(txt_pass.Text)
        sql = "select * from tb_login where (usuario='" & txt_user.Text & "' or email='" & txt_user.Text & "')"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            MsgBox("Usuario incorreto", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
            txt_user.Text = ""
            txt_pass.Text = ""
            txt_user.Focus()

        Else
            tipo_user = rs.Fields(4).Value
            aux_rec = rs.Fields(3).Value
            If aux_rec = txt_pass.Text Then
                aux_id = rs.Fields(0).Value
                aux_nome = rs.Fields(1).Value
            Else
                MsgBox("Senha incorreta", MsgBoxStyle.Exclamation + vbOKOnly, "ATENÇÃO")
                txt_user.Text = ""
                txt_pass.Text = "senha"
                txt_usuario.Focus()
                Exit Sub
            End If
            If rs.Fields(5).Value = "BLOQUEADO" Then
                MsgBox("Sua conta está bloqueada! Contate um administrador ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

            ElseIf tipo_user = "ADMINISTRADOR" Then
                MsgBox("Bem vindo administrador!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")

                TabControl1.TabPages.Remove(Tab_login)
                TabControl1.TabPages.Add(Tab_cadastro)
                TabControl1.TabPages.Add(tab_gerenciar)
                Me.Hide()
                Menu_adm.Show()
            ElseIf tipo_user = "PERSONAL TRAINER" Then
                MsgBox("Bem Vindo Personal! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                With Cadastro
                    If .TabControl1.TabPages.Contains(.TabPage1) Then
                        .TabControl1.TabPages.Remove(.TabPage1)
                    End If
                    If Not .TabControl1.TabPages.Contains(.TabPage2) And
                        Not .TabControl1.TabPages.Contains(.TabPage3) And
                        Not .TabControl1.TabPages.Contains(.TabPage4) Then
                        .TabControl1.TabPages.Add(.TabPage2)
                        .TabControl1.TabPages.Add(.TabPage3)
                        .TabControl1.TabPages.Add(.TabPage4)
                    End If
                End With
                Menu_func.Show()
                Me.Hide()
            ElseIf tipo_user = "FUNCIONARIO" Then
                MsgBox("Bem vindo funcionario! ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                Menu_func.Show()
                With Cadastro
                    If .TabControl1.TabPages.Contains(.TabPage2) And
               .TabControl1.TabPages.Contains(.TabPage3) And
               .TabControl1.TabPages.Contains(.TabPage4) Then
                        .TabControl1.TabPages.Remove(.TabPage2)
                        .TabControl1.TabPages.Remove(.TabPage3)
                        .TabControl1.TabPages.Remove(.TabPage4)
                    End If
                    If Not .TabControl1.TabPages.Contains(.TabPage1) Then
                        .TabControl1.TabPages.Add(.TabPage1)
                    End If
                End With
                Me.Hide()
            Else
                MsgBox("Senha incorreta")
            End If
        End If


    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Menu_adm.Show()
        Me.Hide()
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        alunos.Show()
        Me.Hide()
    End Sub
End Class