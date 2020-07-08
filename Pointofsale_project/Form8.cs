using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pointofsale_project
{
    public partial class checkamount : Form
    {
        public checkamount()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet2.Table_4' table. You can move, or remove it, as needed.
            this.table_4TableAdapter.Fill(this.posDataSet2.Table_4);
            int sum = 0;
            for (int i = 0; i <= display.Rows.Count - 1; i++ )
            {
                sum += Convert.ToInt32(display.Rows[i].Cells[1].Value);
            }
            income.Text = sum.ToString();

        }

        private void ok_Click(object sender, EventArgs e)
        {
            adminmenupage am = new adminmenupage();
            am.Show();
            this.Hide();
        }

      


    }
}
