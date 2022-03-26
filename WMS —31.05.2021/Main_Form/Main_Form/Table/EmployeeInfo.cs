using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection connections = new SqlConnection("Data Source=DESKTOP-FNV545N;Initial Catalog=WMS;Integrated Security=True");
        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            GridInfo();
            CreateID_EmployeeAdapter();
        }
        public void GridInfo()
        {
            connections.Open();
            string query = @"Select ID_Employee
		                    ,CONCAT(E.MName,' ', SUBSTRING(E.FName,1 ,1),'.',' ',SUBSTRING(E.LName,1,1),'.') AS 'ПІБ'
                            ,[Address]
                            ,Age
                            ,Phone 
                            FROM EmployeeInfo AS EI 
                            JOIN Employees AS E ON E.ID = EI.ID_Employee";
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
                "Код працівника",
                "ПІБ",
                "Адреса",
                "Вік",
                "Телефон"
            };
            for (int i = 0; i < names.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = names[i];
            }
        }
        public void CreateID_EmployeeAdapter()
        {
            try
            {
                connections.Open();
                SqlCommand command = new SqlCommand("SELECT ID, CONCAT(MName,' ',SUBSTRING(FName,1,1),'.',' ',SUBSTRING(FName,1,1),'.',' ') AS'ПІБ' FROM Employees", connections);
                SqlDataReader rdr;
                rdr = command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                data.Load(rdr);
                ID_Employee.ValueMember = "ID";
                ID_Employee.DisplayMember = "ПІБ";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    ID_Employee.Text = row.Cells["ID_Employee"].Value.ToString();
                    Address.Text = row.Cells["Address"].Value.ToString();
                    Age.Text = row.Cells["Age"].Value.ToString();
                    Phone.Text = row.Cells["Phone"].Value.ToString();
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
        private void Clear()
        {
            Address.Text = "";
            Age.Text = "";
            Phone.Text = "";
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "INSERT INTO EmployeeInfo(ID_Employee, Address, Age, Phone) VALUES(" + ID_Employee.SelectedValue + ", '" + Address.Text + "', " + Age.Text + ", '" + Phone.Text + "')";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                MessageBox.Show("Додано Інформацію");
                connections.Close();
                GridInfo();
                Clear();
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
        
        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (Address.Text == "" || Age.Text == "" || Phone.Text == "")
                {
                    MessageBox.Show("Потрібно заповнити всі поля");
                }
                else
                {
                    connections.Open();
                    string query = "Update EmployeeInfo set ID_Employee = '" + ID_Employee.Text + "', Address = '" + Address.Text + "', Age ='" + Age.Text + "', Phone = '" + Phone.Text + "' where ID_Employee =" + ID_Employee.Text + ";";
                    SqlCommand command = new SqlCommand(query, connections);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Дані оновленно");
                    connections.Close();
                    GridInfo();
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
        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                connections.Open();
                string query = "delete from EmployeeInfo where ID_Employee = " + ID_Employee.Text + ";";
                SqlCommand command = new SqlCommand(query, connections);
                command.ExecuteNonQuery();
                connections.Close();
                GridInfo();
                MessageBox.Show($"Видалено ротітника {ID_Employee.Text}",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                               );
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

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.Employeer_Report.Employeer_Report employeer = new Reports.Employeer_Report.Employeer_Report();
            employeer.Show();
        }
        void Search()
        {
            try
            {
                if (Search_text.Text == "")
                {
                    MessageBox.Show("Виберіть поле длая пошуку та тип пошуку");
                }
                else 
                { 
                    string seachr = "";
                    if (radioButton1.Checked == true)
                    {
                        seachr = "Mname";
                        label2.Text = "Прізвище";
                       
                    }
                    else if (radioButton2.Checked == true)
                    {
                        seachr = "Fname";
                        label2.Text = "І'мя";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        seachr = "Lname";
                        label2.Text = "По батькові";
                    }
                   

                    connections.Open();
                    string query = @"Select EI.ID_Employee
                                    ,CONCAT(MName,' ',SUBSTRING(FName,1,1),'.',' ',SUBSTRING(FName,1,1),'.',' ') AS'ПІБ'
                                    ,EI.Address
                                    ,EI.Age
                                    ,EI.Phone
                                    from EmployeeInfo EI
                            JOIN Employees E ON E.ID = EI.ID_Employee
                           Where " + seachr + " Like '%" + Search_text.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connections);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    connections.Close();
                    Back.Visible = true;
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

        private void Button_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            GridInfo();
            Back.Visible = false;
        }

        private void Address_Click(object sender, EventArgs e)
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

        private void Age_Leave(object sender, EventArgs e)
        {
            if (Age.Text == "")
            {
                Age.Text = "Вік";
            }
        }

        private void Age_Click(object sender, EventArgs e)
        {
            if (Age.Text == "Вік")
            {
                Age.Text = "";
            }
        }
    }
}
