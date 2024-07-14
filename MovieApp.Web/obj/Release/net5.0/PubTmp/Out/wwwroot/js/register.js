async function validation(element) {
    if (element.id === "password1")
        passwordValidation(element, false);
    else if (element.id === "password2")
        passwordValidation(element, true);
    else if (element.id === "mail1")
        await mailValidation(element, false);
    else if (element.id === "mail2")
        await mailValidation(element, true);
    else if (element.classList.contains("username"))
        await userValidation(element); // await kullanarak çağırıyoruz
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
    let allValid = true;
    inputs.forEach(input => {
        if (!input.classList.contains("is-valid")) {
            allValid = false;
        }
    });
    submitButton.disabled = !allValid;
}

function passwordValidation(element, again) {
    if (!again) {
        if (element.value.length < 8)
            isValid(element, false);
        else
            isValid(element, true);
    } else {
        if (element.value === document.getElementById("password1").value && element.value.length >= 8)
            isValid(element, true);
        else
            isValid(element, false);
    }
}

async function mailValidation(element, again) {
    const mailRegex = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    const isValidMail = mailRegex.test(String(element.value).toLowerCase());

    if (!isValidMail) {
        isValid(element, false);
    } else {
        if (!again) {
            try {
                const response = await $.ajax({
                    url: '/User/UserMailValidation',
                    type: 'POST',
                    dataType: 'json',
                    data: { mail: element.value }
                });

                if (response.isValid) {
                    isValid(element, true);
                } else {
                    isValid(element, false);
                }
            } catch (error) {
                console.error('Mail validation error:', error);
                isValid(element, false);
            }
        } else {
            isValid(element, document.getElementById("mail1").value === element.value);
        }
    }
}

async function userValidation(element) {
    if (element.value.length < 8) {
        isValid(element, false);
    } else {
        try {
            const response = await $.ajax({
                url: '/User/UsernameValidation',
                type: 'POST',
                dataType: 'json',
                data: { username: element.value }
            });
            if (response.isValid) {
                isValid(element, true);
            } else {
                isValid(element, false);
            }
        } catch (error) {
            console.error('Username validation error:', error);
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

