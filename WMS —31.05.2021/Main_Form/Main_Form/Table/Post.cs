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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Post_Load(object sender, EventArgs e)
        {
            GridInto();
        }
        public void GridInto()
        {
            connections.Open();
            string query = "Select * from Post";
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
            dataGridView1.Columns[0].HeaderText = "Код Поста";
            dataGridView1.Columns[1].HeaderText = "Назва";
            dataGridView1.Columns[2].HeaderText = @"Обов'язки";
            dataGridView1.Columns[3].HeaderText = "Зарплата";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID.Text = row.Cells["ID_Post"].Value.ToString();
                    Name_Post.Text = row.Cells["Name_Post"].Value.ToString();
                    Responsibility.Text = row.Cells["Responsibility"].Value.ToString();
                    Salary.Text = row.Cells["Salary"].Value.ToString();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }

        }
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO Post(Name_Post, Responsibility, Salary) VALUES('" + Name_Post.Text + "','" + Name_Post.Text + "'," + Salary.Text + ")";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано пост");
                connections.Close();
                Clear();
                GridInto();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void Clear()
        {
            Name_Post.Text = "";
            Responsibility.Text = "";
            Salary.Text = "";
        }
        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_Post.Text == "" || Responsibility.Text == "" || Salary.Text == "")
                {
                    MessageBox.Show("Потрібно заповнити всі поля");
                }
                connections.Open();
                string query = "Update Post set Name_Post = '" + Name_Post.Text + "', Responsibility ='" + Responsibility.Text + "', Salary = " + Salary.Text.Replace(',','.') + " where ID_Post =" + ID.Text + ";";
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
            string query = "delete from post where ID_Post = " + ID.Text + ";";
            SqlCommand command = new SqlCommand(query, connections);
            command.ExecuteNonQuery();
            connections.Close();
            GridInto();
            MessageBox.Show("Видалено");
        }
    }
}
