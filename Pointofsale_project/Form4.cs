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
    public partial class userloginpage : Form
    {
        public userloginpage()
        {
            InitializeComponent();
        }

       

  

        

        private void login_Click(object sender, EventArgs e)
        {
            check chk = new check();
            bool logcheck = chk.login(user.Text, pass.Text);

            if (logcheck == true)
            {
                MessageBox.Show("You are Logged In");
                Usermenupage fm = new Usermenupage();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect !!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            starterpage st = new starterpage();
            st.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            sign_page sp = new sign_page();
            sp.Show();
            this.Hide();
        }

   
    }
}
