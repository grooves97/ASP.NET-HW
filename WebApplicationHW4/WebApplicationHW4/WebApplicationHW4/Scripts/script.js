$("#send").on("click", function () {
    var title = $("#title").val();
    var text = $("#text").val();
    var imagePath = $("#path").val();
    var request = { "Title": title, "Text": text, "ImagePath": imagePath };
    $.ajax({
        url: "AddArticle",
        type: "POST",
        dataType: "json",
        data: request,
        success: function (response) {
            console.log(response);
        }
    })
});