<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProduct.aspx.cs" Inherits="pages_management_ManageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Type:</p>
    <p>
        <asp:DropDownList ID="typeDropDownList" runat="server" DataSourceID="sdsType" DataTextField="TypeID" DataValueField="TypeID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="sdsType" runat="server" ConnectionString="<%$ ConnectionStrings:FinalConnectionString %>" SelectCommand="SELECT * FROM [ProductType]"></asp:SqlDataSource>
    </p>
    <p>
        Description:</p>
    <p>
        <asp:TextBox ID="descriptionTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        Price:</p>
    <p>
        <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Quantity:</p>
    <p>
        <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Image:</p>
    <p>
        <asp:DropDownList ID="imageDropDownList" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
    </p>
    <p>
        <asp:Label ID="productMessageLabel" runat="server"></asp:Label>
    </p>
</asp:Content>

