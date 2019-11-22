<%@ Page Title="Artist" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="artist.aspx.cs" Inherits="PhotoAuction.artist" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

       <div class="container">  
               <div class="row">
			    <h2 style="text-align:center">Artist Option</h2>
		    </div>
		    <hr>
		    <div class="row">
			    <div class="col-md-4"><a href="addauction.aspx" class="btn btn-primary btn-lg circle"><span class="glyphicon glyphicon-plus-sign"></span> Upload Photo</a></div>
			
			    <div class="col-md-4"><a href="indvidualauction.aspx" class="btn btn-primary btn-lg circle"><span class="glyphicon glyphicon-plus-sign"></span> Your Auctions</a></div>
			
			    <div class="col-md-4"><a href="logout.aspx" class="btn btn-primary btn-lg circle"><span class="glyphicon glyphicon-plus-sign"></span> Logout</a></div>
		    </div>
           <hr>
           <!--Profile-->
           <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad" >
                 
              <asp:DataList ID="artistlist" runat="server">    
                <ItemTemplate>
                  <div class="panel panel-info">
                    <div class="panel-heading">
                      <h3 class="panel-title"><%#Eval("name") %></h3>
                    </div>
                    <div class="panel-body">
                      <div class="row">
                        <div class="col-md-3 col-lg-3 "> <img src="img/user.jpg" class="img-circle img-responsive"> </div>

                        <div class=" col-md-9 col-lg-9 "> 
                          <table class="table table-user-information">
                            <tbody>
                              <tr>
                                <td>Username:</td>
                                <td><%#Eval("username") %></td>
                              </tr>
                              <tr>
                                <td>Profession:</td>
                                <td><%#Eval("profession") %></td>
                              </tr>
                              <tr>
                                <td>Email:</td>
                                <td><%#Eval("email") %></td>
                              </tr>
                   
                               <tr>
                                <td>Address</td>
                                <td><%#Eval("address") %></td>
                               </tr>

                            </tbody>
                          </table>
                 
                        </div>
                      </div>
                    </div>
		         </div>
                </ItemTemplate>
              </asp:DataList>
                    <a href="updateprofile.aspx" class="btn btn-info">Edit Your Profile</a>
	         </div>
	        </div>
      </div>



</asp:Content>
