namespace Aplicação_Igreja.Eventos
{
    partial class consultarEventos
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
            this.calendarioEventos = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.marcaDataBox = new System.Windows.Forms.DateTimePicker();
            this.selecaoEquipe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipeData = new System.Windows.Forms.DataGridView();
            this.selecaoMaterial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialData = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialData)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarioEventos
            // 
            this.calendarioEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.calendarioEventos.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.calendarioEventos.Location = new System.Drawing.Point(21, 84);
            this.calendarioEventos.Name = "calendarioEventos";
            this.calendarioEventos.TabIndex = 0;
            this.calendarioEventos.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.marcaDataBox);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.idTxt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.descricaoTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 83);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Pessoais";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(541, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 28);
            this.button3.TabIndex = 37;
            this.button3.Text = "Registrar Evento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(33, 38);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(44, 20);
            this.idTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Location = new System.Drawing.Point(95, 40);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(320, 20);
            this.descricaoTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // marcaDataBox
            // 
            this.marcaDataBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.marcaDataBox.CustomFormat = "dd-MM-yyyy";
            this.marcaDataBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.marcaDataBox.Location = new System.Drawing.Point(421, 38);
            this.marcaDataBox.Name = "marcaDataBox";
            this.marcaDataBox.Size = new System.Drawing.Size(97, 20);
            this.marcaDataBox.TabIndex = 38;
            // 
            // selecaoEquipe
            // 
            this.selecaoEquipe.HeaderText = "Seleção";
            this.selecaoEquipe.Name = "selecaoEquipe";
            this.selecaoEquipe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selecaoEquipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selecaoEquipe.Width = 55;
            // 
            // equipeData
            // 
            this.equipeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.equipeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecaoEquipe});
            this.equipeData.Location = new System.Drawing.Point(289, 95);
            this.equipeData.Name = "equipeData";
            this.equipeData.Size = new System.Drawing.Size(241, 300);
            this.equipeData.TabIndex = 1;
            // 
            // selecaoMaterial
            // 
            this.selecaoMaterial.HeaderText = "Seleção";
            this.selecaoMaterial.Name = "selecaoMaterial";
            this.selecaoMaterial.Width = 55;
            // 
            // materialData
            // 
            this.materialData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecaoMaterial});
            this.materialData.Location = new System.Drawing.Point(536, 95);
            this.materialData.Name = "materialData";
            this.materialData.Size = new System.Drawing.Size(240, 300);
            this.materialData.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(344, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Registrar Membros";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(622, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Registrar Material";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // consultarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.materialData);
            this.Controls.Add(this.equipeData);
            this.Controls.Add(this.calendarioEventos);
            this.Name = "consultarEventos";
            this.Text = "consultarEventos";
            this.Load += new System.EventHandler(this.consultarEventos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioEventos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker marcaDataBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecaoEquipe;
        private System.Windows.Forms.DataGridView equipeData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecaoMaterial;
        private System.Windows.Forms.DataGridView materialData;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}