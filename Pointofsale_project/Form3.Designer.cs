namespace Pointofsale_project
{
    partial class Usermenupage
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
            this.add = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet = new Pointofsale_project.posDataSet();
            this.table_2TableAdapter = new Pointofsale_project.posDataSetTableAdapters.Table_2TableAdapter();
            this.itemmenu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pricemenu = new System.Windows.Forms.TextBox();
            this.idmenu = new System.Windows.Forms.TextBox();
            this.table2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.table2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.removeall = new System.Windows.Forms.Button();
            this.generatebill = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.received = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your Favourite Dish and \r\nAdd to Food Bucket";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(49, 322);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(110, 51);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(165, 516);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(138, 20);
            this.quantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "quantity :";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Bill
            // 
            this.Bill.AllowUserToAddRows = false;
            this.Bill.AllowUserToDeleteRows = false;
            this.Bill.AllowUserToResizeColumns = false;
            this.Bill.AllowUserToResizeRows = false;
            this.Bill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bill.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bill.Location = new System.Drawing.Point(49, 45);
            this.Bill.Name = "Bill";
            this.Bill.ReadOnly = true;
            this.Bill.Size = new System.Drawing.Size(503, 255);
            this.Bill.TabIndex = 5;
            // 
            // menu
            // 
            this.menu.AllowUserToAddRows = false;
            this.menu.AllowUserToDeleteRows = false;
            this.menu.AllowUserToResizeColumns = false;
            this.menu.AllowUserToResizeRows = false;
            this.menu.AutoGenerateColumns = false;
            this.menu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.menu.DataSource = this.table2BindingSource;
            this.menu.Location = new System.Drawing.Point(47, 110);
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            this.menu.Size = new System.Drawing.Size(345, 255);
            this.menu.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "item name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "item name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table_2";
            this.table2BindingSource.DataSource = this.posDataSet;
            // 
            // posDataSet
            // 
            this.posDataSet.DataSetName = "posDataSet";
            this.posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_2TableAdapter
            // 
            this.table_2TableAdapter.ClearBeforeFill = true;
            // 
            // itemmenu
            // 
            this.itemmenu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "item name", true));
            this.itemmenu.Enabled = false;
            this.itemmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemmenu.Location = new System.Drawing.Point(165, 444);
            this.itemmenu.Name = "itemmenu";
            this.itemmenu.Size = new System.Drawing.Size(138, 20);
            this.itemmenu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(87, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(66, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price :";
            // 
            // pricemenu
            // 
            this.pricemenu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "Price", true));
            this.pricemenu.Enabled = false;
            this.pricemenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricemenu.Location = new System.Drawing.Point(165, 479);
            this.pricemenu.Name = "pricemenu";
            this.pricemenu.Size = new System.Drawing.Size(138, 20);
            this.pricemenu.TabIndex = 13;
            // 
            // idmenu
            // 
            this.idmenu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table2BindingSource, "ID", true));
            this.idmenu.Enabled = false;
            this.idmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idmenu.Location = new System.Drawing.Point(165, 403);
            this.idmenu.Name = "idmenu";
            this.idmenu.Size = new System.Drawing.Size(138, 20);
            this.idmenu.TabIndex = 14;
            // 
            // table2BindingSource1
            // 
            this.table2BindingSource1.DataMember = "Table_2";
            this.table2BindingSource1.DataSource = this.posDataSet;
            // 
            // table2BindingSource2
            // 
            this.table2BindingSource2.DataMember = "Table_2";
            this.table2BindingSource2.DataSource = this.posDataSet;
            // 
            // table2BindingSource3
            // 
            this.table2BindingSource3.DataMember = "Table_2";
            this.table2BindingSource3.DataSource = this.posDataSet;
            // 
            // removeall
            // 
            this.removeall.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeall.Location = new System.Drawing.Point(194, 322);
            this.removeall.Name = "removeall";
            this.removeall.Size = new System.Drawing.Size(104, 51);
            this.removeall.TabIndex = 15;
            this.removeall.Text = "Remove All";
            this.removeall.UseVisualStyleBackColor = true;
            this.removeall.Click += new System.EventHandler(this.removeall_Click);
            // 
            // generatebill
            // 
            this.generatebill.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generatebill.Location = new System.Drawing.Point(336, 322);
            this.generatebill.Name = "generatebill";
            this.generatebill.Size = new System.Drawing.Size(108, 51);
            this.generatebill.TabIndex = 16;
            this.generatebill.Text = "Generate Bill";
            this.generatebill.UseVisualStyleBackColor = true;
            this.generatebill.Click += new System.EventHandler(this.generatebill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(467, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(521, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "0";
            // 
            // received
            // 
            this.received.Location = new System.Drawing.Point(736, 501);
            this.received.Multiline = true;
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(181, 22);
            this.received.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(535, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Customer Amount =";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(322, 394);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(95, 51);
            this.logout.TabIndex = 21;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Bill);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.removeall);
            this.groupBox1.Controls.Add(this.generatebill);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(473, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 417);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Bucket";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(923, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(892, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Waiter at your service";
            // 
            // Usermenupage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pointofsale_project.Properties.Resources.blur_close_up_dining_313700;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 595);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.received);
            this.Controls.Add(this.idmenu);
            this.Controls.Add(this.pricemenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemmenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Name = "Usermenupage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Usermenupage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView Bill;
        private System.Windows.Forms.DataGridView menu;
        private posDataSet posDataSet;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private posDataSetTableAdapters.Table_2TableAdapter table_2TableAdapter;
        private System.Windows.Forms.TextBox itemmenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource table2BindingSource2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricemenu;
        private System.Windows.Forms.BindingSource table2BindingSource3;
        private System.Windows.Forms.TextBox idmenu;
        private System.Windows.Forms.BindingSource table2BindingSource1;
        private System.Windows.Forms.Button removeall;
        private System.Windows.Forms.Button generatebill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox received;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}