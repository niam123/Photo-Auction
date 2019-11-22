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
    public partial class buyer : Page
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
                //get all Buyer info
                string buyerSql = "SELECT * FROM tbl_buyer WHERE username='" + Session["user"].ToString() + "'";
                MySqlCommand acmd = new MySqlCommand(buyerSql, conn);
                acmd.ExecuteNonQuery();
                DataTable adt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(acmd);
                ada.Fill(adt);
                buyerlist.DataSource = adt;
                buyerlist.DataBind();
            }
        }
    }
}