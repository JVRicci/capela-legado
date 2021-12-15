namespace Aplicação_Igreja.Doacoes
{
    partial class cadastroDoacao
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
            this.label6 = new System.Windows.Forms.Label();
            this.doadorTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrarDizimo = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marcaDoacaoBox = new System.Windows.Forms.DateTimePicker();
            this.destinoTxt = new System.Windows.Forms.ComboBox();
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome do Doador";
            // 
            // doadorTxt
            // 
            this.doadorTxt.Location = new System.Drawing.Point(118, 30);
            this.doadorTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doadorTxt.Name = "doadorTxt";
            this.doadorTxt.Size = new System.Drawing.Size(235, 24);
            this.doadorTxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descricao";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Enabled = false;
            this.descricaoTxt.Location = new System.Drawing.Point(115, 132);
            this.descricaoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(94, 24);
            this.descricaoTxt.TabIndex = 15;
            this.descricaoTxt.TextChanged += new System.EventHandler(this.descricaoTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Destino";
            // 
            // registrarDizimo
            // 
            this.registrarDizimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrarDizimo.Location = new System.Drawing.Point(128, 175);
            this.registrarDizimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrarDizimo.Name = "registrarDizimo";
            this.registrarDizimo.Size = new System.Drawing.Size(120, 28);
            this.registrarDizimo.TabIndex = 27;
            this.registrarDizimo.Text = "Registrar Doação";
            this.registrarDizimo.UseVisualStyleBackColor = true;
            this.registrarDizimo.Click += new System.EventHandler(this.registrarDizimo_Click);
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(21, 30);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(61, 24);
            this.idTxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Data ";
            // 
            // marcaDoacaoBox
            // 
            this.marcaDoacaoBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.marcaDoacaoBox.CustomFormat = "dd-MM-yyyy";
            this.marcaDoacaoBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.marcaDoacaoBox.Location = new System.Drawing.Point(21, 81);
            this.marcaDoacaoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marcaDoacaoBox.MaxDate = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            this.marcaDoacaoBox.Name = "marcaDoacaoBox";
            this.marcaDoacaoBox.Size = new System.Drawing.Size(89, 24);
            this.marcaDoacaoBox.TabIndex = 47;
            this.marcaDoacaoBox.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            // 
            // destinoTxt
            // 
            this.destinoTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoTxt.FormattingEnabled = true;
            this.destinoTxt.Items.AddRange(new object[] {
            "Comunidade",
            "Externo"});
            this.destinoTxt.Location = new System.Drawing.Point(234, 85);
            this.destinoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.destinoTxt.Name = "destinoTxt";
            this.destinoTxt.Size = new System.Drawing.Size(104, 24);
            this.destinoTxt.TabIndex = 48;
            // 
            // tipoCombo
            // 
            this.tipoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCombo.FormattingEnabled = true;
            this.tipoCombo.Items.AddRange(new object[] {
            "Material",
            "Em Espécie"});
            this.tipoCombo.Location = new System.Drawing.Point(118, 85);
            this.tipoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(109, 24);
            this.tipoCombo.TabIndex = 50;
            this.tipoCombo.SelectedIndexChanged += new System.EventHandler(this.tipoCombo_SelectedIndexChanged);
            this.tipoCombo.SelectionChangeCommitted += new System.EventHandler(this.tipoCombo_SelectionChangeCommitted);
            this.tipoCombo.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Valor";
            // 
            // valorTxt
            // 
            this.valorTxt.Enabled = false;
            this.valorTxt.Location = new System.Drawing.Point(234, 132);
            this.valorTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(94, 24);
            this.valorTxt.TabIndex = 52;
            this.valorTxt.TextChanged += new System.EventHandler(this.valorTxt_TextChanged);
            this.valorTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTxt_KeyPress);
            // 
            // cadastroDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(362, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorTxt);
            this.Controls.Add(this.tipoCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinoTxt);
            this.Controls.Add(this.marcaDoacaoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrarDizimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.doadorTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descricaoTxt);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cadastroDoacao";
            this.Text = "Cadastro doação";
            this.Load += new System.EventHandler(this.cadastroDoacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox doadorTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrarDizimo;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker marcaDoacaoBox;
        private System.Windows.Forms.ComboBox destinoTxt;
        private System.Windows.Forms.ComboBox tipoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorTxt;
    }
}