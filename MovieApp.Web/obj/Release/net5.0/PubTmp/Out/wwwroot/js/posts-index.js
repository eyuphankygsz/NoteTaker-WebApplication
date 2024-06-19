const links = document.querySelectorAll(".nav-link");

links.forEach((link) => {
    link.classList.remove("active");
});

links[0].classList.add("active");


