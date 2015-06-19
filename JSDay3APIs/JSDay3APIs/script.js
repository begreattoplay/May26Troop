

$('#submit').click(function () {
    getWeather();
});

function getWeather() {
    var city = $('#city').val();
    var errorDiv = $('#error');

    $.getJSON('http://api.openweathermap.org/data/2.5/find?q=' + city + '&type=like&units=imperial')
    .done(function (data) {
        console.log(data);
        if (data.count > 0) {
            var result = data.list[0];
            var weather = result.weather[0].description;
            var temp = Math.round(result.main.temp);
            var city = result.name;

            $('#result').append('<tr><td>' + city + '</td><td>' + weather + '</td><td>' + temp + '&#8457;</td></tr>')

            if (errorDiv.is(':visible')) {
                errorDiv.toggle();
            }
        }
        else {
            if (!errorDiv.is(':visible')) {
                errorDiv.toggle();
            }
            errorDiv.html('Sorry, unable to find that city.');
        }
        
    })
    .fail(function () {
        $('#error').html('Sorry, unable to find that city.');
    });
}


