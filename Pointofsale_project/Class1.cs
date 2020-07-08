using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Pointofsale_project
{
    class check
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NIHMH34\\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");
        
        public bool login(string name,string pass)
        {
            string loginvalue = " select username , password from login where username='" + name + "'and password= '" + pass + "' "; ;
            SqlCommand com = new SqlCommand(loginvalue, conn);
            SqlDataReader rdr;
            conn.Open();
           rdr = com.ExecuteReader();

            return rdr.Read();
        }
        public void signup(string name1 ,string pass1)
        {
            
            
            if (name1 != "" && pass1 != "" && name1!=pass1)
            {
              
                string signvalue = "Insert into login(username,password) values('" + name1 + "' , '" + pass1 + "') "; ;
                SqlCommand cmd = new SqlCommand(signvalue, conn);
                SqlDataReader rdr;
                conn.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
            }
        }
        public void insert(string item , int price)
        {
            if (item != "" && price != 0)
            {
                string insert = "Insert into item([item name] , Price) values('" + item + "','" + price + "')"; ;
                SqlCommand cmad = new SqlCommand(insert, conn);
                conn.Open();
                cmad.ExecuteNonQuery();
                conn.Close();
            }
        
        }
        public void update(int id2,string item2, int price2)
        {
            if (item2 != "" && price2 != 0 && id2 !=0)
            {
                string update = "Update item set [item name]= '" + item2 + "' , Price='" + price2 + "' where ID='" + id2 + "'"; ;
                SqlCommand cmad = new SqlCommand(update, conn);
                conn.Open();
                cmad.ExecuteNonQuery();
                conn.Close();
            }
        
        
        }
        public void delete(int id3)
        {
            if (id3!=0)
            {
                string delete = "delete from item where ID= '"+id3+"'"; ;
                SqlCommand cmad = new SqlCommand(delete, conn);
                conn.Open();
                cmad.ExecuteNonQuery();
                conn.Close();

            }
        }
       



     }
}
