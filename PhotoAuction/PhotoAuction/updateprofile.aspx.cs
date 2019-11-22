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
    public partial class updateprofile : System.Web.UI.Page
    {
        string connStr = "server=localhost;user=root;database=db_photo_auction;password=''";
        MySqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["loggedin"] != "login")
            {
                Response.Redirect("Default.aspx");
            }
            conn = new MySqlConnection(connStr);
            conn.Open();

            if (!IsPostBack)
            {
                Bind();
            }
          

        }
        
        public void Bind()
        {
            string query = "SELECT * FROM tbl_artist WHERE username='" + Session["user"].ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            name.Text = dt.Rows[0].Field<string>("name");
            profession.Text = dt.Rows[0].Field<string>("profession");
            email.Text = dt.Rows[0].Field<string>("email");
            address.Text = dt.Rows[0].Field<string>("address");
        }
        //updatedata
        protected void update_event(object sender, EventArgs e)
        {
            string na = name.Text;
            string prof = profession.Text;
            string em = email.Text;
            string addr = address.Text;
            string query = "UPDATE tbl_artist SET name='" + na + "',profession='" + prof + "', email='" + em + "',address='" + addr + "' WHERE username='" + Session["user"].ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            errmsg.Text = "Profile Updated Successfully.";
            Bind();
            //Response.Write(TextBoxUser.Text + n);
            //  Response.Redirect("Adminpage.aspx");
        }



    }
}