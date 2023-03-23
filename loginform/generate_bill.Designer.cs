namespace loginform
{
    partial class generate_bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.billdatagrid2 = new System.Windows.Forms.DataGridView();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdatagrid3 = new System.Windows.Forms.DataGridView();
            this.amountlbl = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.prodIDtb = new System.Windows.Forms.TextBox();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.qtytb = new System.Windows.Forms.TextBox();
            this.billdatagrid1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.discounttb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.billidtb = new System.Windows.Forms.TextBox();
            this.employeeIDlbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "product ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "quantity";
            // 
            // billdatagrid2
            // 
            this.billdatagrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdatagrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billID,
            this.prodID,
            this.prodname,
            this.prodQTY,
            this.prodPrice,
            this.total});
            this.billdatagrid2.Location = new System.Drawing.Point(311, 66);
            this.billdatagrid2.Name = "billdatagrid2";
            this.billdatagrid2.Size = new System.Drawing.Size(512, 146);
            this.billdatagrid2.TabIndex = 16;
            // 
            // billID
            // 
            this.billID.HeaderText = "billID";
            this.billID.Name = "billID";
            // 
            // prodID
            // 
            this.prodID.HeaderText = "prodID";
            this.prodID.Name = "prodID";
            // 
            // prodname
            // 
            this.prodname.HeaderText = "prodName";
            this.prodname.Name = "prodname";
            // 
            // prodQTY
            // 
            this.prodQTY.HeaderText = "prodQTY";
            this.prodQTY.Name = "prodQTY";
            // 
            // prodPrice
            // 
            this.prodPrice.HeaderText = "prodPrice";
            this.prodPrice.Name = "prodPrice";
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // billdatagrid3
            // 
            this.billdatagrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdatagrid3.Location = new System.Drawing.Point(438, 296);
            this.billdatagrid3.Name = "billdatagrid3";
            this.billdatagrid3.Size = new System.Drawing.Size(364, 145);
            this.billdatagrid3.TabIndex = 17;
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.Location = new System.Drawing.Point(493, 241);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(0, 13);
            this.amountlbl.TabIndex = 18;
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(147, 111);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(100, 20);
            this.nametb.TabIndex = 20;
            // 
            // prodIDtb
            // 
            this.prodIDtb.Location = new System.Drawing.Point(147, 68);
            this.prodIDtb.Name = "prodIDtb";
            this.prodIDtb.Size = new System.Drawing.Size(100, 20);
            this.prodIDtb.TabIndex = 21;
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(147, 151);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(100, 20);
            this.pricetb.TabIndex = 22;
            // 
            // qtytb
            // 
            this.qtytb.Location = new System.Drawing.Point(147, 192);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(100, 20);
            this.qtytb.TabIndex = 23;
            // 
            // billdatagrid1
            // 
            this.billdatagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdatagrid1.Location = new System.Drawing.Point(12, 299);
            this.billdatagrid1.Name = "billdatagrid1";
            this.billdatagrid1.Size = new System.Drawing.Size(372, 172);
            this.billdatagrid1.TabIndex = 24;
            this.billdatagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billdatagrid1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(159, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Add Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(626, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "ORDER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "BILL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Amount Rs.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // discounttb
            // 
            this.discounttb.Location = new System.Drawing.Point(147, 234);
            this.discounttb.Name = "discounttb";
            this.discounttb.Size = new System.Drawing.Size(100, 20);
            this.discounttb.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Bill ID";
            // 
            // billidtb
            // 
            this.billidtb.Location = new System.Drawing.Point(147, 28);
            this.billidtb.Name = "billidtb";
            this.billidtb.Size = new System.Drawing.Size(100, 20);
            this.billidtb.TabIndex = 34;
            // 
            // employeeIDlbl
            // 
            this.employeeIDlbl.AutoSize = true;
            this.employeeIDlbl.Location = new System.Drawing.Point(34, 9);
            this.employeeIDlbl.Name = "employeeIDlbl";
            this.employeeIDlbl.Size = new System.Drawing.Size(63, 13);
            this.employeeIDlbl.TabIndex = 35;
            this.employeeIDlbl.Text = "employeeID";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(742, 9);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(28, 13);
            this.datelbl.TabIndex = 36;
            this.datelbl.Text = "date";
            this.datelbl.Click += new System.EventHandler(this.datelbl_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(311, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "choose another option";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(524, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // generate_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 510);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.employeeIDlbl);
            this.Controls.Add(this.billidtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discounttb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.billdatagrid1);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.prodIDtb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.billdatagrid3);
            this.Controls.Add(this.billdatagrid2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "generate_bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "generate_bill";
            this.Load += new System.EventHandler(this.generate_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView billdatagrid2;
        private System.Windows.Forms.DataGridView billdatagrid3;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox prodIDtb;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.TextBox qtytb;
        private System.Windows.Forms.DataGridView billdatagrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox discounttb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox billidtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label employeeIDlbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}