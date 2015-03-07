$.ready(
    console.log('Ready for action'),
  $("map area").on('click', function (evt) {
      evt.preventDefault();
      evt.stopPropagation();
      updateTerritory($(this).attr('alt'));
  })
);

function updateTerritory(id) {
    console.log('found id ' + id);
    $.get(
            "/Map/SelectTerritory/" + id,
            function (data) {
                $("#territoryDetails").html(data);
            })
};