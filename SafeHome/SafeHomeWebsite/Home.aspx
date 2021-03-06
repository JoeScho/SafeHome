﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SafeHomeWebsite.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>SafeHome</h1>
        <asp:Label ID="lblWelcome" runat="server" Text="Welcome"></asp:Label>
    </div>
    <div class="form-centered">
        <h2>System Status: <asp:Label ID="lblSystemStatus" class="strong" runat="server" Text=""></asp:Label></h2>
        <br />
        <asp:Button ID="btnDisarm" runat="server" CssClass="btn btn-danger btnwidth" Text="Disarm System" OnClick="btnDisarm_Click" />
        &nbsp;
        <asp:Button ID="btnArm" runat="server" CssClass="btn btn-success btnwidth" Text="Arm System" OnClick="btnArm_Click" />
        &nbsp;
        <asp:Button ID="btnReset" runat="server" CssClass="btn btn-warning btnwidth" Text="Reset System" OnClick="btnReset_Click" />
        <br />
        <br />
        <div class="tbl-centered">
            <asp:GridView ID="gvEvents" class="tbl-centered" runat="server">
            </asp:GridView> 
        </div>            
        <asp:Label ID="lblNoEvents" class="strong" runat="server" Text=""></asp:Label>        
        <br />
        <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-info btnwidth" Text="Logout" OnClick="btnLogout_Click" />
    </div>
</asp:Content>
