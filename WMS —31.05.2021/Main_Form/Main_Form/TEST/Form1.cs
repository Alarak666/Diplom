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

namespace Main_Form.TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = i;
            }
        }
        object _region ;
        object _area ;
        object _rack ;
        object level ;
        object place ;
        string data()
        {
            DateTime NOW = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TimeSpan time = new TimeSpan();
            time = (Convert.ToDateTime(DData_Expiration.Value).Subtract(NOW));
            TDateParse.Text = time.Days.ToString();
            return time.Days.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connections.Open();
                        string query = @"Select  
                        Region_Type.ID_Region
                        ,Area_Type.ID_Area
                        ,Term
                        ,Term_Max
                        ,Area_Type.ID_Parameters
                        ,Width / 1000 * Length / 1000 * Height / 1000 as 'm3'
                        from Area_Type
                        JOIN Region_Type ON Region_Type.ID_Region = Area_Type.ID_Region
                        JOIN Place_Parameters ON Place_Parameters.ID_Parametrs = Area_Type.ID_Parameters
                        WHERE Area_Type.Term_Max Between 0 and " + data() + " ";
            SqlCommand sqlcommand = new SqlCommand(query, connections);
            SqlDataReader reader = sqlcommand.ExecuteReader();
            bool check = true;
            while (reader.Read() && check == true)
            {
                 _region = reader["ID_Region"].ToString();
                 _area = reader["ID_Area"].ToString();
            }
            connections.Close();
            //Отнимание времени

        }
    }
}
