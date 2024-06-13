Public Class produtos
    Private Sub dgv_produto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto.CellContentClick

        With dgv_produto
            If .CurrentRow.Cells(4).Selected = True Then
                aux_id = .CurrentRow.Cells(0).Value
                TabControl1.SelectTab(0)
                sql = "select * from tb_produtos where codigo='" & aux_id & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_cod.Text = rs.Fields(0).Value
                    txt_cod.ReadOnly = True
                    txt_nome.Text = rs.Fields(1).Value
                    txt_preco.Text = rs.Fields(2).Value
                    txt_estoque.Text = rs.Fields(3).Value
                End If
            ElseIf .CurrentRow.Cells(5).Selected = True Then
                aux_id = .CurrentRow.Cells(0).Value
                sql = "select * from tb_produtos where codigo='" & aux_id & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                    "o PRODUTO: " & aux_id & "?!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_produtos where codigo= '" & aux_id & "'"
                        rs = db.Execute(sql)
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub produtos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        txt_cod.ReadOnly = False
    End Sub



    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        carregar_produtos()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Menu_adm.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        cadastrar_funcionarios.Show()
        Me.Hide()
        logout()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Menu_adm.Show()
        Me.Hide()
    End Sub

    Private Sub txt_cod_TextChanged(sender As Object, e As EventArgs) Handles txt_cod.TextChanged

    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        txt_cod.ReadOnly = False
        Try
            sql = "select * from tb_produtos where codigo='" & txt_cod.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_produtos set nome='" & txt_nome.Text & "', " &
                    "valor='" & txt_preco.Text & "', " &
                    "estoque='" & txt_estoque.Text & "' where codigo='" & txt_cod.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
                limpar_produtos()
            Else
                sql = "insert into tb_produtos values('" & txt_cod.Text & "', " &
                      "'" & txt_nome.Text & "', '" & txt_preco.Text & "','" & txt_estoque.Text & "' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
                limpar_produtos()

            End If

        Catch ex As Exception
            MsgBox("ERRO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        Menu_adm.Show()
        Me.Hide()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Menu_adm.Show()
        Me.Hide()
    End Sub
End Class