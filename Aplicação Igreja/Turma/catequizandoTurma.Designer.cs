namespace Aplicação_Igreja.Turma
{
    partial class catequizandoTurma
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
            this.catequizandoData = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.encontroTxt = new System.Windows.Forms.TextBox();
            this.turmaTxt = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoData)).BeginInit();
            this.SuspendLayout();
            // 
            // catequizandoData
            // 
            this.catequizandoData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catequizandoData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.catequizandoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catequizandoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectButton});
            this.catequizandoData.Location = new System.Drawing.Point(14, 63);
            this.catequizandoData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.catequizandoData.Name = "catequizandoData";
            this.catequizandoData.Size = new System.Drawing.Size(643, 277);
            this.catequizandoData.TabIndex = 14;
            this.catequizandoData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catequizandoData_CellContentClick);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(270, 348);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 28);
            this.button6.TabIndex = 55;
            this.button6.Text = "Registrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(142, 31);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(42, 24);
            this.idTxt.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Codigo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(372, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 16);
            this.label15.TabIndex = 62;
            this.label15.Text = "Dias de Encontro";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(227, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 60;
            this.label21.Text = "Turma";
            // 
            // encontroTxt
            // 
            this.encontroTxt.Enabled = false;
            this.encontroTxt.Location = new System.Drawing.Point(231, 31);
            this.encontroTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encontroTxt.Name = "encontroTxt";
            this.encontroTxt.Size = new System.Drawing.Size(126, 24);
            this.encontroTxt.TabIndex = 63;
            // 
            // turmaTxt
            // 
            this.turmaTxt.Enabled = false;
            this.turmaTxt.Location = new System.Drawing.Point(376, 31);
            this.turmaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turmaTxt.Name = "turmaTxt";
            this.turmaTxt.Size = new System.Drawing.Size(119, 24);
            this.turmaTxt.TabIndex = 64;
            // 
            // selectButton
            // 
            this.selectButton.HeaderText = "Selecionar";
            this.selectButton.Name = "selectButton";
            this.selectButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // catequizandoTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 384);
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
            this.Name = "catequizandoTurma";
            this.Text = "Catequizando Turma";
            this.Load += new System.EventHandler(this.catequizandoTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catequizandoData;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox encontroTxt;
        private System.Windows.Forms.TextBox turmaTxt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectButton;
    }
}