<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="Trust_Machine_Test.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Transaction
    </p>
    <p>
        Transaction ID
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;</p>
    <p>
        Item ID&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Date&nbsp;&nbsp;
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    </p>
    <p>
        Department ID&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Vendor ID&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Quantity&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
