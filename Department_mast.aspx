<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Department_mast.aspx.cs" Inherits="Trust_Machine_Test.Department_mast" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Department mast</p>
    <p>
        Department ID&nbsp;
        <asp:TextBox ID="txtDepartmetID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" />
    </p>
    <p>
        Department Name&nbsp;
        <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" Text="Save" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModifiy" runat="server" Text="Modifiy" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    </p>
</asp:Content>
