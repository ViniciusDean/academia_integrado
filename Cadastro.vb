Public Class Cadastro


    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        TabControl1.TabPages.Remove(TabPage1)
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage3)
        TabControl1.TabPages.Remove(TabPage4)
        If tipo_user = "FUNCIONARIO" Then
            TabControl1.TabPages.Add(TabPage1)

        ElseIf tipo_user = "PERSONAL TRAINER" Then
            TabControl1.TabPages.Add(TabPage2)
            TabControl1.TabPages.Add(TabPage3)
            TabControl1.TabPages.Add(TabPage4)
        End If

    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Try
            sql = "select * from tb_cep where cep = '" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_num.Focus()
            Else
                MsgBox("CEP NÃO ENCONTRADO!", MsgBoxStyle.Exclamation, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("CEP NÃO ENCONTRADO!", MsgBoxStyle.Exclamation, "AVISO")
        End Try

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            sql = "select * from tb_cadastro where CPF = '" & txt_id.Text & "'"
            rs = db.Execute(sql)
            aux_alun = rs.Fields(0).Value
            If rs.EOF = True Then
                MsgBox("ALUNO NAO ENCONTRADO")
            Else
                aux_dia = cmb_dia.Text
                sql = "select * from tb_treino where id_usuario=" & aux_alun & " and dia = '" & aux_dia & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "delete * from tb_treino where id_usuario=" & aux_alun & " and dia = '" & aux_dia & "'"
                    rs = db.Execute(sql)


                End If
                check_treino_costas()
                check_treino_peito()
                check_treino_triceps()
                check_treino_biceps()
                check_treino_abdomen()
                check_treino_aerobico()
                check_treino_ombros()
                check_treino_quadriceps()
                check_treino_panturrilha()
                check_treino_gluteo()

                sql = "insert into tb_treino values(" & aux_alun & ",'" & chk_costas.Text + chk_costas1.Text + chk_costas2.Text + chk_costas3.Text + chk_costas4.Text & "' , " &
                                "'" & chk_peito.Text + chk_peito1.Text + chk_peito2.Text + chk_peito3.Text + chk_peito4.Text & "', " &
                                "'" & chk_abm.Text + chk_abm1.Text + chk_abm2.Text + chk_abm3.Text & "', " &
                                "'" & chk_biceps.Text + chk_biceps1.Text + chk_biceps2.Text + chk_biceps3.Text + chk_biceps4.Text & "', " &
                                "'" & chk_ombro.Text + chk_ombro1.Text + chk_ombro2.Text + chk_ombro3.Text & "', " &
                                "'" & chk_tri.Text + chk_tri1.Text + chk_tri2.Text + chk_tri3.Text + chk_tri4.Text & "', " &
                                "'" & chk_quad.Text + chk_quad1.Text + chk_quad2.Text + chk_quad3.Text + chk_quad4.Text + chk_quad5.Text & "', " &
                                "'" & chk_pantu.Text + chk_pantu1.Text + chk_pantu2.Text + chk_pantu3.Text + chk_pantu4.Text + chk_pantu5.Text & "', " &
                                "'" & chk_glu.Text + chk_glu1.Text + chk_glu2.Text + chk_glu3.Text & "' , " &
                                "'" & chk_aero.Text + chk_aero1.Text + chk_aero2.Text + chk_aero3.Text & "', " &
                                "'" & cmb_dia.Text & "')"
                rs = db.Execute(sql)

                MsgBox("TREINO CRIADO COM SUCESSO!!!")
                chk_costas1.Checked = False
                chk_glu.Checked = False
                chk_glu1.Checked = False
                chk_glu2.Checked = False
                chk_glu3.Checked = False
                chk_pantu1.Checked = False
                chk_pantu2.Checked = False
                chk_pantu3.Checked = False
                chk_pantu4.Checked = False
                chk_pantu5.Checked = False
                chk_quad.Checked = False
                chk_quad1.Checked = False
                chk_quad2.Checked = False
                chk_quad3.Checked = False
                chk_quad4.Checked = False
                chk_quad5.Checked = False
                chk_peito4.Checked =
                    chk_costas4.Checked = False
                chk_ombro.Checked = False
                chk_ombro1.Checked = False
                chk_ombro2.Checked = False
                chk_biceps.Checked = False
                chk_biceps1.Checked = False
                chk_biceps2.Checked = False
                chk_biceps4.Checked = False
                chk_ombro3.Checked = False
                chk_tri1.Checked = False
                chk_tri2.Checked = False
                chk_tri3.Checked = False
                chk_tri4.Checked = False
                chk_peito2.Checked = False
                chk_peito1.Checked = False
                chk_peito.Checked = False
                chk_costas3.Checked = False
                chk_costas2.Checked = False
                chk_aero.Checked = False
                chk_aero1.Checked = False
                chk_aero2.Checked = False
                chk_aero3.Checked = False
                chk_abm1.Checked = False
                chk_abm2.Checked = False
                chk_abm3.Checked = False
                chk_costas.Checked = False
                chk_costas4.Checked = False
                chk_peito3.Checked = False
                chk_tri.Checked = False
                chk_biceps3.Checked = False
                chk_pantu.Checked = False
                chk_abm.Checked = False
                ' Desmarque todos os GunaWinSwitch com prefixo "chk_"


                txt_id.Text = ""
                cmb_dia.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar o treino")
        End Try


    End Sub


    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        sql = "insert into tb_aulas (id_conta, personal, horario, dia, tipo_aula, max_inscritos) values ('" & aux_id & "', " &
           "'" & aux_nome & "', '" & cmb_hora.Text & "', '" & txt_data1.Value.Date & "',  " &
           " '" & cmb_aula.Text & "', '" & max_alunos.Text & "')"
        rs = db.Execute(sql)
        MsgBox("Aula criada com sucesso")
        carregar_dgv_aulas()

        cmb_aula.Text = ""
        cmb_hora.Text = ""
        txt_data1.Text = ""
        max_alunos.Value = 0
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub

    Private Sub GunaCircleButton1_Click_1(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Menu_func.Show()
        Me.Hide()
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Menu_func.Show()
        Me.Hide()
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click
        Menu_func.Show()
        Me.Hide()
    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs)
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try

            sql = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                        "data_nasc='" & txt_data.Value & "', " &
                        "cep='" & txt_cep.Text & "', " &
                        "endereco='" & txt_endereco.Text & "', " &
                        "num='" & txt_num.Text & "', " &
                        "Objetivo='" & cmb_obj.Text & "', " &
                        "bairro='" & txt_bairro.Text & "', " &
                        "cidade='" & txt_cidade.Text & "', " &
                        "uf='" & txt_uf.Text & "', " &
                        "celular='" & txt_celular.Text & "', " &
                        "email='" & txt_email.Text & "', " &
                        "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            Else
                sql = "insert into tb_cadastro (CPF, NOME, DATA_NASC, CEP, ENDERECO,
            NUM, BAIRRO, CIDADE, UF , CELULAR, EMAIL, OBJETIVO, FOTO) values('" & txt_cpf.Text & "', " &
                 "'" & txt_nome.Text & "', '" & txt_data.Value.Date & "', " &
                 "'" & txt_cep.Text & "' , '" & txt_endereco.Text & "',  " &
                 "'" & txt_num.Text & "' , '" & txt_bairro.Text & "', " &
                 "'" & txt_cidade.Text & "', '" & txt_uf.Text & "', " &
                 "'" & txt_celular.Text & "', '" & txt_email.Text & "', " &
                 "'" & cmb_obj.Text & "' , '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
                txt_cep.Text = ""
                txt_email.Text = ""
                txt_nome.Text = ""
                txt_celular.Text = ""
                txt_cpf.Text = ""
                txt_endereco.Text = ""
                txt_cidade.Text = ""
                txt_bairro.Text = ""
                txt_num.Text = ""
                txt_uf.Text = ""
                cmb_obj.Text = ""

            End If

        Catch ex As Exception
            MsgBox("ERRO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub



    Private Sub dgv_edit_aulas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_edit_aulas.CellContentClick
        With dgv_edit_aulas
            If .CurrentRow.Cells(6).Selected = True Then
                aux_aula = .CurrentRow.Cells(0).Value
                sql = "select * from tb_aulas where id_aula=" & aux_aula & ""
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                        "a aula? ?!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_aulas where id_aula= " & aux_aula & ""
                        rs = db.Execute(sql)
                        sql = "delete * from tb_inscritos where id_aula= " & aux_aula & ""
                        rs = db.Execute(sql)
                        MsgBox("Aula excluida com sucesso!!")
                        carregar_dgv_aulas()
                    End If
                End If
            End If
        End With

    End Sub

    Private Sub dgv_edit_aulas_Enter(sender As Object, e As EventArgs) Handles dgv_edit_aulas.Enter
        carregar_dgv_aulas()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub chk_abm_CheckedChanged(sender As Object, e As EventArgs) Handles chk_abm.CheckedChanged

    End Sub
End Class