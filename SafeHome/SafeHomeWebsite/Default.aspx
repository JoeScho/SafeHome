<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SafeHomeWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>SafeHome</h1>
        <p class="lead">We keep the baddies out. And we let you know if your house has turned to ashes.</p>
    </div>

    <div class="form-centered">
        <asp:TextBox ID="txtUserName" placeholder="Enter your username" class="input-xlarge logintxt" runat="server"></asp:TextBox>
        <br /><br />
        <asp:TextBox ID="txtPwd" type="password" placeholder="Enter your password" class="input-xlarge logintxt" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnLogin" class="btn btn-success btnwidth" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <br />
        <asp:Label ID="lblLogin" runat="server"></asp:Label>
    </div>

</asp:Content>
