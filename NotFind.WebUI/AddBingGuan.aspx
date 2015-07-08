<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBingGuan.aspx.cs" Inherits="BingGuanAdd" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    
</head>
<body>
     <h2 class="text-center primary">房型添加</h2>

    <div class="container">
        <form id="form1" runat="server" >

        <div class="form-group">
            <label for="Texx_DingFangXiTong">系统名称:</label>
            <asp:DropDownList runat="server" class="form-control " ID="Texx_DingFangXiTong" />
        </div>
          

       <div class="form-group">
            <label for="Texx_Name">宾馆名称:</label>
            <asp:TextBox runat="server" class="form-control " ID="Texx_Name" />
        </div>

            <div class="form-group">
            <label for="Texx_Address">宾馆地址:</label>
            <asp:TextBox runat="server" class="form-control " ID="Texx_Address" />
        </div>

            <div class="form-group">
            <label for="Texx_Phone">宾馆电话:</label>
            <asp:TextBox runat="server" class="form-control " ID="Texx_Phone" />
        </div>
      



            <asp:Button ID="Button1" runat="server" type="submit" class="btn btn-default" Text="Submit" OnClick="AddBingGuan"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx" >回到首页演示</asp:HyperLink>
            </form>
    </div>
       
</body>
</html>

