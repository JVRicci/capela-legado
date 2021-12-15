namespace Aplicação_Igreja.Turma
{
    partial class consultarTurmas
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.turmaCombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.turmaData = new System.Windows.Forms.DataGridView();
            this.resgistrarMembButton = new System.Windows.Forms.Button();
            this.catequizandoData = new System.Windows.Forms.DataGridView();
            this.registroFaltas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turmaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoData)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(192, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 25);
            this.button3.TabIndex = 30;
            this.button3.Text = "Registrar Turma";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(141, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 25);
            this.button4.TabIndex = 23;
            this.button4.Text = "Remover Turma";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.turmaCombo);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(4, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 46);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
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
            this.turmaCombo.Location = new System.Drawing.Point(94, 17);
            this.turmaCombo.Name = "turmaCombo";
            this.turmaCombo.Size = new System.Drawing.Size(146, 22);
            this.turmaCombo.TabIndex = 53;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(644, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 25);
            this.button5.TabIndex = 51;
            this.button5.Text = "Recarregar Tabela";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(281, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turmaData
            // 
            this.turmaData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.turmaData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.turmaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turmaData.Location = new System.Drawing.Point(48, 104);
            this.turmaData.Name = "turmaData";
            this.turmaData.ReadOnly = true;
            this.turmaData.Size = new System.Drawing.Size(402, 388);
            this.turmaData.TabIndex = 19;
            this.turmaData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.turmaData_CellContentClick);
            this.turmaData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.turmaData_CellMouseClick);
            // 
            // resgistrarMembButton
            // 
            this.resgistrarMembButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resgistrarMembButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resgistrarMembButton.Enabled = false;
            this.resgistrarMembButton.Location = new System.Drawing.Point(507, 73);
            this.resgistrarMembButton.Name = "resgistrarMembButton";
            this.resgistrarMembButton.Size = new System.Drawing.Size(118, 25);
            this.resgistrarMembButton.TabIndex = 31;
            this.resgistrarMembButton.Text = "Registrar Membros";
            this.resgistrarMembButton.UseVisualStyleBackColor = false;
            this.resgistrarMembButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // catequizandoData
            // 
            this.catequizandoData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catequizandoData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.catequizandoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catequizandoData.Location = new System.Drawing.Point(507, 104);
            this.catequizandoData.Name = "catequizandoData";
            this.catequizandoData.ReadOnly = true;
            this.catequizandoData.Size = new System.Drawing.Size(248, 389);
            this.catequizandoData.TabIndex = 25;
            // 
            // registroFaltas
            // 
            this.registroFaltas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registroFaltas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registroFaltas.Enabled = false;
            this.registroFaltas.Location = new System.Drawing.Point(631, 73);
            this.registroFaltas.Name = "registroFaltas";
            this.registroFaltas.Size = new System.Drawing.Size(124, 25);
            this.registroFaltas.TabIndex = 33;
            this.registroFaltas.Text = "Registrar Faltas";
            this.registroFaltas.UseVisualStyleBackColor = false;
            this.registroFaltas.Click += new System.EventHandler(this.button6_Click);
            // 
            // consultarTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.registroFaltas);
            this.Controls.Add(this.resgistrarMembButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.catequizandoData);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.turmaData);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "consultarTurmas";
            this.Text = "Consultar Turmas";
            this.Load += new System.EventHandler(this.consultarTurmas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turmaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView turmaData;
        private System.Windows.Forms.Button resgistrarMembButton;
        private System.Windows.Forms.DataGridView catequizandoData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button registroFaltas;
        private System.Windows.Forms.ComboBox turmaCombo;
    }
}