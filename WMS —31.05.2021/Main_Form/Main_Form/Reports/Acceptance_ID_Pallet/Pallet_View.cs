using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Reports.Acceptance_ID_Pallet
{
    public partial class Pallet_View : Form
    {
        public Pallet_View()
        {
            InitializeComponent();
        }

        private void Pallet_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Acceptance_IDxsd.AcceptanceOfGoods". При необходимости она может быть перемещена или удалена.
            this.AcceptanceOfGoodsTableAdapter.Fill(this.Acceptance_IDxsd.AcceptanceOfGoods);

            this.reportViewer1.RefreshReport();
        }
    }
}
