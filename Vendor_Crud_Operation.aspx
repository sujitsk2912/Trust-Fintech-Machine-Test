<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendor_Crud_Operation.aspx.cs" Inherits="Trust_Machine_Test.Vendor_Crud_Operation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Vendor Master</p>
    <p>
        Vendor ID&nbsp;&nbsp;
        <asp:TextBox ID="txtVendorID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Vendor Name&nbsp;
        <asp:TextBox ID="txtVendorName" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModify" runat="server" OnClick="Button2_Click" Text="Modify" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
