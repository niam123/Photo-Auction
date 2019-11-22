using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
namespace PhotoAuction
{
    public partial class registrationpage : Page
    {
        string connStr = "server=localhost;user=root;database=db_photo_auction;password=''";
        MySqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                errmsg.Text = "Database Connection Failed";
                errmsg.ForeColor = System.Drawing.Color.Red;
            }

        }
         //register user
        protected void registration_event(object sender, EventArgs e)
        {
            string value = usertype.SelectedValue;
            if (value.Equals("artist"))
            {
                string query = "SELECT * FROM tbl_artist WHERE username='" + uname.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    errmsg.Text = "This username already registered !";
                    errmsg.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    string regSql = "insert into tbl_artist(name,username,password,profession,email,address) values('" + name.Text + "','" + uname.Text + "','" + pass.Text + "','" + prof.Text + "','" + email.Text + "','" + addr.Text + "')";
                    
                    MySqlCommand insertcmd = new MySqlCommand(regSql, conn);
                    insertcmd.ExecuteNonQuery();

                    errmsg.Text = "Registration successful! <a href='Default.aspx'>Signin</a>";
                    errmsg.ForeColor = System.Drawing.Color.Green;
                }
            }

            //registration for buyer
            else if (value.Equals("buyer"))
            {
                string query = "SELECT * FROM tbl_buyer WHERE username='" + uname.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    errmsg.Text = "This username already registered !";
                    errmsg.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    string regSql = "insert into tbl_buyer(name,username,password,profession,email,address) values('" + name.Text + "','" + uname.Text + "','" + pass.Text + "','" + prof.Text + "','" + email.Text + "','" + addr.Text + "')";

                    MySqlCommand insertcmd = new MySqlCommand(regSql, conn);
                    insertcmd.ExecuteNonQuery();

                    errmsg.Text = "Registration successful! <a href='Default.aspx'>Signin</a>";
                    errmsg.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

}
   
}