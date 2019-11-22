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
    public partial class _Default : Page
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
        protected void adminLogin_event(object sender, EventArgs e)
        {
            if (TextBoxUser.Text == "" || TextBoxPass.Text == "")
            {
                errmsg.Text = "<span style='color:red;font-size:16px'>Field must not be empty</span>";
            }
            else
            {
                string value = selectmode.SelectedValue;
               if(value.Equals("admin"))
                {
                    string query = "SELECT * FROM tbl_admin WHERE username='" + TextBoxUser.Text + "' AND password='" + TextBoxPass.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Session["user"] = TextBoxUser.Text;
                        Session["loggedin"] = "login";
                        Response.Redirect("Adminpage.aspx");
                        
                    }
                    else
                    {
                        errmsg.Text = "Your username or password is incorrect";
                        errmsg.ForeColor = System.Drawing.Color.Red;

                    }
                }else if (value.Equals("buyer"))
                {
                    string query = "SELECT * FROM tbl_buyer WHERE username='" + TextBoxUser.Text + "' AND password='" + TextBoxPass.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        int byid = dt.Rows[0].Field<int>("id");
                        Session["user"] = TextBoxUser.Text;
                        Session["loggedin"] = "login";
                        Session["byid"] = byid.ToString();
                        Response.Redirect("buyer.aspx");
                        //Session.RemoveAll();
                    }
                    else
                    {
                        errmsg.Text = "You're username or password is incorrect";
                        errmsg.ForeColor = System.Drawing.Color.Red;

                    }
                }else
                {
                    string query = "SELECT * FROM tbl_artist WHERE username='" + TextBoxUser.Text + "' AND password='" + TextBoxPass.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        int atid = dt.Rows[0].Field<int>("id");
                        Session["user"] = TextBoxUser.Text;
                        Session["loggedin"] = "login";
                        Session["artistid"] = atid.ToString();
                        Response.Redirect("artist.aspx");
                        //Session.RemoveAll();
                    }
                    else
                    {
                        errmsg.Text = "You're username or password is incorrect";
                        errmsg.ForeColor = System.Drawing.Color.Red;

                    }
                }


            }

        }
    }
}