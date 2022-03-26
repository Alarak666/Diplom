
namespace Main_Form
{
    partial class EmployeeInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_text = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.ID_Employee = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.ID_Employee);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 225);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Back);
            this.panel4.Controls.Add(this.Button_Search);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Search_text);
            this.panel4.Location = new System.Drawing.Point(495, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 219);
            this.panel4.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(25, 131);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 37);
            this.Back.TabIndex = 4;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Search.Location = new System.Drawing.Point(25, 87);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(97, 37);
            this.Button_Search.TabIndex = 3;
            this.Button_Search.Text = "Пошук";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Location = new System.Drawing.Point(160, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(109, 53);
            this.panel5.TabIndex = 2;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(81, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(78, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Б";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(50, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "І";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "П";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип пошуку";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пошук :";
            // 
            // Search_text
            // 
            this.Search_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_text.Location = new System.Drawing.Point(25, 51);
            this.Search_text.Name = "Search_text";
            this.Search_text.Size = new System.Drawing.Size(129, 30);
            this.Search_text.TabIndex = 0;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(12, 112);
            this.Phone.Mask = "+00(000)-00-00-000";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(222, 30);
            this.Phone.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(12, 78);
            this.Age.Multiline = true;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(222, 29);
            this.Age.TabIndex = 3;
            this.Age.Text = "Вік";
            this.Age.Click += new System.EventHandler(this.Age_Click);
            this.Age.Leave += new System.EventHandler(this.Age_Leave);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(12, 44);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(222, 29);
            this.Address.TabIndex = 3;
            this.Address.Text = "Адреса";
            this.Address.Click += new System.EventHandler(this.Address_Click);
            this.Address.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // ID_Employee
            // 
            this.ID_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Employee.FormattingEnabled = true;
            this.ID_Employee.Location = new System.Drawing.Point(12, 6);
            this.ID_Employee.Name = "ID_Employee";
            this.ID_Employee.Size = new System.Drawing.Size(222, 33);
            this.ID_Employee.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(787, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 222);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(22, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Звіт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(22, 105);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(196, 37);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(22, 60);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(196, 39);
            this.EDIT.TabIndex = 3;
            this.EDIT.Text = "Редагувати";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(22, 14);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(196, 39);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 306);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.ComboBox ID_Employee;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back;
    }
}