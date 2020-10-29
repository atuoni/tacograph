<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TBValorX = New System.Windows.Forms.TextBox()
        Me.TBValorY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBResultado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBescala = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEnter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBVinicial = New System.Windows.Forms.ComboBox()
        Me.TBFinal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBdesloc = New System.Windows.Forms.TextBox()
        Me.CHBdesloc = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBVEnsaio = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBAprovado = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBValorX
        '
        Me.TBValorX.AcceptsTab = True
        Me.TBValorX.Location = New System.Drawing.Point(149, 45)
        Me.TBValorX.Name = "TBValorX"
        Me.TBValorX.Size = New System.Drawing.Size(105, 22)
        Me.TBValorX.TabIndex = 0
        '
        'TBValorY
        '
        Me.TBValorY.Location = New System.Drawing.Point(149, 93)
        Me.TBValorY.Name = "TBValorY"
        Me.TBValorY.Size = New System.Drawing.Size(105, 22)
        Me.TBValorY.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor X"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor Y"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Escala"
        '
        'TBResultado
        '
        Me.TBResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBResultado.CausesValidation = False
        Me.TBResultado.Cursor = System.Windows.Forms.Cursors.No
        Me.TBResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TBResultado.Location = New System.Drawing.Point(174, 42)
        Me.TBResultado.Name = "TBResultado"
        Me.TBResultado.ReadOnly = True
        Me.TBResultado.Size = New System.Drawing.Size(105, 28)
        Me.TBResultado.TabIndex = 6
        Me.TBResultado.TabStop = False
        Me.TBResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Valor Lido"
        '
        'CBescala
        '
        Me.CBescala.FormattingEnabled = True
        Me.CBescala.Items.AddRange(New Object() {"10", "20"})
        Me.CBescala.Location = New System.Drawing.Point(94, 32)
        Me.CBescala.Name = "CBescala"
        Me.CBescala.Size = New System.Drawing.Size(133, 24)
        Me.CBescala.Sorted = True
        Me.CBescala.TabIndex = 8
        Me.CBescala.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Valor Inicial"
        '
        'TBEnter
        '
        Me.TBEnter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TBEnter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBEnter.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TBEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEnter.ForeColor = System.Drawing.Color.Red
        Me.TBEnter.Location = New System.Drawing.Point(202, 429)
        Me.TBEnter.Name = "TBEnter"
        Me.TBEnter.ReadOnly = True
        Me.TBEnter.Size = New System.Drawing.Size(261, 27)
        Me.TBEnter.TabIndex = 11
        Me.TBEnter.TabStop = False
        Me.TBEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Velocidade Final (km/h)"
        '
        'CBVinicial
        '
        Me.CBVinicial.FormattingEnabled = True
        Me.CBVinicial.Items.AddRange(New Object() {"0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120"})
        Me.CBVinicial.Location = New System.Drawing.Point(369, 33)
        Me.CBVinicial.Name = "CBVinicial"
        Me.CBVinicial.Size = New System.Drawing.Size(135, 24)
        Me.CBVinicial.TabIndex = 13
        Me.CBVinicial.TabStop = False
        '
        'TBFinal
        '
        Me.TBFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFinal.Location = New System.Drawing.Point(174, 82)
        Me.TBFinal.Name = "TBFinal"
        Me.TBFinal.ReadOnly = True
        Me.TBFinal.Size = New System.Drawing.Size(105, 34)
        Me.TBFinal.TabIndex = 18
        Me.TBFinal.TabStop = False
        Me.TBFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBescala)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CBVinicial)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 77)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Iniciais"
        '
        'TBdesloc
        '
        Me.TBdesloc.Location = New System.Drawing.Point(286, 61)
        Me.TBdesloc.Name = "TBdesloc"
        Me.TBdesloc.Size = New System.Drawing.Size(100, 22)
        Me.TBdesloc.TabIndex = 15
        Me.TBdesloc.Text = "0"
        Me.TBdesloc.Visible = False
        '
        'CHBdesloc
        '
        Me.CHBdesloc.AutoSize = True
        Me.CHBdesloc.Location = New System.Drawing.Point(314, 24)
        Me.CHBdesloc.Name = "CHBdesloc"
        Me.CHBdesloc.Size = New System.Drawing.Size(53, 21)
        Me.CHBdesloc.TabIndex = 14
        Me.CHBdesloc.TabStop = False
        Me.CHBdesloc.Text = "SIM"
        Me.CHBdesloc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tem deslocamento no disco?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Valor do Deslocamento"
        Me.Label8.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBdesloc)
        Me.GroupBox2.Controls.Add(Me.CHBdesloc)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 99)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deslocamentos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TBVEnsaio)
        Me.GroupBox3.Controls.Add(Me.TBValorX)
        Me.GroupBox3.Controls.Add(Me.TBValorY)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(39, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 190)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entrar com Valores Lidos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "V.max Ensaio (km/h)"
        '
        'TBVEnsaio
        '
        Me.TBVEnsaio.Location = New System.Drawing.Point(149, 143)
        Me.TBVEnsaio.Name = "TBVEnsaio"
        Me.TBVEnsaio.Size = New System.Drawing.Size(105, 22)
        Me.TBVEnsaio.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TBAprovado)
        Me.GroupBox4.Controls.Add(Me.TBFinal)
        Me.GroupBox4.Controls.Add(Me.TBResultado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(341, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 190)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultado Final"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Aprovação do Ensaio"
        '
        'TBAprovado
        '
        Me.TBAprovado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBAprovado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAprovado.Location = New System.Drawing.Point(174, 129)
        Me.TBAprovado.Name = "TBAprovado"
        Me.TBAprovado.ReadOnly = True
        Me.TBAprovado.Size = New System.Drawing.Size(106, 38)
        Me.TBAprovado.TabIndex = 19
        Me.TBAprovado.TabStop = False
        Me.TBAprovado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(676, 465)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBEnter)
        Me.Name = "Form1"
        Me.Text = "Leitura Tacógrafo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBValorY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBResultado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBValorX As TextBox

    Private Sub TBValorX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBValorX.KeyPress 'Verifica se o evento alguma tecla foi pressionada
        'TBdesloc.Text = "0"
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 Then  'Verifica se a tecla pressionada nao é um numero ou ENTER ou BACKSPACE
            MsgBox("Valor não numerico", MsgBoxStyle.Exclamation, "Erro")  'Caixa de mensagem de erro
            e.Handled = True
            e.KeyChar = ""                                                 'Não retorna nenhum caracter 

        End If

        If Asc(e.KeyChar) = 13 AndAlso TBValorX.Text <> "" Then     'Verifica se o ENTER foi pressionado
            TBValorY.Focus()                         'Muda o foco para caixa de texto Valor Y
            e.Handled = True
        End If

    End Sub     ' Fim do evento

    Private Sub TBValorY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBValorY.KeyPress  'Verifica se o evento alguma tecla foi pressionada
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 Then    'Verifica se a tecla pressionada é um numero ou ENTER ou BACKSPACE
            MsgBox("Valor não numerico", MsgBoxStyle.Exclamation, "Erro")   ' aciona a Caixa de mensagem de erro
            e.KeyChar = ""                                                   'Não retorna nenhum caracter 
        End If

        If Asc(e.KeyChar) = 13 AndAlso TBValorY.Text <> "" Then           'Verifica se o ENTER foi pressionado
            TBVEnsaio.Focus()                                             'Muda o foco para caixa de texto Valor Ensaio
            e.Handled = True
        End If
    End Sub  'Fim do evento


    Friend WithEvents CBescala As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEnter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBVinicial As ComboBox

    Private Sub CHBdesloc_CheckedChanged(sender As Object, e As EventArgs) Handles CHBdesloc.CheckedChanged  'Verifica se o evento CheckBox mudou de estado
        TBdesloc.Clear()   'Limpa a caixa de texto deslocamento

        If CHBdesloc.CheckState = 1 Then          ' Se o checkbox estiver acionado
            TBdesloc.Visible = True               'Torna a caixa de texto deslocamento visivel
            Label8.Visible = True                 'Torna o label "valor de deslocamento" visivel
            TBdesloc.Focus()                      'Muda o foca para a caixa valor de deslocamento
        Else
            TBdesloc.Visible = False              'Se o checkbox estiver não acionado
            Label8.Visible = False                'Torna a caixa de texto deslocamento invisivel
            TBdesloc.Text = "0"                   'Inicializa o valor de deslocamento igual a 0 para não influenciar no calculo
            TBValorX.Focus()                      'Muda o foco para a caixa de texto Valor X
        End If
    End Sub                                      'Fim do evento

    Private Sub TBEnter_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TBEnter.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TBValorX.Focus()
            TBValorX.Clear()
            TBValorY.Clear()
            TBResultado.Clear()
            TBFinal.Clear()
            TBVEnsaio.Clear()
            TBAprovado.Clear()
            TBEnter.Clear()
            TBResultado.BackColor = Color.LightGray
            TBAprovado.BackColor = Color.LightGray
            e.Handled = True
        End If
    End Sub
    Friend WithEvents TBFinal As TextBox

    Private Sub TBdesloc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBdesloc.KeyPress 'Verifica se alguma tecla foi pressionada na caixa valor de deslocamento

        If Asc(e.KeyChar) = 13 Then                 ' se o ENTER foi pressionado
            TBValorX.Focus()                        'Muda o foco para a caixa de texto ValorX
            TBValorX.Clear()                        'Limpa a caixa de texto ValorX
            TBValorY.Clear()                        'Limpa a caixa de texto ValorY
            TBVEnsaio.Clear()                       'Limpa a caixa de texto Velocidade de Ensaio
            TBResultado.Clear()                     'Limpa a caixa de texto Valor lido
            TBAprovado.Clear()                      'Limpa a caixa Aprovação do Ensaio
            TBFinal.Clear()                         'Limpa a caixa Velocidade Final
            TBEnter.Clear()                         'Limpa a caixa Pressione Enter
            TBResultado.BackColor = Color.LightGray 'Muda a cor de fundo da caixa de texto Valor lido para Cinza Claro
        End If
    End Sub                                          'Fim do evento
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBdesloc As TextBox
    Friend WithEvents CHBdesloc As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TBVEnsaio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBAprovado As TextBox
    Friend WithEvents Label10 As Label

    Private Sub TBVEnsaio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBVEnsaio.KeyPress    'Verifica se alguma tecla foi pressionada na caixa de texto velocidade de ensaio
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 44 Then  'Verifica se a tecla pressionada é um numero ou ENTER ou BACKSPACE ou "."
            MsgBox("Valor não numerico", MsgBoxStyle.Exclamation, "Erro")   ' aciona a Caixa de mensagem de erro
            e.KeyChar = ""                                                 'não retorna nenhum caracter para a caixa de texto
        End If

        If Asc(e.KeyChar) = 13 AndAlso TBVEnsaio.Text <> "" Then        ' Se a tecla enter for pressionada e caixa de texto não estiver vazia
            Dim valorX As Integer                                   'cria a variavel valorx do tipo inteiro
            Dim valorY As Integer                     'cria a variavel valory do tipo inteiro
            Dim vensaio As Double           'cria a variavel vensaio do tipo decimal
            Dim vlido As Double             'cria a variavel vlido do tipo decimal
            Dim escala As Integer            'cria a variavel escala do tipo inteiro
            Dim deslocamento As Integer      'cria a variavel deslocamento do tipo inteiro
            Dim vfinal As Double             'cria a variavel vfinal do tipo decimal
            Dim vinicial As Integer          'cria a variavel vinicial do tipo inteiro
            Dim vdiferenca As Double          'cria a variavel vdiferenca do tipo decimal
            Dim flaginicial As Boolean = True     'cria a variavel flaginicial do tipo Booleana igual a True


            Try
                valorX = Integer.Parse(TBValorX.Text)  'Copia o dado da caixa de texto para a variavel
            Catch ex As Exception                      'Trata exceção      
                MsgBox("Sem o valor de X", MsgBoxStyle.Exclamation, "Erro")  'Caixa de Texto de Erro
                e.Handled = True
            End Try
            Try
                valorY = Integer.Parse(TBValorY.Text)  'Copia o dado da caixa de texto para a variavel
            Catch ex As Exception                      'Trata exceção  
                MsgBox("Sem o valor de Y", MsgBoxStyle.Exclamation, "Erro")  'Caixa de Texto de Erro
                e.Handled = True
            End Try

            Try
                vensaio = Double.Parse(TBVEnsaio.Text)   'Copia o dado da caixa de texto para a variavel
            Catch ex As Exception
                MsgBox("Sem o valor de Ensaio", MsgBoxStyle.Exclamation, "Erro")  'Caixa de Texto de Erro
                e.Handled = True
            End Try
            Try
                deslocamento = Integer.Parse(TBdesloc.Text)   'Copia o dado da caixa de texto para a variavel
            Catch ex As Exception
                MsgBox("Sem o valor de Deslocamento", MsgBoxStyle.Exclamation, "Erro")   'Caixa de Texto de Erro
                e.Handled = True
            End Try
            Try
                vinicial = Integer.Parse(CBVinicial.Text)  'Copia o dado da caixa de texto para a variavel
            Catch ex As Exception
                MsgBox("Atenção - Valor inicial não fornecido !!", MsgBoxStyle.Exclamation, "Erro")  'Caixa de Texto de Erro
                flaginicial = False
                e.Handled = True
            End Try


            TBEnter.Focus()  ' Coloca o foco na caixa de texto pressione enter
            e.Handled = True


            Select Case CBescala.Text      'Verifica a selecão do combobox escala

                Case "10"                  'caso seja selecionado o valor 10
                    escala = 10             'atribui 10 para a escala
                    valorX = valorX - deslocamento    'calcula o valorx compensando o deslocamento
                    Try
                        vlido = (escala * valorX) / valorY     'calcula o vlido 
                        vfinal = vlido + vinicial              'calcula o vfinal somando o valor lido com o valor inicial de 10
                    Catch ex As OverflowException
                        MsgBox("Valor excedeu o limite", MsgBoxStyle.Exclamation, "Erro")
                        flaginicial = False
                        e.Handled = True
                    End Try

                    TBResultado.Text = FormatNumber(vlido, 2)  'transforma o vlido com duas casas decimais e atribui para a caixa de texto Valor Lido
                    TBResultado.BackColor = Color.LightGray
                    TBFinal.Text = FormatNumber(vfinal, 2)       'transforma o vfinal com duas casas decimais e atribui para a caixa de texto Velocidade Final
                    If flaginicial = False Then             'se o flaginicial igual falso quer dizer um valor inicial nao foi selecionado
                        TBFinal.Text = "--"                  'apresenta --  na caixa de texto "velocidade final"
                    Else                                     ' se flaginicial igual true quer dizer um velocidade inicial foi selecionada
                        TBFinal.Text = FormatNumber(vfinal, 2)   'transforma o vfinal com duas casas decimais e atribui para a caixa de texto Velocidade Final
                    End If
                    vdiferenca = vensaio - vfinal       'calcula a diferenca entre o valor de ensaio e a velocidade final
                    vdiferenca = Math.Abs(vdiferenca)     ' calcula o valor absoluto da diferença
                    If flaginicial = True Then          'se o foi selecionada uma velocidade inicial
                        If vdiferenca > 4.0 Then              'e se a diferença entre vensaio - vfinal > 4
                            TBAprovado.Text = FormatNumber(vdiferenca, 2) 'transforma vdiferença com duas casas decimais e atribui para a caixa de Aprovação do Ensaio
                            TBAprovado.BackColor = Color.Red      'coloca o fundo da caixa de texto ensaio aprovado em vermelho
                        Else                                      'caso a diferença for <4
                            TBAprovado.Text = FormatNumber(vdiferenca, 2)     'transforma vdiferença com duas casas decimais e atribui para a caixa de aprovação do ensaio
                            TBAprovado.BackColor = Color.LimeGreen           'coloca o funda da caixa de texto ensaio aprovado em verde
                        End If
                    Else                                               'se não for selecionada uma velocidade inicial
                        TBAprovado.Text = "--"                         'apresenta -- na caixa de texto Ensaio aprovado    
                    End If

                    TBEnter.Text = "Pressione Enter"                    'apos a apresentação do resultado apresenta o texto pressione enter na caixa de texto enter

                Case "20"                                     'caso seja selecionado o valor 10
                    escala = 20                        'atribui 10 para a escala
                    valorX = valorX - deslocamento       'calcula o valorx compensando o deslocamento
                    Try
                        vlido = (escala * valorX) / valorY             'calcula o vlido 
                        vfinal = vlido + vinicial                     'calcula o vfinal somando o valor lido com o valor inicial de 10
                    Catch ex As OverflowException
                        MsgBox("Valor excedeu o limite", MsgBoxStyle.Exclamation, "Erro")
                        flaginicial = False
                        e.Handled = True
                    End Try
                    TBResultado.Text = FormatNumber(vlido, 2)         'transforma o vlido com duas casas decimais e atribui para a caixa de texto Valor Lido
                    'TBResultado.Text = result.ToString          
                    TBResultado.BackColor = Color.LightGray
                    If flaginicial = False Then        'se o flaginicial igual falso quer dizer um valor inicial nao foi selecionado
                        TBFinal.Text = "--"           'apresenta --  na caixa de texto "velocidade final"
                    Else                                 ' se flaginicial igual true quer dizer um velocidade inicial foi selecionada
                        TBFinal.Text = FormatNumber(vfinal, 2)   'transforma o vfinal com duas casas decimais e atribui para a caixa de texto Velocidade Final
                    End If


                    vdiferenca = vensaio - vfinal    'calcula a diferenca entre o valor de ensaio e a velocidade final
                    vdiferenca = Math.Abs(vdiferenca)   ' calcula o valor absoluto da diferença
                    If flaginicial = True Then       'se o foi selecionada uma velocidade inicial
                        If vdiferenca > 4.0 Then        'e se a diferença entre vensaio - vfinal > 4
                            TBAprovado.Text = FormatNumber(vdiferenca, 2)   'transforma vdiferença com duas casas decimais e atribui para a caixa de Aprovação do Ensaio
                            TBAprovado.BackColor = Color.Red        'coloca o fundo da caixa de texto ensaio aprovado em vermelho
                        Else                         'caso a diferença for <4
                            TBAprovado.Text = FormatNumber(vdiferenca, 2)    'transforma vdiferença com duas casas decimais e atribui para a caixa de aprovação do ensaio
                            TBAprovado.BackColor = Color.LimeGreen    'coloca o funda da caixa de texto ensaio aprovado em verde
                        End If
                    Else                       'se não for selecionada uma velocidade inicial
                        TBAprovado.Text = "--"   'apresenta -- na caixa de texto Ensaio aprovado  
                    End If
                    TBEnter.Text = "Pressione Enter"    'apos a apresentação do resultado apresenta o texto pressione enter na caixa de texto enter

                Case Else     'caso nenhuma escala for selecionada
                    MsgBox("A escala não foi selecionada", MsgBoxStyle.Exclamation, "Erro")  'apresenta a caixa de texto de erro
                    TBResultado.Text = "Sem escala"   ' apresenta o texto Sem escala na caixa de texto valor lido
                    TBResultado.BackColor = Color.LightGray   'seleciona a cor cinza claro no fundo da caixa valor lido
                    TBEnter.Text = "Pressione Enter" 'apresenta o texto pressione enter na caixa de texto
            End Select  'fim do select
        End If
    End Sub   'fim do evento

    Private Sub CBescala_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBescala.SelectionChangeCommitted  'verifica se algum valor na caixa de seleção da escala foi selecionada
        TBValorX.Focus()  'coloca o foco para caixa de texto valor X
        TBValorX.Clear()   'limpa a caixa valor X
        TBValorY.Clear()    'limpa a caixa valor Y
        TBdesloc.Text = "0"  'Inicializa o valor de deslocamento igual a 0 para não influenciar no calculo
        TBVEnsaio.Clear()    'limpa a caixa velocidade de ensaio
        TBResultado.Clear()   'limpa a caixa de texto valor lido
        TBAprovado.Clear()     'limpa a caixa de texto ensaio aprovado
        TBFinal.Clear()    'limpa a caixa de texto velocidade final
        TBEnter.Clear()    'limpa a caixa de texto pressione enter
    End Sub  ' fim do evento

    Private Sub CBVinicial_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBVinicial.SelectionChangeCommitted   'verifica se algum valor na caixa de seleção velocidade inicial foi selecionada
        TBValorX.Focus()  'coloca o foco na caixa de texto valorX 
    End Sub  'fim do evento
End Class  'fim da classe
