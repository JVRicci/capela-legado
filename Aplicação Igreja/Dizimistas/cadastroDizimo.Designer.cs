namespace Aplicação_Igreja.Dizimistas
{
    partial class cadastroDizimo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dizimistaTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.registrarButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recebimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dizimista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(44, 20);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(40, 24);
            this.idTextBox.TabIndex = 5;
            // 
            // dizimistaTextBox
            // 
            this.dizimistaTextBox.Enabled = false;
            this.dizimistaTextBox.Location = new System.Drawing.Point(178, 20);
            this.dizimistaTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dizimistaTextBox.Name = "dizimistaTextBox";
            this.dizimistaTextBox.Size = new System.Drawing.Size(202, 24);
            this.dizimistaTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(178, 58);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(75, 24);
            this.valorTextBox.TabIndex = 9;
            this.valorTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // registrarButton
            // 
            this.registrarButton.Location = new System.Drawing.Point(145, 142);
            this.registrarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(87, 28);
            this.registrarButton.TabIndex = 10;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataTextBox.CustomFormat = "dd-MM-yyyy";
            this.dataTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataTextBox.Location = new System.Drawing.Point(178, 91);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(87, 24);
            this.dataTextBox.TabIndex = 49;
            // 
            // cadastroDizimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 181);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.dizimistaTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastroDizimo";
            this.Text = "Registro de Dizimo";
            this.Load += new System.EventHandler(this.cadastroDizimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox dizimistaTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.DateTimePicker dataTextBox;
    }
}