
namespace Main_Form.Reports.Employees_Acceptance
{
    partial class Report_Employeer_Acceptance
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
            this.Employeer_Acceptance = new Main_Form.Reports.Employees_Acceptance.Employeer_Acceptance();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesTableAdapter = new Main_Form.Reports.Employees_Acceptance.Employeer_AcceptanceTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Employeer_Acceptance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main_Form.Reports.Employees_Acceptance.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Employeer_Acceptance
            // 
            this.Employeer_Acceptance.DataSetName = "Employeer_Acceptance";
            this.Employeer_Acceptance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.Employeer_Acceptance;
            // 
            // EmployeesTableAdapter
            // 
            this.EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Employeer_Acceptance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Employeer_Acceptance";
            this.Text = "Report_Employeer_Acceptance";
            this.Load += new System.EventHandler(this.Report_Employeer_Acceptance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employeer_Acceptance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private Employeer_Acceptance Employeer_Acceptance;
        private Employeer_AcceptanceTableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
    }
}