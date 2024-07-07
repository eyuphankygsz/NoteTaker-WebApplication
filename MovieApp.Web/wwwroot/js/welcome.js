const time = document.querySelector(".welcome-nexttheme-time");

setInterval(function () {
    const userLocalDate = new Date();

    let today = new Date(userLocalDate.getFullYear(), userLocalDate.getMonth(), userLocalDate.getDate(), 0, 0, 0);
    const userTimezoneOffset = userLocalDate.getTimezoneOffset() * 60 * 1000;

    const today_timezone = new Date(today.getTime() - userTimezoneOffset);
    const currentDate = new Date();

    let diffMilliseconds;
    if (currentDate.getTime() < today_timezone.getTime()) {
        diffMilliseconds = today_timezone.getTime() - currentDate.getTime();
    } else {
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
