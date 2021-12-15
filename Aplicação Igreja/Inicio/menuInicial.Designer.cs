namespace Aplicação_Igreja.Inicio
{
    partial class menuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuInicial));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.nomeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.principalAbas = new System.Windows.Forms.TabControl();
            this.inicioTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catequeseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catequizandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catequistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contasButton = new System.Windows.Forms.Button();
            this.doacoesButton = new System.Windows.Forms.Button();
            this.dizimoButton = new System.Windows.Forms.Button();
            this.turmasButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.principalAbas.SuspendLayout();
            this.inicioTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // nomeStatusLabel
            // 
            this.nomeStatusLabel.Name = "nomeStatusLabel";
            this.nomeStatusLabel.Size = new System.Drawing.Size(98, 17);
            this.nomeStatusLabel.Text = "nomeStatusLabel";
            // 
            // principalAbas
            // 
            this.principalAbas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.principalAbas.Controls.Add(this.inicioTab);
            this.principalAbas.Location = new System.Drawing.Point(209, 27);
            this.principalAbas.Name = "principalAbas";
            this.principalAbas.SelectedIndex = 0;
            this.principalAbas.Size = new System.Drawing.Size(763, 492);
            this.principalAbas.TabIndex = 4;
            this.principalAbas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.principalAbas_MouseDoubleClick);
            // 
            // inicioTab
            // 
            this.inicioTab.BackColor = System.Drawing.Color.LightSeaGreen;
            this.inicioTab.Controls.Add(this.pictureBox1);
            this.inicioTab.Controls.Add(this.label1);
            this.inicioTab.Location = new System.Drawing.Point(4, 22);
            this.inicioTab.Name = "inicioTab";
            this.inicioTab.Size = new System.Drawing.Size(755, 466);
            this.inicioTab.TabIndex = 0;
            this.inicioTab.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 466);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comunidade Santo Antonio de Pádua";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosDoSistemaToolStripMenuItem,
            this.catequeseToolStripMenuItem,
            this.dizimoToolStripMenuItem,
            this.doacoesToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.contaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosDoSistemaToolStripMenuItem
            // 
            this.usuáriosDoSistemaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriosDoSistemaToolStripMenuItem.Name = "usuáriosDoSistemaToolStripMenuItem";
            this.usuáriosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.usuáriosDoSistemaToolStripMenuItem.Text = "Usuários do Sistema";
            this.usuáriosDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuáriosDoSistemaToolStripMenuItem_Click);
            // 
            // catequeseToolStripMenuItem
            // 
            this.catequeseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catequizandoToolStripMenuItem,
            this.catequistasToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.catequeseToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catequeseToolStripMenuItem.Name = "catequeseToolStripMenuItem";
            this.catequeseToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.catequeseToolStripMenuItem.Text = "Catequese";
            // 
            // catequizandoToolStripMenuItem
            // 
            this.catequizandoToolStripMenuItem.Name = "catequizandoToolStripMenuItem";
            this.catequizandoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.catequizandoToolStripMenuItem.Text = "Catequizando";
            this.catequizandoToolStripMenuItem.Click += new System.EventHandler(this.catequizandoToolStripMenuItem_Click);
            // 
            // catequistasToolStripMenuItem
            // 
            this.catequistasToolStripMenuItem.Name = "catequistasToolStripMenuItem";
            this.catequistasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.catequistasToolStripMenuItem.Text = "Catequistas";
            this.catequistasToolStripMenuItem.Click += new System.EventHandler(this.catequistasToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // dizimoToolStripMenuItem
            // 
            this.dizimoToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dizimoToolStripMenuItem.Name = "dizimoToolStripMenuItem";
            this.dizimoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dizimoToolStripMenuItem.Text = "Dizimo";
            this.dizimoToolStripMenuItem.Click += new System.EventHandler(this.dizimoToolStripMenuItem_Click);
            // 
            // doacoesToolStripMenuItem
            // 
            this.doacoesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doacoesToolStripMenuItem.Name = "doacoesToolStripMenuItem";
            this.doacoesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.doacoesToolStripMenuItem.Text = "Doações";
            this.doacoesToolStripMenuItem.Click += new System.EventHandler(this.doacoesToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Visible = false;
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.contaToolStripMenuItem.Text = "Contas a Pagar";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.contasButton);
            this.groupBox1.Controls.Add(this.doacoesButton);
            this.groupBox1.Controls.Add(this.dizimoButton);
            this.groupBox1.Controls.Add(this.turmasButton);
            this.groupBox1.Controls.Add(this.userButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 470);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funções";
            // 
            // contasButton
            // 
            this.contasButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contasButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contasButton.Image = ((System.Drawing.Image)(resources.GetObject("contasButton.Image")));
            this.contasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contasButton.Location = new System.Drawing.Point(0, 31);
            this.contasButton.Name = "contasButton";
            this.contasButton.Size = new System.Drawing.Size(176, 64);
            this.contasButton.TabIndex = 4;
            this.contasButton.Text = "Contas a Pagar";
            this.contasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contasButton.UseVisualStyleBackColor = false;
            this.contasButton.Click += new System.EventHandler(this.contasButton_Click);
            // 
            // doacoesButton
            // 
            this.doacoesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.doacoesButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doacoesButton.Image = ((System.Drawing.Image)(resources.GetObject("doacoesButton.Image")));
            this.doacoesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doacoesButton.Location = new System.Drawing.Point(-1, 298);
            this.doacoesButton.Name = "doacoesButton";
            this.doacoesButton.Size = new System.Drawing.Size(177, 64);
            this.doacoesButton.TabIndex = 3;
            this.doacoesButton.Text = "Doações";
            this.doacoesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doacoesButton.UseVisualStyleBackColor = false;
            this.doacoesButton.Click += new System.EventHandler(this.doacoesButton_Click);
            // 
            // dizimoButton
            // 
            this.dizimoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dizimoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dizimoButton.Image = ((System.Drawing.Image)(resources.GetObject("dizimoButton.Image")));
            this.dizimoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dizimoButton.Location = new System.Drawing.Point(-1, 228);
            this.dizimoButton.Name = "dizimoButton";
            this.dizimoButton.Size = new System.Drawing.Size(177, 64);
            this.dizimoButton.TabIndex = 2;
            this.dizimoButton.Text = "Dizimo";
            this.dizimoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dizimoButton.UseVisualStyleBackColor = false;
            this.dizimoButton.Click += new System.EventHandler(this.dizimoButton_Click);
            // 
            // turmasButton
            // 
            this.turmasButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.turmasButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmasButton.Image = ((System.Drawing.Image)(resources.GetObject("turmasButton.Image")));
            this.turmasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turmasButton.Location = new System.Drawing.Point(-1, 158);
            this.turmasButton.Name = "turmasButton";
            this.turmasButton.Size = new System.Drawing.Size(177, 64);
            this.turmasButton.TabIndex = 1;
            this.turmasButton.Text = "Turmas";
            this.turmasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.turmasButton.UseVisualStyleBackColor = false;
            this.turmasButton.Click += new System.EventHandler(this.turmasButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.Location = new System.Drawing.Point(0, 101);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(176, 51);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Usuários";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // menuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.principalAbas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "menuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comunidade Santo Antônio de Pádua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menuInicial_FormClosing);
            this.Load += new System.EventHandler(this.menuInicial_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.principalAbas.ResumeLayout(false);
            this.inicioTab.ResumeLayout(false);
            this.inicioTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel nomeStatusLabel;
        private System.Windows.Forms.TabControl principalAbas;
        private System.Windows.Forms.TabPage inicioTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catequeseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catequizandoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catequistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button contasButton;
        private System.Windows.Forms.Button doacoesButton;
        private System.Windows.Forms.Button dizimoButton;
        private System.Windows.Forms.Button turmasButton;
        private System.Windows.Forms.Button userButton;
    }
}