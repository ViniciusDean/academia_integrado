<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastrar_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_funcionarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tab_login = New System.Windows.Forms.TabPage()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_entrar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txt_user = New ns1.BunifuMaterialTextbox()
        Me.txt_pass = New ns1.BunifuMaterialTextbox()
        Me.chk_senha = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab_cadastro = New System.Windows.Forms.TabPage()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_enviar = New Guna.UI.WinForms.GunaCircleButton()
        Me.txt_senha = New ns1.BunifuMaterialTextbox()
        Me.txt_email = New ns1.BunifuMaterialTextbox()
        Me.txt_usuario = New ns1.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.chk_visualizar = New System.Windows.Forms.CheckBox()
        Me.txt_repete = New ns1.BunifuMaterialTextbox()
        Me.tab_gerenciar = New System.Windows.Forms.TabPage()
        Me.toolstrip_cad = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_gerenciar = New System.Windows.Forms.DataGridView()
        Me.id_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ativar_bloquear = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tab_login.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_cadastro.SuspendLayout()
        Me.tab_gerenciar.SuspendLayout()
        Me.toolstrip_cad.SuspendLayout()
        CType(Me.dgv_gerenciar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_login
        '
        Me.Tab_login.BackColor = System.Drawing.Color.Maroon
        Me.Tab_login.BackgroundImage = CType(resources.GetObject("Tab_login.BackgroundImage"), System.Drawing.Image)
        Me.Tab_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tab_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab_login.Controls.Add(Me.GunaCircleButton2)
        Me.Tab_login.Controls.Add(Me.btn_entrar)
        Me.Tab_login.Controls.Add(Me.txt_user)
        Me.Tab_login.Controls.Add(Me.txt_pass)
        Me.Tab_login.Controls.Add(Me.chk_senha)
        Me.Tab_login.Location = New System.Drawing.Point(4, 25)
        Me.Tab_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_login.Name = "Tab_login"
        Me.Tab_login.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_login.Size = New System.Drawing.Size(1693, 885)
        Me.Tab_login.TabIndex = 2
        Me.Tab_login.Text = "Login Funcionarios"
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.Gray
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.BorderSize = 2
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = CType(resources.GetObject("GunaCircleButton2.Image"), System.Drawing.Image)
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(1531, 754)
        Me.GunaCircleButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Size = New System.Drawing.Size(69, 58)
        Me.GunaCircleButton2.TabIndex = 242
        '
        'btn_entrar
        '
        Me.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BaseColor = System.Drawing.Color.Black
        Me.btn_entrar.BorderColor = System.Drawing.Color.White
        Me.btn_entrar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_entrar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_entrar.CheckedImage = CType(resources.GetObject("btn_entrar.CheckedImage"), System.Drawing.Image)
        Me.btn_entrar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.ImageSize = New System.Drawing.Size(35, 35)
        Me.btn_entrar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_entrar.Location = New System.Drawing.Point(707, 626)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.SeaGreen
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_entrar.Radius = 20
        Me.btn_entrar.Size = New System.Drawing.Size(275, 49)
        Me.btn_entrar.TabIndex = 29
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_user
        '
        Me.txt_user.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_user.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.Color.Black
        Me.txt_user.HintForeColor = System.Drawing.Color.Empty
        Me.txt_user.HintText = "Usuário:"
        Me.txt_user.isPassword = False
        Me.txt_user.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_user.LineIdleColor = System.Drawing.Color.Black
        Me.txt_user.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_user.LineThickness = 5
        Me.txt_user.Location = New System.Drawing.Point(629, 430)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(440, 47)
        Me.txt_user.TabIndex = 28
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_pass
        '
        Me.txt_pass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_pass.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.ForeColor = System.Drawing.Color.Black
        Me.txt_pass.HintForeColor = System.Drawing.Color.Empty
        Me.txt_pass.HintText = "Senha:"
        Me.txt_pass.isPassword = True
        Me.txt_pass.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_pass.LineIdleColor = System.Drawing.Color.Black
        Me.txt_pass.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_pass.LineThickness = 4
        Me.txt_pass.Location = New System.Drawing.Point(684, 502)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(305, 54)
        Me.txt_pass.TabIndex = 18
        Me.txt_pass.Text = "Senha"
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'chk_senha
        '
        Me.chk_senha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chk_senha.AutoSize = True
        Me.chk_senha.BackColor = System.Drawing.Color.Transparent
        Me.chk_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chk_senha.Image = CType(resources.GetObject("chk_senha.Image"), System.Drawing.Image)
        Me.chk_senha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_senha.Location = New System.Drawing.Point(755, 564)
        Me.chk_senha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_senha.Name = "chk_senha"
        Me.chk_senha.Size = New System.Drawing.Size(153, 24)
        Me.chk_senha.TabIndex = 16
        Me.chk_senha.Text = "Visualizar Senha"
        Me.chk_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_senha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chk_senha.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tab_login)
        Me.TabControl1.Controls.Add(Me.Tab_cadastro)
        Me.TabControl1.Controls.Add(Me.tab_gerenciar)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1701, 914)
        Me.TabControl1.TabIndex = 0
        '
        'Tab_cadastro
        '
        Me.Tab_cadastro.BackColor = System.Drawing.Color.Maroon
        Me.Tab_cadastro.BackgroundImage = CType(resources.GetObject("Tab_cadastro.BackgroundImage"), System.Drawing.Image)
        Me.Tab_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tab_cadastro.Controls.Add(Me.GunaCircleButton1)
        Me.Tab_cadastro.Controls.Add(Me.btn_enviar)
        Me.Tab_cadastro.Controls.Add(Me.txt_senha)
        Me.Tab_cadastro.Controls.Add(Me.txt_email)
        Me.Tab_cadastro.Controls.Add(Me.txt_usuario)
        Me.Tab_cadastro.Controls.Add(Me.Label5)
        Me.Tab_cadastro.Controls.Add(Me.cmb_tipo)
        Me.Tab_cadastro.Controls.Add(Me.chk_visualizar)
        Me.Tab_cadastro.Controls.Add(Me.txt_repete)
        Me.Tab_cadastro.Location = New System.Drawing.Point(4, 25)
        Me.Tab_cadastro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_cadastro.Name = "Tab_cadastro"
        Me.Tab_cadastro.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab_cadastro.Size = New System.Drawing.Size(1693, 885)
        Me.Tab_cadastro.TabIndex = 3
        Me.Tab_cadastro.Text = "Cadastro Funcionarios"
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(1545, 57)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(69, 58)
        Me.GunaCircleButton1.TabIndex = 240
        '
        'btn_enviar
        '
        Me.btn_enviar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_enviar.AnimationHoverSpeed = 0.07!
        Me.btn_enviar.AnimationSpeed = 0.03!
        Me.btn_enviar.BackColor = System.Drawing.Color.DimGray
        Me.btn_enviar.BaseColor = System.Drawing.Color.YellowGreen
        Me.btn_enviar.BorderColor = System.Drawing.Color.Black
        Me.btn_enviar.BorderSize = 2
        Me.btn_enviar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_enviar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_enviar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_enviar.ForeColor = System.Drawing.Color.White
        Me.btn_enviar.Image = CType(resources.GetObject("btn_enviar.Image"), System.Drawing.Image)
        Me.btn_enviar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_enviar.Location = New System.Drawing.Point(824, 671)
        Me.btn_enviar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btn_enviar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_enviar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_enviar.OnHoverImage = Nothing
        Me.btn_enviar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_enviar.Size = New System.Drawing.Size(69, 58)
        Me.btn_enviar.TabIndex = 66
        '
        'txt_senha
        '
        Me.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_senha.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_senha.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_senha.HintText = "Senha:"
        Me.txt_senha.isPassword = False
        Me.txt_senha.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_senha.LineIdleColor = System.Drawing.Color.Black
        Me.txt_senha.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_senha.LineThickness = 5
        Me.txt_senha.Location = New System.Drawing.Point(649, 452)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(387, 43)
        Me.txt_senha.TabIndex = 64
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_email
        '
        Me.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_email.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_email.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.HintForeColor = System.Drawing.Color.Empty
        Me.txt_email.HintText = "Email:"
        Me.txt_email.isPassword = False
        Me.txt_email.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_email.LineIdleColor = System.Drawing.Color.Black
        Me.txt_email.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_email.LineThickness = 5
        Me.txt_email.Location = New System.Drawing.Point(649, 398)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(387, 43)
        Me.txt_email.TabIndex = 63
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_usuario
        '
        Me.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_usuario.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_usuario.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.Black
        Me.txt_usuario.HintForeColor = System.Drawing.Color.Empty
        Me.txt_usuario.HintText = "Usuário:"
        Me.txt_usuario.isPassword = False
        Me.txt_usuario.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_usuario.LineIdleColor = System.Drawing.Color.Black
        Me.txt_usuario.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_usuario.LineThickness = 5
        Me.txt_usuario.Location = New System.Drawing.Point(649, 345)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(387, 43)
        Me.txt_usuario.TabIndex = 62
        Me.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(768, 606)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Tipo de conta:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Administrador", "Funcionario", "Personal Trainer"})
        Me.cmb_tipo.Location = New System.Drawing.Point(740, 636)
        Me.cmb_tipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(220, 24)
        Me.cmb_tipo.TabIndex = 57
        '
        'chk_visualizar
        '
        Me.chk_visualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chk_visualizar.AutoSize = True
        Me.chk_visualizar.BackColor = System.Drawing.Color.Transparent
        Me.chk_visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_visualizar.Location = New System.Drawing.Point(745, 564)
        Me.chk_visualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_visualizar.Name = "chk_visualizar"
        Me.chk_visualizar.Size = New System.Drawing.Size(171, 24)
        Me.chk_visualizar.TabIndex = 56
        Me.chk_visualizar.Text = "Visualizar senha"
        Me.chk_visualizar.UseVisualStyleBackColor = False
        '
        'txt_repete
        '
        Me.txt_repete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_repete.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.txt_repete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_repete.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_repete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_repete.ForeColor = System.Drawing.Color.Black
        Me.txt_repete.HintForeColor = System.Drawing.Color.Empty
        Me.txt_repete.HintText = "Repetir senha:"
        Me.txt_repete.isPassword = False
        Me.txt_repete.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_repete.LineIdleColor = System.Drawing.Color.Black
        Me.txt_repete.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_repete.LineThickness = 5
        Me.txt_repete.Location = New System.Drawing.Point(649, 506)
        Me.txt_repete.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_repete.Name = "txt_repete"
        Me.txt_repete.Size = New System.Drawing.Size(387, 43)
        Me.txt_repete.TabIndex = 65
        Me.txt_repete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tab_gerenciar
        '
        Me.tab_gerenciar.Controls.Add(Me.toolstrip_cad)
        Me.tab_gerenciar.Controls.Add(Me.dgv_gerenciar)
        Me.tab_gerenciar.Location = New System.Drawing.Point(4, 25)
        Me.tab_gerenciar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_gerenciar.Name = "tab_gerenciar"
        Me.tab_gerenciar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_gerenciar.Size = New System.Drawing.Size(1693, 885)
        Me.tab_gerenciar.TabIndex = 4
        Me.tab_gerenciar.Text = "Gerenciar Funcionarios"
        Me.tab_gerenciar.UseVisualStyleBackColor = True
        '
        'toolstrip_cad
        '
        Me.toolstrip_cad.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolstrip_cad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3})
        Me.toolstrip_cad.Location = New System.Drawing.Point(3, 2)
        Me.toolstrip_cad.Name = "toolstrip_cad"
        Me.toolstrip_cad.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.toolstrip_cad.Size = New System.Drawing.Size(1687, 31)
        Me.toolstrip_cad.TabIndex = 62
        Me.toolstrip_cad.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton2.Text = "ToolStripButton1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'dgv_gerenciar
        '
        Me.dgv_gerenciar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_gerenciar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gerenciar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_conta, Me.Usuario, Me.Tipo_conta, Me.Editar, Me.Excluir, Me.Ativar_bloquear})
        Me.dgv_gerenciar.Location = New System.Drawing.Point(-7, 33)
        Me.dgv_gerenciar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_gerenciar.Name = "dgv_gerenciar"
        Me.dgv_gerenciar.RowHeadersWidth = 62
        Me.dgv_gerenciar.RowTemplate.Height = 28
        Me.dgv_gerenciar.Size = New System.Drawing.Size(1703, 849)
        Me.dgv_gerenciar.TabIndex = 1
        '
        'id_conta
        '
        Me.id_conta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.id_conta.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_conta.HeaderText = "ID"
        Me.id_conta.MinimumWidth = 8
        Me.id_conta.Name = "id_conta"
        Me.id_conta.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Usuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MinimumWidth = 8
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Tipo_conta
        '
        Me.Tipo_conta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Tipo_conta.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo_conta.HeaderText = "Tipo conta"
        Me.Tipo_conta.MinimumWidth = 8
        Me.Tipo_conta.Name = "Tipo_conta"
        Me.Tipo_conta.ReadOnly = True
        '
        'Editar
        '
        Me.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Editar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.MinimumWidth = 8
        Me.Editar.Name = "Editar"
        '
        'Excluir
        '
        Me.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.Excluir.DefaultCellStyle = DataGridViewCellStyle5
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.MinimumWidth = 8
        Me.Excluir.Name = "Excluir"
        '
        'Ativar_bloquear
        '
        Me.Ativar_bloquear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Ativar_bloquear.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ativar_bloquear.HeaderText = "Ativar/bloquear"
        Me.Ativar_bloquear.MinimumWidth = 8
        Me.Ativar_bloquear.Name = "Ativar_bloquear"
        '
        'cadastrar_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1701, 910)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "cadastrar_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastrar_funcionarios"
        Me.Tab_login.ResumeLayout(False)
        Me.Tab_login.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_cadastro.ResumeLayout(False)
        Me.Tab_cadastro.PerformLayout()
        Me.tab_gerenciar.ResumeLayout(False)
        Me.tab_gerenciar.PerformLayout()
        Me.toolstrip_cad.ResumeLayout(False)
        Me.toolstrip_cad.PerformLayout()
        CType(Me.dgv_gerenciar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_login As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab_cadastro As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents chk_visualizar As CheckBox
    Friend WithEvents chk_senha As CheckBox
    Friend WithEvents tab_gerenciar As TabPage
    Friend WithEvents dgv_gerenciar As DataGridView
    Friend WithEvents toolstrip_cad As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents txt_pass As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_repete As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_senha As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_email As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_usuario As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_enviar As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txt_user As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents id_conta As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_conta As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents Ativar_bloquear As DataGridViewCheckBoxColumn
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
End Class
