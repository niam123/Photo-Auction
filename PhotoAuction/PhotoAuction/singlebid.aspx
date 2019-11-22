<%@ Page Title="Single Bid Item" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="singlebid.aspx.cs" Inherits="PhotoAuction.singlebid" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="container">     
       <div class="row" style="margin-top:10px;">
               <div class="col-md-10">
               <a href="auctionitem.aspx" class="btn btn-primary" >Back to Auction List</a>   
                </div>
               <div class="col-md-2">
                    <a href="logout.aspx" class="btn btn-primary"><span class="glyphicon glyphicon-user"></span> Logout</a>
               </div>
           </div><hr>
    <div class="row">
        <div class="col-md-6">
              <asp:Label ID="bidmsg"  style="font-size:18px;" class="label" runat="server" ></asp:Label>
        </div>
        <div class="col-md-6"><h4>Auction Details</h4></div>
    </div>
		<hr />
		<div class="row">
      <asp:DataList ID="itemlist" runat="server">
            <ItemTemplate>
			    <div class="col-md-4">
				    <h3><%#Eval("itemName")%></h3><hr>
				    <span class="label label-warning">120 minute left</span><hr />
                    <p>Bid Description Content will be go here. Bid Description Content will be go here. Bid Description Content will be go here. Bid Description Content will be go here. Bid Description Content will be go here. Bid Description Content will be go here. Bid Description Content will be go here</p>
				    <hr><h4 style="color:blueviolet">Bid limit: $ <%#Eval("initPrice")%></h4>
			    </div>
			    <div class="col-md-8">
				    <img src='upload/<%#Eval("photo")%>' style="height:360px;width:700px;"class="img-rounded"/>
			    </div>
          </ItemTemplate>
    </asp:DataList>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="itemidset" style="display:none" runat="server"></asp:Label>
            <hr> <asp:TextBox ID="bidprice" class="form-control" placeholder="Enter bid amount" required="1" runat="server"></asp:TextBox><hr>
              
              <asp:Button ID="bidbtn" class="btn btn-primary" OnClick="placebid_event" runat="server" Text="Place Your Bid" />
        </div>
        </div>
		</div><hr />
		<div class="row">
			<div class="col-md-8">
				<h3>Bid History <asp:Label ID="histolb" class="label label-default" runat="server"></asp:Label></h3>
                    <hr />
				<div class="table-responsive">
				<table  class="table table-hover table-alt table-striped">
				<thead>
					<tr>
					<th style="width:10%">SL</th>
					<th style="width:15%">Bidder</th>
					<th style="width:14%">Amount</th>
					<th style="width:30%;text-align:center">Time</th>
					</tr>
				</thead>
				<tbody>
                    <asp:DataList ID="historylist"  style="text-align:center" class="table table-hover table-alt table-striped" runat="server">
                        <ItemTemplate>
                            <%# Container.ItemIndex + 1   %>
						    <td><%# Eval("username") %></td>
						    <td>$ <%# Eval("bidPrice") %></td>
						    <td>
						    155 Days ago
						    </td>
					    
                        </ItemTemplate>
                    </asp:DataList>
					
				</table>
				
			</div>
		</div> 

	</div>    
</div>
</asp:Content>
