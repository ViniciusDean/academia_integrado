<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alunos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alunos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_sair = New Guna.UI.WinForms.GunaCircleButton()
        Me.button1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.txt_cpf = New ns1.BunifuMaterialTextbox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_logout = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_acessar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_visu = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_aulas = New System.Windows.Forms.DataGridView()
        Me.id_aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personal_aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dia_aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_aula_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inscrever = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_aulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1276, 743)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Maroon
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.btn_sair)
        Me.TabPage1.Controls.Add(Me.button1)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1268, 717)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LOGIN"
        '
        'btn_sair
        '
        Me.btn_sair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sair.AnimationHoverSpeed = 0.07!
        Me.btn_sair.AnimationSpeed = 0.03!
        Me.btn_sair.BackColor = System.Drawing.Color.Transparent
        Me.btn_sair.BaseColor = System.Drawing.Color.DimGray
        Me.btn_sair.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.BorderSize = 2
        Me.btn_sair.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sair.FocusedColor = System.Drawing.Color.Empty
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageSize = New System.Drawing.Size(45, 45)
        Me.btn_sair.Location = New System.Drawing.Point(1171, 45)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Size = New System.Drawing.Size(45, 45)
        Me.btn_sair.TabIndex = 240
        '
        'button1
        '
        Me.button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button1.AnimationHoverSpeed = 0.07!
        Me.button1.AnimationSpeed = 0.03!
        Me.button1.BackColor = System.Drawing.Color.DimGray
        Me.button1.BaseColor = System.Drawing.Color.YellowGreen
        Me.button1.BorderColor = System.Drawing.Color.Black
        Me.button1.BorderSize = 2
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.button1.FocusedColor = System.Drawing.Color.Empty
        Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.button1.Location = New System.Drawing.Point(611, 543)
        Me.button1.Name = "button1"
        Me.button1.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button1.OnHoverForeColor = System.Drawing.Color.White
        Me.button1.OnHoverImage = Nothing
        Me.button1.OnPressedColor = System.Drawing.Color.Black
        Me.button1.Size = New System.Drawing.Size(52, 47)
        Me.button1.TabIndex = 68
        '
        'txt_cpf
        '
        Me.txt_cpf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.Black
        Me.txt_cpf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpf.HintText = "CPF ALUNO:"
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.LineFocusedColor = System.Drawing.Color.Crimson
        Me.txt_cpf.LineIdleColor = System.Drawing.Color.Black
        Me.txt_cpf.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txt_cpf.LineThickness = 5
        Me.txt_cpf.Location = New System.Drawing.Point(442, 309)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(387, 57)
        Me.txt_cpf.TabIndex = 30
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Lime
        Me.LinkLabel1.Location = New System.Drawing.Point(540, 439)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(185, 24)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SOU FUNCIONARIO"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Maroon
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.btn_logout)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.btn_acessar)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.cmb_visu)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(1268, 717)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TREINO ALUNO"
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_logout.AnimationHoverSpeed = 0.07!
        Me.btn_logout.AnimationSpeed = 0.03!
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BaseColor = System.Drawing.Color.DarkGray
        Me.btn_logout.BorderColor = System.Drawing.Color.Black
        Me.btn_logout.BorderSize = 2
        Me.btn_logout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logout.FocusedColor = System.Drawing.Color.Empty
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageSize = New System.Drawing.Size(52, 52)
        Me.btn_logout.Location = New System.Drawing.Point(1157, 53)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.RosyBrown
        Me.btn_logout.OnHoverImage = Nothing
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Size = New System.Drawing.Size(52, 52)
        Me.btn_logout.TabIndex = 239
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(473, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 60)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ÁREA DO ALUNO"
        '
        'btn_acessar
        '
        Me.btn_acessar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessar.AnimationHoverSpeed = 0.07!
        Me.btn_acessar.AnimationSpeed = 0.03!
        Me.btn_acessar.BackColor = System.Drawing.Color.Transparent
        Me.btn_acessar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_acessar.BorderColor = System.Drawing.Color.White
        Me.btn_acessar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_acessar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_acessar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_acessar.CheckedImage = CType(resources.GetObject("btn_acessar.CheckedImage"), System.Drawing.Image)
        Me.btn_acessar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_acessar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_acessar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_acessar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessar.ForeColor = System.Drawing.Color.White
        Me.btn_acessar.Image = CType(resources.GetObject("btn_acessar.Image"), System.Drawing.Image)
        Me.btn_acessar.ImageSize = New System.Drawing.Size(35, 35)
        Me.btn_acessar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_acessar.Location = New System.Drawing.Point(444, 463)
        Me.btn_acessar.Name = "btn_acessar"
        Me.btn_acessar.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_acessar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_acessar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_acessar.OnHoverImage = Nothing
        Me.btn_acessar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_acessar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_acessar.Radius = 20
        Me.btn_acessar.Size = New System.Drawing.Size(390, 57)
        Me.btn_acessar.TabIndex = 10
        Me.btn_acessar.Text = "ACESSAR TREINOS"
        Me.btn_acessar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 288)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(406, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selecione o dia que deseja visualizar"
        '
        'cmb_visu
        '
        Me.cmb_visu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_visu.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmb_visu.FormattingEnabled = True
        Me.cmb_visu.Items.AddRange(New Object() {"Segunda - Feira", "Terça - Feira", "Quarta - Feira", "Quinta - Feira", "Sexta - Feira", "Sábado", "Domingo"})
        Me.cmb_visu.Location = New System.Drawing.Point(525, 350)
        Me.cmb_visu.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_visu.Name = "cmb_visu"
        Me.cmb_visu.Size = New System.Drawing.Size(221, 21)
        Me.cmb_visu.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_aulas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1268, 717)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INSCRIÇÃO AULAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_aulas
        '
        Me.dgv_aulas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_aulas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_aulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_aulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_aula, Me.personal_aula, Me.horario, Me.dia_aula, Me.tipo_aula_dgv, Me.Inscrever})
        Me.dgv_aulas.Location = New System.Drawing.Point(2, 15)
        Me.dgv_aulas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_aulas.Name = "dgv_aulas"
        Me.dgv_aulas.RowHeadersWidth = 51
        Me.dgv_aulas.RowTemplate.Height = 24
        Me.dgv_aulas.Size = New System.Drawing.Size(1262, 696)
        Me.dgv_aulas.TabIndex = 1
        '
        'id_aula
        '
        Me.id_aula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_aula.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_aula.FillWeight = 25.66845!
        Me.id_aula.HeaderText = "ID Aula"
        Me.id_aula.MinimumWidth = 8
        Me.id_aula.Name = "id_aula"
        Me.id_aula.ReadOnly = True
        Me.id_aula.Width = 67
        '
        'personal_aula
        '
        Me.personal_aula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.personal_aula.DefaultCellStyle = DataGridViewCellStyle2
        Me.personal_aula.FillWeight = 25.66845!
        Me.personal_aula.HeaderText = "Personal"
        Me.personal_aula.MinimumWidth = 8
        Me.personal_aula.Name = "personal_aula"
        Me.personal_aula.ReadOnly = True
        Me.personal_aula.Width = 73
        '
        'horario
        '
        Me.horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.horario.DefaultCellStyle = DataGridViewCellStyle3
        Me.horario.FillWeight = 25.66845!
        Me.horario.HeaderText = "Horario"
        Me.horario.MinimumWidth = 8
        Me.horario.Name = "horario"
        Me.horario.ReadOnly = True
        Me.horario.Width = 66
        '
        'dia_aula
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dia_aula.DefaultCellStyle = DataGridViewCellStyle4
        Me.dia_aula.FillWeight = 471.6577!
        Me.dia_aula.HeaderText = "Dia"
        Me.dia_aula.MinimumWidth = 8
        Me.dia_aula.Name = "dia_aula"
        Me.dia_aula.ReadOnly = True
        Me.dia_aula.Width = 130
        '
        'tipo_aula_dgv
        '
        Me.tipo_aula_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.tipo_aula_dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.tipo_aula_dgv.FillWeight = 25.66845!
        Me.tipo_aula_dgv.HeaderText = "Tipo de aula"
        Me.tipo_aula_dgv.MinimumWidth = 8
        Me.tipo_aula_dgv.Name = "tipo_aula_dgv"
        Me.tipo_aula_dgv.ReadOnly = True
        Me.tipo_aula_dgv.Width = 91
        '
        'Inscrever
        '
        Me.Inscrever.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Inscrever.DefaultCellStyle = DataGridViewCellStyle6
        Me.Inscrever.FillWeight = 25.66845!
        Me.Inscrever.HeaderText = "Inscrever-se"
        Me.Inscrever.Image = CType(resources.GetObject("Inscrever.Image"), System.Drawing.Image)
        Me.Inscrever.MinimumWidth = 8
        Me.Inscrever.Name = "Inscrever"
        Me.Inscrever.Width = 71
        '
        'alunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1276, 739)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "alunos"
        Me.Text = "alunos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_aulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents dgv_aulas As DataGridView
    Friend WithEvents txt_cpf As ns1.BunifuMaterialTextbox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_visu As ComboBox
    Friend WithEvents button1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_acessar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents id_aula As DataGridViewTextBoxColumn
    Friend WithEvents personal_aula As DataGridViewTextBoxColumn
    Friend WithEvents horario As DataGridViewTextBoxColumn
    Friend WithEvents dia_aula As DataGridViewTextBoxColumn
    Friend WithEvents tipo_aula_dgv As DataGridViewTextBoxColumn
    Friend WithEvents Inscrever As DataGridViewImageColumn
End Class
