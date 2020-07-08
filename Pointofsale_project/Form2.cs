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
    public partial class sign_page : Form
    {
        public sign_page()
        {
            InitializeComponent();
        }

        

       
        private void submit_Click(object sender, EventArgs e)
        {
            check chk = new check();
            chk.signup(newuser.Text, newpass.Text);

            if (newuser.Text != "" && newpass.Text != "" && newuser.Text != newpass.Text)
            {
                MessageBox.Show("You have successfully signup !!");
                userloginpage up = new userloginpage();
                up.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error !!");
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
