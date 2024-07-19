sidebarActive(4);
bottombarActive(4);

let skip = 0;
const skipCount = 20;



$(document).ready(function () {

    getMessage();
    const messageContainer = document.querySelector(".message-container");
    $(window).scroll(function () {
        if ($(window).scrollTop() == 0 && !isLoading) {
            skip += skipCount;
            getMessage();
        }
    });
});


function getMessage() {
    $('.get-messages').off('click');
    $('.get-messages').click(function () {
        var username = $(this).data('username');

        $.ajax({
            url: '/Messages/GetMessages',
            type: 'GET',
            data: { username: username, skip: skip },
            success: function (response) {
                const messageContainer = $(".message-container");
                messageContainer.empty();
                messageContainer.html(response);
            },
            error: function () {
                alert('There were some errors. Please try again after few minutes.');
            }
        });
    });
}

function loadMoreMessage