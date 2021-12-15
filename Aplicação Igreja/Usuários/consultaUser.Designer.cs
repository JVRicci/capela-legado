namespace Aplicação_Igreja.Usuários
{
    partial class consultaUser
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
            this.atualizaButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcaoCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sexoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ativoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userData = new System.Windows.Forms.DataGridView();
            this.selecao = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idLogin = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userData)).BeginInit();
            this.SuspendLayout();
            // 
            // atualizaButton
            // 
            this.atualizaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.atualizaButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.atualizaButton.Enabled = false;
            this.atualizaButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizaButton.Location = new System.Drawing.Point(369, 414);
            this.atualizaButton.Name = "atualizaButton";
            this.atualizaButton.Size = new System.Drawing.Size(75, 23);
            this.atualizaButton.TabIndex = 52;
            this.atualizaButton.Text = "Atualizar";
            this.atualizaButton.UseVisualStyleBackColor = false;
            this.atualizaButton.Click += new System.EventHandler(this.atualizaButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.funcaoCombo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sexoCombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ativoCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.idTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nomeTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(219, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 117);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // funcaoCombo
            // 
            this.funcaoCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Coordenador",
            "Auxiliar",
            "Catequista"});
            this.funcaoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcaoCombo.FormattingEnabled = true;
            this.funcaoCombo.Items.AddRange(new object[] {
            "Coordenadora",
            "Auxiliar",
            "Administrador"});
            this.funcaoCombo.Location = new System.Drawing.Point(265, 75);
            this.funcaoCombo.Name = "funcaoCombo";
            this.funcaoCombo.Size = new System.Drawing.Size(69, 22);
            this.funcaoCombo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Função";
            // 
            // sexoCombo
            // 
            this.sexoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoCombo.FormattingEnabled = true;
            this.sexoCombo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexoCombo.Location = new System.Drawing.Point(66, 75);
            this.sexoCombo.Name = "sexoCombo";
            this.sexoCombo.Size = new System.Drawing.Size(102, 22);
            this.sexoCombo.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sexo";
            // 
            // ativoCombo
            // 
            this.ativoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ativoCombo.FormattingEnabled = true;
            this.ativoCombo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.ativoCombo.Location = new System.Drawing.Point(174, 75);
            this.ativoCombo.Name = "ativoCombo";
            this.ativoCombo.Size = new System.Drawing.Size(85, 22);
            this.ativoCombo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ativo";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(23, 35);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(37, 21);
            this.idTxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(66, 35);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(268, 21);
            this.nomeTxt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Codigo";
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(656, 414);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 51;
            this.button8.Text = "Remover";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pesquisaTxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 43);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(604, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Recarregar Tabela";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaTxt.Location = new System.Drawing.Point(66, 15);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(369, 21);
            this.pesquisaTxt.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(91, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userData
            // 
            this.userData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecao});
            this.userData.Location = new System.Drawing.Point(91, 61);
            this.userData.Name = "userData";
            this.userData.Size = new System.Drawing.Size(640, 224);
            this.userData.TabIndex = 45;
            this.userData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userData_CellContentClick);
            // 
            // selecao
            // 
            this.selecao.HeaderText = "Seleção";
            this.selecao.Name = "selecao";
            this.selecao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selecao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selecao.Width = 60;
            // 
            // idLogin
            // 
            this.idLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idLogin.AutoSize = true;
            this.idLogin.Location = new System.Drawing.Point(778, 33);
            this.idLogin.Name = "idLogin";
            this.idLogin.Size = new System.Drawing.Size(10, 13);
            this.idLogin.TabIndex = 53;
            this.idLogin.Text = " ";
            this.idLogin.Visible = false;
            // 
            // consultaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.idLogin);
            this.Controls.Add(this.atualizaButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userData);
            this.Name = "consultaUser";
            this.Text = "Consulta Usuários";
            this.Load += new System.EventHandler(this.consultaUser_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button atualizaButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ativoCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView userData;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox funcaoCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label idLogin;
        private System.Windows.Forms.DataGridViewButtonColumn selecao;
    }
}