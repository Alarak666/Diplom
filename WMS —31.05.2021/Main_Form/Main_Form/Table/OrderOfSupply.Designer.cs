
namespace Main_Form
{
    partial class OrderOfSupply
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Status = new System.Windows.Forms.CheckBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this.ID_Supply = new System.Windows.Forms.ComboBox();
            this.ID_Product = new System.Windows.Forms.ComboBox();
            this.ID_Provider = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AllOrder = new System.Windows.Forms.Button();
            this.back_order = new System.Windows.Forms.Button();
            this.Supply_Acceptance = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.Status);
            this.panel2.Controls.Add(this.Qty);
            this.panel2.Controls.Add(this.ID_Supply);
            this.panel2.Controls.Add(this.ID_Product);
            this.panel2.Controls.Add(this.ID_Provider);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 315);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Продукт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Постачальник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Код";
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(179, 161);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(208, 30);
            this.Date.TabIndex = 5;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.White;
            this.Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(179, 126);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(90, 29);
            this.Status.TabIndex = 4;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = false;
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qty.Location = new System.Drawing.Point(179, 90);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(208, 30);
            this.Qty.TabIndex = 3;
            // 
            // ID_Supply
            // 
            this.ID_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Supply.FormattingEnabled = true;
            this.ID_Supply.Location = new System.Drawing.Point(179, 12);
            this.ID_Supply.Name = "ID_Supply";
            this.ID_Supply.Size = new System.Drawing.Size(208, 33);
            this.ID_Supply.TabIndex = 2;
            // 
            // ID_Product
            // 
            this.ID_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Product.FormattingEnabled = true;
            this.ID_Product.Location = new System.Drawing.Point(179, 197);
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(208, 33);
            this.ID_Product.TabIndex = 2;
            // 
            // ID_Provider
            // 
            this.ID_Provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Provider.FormattingEnabled = true;
            this.ID_Provider.Location = new System.Drawing.Point(179, 51);
            this.ID_Provider.Name = "ID_Provider";
            this.ID_Provider.Size = new System.Drawing.Size(208, 33);
            this.ID_Provider.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AllOrder);
            this.panel3.Controls.Add(this.back_order);
            this.panel3.Controls.Add(this.Supply_Acceptance);
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.EDIT);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(485, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 315);
            this.panel3.TabIndex = 1;
            // 
            // AllOrder
            // 
            this.AllOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllOrder.Location = new System.Drawing.Point(30, 262);
            this.AllOrder.Name = "AllOrder";
            this.AllOrder.Size = new System.Drawing.Size(181, 32);
            this.AllOrder.TabIndex = 1;
            this.AllOrder.Text = "Всі замовлення";
            this.AllOrder.UseVisualStyleBackColor = true;
            this.AllOrder.Click += new System.EventHandler(this.AllOrder_Click);
            // 
            // back_order
            // 
            this.back_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_order.Location = new System.Drawing.Point(30, 224);
            this.back_order.Name = "back_order";
            this.back_order.Size = new System.Drawing.Size(155, 32);
            this.back_order.TabIndex = 1;
            this.back_order.Text = "Замовлення";
            this.back_order.UseVisualStyleBackColor = true;
            this.back_order.Click += new System.EventHandler(this.back_order_Click);
            // 
            // Supply_Acceptance
            // 
            this.Supply_Acceptance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Supply_Acceptance.Location = new System.Drawing.Point(30, 137);
            this.Supply_Acceptance.Name = "Supply_Acceptance";
            this.Supply_Acceptance.Size = new System.Drawing.Size(155, 32);
            this.Supply_Acceptance.TabIndex = 1;
            this.Supply_Acceptance.Text = "Розмістити";
            this.Supply_Acceptance.UseVisualStyleBackColor = true;
            this.Supply_Acceptance.Click += new System.EventHandler(this.Supply_Acceptance_Click);
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(30, 99);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(155, 32);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click_1);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(30, 60);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(155, 32);
            this.EDIT.TabIndex = 0;
            this.EDIT.Text = "Оновити";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click_1);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(30, 22);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(155, 32);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 302);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // OrderOfSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderOfSupply";
            this.Text = "OrderOfSupply";
            this.Load += new System.EventHandler(this.OrderOfSupply_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        public System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.ComboBox ID_Provider;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ID_Supply;
        private System.Windows.Forms.ComboBox ID_Product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Supply_Acceptance;
        private System.Windows.Forms.Button AllOrder;
        private System.Windows.Forms.Button back_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}