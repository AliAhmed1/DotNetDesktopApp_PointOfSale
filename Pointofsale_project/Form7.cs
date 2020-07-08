using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pointofsale_project
{
    public partial class Billpage : Form
    {
        public Billpage()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DESKTOP-NIHMH34\\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");   

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet2.Table_5' table. You can move, or remove it, as needed.
            this.table_5TableAdapter.Fill(this.posDataSet2.Table_5);
            // TODO: This line of code loads data into the 'posDataSet2.Table_6' table. You can move, or remove it, as needed.
            this.table_6TableAdapter.Fill(this.posDataSet2.Table_6);
            
           

        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from table_5", conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmad = new SqlCommand("delete from table_6", conn);
            cmad.ExecuteNonQuery();
            conn.Close();
        }

   

        private void logout_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from table_5", conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmad = new SqlCommand("delete from table_6", conn);
            cmad.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("You Have Been logged Out");
            userloginpage up = new userloginpage();
            up.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from table_5", conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmad = new SqlCommand("delete from table_6", conn);
            cmad.ExecuteNonQuery();
            conn.Close();
            Usermenupage up = new Usermenupage();
            up.Show();
            this.Hide();
           

        }


     

     
    }
}
