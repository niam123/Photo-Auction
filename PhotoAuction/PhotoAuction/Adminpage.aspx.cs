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
    public partial class Adminpage : System.Web.UI.Page
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
                // all statements
                //get all auctions info
                string aucSql = "select tbl_item.*, tbl_artist.username from tbl_item inner join tbl_artist on tbl_item.artistid = tbl_artist.id order by id desc";
                MySqlCommand aucmd = new MySqlCommand(aucSql, conn);
                aucmd.ExecuteNonQuery();
                DataTable audt = new DataTable();
                MySqlDataAdapter auda = new MySqlDataAdapter(aucmd);
                auda.Fill(audt);
                auctionlist.DataSource = audt;
                auctionlist.DataBind();

                //get all buyer info
                string query = "SELECT * FROM tbl_buyer";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                buyerlist.DataSource = dt;
                buyerlist.DataBind();

                //get all artist info
                string artisSql = "SELECT * FROM tbl_artist";
                MySqlCommand acmd = new MySqlCommand(artisSql, conn);
                acmd.ExecuteNonQuery();
                DataTable adt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(acmd);
                ada.Fill(adt);
                artistlist.DataSource = adt;
                artistlist.DataBind();
            }
        }

       
    }
}