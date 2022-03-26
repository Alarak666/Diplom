
namespace Main_Form.Reports.Employeer_Report
{
    partial class Employeer_Report
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
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Employeer = new Main_Form.Reports.Employeer_Report.Employeer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeesTableAdapter = new Main_Form.Reports.Employeer_Report.EmployeerTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employeer)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.Employeer;
            // 
            // Employeer
            // 
            this.Employeer.DataSetName = "Employeer";
            this.Employeer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main_Form.Reports.Employeer_Report.Employeer_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(932, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmployeesTableAdapter
            // 
            this.EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // Employeer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 599);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Employeer_Report";
            this.Text = "Employeer_Report";
            this.Load += new System.EventHandler(this.Employeer_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employeer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private Employeer Employeer;
        private EmployeerTableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
    }
}