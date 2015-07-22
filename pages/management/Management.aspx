<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Management.aspx.cs" Inherits="pages_management_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinkButton ID="addProductLinkButton" runat="server" PostBackUrl="~/pages/management/ManageProduct.aspx">Add New Product</asp:LinkButton>
    <br />
    <br />
    <asp:GridView ID="productGridView" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="productSqlDataSource">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="productSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:FinalConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO [Product] ([Name], [Type], [Description], [Price], [Image], [Quantity]) VALUES (@Name, @Type, @Description, @Price, @Image, @Quantity)" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [Name] = @Name, [Type] = @Type, [Description] = @Description, [Price] = @Price, [Image] = @Image, [Quantity] = @Quantity WHERE [ProductID] = @ProductID">
        <DeleteParameters>
            <asp:Parameter Name="ProductID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Type" Type="Int32" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Quantity" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Type" Type="Int32" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="ProductID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:LinkButton ID="lnkAddProTypeLinkButton" runat="server" PostBackUrl="~/pages/management/ManageProductType.aspx">Add Product Type</asp:LinkButton>
    <br />
    <br />
    <asp:GridView ID="productTypeGridView" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="TypeID" DataSourceID="productTypeSqlDataSource">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="TypeID" HeaderText="TypeID" InsertVisible="False" ReadOnly="True" SortExpression="TypeID" />
            <asp:BoundField DataField="TypeDescreption" HeaderText="TypeDescreption" SortExpression="TypeDescreption" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="productTypeSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:FinalConnectionString %>" DeleteCommand="DELETE FROM [ProductType] WHERE [TypeID] = @TypeID" InsertCommand="INSERT INTO [ProductType] ([TypeDescreption]) VALUES (@TypeDescreption)" SelectCommand="SELECT * FROM [ProductType]" UpdateCommand="UPDATE [ProductType] SET [TypeDescreption] = @TypeDescreption WHERE [TypeID] = @TypeID">
        <DeleteParameters>
            <asp:Parameter Name="TypeID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="TypeDescreption" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="TypeDescreption" Type="String" />
            <asp:Parameter Name="TypeID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

