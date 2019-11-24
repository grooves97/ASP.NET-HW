$("#btn").on("click", function () {
    $.ajax({
        type: "Post",
        url: "Create",
        data: { name: $("#name").val(), price: $("#price").val(), description: $("#description").val() }
    });
});