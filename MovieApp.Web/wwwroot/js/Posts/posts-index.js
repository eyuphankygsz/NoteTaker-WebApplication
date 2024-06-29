sidebarActive(0); bottombarActive(1);


const yesterdayPostsParent = document.getElementById("yesterdays-container");
yesterdayPostsParent.querySelector(":scope .carousel-item").classList.add("active");

const checkOutParent = document.getElementById("checkout-container");
checkOutParent.querySelector(":scope .carousel-item").classList.add("active");