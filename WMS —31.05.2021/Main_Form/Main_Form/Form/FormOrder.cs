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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void FormOrder_Load(object sender, EventArgs e)
        {
            GridInfo();
            InfoProduct();
            InfoProducts();
            InfoEmployee();
            InfoOrder();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"SELECT OD.ID_Order
                             ,CONCAT(FName,' ',SUBSTRING(MName,1,1), '.', ' ', SUBSTRING(LName,1,1),'.') AS 'FIO'
		                    ,Order_Status
                            ,Date_Orders 
                            ,[Name]
                            ,Qty
                    FROM OrdersDateils AS OD
                    JOIN Orders AS O ON O.ID_Order = OD.ID_Order
	                    JOIN Product AS P ON OD.ID_Product = P.ID_Product
		                    JOIN Employees AS E ON O.ID_Employee = E.ID";
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
            dataGridView1.Columns[0].HeaderText = "Код_замовлення";
            dataGridView1.Columns[1].HeaderText = "Працівник";
            dataGridView1.Columns[2].HeaderText = "Статус";
            dataGridView1.Columns[3].HeaderText = "Дата";
            dataGridView1.Columns[4].HeaderText = "Продукт";
            dataGridView1.Columns[5].HeaderText = "Кількість";
            
        }
        public void InfoEmployee()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID" +
                    ",CONCAT(FName,' ', SUBSTRING(MName,1,1),'. ',SUBSTRING(LName,1,1),'.') AS 'FIO' FROM Employees", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Employee.ValueMember = "ID";
                ID_Employee.DisplayMember = "FIO";
                ID_Employee.DataSource = data;
                connections.Close();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        public void InfoOrder()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("Select ID_Order from Orders", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Order.DisplayMember = "ID_Order";
                ID_Order.ValueMember = "ID_Order";
                ID_Order.DataSource = data;
                connections.Close();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        public void InfoProducts()
        {
            try
            {
                connections.Open();
                DataSet data = new DataSet();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(@"Select Stock.ID_Product, Name from Stock
join Product on Stock.ID_Product = Product.ID_Product", connections);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                EditProduct.DisplayMember = "Name";
                EditProduct.ValueMember = "ID_Product";
                EditProduct.DataSource = dataTable;
                connections.Close();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        public void InfoProduct()
        {
            try
            {
                connections.Open();
                DataSet data = new DataSet();
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(@"Select Stock.ID_Product, Name from Stock
                join Product on Stock.ID_Product = Product.ID_Product", connections);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                Product.DisplayMember = "Name";
                Product.ValueMember = "ID_Product";
                Product.DataSource = dataTable;
                connections.Close();
                
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        private void AddOrdersDetails(int i)
        {
            try
            {
                connections.Open();
                string query = @"INSERT INTO OrdersDateils
                                       (ID_Order
                                       ,ID_Product
                                       ,Qty)
                                       VALUES
                                       (" + ID_Order.SelectedValue + "" +
                             "," + dataGridView2.Rows[i].Cells[0].Value.ToString() + "" +
                             "," + dataGridView2.Rows[i].Cells[1].Value.ToString() + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int a = 0; a < exc.Errors.Count; a++)
                {
                    errorMessages.Append("Index #" + a + "\n" +
                        "Message: " + exc.Errors[a].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"Select ID_Order FROM Orders Where ID_Order = " + ID_Order.SelectedValue + "";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rd = command.ExecuteReader();
                if (rd.Read())
                {
                    connections.Close();
                    for (int i = 0; i < dataGridView2.Rows.Count-1 ; i++)
                    {
                        AddOrdersDetails(i);
                    }
                }
                else
                {
                    connections.Close();
                    connections.Open();
                    query = @"INSERT INTO Orders
                                (ID_Employee
                                ,Order_Status
                                ,Date_Orders)
                                 VALUES(" + ID_Employee.Text + "" +
                                           "," + Order_Status.Text + "" +
                                           ", @Date )";
                    command = new SqlCommand(query, connections);
                    command.Parameters.Add("@Date", SqlDbType.Date).Value = Data.Value.Date;
                    command.ExecuteNonQuery();
                    connections.Close();
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        AddOrdersDetails(i);
                    }
                }
                GridInfo();
                DeleteFormPlaceOfProduct();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
            
        }
        void DeleteFormPlaceOfProduct()
        {
            int rows = dataGridView2.RowCount;
            string[] delete = new string[rows];
            for (int i = 0; i < dataGridView2.RowCount-1; i++)
            {
                delete[i] = dataGridView2.Rows[i].Cells[2].Value.ToString();
            }
            for (int i = 0; i < dataGridView2.RowCount-1; i++)
            {
                connections.Open();
                string query = "delete from PlaceOfproduct where id_Place = '"+delete[i]+"'";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
            }
        }
        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"Update Orders
                                  Set ID_Employee = " + ID_Employee.SelectedValue + "" +
                                  ",Order_Status =" + Order_Status.Text + "" +
                                  ",Date_Orders = @Date " +
                                  "where ID_Order = " + ID_Order.SelectedValue + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = Data.Value.Date;
                command.ExecuteNonQuery();
                connections.Close();
                connections.Open();
                query = @"UPDATE OrdersDateils
                          SET ID_Order = " + ID_Order.SelectedValue + "" +
                             ",ID_Product =" + EditProduct.SelectedValue.ToString()+ "" +
                             ",Qty = +" + TQty.Text + "" +
                             "WHERE ID_Order = " + ID_Order.SelectedValue + " and ID_Product ="+EditProduct.SelectedValue+" ;";
                command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                ENDVisibles();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "delete from OrdersDateils where ID_Order = " + ID_Order.SelectedValue + " and ID_Product =" + EditProduct.SelectedValue + " ;";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                ENDVisibles();
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID_Order.SelectedValue = row.Cells["ID_Order"].Value.ToString();
                    ID_Employee.Text = row.Cells["FIO"].Value.ToString();
                    Order_Status.Text = row.Cells["Order_Status"].Value.ToString();
                    EditProduct.Text = row.Cells["Name"].Value.ToString();
                    TQty.Text = row.Cells["Qty"].Value.ToString();
                    Visibles();
                    
                }
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
        private void Visibles()
        {
            EditProduct.Visible = true;
            TQty.Visible = true;
            EDITORDERS.Visible = true;
        }
        private void ENDVisibles()
        {
            EditProduct.Visible = false;
            TQty.Visible = false;
            EDITORDERS.Visible = false;
        }
        private void BSum_Click(object sender, EventArgs e)
        {
            connections.Open();
            string query = @"SELECT O.ID_Order
	                               ,CONCAT(FName,' ',SUBSTRING(MName,1,1), '.', ' ', SUBSTRING(LName,1,1),'.') AS 'FIO'
	                               ,O.Order_Status
	                               ,O.Date_Orders
	                               ,P.Name
	                               ,OD.Qty
	                               ,Round(P.Price,1,1) AS 'Ціна'
	                               ,Round(SUM(Price * Qty),1,1)AS 'Сума'
                            FROM Orders AS O
                            JOIN OrdersDateils AS OD
                            ON O.ID_Order = OD.ID_Order
                            JOIN Product AS P
                            ON P.ID_Product = OD.ID_Product
							JOIN Employees AS E
                            ON E.ID = O.ID_Employee
                            GROUP BY
		                            O.ID_Order
	                               ,CONCAT(FName,' ',SUBSTRING(MName,1,1), '.', ' ', SUBSTRING(LName,1,1),'.') 
	                               ,O.Order_Status
	                               ,O.Date_Orders
	                               ,P.Name
	                               ,OD.Qty
	                               ,P.Price";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            ColumName();
            connections.Close();
            
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int column = dataGridView2.CurrentCell.ColumnIndex;
            int rows = dataGridView2.CurrentCell.RowIndex;
            try
            {
                if (column == 0)
                {
                    DataGridViewComboBoxCell product = dataGridView2.Rows[e.RowIndex].Cells[0] as DataGridViewComboBoxCell;
                    DataGridViewComboBoxCell qty = dataGridView2.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell;
                    string mproduct = product.Value.ToString();
                    connections.Open(); 
                    string query = @"Select  qty from stock
                                    join product on product.id_product = stock.id_product 
                                    where product.id_product =  " + mproduct + " and ID_ordersSupply = " +
                                    "(Select min(ID_ordersSupply) from stock" +
                                    " where id_product = " + mproduct + ")";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connections);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string qtys = row["Qty"].ToString();
                        dataGridView2.Rows[rows].Cells[1].Value = qtys;
                    }
                    
                    connections.Close();
                    connections.Open();
                    query = @"Select ID_Place from stock
                                    join product on product.id_product = stock.id_product 
                                    where product.id_product =  " + mproduct + " and ID_ordersSupply = " +
                                    "(Select min(ID_ordersSupply) from stock" +
                                    " where id_product = " + mproduct + ")";
                    dataAdapter = new SqlDataAdapter(query, connections);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string palet = row["ID_Place"].ToString();
                        dataGridView2.Rows[rows].Cells[2].Value = palet;
                    }
                    connections.Close();
                }
                
            }
            catch (SqlException exc)
            {
                StringBuilder errorMessages = new StringBuilder();
                connections.Close();
                for (int i = 0; i < exc.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + exc.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void Orderss_Click(object sender, EventArgs e)
        {
            GridInfo();
        }
    }
}