using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
       // string ImgQuery = "";
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void Products_Load(object sender, EventArgs e)
        {
            GridInfo();
        }
        //private void Browse_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        connections.Open(); 
        //        OpenFileDialog fileDialog = new OpenFileDialog();
        //        fileDialog.Filter = "ALL Files (*.*)| *.*";
        //        fileDialog.Title = "Select Photo";
        //        if (fileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            ImgQuery = fileDialog.FileName.ToString();
        //            Photo.ImageLocation = ImgQuery;
        //        }
        //        connections.Close();
        //    }
        //    catch (Exception ecx)
        //    {
        //        MessageBox.Show(ecx.ToString());
        //        connections.Close();
        //    }
        //}
        //public void OpenPhoto()
        //{
        //    connections.Open();
        //    string query = "Select Photo from Product";
        //    SqlCommand command = new SqlCommand(query, connections);
        //    SqlDataReader reader = command.ExecuteReader();
        //    reader.Read();
        //    if (reader.HasRows)
        //    {
        //        byte[] img = (byte[])(reader[0]);
        //        if (img == null)
        //        {
        //            this.Photo.Image = null;
        //        }
        //        else
        //        {
        //            MemoryStream ms = new MemoryStream(img);
        //            Photo.Image = Image.FromStream(ms);
        //        }
        //    }
        //    connections.Close();
        //}
        //private void Save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        connections.Open();
        //        byte[] img = null;
        //        FileStream file = new FileStream(ImgQuery, FileMode.Open, FileAccess.Read);
        //        BinaryReader binary = new BinaryReader(file);
        //        img = binary.ReadBytes((int)file.Length);
        //        string query = "Update Product set Photo = @image where ID_Product = " + ID_Product.Text + "";
        //        SqlCommand command = new SqlCommand(query, connections);
        //        command.Parameters.Add(new SqlParameter(@"image", img));
        //        int URL = command.ExecuteNonQuery();
        //        MessageBox.Show(URL.ToString() + " Save");
        //        connections.Close();
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.ToString());
        //        connections.Close();
        //    }
        //}
        public void GridInfo()
        {
            connections.Open();
            string query = "Select ID_Product, Name, Description, Price from Product";
            SqlCommand command = new SqlCommand(query, connections);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while(reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader["ID_Product"].ToString();
                data[data.Count - 1][1] = reader["Name"].ToString();
                data[data.Count - 1][2] = reader["Description"].ToString();
                decimal price = Math.Round(Convert.ToDecimal(reader["Price"]), 2);
                Price.Text = price.ToString().Replace(',', '.');
                data[data.Count - 1][3] = price.ToString();
            }
            connections.Close();
            foreach (string[] item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }
        public void ColumName()
        {
           
            dataGridView1.Columns[0].HeaderText = "Код_товару";
            dataGridView1.Columns[1].HeaderText = "Назва товару";
            dataGridView1.Columns[2].HeaderText = "Опис";
            dataGridView1.Columns[3].HeaderText = "Ціна";
        }
        
        #region кнопки

        
        private void PName_MouseClick(object sender, MouseEventArgs e)
        {
            if (PName.Text == "Назва товару")
            {
                PName.Text = "";
            }
                
        }

        private void PName_Leave(object sender, EventArgs e)
        {
            if (PName.Text == "")
                PName.Text = "Назва товару";
        }

        private void Discription_MouseClick(object sender, MouseEventArgs e)
        {
            if (Description.Text == "Опис товару")
                Description.Text = "";
        }

        private void Discription_Leave(object sender, EventArgs e)
        {
            if (Description.Text == "")
                Description.Text = "Опис товару";
        }

        private void Price_MouseClick(object sender, MouseEventArgs e)
        {
            if (Price.Text == "Ціна")
                Price.Text = "";
        }

        private void Price_Leave(object sender, EventArgs e)
        {
            if (Price.Text == "")
                Price.Text = "Ціна";
        }
        #endregion

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO Product(Name, Description, Price) VALUES('" + PName.Text + "','"+Description.Text+"',"+Price.Text+")";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано продукт");
                connections.Close();
                GridInfo();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "Update Product Set Name = '" + PName.Text + "', Description ='" + Description.Text + "', Price = "+Price.Text.Replace(',','.')+" where ID_Product = " + ID_Product.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Оновлення продукту");
                connections.Close();
                GridInfo();
            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "delete from Product where ID_Product = " + ID_Product.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                MessageBox.Show("Видалено");
                

            }
            catch (Exception exc)
            {
                connections.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    ID_Product.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    PName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Description.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }
    }
}
