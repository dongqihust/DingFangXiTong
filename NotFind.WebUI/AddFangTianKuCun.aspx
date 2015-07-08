<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFangTianKuCun.aspx.cs" Inherits="FangTianKuCunAdd" %>

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
                <asp:DropDownList runat="server" class="form-control " ID="Texx_FangXing" OnSelectedIndexChanged="FangJianDataBind" AutoPostBack="true" />
            </div>

            <div class="form-group">
                <label for="Texx_FangJian">房间号（多个房间号以标点符号或者空格隔开）:</label>
                <asp:DropDownList runat="server" class="form-control " ID="Texx_FangJian" />
            </div>


            <div class="form-group">
                <label for="Texx_FangJianJiaGe">整间价格:</label>
                <asp:TextBox runat="server" class="form-control " ID="Texx_FangJianJiaGe" Text="0.0" />
            </div>

            <div class="form-group">
                <label for="Texx_RuZhuStartDate ">最早入住时间（小时）</label>
                <asp:TextBox CssClass="form-control" ID="Texx_RuZhuStartDate" runat="server" MaxLength="50">2014-01-01 12:00</asp:TextBox>
            </div>

            <div class="form-group">
                <label for="Texx_TuiFangEndDate">最早入住时间（小时）</label>
                <asp:TextBox CssClass="form-control" ID="Texx_TuiFangEndDate" runat="server" MaxLength="50">2014-01-01 12:00</asp:TextBox>
            </div>

            <div class="form-group">
                <label for="Texx_BaoLiuZhuangTai">保留状态</label>
                <asp:DropDownList CssClass="form-control" ID="Texx_BaoLiuZhuangTai" runat="server" MaxLength="50">
                    <asp:ListItem Value="0">非保留（默认）</asp:ListItem>
                     <asp:ListItem Value="0">保留，前台不显示</asp:ListItem>
                     <asp:ListItem Value="0">保留，前台显示，但是需要验证码</asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Button ID="Button1" runat="server" type="submit" class="btn btn-default" Text="Submit" OnClick="AddFangJianTianKuCun" />
              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx" >回到首页演示</asp:HyperLink>
        </form>
    </div>

</body>
</html>

