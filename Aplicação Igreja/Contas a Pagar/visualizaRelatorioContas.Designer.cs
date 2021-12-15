namespace Aplicação_Igreja.Contas_a_Pagar
{
    partial class visualizaRelatorioContas
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
            this.bancoCapelaDataSet = new Aplicação_Igreja.bancoCapelaDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new Aplicação_Igreja.bancoCapelaDataSetTableAdapters.contasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bancoCapelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoCapelaDataSet
            // 
            this.bancoCapelaDataSet.DataSetName = "bancoCapelaDataSet";
            this.bancoCapelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "contas";
            this.contasBindingSource.DataSource = this.bancoCapelaDataSet;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "contasData";
            reportDataSource1.Value = this.contasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplicação_Igreja.Contas a Pagar.relatorioContas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // visualizaRelatorioContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "visualizaRelatorioContas";
            this.Text = "visualizaRelatorioContas";
            this.Load += new System.EventHandler(this.visualizaRelatorioContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoCapelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bancoCapelaDataSet bancoCapelaDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private bancoCapelaDataSetTableAdapters.contasTableAdapter contasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}