const links = document.querySelectorAll(".sticky-top  .nav-link");
const links2 = document.querySelectorAll(".fixed-bottom  .nav-item  a");

links.forEach((link) => {
    link.classList.remove("active");
});

links2.forEach((link) => {
    link.classList.remove("active");
})

console.log(links);
console.log(links2);
links[1].classList.add("active");
links2[0].classList.add("active");


