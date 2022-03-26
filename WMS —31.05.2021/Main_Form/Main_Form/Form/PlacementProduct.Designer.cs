
namespace Main_Form
{
    partial class PlacementProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.ADDProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.order_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.ID_Products = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.TextBox();
            this.ID_Provider = new System.Windows.Forms.ComboBox();
            this.ID_Product = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADDOrder = new System.Windows.Forms.Button();
            this.OrdersProduct = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.ADDProduct);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LabelProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 628);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(395, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Новий продукт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(395, 83);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 43);
            this.Search.TabIndex = 5;
            this.Search.Text = "Пошук ";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ADDProduct
            // 
            this.ADDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADDProduct.Location = new System.Drawing.Point(32, 334);
            this.ADDProduct.Name = "ADDProduct";
            this.ADDProduct.Size = new System.Drawing.Size(122, 34);
            this.ADDProduct.TabIndex = 4;
            this.ADDProduct.Text = "Створити";
            this.ADDProduct.UseVisualStyleBackColor = true;
            this.ADDProduct.Click += new System.EventHandler(this.ADDProduct_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Product);
            this.panel3.Controls.Add(this.Description);
            this.panel3.Controls.Add(this.Price);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(29, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 245);
            this.panel3.TabIndex = 3;
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(3, 25);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(157, 33);
            this.Product.TabIndex = 3;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.FormattingEnabled = true;
            this.Description.Location = new System.Drawing.Point(3, 62);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(157, 33);
            this.Description.TabIndex = 3;
            this.Description.SelectedIndexChanged += new System.EventHandler(this.Description_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(3, 100);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(157, 30);
            this.Price.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва продукту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(166, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(166, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Опис продукту";
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.BackColor = System.Drawing.Color.Honeydew;
            this.LabelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProduct.Location = new System.Drawing.Point(138, 30);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(272, 31);
            this.LabelProduct.TabIndex = 0;
            this.LabelProduct.Text = "Створення продукту";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.order_button);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ADDOrder);
            this.panel2.Controls.Add(this.OrdersProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(626, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 628);
            this.panel2.TabIndex = 1;
            // 
            // order_button
            // 
            this.order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_button.Location = new System.Drawing.Point(236, 336);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(148, 58);
            this.order_button.TabIndex = 7;
            this.order_button.Text = "Замовлення";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Date);
            this.panel4.Controls.Add(this.ID_Products);
            this.panel4.Controls.Add(this.Qty);
            this.panel4.Controls.Add(this.ID_Provider);
            this.panel4.Controls.Add(this.ID_Product);
            this.panel4.Controls.Add(this.LabelDate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(92, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 245);
            this.panel4.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(3, 92);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 30);
            this.Date.TabIndex = 5;
            // 
            // ID_Products
            // 
            this.ID_Products.AutoSize = true;
            this.ID_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Products.Location = new System.Drawing.Point(211, 129);
            this.ID_Products.Name = "ID_Products";
            this.ID_Products.Size = new System.Drawing.Size(156, 25);
            this.ID_Products.TabIndex = 1;
            this.ID_Products.Text = "Назва продукту";
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qty.Location = new System.Drawing.Point(2, 56);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(200, 30);
            this.Qty.TabIndex = 2;
            // 
            // ID_Provider
            // 
            this.ID_Provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Provider.FormattingEnabled = true;
            this.ID_Provider.Location = new System.Drawing.Point(3, 17);
            this.ID_Provider.Name = "ID_Provider";
            this.ID_Provider.Size = new System.Drawing.Size(200, 33);
            this.ID_Provider.TabIndex = 3;
            // 
            // ID_Product
            // 
            this.ID_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Product.Location = new System.Drawing.Point(4, 129);
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(201, 30);
            this.ID_Product.TabIndex = 2;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.Location = new System.Drawing.Point(211, 92);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(175, 25);
            this.LabelDate.TabIndex = 1;
            this.LabelDate.Text = "Дата привезення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(211, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Провайдер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(211, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Кількість";
            // 
            // ADDOrder
            // 
            this.ADDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADDOrder.Location = new System.Drawing.Point(92, 336);
            this.ADDOrder.Name = "ADDOrder";
            this.ADDOrder.Size = new System.Drawing.Size(139, 58);
            this.ADDOrder.TabIndex = 4;
            this.ADDOrder.Text = "Додати замовлення";
            this.ADDOrder.UseVisualStyleBackColor = true;
            this.ADDOrder.Click += new System.EventHandler(this.ADDOrder_Click);
            // 
            // OrdersProduct
            // 
            this.OrdersProduct.AutoSize = true;
            this.OrdersProduct.BackColor = System.Drawing.Color.Honeydew;
            this.OrdersProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersProduct.Location = new System.Drawing.Point(121, 30);
            this.OrdersProduct.Name = "OrdersProduct";
            this.OrdersProduct.Size = new System.Drawing.Size(298, 31);
            this.OrdersProduct.TabIndex = 0;
            this.OrdersProduct.Text = "Замовлення продукту ";
            // 
            // PlacementProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlacementProduct";
            this.Text = "Розміщення товару ";
            this.Load += new System.EventHandler(this.PlacementProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.Button ADDProduct;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.ComboBox ID_Provider;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ADDOrder;
        private System.Windows.Forms.Label OrdersProduct;
        private System.Windows.Forms.Label ID_Products;
        private System.Windows.Forms.TextBox ID_Product;
        private System.Windows.Forms.Button Search;
        public System.Windows.Forms.ComboBox Description;
        public System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button order_button;
    }
}