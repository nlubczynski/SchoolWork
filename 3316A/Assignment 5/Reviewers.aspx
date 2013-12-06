<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reviewers.aspx.cs" Inherits="Reviewers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1><asp:Label ID="reviewerPageLabel" 
            runat="server" 
            cssClass="customInput title"
            text="Reviewers"/></h1>
        <p class="lead">
            <asp:Label id="reviewerPageSubLabel" runat="server" 
                text="Edit reviewers."/>
        </p>
        <p>
            <asp:GridView ID="reviewerGrid" 
                runat="server" 
                cssClass="customTable" 
                AutoGenerateColumns="false"
                onRowCommand="reviewerGrid_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:TextBox id="name" runat="server" 
                                Text='<%# Bind("name") %>'
                                cssClass="customInput"
                                readOnly="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:TextBox id="instrument" runat="server" 
                                Text='<%# Bind("id") %>'
                                cssClass="customInput"
                                readOnly="false"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Company">
                        <ItemTemplate>
                            <asp:TextBox id="joined" runat="server" 
                                Text='<%# Bind("Company") %>'
                                cssClass="customInput"
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
            <asp:Button runat="server" ID="add" Text="Add reviewer" 
                CssClass="memberAdd" OnClick="add_Click"
                visible="false"/>
            <asp:Button runat="server" ID="submit" Text="Save" 
                CssClass="bandSubmit" OnClick="submit_Click"/>
        </p>
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

