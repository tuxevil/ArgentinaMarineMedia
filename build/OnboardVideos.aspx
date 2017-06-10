<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OnboardVideos.aspx.cs" Inherits="Argentina_MarineMedia.OnboardVideos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <title>Argentina MarineMedia - Onboard Videos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainBody" runat="server">
    <div class="imagesmenu">
        <div class="mainMenuLink">
            <img style="float: left;" src="img/corner.png" />
            <a href="/">MAIN MENU</a>
            <span>ONBOARD VIDEO</span>
        </div>
        <div class="imageless"></div>
        <div class="imageless"></div>
        <a class="imageslink" href="Optimist.aspx"><span>OPTIMIST</span><img src="img/menu4.png" /></a>
        <div class="imageless"></div>
        <div class="imageless"></div>
        <a class="imageslink" href="Keelboats.aspx"><span>KEELBOATS</span><img src="img/menu6.png" /></a>
        <a class="imageslink" href="TeamVodafoneSailing.aspx"><span>TEAM VODAFONE SAILING</span><img src="img/menu8.png" /></a>
        <div class="imageless"></div>
        <a class="imageslink" href="Other.aspx"><span>OTHER</span><img src="img/menu10.png" /></a>
    </div>
    <div class="mainMenu" style="margin-left: 40px;">
        <a href="Optimist.aspx">OPTIMIST</a>
        <a href="TeamVodafoneSailing.aspx">TEAM VODAFONE SAILING</a>
        <a href="Keelboats.aspx">KEELBOATS</a>
        <a href="Other.aspx">OTHER</a>
    </div>
</asp:Content>
