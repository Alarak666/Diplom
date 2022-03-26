
namespace Main_Form
{
    partial class Employees
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_Post = new System.Windows.Forms.ComboBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.MName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Main_Form.WMSDataSet();
            this.employeesTableAdapter = new Main_Form.WMSDataSetTableAdapters.EmployeesTableAdapter();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new Main_Form.WMSDataSetTableAdapters.PostTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.ID_Post);
            this.panel1.Controls.Add(this.LName);
            this.panel1.Controls.Add(this.MName);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.FName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 258);
            this.panel1.TabIndex = 0;
            // 
            // ID_Post
            // 
            this.ID_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Post.FormattingEnabled = true;
            this.ID_Post.Location = new System.Drawing.Point(12, 182);
            this.ID_Post.Name = "ID_Post";
            this.ID_Post.Size = new System.Drawing.Size(196, 33);
            this.ID_Post.TabIndex = 5;
            // 
            // LName
            // 
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(12, 143);
            this.LName.Multiline = true;
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(196, 33);
            this.LName.TabIndex = 4;
            this.LName.Text = "По батькові";
            this.LName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LName_MouseClick);
            this.LName.Leave += new System.EventHandler(this.LName_Leave);
            // 
            // MName
            // 
            this.MName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MName.Location = new System.Drawing.Point(12, 105);
            this.MName.Multiline = true;
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(196, 33);
            this.MName.TabIndex = 3;
            this.MName.Text = "Прізвище";
            this.MName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MName_MouseClick);
            this.MName.Leave += new System.EventHandler(this.MName_Leave);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(12, 30);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(196, 33);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            this.ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FName_MouseClick);
            this.ID.Leave += new System.EventHandler(this.FName_Leave);
            // 
            // FName
            // 
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName.Location = new System.Drawing.Point(12, 67);
            this.FName.Multiline = true;
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(196, 33);
            this.FName.TabIndex = 2;
            this.FName.Text = "Введіть ім\'я";
            this.FName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FName_MouseClick);
            this.FName.Leave += new System.EventHandler(this.FName_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DELETE);
            this.panel2.Controls.Add(this.EDIT);
            this.panel2.Controls.Add(this.GoBack);
            this.panel2.Controls.Add(this.ADD);
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 258);
            this.panel2.TabIndex = 0;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(21, 102);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(196, 39);
            this.DELETE.TabIndex = 1;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(21, 57);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(196, 39);
            this.EDIT.TabIndex = 1;
            this.EDIT.Text = "Редагувати";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBack.Location = new System.Drawing.Point(21, 208);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(196, 39);
            this.GoBack.TabIndex = 0;
            this.GoBack.Text = "Повернутись";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(21, 12);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(196, 39);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1063, 281);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.wMSDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 534);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private WMSDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.ComboBox ID_Post;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.BindingSource postBindingSource;
        private WMSDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button GoBack;
    }
}