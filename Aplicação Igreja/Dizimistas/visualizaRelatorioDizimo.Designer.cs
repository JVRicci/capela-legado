﻿namespace Aplicação_Igreja.Dizimistas
{
    partial class visualizaRelatorioDizimo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bancoCapelaDataSet = new Aplicação_Igreja.bancoCapelaDataSet();
            this.dizimoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dizimoTableAdapter = new Aplicação_Igreja.bancoCapelaDataSetTableAdapters.dizimoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bancoCapelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dizimoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dizimoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplicação_Igreja.Dizimistas.relatorioDizimo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // bancoCapelaDataSet
            // 
            this.bancoCapelaDataSet.DataSetName = "bancoCapelaDataSet";
            this.bancoCapelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dizimoBindingSource
            // 
            this.dizimoBindingSource.DataMember = "dizimo";
            this.dizimoBindingSource.DataSource = this.bancoCapelaDataSet;
            // 
            // dizimoTableAdapter
            // 
            this.dizimoTableAdapter.ClearBeforeFill = true;
            // 
            // visualizaRelatorioDizimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "visualizaRelatorioDizimo";
            this.Text = "visualizaRelatorioDizimo";
            this.Load += new System.EventHandler(this.visualizaRelatorioDizimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoCapelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dizimoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bancoCapelaDataSet bancoCapelaDataSet;
        private System.Windows.Forms.BindingSource dizimoBindingSource;
        private bancoCapelaDataSetTableAdapters.dizimoTableAdapter dizimoTableAdapter;
    }
}