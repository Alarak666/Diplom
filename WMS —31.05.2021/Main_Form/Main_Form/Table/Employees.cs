using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Form
{
    public partial class Employees : Form
    {
        
        public Employees()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Employees_Load(object sender, EventArgs e)
        {
            GridInto();
            CreateEmployeeAdapter();
        }
        public void GridInto()
        {
            connections.Open();
            string query = @"SELECT ID,
                                    FName,
                                    MName,
                                    LName,
                                    P.Name_Post AS 'Post'
                             FROM Employees AS E
                             JOIN Post AS P ON P.ID_Post = E.ID_Post";
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
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Ім'я";
            dataGridView1.Columns[2].HeaderText = "Прізвище";
            dataGridView1.Columns[3].HeaderText = "По батькові";
            dataGridView1.Columns[4].HeaderText = "Пост";
        }
        public  void CreateEmployeeAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID_Post, Name_Post FROM Post", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_Post", typeof(string));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Post.ValueMember = "ID_Post";
                ID_Post.DisplayMember = "Name_Post";
                ID_Post.DataSource = data;
                connections.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void FName_MouseClick(object sender, MouseEventArgs e)
        {
            if (FName.Text == "Введіть ім\'я")
            {
                FName.Text = "";
            }
        }
        private void FName_Leave(object sender, EventArgs e)
        {
            if (FName.Text == "")
            {
                FName.Text = "Введіть ім\'я";
            }
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO Employees(FName, MName, LName, ID_Post) VALUES('"+FName.Text.ToString()+"','"+MName.Text.ToString() + "','"+LName.Text.ToString() + "',"+ID_Post.SelectedValue+")";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано");
                connections.Close();
                Clear();
                ID_Post.SelectedIndex = -1;
                GridInto();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            } 
        }
        private void Clear() 
        {
            FName.Text = MName.Text = LName.Text = "";
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
        private void LName_MouseClick(object sender, MouseEventArgs e)
        {
            if (LName.Text == "По батькові")
            {
                LName.Text = "";
            }
        }
        private void LName_Leave(object sender, EventArgs e)
        {
            if (LName.Text == "")
            {
                LName.Text = "По батькові";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID.Text = row.Cells["ID"].Value.ToString();
                    FName.Text = row.Cells["Fname"].Value.ToString();
                    MName.Text = row.Cells["MName"].Value.ToString();
                    LName.Text = row.Cells["LName"].Value.ToString();
                    ID_Post.Text = row.Cells["Post"].Value.ToString();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            
        }
      
    private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if(FName.Text == "" || MName.Text == "" || LName.Text == "" || ID_Post.Text == "")
                {
                    MessageBox.Show("Потрібно заповнити всі поля");
                }
                connections.Open();
                string query = "Update Employees set FName = '" + FName.Text + "', MName ='" + MName.Text + "', LName = '" + LName.Text + "', ID_Post = " + ID_Post.SelectedValue + " where ID =" + ID.Text+ ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Дані оновленно");
                connections.Close();
                GridInto();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }   
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            connections.Open();
            string query = "delete from employee where ID = "+ID.Text+";";
            SqlCommand command = new SqlCommand(query, connections);
            command.ExecuteNonQuery();
            connections.Close();
            GridInto();
            MessageBox.Show("Видалено");
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Main_Forms main_ = new Main_Forms();
            main_.Show();
            this.Dispose();
        }
    }
}
