
namespace Main_Form
{
    partial class Provider
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
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.MName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.LName);
            this.panel1.Controls.Add(this.MName);
            this.panel1.Controls.Add(this.FName);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 296);
            this.panel1.TabIndex = 0;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(40, 256);
            this.Phone.Mask = "+00(000)-00-00-000";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(222, 30);
            this.Phone.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(40, 176);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(222, 74);
            this.Address.TabIndex = 2;
            this.Address.Text = "Адреса";
            this.Address.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Address_MouseClick);
            this.Address.Leave += new System.EventHandler(this.Address_Leave);
            // 
            // LName
            // 
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(40, 136);
            this.LName.Multiline = true;
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(222, 34);
            this.LName.TabIndex = 1;
            this.LName.Text = "По батькові";
            this.LName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LName_MouseClick);
            this.LName.Leave += new System.EventHandler(this.LName_Leave);
            // 
            // MName
            // 
            this.MName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MName.Location = new System.Drawing.Point(40, 96);
            this.MName.Multiline = true;
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(222, 34);
            this.MName.TabIndex = 1;
            this.MName.Text = "Прізвище";
            this.MName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MName_MouseClick);
            this.MName.Leave += new System.EventHandler(this.MName_Leave);
            // 
            // FName
            // 
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName.Location = new System.Drawing.Point(40, 56);
            this.FName.Multiline = true;
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(222, 34);
            this.FName.TabIndex = 1;
            this.FName.Text = "Ім\'я";
            this.FName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FName_MouseClick);
            this.FName.Leave += new System.EventHandler(this.FName_Leave);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(40, 16);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(222, 34);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Search_button);
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(529, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 296);
            this.panel3.TabIndex = 0;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(22, 103);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(138, 39);
            this.DELETE.TabIndex = 1;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(22, 58);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(138, 39);
            this.EDIT.TabIndex = 2;
            this.EDIT.Text = "Оновити";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(22, 13);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(138, 39);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 362);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(22, 148);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(138, 39);
            this.Search_button.TabIndex = 1;
            this.Search_button.Text = "Пошук";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Provider";
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.Provider_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button Search_button;
    }
}