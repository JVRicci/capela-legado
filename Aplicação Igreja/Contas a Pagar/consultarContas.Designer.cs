namespace Aplicação_Igreja.Contas_a_Pagar
{
    partial class consultarContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resgistrarMembButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.contasData = new System.Windows.Forms.DataGridView();
            this.selectColuna = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fornecedorTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriaCombo = new System.Windows.Forms.ComboBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.estadoCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.totalParcelas = new System.Windows.Forms.TextBox();
            this.parcelasRecebimento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pagamentoCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resgistrarMembButton
            // 
            this.resgistrarMembButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resgistrarMembButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resgistrarMembButton.Location = new System.Drawing.Point(629, 29);
            this.resgistrarMembButton.Name = "resgistrarMembButton";
            this.resgistrarMembButton.Size = new System.Drawing.Size(147, 23);
            this.resgistrarMembButton.TabIndex = 42;
            this.resgistrarMembButton.Text = "Registrar Conta";
            this.resgistrarMembButton.UseVisualStyleBackColor = false;
            this.resgistrarMembButton.Click += new System.EventHandler(this.resgistrarMembButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.estado);
            this.groupBox1.Controls.Add(this.resgistrarMembButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 70);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(288, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Listar Todos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(154, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // estado
            // 
            this.estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Em Aberto",
            "Vencido",
            "Pago"});
            this.estado.Location = new System.Drawing.Point(27, 30);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 24);
            this.estado.TabIndex = 3;
            // 
            // contasData
            // 
            this.contasData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contasData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColuna});
            this.contasData.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contasData.Location = new System.Drawing.Point(6, 88);
            this.contasData.Name = "contasData";
            this.contasData.Size = new System.Drawing.Size(782, 230);
            this.contasData.TabIndex = 32;
            this.contasData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contasData_CellContentClick);
            // 
            // selectColuna
            // 
            this.selectColuna.HeaderText = "Selecione";
            this.selectColuna.Name = "selectColuna";
            this.selectColuna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectColuna.Width = 60;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Cadastrante:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(157, 327);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(16, 18);
            this.nomeLabel.TabIndex = 46;
            this.nomeLabel.Text = "_";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Fornecedor";
            // 
            // fornecedorTxt
            // 
            this.fornecedorTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fornecedorTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorTxt.Location = new System.Drawing.Point(272, 99);
            this.fornecedorTxt.Name = "fornecedorTxt";
            this.fornecedorTxt.Size = new System.Drawing.Size(165, 24);
            this.fornecedorTxt.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Categoria";
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoriaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaCombo.FormattingEnabled = true;
            this.categoriaCombo.Items.AddRange(new object[] {
            "Unico",
            "Mensal",
            "Anual"});
            this.categoriaCombo.Location = new System.Drawing.Point(129, 99);
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.Size = new System.Drawing.Size(121, 24);
            this.categoriaCombo.TabIndex = 79;
            this.categoriaCombo.SelectedIndexChanged += new System.EventHandler(this.categoriaCombo_SelectedIndexChanged);
            this.categoriaCombo.TextChanged += new System.EventHandler(this.categoriaCombo_TextChanged);
            this.categoriaCombo.Leave += new System.EventHandler(this.categoriaCombo_Leave);
            // 
            // valorTextBox
            // 
            this.valorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(25, 96);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(95, 24);
            this.valorTextBox.TabIndex = 78;
            this.valorTextBox.TextChanged += new System.EventHandler(this.valorTextBox_TextChanged);
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Valor:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 76;
            this.label13.Text = "Descrição";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descricaoTxt.Enabled = false;
            this.descricaoTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(98, 44);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(164, 24);
            this.descricaoTxt.TabIndex = 75;
            // 
            // dataPagamento
            // 
            this.dataPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPagamento.CustomFormat = "dd-MM-yyyy";
            this.dataPagamento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPagamento.Location = new System.Drawing.Point(271, 44);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(75, 24);
            this.dataPagamento.TabIndex = 73;
            // 
            // dataVencimento
            // 
            this.dataVencimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataVencimento.CustomFormat = "dd-MM-yyyy";
            this.dataVencimento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataVencimento.Location = new System.Drawing.Point(362, 44);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(75, 24);
            this.dataVencimento.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(456, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 70;
            this.label16.Text = "Estado";
            // 
            // estadoCombo
            // 
            this.estadoCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estadoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCombo.FormattingEnabled = true;
            this.estadoCombo.Items.AddRange(new object[] {
            "Em Aberto",
            "Vencido",
            "Pago"});
            this.estadoCombo.Location = new System.Drawing.Point(459, 99);
            this.estadoCombo.Name = "estadoCombo";
            this.estadoCombo.Size = new System.Drawing.Size(93, 24);
            this.estadoCombo.TabIndex = 69;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(189, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 91;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(581, 499);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 100;
            this.button5.Text = "Remover";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // totalParcelas
            // 
            this.totalParcelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalParcelas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalParcelas.Location = new System.Drawing.Point(575, 99);
            this.totalParcelas.Name = "totalParcelas";
            this.totalParcelas.Size = new System.Drawing.Size(62, 24);
            this.totalParcelas.TabIndex = 99;
            this.totalParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalParcelas_KeyPress);
            this.totalParcelas.Leave += new System.EventHandler(this.totalParcelas_Leave);
            // 
            // parcelasRecebimento
            // 
            this.parcelasRecebimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parcelasRecebimento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelasRecebimento.Location = new System.Drawing.Point(575, 44);
            this.parcelasRecebimento.Name = "parcelasRecebimento";
            this.parcelasRecebimento.Size = new System.Drawing.Size(60, 24);
            this.parcelasRecebimento.TabIndex = 98;
            this.parcelasRecebimento.TextChanged += new System.EventHandler(this.valorTextBox_TextChanged);
            this.parcelasRecebimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Parcelas Total";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 95;
            this.label8.Text = "Parcelas Pagas";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(454, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 93;
            this.label11.Text = " Pagamento";
            // 
            // pagamentoCombo
            // 
            this.pagamentoCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagamentoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagamentoCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagamentoCombo.FormattingEnabled = true;
            this.pagamentoCombo.Items.AddRange(new object[] {
            "Cartão",
            "Boleto",
            "Dinheiro"});
            this.pagamentoCombo.Location = new System.Drawing.Point(459, 44);
            this.pagamentoCombo.Name = "pagamentoCombo";
            this.pagamentoCombo.Size = new System.Drawing.Size(93, 24);
            this.pagamentoCombo.TabIndex = 92;
            this.pagamentoCombo.Leave += new System.EventHandler(this.pagamentoCombo_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 102;
            this.label1.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTxt.Enabled = false;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(29, 44);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(52, 24);
            this.idTxt.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "Entrada";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 104;
            this.label5.Text = "Vencimento";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.idTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataPagamento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataVencimento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.valorTextBox);
            this.groupBox2.Controls.Add(this.estadoCombo);
            this.groupBox2.Controls.Add(this.totalParcelas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.categoriaCombo);
            this.groupBox2.Controls.Add(this.parcelasRecebimento);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.fornecedorTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pagamentoCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.descricaoTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(82, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 136);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Conta";
            // 
            // consultarContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contasData);
            this.Controls.Add(this.button4);
            this.Name = "consultarContas";
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.consultarContas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resgistrarMembButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView contasData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.DataGridViewButtonColumn selectColuna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fornecedorTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoriaCombo;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.DateTimePicker dataPagamento;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox estadoCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox totalParcelas;
        private System.Windows.Forms.TextBox parcelasRecebimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox pagamentoCombo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}