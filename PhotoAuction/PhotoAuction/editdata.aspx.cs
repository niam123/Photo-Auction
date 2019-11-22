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
        public partial class editdata : Page
        {
            string connStr = "server=localhost;user=root;database=db_photo_auction;password=''";
                MySqlConnection conn;
                string tbl;
                int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["loggedin"] != "login")
            {
                Response.Redirect("Default.aspx");
            }
            conn = new MySqlConnection(connStr);
                    conn.Open();
                if (Request.QueryString["buyerid"] != null)
                {
                    id = Convert.ToInt32(Request.QueryString["buyerid"].ToString());
                    tbl = Request.QueryString["tbl"].ToString();
    
                    string query = "SELECT * FROM "+tbl+" WHERE id='"+id+"'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                TextBoxUser.Text = dt.Rows[0].Field<string>("username");
                TextBoxName.Text = dt.Rows[0].Field<string>("name");
               
                }
            }

        protected void backEvent(object sender, EventArgs e)
        {
             Response.Redirect("Adminpage.aspx");
        }

        protected void update_event(object sender, EventArgs e)
        {
            string n = TextBoxName.Text;
            string query = "UPDATE " + tbl + " SET name='" + n + "',username='" + TextBoxUser.Text + "', password='" + TextBoxPass.Text + "',address='" + TextBoxAddr.Text + "' WHERE id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
           
            Response.Write(TextBoxUser.Text + n);
          //  Response.Redirect("Adminpage.aspx");
        }

    }
}