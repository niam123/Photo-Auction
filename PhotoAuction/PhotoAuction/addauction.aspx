<%@ Page Title="Start a new Auction" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addauction.aspx.cs" Inherits="PhotoAuction.addauction" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">     
           <div class="row" style="margin-top:10px;">
               <div class="col-md-10">
               <a href="artist.aspx" class="btn btn-primary" >Back to Previous</a>   
                </div>
               <div class="col-md-2">
                    <a href="logout.aspx" class="btn btn-primary"><span class="glyphicon glyphicon-user"></span> Logout</a>
               </div>
           </div><hr>
		<div class="row">
			<div class="col-xs-8 white-content">
				<h3>Start an Auction</h3>
				<hr/>
				<p>Auction Title</p>
                <asp:TextBox ID="title" class="form-control form-underline" placeholder="Enter Item name" required="1" runat="server"></asp:TextBox>			
				<br/>
				<p>Minimum Bid Limit</p>
                <asp:TextBox ID="bidlimit" class="form-control form-underline" placeholder="Enter Minimum Bid Price" required="1" runat="server"></asp:TextBox>
				<br/>
				<p>Maximum Time Limit</p>
                <asp:TextBox ID="maxtime" class="form-control form-underline" placeholder="Max Time in Minute" required="1" runat="server"></asp:TextBox>
			    <br>
			</div> 
			<div class="col-xs-4">
				<div class="white-content">
					<h3>Photos</h3><hr>
					<span style="font-size:150px;" class="glyphicon glyphicon-picture"></span>
				</div> 
			</div> 
			<div class="col-xs-4">
				<div class="white-content">
					<p>At least 370x370 in size required.</p>
                     <asp:FileUpload ID="imgupload" class="uploadAuctionPhotos form-control multi" runat="server" />
	       	</div> 
			</div> 
			</div><hr/> 
			<div class="row">
	    	<div class="col-xs-4">
            <asp:Button ID="Button1"  class="btn btn-primary btn-lg" OnClick="submit_auction" runat="server" Text="Submit Auction" />
               
			</div> 
				<div class="col-xs-8">
                <asp:Label ID="msg" style="font-size:16px;" class="label label-success label-lg" runat="server"></asp:Label>
					
				</div> 
			</div>
    </div>
</asp:Content>
