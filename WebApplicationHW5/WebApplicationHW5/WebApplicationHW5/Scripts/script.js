$("#button").on("click", function () {
    $.ajax({
        type: "Post",
        async: true,
        url: "Home/ProcessData",
        data: { name: $("#name").val(), text: $("#text").val() },
        success: function (response) {
            $("#tableBody").append("<tr><td>" + response.Name + "</td><td>" + response.Text + "</td></tr>");
            console.log("Was Send");
        }
    });
});