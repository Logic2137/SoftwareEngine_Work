<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TemperatureWebClient._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>温度转换服务</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>温度转换</h2>

            <!-- 摄氏温度输入框和转换按钮 -->
            <asp:Label ID="lblCelsius" runat="server" Text="摄氏温度: "></asp:Label>
            <asp:TextBox ID="txtCelsius" runat="server"></asp:TextBox>
            <asp:Button ID="btnC2F" runat="server" Text="C转F" OnClick="btnC2F_Click" />
            <br /><br />

            <!-- 华氏温度输入框和转换按钮 -->
            <asp:Label ID="lblFahrenheit" runat="server" Text="华氏温度: "></asp:Label>
            <asp:TextBox ID="txtFahrenheit" runat="server"></asp:TextBox>
            <asp:Button ID="btnF2C" runat="server" Text="F转C" OnClick="btnF2C_Click" />
            <br /><br />

            <!-- 显示转换结果的标签 -->
            <asp:Label ID="lblResult" runat="server" Text="转换结果:"></asp:Label>
        </div>
    </form>
</body>
</html>
