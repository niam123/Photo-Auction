<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhotoAuction._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Container landing">
     
        <div class="row">
            <div class="col-md-6">
                <h2>Photo Auction Management</h2>
                <p class="lead">A place for buyers and sellers to come together and trade Photos</p>
              <img src="img/gallery.jpg" class="img-rounded galleryimg" alt="gallery" />
            </div>

            <div class="col-md-6">
                <div class="card card-container">
            <img id="profile-img" class="profile-img-card" src="img/admin.png" />
            <p id="profile-name" class="profile-name-card"></p>
            <!--Start form-->
                <span id="reauth-email" class="reauth-email"></span>
                <asp:DropDownList ID="selectmode" class="selectpicker form-control" runat="server">
                                  <asp:ListItem Value="artist">Artist</asp:ListItem>
                                  <asp:ListItem Value="buyer">Buyer</asp:ListItem>
                                  <asp:ListItem Value="admin">Admin</asp:ListItem>
                              </asp:DropDownList><br>
               <asp:TextBox ID="TextBoxUser" class="form-control" placeholder="Username" runat="server"></asp:TextBox><br>
               <asp:TextBox ID="TextBoxPass" class="form-control"  TextMode="Password" placeholder="Password" runat="server" ></asp:TextBox><br>
             <!--<input type="text" id="inputEmail" class="form-control" placeholder="Username" required autofocus><br>
                <input type="password" id="inputPassword" class="form-control" placeholder="Password" required><br>
                <button type="submit">Sign in</button> 
                 -->
             <asp:Button ID="adminlogin"  class="btn btn-lg btn-primary btn-block btn-signin" runat="server" OnClick="adminLogin_event" Text="Sign in" /><br>
            <a href="registrationpage.aspx">Create a new account</a><br>
            <asp:Label ID="errmsg" runat="server"></asp:Label>
            <!-- /form -->
          </div><!-- /card-container -->
                
            </div>
        </div>

    </div>
  
    <div class="container">
      
    </div><!-- /container -->

</asp:Content>
