Public Class vendas
    Private Sub cmb_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produto.SelectedIndexChanged
        sql = "select * from tb_produtos where nome = '" & cmb_produto.Text & "'"
        rs = db.Execute(sql)
        txt_qtd.Text = 1
        aux_valor = rs.Fields(2).Value
        txt_valor.Text = aux_valor
        txt_preco.Text = aux_valor

    End Sub

    Private Sub vendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        sql = "select * from tb_produtos"
        rs = db.Execute(sql)

        Do While (rs.EOF = False)
            aux_prod = rs.Fields(1).Value
            aux_valor = rs.Fields(2).Value
            cmb_produto.Items.Add("" & aux_prod & "")
            rs.MoveNext()
        Loop

    End Sub
    Private Sub txt_qtd_TextChanged(sender As Object, e As EventArgs) Handles txt_qtd.TextChanged
        Integer.TryParse(txt_qtd.Text, aux_preco)
        If aux_preco <= 1 Then
            txt_preco.Text = aux_valor
        Else
            txt_preco.Text = aux_valor * aux_preco
        End If

    End Sub

    Private Sub txt_preco_TextChanged(sender As Object, e As EventArgs) Handles txt_preco.TextChanged

    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        sql = "insert into tb_vendas(cpf, produto, quantidade, valor_final) values('" & txt_cpf.Text & "', " &
      "'" & cmb_produto.Text & "', '" & txt_qtd.Text & "', '" & txt_preco.Text & "')"
        rs = db.Execute(sql)
        MsgBox("Venda cadastrada com sucesso")
        txt_cpf.Text = ""
        txt_valor.Text = ""
        cmb_produto.Text = ""
        txt_qtd.Text = ""
        txt_preco.Text = ""
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Menu_func.Show()
        Me.Hide()
    End Sub
End Class