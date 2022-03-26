using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class OrdersDateils : Form
    {
        public OrdersDateils()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");

        private void OrdersDateils_Load(object sender, EventArgs e)
        {
            GridInfo();
            CreateID_OrderAdapter();
            CreateID_ProductAdapter();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"Select ID_Order
		                            ,Name
		                            ,Qty 
                            from OrdersDateils
                            join product on product.Id_product = ordersdateils.id_product
                            ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            ColumName();
            connections.Close();
        }
        public void ColumName()
        {
            string[] names = new string[]
            {
                "Код замовлення",
                "Продукт",
                "Кількість"
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }
        public void CreateID_OrderAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID_Order FROM Orders", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_Order", typeof(string));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Order.ValueMember = "ID_Order";
                ID_Order.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
        public void CreateID_ProductAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID_Product, Name  FROM Product", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Product.ValueMember = "ID_Product";
                ID_Product.DisplayMember = "Name";
                ID_Product.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID_Order.Text = row.Cells["ID_Order"].Value.ToString();
                    ID_Product.Text = row.Cells["Name"].Value.ToString();
                    Qty.Text = row.Cells["Qty"].Value.ToString();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO OrdersDateils(ID_Order, ID_Product, Qty) VALUES(" + ID_Order.Text + "," + ID_Product.SelectedValue + "," + Qty.Text + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано замовлення");
                connections.Close();
                GridInfo();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "Update OrdersDateils Set ID_Product = "+ID_Product.SelectedValue+", Qty = "+Qty.Text+" where ID_Order = " + ID_Order.Text + " and ID_Product = "+ID_Product.SelectedValue + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Оновлення замовлення");
                connections.Close();
                GridInfo();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "delete from OrdersDateils where ID_Order =  " + ID_Order.SelectedValue + " and ID_Product = " + ID_Product.SelectedValue + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                MessageBox.Show("Видалено");

            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
