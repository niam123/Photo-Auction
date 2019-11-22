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
    public partial class indvidualauction : System.Web.UI.Page
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
                //get all auctions info
                string aucSql = "select * from tbl_item where artistid='"+Session["artistid"].ToString()+"'order by id desc";
                MySqlCommand aucmd = new MySqlCommand(aucSql, conn);
                aucmd.ExecuteNonQuery();
                DataTable audt = new DataTable();
                MySqlDataAdapter auda = new MySqlDataAdapter(aucmd);
                auda.Fill(audt);
                indilist.DataSource = audt;
                indilist.DataBind();

            }
        }
    }
}