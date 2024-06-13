<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class produtos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(produtos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlProduto = New System.Windows.Forms.Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_salvar = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_estoque = New ns1.BunifuMaterialTextbox()
        Me.txt_preco = New ns1.BunifuMaterialTextbox()
        Me.txt_nome = New ns1.BunifuMaterialTextbox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_produto = New System.Windows.Forms.DataGridView()
        Me.id_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlProduto.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(586, 530)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlProduto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(578, 504)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro Produtos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlProduto
        '
        Me.pnlProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProduto.BackColor = System.Drawing.Color.Brown
        Me.pnlProduto.BackgroundImage = CType(resources.GetObject("pnlProduto.BackgroundImage"), System.Drawing.Image)
        Me.pnlProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlProduto.Controls.Add(Me.GunaCircleButton1)
        Me.pnlProduto.Controls.Add(Me.btn_salvar)
        Me.pnlProduto.Controls.Add(Me.Label2)
        Me.pnlProduto.Controls.Add(Me.txt_cod)
        Me.pnlProduto.Controls.Add(Me.txt_estoque)
        Me.pnlProduto.Controls.Add(Me.txt_preco)
        Me.pnlProduto.Controls.Add(Me.txt_nome)
        Me.pnlProduto.Location = New System.Drawing.Point(0, 0)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(580, 501)
        Me.pnlProduto.TabIndex = 7
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.BorderSize = 2
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(500, 32)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(52, 47)
        Me.GunaCircleButton1.TabIndex = 241
        '
        'btn_salvar
        '
        Me.btn_salvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_salvar.AnimationHoverSpeed = 0.07!
        Me.btn_salvar.AnimationSpeed = 0.03!
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BaseColor = System.Drawing.Color.YellowGreen
        Me.btn_salvar.BorderColor = System.Drawing.Color.Black
        Me.btn_salvar.BorderSize = 2
        Me.btn_salvar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_salvar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_salvar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_salvar.Location = New System.Drawing.Point(263, 359)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btn_salvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_salvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_salvar.OnHoverImage = Nothing
        Me.btn_salvar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_salvar.Size = New System.Drawing.Size(52, 47)
        Me.btn_salvar.TabIndex = 237
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Código"
        '
        'txt_cod
        '
        Me.txt_cod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_cod.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.Location = New System.Drawing.Point(244, 165)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(90, 29)
        Me.txt_cod.TabIndex = 68
        '
        'txt_estoque
        '
        Me.txt_estoque.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_estoque.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_estoque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_estoque.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estoque.ForeColor = System.Drawing.Color.Black
        Me.txt_estoque.HintForeColor = System.Drawing.Color.Empty
        Me.txt_estoque.HintText = "ESTOQUE:"
        Me.txt_estoque.isPassword = False
        Me.txt_estoque.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_estoque.LineIdleColor = System.Drawing.Color.Black
        Me.txt_estoque.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_estoque.LineThickness = 5
        Me.txt_estoque.Location = New System.Drawing.Point(177, 302)
        Me.txt_estoque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_estoque.Name = "txt_estoque"
        Me.txt_estoque.Size = New System.Drawing.Size(231, 44)
        Me.txt_estoque.TabIndex = 31
        Me.txt_estoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_preco
        '
        Me.txt_preco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_preco.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_preco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_preco.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.ForeColor = System.Drawing.Color.Black
        Me.txt_preco.HintForeColor = System.Drawing.Color.Empty
        Me.txt_preco.HintText = "PREÇO DE VENDA:"
        Me.txt_preco.isPassword = False
        Me.txt_preco.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_preco.LineIdleColor = System.Drawing.Color.Black
        Me.txt_preco.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_preco.LineThickness = 5
        Me.txt_preco.Location = New System.Drawing.Point(176, 254)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(231, 44)
        Me.txt_preco.TabIndex = 30
        Me.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_nome
        '
        Me.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_nome.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.Black
        Me.txt_nome.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nome.HintText = "NOME:"
        Me.txt_nome.isPassword = False
        Me.txt_nome.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_nome.LineIdleColor = System.Drawing.Color.Black
        Me.txt_nome.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_nome.LineThickness = 5
        Me.txt_nome.Location = New System.Drawing.Point(178, 200)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(231, 44)
        Me.txt_nome.TabIndex = 29
        Me.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Controls.Add(Me.dgv_produto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(578, 504)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gerenciar produtos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton12, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(574, 27)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton12.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'dgv_produto
        '
        Me.dgv_produto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_produto.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_prod, Me.nome, Me.valor, Me.estoque, Me.editar, Me.excluir})
        Me.dgv_produto.Location = New System.Drawing.Point(8, 25)
        Me.dgv_produto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_produto.Name = "dgv_produto"
        Me.dgv_produto.RowHeadersWidth = 51
        Me.dgv_produto.RowTemplate.Height = 24
        Me.dgv_produto.Size = New System.Drawing.Size(568, 477)
        Me.dgv_produto.TabIndex = 2
        '
        'id_prod
        '
        Me.id_prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.id_prod.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_prod.HeaderText = "ID Produto"
        Me.id_prod.MinimumWidth = 6
        Me.id_prod.Name = "id_prod"
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.nome.DefaultCellStyle = DataGridViewCellStyle2
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        '
        'valor
        '
        Me.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.valor.DefaultCellStyle = DataGridViewCellStyle3
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        '
        'estoque
        '
        Me.estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.estoque.DefaultCellStyle = DataGridViewCellStyle4
        Me.estoque.HeaderText = "Estoque"
        Me.estoque.MinimumWidth = 6
        Me.estoque.Name = "estoque"
        '
        'editar
        '
        Me.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.editar.DefaultCellStyle = DataGridViewCellStyle5
        Me.editar.HeaderText = "Editar"
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.MinimumWidth = 6
        Me.editar.Name = "editar"
        '
        'excluir
        '
        Me.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.excluir.DefaultCellStyle = DataGridViewCellStyle6
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.MinimumWidth = 6
        Me.excluir.Name = "excluir"
        '
        'produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(580, 525)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "produtos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlProduto.ResumeLayout(False)
        Me.pnlProduto.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnlProduto As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_produto As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents id_prod As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents estoque As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
    Friend WithEvents txt_estoque As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_preco As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_nome As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salvar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
