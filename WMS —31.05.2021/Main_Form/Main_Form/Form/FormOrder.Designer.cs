
namespace Main_Form
{
    partial class FormOrder
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
            this.ID_Order = new System.Windows.Forms.ComboBox();
            this.EditProduct = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Pallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDetails = new System.Windows.Forms.Label();
            this.EDITORDERS = new System.Windows.Forms.Label();
            this.LOrder = new System.Windows.Forms.Label();
            this.TQty = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.ID_Employee = new System.Windows.Forms.ComboBox();
            this.Order_Status = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Orderss = new System.Windows.Forms.Button();
            this.BSum = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wMSDataSet = new Main_Form.WMSDataSet();
            this.ordersDateilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDateilsTableAdapter = new Main_Form.WMSDataSetTableAdapters.OrdersDateilsTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Main_Form.WMSDataSetTableAdapters.ProductTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDateilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.ID_Order);
            this.panel1.Controls.Add(this.EditProduct);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.LDetails);
            this.panel1.Controls.Add(this.EDITORDERS);
            this.panel1.Controls.Add(this.LOrder);
            this.panel1.Controls.Add(this.TQty);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.ID_Employee);
            this.panel1.Controls.Add(this.Order_Status);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 600);
            this.panel1.TabIndex = 0;
            // 
            // ID_Order
            // 
            this.ID_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Order.FormattingEnabled = true;
            this.ID_Order.Location = new System.Drawing.Point(28, 40);
            this.ID_Order.Name = "ID_Order";
            this.ID_Order.Size = new System.Drawing.Size(214, 33);
            this.ID_Order.TabIndex = 13;
            // 
            // EditProduct
            // 
            this.EditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProduct.FormattingEnabled = true;
            this.EditProduct.Location = new System.Drawing.Point(28, 235);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(214, 33);
            this.EditProduct.TabIndex = 12;
            this.EditProduct.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Qty,
            this.ID_Pallet});
            this.dataGridView2.Location = new System.Drawing.Point(301, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(524, 223);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Кількість";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.Width = 125;
            // 
            // ID_Pallet
            // 
            this.ID_Pallet.HeaderText = "Палета";
            this.ID_Pallet.MinimumWidth = 6;
            this.ID_Pallet.Name = "ID_Pallet";
            this.ID_Pallet.Width = 125;
            // 
            // LDetails
            // 
            this.LDetails.AutoSize = true;
            this.LDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDetails.Location = new System.Drawing.Point(306, 10);
            this.LDetails.Name = "LDetails";
            this.LDetails.Size = new System.Drawing.Size(198, 25);
            this.LDetails.TabIndex = 10;
            this.LDetails.Text = "Деталі замовлення";
            // 
            // EDITORDERS
            // 
            this.EDITORDERS.AutoSize = true;
            this.EDITORDERS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EDITORDERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDITORDERS.Location = new System.Drawing.Point(29, 201);
            this.EDITORDERS.Name = "EDITORDERS";
            this.EDITORDERS.Size = new System.Drawing.Size(247, 25);
            this.EDITORDERS.TabIndex = 10;
            this.EDITORDERS.Text = "Редагування замовлення";
            this.EDITORDERS.Visible = false;
            // 
            // LOrder
            // 
            this.LOrder.AutoSize = true;
            this.LOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOrder.Location = new System.Drawing.Point(29, 10);
            this.LOrder.Name = "LOrder";
            this.LOrder.Size = new System.Drawing.Size(129, 25);
            this.LOrder.TabIndex = 10;
            this.LOrder.Text = "Замовлення";
            // 
            // TQty
            // 
            this.TQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TQty.Location = new System.Drawing.Point(28, 272);
            this.TQty.Name = "TQty";
            this.TQty.Size = new System.Drawing.Size(214, 30);
            this.TQty.TabIndex = 9;
            this.TQty.Visible = false;
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Location = new System.Drawing.Point(28, 153);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(214, 30);
            this.Data.TabIndex = 8;
            this.Data.Value = new System.DateTime(2021, 4, 5, 0, 0, 0, 0);
            // 
            // ID_Employee
            // 
            this.ID_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Employee.FormattingEnabled = true;
            this.ID_Employee.Location = new System.Drawing.Point(28, 79);
            this.ID_Employee.Name = "ID_Employee";
            this.ID_Employee.Size = new System.Drawing.Size(214, 33);
            this.ID_Employee.TabIndex = 7;
            // 
            // Order_Status
            // 
            this.Order_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_Status.FormattingEnabled = true;
            this.Order_Status.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.Order_Status.Location = new System.Drawing.Point(28, 116);
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.Size = new System.Drawing.Size(214, 33);
            this.Order_Status.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.Orderss);
            this.panel2.Controls.Add(this.BSum);
            this.panel2.Controls.Add(this.DELETE);
            this.panel2.Controls.Add(this.EDIT);
            this.panel2.Controls.Add(this.ADD);
            this.panel2.Location = new System.Drawing.Point(831, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 600);
            this.panel2.TabIndex = 1;
            // 
            // Orderss
            // 
            this.Orderss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orderss.Location = new System.Drawing.Point(27, 215);
            this.Orderss.Name = "Orderss";
            this.Orderss.Size = new System.Drawing.Size(143, 37);
            this.Orderss.TabIndex = 0;
            this.Orderss.Text = "Замовлення";
            this.Orderss.UseVisualStyleBackColor = true;
            this.Orderss.Click += new System.EventHandler(this.Orderss_Click);
            // 
            // BSum
            // 
            this.BSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSum.Location = new System.Drawing.Point(27, 172);
            this.BSum.Name = "BSum";
            this.BSum.Size = new System.Drawing.Size(143, 37);
            this.BSum.TabIndex = 0;
            this.BSum.Text = "Сума";
            this.BSum.UseVisualStyleBackColor = true;
            this.BSum.Click += new System.EventHandler(this.BSum_Click);
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(27, 119);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(143, 37);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "Видалити";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // EDIT
            // 
            this.EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDIT.Location = new System.Drawing.Point(27, 68);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(143, 37);
            this.EDIT.TabIndex = 0;
            this.EDIT.Text = "Редагувати";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(27, 17);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(143, 37);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(0, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 354);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1112, 351);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersDateilsBindingSource
            // 
            this.ordersDateilsBindingSource.DataMember = "OrdersDateils";
            this.ordersDateilsBindingSource.DataSource = this.wMSDataSet;
            // 
            // ordersDateilsTableAdapter
            // 
            this.ordersDateilsTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.wMSDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.wMSDataSet;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 684);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormOrder";
            this.Text = "Формування замовлення";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDateilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.ComboBox ID_Employee;
        private System.Windows.Forms.ComboBox Order_Status;
        private System.Windows.Forms.Label LDetails;
        private System.Windows.Forms.Label LOrder;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button BSum;
        private System.Windows.Forms.DataGridView dataGridView2;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource ordersDateilsBindingSource;
        private WMSDataSetTableAdapters.OrdersDateilsTableAdapter ordersDateilsTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WMSDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TQty;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.ComboBox EditProduct;
        private System.Windows.Forms.Label EDITORDERS;
        private System.Windows.Forms.ComboBox ID_Order;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pallet;
        private System.Windows.Forms.Button Orderss;
    }
}