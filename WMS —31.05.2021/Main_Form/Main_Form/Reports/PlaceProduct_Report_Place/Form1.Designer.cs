
namespace Main_Form.Reports.PlaceProduct_Report_Place
{
    partial class Form1
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
            this.PlaceOfProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Place_Product_Place = new Main_Form.Reports.PlaceProduct_Report_Place.Place_Product_Place();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PlaceOfProductTableAdapter = new Main_Form.Reports.PlaceProduct_Report_Place.Place_Product_PlaceTableAdapters.PlaceOfProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceOfProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Place_Product_Place)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaceOfProductBindingSource
            // 
            this.PlaceOfProductBindingSource.DataMember = "PlaceOfProduct";
            this.PlaceOfProductBindingSource.DataSource = this.Place_Product_Place;
            // 
            // Place_Product_Place
            // 
            this.Place_Product_Place.DataSetName = "Place_Product_Place";
            this.Place_Product_Place.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Place_Product_Place";
            reportDataSource1.Value = this.PlaceOfProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main_Form.Reports.PlaceProduct_Report_Place.Place.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1172, 814);
            this.reportViewer1.TabIndex = 0;
            // 
            // PlaceOfProductTableAdapter
            // 
            this.PlaceOfProductTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 814);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaceOfProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Place_Product_Place)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PlaceOfProductBindingSource;
        private Place_Product_Place Place_Product_Place;
        private Place_Product_PlaceTableAdapters.PlaceOfProductTableAdapter PlaceOfProductTableAdapter;
    }
}