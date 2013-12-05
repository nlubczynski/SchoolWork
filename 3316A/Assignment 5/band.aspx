<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="band.aspx.cs" Inherits="band" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1><asp:Label ID="bandPageLabel" runat="server" /></h1>
        <p class="lead">
            <asp:Label id="bandPageSubLabel" runat="server" />
            <asp:GridView ID="memberGrid" runat="server" cssClass="customTable" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:TextBox id="name" runat="server" 
                                Text='<%# Bind("name") %>'
                                cssClass="customInput" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Instrument">
                        <ItemTemplate>
                            <asp:TextBox id="instrument" runat="server" 
                                Text='<%# Bind("instrument") %>'
                                cssClass="customInput"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Joined">
                        <ItemTemplate>
                            <asp:TextBox id="joined" runat="server" 
                                Text='<%# Bind("Joined") %>'
                                cssClass="customInput"  TextMode="Date" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" ID="submit" Text="Save" CssClass="bandSubmit" OnClick="submit_Click" />
        </p>
        <script>
            jQuery(document).ready( function(){
                jQuery("#MainContent_memberGrid .customInput").click(function () {
                    jQuery("#MainContent_submit").show();
                });
            });
        </script>
    </div>
    <asp:GridView ID="bandsTable" runat="server"
        autoGenerateColumns="false"
        cssClass="customTable"
        onRowCommand="bandsTable_RowCommand">
        <Columns>
            <asp:BoundField headerText="Band Name" DataField="name"/>
            <asp:ButtonField ButtonType="Button" CommandName="bandClick" Text="Select"/>
        </Columns>
    </asp:GridView>
</asp:Content>

