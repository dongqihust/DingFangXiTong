<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddDingFangXiTong.aspx.cs" Inherits="AddXiTong" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    
</head>
<body>
     <h2 class="text-center primary">订房系统的添加</h2>

    <div class="container">
        <form id="form1" runat="server" >
       <div class="form-group">
            <label for="Texx_DingFangXiTongName">系统名称:</label>
            <asp:TextBox runat="server" class="form-control " ID="Texx_DingFangXiTongName" />
        </div>
         <div class="form-group">
            <label for="Texx_BuMenSN">部门SN:</label>
            <asp:TextBox runat="server" class="form-control " ID="Texx_BuMenSN" />
        </div>
         <div class="form-group">
            <label for="Texx_BanJiSNs">班级SNs:</label>
            <asp:TextBox runat="server" class="form-control " ID="Texx_BanJiSNs" />
        </div>
   
            <asp:Button ID="Button1" runat="server" type="submit" class="btn btn-default" Text="Submit" OnClick="AddDingFangXiTong"/>
            <asp:HyperLink runat="server" NavigateUrl="~/index.aspx" >回到首页演示</asp:HyperLink>
            </form>
    </div>
       
</body>
</html>

