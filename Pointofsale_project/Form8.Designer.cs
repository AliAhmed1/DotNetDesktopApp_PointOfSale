namespace Pointofsale_project
{
    partial class checkamount
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
            this.display = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet2 = new Pointofsale_project.posDataSet2();
            this.table_4TableAdapter = new Pointofsale_project.posDataSet2TableAdapters.Table_4TableAdapter();
            this.ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AllowUserToAddRows = false;
            this.display.AllowUserToDeleteRows = false;
            this.display.AutoGenerateColumns = false;
            this.display.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.receivedAmountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.display.DataSource = this.table4BindingSource;
            this.display.Location = new System.Drawing.Point(158, 105);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(443, 221);
            this.display.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedAmountDataGridViewTextBoxColumn
            // 
            this.receivedAmountDataGridViewTextBoxColumn.DataPropertyName = "Received Amount";
            this.receivedAmountDataGridViewTextBoxColumn.HeaderText = "Received Amount";
            this.receivedAmountDataGridViewTextBoxColumn.Name = "receivedAmountDataGridViewTextBoxColumn";
            this.receivedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // table4BindingSource
            // 
            this.table4BindingSource.DataMember = "Table_4";
            this.table4BindingSource.DataSource = this.posDataSet2;
            // 
            // posDataSet2
            // 
            this.posDataSet2.DataSetName = "posDataSet2";
            this.posDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_4TableAdapter
            // 
            this.table_4TableAdapter.ClearBeforeFill = true;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(328, 435);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(107, 42);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Income($) =";
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income.Location = new System.Drawing.Point(441, 372);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(19, 20);
            this.income.TabIndex = 3;
            this.income.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cashier statements";
            // 
            // checkamount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.income);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.display);
            this.Name = "checkamount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amount Statement";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView display;
        private posDataSet2 posDataSet2;
        private System.Windows.Forms.BindingSource table4BindingSource;
        private posDataSet2TableAdapters.Table_4TableAdapter table_4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label label2;
    }
}