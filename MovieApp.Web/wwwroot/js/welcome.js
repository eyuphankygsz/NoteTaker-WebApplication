const time = document.querySelector(".welcome-nexttheme-time");

let reloadNewTheme = false;
setInterval(function () {
    const userLocalDate = new Date();

    let today = new Date(userLocalDate.getFullYear(), userLocalDate.getMonth(), userLocalDate.getDate(), 0, 0, 0);
    const userTimezoneOffset = userLocalDate.getTimezoneOffset() * 60 * 1000;

    const today_timezone = new Date(today.getTime() - userTimezoneOffset);
    const currentDate = new Date();

    let diffMilliseconds;


    if (!reloadNewTheme && currentDate.getTime() > today_timezone.getTime() - 1000 && currentDate.getTime() < today_timezone.getTime() + 1000) {
        reloadNewTheme = true;
        setTimeout(function () {
            window.location.reload();
        }, 1100);
    }
    if (currentDate.getTime() < today_timezone.getTime()) {
        diffMilliseconds = today_timezone.getTime() - currentDate.getTime();
    }
    else {
        const tomorrow = new Date(today_timezone);
        tomorrow.setDate(tomorrow.getDate() + 1);
        const utcTomorrow = new Date(tomorrow.getTime());
        diffMilliseconds = utcTomorrow.getTime() - currentDate.getTime();
    }

    let diffSeconds = Math.floor(diffMilliseconds / 1000);
    const diffHours = Math.floor(diffSeconds / 3600);
    diffSeconds %= 3600;
    const diffMinutes = Math.floor(diffSeconds / 60);
    diffSeconds %= 60;

    const formattedSeconds = diffSeconds.toString().padStart(2, '0');
    const formattedMinutes = diffMinutes.toString().padStart(2, '0');
    const formattedHours = diffHours.toString().padStart(2, '0');

    time.textContent = `${formattedHours}:${formattedMinutes}:${formattedSeconds}`;
}, 1000);

let typing = false;
let typeTimeout;

const searchbarDiv = document.querySelector(".searchbar");
const searchbar = searchbarDiv.children[0];
const searchItems = document.querySelector("#search-items");

searchbar.addEventListener('input', () => {
    typing = true;
    clearTimeout(typeTimeout);
    typeTimeout = setTimeout(async () => {
        typing = false;
        await search(searchbar.value);
    }, 500);
});

let isMouseOverItems = false;
searchbar.addEventListener('focus', () => {
    searchItems.style.display = 'block';
});
searchbar.addEventListener('focusout', () => {
    if (!isMouseOverItems)
        searchItems.style.display = 'none';
});



async function search(txt) {
    while (searchItems.firstChild)
        searchItems.removeChild(searchItems.firstChild);

    isLoading = true;
    if (txt.length > 0)
        $.ajax({
            url: '/Search/Text',
            type: 'GET',
            data: { text: txt },
            success: function (data) {
                $('#search-items').append(data);
                isLoading = false;
                const linksInsideSearchItems = searchItems.querySelectorAll('a');
                linksInsideSearchItems.forEach(link => {
                    link.addEventListener('mouseenter', () => {
                        isMouseOverItems = true;
                    });
                    link.addEventListener('mouseleave', () => {
                        isMouseOverItems = false;
                    });
                });
            },
            error: function (xhr, status, errorThrown) {
                console.error("Ajax error:", errorThrown);
                isLoading = false;
            }
        });



}