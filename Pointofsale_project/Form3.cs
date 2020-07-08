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
    public partial class Usermenupage : Form
    {
        public Usermenupage()
        {
            InitializeComponent();
            

           
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NIHMH34\\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");   
         DataTable dt = new DataTable();
        
           

      
        private void Usermenupage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.posDataSet.Table_2);
            //this.table_2TableAdapter.Fill();
            dt.Columns.Add("ID",typeof(int));
            dt.Columns.Add("item name", typeof(string));
            dt.Columns.Add("price", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Amount",typeof(int));
            Bill.DataSource = dt;


        }

      
        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Been Logged Out");
            userloginpage up = new userloginpage();
            up.Show();
            this.Hide();
        }

        private void generatebill_Click(object sender, EventArgs e)
        {
            int balance;

            //total = Convert.ToInt32(label7.Text);
            //receive = Convert.ToInt32(received.Text);

            if (string.IsNullOrEmpty(received.Text))
            {
                MessageBox.Show("Please Enter Your Amount First !!");

            }
            else if (Convert.ToInt32(received.Text) < Convert.ToInt32(label7.Text))
            {
                MessageBox.Show("Not Enough Cash !!");

            }
            else if (Bill.Rows.Count == 0)
            {
                MessageBox.Show("Enter Your Menu First !!");
            }
            else
            {
                balance = Convert.ToInt32(received.Text) - Convert.ToInt32(label7.Text);
                string message = "Are you Sure you want to Generate Bill";
                string title = "Generate Bill";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    for (int i = 0; i <= Bill.Rows.Count - 1; i++)
                    {

                        SqlCommand cm = new SqlCommand("Insert into table_3 (ID , [Item Name] , Price , Quantity , Amount) values('" + Convert.ToInt32(Bill.Rows[i].Cells[0].Value) + "' , '" + Bill.Rows[i].Cells[1].Value + "', '" + Convert.ToInt32(Bill.Rows[i].Cells[2].Value) + "'  , '" + Convert.ToInt32(Bill.Rows[i].Cells[3].Value) + "' ,'" + Convert.ToInt32(Bill.Rows[i].Cells[4].Value) + "')", conn);
                        cm.ExecuteNonQuery();
                        SqlCommand cmnd = new SqlCommand("Insert into table_5 (ID , [Item Name] , Price , Quantity , Amount) values('" + Convert.ToInt32(Bill.Rows[i].Cells[0].Value) + "' , '" + Bill.Rows[i].Cells[1].Value + "', '" + Convert.ToInt32(Bill.Rows[i].Cells[2].Value) + "'  , '" + Convert.ToInt32(Bill.Rows[i].Cells[3].Value) + "' ,'" + Convert.ToInt32(Bill.Rows[i].Cells[4].Value) + "')", conn);
                        cmnd.ExecuteNonQuery();


                    }
                    SqlCommand cmd = new SqlCommand("Insert into table_4 ([Total Amount],[Received Amount],Balance) values('" + label7.Text + "', '" + received.Text + "' , '" + balance + "')", conn);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmad = new SqlCommand("Insert into table_6 ([Total Amount],[Received Amount],Balance) values('" + label7.Text + "', '" + received.Text + "' , '" + balance + "')", conn);
                    cmad.ExecuteNonQuery();

                    conn.Close();
                    Billpage fm = new Billpage();
                    fm.Show();
                    this.Hide();

                }
                else
                {
                    this.Show();
                }

            }

        }

        private void removeall_Click(object sender, EventArgs e)
        {
            Usermenupage mp = new Usermenupage();
            mp.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int amount;


            if (string.IsNullOrEmpty(quantity.Text) || Convert.ToInt32(quantity.Text) == 0)
            {

                MessageBox.Show("Quantity must be filled and not equal to zero !!");

            }

            else
            {
                amount = Convert.ToInt32(pricemenu.Text) * Convert.ToInt32(quantity.Text);

                dt.Rows.Add(idmenu.Text, itemmenu.Text, pricemenu.Text, quantity.Text, amount);
                Bill.DataSource = dt;
                quantity.Clear();
                int sum = 0;
                for (int i = 0; i <= Bill.Rows.Count - 1; i++)
                {
                    sum += Convert.ToInt32(Bill.Rows[i].Cells[4].Value);

                }
                label7.Text = sum.ToString();


            }
        }


       
    }
}
