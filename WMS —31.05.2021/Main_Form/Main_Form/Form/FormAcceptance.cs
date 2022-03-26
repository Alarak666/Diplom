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
    public partial class FormAcceptance : Form
    {
        public FormAcceptance()
        {
            InitializeComponent();
        }
        public int ID_Products;
        public void CreateID_ProductAdapter()
        {
            try
            {
                connections.Open();
                string query = @"SELECT ID_Product,
                                Name
                                FROM [Product]";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_Product", typeof(string));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Product.DisplayMember = "Name";
                ID_Product.ValueMember = "ID_Product";
                ID_Product.DataSource = data;
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
                string query = @"Select ID_Supply FROM OrdersOfSupply";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Supply.ValueMember = "ID_Supply";
                ID_Supply.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
        public void CreateID_EmployerAdapter()
        {
            try
            {
                connections.Open();
                string query = @"SELECT ID,
                                CONCAT(MName, ' ', SUBSTRING(FNAME,1,1), '.', ' ', SUBSTRING(LNAME,1,1), '.', ' ') AS 'Прізвище'
                                FROM [Employees]";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Employyer.DisplayMember = "Прізвище";
                ID_Employyer.ValueMember = "ID";
                ID_Employyer.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
        public void CreateType_PalletAdapter()
        {
            try
            {
                connections.Open();
                string query = @"select ID_Type , CONCAT(Type_Pallet,' | ',TP.Lenght,'x',TP.Height,'x',TP.Width)as 'Розмір' from Type_Pallet TP 
 ";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Type_Pallet.DisplayMember = "Розмір";
                Type_Pallet.ValueMember = "ID_Type";
                Type_Pallet.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"SELECT ID_Acceptance
		                    ,Type_Pallet.Type_Pallet
		                    ,Product.Name
		                    ,CONCAT(Employees.MName, ' ', Employees.FName, '.', ' ', Employees.LName,'.') AS 'ПІБ'
		                    ,AcceptanceOfGoods.Width
		                    ,AcceptanceOfGoods.Heigth
		                    ,AcceptanceOfGoods.Length
		                    ,AcceptanceOfGoods.Weight
		                    ,AcceptanceOfGoods.Qty
		                    ,AcceptanceOfGoods.Date_Accepts
		                    ,AcceptanceOfGoods.Data_Expiration
		                    ,N_Pallet
		                    ,OOS.ID_Supply FROM AcceptanceOfGoods
		                    JOIN Product ON Product.ID_Product = AcceptanceOfGoods.ID_Product
		                    JOIN Employees ON Employees.ID = AcceptanceOfGoods.ID_Employer
		                    JOIN Type_Pallet ON Type_Pallet.ID_Type = AcceptanceOfGoods.ID_Type_Pallet
		                    JOIN OrdersOfSupply OOS ON OOS.ID_Supply = AcceptanceOfGoods.ID_SupplyProuduct";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
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
                "Код прийому",
                "Тип палети",
                "Продукт",
                "Працівник",
                "Ширина",
                "Висота",
                "Длина",
                "Вага",
                "Кількість товару",
                "Дата прийому товару",
                "Дата придатности товару",
                "Номер палети",
                "Номер постачання"
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }
        private void FormAcceptance_Load(object sender, EventArgs e)
        {
            GridInfo();
            CreateID_ProductAdapter();
            CreateID_EmployerAdapter();
            CreateType_PalletAdapter();
            //CreateID_SupplyAdapter();
            ID_Product.SelectedIndex = ID_Products-1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        public void Add_Info()
        {
            connections.Open();
            string query = @"INSERT INTO [dbo].[AcceptanceOfGoods]
           ([ID_Type_Pallet]
           ,[ID_Product]
           ,[ID_Employer]
           ,[Width]
           ,[Heigth]
           ,[Length]
           ,[Weight]
           ,[Qty]
           ,[Data_Expiration]
           ,[ID_SupplyProuduct])
     VALUES
           (" + Type_Pallet.SelectedValue + "" +
           "," + ID_Product.SelectedValue + "" +
           "," + ID_Employyer.SelectedValue + "" +
           "," + _Width.Text + "" +
           "," + _Height.Text + "" +
           "," + _Lenght.Text + "" +
           "," + _Weight.Text + "" +
           "," + Qty.Text + "" +
           ",@Date_Expiration" +
           ","+ID_Supply.Text+");";
            SqlCommand command = new SqlCommand(query, connections);
            command.Parameters.Add("@Date_Expiration", SqlDbType.Date).Value = Date_Expiration.Value;
            command.ExecuteNonQuery();
            connections.Close();
            GridInfo();
        }
        public void InsertChecked()
        {
            connections.Open();
            string query = @"UPDATE [dbo].[OrdersOfSupply]
                            SET [Status] = 1
                            WHERE ID_Supply = "+ID_Supply.Text+"";
            SqlCommand command = new SqlCommand(query, connections);
            command.ExecuteNonQuery();
            connections.Close();
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Info();
                AdapterAcceptance_ID();
                InsertChecked();
                Reports.Acceptance_ID_Pallet.Pallet_View _View = new Reports.Acceptance_ID_Pallet.Pallet_View();
                _View.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }
        public void AdapterAcceptance_ID()
        {
            connections.Open();
            string query = @"SELECT TOP 1 ID_Acceptance, N_Pallet 
                                FROM AcceptanceOfGoods ORDER BY ID_Acceptance DESC";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            while(rdr.Read())
            {
                string parameterID_Acceptance = rdr["ID_Acceptance"].ToString();
                string parameterN_Pallet = rdr["N_Pallet"].ToString();
                ID_Acceptance.Text = parameterID_Acceptance;
                ID_Pallet.Text = parameterN_Pallet;
            }
            connections.Close();
        }
        private void PlaceOfProduct_Click(object sender, EventArgs e)
        {
            Add_Info();
            AdapterAcceptance_ID();
            InsertChecked();
            PlaceOfProduct placeOfProduct = new PlaceOfProduct();
            placeOfProduct.ID_Pallet.Text = ID_Pallet.Text;
            placeOfProduct.ID_acceptances = Convert.ToInt32(ID_Acceptance.Text);
            double parameter = (Convert.ToDouble(_Width.Text) / 1000 * Convert.ToDouble(_Height.Text) / 1000 * Convert.ToDouble(_Lenght.Text) / 1000) * Convert.ToDouble(Qty.Text);
            placeOfProduct.Parameter_Product.Text =Convert.ToString(Math.Round(parameter, 4).ToString().Replace(',', '.'));
            placeOfProduct.ID_acceptances =Convert.ToInt32(ID_Acceptance.Text);
            placeOfProduct.Date_Aceptance = DateAcceptance.Value.ToString("dd.MM.yyyy");
            placeOfProduct.Date_Expiration = Date_Expiration.Value.ToString("dd.MM.yyyy");
            placeOfProduct.ID_Product =Convert.ToInt32(ID_Product.SelectedValue.ToString());
            placeOfProduct.Qty = Convert.ToInt32(Qty.Text.ToString());
            placeOfProduct.ID_Supply = Convert.ToInt32(ID_Supply.Text.ToString());
            placeOfProduct.Show();
        }
    }
}
