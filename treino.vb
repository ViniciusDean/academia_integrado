Imports DevComponents.DotNetBar.Controls

Public Class treino

    Private Sub treino_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        Try
            sql = "select * from tb_treino where id_usuario = " & aux_id & " and dia = '" & aux_dia & "'"
            rs = db.Execute(sql)
            With dgv_treino
                cont = 1
                i = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(11).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
                sql = "select * from tb_treino where id_usuario = " & aux_id & " and dia = '" & aux_dia & "'"
                rs = db.Execute(sql)
                Do While i <= 10
                    If rs.Fields(i).Value = "" Then
                        .Columns(i).Visible = False
                    End If
                    i = i + 1
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar o treino! Contate o personal")
            Me.Hide()
        End Try


    End Sub


    Private Sub dgv_treino_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_treino.CellFormatting

        If e.Value IsNot Nothing Then
            Dim cellValue As String = e.Value.ToString()
            Dim formattedValue As String = cellValue.Replace(";", Environment.NewLine)
            e.Value = formattedValue
            e.FormattingApplied = True
        End If

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)
        alunos.Show()
    End Sub


End Class