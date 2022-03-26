
namespace Main_Form.Reports.Product_Report
{
    partial class Product_Reports
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
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product = new Main_Form.Reports.Product_Report.Product();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductTableAdapter = new Main_Form.Reports.Product_Report.ProductTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataMember = "Product";
            this.ProductBindingSource.DataSource = this.Product;
            // 
            // Product
            // 
            this.Product.DataSetName = "Product";
            this.Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main_Form.Reports.Product_Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(914, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProductTableAdapter
            // 
            this.ProductTableAdapter.ClearBeforeFill = true;
            // 
            // Product_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 598);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Product_Reports";
            this.Text = "Product_Reports";
            this.Load += new System.EventHandler(this.Product_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private Product Product;
        private ProductTableAdapters.ProductTableAdapter ProductTableAdapter;
    }
}