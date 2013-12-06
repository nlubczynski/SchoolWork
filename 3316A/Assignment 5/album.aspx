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
            <asp:DropDownList ID="bandDropDown" runat="server" 
                onSelectedINdexChanged="bandDropDown_SelectedIndexChanged"
                autoPostBack="true"/>
            <asp:DropDownList ID="albumDropDown" runat="server" />
            <asp:Button ID="selectAlbum" Text="Go" runat="server" 
                onClick="selectAlbum_Click"
                validateRequest="false"/>
            <asp:Button ID="deleteAlbum" Text="Delete Album" runat="server" 
                onClick="deleteAlbum_Click"
                validateRequest="false"/>
        <asp:GridView runat="server" ID="songGridView"
            autoGenerateColumns="false"
            cssClass="customTable"
            onRowCommand="songGridView_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Song Name">
                    <ItemTemplate>
                        <asp:TextBox ID="songName" runat="server"
                            Text='<%# Bind("name") %>'
                            cssClass="customInput"
                            readonly="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Song Length">
                    <ItemTemplate>
                        <asp:TextBox ID="songLength" runat="server"
                            Text='<%# Bind("length") %>'
                            cssClass="customInput"
                            readonly="false"
                            TextMod="Length" />
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
            <asp:Button runat="server" ID="add" Text="Add song" 
                CssClass="memberAdd"
                visible="false"
                onClick="add_Click"/>
            <br />
            <br />
            <asp:Label id="reviewLabel" text="Reviews" runat="server" visible="false"/>
            <asp:GridView runat="server" ID="reviewsGridView"
                autoGenerateColumns="false"
                cssClass="customTable"
                onRowCommand="reviewsGridView_RowCommand"
                onRowDataBound="reviewsGridView_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Reviewer name">
                    <ItemTemplate>
                        <asp:DropDownList ID="reviewerDropDown" runat="server" 
                            autoPostBack="false"
                            DataTextField="name"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Review">
                    <ItemTemplate>
                        <asp:TextBox ID="songLength" runat="server"
                            Text='<%# Bind("review") %>'
                            cssClass="customInput"
                            readonly="false"
                            TextMod="Length" />
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
            <asp:Button runat="server" ID="addReview" Text="Add Review" 
                CssClass="memberAdd"
                visible="false"
                onClick="addReview_Click"/>
        <asp:Button runat="server" ID="submit" Text="Save" 
                CssClass="bandSubmit"
                onClick="submit_Click"  />
        <script>
            jQuery(document).ready(function () {
                jQuery(".customInput").change(function () {
                    jQuery("#MainContent_submit").show();
                });
            });
        </script>
        </p>
        </div>
</asp:Content>



