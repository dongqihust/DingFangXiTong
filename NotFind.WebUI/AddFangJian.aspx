<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFangJian.aspx.cs" Inherits="AddFangJianS" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <h2 class="text-center primary">房间添加</h2>

    <div class="container">
        <form id="form1" runat="server">

            <div class="form-group">
                <label for="Texx_DingFangXiTong">系统名称:</label>
                <asp:DropDownList runat="server" class="form-control " ID="Texx_DingFangXiTong" OnSelectedIndexChanged="BinGuanDataBind" AutoPostBack="true" />
            </div>


            <div class="form-group">
                <label for="Texx_BingGuan">宾馆名称:</label>
                <asp:DropDownList runat="server" class="form-control " ID="Texx_BingGuan" OnSelectedIndexChanged="FangXingDataBind" AutoPostBack="true" />
            </div>
            <div class="form-group">
                <label for="Texx_FangXing">房型名称:</label>
                <asp:DropDownList runat="server" class="form-control " ID="Texx_FangXing" />
            </div>

            <div class="form-group">
                <label for="Texx_FangJianHao">房间号（多个房间号以标点符号或者空格隔开）:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_FangJianHao" />
            </div>

            <div class="form-group">
                <label for="Texx_FangJianBeiZhu">备注:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_FangJianBeiZhu" />
            </div>

            <div class="form-group">
                <label for="Texx_FangJianJiaGe">整间价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_FangJianJiaGe" Text="0.0" />
            </div>


            <div class="form-group">
                <label for="Texx_ChuangWei1JiaGe">床位1价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_ChuangWei1JiaGe" Text="0.0" />
            </div>

            <div class="form-group">
                <label for="Texx_ChuangWei2JiaGe">床位2价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_ChuangWei2JiaGe" Text="0.0" />
            </div>
            <div class="form-group">
                <label for="Texx_ChuangWei3JiaGe">床位3价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_ChuangWei3JiaGe" Text="0.0" />
            </div>
            <div class="form-group">
                <label for="Texx_ChuangWei4JiaGe">床位4价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_ChuangWei4JiaGe" Text="0.0" />
            </div>
            <div class="form-group">
                <label for="Texx_ChuangWei5JiaGe">床位5价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_ChuangWei5JiaGe" Text="0.0" />
            </div>


            <asp:Button ID="Button1" runat="server" type="submit" class="btn btn-default" Text="Submit" OnClick="AddFangJian" />
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx" >回到首页演示</asp:HyperLink>
        </form>
    </div>

</body>
</html>

