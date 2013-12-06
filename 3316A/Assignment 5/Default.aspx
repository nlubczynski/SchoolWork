<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Band Viewer</h1>
        <p class="lead">A website for viewing your favourite band's information</p>
        <p>
            <asp:DropDownList ID="bandDropDown" 
                runat="server"/>
            <asp:DropDownList ID="albumDropDown" 
                runat="server"
                onSelectedIndexChanged="albumDropDown_SelectedIndexChanged"
                autoPostback="true" />
            <asp:DropDownList ID="memberDropDown" 
                runat="server"
                onSelectedIndexChanged="memberDropDown_SelectedIndexChanged"
                autoPostback="true" />
            <asp:LinkButton CssClass="btn btn-primary btn-large" 
                runat ="server" Text="View Band &raquo;"
                id="beging"
                onclick="begin_Click"/>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Select a Band</h2>
            <p>
                See all the bands currently stored in the database, as well as a quick view of their members. From old to new, we have it all!
            </p>
            <p>
                <a class="btn btn-default" href="band.aspx">See band &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Select a Reviewer</h2>
            <p>
                We accept nothing but the best of the best, and therefore, see what our critics are saying about our fantasic array of music!
            </p>
            <p>
                <a class="btn btn-default" href="reviewers.aspx">Choose reviewer &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Select an Album</h2>
            <p>
                For those who know what they want to find, and where to find it, can search our cataglouges by album.
            </p>
            <p>
                <a class="btn btn-default" href="album.aspx">Browse albums &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
