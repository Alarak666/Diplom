using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form.Reports.PlaceProduct_Report_Place
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Place_Product_Place.PlaceOfProduct". При необходимости она может быть перемещена или удалена.
            this.PlaceOfProductTableAdapter.Fill(this.Place_Product_Place.PlaceOfProduct);

            this.reportViewer1.RefreshReport();
        }
    }
}
