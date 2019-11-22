<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registrationpage.aspx.cs" Inherits="PhotoAuction.registrationpage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
       <div class="container">     
          <hr>
               <a href="Default.aspx" class="btn btn-primary">Back to Home</a><hr>
                <asp:Label ID="errmsg" class="alert alert-success" runat="server"></asp:Label>
           <hr>

                     <div class="form-group">
                        <label class="control-label col-md-4">Name:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="name" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div>   
             
                    <div class="form-group">
                        <label class="control-label col-md-4">Username:  </label>
                        <div class="col-md-8">
                             <asp:TextBox ID="uname" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 

                    <div class="form-group">
                        <label class="control-label col-md-4">Password:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="pass" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 

                    <div class="form-group">
                        <label class="control-label col-md-4">Profession:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="prof" class="form-control"  runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 
                      <div class="form-group">
                        <label class="control-label col-md-4">Email:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="email" class="form-control"  runat="server" ></asp:TextBox><br>
                        </div>
                     </div>
                       <div class="form-group">
                        <label class="control-label col-md-4">Address:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="addr" class="form-control"  runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 
                        <div class="form-group">
                        <label class="control-label col-md-4">User Type:  </label>
                        <div class="col-md-8">
                            <asp:DropDownList ID="usertype" class="selectpicker form-control" runat="server">
                                  <asp:ListItem Value="artist">Artist</asp:ListItem>
                                  <asp:ListItem Value="buyer">Buyer</asp:ListItem>
                              </asp:DropDownList><br>
                        </div>
                     </div> 
                    <div class="form-group">
                        <div class="col-md-8">
                           <asp:Button ID="Button1" runat="server" class="btn btn-primary " Text="Create an Account" OnClick="registration_event" />
                        </div>
                     </div> 
               
        </div>
</asp:Content>
