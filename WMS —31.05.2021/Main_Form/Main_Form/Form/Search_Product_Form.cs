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
    public partial class Search_Product_Form : Form
    {
        public Search_Product_Form()
        {
            InitializeComponent(); 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Search_Product_Form_Load(object sender, EventArgs e)
        {
            GridInfo();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = "Select ID_Product, Name, Description, Price from Product";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader["ID_Product"].ToString();
                data[data.Count - 1][1] = reader["Name"].ToString();
                data[data.Count - 1][2] = reader["Description"].ToString();
                decimal price = Math.Round(Convert.ToDecimal(reader["Price"]), 2);
                data[data.Count - 1][3] = price.ToString().Replace(',', '.');
            }
            foreach (string[] item in data)
            {
                dataGridView1.Rows.Add(item);
            }
            reader.Close();
           
            connections.Close();
        }
        void ColumName()
        {
            string[] names = new string[]
            {
                "Код продукту",
                "Назва",
                "Опис",
                "Ціна"
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search_T.Text == "")
                {
                    MessageBox.Show("Виберіть поле для пошуку та тип пошуку");
                }
                else
                {
                    string seachr = "";
                    if (radioButton1.Checked == true)
                    {
                        seachr = "Name";
                        Search_Label.Text = "Назва";

                    }
                    else if (radioButton2.Checked == true)
                    {
                        seachr = "Description";
                        Search_Label.Text = "Опис";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        seachr = "Price";
                        Search_Label.Text = "Ціна";
                    }
                    dataGridView1.Rows.Clear();
                    connections.Open();
                    bool  text = int.TryParse(Search_T.Text, out int num);
                    string query = "";
                    if (text)
                    {
                         query = "Select ID_Product, Name, Description, Price from Product Where  " + seachr + " like '%" + Search_T.Text + "%'";
                    }
                    else
                         query = "Select ID_Product, Name, Description, Price from Product Where  " + seachr + " like '%" + Search_T.Text + "%'";
                    SqlCommand command = new SqlCommand(query, connections);
                    SqlDataReader reader = command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[4]);
                        data[data.Count - 1][0] = reader["ID_Product"].ToString();
                        Name_Product.Text =  data[data.Count - 1][1] = reader["Name"].ToString();
                        Description.Text =  data[data.Count - 1][2] = reader["Description"].ToString();
                        decimal price = Math.Round(Convert.ToDecimal(reader["Price"]), 2);
                        Price.Text = data[data.Count - 1][3] = price.ToString().Replace(',', '.');
                    }
                    connections.Close();
                    foreach (string[] item in data)
                    {
                        dataGridView1.Rows.Add(item);
                    }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Name_Product.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Description.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void Migrate_Click(object sender, EventArgs e)
        {
            PlacementProduct placement = new PlacementProduct();
            placement.Product.Text = Name_Product.Text;
            placement.Description.Text = Description.Text;
            placement.Price.Text = Price.Text;
            placement.Show();
            this.Hide();
        }
    }
}