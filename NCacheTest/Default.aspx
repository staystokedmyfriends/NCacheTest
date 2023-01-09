<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="NCacheTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Button runat="server" ID="btnCacheWithOutEnum" Text="Cache Datatable Without Enum" OnClick="btnCacheWithOutEnum_Click" />
        <asp:Button runat="server" ID="btnCacheWithEnum" Text="Cache Datatable With Enum" OnClick="btnCacheWithEnum_Click" />
    </div>
    
    <div>
        <asp:TextBox runat="server" ID="txtLog" TextMode="MultiLine" Columns="100" Rows="15" ></asp:TextBox>
    </div>

</asp:Content>
