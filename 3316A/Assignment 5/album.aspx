<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="album.aspx.cs" Inherits="album" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1><asp:TextBox ID="albumPageLabel" 
            runat="server" 
            cssClass="customInput title"/></h1>
        <p class="lead">
            <asp:Label id="albumPageSubLabel" runat="server" />
        </p>
        <p>
            <asp:DropDownList ID="bandDropDown" runat="server" />
            <asp:DropDownList ID="AlbumDropDown" runat="server" />
        </p>
    </div>
</asp:Content>



