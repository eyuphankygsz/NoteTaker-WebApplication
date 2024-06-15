

function validation(element) {
    if (element.classList.contains("password"))
        passwordValidation(element);
    else if (element.classList.contains("mail"))
        mailValidation(element);
    else if (element.classList.contains("username"))
        userValidation(element);
}

function isValid(element, valid) {

    if (valid) {
        element.classList.add("is-valid");
        element.classList.remove("is-invalid");
    }
    else {
        element.classList.add("is-invalid");
        element.classList.remove("is-valid");
    }
}
function passwordValidation(element) {
    if (element.value.length < 8) isValid(element, false);
    else isValid(element, true);
} function mailValidation(element) {
    const mail = String(element.value)
        .toLowerCase()
        .match(
            /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    );

    isValid(element, mail);
} function userValidation(element) {
    if (element.value.length < 8) isValid(element, false);
    else isValid(element, true);
}

const inputs = document.querySelectorAll(".register-container > div > input");

console.log(inputs);
inputs.forEach((element) => {
    element.addEventListener("focus", () => { validation(element); });
    element.addEventListener("focusout", () => { validation(element); });
    element.addEventListener("input", () => { validation(element); });
});