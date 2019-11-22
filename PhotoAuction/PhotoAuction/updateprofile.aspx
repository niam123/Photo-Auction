<%@ Page Title="Update Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updateprofile.aspx.cs" Inherits="PhotoAuction.updateprofile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
       <div class="container">     
               <h1>Update Your Profile</h1> <a href="artist.aspx" class="btn btn-primary">Back To Profile</a><hr>
          <!--Profile-->
           <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad" >

       
           <hr>
                <asp:Label ID="errmsg" class="alert alert-success" runat="server"></asp:Label>
           <hr>

                     <div class="form-group">
                        <label class="control-label col-md-4">Name:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="name" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div>   
             
                    <div class="form-group">
                        <label class="control-label col-md-4">Profession:  </label>
                        <div class="col-md-8">
                             <asp:TextBox ID="profession" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 

                    <div class="form-group">
                        <label class="control-label col-md-4">Email:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="email" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 

                    <div class="form-group">
                        <label class="control-label col-md-4">Address:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="address" class="form-control"  runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 
                    <div class="form-group">
                        <div class="col-md-8">
                           <asp:Button ID="Button1" runat="server" class="btn btn-primary " Text="UPDATE" OnClick="update_event" />
                        </div>
                     </div>   
     
	         </div>
	        </div>
        </div>
</asp:Content>
