let dbServiceCount = $("dbServiceCount").val()

$("#btnLoadMore").on("click", () => {

    let serviceCount = $("#services").children().length

    $.ajax("/Services/LoadMore", {

        method: "GET",
        data: {
            skip: serviceCount
            take:16
        },
        success: (data) => {
            $("#services").append(data)
            serviceCount = $("#services").children().length
            if (ServiceCount >= dbServiceCount) {
                $("#btnLoadMore").remove()
            }
        }
    })
})

