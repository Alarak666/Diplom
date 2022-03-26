
namespace Main_Form
{
    partial class PlaceOfProduct
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
            this.label111 = new System.Windows.Forms.Label();
            this.ID_Pallet = new System.Windows.Forms.TextBox();
            this.Parameter_Product = new System.Windows.Forms.TextBox();
            this.Occupied = new System.Windows.Forms.CheckBox();
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
            this.ID_Parameters = new System.Windows.Forms.ComboBox();
            this._Place = new System.Windows.Forms.ComboBox();
            this._Level = new System.Windows.Forms.ComboBox();
            this._Rack = new System.Windows.Forms.ComboBox();
            this.Area = new System.Windows.Forms.ComboBox();
            this._Region = new System.Windows.Forms.ComboBox();
            this.ID_Place = new System.Windows.Forms.TextBox();
            this._Notes = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Stock_ = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 288);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label111);
            this.panel2.Controls.Add(this.ID_Pallet);
            this.panel2.Controls.Add(this.Parameter_Product);
            this.panel2.Controls.Add(this.Occupied);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ID_Parameters);
            this.panel2.Controls.Add(this._Place);
            this.panel2.Controls.Add(this._Level);
            this.panel2.Controls.Add(this._Rack);
            this.panel2.Controls.Add(this.Area);
            this.panel2.Controls.Add(this._Region);
            this.panel2.Controls.Add(this.ID_Place);
            this.panel2.Controls.Add(this._Notes);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 486);
            this.panel2.TabIndex = 1;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label111.Location = new System.Drawing.Point(25, 354);
            this.label111.MinimumSize = new System.Drawing.Size(121, 27);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(187, 27);
            this.label111.TabIndex = 8;
            this.label111.Text = "Параметри товару";
            // 
            // ID_Pallet
            // 
            this.ID_Pallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Pallet.Location = new System.Drawing.Point(228, 231);
            this.ID_Pallet.Name = "ID_Pallet";
            this.ID_Pallet.Size = new System.Drawing.Size(501, 30);
            this.ID_Pallet.TabIndex = 7;
            // 
            // Parameter_Product
            // 
            this.Parameter_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parameter_Product.Location = new System.Drawing.Point(228, 354);
            this.Parameter_Product.Name = "Parameter_Product";
            this.Parameter_Product.Size = new System.Drawing.Size(501, 30);
            this.Parameter_Product.TabIndex = 7;
            // 
            // Occupied
            // 
            this.Occupied.AutoSize = true;
            this.Occupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Occupied.Location = new System.Drawing.Point(228, 393);
            this.Occupied.MinimumSize = new System.Drawing.Size(121, 33);
            this.Occupied.Name = "Occupied";
            this.Occupied.Size = new System.Drawing.Size(121, 33);
            this.Occupied.TabIndex = 6;
            this.Occupied.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 432);
            this.label10.MinimumSize = new System.Drawing.Size(121, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 27);
            this.label10.TabIndex = 5;
            this.label10.Text = "Код місця";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(25, 393);
            this.label9.MinimumSize = new System.Drawing.Size(121, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Розміщено";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 312);
            this.label8.MinimumSize = new System.Drawing.Size(121, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Параметри місця";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 273);
            this.label7.MinimumSize = new System.Drawing.Size(121, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Нотатки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 231);
            this.label6.MinimumSize = new System.Drawing.Size(121, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Код палети";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 189);
            this.label5.MinimumSize = new System.Drawing.Size(121, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Місце";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.MinimumSize = new System.Drawing.Size(121, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Рівень";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.MinimumSize = new System.Drawing.Size(121, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стелаж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.MinimumSize = new System.Drawing.Size(121, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Регіон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.MinimumSize = new System.Drawing.Size(121, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Область";
            // 
            // ID_Parameters
            // 
            this.ID_Parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Parameters.FormattingEnabled = true;
            this.ID_Parameters.Location = new System.Drawing.Point(228, 312);
            this.ID_Parameters.Name = "ID_Parameters";
            this.ID_Parameters.Size = new System.Drawing.Size(501, 33);
            this.ID_Parameters.TabIndex = 4;
            // 
            // _Place
            // 
            this._Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Place.FormattingEnabled = true;
            this._Place.Location = new System.Drawing.Point(228, 189);
            this._Place.Name = "_Place";
            this._Place.Size = new System.Drawing.Size(501, 33);
            this._Place.TabIndex = 4;
            // 
            // _Level
            // 
            this._Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Level.FormattingEnabled = true;
            this._Level.Location = new System.Drawing.Point(228, 147);
            this._Level.Name = "_Level";
            this._Level.Size = new System.Drawing.Size(501, 33);
            this._Level.TabIndex = 4;
            this._Level.SelectedIndexChanged += new System.EventHandler(this._Level_SelectedIndexChanged);
            // 
            // _Rack
            // 
            this._Rack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Rack.FormattingEnabled = true;
            this._Rack.Location = new System.Drawing.Point(228, 105);
            this._Rack.Name = "_Rack";
            this._Rack.Size = new System.Drawing.Size(501, 33);
            this._Rack.TabIndex = 4;
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Area.FormattingEnabled = true;
            this.Area.Location = new System.Drawing.Point(228, 63);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(501, 33);
            this.Area.TabIndex = 4;
            this.Area.SelectedValueChanged += new System.EventHandler(this.Area_SelectedValueChanged);
            // 
            // _Region
            // 
            this._Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Region.FormattingEnabled = true;
            this._Region.Location = new System.Drawing.Point(228, 21);
            this._Region.Name = "_Region";
            this._Region.Size = new System.Drawing.Size(501, 33);
            this._Region.TabIndex = 4;
            this._Region.SelectedValueChanged += new System.EventHandler(this._Region_SelectedValueChanged);
            // 
            // ID_Place
            // 
            this.ID_Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_Place.Location = new System.Drawing.Point(228, 432);
            this.ID_Place.Name = "ID_Place";
            this.ID_Place.Size = new System.Drawing.Size(501, 30);
            this.ID_Place.TabIndex = 3;
            // 
            // _Notes
            // 
            this._Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Notes.Location = new System.Drawing.Point(228, 273);
            this._Notes.Name = "_Notes";
            this._Notes.Size = new System.Drawing.Size(501, 30);
            this._Notes.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.Stock_);
            this.panel3.Controls.Add(this.ADD);
            this.panel3.Location = new System.Drawing.Point(773, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 486);
            this.panel3.TabIndex = 2;
            // 
            // Stock_
            // 
            this.Stock_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stock_.Location = new System.Drawing.Point(22, 69);
            this.Stock_.Name = "Stock_";
            this.Stock_.Size = new System.Drawing.Size(196, 63);
            this.Stock_.TabIndex = 5;
            this.Stock_.Text = "Розмістити на склад";
            this.Stock_.UseVisualStyleBackColor = true;
            this.Stock_.Click += new System.EventHandler(this.Stock__Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD.Location = new System.Drawing.Point(22, 14);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(196, 39);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "Додати";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // PlaceOfProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PlaceOfProduct";
            this.Text = "PlaceOfProduct";
            this.Load += new System.EventHandler(this.PlaceOfProduct_Load);
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
        private System.Windows.Forms.ComboBox ID_Parameters;
        private System.Windows.Forms.ComboBox _Place;
        private System.Windows.Forms.ComboBox _Level;
        private System.Windows.Forms.ComboBox _Rack;
        private System.Windows.Forms.ComboBox Area;
        private System.Windows.Forms.ComboBox _Region;
        private System.Windows.Forms.TextBox ID_Place;
        private System.Windows.Forms.TextBox _Notes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ADD;
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
        private System.Windows.Forms.CheckBox Occupied;
        private System.Windows.Forms.Label label111;
        public System.Windows.Forms.TextBox Parameter_Product;
        public System.Windows.Forms.TextBox ID_Pallet;
        private System.Windows.Forms.Button Stock_;
    }
}