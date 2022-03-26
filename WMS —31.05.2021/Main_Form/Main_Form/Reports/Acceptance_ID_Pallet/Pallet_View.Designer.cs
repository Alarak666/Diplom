
namespace Main_Form.Reports.Acceptance_ID_Pallet
{
    partial class Pallet_View
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
            this.AcceptanceOfGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Acceptance_IDxsd = new Main_Form.Reports.Acceptance_ID_Pallet.Acceptance_IDxsd();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AcceptanceOfGoodsTableAdapter = new Main_Form.Reports.Acceptance_ID_Pallet.Acceptance_IDxsdTableAdapters.AcceptanceOfGoodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceOfGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acceptance_IDxsd)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptanceOfGoodsBindingSource
            // 
            this.AcceptanceOfGoodsBindingSource.DataMember = "AcceptanceOfGoods";
            this.AcceptanceOfGoodsBindingSource.DataSource = this.Acceptance_IDxsd;
            // 
            // Acceptance_IDxsd
            // 
            this.Acceptance_IDxsd.DataSetName = "Acceptance_IDxsd";
            this.Acceptance_IDxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Pallet_ID_1";
            reportDataSource1.Value = this.AcceptanceOfGoodsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main_Form.Reports.Acceptance_ID_Pallet.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1095, 736);
            this.reportViewer1.TabIndex = 0;
            // 
            // AcceptanceOfGoodsTableAdapter
            // 
            this.AcceptanceOfGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // Pallet_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 736);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Pallet_View";
            this.Text = "Pallet_View";
            this.Load += new System.EventHandler(this.Pallet_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceOfGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Acceptance_IDxsd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AcceptanceOfGoodsBindingSource;
        private Acceptance_IDxsd Acceptance_IDxsd;
        private Acceptance_IDxsdTableAdapters.AcceptanceOfGoodsTableAdapter AcceptanceOfGoodsTableAdapter;
    }
}