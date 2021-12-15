namespace Aplicação_Igreja.Catequista
{
    partial class cadastroCatequista
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
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.marcaDataBox = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cidadeTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.celularTxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.telefoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.ufCombo = new System.Windows.Forms.ComboBox();
            this.cepTxt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(252, 297);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 47;
            this.button7.Text = "Cadastrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.marcaDataBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cidadeTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.celularTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nomeTxt);
            this.groupBox2.Controls.Add(this.telefoneTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(this.bairroTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numeroTxt);
            this.groupBox2.Controls.Add(this.ufCombo);
            this.groupBox2.Controls.Add(this.cepTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(521, 261);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // marcaDataBox
            // 
            this.marcaDataBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.marcaDataBox.CustomFormat = "dd-MM-yyyy";
            this.marcaDataBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.marcaDataBox.Location = new System.Drawing.Point(392, 43);
            this.marcaDataBox.Margin = new System.Windows.Forms.Padding(4);
            this.marcaDataBox.MaxDate = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            this.marcaDataBox.Name = "marcaDataBox";
            this.marcaDataBox.Size = new System.Drawing.Size(101, 21);
            this.marcaDataBox.TabIndex = 39;
            this.marcaDataBox.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            this.marcaDataBox.ValueChanged += new System.EventHandler(this.marcaDataBox_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 121);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 14);
            this.label19.TabIndex = 22;
            this.label19.Text = "Cidade";
            // 
            // cidadeTxt
            // 
            this.cidadeTxt.Location = new System.Drawing.Point(25, 142);
            this.cidadeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cidadeTxt.Name = "cidadeTxt";
            this.cidadeTxt.Size = new System.Drawing.Size(256, 21);
            this.cidadeTxt.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nacimento";
            // 
            // celularTxt
            // 
            this.celularTxt.Location = new System.Drawing.Point(173, 194);
            this.celularTxt.Margin = new System.Windows.Forms.Padding(4);
            this.celularTxt.Mask = "(00)00000-0000";
            this.celularTxt.Name = "celularTxt";
            this.celularTxt.Size = new System.Drawing.Size(108, 21);
            this.celularTxt.TabIndex = 17;
            this.celularTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 14);
            this.label13.TabIndex = 16;
            this.label13.Text = "Celular";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(25, 42);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(347, 21);
            this.nomeTxt.TabIndex = 21;
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Location = new System.Drawing.Point(25, 194);
            this.telefoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.telefoneTxt.Mask = "(00)0000-0000";
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(100, 21);
            this.telefoneTxt.TabIndex = 15;
            this.telefoneTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 14);
            this.label12.TabIndex = 14;
            this.label12.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "UF";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(25, 87);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(256, 21);
            this.enderecoTextBox.TabIndex = 5;
            // 
            // bairroTxt
            // 
            this.bairroTxt.Location = new System.Drawing.Point(396, 89);
            this.bairroTxt.Margin = new System.Windows.Forms.Padding(4);
            this.bairroTxt.Name = "bairroTxt";
            this.bairroTxt.Size = new System.Drawing.Size(97, 21);
            this.bairroTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logradouro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bairro";
            // 
            // numeroTxt
            // 
            this.numeroTxt.Location = new System.Drawing.Point(295, 87);
            this.numeroTxt.Margin = new System.Windows.Forms.Padding(4);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(77, 21);
            this.numeroTxt.TabIndex = 7;
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
            this.ufCombo.Location = new System.Drawing.Point(396, 142);
            this.ufCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ufCombo.Name = "ufCombo";
            this.ufCombo.Size = new System.Drawing.Size(68, 22);
            this.ufCombo.TabIndex = 12;
            // 
            // cepTxt
            // 
            this.cepTxt.Location = new System.Drawing.Point(295, 142);
            this.cepTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cepTxt.Mask = "00.000-000";
            this.cepTxt.Name = "cepTxt";
            this.cepTxt.Size = new System.Drawing.Size(77, 21);
            this.cepTxt.TabIndex = 10;
            this.cepTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "CEP";
            // 
            // cadastroCatequista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(623, 350);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastroCatequista";
            this.Text = "Cadastro Catequista";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.cadastroCatequista_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cidadeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox celularTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.MaskedTextBox telefoneTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numeroTxt;
        private System.Windows.Forms.ComboBox ufCombo;
        private System.Windows.Forms.MaskedTextBox cepTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker marcaDataBox;
    }
}