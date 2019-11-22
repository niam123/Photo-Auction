<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="PhotoAuction.AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="card card-container">
            <img id="profile-img" class="profile-img-card" src="img/admin.png" />
            <p id="profile-name" class="profile-name-card"></p>
            <!--Start form-->
                <span id="reauth-email" class="reauth-email"></span>
               <asp:TextBox ID="TextBoxUser" class="form-control" placeholder="Username" runat="server" required=1></asp:TextBox><br>
               <asp:TextBox ID="TextBoxPass" class="form-control" placeholder="Password" runat="server" ></asp:TextBox><br>
             <!--<input type="text" id="inputEmail" class="form-control" placeholder="Username" required autofocus><br>
                <input type="password" id="inputPassword" class="form-control" placeholder="Password" required><br>
                <button type="submit">Sign in</button> 
                 -->
             <asp:Button ID="adminlogin"  class="btn btn-lg btn-primary btn-block btn-signin" runat="server" OnClick="adminLogin_event" Text="Sign in" /><br>

            <asp:Label ID="errmsg" runat="server"></asp:Label>
            <!-- /form -->
        </div><!-- /card-container -->
    </div><!-- /container -->

</asp:Content>
