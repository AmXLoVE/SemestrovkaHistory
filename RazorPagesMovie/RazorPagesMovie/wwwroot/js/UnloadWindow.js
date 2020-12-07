window.onunload=function()
{
    $.ajax({
        type: "GET",
        url: "/signup",
        data: {online: 0}
    });
}

