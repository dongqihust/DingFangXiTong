<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EntityBuilder.aspx.cs" ValidateRequest="false"  Inherits="_Temp_var" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Notfind程式生成工具</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        数据表名:<asp:TextBox ID="DB_TableName" runat="server"></asp:TextBox>&nbsp; 模块名称:<asp:TextBox ID="Entity_Title" runat="server"></asp:TextBox><br /><asp:Button ID="Button1" runat="server" Text="生成存储过程" OnClick="Button1_Click" />
        <asp:Button ID="DB_Submit" runat="server" Text="生成实体类" OnClick="DB_Submit_Click" />
        <asp:Button ID="Entity_Data" runat="server" Text="生成数据层" OnClick="Entity_Data_Click" />
        <asp:Button ID="Button2" runat="server" Text="生成业务层" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="生成字段" OnClick="Button21_Click" />
        <asp:Button ID="Button4" runat="server" Text="生成程序" OnClick="DB_Submit5_Click" /><br />
        [注]本程序仅应用于NotFind架构的系统上,如生成存储过程请确保您的第一个字段为SN.<br />
        生成结果为程序自动生成,请在使用前人工检测,以免发生程式错误.
        <br />
        <br />
        <br />
        生成结果<br />
        <asp:TextBox ID="Entity_Result" runat="server" Height="641px" TextMode="MultiLine"
            Width="1133px"></asp:TextBox></div>
    </form>
</body>
</html>
