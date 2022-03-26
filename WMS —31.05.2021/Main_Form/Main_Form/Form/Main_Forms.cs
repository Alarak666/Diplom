using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Main_Forms : Form
    {
        public Main_Forms()
        {
            InitializeComponent();
        }

        private void BOrders_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void BEmployee_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
           
        }

        private void Main_Forms_Load(object sender, EventArgs e)
        {

        }

        private void BProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void BProvider_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.Show();
        }

        private void BOrderDetails_Click(object sender, EventArgs e)
        {
            OrdersDateils employee = new OrdersDateils();
            employee.Show();
        }

        private void BEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo employee = new EmployeeInfo();
            employee.Show();
        }

        private void OrdersSupply_Click(object sender, EventArgs e)
        {
            OrderOfSupply supply = new OrderOfSupply();
            supply.Show();
        }

        private void CreateOrders_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            order.Show();
        }

        private void BPost_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.Show();
        }

        private void BPlaceProducts_Click(object sender, EventArgs e)
        {
            FormAcceptance  acceptance = new FormAcceptance();
            acceptance.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlacementProduct PlacementProducts = new PlacementProduct();
            PlacementProducts.Show();
        }
        private void BStocks_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void Supply_Order_Click(object sender, EventArgs e)
        {
            OrderOfSupply orderOfSupply = new OrderOfSupply();
            orderOfSupply.Show();
        }
    }
}
