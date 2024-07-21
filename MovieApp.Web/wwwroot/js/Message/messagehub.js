let currentPath = "";
document.addEventListener("DOMContentLoaded", function () {
    currentPath = window.location.pathname;

    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/chatHub")
        .build();
    connection.start().then(function () {
        console.log("SignalR connected.");
    }).catch(function (err) {
        return console.error(err.toString());
    });

    connection.on("ReceiveMessage", function (fromUser) {
        if (currentPath.includes("Inbox"))
            getLastMessage(fromUser);

        addNotification();
    });

    function addNotification() {
        const span = $('#side-likes span');
        let spanString = 1;
        if (span.text().length != 0) {
            spanString = parseInt(span.text());
            if (isNaN(spanString)) {
                spanString = 1; // Eğer metin sayı değilse varsayılan değeri 1 olarak ayarla
            }
            spanString++;
        }

        span.text(spanString);

    }

});

