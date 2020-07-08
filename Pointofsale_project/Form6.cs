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
    public partial class adminmenupage : Form
    {
        public adminmenupage()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.posDataSet.Table_2);

        }

    

        private void update_Click(object sender, EventArgs e)
        {
            check chk = new check();
            chk.update(Convert.ToInt32(ID2.Text), item2.Text, Convert.ToInt32(price2.Text));
            MessageBox.Show("item Updated !!");
            ID2.Clear();
            item2.Clear();
            price2.Clear();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            check chk = new check();
            chk.delete(Convert.ToInt32(id3.Text));
            MessageBox.Show("item Deleted !!");
            id3.Clear();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            adminmenupage fm = new adminmenupage();
            fm.Show();
            this.Hide();
        }

     


        private void insert_Click(object sender, EventArgs e)
        {
            check chk = new check();
            chk.insert(item.Text, Convert.ToInt32(Price.Text));
            MessageBox.Show("item Inserted !!");
            item.Clear();
            Price.Clear();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Are Logged Out");
            adminloginpage ap = new adminloginpage();
            ap.Show();
            this.Hide();
        }

        private void checkincome_Click(object sender, EventArgs e)
        {
            checkamount ca = new checkamount();
            ca.Show();
            this.Hide();
        }
    }
}
