const links = document.querySelectorAll('.sticky-top  .nav-link');
const links2 = document.querySelectorAll('.fixed-bottom  .nav-item  a');

links.forEach((link) => {
    link.classList.remove('active');
});

links2.forEach((link) => {
    link.classList.remove('active');
})


function sidebarActive(pos) {

    links[pos].classList.add('active');
}
function bottombarActive(pos) {
    links2[pos].classList.add('active');
}

function setLikeInteraction() {
    $('.like-post').off('click');
    $('.like-post').click(function () {
        var postId = $(this).data('post-id');
        var button = $(this);

        $.ajax({
            url: '/Posts/LikePost',
            type: 'POST',
            data: { postId: postId },
            success: function (response) {
                if (response.isSuccess) {
                    button.find('i').toggleClass('liked');
                    button.find('i').toggleClass('unliked');
                }
            },
            error: function () {
                alert('There were some errors. Please try again after few minutes.');
            }
        });
    });
}



function setFollowInteraction() {
    $('.follow-user').off('click');
    $('.follow-user').click(function () {
        var user_name = $(this).data('username');
        var button = $(this);

        $.ajax({
            url: '/User/FriendRequest',
            type: 'POST',
            data: { username: user_name },
            success: function (response) {
                if (response.isSuccess) {
                    if (response.isWaiting) {
                        button.find('i').addClass('fa-envelope');
                        button.find('i').removeClass('fa-plus');
                        button.find('i').removeClass('fa-check');
                    }
                    else if (response.isAccepted) {
                        button.find('i').removeClass('fa-envelope');
                        button.find('i').removeClass('fa-plus');
                        button.find('i').addClass('fa-check');
                    } else {
                        button.find('i').removeClass('fa-envelope');
                        button.find('i').addClass('fa-plus');
                        button.find('i').removeClass('fa-check');
                    }
                }
                else {
                    button.find('i').removeClass('fa-envelope');
                    button.find('i').addClass('fa-plus');
                    button.find('i').removeClass('fa-check');
                }
            },
            error: function () {
                alert('There were some errors. Please try again after few minutes.');
            }
        });
    });
}

