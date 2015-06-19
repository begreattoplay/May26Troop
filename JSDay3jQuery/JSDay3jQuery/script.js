$('button').click(function (e) {
    $(this).html('I got changed!');
    e.preventDefault();
    $('#message').fadeToggle('slow');
});