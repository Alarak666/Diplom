using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Reports.Provider_Report
{
    public partial class Provider_Report : Form
    {
        public Provider_Report()
        {
            InitializeComponent();
        }

        private void Provider_Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Provider_DataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.ProviderTableAdapter.Fill(this.Provider_DataSet.Provider);

            this.reportViewer1.RefreshReport();
        }
    }
}
