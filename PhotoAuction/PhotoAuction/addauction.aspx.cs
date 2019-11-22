﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
namespace PhotoAuction
{
    public partial class addauction : Page
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

        }
        protected void submit_auction(object sender, EventArgs e)
        {
            string artisSql = "SELECT * FROM tbl_artist WHERE username='" + Session["user"].ToString() + "'";
            MySqlCommand acmd = new MySqlCommand(artisSql, conn);
            acmd.ExecuteNonQuery();
            DataTable adt = new DataTable();
            MySqlDataAdapter ada = new MySqlDataAdapter(acmd);
            ada.Fill(adt);
            int aid = adt.Rows[0].Field<int>("id");

            if (imgupload.HasFile)
            {
                //modify image name
                string filename = imgupload.FileName.ToString();
                string[] exts = filename.Split('.');
                //Int16 n = Convert.ToInt16(exts);
                string fname = exts[0].ToString()+ DateTime.Now.ToString("yyyyMMddHHmmss");
                string ext = exts[1].ToString();
                string strname = fname +"." + ext;
        //upload auction sql
                imgupload.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);
            string sql = "insert into tbl_item(artistid,itemName,photo,initPrice) values('"+aid+"','"+title.Text+"','"+strname+"','"+bidlimit.Text+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                msg.Visible = true;
                msg.Text = "Auction Uploaded successfully";
            }
            else
            {
                msg.Visible = true;
                msg.Text = "Plz upload the image!!!!";
            }
        }
    }
}