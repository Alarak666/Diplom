
namespace Main_Form
{
    partial class Stock
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
            this.Qty = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.ID_Supply = new System.Windows.Forms.ComboBox();
            this.ID_Product = new System.Windows.Forms.ComboBox();
            this.ID_Place = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.Qty);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.ID_Supply);
            this.panel1.Controls.Add(this.ID_Product);
            this.panel1.Controls.Add(this.ID_Place);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 292);
            this.panel1.TabIndex = 0;
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qty.Location = new System.Drawing.Point(12, 174);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(202, 30);
            this.Qty.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(12, 138);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(202, 30);
            this.Date.TabIndex = 4;
            // 
            // ID_Supply
            // 
            this.ID_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Supply.FormattingEnabled = true;
            this.ID_Supply.Location = new System.Drawing.Point(12, 99);
            this.ID_Supply.Name = "ID_Supply";
            this.ID_Supply.Size = new System.Drawing.Size(202, 33);
            this.ID_Supply.TabIndex = 3;
            // 
            // ID_Product
            // 
            this.ID_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Product.FormattingEnabled = true;
            this.ID_Product.Location = new System.Drawing.Point(12, 60);
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(202, 33);
            this.ID_Product.TabIndex = 3;
            // 
            // ID_Place
            // 
            this.ID_Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Place.FormattingEnabled = true;
            this.ID_Place.Location = new System.Drawing.Point(12, 21);
            this.ID_Place.Name = "ID_Place";
            this.ID_Place.Size = new System.Drawing.Size(202, 33);
            this.ID_Place.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(518, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 290);
            this.panel3.TabIndex = 2;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(22, 99);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(196, 39);
            this.DELETE.TabIndex = 4;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(22, 54);
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
            this.ADD.Location = new System.Drawing.Point(22, 8);
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
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 297);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox ID_Supply;
        private System.Windows.Forms.ComboBox ID_Product;
        private System.Windows.Forms.ComboBox ID_Place;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}