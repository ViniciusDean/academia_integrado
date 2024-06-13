<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.USUÁRIO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_senha = New System.Windows.Forms.LinkLabel()
        Me.chk_visualizar = New System.Windows.Forms.CheckBox()
        Me.btn_aluno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.Image = CType(resources.GetObject("btn_entrar.Image"), System.Drawing.Image)
        Me.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_entrar.Location = New System.Drawing.Point(284, 398)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(232, 52)
        Me.btn_entrar.TabIndex = 0
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(233, 218)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(331, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'USUÁRIO
        '
        Me.USUÁRIO.AutoSize = True
        Me.USUÁRIO.BackColor = System.Drawing.Color.Transparent
        Me.USUÁRIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.USUÁRIO.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.USUÁRIO.Location = New System.Drawing.Point(228, 185)
        Me.USUÁRIO.Name = "USUÁRIO"
        Me.USUÁRIO.Size = New System.Drawing.Size(79, 25)
        Me.USUÁRIO.TabIndex = 2
        Me.USUÁRIO.Text = "Usuário"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(340, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(228, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(233, 297)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(331, 22)
        Me.txt_senha.TabIndex = 5
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.LinkColor = System.Drawing.Color.Lime
        Me.lbl_senha.Location = New System.Drawing.Point(323, 453)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(149, 17)
        Me.lbl_senha.TabIndex = 7
        Me.lbl_senha.TabStop = True
        Me.lbl_senha.Text = "Esqueceu sua senha?"
        '
        'chk_visualizar
        '
        Me.chk_visualizar.AutoSize = True
        Me.chk_visualizar.BackColor = System.Drawing.Color.Transparent
        Me.chk_visualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk_visualizar.Image = CType(resources.GetObject("chk_visualizar.Image"), System.Drawing.Image)
        Me.chk_visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_visualizar.Location = New System.Drawing.Point(233, 327)
        Me.chk_visualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_visualizar.Name = "chk_visualizar"
        Me.chk_visualizar.Size = New System.Drawing.Size(152, 24)
        Me.chk_visualizar.TabIndex = 8
        Me.chk_visualizar.Text = "Vizualizar Senha"
        Me.chk_visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_visualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chk_visualizar.UseVisualStyleBackColor = False
        '
        'btn_aluno
        '
        Me.btn_aluno.BackColor = System.Drawing.Color.Transparent
        Me.btn_aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aluno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_aluno.Image = CType(resources.GetObject("btn_aluno.Image"), System.Drawing.Image)
        Me.btn_aluno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aluno.Location = New System.Drawing.Point(289, 565)
        Me.btn_aluno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_aluno.Name = "btn_aluno"
        Me.btn_aluno.Size = New System.Drawing.Size(227, 50)
        Me.btn_aluno.TabIndex = 0
        Me.btn_aluno.Text = "Acesso Aluno"
        Me.btn_aluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aluno.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(779, 647)
        Me.Controls.Add(Me.btn_aluno)
        Me.Controls.Add(Me.chk_visualizar)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USUÁRIO)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.btn_entrar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_entrar As Button
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents USUÁRIO As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents lbl_senha As LinkLabel
    Friend WithEvents chk_visualizar As CheckBox
    Friend WithEvents btn_aluno As Button
End Class
