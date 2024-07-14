// DOM yüklendiğinde yapılacaklar
document.addEventListener('DOMContentLoaded', function () {

    sidebarActive(2); bottombarActive(2);
    const titleMax = document.querySelector('#titleMax');
    const titleInput = document.querySelector('#titleInput');
    titleInput.addEventListener("input", () => limitCharacter(30, titleInput, titleMax));

    const contentMax = document.querySelector('#contentMax');
    const contentInput = document.querySelector('#contentInput');
    contentInput.addEventListener("input", () => limitCharacter(250, contentInput, contentMax));


    const createButtonSpan = document.querySelector('#createButton-span');
    let popover = PopoverCreate();


    let createPopOver = document.querySelector(".createpopover");
    const waitPopover = setInterval(() => {

        const errors = [];
        const title = GetError(5, 30, titleInput);
        const content = GetError(30, 250, contentInput);

        if (title)
            errors.push("Title: " + title);
        if (content)
            errors.push("Content: " + content);
        if (errors.length == 0) {
            if (popover)
                popover.dispose();
            popover = null;
            createButtonSpan.children[0].disabled = false;
        }
        else {
            createButtonSpan.children[0].disabled = true;
            if (!popover) popover = PopoverCreate();
        }

        createPopOver = document.querySelector(".createpopover");
        if (!createPopOver) return;

        while (createPopOver.children[2].firstChild)
            createPopOver.children[2].removeChild(createPopOver.children[2].firstChild);

        errors.forEach(error => {
            const newError = document.createElement('p');
            newError.textContent = error;
            createPopOver.children[2].appendChild(newError);
        });
    }, 100);

    function limitCharacter(limit, input, max) {
        if (input.value.length > limit)
            input.value = input.value.slice(0, limit);
        max.textContent = input.value.length + '/' + limit;
    }
    function PopoverCreate() {
        return new bootstrap.Popover(createButtonSpan, {
            container: 'body', // Popover'ın nerede oluşturulacağını belirtin
            boundary: 'viewport', // Popover'ın sınırlarını belirleyin
            customClass: 'custom-popover createpopover', // Özel sınıfı belirtin
            title: 'Requirements', // Popover başlığı
            content: ' ', // Başlangıçta boş içerik
            trigger: 'hover', // Tetikleyici olaylar
            placement: 'right' // Yerleştirme yönü
        });
    }
    function GetError(minLimit, maxLimit, input) {
        if (input.value.length > maxLimit || input.value.length < minLimit)
            return "must be between " + minLimit + " to " + maxLimit + " characters!";
        return ""; // Hata yoksa boş string döndür
    }
});