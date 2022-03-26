
namespace Main_Form
{
    partial class FormAcceptance
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.Supply = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ID_Pallet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAcceptance = new System.Windows.Forms.DateTimePicker();
            this.Date_Expiration = new System.Windows.Forms.DateTimePicker();
            this.ID_Acceptance = new System.Windows.Forms.ComboBox();
            this.ID_Supply = new System.Windows.Forms.ComboBox();
            this.Type_Pallet = new System.Windows.Forms.ComboBox();
            this.ID_Employyer = new System.Windows.Forms.ComboBox();
            this.ID_Product = new System.Windows.Forms.ComboBox();
            this._Height = new System.Windows.Forms.TextBox();
            this._Weight = new System.Windows.Forms.TextBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this._Lenght = new System.Windows.Forms.TextBox();
            this._Width = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlaceOfProduct = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 249);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 255);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 500);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Supply);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.ID_Pallet);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.DateAcceptance);
            this.panel4.Controls.Add(this.Date_Expiration);
            this.panel4.Controls.Add(this.ID_Acceptance);
            this.panel4.Controls.Add(this.ID_Supply);
            this.panel4.Controls.Add(this.Type_Pallet);
            this.panel4.Controls.Add(this.ID_Employyer);
            this.panel4.Controls.Add(this.ID_Product);
            this.panel4.Controls.Add(this._Height);
            this.panel4.Controls.Add(this._Weight);
            this.panel4.Controls.Add(this.Qty);
            this.panel4.Controls.Add(this._Lenght);
            this.panel4.Controls.Add(this._Width);
            this.panel4.Location = new System.Drawing.Point(11, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 488);
            this.panel4.TabIndex = 6;
            // 
            // Supply
            // 
            this.Supply.AutoSize = true;
            this.Supply.BackColor = System.Drawing.Color.White;
            this.Supply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Supply.Location = new System.Drawing.Point(3, 446);
            this.Supply.MinimumSize = new System.Drawing.Size(190, 27);
            this.Supply.Name = "Supply";
            this.Supply.Size = new System.Drawing.Size(190, 27);
            this.Supply.TabIndex = 5;
            this.Supply.Text = "Код постачання";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 410);
            this.label12.MinimumSize = new System.Drawing.Size(190, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 27);
            this.label12.TabIndex = 5;
            this.label12.Text = "Код палети";
            // 
            // ID_Pallet
            // 
            this.ID_Pallet.Enabled = false;
            this.ID_Pallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Pallet.Location = new System.Drawing.Point(221, 410);
            this.ID_Pallet.Name = "ID_Pallet";
            this.ID_Pallet.Size = new System.Drawing.Size(299, 30);
            this.ID_Pallet.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 374);
            this.label11.MinimumSize = new System.Drawing.Size(190, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 27);
            this.label11.TabIndex = 5;
            this.label11.Text = "Дата придатности";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 338);
            this.label10.MinimumSize = new System.Drawing.Size(190, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 27);
            this.label10.TabIndex = 5;
            this.label10.Text = "Дата прийому";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 302);
            this.label9.MinimumSize = new System.Drawing.Size(190, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Кількість";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 266);
            this.label8.MinimumSize = new System.Drawing.Size(190, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Вага";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 230);
            this.label7.MinimumSize = new System.Drawing.Size(190, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Длина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 194);
            this.label6.MinimumSize = new System.Drawing.Size(190, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Висота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.MinimumSize = new System.Drawing.Size(190, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.MinimumSize = new System.Drawing.Size(190, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Працівник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.MinimumSize = new System.Drawing.Size(190, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Продукт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.MinimumSize = new System.Drawing.Size(190, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип палети";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.MinimumSize = new System.Drawing.Size(190, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Код";
            // 
            // DateAcceptance
            // 
            this.DateAcceptance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateAcceptance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateAcceptance.Location = new System.Drawing.Point(221, 338);
            this.DateAcceptance.Name = "DateAcceptance";
            this.DateAcceptance.Size = new System.Drawing.Size(299, 30);
            this.DateAcceptance.TabIndex = 4;
            // 
            // Date_Expiration
            // 
            this.Date_Expiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Expiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Expiration.Location = new System.Drawing.Point(221, 374);
            this.Date_Expiration.Name = "Date_Expiration";
            this.Date_Expiration.Size = new System.Drawing.Size(299, 30);
            this.Date_Expiration.TabIndex = 4;
            // 
            // ID_Acceptance
            // 
            this.ID_Acceptance.Enabled = false;
            this.ID_Acceptance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Acceptance.FormattingEnabled = true;
            this.ID_Acceptance.Location = new System.Drawing.Point(221, 5);
            this.ID_Acceptance.Name = "ID_Acceptance";
            this.ID_Acceptance.Size = new System.Drawing.Size(299, 33);
            this.ID_Acceptance.TabIndex = 2;
            // 
            // ID_Supply
            // 
            this.ID_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Supply.FormattingEnabled = true;
            this.ID_Supply.Location = new System.Drawing.Point(221, 446);
            this.ID_Supply.Name = "ID_Supply";
            this.ID_Supply.Size = new System.Drawing.Size(299, 33);
            this.ID_Supply.TabIndex = 2;
            // 
            // Type_Pallet
            // 
            this.Type_Pallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_Pallet.FormattingEnabled = true;
            this.Type_Pallet.Location = new System.Drawing.Point(221, 44);
            this.Type_Pallet.Name = "Type_Pallet";
            this.Type_Pallet.Size = new System.Drawing.Size(299, 33);
            this.Type_Pallet.TabIndex = 2;
            // 
            // ID_Employyer
            // 
            this.ID_Employyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Employyer.FormattingEnabled = true;
            this.ID_Employyer.Location = new System.Drawing.Point(221, 121);
            this.ID_Employyer.Name = "ID_Employyer";
            this.ID_Employyer.Size = new System.Drawing.Size(299, 33);
            this.ID_Employyer.TabIndex = 2;
            // 
            // ID_Product
            // 
            this.ID_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Product.FormattingEnabled = true;
            this.ID_Product.Location = new System.Drawing.Point(221, 82);
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.Size = new System.Drawing.Size(299, 33);
            this.ID_Product.TabIndex = 2;
            // 
            // _Height
            // 
            this._Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Height.Location = new System.Drawing.Point(221, 194);
            this._Height.Name = "_Height";
            this._Height.Size = new System.Drawing.Size(299, 30);
            this._Height.TabIndex = 1;
            // 
            // _Weight
            // 
            this._Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Weight.Location = new System.Drawing.Point(221, 266);
            this._Weight.Name = "_Weight";
            this._Weight.Size = new System.Drawing.Size(299, 30);
            this._Weight.TabIndex = 1;
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qty.Location = new System.Drawing.Point(221, 302);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(299, 30);
            this.Qty.TabIndex = 1;
            // 
            // _Lenght
            // 
            this._Lenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Lenght.Location = new System.Drawing.Point(221, 230);
            this._Lenght.Name = "_Lenght";
            this._Lenght.Size = new System.Drawing.Size(299, 30);
            this._Lenght.TabIndex = 1;
            // 
            // _Width
            // 
            this._Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Width.Location = new System.Drawing.Point(221, 158);
            this._Width.Name = "_Width";
            this._Width.Size = new System.Drawing.Size(299, 30);
            this._Width.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PlaceOfProduct);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(676, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 499);
            this.panel3.TabIndex = 0;
            // 
            // PlaceOfProduct
            // 
            this.PlaceOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceOfProduct.Location = new System.Drawing.Point(35, 91);
            this.PlaceOfProduct.Name = "PlaceOfProduct";
            this.PlaceOfProduct.Size = new System.Drawing.Size(156, 53);
            this.PlaceOfProduct.TabIndex = 0;
            this.PlaceOfProduct.Text = "Розміщення на склад";
            this.PlaceOfProduct.UseVisualStyleBackColor = true;
            this.PlaceOfProduct.Click += new System.EventHandler(this.PlaceOfProduct_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(35, 20);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(156, 53);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Прийом товару";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // FormAcceptance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAcceptance";
            this.Text = "FormAcceptance";
            this.Load += new System.EventHandler(this.FormAcceptance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker Date_Expiration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ID_Acceptance;
        public System.Windows.Forms.ComboBox ID_Supply;
        public System.Windows.Forms.ComboBox ID_Product;
        private System.Windows.Forms.TextBox _Height;
        private System.Windows.Forms.TextBox _Lenght;
        private System.Windows.Forms.TextBox _Width;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox _Weight;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DateAcceptance;
        public System.Windows.Forms.TextBox ID_Pallet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PlaceOfProduct;
        private System.Windows.Forms.ComboBox Type_Pallet;
        private System.Windows.Forms.Label Supply;
        private System.Windows.Forms.ComboBox ID_Employyer;
    }
}