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
    public partial class starterpage : Form
    {
        public starterpage()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

      
       

        private void admin_Click(object sender, EventArgs e)
        {
            adminloginpage fm = new adminloginpage();
            fm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            userloginpage frm = new userloginpage();
            frm.Show();
            this.Hide();
        }
    }
}
       