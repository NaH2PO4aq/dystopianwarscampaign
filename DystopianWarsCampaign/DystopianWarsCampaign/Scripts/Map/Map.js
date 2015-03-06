$.ready(
    console.log("Script succesfully initialized")
    );
$("map area").on('click', function (evt) {
    //alert($(this).attr('alt'));
    evt.preventDefault();
    evt.stopPropagation();
    $.get(
        "/Map/SelectTerritory/" + $(this).attr('alt'),
        function (data) { $("territoryDetails").replaceWith(data); console.log("Succes!"); });
    //$.ajax({
    //    url: "/Map/SelectTerritory/" + $(this).attr('alt'),

    //    complete: function () {
    //        console.log("Send ajax request...")
    //    },
    //    success: function (result) {
    //        console.log(result)
    //    }
    //})
});