async function validation(element) {


    if (element.id == "password1")
        passwordValidation(element, false);
    else if (element.id == "password2")
        passwordValidation(element, true);

    else if (element.id == "mail1")
        await mailValidation(element, false);
    else if (element.id == "mail2")
        await mailValidation(element, true);

    else if (element.classList.contains("username")) {
        await userValidation(element); // await kullanarak çağırıyoruz
    }
}

function isValid(element, valid) {
    if (valid) {
        element.classList.add("is-valid");
        element.classList.remove("is-invalid");
    } else {
        element.classList.add("is-invalid");
        element.classList.remove("is-valid");
    }

    checkAll();
}
const submitButton = document.getElementById("submitButton");
submitButton.disabled = true;
function checkAll() {
    for (let i = 0; i < inputs.length; i++) {
        if (!inputs[i].classList.contains("is-valid")) {
            submitButton.disabled = true;
            return;
        }
    }
    submitButton.disabled = false;


}

function passwordValidation(element, again) {
    if (!again)
        if (element.value.length < 8) isValid(element, false);
        else isValid(element, true);
    else
        if (element.value == document.getElementById("password1").value && (element.value.length >= 8)) isValid(element, true);
        else isValid(element, false);
}

async function mailValidation(element, again) {
    const mail = String(element.value)
        .toLowerCase()
        .match(
            /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
        );

    if (!mail)
        isValid(element, false);
    else
        if (!again)
            try {
                const response = await fetch(`/api/user/validate-mail?mail=${element.value}`);
                const data = await response.json();
                isValid(element, !data.isValid);
            } catch (error) {
                isValid(element, false);
            }
        else
            isValid(element, document.getElementById("mail1").value == element.value);
}

async function userValidation(element) {
    if (element.value.length < 8) {
        isValid(element, false);
    } else {
        try {
            const response = await fetch(`/api/user/validate-username?username=${element.value}`);
            const data = await response.json();
            isValid(element, !data.isValid);
        } catch (error) {
            isValid(element, false);
        }
    }
}

const inputs = document.querySelectorAll(".register-container > div > input");

inputs.forEach((element) => {
    element.addEventListener("focus", async () => { await validation(element); });
    element.addEventListener("focusout", async () => { await validation(element); });
    element.addEventListener("input", async () => { await validation(element); });
});

document.getElementById("nav-signUpButton").classList.add("d-none");