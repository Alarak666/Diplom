
namespace Main_Form
{
    partial class Post
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salary = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EDIT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.Responsibility = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Name_Post = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 304);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.Salary);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Responsibility);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.Name_Post);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 318);
            this.panel2.TabIndex = 1;
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.Location = new System.Drawing.Point(12, 137);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(196, 33);
            this.Salary.TabIndex = 8;
            this.Salary.Text = "Зарплата";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(593, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 318);
            this.panel3.TabIndex = 5;
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(27, 61);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(196, 39);
            this.EDIT.TabIndex = 3;
            this.EDIT.Text = "Редагувати";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(27, 106);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(196, 39);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(27, 16);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(196, 39);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Responsibility
            // 
            this.Responsibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Responsibility.Location = new System.Drawing.Point(12, 99);
            this.Responsibility.Multiline = true;
            this.Responsibility.Name = "Responsibility";
            this.Responsibility.Size = new System.Drawing.Size(196, 33);
            this.Responsibility.TabIndex = 7;
            this.Responsibility.Text = "Обов\'язки";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(12, 24);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(196, 33);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // Name_Post
            // 
            this.Name_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Post.Location = new System.Drawing.Point(12, 61);
            this.Name_Post.Multiline = true;
            this.Name_Post.Name = "Name_Post";
            this.Name_Post.Size = new System.Drawing.Size(196, 33);
            this.Name_Post.TabIndex = 6;
            this.Name_Post.Text = "Назва посту";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Post";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.TextBox Responsibility;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Name_Post;
    }
}