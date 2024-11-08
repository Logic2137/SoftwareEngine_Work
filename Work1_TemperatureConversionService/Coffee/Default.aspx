<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Coffee._Default"%>
<!DOCTYPE htmlPUBLIC"-//W3C//DTD XHTML 1.0 Transitional//EN'"http://www.w3.org/TR/xhtmll/DTD/xhtmll-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtm!">
<head id="Headl" runat="server">
<title>Coffee Vendor</title></head>
<body>
<form id="forml" runat="server">
<div>
Welcome to Coffee Vendor, Fach cup of coffee costs 75 cents.<br/>
The machine takes quarters and dollars.<br/>
</div>
<asp:Button ID="btnQuarter" runat="server" Text="Insert a Quarter" Width="117px" OnClick="btnQuarter_Click"/>
<asp:Button ID="BtnDollar" runat="server" Text="Insert a Dollar" Width="114px" OnClick="BtnDollar_Click"/>
<p> The amount you have deposited:
    <asp:Label ID="lblAmount" runat="server" Text="0"></asp:label>
</p >
<asp:Button ID="btnCoffee" runat="server" Text="Buy a Coffee" Width="128px"/>
<asp:Label ID="lblCoffee" runat="server" Text="()"></asp:Label><br />
<asp:Button ID="btnRtn" runat="server" Text="Return Deposit"/>
<asp:Label ID="lblRtn" runat="server" Text="()"></asp:Label><br/></form></body>
</html>