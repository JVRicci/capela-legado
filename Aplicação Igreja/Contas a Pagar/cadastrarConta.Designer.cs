namespace Aplicação_Igreja.Contas_a_Pagar
{
    partial class cadastrarConta
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
            this.label3 = new System.Windows.Forms.Label();
            this.estadoCombo = new System.Windows.Forms.ComboBox();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriaCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fornecedorTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.responsavelTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cadastranteTxt = new System.Windows.Forms.TextBox();
            this.userData = new System.Windows.Forms.DataGridView();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pagamentoCombo = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userData)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // estadoCombo
            // 
            this.estadoCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.estadoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCombo.FormattingEnabled = true;
            this.estadoCombo.Items.AddRange(new object[] {
            "Aberto",
            "Vencid",
            "Pago"});
            this.estadoCombo.Location = new System.Drawing.Point(305, 190);
            this.estadoCombo.Name = "estadoCombo";
            this.estadoCombo.Size = new System.Drawing.Size(97, 22);
            this.estadoCombo.TabIndex = 5;
            // 
            // dataVencimento
            // 
            this.dataVencimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataVencimento.CustomFormat = "dd-MM-yyyy";
            this.dataVencimento.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataVencimento.Location = new System.Drawing.Point(305, 72);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(75, 21);
            this.dataVencimento.TabIndex = 46;
            this.dataVencimento.Value = new System.DateTime(2019, 11, 10, 15, 41, 0, 0);
            this.dataVencimento.ValueChanged += new System.EventHandler(this.dataVencimento_ValueChanged);
            this.dataVencimento.Leave += new System.EventHandler(this.dataVencimento_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 47;
            this.label1.Text = "Vencimento";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 49;
            this.label2.Text = "Pagamento";
            // 
            // dataPagamento
            // 
            this.dataPagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataPagamento.CustomFormat = "dd-MM-yyyy";
            this.dataPagamento.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataPagamento.Location = new System.Drawing.Point(305, 33);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(75, 21);
            this.dataPagamento.TabIndex = 48;
            this.dataPagamento.ValueChanged += new System.EventHandler(this.dataPagamento_ValueChanged);
            this.dataPagamento.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.dateTimePicker1_ControlRemoved);
            this.dataPagamento.Leave += new System.EventHandler(this.dataRecebimento_Leave);
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(50, 33);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(241, 21);
            this.descricaoTxt.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Descrição";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTextBox.Location = new System.Drawing.Point(50, 72);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(86, 21);
            this.valorTextBox.TabIndex = 53;
            this.valorTextBox.TextChanged += new System.EventHandler(this.valorTextBox_TextChanged);
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 52;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "Categoria";
            // 
            // categoriaCombo
            // 
            this.categoriaCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoriaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaCombo.FormattingEnabled = true;
            this.categoriaCombo.Items.AddRange(new object[] {
            "Unico",
            "Mensal",
            "Anual"});
            this.categoriaCombo.Location = new System.Drawing.Point(161, 72);
            this.categoriaCombo.Name = "categoriaCombo";
            this.categoriaCombo.Size = new System.Drawing.Size(121, 22);
            this.categoriaCombo.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fornecedor";
            // 
            // fornecedorTxt
            // 
            this.fornecedorTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorTxt.Location = new System.Drawing.Point(50, 113);
            this.fornecedorTxt.Name = "fornecedorTxt";
            this.fornecedorTxt.Size = new System.Drawing.Size(241, 21);
            this.fornecedorTxt.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 59;
            this.label8.Text = "Responsável";
            // 
            // responsavelTxt
            // 
            this.responsavelTxt.Enabled = false;
            this.responsavelTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsavelTxt.Location = new System.Drawing.Point(87, 190);
            this.responsavelTxt.Name = "responsavelTxt";
            this.responsavelTxt.Size = new System.Drawing.Size(208, 21);
            this.responsavelTxt.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 14);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cadastrante";
            // 
            // cadastranteTxt
            // 
            this.cadastranteTxt.Enabled = false;
            this.cadastranteTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastranteTxt.Location = new System.Drawing.Point(50, 152);
            this.cadastranteTxt.Name = "cadastranteTxt";
            this.cadastranteTxt.Size = new System.Drawing.Size(241, 21);
            this.cadastranteTxt.TabIndex = 60;
            // 
            // userData
            // 
            this.userData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.userData.Location = new System.Drawing.Point(50, 217);
            this.userData.Name = "userData";
            this.userData.ReadOnly = true;
            this.userData.Size = new System.Drawing.Size(352, 197);
            this.userData.TabIndex = 62;
            this.userData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userData_CellContentClick);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cadastrarButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarButton.Location = new System.Drawing.Point(196, 420);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.cadastrarButton.TabIndex = 63;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 14);
            this.label10.TabIndex = 66;
            this.label10.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(50, 190);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(31, 21);
            this.idTxt.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 14);
            this.label11.TabIndex = 68;
            this.label11.Text = "Forma de Pagamento";
            // 
            // pagamentoCombo
            // 
            this.pagamentoCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pagamentoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagamentoCombo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagamentoCombo.FormattingEnabled = true;
            this.pagamentoCombo.Items.AddRange(new object[] {
            "Cartão",
            "Boleto",
            "Dinheiro"});
            this.pagamentoCombo.Location = new System.Drawing.Point(305, 148);
            this.pagamentoCombo.Name = "pagamentoCombo";
            this.pagamentoCombo.Size = new System.Drawing.Size(97, 22);
            this.pagamentoCombo.TabIndex = 67;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selecao";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 60;
            // 
            // cadastrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(459, 455);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pagamentoCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.userData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cadastranteTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.responsavelTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fornecedorTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoriaCombo);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descricaoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoCombo);
            this.Name = "cadastrarConta";
            this.Text = "Cadastrar Conta";
            this.Load += new System.EventHandler(this.cadastrarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estadoCombo;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataPagamento;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoriaCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fornecedorTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox responsavelTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cadastranteTxt;
        private System.Windows.Forms.DataGridView userData;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox pagamentoCombo;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}