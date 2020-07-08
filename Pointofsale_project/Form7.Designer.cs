namespace Pointofsale_project
{
    partial class Billpage
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
            this.label2 = new System.Windows.Forms.Label();
            this.table3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet1 = new Pointofsale_project.posDataSet1();
            this.table3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.table4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_3TableAdapter = new Pointofsale_project.posDataSet1TableAdapters.Table_3TableAdapter();
            this.table_4TableAdapter = new Pointofsale_project.posDataSet1TableAdapters.Table_4TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.table6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet2 = new Pointofsale_project.posDataSet2();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.table6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.table6BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_6TableAdapter = new Pointofsale_project.posDataSet2TableAdapters.Table_6TableAdapter();
            this.table_5TableAdapter = new Pointofsale_project.posDataSet2TableAdapters.Table_5TableAdapter();
            this.logout = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 144);
            this.label2.TabIndex = 1;
            this.label2.Text = "  Thank You \r\nFor Purchasing\r\n hope You like \r\n   Our Food";
            // 
            // table3BindingSource1
            // 
            this.table3BindingSource1.DataMember = "Table_3";
            this.table3BindingSource1.DataSource = this.posDataSet1;
            // 
            // posDataSet1
            // 
            this.posDataSet1.DataSetName = "posDataSet1";
            this.posDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table3BindingSource
            // 
            this.table3BindingSource.DataMember = "Table_3";
            this.table3BindingSource.DataSource = this.posDataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Amount =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Received Amount =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance =";
            // 
            // table4BindingSource
            // 
            this.table4BindingSource.DataMember = "Table_4";
            this.table4BindingSource.DataSource = this.posDataSet1;
            // 
            // table_3TableAdapter
            // 
            this.table_3TableAdapter.ClearBeforeFill = true;
            // 
            // table_4TableAdapter
            // 
            this.table_4TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table6BindingSource, "Total Amount", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(153, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 6;
            // 
            // table6BindingSource
            // 
            this.table6BindingSource.DataMember = "Table_6";
            this.table6BindingSource.DataSource = this.posDataSet2;
            // 
            // posDataSet2
            // 
            this.posDataSet2.DataSetName = "posDataSet2";
            this.posDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table6BindingSource1, "Received Amount", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(153, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 7;
            // 
            // table6BindingSource1
            // 
            this.table6BindingSource1.DataMember = "Table_6";
            this.table6BindingSource1.DataSource = this.posDataSet2;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table6BindingSource2, "Balance", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(153, 330);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 8;
            // 
            // table6BindingSource2
            // 
            this.table6BindingSource2.DataMember = "Table_6";
            this.table6BindingSource2.DataSource = this.posDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table5BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(47, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 9;
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
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // table5BindingSource
            // 
            this.table5BindingSource.DataMember = "Table_5";
            this.table5BindingSource.DataSource = this.posDataSet2;
            // 
            // table_6TableAdapter
            // 
            this.table_6TableAdapter.ClearBeforeFill = true;
            // 
            // table_5TableAdapter
            // 
            this.table_5TableAdapter.ClearBeforeFill = true;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(328, 458);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(120, 42);
            this.logout.TabIndex = 10;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(470, 458);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 42);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 381);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Bill";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(210, 458);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(98, 42);
            this.back.TabIndex = 13;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "$";
            // 
            // Billpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pointofsale_project.Properties.Resources.alexandre_godreau_510220_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 542);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table4BindingSource, "Total Amount", true));
            this.Name = "Billpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billpage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private posDataSet1 posDataSet1;
        private System.Windows.Forms.BindingSource table3BindingSource;
        private posDataSet1TableAdapters.Table_3TableAdapter table_3TableAdapter;
        private System.Windows.Forms.BindingSource table3BindingSource1;
        private System.Windows.Forms.BindingSource table4BindingSource;
        private posDataSet1TableAdapters.Table_4TableAdapter table_4TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private posDataSet2 posDataSet2;
        private System.Windows.Forms.BindingSource table6BindingSource;
        private posDataSet2TableAdapters.Table_6TableAdapter table_6TableAdapter;
        private System.Windows.Forms.BindingSource table6BindingSource1;
        private System.Windows.Forms.BindingSource table6BindingSource2;
        private System.Windows.Forms.BindingSource table5BindingSource;
        private posDataSet2TableAdapters.Table_5TableAdapter table_5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}