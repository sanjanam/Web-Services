<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Stemming._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Enter string"></asp:Label>

<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>

<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="shoot" />

<asp:Label ID="Label2" runat="server" Text="Stemmed Words"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

</asp:Content>
