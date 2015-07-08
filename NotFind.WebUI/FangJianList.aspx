<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FangJianList.aspx.cs" Inherits="FangJianList" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" src="js/area.js"></script>
    <!-- 新 Bootstrap 核心 CSS 文件 -->
 <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/header.css" rel="stylesheet" />
    <script src="/js/firefox.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Chex_choice_onclick(flag) {
            var inputs = document.all.Griw_List.getElementsByTagName("input");
            for (var i = 0; i < inputs.length; i++)
                if (inputs[i].type == 'checkbox') {
                    if (flag)
                        inputs[i].checked = true;
                    else
                        inputs[i].checked = !inputs[i].checked;
                }
        }

    </script>

</head>
<body>

    <h2 class="text-center">房间列表</h2>
    <div class="container">
        
        <form id="Form1" runat="server">
              <div class="panel panel-default">
                <div class="row panel-body">
                    <asp:GridView ID="Griw_List" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="table table-bordered table-hover">

                        <Columns>
                            <asp:TemplateField>

                                <ItemTemplate>
                                    <asp:CheckBox ID="Chex_Selete" runat="server" />
                                    <asp:Label ID="Labl_CSN" runat="server" Text='<%# Eval("F_SN") %>' Visible="False"></asp:Label>

                                </ItemTemplate>

                                <HeaderTemplate>
                                    <input id="Chex_choice" type="checkbox" onclick="return Chex_choice_onclick()" />
                                </HeaderTemplate>

                            </asp:TemplateField>

                         
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_SuoShuFangXingSN")%>
                                </ItemTemplate>
                                <HeaderTemplate>所属房型</HeaderTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_FangJianHao")%>
                                </ItemTemplate>
                                <HeaderTemplate>房间号</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_ZhengJianJiaGe")%>
                                </ItemTemplate>
                                <HeaderTemplate>整件间价格</HeaderTemplate>
                            </asp:TemplateField>



                        </Columns>
                    </asp:GridView>
                </div>
               
                   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx" >回到首页演示</asp:HyperLink>   
            </div>

        </form>
     

    </div>


</body>
</html>
