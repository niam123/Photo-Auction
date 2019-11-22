<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminpage.aspx.cs" Inherits="PhotoAuction.Adminpage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
       <div class="container">  
           <asp:Label ID="lb" runat="server" ></asp:Label>
           <div class="row">
                <div class="col-md-8">
                     <h1><%: Title %></h1>
                </div>
               <div class="col-md-4">
                  <a style="margin-top:25px; text-align:right" href="logout.aspx" class="btn btn-primary">Logout</a>
               </div>
           </div>
          <hr><hr>

          <!--  pills and tab allmost same-->
           <ul class="nav nav-pills nav-justified">
               <li class="active"><a href="#section1" data-toggle="tab">Auction List</a></li>
               <li><a href="#section2" data-toggle="tab">Buyer List</a></li>
               <li><a href="#section3" data-toggle="tab">Artist List</a></li>
           </ul>
           <div class="tab-content">
               <div class="tab-pane fade in active" id="section1"><hr>
                   <!--Showing auction data from db-->
                    <table class="table table-hover">
                        <tr>
                            <th style="width:5%">SL</th>
                            <th  style="width:15%">Title</th>
                            <th  style="width:20%">Bid Limit</th>
                            <th  style="width:25%">photo</th>
                            <th  style="width:20%">Uploaded BY</th>
                            <th  style="width:25%">Action</th>
                        </tr>
               </table>
                   <asp:DataList ID="auctionlist" class="table table-hover" runat="server">
                       <ItemTemplate>
                                <%# Container.ItemIndex + 1   %>
                                <td style="width:15%"><%#Eval("itemName") %></td>
                                <td style="width:20%">$ <%#Eval("initPrice") %></td>
                                <td style="width:25%"><img style="height:90px;width:150px;" src="upload/<%#Eval("photo") %>" class="img-rounded" /></td>
                                <td style="width:15%"><%#Eval("username") %></td>
                          <td style="width:20%"><a href="deldata.aspx?auctionid=<%# Eval("id") %>"  class="btn btn-danger" onclick="return confirm('Are you sure to delete?');">Remove</a> | <a href="adminsinglebid.aspx?itemid=<%# Eval("id") %>&artistid=<%# Eval("artistid") %>"  class="btn btn-info">View</a></td>
                          
                    </ItemTemplate>

                   </asp:DataList>
                 
               </div> 
               <div class="tab-pane fade" id="section2"><br>
                   <!--Showing buyer data from db-->
           <table class="table table-hover">
                        <tr>
                            <th style="width:5%">SL</th>
                            <th  style="width:15%">Username</th>
                            <th  style="width:20%">Name</th>
                            <th  style="width:15%">Profession</th>
                            <th  style="width:20%">Email</th>
                            <th  style="width:15%">Address</th>
                            <th  style="width:10%">Action</th>
                        </tr>
               </table>
                   <asp:DataList ID="buyerlist" class="table table-hover" runat="server">
                       <ItemTemplate>
                             <%# Container.ItemIndex + 1   %>
                                <td style="width:15%"><%#Eval("username") %></td>
                                <td style="width:20%"><%#Eval("name") %></td>
                                <td style="width:15%"><%#Eval("profession") %></td>
                                <td style="width:20%"><%#Eval("email") %></td>
                                <td style="width:15%"><%#Eval("address") %></td>
                          <td style="width:10%"><a href="deldata.aspx?buyerid=<%# Eval("id") %>"  class="btn btn-danger" onclick="return confirm('Are you sure to delete?');">Remove</a></td>
                          
                    </ItemTemplate>

                   </asp:DataList>
                </div>
                  <div class="tab-pane fade" id="section3">
                    <!--Showing artist data from db-->
                       <table class="table table-hover">
                        <tr>
                            <th style="width:5%">SL</th>
                            <th  style="width:15%">Username</th>
                            <th  style="width:20%">Name</th>
                            <th  style="width:15%">Profession</th>
                            <th  style="width:20%">Email</th>
                            <th  style="width:15%">Address</th>
                            <th  style="width:10%">Action</th>
                        </tr>
               </table>
                   <asp:DataList ID="artistlist" class="table table-hover" runat="server">
                       <ItemTemplate>
                             <%# Container.ItemIndex + 1   %>
                                <td style="width:15%"><%#Eval("username") %></td>
                                <td style="width:20%"><%#Eval("name") %></td>
                                <td style="width:15%"><%#Eval("profession") %></td>
                                <td style="width:20%"><%#Eval("email") %></td>
                                <td style="width:15%"><%#Eval("address") %></td>
                          <td style="width:10%"><a href="deldata.aspx?artistid=<%# Eval("id") %>"  class="btn btn-danger" onclick="return confirm('Are you sure to delete?');">Remove</a></td>
                          
                    </ItemTemplate>

                   </asp:DataList>
                 </div>
            </div>
        </div>
</asp:Content>