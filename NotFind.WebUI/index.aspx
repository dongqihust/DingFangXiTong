<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h2 class="text-info text-center">演示汇总页</h2>
    
    <div class="container" style="margin-top:80px">
        <div>这是一个演示的首页，具体的数据添加和存库与前台的呈现已经做了,前台的数据控制还没做。</div>
    <form id="form1" runat="server">

       
    <div class="panel">
       <a href="AddDingFangXiTong.aspx" ><h3>增加订房系统</h3></a> 
        <a href="DingFangXiTongList.aspx" ><h3>系统列表</h3></a> 
    </div>

   <div class="panel">
       <a href="AddBingGuan.aspx"><h3>增加宾馆</h3></a> 
         <a href="BingGuanList.aspx"><h3>宾馆列表</h3></a> 
    </div>


    <div class="panel">
       <a href="AddFangXing.aspx"><h3>增加房型</h3></a> 
        <a href="FangJianList.aspx"><h3>房型列表</h3></a> 
    </div>

     <div class="panel">
       <a href="AddFangJian.aspx" ><h3>增加房间</h3></a> 
        <a href="FangJianList.aspx" ><h3>房间列表</h3></a> 
    </div>
       

    <div class="panel" >
       <a href="AddFangTianKuCun.aspx" ><h3>增加一个库存天</h3></a> 
       <a href="KuCunTianList.aspx" ><h3>库存天列表</h3></a> 
            <a href="ChuangWeiKuCunTianList.aspx" ><h3>床位列表</h3></a> 
         <a href="UserDingFang.aspx" ><h3>前台搜索页面</h3></a> 
    </div>



    </form>
        </div>
</body>
</html>
