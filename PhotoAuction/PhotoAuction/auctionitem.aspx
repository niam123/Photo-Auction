<%@ Page Title="Auction Item List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="auctionitem.aspx.cs" Inherits="PhotoAuction.auctionitem" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
       <div class="container">     
           <div class="row" style="margin-top:10px;">
               <div class="col-md-10">
               <a href="buyer.aspx" class="btn btn-primary" >Back to Previous</a>   
                </div>
               <div class="col-md-2">
                    <a href="logout.aspx" class="btn btn-primary"><span class="glyphicon glyphicon-user"></span> Logout</a>
               </div>
           </div><hr>
		<div style="text-align:center;background:#0F212F;color:white;font-size:20px;padding:5px">All Auctions</div><hr />
		<div class="row">
    <asp:DataList ID="auctionitemlist" RepeatDirection="Horizontal" RepeatColumns="3" runat="server">
             <ItemTemplate>
			    <div class="col-md-12">
				    <h3><%#Eval("itemName")%></h3>
				    <img src='upload/<%# Eval("photo") %>' style="height:250px;width=340px;" class=img-thumbnail alt="" /><br /><br />
				    <span class="label label-warning">120 minute left</span><br />
				    <h4>Bid limit: $ <%# Eval("initPrice") %></h4>
				    <a href="singlebid.aspx?itemid=<%# Eval("id") %>" class="btn btn-info">View Details</a>
			    </div>
           </ItemTemplate>
    </asp:DataList>
		</div>

        </div>
       
</asp:Content>
