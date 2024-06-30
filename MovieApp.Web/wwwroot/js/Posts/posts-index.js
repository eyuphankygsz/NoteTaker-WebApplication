sidebarActive(0); bottombarActive(1);


const yesterdayPostsParent = document.getElementById("yesterdays-container");
yesterdayPostsParent.querySelector(":scope .carousel-item").classList.add("active");

const checkOutParent = document.getElementById("checkout-container");
checkOutParent.querySelector(":scope .carousel-item").classList.add("active");



let skip = 0;
const take = 18;
let isLoading = false;

$(document).ready(function () {

    loadMoreData();

    $(window).scroll(function () {
        if ($(window).scrollTop() + $(window).height() >= $(document).height() && !isLoading) {
            skip += take;
            loadMoreData();
        }
    });
});

function loadMoreData() {
    isLoading = true;
    $.ajax({
        url: '/Home/LoadMoreData',
        type: 'GET',
        data: { skip: skip, take: take },
        success: function (data) {
            $('#content').append(data);
            isLoading = false;
        },
        error: function () {
            // Hata durumunda isLoading'i false yaparak yeniden istek yapılmasına izin ver
            isLoading = false;
        }
    });
}