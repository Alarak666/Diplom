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
    public partial class PlaceOfProduct : Form
    {
        public class Place
        {
            public int ID { get; set; }
            public string place { get; set; }
        }
        public class Rack
        {
            public int ID { get; set; }
            public string rack { get; set; }
        }
        public PlaceOfProduct()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        public int ID_acceptances;
        public string Date_Aceptance = "12.11.2021";
        public string Date_Expiration ="13.12.2021";
        public int ID_Supply;
        public int Qty;
        public int ID_Product;
        private void PlaceOfProduct_Load(object sender, EventArgs e)
        {
            GridInfo();
            InfoRegion();
            InfoArea();
            InfoRack();
            InfoLevel();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"Select Region,
		                            Area,
		                            Rack,
		                            Level,
		                            Place,
		                            AOG.N_Pallet,
		                            Storage_notes,
		                            PPa.Length/1000*PPa.Height/1000*PPa.Width/1000 as'Place_parameter',
		                            ROUND((AOG.Length/1000* AOG.Heigth/1000*AOG.Width/1000)*AOG.Qty,2)as'Product_parameter',
		                            OccupiedPlace,
		                            PP.ID_Place from PlaceOfProduct as PP
                            join AcceptanceOfGoods as AOG on AOG.ID_Acceptance =PP.ID_Acceptance
                            JOIN Place_Parameters as PPa ON PPa.ID_Parametrs = PP.ID_Parameters";
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
                "Область",
                "Регіон",
                "Стелаж",
                "Рівень",
                "Місце",
                "Номер палети",
                "Нотатки",
                "Параметри місця",
                "Параметри товару",
                "Розміщено",
                "Код місця",
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }

        void InfoRegion()
        {
            connections.Open();
            string query = "Select ID_Region, Description from  Region_Type";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            _Region.DisplayMember = "Description";
            _Region.ValueMember = "ID_Region";
            _Region.DataSource = data;
            connections.Close();
        }
        void InfoArea()
        {
            connections.Open();
            string query = "Select ID_Area, Description from Area_Type";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            Area.DisplayMember = "Description";
            Area.ValueMember = "ID_Area";
            Area.DataSource = data;
            connections.Close();
        }
        void InfoRack()
        {
            int data = 0;
            
            connections.Open();
            string query = @"Select Rack_Qty from Area_Type WHERE ID_Area = "+ Area.SelectedValue + "";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            while(rdr.Read())
            {
                data = Convert.ToInt32(rdr["Rack_Qty"].ToString());
            }
            List<Rack> racks= new List<Rack>();
            for (int i = 0; i < data; i++)
            {
                racks.Add(new Rack() { ID = i + 1,rack = $"Стелаж - {i+1}" });
            }
            connections.Close();
            _Rack.DataSource = racks;
            _Rack.ValueMember = "ID";
            _Rack.DisplayMember = "rack";
        }
        void InfoLevel()
        {
            connections.Close();
            for (int i = 0; i <= 4; i++)
            {
                _Level.Items.Add($"Рівень - {i}");
            }
        }
         int[] VisiblePlace(ref int[] ocupaid)
        {
            int Region_ = int.Parse(_Region.SelectedValue.ToString());
            int Area_ = int.Parse(Area.SelectedValue.ToString());
            int Rack_ = int.Parse(_Rack.SelectedIndex.ToString());
            int Level_ = int.Parse(_Level.SelectedIndex .ToString());
            Rack_++;
            connections.Open();
            string query = "Select place from placeofproduct where Region = " + Region_ + " and " +
                "Area = " + Area_ + " and " +
                "Rack = " + Rack_ + " and " +
                "Level = " + Level_ + "";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ocupationRead = int.Parse(reader["place"].ToString());
                ocupaid[ocupationRead-1] = ocupationRead;
            }
            connections.Close();
            return ocupaid;
        }
        void InfoPlace()
        {
            int data = 0;
            
            connections.Open();
            string query = @"Select Qty_Place from Area_Type WHERE ID_Area =" + Area.SelectedValue + "";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                data = Convert.ToInt32(rdr["Qty_Place"].ToString());
            }
            int[] ocupaid = new int[data];
            connections.Close();
            VisiblePlace(ref ocupaid);
            List<Place> list = new List<Place>();
            for (int i = 1; i <= data; i++)
            {
                if (ocupaid[i-1] == i)
                {
                    continue;
                }

                list.Add(new Place() { ID = i, place = $"Місце - {i}" });
            }
            _Place.DataSource = list;
            _Place.ValueMember = "ID";
            _Place.DisplayMember = "place";
        }
        void InfoPlace_Parameters()
        {
            connections.Open();
            string query = @"select PPa.ID_Parametrs, PPa.Length/1000*PPa.Height/1000*PPa.Width/1000 as 'Place_parameter' from Place_Parameters PPa
                                join Area_Type AT ON AT.ID_Parameters =PPa.ID_Parametrs
                                Where at.ID_Area =" + Area.SelectedValue+"";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rdr);
            ID_Parameters.DisplayMember = "Place_parameter";
            ID_Parameters.ValueMember = "PPa.ID_Parametrs";
            ID_Parameters.DataSource = data;
            connections.Close();
        }
       
        private void _Region_SelectedValueChanged(object sender, EventArgs e)
        {
            if (connections.State != ConnectionState.Open)
            {
                connections.Open();
                string query = @"Select AT.ID_Area,
                                        AT.Description from
                                        Region_Type RT
                                        JOIN Area_Type AT ON AT.ID_Region = RT.ID_Region
                                        WHERE RT.ID_Region = " + _Region.SelectedValue + "";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(rdr);
                Area.DisplayMember = "AT.Description";
                Area.ValueMember = "AT.ID_Area";
                Area.DataSource = data;
                connections.Close();
            }
        }

        private void Area_SelectedValueChanged(object sender, EventArgs e)
        {
            int data = 0;
            if (connections.State != ConnectionState.Open)
            {
                
                connections.Open();
                string query = @"Select Rack_Qty from Area_Type WHERE ID_Area = " + Area.SelectedValue + "";
                SqlCommand command = new SqlCommand(query, connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    data = Convert.ToInt32(rdr["Rack_Qty"].ToString());
                }
                connections.Close();
                InfoRack();
                InfoPlace_Parameters();

            }

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = @"INSERT INTO [dbo].[PlaceOfProduct]
                           ([Region]
                           ,[Area]
                           ,[Rack]
                           ,[Level]
                           ,[Place]
                           ,[ID_Acceptance]
                           ,[Storage_notes]
                           ,[ID_Parameters]
                           ,[OccupiedPlace])
                     VALUES
                           (" + _Region.SelectedValue + "" +
                               "," + Area.SelectedValue + "" +
                               "," + _Rack.SelectedValue + "" +
                               "," + _Level.SelectedIndex + "" +
                               "," + _Place.SelectedValue + "" +
                               "," + ID_acceptances + "" +
                               ",'" + _Notes.Text + "'" +
                               "," + ID_Parameters.SelectedValue + "" +
                               ",@OccupiedPlace)";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.AddWithValue("@OccupiedPlace", Occupied.Checked);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                addPlace();
                Reports.PlaceProduct_Report_Place.Form1 form = new Reports.PlaceProduct_Report_Place.Form1();
                form.Show();
            }
            catch (Exception ecs)
            {
                MessageBox.Show(ecs.ToString());
            }
           
        }
        void StockAdd()
        {
            try
            {
                connections.Open();
                string query = @"INSERT INTO Stock(ID_Place
                            ,ID_Product
                            ,Date
                            ,ID_OrdersSupply
                            ,Qty)
                            VALUES
                            ('" + ID_Place.Text + "'" +
                                "," + ID_Product + "" +
                                ",@Date" +
                                "," + ID_Supply + "" +
                                "," + Qty + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Parse(Date_Aceptance).Date;
                command.ExecuteNonQuery();
                connections.Close();
                InsertChecked();
            }catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }
        void addPlace()
        {
            string data;
            connections.Open();
            string query = @"Select ID_Place from PlaceOfProduct
                        Where ID_Acceptance = "+ID_acceptances+"";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader rdr;
            rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                data = rdr["ID_Place"].ToString();
                ID_Place.Text = data;
            }
            connections.Close();
        }
        

        private void Auto_Place_Click(object sender, EventArgs e)
        {
            double dates =(DateTime.Parse(Date_Expiration) - DateTime.Parse(Date_Aceptance)).TotalDays;
            if(dates >=0)
            {
                
            }
        }
        public void InsertChecked()
        {
            connections.Open();
            string query = @"UPDATE [dbo].[OrdersOfSupply]
                            SET [Status] = 1
                            WHERE ID_Supply = " + ID_Supply + "";
            SqlCommand command = new SqlCommand(query, connections);
            command.ExecuteNonQuery();
            connections.Close();
        }
        private void Stock__Click(object sender, EventArgs e)
        {
            StockAdd();
            Stock stock = new Stock();
            stock.Show();
        }

        private void _Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(connections.State == ConnectionState.Closed)
            {
                InfoPlace();
            }
        }

        
    }
}
