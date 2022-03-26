
namespace Main_Form
{
    partial class OrdersDateils
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Qty = new System.Windows.Forms.TextBox();
            this.ID_Order = new System.Windows.Forms.ComboBox();
            this.ID_Product = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 305);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(401, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 289);
            this.panel3.TabIndex = 1;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(25, 109);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(196, 39);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(25, 64);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(196, 39);
            this.EDIT.TabIndex = 0;
            this.EDIT.Text = "Оновити";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(23, 19);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(196, 39);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.Qty);
            this.panel2.Controls.Add(this.ID_Order);
            this.panel2.Controls.Add(this.ID_Product);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 292);
            this.panel2.TabIndex = 3;
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qty.Location = new System.Drawing.Point(12, 100);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(184, 30);
            this.Qty.TabIndex = 5;
            // 
            // ID_Order
            // 
            this.ID_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Order.FormattingEnabled = true;
            this.ID_Order.Location = new System.Drawing.Point(12, 22);
            this.ID_Order.Name = "ID_Order";
            this.ID_Order.Size = new System.Drawing.Size(184, 33);
            this.ID_Order.TabIndex = 3;
            // 
            // ID_Product
            // 
            this.ID_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Product.FormattingEnabled = true;
            this.ID_Product.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.ID_Product.Location = new System.Drawing.Point(12, 61);
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(184, 33);
            this.ID_Product.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 308);
            this.panel1.TabIndex = 2;
            // 
            // OrdersDateils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrdersDateils";
            this.Text = "OrdersDetails";
            this.Load += new System.EventHandler(this.OrdersDateils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ID_Order;
        private System.Windows.Forms.ComboBox ID_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Qty;
    }
}