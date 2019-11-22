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
    public partial class deldata : Page
    {
        string connStr = "server=localhost;user=root;database=db_photo_auction;password=''";
        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (Request.QueryString["buyerid"] != null)
            {
            conn = new MySqlConnection(connStr);
            conn.Open();
            int id = Convert.ToInt32(Request.QueryString["buyerid"].ToString());
            string del = "DELETE FROM tbl_buyer WHERE id='" + id + "'";
               MySqlCommand cmd = new MySqlCommand(del, conn);
               cmd.ExecuteNonQuery();
               Response.Redirect("Adminpage");
            }
            else if (Request.QueryString["artistid"] != null)
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                int id = Convert.ToInt32(Request.QueryString["artistid"].ToString());
                string del = "DELETE FROM tbl_artist WHERE id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(del, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect("Adminpage");
            }
            else if (Request.QueryString["auctionid"] != null)
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                int id = Convert.ToInt32(Request.QueryString["auctionid"].ToString());
                string del = "DELETE FROM tbl_item WHERE id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(del, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect("Adminpage.aspx");
            }
            else if (Request.QueryString["itemid"] != null)
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                int id = Convert.ToInt32(Request.QueryString["itemid"].ToString());
                string del = "DELETE FROM tbl_item WHERE id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(del, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect("indvidualauction.aspx");
            }


        }
    }
}