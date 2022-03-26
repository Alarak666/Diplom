using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Reports.Employeer_Report
{
    public partial class Employeer_Report : Form
    {
        public Employeer_Report()
        {
            InitializeComponent();
        }

        private void Employeer_Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Employeer.Employees". При необходимости она может быть перемещена или удалена.
            this.EmployeesTableAdapter.Fill(this.Employeer.Employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
