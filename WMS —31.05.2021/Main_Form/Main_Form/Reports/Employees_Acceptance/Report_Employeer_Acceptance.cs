using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Reports.Employees_Acceptance
{
    public partial class Report_Employeer_Acceptance : Form
    {
        public Report_Employeer_Acceptance()
        {
            InitializeComponent();
        }

        private void Report_Employeer_Acceptance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Employeer_Acceptance.Employees". При необходимости она может быть перемещена или удалена.
            this.EmployeesTableAdapter.Fill(this.Employeer_Acceptance.Employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
