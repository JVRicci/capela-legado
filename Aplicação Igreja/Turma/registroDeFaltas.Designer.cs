namespace Aplicação_Igreja.Turma
{
    partial class registroDeFaltas
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
            this.turmaTxt = new System.Windows.Forms.TextBox();
            this.encontroTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.catequizandoData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.faltaEncCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idCatTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.faltaCelebTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoData)).BeginInit();
            this.SuspendLayout();
            // 
            // turmaTxt
            // 
            this.turmaTxt.Enabled = false;
            this.turmaTxt.Location = new System.Drawing.Point(311, 40);
            this.turmaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turmaTxt.Name = "turmaTxt";
            this.turmaTxt.Size = new System.Drawing.Size(119, 24);
            this.turmaTxt.TabIndex = 72;
            // 
            // encontroTxt
            // 
            this.encontroTxt.Enabled = false;
            this.encontroTxt.Location = new System.Drawing.Point(177, 40);
            this.encontroTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encontroTxt.Name = "encontroTxt";
            this.encontroTxt.Size = new System.Drawing.Size(126, 24);
            this.encontroTxt.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 16);
            this.label15.TabIndex = 70;
            this.label15.Text = "Dias de Encontro";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(173, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 69;
            this.label21.Text = "Turma";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(123, 40);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(42, 24);
            this.idTxt.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Codigo";
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(209, 390);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 28);
            this.button6.TabIndex = 66;
            this.button6.Text = "Registrar Falta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // catequizandoData
            // 
            this.catequizandoData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catequizandoData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.catequizandoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catequizandoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.catequizandoData.Location = new System.Drawing.Point(27, 72);
            this.catequizandoData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catequizandoData.Name = "catequizandoData";
            this.catequizandoData.ReadOnly = true;
            this.catequizandoData.Size = new System.Drawing.Size(520, 250);
            this.catequizandoData.TabIndex = 65;
            this.catequizandoData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catequizandoData_CellContentClick);
            this.catequizandoData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catequizandoData_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleção";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // faltaEncCombo
            // 
            this.faltaEncCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faltaEncCombo.FormattingEnabled = true;
            this.faltaEncCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.faltaEncCombo.Location = new System.Drawing.Point(299, 358);
            this.faltaEncCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.faltaEncCombo.Name = "faltaEncCombo";
            this.faltaEncCombo.Size = new System.Drawing.Size(77, 24);
            this.faltaEncCombo.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Encontros";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Enabled = false;
            this.nomeTxt.Location = new System.Drawing.Point(167, 358);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(126, 24);
            this.nomeTxt.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nome";
            // 
            // idCatTxt
            // 
            this.idCatTxt.Enabled = false;
            this.idCatTxt.Location = new System.Drawing.Point(102, 358);
            this.idCatTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idCatTxt.Name = "idCatTxt";
            this.idCatTxt.Size = new System.Drawing.Size(42, 24);
            this.idCatTxt.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Celebrações";
            // 
            // faltaCelebTxt
            // 
            this.faltaCelebTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faltaCelebTxt.FormattingEnabled = true;
            this.faltaCelebTxt.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.faltaCelebTxt.Location = new System.Drawing.Point(384, 358);
            this.faltaCelebTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.faltaCelebTxt.Name = "faltaCelebTxt";
            this.faltaCelebTxt.Size = new System.Drawing.Size(77, 24);
            this.faltaCelebTxt.TabIndex = 81;
            // 
            // registroDeFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.faltaCelebTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idCatTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faltaEncCombo);
            this.Controls.Add(this.turmaTxt);
            this.Controls.Add(this.encontroTxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.catequizandoData);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "registroDeFaltas";
            this.Text = "Registro de Faltas";
            this.Load += new System.EventHandler(this.registroDeFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox turmaTxt;
        private System.Windows.Forms.TextBox encontroTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView catequizandoData;
        private System.Windows.Forms.ComboBox faltaEncCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idCatTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox faltaCelebTxt;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}