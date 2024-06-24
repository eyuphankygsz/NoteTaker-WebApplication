const links = document.querySelectorAll(".sticky-top  .nav-link");
const links2 = document.querySelectorAll(".fixed-bottom  .nav-item  a");

links.forEach((link) => {
    link.classList.remove("active");
});

links2.forEach((link) => {
    link.classList.remove("active");
})


function sidebarActive(pos) {

    links[pos].classList.add("active");
}
function bottombarActive(pos) {
    links2[pos].classList.add("active");
}

