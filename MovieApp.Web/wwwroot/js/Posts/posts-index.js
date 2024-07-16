sidebarActive(0);
bottombarActive(1);

const yesterdayPostsParent = document.getElementById("yesterdays-container");
yesterdayPostsParent.querySelector(":scope .carousel-item").classList.add("active");

const checkOutParent = document.getElementById("checkout-container");
checkOutParent.querySelector(":scope .carousel-item").classList.add("active");

const theme = document.querySelector('.theme-name').textContent;

let skip = 0;
const skipCount = 18;
let isLoading = false;

$(document).ready(function () {

    loadMoreData();
    $(window).scroll(function () {
        if ($(window).scrollTop() + $(window).height() >= $(document).height() && !isLoading) {
            skip += skipCount;
            loadMoreData();
        }
    });
});

function loadMoreData() {
    isLoading = true;
    $.ajax({
        url: '/Posts/LoadMoreData',
        type: 'GET',
        data: { theme:theme, skip: skip },
        success: function (data) {
            $('#today-posts-container').append(data);
            isLoading = false;
            setLikeInteraction();
            setFollowInteraction();
        },
        error: function () {
            isLoading = false;
        }
    });
}
