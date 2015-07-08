    //iframe弹出层
    function tanchuceng(width, height, tit, url) {
        var winWinth = $(window).width(), winHeight = $(document).height();
        $("body").append("<div class='winbj'></div>");
        $("body").append("<div class='tanChu' style='margin-top:36px'><div class='tanChutit'><img src='/skin/TanchuTitle_Left.jpg' style='display:inline; float:left' /><span class='tanchuTxt'>" + tit + "</span><img src='/skin/TanchuTitle_Right.jpg' style='display:inline; float:right' /><span class='tanchuClose'><b>关闭(ESC键)×</b></span></div><iframe class='winIframe' frameborder='0' hspace='0' scrolling='no' src=" + url + "></iframe></div>");
        $(".winbj").css({ width: "100%", height: winHeight, background: "#000", position: "absolute", left: "0", top: "0" });
        $(".winbj").fadeTo(0, 0.7);
        var tanchuLeft = $(window).width() / 2 - width / 2;
        var tanchuTop = $(window).height() / 2 - height / 2 + $(window).scrollTop();
        $(".tanChu").css({ width: width, height: height, left: tanchuLeft, top: tanchuTop, background: "#fff", position: "absolute" });
        $(".tanChutit").css({ width: width, height: "39px", "background-image": "url('/skin/TanchuTitle_BG.jpg')", "line-height": "25px" });
        $(".tanchuTxt").css({ "text-indent": "8px", "float": "left", "font-size": "18px","font-family":"微软雅黑","line-height":"39px","color":"#fff" });
        $(".tanchuClose").css({ "width": "100px", "height": "17px", "float": "right", "cursor": "pointer", "margin-right": "1px", "margin-top": "8px", "color": "#F6F6F6", "font-size": "14px" });
        var winIframeHeight = height - 26;
        $(".winIframe").css({ width: width, height: winIframeHeight, background: "#ffffff" });
        $(".tanchuClose").hover(
function() {
   $(this).css("color", "#E6E6E6");
}, function() {
   $(this).css("color", "#F6F6F6");
}
);
        $(".tanchuClose").click(function() {
            $(".winbj").remove();
            $(".tanChu").remove();
        });

//按ESC关闭弹出层代码
function keyevent(){
		  if(event.keyCode==27){
			$(".winbj").remove();
           	$(".tanChu").remove();
}
      }
      document.onkeydown = keyevent;
    }

    //iframe弹出层end
    //<img width='45px' height='14px' src='/User/images/jhxkc_0311.jpg' style='position: relative; top: 6px;' /> （关闭按钮上如果用图片来当作按钮那么就会出现找不到文本框焦点的问题，如果实用文字当作关闭按钮那么就没有问题）