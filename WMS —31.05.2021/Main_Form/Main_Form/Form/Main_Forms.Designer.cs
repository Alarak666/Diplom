
namespace Main_Form
{
    partial class Main_Forms
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
            this.BEmployee = new System.Windows.Forms.Button();
            this.BEmployeeInfo = new System.Windows.Forms.Button();
            this.BPost = new System.Windows.Forms.Button();
            this.OrdersSupply = new System.Windows.Forms.Button();
            this.BPlaceProducts = new System.Windows.Forms.Button();
            this.BStocks = new System.Windows.Forms.Button();
            this.BProvider = new System.Windows.Forms.Button();
            this.BProducts = new System.Windows.Forms.Button();
            this.BOrders = new System.Windows.Forms.Button();
            this.BOrderDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateOrders = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Supply_Order = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BEmployee
            // 
            this.BEmployee.BackColor = System.Drawing.Color.White;
            this.BEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEmployee.Location = new System.Drawing.Point(27, 65);
            this.BEmployee.Name = "BEmployee";
            this.BEmployee.Size = new System.Drawing.Size(211, 74);
            this.BEmployee.TabIndex = 0;
            this.BEmployee.Text = "Працівники";
            this.BEmployee.UseVisualStyleBackColor = false;
            this.BEmployee.Click += new System.EventHandler(this.BEmployee_Click);
            // 
            // BEmployeeInfo
            // 
            this.BEmployeeInfo.BackColor = System.Drawing.Color.White;
            this.BEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEmployeeInfo.Location = new System.Drawing.Point(27, 157);
            this.BEmployeeInfo.Name = "BEmployeeInfo";
            this.BEmployeeInfo.Size = new System.Drawing.Size(211, 74);
            this.BEmployeeInfo.TabIndex = 1;
            this.BEmployeeInfo.Text = "Інформація працівників ";
            this.BEmployeeInfo.UseVisualStyleBackColor = false;
            this.BEmployeeInfo.Click += new System.EventHandler(this.BEmployeeInfo_Click);
            // 
            // BPost
            // 
            this.BPost.BackColor = System.Drawing.Color.White;
            this.BPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPost.Location = new System.Drawing.Point(27, 245);
            this.BPost.Name = "BPost";
            this.BPost.Size = new System.Drawing.Size(211, 74);
            this.BPost.TabIndex = 1;
            this.BPost.Text = "Посада";
            this.BPost.UseVisualStyleBackColor = false;
            this.BPost.Click += new System.EventHandler(this.BPost_Click);
            // 
            // OrdersSupply
            // 
            this.OrdersSupply.BackColor = System.Drawing.Color.White;
            this.OrdersSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersSupply.Location = new System.Drawing.Point(33, 145);
            this.OrdersSupply.Name = "OrdersSupply";
            this.OrdersSupply.Size = new System.Drawing.Size(211, 74);
            this.OrdersSupply.TabIndex = 1;
            this.OrdersSupply.Text = "Замовлення на постачання";
            this.OrdersSupply.UseVisualStyleBackColor = false;
            this.OrdersSupply.Click += new System.EventHandler(this.OrdersSupply_Click);
            // 
            // BPlaceProducts
            // 
            this.BPlaceProducts.BackColor = System.Drawing.Color.White;
            this.BPlaceProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPlaceProducts.Location = new System.Drawing.Point(35, 157);
            this.BPlaceProducts.Name = "BPlaceProducts";
            this.BPlaceProducts.Size = new System.Drawing.Size(211, 74);
            this.BPlaceProducts.TabIndex = 3;
            this.BPlaceProducts.Text = "Розміщення продукції";
            this.BPlaceProducts.UseVisualStyleBackColor = false;
            this.BPlaceProducts.Click += new System.EventHandler(this.BPlaceProducts_Click);
            // 
            // BStocks
            // 
            this.BStocks.BackColor = System.Drawing.Color.White;
            this.BStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStocks.Location = new System.Drawing.Point(35, 65);
            this.BStocks.Name = "BStocks";
            this.BStocks.Size = new System.Drawing.Size(211, 74);
            this.BStocks.TabIndex = 4;
            this.BStocks.Text = "Склад";
            this.BStocks.UseVisualStyleBackColor = false;
            this.BStocks.Click += new System.EventHandler(this.BStocks_Click);
            // 
            // BProvider
            // 
            this.BProvider.BackColor = System.Drawing.Color.White;
            this.BProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BProvider.Location = new System.Drawing.Point(33, 65);
            this.BProvider.Name = "BProvider";
            this.BProvider.Size = new System.Drawing.Size(211, 74);
            this.BProvider.TabIndex = 6;
            this.BProvider.Text = "Постачальник";
            this.BProvider.UseVisualStyleBackColor = false;
            this.BProvider.Click += new System.EventHandler(this.BProvider_Click);
            // 
            // BProducts
            // 
            this.BProducts.BackColor = System.Drawing.Color.White;
            this.BProducts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BProducts.Location = new System.Drawing.Point(31, 65);
            this.BProducts.Name = "BProducts";
            this.BProducts.Size = new System.Drawing.Size(211, 74);
            this.BProducts.TabIndex = 7;
            this.BProducts.Text = "Продукція";
            this.BProducts.UseVisualStyleBackColor = false;
            this.BProducts.Click += new System.EventHandler(this.BProducts_Click);
            // 
            // BOrders
            // 
            this.BOrders.BackColor = System.Drawing.Color.White;
            this.BOrders.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BOrders.Location = new System.Drawing.Point(31, 157);
            this.BOrders.Name = "BOrders";
            this.BOrders.Size = new System.Drawing.Size(211, 74);
            this.BOrders.TabIndex = 8;
            this.BOrders.Text = "Замовлення";
            this.BOrders.UseVisualStyleBackColor = false;
            this.BOrders.Click += new System.EventHandler(this.BOrders_Click);
            // 
            // BOrderDetails
            // 
            this.BOrderDetails.BackColor = System.Drawing.Color.White;
            this.BOrderDetails.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BOrderDetails.Location = new System.Drawing.Point(31, 245);
            this.BOrderDetails.Name = "BOrderDetails";
            this.BOrderDetails.Size = new System.Drawing.Size(211, 74);
            this.BOrderDetails.TabIndex = 9;
            this.BOrderDetails.Text = "Деталі замовлень";
            this.BOrderDetails.UseVisualStyleBackColor = false;
            this.BOrderDetails.Click += new System.EventHandler(this.BOrderDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.BEmployeeInfo);
            this.panel1.Controls.Add(this.BEmployee);
            this.panel1.Controls.Add(this.BPost);
            this.panel1.Location = new System.Drawing.Point(22, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 433);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.panel2.Controls.Add(this.BProducts);
            this.panel2.Controls.Add(this.BOrders);
            this.panel2.Controls.Add(this.CreateOrders);
            this.panel2.Controls.Add(this.BOrderDetails);
            this.panel2.Location = new System.Drawing.Point(315, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 433);
            this.panel2.TabIndex = 12;
            // 
            // CreateOrders
            // 
            this.CreateOrders.BackColor = System.Drawing.Color.White;
            this.CreateOrders.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreateOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrders.Location = new System.Drawing.Point(31, 336);
            this.CreateOrders.Name = "CreateOrders";
            this.CreateOrders.Size = new System.Drawing.Size(211, 74);
            this.CreateOrders.TabIndex = 9;
            this.CreateOrders.Text = "Створення замовлень";
            this.CreateOrders.UseVisualStyleBackColor = false;
            this.CreateOrders.Click += new System.EventHandler(this.CreateOrders_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.panel3.Controls.Add(this.BStocks);
            this.panel3.Controls.Add(this.Supply_Order);
            this.panel3.Controls.Add(this.BPlaceProducts);
            this.panel3.Location = new System.Drawing.Point(606, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 433);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(101)))));
            this.panel4.Controls.Add(this.BProvider);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.OrdersSupply);
            this.panel4.Location = new System.Drawing.Point(897, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 433);
            this.panel4.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Постачання";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main_Form.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(376, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Supply_Order
            // 
            this.Supply_Order.BackColor = System.Drawing.Color.White;
            this.Supply_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Supply_Order.Location = new System.Drawing.Point(35, 245);
            this.Supply_Order.Name = "Supply_Order";
            this.Supply_Order.Size = new System.Drawing.Size(211, 74);
            this.Supply_Order.TabIndex = 3;
            this.Supply_Order.Text = "Розміщення постачання";
            this.Supply_Order.UseVisualStyleBackColor = false;
            this.Supply_Order.Click += new System.EventHandler(this.Supply_Order_Click);
            // 
            // Main_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1220, 616);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main_Forms";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Main_Forms_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BEmployee;
        private System.Windows.Forms.Button BEmployeeInfo;
        private System.Windows.Forms.Button BPost;
        private System.Windows.Forms.Button OrdersSupply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BPlaceProducts;
        private System.Windows.Forms.Button BStocks;
        private System.Windows.Forms.Button BProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button BProducts;
        public System.Windows.Forms.Button BOrders;
        public System.Windows.Forms.Button BOrderDetails;
        public System.Windows.Forms.Button CreateOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Supply_Order;
    }
}