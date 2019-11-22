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
    public partial class artist : Page
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
                //get all artist info
                string artisSql = "SELECT * FROM tbl_artist WHERE username='"+Session["user"].ToString()+"'";
                MySqlCommand acmd = new MySqlCommand(artisSql, conn);
                acmd.ExecuteNonQuery();
                DataTable adt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(acmd);
                ada.Fill(adt);
                artistlist.DataSource = adt;
                artistlist.DataBind();
            }
        }
     

      



        //end of class
    }
}