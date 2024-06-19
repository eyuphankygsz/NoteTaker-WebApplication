"use strict";
/*
const step1 = document.querySelector(".steps").children[0].children[0];
const step2 = document.querySelector(".steps").children[1].children[0];
const step3 = document.querySelector(".steps").children[2].children[0];

console.log(step1);
console.log(step2);
console.log(step3);

step1.addEventListener("click", () => {
    changeStepBackground("#7E30E1");
});

step2.addEventListener("click", () => {
    changeStepBackground("#864AF9");
});

step3.addEventListener("click", () => {
    changeStepBackground("#711DB0");
});

function changeStepBackground(color) {
    document.querySelector(".step-container-color").style.setProperty("background-color", color, "important");
}

*/
const choiceArray = document.querySelectorAll(".choice")

choiceArray.forEach((card) => {
    card.addEventListener("click", () => {
        choiceArray.forEach((element) => {
            element.classList.remove("expand")
            element.classList.add('small')
        })
        card.classList.remove("small")
        card.classList.add('expand')
    });
});
