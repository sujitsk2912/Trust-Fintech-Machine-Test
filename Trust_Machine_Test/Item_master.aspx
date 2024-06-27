<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item_master.aspx.cs" Inherits="Trust_Machine_Test.Item_master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Item Master</p>
    <p>
        Item ID&nbsp; <asp:TextBox ID="txtItemID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" />
    </p>
    <p>
        Item Name&nbsp;
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
    </p>
    <p>
        Category&nbsp;
        <asp:DropDownList ID="txtDropDownCategory" runat="server">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Electronic</asp:ListItem>
            <asp:ListItem>Furniture</asp:ListItem>
            <asp:ListItem>Stationary</asp:ListItem>
            <asp:ListItem>Consumbal</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Rate&nbsp;
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
    </p>
    <p>
        Balance Quantity&nbsp;
        <asp:TextBox ID="txtBalQuantity" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" Text="Save" />
&nbsp;&nbsp;
        <asp:Button ID="btnModifiy" runat="server" Text="Modifiy" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    </p>
</asp:Content>
