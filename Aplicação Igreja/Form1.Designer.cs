namespace Aplicação_Igreja
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.logarButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.senhaTextBox.Location = new System.Drawing.Point(264, 112);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(139, 24);
            this.senhaTextBox.TabIndex = 14;
            this.senhaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.senhaTextBox_KeyDown);
            // 
            // logarButton
            // 
            this.logarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logarButton.Location = new System.Drawing.Point(291, 163);
            this.logarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logarButton.Name = "logarButton";
            this.logarButton.Size = new System.Drawing.Size(87, 28);
            this.logarButton.TabIndex = 12;
            this.logarButton.Text = "Entrar";
            this.logarButton.UseVisualStyleBackColor = false;
            this.logarButton.Click += new System.EventHandler(this.logarButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(264, 80);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(139, 24);
            this.loginTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 138);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(441, 204);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.logarButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button logarButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

