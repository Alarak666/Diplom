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
    public partial class OrderOfSupply : Form
    {
        public OrderOfSupply()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");

        private void OrderOfSupply_Load(object sender, EventArgs e)
        {
            GridInfo();
            CreateID_ProductAdapter();
            CreateID_ProviderAdapter();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"SELECT ID_Supply
		                            ,CONCAT(PD.MName,' ', SUBSTRING(PD.FName,1 ,1),'.',' ',SUBSTRING(PD.LName,1,1),'.') AS 'ПІБ'
		                            ,Qty
		                            ,Status
		                            ,Date_Orders
		                            ,Name 
                            FROM OrdersOfSupply O
                            JOIN Product P ON O.ID_Product = P.ID_Product
                            JOIN Provider PD ON PD.ID = O.ID_Provider
							WHERE O.Status = 0;";
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
                "Код постачання",
                "Постачальник",
                "Кількість",
                "Статус",
                "Дата",
                "Продукт"
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }
        public void CreateID_ProviderAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand(@"SELECT ID
                                                            ,CONCAT(E.MName,' ', SUBSTRING(E.FName,1 ,1),'.',' ',SUBSTRING(E.LName,1,1),'.') AS 'ПІБ'
                                                        FROM Provider E", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Provider.ValueMember = "ID";
                ID_Provider.DisplayMember = "ПІБ";
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
        public void CreateID_ProductAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID_Product, Name FROM Product", connections);
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

        }


        private void ADD_Click(object sender, EventArgs e)
        {

        }

        private void EDIT_Click(object sender, EventArgs e)
        {

        }
        private void DELETE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ID_Supply.Text = row.Cells["ID_Supply"].Value.ToString();
                ID_Provider.Text = row.Cells["ПІБ"].Value.ToString();
                Qty.Text = row.Cells["Qty"].Value.ToString();
                Status.Checked = Convert.ToBoolean(row.Cells["Status"].Value.ToString());
                Date.Value =DateTime.Parse(row.Cells["Date_Orders"].Value.ToString());
                ID_Product.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void Supply_Acceptance_Click(object sender, EventArgs e)
        {
            FormAcceptance acceptance = new FormAcceptance();
            acceptance.ID_Supply.Text = ID_Supply.Text;
            acceptance.ID_Products = Convert.ToInt32(ID_Product.SelectedValue.ToString());
            acceptance.Show();
        }

        private void AllOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"SELECT ID_Supply
		                            ,CONCAT(PD.MName,' ', SUBSTRING(PD.FName,1 ,1),'.',' ',SUBSTRING(PD.LName,1,1),'.') AS 'ПІБ'
		                            ,Qty
		                            ,Status
		                            ,Date_Orders
		                            ,Name 
                            FROM OrdersOfSupply O
                            JOIN Product P ON O.ID_Product = P.ID_Product
                            JOIN Provider PD ON PD.ID = O.ID_Provider";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                ColumName();
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

        private void back_order_Click(object sender, EventArgs e)
        {
            GridInfo();
        }

        private void ADD_Click_1(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"INSERT INTO [dbo].[OrdersOfSupply]
                               ([ID_Provider]
                               ,[Qty]
                               ,[Status]
                               ,[Date_Orders]
                               ,[ID_Product])
                         VALUES
                               (" + ID_Provider.SelectedValue + "" +
                                   "," + Qty.Text + "" +
                                   ",@Status" +
                                   ",@Date" +
                                   "," + ID_Product.SelectedValue + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Date.Value.Date;
                command.Parameters.Add("@Status", SqlDbType.Bit).Value = Status.Checked;
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
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

        private void EDIT_Click_1(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"UPDATE[dbo].[OrdersOfSupply]
                               SET [ID_Provider] = "+ID_Provider.SelectedValue+""+
                                ",[Qty] = " + Qty.Text + "" +
                                    ",[Status] = @Status" +
                                    ",[Date_Orders] = @Date" +
                                    ",[ID_Product] = " + ID_Product.SelectedValue + "" +
                                    " WHERE ID_Supply = " + ID_Supply.Text + "";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Date.Value.Date;
                command.Parameters.Add("@Status", SqlDbType.Bit).Value = Status.Checked;
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
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

        private void DELETE_Click_1(object sender, EventArgs e)
        {

        }
    }
}
