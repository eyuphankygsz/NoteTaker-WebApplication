sidebarActive(4);
bottombarActive(4);

let skip = 0;
let username = "";
let isLoading = false;
const skipCount = 20;
const messageInput = document.querySelector("#text-input");
const messageContainer = document.querySelector(".message-container");
$(document).ready(function () {

    getMessages();
    document.querySelector('#send-text').addEventListener('click', () => sendMessage())
    $(window).scroll(function () {
        if ($(window).scrollTop() == 0 && !isLoading) {
            skip += skipCount;
            getMessages();
        }
    });
});


function getMessages() {
    $('.get-messages').off('click');
    $('.get-messages').click(function () {
        skip = 0;
        username = $(this).data('username');
        loadMoreMessages();
    });
}

function loadMoreMessages() {

    isLoading = true;
    $.ajax({
        url: '/Messages/GetMessages',
        type: 'GET',
        data: { username: username, skip: skip },
        success: function (response) {
            const messageContainer = $('.message-container');
            messageContainer.empty();
            messageContainer.html(response);
            isLoading = false;
        },
        error: function () {
            alert('There were some errors. Please try again after few minutes.');
        }
    });
}

function sendMessage() {

    $.ajax({
        url: '/Messages/SendMessage',
        type: 'GET',
        data: { username: username, message: messageInput.value },
        success: function (response) {
            const messageContainer = $('.message-container');
            messageInput.value = "";
            messageContainer.prepend(response);
            isLoading = false;
        },
        error: function () {
            alert('There were some errors. Please try again after few minutes.');
        }
    });
}