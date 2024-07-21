sidebarActive(4);
bottombarActive(4);

let skip = 0;
let username = "";
let isLoading = false;
const skipCount = 20;
const messageInput = document.querySelector("#text-input");
const messageContainer = $('.message-container');
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
            messageContainer.empty();
            messageContainer.html(response);
            isLoading = false;
        },
        error: function () {
            alert('There were some errors. Please try again after few minutes.');
        }
    });
}


const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();
connection.start().then(function () {
    console.log("SignalR connected.");
}).catch(function (err) {
    return console.error(err.toString());
});
connection.on("ReceiveMessage", function (fromUser) {

    if (username != fromUser)
        return;
    else
        $.ajax({
            url: '/Messages/GetLastMessage',
            type: 'GET',
            data: { username: fromUser },
            success: function (response) {
                messageContainer.prepend(response);
                isLoading = false;
            },
            error: function () {
                alert('There were some errors. Please try again after few minutes.');
            }
        });
});

function sendMessage() {

    $.ajax({
        url: '/Messages/SendMessage',
        type: 'GET',
        data: { username: username, message: messageInput.value },
        success: function (response) {
            console.log(response);
            messageInput.value = "";
            messageContainer.prepend(response);
            isLoading = false;
        },
        error: function () {
            alert('There were some errors. Please try again after few minutes.');
        }
    });
}

