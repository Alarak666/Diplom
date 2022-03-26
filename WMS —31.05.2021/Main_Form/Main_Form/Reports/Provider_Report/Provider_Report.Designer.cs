
namespace Main_Form.Reports.Provider_Report
{
    partial class Provider_Report
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
            this.ProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Provider_DataSet = new Main_Form.Reports.Provider_Report.Provider_DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProviderTableAdapter = new Main_Form.Reports.Provider_Report.Provider_DataSetTableAdapters.ProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Provider_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProviderBindingSource
            // 
            this.ProviderBindingSource.DataMember = "Provider";
            this.ProviderBindingSource.DataSource = this.Provider_DataSet;
            // 
            // Provider_DataSet
            // 
            this.Provider_DataSet.DataSetName = "Provider_DataSet";
            this.Provider_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Provider_DataSet";
            reportDataSource1.Value = this.ProviderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main_Form.Reports.Provider_Report.Provider_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(905, 663);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProviderTableAdapter
            // 
            this.ProviderTableAdapter.ClearBeforeFill = true;
            // 
            // Provider_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 663);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Provider_Report";
            this.Text = "Provider_Report";
            this.Load += new System.EventHandler(this.Provider_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Provider_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProviderBindingSource;
        private Provider_DataSet Provider_DataSet;
        private Provider_DataSetTableAdapters.ProviderTableAdapter ProviderTableAdapter;
    }
}