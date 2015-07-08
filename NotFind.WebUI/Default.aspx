<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="/Email/List.aspx" target="_blank">演示查删改增数据</a>

    <br /><br />
    <a href="/Tools/EntityBuilder.aspx" target="_blank">生成三层架构 和 存储过程的工具</a>

    <br /><br />
    实体层类的命名规则：XXXInfo，如：Email_MasterInfo <br />
    业务逻辑层类的命名规则：MyXXX，如：MyEmail_Master <br />
    数据层层类的命名规则：XXXData，如：Email_MasterData <br />

    <br /><br />
    文本框命名规则：Texx_数据库字段中_后面的名字，如：Texx_XingMing <br />
    按钮框命名规则：Butn_XXXX，如：Butn_TiJiao ，Butn_Delete<br />
    全局用到的js都放到了根目录的js文件夹下，如果就一个地方用的就直接在页面上写即可，或者放在某个地方的文件中。<br />

    <br /><br />
    如果有添加图片的地方那么把图片的位置放在网站的根目录Image文件夹下的一个新建的文件夹中，如学校中的校长照片，那么可以在Image文件夹下建立XueXiao_XiaoZhang，然后文件最后存储在/Image/XueXiao_XiaoZhang 中。<br />

    <br /><br />
    数据库表命名，如果是考试科目表：KaoShi_KeMu <br />
    数据库表命名，如果是考试考官表：KaoShi_KaoGuan <br />
    数据库字段命名格式如：K_SN，K_KeMuMing <br />
    所有字段不允许空，都给默认值。<br />

    <br /><br />
    数据库连接字符串在：Web.config 文件中修改 <br />
    NotFind.Business 业务逻辑层，里面的 MethodLibrary.cs 是一些常用方法，里面的My_Sql.cs 是可以传递sql语句去直接执行语句的一些方法。 <br />
    NotFind.Data 数据层，里面的 SqlHelpler.cs 是对数据操作的一些方法<br />
    NotFind.Entity 实体类 <br />
    DataBase 文件夹中存放数据库 和 存储过程文件。 <br />

    </div>
    </form>
</body>
</html>
