namespace Aplicação_Igreja.Dizimistas
{
    partial class Cadastro_Dizimista
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nascConjText = new System.Windows.Forms.DateTimePicker();
            this.nascimentoTxt = new System.Windows.Forms.DateTimePicker();
            this.tipoCasaCombo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.estadoCivilCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conjugeText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfTxt = new System.Windows.Forms.MaskedTextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cidadeTxt = new System.Windows.Forms.TextBox();
            this.celularTxt = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.telefoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bairroTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ufCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cepTxt = new System.Windows.Forms.MaskedTextBox();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.nascConjText);
            this.groupBox3.Controls.Add(this.nascimentoTxt);
            this.groupBox3.Controls.Add(this.tipoCasaCombo);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.estadoCivilCombo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.conjugeText);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cpfTxt);
            this.groupBox3.Controls.Add(this.nomeTxt);
            this.groupBox3.Location = new System.Drawing.Point(28, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(366, 215);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Pessoais";
            // 
            // nascConjText
            // 
            this.nascConjText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nascConjText.CustomFormat = "dd-MM-yyyy";
            this.nascConjText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nascConjText.Location = new System.Drawing.Point(257, 158);
            this.nascConjText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nascConjText.MaxDate = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            this.nascConjText.Name = "nascConjText";
            this.nascConjText.Size = new System.Drawing.Size(89, 24);
            this.nascConjText.TabIndex = 52;
            this.nascConjText.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            // 
            // nascimentoTxt
            // 
            this.nascimentoTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nascimentoTxt.CustomFormat = "dd-MM-yyyy";
            this.nascimentoTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nascimentoTxt.Location = new System.Drawing.Point(257, 49);
            this.nascimentoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nascimentoTxt.MaxDate = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            this.nascimentoTxt.Name = "nascimentoTxt";
            this.nascimentoTxt.Size = new System.Drawing.Size(89, 24);
            this.nascimentoTxt.TabIndex = 51;
            this.nascimentoTxt.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            // 
            // tipoCasaCombo
            // 
            this.tipoCasaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCasaCombo.FormattingEnabled = true;
            this.tipoCasaCombo.Items.AddRange(new object[] {
            "Igreja",
            "Civil",
            "Ambos"});
            this.tipoCasaCombo.Location = new System.Drawing.Point(260, 105);
            this.tipoCasaCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipoCasaCombo.Name = "tipoCasaCombo";
            this.tipoCasaCombo.Size = new System.Drawing.Size(98, 24);
            this.tipoCasaCombo.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Tipo de Casamento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(257, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Nacimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Conjuge";
            // 
            // estadoCivilCombo
            // 
            this.estadoCivilCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCivilCombo.FormattingEnabled = true;
            this.estadoCivilCombo.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Divorcia",
            "Separado",
            "Viuvo"});
            this.estadoCivilCombo.Location = new System.Drawing.Point(128, 103);
            this.estadoCivilCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.estadoCivilCombo.Name = "estadoCivilCombo";
            this.estadoCivilCombo.Size = new System.Drawing.Size(116, 24);
            this.estadoCivilCombo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado Civil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nacimento";
            // 
            // conjugeText
            // 
            this.conjugeText.Location = new System.Drawing.Point(10, 158);
            this.conjugeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conjugeText.Name = "conjugeText";
            this.conjugeText.Size = new System.Drawing.Size(238, 24);
            this.conjugeText.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // cpfTxt
            // 
            this.cpfTxt.Location = new System.Drawing.Point(10, 105);
            this.cpfTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cpfTxt.Mask = "000.000.000-00";
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(94, 24);
            this.cpfTxt.TabIndex = 12;
            this.cpfTxt.ValidatingType = typeof(System.DateTime);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(10, 49);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(238, 24);
            this.nomeTxt.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cidadeTxt);
            this.groupBox2.Controls.Add(this.celularTxt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.telefoneTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.bairroTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ufCombo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cepTxt);
            this.groupBox2.Controls.Add(this.numeroTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.enderecoTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(401, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(373, 215);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço e Telefones";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 22;
            this.label19.Text = "Cidade";
            // 
            // cidadeTxt
            // 
            this.cidadeTxt.Location = new System.Drawing.Point(23, 98);
            this.cidadeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cidadeTxt.Name = "cidadeTxt";
            this.cidadeTxt.Size = new System.Drawing.Size(101, 24);
            this.cidadeTxt.TabIndex = 23;
            // 
            // celularTxt
            // 
            this.celularTxt.Location = new System.Drawing.Point(265, 150);
            this.celularTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.celularTxt.Mask = "(00)00000-0000";
            this.celularTxt.Name = "celularTxt";
            this.celularTxt.Size = new System.Drawing.Size(95, 24);
            this.celularTxt.TabIndex = 17;
            this.celularTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Celular";
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Location = new System.Drawing.Point(142, 150);
            this.telefoneTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telefoneTxt.Mask = "(00)0000-0000";
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(88, 24);
            this.telefoneTxt.TabIndex = 15;
            this.telefoneTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Telefone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "UF";
            // 
            // bairroTxt
            // 
            this.bairroTxt.Location = new System.Drawing.Point(142, 96);
            this.bairroTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bairroTxt.Name = "bairroTxt";
            this.bairroTxt.Size = new System.Drawing.Size(101, 24);
            this.bairroTxt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bairro";
            // 
            // ufCombo
            // 
            this.ufCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufCombo.FormattingEnabled = true;
            this.ufCombo.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.ufCombo.Location = new System.Drawing.Point(23, 149);
            this.ufCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ufCombo.Name = "ufCombo";
            this.ufCombo.Size = new System.Drawing.Size(60, 24);
            this.ufCombo.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "CEP";
            // 
            // cepTxt
            // 
            this.cepTxt.Location = new System.Drawing.Point(265, 96);
            this.cepTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cepTxt.Mask = "00.000-000";
            this.cepTxt.Name = "cepTxt";
            this.cepTxt.Size = new System.Drawing.Size(68, 24);
            this.cepTxt.TabIndex = 10;
            this.cepTxt.ValidatingType = typeof(System.DateTime);
            // 
            // numeroTxt
            // 
            this.numeroTxt.Location = new System.Drawing.Point(265, 48);
            this.numeroTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(60, 24);
            this.numeroTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Logradouro";
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.Location = new System.Drawing.Point(23, 44);
            this.enderecoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(220, 24);
            this.enderecoTxt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Número";
            // 
            // Cadastro_Dizimista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(791, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Dizimista";
            this.Text = "Cadastro de Dizimista";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cadastro_Dizimista_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox tipoCasaCombo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox estadoCivilCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conjugeText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cpfTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cidadeTxt;
        private System.Windows.Forms.MaskedTextBox celularTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox telefoneTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bairroTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ufCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox cepTxt;
        private System.Windows.Forms.TextBox numeroTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker nascConjText;
        private System.Windows.Forms.DateTimePicker nascimentoTxt;
    }
}