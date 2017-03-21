$(function() {
    $("#addRow").bind("click", function() {
        var liCount = $("#row li").length;
        var html = "<li>第" + (liCount + 1) + "行</li>";
        $("#row").append(html);
    });
    //自定义事件
    $(".user-defined").bind("frob.widget", function(event, dataNumber) {
        console.log(dataNumber);
        return true;
    });
    //委托绑定事件
    $("#row").delegate("li", "click", function() {
        var result = $._data($(this)[0], "events"); //获取当前对象私有事件
        if (result != undefined && result.frob != undefined && result.frob[0].namespace == "widget")
            $(this).trigger("frob.widget", $(this).index() + 1);
        else
            console.log("点击了" + $(this).text());
    });
});