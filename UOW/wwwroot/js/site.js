// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $(".ui-accordion").accordion();

    $("#enrolmentTabs").tabs();

    $(".sortable").sortable();

    $("#boxForm").validate({
        rules: {
            boxes: {
                required: true,
                digits: true,
                min: 300,
                max: 500
            }
        },
        submitHandler: function (form) {
            let numberOfBoxes = $("#boxes").val();
            console.log(numberOfBoxes);
            $("#box-wrapper").empty();
            $("#box-wrapper").append('<button id="move" class="btn btn-default">Move boxes</button>');
            //move the box according to their z-index. Higher the z-index, higher the speed
            $("#move").click(function () {
                console.log("clicked");
                $(".box").each(function (index) {
                    loop($(this));
                });
            });
            for (let i = 1; i <= numberOfBoxes; i++) {
                $("#box-wrapper").append(`<div class="box" style="background-color:${getRandomColor()}; z-index:${i};"></div>`);
            }
            $(".box").draggable();
            $("#boxes").val("");
        }
    });
})

function loop(box) {
    box.animate({ left: '1000px' }, 5000 / box.css("z-index"));
    box.animate({ left: '0px' }, 5000 / box.css("z-index"), function () {
        loop(box);
    });
}

function getRandomColor() {
    return "rgb(" + Math.floor(Math.random() * 255) + "," + Math.floor(Math.random() * 255) + ","
        + Math.floor(Math.random() * 255) + ")";
}
