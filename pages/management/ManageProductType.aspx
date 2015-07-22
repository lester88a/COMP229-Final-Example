<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProductType.aspx.cs" Inherits="pages_management_ManageProductType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        Product Type Description:<br />
<asp:TextBox ID="TextBoxProductDesc" runat="server"></asp:TextBox>
<br />
<asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" style="height: 26px" Text="Submit" />
<br />
<asp:Label ID="resultLabel" runat="server"></asp:Label>
</asp:Content>

