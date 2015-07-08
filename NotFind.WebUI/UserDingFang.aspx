<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDingFang.aspx.cs" Inherits="UserDingFang" %>

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
    <script type="text/javascript" src="/calendar/xin/WdatePicker.js"></script>
    <script src="/js/firefox.js" type="text/javascript"></script>
    <link href="skin/hbjwxt_css.css" rel="stylesheet" />
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
        function Chex_choice_onclick2(flag) {
            var inputs = document.all.Griw_List2.getElementsByTagName("input");
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

    <h2 class="text-center">前台搜索页面</h2>
    <div class="container">


        <div class="divider"></div>


        <form runat="server">


            <div class="navbar-form navbar-left" role="search">

                <div class="form-group">
                    <label for="Texx_Style">类别:</label>
                    <asp:DropDownList runat="server" class="form-control " ID="Texx_Style">
                        <asp:ListItem Value="0">查房间</asp:ListItem>
                        <asp:ListItem Value="1">查床位</asp:ListItem>
                    </asp:DropDownList>
                </div>

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
                    <label for="Texx_RuZhuStartDate">入住:</label>
                    <asp:TextBox runat="server" class="form-control " ID="Texx_RuZhuStartDate" onclick="WdatePicker('yyyy-MM-dd')" />
                </div>


                <div class="form-group">
                    <label for="Texx_TuiFangEndDate">离开:</label>
                    <asp:TextBox runat="server" class="form-control " ID="Texx_TuiFangEndDate" onclick="WdatePicker('yyyy-MM-dd')" />
                </div>



                <asp:Button runat="server" class="btn btn-default" Text="搜索" OnClick="Search_Click"></asp:Button>
            </div>



            <div class="panel panel-default" runat="server" ID="Panel1">
                <div class="row panel-body">
                    <asp:GridView ID="Griw_List1" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="table table-bordered table-hover">

                        <Columns>
                            <asp:TemplateField>

                                <ItemTemplate>
                                    <asp:CheckBox ID="Chex_Selete" runat="server" />
                                    <asp:Label ID="Labl_CSN" runat="server" Text='<%# Eval("F_SN") %>' Visible="False"></asp:Label>

                                </ItemTemplate>

                                <HeaderTemplate>
                                     <input id="Chex_choice" type="checkbox"" onclick="return Chex_choice_onclick()" />
                                </HeaderTemplate>

                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("D_Name")%>
                                </ItemTemplate>
                                <HeaderTemplate>订房系统名称</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("B_Name")%>
                                </ItemTemplate>
                                <HeaderTemplate>宾馆名称</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_Name")%>
                                </ItemTemplate>
                                <HeaderTemplate>房型</HeaderTemplate>
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
                                <HeaderTemplate>整间价格</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_RuZhuStartDate").ToString().Replace("/","-")%>
                                </ItemTemplate>
                                <HeaderTemplate>最早住时间</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_TuiFangEndDate").ToString().Replace("/","-")%>
                                </ItemTemplate>
                                <HeaderTemplate>最晚退房时间</HeaderTemplate>
                            </asp:TemplateField>

                        </Columns>

                        <EmptyDataTemplate>
                            <p class="text-info text-center ">没有搜索到符合要求的数据</p>
                        </EmptyDataTemplate>
                    </asp:GridView>
                </div>
                <div class="Items_Page" style="padding-left: 0;" runat="server" id="PageDiv1">
                    <asp:Label ID="Lab_PageString1" runat="server"></asp:Label>
                </div>
            </div>

            <div class="panel panel-default" runat="server" id="Panel2">
                <div class="row panel-body">
                    <asp:GridView ID="Griw_List2" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="table table-bordered table-hover">

                        <Columns>
                            <asp:TemplateField>

                                <ItemTemplate>
                                    <asp:CheckBox ID="Chex_Selete" runat="server" />
                                    <asp:Label ID="Labl_CSN" runat="server" Text='<%# Eval("C_SN") %>' Visible="False"></asp:Label>

                                </ItemTemplate>

                                <HeaderTemplate>
                                    <input id="Chex_choice" type="checkbox" onclick="return Chex_choice_onclick2()" />
                                </HeaderTemplate>

                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("D_Name")%>
                                </ItemTemplate>
                                <HeaderTemplate>订房系统名称</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("B_Name")%>
                                </ItemTemplate>
                                <HeaderTemplate>宾馆名称</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_Name")%>
                                </ItemTemplate>
                                <HeaderTemplate>房型</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("F_FangJianHao")%>
                                </ItemTemplate>
                                <HeaderTemplate>房间号</HeaderTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("C_ChuangWeiHao")%>
                                </ItemTemplate>
                                <HeaderTemplate>床位号</HeaderTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("C_ChuangWei1JiaGe")%>
                                </ItemTemplate>
                                <HeaderTemplate>床位价格</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("C_RuZhuStartDate").ToString().Replace("/","-")%>
                                </ItemTemplate>
                                <HeaderTemplate>最早住时间</HeaderTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <%#Eval("C_TuiFangEndDate").ToString().Replace("/","-")%>
                                </ItemTemplate>
                                <HeaderTemplate>最晚退房时间</HeaderTemplate>
                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>

                </div>
                <div class="Items_Page" style="padding-left: 0;" ID="PageDiv2"  runat ="server">
                    <asp:Label ID="Lab_PageString2" runat="server"></asp:Label>
                </div>
            </div>



        </form>

    </div>


</body>
</html>
