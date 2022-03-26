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
    public partial class PlacementProduct : Form
    {
        public PlacementProduct()
        {
            InitializeComponent();
            CreateID_ProviderAdapter();
            CreateID_Product();
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void PlacementProduct_Load(object sender, EventArgs e)
        {
            
        }
        
        private void ADDProduct_Click(object sender, EventArgs e)
        {
            CreateID_ProductAdapter();
        }
        public void CreateID_ProductAdapter()
        {
            try
            {
                connections.Open();
                string query = @"SELECT ID_Product
                                FROM Product WHERE Name = '" + Product.Text + "' and description = '"+Description.Text+"'";
                SqlCommand command = new SqlCommand(query, connections);
                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {

                    DataSet ds = new DataSet();
                    da.Fill(ds, "Product");
                    ID_Product.Text = ds.Tables[0].Rows[0]["ID_Product"].ToString();
                    connections.Close();
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        
        public void CreateID_Product()
        {
            connections.Open();
            string query = "SELECT DISTINCT Name FROM Product";
            SqlCommand command = new SqlCommand(query, connections);
            command.ExecuteNonQuery();
            SqlDataReader rd = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rd);       
            Product.DisplayMember = "Name";
            Product.ValueMember = "Name";
            Product.DataSource = data;
            connections.Close();
            Description.Enabled = false;
        }
        public void CreateID_ProviderAdapter()
        {
            try
            {
                connections.Open();
                string query = @"SELECT ID,
                                CONCAT(MName, ' ', SUBSTRING(FNAME,1,1), '.', ' ', SUBSTRING(LNAME,1,1), '.', ' ') AS 'Прізвище'
                                FROM [PROVIDER]";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(string));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Provider.DisplayMember = "Прізвище";
                ID_Provider.ValueMember = "ID";
                ID_Provider.DataSource = data;
                connections.Close();
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connections.State == ConnectionState.Closed)
            {
                connections.Open();
                string query = "SELECT Description FROM Product Where Name = '"+Product.Text+"'";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                SqlDataReader rd = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rd);
                Description.ValueMember = "Description";
                Description.DisplayMember = "Description";
                Description.DataSource = data;
                connections.Close();
                Description.Enabled = true;
            }
        }
        private void Description_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connections.State == ConnectionState.Closed)
            {
                connections.Open();
                string query = "SELECT Price FROM Product Where Description = '" + Description.Text + "'";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    decimal price = Math.Round(Convert.ToDecimal(rd["Price"]),2);
                    Price.Text = price.ToString().Replace(',','.');
                }
                
                connections.Close();
            }
        }
        private void ADDOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"INSERT INTO OrdersOfSupply(ID_Provider, Qty, Date_Orders, ID_Product)VALUES(" + ID_Provider.SelectedValue.ToString() + "," + Qty.Text + ", @Date, " + ID_Product.Text + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Date.Value.Date;
                command.ExecuteNonQuery();
                MessageBox.Show("Додано Замовлення");
                connections.Close();
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search_Product_Form search = new Search_Product_Form();
            search.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            OrderOfSupply order = new OrderOfSupply();
            order.Show();
        }
    }
}
