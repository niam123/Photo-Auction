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
    public partial class singlebid : Page
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
               
                if (Request.QueryString["itemid"] != null)
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    int id = Convert.ToInt32(Request.QueryString["itemid"].ToString());
                    //set the item id
                    itemidset.Text = id.ToString();

                    string query = "SELECT * FROM tbl_item where id='"+id+"'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    
                    itemlist.DataSource = dt;
                    itemlist.DataBind();
                   
                    //set bid history in datalist
                    string cksql = "SELECT tbl_bid.*, tbl_buyer.username FROM tbl_bid INNER JOIN tbl_buyer ON tbl_bid.buyerid = tbl_buyer.id WHERE tbl_bid.itemid ='" + id + "'ORDER BY tbl_bid.bidPrice DESC";
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
        
        //place your bid event
        protected void placebid_event(object sender, EventArgs e)
        {
            int prevprice = 0;
            int itemid = Convert.ToInt32(itemidset.Text);
            int buyerid = Convert.ToInt32(Session["byid"].ToString());
            string price = bidprice.Text;
            //check codition whethere your entered price it greater than the previous price

            string cksql = "SELECT bidPrice FROM tbl_bid WHERE itemid='" + itemid + "' ORDER BY bidPrice DESC LIMIT 1";
            MySqlCommand ckcmd = new MySqlCommand(cksql, conn);
            ckcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(ckcmd);
            da.Fill(dt);
            ///check database table row
            if (dt.Rows.Count > 0)
            {
                prevprice = dt.Rows[0].Field<int>("bidPrice");
                if (prevprice >= Convert.ToInt32(price))
                {
                    bidmsg.Text = "You have to bid more than: $ " + prevprice;
                    bidmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    //insert bid into tbl_bid
                    string query = "insert into tbl_bid(itemid,buyerid,bidPrice) values('" + itemid + "','" + buyerid + "','" + price + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    //after inerting the bid i have to update on tbl_item (initPrice)
                    string updateslq = "UPDATE tbl_item SET initPrice='" + price + "' WHERE id='" + itemid + "'";
                    MySqlCommand updatecmd = new MySqlCommand(updateslq, conn);
                    updatecmd.ExecuteNonQuery();

                    //then show the success message
                    bidmsg.Text = "You Successfully bid this Item";
                    bidmsg.ForeColor = System.Drawing.Color.Green;
                    //al last close the connection
                    conn.Close();
                }

                //end if of row check
            }
            else
            {
                //ck condition 

                string asql = "SELECT initPrice FROM tbl_item WHERE id='" + itemid + "' ";
                MySqlCommand acmd = new MySqlCommand(asql, conn);
                acmd.ExecuteNonQuery();
                DataTable ndt = new DataTable();
                MySqlDataAdapter nda = new MySqlDataAdapter(acmd);
                nda.Fill(ndt);
             
                int initprice = ndt.Rows[0].Field<int>("initPrice");

                if(initprice >= Convert.ToInt32(price))
                {
                        bidmsg.Text = "You have to bid more than: $ " + initprice;
                        bidmsg.ForeColor = System.Drawing.Color.Red;
                  
                }

                else{
                    //insert bid into tbl_bid
                    string query = "insert into tbl_bid(itemid,buyerid,bidPrice) values('" + itemid + "','" + buyerid + "','" + price + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    //after inerting the bid i have to update on tbl_item (initPrice)
                    string updateslq = "UPDATE tbl_item SET initPrice='" + price + "' WHERE id='" + itemid + "'";
                    MySqlCommand updatecmd = new MySqlCommand(updateslq, conn);
                    updatecmd.ExecuteNonQuery();

                    //then show the success message
                    bidmsg.Text = "You Successfully bid this Item";
                    bidmsg.ForeColor = System.Drawing.Color.Green;
                    //al last close the connection
                    conn.Close();
                }

                
            }

        }
        
    }
}