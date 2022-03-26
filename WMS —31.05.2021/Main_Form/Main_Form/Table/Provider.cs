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
    public partial class Provider : Form
    {
        
        public Provider()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        DataSet data = new DataSet();
        private void Provider_Load(object sender, EventArgs e)
        {
            ProviderGrid();
        }
        public void ProviderGrid()
        {
            connections.Open();
            string query = "Select * from Provider";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            ColumnName();
            connections.Close();
        }
        private void ColumnName()
        {
            dataGridView1.Columns[0].HeaderText = "Код_постачальника";
            dataGridView1.Columns[1].HeaderText = "Ім'я";
            dataGridView1.Columns[2].HeaderText = "Прізвище";
            dataGridView1.Columns[3].HeaderText = "По батькові";
            dataGridView1.Columns[4].HeaderText = "Адрес";
            dataGridView1.Columns[5].HeaderText = "Телефон";
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO Provider(FName, MName, LName, Address, Phone) VALUES('"+FName.Text+ "','" + MName.Text + "','" + LName.Text + "','"+Address.Text+"','"+Phone.Text+"')";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано Постачальника");
                connections.Close();
                ProviderGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "Update Provider Set Fname ='" + FName.Text + "', MName = '" + MName.Text + "', LName = '" + LName.Text + "', Address = '" + Address.Text + "', Phone = '" + Phone.Text + "' where Id = "+ID.Text+";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Оновлення Постачальника");
                connections.Close();
                ProviderGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                connections.Close();
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "delete from Provider where ID = " + ID.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                ProviderGrid();
                MessageBox.Show($"Видалено З кодом{ID.Text}") ;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void FName_MouseClick(object sender, MouseEventArgs e)
        {
            if(FName.Text == "Ім'я")
            {
                FName.Text = "";
            }
        }

        private void FName_Leave(object sender, EventArgs e)
        {
            if (FName.Text == "")
            {
                FName.Text = "Ім'я";
            }
        }

        private void MName_MouseClick(object sender, MouseEventArgs e)
        {
            if (MName.Text == "Прізвище")
            {
                MName.Text = "";
            }
        }

        private void MName_Leave(object sender, EventArgs e)
        {
            if (MName.Text == "")
            {
                MName.Text = "Прізвище";
            }
        }

        private void LName_Leave(object sender, EventArgs e)
        {
            if (LName.Text == "")
            {
                LName.Text = "По батькові";
            }
        }

        private void LName_MouseClick(object sender, MouseEventArgs e)
        {
            if (LName.Text == "По батькові")
            {
                LName.Text = "";
            }
        }

        private void Address_MouseClick(object sender, MouseEventArgs e)
        {
            if (Address.Text == "Адреса")
            {
                Address.Text = "";
            }
        }

        private void Address_Leave(object sender, EventArgs e)
        {
            if (Address.Text == "")
            {
                Address.Text = "Адреса";
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ID.Text = row.Cells["ID"].Value.ToString();
                FName.Text = row.Cells["FName"].Value.ToString();
                MName.Text = row.Cells["MName"].Value.ToString();
                LName.Text = row.Cells["LName"].Value.ToString();
                Address.Text = row.Cells["Address"].Value.ToString();
                Phone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
