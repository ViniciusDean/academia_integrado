<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vendas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New ns1.BunifuMaterialTextbox()
        Me.btn_criar = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 251)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "QUANTIDADE"
        '
        'cmb_produto
        '
        Me.cmb_produto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_produto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmb_produto.FormattingEnabled = True
        Me.cmb_produto.Location = New System.Drawing.Point(187, 175)
        Me.cmb_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_produto.Name = "cmb_produto"
        Me.cmb_produto.Size = New System.Drawing.Size(202, 21)
        Me.cmb_produto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PREÇO FINAL:"
        '
        'txt_preco
        '
        Me.txt_preco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_preco.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_preco.Location = New System.Drawing.Point(230, 331)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(110, 20)
        Me.txt_preco.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 204)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "VALOR:"
        '
        'txt_valor
        '
        Me.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_valor.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_valor.Location = New System.Drawing.Point(230, 224)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(110, 20)
        Me.txt_valor.TabIndex = 7
        '
        'txt_qtd
        '
        Me.txt_qtd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_qtd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_qtd.Location = New System.Drawing.Point(227, 277)
        Me.txt_qtd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(32, 20)
        Me.txt_qtd.TabIndex = 9
        '
        'txt_cpf
        '
        Me.txt_cpf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_cpf.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.Black
        Me.txt_cpf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpf.HintText = "CPF NA NOTA:"
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_cpf.LineIdleColor = System.Drawing.Color.Black
        Me.txt_cpf.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_cpf.LineThickness = 5
        Me.txt_cpf.Location = New System.Drawing.Point(171, 132)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(236, 35)
        Me.txt_cpf.TabIndex = 63
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_criar
        '
        Me.btn_criar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_criar.AnimationHoverSpeed = 0.07!
        Me.btn_criar.AnimationSpeed = 0.03!
        Me.btn_criar.BackColor = System.Drawing.Color.Transparent
        Me.btn_criar.BaseColor = System.Drawing.Color.YellowGreen
        Me.btn_criar.BorderColor = System.Drawing.Color.Black
        Me.btn_criar.BorderSize = 2
        Me.btn_criar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_criar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_criar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_criar.ForeColor = System.Drawing.Color.White
        Me.btn_criar.Image = CType(resources.GetObject("btn_criar.Image"), System.Drawing.Image)
        Me.btn_criar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_criar.Location = New System.Drawing.Point(257, 356)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btn_criar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_criar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_criar.OnHoverImage = Nothing
        Me.btn_criar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_criar.Size = New System.Drawing.Size(52, 47)
        Me.btn_criar.TabIndex = 237
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(485, 31)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(52, 47)
        Me.GunaCircleButton1.TabIndex = 238
        '
        'vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 491)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_qtd)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_produto)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "vendas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_produto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents txt_cpf As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_criar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
