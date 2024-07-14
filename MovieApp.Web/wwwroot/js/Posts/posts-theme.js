sidebarActive(0); bottombarActive(1);

let skip = 0;
const skipCount = 18;
let isLoading = false;


var pathname = window.location.pathname;
var pathParts = pathname.split('/');
var theme = pathParts.filter(Boolean).pop().replace(/-/g, ' ');
console.log(theme);

$(document).ready(function () {

    loadMoreData();
    $(window).scroll(function () {
        console.log(skip);
        if ($(window).scrollTop() + $(window).height() >= $(document).height() && !isLoading) {
            skip += skipCount;
            loadMoreData();
        }
    });
});

function loadMoreData() {
    isLoading = true;
    $.ajax({
        url: '/Posts/LoadMoreData_Theme',
        type: 'GET',
        data: { theme: theme, skip: skip },
        success: function (data) {
            $('#theme-posts-container').append(data);
            isLoading = false;
        },
        error: function () {
            isLoading = false;
        }
    });
}