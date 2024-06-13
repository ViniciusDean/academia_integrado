Imports DevComponents.DotNetBar

Public Class alunos
    Private Sub dgv_aulas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_aulas.CellContentClick
        With dgv_aulas
            If .CurrentRow.Cells(5).Selected = True Then
                resp = MsgBox("Tem certeza que deseja se inscrever? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                If resp = vbYes Then
                    aux_id = .CurrentRow.Cells(0).Value
                    sql = "insert into tb_inscritos values ('" & aux_aluno & "', '" & aux_id & "') "
                    rs = db.Execute(sql)
                    MsgBox("inscrito na aula com sucesso! ")
                End If


            End If
        End With

    End Sub

    Private Sub alunos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage4)


    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        carregar_aulas()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        cadastrar_funcionarios.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        'carregar_treinos()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        '   Try

        sql = "select * from tb_cadastro where cpf = '" & txt_cpf.Text & "'"
        rs = db.Execute(sql)
        aux_id = rs.Fields(0).Value
        If rs.EOF = False Then
            aux_aluno = rs.Fields(2).Value
            MsgBox("Bem vindo aluno: " + aux_aluno)
            If TabControl1.TabPages.Contains(TabPage1) Then
                TabControl1.TabPages.Add(TabPage4)
                TabControl1.TabPages.Add(TabPage2)
                TabControl1.SelectedTab = TabPage4
                TabControl1.TabPages.Remove(TabPage1)
                carregar_aulas()
            End If
            txt_cpf.Text = ""
        Else
            MsgBox("Aluno não encontrado!!", vbInformation + vbOKOnly, "AIVSO")
            txt_cpf.Text = ""
            txt_cpf.Focus()
        End If
            'Catch ex As Exception
        '  MsgBox("Não foi possivel efetuar o login!", MsgBoxStyle.Exclamation, "AVISO")
        '  End Try

    End Sub

    Private Sub btn_acessar_Click(sender As Object, e As EventArgs) Handles btn_acessar.Click
        If cmb_visu.Text <> "" Then
            aux_dia = cmb_visu.Text

            treino.Show()

            Else
                MsgBox("Selecione um dia para continuar! ")
        End If

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage4)
        TabControl1.TabPages.Add(TabPage1)
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub alunos_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub
End Class