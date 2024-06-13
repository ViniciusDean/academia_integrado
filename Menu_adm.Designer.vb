<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_adm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_adm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cad_produtos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Button1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_logout = New Guna.UI.WinForms.GunaCircleButton()
        Me.btn_sair = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(435, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 75)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MENU ADM"
        '
        'btn_cad_produtos
        '
        Me.btn_cad_produtos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cad_produtos.AnimationHoverSpeed = 0.07!
        Me.btn_cad_produtos.AnimationSpeed = 0.03!
        Me.btn_cad_produtos.BackColor = System.Drawing.Color.Transparent
        Me.btn_cad_produtos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cad_produtos.BorderColor = System.Drawing.Color.White
        Me.btn_cad_produtos.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_cad_produtos.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_cad_produtos.CheckedForeColor = System.Drawing.Color.White
        Me.btn_cad_produtos.CheckedImage = CType(resources.GetObject("btn_cad_produtos.CheckedImage"), System.Drawing.Image)
        Me.btn_cad_produtos.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_cad_produtos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cad_produtos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cad_produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_produtos.ForeColor = System.Drawing.Color.White
        Me.btn_cad_produtos.Image = CType(resources.GetObject("btn_cad_produtos.Image"), System.Drawing.Image)
        Me.btn_cad_produtos.ImageSize = New System.Drawing.Size(35, 35)
        Me.btn_cad_produtos.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cad_produtos.Location = New System.Drawing.Point(341, 310)
        Me.btn_cad_produtos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cad_produtos.Name = "btn_cad_produtos"
        Me.btn_cad_produtos.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_cad_produtos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_cad_produtos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cad_produtos.OnHoverImage = Nothing
        Me.btn_cad_produtos.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cad_produtos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cad_produtos.Radius = 20
        Me.btn_cad_produtos.Size = New System.Drawing.Size(520, 70)
        Me.btn_cad_produtos.TabIndex = 0
        Me.btn_cad_produtos.Text = "CADASTRAR PRODUTOS"
        Me.btn_cad_produtos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.BorderColor = System.Drawing.Color.White
        Me.Button1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Button1.CheckedBorderColor = System.Drawing.Color.Black
        Me.Button1.CheckedForeColor = System.Drawing.Color.White
        Me.Button1.CheckedImage = CType(resources.GetObject("Button1.CheckedImage"), System.Drawing.Image)
        Me.Button1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageSize = New System.Drawing.Size(35, 35)
        Me.Button1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(343, 407)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.Red
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 20
        Me.Button1.Size = New System.Drawing.Size(520, 70)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "CADASTRAR FUNCIONÁRIOS"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btn_logout.Location = New System.Drawing.Point(565, 596)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logout.OnHoverForeColor = System.Drawing.Color.RosyBrown
        Me.btn_logout.OnHoverImage = Nothing
        Me.btn_logout.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logout.Size = New System.Drawing.Size(69, 64)
        Me.btn_logout.TabIndex = 238
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
        Me.btn_sair.Location = New System.Drawing.Point(1036, 58)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Size = New System.Drawing.Size(60, 55)
        Me.btn_sair.TabIndex = 239
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(35, 35)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(341, 503)
        Me.GunaAdvenceButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 20
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(520, 70)
        Me.GunaAdvenceButton1.TabIndex = 241
        Me.GunaAdvenceButton1.Text = "ACESSAR RELATÓRIOS"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Menu_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1185, 839)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cad_produtos)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Menu_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cad_produtos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btn_logout As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
