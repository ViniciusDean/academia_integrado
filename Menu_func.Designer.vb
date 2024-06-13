<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_func
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_func))
        Me.btn_cad_alunos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_cad_produtos = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.button3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'btn_cad_alunos
        '
        Me.btn_cad_alunos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cad_alunos.AnimationHoverSpeed = 0.07!
        Me.btn_cad_alunos.AnimationSpeed = 0.03!
        Me.btn_cad_alunos.BackColor = System.Drawing.Color.Transparent
        Me.btn_cad_alunos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cad_alunos.BorderColor = System.Drawing.Color.White
        Me.btn_cad_alunos.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_cad_alunos.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_cad_alunos.CheckedForeColor = System.Drawing.Color.White
        Me.btn_cad_alunos.CheckedImage = CType(resources.GetObject("btn_cad_alunos.CheckedImage"), System.Drawing.Image)
        Me.btn_cad_alunos.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_cad_alunos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cad_alunos.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cad_alunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_alunos.ForeColor = System.Drawing.Color.White
        Me.btn_cad_alunos.Image = CType(resources.GetObject("btn_cad_alunos.Image"), System.Drawing.Image)
        Me.btn_cad_alunos.ImageSize = New System.Drawing.Size(35, 35)
        Me.btn_cad_alunos.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cad_alunos.Location = New System.Drawing.Point(584, 297)
        Me.btn_cad_alunos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cad_alunos.Name = "btn_cad_alunos"
        Me.btn_cad_alunos.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btn_cad_alunos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_cad_alunos.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cad_alunos.OnHoverImage = Nothing
        Me.btn_cad_alunos.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cad_alunos.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cad_alunos.Radius = 20
        Me.btn_cad_alunos.Size = New System.Drawing.Size(520, 70)
        Me.btn_cad_alunos.TabIndex = 7
        Me.btn_cad_alunos.Text = "CADASTRAR ALUNOS"
        Me.btn_cad_alunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btn_cad_produtos.Location = New System.Drawing.Point(584, 401)
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
        Me.btn_cad_produtos.TabIndex = 8
        Me.btn_cad_produtos.Text = "CADASTRAR VENDAS"
        Me.btn_cad_produtos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'button3
        '
        Me.button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.button3.AnimationHoverSpeed = 0.07!
        Me.button3.AnimationSpeed = 0.03!
        Me.button3.BackColor = System.Drawing.Color.Transparent
        Me.button3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button3.BorderColor = System.Drawing.Color.White
        Me.button3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button3.CheckedBorderColor = System.Drawing.Color.Black
        Me.button3.CheckedForeColor = System.Drawing.Color.White
        Me.button3.CheckedImage = CType(resources.GetObject("button3.CheckedImage"), System.Drawing.Image)
        Me.button3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.button3.FocusedColor = System.Drawing.Color.Empty
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.ImageSize = New System.Drawing.Size(35, 35)
        Me.button3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button3.Location = New System.Drawing.Point(584, 507)
        Me.button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button3.Name = "button3"
        Me.button3.OnHoverBaseColor = System.Drawing.Color.Red
        Me.button3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button3.OnHoverForeColor = System.Drawing.Color.White
        Me.button3.OnHoverImage = Nothing
        Me.button3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.button3.OnPressedColor = System.Drawing.Color.Black
        Me.button3.Radius = 20
        Me.button3.Size = New System.Drawing.Size(520, 70)
        Me.button3.TabIndex = 9
        Me.button3.Text = "TREINOS"
        Me.button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.DarkGray
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.BorderSize = 2
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 7.75!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(815, 594)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Red
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.RosyBrown
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(69, 64)
        Me.GunaCircleButton1.TabIndex = 239
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(580, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 75)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "MENU FUNCIONÁRIO"
        '
        'Menu_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1685, 839)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.btn_cad_produtos)
        Me.Controls.Add(Me.btn_cad_alunos)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Menu_func"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cad_alunos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_cad_produtos As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents button3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
