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
    public partial class adminloginpage : Form
    {
        public adminloginpage()
        {
            InitializeComponent();
        }

      

        private void Login_Click(object sender, EventArgs e)
        {
            if (ID.Text == "admin" && Password.Text == "abc123")
            {
                MessageBox.Show("Logged In");
                adminmenupage fm = new adminmenupage();
                fm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong ID or Password !!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            starterpage st = new starterpage();
            st.Show();
            this.Hide();
        }

      

     
    }
}
