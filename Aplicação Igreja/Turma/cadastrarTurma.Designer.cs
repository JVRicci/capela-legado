namespace Aplicação_Igreja.Turma
{
    partial class cadastrarTurma
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
            this.catequistaData = new System.Windows.Forms.DataGridView();
            this.turmaCombo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catequistaTxt = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.diaEncontroCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catequistaData)).BeginInit();
            this.SuspendLayout();
            // 
            // catequistaData
            // 
            this.catequistaData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catequistaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catequistaData.Location = new System.Drawing.Point(17, 60);
            this.catequistaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catequistaData.Name = "catequistaData";
            this.catequistaData.Size = new System.Drawing.Size(590, 286);
            this.catequistaData.TabIndex = 26;
            this.catequistaData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.catequistaData_CellMouseClick);
            // 
            // turmaCombo
            // 
            this.turmaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turmaCombo.FormattingEnabled = true;
            this.turmaCombo.Items.AddRange(new object[] {
            "1° Ano (Comunhão)",
            "2° Ano (Comunhão)",
            "3° Ano (Comunhão)",
            "4° Ano (Comunhão)",
            "1° Ano (Crisma)",
            "2° Ano (Crisma)",
            "3° Ano (Crisma)",
            "4° Ano (Crisma)"});
            this.turmaCombo.Location = new System.Drawing.Point(407, 25);
            this.turmaCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turmaCombo.Name = "turmaCombo";
            this.turmaCombo.Size = new System.Drawing.Size(96, 24);
            this.turmaCombo.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(407, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 48;
            this.label21.Text = "Turma";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(17, 25);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(42, 24);
            this.idTxt.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nome do Catequista";
            // 
            // catequistaTxt
            // 
            this.catequistaTxt.Enabled = false;
            this.catequistaTxt.Location = new System.Drawing.Point(117, 27);
            this.catequistaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catequistaTxt.Name = "catequistaTxt";
            this.catequistaTxt.Size = new System.Drawing.Size(258, 24);
            this.catequistaTxt.TabIndex = 52;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(262, 353);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 28);
            this.button6.TabIndex = 54;
            this.button6.Text = "Cadastrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // diaEncontroCombo
            // 
            this.diaEncontroCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.diaEncontroCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diaEncontroCombo.FormattingEnabled = true;
            this.diaEncontroCombo.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.diaEncontroCombo.Location = new System.Drawing.Point(511, 27);
            this.diaEncontroCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diaEncontroCombo.Name = "diaEncontroCombo";
            this.diaEncontroCombo.Size = new System.Drawing.Size(93, 24);
            this.diaEncontroCombo.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Dias de Encontro";
            // 
            // cadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 396);
            this.Controls.Add(this.diaEncontroCombo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catequistaTxt);
            this.Controls.Add(this.turmaCombo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catequistaData);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastrarTurma";
            this.Text = "Cadastrar Turma";
            this.Load += new System.EventHandler(this.cadastrarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catequistaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catequistaData;
        private System.Windows.Forms.ComboBox turmaCombo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catequistaTxt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox diaEncontroCombo;
        private System.Windows.Forms.Label label15;
    }
}