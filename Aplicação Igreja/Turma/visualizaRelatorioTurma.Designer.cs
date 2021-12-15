namespace Aplicação_Igreja.Turma
{
    partial class visualizaRelatorioTurma
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.catequizandoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoCapelaDataSet = new Aplicação_Igreja.bancoCapelaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmaTableAdapter = new Aplicação_Igreja.bancoCapelaDataSetTableAdapters.turmaTableAdapter();
            this.catequizandoTableAdapter = new Aplicação_Igreja.bancoCapelaDataSetTableAdapters.catequizandoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoCapelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catequizandoBindingSource
            // 
            this.catequizandoBindingSource.DataMember = "catequizando";
            this.catequizandoBindingSource.DataSource = this.bancoCapelaDataSet;
            // 
            // bancoCapelaDataSet
            // 
            this.bancoCapelaDataSet.DataSetName = "bancoCapelaDataSet";
            this.bancoCapelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.catequizandoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplicação_Igreja.Turma.relatorioFaltas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataMember = "turma";
            this.turmaBindingSource.DataSource = this.bancoCapelaDataSet;
            // 
            // turmaTableAdapter
            // 
            this.turmaTableAdapter.ClearBeforeFill = true;
            // 
            // catequizandoTableAdapter
            // 
            this.catequizandoTableAdapter.ClearBeforeFill = true;
            // 
            // visualizaRelatorioTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "visualizaRelatorioTurma";
            this.Text = "visualizaRelatorioTurma";
            this.Load += new System.EventHandler(this.visualizaRelatorioTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catequizandoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoCapelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bancoCapelaDataSet bancoCapelaDataSet;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private bancoCapelaDataSetTableAdapters.turmaTableAdapter turmaTableAdapter;
        private System.Windows.Forms.BindingSource catequizandoBindingSource;
        private bancoCapelaDataSetTableAdapters.catequizandoTableAdapter catequizandoTableAdapter;
    }
}