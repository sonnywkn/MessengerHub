$('#send').click(() => {
    var url = '/ChatRoom/Send';
    var message = $('#message').val();

    $.post(
        url,
        {
            name: 'test',
            message: message
        },
        (response) => {
            console.log(response);
        }
    );
});