﻿<%@ Page Title="Your All Auctions" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="indvidualauction.aspx.cs" Inherits="PhotoAuction.indvidualauction" %>

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
               <p style="text-align:center; color:darkorchid;font-size:18px;">Your All Auctions</p>
           </div><hr>
            <!--Showing auction data from db-->
                    <table class="table table-hover">
                        <tr>
                            <th style="width:10%">SL</th>
                            <th  style="width:20%">Title</th>
                            <th  style="width:20%">Bid Limit</th>
                            <th  style="width:25%">photo</th>
                            <th  style="width:25%">Action</th>
                        </tr>
               </table>
                   <asp:DataList ID="indilist" class="table table-hover" runat="server">
                       <ItemTemplate>
                                <%# Container.ItemIndex + 1   %>
                                <td style="width:20%"><%#Eval("itemName") %></td>
                                <td style="width:20%">$ <%#Eval("initPrice") %></td>
                                <td style="width:25%"><img style="height:90px;width:150px;" src="upload/<%#Eval("photo") %>" class="img-rounded" /></td>
                                
                          <td style="width:25%"><a href="deldata.aspx?itemid=<%# Eval("id") %>"  class="btn btn-danger" onclick="return confirm('Are you sure to delete?');">Remove</a> | <a href="artistsinglebid.aspx?itemid=<%# Eval("id") %>&artistid=<%# Eval("artistid") %>"  class="btn btn-info">View</a></td>
                          
                  </ItemTemplate>

              </asp:DataList>
        </div>
</asp:Content>
