<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class treino
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_treino = New System.Windows.Forms.DataGridView()
        Me.DIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEITO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ABDOMEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BICEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OMBRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRICEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUADRICEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANTURRILHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLUTEO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AEROBICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_treino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_treino
        '
        Me.dgv_treino.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_treino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_treino.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DIA, Me.COSTAS, Me.PEITO, Me.ABDOMEN, Me.BICEPS, Me.OMBRO, Me.TRICEPS, Me.QUADRICEPS, Me.PANTURRILHA, Me.GLUTEO, Me.AEROBICO})
        Me.dgv_treino.Location = New System.Drawing.Point(0, 0)
        Me.dgv_treino.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_treino.Name = "dgv_treino"
        Me.dgv_treino.RowHeadersWidth = 62
        Me.dgv_treino.RowTemplate.Height = 28
        Me.dgv_treino.Size = New System.Drawing.Size(1011, 657)
        Me.dgv_treino.TabIndex = 1
        '
        'DIA
        '
        Me.DIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Clarendon Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DIA.DefaultCellStyle = DataGridViewCellStyle1
        Me.DIA.HeaderText = "DIA"
        Me.DIA.MinimumWidth = 100
        Me.DIA.Name = "DIA"
        '
        'COSTAS
        '
        Me.COSTAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COSTAS.DefaultCellStyle = DataGridViewCellStyle2
        Me.COSTAS.HeaderText = "COSTAS"
        Me.COSTAS.MinimumWidth = 100
        Me.COSTAS.Name = "COSTAS"
        '
        'PEITO
        '
        Me.PEITO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PEITO.DefaultCellStyle = DataGridViewCellStyle3
        Me.PEITO.HeaderText = "PEITO"
        Me.PEITO.MinimumWidth = 8
        Me.PEITO.Name = "PEITO"
        Me.PEITO.Width = 64
        '
        'ABDOMEN
        '
        Me.ABDOMEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ABDOMEN.DefaultCellStyle = DataGridViewCellStyle4
        Me.ABDOMEN.HeaderText = "ABDOMEN"
        Me.ABDOMEN.MinimumWidth = 8
        Me.ABDOMEN.Name = "ABDOMEN"
        Me.ABDOMEN.Width = 86
        '
        'BICEPS
        '
        Me.BICEPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BICEPS.DefaultCellStyle = DataGridViewCellStyle5
        Me.BICEPS.HeaderText = "BICEPS"
        Me.BICEPS.MinimumWidth = 8
        Me.BICEPS.Name = "BICEPS"
        Me.BICEPS.Width = 70
        '
        'OMBRO
        '
        Me.OMBRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OMBRO.DefaultCellStyle = DataGridViewCellStyle6
        Me.OMBRO.HeaderText = "OMBRO"
        Me.OMBRO.MinimumWidth = 8
        Me.OMBRO.Name = "OMBRO"
        Me.OMBRO.Width = 72
        '
        'TRICEPS
        '
        Me.TRICEPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TRICEPS.DefaultCellStyle = DataGridViewCellStyle7
        Me.TRICEPS.HeaderText = "TRICEPS"
        Me.TRICEPS.MinimumWidth = 8
        Me.TRICEPS.Name = "TRICEPS"
        Me.TRICEPS.Width = 78
        '
        'QUADRICEPS
        '
        Me.QUADRICEPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QUADRICEPS.DefaultCellStyle = DataGridViewCellStyle8
        Me.QUADRICEPS.HeaderText = "QUADRICEPS"
        Me.QUADRICEPS.MinimumWidth = 100
        Me.QUADRICEPS.Name = "QUADRICEPS"
        Me.QUADRICEPS.Width = 102
        '
        'PANTURRILHA
        '
        Me.PANTURRILHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PANTURRILHA.DefaultCellStyle = DataGridViewCellStyle9
        Me.PANTURRILHA.HeaderText = "PANTURRILHA"
        Me.PANTURRILHA.MinimumWidth = 100
        Me.PANTURRILHA.Name = "PANTURRILHA"
        Me.PANTURRILHA.Width = 109
        '
        'GLUTEO
        '
        Me.GLUTEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GLUTEO.DefaultCellStyle = DataGridViewCellStyle10
        Me.GLUTEO.HeaderText = "GLUTEO"
        Me.GLUTEO.MinimumWidth = 8
        Me.GLUTEO.Name = "GLUTEO"
        Me.GLUTEO.Width = 76
        '
        'AEROBICO
        '
        Me.AEROBICO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Clarendon Blk BT", 14.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AEROBICO.DefaultCellStyle = DataGridViewCellStyle11
        Me.AEROBICO.HeaderText = "AEROBICO"
        Me.AEROBICO.MinimumWidth = 8
        Me.AEROBICO.Name = "AEROBICO"
        Me.AEROBICO.Width = 87
        '
        'treino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 657)
        Me.Controls.Add(Me.dgv_treino)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "treino"
        Me.Text = "treino"
        CType(Me.dgv_treino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_treino As DataGridView
    Friend WithEvents DIA As DataGridViewTextBoxColumn
    Friend WithEvents COSTAS As DataGridViewTextBoxColumn
    Friend WithEvents PEITO As DataGridViewTextBoxColumn
    Friend WithEvents ABDOMEN As DataGridViewTextBoxColumn
    Friend WithEvents BICEPS As DataGridViewTextBoxColumn
    Friend WithEvents OMBRO As DataGridViewTextBoxColumn
    Friend WithEvents TRICEPS As DataGridViewTextBoxColumn
    Friend WithEvents QUADRICEPS As DataGridViewTextBoxColumn
    Friend WithEvents PANTURRILHA As DataGridViewTextBoxColumn
    Friend WithEvents GLUTEO As DataGridViewTextBoxColumn
    Friend WithEvents AEROBICO As DataGridViewTextBoxColumn
End Class
