
namespace Main_Form
{
    partial class Products
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Main_Form.WMSDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.ID_Product = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.productTableAdapter = new Main_Form.WMSDataSetTableAdapters.ProductTableAdapter();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Назва = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Опис = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ціна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 309);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код,
            this.Назва,
            this.Опис,
            this.Ціна});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.Description);
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.PName);
            this.panel2.Controls.Add(this.ID_Product);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 252);
            this.panel2.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(15, 89);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(175, 67);
            this.Description.TabIndex = 4;
            this.Description.Text = "Опис товару";
            this.Description.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Discription_MouseClick);
            this.Description.Leave += new System.EventHandler(this.Discription_Leave);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(15, 162);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(175, 35);
            this.Price.TabIndex = 3;
            this.Price.Text = "Ціна";
            this.Price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Price_MouseClick);
            this.Price.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PName.Location = new System.Drawing.Point(15, 50);
            this.PName.Multiline = true;
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(175, 33);
            this.PName.TabIndex = 3;
            this.PName.Text = "Назва товару";
            this.PName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PName_MouseClick);
            this.PName.Leave += new System.EventHandler(this.PName_Leave);
            // 
            // ID_Product
            // 
            this.ID_Product.Enabled = false;
            this.ID_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Product.Location = new System.Drawing.Point(15, 12);
            this.ID_Product.Multiline = true;
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(175, 32);
            this.ID_Product.TabIndex = 3;
            this.ID_Product.Text = "Код";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(614, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 252);
            this.panel3.TabIndex = 2;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(19, 98);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(127, 38);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(19, 59);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(127, 33);
            this.EDIT.TabIndex = 0;
            this.EDIT.Text = "Редагувати";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(19, 20);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(127, 33);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Код
            // 
            this.Код.HeaderText = "Код";
            this.Код.MinimumWidth = 6;
            this.Код.Name = "Код";
            this.Код.Width = 125;
            // 
            // Назва
            // 
            this.Назва.HeaderText = "Назва";
            this.Назва.MinimumWidth = 6;
            this.Назва.Name = "Назва";
            this.Назва.Width = 125;
            // 
            // Опис
            // 
            this.Опис.HeaderText = "Опис";
            this.Опис.MinimumWidth = 6;
            this.Опис.Name = "Опис";
            this.Опис.Width = 125;
            // 
            // Ціна
            // 
            this.Ціна.HeaderText = "Ціна";
            this.Ціна.MinimumWidth = 6;
            this.Ціна.Name = "Ціна";
            this.Ціна.Width = 125;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Products";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WMSDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox ID_Product;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.DataGridViewTextBoxColumn Назва;
        private System.Windows.Forms.DataGridViewTextBoxColumn Опис;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ціна;
    }
}