<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="band.aspx.cs" Inherits="band" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1><asp:TextBox ID="bandPageLabel" 
            runat="server" 
            cssClass="customInput title"/></h1>
        <p class="lead">
            <asp:Label id="bandPageSubLabel" runat="server" />
            <asp:GridView ID="memberGrid" 
                runat="server" 
                cssClass="customTable" 
                AutoGenerateColumns="false"
                onRowCommand="bandsTable_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:TextBox id="name" runat="server" 
                                Text='<%# Bind("name") %>'
                                cssClass="customInput"
                                readOnly="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Instrument">
                        <ItemTemplate>
                            <asp:TextBox id="instrument" runat="server" 
                                Text='<%# Bind("instrument") %>'
                                cssClass="customInput"
                                readOnly="false"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Joined">
                        <ItemTemplate>
                            <asp:TextBox id="joined" runat="server" 
                                Text='<%# Bind("Joined") %>'
                                cssClass="customInput"  TextMode="Date"
                                readOnly="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField  
                        ButtonType="Image"
                        HeaderText="Remove" 
                        ImageUrl="~\images\remove.png"
                        CommandName="remove">
                        <ControlStyle CssClass="removeButton" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            <asp:Button runat="server" ID="add" Text="Add member" 
                CssClass="memberAdd" OnClick="add_Click" 
                visible="false"/>
            <asp:Button runat="server" ID="submit" Text="Save" 
                CssClass="bandSubmit" OnClick="submit_Click" />
        </p>
        <script>
            jQuery(document).ready( function(){
                jQuery(".customInput").change(function () {
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
            <asp:ButtonField ButtonType="Button" CommandName="bandRemove" Text="Remove" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="addBand" 
        Text="Add Band" 
        OnClick="addBand_Click" 
        runat="server"
        cssClass="addBand"/>
</asp:Content>

