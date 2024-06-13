Module Module1
    Public cont, aux_id, insc, aux_valor, aux_preco, i, aux_aula, aux_alun As Integer
    Public diretorio, sql, aux_nome, resp, tipo_user, aux_rec, txt_temporario, aux_aluno, aux_prod, cell, key, aux_senha As String
    Public data, data2, aux_dia As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dir_banco = Application.StartupPath & "\banco\academia.mdb"

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & dir_banco)
            ' MsgBox("Conectado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch
            MsgBox("Erro ao conectar com o banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_login()
        Try
            sql = "select * from tb_login order by usuario asc"
            rs = db.Execute(sql)
            With cadastrar_funcionarios.dgv_gerenciar
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Sub limpar_cadastro()
        With cadastrar_funcionarios
            .txt_usuario.Text = ""
            .txt_email.Text = ""
            .txt_senha.Text = ""
            .txt_repete.Text = ""
            .txt_usuario.Focus()
        End With

    End Sub

    Sub carregar_produtos()
        Try
            sql = "select * from tb_produtos order by codigo"
            rs = db.Execute(sql)
            With produtos.dgv_produto
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Sub carregar_dgv_aulas()
        Try
            sql = "select * from tb_aulas order by id_aula"
            rs = db.Execute(sql)
            With Cadastro.dgv_edit_aulas
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(6).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Sub carregar_aulas()
        Try
            sql = "select * from tb_aulas order by id_aula"
            rs = db.Execute(sql)
            With alunos.dgv_aulas
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(6).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Sub logout()
        With cadastrar_funcionarios
            .txt_user.Text = ""
            .txt_pass.Text = ""
            .txt_pass.isPassword = True
            If .TabControl1.TabPages.Contains(.Tab_cadastro) Or
                .TabControl1.TabPages.Contains(.tab_gerenciar) And
                Not .TabControl1.TabPages.Contains(.Tab_login) Then
                .TabControl1.TabPages.Remove(.Tab_cadastro)
                .TabControl1.TabPages.Remove(.tab_gerenciar)
                .TabControl1.TabPages.Add(.Tab_login)

            End If
            With Cadastro
                .TabControl1.TabPages.Remove(.TabPage1)
                .TabControl1.TabPages.Remove(.TabPage2)
                .TabControl1.TabPages.Remove(.TabPage3)
                .TabControl1.TabPages.Remove(.TabPage4)
            End With

        End With
    End Sub

    Sub check_treino_costas()
        With Cadastro
            If .chk_costas.Checked = True Then
                .chk_costas.Text = " Remada baixa;"
            Else
                .chk_costas.Text = ""
            End If
            If .chk_costas1.Checked = True Then
                .chk_costas1.Text = " Remada alta;"
            Else
                .chk_costas1.Text = ""
            End If
            If .chk_costas2.Checked = True Then
                .chk_costas2.Text = " Puxada frontal;"
            Else
                .chk_costas2.Text = ""
            End If
            If .chk_costas3.Checked = True Then
                .chk_costas3.Text = " Barra livre;"
            Else
                .chk_costas3.Text = ""
            End If
            If .chk_costas4.Checked = True Then
                .chk_costas4.Text = " Remada cavalinho;"
            Else
                .chk_costas4.Text = ""
            End If

        End With
    End Sub


    Sub check_treino_peito()

        With Cadastro
            If .chk_peito.Checked = True Then
                .chk_peito.Text = " Supino reto;"
            Else
                .chk_peito.Text = ""
            End If
            If .chk_peito1.Checked = True Then
                .chk_peito1.Text = " Supito inclinado;"
            Else
                .chk_peito1.Text = ""
            End If
            If .chk_peito2.Checked = True Then
                .chk_peito2.Text = " Supino declinado;"
            Else
                .chk_peito2.Text = ""
            End If
            If .chk_peito3.Checked = True Then
                .chk_peito3.Text = " Crucifixo;"
            Else
                .chk_peito3.Text = ""
            End If
            If .chk_peito4.Checked = True Then
                .chk_peito4.Text = " PeckDeck;"
            Else
                .chk_peito4.Text = ""
            End If

        End With
    End Sub

    Sub check_treino_triceps()
        With Cadastro

            If .chk_tri.Checked = True Then
                .chk_tri.Text = " Tríceps mergulho;"
            Else
                .chk_tri.Text = ""
            End If
            If .chk_tri1.Checked = True Then
                .chk_tri1.Text = " Rosca francesa;"
            Else
                .chk_tri1.Text = ""
            End If
            If .chk_tri2.Checked = True Then
                .chk_tri2.Text = " Flexão de tríceps;"
            Else
                .chk_tri2.Text = ""
            End If
            If .chk_tri3.Checked = True Then
                .chk_tri3.Text = " Tríceps corda;"
            Else
                .chk_tri3.Text = ""
            End If
            If .chk_tri4.Checked = True Then
                .chk_tri4.Text = " Tríceps com halteres;"
            Else
                .chk_tri4.Text = ""
            End If

        End With
    End Sub

    Sub check_treino_biceps()
        With Cadastro

            If .chk_biceps.Checked = True Then
                .chk_biceps.Text = " Rosca alternada;"
            Else
                .chk_biceps.Text = ""
            End If
            If .chk_biceps1.Checked = True Then
                .chk_biceps1.Text = " Rosca direta;"
            Else
                .chk_biceps1.Text = ""
            End If
            If .chk_biceps2.Checked = True Then
                .chk_biceps2.Text = " Rosca Scott;"
            Else
                .chk_biceps2.Text = ""
            End If
            If .chk_biceps3.Checked = True Then
                .chk_biceps3.Text = " Rosca inversa;"
            Else
                .chk_biceps3.Text = ""
            End If
            If .chk_biceps4.Checked = True Then
                .chk_biceps4.Text = " Rosca martelo;"
            Else
                .chk_biceps4.Text = ""
            End If

        End With
    End Sub

    Sub check_treino_abdomen()
        With Cadastro

            If .chk_abm.Checked = True Then
                .chk_abm.Text = " Abdominais clássicos;"
            Else
                .chk_abm.Text = ""
            End If
            If .chk_abm1.Checked = True Then
                .chk_abm1.Text = " Abdominal obliquo;"
            Else
                .chk_abm1.Text = ""
            End If
            If .chk_abm2.Checked = True Then
                .chk_abm2.Text = " Prancha lateral;"
            Else
                .chk_abm2.Text = ""
            End If
            If .chk_abm3.Checked = True Then
                .chk_abm3.Text = " Prancha abdominal;"
            Else
                .chk_abm3.Text = ""
            End If

        End With
    End Sub


    Sub check_treino_aerobico()
        With Cadastro

            If .chk_aero.Checked = True Then
                .chk_aero.Text = " Esteira;"
            Else
                .chk_aero.Text = ""
            End If
            If .chk_aero1.Checked = True Then
                .chk_aero1.Text = " Corda;"
            Else
                .chk_aero1.Text = ""
            End If
            If .chk_aero2.Checked = True Then
                .chk_aero2.Text = " Bicicleta;"
            Else
                .chk_aero2.Text = ""
            End If
            If .chk_aero3.Checked = True Then
                .chk_aero3.Text = " Eliptico;"
            Else
                .chk_aero3.Text = ""
            End If


        End With
    End Sub

    Sub check_treino_ombros()
        With Cadastro

            If .chk_ombro.Checked = True Then
                .chk_ombro.Text = " Desenvolvimento barra;"
            Else
                .chk_ombro.Text = ""
            End If
            If .chk_ombro1.Checked = True Then
                .chk_ombro1.Text = " Desenvolvimento halteres;"
            Else
                .chk_ombro1.Text = ""
            End If
            If .chk_ombro2.Checked = True Then
                .chk_ombro2.Text = " Elevação lateral;"
            Else
                .chk_ombro2.Text = ""
            End If
            If .chk_ombro3.Checked = True Then
                .chk_ombro3.Text = " Elevação frontal;"
            Else
                .chk_ombro3.Text = ""
            End If


        End With
    End Sub

    Sub check_treino_quadriceps()
        With Cadastro

            If .chk_quad.Checked = True Then
                .chk_quad.Text = " Agachamento com barra;"
            Else
                .chk_quad.Text = ""
            End If
            If .chk_quad1.Checked = True Then
                .chk_quad1.Text = " Agachamento com halteres;"
            Else
                .chk_quad1.Text = ""
            End If
            If .chk_quad2.Checked = True Then
                .chk_quad2.Text = " Leg press;"
            Else
                .chk_quad2.Text = ""
            End If
            If .chk_quad3.Checked = True Then
                .chk_quad3.Text = " Afundo;"
            Else
                .chk_quad3.Text = ""
            End If
            If .chk_quad4.Checked = True Then
                .chk_quad4.Text = " Cadeira flexora;"
            Else
                .chk_quad4.Text = ""
            End If
            If .chk_quad5.Checked = True Then
                .chk_quad5.Text = " Cadeira extensora;"
            Else
                .chk_quad5.Text = ""
            End If

        End With
    End Sub

    Sub check_treino_panturrilha()
        With Cadastro

            If .chk_pantu.Checked = True Then
                .chk_pantu.Text = " Elevação panturrilha em pé;"
            Else
                .chk_pantu.Text = ""
            End If
            If .chk_pantu1.Checked = True Then
                .chk_pantu1.Text = " Elevação panturrilha sentado;"
            Else
                .chk_pantu1.Text = ""
            End If
            If .chk_pantu2.Checked = True Then
                .chk_pantu2.Text = " Salto com elevação de panturrilha;"
            Else
                .chk_pantu2.Text = ""
            End If
            If .chk_pantu3.Checked = True Then
                .chk_pantu3.Text = " Elevação de panturrilha com barra;"
            Else
                .chk_pantu3.Text = ""
            End If
            If .chk_pantu4.Checked = True Then
                .chk_pantu4.Text = " Elevação panturrilha máquina;"
            Else
                .chk_pantu4.Text = ""
            End If
            If .chk_pantu5.Checked = True Then
                .chk_pantu5.Text = " Elevação panturrilha unilateral;"
            Else
                .chk_pantu5.Text = ""
            End If

        End With
    End Sub


    Sub check_treino_gluteo()
        With Cadastro

            If .chk_glu.Checked = True Then
                .chk_glu.Text = " Agachamento com barra;"
            Else
                .chk_glu.Text = ""
            End If
            If .chk_glu1.Checked = True Then
                .chk_glu1.Text = " Glúteo bridge;"
            Else
                .chk_glu1.Text = ""
            End If
            If .chk_glu2.Checked = True Then
                .chk_glu2.Text = " Agachamento sumô;"
            Else
                .chk_glu2.Text = ""
            End If
            If .chk_glu3.Checked = True Then
                .chk_glu3.Text = " Elevação quadril barra;"
            Else
                .chk_glu3.Text = ""
            End If


        End With
    End Sub
    Sub limpar_produtos()
        With produtos
            .txt_cod.Text = ""
            .txt_estoque.Text = ""
            .txt_nome.Text = ""
            .txt_preco.Text = ""
        End With
    End Sub


End Module
