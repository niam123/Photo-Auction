<%@ Page Title="Edit Account details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editdata.aspx.cs" Inherits="PhotoAuction.editdata" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
       <div class="container">   

           <h1><%: Title %></h1><hr>
           <asp:Button ID="back" class="btn btn-success" runat="server" OnClick="backEvent" Text="Back To Admin Panel" />   
           <hr>
                <asp:Label ID="errmsg" class="alert alert-success" runat="server"></asp:Label>
           <hr>

                     <div class="form-group">
                        <label class="control-label col-md-4">Username:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="TextBoxUser" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div>   
             
                    <div class="form-group">
                        <label class="control-label col-md-4">Name:  </label>
                        <div class="col-md-8">
                             <asp:TextBox ID="TextBoxName" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 

                    <div class="form-group">
                        <label class="control-label col-md-4">Password:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="TextBoxPass" class="form-control" runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 

                    <div class="form-group">
                        <label class="control-label col-md-4">Address:  </label>
                        <div class="col-md-8">
                            <asp:TextBox ID="TextBoxAddr" class="form-control"  runat="server" ></asp:TextBox><br>
                        </div>
                     </div> 
                    <div class="form-group">
                        <div class="col-md-8">
                           <asp:Button ID="Button1" runat="server" class="btn btn-primary " Text="UPDATE" OnClick="update_event" />
                        </div>
                     </div> 
               
      </div>
</asp:Content>
