﻿namespace loginform
{
    partial class enter_stock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unittb = new System.Windows.Forms.TextBox();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.discounttb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dbprojectDataSet = new loginform.dbprojectDataSet();
            this.dbprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productdatagrid = new System.Windows.Forms.DataGridView();
            this.datelbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(152, 54);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(143, 20);
            this.IDtb.TabIndex = 2;
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(152, 96);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(143, 20);
            this.nametb.TabIndex = 4;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // qtytb
            // 
            this.qtytb.Location = new System.Drawing.Point(152, 215);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(143, 20);
            this.qtytb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unit";
            // 
            // unittb
            // 
            this.unittb.Location = new System.Drawing.Point(152, 137);
            this.unittb.Name = "unittb";
            this.unittb.Size = new System.Drawing.Size(143, 20);
            this.unittb.TabIndex = 7;
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(152, 174);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(143, 20);
            this.pricetb.TabIndex = 8;
            this.pricetb.TextChanged += new System.EventHandler(this.pricetb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit Price";
            // 
            // discounttb
            // 
            this.discounttb.Location = new System.Drawing.Point(152, 261);
            this.discounttb.Name = "discounttb";
            this.discounttb.Size = new System.Drawing.Size(143, 20);
            this.discounttb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Discount";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(179, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(291, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dbprojectDataSet
            // 
            this.dbprojectDataSet.DataSetName = "dbprojectDataSet";
            this.dbprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbprojectDataSetBindingSource
            // 
            this.dbprojectDataSetBindingSource.DataSource = this.dbprojectDataSet;
            this.dbprojectDataSetBindingSource.Position = 0;
            // 
            // productdatagrid
            // 
            this.productdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdatagrid.Location = new System.Drawing.Point(342, 32);
            this.productdatagrid.Name = "productdatagrid";
            this.productdatagrid.Size = new System.Drawing.Size(446, 291);
            this.productdatagrid.TabIndex = 15;
            this.productdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(719, 9);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(30, 13);
            this.datelbl.TabIndex = 16;
            this.datelbl.Text = "Date";
            this.datelbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(80, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "choose another option";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // enter_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.productdatagrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discounttb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.unittb);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "enter_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "enter_stock";
            this.Load += new System.EventHandler(this.enter_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unittb;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox discounttb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource dbprojectDataSetBindingSource;
        private dbprojectDataSet dbprojectDataSet;
        private System.Windows.Forms.DataGridView productdatagrid;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Button button4;
    }
}