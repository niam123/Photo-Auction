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
    public partial class artistsinglebid : Page
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

                if (Request.QueryString["artistid"] != null && Request.QueryString["itemid"] != null)
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();

                    int atid = Convert.ToInt32(Request.QueryString["artistid"].ToString());
                    int itemid = Convert.ToInt32(Request.QueryString["itemid"].ToString());

                    string query = "SELECT * FROM tbl_item where id='" + itemid + "' and artistid='" + atid + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    singlelist.DataSource = dt;
                    singlelist.DataBind();

                    //set bid history in datalist
                    string cksql = "SELECT tbl_bid.*, tbl_buyer.username FROM tbl_bid INNER JOIN tbl_buyer ON tbl_bid.buyerid = tbl_buyer.id WHERE tbl_bid.itemid ='" + itemid + "'ORDER BY tbl_bid.bidPrice DESC";
                    MySqlCommand ckcmd = new MySqlCommand(cksql, conn);
                    ckcmd.ExecuteNonQuery();
                    DataTable biddt = new DataTable();
                    MySqlDataAdapter bda = new MySqlDataAdapter(ckcmd);
                    bda.Fill(biddt);
                    if (biddt.Rows.Count > 0)
                    {
                        historylist.DataSource = biddt;
                        historylist.DataBind();
                    }
                    else
                    {
                        histolb.Text = "No Bid Available";
                    }
                }


            }
        }
    }
}