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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Stock_Load(object sender, EventArgs e)
        {
            GridInfo();
            CreateID_PlaceAdapter();
            CreateID_SupplyAdapter();
            CreateID_ProductAdapter();
            CreateQtyAdapter();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"SELECT 
                            ID_Place
                            ,Name
                            ,Date
                            ,ID_OrdersSupply
                            ,Qty
                            FROM Stock AS S
                            JOIN Product AS P ON P.ID_Product = S.ID_Product";
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
                "Код Розміщення",
                "Назва продукту",
                "Дата",
                "Код Постачання",
                "Кількість"
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }
        public void CreateID_PlaceAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID_Place FROM PlaceOfProduct", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_Place", typeof(string));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Place.ValueMember = "ID_Place";
                ID_Place.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
        public void CreateID_SupplyAdapter()
        {
            try
            {
                connections.Open();
                DataSet data = new DataSet();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(@"SELECT ID_Supply FROM OrdersOfSupply", connections);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                ID_Supply.ValueMember = "ID_Supply";
                ID_Supply.DataSource = dataTable;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
        public void CreateQtyAdapter()
        {
            try
            {
                connections.Open();
                DataSet data = new DataSet();
                string query = @"Select Qty from OrdersOfSupply
                where ID_Supply = "+ID_Supply.Text+"";
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(query, connections);
                Qty.Text = command.ExecuteScalar().ToString();
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
                string query = @"Select DISTINCT Product.Name as 'Name',
                                        Product.ID_Product as 'ID' from Product
                                        join OrdersOfSupply on Product.ID_Product = OrdersOfSupply.ID_Product";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Product.ValueMember = "ID";
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
                    ID_Place.Text = row.Cells["ID_Place"].Value.ToString();
                    ID_Product.Text = row.Cells["Name"].Value.ToString();
                    Date.Text = row.Cells["Date"].Value.ToString();
                    ID_Supply.Text = row.Cells["ID_OrdersSupply"].Value.ToString();
                    Qty.Text = row.Cells["Qty"].Value.ToString();
                
                }
            }
            catch (Exception exe)
            {
                connections.Close();
                MessageBox.Show(exe.ToString());
            }

        }
         
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"INSERT INTO Stock(ID_Place, ID_Product, Date, ID_OrdersSupply, Qty)VALUES('"+ID_Place.Text+"'," + ID_Product.SelectedValue + ",@Date," + ID_Supply.Text + "," + Qty.Text + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Date.Value.Date;
                command.ExecuteNonQuery();
                MessageBox.Show($"Продук додано на склад {ID_Product.Text}",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                               );
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
                if (Qty.Text == "" || Date.Text == "")
                {
                    MessageBox.Show("Потрібно заповнити всі поля");
                }
                connections.Open();
                string query = "Update Stock set ID_Product = " + ID_Product.SelectedValue + ", Date = @Date, ID_OrdersSupply =" + ID_Supply.Text + ", Qty = '" + Qty.Text + "' where ID_Place =" + ID_Place.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Date.Value.Date;
                command.ExecuteNonQuery();
                MessageBox.Show("Дані оновленно");
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
                string query = "delete from Stock where ID_Place = " + ID_Place.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                MessageBox.Show($"Товар видалено з місця, {ID_Place.Text}",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                               );
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString(), MessageBoxButtons.OK.ToString());
            }

        }

        
    }
}
