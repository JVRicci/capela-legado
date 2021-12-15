namespace Aplicação_Igreja.Usuários
{
    partial class cadastraUser
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.funcaoCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sexoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ativoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.Location = new System.Drawing.Point(214, 217);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 28);
            this.button7.TabIndex = 56;
            this.button7.Text = "Cadastrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.senhaTextBox);
            this.groupBox2.Controls.Add(this.loginTextBox);
            this.groupBox2.Controls.Add(this.funcaoCombo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sexoCombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ativoCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nomeTxt);
            this.groupBox2.Location = new System.Drawing.Point(42, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(420, 194);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Login";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.senhaTextBox.Location = new System.Drawing.Point(51, 146);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(224, 24);
            this.senhaTextBox.TabIndex = 59;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(48, 97);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(224, 24);
            this.loginTextBox.TabIndex = 58;
            // 
            // funcaoCombo
            // 
            this.funcaoCombo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.funcaoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcaoCombo.FormattingEnabled = true;
            this.funcaoCombo.Items.AddRange(new object[] {
            "Coordenadora",
            "Auxiliar"});
            this.funcaoCombo.Location = new System.Drawing.Point(283, 96);
            this.funcaoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.funcaoCombo.Name = "funcaoCombo";
            this.funcaoCombo.Size = new System.Drawing.Size(80, 24);
            this.funcaoCombo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Função";
            // 
            // sexoCombo
            // 
            this.sexoCombo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sexoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoCombo.FormattingEnabled = true;
            this.sexoCombo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexoCombo.Location = new System.Drawing.Point(283, 47);
            this.sexoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sexoCombo.Name = "sexoCombo";
            this.sexoCombo.Size = new System.Drawing.Size(80, 24);
            this.sexoCombo.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sexo";
            // 
            // ativoCombo
            // 
            this.ativoCombo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ativoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ativoCombo.FormattingEnabled = true;
            this.ativoCombo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.ativoCombo.Location = new System.Drawing.Point(283, 145);
            this.ativoCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ativoCombo.Name = "ativoCombo";
            this.ativoCombo.Size = new System.Drawing.Size(80, 24);
            this.ativoCombo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(48, 47);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(224, 24);
            this.nomeTxt.TabIndex = 21;
            // 
            // cadastraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 258);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cadastraUser";
            this.Text = "cadastraUser";
            this.Load += new System.EventHandler(this.cadastraUser_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox funcaoCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ativoCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
    }
}